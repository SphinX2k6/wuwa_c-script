using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004767 RID: 18279
	public class KurotatoRewardButton : UiPanelBase
	{
		// Token: 0x0602DE11 RID: 187921 RVA: 0x00CD7678 File Offset: 0x00CD5878
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

		// Token: 0x0602DE12 RID: 187922 RVA: 0x00CD77A2 File Offset: 0x00CD59A2
		public void SetLimitTimeTextShow(bool isShow)
		{
			base.GetItem(5).SetUIActive(isShow);
		}

		// Token: 0x0602DE13 RID: 187923 RVA: 0x00CD77B1 File Offset: 0x00CD59B1
		[NullableContext(1)]
		public void SetLimitTimeText(string text)
		{
			base.GetText(4).SetText(text, true);
		}

		// Token: 0x0602DE14 RID: 187924 RVA: 0x00CD77C4 File Offset: 0x00CD59C4
		public void SetProgressNumText(int curNum, int totalNum)
		{
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(curNum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalNum);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602DE15 RID: 187925 RVA: 0x00CD780C File Offset: 0x00CD5A0C
		public void SetRedDotShow(bool isShow)
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(isShow);
			}
		}

		// Token: 0x0602DE16 RID: 187926 RVA: 0x00CD782B File Offset: 0x00CD5A2B
		private void OnClickBtn()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401881B RID: 100379
		[Nullable(2)]
		public Action ClickCallback;

		// Token: 0x0200A3CE RID: 41934
		protected enum ERewardBtnComponent
		{
			// Token: 0x04032C65 RID: 207973
			RootBtn,
			// Token: 0x04032C66 RID: 207974
			TxtNum,
			// Token: 0x04032C67 RID: 207975
			RedDot,
			// Token: 0x04032C68 RID: 207976
			TxtName,
			// Token: 0x04032C69 RID: 207977
			TxtTime,
			// Token: 0x04032C6A RID: 207978
			PanelTime
		}
	}
}
