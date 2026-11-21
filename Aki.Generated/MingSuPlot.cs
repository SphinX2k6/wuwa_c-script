using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEF RID: 3823
	public struct MingSuPlot : IFlatbufferObject
	{
		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x002A3676 File Offset: 0x002A1876
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A40 RID: 39488 RVA: 0x002A3683 File Offset: 0x002A1883
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x002A368C File Offset: 0x002A188C
		public static MingSuPlot GetRootAsMingSuPlot(ByteBuffer _bb)
		{
			return MingSuPlot.GetRootAsMingSuPlot(_bb, default(MingSuPlot));
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x002A36A8 File Offset: 0x002A18A8
		public static MingSuPlot GetRootAsMingSuPlot(ByteBuffer _bb, MingSuPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x002A36C5 File Offset: 0x002A18C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x002A36D4 File Offset: 0x002A18D4
		public MingSuPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06009A45 RID: 39493 RVA: 0x002A36E4 File Offset: 0x002A18E4
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

		// Token: 0x06009A46 RID: 39494 RVA: 0x002A3720 File Offset: 0x002A1920
		public string CanLevelUpTips(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06009A47 RID: 39495 RVA: 0x002A375C File Offset: 0x002A195C
		public int CanLevelUpTipsLength
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

		// Token: 0x06009A48 RID: 39496 RVA: 0x002A3787 File Offset: 0x002A1987
		[NullableContext(1)]
		public string[] CanLevelUpTips()
		{
			return this.CanLevelUpTipsIter().ToArray<string>();
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x002A3794 File Offset: 0x002A1994
		[NullableContext(1)]
		public IEnumerable<string> CanLevelUpTipsIter()
		{
			MingSuPlot.<CanLevelUpTipsIter>d__14 <CanLevelUpTipsIter>d__ = new MingSuPlot.<CanLevelUpTipsIter>d__14(-2);
			<CanLevelUpTipsIter>d__.<>3__<>4__this = this;
			return <CanLevelUpTipsIter>d__;
		}

		// Token: 0x04005494 RID: 21652
		private Table __p;
	}
}
