using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200116D RID: 4461
	public struct RoverRogueBless : IFlatbufferObject
	{
		// Token: 0x1700350F RID: 13583
		// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x00323D16 File Offset: 0x00321F16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D4D1 RID: 54481 RVA: 0x00323D23 File Offset: 0x00321F23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D4D2 RID: 54482 RVA: 0x00323D2C File Offset: 0x00321F2C
		public static RoverRogueBless GetRootAsRoverRogueBless(ByteBuffer _bb)
		{
			return RoverRogueBless.GetRootAsRoverRogueBless(_bb, default(RoverRogueBless));
		}

		// Token: 0x0600D4D3 RID: 54483 RVA: 0x00323D48 File Offset: 0x00321F48
		public static RoverRogueBless GetRootAsRoverRogueBless(ByteBuffer _bb, RoverRogueBless obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D4D4 RID: 54484 RVA: 0x00323D65 File Offset: 0x00321F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D4D5 RID: 54485 RVA: 0x00323D74 File Offset: 0x00321F74
		public RoverRogueBless __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003510 RID: 13584
		// (get) Token: 0x0600D4D6 RID: 54486 RVA: 0x00323D84 File Offset: 0x00321F84
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

		// Token: 0x17003511 RID: 13585
		// (get) Token: 0x0600D4D7 RID: 54487 RVA: 0x00323DC0 File Offset: 0x00321FC0
		public int BlessRoleId
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

		// Token: 0x17003512 RID: 13586
		// (get) Token: 0x0600D4D8 RID: 54488 RVA: 0x00323DFC File Offset: 0x00321FFC
		public int SlotId
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

		// Token: 0x17003513 RID: 13587
		// (get) Token: 0x0600D4D9 RID: 54489 RVA: 0x00323E38 File Offset: 0x00322038
		public int Quality
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

		// Token: 0x17003514 RID: 13588
		// (get) Token: 0x0600D4DA RID: 54490 RVA: 0x00323E78 File Offset: 0x00322078
		public int Level
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003515 RID: 13589
		// (get) Token: 0x0600D4DB RID: 54491 RVA: 0x00323EB8 File Offset: 0x003220B8
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

		// Token: 0x0600D4DC RID: 54492 RVA: 0x00323EF0 File Offset: 0x003220F0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x00323F00 File Offset: 0x00322100
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003516 RID: 13590
		// (get) Token: 0x0600D4DE RID: 54494 RVA: 0x00323F18 File Offset: 0x00322118
		public string Desc
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

		// Token: 0x0600D4DF RID: 54495 RVA: 0x00323F50 File Offset: 0x00322150
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x00323F60 File Offset: 0x00322160
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D4E1 RID: 54497 RVA: 0x00323F78 File Offset: 0x00322178
		public string Params(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003517 RID: 13591
		// (get) Token: 0x0600D4E2 RID: 54498 RVA: 0x00323FB4 File Offset: 0x003221B4
		public int ParamsLength
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

		// Token: 0x17003518 RID: 13592
		// (get) Token: 0x0600D4E3 RID: 54499 RVA: 0x00323FE0 File Offset: 0x003221E0
		public string AdditionText
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

		// Token: 0x0600D4E4 RID: 54500 RVA: 0x00324018 File Offset: 0x00322218
		public Span<byte> GetAdditionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x00324028 File Offset: 0x00322228
		public byte[] GetAdditionTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x00324040 File Offset: 0x00322240
		public string AdditionParams(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600D4E7 RID: 54503 RVA: 0x0032407C File Offset: 0x0032227C
		public int AdditionParamsLength
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

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600D4E8 RID: 54504 RVA: 0x003240A8 File Offset: 0x003222A8
		public string Icon
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

		// Token: 0x0600D4E9 RID: 54505 RVA: 0x003240E0 File Offset: 0x003222E0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D4EA RID: 54506 RVA: 0x003240F0 File Offset: 0x003222F0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600D4EB RID: 54507 RVA: 0x00324108 File Offset: 0x00322308
		public int NextBlessId
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

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600D4EC RID: 54508 RVA: 0x00324148 File Offset: 0x00322348
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600D4ED RID: 54509 RVA: 0x00324188 File Offset: 0x00322388
		public string TriggerRoleInfo
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

		// Token: 0x0600D4EE RID: 54510 RVA: 0x003241C0 File Offset: 0x003223C0
		public Span<byte> GetTriggerRoleInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D4EF RID: 54511 RVA: 0x003241D0 File Offset: 0x003223D0
		public byte[] GetTriggerRoleInfoArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D4F0 RID: 54512 RVA: 0x003241E8 File Offset: 0x003223E8
		[NullableContext(1)]
		public string[] AdditionParams()
		{
			return this.AdditionParamsIter().ToArray<string>();
		}

		// Token: 0x0600D4F1 RID: 54513 RVA: 0x003241F5 File Offset: 0x003223F5
		[NullableContext(1)]
		public IEnumerable<string> AdditionParamsIter()
		{
			RoverRogueBless.<AdditionParamsIter>d__49 <AdditionParamsIter>d__ = new RoverRogueBless.<AdditionParamsIter>d__49(-2);
			<AdditionParamsIter>d__.<>3__<>4__this = this;
			return <AdditionParamsIter>d__;
		}

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x0032420A File Offset: 0x0032240A
		[NullableContext(1)]
		public string[] Params()
		{
			return this.ParamsIter().ToArray<string>();
		}

		// Token: 0x0600D4F3 RID: 54515 RVA: 0x00324217 File Offset: 0x00322417
		[NullableContext(1)]
		public IEnumerable<string> ParamsIter()
		{
			RoverRogueBless.<ParamsIter>d__51 <ParamsIter>d__ = new RoverRogueBless.<ParamsIter>d__51(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x0400577A RID: 22394
		private Table __p;
	}
}
