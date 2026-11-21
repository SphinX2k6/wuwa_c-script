using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B8 RID: 22712
	public class SolarSchoolGiveGiftAction : SolarSchoolActionBase
	{
		// Token: 0x06037F02 RID: 229122 RVA: 0x00FA2AF3 File Offset: 0x00FA0CF3
		[NullableContext(1)]
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.RoleId = ActivityActionBase.GetParamInt(parameters, "SolarSchoolRoleId", this.RoleId);
		}

		// Token: 0x06037F03 RID: 229123 RVA: 0x00FA2B0C File Offset: 0x00FA0D0C
		protected unsafe override void OnStart()
		{
			SolarSchoolFriendData friendData = SolarSchoolGamePlayModel.Instance.FriendData;
			if (this.RoleId <= 0 || SolarSchoolConfig.Instance.GetRole(this.RoleId) == null || !friendData.IsRoleUnlocked(this.RoleId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 赠礼 Action 角色参数非法或角色未解锁";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("roleId", this.RoleId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				base.MarkFailed();
				return;
			}
			SolarSchoolBagGiftParam param = new SolarSchoolBagGiftParam(this.RoleId, new Func<int, int>(this.OnGiftSelected), new Action(this.OnGiftViewClosed));
			this.ViewOpened = true;
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolBagView, param, null);
		}

		// Token: 0x06037F04 RID: 229124 RVA: 0x00FA2C04 File Offset: 0x00FA0E04
		private int OnGiftSelected(int itemId)
		{
			if (!base.IsRunning())
			{
				return 0;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolFriendData friendData = instance.FriendData;
			if (friendData.IsFavorFrozen(this.RoleId))
			{
				string conditionHintText = SolarSchoolUtils.GetConditionHintText(friendData.GetNextLevelPreUnlockConditionId(this.RoleId));
				ScrollingTipsController.Instance.ShowTipsByText(conditionHintText);
				return 0;
			}
			if (friendData.GetFavor(this.RoleId) >= friendData.GetCurrentLevelFavorCap(this.RoleId))
			{
				SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(this.RoleId);
				ScrollingTipsController.Instance.ShowTipsByTextId(friendData.IsFavorLevelMaxed(this.RoleId) ? "SolarSchool_FondnessOver2" : "SolarSchool_FondnessOver", new object[]
				{
					new TableTextArgNew((role != null) ? role.GetValueOrDefault().Name : null, Array.Empty<object>())
				});
				return 0;
			}
			return instance.GiveGift(itemId, this.RoleId);
		}

		// Token: 0x06037F05 RID: 229125 RVA: 0x00FA2CE2 File Offset: 0x00FA0EE2
		private void OnGiftViewClosed()
		{
			this.ViewOpened = false;
			base.MarkDone();
		}

		// Token: 0x06037F06 RID: 229126 RVA: 0x00FA2CF1 File Offset: 0x00FA0EF1
		protected override void OnDelete()
		{
			this.CloseOpenedView();
		}

		// Token: 0x06037F07 RID: 229127 RVA: 0x00FA2CF9 File Offset: 0x00FA0EF9
		private void CloseOpenedView()
		{
			if (!this.ViewOpened)
			{
				return;
			}
			this.ViewOpened = false;
			UiManager.Instance.CloseView(EUiViewName.SolarSchoolBagView, null);
		}

		// Token: 0x0401D81A RID: 120858
		private int RoleId;

		// Token: 0x0401D81B RID: 120859
		private bool ViewOpened;
	}
}
