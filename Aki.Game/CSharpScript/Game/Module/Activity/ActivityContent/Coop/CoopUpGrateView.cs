using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068E9 RID: 26857
	[NullableContext(2)]
	[Nullable(0)]
	public class CoopUpGrateView : UiViewBase
	{
		// Token: 0x06042FF2 RID: 274418 RVA: 0x010519A6 File Offset: 0x0104FBA6
		[NullableContext(1)]
		public CoopUpGrateView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042FF3 RID: 274419 RVA: 0x010519BC File Offset: 0x0104FBBC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnClickGoBtn))
			};
		}

		// Token: 0x06042FF4 RID: 274420 RVA: 0x01051AC0 File Offset: 0x0104FCC0
		protected override UniTask OnBeforeStartAsync()
		{
			CoopUpGrateView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CoopUpGrateView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042FF5 RID: 274421 RVA: 0x01051B04 File Offset: 0x0104FD04
		protected override void OnStart()
		{
			CoopUpGrateViewParams coopUpGrateViewParams = this.OpenParam as CoopUpGrateViewParams;
			this.ActivityData = coopUpGrateViewParams.ActivityData;
			this.RoleId = new int?(coopUpGrateViewParams.RoleId);
			if (this.RoleId != null && this.RoleId.Value != 0)
			{
				CoopRole? coopRoleConfigByRoleId = CoopConfig.Instance.GetCoopRoleConfigByRoleId(this.RoleId.Value);
				if (!string.IsNullOrEmpty((coopRoleConfigByRoleId != null) ? coopRoleConfigByRoleId.GetValueOrDefault().LevelUpRolePortrait : null))
				{
					base.SetTextureByPath(coopRoleConfigByRoleId.Value.LevelUpRolePortrait, base.GetTexture(0), null, null);
				}
				CoopActivityData activityData = this.ActivityData;
				int? num = (activityData != null) ? new int?(activityData.GetRoleCurCoopLevelId(this.RoleId.Value)) : null;
				if (num != null)
				{
					int? num2 = num;
					int num3 = 0;
					if (!(num2.GetValueOrDefault() == num3 & num2 != null))
					{
						CoopRoleLevel? coopConfigById = CoopConfig.Instance.GetCoopConfigById(num.Value);
						if (!string.IsNullOrEmpty((coopConfigById != null) ? coopConfigById.GetValueOrDefault().LevelUpText : null))
						{
							LguiUtil.Instance.SetLocalTextNew(base.GetText(8), coopConfigById.Value.LevelUpText, Array.Empty<object>());
						}
						if (!string.IsNullOrEmpty((coopConfigById != null) ? coopConfigById.GetValueOrDefault().LevelUpTitleText : null))
						{
							LguiUtil.Instance.SetLocalTextNew(base.GetText(7), coopConfigById.Value.LevelUpTitleText, Array.Empty<object>());
							goto IL_19F;
						}
						goto IL_19F;
					}
				}
				return;
			}
			IL_19F:
			this.RefreshLevelTogItemList();
		}

		// Token: 0x06042FF6 RID: 274422 RVA: 0x01051CB8 File Offset: 0x0104FEB8
		private void RefreshLevelTogItemList()
		{
			if (this.RoleId == null || this.RoleId.Value == 0)
			{
				return;
			}
			CoopActivityData activityData = this.ActivityData;
			CoopRoleData coopRoleData = (activityData != null) ? activityData.GetRoleData(this.RoleId.Value) : null;
			if (coopRoleData == null)
			{
				return;
			}
			ECoopLvUpShowType levelUpViewShowType = coopRoleData.LevelUpViewShowType;
			List<CoopLevelData> coopLevelDataList = coopRoleData.GetCoopLevelDataList();
			if (levelUpViewShowType == ECoopLvUpShowType.OneLevel)
			{
				this.RefreshOneLevelTogItem(coopLevelDataList);
				return;
			}
			if (levelUpViewShowType != ECoopLvUpShowType.FiveLevel)
			{
				return;
			}
			this.RefreshFiveLevelTogItem(coopLevelDataList);
		}

		// Token: 0x06042FF7 RID: 274423 RVA: 0x01051D28 File Offset: 0x0104FF28
		[NullableContext(1)]
		private void RefreshOneLevelTogItem(List<CoopLevelData> levelDataList)
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(4).SetUIActive(true);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			if (levelDataList.Count > 0)
			{
				this.LevelTogItem3.RefreshView(levelDataList[0]);
			}
		}

		// Token: 0x06042FF8 RID: 274424 RVA: 0x01051D94 File Offset: 0x0104FF94
		[NullableContext(1)]
		private void RefreshFiveLevelTogItem(List<CoopLevelData> levelDataList)
		{
			base.GetItem(2).SetUIActive(true);
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(true);
			base.GetItem(5).SetUIActive(true);
			base.GetItem(6).SetUIActive(true);
			for (int i = 0; i < levelDataList.Count; i++)
			{
				CoopLevelData levelData = levelDataList[i];
				this.LevelTogItemList[i].RefreshView(levelData);
			}
		}

		// Token: 0x06042FF9 RID: 274425 RVA: 0x01051E10 File Offset: 0x01050010
		protected void OnClickGoBtn()
		{
			CoopActivityData activityData = this.ActivityData;
			int? num = (activityData != null) ? new int?(activityData.GetRoleCurCoopLevel(this.RoleId.Value)) : null;
			CoopActivityData activityData2 = this.ActivityData;
			int? num2 = (activityData2 != null) ? new int?(activityData2.GetRoleCurCoopLevelId(this.RoleId.Value)) : null;
			CoopRoleSelectViewParams param = new CoopRoleSelectViewParams
			{
				ActivityData = this.ActivityData,
				Index = this.ActivityData.GetRoleIndexByRoleId(this.RoleId.Value),
				Level = num.Value,
				LevelId = num2.Value,
				IsOpenByUpGradeView = true
			};
			base.CloseMe(null);
			UiManager.Instance.OpenView(EUiViewName.CoopRoleSelectView, param, null);
		}

		// Token: 0x04022E10 RID: 142864
		private CoopActivityData ActivityData;

		// Token: 0x04022E11 RID: 142865
		private int? RoleId;

		// Token: 0x04022E12 RID: 142866
		private CoopUpLevelTogItem LevelTogItem1;

		// Token: 0x04022E13 RID: 142867
		private CoopUpLevelTogItem LevelTogItem2;

		// Token: 0x04022E14 RID: 142868
		private CoopUpLevelTogItem LevelTogItem3;

		// Token: 0x04022E15 RID: 142869
		private CoopUpLevelTogItem LevelTogItem4;

		// Token: 0x04022E16 RID: 142870
		private CoopUpLevelTogItem LevelTogItem5;

		// Token: 0x04022E17 RID: 142871
		[Nullable(1)]
		private List<CoopUpLevelTogItem> LevelTogItemList = new List<CoopUpLevelTogItem>();
	}
}
