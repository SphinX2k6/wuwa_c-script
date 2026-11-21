using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA9 RID: 3753
	public struct LifeMaxCustomization : IFlatbufferObject
	{
		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x060093B4 RID: 37812 RVA: 0x002950D5 File Offset: 0x002932D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x002950E2 File Offset: 0x002932E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x002950EC File Offset: 0x002932EC
		public static LifeMaxCustomization GetRootAsLifeMaxCustomization(ByteBuffer _bb)
		{
			return LifeMaxCustomization.GetRootAsLifeMaxCustomization(_bb, default(LifeMaxCustomization));
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x00295108 File Offset: 0x00293308
		public static LifeMaxCustomization GetRootAsLifeMaxCustomization(ByteBuffer _bb, LifeMaxCustomization obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x00295125 File Offset: 0x00293325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x00295134 File Offset: 0x00293334
		public LifeMaxCustomization __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x060093BA RID: 37818 RVA: 0x00295144 File Offset: 0x00293344
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

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x060093BB RID: 37819 RVA: 0x00295180 File Offset: 0x00293380
		public int LifeCustomType
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

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x060093BC RID: 37820 RVA: 0x002951BC File Offset: 0x002933BC
		public int SingleTubeLife
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

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x060093BD RID: 37821 RVA: 0x002951F8 File Offset: 0x002933F8
		public int LifeCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x060093BE RID: 37822 RVA: 0x00295238 File Offset: 0x00293438
		public int RageMaxCustom
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

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x060093BF RID: 37823 RVA: 0x00295278 File Offset: 0x00293478
		public int InitLifeCount
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

		// Token: 0x060093C0 RID: 37824 RVA: 0x002952B8 File Offset: 0x002934B8
		public int SingleTubeLifeArr(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x002952F8 File Offset: 0x002934F8
		public int SingleTubeLifeArrLength
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

		// Token: 0x060093C2 RID: 37826 RVA: 0x00295324 File Offset: 0x00293524
		public Span<int> GetSingleTubeLifeArrBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x00295334 File Offset: 0x00293534
		public int[] GetSingleTubeLifeArrArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x0029534C File Offset: 0x0029354C
		public int LifeCountAttr(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x0029538C File Offset: 0x0029358C
		public int LifeCountAttrLength
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

		// Token: 0x060093C6 RID: 37830 RVA: 0x002953B8 File Offset: 0x002935B8
		public Span<int> GetLifeCountAttrBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x002953C8 File Offset: 0x002935C8
		public int[] GetLifeCountAttrArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x002953E0 File Offset: 0x002935E0
		public int RageMaxCustomArr(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x060093C9 RID: 37833 RVA: 0x00295420 File Offset: 0x00293620
		public int RageMaxCustomArrLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x0029544C File Offset: 0x0029364C
		public Span<int> GetRageMaxCustomArrBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x0029545C File Offset: 0x0029365C
		public int[] GetRageMaxCustomArrArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x00295474 File Offset: 0x00293674
		public int InitLifeCountAttr(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x060093CD RID: 37837 RVA: 0x002954B4 File Offset: 0x002936B4
		public int InitLifeCountAttrLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x002954E0 File Offset: 0x002936E0
		public Span<int> GetInitLifeCountAttrBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x002954F0 File Offset: 0x002936F0
		public int[] GetInitLifeCountAttrArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x00295508 File Offset: 0x00293708
		public string CustomColorSet(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x060093D1 RID: 37841 RVA: 0x00295544 File Offset: 0x00293744
		public int CustomColorSetLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x00295570 File Offset: 0x00293770
		[NullableContext(1)]
		public string[] CustomColorSet()
		{
			return this.CustomColorSetIter().ToArray<string>();
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x0029557D File Offset: 0x0029377D
		[NullableContext(1)]
		public IEnumerable<string> CustomColorSetIter()
		{
			LifeMaxCustomization.<CustomColorSetIter>d__44 <CustomColorSetIter>d__ = new LifeMaxCustomization.<CustomColorSetIter>d__44(-2);
			<CustomColorSetIter>d__.<>3__<>4__this = this;
			return <CustomColorSetIter>d__;
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x00295592 File Offset: 0x00293792
		[NullableContext(1)]
		public int[] InitLifeCountAttr()
		{
			return this.GetInitLifeCountAttrArray();
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x0029559A File Offset: 0x0029379A
		[NullableContext(1)]
		public IEnumerable<int> InitLifeCountAttrIter()
		{
			LifeMaxCustomization.<InitLifeCountAttrIter>d__46 <InitLifeCountAttrIter>d__ = new LifeMaxCustomization.<InitLifeCountAttrIter>d__46(-2);
			<InitLifeCountAttrIter>d__.<>3__<>4__this = this;
			return <InitLifeCountAttrIter>d__;
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x002955AF File Offset: 0x002937AF
		[NullableContext(1)]
		public int[] LifeCountAttr()
		{
			return this.GetLifeCountAttrArray();
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x002955B7 File Offset: 0x002937B7
		[NullableContext(1)]
		public IEnumerable<int> LifeCountAttrIter()
		{
			LifeMaxCustomization.<LifeCountAttrIter>d__48 <LifeCountAttrIter>d__ = new LifeMaxCustomization.<LifeCountAttrIter>d__48(-2);
			<LifeCountAttrIter>d__.<>3__<>4__this = this;
			return <LifeCountAttrIter>d__;
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x002955CC File Offset: 0x002937CC
		[NullableContext(1)]
		public int[] RageMaxCustomArr()
		{
			return this.GetRageMaxCustomArrArray();
		}

		// Token: 0x060093D9 RID: 37849 RVA: 0x002955D4 File Offset: 0x002937D4
		[NullableContext(1)]
		public IEnumerable<int> RageMaxCustomArrIter()
		{
			LifeMaxCustomization.<RageMaxCustomArrIter>d__50 <RageMaxCustomArrIter>d__ = new LifeMaxCustomization.<RageMaxCustomArrIter>d__50(-2);
			<RageMaxCustomArrIter>d__.<>3__<>4__this = this;
			return <RageMaxCustomArrIter>d__;
		}

		// Token: 0x060093DA RID: 37850 RVA: 0x002955E9 File Offset: 0x002937E9
		[NullableContext(1)]
		public int[] SingleTubeLifeArr()
		{
			return this.GetSingleTubeLifeArrArray();
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x002955F1 File Offset: 0x002937F1
		[NullableContext(1)]
		public IEnumerable<int> SingleTubeLifeArrIter()
		{
			LifeMaxCustomization.<SingleTubeLifeArrIter>d__52 <SingleTubeLifeArrIter>d__ = new LifeMaxCustomization.<SingleTubeLifeArrIter>d__52(-2);
			<SingleTubeLifeArrIter>d__.<>3__<>4__this = this;
			return <SingleTubeLifeArrIter>d__;
		}

		// Token: 0x0400543F RID: 21567
		private Table __p;
	}
}
