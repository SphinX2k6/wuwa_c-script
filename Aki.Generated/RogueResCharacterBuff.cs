using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF5 RID: 4085
	public struct RogueResCharacterBuff : IFlatbufferObject
	{
		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0600C122 RID: 49442 RVA: 0x002E9C04 File Offset: 0x002E7E04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C123 RID: 49443 RVA: 0x002E9C11 File Offset: 0x002E7E11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C124 RID: 49444 RVA: 0x002E9C18 File Offset: 0x002E7E18
		public static RogueResCharacterBuff GetRootAsRogueResCharacterBuff(ByteBuffer _bb)
		{
			return RogueResCharacterBuff.GetRootAsRogueResCharacterBuff(_bb, default(RogueResCharacterBuff));
		}

		// Token: 0x0600C125 RID: 49445 RVA: 0x002E9C34 File Offset: 0x002E7E34
		public static RogueResCharacterBuff GetRootAsRogueResCharacterBuff(ByteBuffer _bb, RogueResCharacterBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C126 RID: 49446 RVA: 0x002E9C51 File Offset: 0x002E7E51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C127 RID: 49447 RVA: 0x002E9C60 File Offset: 0x002E7E60
		public RogueResCharacterBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0600C128 RID: 49448 RVA: 0x002E9C70 File Offset: 0x002E7E70
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

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0600C129 RID: 49449 RVA: 0x002E9CAC File Offset: 0x002E7EAC
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C12A RID: 49450 RVA: 0x002E9CF4 File Offset: 0x002E7EF4
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0600C12B RID: 49451 RVA: 0x002E9D40 File Offset: 0x002E7F40
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

		// Token: 0x0600C12C RID: 49452 RVA: 0x002E9D6B File Offset: 0x002E7F6B
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600C12D RID: 49453 RVA: 0x002E9D7F File Offset: 0x002E7F7F
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0600C12E RID: 49454 RVA: 0x002E9DBC File Offset: 0x002E7FBC
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

		// Token: 0x0600C12F RID: 49455 RVA: 0x002E9DF4 File Offset: 0x002E7FF4
		public Span<byte> GetAffixDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C130 RID: 49456 RVA: 0x002E9E04 File Offset: 0x002E8004
		public byte[] GetAffixDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C131 RID: 49457 RVA: 0x002E9E1C File Offset: 0x002E801C
		public string AffixDescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0600C132 RID: 49458 RVA: 0x002E9E58 File Offset: 0x002E8058
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

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0600C133 RID: 49459 RVA: 0x002E9E84 File Offset: 0x002E8084
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

		// Token: 0x0600C134 RID: 49460 RVA: 0x002E9EBC File Offset: 0x002E80BC
		public Span<byte> GetAffixDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C135 RID: 49461 RVA: 0x002E9ECC File Offset: 0x002E80CC
		public byte[] GetAffixDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0600C136 RID: 49462 RVA: 0x002E9EE4 File Offset: 0x002E80E4
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

		// Token: 0x0600C137 RID: 49463 RVA: 0x002E9F1C File Offset: 0x002E811C
		public Span<byte> GetAffixTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C138 RID: 49464 RVA: 0x002E9F2C File Offset: 0x002E812C
		public byte[] GetAffixTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0600C139 RID: 49465 RVA: 0x002E9F44 File Offset: 0x002E8144
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

		// Token: 0x0600C13A RID: 49466 RVA: 0x002E9F7C File Offset: 0x002E817C
		public Span<byte> GetAffixIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x002E9F8C File Offset: 0x002E818C
		public byte[] GetAffixIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C13C RID: 49468 RVA: 0x002E9FA4 File Offset: 0x002E81A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AffixDescParamIter()或GetAffixDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AffixDescParam()
		{
			return this.AffixDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x002E9FB1 File Offset: 0x002E81B1
		[NullableContext(1)]
		public readonly IEnumerable<string> AffixDescParamIter()
		{
			RogueResCharacterBuff.<AffixDescParamIter>d__37 <AffixDescParamIter>d__ = new RogueResCharacterBuff.<AffixDescParamIter>d__37(-2);
			<AffixDescParamIter>d__.<>3__<>4__this = this;
			return <AffixDescParamIter>d__;
		}

		// Token: 0x0600C13E RID: 49470 RVA: 0x002E9FC8 File Offset: 0x002E81C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			RogueResCharacterBuff rogueResCharacterBuff = this;
			return rogueResCharacterBuff.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600C13F RID: 49471 RVA: 0x002E9FEC File Offset: 0x002E81EC
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			RogueResCharacterBuff.<BuffIdsIter>d__39 <BuffIdsIter>d__ = new RogueResCharacterBuff.<BuffIdsIter>d__39(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x040050DD RID: 20701
		private Table __p;
	}
}
