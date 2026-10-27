using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x02006453 RID: 25683
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorLinkageButton : UiPanelBase
	{
		// Token: 0x060408CD RID: 264397 RVA: 0x00F9FED8 File Offset: 0x00F9E0D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick))
			};
		}

		// Token: 0x060408CE RID: 264398 RVA: 0x00F9FF6C File Offset: 0x00F9E16C
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointEnterCallBack.Bind(new Action(this.OnButtonEnter));
				button.OnPointExitCallBack.Bind(new Action(this.OnButtonExit));
			}
		}

		// Token: 0x060408CF RID: 264399 RVA: 0x00F9FFB2 File Offset: 0x00F9E1B2
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x060408D0 RID: 264400 RVA: 0x00F9FFBC File Offset: 0x00F9E1BC
		public void Refresh()
		{
			MotorLinkageIp ipConfig = ActivityMotorLinkageConfig.Instance.GetIpConfig(this.IpId);
			ActivityMotorLinkageData activityData = ActivityMotorLinkageController.Instance.ActivityData;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(activityData.IsStickerReceived(ipConfig.IpStickerList(0)));
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(activityData.IsStickerReceived(ipConfig.IpStickerList(1)));
			}
			bool uiactive = activityData.IpHasAnyRewardCanReceive(this.IpId);
			UUIItem item3 = base.GetItem(3);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(uiactive);
		}

		// Token: 0x060408D1 RID: 264401 RVA: 0x00FA0044 File Offset: 0x00F9E244
		public void SetIpId(int ipId)
		{
			this.IpId = ipId;
		}

		// Token: 0x060408D2 RID: 264402 RVA: 0x00FA004D File Offset: 0x00F9E24D
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x060408D3 RID: 264403 RVA: 0x00FA0056 File Offset: 0x00F9E256
		public void SetEnterCallback(Action<int> callback)
		{
			this.EnterCallback = callback;
		}

		// Token: 0x060408D4 RID: 264404 RVA: 0x00FA005F File Offset: 0x00F9E25F
		public void SetExitCallback(Action callback)
		{
			this.ExitCallback = callback;
		}

		// Token: 0x060408D5 RID: 264405 RVA: 0x00FA0068 File Offset: 0x00F9E268
		private void OnButtonClick()
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.IpId);
		}

		// Token: 0x060408D6 RID: 264406 RVA: 0x00FA0080 File Offset: 0x00F9E280
		private void OnButtonEnter()
		{
			Action<int> enterCallback = this.EnterCallback;
			if (enterCallback == null)
			{
				return;
			}
			enterCallback(this.IpId);
		}

		// Token: 0x060408D7 RID: 264407 RVA: 0x00FA0098 File Offset: 0x00F9E298
		private void OnButtonExit()
		{
			Action exitCallback = this.ExitCallback;
			if (exitCallback == null)
			{
				return;
			}
			exitCallback();
		}

		// Token: 0x0402191C RID: 137500
		private int IpId;

		// Token: 0x0402191D RID: 137501
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0402191E RID: 137502
		[Nullable(2)]
		private Action<int> EnterCallback;

		// Token: 0x0402191F RID: 137503
		[Nullable(2)]
		private Action ExitCallback;
	}
}
