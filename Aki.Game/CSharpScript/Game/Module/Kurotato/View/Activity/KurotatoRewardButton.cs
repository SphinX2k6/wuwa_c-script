using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02005790 RID: 22416
	public class KurotatoRewardButton : UiPanelBase
	{
		// Token: 0x06038F01 RID: 233217 RVA: 0x00D88928 File Offset: 0x00D86B28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038F02 RID: 233218 RVA: 0x00D88A52 File Offset: 0x00D86C52
		public void SetLimitTimeTextShow(bool isShow)
		{
			base.GetItem(5).SetUIActive(isShow);
		}

		// Token: 0x06038F03 RID: 233219 RVA: 0x00D88A61 File Offset: 0x00D86C61
		[NullableContext(1)]
		public void SetLimitTimeText(string text)
		{
			base.GetText(4).SetText(text, true);
		}

		// Token: 0x06038F04 RID: 233220 RVA: 0x00D88A74 File Offset: 0x00D86C74
		public void SetProgressNumText(int curNum, int totalNum)
		{
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(curNum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06038F05 RID: 233221 RVA: 0x00D88ABC File Offset: 0x00D86CBC
		public void SetRedDotShow(bool isShow)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isShow);
			}
		}

		// Token: 0x06038F06 RID: 233222 RVA: 0x00D88ADB File Offset: 0x00D86CDB
		private void OnClickBtn()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401DD85 RID: 122245
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200B9B8 RID: 47544
		protected enum ERewardBtnComponent
		{
			// Token: 0x04038274 RID: 230004
			RootBtn,
			// Token: 0x04038275 RID: 230005
			TxtNum,
			// Token: 0x04038276 RID: 230006
			RedDot,
			// Token: 0x04038277 RID: 230007
			TxtName,
			// Token: 0x04038278 RID: 230008
			TxtTime,
			// Token: 0x04038279 RID: 230009
			PanelTime
		}
	}
}
