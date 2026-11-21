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
	// Token: 0x0200495A RID: 18778
	[NullableContext(2)]
	[Nullable(0)]
	public class GiantMindsetEntryItem : UiPanelBase
	{
		// Token: 0x0602F16D RID: 192877 RVA: 0x00D226D0 File Offset: 0x00D208D0
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

		// Token: 0x0602F16E RID: 192878 RVA: 0x00D2271C File Offset: 0x00D2091C
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

		// Token: 0x0602F16F RID: 192879 RVA: 0x00D22809 File Offset: 0x00D20A09
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnPointUpCallBack.Unbind();
		}

		// Token: 0x0602F170 RID: 192880 RVA: 0x00D22821 File Offset: 0x00D20A21
		[NullableContext(1)]
		public void SetClickCallback(Action call)
		{
			this.OnClickCall = call;
		}

		// Token: 0x0602F171 RID: 192881 RVA: 0x00D2282C File Offset: 0x00D20A2C
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

		// Token: 0x0602F172 RID: 192882 RVA: 0x00D22898 File Offset: 0x00D20A98
		public UUIItem GetRedDotItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x0602F173 RID: 192883 RVA: 0x00D228A1 File Offset: 0x00D20AA1
		public UUIItem GetTagNewItem()
		{
			return base.GetItem(1);
		}

		// Token: 0x0602F174 RID: 192884 RVA: 0x00D228AA File Offset: 0x00D20AAA
		private void OnClick(EToggleState state)
		{
			Action onClickCall = this.OnClickCall;
			if (onClickCall == null)
			{
				return;
			}
			onClickCall();
		}

		// Token: 0x04019001 RID: 102401
		private Action OnClickCall;
	}
}
