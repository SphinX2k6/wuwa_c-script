using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200577B RID: 22395
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOutBackpackTouchInput
	{
		// Token: 0x06037440 RID: 226368 RVA: 0x00F6E24D File Offset: 0x00F6C44D
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

		// Token: 0x06037441 RID: 226369 RVA: 0x00F6E28C File Offset: 0x00F6C48C
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

		// Token: 0x06037442 RID: 226370 RVA: 0x00F6E321 File Offset: 0x00F6C521
		public void Reset()
		{
			this.FirstItem = null;
			this.FirstPointerId = 0;
			this.InMultiTouch = false;
			this.MultiTouchEndTime = double.NegativeInfinity;
		}

		// Token: 0x06037443 RID: 226371 RVA: 0x00F6E347 File Offset: 0x00F6C547
		private void EnterMultiTouch()
		{
			this.InMultiTouch = true;
			this.FirstItem = null;
		}

		// Token: 0x0401D322 RID: 119586
		private const double MultiTouchCoolDownSeconds = 0.5;

		// Token: 0x0401D323 RID: 119587
		[Nullable(2)]
		private DangoBrawlOutBackpackItemBase FirstItem;

		// Token: 0x0401D324 RID: 119588
		private int FirstPointerId;

		// Token: 0x0401D325 RID: 119589
		private bool InMultiTouch;

		// Token: 0x0401D326 RID: 119590
		private double MultiTouchEndTime = double.NegativeInfinity;
	}
}
