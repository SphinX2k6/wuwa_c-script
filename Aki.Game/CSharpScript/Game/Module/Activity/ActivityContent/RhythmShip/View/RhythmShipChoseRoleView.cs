using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x0200621E RID: 25118
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipChoseRoleView : UiViewBase
	{
		// Token: 0x0603F5B9 RID: 259513 RVA: 0x00F50662 File Offset: 0x00F4E862
		public RhythmShipChoseRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F5BA RID: 259514 RVA: 0x00F5066C File Offset: 0x00F4E86C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn))
			};
		}

		// Token: 0x0603F5BB RID: 259515 RVA: 0x00F50718 File Offset: 0x00F4E918
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipChoseRoleView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipChoseRoleView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F5BC RID: 259516 RVA: 0x00F5075C File Offset: 0x00F4E95C
		protected override void OnStart()
		{
			RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			this.CurrentSelectRole = activityData.CurrentRole;
			this.RoleLayout = new GenericLayout<RhythmShipChoseRoleItem, int>(base.GetHorizontalLayout(1), new Func<RhythmShipChoseRoleItem>(this.InitRoleItem), null, false, true);
			List<int> data = RhythmShipConfig.Instance.GetRhythmRoleAll() ?? new List<int>();
			this.RoleLayout.RefreshByData(data, delegate
			{
				GenericLayout<RhythmShipChoseRoleItem, int> roleLayout = this.RoleLayout;
				foreach (RhythmShipChoseRoleItem rhythmShipChoseRoleItem in (((roleLayout != null) ? roleLayout.GetLayoutItemList() : null) ?? new List<RhythmShipChoseRoleItem>()))
				{
					rhythmShipChoseRoleItem.SetCurrentLevelSelectState(rhythmShipChoseRoleItem.RoleId == this.CurrentSelectRole);
				}
			}, true);
		}

		// Token: 0x0603F5BD RID: 259517 RVA: 0x00F507D2 File Offset: 0x00F4E9D2
		private RhythmShipChoseRoleItem InitRoleItem()
		{
			return new RhythmShipChoseRoleItem
			{
				OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickRoleItem)
			};
		}

		// Token: 0x0603F5BE RID: 259518 RVA: 0x00F507EB File Offset: 0x00F4E9EB
		[NullableContext(2)]
		private void OnClickRoleItem(int roleId, UUIExtendToggle toggle)
		{
			UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
			if (currentSelectToggle != null)
			{
				currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.CurrentSelectToggle = toggle;
			this.CurrentSelectRole = roleId;
		}

		// Token: 0x0603F5BF RID: 259519 RVA: 0x00F50814 File Offset: 0x00F4EA14
		private void OnClickConfirmBtn()
		{
			if (this.CurrentSelectRole != 0)
			{
				int currentSelectRole = this.CurrentSelectRole;
				RhythmShipData activityData = RhythmShipModel.Instance.ActivityData;
				int? num = (activityData != null) ? new int?(activityData.CurrentRole) : null;
				if (!(currentSelectRole == num.GetValueOrDefault() & num != null))
				{
					RhythmShipController.Instance.RhythmChangePartnerRoleRequest(this.CurrentSelectRole);
				}
			}
			base.CloseMe(null);
		}

		// Token: 0x0603F5C0 RID: 259520 RVA: 0x00F50880 File Offset: 0x00F4EA80
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams[0] == "RoleItem")
			{
				int num = int.Parse(configParams[1]);
				if (num >= 0)
				{
					int num2 = num;
					GenericLayout<RhythmShipChoseRoleItem, int> roleLayout = this.RoleLayout;
					if (num2 < ((roleLayout != null) ? roleLayout.GetLayoutItemList().Count : 0))
					{
						GenericLayout<RhythmShipChoseRoleItem, int> roleLayout2 = this.RoleLayout;
						UUIItem uuiitem = (roleLayout2 != null) ? roleLayout2.GetItemByIndex(num) : null;
						if (uuiitem == null)
						{
							return null;
						}
						return new UUIItem[]
						{
							uuiitem,
							uuiitem
						};
					}
				}
			}
			return null;
		}

		// Token: 0x04021110 RID: 135440
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021111 RID: 135441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RhythmShipChoseRoleItem, int> RoleLayout;

		// Token: 0x04021112 RID: 135442
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x04021113 RID: 135443
		private int CurrentSelectRole;
	}
}
