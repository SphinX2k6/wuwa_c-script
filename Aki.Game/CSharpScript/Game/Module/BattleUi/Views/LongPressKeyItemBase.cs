using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D63 RID: 23907
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class LongPressKeyItemBase : KeyItemBase
	{
		// Token: 0x0603CB2B RID: 248619 RVA: 0x00E92FDF File Offset: 0x00E911DF
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

		// Token: 0x0603CB2C RID: 248620 RVA: 0x00E93017 File Offset: 0x00E91217
		public void ForceShowLongPress()
		{
			this.LongPressTime = 0f;
			this.SetLongPressItemVisible(true);
			this.SetLongPressPercent(100f);
		}

		// Token: 0x0603CB2D RID: 248621 RVA: 0x00E93036 File Offset: 0x00E91236
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

		// Token: 0x0603CB2E RID: 248622 RVA: 0x00E93060 File Offset: 0x00E91260
		protected override void OnBeforeDestroy()
		{
			this.DeactivateLongPressRefresh();
		}

		// Token: 0x0603CB2F RID: 248623 RVA: 0x00E93068 File Offset: 0x00E91268
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

		// Token: 0x0603CB30 RID: 248624 RVA: 0x00E9308C File Offset: 0x00E9128C
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

		// Token: 0x0603CB31 RID: 248625 RVA: 0x00E930E6 File Offset: 0x00E912E6
		private void ActivateLongPressRefresh()
		{
			this.PressTime = 0f;
			this.SetLongPressPercent(0f);
			this.IsPress = true;
		}

		// Token: 0x0603CB32 RID: 248626 RVA: 0x00E93105 File Offset: 0x00E91305
		private void DeactivateLongPressRefresh()
		{
			this.PressTime = 0f;
			this.SetLongPressPercent(0f);
			this.IsPress = false;
		}

		// Token: 0x0603CB33 RID: 248627 RVA: 0x00E93124 File Offset: 0x00E91324
		private void SetLongPressItemVisible(bool bVisible)
		{
			UUIItem longPressItem = this.GetLongPressItem();
			if (longPressItem == null)
			{
				return;
			}
			longPressItem.SetUIActive(bVisible);
		}

		// Token: 0x0603CB34 RID: 248628 RVA: 0x00E93137 File Offset: 0x00E91337
		private void SetLongPressPercent(float percent)
		{
			UUITexture longPressTexture = this.GetLongPressTexture();
			if (longPressTexture == null)
			{
				return;
			}
			longPressTexture.SetFillAmount(percent);
		}

		// Token: 0x0603CB35 RID: 248629
		protected abstract override UUIText GetKeyText();

		// Token: 0x0603CB36 RID: 248630
		protected abstract override UUITexture GetKeyTexture();

		// Token: 0x0603CB37 RID: 248631
		protected abstract UUITexture GetLongPressTexture();

		// Token: 0x0603CB38 RID: 248632
		protected abstract UUIItem GetLongPressItem();

		// Token: 0x0401F9E8 RID: 129512
		private float LongPressTime;

		// Token: 0x0401F9E9 RID: 129513
		private float PressTime;

		// Token: 0x0401F9EA RID: 129514
		private bool IsPress;
	}
}
