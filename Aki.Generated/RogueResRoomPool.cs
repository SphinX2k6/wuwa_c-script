using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F8 RID: 4344
	public struct RogueResRoomPool : IFlatbufferObject
	{
		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600C9FB RID: 51707 RVA: 0x0030B4B0 File Offset: 0x003096B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9FC RID: 51708 RVA: 0x0030B4BD File Offset: 0x003096BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x0030B4C4 File Offset: 0x003096C4
		public static RogueResRoomPool GetRootAsRogueResRoomPool(ByteBuffer _bb)
		{
			return RogueResRoomPool.GetRootAsRogueResRoomPool(_bb, default(RogueResRoomPool));
		}

		// Token: 0x0600C9FE RID: 51710 RVA: 0x0030B4E0 File Offset: 0x003096E0
		public static RogueResRoomPool GetRootAsRogueResRoomPool(ByteBuffer _bb, RogueResRoomPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9FF RID: 51711 RVA: 0x0030B4FD File Offset: 0x003096FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x0030B50C File Offset: 0x0030970C
		public RogueResRoomPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600CA01 RID: 51713 RVA: 0x0030B51C File Offset: 0x0030971C
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

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0600CA02 RID: 51714 RVA: 0x0030B558 File Offset: 0x00309758
		public int BehaviorTree
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

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0600CA03 RID: 51715 RVA: 0x0030B594 File Offset: 0x00309794
		public string RoomsMusicState
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

		// Token: 0x0600CA04 RID: 51716 RVA: 0x0030B5CB File Offset: 0x003097CB
		public Span<byte> GetRoomsMusicStateBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CA05 RID: 51717 RVA: 0x0030B5DA File Offset: 0x003097DA
		public byte[] GetRoomsMusicStateArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x0030B5F4 File Offset: 0x003097F4
		public string MonsterDesc(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0600CA07 RID: 51719 RVA: 0x0030B630 File Offset: 0x00309830
		public int MonsterDescLength
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

		// Token: 0x0600CA08 RID: 51720 RVA: 0x0030B65C File Offset: 0x0030985C
		public string MonsterDescParams(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600CA09 RID: 51721 RVA: 0x0030B698 File Offset: 0x00309898
		public int MonsterDescParamsLength
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

		// Token: 0x0600CA0A RID: 51722 RVA: 0x0030B6C4 File Offset: 0x003098C4
		public string MonsterFig(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600CA0B RID: 51723 RVA: 0x0030B700 File Offset: 0x00309900
		public int MonsterFigLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x0030B72C File Offset: 0x0030992C
		public string EnvDesc(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600CA0D RID: 51725 RVA: 0x0030B768 File Offset: 0x00309968
		public int EnvDescLength
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

		// Token: 0x0600CA0E RID: 51726 RVA: 0x0030B794 File Offset: 0x00309994
		public string EnvFig(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003136 RID: 12598
		// (get) Token: 0x0600CA0F RID: 51727 RVA: 0x0030B7D0 File Offset: 0x003099D0
		public int EnvFigLength
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

		// Token: 0x0600CA10 RID: 51728 RVA: 0x0030B7FC File Offset: 0x003099FC
		public string EnvDescParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003137 RID: 12599
		// (get) Token: 0x0600CA11 RID: 51729 RVA: 0x0030B838 File Offset: 0x00309A38
		public int EnvDescParamsLength
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

		// Token: 0x0600CA12 RID: 51730 RVA: 0x0030B864 File Offset: 0x00309A64
		[NullableContext(1)]
		public string[] EnvDesc()
		{
			return this.EnvDescIter().ToArray<string>();
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x0030B871 File Offset: 0x00309A71
		[NullableContext(1)]
		public IEnumerable<string> EnvDescIter()
		{
			RogueResRoomPool.<EnvDescIter>d__35 <EnvDescIter>d__ = new RogueResRoomPool.<EnvDescIter>d__35(-2);
			<EnvDescIter>d__.<>3__<>4__this = this;
			return <EnvDescIter>d__;
		}

		// Token: 0x0600CA14 RID: 51732 RVA: 0x0030B886 File Offset: 0x00309A86
		[NullableContext(1)]
		public string[] EnvDescParams()
		{
			return this.EnvDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600CA15 RID: 51733 RVA: 0x0030B893 File Offset: 0x00309A93
		[NullableContext(1)]
		public IEnumerable<string> EnvDescParamsIter()
		{
			RogueResRoomPool.<EnvDescParamsIter>d__37 <EnvDescParamsIter>d__ = new RogueResRoomPool.<EnvDescParamsIter>d__37(-2);
			<EnvDescParamsIter>d__.<>3__<>4__this = this;
			return <EnvDescParamsIter>d__;
		}

		// Token: 0x0600CA16 RID: 51734 RVA: 0x0030B8A8 File Offset: 0x00309AA8
		[NullableContext(1)]
		public string[] EnvFig()
		{
			return this.EnvFigIter().ToArray<string>();
		}

		// Token: 0x0600CA17 RID: 51735 RVA: 0x0030B8B5 File Offset: 0x00309AB5
		[NullableContext(1)]
		public IEnumerable<string> EnvFigIter()
		{
			RogueResRoomPool.<EnvFigIter>d__39 <EnvFigIter>d__ = new RogueResRoomPool.<EnvFigIter>d__39(-2);
			<EnvFigIter>d__.<>3__<>4__this = this;
			return <EnvFigIter>d__;
		}

		// Token: 0x0600CA18 RID: 51736 RVA: 0x0030B8CA File Offset: 0x00309ACA
		[NullableContext(1)]
		public string[] MonsterDesc()
		{
			return this.MonsterDescIter().ToArray<string>();
		}

		// Token: 0x0600CA19 RID: 51737 RVA: 0x0030B8D7 File Offset: 0x00309AD7
		[NullableContext(1)]
		public IEnumerable<string> MonsterDescIter()
		{
			RogueResRoomPool.<MonsterDescIter>d__41 <MonsterDescIter>d__ = new RogueResRoomPool.<MonsterDescIter>d__41(-2);
			<MonsterDescIter>d__.<>3__<>4__this = this;
			return <MonsterDescIter>d__;
		}

		// Token: 0x0600CA1A RID: 51738 RVA: 0x0030B8EC File Offset: 0x00309AEC
		[NullableContext(1)]
		public string[] MonsterDescParams()
		{
			return this.MonsterDescParamsIter().ToArray<string>();
		}

		// Token: 0x0600CA1B RID: 51739 RVA: 0x0030B8F9 File Offset: 0x00309AF9
		[NullableContext(1)]
		public IEnumerable<string> MonsterDescParamsIter()
		{
			RogueResRoomPool.<MonsterDescParamsIter>d__43 <MonsterDescParamsIter>d__ = new RogueResRoomPool.<MonsterDescParamsIter>d__43(-2);
			<MonsterDescParamsIter>d__.<>3__<>4__this = this;
			return <MonsterDescParamsIter>d__;
		}

		// Token: 0x0600CA1C RID: 51740 RVA: 0x0030B90E File Offset: 0x00309B0E
		[NullableContext(1)]
		public string[] MonsterFig()
		{
			return this.MonsterFigIter().ToArray<string>();
		}

		// Token: 0x0600CA1D RID: 51741 RVA: 0x0030B91B File Offset: 0x00309B1B
		[NullableContext(1)]
		public IEnumerable<string> MonsterFigIter()
		{
			RogueResRoomPool.<MonsterFigIter>d__45 <MonsterFigIter>d__ = new RogueResRoomPool.<MonsterFigIter>d__45(-2);
			<MonsterFigIter>d__.<>3__<>4__this = this;
			return <MonsterFigIter>d__;
		}

		// Token: 0x040056E5 RID: 22245
		private Table __p;
	}
}
