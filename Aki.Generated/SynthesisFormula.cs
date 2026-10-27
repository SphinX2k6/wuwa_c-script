using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001111 RID: 4369
	public struct SynthesisFormula : IFlatbufferObject
	{
		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0600DC7B RID: 56443 RVA: 0x00328960 File Offset: 0x00326B60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x0032896D File Offset: 0x00326B6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC7D RID: 56445 RVA: 0x00328974 File Offset: 0x00326B74
		public static SynthesisFormula GetRootAsSynthesisFormula(ByteBuffer _bb)
		{
			return SynthesisFormula.GetRootAsSynthesisFormula(_bb, default(SynthesisFormula));
		}

		// Token: 0x0600DC7E RID: 56446 RVA: 0x00328990 File Offset: 0x00326B90
		public static SynthesisFormula GetRootAsSynthesisFormula(ByteBuffer _bb, SynthesisFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC7F RID: 56447 RVA: 0x003289AD File Offset: 0x00326BAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC80 RID: 56448 RVA: 0x003289BC File Offset: 0x00326BBC
		public SynthesisFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0600DC81 RID: 56449 RVA: 0x003289CC File Offset: 0x00326BCC
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

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0600DC82 RID: 56450 RVA: 0x00328A08 File Offset: 0x00326C08
		public int FormulaItemId
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

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0600DC83 RID: 56451 RVA: 0x00328A44 File Offset: 0x00326C44
		public int ItemId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0600DC84 RID: 56452 RVA: 0x00328A80 File Offset: 0x00326C80
		public int FormulaType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600DC85 RID: 56453 RVA: 0x00328AC0 File Offset: 0x00326CC0
		public int ItemGroup
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600DC86 RID: 56454 RVA: 0x00328B00 File Offset: 0x00326D00
		public string Name
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

		// Token: 0x0600DC87 RID: 56455 RVA: 0x00328B38 File Offset: 0x00326D38
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DC88 RID: 56456 RVA: 0x00328B48 File Offset: 0x00326D48
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DC89 RID: 56457 RVA: 0x00328B60 File Offset: 0x00326D60
		public OneItemConfig? ConsumeItems(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600DC8A RID: 56458 RVA: 0x00328BC4 File Offset: 0x00326DC4
		public int ConsumeItemsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600DC8B RID: 56459 RVA: 0x00328BF0 File Offset: 0x00326DF0
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600DC8C RID: 56460 RVA: 0x00328C30 File Offset: 0x00326E30
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600DC8D RID: 56461 RVA: 0x00328C70 File Offset: 0x00326E70
		public int Proficiency
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0600DC8E RID: 56462 RVA: 0x00328CB0 File Offset: 0x00326EB0
		public int MaxProficiencyCount
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600DC8F RID: 56463 RVA: 0x00328CF0 File Offset: 0x00326EF0
		public int TypeId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600DC90 RID: 56464 RVA: 0x00328D30 File Offset: 0x00326F30
		public bool IsCollect
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600DC91 RID: 56465 RVA: 0x00328D70 File Offset: 0x00326F70
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600DC92 RID: 56466 RVA: 0x00328DB0 File Offset: 0x00326FB0
		public int LimitCount
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600DC93 RID: 56467 RVA: 0x00328DF0 File Offset: 0x00326FF0
		public bool PermanentLimit
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600DC94 RID: 56468 RVA: 0x00328E30 File Offset: 0x00327030
		public int RoleList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0600DC95 RID: 56469 RVA: 0x00328E70 File Offset: 0x00327070
		public int RoleListLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DC96 RID: 56470 RVA: 0x00328E9C File Offset: 0x0032709C
		public Span<int> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600DC97 RID: 56471 RVA: 0x00328EAC File Offset: 0x003270AC
		public int[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600DC98 RID: 56472 RVA: 0x00328EC4 File Offset: 0x003270C4
		public string ComposeContent
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC99 RID: 56473 RVA: 0x00328EFC File Offset: 0x003270FC
		public Span<byte> GetComposeContentBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600DC9A RID: 56474 RVA: 0x00328F0C File Offset: 0x0032710C
		public byte[] GetComposeContentArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600DC9B RID: 56475 RVA: 0x00328F24 File Offset: 0x00327124
		public string ComposeBackground
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC9C RID: 56476 RVA: 0x00328F5C File Offset: 0x0032715C
		public Span<byte> GetComposeBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600DC9D RID: 56477 RVA: 0x00328F6C File Offset: 0x0032716C
		public byte[] GetComposeBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DC9E RID: 56478 RVA: 0x00328F84 File Offset: 0x00327184
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConsumeItemsIter()或GetConsumeItemsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly OneItemConfig[] ConsumeItems()
		{
			return this.ConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600DC9F RID: 56479 RVA: 0x00328F91 File Offset: 0x00327191
		[NullableContext(1)]
		public readonly IEnumerable<OneItemConfig> ConsumeItemsIter()
		{
			SynthesisFormula.<ConsumeItemsIter>d__57 <ConsumeItemsIter>d__ = new SynthesisFormula.<ConsumeItemsIter>d__57(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x0600DCA0 RID: 56480 RVA: 0x00328FA8 File Offset: 0x003271A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleListIter()或GetRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleList()
		{
			SynthesisFormula synthesisFormula = this;
			return synthesisFormula.GetRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DCA1 RID: 56481 RVA: 0x00328FCC File Offset: 0x003271CC
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleListIter()
		{
			SynthesisFormula.<RoleListIter>d__59 <RoleListIter>d__ = new SynthesisFormula.<RoleListIter>d__59(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x0400524E RID: 21070
		private Table __p;
	}
}
