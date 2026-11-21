using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FE RID: 4350
	public struct RogueResTalentTreeDesc : IFlatbufferObject
	{
		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600CA62 RID: 51810 RVA: 0x0030C1CA File Offset: 0x0030A3CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA63 RID: 51811 RVA: 0x0030C1D7 File Offset: 0x0030A3D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x0030C1E0 File Offset: 0x0030A3E0
		public static RogueResTalentTreeDesc GetRootAsRogueResTalentTreeDesc(ByteBuffer _bb)
		{
			return RogueResTalentTreeDesc.GetRootAsRogueResTalentTreeDesc(_bb, default(RogueResTalentTreeDesc));
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x0030C1FC File Offset: 0x0030A3FC
		public static RogueResTalentTreeDesc GetRootAsRogueResTalentTreeDesc(ByteBuffer _bb, RogueResTalentTreeDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x0030C219 File Offset: 0x0030A419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x0030C228 File Offset: 0x0030A428
		public RogueResTalentTreeDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0600CA68 RID: 51816 RVA: 0x0030C238 File Offset: 0x0030A438
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

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0600CA69 RID: 51817 RVA: 0x0030C274 File Offset: 0x0030A474
		public string TalentName
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

		// Token: 0x0600CA6A RID: 51818 RVA: 0x0030C2AB File Offset: 0x0030A4AB
		public Span<byte> GetTalentNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x0030C2BA File Offset: 0x0030A4BA
		public byte[] GetTalentNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600CA6C RID: 51820 RVA: 0x0030C2D4 File Offset: 0x0030A4D4
		public string TalentDesc
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

		// Token: 0x0600CA6D RID: 51821 RVA: 0x0030C30B File Offset: 0x0030A50B
		public Span<byte> GetTalentDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x0030C31A File Offset: 0x0030A51A
		public byte[] GetTalentDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x0030C334 File Offset: 0x0030A534
		public string Args(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600CA70 RID: 51824 RVA: 0x0030C370 File Offset: 0x0030A570
		public int ArgsLength
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

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600CA71 RID: 51825 RVA: 0x0030C39C File Offset: 0x0030A59C
		public string TalentIcon
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

		// Token: 0x0600CA72 RID: 51826 RVA: 0x0030C3D4 File Offset: 0x0030A5D4
		public Span<byte> GetTalentIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CA73 RID: 51827 RVA: 0x0030C3E4 File Offset: 0x0030A5E4
		public byte[] GetTalentIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x0030C3FC File Offset: 0x0030A5FC
		[NullableContext(1)]
		public string[] Args()
		{
			return this.ArgsIter().ToArray<string>();
		}

		// Token: 0x0600CA75 RID: 51829 RVA: 0x0030C409 File Offset: 0x0030A609
		[NullableContext(1)]
		public IEnumerable<string> ArgsIter()
		{
			RogueResTalentTreeDesc.<ArgsIter>d__26 <ArgsIter>d__ = new RogueResTalentTreeDesc.<ArgsIter>d__26(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x040056EC RID: 22252
		private Table __p;
	}
}
