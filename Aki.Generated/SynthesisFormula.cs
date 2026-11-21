using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001247 RID: 4679
	public struct SynthesisFormula : IFlatbufferObject
	{
		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x0600E9C6 RID: 59846 RVA: 0x00353AF0 File Offset: 0x00351CF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E9C7 RID: 59847 RVA: 0x00353AFD File Offset: 0x00351CFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E9C8 RID: 59848 RVA: 0x00353B04 File Offset: 0x00351D04
		public static SynthesisFormula GetRootAsSynthesisFormula(ByteBuffer _bb)
		{
			return SynthesisFormula.GetRootAsSynthesisFormula(_bb, default(SynthesisFormula));
		}

		// Token: 0x0600E9C9 RID: 59849 RVA: 0x00353B20 File Offset: 0x00351D20
		public static SynthesisFormula GetRootAsSynthesisFormula(ByteBuffer _bb, SynthesisFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E9CA RID: 59850 RVA: 0x00353B3D File Offset: 0x00351D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E9CB RID: 59851 RVA: 0x00353B4C File Offset: 0x00351D4C
		public SynthesisFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x00353B5C File Offset: 0x00351D5C
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

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x0600E9CD RID: 59853 RVA: 0x00353B98 File Offset: 0x00351D98
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

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x0600E9CE RID: 59854 RVA: 0x00353BD4 File Offset: 0x00351DD4
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

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600E9CF RID: 59855 RVA: 0x00353C10 File Offset: 0x00351E10
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

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x00353C50 File Offset: 0x00351E50
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

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600E9D1 RID: 59857 RVA: 0x00353C90 File Offset: 0x00351E90
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

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x00353CC8 File Offset: 0x00351EC8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E9D3 RID: 59859 RVA: 0x00353CD8 File Offset: 0x00351ED8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x00353CF0 File Offset: 0x00351EF0
		public OneItemConfig? ConsumeItems(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600E9D5 RID: 59861 RVA: 0x00353D54 File Offset: 0x00351F54
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

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0600E9D6 RID: 59862 RVA: 0x00353D80 File Offset: 0x00351F80
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

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0600E9D7 RID: 59863 RVA: 0x00353DC0 File Offset: 0x00351FC0
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

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0600E9D8 RID: 59864 RVA: 0x00353E00 File Offset: 0x00352000
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

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x0600E9D9 RID: 59865 RVA: 0x00353E40 File Offset: 0x00352040
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

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x0600E9DA RID: 59866 RVA: 0x00353E80 File Offset: 0x00352080
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

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x00353EC0 File Offset: 0x003520C0
		public bool IsCollect
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600E9DC RID: 59868 RVA: 0x00353F00 File Offset: 0x00352100
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600E9DD RID: 59869 RVA: 0x00353F40 File Offset: 0x00352140
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

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600E9DE RID: 59870 RVA: 0x00353F80 File Offset: 0x00352180
		public bool PermanentLimit
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E9DF RID: 59871 RVA: 0x00353FC0 File Offset: 0x003521C0
		public int RoleList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600E9E0 RID: 59872 RVA: 0x00354000 File Offset: 0x00352200
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

		// Token: 0x0600E9E1 RID: 59873 RVA: 0x0035402C File Offset: 0x0035222C
		public Span<int> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x0035403C File Offset: 0x0035223C
		public int[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0600E9E3 RID: 59875 RVA: 0x00354054 File Offset: 0x00352254
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

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x0035408C File Offset: 0x0035228C
		public Span<byte> GetComposeContentBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x0035409C File Offset: 0x0035229C
		public byte[] GetComposeContentArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600E9E6 RID: 59878 RVA: 0x003540B4 File Offset: 0x003522B4
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

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x003540EC File Offset: 0x003522EC
		public Span<byte> GetComposeBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x003540FC File Offset: 0x003522FC
		public byte[] GetComposeBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E9E9 RID: 59881 RVA: 0x00354114 File Offset: 0x00352314
		[NullableContext(1)]
		public OneItemConfig[] ConsumeItems()
		{
			return this.ConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600E9EA RID: 59882 RVA: 0x00354121 File Offset: 0x00352321
		[NullableContext(1)]
		public IEnumerable<OneItemConfig> ConsumeItemsIter()
		{
			SynthesisFormula.<ConsumeItemsIter>d__57 <ConsumeItemsIter>d__ = new SynthesisFormula.<ConsumeItemsIter>d__57(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x0600E9EB RID: 59883 RVA: 0x00354136 File Offset: 0x00352336
		[NullableContext(1)]
		public int[] RoleList()
		{
			return this.GetRoleListArray();
		}

		// Token: 0x0600E9EC RID: 59884 RVA: 0x0035413E File Offset: 0x0035233E
		[NullableContext(1)]
		public IEnumerable<int> RoleListIter()
		{
			SynthesisFormula.<RoleListIter>d__59 <RoleListIter>d__ = new SynthesisFormula.<RoleListIter>d__59(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x04005891 RID: 22673
		private Table __p;
	}
}
