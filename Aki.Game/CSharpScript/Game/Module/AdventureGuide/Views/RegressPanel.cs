using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.AdventureGuide.Views
{
	// Token: 0x02004EBB RID: 20155
	[NullableContext(2)]
	[Nullable(0)]
	public class RegressPanel : UiPanelBase
	{
		// Token: 0x06032B16 RID: 207638 RVA: 0x00E39F3C File Offset: 0x00E3813C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickJumpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06032B17 RID: 207639 RVA: 0x00E3A024 File Offset: 0x00E38224
		private void InitV2ActivityData()
		{
			this.V2Controller = (ActivityManager.GetActivityController(108) as ActivityNewPlayerSupportActivityV2Controller);
			ActivityNewPlayerSupportActivityV2Controller v2Controller = this.V2Controller;
			this.V2ActivityData = ((v2Controller != null) ? v2Controller.ActivityData : null);
			this.IsV2ActivityValid = (PlayerInfoModel.Instance.NewbieGuideV2 && this.V2ActivityData != null && this.V2ActivityData.CheckIfInShowTime());
		}

		// Token: 0x06032B18 RID: 207640 RVA: 0x00E3A083 File Offset: 0x00E38283
		public bool CanShowV2Activity()
		{
			this.InitV2ActivityData();
			return this.IsV2ActivityValid;
		}

		// Token: 0x06032B19 RID: 207641 RVA: 0x00E3A094 File Offset: 0x00E38294
		protected override void OnStart()
		{
			this.RemainTimeText = ConfigMultiTextLang.GetLocalTextNew("RegressPanelRemainTime", null);
			this.RoleLayout = new GenericLayout<RoleItem, int>(base.GetHorizontalLayout(1), new Func<RoleItem>(this.InitRoleItem), null, false, true);
			bool checkIfInShowTime = ActivityRegressModel.Instance.CheckIfInShowTime;
			this.InitV2ActivityData();
			List<int> roleListForPanel = this.GetRoleListForPanel(checkIfInShowTime);
			this.RoleLayout.RefreshByData(roleListForPanel, null, false);
			if (checkIfInShowTime)
			{
				this.ActivityData = ActivityRegressModel.Instance.ActivityData;
			}
			else if (this.IsV2ActivityValid)
			{
				this.ActivityData = this.V2ActivityData;
			}
			else
			{
				this.ActivityData = ActivityNewPlayerSupportController.Instance.ActivityData;
			}
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTimerRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
			this.OnTimerRefresh(0f);
		}

		// Token: 0x06032B1A RID: 207642 RVA: 0x00E3A16F File Offset: 0x00E3836F
		[NullableContext(1)]
		private List<int> GetRoleListForPanel(bool inRegress)
		{
			if (inRegress)
			{
				return ActivityRegressModel.Instance.GetGachaPoolUpRole();
			}
			if (this.IsV2ActivityValid && this.V2Controller != null)
			{
				return this.V2Controller.CollectAdventureV2RoleIds();
			}
			return ActivityRegressModel.Instance.GetGachaPoolUpRole();
		}

		// Token: 0x06032B1B RID: 207643 RVA: 0x00E3A1A8 File Offset: 0x00E383A8
		private void OnTimerRefresh(float _)
		{
			if (this.ActivityData == null || !this.ActivityData.CheckIfInShowTime())
			{
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, this.RemainTimeText);
			base.GetText(0).SetText(remainTimeText, true);
		}

		// Token: 0x06032B1C RID: 207644 RVA: 0x00E3A1F5 File Offset: 0x00E383F5
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x06032B1D RID: 207645 RVA: 0x00E3A221 File Offset: 0x00E38421
		[NullableContext(1)]
		private RoleItem InitRoleItem()
		{
			return new RoleItem();
		}

		// Token: 0x06032B1E RID: 207646 RVA: 0x00E3A228 File Offset: 0x00E38428
		private void OnClickJumpBtn()
		{
			if (ActivityRegressModel.Instance.CheckIfInShowTime)
			{
				IActivityRegressMainViewOpenData activityRegressMainViewOpenData = new IActivityRegressMainViewOpenData
				{
					SubView = EActivityMainSubViewNewType.Adventure,
					OpenType = EActivityRegressMainViewOpenDataType.Regress
				};
				UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, activityRegressMainViewOpenData, null);
				return;
			}
			this.InitV2ActivityData();
			if (this.IsV2ActivityValid && this.V2Controller != null)
			{
				this.V2Controller.OpenAdventureV2View();
				return;
			}
			IActivityRegressMainViewOpenData activityRegressMainViewOpenData2 = new IActivityRegressMainViewOpenData
			{
				SubView = EActivityMainSubViewNewType.Adventure,
				OpenType = EActivityRegressMainViewOpenDataType.NewPlayer
			};
			UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, activityRegressMainViewOpenData2, null);
		}

		// Token: 0x06032B1F RID: 207647 RVA: 0x00E3A2C4 File Offset: 0x00E384C4
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x0401AE7A RID: 110202
		[Nullable(1)]
		private string RemainTimeText = "";

		// Token: 0x0401AE7B RID: 110203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoleItem, int> RoleLayout;

		// Token: 0x0401AE7C RID: 110204
		private TimerHandle RefreshTimer;

		// Token: 0x0401AE7D RID: 110205
		private ActivityBaseData ActivityData;

		// Token: 0x0401AE7E RID: 110206
		private ActivityNewPlayerSupportActivityV2Controller V2Controller;

		// Token: 0x0401AE7F RID: 110207
		private ActivityBaseData V2ActivityData;

		// Token: 0x0401AE80 RID: 110208
		private bool IsV2ActivityValid;
	}
}
