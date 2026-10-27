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
	// Token: 0x020049F2 RID: 18930
	public class MultipleHotKeyItem : HotKeyItem
	{
		// Token: 0x06031267 RID: 201319 RVA: 0x00B66B24 File Offset: 0x00B64D24
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

		// Token: 0x06031268 RID: 201320 RVA: 0x00B66B90 File Offset: 0x00B64D90
		protected override UniTask OnBeforeStartAsync()
		{
			MultipleHotKeyItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultipleHotKeyItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031269 RID: 201321 RVA: 0x00B66BD4 File Offset: 0x00B64DD4
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

		// Token: 0x0603126A RID: 201322 RVA: 0x00B66C10 File Offset: 0x00B64E10
		protected override void OnClear()
		{
			foreach (HotKeyTypeBase hotKeyTypeBase in this.HotKeyTypeList)
			{
				hotKeyTypeBase.Clear();
			}
		}

		// Token: 0x0603126B RID: 201323 RVA: 0x00B66C60 File Offset: 0x00B64E60
		private UniTask RefreshHotKey()
		{
			MultipleHotKeyItem.<RefreshHotKey>d__8 <RefreshHotKey>d__;
			<RefreshHotKey>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshHotKey>d__.<>4__this = this;
			<RefreshHotKey>d__.<>1__state = -1;
			<RefreshHotKey>d__.<>t__builder.Start<MultipleHotKeyItem.<RefreshHotKey>d__8>(ref <RefreshHotKey>d__);
			return <RefreshHotKey>d__.<>t__builder.Task;
		}

		// Token: 0x0603126C RID: 201324 RVA: 0x00B66CA4 File Offset: 0x00B64EA4
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

		// Token: 0x0401A4E2 RID: 107746
		[Nullable(new byte[]
		{
			2,
			0,
			2
		})]
		private GenericLayoutNew<UniTask<HotKeyTypeBase>> Layout;

		// Token: 0x0401A4E3 RID: 107747
		private int HotKeyViewIndex;

		// Token: 0x0401A4E4 RID: 107748
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private List<HotKeyTypeBase> HotKeyTypeList = new List<HotKeyTypeBase>();

		// Token: 0x0200ABBD RID: 43965
		private class EKeyCommonCom
		{
			// Token: 0x04034342 RID: 213826
			public const int Layout = 0;

			// Token: 0x04034343 RID: 213827
			public const int SingleHotKeyItem = 1;
		}
	}
}
