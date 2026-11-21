using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D4 RID: 4308
	public struct RogueResAffix : IFlatbufferObject
	{
		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0600C69C RID: 50844 RVA: 0x00303FD0 File Offset: 0x003021D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C69D RID: 50845 RVA: 0x00303FDD File Offset: 0x003021DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C69E RID: 50846 RVA: 0x00303FE4 File Offset: 0x003021E4
		public static RogueResAffix GetRootAsRogueResAffix(ByteBuffer _bb)
		{
			return RogueResAffix.GetRootAsRogueResAffix(_bb, default(RogueResAffix));
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x00304000 File Offset: 0x00302200
		public static RogueResAffix GetRootAsRogueResAffix(ByteBuffer _bb, RogueResAffix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x0030401D File Offset: 0x0030221D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x0030402C File Offset: 0x0030222C
		public RogueResAffix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0600C6A2 RID: 50850 RVA: 0x0030403C File Offset: 0x0030223C
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

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x00304078 File Offset: 0x00302278
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x0600C6A4 RID: 50852 RVA: 0x003040C4 File Offset: 0x003022C4
		public int BuffIdLength
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

		// Token: 0x0600C6A5 RID: 50853 RVA: 0x003040EF File Offset: 0x003022EF
		public Span<long> GetBuffIdBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(6, 8));
		}

		// Token: 0x0600C6A6 RID: 50854 RVA: 0x00304103 File Offset: 0x00302303
		public long[] GetBuffIdArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(6) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x0600C6A7 RID: 50855 RVA: 0x00304140 File Offset: 0x00302340
		public string AffixDesc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C6A8 RID: 50856 RVA: 0x00304177 File Offset: 0x00302377
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C6A9 RID: 50857 RVA: 0x00304186 File Offset: 0x00302386
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C6AA RID: 50858 RVA: 0x003041A0 File Offset: 0x003023A0
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x0600C6AB RID: 50859 RVA: 0x003041DC File Offset: 0x003023DC
		public int AffixDescParamLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x0600C6AC RID: 50860 RVA: 0x00304208 File Offset: 0x00302408
		public string AffixDescSimple
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C6AD RID: 50861 RVA: 0x00304240 File Offset: 0x00302440
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C6AE RID: 50862 RVA: 0x00304250 File Offset: 0x00302450
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C6AF RID: 50863 RVA: 0x00304268 File Offset: 0x00302468
		[NullableContext(1)]
		public string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C6B0 RID: 50864 RVA: 0x00304275 File Offset: 0x00302475
		[NullableContext(1)]
		public IEnumerable<string> AffixDescParamIter()
		{
			RogueResAffix.<AffixDescParamIter>d__27 <AffixDescParamIter>d__ = new RogueResAffix.<AffixDescParamIter>d__27(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600C6B1 RID: 50865 RVA: 0x0030428A File Offset: 0x0030248A
		[NullableContext(1)]
		public long[] BuffId()
		{
			return this.GetBuffIdArray();
		}

		// Token: 0x0600C6B2 RID: 50866 RVA: 0x00304292 File Offset: 0x00302492
		[NullableContext(1)]
		public IEnumerable<long> BuffIdIter()
		{
			RogueResAffix.<BuffIdIter>d__29 <BuffIdIter>d__ = new RogueResAffix.<BuffIdIter>d__29(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x040056B5 RID: 22197
		private Table __p;
	}
}
