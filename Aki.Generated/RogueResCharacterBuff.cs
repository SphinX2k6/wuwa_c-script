using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DD RID: 4317
	public struct RogueResCharacterBuff : IFlatbufferObject
	{
		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0600C76C RID: 51052 RVA: 0x00305ECC File Offset: 0x003040CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C76D RID: 51053 RVA: 0x00305ED9 File Offset: 0x003040D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C76E RID: 51054 RVA: 0x00305EE0 File Offset: 0x003040E0
		public static RogueResCharacterBuff GetRootAsRogueResCharacterBuff(ByteBuffer _bb)
		{
			return RogueResCharacterBuff.GetRootAsRogueResCharacterBuff(_bb, default(RogueResCharacterBuff));
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x00305EFC File Offset: 0x003040FC
		public static RogueResCharacterBuff GetRootAsRogueResCharacterBuff(ByteBuffer _bb, RogueResCharacterBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x00305F19 File Offset: 0x00304119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x00305F28 File Offset: 0x00304128
		public RogueResCharacterBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x0600C772 RID: 51058 RVA: 0x00305F38 File Offset: 0x00304138
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

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x0600C773 RID: 51059 RVA: 0x00305F74 File Offset: 0x00304174
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C774 RID: 51060 RVA: 0x00305FBC File Offset: 0x003041BC
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x0600C775 RID: 51061 RVA: 0x00306008 File Offset: 0x00304208
		public int BuffIdsLength
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

		// Token: 0x0600C776 RID: 51062 RVA: 0x00306033 File Offset: 0x00304233
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x00306047 File Offset: 0x00304247
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x0600C778 RID: 51064 RVA: 0x00306084 File Offset: 0x00304284
		public string AffixDesc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x003060BC File Offset: 0x003042BC
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x003060CC File Offset: 0x003042CC
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x003060E4 File Offset: 0x003042E4
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0600C77C RID: 51068 RVA: 0x00306120 File Offset: 0x00304320
		public int AffixDescParamLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x0600C77D RID: 51069 RVA: 0x0030614C File Offset: 0x0030434C
		public string AffixDescSimple
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

		// Token: 0x0600C77E RID: 51070 RVA: 0x00306184 File Offset: 0x00304384
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C77F RID: 51071 RVA: 0x00306194 File Offset: 0x00304394
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x0600C780 RID: 51072 RVA: 0x003061AC File Offset: 0x003043AC
		public string AffixTitle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C781 RID: 51073 RVA: 0x003061E4 File Offset: 0x003043E4
		public Span<byte> GetAffixTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C782 RID: 51074 RVA: 0x003061F4 File Offset: 0x003043F4
		public byte[] GetAffixTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x0600C783 RID: 51075 RVA: 0x0030620C File Offset: 0x0030440C
		public string AffixIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C784 RID: 51076 RVA: 0x00306244 File Offset: 0x00304444
		public Span<byte> GetAffixIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C785 RID: 51077 RVA: 0x00306254 File Offset: 0x00304454
		public byte[] GetAffixIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C786 RID: 51078 RVA: 0x0030626C File Offset: 0x0030446C
		[NullableContext(1)]
		public string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C787 RID: 51079 RVA: 0x00306279 File Offset: 0x00304479
		[NullableContext(1)]
		public IEnumerable<string> AffixDescParamIter()
		{
			RogueResCharacterBuff.<AffixDescParamIter>d__37 <AffixDescParamIter>d__ = new RogueResCharacterBuff.<AffixDescParamIter>d__37(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600C788 RID: 51080 RVA: 0x0030628E File Offset: 0x0030448E
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x0600C789 RID: 51081 RVA: 0x00306296 File Offset: 0x00304496
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			RogueResCharacterBuff.<BuffIdsIter>d__39 <BuffIdsIter>d__ = new RogueResCharacterBuff.<BuffIdsIter>d__39(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x040056C5 RID: 22213
		private Table __p;
	}
}
