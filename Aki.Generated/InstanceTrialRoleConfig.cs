using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5A RID: 3674
	public struct InstanceTrialRoleConfig : IFlatbufferObject
	{
		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06008BC2 RID: 35778 RVA: 0x0028297E File Offset: 0x00280B7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x0028298B File Offset: 0x00280B8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x00282994 File Offset: 0x00280B94
		public static InstanceTrialRoleConfig GetRootAsInstanceTrialRoleConfig(ByteBuffer _bb)
		{
			return InstanceTrialRoleConfig.GetRootAsInstanceTrialRoleConfig(_bb, default(InstanceTrialRoleConfig));
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x002829B0 File Offset: 0x00280BB0
		public static InstanceTrialRoleConfig GetRootAsInstanceTrialRoleConfig(ByteBuffer _bb, InstanceTrialRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x002829CD File Offset: 0x00280BCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x002829DC File Offset: 0x00280BDC
		public InstanceTrialRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06008BC8 RID: 35784 RVA: 0x002829EC File Offset: 0x00280BEC
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

		// Token: 0x06008BC9 RID: 35785 RVA: 0x00282A28 File Offset: 0x00280C28
		public int MaleFormation(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06008BCA RID: 35786 RVA: 0x00282A68 File Offset: 0x00280C68
		public int MaleFormationLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x00282A93 File Offset: 0x00280C93
		public Span<int> GetMaleFormationBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x00282AA2 File Offset: 0x00280CA2
		public int[] GetMaleFormationArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x00282ABC File Offset: 0x00280CBC
		public int FemaleFormation(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06008BCE RID: 35790 RVA: 0x00282AFC File Offset: 0x00280CFC
		public int FemaleFormationLength
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

		// Token: 0x06008BCF RID: 35791 RVA: 0x00282B27 File Offset: 0x00280D27
		public Span<int> GetFemaleFormationBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x00282B36 File Offset: 0x00280D36
		public int[] GetFemaleFormationArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06008BD1 RID: 35793 RVA: 0x00282B50 File Offset: 0x00280D50
		public int MaleDelayFormation(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x00282B90 File Offset: 0x00280D90
		public int MaleDelayFormationLength
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

		// Token: 0x06008BD3 RID: 35795 RVA: 0x00282BBC File Offset: 0x00280DBC
		public Span<int> GetMaleDelayFormationBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x00282BCC File Offset: 0x00280DCC
		public int[] GetMaleDelayFormationArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x00282BE4 File Offset: 0x00280DE4
		public int FemaleDelayFormation(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06008BD6 RID: 35798 RVA: 0x00282C24 File Offset: 0x00280E24
		public int FemaleDelayFormationLength
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

		// Token: 0x06008BD7 RID: 35799 RVA: 0x00282C50 File Offset: 0x00280E50
		public Span<int> GetFemaleDelayFormationBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x00282C60 File Offset: 0x00280E60
		public int[] GetFemaleDelayFormationArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06008BD9 RID: 35801 RVA: 0x00282C78 File Offset: 0x00280E78
		public bool OnlyTrial
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06008BDA RID: 35802 RVA: 0x00282CB8 File Offset: 0x00280EB8
		public bool AutoChange
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06008BDB RID: 35803 RVA: 0x00282CF8 File Offset: 0x00280EF8
		public bool ShowInEntrance
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x00282D38 File Offset: 0x00280F38
		[NullableContext(1)]
		public int[] FemaleDelayFormation()
		{
			return this.GetFemaleDelayFormationArray();
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x00282D40 File Offset: 0x00280F40
		[NullableContext(1)]
		public IEnumerable<int> FemaleDelayFormationIter()
		{
			InstanceTrialRoleConfig.<FemaleDelayFormationIter>d__37 <FemaleDelayFormationIter>d__ = new InstanceTrialRoleConfig.<FemaleDelayFormationIter>d__37(-2);
			<FemaleDelayFormationIter>d__.<>3__<>4__this = this;
			return <FemaleDelayFormationIter>d__;
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x00282D55 File Offset: 0x00280F55
		[NullableContext(1)]
		public int[] FemaleFormation()
		{
			return this.GetFemaleFormationArray();
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x00282D5D File Offset: 0x00280F5D
		[NullableContext(1)]
		public IEnumerable<int> FemaleFormationIter()
		{
			InstanceTrialRoleConfig.<FemaleFormationIter>d__39 <FemaleFormationIter>d__ = new InstanceTrialRoleConfig.<FemaleFormationIter>d__39(-2);
			<FemaleFormationIter>d__.<>3__<>4__this = this;
			return <FemaleFormationIter>d__;
		}

		// Token: 0x06008BE0 RID: 35808 RVA: 0x00282D72 File Offset: 0x00280F72
		[NullableContext(1)]
		public int[] MaleDelayFormation()
		{
			return this.GetMaleDelayFormationArray();
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x00282D7A File Offset: 0x00280F7A
		[NullableContext(1)]
		public IEnumerable<int> MaleDelayFormationIter()
		{
			InstanceTrialRoleConfig.<MaleDelayFormationIter>d__41 <MaleDelayFormationIter>d__ = new InstanceTrialRoleConfig.<MaleDelayFormationIter>d__41(-2);
			<MaleDelayFormationIter>d__.<>3__<>4__this = this;
			return <MaleDelayFormationIter>d__;
		}

		// Token: 0x06008BE2 RID: 35810 RVA: 0x00282D8F File Offset: 0x00280F8F
		[NullableContext(1)]
		public int[] MaleFormation()
		{
			return this.GetMaleFormationArray();
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x00282D97 File Offset: 0x00280F97
		[NullableContext(1)]
		public IEnumerable<int> MaleFormationIter()
		{
			InstanceTrialRoleConfig.<MaleFormationIter>d__43 <MaleFormationIter>d__ = new InstanceTrialRoleConfig.<MaleFormationIter>d__43(-2);
			<MaleFormationIter>d__.<>3__<>4__this = this;
			return <MaleFormationIter>d__;
		}

		// Token: 0x040053E2 RID: 21474
		private Table __p;
	}
}
