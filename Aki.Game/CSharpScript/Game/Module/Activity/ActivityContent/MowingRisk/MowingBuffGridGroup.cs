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
	// Token: 0x020063D6 RID: 25558
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MowingBuffGridGroup : GridProxyAbstract<IMowingBuffGridGroupData>
	{
		// Token: 0x06040492 RID: 263314 RVA: 0x00F8C1F0 File Offset: 0x00F8A3F0
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

		// Token: 0x06040493 RID: 263315 RVA: 0x00F8C27A File Offset: 0x00F8A47A
		protected override void OnStart()
		{
			this.GridLayout = new GenericLayout<MowingBuffGridItem, IMowingBuffGridItemData>(base.GetGridLayout(1), new Func<MowingBuffGridItem>(this.BuildGridItem), null, false, true);
		}

		// Token: 0x06040494 RID: 263316 RVA: 0x00F8C29D File Offset: 0x00F8A49D
		protected override void OnBeforeDestroy()
		{
			this.GridLayout.UnBindLateUpdate();
		}

		// Token: 0x06040495 RID: 263317 RVA: 0x00F8C2AC File Offset: 0x00F8A4AC
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

		// Token: 0x06040496 RID: 263318 RVA: 0x00F8C2F7 File Offset: 0x00F8A4F7
		private MowingBuffGridItem BuildGridItem()
		{
			return new MowingBuffGridItem();
		}

		// Token: 0x06040497 RID: 263319 RVA: 0x00F8C2FE File Offset: 0x00F8A4FE
		public GenericLayout<MowingBuffGridItem, IMowingBuffGridItemData> GetBuffGridItemLayout()
		{
			return this.GridLayout;
		}

		// Token: 0x04021745 RID: 137029
		private GenericLayout<MowingBuffGridItem, IMowingBuffGridItemData> GridLayout;

		// Token: 0x0200C5D4 RID: 50644
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BBAA RID: 244650
			public const int TitleText = 0;

			// Token: 0x0403BBAB RID: 244651
			public const int GridLayout = 1;

			// Token: 0x0403BBAC RID: 244652
			public const int GridItem = 2;
		}
	}
}
