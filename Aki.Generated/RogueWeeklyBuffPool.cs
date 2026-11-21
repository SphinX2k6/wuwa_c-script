using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001113 RID: 4371
	public struct RogueWeeklyBuffPool : IFlatbufferObject
	{
		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600CC03 RID: 52227 RVA: 0x0030FA95 File Offset: 0x0030DC95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC04 RID: 52228 RVA: 0x0030FAA2 File Offset: 0x0030DCA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC05 RID: 52229 RVA: 0x0030FAAC File Offset: 0x0030DCAC
		public static RogueWeeklyBuffPool GetRootAsRogueWeeklyBuffPool(ByteBuffer _bb)
		{
			return RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(_bb, default(RogueWeeklyBuffPool));
		}

		// Token: 0x0600CC06 RID: 52230 RVA: 0x0030FAC8 File Offset: 0x0030DCC8
		public static RogueWeeklyBuffPool GetRootAsRogueWeeklyBuffPool(ByteBuffer _bb, RogueWeeklyBuffPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC07 RID: 52231 RVA: 0x0030FAE5 File Offset: 0x0030DCE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC08 RID: 52232 RVA: 0x0030FAF4 File Offset: 0x0030DCF4
		public RogueWeeklyBuffPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600CC09 RID: 52233 RVA: 0x0030FB04 File Offset: 0x0030DD04
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

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600CC0A RID: 52234 RVA: 0x0030FB40 File Offset: 0x0030DD40
		public int RelatedArtifactId
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

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600CC0B RID: 52235 RVA: 0x0030FB7C File Offset: 0x0030DD7C
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(8);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600CC0C RID: 52236 RVA: 0x0030FBC4 File Offset: 0x0030DDC4
		public int PerIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600CC0D RID: 52237 RVA: 0x0030FC04 File Offset: 0x0030DE04
		public int PerIdsLength
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

		// Token: 0x0600CC0E RID: 52238 RVA: 0x0030FC30 File Offset: 0x0030DE30
		public Span<int> GetPerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CC0F RID: 52239 RVA: 0x0030FC40 File Offset: 0x0030DE40
		public int[] GetPerIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600CC10 RID: 52240 RVA: 0x0030FC58 File Offset: 0x0030DE58
		public int BuffType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600CC11 RID: 52241 RVA: 0x0030FC98 File Offset: 0x0030DE98
		public int BuffTriggerTagId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600CC12 RID: 52242 RVA: 0x0030FCD8 File Offset: 0x0030DED8
		public string BuffTriggerActionName
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

		// Token: 0x0600CC13 RID: 52243 RVA: 0x0030FD10 File Offset: 0x0030DF10
		public Span<byte> GetBuffTriggerActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CC14 RID: 52244 RVA: 0x0030FD20 File Offset: 0x0030DF20
		public byte[] GetBuffTriggerActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC15 RID: 52245 RVA: 0x0030FD38 File Offset: 0x0030DF38
		public int BuffTagId(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600CC16 RID: 52246 RVA: 0x0030FD78 File Offset: 0x0030DF78
		public int BuffTagIdLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CC17 RID: 52247 RVA: 0x0030FDA4 File Offset: 0x0030DFA4
		public Span<int> GetBuffTagIdBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600CC18 RID: 52248 RVA: 0x0030FDB4 File Offset: 0x0030DFB4
		public int[] GetBuffTagIdArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600CC19 RID: 52249 RVA: 0x0030FDCC File Offset: 0x0030DFCC
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600CC1A RID: 52250 RVA: 0x0030FE0C File Offset: 0x0030E00C
		public string BuffIcon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x0030FE44 File Offset: 0x0030E044
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CC1C RID: 52252 RVA: 0x0030FE54 File Offset: 0x0030E054
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600CC1D RID: 52253 RVA: 0x0030FE6C File Offset: 0x0030E06C
		public string ButtonIcon
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC1E RID: 52254 RVA: 0x0030FEA4 File Offset: 0x0030E0A4
		public Span<byte> GetButtonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600CC1F RID: 52255 RVA: 0x0030FEB4 File Offset: 0x0030E0B4
		public byte[] GetButtonIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600CC20 RID: 52256 RVA: 0x0030FECC File Offset: 0x0030E0CC
		public string BuffDesc
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC21 RID: 52257 RVA: 0x0030FF04 File Offset: 0x0030E104
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CC22 RID: 52258 RVA: 0x0030FF14 File Offset: 0x0030E114
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC23 RID: 52259 RVA: 0x0030FF2C File Offset: 0x0030E12C
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600CC24 RID: 52260 RVA: 0x0030FF68 File Offset: 0x0030E168
		public int BuffDescParamLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600CC25 RID: 52261 RVA: 0x0030FF94 File Offset: 0x0030E194
		public string BuffDescSimple
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC26 RID: 52262 RVA: 0x0030FFCC File Offset: 0x0030E1CC
		public Span<byte> GetBuffDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600CC27 RID: 52263 RVA: 0x0030FFDC File Offset: 0x0030E1DC
		public byte[] GetBuffDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170031ED RID: 12781
		// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x0030FFF4 File Offset: 0x0030E1F4
		public string BuffName
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC29 RID: 52265 RVA: 0x0031002C File Offset: 0x0030E22C
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600CC2A RID: 52266 RVA: 0x0031003C File Offset: 0x0030E23C
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC2B RID: 52267 RVA: 0x00310054 File Offset: 0x0030E254
		[NullableContext(1)]
		public string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600CC2C RID: 52268 RVA: 0x00310061 File Offset: 0x0030E261
		[NullableContext(1)]
		public IEnumerable<string> BuffDescParamIter()
		{
			RogueWeeklyBuffPool.<BuffDescParamIter>d__58 <BuffDescParamIter>d__ = new RogueWeeklyBuffPool.<BuffDescParamIter>d__58(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600CC2D RID: 52269 RVA: 0x00310076 File Offset: 0x0030E276
		[NullableContext(1)]
		public int[] BuffTagId()
		{
			return this.GetBuffTagIdArray();
		}

		// Token: 0x0600CC2E RID: 52270 RVA: 0x0031007E File Offset: 0x0030E27E
		[NullableContext(1)]
		public IEnumerable<int> BuffTagIdIter()
		{
			RogueWeeklyBuffPool.<BuffTagIdIter>d__60 <BuffTagIdIter>d__ = new RogueWeeklyBuffPool.<BuffTagIdIter>d__60(-2);
			<BuffTagIdIter>d__.<>3__<>4__this = this;
			return <BuffTagIdIter>d__;
		}

		// Token: 0x0600CC2F RID: 52271 RVA: 0x00310093 File Offset: 0x0030E293
		[NullableContext(1)]
		public int[] PerIds()
		{
			return this.GetPerIdsArray();
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x0031009B File Offset: 0x0030E29B
		[NullableContext(1)]
		public IEnumerable<int> PerIdsIter()
		{
			RogueWeeklyBuffPool.<PerIdsIter>d__62 <PerIdsIter>d__ = new RogueWeeklyBuffPool.<PerIdsIter>d__62(-2);
			<PerIdsIter>d__.<>3__<>4__this = this;
			return <PerIdsIter>d__;
		}

		// Token: 0x04005706 RID: 22278
		private Table __p;
	}
}
