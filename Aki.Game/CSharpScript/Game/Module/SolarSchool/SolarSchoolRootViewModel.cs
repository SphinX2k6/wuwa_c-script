using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityCommonRootView;
using CSharpScript.Game.Module.VisualNovel;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A36 RID: 23094
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolRootViewModel : ICommonRootViewModel
	{
		// Token: 0x17006C80 RID: 27776
		// (get) Token: 0x06038EC9 RID: 233161 RVA: 0x00FF132F File Offset: 0x00FEF52F
		public int CurLocationId
		{
			get
			{
				return SolarSchoolGamePlayModel.Instance.MapData.CurrentLocationId;
			}
		}

		// Token: 0x06038ECA RID: 233162 RVA: 0x00FF1340 File Offset: 0x00FEF540
		[NullableContext(1)]
		public void RequestRootUi(SolarSchoolRootUiParams uiParams)
		{
			Action<SolarSchoolRootUiParams> applyRootUiParams = this.ApplyRootUiParams;
			if (applyRootUiParams == null)
			{
				return;
			}
			applyRootUiParams(uiParams);
		}

		// Token: 0x06038ECB RID: 233163 RVA: 0x00FF1353 File Offset: 0x00FEF553
		public void RefreshInvitationTag()
		{
			Action<bool> applyInvitationTag = this.ApplyInvitationTag;
			if (applyInvitationTag == null)
			{
				return;
			}
			applyInvitationTag(SolarSchoolGamePlayModel.Instance.ShouldShowInvitationTag());
		}

		// Token: 0x06038ECC RID: 233164 RVA: 0x00FF1370 File Offset: 0x00FEF570
		public void RefreshFestivalTips()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			Action<SolarSchoolFestivalTipsParams> applyFestivalTips = this.ApplyFestivalTips;
			if (applyFestivalTips == null)
			{
				return;
			}
			applyFestivalTips(instance.IsFestivalInstance ? new SolarSchoolFestivalTipsParams(instance.FestivalName) : null);
		}

		// Token: 0x06038ECD RID: 233165 RVA: 0x00FF13A9 File Offset: 0x00FEF5A9
		public void SetFatiguePreview(int fatigue)
		{
			Action<int> applyFatiguePreview = this.ApplyFatiguePreview;
			if (applyFatiguePreview == null)
			{
				return;
			}
			applyFatiguePreview(fatigue);
		}

		// Token: 0x06038ECE RID: 233166 RVA: 0x00FF13BC File Offset: 0x00FEF5BC
		public void ClearFatiguePreview()
		{
			Action applyClearFatiguePreview = this.ApplyClearFatiguePreview;
			if (applyClearFatiguePreview == null)
			{
				return;
			}
			applyClearFatiguePreview();
		}

		// Token: 0x06038ECF RID: 233167 RVA: 0x00FF13CE File Offset: 0x00FEF5CE
		public void HoldFatigueUntilSettled(int fatigue)
		{
			Action<int> applyHoldFatigueUntilSettled = this.ApplyHoldFatigueUntilSettled;
			if (applyHoldFatigueUntilSettled == null)
			{
				return;
			}
			applyHoldFatigueUntilSettled(fatigue);
		}

		// Token: 0x06038ED0 RID: 233168 RVA: 0x00FF13E1 File Offset: 0x00FEF5E1
		public bool ConsumeLocationEnterPending()
		{
			bool locationEnterPending = this.LocationEnterPending;
			this.LocationEnterPending = false;
			return locationEnterPending;
		}

		// Token: 0x06038ED1 RID: 233169 RVA: 0x00FF13F0 File Offset: 0x00FEF5F0
		public void RefreshLocationRole()
		{
			Action applyLocationRole = this.ApplyLocationRole;
			if (applyLocationRole != null)
			{
				applyLocationRole();
			}
			this.LocationRoleSpineId = 0;
			this.LocationRolePlayVoice = false;
		}

		// Token: 0x06038ED2 RID: 233170 RVA: 0x00FF1411 File Offset: 0x00FEF611
		public void ChangeLocationId(int locationId)
		{
			SolarSchoolGamePlayModel.Instance.MapData.SetCurrentLocation(locationId);
		}

		// Token: 0x06038ED3 RID: 233171 RVA: 0x00FF1423 File Offset: 0x00FEF623
		public void SetBackgroundByLocationId(int locationId, string switchSequence = null)
		{
			Action<int, string> setBackgroundByLocation = this.SetBackgroundByLocation;
			if (setBackgroundByLocation == null)
			{
				return;
			}
			setBackgroundByLocation(locationId, switchSequence);
		}

		// Token: 0x06038ED4 RID: 233172 RVA: 0x00FF1437 File Offset: 0x00FEF637
		public void SetBackgroundSpine([TupleElementNames(new string[]
		{
			"AtlasResourceId",
			"SkeletonDataResourceId"
		})] [Nullable(new byte[]
		{
			0,
			1,
			1
		})] ValueTuple<string, string>? resourceIds)
		{
			Action<ValueTuple<string, string>?> applyBackgroundSpine = this.ApplyBackgroundSpine;
			if (applyBackgroundSpine == null)
			{
				return;
			}
			applyBackgroundSpine(resourceIds);
		}

		// Token: 0x06038ED5 RID: 233173 RVA: 0x00FF144A File Offset: 0x00FEF64A
		public void SetBackgroundByBackgroundId(int backgroundId)
		{
			Action<int> setBackgroundById = this.SetBackgroundById;
			if (setBackgroundById == null)
			{
				return;
			}
			setBackgroundById(backgroundId);
		}

		// Token: 0x0401DF45 RID: 122693
		public Action<int, string> SetBackgroundByLocation;

		// Token: 0x0401DF46 RID: 122694
		public Action<int> SetBackgroundById;

		// Token: 0x0401DF47 RID: 122695
		[TupleElementNames(new string[]
		{
			"AtlasResourceId",
			"SkeletonDataResourceId"
		})]
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		public Action<ValueTuple<string, string>?> ApplyBackgroundSpine;

		// Token: 0x0401DF48 RID: 122696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolRootUiParams> ApplyRootUiParams;

		// Token: 0x0401DF49 RID: 122697
		public Action<bool> ApplyInvitationTag;

		// Token: 0x0401DF4A RID: 122698
		public Action<SolarSchoolFestivalTipsParams> ApplyFestivalTips;

		// Token: 0x0401DF4B RID: 122699
		public Action<int> ApplyFatiguePreview;

		// Token: 0x0401DF4C RID: 122700
		public Action ApplyClearFatiguePreview;

		// Token: 0x0401DF4D RID: 122701
		public Action<int> ApplyHoldFatigueUntilSettled;

		// Token: 0x0401DF4E RID: 122702
		public Action ApplyLocationRole;

		// Token: 0x0401DF4F RID: 122703
		public Action RefreshDateVisible;

		// Token: 0x0401DF50 RID: 122704
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<VisualNovelDate, Action, bool> PlayEndingTimeTransition;

		// Token: 0x0401DF51 RID: 122705
		public Action StopTimeSlotTransition;

		// Token: 0x0401DF52 RID: 122706
		public Action<ESolarSchoolMapTimePhase> SnapTimeSlotPhase;

		// Token: 0x0401DF53 RID: 122707
		public Action RefreshDate;

		// Token: 0x0401DF54 RID: 122708
		public Action SnapTimeDisplay;

		// Token: 0x0401DF55 RID: 122709
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ESolarSchoolTimeTransition, Action, bool> PlayDayTransition;

		// Token: 0x0401DF56 RID: 122710
		public Action StopDayTransition;

		// Token: 0x0401DF57 RID: 122711
		public Action FocusMapOnHome;

		// Token: 0x0401DF58 RID: 122712
		public Action PushDateToNextDay;

		// Token: 0x0401DF59 RID: 122713
		public ESolarSchoolMapTimePhase? LastShownMapPhase;

		// Token: 0x0401DF5A RID: 122714
		public bool LocationEnterPending;

		// Token: 0x0401DF5B RID: 122715
		public int LocationRoleSpineId;

		// Token: 0x0401DF5C RID: 122716
		public bool LocationRolePlayVoice;
	}
}
