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
	// Token: 0x02004B93 RID: 19347
	public class PreviewMinoItem : UiPanelBase
	{
		// Token: 0x06032223 RID: 205347 RVA: 0x00BA58B4 File Offset: 0x00BA3AB4
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

		// Token: 0x06032224 RID: 205348 RVA: 0x00BA58FC File Offset: 0x00BA3AFC
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

		// Token: 0x06032225 RID: 205349 RVA: 0x00BA5938 File Offset: 0x00BA3B38
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

		// Token: 0x06032226 RID: 205350 RVA: 0x00BA599C File Offset: 0x00BA3B9C
		public UniTask EndShow()
		{
			PreviewMinoItem.<EndShow>d__6 <EndShow>d__;
			<EndShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EndShow>d__.<>4__this = this;
			<EndShow>d__.<>1__state = -1;
			<EndShow>d__.<>t__builder.Start<PreviewMinoItem.<EndShow>d__6>(ref <EndShow>d__);
			return <EndShow>d__.<>t__builder.Task;
		}

		// Token: 0x06032227 RID: 205351 RVA: 0x00BA59E0 File Offset: 0x00BA3BE0
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

		// Token: 0x0401AB53 RID: 109395
		public bool IsUse;

		// Token: 0x0200ADA2 RID: 44450
		[RequiredMember]
		private class CoordOffset
		{
			// Token: 0x1700A15F RID: 41311
			// (get) Token: 0x0604DEC1 RID: 319169 RVA: 0x0149D3C6 File Offset: 0x0149B5C6
			// (set) Token: 0x0604DEC2 RID: 319170 RVA: 0x0149D3CE File Offset: 0x0149B5CE
			[RequiredMember]
			public double X { get; set; }

			// Token: 0x1700A160 RID: 41312
			// (get) Token: 0x0604DEC3 RID: 319171 RVA: 0x0149D3D7 File Offset: 0x0149B5D7
			// (set) Token: 0x0604DEC4 RID: 319172 RVA: 0x0149D3DF File Offset: 0x0149B5DF
			[RequiredMember]
			public double Y { get; set; }

			// Token: 0x0604DEC5 RID: 319173 RVA: 0x0149D3E8 File Offset: 0x0149B5E8
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public CoordOffset()
			{
			}
		}

		// Token: 0x0200ADA3 RID: 44451
		private enum EViewComponent
		{
			// Token: 0x04034BC3 RID: 216003
			Sprite
		}
	}
}
