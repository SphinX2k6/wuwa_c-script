using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B1 RID: 26033
	[NullableContext(1)]
	[Nullable(0)]
	public class ListLayout : UiPanelBase
	{
		// Token: 0x060414A8 RID: 267432 RVA: 0x00FD2CB0 File Offset: 0x00FD0EB0
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

		// Token: 0x060414A9 RID: 267433 RVA: 0x00FD2D1C File Offset: 0x00FD0F1C
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<ListItem, int>(base.GetLayoutBase(0), new Func<ListItem>(this.InitItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
			this.GridWidth = base.GetItem(1).GetWidth();
		}

		// Token: 0x060414AA RID: 267434 RVA: 0x00FD2D6C File Offset: 0x00FD0F6C
		private ListItem InitItem()
		{
			return new ListItem();
		}

		// Token: 0x060414AB RID: 267435 RVA: 0x00FD2D74 File Offset: 0x00FD0F74
		public UniTask RefreshAsync(List<List<int>> dataDoublyList, int qualityId)
		{
			ListLayout.<RefreshAsync>d__6 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.dataDoublyList = dataDoublyList;
			<RefreshAsync>d__.qualityId = qualityId;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<ListLayout.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04021FC8 RID: 139208
		protected GenericLayout<ListItem, int> Layout;

		// Token: 0x04021FC9 RID: 139209
		protected float GridWidth;

		// Token: 0x0200C7B8 RID: 51128
		[NullableContext(0)]
		private class EListLayout
		{
			// Token: 0x0403C53F RID: 247103
			public const int LayoutItem = 0;

			// Token: 0x0403C540 RID: 247104
			public const int GridItem = 1;
		}
	}
}
