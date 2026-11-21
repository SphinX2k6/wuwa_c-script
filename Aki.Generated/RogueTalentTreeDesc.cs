using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110C RID: 4364
	public struct RogueTalentTreeDesc : IFlatbufferObject
	{
		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600CB84 RID: 52100 RVA: 0x0030EA7F File Offset: 0x0030CC7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x0030EA8C File Offset: 0x0030CC8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB86 RID: 52102 RVA: 0x0030EA94 File Offset: 0x0030CC94
		public static RogueTalentTreeDesc GetRootAsRogueTalentTreeDesc(ByteBuffer _bb)
		{
			return RogueTalentTreeDesc.GetRootAsRogueTalentTreeDesc(_bb, default(RogueTalentTreeDesc));
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x0030EAB0 File Offset: 0x0030CCB0
		public static RogueTalentTreeDesc GetRootAsRogueTalentTreeDesc(ByteBuffer _bb, RogueTalentTreeDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB88 RID: 52104 RVA: 0x0030EACD File Offset: 0x0030CCCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB89 RID: 52105 RVA: 0x0030EADC File Offset: 0x0030CCDC
		public RogueTalentTreeDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600CB8A RID: 52106 RVA: 0x0030EAEC File Offset: 0x0030CCEC
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

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600CB8B RID: 52107 RVA: 0x0030EB28 File Offset: 0x0030CD28
		public string BaseDesc
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

		// Token: 0x0600CB8C RID: 52108 RVA: 0x0030EB5F File Offset: 0x0030CD5F
		public Span<byte> GetBaseDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CB8D RID: 52109 RVA: 0x0030EB6E File Offset: 0x0030CD6E
		public byte[] GetBaseDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CB8E RID: 52110 RVA: 0x0030EB88 File Offset: 0x0030CD88
		public IntArray? Args(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x0030EBE8 File Offset: 0x0030CDE8
		public int ArgsLength
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

		// Token: 0x0600CB90 RID: 52112 RVA: 0x0030EC14 File Offset: 0x0030CE14
		public string Params(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600CB91 RID: 52113 RVA: 0x0030EC50 File Offset: 0x0030CE50
		public int ParamsLength
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

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600CB92 RID: 52114 RVA: 0x0030EC7C File Offset: 0x0030CE7C
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

		// Token: 0x0600CB93 RID: 52115 RVA: 0x0030ECB4 File Offset: 0x0030CEB4
		public Span<byte> GetTalentIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CB94 RID: 52116 RVA: 0x0030ECC4 File Offset: 0x0030CEC4
		public byte[] GetTalentIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x0030ECDC File Offset: 0x0030CEDC
		public string TalentName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB96 RID: 52118 RVA: 0x0030ED14 File Offset: 0x0030CF14
		public Span<byte> GetTalentNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x0030ED24 File Offset: 0x0030CF24
		public byte[] GetTalentNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x0030ED3C File Offset: 0x0030CF3C
		[NullableContext(1)]
		public IntArray[] Args()
		{
			return this.ArgsIter().ToArray<IntArray>();
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x0030ED49 File Offset: 0x0030CF49
		[NullableContext(1)]
		public IEnumerable<IntArray> ArgsIter()
		{
			RogueTalentTreeDesc.<ArgsIter>d__29 <ArgsIter>d__ = new RogueTalentTreeDesc.<ArgsIter>d__29(-2);
			<ArgsIter>d__.<>3__<>4__this = this;
			return <ArgsIter>d__;
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x0030ED5E File Offset: 0x0030CF5E
		[NullableContext(1)]
		public string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600CB9B RID: 52123 RVA: 0x0030ED6B File Offset: 0x0030CF6B
		[NullableContext(1)]
		public IEnumerable<string> ParamsIter()
		{
			RogueTalentTreeDesc.<ParamsIter>d__31 <ParamsIter>d__ = new RogueTalentTreeDesc.<ParamsIter>d__31(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x040056FF RID: 22271
		private Table __p;
	}
}
