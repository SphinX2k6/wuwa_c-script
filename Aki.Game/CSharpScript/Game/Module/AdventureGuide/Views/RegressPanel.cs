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
	// Token: 0x02005ED4 RID: 24276
	[NullableContext(2)]
	[Nullable(0)]
	public class RegressPanel : UiPanelBase
	{
		// Token: 0x0603DB84 RID: 252804 RVA: 0x00EE8764 File Offset: 0x00EE6964
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

		// Token: 0x0603DB85 RID: 252805 RVA: 0x00EE884C File Offset: 0x00EE6A4C
		private void InitV2ActivityData()
		{
			this.V2Controller = (ActivityManager.GetActivityController(108) as ActivityNewPlayerSupportActivityV2Controller);
			ActivityNewPlayerSupportActivityV2Controller v2Controller = this.V2Controller;
			this.V2ActivityData = ((v2Controller != null) ? v2Controller.ActivityData : null);
			this.IsV2ActivityValid = (PlayerInfoModel.Instance.NewbieGuideV2 && this.V2ActivityData != null && this.V2ActivityData.CheckIfInShowTime());
		}

		// Token: 0x0603DB86 RID: 252806 RVA: 0x00EE88AB File Offset: 0x00EE6AAB
		public bool CanShowV2Activity()
		{
			this.InitV2ActivityData();
			return this.IsV2ActivityValid;
		}

		// Token: 0x0603DB87 RID: 252807 RVA: 0x00EE88BC File Offset: 0x00EE6ABC
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

		// Token: 0x0603DB88 RID: 252808 RVA: 0x00EE8997 File Offset: 0x00EE6B97
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

		// Token: 0x0603DB89 RID: 252809 RVA: 0x00EE89D0 File Offset: 0x00EE6BD0
		private void OnTimerRefresh(float _)
		{
			if (this.ActivityData == null || !this.ActivityData.CheckIfInShowTime())
			{
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, this.RemainTimeText);
			base.GetText(0).SetText(remainTimeText, true);
		}

		// Token: 0x0603DB8A RID: 252810 RVA: 0x00EE8A1D File Offset: 0x00EE6C1D
		private void ClearTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.RefreshTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x0603DB8B RID: 252811 RVA: 0x00EE8A49 File Offset: 0x00EE6C49
		[NullableContext(1)]
		private RoleItem InitRoleItem()
		{
			return new RoleItem();
		}

		// Token: 0x0603DB8C RID: 252812 RVA: 0x00EE8A50 File Offset: 0x00EE6C50
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

		// Token: 0x0603DB8D RID: 252813 RVA: 0x00EE8AEC File Offset: 0x00EE6CEC
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
		}

		// Token: 0x040203AB RID: 132011
		[Nullable(1)]
		private string RemainTimeText = "";

		// Token: 0x040203AC RID: 132012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoleItem, int> RoleLayout;

		// Token: 0x040203AD RID: 132013
		private TimerHandle RefreshTimer;

		// Token: 0x040203AE RID: 132014
		private ActivityBaseData ActivityData;

		// Token: 0x040203AF RID: 132015
		private ActivityNewPlayerSupportActivityV2Controller V2Controller;

		// Token: 0x040203B0 RID: 132016
		private ActivityBaseData V2ActivityData;

		// Token: 0x040203B1 RID: 132017
		private bool IsV2ActivityValid;
	}
}
