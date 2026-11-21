using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052D7 RID: 21207
	public class PinballItemGridRoleClassComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CBF RID: 216255 RVA: 0x00EC280C File Offset: 0x00EC0A0C
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

		// Token: 0x06034CC0 RID: 216256 RVA: 0x00EC2854 File Offset: 0x00EC0A54
		protected override UniTask OnBeforeStartAsync()
		{
			PinballItemGridRoleClassComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballItemGridRoleClassComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034CC1 RID: 216257 RVA: 0x00EC2897 File Offset: 0x00EC0A97
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseRoleJob";
		}

		// Token: 0x06034CC2 RID: 216258 RVA: 0x00EC28A0 File Offset: 0x00EC0AA0
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

		// Token: 0x0401BF06 RID: 114438
		[Nullable(2)]
		private ClassComponent RoleClassComponent;

		// Token: 0x0200AF61 RID: 44897
		private enum EComponent
		{
			// Token: 0x0403630F RID: 221967
			Item
		}
	}
}
