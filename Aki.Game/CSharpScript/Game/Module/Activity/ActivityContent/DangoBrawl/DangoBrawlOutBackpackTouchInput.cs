using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200682B RID: 26667
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackTouchInput
	{
		// Token: 0x060428EC RID: 272620 RVA: 0x0102CD11 File Offset: 0x0102AF11
		public void OnPointerDown(DangoBrawlOutBackpackItemBase item, [Nullable(2)] ULGUIPointerEventData data)
		{
			if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
			{
				this.EnterMultiTouch();
				return;
			}
			if (this.InMultiTouch)
			{
				this.InMultiTouch = false;
			}
			this.FirstItem = item;
			this.FirstPointerId = ((data != null) ? data.pointerID : 0);
		}

		// Token: 0x060428ED RID: 272621 RVA: 0x0102CD50 File Offset: 0x0102AF50
		public bool TryAcceptPointerUp(DangoBrawlOutBackpackItemBase item, [Nullable(2)] ULGUIPointerEventData data)
		{
			int num = (data != null) ? data.pointerID : 0;
			int touchFingerCount = TouchFingerManager.Instance.GetTouchFingerCount();
			double nowSeconds = Time.Instance.NowSeconds;
			if (touchFingerCount > 0)
			{
				this.EnterMultiTouch();
			}
			if (this.InMultiTouch)
			{
				if (touchFingerCount == 0)
				{
					this.InMultiTouch = false;
					this.MultiTouchEndTime = nowSeconds;
				}
				return false;
			}
			if (nowSeconds - this.MultiTouchEndTime < 0.5)
			{
				this.FirstItem = null;
				return false;
			}
			if (this.FirstItem == null || item != this.FirstItem || num != this.FirstPointerId)
			{
				return false;
			}
			this.FirstItem = null;
			return true;
		}

		// Token: 0x060428EE RID: 272622 RVA: 0x0102CDE5 File Offset: 0x0102AFE5
		public void Reset()
		{
			this.FirstItem = null;
			this.FirstPointerId = 0;
			this.InMultiTouch = false;
			this.MultiTouchEndTime = double.NegativeInfinity;
		}

		// Token: 0x060428EF RID: 272623 RVA: 0x0102CE0B File Offset: 0x0102B00B
		private void EnterMultiTouch()
		{
			this.InMultiTouch = true;
			this.FirstItem = null;
		}

		// Token: 0x04022AC5 RID: 142021
		private const double MultiTouchCoolDownSeconds = 0.5;

		// Token: 0x04022AC6 RID: 142022
		[Nullable(2)]
		private DangoBrawlOutBackpackItemBase FirstItem;

		// Token: 0x04022AC7 RID: 142023
		private int FirstPointerId;

		// Token: 0x04022AC8 RID: 142024
		private bool InMultiTouch;

		// Token: 0x04022AC9 RID: 142025
		private double MultiTouchEndTime = double.NegativeInfinity;
	}
}
