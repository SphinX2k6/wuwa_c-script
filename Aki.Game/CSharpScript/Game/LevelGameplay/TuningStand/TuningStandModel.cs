using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.TuningStand.Bubble;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x020069CB RID: 27083
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TuningStandModel : ModelBase
	{
		// Token: 0x0604360F RID: 275983 RVA: 0x010764A8 File Offset: 0x010746A8
		public void LoadData(ITuningStand config)
		{
			this.Config = config;
			this.ResetTimes = 0;
			this.InitGridData();
			this.InitTalkBubble();
			global::Log.Instance.Info(ELogModule.LevelPlay, ELogAuthor.WHJ, "调律台资源开始加载", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x06043610 RID: 275984 RVA: 0x010764EB File Offset: 0x010746EB
		public bool GetIsPressing()
		{
			return this.IsPressing;
		}

		// Token: 0x06043611 RID: 275985 RVA: 0x010764F3 File Offset: 0x010746F3
		public int? GetCurIndex()
		{
			return this.CurIndex;
		}

		// Token: 0x06043612 RID: 275986 RVA: 0x010764FB File Offset: 0x010746FB
		public List<TuningGridData> GetGridList()
		{
			return this.GridData;
		}

		// Token: 0x06043613 RID: 275987 RVA: 0x01076504 File Offset: 0x01074704
		protected EGridCheckState CheckOpValidState(TuningGridData from, TuningGridData to)
		{
			ITuningStateData curGridState = from.GetCurGridState();
			if (curGridState.State == EGridBelongType.Empty)
			{
				return EGridCheckState.Invalid;
			}
			if (to.GridType == ETuningStandGridType.Empty)
			{
				return EGridCheckState.EmptyGrid;
			}
			ITuningStateData curGridState2 = to.GetCurGridState();
			int[] gridLoc = from.GridLoc;
			int[] gridLoc2 = to.GridLoc;
			if (curGridState.State == curGridState2.State)
			{
				return EGridCheckState.SameTuneCut;
			}
			if (Math.Abs(gridLoc[0] - gridLoc2[0]) + Math.Abs(gridLoc[1] - gridLoc2[1]) > 1)
			{
				return EGridCheckState.EmptyGrid;
			}
			if (to.GridMainType == EGridMainType.Start)
			{
				return EGridCheckState.Invalid;
			}
			if (to.GridMainType == EGridMainType.End && !this.CheckEndValid(from, to))
			{
				return EGridCheckState.Invalid;
			}
			if (from.GridValue > to.GridValue)
			{
				return EGridCheckState.Invalid;
			}
			if (curGridState2.State != EGridBelongType.Empty)
			{
				return EGridCheckState.DiffTuneCut;
			}
			return EGridCheckState.Valid;
		}

		// Token: 0x06043614 RID: 275988 RVA: 0x010765AC File Offset: 0x010747AC
		protected bool CheckEndValid(TuningGridData from, TuningGridData to)
		{
			ITuningStateData curGridState = from.GetCurGridState();
			if (to.GridType == ETuningStandGridType.End1)
			{
				return curGridState.State == EGridBelongType.Type1;
			}
			return curGridState.State == EGridBelongType.Type2;
		}

		// Token: 0x06043615 RID: 275989 RVA: 0x010765DC File Offset: 0x010747DC
		protected void InitGridData()
		{
			this.GridData.Clear();
			this.CurIndex = null;
			this.CurNodeIndex = 0;
			this.CreateEventList();
			for (int i = 0; i < this.Config.BoardConfig.Grids.Count; i++)
			{
				TuningGridData tuningGridData = new TuningGridData();
				tuningGridData.Index = i;
				tuningGridData.GridType = this.Config.BoardConfig.Grids[i];
				if (tuningGridData.GridType == ETuningStandGridType.Start1)
				{
					tuningGridData.StaticState.State = EGridBelongType.Type1;
				}
				else if (tuningGridData.GridType == ETuningStandGridType.Start2)
				{
					tuningGridData.StaticState.State = EGridBelongType.Type2;
				}
				tuningGridData.GridValue = TuningStandDefine.gridValueMap[tuningGridData.GridType];
				tuningGridData.GridMainType = TuningStandDefine.gridMainTypeMap[tuningGridData.GridType];
				this.GridData.Add(tuningGridData);
			}
		}

		// Token: 0x06043616 RID: 275990 RVA: 0x010766C0 File Offset: 0x010748C0
		public void ResetGrid()
		{
			if (Time.Instance.Now - 3.0 < this.PrevResetTime)
			{
				return;
			}
			this.TryStartBubbleFlow(ETuningStandBubbleTriggerType.Reset);
			this.PrevResetTime = Time.Instance.Now;
			this.ResetTimes++;
			if (this.ResetTimes == 3)
			{
				this.ProcessTooLong();
			}
			this.InitGridData();
		}

		// Token: 0x06043617 RID: 275991 RVA: 0x01076728 File Offset: 0x01074928
		public void UnloadData()
		{
			this.Config = null;
			this.ResetTimes = 0;
			this.PrevResetTime = 0.0;
			this.DestroyBubble();
			this.GridData.Clear();
			this.CurIndex = null;
			this.CurNodeIndex = 0;
			this.EventList.Clear();
		}

		// Token: 0x06043618 RID: 275992 RVA: 0x01076781 File Offset: 0x01074981
		public void InitData(bool isPress)
		{
			this.IsPressing = isPress;
			this.CurIndex = null;
		}

		// Token: 0x06043619 RID: 275993 RVA: 0x01076798 File Offset: 0x01074998
		public void OnPress(TuningGridData data)
		{
			EGridMainType gridMainType = data.GridMainType;
			if (gridMainType == EGridMainType.End || gridMainType == EGridMainType.Empty)
			{
				return;
			}
			if (data.StaticState.State == EGridBelongType.Empty)
			{
				return;
			}
			EventSystem.Instance.Emit<bool>(EEventName.TuningStandOnLinkMiss, false);
			this.InitData(true);
			int index = data.Index;
			this.CurIndex = new int?(index);
			this.TryStartBubbleFlow(ETuningStandBubbleTriggerType.StartLink);
			if (this.ClearAllNextPathStatic(index))
			{
				this.PlayAkEvent(false);
				return;
			}
			this.PlayStartEvent();
		}

		// Token: 0x0604361A RID: 275994 RVA: 0x0107680C File Offset: 0x01074A0C
		public void OnRelease(TuningGridData data)
		{
			bool flag = this.Config.VisualType == ETuningStandVisualType.Tuning;
			int? curIndex = this.CurIndex;
			this.InitData(false);
			this.SaveDynamicGrid();
			EventSystem.Instance.Emit<int?>(EEventName.TuningStandUpdate, null);
			if (this.CheckAllClear())
			{
				EventSystem.Instance.Emit(EEventName.TuningStandSuccess);
				this.StartRevolving();
				return;
			}
			if (curIndex != null)
			{
				int[] array = this.CheckEndCount();
				if (this.GridData[curIndex.Value].GridMainType == EGridMainType.End && flag)
				{
					if (array[0] == array[1])
					{
						EventSystem.Instance.Emit<bool>(EEventName.TuningStandOnLinkMiss, true);
						AudioSystem.Instance.PostEvent("play_ui_tiaolvtai_attention2");
					}
					if (array[0] == 1 && array[1] != 1)
					{
						this.TryStartBubbleFlow(ETuningStandBubbleTriggerType.LinkUp);
						return;
					}
					if (array[0] == array[1])
					{
						this.TryStartBubbleFlow(ETuningStandBubbleTriggerType.LinkMiss);
					}
				}
			}
		}

		// Token: 0x0604361B RID: 275995 RVA: 0x010768F0 File Offset: 0x01074AF0
		public EGridCheckReturnState OnHover(TuningGridData data)
		{
			if (!this.IsPressing)
			{
				return EGridCheckReturnState.Empty;
			}
			TuningGridData tuningGridData = this.GridData[this.CurIndex.Value];
			EGridCheckState egridCheckState = this.CheckOpValidState(tuningGridData, data);
			if (egridCheckState == EGridCheckState.EmptyGrid)
			{
				return EGridCheckReturnState.Empty;
			}
			if (egridCheckState == EGridCheckState.Invalid)
			{
				AudioSystem.Instance.PostEvent("play_ui_tiaolvtai_attention3");
				return EGridCheckReturnState.Error;
			}
			if (egridCheckState == EGridCheckState.DiffTuneCut)
			{
				this.ClearAllNextPathDynamic(data.Index);
			}
			else if (egridCheckState == EGridCheckState.SameTuneCut)
			{
				int? curIndex = this.CurIndex;
				int index = data.Index;
				if (!(curIndex.GetValueOrDefault() == index & curIndex != null))
				{
					this.PlayAkEvent(false);
				}
				if (!this.ClearAllNextPathDynamic(data.Index))
				{
					tuningGridData.GetCurGridState().Next = null;
				}
				this.CurIndex = new int?(data.Index);
				return EGridCheckReturnState.Valid;
			}
			data.IsStatic = false;
			tuningGridData.GetCurGridState().Next = new int?(data.Index);
			data.DynamicState.State = tuningGridData.GetCurGridState().State;
			data.DynamicState.Prev = this.CurIndex;
			data.DynamicState.Next = null;
			this.CurIndex = new int?(data.Index);
			this.PlayAkEvent(true);
			return EGridCheckReturnState.Valid;
		}

		// Token: 0x0604361C RID: 275996 RVA: 0x01076A2C File Offset: 0x01074C2C
		protected bool ClearAllNextPathStatic(int head)
		{
			TuningGridData tuningGridData = this.GridData[head];
			if (tuningGridData.StaticState.Next == null)
			{
				return false;
			}
			tuningGridData.IsStatic = true;
			int? next = tuningGridData.StaticState.Next;
			tuningGridData.StaticState.Next = null;
			while (next != null)
			{
				TuningGridData tuningGridData2 = this.GridData[next.Value];
				next = tuningGridData2.StaticState.Next;
				tuningGridData2.IsStatic = true;
				tuningGridData2.StaticState.State = EGridBelongType.Empty;
				tuningGridData2.DynamicState.Next = null;
				tuningGridData2.DynamicState.Prev = null;
				tuningGridData2.StaticState.Next = null;
				tuningGridData2.StaticState.Prev = null;
			}
			EventSystem.Instance.Emit<int?>(EEventName.TuningStandUpdate, null);
			return true;
		}

		// Token: 0x0604361D RID: 275997 RVA: 0x01076B30 File Offset: 0x01074D30
		protected bool ClearAllNextPathDynamic(int head)
		{
			bool flag = false;
			TuningGridData tuningGridData = this.GridData[head];
			if (tuningGridData.IsStatic)
			{
				tuningGridData.IsStatic = false;
				tuningGridData.DynamicState.State = tuningGridData.StaticState.State;
				tuningGridData.DynamicState.Prev = tuningGridData.StaticState.Prev;
				tuningGridData.DynamicState.Next = tuningGridData.StaticState.Next;
			}
			ITuningStateData curGridState = tuningGridData.GetCurGridState();
			EGridBelongType state = curGridState.State;
			int? next = curGridState.Next;
			curGridState.Next = null;
			List<int> list = new List<int>();
			while (next != null)
			{
				TuningGridData tuningGridData2 = this.GridData[next.Value];
				next = tuningGridData2.GetCurGridState().Next;
				if (tuningGridData2.GetCurGridState().State != state)
				{
					return false;
				}
				if (tuningGridData2.StaticState.State != state && tuningGridData2.StaticState.State != EGridBelongType.Empty)
				{
					int value = tuningGridData2.StaticState.Prev.Value;
					TuningGridData tuningGridData3 = this.GridData[value];
					if (tuningGridData3.GetCurGridState().State == tuningGridData3.StaticState.State)
					{
						flag = true;
						list.Add(tuningGridData2.Index);
					}
					else
					{
						tuningGridData2.IsStatic = false;
						tuningGridData2.DynamicState.State = EGridBelongType.Empty;
						tuningGridData2.DynamicState.Next = null;
						tuningGridData2.DynamicState.Prev = null;
					}
				}
				else
				{
					tuningGridData2.IsStatic = false;
					tuningGridData2.DynamicState.State = EGridBelongType.Empty;
					tuningGridData2.DynamicState.Next = null;
					tuningGridData2.DynamicState.Prev = null;
				}
			}
			if (flag)
			{
				int num = this.CheckRecoverLead(list);
				if (num != -1)
				{
					this.RecoverGrid(num);
				}
			}
			EventSystem.Instance.Emit<int?>(EEventName.TuningStandUpdate, null);
			return flag;
		}

		// Token: 0x0604361E RID: 275998 RVA: 0x01076D3C File Offset: 0x01074F3C
		protected void SaveDynamicGrid()
		{
			foreach (TuningGridData tuningGridData in this.GridData)
			{
				if (!tuningGridData.IsStatic)
				{
					tuningGridData.IsStatic = true;
					tuningGridData.StaticState.State = tuningGridData.DynamicState.State;
					tuningGridData.StaticState.Next = tuningGridData.DynamicState.Next;
					tuningGridData.StaticState.Prev = tuningGridData.DynamicState.Prev;
					tuningGridData.DynamicState.State = EGridBelongType.Empty;
					tuningGridData.DynamicState.Next = null;
					tuningGridData.DynamicState.Prev = null;
				}
			}
			foreach (TuningGridData tuningGridData2 in this.GridData)
			{
				int? next = tuningGridData2.StaticState.Next;
				if (next != null && this.GridData[next.Value].StaticState.State != tuningGridData2.StaticState.State)
				{
					tuningGridData2.StaticState.Next = null;
				}
			}
		}

		// Token: 0x0604361F RID: 275999 RVA: 0x01076EA4 File Offset: 0x010750A4
		protected bool CheckAllClear()
		{
			foreach (TuningGridData tuningGridData in this.GridData)
			{
				if (tuningGridData.GridMainType != EGridMainType.Empty && tuningGridData.StaticState.State == EGridBelongType.Empty)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06043620 RID: 276000 RVA: 0x01076F0C File Offset: 0x0107510C
		protected int[] CheckEndCount()
		{
			int[] array = new int[2];
			foreach (TuningGridData tuningGridData in this.GridData)
			{
				if (tuningGridData.GridMainType == EGridMainType.End)
				{
					array[1]++;
					if (tuningGridData.StaticState.State != EGridBelongType.Empty)
					{
						array[0]++;
					}
				}
			}
			return array;
		}

		// Token: 0x06043621 RID: 276001 RVA: 0x01076F90 File Offset: 0x01075190
		protected int CheckRecoverLead(List<int> recoverList)
		{
			int count = recoverList.Count;
			if (count == 1)
			{
				return recoverList[0];
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (int key in recoverList)
			{
				dictionary[key] = 0;
			}
			foreach (int num in recoverList)
			{
				if (dictionary[num] != -1)
				{
					for (int? next = new int?(num); next != null; next = this.GridData[next.Value].StaticState.Next)
					{
						if (dictionary.ContainsKey(next.Value))
						{
							int num2 = dictionary[next.Value];
							int? num3 = next;
							int num4 = num;
							if (num3.GetValueOrDefault() == num4 & num3 != null)
							{
								dictionary[num] = 1;
							}
							else
							{
								if (num2 != 0)
								{
									dictionary[num] = num2 + 1;
									break;
								}
								dictionary[next.Value] = -1;
								dictionary[num]++;
							}
						}
					}
				}
			}
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				if (keyValuePair.Value == count)
				{
					return keyValuePair.Key;
				}
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "Check Recover Leading Error";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RecoverList", recoverList);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}

		// Token: 0x06043622 RID: 276002 RVA: 0x01077170 File Offset: 0x01075370
		protected void RecoverGrid(int head)
		{
			TuningGridData tuningGridData = this.GridData[head];
			int? next = new int?(head);
			EGridBelongType state = tuningGridData.StaticState.State;
			while (next != null)
			{
				TuningGridData tuningGridData2 = this.GridData[next.Value];
				int? num = next;
				if (!(head == num.GetValueOrDefault() & num != null) && tuningGridData2.GetCurGridState().State != EGridBelongType.Empty && tuningGridData2.GetCurGridState().State != state)
				{
					return;
				}
				next = tuningGridData2.StaticState.Next;
				tuningGridData2.IsStatic = true;
				tuningGridData2.DynamicState.Next = null;
				tuningGridData2.DynamicState.Prev = null;
			}
		}

		// Token: 0x06043623 RID: 276003 RVA: 0x01077230 File Offset: 0x01075430
		private void StartRevolving()
		{
			List<int> list = new List<int>();
			foreach (TuningGridData tuningGridData in this.GridData)
			{
				if (tuningGridData.GridMainType == EGridMainType.Start)
				{
					list.Add(tuningGridData.Index);
				}
			}
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.TuningStandSuccessShowStart, list);
		}

		// Token: 0x06043624 RID: 276004 RVA: 0x010772A8 File Offset: 0x010754A8
		protected void CreateEventList()
		{
			this.EventList.Clear();
			string noteSequence = this.Config.NoteSequence;
			foreach (string node in ((noteSequence != null) ? noteSequence.Split(',', StringSplitOptions.None) : null) ?? Array.Empty<string>())
			{
				TuningStandConfig instance = TuningStandConfig.Instance;
				string text = (instance != null) ? instance.GetEvent(node) : null;
				if (text != null)
				{
					this.EventList.Add(text);
				}
			}
		}

		// Token: 0x06043625 RID: 276005 RVA: 0x01077318 File Offset: 0x01075518
		protected void PlayStartEvent()
		{
			if (this.CurAkTime + 0.05000000074505806 > Time.Instance.Now)
			{
				return;
			}
			if (this.CurNodeIndex >= this.EventList.Count)
			{
				this.CurNodeIndex = 0;
			}
			AudioSystem.Instance.PostEvent(this.EventList[this.CurNodeIndex]);
			this.CurAkTime = Time.Instance.Now;
		}

		// Token: 0x06043626 RID: 276006 RVA: 0x01077388 File Offset: 0x01075588
		protected void PlayAkEvent(bool isForward)
		{
			if (this.EventList.Count == 0)
			{
				return;
			}
			if (this.CurAkTime + 0.05000000074505806 > Time.Instance.Now)
			{
				return;
			}
			if (isForward)
			{
				this.CurNodeIndex++;
				if (this.CurNodeIndex >= this.EventList.Count)
				{
					this.CurNodeIndex = 0;
				}
			}
			else
			{
				this.CurNodeIndex--;
				if (this.CurNodeIndex < 0)
				{
					this.CurNodeIndex = this.EventList.Count - 1;
				}
			}
			AudioSystem.Instance.PostEvent(this.EventList[this.CurNodeIndex]);
			this.CurAkTime = Time.Instance.Now;
		}

		// Token: 0x06043627 RID: 276007 RVA: 0x01077443 File Offset: 0x01075643
		protected void InitTalkBubble()
		{
			if (this.Config.VisualType == ETuningStandVisualType.Challenge || this.Config.BubbleConfig == null)
			{
				this.BubbleProxy = null;
				return;
			}
			this.BubbleProxy = new TuningStandBubbleProxy(this.Config.BubbleConfig);
		}

		// Token: 0x06043628 RID: 276008 RVA: 0x0107747E File Offset: 0x0107567E
		public bool TryStartBubbleFlow(ETuningStandBubbleTriggerType type)
		{
			return this.BubbleProxy != null && this.BubbleProxy.TryStartBubbleFlow(type);
		}

		// Token: 0x06043629 RID: 276009 RVA: 0x01077496 File Offset: 0x01075696
		public void ProcessTooLong()
		{
			this.TryStartBubbleFlow(ETuningStandBubbleTriggerType.TooLong);
		}

		// Token: 0x0604362A RID: 276010 RVA: 0x010774A0 File Offset: 0x010756A0
		protected void DestroyBubble()
		{
			TuningStandBubbleProxy bubbleProxy = this.BubbleProxy;
			if (bubbleProxy != null)
			{
				bubbleProxy.Destroy();
			}
			this.BubbleProxy = null;
		}

		// Token: 0x17009876 RID: 39030
		// (get) Token: 0x0604362B RID: 276011 RVA: 0x010774BA File Offset: 0x010756BA
		public static TuningStandModel Instance
		{
			get
			{
				return TuningStandModel._Instance;
			}
		}

		// Token: 0x0604362C RID: 276012 RVA: 0x010774C1 File Offset: 0x010756C1
		public static TuningStandModel GetOrCreateInstance()
		{
			if (TuningStandModel._Instance == null)
			{
				TuningStandModel.CreateInstance();
			}
			return TuningStandModel._Instance;
		}

		// Token: 0x0604362D RID: 276013 RVA: 0x010774D5 File Offset: 0x010756D5
		public static bool CreateInstance()
		{
			if (TuningStandModel._Instance != null)
			{
				return true;
			}
			TuningStandModel._Instance = new TuningStandModel();
			return true;
		}

		// Token: 0x0604362E RID: 276014 RVA: 0x010774EB File Offset: 0x010756EB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604362F RID: 276015 RVA: 0x010774ED File Offset: 0x010756ED
		public static void ResetStaticDefaultValue()
		{
			TuningStandModel._Instance = null;
		}

		// Token: 0x06043630 RID: 276016 RVA: 0x010774F5 File Offset: 0x010756F5
		static TuningStandModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TuningStandModel.CreateStaticDefaultValue), new Action(TuningStandModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402327C RID: 143996
		[Nullable(2)]
		protected ITuningStand Config;

		// Token: 0x0402327D RID: 143997
		protected List<TuningGridData> GridData = new List<TuningGridData>();

		// Token: 0x0402327E RID: 143998
		protected int? CurIndex;

		// Token: 0x0402327F RID: 143999
		protected int CurNodeIndex;

		// Token: 0x04023280 RID: 144000
		protected bool IsPressing;

		// Token: 0x04023281 RID: 144001
		[Nullable(2)]
		protected TuningStandBubbleProxy BubbleProxy;

		// Token: 0x04023282 RID: 144002
		protected double PrevResetTime;

		// Token: 0x04023283 RID: 144003
		protected int ResetTimes;

		// Token: 0x04023284 RID: 144004
		protected List<string> EventList = new List<string>();

		// Token: 0x04023285 RID: 144005
		protected double CurAkTime;

		// Token: 0x04023286 RID: 144006
		[Nullable(2)]
		private static TuningStandModel _Instance;
	}
}
