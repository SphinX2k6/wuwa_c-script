using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoLinkage
{
	// Token: 0x020053D1 RID: 21457
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorLinkageButton : UiPanelBase
	{
		// Token: 0x0603558E RID: 218510 RVA: 0x00EE6E54 File Offset: 0x00EE5054
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

		// Token: 0x0603558F RID: 218511 RVA: 0x00EE6EE8 File Offset: 0x00EE50E8
		protected override void OnStart()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.OnPointEnterCallBack.Bind(new Action(this.OnButtonEnter));
				button.OnPointExitCallBack.Bind(new Action(this.OnButtonExit));
			}
		}

		// Token: 0x06035590 RID: 218512 RVA: 0x00EE6F2E File Offset: 0x00EE512E
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x06035591 RID: 218513 RVA: 0x00EE6F38 File Offset: 0x00EE5138
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

		// Token: 0x06035592 RID: 218514 RVA: 0x00EE6FC0 File Offset: 0x00EE51C0
		public void SetIpId(int ipId)
		{
			this.IpId = ipId;
		}

		// Token: 0x06035593 RID: 218515 RVA: 0x00EE6FC9 File Offset: 0x00EE51C9
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06035594 RID: 218516 RVA: 0x00EE6FD2 File Offset: 0x00EE51D2
		public void SetEnterCallback(Action<int> callback)
		{
			this.EnterCallback = callback;
		}

		// Token: 0x06035595 RID: 218517 RVA: 0x00EE6FDB File Offset: 0x00EE51DB
		public void SetExitCallback(Action callback)
		{
			this.ExitCallback = callback;
		}

		// Token: 0x06035596 RID: 218518 RVA: 0x00EE6FE4 File Offset: 0x00EE51E4
		private void OnButtonClick()
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.IpId);
		}

		// Token: 0x06035597 RID: 218519 RVA: 0x00EE6FFC File Offset: 0x00EE51FC
		private void OnButtonEnter()
		{
			Action<int> enterCallback = this.EnterCallback;
			if (enterCallback == null)
			{
				return;
			}
			enterCallback(this.IpId);
		}

		// Token: 0x06035598 RID: 218520 RVA: 0x00EE7014 File Offset: 0x00EE5214
		private void OnButtonExit()
		{
			Action exitCallback = this.ExitCallback;
			if (exitCallback == null)
			{
				return;
			}
			exitCallback();
		}

		// Token: 0x0401C24B RID: 115275
		private int IpId;

		// Token: 0x0401C24C RID: 115276
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0401C24D RID: 115277
		[Nullable(2)]
		private Action<int> EnterCallback;

		// Token: 0x0401C24E RID: 115278
		[Nullable(2)]
		private Action ExitCallback;
	}
}
