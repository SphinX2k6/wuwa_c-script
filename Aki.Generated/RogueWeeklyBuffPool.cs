using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102B RID: 4139
	public struct RogueWeeklyBuffPool : IFlatbufferObject
	{
		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x0600C5B9 RID: 50617 RVA: 0x002F3B09 File Offset: 0x002F1D09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C5BA RID: 50618 RVA: 0x002F3B16 File Offset: 0x002F1D16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C5BB RID: 50619 RVA: 0x002F3B20 File Offset: 0x002F1D20
		public static RogueWeeklyBuffPool GetRootAsRogueWeeklyBuffPool(ByteBuffer _bb)
		{
			return RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(_bb, default(RogueWeeklyBuffPool));
		}

		// Token: 0x0600C5BC RID: 50620 RVA: 0x002F3B3C File Offset: 0x002F1D3C
		public static RogueWeeklyBuffPool GetRootAsRogueWeeklyBuffPool(ByteBuffer _bb, RogueWeeklyBuffPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C5BD RID: 50621 RVA: 0x002F3B59 File Offset: 0x002F1D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C5BE RID: 50622 RVA: 0x002F3B68 File Offset: 0x002F1D68
		public RogueWeeklyBuffPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0600C5BF RID: 50623 RVA: 0x002F3B78 File Offset: 0x002F1D78
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

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x0600C5C0 RID: 50624 RVA: 0x002F3BB4 File Offset: 0x002F1DB4
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

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0600C5C1 RID: 50625 RVA: 0x002F3BF0 File Offset: 0x002F1DF0
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(8);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600C5C2 RID: 50626 RVA: 0x002F3C38 File Offset: 0x002F1E38
		public int PerIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0600C5C3 RID: 50627 RVA: 0x002F3C78 File Offset: 0x002F1E78
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

		// Token: 0x0600C5C4 RID: 50628 RVA: 0x002F3CA4 File Offset: 0x002F1EA4
		public Span<int> GetPerIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C5C5 RID: 50629 RVA: 0x002F3CB4 File Offset: 0x002F1EB4
		public int[] GetPerIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0600C5C6 RID: 50630 RVA: 0x002F3CCC File Offset: 0x002F1ECC
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

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600C5C7 RID: 50631 RVA: 0x002F3D0C File Offset: 0x002F1F0C
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

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600C5C8 RID: 50632 RVA: 0x002F3D4C File Offset: 0x002F1F4C
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

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x002F3D84 File Offset: 0x002F1F84
		public Span<byte> GetBuffTriggerActionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x002F3D94 File Offset: 0x002F1F94
		public byte[] GetBuffTriggerActionNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x002F3DAC File Offset: 0x002F1FAC
		public int BuffTagId(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600C5CC RID: 50636 RVA: 0x002F3DEC File Offset: 0x002F1FEC
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

		// Token: 0x0600C5CD RID: 50637 RVA: 0x002F3E18 File Offset: 0x002F2018
		public Span<int> GetBuffTagIdBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C5CE RID: 50638 RVA: 0x002F3E28 File Offset: 0x002F2028
		public int[] GetBuffTagIdArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600C5CF RID: 50639 RVA: 0x002F3E40 File Offset: 0x002F2040
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

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600C5D0 RID: 50640 RVA: 0x002F3E80 File Offset: 0x002F2080
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

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x002F3EB8 File Offset: 0x002F20B8
		public Span<byte> GetBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C5D2 RID: 50642 RVA: 0x002F3EC8 File Offset: 0x002F20C8
		public byte[] GetBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600C5D3 RID: 50643 RVA: 0x002F3EE0 File Offset: 0x002F20E0
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

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x002F3F18 File Offset: 0x002F2118
		public Span<byte> GetButtonIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x002F3F28 File Offset: 0x002F2128
		public byte[] GetButtonIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600C5D6 RID: 50646 RVA: 0x002F3F40 File Offset: 0x002F2140
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

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x002F3F78 File Offset: 0x002F2178
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x002F3F88 File Offset: 0x002F2188
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x002F3FA0 File Offset: 0x002F21A0
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600C5DA RID: 50650 RVA: 0x002F3FDC File Offset: 0x002F21DC
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

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600C5DB RID: 50651 RVA: 0x002F4008 File Offset: 0x002F2208
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

		// Token: 0x0600C5DC RID: 50652 RVA: 0x002F4040 File Offset: 0x002F2240
		public Span<byte> GetBuffDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x002F4050 File Offset: 0x002F2250
		public byte[] GetBuffDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600C5DE RID: 50654 RVA: 0x002F4068 File Offset: 0x002F2268
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

		// Token: 0x0600C5DF RID: 50655 RVA: 0x002F40A0 File Offset: 0x002F22A0
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600C5E0 RID: 50656 RVA: 0x002F40B0 File Offset: 0x002F22B0
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x002F40C8 File Offset: 0x002F22C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffDescParamIter()或GetBuffDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x002F40D5 File Offset: 0x002F22D5
		[NullableContext(1)]
		public readonly IEnumerable<string> BuffDescParamIter()
		{
			RogueWeeklyBuffPool.<BuffDescParamIter>d__58 <BuffDescParamIter>d__ = new RogueWeeklyBuffPool.<BuffDescParamIter>d__58(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x002F40EC File Offset: 0x002F22EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffTagIdIter()或GetBuffTagIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffTagId()
		{
			RogueWeeklyBuffPool rogueWeeklyBuffPool = this;
			return rogueWeeklyBuffPool.GetBuffTagIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x002F4110 File Offset: 0x002F2310
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffTagIdIter()
		{
			RogueWeeklyBuffPool.<BuffTagIdIter>d__60 <BuffTagIdIter>d__ = new RogueWeeklyBuffPool.<BuffTagIdIter>d__60(-2);
			<BuffTagIdIter>d__.<>3__<>4__this = this;
			return <BuffTagIdIter>d__;
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x002F4128 File Offset: 0x002F2328
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PerIdsIter()或GetPerIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PerIds()
		{
			RogueWeeklyBuffPool rogueWeeklyBuffPool = this;
			return rogueWeeklyBuffPool.GetPerIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C5E6 RID: 50662 RVA: 0x002F414C File Offset: 0x002F234C
		[NullableContext(1)]
		public readonly IEnumerable<int> PerIdsIter()
		{
			RogueWeeklyBuffPool.<PerIdsIter>d__62 <PerIdsIter>d__ = new RogueWeeklyBuffPool.<PerIdsIter>d__62(-2);
			<PerIdsIter>d__.<>3__<>4__this = this;
			return <PerIdsIter>d__;
		}

		// Token: 0x0400511E RID: 20766
		private Table __p;
	}
}
