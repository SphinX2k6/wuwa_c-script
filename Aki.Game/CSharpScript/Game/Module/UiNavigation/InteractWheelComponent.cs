using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F8 RID: 14584
	public class InteractWheelComponent : HotKeyComponent
	{
		// Token: 0x06025C05 RID: 154629 RVA: 0x00A9DA8B File Offset: 0x00A9BC8B
		public InteractWheelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C06 RID: 154630 RVA: 0x00A9DA94 File Offset: 0x00A9BC94
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			float num = -value;
			if (this.ZoomValue * num < 0f)
			{
				this.ZoomValue = 0f;
			}
			this.ZoomValue += num;
			float num2 = (float)((num > 0f) ? 1 : -1) * (float)Math.Floor((double)Math.Abs(this.ZoomValue / 1f));
			this.ZoomValue -= 1f * num2;
			bool flag = value != 0f;
			if (this.IsPress == flag)
			{
				return;
			}
			this.IsPress = flag;
			if (value > 0f)
			{
				UiNavigationNewController.Instance.FindTarget(ELGUINavigationDirection.Prev);
				return;
			}
			if (value < 0f)
			{
				UiNavigationNewController.Instance.FindTarget(ELGUINavigationDirection.Next);
			}
		}

		// Token: 0x06025C07 RID: 154631 RVA: 0x00A9DB4B File Offset: 0x00A9BD4B
		protected override void OnRefreshMode()
		{
			this.CurComponent.SetNeedRefreshKeyName(false);
			base.OnRefreshMode();
		}

		// Token: 0x06025C08 RID: 154632 RVA: 0x00A9DB60 File Offset: 0x00A9BD60
		public bool UpdateIndex(int totalNum)
		{
			int indexInternal = this.IndexInternal;
			this.UpdateIndexInternal(totalNum);
			return this.IndexInternal != indexInternal;
		}

		// Token: 0x06025C09 RID: 154633 RVA: 0x00A9DB88 File Offset: 0x00A9BD88
		private void UpdateIndexInternal(int totalNum)
		{
			if (totalNum != 0)
			{
				this.TotalNumInternal = totalNum;
			}
			if (this.TotalNumInternal == 0)
			{
				return;
			}
			if (this.IndexInternal < 0 || this.IndexInternal >= this.TotalNumInternal)
			{
				if (!this.AllowLoop)
				{
					this.IndexInternal = Math.Max(0, Math.Min(this.IndexInternal, this.TotalNumInternal - 1));
					return;
				}
				this.IndexInternal %= this.TotalNumInternal;
				if (this.IndexInternal < 0)
				{
					this.IndexInternal = this.TotalNumInternal + this.IndexInternal;
				}
			}
		}

		// Token: 0x04014D14 RID: 85268
		private const int ZOOM_THRESHOLD = 1;

		// Token: 0x04014D15 RID: 85269
		private int TotalNumInternal;

		// Token: 0x04014D16 RID: 85270
		private int IndexInternal;

		// Token: 0x04014D17 RID: 85271
		private float ZoomValue;

		// Token: 0x04014D18 RID: 85272
		protected new bool IsPress;

		// Token: 0x04014D19 RID: 85273
		private readonly bool AllowLoop;
	}
}
