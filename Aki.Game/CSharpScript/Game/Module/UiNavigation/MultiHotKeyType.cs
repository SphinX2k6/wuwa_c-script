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
	// Token: 0x02003969 RID: 14697
	public class MultiHotKeyType : HotKeyTypeBase
	{
		// Token: 0x06025D90 RID: 155024 RVA: 0x00AA182C File Offset: 0x00A9FA2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06025D91 RID: 155025 RVA: 0x00AA1898 File Offset: 0x00A9FA98
		protected override UniTask OnBeforeStartAsync()
		{
			MultiHotKeyType.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiHotKeyType.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025D92 RID: 155026 RVA: 0x00AA18DC File Offset: 0x00A9FADC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			0,
			2
		})]
		private ILayoutItem<UniTask<HotKeyComponent>> OnInitItem(object hotKeyMapId, UUIItem uiItem, int index)
		{
			AActor owner = uiItem.GetOwner();
			if (owner == null)
			{
				return null;
			}
			UniTask<HotKeyComponent> value = HotKeyItemFactory.CreateHotKeyComponent(owner, (int)hotKeyMapId, this);
			return new LayoutItem<UniTask<HotKeyComponent>>
			{
				Key = hotKeyMapId,
				Value = value
			};
		}

		// Token: 0x06025D93 RID: 155027 RVA: 0x00AA1918 File Offset: 0x00A9FB18
		protected override void OnClear()
		{
			foreach (HotKeyComponent hotKeyComponent in this.HotKeyComponentList)
			{
				if (hotKeyComponent != null)
				{
					hotKeyComponent.Clear();
				}
			}
		}

		// Token: 0x06025D94 RID: 155028 RVA: 0x00AA1970 File Offset: 0x00A9FB70
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public override List<HotKeyComponent> GetHotKeyComponents()
		{
			return this.HotKeyComponentList;
		}

		// Token: 0x06025D95 RID: 155029 RVA: 0x00AA1978 File Offset: 0x00A9FB78
		public override void KeyItemNotifySetActive(bool value)
		{
			bool active = false;
			foreach (HotKeyComponent hotKeyComponent in this.HotKeyComponentList)
			{
				if (hotKeyComponent != null && hotKeyComponent.IsHotKeyActive())
				{
					active = true;
					break;
				}
			}
			this.SetActive(active);
		}

		// Token: 0x04014D4F RID: 85327
		[Nullable(new byte[]
		{
			1,
			0,
			2
		})]
		protected GenericLayoutNew<UniTask<HotKeyComponent>> Layout;

		// Token: 0x04014D50 RID: 85328
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private List<HotKeyComponent> HotKeyComponentList = new List<HotKeyComponent>();

		// Token: 0x020095C9 RID: 38345
		private class EMultiHotKeyType
		{
			// Token: 0x0402ECBB RID: 191675
			public const int HotKey = 0;

			// Token: 0x0402ECBC RID: 191676
			public const int Layout = 1;
		}
	}
}
