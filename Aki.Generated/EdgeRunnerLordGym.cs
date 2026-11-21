using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFD RID: 3325
	public struct EdgeRunnerLordGym : IFlatbufferObject
	{
		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06006CF3 RID: 27891 RVA: 0x0023E189 File Offset: 0x0023C389
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x0023E196 File Offset: 0x0023C396
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x0023E1A0 File Offset: 0x0023C3A0
		public static EdgeRunnerLordGym GetRootAsEdgeRunnerLordGym(ByteBuffer _bb)
		{
			return EdgeRunnerLordGym.GetRootAsEdgeRunnerLordGym(_bb, default(EdgeRunnerLordGym));
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x0023E1BC File Offset: 0x0023C3BC
		public static EdgeRunnerLordGym GetRootAsEdgeRunnerLordGym(ByteBuffer _bb, EdgeRunnerLordGym obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x0023E1D9 File Offset: 0x0023C3D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x0023E1E8 File Offset: 0x0023C3E8
		public EdgeRunnerLordGym __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x0023E1F8 File Offset: 0x0023C3F8
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

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x0023E234 File Offset: 0x0023C434
		public int ActivityId
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

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x0023E270 File Offset: 0x0023C470
		public int IsHard
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

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06006CFC RID: 27900 RVA: 0x0023E2AC File Offset: 0x0023C4AC
		public int InstId
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

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06006CFD RID: 27901 RVA: 0x0023E2EC File Offset: 0x0023C4EC
		public int PlayId
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

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06006CFE RID: 27902 RVA: 0x0023E32C File Offset: 0x0023C52C
		public int RewardId
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

		// Token: 0x06006CFF RID: 27903 RVA: 0x0023E36C File Offset: 0x0023C56C
		public int TrialRole(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x0023E3AC File Offset: 0x0023C5AC
		public int TrialRoleLength
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

		// Token: 0x06006D01 RID: 27905 RVA: 0x0023E3D8 File Offset: 0x0023C5D8
		public Span<int> GetTrialRoleBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x0023E3E8 File Offset: 0x0023C5E8
		public int[] GetTrialRoleArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x0023E400 File Offset: 0x0023C600
		public int UpRole(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06006D04 RID: 27908 RVA: 0x0023E440 File Offset: 0x0023C640
		public int UpRoleLength
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

		// Token: 0x06006D05 RID: 27909 RVA: 0x0023E46C File Offset: 0x0023C66C
		public Span<int> GetUpRoleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x0023E47C File Offset: 0x0023C67C
		public int[] GetUpRoleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06006D07 RID: 27911 RVA: 0x0023E494 File Offset: 0x0023C694
		public string LevelTitle
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

		// Token: 0x06006D08 RID: 27912 RVA: 0x0023E4CC File Offset: 0x0023C6CC
		public Span<byte> GetLevelTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x0023E4DC File Offset: 0x0023C6DC
		public byte[] GetLevelTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06006D0A RID: 27914 RVA: 0x0023E4F4 File Offset: 0x0023C6F4
		public string Title
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

		// Token: 0x06006D0B RID: 27915 RVA: 0x0023E52C File Offset: 0x0023C72C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x0023E53C File Offset: 0x0023C73C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x0023E554 File Offset: 0x0023C754
		public string BuffDesc
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

		// Token: 0x06006D0E RID: 27918 RVA: 0x0023E58C File Offset: 0x0023C78C
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x0023E59C File Offset: 0x0023C79C
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x0023E5B4 File Offset: 0x0023C7B4
		public string BuffNum(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x0023E5F0 File Offset: 0x0023C7F0
		public int BuffNumLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06006D12 RID: 27922 RVA: 0x0023E61C File Offset: 0x0023C81C
		public int Level
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x0023E65C File Offset: 0x0023C85C
		public int MeshId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x0023E69C File Offset: 0x0023C89C
		public float Zoom(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x0023E6E0 File Offset: 0x0023C8E0
		public int ZoomLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006D16 RID: 27926 RVA: 0x0023E70C File Offset: 0x0023C90C
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(32, 4);
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x0023E71C File Offset: 0x0023C91C
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(32) ?? Array.Empty<float>();
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x0023E734 File Offset: 0x0023C934
		public float Location(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x0023E778 File Offset: 0x0023C978
		public int LocationLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x0023E7A4 File Offset: 0x0023C9A4
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(34, 4);
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x0023E7B4 File Offset: 0x0023C9B4
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(34) ?? Array.Empty<float>();
		}

		// Token: 0x06006D1C RID: 27932 RVA: 0x0023E7CC File Offset: 0x0023C9CC
		public float Rotator(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06006D1D RID: 27933 RVA: 0x0023E810 File Offset: 0x0023CA10
		public int RotatorLength
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

		// Token: 0x06006D1E RID: 27934 RVA: 0x0023E83C File Offset: 0x0023CA3C
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(36, 4);
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x0023E84C File Offset: 0x0023CA4C
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(36) ?? Array.Empty<float>();
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06006D20 RID: 27936 RVA: 0x0023E864 File Offset: 0x0023CA64
		public string LordUISceneEffect
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

		// Token: 0x06006D21 RID: 27937 RVA: 0x0023E89C File Offset: 0x0023CA9C
		public Span<byte> GetLordUISceneEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x0023E8AC File Offset: 0x0023CAAC
		public byte[] GetLordUISceneEffectArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06006D23 RID: 27939 RVA: 0x0023E8C4 File Offset: 0x0023CAC4
		public string MaterialController
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

		// Token: 0x06006D24 RID: 27940 RVA: 0x0023E8FC File Offset: 0x0023CAFC
		public Span<byte> GetMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x0023E90C File Offset: 0x0023CB0C
		public byte[] GetMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06006D26 RID: 27942 RVA: 0x0023E924 File Offset: 0x0023CB24
		public string StandAnim
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x0023E95C File Offset: 0x0023CB5C
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x0023E96C File Offset: 0x0023CB6C
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x0023E984 File Offset: 0x0023CB84
		[NullableContext(1)]
		public string[] BuffNum()
		{
			return this.BuffNumIter().ToArray<string>();
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x0023E991 File Offset: 0x0023CB91
		[NullableContext(1)]
		public IEnumerable<string> BuffNumIter()
		{
			EdgeRunnerLordGym.<BuffNumIter>d__77 <BuffNumIter>d__ = new EdgeRunnerLordGym.<BuffNumIter>d__77(-2);
			<BuffNumIter>d__.<>3__<>4__this = this;
			return <BuffNumIter>d__;
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x0023E9A6 File Offset: 0x0023CBA6
		[NullableContext(1)]
		public float[] Location()
		{
			return this.GetLocationArray();
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x0023E9AE File Offset: 0x0023CBAE
		[NullableContext(1)]
		public IEnumerable<float> LocationIter()
		{
			EdgeRunnerLordGym.<LocationIter>d__79 <LocationIter>d__ = new EdgeRunnerLordGym.<LocationIter>d__79(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x0023E9C3 File Offset: 0x0023CBC3
		[NullableContext(1)]
		public float[] Rotator()
		{
			return this.GetRotatorArray();
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x0023E9CB File Offset: 0x0023CBCB
		[NullableContext(1)]
		public IEnumerable<float> RotatorIter()
		{
			EdgeRunnerLordGym.<RotatorIter>d__81 <RotatorIter>d__ = new EdgeRunnerLordGym.<RotatorIter>d__81(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x0023E9E0 File Offset: 0x0023CBE0
		[NullableContext(1)]
		public int[] TrialRole()
		{
			return this.GetTrialRoleArray();
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x0023E9E8 File Offset: 0x0023CBE8
		[NullableContext(1)]
		public IEnumerable<int> TrialRoleIter()
		{
			EdgeRunnerLordGym.<TrialRoleIter>d__83 <TrialRoleIter>d__ = new EdgeRunnerLordGym.<TrialRoleIter>d__83(-2);
			<TrialRoleIter>d__.<>3__<>4__this = this;
			return <TrialRoleIter>d__;
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x0023E9FD File Offset: 0x0023CBFD
		[NullableContext(1)]
		public int[] UpRole()
		{
			return this.GetUpRoleArray();
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x0023EA05 File Offset: 0x0023CC05
		[NullableContext(1)]
		public IEnumerable<int> UpRoleIter()
		{
			EdgeRunnerLordGym.<UpRoleIter>d__85 <UpRoleIter>d__ = new EdgeRunnerLordGym.<UpRoleIter>d__85(-2);
			<UpRoleIter>d__.<>3__<>4__this = this;
			return <UpRoleIter>d__;
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x0023EA1A File Offset: 0x0023CC1A
		[NullableContext(1)]
		public float[] Zoom()
		{
			return this.GetZoomArray();
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x0023EA22 File Offset: 0x0023CC22
		[NullableContext(1)]
		public IEnumerable<float> ZoomIter()
		{
			EdgeRunnerLordGym.<ZoomIter>d__87 <ZoomIter>d__ = new EdgeRunnerLordGym.<ZoomIter>d__87(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x0400523D RID: 21053
		private Table __p;
	}
}
