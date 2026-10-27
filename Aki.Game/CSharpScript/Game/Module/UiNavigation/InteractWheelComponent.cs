using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004980 RID: 18816
	public class InteractWheelComponent : HotKeyComponent
	{
		// Token: 0x060310D5 RID: 200917 RVA: 0x00B62B8B File Offset: 0x00B60D8B
		public InteractWheelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310D6 RID: 200918 RVA: 0x00B62B94 File Offset: 0x00B60D94
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

		// Token: 0x060310D7 RID: 200919 RVA: 0x00B62C4B File Offset: 0x00B60E4B
		protected override void OnRefreshMode()
		{
			this.CurComponent.SetNeedRefreshKeyName(false);
			base.OnRefreshMode();
		}

		// Token: 0x060310D8 RID: 200920 RVA: 0x00B62C60 File Offset: 0x00B60E60
		public bool UpdateIndex(int totalNum)
		{
			int indexInternal = this.IndexInternal;
			this.UpdateIndexInternal(totalNum);
			return this.IndexInternal != indexInternal;
		}

		// Token: 0x060310D9 RID: 200921 RVA: 0x00B62C88 File Offset: 0x00B60E88
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

		// Token: 0x0401A4A1 RID: 107681
		private const int ZOOM_THRESHOLD = 1;

		// Token: 0x0401A4A2 RID: 107682
		private int TotalNumInternal;

		// Token: 0x0401A4A3 RID: 107683
		private int IndexInternal;

		// Token: 0x0401A4A4 RID: 107684
		private float ZoomValue;

		// Token: 0x0401A4A5 RID: 107685
		protected new bool IsPress;

		// Token: 0x0401A4A6 RID: 107686
		private readonly bool AllowLoop;
	}
}
