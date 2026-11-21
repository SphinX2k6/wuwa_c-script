using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C4 RID: 4292
	public struct RogueCharacterBuff : IFlatbufferObject
	{
		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600C4CE RID: 50382 RVA: 0x00300145 File Offset: 0x002FE345
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x00300152 File Offset: 0x002FE352
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x0030015C File Offset: 0x002FE35C
		public static RogueCharacterBuff GetRootAsRogueCharacterBuff(ByteBuffer _bb)
		{
			return RogueCharacterBuff.GetRootAsRogueCharacterBuff(_bb, default(RogueCharacterBuff));
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x00300178 File Offset: 0x002FE378
		public static RogueCharacterBuff GetRootAsRogueCharacterBuff(ByteBuffer _bb, RogueCharacterBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4D2 RID: 50386 RVA: 0x00300195 File Offset: 0x002FE395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x003001A4 File Offset: 0x002FE3A4
		public RogueCharacterBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600C4D4 RID: 50388 RVA: 0x003001B4 File Offset: 0x002FE3B4
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

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0600C4D5 RID: 50389 RVA: 0x003001F0 File Offset: 0x002FE3F0
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C4D6 RID: 50390 RVA: 0x00300238 File Offset: 0x002FE438
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600C4D7 RID: 50391 RVA: 0x00300284 File Offset: 0x002FE484
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

		// Token: 0x0600C4D8 RID: 50392 RVA: 0x003002AF File Offset: 0x002FE4AF
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x003002C3 File Offset: 0x002FE4C3
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600C4DA RID: 50394 RVA: 0x00300300 File Offset: 0x002FE500
		public string AffixTypeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600C4DB RID: 50395 RVA: 0x0030033C File Offset: 0x002FE53C
		public int AffixTypeListLength
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

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0600C4DC RID: 50396 RVA: 0x00300368 File Offset: 0x002FE568
		public string AffixDesc
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

		// Token: 0x0600C4DD RID: 50397 RVA: 0x003003A0 File Offset: 0x002FE5A0
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C4DE RID: 50398 RVA: 0x003003B0 File Offset: 0x002FE5B0
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C4DF RID: 50399 RVA: 0x003003C8 File Offset: 0x002FE5C8
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600C4E0 RID: 50400 RVA: 0x00300404 File Offset: 0x002FE604
		public int AffixDescParamLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600C4E1 RID: 50401 RVA: 0x00300430 File Offset: 0x002FE630
		public string AffixDescSimple
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

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x00300468 File Offset: 0x002FE668
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x00300478 File Offset: 0x002FE678
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600C4E4 RID: 50404 RVA: 0x00300490 File Offset: 0x002FE690
		public string AffixTitle
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

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x003004C8 File Offset: 0x002FE6C8
		public Span<byte> GetAffixTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C4E6 RID: 50406 RVA: 0x003004D8 File Offset: 0x002FE6D8
		public byte[] GetAffixTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600C4E7 RID: 50407 RVA: 0x003004F0 File Offset: 0x002FE6F0
		public string AffixIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C4E8 RID: 50408 RVA: 0x00300528 File Offset: 0x002FE728
		public Span<byte> GetAffixIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x00300538 File Offset: 0x002FE738
		public byte[] GetAffixIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C4EA RID: 50410 RVA: 0x00300550 File Offset: 0x002FE750
		[NullableContext(1)]
		public string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C4EB RID: 50411 RVA: 0x0030055D File Offset: 0x002FE75D
		[NullableContext(1)]
		public IEnumerable<string> AffixDescParamIter()
		{
			RogueCharacterBuff.<AffixDescParamIter>d__40 <AffixDescParamIter>d__ = new RogueCharacterBuff.<AffixDescParamIter>d__40(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600C4EC RID: 50412 RVA: 0x00300572 File Offset: 0x002FE772
		[NullableContext(1)]
		public string[] AffixTypeList()
		{
			return this.AffixTypeListIter().ToArray<string>();
		}

		// Token: 0x0600C4ED RID: 50413 RVA: 0x0030057F File Offset: 0x002FE77F
		[NullableContext(1)]
		public IEnumerable<string> AffixTypeListIter()
		{
			RogueCharacterBuff.<AffixTypeListIter>d__42 <AffixTypeListIter>d__ = new RogueCharacterBuff.<AffixTypeListIter>d__42(-2);
			<AffixTypeListIter>d__.<>3__<>4__this = this;
			return <AffixTypeListIter>d__;
		}

		// Token: 0x0600C4EE RID: 50414 RVA: 0x00300594 File Offset: 0x002FE794
		[NullableContext(1)]
		public long[] BuffIds()
		{
			return this.GetBuffIdsArray();
		}

		// Token: 0x0600C4EF RID: 50415 RVA: 0x0030059C File Offset: 0x002FE79C
		[NullableContext(1)]
		public IEnumerable<long> BuffIdsIter()
		{
			RogueCharacterBuff.<BuffIdsIter>d__44 <BuffIdsIter>d__ = new RogueCharacterBuff.<BuffIdsIter>d__44(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x040056A1 RID: 22177
		private Table __p;
	}
}
