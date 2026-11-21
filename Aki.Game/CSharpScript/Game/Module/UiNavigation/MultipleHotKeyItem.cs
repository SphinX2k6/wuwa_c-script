using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200396C RID: 14700
	public class MultipleHotKeyItem : HotKeyItem
	{
		// Token: 0x06025D9D RID: 155037 RVA: 0x00AA1AE0 File Offset: 0x00A9FCE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06025D9E RID: 155038 RVA: 0x00AA1B4C File Offset: 0x00A9FD4C
		protected override UniTask OnBeforeStartAsync()
		{
			MultipleHotKeyItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultipleHotKeyItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025D9F RID: 155039 RVA: 0x00AA1B90 File Offset: 0x00A9FD90
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			1,
			0,
			2
		})]
		private ILayoutItem<UniTask<HotKeyTypeBase>> OnInitItem(object hotKeyTypeId, UUIItem uiItem, int index)
		{
			UniTask<HotKeyTypeBase> value = HotKeyTypeCreator.CreateHotKeyType(uiItem.GetOwner(), ((int?)hotKeyTypeId).Value, true);
			return new LayoutItem<UniTask<HotKeyTypeBase>>
			{
				Key = hotKeyTypeId,
				Value = value
			};
		}

		// Token: 0x06025DA0 RID: 155040 RVA: 0x00AA1BCC File Offset: 0x00A9FDCC
		protected override void OnClear()
		{
			foreach (HotKeyTypeBase hotKeyTypeBase in this.HotKeyTypeList)
			{
				hotKeyTypeBase.Clear();
			}
		}

		// Token: 0x06025DA1 RID: 155041 RVA: 0x00AA1C1C File Offset: 0x00A9FE1C
		private UniTask RefreshHotKey()
		{
			MultipleHotKeyItem.<RefreshHotKey>d__8 <RefreshHotKey>d__;
			<RefreshHotKey>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshHotKey>d__.<>4__this = this;
			<RefreshHotKey>d__.<>1__state = -1;
			<RefreshHotKey>d__.<>t__builder.Start<MultipleHotKeyItem.<RefreshHotKey>d__8>(ref <RefreshHotKey>d__);
			return <RefreshHotKey>d__.<>t__builder.Task;
		}

		// Token: 0x06025DA2 RID: 155042 RVA: 0x00AA1C60 File Offset: 0x00A9FE60
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public override List<HotKeyComponent> GetHotKeyComponentArray()
		{
			List<HotKeyTypeBase> hotKeyTypeList = this.HotKeyTypeList;
			List<HotKeyComponent> list = new List<HotKeyComponent>();
			foreach (HotKeyTypeBase hotKeyTypeBase in hotKeyTypeList)
			{
				list.AddRange(hotKeyTypeBase.GetHotKeyComponents());
			}
			return list;
		}

		// Token: 0x04014D54 RID: 85332
		[Nullable(new byte[]
		{
			2,
			0,
			2
		})]
		private GenericLayoutNew<UniTask<HotKeyTypeBase>> Layout;

		// Token: 0x04014D55 RID: 85333
		private int HotKeyViewIndex;

		// Token: 0x04014D56 RID: 85334
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private List<HotKeyTypeBase> HotKeyTypeList = new List<HotKeyTypeBase>();

		// Token: 0x020095CC RID: 38348
		private class EKeyCommonCom
		{
			// Token: 0x0402ECC5 RID: 191685
			public const int Layout = 0;

			// Token: 0x0402ECC6 RID: 191686
			public const int SingleHotKeyItem = 1;
		}
	}
}
