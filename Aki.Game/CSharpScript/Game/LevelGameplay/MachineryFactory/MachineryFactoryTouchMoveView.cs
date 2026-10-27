using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.MachineryFactory
{
	// Token: 0x02006AC4 RID: 27332
	[NullableContext(2)]
	[Nullable(0)]
	public class MachineryFactoryTouchMoveView : UiViewBase
	{
		// Token: 0x06043EA0 RID: 278176 RVA: 0x010A6A93 File Offset: 0x010A4C93
		[NullableContext(1)]
		public MachineryFactoryTouchMoveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043EA1 RID: 278177 RVA: 0x010A6AA8 File Offset: 0x010A4CA8
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

		// Token: 0x06043EA2 RID: 278178 RVA: 0x010A6B70 File Offset: 0x010A4D70
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

		// Token: 0x06043EA3 RID: 278179 RVA: 0x010A6C04 File Offset: 0x010A4E04
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

		// Token: 0x06043EA4 RID: 278180 RVA: 0x010A6C8F File Offset: 0x010A4E8F
		protected override void OnBeforeDestroy()
		{
			if (this.DelayClickHandle != null)
			{
				TimerSystem.Instance.Remove(this.DelayClickHandle);
				this.DelayClickHandle = null;
			}
		}

		// Token: 0x06043EA5 RID: 278181 RVA: 0x010A6CB1 File Offset: 0x010A4EB1
		private void OnButtonClick()
		{
			this.ClickCount++;
			this.RefreshTitle();
		}

		// Token: 0x040237CE RID: 145358
		private UUIItem PnlMask;

		// Token: 0x040237CF RID: 145359
		private UUIText TxtTitle;

		// Token: 0x040237D0 RID: 145360
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<string> TextKeys = new List<string>();

		// Token: 0x040237D1 RID: 145361
		private int ClickCount;

		// Token: 0x040237D2 RID: 145362
		private UUIButtonComponent BtnProceed;

		// Token: 0x040237D3 RID: 145363
		private TimerHandle DelayClickHandle;

		// Token: 0x0200CBA8 RID: 52136
		[NullableContext(0)]
		private enum EViewComponent
		{
			// Token: 0x0403D788 RID: 251784
			PnlMask,
			// Token: 0x0403D789 RID: 251785
			TxtTitle,
			// Token: 0x0403D78A RID: 251786
			BtnProceed
		}
	}
}
