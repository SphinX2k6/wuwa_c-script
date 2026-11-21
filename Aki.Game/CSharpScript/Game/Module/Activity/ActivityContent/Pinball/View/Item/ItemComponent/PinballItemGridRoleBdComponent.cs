using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052D5 RID: 21205
	public class PinballItemGridRoleBdComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CB7 RID: 216247 RVA: 0x00EC2654 File Offset: 0x00EC0854
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

		// Token: 0x06034CB8 RID: 216248 RVA: 0x00EC269C File Offset: 0x00EC089C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballItemGridRoleBdComponent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballItemGridRoleBdComponent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034CB9 RID: 216249 RVA: 0x00EC26DF File Offset: 0x00EC08DF
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseType";
		}

		// Token: 0x06034CBA RID: 216250 RVA: 0x00EC26E8 File Offset: 0x00EC08E8
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

		// Token: 0x0401BF05 RID: 114437
		[Nullable(2)]
		private BdComponent RoleBdComponent;

		// Token: 0x0200AF5E RID: 44894
		private enum EComponent
		{
			// Token: 0x04036306 RID: 221958
			BdItem
		}
	}
}
