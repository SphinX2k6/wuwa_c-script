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
	// Token: 0x020049EF RID: 18927
	public class MultiHotKeyType : HotKeyTypeBase
	{
		// Token: 0x0603125A RID: 201306 RVA: 0x00B66870 File Offset: 0x00B64A70
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

		// Token: 0x0603125B RID: 201307 RVA: 0x00B668DC File Offset: 0x00B64ADC
		protected override UniTask OnBeforeStartAsync()
		{
			MultiHotKeyType.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MultiHotKeyType.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603125C RID: 201308 RVA: 0x00B66920 File Offset: 0x00B64B20
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

		// Token: 0x0603125D RID: 201309 RVA: 0x00B6695C File Offset: 0x00B64B5C
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

		// Token: 0x0603125E RID: 201310 RVA: 0x00B669B4 File Offset: 0x00B64BB4
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public override List<HotKeyComponent> GetHotKeyComponents()
		{
			return this.HotKeyComponentList;
		}

		// Token: 0x0603125F RID: 201311 RVA: 0x00B669BC File Offset: 0x00B64BBC
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

		// Token: 0x0401A4DD RID: 107741
		[Nullable(new byte[]
		{
			1,
			0,
			2
		})]
		protected GenericLayoutNew<UniTask<HotKeyComponent>> Layout;

		// Token: 0x0401A4DE RID: 107742
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private List<HotKeyComponent> HotKeyComponentList = new List<HotKeyComponent>();

		// Token: 0x0200ABBA RID: 43962
		private class EMultiHotKeyType
		{
			// Token: 0x04034338 RID: 213816
			public const int HotKey = 0;

			// Token: 0x04034339 RID: 213817
			public const int Layout = 1;
		}
	}
}
