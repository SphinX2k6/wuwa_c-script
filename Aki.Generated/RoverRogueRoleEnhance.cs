using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001085 RID: 4229
	public struct RoverRogueRoleEnhance : IFlatbufferObject
	{
		// Token: 0x170034A8 RID: 13480
		// (get) Token: 0x0600CED7 RID: 52951 RVA: 0x00308627 File Offset: 0x00306827
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CED8 RID: 52952 RVA: 0x00308634 File Offset: 0x00306834
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CED9 RID: 52953 RVA: 0x0030863C File Offset: 0x0030683C
		public static RoverRogueRoleEnhance GetRootAsRoverRogueRoleEnhance(ByteBuffer _bb)
		{
			return RoverRogueRoleEnhance.GetRootAsRoverRogueRoleEnhance(_bb, default(RoverRogueRoleEnhance));
		}

		// Token: 0x0600CEDA RID: 52954 RVA: 0x00308658 File Offset: 0x00306858
		public static RoverRogueRoleEnhance GetRootAsRoverRogueRoleEnhance(ByteBuffer _bb, RoverRogueRoleEnhance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEDB RID: 52955 RVA: 0x00308675 File Offset: 0x00306875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEDC RID: 52956 RVA: 0x00308684 File Offset: 0x00306884
		public RoverRogueRoleEnhance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600CEDD RID: 52957 RVA: 0x00308694 File Offset: 0x00306894
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

		// Token: 0x0600CEDE RID: 52958 RVA: 0x003086D0 File Offset: 0x003068D0
		public int RoleType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600CEDF RID: 52959 RVA: 0x00308710 File Offset: 0x00306910
		public int RoleTypeLength
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

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x0030873B File Offset: 0x0030693B
		public Span<int> GetRoleTypeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x0030874A File Offset: 0x0030694A
		public int[] GetRoleTypeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600CEE2 RID: 52962 RVA: 0x00308764 File Offset: 0x00306964
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x0030879B File Offset: 0x0030699B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x003087AA File Offset: 0x003069AA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170034AC RID: 13484
		// (get) Token: 0x0600CEE5 RID: 52965 RVA: 0x003087C4 File Offset: 0x003069C4
		public string Desc
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

		// Token: 0x0600CEE6 RID: 52966 RVA: 0x003087FC File Offset: 0x003069FC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CEE7 RID: 52967 RVA: 0x0030880C File Offset: 0x00306A0C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CEE8 RID: 52968 RVA: 0x00308824 File Offset: 0x00306A24
		public string DescParams(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034AD RID: 13485
		// (get) Token: 0x0600CEE9 RID: 52969 RVA: 0x00308860 File Offset: 0x00306A60
		public int DescParamsLength
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

		// Token: 0x170034AE RID: 13486
		// (get) Token: 0x0600CEEA RID: 52970 RVA: 0x0030888C File Offset: 0x00306A8C
		public string BriefDesc
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

		// Token: 0x0600CEEB RID: 52971 RVA: 0x003088C4 File Offset: 0x00306AC4
		public Span<byte> GetBriefDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CEEC RID: 52972 RVA: 0x003088D4 File Offset: 0x00306AD4
		public byte[] GetBriefDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CEED RID: 52973 RVA: 0x003088EC File Offset: 0x00306AEC
		public string BriefDescParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034AF RID: 13487
		// (get) Token: 0x0600CEEE RID: 52974 RVA: 0x00308928 File Offset: 0x00306B28
		public int BriefDescParamsLength
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

		// Token: 0x170034B0 RID: 13488
		// (get) Token: 0x0600CEEF RID: 52975 RVA: 0x00308954 File Offset: 0x00306B54
		public string AdditionText
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

		// Token: 0x0600CEF0 RID: 52976 RVA: 0x0030898C File Offset: 0x00306B8C
		public Span<byte> GetAdditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CEF1 RID: 52977 RVA: 0x0030899C File Offset: 0x00306B9C
		public byte[] GetAdditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x003089B4 File Offset: 0x00306BB4
		public string AdditionParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034B1 RID: 13489
		// (get) Token: 0x0600CEF3 RID: 52979 RVA: 0x003089F0 File Offset: 0x00306BF0
		public int AdditionParamsLength
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

		// Token: 0x170034B2 RID: 13490
		// (get) Token: 0x0600CEF4 RID: 52980 RVA: 0x00308A1C File Offset: 0x00306C1C
		public string Icon
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

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x00308A54 File Offset: 0x00306C54
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x00308A64 File Offset: 0x00306C64
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170034B3 RID: 13491
		// (get) Token: 0x0600CEF7 RID: 52983 RVA: 0x00308A7C File Offset: 0x00306C7C
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600CEF8 RID: 52984 RVA: 0x00308ABC File Offset: 0x00306CBC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AdditionParamsIter()或GetAdditionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AdditionParams()
		{
			return this.AdditionParamsIter().ToArray<string>();
		}

		// Token: 0x0600CEF9 RID: 52985 RVA: 0x00308AC9 File Offset: 0x00306CC9
		[NullableContext(1)]
		public readonly IEnumerable<string> AdditionParamsIter()
		{
			RoverRogueRoleEnhance.<AdditionParamsIter>d__47 <AdditionParamsIter>d__ = new RoverRogueRoleEnhance.<AdditionParamsIter>d__47(-2);
			<AdditionParamsIter>d__.<>3__<>4__this = this;
			return <AdditionParamsIter>d__;
		}

		// Token: 0x0600CEFA RID: 52986 RVA: 0x00308ADE File Offset: 0x00306CDE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BriefDescParamsIter()或GetBriefDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BriefDescParams()
		{
			return this.BriefDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600CEFB RID: 52987 RVA: 0x00308AEB File Offset: 0x00306CEB
		[NullableContext(1)]
		public readonly IEnumerable<string> BriefDescParamsIter()
		{
			RoverRogueRoleEnhance.<BriefDescParamsIter>d__49 <BriefDescParamsIter>d__ = new RoverRogueRoleEnhance.<BriefDescParamsIter>d__49(-2);
			<BriefDescParamsIter>d__.<>3__<>4__this = this;
			return <BriefDescParamsIter>d__;
		}

		// Token: 0x0600CEFC RID: 52988 RVA: 0x00308B00 File Offset: 0x00306D00
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600CEFD RID: 52989 RVA: 0x00308B0D File Offset: 0x00306D0D
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			RoverRogueRoleEnhance.<DescParamsIter>d__51 <DescParamsIter>d__ = new RoverRogueRoleEnhance.<DescParamsIter>d__51(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x00308B24 File Offset: 0x00306D24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleTypeIter()或GetRoleTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleType()
		{
			RoverRogueRoleEnhance roverRogueRoleEnhance = this;
			return roverRogueRoleEnhance.GetRoleTypeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CEFF RID: 52991 RVA: 0x00308B48 File Offset: 0x00306D48
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleTypeIter()
		{
			RoverRogueRoleEnhance.<RoleTypeIter>d__53 <RoleTypeIter>d__ = new RoverRogueRoleEnhance.<RoleTypeIter>d__53(-2);
			<RoleTypeIter>d__.<>3__<>4__this = this;
			return <RoleTypeIter>d__;
		}

		// Token: 0x04005191 RID: 20881
		private Table __p;
	}
}
