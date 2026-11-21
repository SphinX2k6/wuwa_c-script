using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E51 RID: 20049
	public struct ICheckChildQuestFinished : IFlatbufferObject
	{
		// Token: 0x17008EDD RID: 36573
		// (get) Token: 0x0601F057 RID: 127063 RVA: 0x00454ACC File Offset: 0x00452CCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F058 RID: 127064 RVA: 0x00454AD9 File Offset: 0x00452CD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F059 RID: 127065 RVA: 0x00454AE0 File Offset: 0x00452CE0
		public static ICheckChildQuestFinished GetRootAsICheckChildQuestFinished(ByteBuffer _bb)
		{
			return ICheckChildQuestFinished.GetRootAsICheckChildQuestFinished(_bb, default(ICheckChildQuestFinished));
		}

		// Token: 0x0601F05A RID: 127066 RVA: 0x00454AFC File Offset: 0x00452CFC
		public static ICheckChildQuestFinished GetRootAsICheckChildQuestFinished(ByteBuffer _bb, ICheckChildQuestFinished obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F05B RID: 127067 RVA: 0x00454B19 File Offset: 0x00452D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F05C RID: 127068 RVA: 0x00454B28 File Offset: 0x00452D28
		public ICheckChildQuestFinished __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EDE RID: 36574
		// (get) Token: 0x0601F05D RID: 127069 RVA: 0x00454B38 File Offset: 0x00452D38
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EDF RID: 36575
		// (get) Token: 0x0601F05E RID: 127070 RVA: 0x00454B74 File Offset: 0x00452D74
		public int QuestId
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

		// Token: 0x17008EE0 RID: 36576
		// (get) Token: 0x0601F05F RID: 127071 RVA: 0x00454BB0 File Offset: 0x00452DB0
		public int ChildQuestId
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

		// Token: 0x17008EE1 RID: 36577
		// (get) Token: 0x0601F060 RID: 127072 RVA: 0x00454BEC File Offset: 0x00452DEC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EE2 RID: 36578
		// (get) Token: 0x0601F061 RID: 127073 RVA: 0x00454C2C File Offset: 0x00452E2C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F062 RID: 127074 RVA: 0x00454C69 File Offset: 0x00452E69
		public static Offset<ICheckChildQuestFinished> CreateICheckChildQuestFinished(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int QuestId = 0, int ChildQuestId = 0, ECompare Compare = ECompare.Eq, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICheckChildQuestFinished.AddChildQuestId(builder, ChildQuestId);
			ICheckChildQuestFinished.AddQuestId(builder, QuestId);
			ICheckChildQuestFinished.AddNullMask(builder, NullMask);
			ICheckChildQuestFinished.AddCompare(builder, Compare);
			ICheckChildQuestFinished.AddType(builder, Type);
			return ICheckChildQuestFinished.EndICheckChildQuestFinished(builder);
		}

		// Token: 0x0601F063 RID: 127075 RVA: 0x00454C9D File Offset: 0x00452E9D
		public static void StartICheckChildQuestFinished(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F064 RID: 127076 RVA: 0x00454CA6 File Offset: 0x00452EA6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F065 RID: 127077 RVA: 0x00454CB1 File Offset: 0x00452EB1
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601F066 RID: 127078 RVA: 0x00454CBC File Offset: 0x00452EBC
		public static void AddChildQuestId(FlatBufferBuilder builder, int childQuestId)
		{
			builder.AddInt(2, childQuestId, 0);
		}

		// Token: 0x0601F067 RID: 127079 RVA: 0x00454CC7 File Offset: 0x00452EC7
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601F068 RID: 127080 RVA: 0x00454CD2 File Offset: 0x00452ED2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601F069 RID: 127081 RVA: 0x00454CDD File Offset: 0x00452EDD
		public static Offset<ICheckChildQuestFinished> EndICheckChildQuestFinished(FlatBufferBuilder builder)
		{
			return new Offset<ICheckChildQuestFinished>(builder.EndTable());
		}

		// Token: 0x0601F06A RID: 127082 RVA: 0x00454CEC File Offset: 0x00452EEC
		public ICheckChildQuestFinishedT UnPack()
		{
			ICheckChildQuestFinishedT checkChildQuestFinishedT = new ICheckChildQuestFinishedT();
			this.UnPackTo(checkChildQuestFinishedT);
			return checkChildQuestFinishedT;
		}

		// Token: 0x0601F06B RID: 127083 RVA: 0x00454D07 File Offset: 0x00452F07
		public void UnPackTo(ICheckChildQuestFinishedT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
			_o.ChildQuestId = this.ChildQuestId;
			_o.Compare = this.Compare;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F06C RID: 127084 RVA: 0x00454D48 File Offset: 0x00452F48
		public static Offset<ICheckChildQuestFinished> Pack(FlatBufferBuilder builder, ICheckChildQuestFinishedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckChildQuestFinished>);
			}
			return ICheckChildQuestFinished.CreateICheckChildQuestFinished(builder, _o.Type, _o.QuestId, _o.ChildQuestId, _o.Compare, _o.NullMask);
		}

		// Token: 0x0400DC76 RID: 56438
		private Table __p;
	}
}
