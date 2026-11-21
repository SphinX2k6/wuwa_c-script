using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.TuningStand.Bubble;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B27 RID: 23335
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TuningStandModel : ModelBase
	{
		// Token: 0x0603964B RID: 235083 RVA: 0x0101A93C File Offset: 0x01018B3C
		public void LoadData(ITuningStand config)
		{
			this.Config = config;
			this.ResetTimes = 0;
			this.InitGridData();
			this.InitTalkBubble();
			global::Log.Instance.Info(ELogModule.LevelPlay, ELogAuthor.WHJ, "调律台资源开始加载", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603964C RID: 235084 RVA: 0x0101A97F File Offset: 0x01018B7F
		public bool GetIsPressing()
		{
			return this.IsPressing;
		}

		// Token: 0x0603964D RID: 235085 RVA: 0x0101A987 File Offset: 0x01018B87
		public int? GetCurIndex()
		{
			return this.CurIndex;
		}

		// Token: 0x0603964E RID: 235086 RVA: 0x0101A98F File Offset: 0x01018B8F
		public List<TuningGridData> GetGridList()
		{
			return this.GridData;
		}

		// Token: 0x0603964F RID: 235087 RVA: 0x0101A998 File Offset: 0x01018B98
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

		// Token: 0x06039650 RID: 235088 RVA: 0x0101AA40 File Offset: 0x01018C40
		protected bool CheckEndValid(TuningGridData from, TuningGridData to)
		{
			ITuningStateData curGridState = from.GetCurGridState();
			if (to.GridType == ETuningStandGridType.End1)
			{
				return curGridState.State == EGridBelongType.Type1;
			}
			return curGridState.State == EGridBelongType.Type2;
		}

		// Token: 0x06039651 RID: 235089 RVA: 0x0101AA70 File Offset: 0x01018C70
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

		// Token: 0x06039652 RID: 235090 RVA: 0x0101AB54 File Offset: 0x01018D54
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

		// Token: 0x06039653 RID: 235091 RVA: 0x0101ABBC File Offset: 0x01018DBC
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

		// Token: 0x06039654 RID: 235092 RVA: 0x0101AC15 File Offset: 0x01018E15
		public void InitData(bool isPress)
		{
			this.IsPressing = isPress;
			this.CurIndex = null;
		}

		// Token: 0x06039655 RID: 235093 RVA: 0x0101AC2C File Offset: 0x01018E2C
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

		// Token: 0x06039656 RID: 235094 RVA: 0x0101ACA0 File Offset: 0x01018EA0
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

		// Token: 0x06039657 RID: 235095 RVA: 0x0101AD84 File Offset: 0x01018F84
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

		// Token: 0x06039658 RID: 235096 RVA: 0x0101AEC0 File Offset: 0x010190C0
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

		// Token: 0x06039659 RID: 235097 RVA: 0x0101AFC4 File Offset: 0x010191C4
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

		// Token: 0x0603965A RID: 235098 RVA: 0x0101B1D0 File Offset: 0x010193D0
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

		// Token: 0x0603965B RID: 235099 RVA: 0x0101B338 File Offset: 0x01019538
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

		// Token: 0x0603965C RID: 235100 RVA: 0x0101B3A0 File Offset: 0x010195A0
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

		// Token: 0x0603965D RID: 235101 RVA: 0x0101B424 File Offset: 0x01019624
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

		// Token: 0x0603965E RID: 235102 RVA: 0x0101B604 File Offset: 0x01019804
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

		// Token: 0x0603965F RID: 235103 RVA: 0x0101B6C4 File Offset: 0x010198C4
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

		// Token: 0x06039660 RID: 235104 RVA: 0x0101B73C File Offset: 0x0101993C
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

		// Token: 0x06039661 RID: 235105 RVA: 0x0101B7AC File Offset: 0x010199AC
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

		// Token: 0x06039662 RID: 235106 RVA: 0x0101B81C File Offset: 0x01019A1C
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

		// Token: 0x06039663 RID: 235107 RVA: 0x0101B8D7 File Offset: 0x01019AD7
		protected void InitTalkBubble()
		{
			if (this.Config.VisualType == ETuningStandVisualType.Challenge || this.Config.BubbleConfig == null)
			{
				this.BubbleProxy = null;
				return;
			}
			this.BubbleProxy = new TuningStandBubbleProxy(this.Config.BubbleConfig);
		}

		// Token: 0x06039664 RID: 235108 RVA: 0x0101B912 File Offset: 0x01019B12
		public bool TryStartBubbleFlow(ETuningStandBubbleTriggerType type)
		{
			return this.BubbleProxy != null && this.BubbleProxy.TryStartBubbleFlow(type);
		}

		// Token: 0x06039665 RID: 235109 RVA: 0x0101B92A File Offset: 0x01019B2A
		public void ProcessTooLong()
		{
			this.TryStartBubbleFlow(ETuningStandBubbleTriggerType.TooLong);
		}

		// Token: 0x06039666 RID: 235110 RVA: 0x0101B934 File Offset: 0x01019B34
		protected void DestroyBubble()
		{
			TuningStandBubbleProxy bubbleProxy = this.BubbleProxy;
			if (bubbleProxy != null)
			{
				bubbleProxy.Destroy();
			}
			this.BubbleProxy = null;
		}

		// Token: 0x17006D56 RID: 27990
		// (get) Token: 0x06039667 RID: 235111 RVA: 0x0101B94E File Offset: 0x01019B4E
		public static TuningStandModel Instance
		{
			get
			{
				return TuningStandModel._Instance;
			}
		}

		// Token: 0x06039668 RID: 235112 RVA: 0x0101B955 File Offset: 0x01019B55
		public static TuningStandModel GetOrCreateInstance()
		{
			if (TuningStandModel._Instance == null)
			{
				TuningStandModel.CreateInstance();
			}
			return TuningStandModel._Instance;
		}

		// Token: 0x06039669 RID: 235113 RVA: 0x0101B969 File Offset: 0x01019B69
		public static bool CreateInstance()
		{
			if (TuningStandModel._Instance != null)
			{
				return true;
			}
			TuningStandModel._Instance = new TuningStandModel();
			return true;
		}

		// Token: 0x0603966A RID: 235114 RVA: 0x0101B97F File Offset: 0x01019B7F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603966B RID: 235115 RVA: 0x0101B981 File Offset: 0x01019B81
		public static void ResetStaticDefaultValue()
		{
			TuningStandModel._Instance = null;
		}

		// Token: 0x0603966C RID: 235116 RVA: 0x0101B989 File Offset: 0x01019B89
		static TuningStandModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TuningStandModel.CreateStaticDefaultValue), new Action(TuningStandModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E46C RID: 124012
		[Nullable(2)]
		protected ITuningStand Config;

		// Token: 0x0401E46D RID: 124013
		protected List<TuningGridData> GridData = new List<TuningGridData>();

		// Token: 0x0401E46E RID: 124014
		protected int? CurIndex;

		// Token: 0x0401E46F RID: 124015
		protected int CurNodeIndex;

		// Token: 0x0401E470 RID: 124016
		protected bool IsPressing;

		// Token: 0x0401E471 RID: 124017
		[Nullable(2)]
		protected TuningStandBubbleProxy BubbleProxy;

		// Token: 0x0401E472 RID: 124018
		protected double PrevResetTime;

		// Token: 0x0401E473 RID: 124019
		protected int ResetTimes;

		// Token: 0x0401E474 RID: 124020
		protected List<string> EventList = new List<string>();

		// Token: 0x0401E475 RID: 124021
		protected double CurAkTime;

		// Token: 0x0401E476 RID: 124022
		[Nullable(2)]
		private static TuningStandModel _Instance;
	}
}
