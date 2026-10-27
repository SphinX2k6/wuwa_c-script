using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049F0 RID: 18928
	public class NormalHotKeyType : HotKeyTypeBase
	{
		// Token: 0x06031261 RID: 201313 RVA: 0x00B66A34 File Offset: 0x00B64C34
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031262 RID: 201314 RVA: 0x00B66A7C File Offset: 0x00B64C7C
		protected override UniTask OnBeforeStartAsync()
		{
			NormalHotKeyType.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NormalHotKeyType.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031263 RID: 201315 RVA: 0x00B66ABF File Offset: 0x00B64CBF
		protected override void OnClear()
		{
			HotKeyComponent hotKeyComponent = this.HotKeyComponent;
			if (hotKeyComponent == null)
			{
				return;
			}
			hotKeyComponent.Clear();
		}

		// Token: 0x06031264 RID: 201316 RVA: 0x00B66AD4 File Offset: 0x00B64CD4
		[return: Nullable(new byte[]
		{
			1,
			2
		})]
		public unsafe override List<HotKeyComponent> GetHotKeyComponents()
		{
			int num = 1;
			List<HotKeyComponent> list = new List<HotKeyComponent>(num);
			CollectionsMarshal.SetCount<HotKeyComponent>(list, num);
			Span<HotKeyComponent> span = CollectionsMarshal.AsSpan<HotKeyComponent>(list);
			int index = 0;
			*span[index] = this.HotKeyComponent;
			return list;
		}

		// Token: 0x06031265 RID: 201317 RVA: 0x00B66B08 File Offset: 0x00B64D08
		public override void KeyItemNotifySetActive(bool value)
		{
			if (this.IsMultiKeyItem)
			{
				this.SetActive(value);
			}
		}

		// Token: 0x0401A4DF RID: 107743
		[Nullable(2)]
		protected HotKeyComponent HotKeyComponent;
	}
}
