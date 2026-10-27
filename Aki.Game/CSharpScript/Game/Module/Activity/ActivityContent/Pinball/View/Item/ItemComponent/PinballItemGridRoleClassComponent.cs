using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x02006359 RID: 25433
	public class PinballItemGridRoleClassComponent : PinballItemGridComponentBase
	{
		// Token: 0x0603FFFE RID: 262142 RVA: 0x00F7B8AC File Offset: 0x00F79AAC
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

		// Token: 0x0603FFFF RID: 262143 RVA: 0x00F7B8F4 File Offset: 0x00F79AF4
		protected override UniTask OnBeforeStartAsync()
		{
			PinballItemGridRoleClassComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballItemGridRoleClassComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040000 RID: 262144 RVA: 0x00F7B937 File Offset: 0x00F79B37
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseRoleJob";
		}

		// Token: 0x06040001 RID: 262145 RVA: 0x00F7B940 File Offset: 0x00F79B40
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
			ClassComponent roleClassComponent = this.RoleClassComponent;
			if (roleClassComponent == null)
			{
				return;
			}
			roleClassComponent.RefreshItem(num);
		}

		// Token: 0x040215D7 RID: 136663
		[Nullable(2)]
		private ClassComponent RoleClassComponent;

		// Token: 0x0200C57A RID: 50554
		private enum EComponent
		{
			// Token: 0x0403B9AD RID: 244141
			Item
		}
	}
}
