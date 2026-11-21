using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200396A RID: 14698
	public class NormalHotKeyType : HotKeyTypeBase
	{
		// Token: 0x06025D97 RID: 155031 RVA: 0x00AA19F0 File Offset: 0x00A9FBF0
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

		// Token: 0x06025D98 RID: 155032 RVA: 0x00AA1A38 File Offset: 0x00A9FC38
		protected override UniTask OnBeforeStartAsync()
		{
			NormalHotKeyType.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<NormalHotKeyType.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025D99 RID: 155033 RVA: 0x00AA1A7B File Offset: 0x00A9FC7B
		protected override void OnClear()
		{
			HotKeyComponent hotKeyComponent = this.HotKeyComponent;
			if (hotKeyComponent == null)
			{
				return;
			}
			hotKeyComponent.Clear();
		}

		// Token: 0x06025D9A RID: 155034 RVA: 0x00AA1A90 File Offset: 0x00A9FC90
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

		// Token: 0x06025D9B RID: 155035 RVA: 0x00AA1AC4 File Offset: 0x00A9FCC4
		public override void KeyItemNotifySetActive(bool value)
		{
			if (this.IsMultiKeyItem)
			{
				this.SetActive(value);
			}
		}

		// Token: 0x04014D51 RID: 85329
		[Nullable(2)]
		protected HotKeyComponent HotKeyComponent;
	}
}
