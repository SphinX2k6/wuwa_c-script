using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D63 RID: 3427
	public struct FishingGridItemShape : IFlatbufferObject
	{
		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06007556 RID: 30038 RVA: 0x0025023D File Offset: 0x0024E43D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x0025024A File Offset: 0x0024E44A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x00250254 File Offset: 0x0024E454
		public static FishingGridItemShape GetRootAsFishingGridItemShape(ByteBuffer _bb)
		{
			return FishingGridItemShape.GetRootAsFishingGridItemShape(_bb, default(FishingGridItemShape));
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x00250270 File Offset: 0x0024E470
		public static FishingGridItemShape GetRootAsFishingGridItemShape(ByteBuffer _bb, FishingGridItemShape obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x0025028D File Offset: 0x0024E48D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x0025029C File Offset: 0x0024E49C
		public FishingGridItemShape __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x002502AC File Offset: 0x0024E4AC
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

		// Token: 0x0600755D RID: 30045 RVA: 0x002502E8 File Offset: 0x0024E4E8
		public IntArray? FillState(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600755E RID: 30046 RVA: 0x00250348 File Offset: 0x0024E548
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

		// Token: 0x0600755F RID: 30047 RVA: 0x00250373 File Offset: 0x0024E573
		[NullableContext(1)]
		public IntArray[] FillState()
		{
			return this.FillStateIter().ToArray<IntArray>();
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x00250380 File Offset: 0x0024E580
		[NullableContext(1)]
		public IEnumerable<IntArray> FillStateIter()
		{
			FishingGridItemShape.<FillStateIter>d__14 <FillStateIter>d__ = new FishingGridItemShape.<FillStateIter>d__14(-2);
			<FillStateIter>d__.<>3__<>4__this = this;
			return <FillStateIter>d__;
		}

		// Token: 0x040052B2 RID: 21170
		private Table __p;
	}
}
