using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x02006357 RID: 25431
	public class PinballItemGridRoleBdComponent : PinballItemGridComponentBase
	{
		// Token: 0x0603FFF6 RID: 262134 RVA: 0x00F7B6F4 File Offset: 0x00F798F4
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

		// Token: 0x0603FFF7 RID: 262135 RVA: 0x00F7B73C File Offset: 0x00F7993C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballItemGridRoleBdComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballItemGridRoleBdComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFF8 RID: 262136 RVA: 0x00F7B77F File Offset: 0x00F7997F
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseType";
		}

		// Token: 0x0603FFF9 RID: 262137 RVA: 0x00F7B788 File Offset: 0x00F79988
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			int num = (int)args[0];
			if (num <= 0)
			{
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			BdComponent roleBdComponent = this.RoleBdComponent;
			if (roleBdComponent == null)
			{
				return;
			}
			roleBdComponent.RefreshItem(num);
		}

		// Token: 0x040215D6 RID: 136662
		[Nullable(2)]
		private BdComponent RoleBdComponent;

		// Token: 0x0200C577 RID: 50551
		private enum EComponent
		{
			// Token: 0x0403B9A4 RID: 244132
			BdItem
		}
	}
}
