using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D45 RID: 19781
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class LongPressKeyItemBase : KeyItemBase
	{
		// Token: 0x06031A86 RID: 203398 RVA: 0x00DE381B File Offset: 0x00DE1A1B
		[NullableContext(1)]
		public void RefreshActionLongPress(string actionName, float longPressTime = 0f)
		{
			if (this.ActionName == actionName)
			{
				return;
			}
			this.LongPressTime = longPressTime;
			this.RefreshAction(actionName);
			this.SetLongPressItemVisible(longPressTime > 0f);
			this.SetLongPressPercent(0f);
		}

		// Token: 0x06031A87 RID: 203399 RVA: 0x00DE3853 File Offset: 0x00DE1A53
		public void ForceShowLongPress()
		{
			this.LongPressTime = 0f;
			this.SetLongPressItemVisible(true);
			this.SetLongPressPercent(100f);
		}

		// Token: 0x06031A88 RID: 203400 RVA: 0x00DE3872 File Offset: 0x00DE1A72
		[NullableContext(1)]
		public override void RefreshAxis(string axisName)
		{
			if (this.AxisName == axisName)
			{
				return;
			}
			this.LongPressTime = 0f;
			this.SetLongPressItemVisible(false);
			base.RefreshAxis(axisName);
		}

		// Token: 0x06031A89 RID: 203401 RVA: 0x00DE389C File Offset: 0x00DE1A9C
		protected override void OnBeforeDestroy()
		{
			this.DeactivateLongPressRefresh();
		}

		// Token: 0x06031A8A RID: 203402 RVA: 0x00DE38A4 File Offset: 0x00DE1AA4
		[NullableContext(1)]
		protected override void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType)
		{
			if (!this.IsEnable)
			{
				this.DeactivateLongPressRefresh();
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				this.ActivateLongPressRefresh();
				return;
			}
			this.DeactivateLongPressRefresh();
		}

		// Token: 0x06031A8B RID: 203403 RVA: 0x00DE38C8 File Offset: 0x00DE1AC8
		public void Tick(float delta)
		{
			if (!this.IsPress)
			{
				return;
			}
			if (!this.IsEnable)
			{
				this.DeactivateLongPressRefresh();
				return;
			}
			this.PressTime += delta;
			this.SetLongPressPercent(this.PressTime / this.LongPressTime);
			if (this.PressTime >= this.LongPressTime)
			{
				this.DeactivateLongPressRefresh();
			}
		}

		// Token: 0x06031A8C RID: 203404 RVA: 0x00DE3922 File Offset: 0x00DE1B22
		private void ActivateLongPressRefresh()
		{
			this.PressTime = 0f;
			this.SetLongPressPercent(0f);
			this.IsPress = true;
		}

		// Token: 0x06031A8D RID: 203405 RVA: 0x00DE3941 File Offset: 0x00DE1B41
		private void DeactivateLongPressRefresh()
		{
			this.PressTime = 0f;
			this.SetLongPressPercent(0f);
			this.IsPress = false;
		}

		// Token: 0x06031A8E RID: 203406 RVA: 0x00DE3960 File Offset: 0x00DE1B60
		private void SetLongPressItemVisible(bool bVisible)
		{
			UUIItem longPressItem = this.GetLongPressItem();
			if (longPressItem == null)
			{
				return;
			}
			longPressItem.SetUIActive(bVisible);
		}

		// Token: 0x06031A8F RID: 203407 RVA: 0x00DE3973 File Offset: 0x00DE1B73
		private void SetLongPressPercent(float percent)
		{
			UUITexture longPressTexture = this.GetLongPressTexture();
			if (longPressTexture == null)
			{
				return;
			}
			longPressTexture.SetFillAmount(percent);
		}

		// Token: 0x06031A90 RID: 203408
		protected abstract override UUIText GetKeyText();

		// Token: 0x06031A91 RID: 203409
		protected abstract override UUITexture GetKeyTexture();

		// Token: 0x06031A92 RID: 203410
		protected abstract UUITexture GetLongPressTexture();

		// Token: 0x06031A93 RID: 203411
		protected abstract UUIItem GetLongPressItem();

		// Token: 0x0401A4A0 RID: 107680
		private float LongPressTime;

		// Token: 0x0401A4A1 RID: 107681
		private float PressTime;

		// Token: 0x0401A4A2 RID: 107682
		private bool IsPress;
	}
}
