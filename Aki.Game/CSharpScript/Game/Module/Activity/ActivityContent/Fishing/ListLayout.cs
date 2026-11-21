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
	// Token: 0x0200552F RID: 21807
	[NullableContext(1)]
	[Nullable(0)]
	public class ListLayout : UiPanelBase
	{
		// Token: 0x0603616D RID: 221549 RVA: 0x00F19CB4 File Offset: 0x00F17EB4
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

		// Token: 0x0603616E RID: 221550 RVA: 0x00F19D20 File Offset: 0x00F17F20
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<ListItem, int>(base.GetLayoutBase(0), new Func<ListItem>(this.InitItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
			this.GridWidth = base.GetItem(1).GetWidth();
		}

		// Token: 0x0603616F RID: 221551 RVA: 0x00F19D70 File Offset: 0x00F17F70
		private ListItem InitItem()
		{
			return new ListItem();
		}

		// Token: 0x06036170 RID: 221552 RVA: 0x00F19D78 File Offset: 0x00F17F78
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

		// Token: 0x0401C8F9 RID: 116985
		protected GenericLayout<ListItem, int> Layout;

		// Token: 0x0401C8FA RID: 116986
		protected float GridWidth;

		// Token: 0x0200B19D RID: 45469
		[NullableContext(0)]
		private class EListLayout
		{
			// Token: 0x04036E90 RID: 224912
			public const int LayoutItem = 0;

			// Token: 0x04036E91 RID: 224913
			public const int GridItem = 1;
		}
	}
}
