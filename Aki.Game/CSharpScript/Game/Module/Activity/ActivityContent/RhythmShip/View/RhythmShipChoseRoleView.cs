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
	// Token: 0x0200519C RID: 20892
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipChoseRoleView : UiViewBase
	{
		// Token: 0x0603427A RID: 213626 RVA: 0x00E975BA File Offset: 0x00E957BA
		public RhythmShipChoseRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603427B RID: 213627 RVA: 0x00E975C4 File Offset: 0x00E957C4
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

		// Token: 0x0603427C RID: 213628 RVA: 0x00E97670 File Offset: 0x00E95870
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipChoseRoleView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipChoseRoleView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603427D RID: 213629 RVA: 0x00E976B4 File Offset: 0x00E958B4
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

		// Token: 0x0603427E RID: 213630 RVA: 0x00E9772A File Offset: 0x00E9592A
		private RhythmShipChoseRoleItem InitRoleItem()
		{
			return new RhythmShipChoseRoleItem
			{
				OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickRoleItem)
			};
		}

		// Token: 0x0603427F RID: 213631 RVA: 0x00E97743 File Offset: 0x00E95943
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

		// Token: 0x06034280 RID: 213632 RVA: 0x00E9776C File Offset: 0x00E9596C
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

		// Token: 0x06034281 RID: 213633 RVA: 0x00E977D8 File Offset: 0x00E959D8
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

		// Token: 0x0401BA3F RID: 113215
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BA40 RID: 113216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RhythmShipChoseRoleItem, int> RoleLayout;

		// Token: 0x0401BA41 RID: 113217
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectToggle;

		// Token: 0x0401BA42 RID: 113218
		private int CurrentSelectRole;
	}
}
