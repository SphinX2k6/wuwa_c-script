using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E2D RID: 20013
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackedMarksView : BattleChildView
	{
		// Token: 0x0603259C RID: 206236 RVA: 0x00E1F0C4 File Offset: 0x00E1D2C4
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			this.BindEvents();
			foreach (Dictionary<int, ITrackData> dictionary in BattleUiModel.Instance.TrackDatas.Values)
			{
				foreach (ITrackData trackData in dictionary.Values)
				{
					this.TrackMark(trackData);
				}
			}
		}

		// Token: 0x0603259D RID: 206237 RVA: 0x00E1F168 File Offset: 0x00E1D368
		public override void Reset()
		{
			base.Reset();
			this.UnbindEvents();
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.Destroy(null);
				}
			}
			this.TrackedMarks.Clear();
		}

		// Token: 0x0603259E RID: 206238 RVA: 0x00E1F210 File Offset: 0x00E1D410
		public void OnShowBattleChildViewPanel()
		{
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.OnUiShow();
				}
			}
		}

		// Token: 0x0603259F RID: 206239 RVA: 0x00E1F2A0 File Offset: 0x00E1D4A0
		public void Update(float delta)
		{
			TrackModel.Instance.ClearGroupMinDistance();
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.UpdateTrackDistance();
				}
			}
			foreach (KeyValuePair<int, Dictionary<int, TrackedMark>> keyValuePair in this.TrackedMarks)
			{
				int num;
				Dictionary<int, TrackedMark> dictionary2;
				keyValuePair.Deconstruct(out num, out dictionary2);
				int inSourceId = num;
				foreach (TrackedMark trackedMark2 in dictionary2.Values)
				{
					if (this.TrackedMarksDirty)
					{
						if (this.IsTrackTargetRepeat(trackedMark2, (ETrackSource)inSourceId))
						{
							trackedMark2.ShouldShowTrackMark = false;
						}
						else
						{
							trackedMark2.ShouldShowTrackMark = true;
						}
					}
					trackedMark2.Update(delta);
				}
			}
			this.TrackedMarksDirty = false;
		}

		// Token: 0x060325A0 RID: 206240 RVA: 0x00E1F3F4 File Offset: 0x00E1D5F4
		public bool IsTrackTargetRepeat(TrackedMark item, ETrackSource inSourceId)
		{
			foreach (KeyValuePair<int, Dictionary<int, TrackedMark>> keyValuePair in this.TrackedMarks)
			{
				int num;
				Dictionary<int, TrackedMark> dictionary;
				keyValuePair.Deconstruct(out num, out dictionary);
				int num2 = num;
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					if (item.TrackTarget == trackedMark.TrackTarget && inSourceId < (ETrackSource)num2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060325A1 RID: 206241 RVA: 0x00E1F4A8 File Offset: 0x00E1D6A8
		public void OnHideBattleChildViewPanel()
		{
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.OnUiHide();
				}
			}
		}

		// Token: 0x060325A2 RID: 206242 RVA: 0x00E1F538 File Offset: 0x00E1D738
		private void TrackMark(ITrackData trackData)
		{
			if (!MarkItemUtil.CanShowTrackMark(trackData))
			{
				ELogAuthor author = ELogAuthor.LYX;
				string message = "标记系统-追踪->TackedMarksView.TrackMark,追踪标记不满足显示条件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("trackData", trackData);
				MapLogger.Debug(author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			TTrackTarget_AActor ttrackTarget_AActor = trackData.TrackTarget as TTrackTarget_AActor;
			if (ttrackTarget_AActor != null && !ttrackTarget_AActor.Value.IsValid())
			{
				return;
			}
			Dictionary<int, TrackedMark> dictionary;
			if (!this.TrackedMarks.TryGetValue((int)trackData.TrackSource, out dictionary))
			{
				dictionary = new Dictionary<int, TrackedMark>();
				this.TrackedMarks[(int)trackData.TrackSource] = dictionary;
			}
			if (!dictionary.ContainsKey(trackData.Id))
			{
				TrackedMark trackedMark;
				if (TowerDefenseController.Instance.CheckIsTowerEntity(trackData))
				{
					trackedMark = new TrackedMarkForTower(trackData);
				}
				else
				{
					trackedMark = new TrackedMark(trackData);
				}
				dictionary[trackData.Id] = trackedMark;
				trackedMark.Initialize(this.RootItem);
				Dictionary<int, ITrackData> dictionary2;
				if (!BattleUiModel.Instance.TrackDatas.TryGetValue((int)trackData.TrackSource, out dictionary2))
				{
					dictionary2 = new Dictionary<int, ITrackData>();
					BattleUiModel.Instance.TrackDatas[(int)trackData.TrackSource] = dictionary2;
				}
				dictionary2[trackData.Id] = trackData;
			}
			this.TrackedMarksDirty = true;
		}

		// Token: 0x060325A3 RID: 206243 RVA: 0x00E1F64C File Offset: 0x00E1D84C
		private void UnTrackMark(ITrackData trackData)
		{
			Dictionary<int, TrackedMark> dictionary;
			if (!this.TrackedMarks.TryGetValue((int)trackData.TrackSource, out dictionary))
			{
				return;
			}
			TrackedMark trackedMark;
			if (dictionary.TryGetValue(trackData.Id, out trackedMark))
			{
				trackedMark.Destroy(null);
				dictionary.Remove(trackData.Id);
				Dictionary<int, ITrackData> dictionary2;
				if (BattleUiModel.Instance.TrackDatas.TryGetValue((int)trackData.TrackSource, out dictionary2))
				{
					dictionary2.Remove(trackData.Id);
				}
			}
			this.TrackedMarksDirty = true;
		}

		// Token: 0x060325A4 RID: 206244 RVA: 0x00E1F6C0 File Offset: 0x00E1D8C0
		private void UpdateTrackTarget(ETrackSource trackSource, int id, TTrackTarget trackTarget)
		{
			Dictionary<int, TrackedMark> dictionary;
			if (!this.TrackedMarks.TryGetValue((int)trackSource, out dictionary))
			{
				return;
			}
			TrackedMark trackedMark;
			if (dictionary.TryGetValue(id, out trackedMark))
			{
				trackedMark.UpdateTrackTarget(trackTarget);
			}
		}

		// Token: 0x060325A5 RID: 206245 RVA: 0x00E1F6F4 File Offset: 0x00E1D8F4
		private void SetTrackMarkOccupied(ETrackSource trackSource, int id, bool bOccupied)
		{
			Dictionary<int, TrackedMark> dictionary;
			if (!this.TrackedMarks.TryGetValue((int)trackSource, out dictionary))
			{
				return;
			}
			TrackedMark trackedMark;
			if (dictionary.TryGetValue(id, out trackedMark))
			{
				trackedMark.SetVisibleByOccupied(bOccupied);
			}
		}

		// Token: 0x060325A6 RID: 206246 RVA: 0x00E1F724 File Offset: 0x00E1D924
		private void SetInteractSpotOccupied(ETrackSource trackSource, int id, bool bOccupied)
		{
			Dictionary<int, TrackedMark> dictionary;
			if (!this.TrackedMarks.TryGetValue((int)trackSource, out dictionary))
			{
				return;
			}
			TrackedMark trackedMark;
			if (dictionary.TryGetValue(id, out trackedMark))
			{
				trackedMark.SetVisibleByInteractionSpotOccupied(bOccupied);
			}
		}

		// Token: 0x060325A7 RID: 206247 RVA: 0x00E1F754 File Offset: 0x00E1D954
		private void OnWorldMapSubMapChanged(int floor)
		{
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.UpdateDownStateSprite();
				}
			}
		}

		// Token: 0x060325A8 RID: 206248 RVA: 0x00E1F7E4 File Offset: 0x00E1D9E4
		private void OnMarkItemShowStateChange(int markId)
		{
			using (Dictionary<int, Dictionary<int, TrackedMark>>.ValueCollection.Enumerator enumerator = this.TrackedMarks.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TrackedMark trackedMark;
					if (enumerator.Current.TryGetValue(markId, out trackedMark))
					{
						trackedMark.UpdateUpStateSprite();
					}
				}
			}
		}

		// Token: 0x060325A9 RID: 206249 RVA: 0x00E1F844 File Offset: 0x00E1DA44
		private void OnMarkItemUpdateMarkHideInfo()
		{
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.UpdateUpStateSprite();
				}
			}
		}

		// Token: 0x060325AA RID: 206250 RVA: 0x00E1F8D4 File Offset: 0x00E1DAD4
		private void OnLevelPlayStateChange()
		{
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.UpdateUpStateSprite();
				}
			}
		}

		// Token: 0x060325AB RID: 206251 RVA: 0x00E1F964 File Offset: 0x00E1DB64
		private void OnLevelPlayStateChange(int levelId, ELevelPlayState state)
		{
			foreach (Dictionary<int, TrackedMark> dictionary in this.TrackedMarks.Values)
			{
				foreach (TrackedMark trackedMark in dictionary.Values)
				{
					trackedMark.UpdateUpStateSprite();
				}
			}
		}

		// Token: 0x060325AC RID: 206252 RVA: 0x00E1F9F4 File Offset: 0x00E1DBF4
		private void BindEvents()
		{
			EventSystem.Instance.Add<ITrackData>(EEventName.TrackMark, new Action<ITrackData>(this.TrackMark));
			EventSystem.Instance.Add<ITrackData>(EEventName.UnTrackMark, new Action<ITrackData>(this.UnTrackMark));
			EventSystem.Instance.Add<ETrackSource, int, TTrackTarget>(EEventName.UpdateTrackTarget, new Action<ETrackSource, int, TTrackTarget>(this.UpdateTrackTarget));
			EventSystem.Instance.Add<ETrackSource, int, bool>(EEventName.SetTrackMarkOccupied, new Action<ETrackSource, int, bool>(this.SetTrackMarkOccupied));
			EventSystem.Instance.Add<ETrackSource, int, bool>(EEventName.SetInteractSpotOccupied, new Action<ETrackSource, int, bool>(this.SetInteractSpotOccupied));
			EventSystem.Instance.Add<int>(EEventName.WorldMapSubMapChanged, new Action<int>(this.OnWorldMapSubMapChanged));
			EventSystem.Instance.Add<int>(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemShowStateChange));
			EventSystem.Instance.Add(EEventName.OnMarkItemUpdateMarkHideInfo, new Action(this.OnMarkItemUpdateMarkHideInfo));
			EventSystem.Instance.Add(EEventName.LevelPlayStateDetailUpdate, new Action(this.OnLevelPlayStateChange));
			EventSystem.Instance.Add<int, ELevelPlayState>(EEventName.OnLevelPlayStateChange, new Action<int, ELevelPlayState>(this.OnLevelPlayStateChange));
			EventSystem.Instance.Add(EEventName.LevelPlayRewardDetailUpdate, new Action(this.OnLevelPlayStateChange));
		}

		// Token: 0x060325AD RID: 206253 RVA: 0x00E1FB38 File Offset: 0x00E1DD38
		private void UnbindEvents()
		{
			EventSystem.Instance.Remove(EEventName.TrackMark, new Action<ITrackData>(this.TrackMark));
			EventSystem.Instance.Remove(EEventName.UnTrackMark, new Action<ITrackData>(this.UnTrackMark));
			EventSystem.Instance.Remove(EEventName.UpdateTrackTarget, new Action<ETrackSource, int, TTrackTarget>(this.UpdateTrackTarget));
			EventSystem.Instance.Remove(EEventName.SetTrackMarkOccupied, new Action<ETrackSource, int, bool>(this.SetTrackMarkOccupied));
			EventSystem.Instance.Remove(EEventName.SetInteractSpotOccupied, new Action<ETrackSource, int, bool>(this.SetInteractSpotOccupied));
			EventSystem.Instance.Remove(EEventName.WorldMapSubMapChanged, new Action<int>(this.OnWorldMapSubMapChanged));
			EventSystem.Instance.Remove(EEventName.OnMarkItemShowStateChange, new Action<int>(this.OnMarkItemShowStateChange));
			EventSystem.Instance.Remove(EEventName.OnMarkItemUpdateMarkHideInfo, new Action(this.OnMarkItemUpdateMarkHideInfo));
			EventSystem.Instance.Remove(EEventName.LevelPlayStateDetailUpdate, new Action(this.OnLevelPlayStateChange));
			EventSystem.Instance.Remove<int, ELevelPlayState>(EEventName.OnLevelPlayStateChange, new Action<int, ELevelPlayState>(this.OnLevelPlayStateChange));
			EventSystem.Instance.Remove(EEventName.LevelPlayRewardDetailUpdate, new Action(this.OnLevelPlayStateChange));
		}

		// Token: 0x060325AE RID: 206254 RVA: 0x00E1FC79 File Offset: 0x00E1DE79
		protected override bool DestroyOverride()
		{
			return true;
		}

		// Token: 0x0401AB2F RID: 109359
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("(BattleView)UpdateTrackDistance", "", "");

		// Token: 0x0401AB30 RID: 109360
		private readonly Dictionary<int, Dictionary<int, TrackedMark>> TrackedMarks = new Dictionary<int, Dictionary<int, TrackedMark>>();

		// Token: 0x0401AB31 RID: 109361
		private bool TrackedMarksDirty;
	}
}
