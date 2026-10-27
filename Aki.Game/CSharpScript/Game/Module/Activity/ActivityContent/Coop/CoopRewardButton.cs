using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068D4 RID: 26836
	public class CoopRewardButton : UiPanelBase
	{
		// Token: 0x06042F65 RID: 274277 RVA: 0x0104EBF8 File Offset: 0x0104CDF8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn))
			};
		}

		// Token: 0x06042F66 RID: 274278 RVA: 0x0104EC8C File Offset: 0x0104CE8C
		public void SetRedDotShow(bool isShow)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(isShow);
			}
		}

		// Token: 0x06042F67 RID: 274279 RVA: 0x0104ECAC File Offset: 0x0104CEAC
		public void RefreshRewardCount(int receivedCount)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(receivedCount);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}

		// Token: 0x06042F68 RID: 274280 RVA: 0x0104ECE3 File Offset: 0x0104CEE3
		private void OnClickBtn()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x04022D75 RID: 142709
		[Nullable(2)]
		public Action ClickCallback;
	}
}
