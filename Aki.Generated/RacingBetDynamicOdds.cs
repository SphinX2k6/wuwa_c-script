using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106B RID: 4203
	public struct RacingBetDynamicOdds : IFlatbufferObject
	{
		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0600BDFD RID: 48637 RVA: 0x002F11B1 File Offset: 0x002EF3B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x002F11BE File Offset: 0x002EF3BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x002F11C8 File Offset: 0x002EF3C8
		public static RacingBetDynamicOdds GetRootAsRacingBetDynamicOdds(ByteBuffer _bb)
		{
			return RacingBetDynamicOdds.GetRootAsRacingBetDynamicOdds(_bb, default(RacingBetDynamicOdds));
		}

		// Token: 0x0600BE00 RID: 48640 RVA: 0x002F11E4 File Offset: 0x002EF3E4
		public static RacingBetDynamicOdds GetRootAsRacingBetDynamicOdds(ByteBuffer _bb, RacingBetDynamicOdds obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE01 RID: 48641 RVA: 0x002F1201 File Offset: 0x002EF401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE02 RID: 48642 RVA: 0x002F1210 File Offset: 0x002EF410
		public RacingBetDynamicOdds __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x0600BE03 RID: 48643 RVA: 0x002F1220 File Offset: 0x002EF420
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

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x0600BE04 RID: 48644 RVA: 0x002F125C File Offset: 0x002EF45C
		public int LegId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE05 RID: 48645 RVA: 0x002F1298 File Offset: 0x002EF498
		public int Proportion(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x0600BE06 RID: 48646 RVA: 0x002F12D8 File Offset: 0x002EF4D8
		public int ProportionLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BE07 RID: 48647 RVA: 0x002F1303 File Offset: 0x002EF503
		public Span<int> GetProportionBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BE08 RID: 48648 RVA: 0x002F1312 File Offset: 0x002EF512
		public int[] GetProportionArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x0600BE09 RID: 48649 RVA: 0x002F132C File Offset: 0x002EF52C
		public int DynamicOdds
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BE0A RID: 48650 RVA: 0x002F1369 File Offset: 0x002EF569
		[NullableContext(1)]
		public int[] Proportion()
		{
			return this.GetProportionArray();
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x002F1371 File Offset: 0x002EF571
		[NullableContext(1)]
		public IEnumerable<int> ProportionIter()
		{
			RacingBetDynamicOdds.<ProportionIter>d__20 <ProportionIter>d__ = new RacingBetDynamicOdds.<ProportionIter>d__20(-2);
			<ProportionIter>d__.<>3__<>4__this = this;
			return <ProportionIter>d__;
		}

		// Token: 0x04005639 RID: 22073
		private Table __p;
	}
}
