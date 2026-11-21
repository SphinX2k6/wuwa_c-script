using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x02005824 RID: 22564
	public class CoopRewardButton : UiPanelBase
	{
		// Token: 0x06037ABD RID: 228029 RVA: 0x00F90220 File Offset: 0x00F8E420
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

		// Token: 0x06037ABE RID: 228030 RVA: 0x00F902B4 File Offset: 0x00F8E4B4
		public void SetRedDotShow(bool isShow)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(isShow);
			}
		}

		// Token: 0x06037ABF RID: 228031 RVA: 0x00F902D4 File Offset: 0x00F8E4D4
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

		// Token: 0x06037AC0 RID: 228032 RVA: 0x00F9030B File Offset: 0x00F8E50B
		private void OnClickBtn()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401D5D1 RID: 120273
		[Nullable(2)]
		public Action ClickCallback;
	}
}
