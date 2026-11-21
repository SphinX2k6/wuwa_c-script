using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B3D RID: 15165
	public class PreviewMinoItem : UiPanelBase
	{
		// Token: 0x06026FB3 RID: 159667 RVA: 0x00AE9A00 File Offset: 0x00AE7C00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06026FB4 RID: 159668 RVA: 0x00AE9A48 File Offset: 0x00AE7C48
		protected override void OnStart()
		{
			UUISprite sprite = base.GetSprite(0);
			if (sprite != null)
			{
				sprite.SetWidth(this.RootItem.GetWidth());
			}
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetHeight(this.RootItem.GetHeight());
		}

		// Token: 0x06026FB5 RID: 159669 RVA: 0x00AE9A84 File Offset: 0x00AE7C84
		[NullableContext(1)]
		public UniTask StartShow(SlidingBlocksDefine.ETetrominoBorad tetrominoType, string styleName, double x, double y)
		{
			PreviewMinoItem.<StartShow>d__5 <StartShow>d__;
			<StartShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartShow>d__.<>4__this = this;
			<StartShow>d__.tetrominoType = tetrominoType;
			<StartShow>d__.styleName = styleName;
			<StartShow>d__.x = x;
			<StartShow>d__.y = y;
			<StartShow>d__.<>1__state = -1;
			<StartShow>d__.<>t__builder.Start<PreviewMinoItem.<StartShow>d__5>(ref <StartShow>d__);
			return <StartShow>d__.<>t__builder.Task;
		}

		// Token: 0x06026FB6 RID: 159670 RVA: 0x00AE9AE8 File Offset: 0x00AE7CE8
		public UniTask EndShow()
		{
			PreviewMinoItem.<EndShow>d__6 <EndShow>d__;
			<EndShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndShow>d__.<>4__this = this;
			<EndShow>d__.<>1__state = -1;
			<EndShow>d__.<>t__builder.Start<PreviewMinoItem.<EndShow>d__6>(ref <EndShow>d__);
			return <EndShow>d__.<>t__builder.Task;
		}

		// Token: 0x06026FB7 RID: 159671 RVA: 0x00AE9B2C File Offset: 0x00AE7D2C
		[NullableContext(1)]
		private PreviewMinoItem.CoordOffset GetCoordOffset(SlidingBlocksDefine.ETetrominoBorad boardType)
		{
			PreviewMinoItem.CoordOffset coordOffset = new PreviewMinoItem.CoordOffset
			{
				X = 0.0,
				Y = 0.0
			};
			switch (boardType)
			{
			case SlidingBlocksDefine.ETetrominoBorad.二乘二:
				coordOffset.X = 1.5;
				coordOffset.Y = 1.5;
				break;
			case SlidingBlocksDefine.ETetrominoBorad.三乘三:
				coordOffset.X = 1.0;
				coordOffset.Y = 1.0;
				break;
			case SlidingBlocksDefine.ETetrominoBorad.四乘四:
				coordOffset.X = 0.5;
				coordOffset.Y = 0.5;
				break;
			}
			return coordOffset;
		}

		// Token: 0x040154A7 RID: 87207
		public bool IsUse;

		// Token: 0x020097C1 RID: 38849
		[RequiredMember]
		private class CoordOffset
		{
			// Token: 0x170078FD RID: 30973
			// (get) Token: 0x060444A4 RID: 279716 RVA: 0x014557FE File Offset: 0x014539FE
			// (set) Token: 0x060444A5 RID: 279717 RVA: 0x01455806 File Offset: 0x01453A06
			[RequiredMember]
			public double X { get; set; }

			// Token: 0x170078FE RID: 30974
			// (get) Token: 0x060444A6 RID: 279718 RVA: 0x0145580F File Offset: 0x01453A0F
			// (set) Token: 0x060444A7 RID: 279719 RVA: 0x01455817 File Offset: 0x01453A17
			[RequiredMember]
			public double Y { get; set; }

			// Token: 0x060444A8 RID: 279720 RVA: 0x01455820 File Offset: 0x01453A20
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public CoordOffset()
			{
			}
		}

		// Token: 0x020097C2 RID: 38850
		private enum EViewComponent
		{
			// Token: 0x0402F56A RID: 193898
			Sprite
		}
	}
}
