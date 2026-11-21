using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005354 RID: 21332
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MowingBuffGridGroup : GridProxyAbstract<IMowingBuffGridGroupData>
	{
		// Token: 0x06035153 RID: 217427 RVA: 0x00ED3188 File Offset: 0x00ED1388
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035154 RID: 217428 RVA: 0x00ED3212 File Offset: 0x00ED1412
		protected override void OnStart()
		{
			this.GridLayout = new GenericLayout<MowingBuffGridItem, IMowingBuffGridItemData>(base.GetGridLayout(1), new Func<MowingBuffGridItem>(this.BuildGridItem), null, false, true);
		}

		// Token: 0x06035155 RID: 217429 RVA: 0x00ED3235 File Offset: 0x00ED1435
		protected override void OnBeforeDestroy()
		{
			this.GridLayout.UnBindLateUpdate();
		}

		// Token: 0x06035156 RID: 217430 RVA: 0x00ED3244 File Offset: 0x00ED1444
		public override UniTask RefreshAsync(IMowingBuffGridGroupData data, bool isSelected, int gridIndex)
		{
			MowingBuffGridGroup.<RefreshAsync>d__5 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<MowingBuffGridGroup.<RefreshAsync>d__5>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035157 RID: 217431 RVA: 0x00ED328F File Offset: 0x00ED148F
		private MowingBuffGridItem BuildGridItem()
		{
			return new MowingBuffGridItem();
		}

		// Token: 0x06035158 RID: 217432 RVA: 0x00ED3296 File Offset: 0x00ED1496
		public GenericLayout<MowingBuffGridItem, IMowingBuffGridItemData> GetBuffGridItemLayout()
		{
			return this.GridLayout;
		}

		// Token: 0x0401C074 RID: 114804
		private GenericLayout<MowingBuffGridItem, IMowingBuffGridItemData> GridLayout;

		// Token: 0x0200AFBB RID: 44987
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04036509 RID: 222473
			public const int TitleText = 0;

			// Token: 0x0403650A RID: 222474
			public const int GridLayout = 1;

			// Token: 0x0403650B RID: 222475
			public const int GridItem = 2;
		}
	}
}
