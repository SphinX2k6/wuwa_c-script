using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x02005981 RID: 22913
	[NullableContext(2)]
	[Nullable(0)]
	public class GiantMindsetEntryItem : UiPanelBase
	{
		// Token: 0x0603A247 RID: 238151 RVA: 0x00DD3240 File Offset: 0x00DD1440
		[NullableContext(1)]
		public UniTask Init(UUIItem item)
		{
			GiantMindsetEntryItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GiantMindsetEntryItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603A248 RID: 238152 RVA: 0x00DD328C File Offset: 0x00DD148C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A249 RID: 238153 RVA: 0x00DD3379 File Offset: 0x00DD1579
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnPointUpCallBack.Unbind();
		}

		// Token: 0x0603A24A RID: 238154 RVA: 0x00DD3391 File Offset: 0x00DD1591
		[NullableContext(1)]
		public void SetClickCallback(Action call)
		{
			this.OnClickCall = call;
		}

		// Token: 0x0603A24B RID: 238155 RVA: 0x00DD339C File Offset: 0x00DD159C
		public void Refresh(int level, bool isGot)
		{
			UUIText text = base.GetText(3);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Lv.");
				defaultInterpolatedStringHandler.AppendFormatted<int>(level);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(isGot);
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(!isGot);
		}

		// Token: 0x0603A24C RID: 238156 RVA: 0x00DD3408 File Offset: 0x00DD1608
		public UUIItem GetRedDotItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x0603A24D RID: 238157 RVA: 0x00DD3411 File Offset: 0x00DD1611
		public UUIItem GetTagNewItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0603A24E RID: 238158 RVA: 0x00DD341A File Offset: 0x00DD161A
		private void OnClick(EToggleState state)
		{
			Action onClickCall = this.OnClickCall;
			if (onClickCall == null)
			{
				return;
			}
			onClickCall();
		}

		// Token: 0x0401E563 RID: 124259
		private Action OnClickCall;
	}
}
