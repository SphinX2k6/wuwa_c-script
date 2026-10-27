using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7F RID: 3199
	public struct FishingGridItemShape : IFlatbufferObject
	{
		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06006F4B RID: 28491 RVA: 0x00231071 File Offset: 0x0022F271
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x0023107E File Offset: 0x0022F27E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x00231088 File Offset: 0x0022F288
		public static FishingGridItemShape GetRootAsFishingGridItemShape(ByteBuffer _bb)
		{
			return FishingGridItemShape.GetRootAsFishingGridItemShape(_bb, default(FishingGridItemShape));
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x002310A4 File Offset: 0x0022F2A4
		public static FishingGridItemShape GetRootAsFishingGridItemShape(ByteBuffer _bb, FishingGridItemShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x002310C1 File Offset: 0x0022F2C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x002310D0 File Offset: 0x0022F2D0
		public FishingGridItemShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06006F51 RID: 28497 RVA: 0x002310E0 File Offset: 0x0022F2E0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x0023111C File Offset: 0x0022F31C
		public IntArray? FillState(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06006F53 RID: 28499 RVA: 0x0023117C File Offset: 0x0022F37C
		public int FillStateLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x002311A7 File Offset: 0x0022F3A7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FillStateIter()或GetFillStateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] FillState()
		{
			return this.FillStateIter().ToArray<IntArray>();
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x002311B4 File Offset: 0x0022F3B4
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> FillStateIter()
		{
			FishingGridItemShape.<FillStateIter>d__14 <FillStateIter>d__ = new FishingGridItemShape.<FillStateIter>d__14(-2);
			<FillStateIter>d__.<>3__<>4__this = this;
			return <FillStateIter>d__;
		}

		// Token: 0x04004CCE RID: 19662
		private Table __p;
	}
}
