using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.MachineryFactory
{
	// Token: 0x02005C3C RID: 23612
	[NullableContext(2)]
	[Nullable(0)]
	public class MachineryFactoryTouchMoveView : UiViewBase
	{
		// Token: 0x06039FE9 RID: 237545 RVA: 0x01050143 File Offset: 0x0104E343
		[NullableContext(1)]
		public MachineryFactoryTouchMoveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039FEA RID: 237546 RVA: 0x01050158 File Offset: 0x0104E358
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039FEB RID: 237547 RVA: 0x01050220 File Offset: 0x0104E420
		protected override void OnBeforeShow()
		{
			this.PnlMask = base.GetItem(0);
			this.TxtTitle = base.GetText(1);
			this.BtnProceed = base.GetButton(2);
			bool uiactive = LanguageSystem.Instance.PackageLanguage == "zh-Hans" || LanguageSystem.Instance.PackageLanguage == "zh-Hant";
			UUIItem pnlMask = this.PnlMask;
			if (pnlMask != null)
			{
				pnlMask.SetUIActive(uiactive);
			}
			this.TextKeys = (this.OpenParam as List<string>);
			this.ClickCount = 0;
			this.RefreshTitle();
		}

		// Token: 0x06039FEC RID: 237548 RVA: 0x010502B4 File Offset: 0x0104E4B4
		private void RefreshTitle()
		{
			if (this.ClickCount < this.TextKeys.Count)
			{
				string textStringId = this.TextKeys[this.ClickCount];
				LguiUtil.Instance.SetLocalTextNew(this.TxtTitle, textStringId, Array.Empty<object>());
				UUIButtonComponent btnProceed = this.BtnProceed;
				if (btnProceed != null)
				{
					btnProceed.SetSelfInteractive(false);
				}
				this.DelayClickHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					UUIButtonComponent btnProceed2 = this.BtnProceed;
					if (btnProceed2 != null)
					{
						btnProceed2.SetSelfInteractive(true);
					}
					this.DelayClickHandle = null;
				}, 1000f, null, null, true, 1f);
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06039FED RID: 237549 RVA: 0x0105033F File Offset: 0x0104E53F
		protected override void OnBeforeDestroy()
		{
			if (this.DelayClickHandle != null)
			{
				TimerSystem.Instance.Remove(this.DelayClickHandle);
				this.DelayClickHandle = null;
			}
		}

		// Token: 0x06039FEE RID: 237550 RVA: 0x01050361 File Offset: 0x0104E561
		private void OnButtonClick()
		{
			this.ClickCount++;
			this.RefreshTitle();
		}

		// Token: 0x0401EA6E RID: 125550
		private UUIItem PnlMask;

		// Token: 0x0401EA6F RID: 125551
		private UUIText TxtTitle;

		// Token: 0x0401EA70 RID: 125552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> TextKeys = new List<string>();

		// Token: 0x0401EA71 RID: 125553
		private int ClickCount;

		// Token: 0x0401EA72 RID: 125554
		private UUIButtonComponent BtnProceed;

		// Token: 0x0401EA73 RID: 125555
		private TimerHandle DelayClickHandle;

		// Token: 0x0200B799 RID: 47001
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x04038BAB RID: 232363
			PnlMask,
			// Token: 0x04038BAC RID: 232364
			TxtTitle,
			// Token: 0x04038BAD RID: 232365
			BtnProceed
		}
	}
}
