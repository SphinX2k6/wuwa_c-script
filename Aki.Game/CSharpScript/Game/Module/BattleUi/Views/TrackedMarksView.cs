using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks;
using CSharpScript.Game.Module.Map.Misc;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E48 RID: 24136
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackedMarksView : BattleChildView
	{
		// Token: 0x0603D60C RID: 251404 RVA: 0x00ECDB54 File Offset: 0x00ECBD54
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

		// Token: 0x0603D60D RID: 251405 RVA: 0x00ECDBF8 File Offset: 0x00ECBDF8
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

		// Token: 0x0603D60E RID: 251406 RVA: 0x00ECDCA0 File Offset: 0x00ECBEA0
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

		// Token: 0x0603D60F RID: 251407 RVA: 0x00ECDD30 File Offset: 0x00ECBF30
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

		// Token: 0x0603D610 RID: 251408 RVA: 0x00ECDE84 File Offset: 0x00ECC084
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

		// Token: 0x0603D611 RID: 251409 RVA: 0x00ECDF38 File Offset: 0x00ECC138
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

		// Token: 0x0603D612 RID: 251410 RVA: 0x00ECDFC8 File Offset: 0x00ECC1C8
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

		// Token: 0x0603D613 RID: 251411 RVA: 0x00ECE0DC File Offset: 0x00ECC2DC
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

		// Token: 0x0603D614 RID: 251412 RVA: 0x00ECE150 File Offset: 0x00ECC350
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

		// Token: 0x0603D615 RID: 251413 RVA: 0x00ECE184 File Offset: 0x00ECC384
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

		// Token: 0x0603D616 RID: 251414 RVA: 0x00ECE1B4 File Offset: 0x00ECC3B4
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

		// Token: 0x0603D617 RID: 251415 RVA: 0x00ECE1E4 File Offset: 0x00ECC3E4
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

		// Token: 0x0603D618 RID: 251416 RVA: 0x00ECE274 File Offset: 0x00ECC474
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

		// Token: 0x0603D619 RID: 251417 RVA: 0x00ECE2D4 File Offset: 0x00ECC4D4
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

		// Token: 0x0603D61A RID: 251418 RVA: 0x00ECE364 File Offset: 0x00ECC564
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

		// Token: 0x0603D61B RID: 251419 RVA: 0x00ECE3F4 File Offset: 0x00ECC5F4
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

		// Token: 0x0603D61C RID: 251420 RVA: 0x00ECE484 File Offset: 0x00ECC684
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

		// Token: 0x0603D61D RID: 251421 RVA: 0x00ECE5C8 File Offset: 0x00ECC7C8
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

		// Token: 0x0603D61E RID: 251422 RVA: 0x00ECE709 File Offset: 0x00ECC909
		protected override bool DestroyOverride()
		{
			return true;
		}

		// Token: 0x04020068 RID: 131176
		[StaticVariableRuleIgnore]
		private static readonly Stat TickStatsObject = Stat.Create("(BattleView)UpdateTrackDistance", "", "");

		// Token: 0x04020069 RID: 131177
		private readonly Dictionary<int, Dictionary<int, TrackedMark>> TrackedMarks = new Dictionary<int, Dictionary<int, TrackedMark>>();

		// Token: 0x0402006A RID: 131178
		private bool TrackedMarksDirty;
	}
}
