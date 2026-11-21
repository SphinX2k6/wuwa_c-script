using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001112 RID: 4370
	public struct RogueWeeklyBuffDesc : IFlatbufferObject
	{
		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600CBF5 RID: 52213 RVA: 0x0030F901 File Offset: 0x0030DB01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x0030F90E File Offset: 0x0030DB0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x0030F918 File Offset: 0x0030DB18
		public static RogueWeeklyBuffDesc GetRootAsRogueWeeklyBuffDesc(ByteBuffer _bb)
		{
			return RogueWeeklyBuffDesc.GetRootAsRogueWeeklyBuffDesc(_bb, default(RogueWeeklyBuffDesc));
		}

		// Token: 0x0600CBF8 RID: 52216 RVA: 0x0030F934 File Offset: 0x0030DB34
		public static RogueWeeklyBuffDesc GetRootAsRogueWeeklyBuffDesc(ByteBuffer _bb, RogueWeeklyBuffDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x0030F951 File Offset: 0x0030DB51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x0030F960 File Offset: 0x0030DB60
		public RogueWeeklyBuffDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600CBFB RID: 52219 RVA: 0x0030F970 File Offset: 0x0030DB70
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

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600CBFC RID: 52220 RVA: 0x0030F9AC File Offset: 0x0030DBAC
		public string BuffDsec
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CBFD RID: 52221 RVA: 0x0030F9E3 File Offset: 0x0030DBE3
		public Span<byte> GetBuffDsecBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CBFE RID: 52222 RVA: 0x0030F9F2 File Offset: 0x0030DBF2
		public byte[] GetBuffDsecArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CBFF RID: 52223 RVA: 0x0030FA0C File Offset: 0x0030DC0C
		public string BuffDsecParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600CC00 RID: 52224 RVA: 0x0030FA48 File Offset: 0x0030DC48
		public int BuffDsecParamLength
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

		// Token: 0x0600CC01 RID: 52225 RVA: 0x0030FA73 File Offset: 0x0030DC73
		[NullableContext(1)]
		public string[] BuffDsecParam()
		{
			return this.BuffDsecParamIter().ToArray<string>();
		}

		// Token: 0x0600CC02 RID: 52226 RVA: 0x0030FA80 File Offset: 0x0030DC80
		[NullableContext(1)]
		public IEnumerable<string> BuffDsecParamIter()
		{
			RogueWeeklyBuffDesc.<BuffDsecParamIter>d__18 <BuffDsecParamIter>d__ = new RogueWeeklyBuffDesc.<BuffDsecParamIter>d__18(-2);
			<BuffDsecParamIter>d__.<>3__<>4__this = this;
			return <BuffDsecParamIter>d__;
		}

		// Token: 0x04005705 RID: 22277
		private Table __p;
	}
}
