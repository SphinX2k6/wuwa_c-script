using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001180 RID: 4480
	public struct RoverRogueRoleEnhance : IFlatbufferObject
	{
		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600D6AA RID: 54954 RVA: 0x00327C97 File Offset: 0x00325E97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6AB RID: 54955 RVA: 0x00327CA4 File Offset: 0x00325EA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6AC RID: 54956 RVA: 0x00327CAC File Offset: 0x00325EAC
		public static RoverRogueRoleEnhance GetRootAsRoverRogueRoleEnhance(ByteBuffer _bb)
		{
			return RoverRogueRoleEnhance.GetRootAsRoverRogueRoleEnhance(_bb, default(RoverRogueRoleEnhance));
		}

		// Token: 0x0600D6AD RID: 54957 RVA: 0x00327CC8 File Offset: 0x00325EC8
		public static RoverRogueRoleEnhance GetRootAsRoverRogueRoleEnhance(ByteBuffer _bb, RoverRogueRoleEnhance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6AE RID: 54958 RVA: 0x00327CE5 File Offset: 0x00325EE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6AF RID: 54959 RVA: 0x00327CF4 File Offset: 0x00325EF4
		public RoverRogueRoleEnhance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x00327D04 File Offset: 0x00325F04
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

		// Token: 0x0600D6B1 RID: 54961 RVA: 0x00327D40 File Offset: 0x00325F40
		public int RoleType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x00327D80 File Offset: 0x00325F80
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

		// Token: 0x0600D6B3 RID: 54963 RVA: 0x00327DAB File Offset: 0x00325FAB
		public Span<int> GetRoleTypeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600D6B4 RID: 54964 RVA: 0x00327DBA File Offset: 0x00325FBA
		public int[] GetRoleTypeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600D6B5 RID: 54965 RVA: 0x00327DD4 File Offset: 0x00325FD4
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

		// Token: 0x0600D6B6 RID: 54966 RVA: 0x00327E0B File Offset: 0x0032600B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x00327E1A File Offset: 0x0032601A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x00327E34 File Offset: 0x00326034
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

		// Token: 0x0600D6B9 RID: 54969 RVA: 0x00327E6C File Offset: 0x0032606C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D6BA RID: 54970 RVA: 0x00327E7C File Offset: 0x0032607C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D6BB RID: 54971 RVA: 0x00327E94 File Offset: 0x00326094
		public string DescParams(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600D6BC RID: 54972 RVA: 0x00327ED0 File Offset: 0x003260D0
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

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600D6BD RID: 54973 RVA: 0x00327EFC File Offset: 0x003260FC
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

		// Token: 0x0600D6BE RID: 54974 RVA: 0x00327F34 File Offset: 0x00326134
		public Span<byte> GetBriefDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D6BF RID: 54975 RVA: 0x00327F44 File Offset: 0x00326144
		public byte[] GetBriefDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D6C0 RID: 54976 RVA: 0x00327F5C File Offset: 0x0032615C
		public string BriefDescParams(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0600D6C1 RID: 54977 RVA: 0x00327F98 File Offset: 0x00326198
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

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x00327FC4 File Offset: 0x003261C4
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

		// Token: 0x0600D6C3 RID: 54979 RVA: 0x00327FFC File Offset: 0x003261FC
		public Span<byte> GetAdditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D6C4 RID: 54980 RVA: 0x0032800C File Offset: 0x0032620C
		public byte[] GetAdditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D6C5 RID: 54981 RVA: 0x00328024 File Offset: 0x00326224
		public string AdditionParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x00328060 File Offset: 0x00326260
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

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600D6C7 RID: 54983 RVA: 0x0032808C File Offset: 0x0032628C
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

		// Token: 0x0600D6C8 RID: 54984 RVA: 0x003280C4 File Offset: 0x003262C4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D6C9 RID: 54985 RVA: 0x003280D4 File Offset: 0x003262D4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600D6CA RID: 54986 RVA: 0x003280EC File Offset: 0x003262EC
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600D6CB RID: 54987 RVA: 0x0032812C File Offset: 0x0032632C
		[NullableContext(1)]
		public string[] AdditionParams()
		{
			return this.AdditionParamsIter().ToArray<string>();
		}

		// Token: 0x0600D6CC RID: 54988 RVA: 0x00328139 File Offset: 0x00326339
		[NullableContext(1)]
		public IEnumerable<string> AdditionParamsIter()
		{
			RoverRogueRoleEnhance.<AdditionParamsIter>d__47 <AdditionParamsIter>d__ = new RoverRogueRoleEnhance.<AdditionParamsIter>d__47(-2);
			<AdditionParamsIter>d__.<>3__<>4__this = this;
			return <AdditionParamsIter>d__;
		}

		// Token: 0x0600D6CD RID: 54989 RVA: 0x0032814E File Offset: 0x0032634E
		[NullableContext(1)]
		public string[] BriefDescParams()
		{
			return this.BriefDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600D6CE RID: 54990 RVA: 0x0032815B File Offset: 0x0032635B
		[NullableContext(1)]
		public IEnumerable<string> BriefDescParamsIter()
		{
			RoverRogueRoleEnhance.<BriefDescParamsIter>d__49 <BriefDescParamsIter>d__ = new RoverRogueRoleEnhance.<BriefDescParamsIter>d__49(-2);
			<BriefDescParamsIter>d__.<>3__<>4__this = this;
			return <BriefDescParamsIter>d__;
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x00328170 File Offset: 0x00326370
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x0032817D File Offset: 0x0032637D
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			RoverRogueRoleEnhance.<DescParamsIter>d__51 <DescParamsIter>d__ = new RoverRogueRoleEnhance.<DescParamsIter>d__51(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x0600D6D1 RID: 54993 RVA: 0x00328192 File Offset: 0x00326392
		[NullableContext(1)]
		public int[] RoleType()
		{
			return this.GetRoleTypeArray();
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x0032819A File Offset: 0x0032639A
		[NullableContext(1)]
		public IEnumerable<int> RoleTypeIter()
		{
			RoverRogueRoleEnhance.<RoleTypeIter>d__53 <RoleTypeIter>d__ = new RoverRogueRoleEnhance.<RoleTypeIter>d__53(-2);
			<RoleTypeIter>d__.<>3__<>4__this = this;
			return <RoleTypeIter>d__;
		}

		// Token: 0x04005790 RID: 22416
		private Table __p;
	}
}
