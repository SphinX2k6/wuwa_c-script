using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200519F RID: 20895
	public struct IQuestPreConditionDungeonId : IFlatbufferObject
	{
		// Token: 0x170095A0 RID: 38304
		// (get) Token: 0x06020E1B RID: 134683 RVA: 0x0048CA72 File Offset: 0x0048AC72
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020E1C RID: 134684 RVA: 0x0048CA7F File Offset: 0x0048AC7F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020E1D RID: 134685 RVA: 0x0048CA88 File Offset: 0x0048AC88
		public static IQuestPreConditionDungeonId GetRootAsIQuestPreConditionDungeonId(ByteBuffer _bb)
		{
			return IQuestPreConditionDungeonId.GetRootAsIQuestPreConditionDungeonId(_bb, default(IQuestPreConditionDungeonId));
		}

		// Token: 0x06020E1E RID: 134686 RVA: 0x0048CAA4 File Offset: 0x0048ACA4
		public static IQuestPreConditionDungeonId GetRootAsIQuestPreConditionDungeonId(ByteBuffer _bb, IQuestPreConditionDungeonId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E1F RID: 134687 RVA: 0x0048CAC1 File Offset: 0x0048ACC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E20 RID: 134688 RVA: 0x0048CAD0 File Offset: 0x0048ACD0
		public IQuestPreConditionDungeonId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095A1 RID: 38305
		// (get) Token: 0x06020E21 RID: 134689 RVA: 0x0048CAE0 File Offset: 0x0048ACE0
		public EQuestPreConditionDungeonType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestPreConditionDungeonType.DungeonId;
				}
				return (EQuestPreConditionDungeonType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095A2 RID: 38306
		// (get) Token: 0x06020E22 RID: 134690 RVA: 0x0048CB1C File Offset: 0x0048AD1C
		public int DungeonId
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

		// Token: 0x06020E23 RID: 134691 RVA: 0x0048CB58 File Offset: 0x0048AD58
		public static Offset<IQuestPreConditionDungeonId> CreateIQuestPreConditionDungeonId(FlatBufferBuilder builder, EQuestPreConditionDungeonType Type = EQuestPreConditionDungeonType.DungeonId, int DungeonId = 0)
		{
			builder.StartTable(2);
			IQuestPreConditionDungeonId.AddDungeonId(builder, DungeonId);
			IQuestPreConditionDungeonId.AddType(builder, Type);
			return IQuestPreConditionDungeonId.EndIQuestPreConditionDungeonId(builder);
		}

		// Token: 0x06020E24 RID: 134692 RVA: 0x0048CB75 File Offset: 0x0048AD75
		public static void StartIQuestPreConditionDungeonId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020E25 RID: 134693 RVA: 0x0048CB7E File Offset: 0x0048AD7E
		public static void AddType(FlatBufferBuilder builder, EQuestPreConditionDungeonType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E26 RID: 134694 RVA: 0x0048CB89 File Offset: 0x0048AD89
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x06020E27 RID: 134695 RVA: 0x0048CB94 File Offset: 0x0048AD94
		public static Offset<IQuestPreConditionDungeonId> EndIQuestPreConditionDungeonId(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPreConditionDungeonId>(builder.EndTable());
		}

		// Token: 0x06020E28 RID: 134696 RVA: 0x0048CBA4 File Offset: 0x0048ADA4
		public IQuestPreConditionDungeonIdT UnPack()
		{
			IQuestPreConditionDungeonIdT questPreConditionDungeonIdT = new IQuestPreConditionDungeonIdT();
			this.UnPackTo(questPreConditionDungeonIdT);
			return questPreConditionDungeonIdT;
		}

		// Token: 0x06020E29 RID: 134697 RVA: 0x0048CBBF File Offset: 0x0048ADBF
		public void UnPackTo(IQuestPreConditionDungeonIdT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
		}

		// Token: 0x06020E2A RID: 134698 RVA: 0x0048CBDC File Offset: 0x0048ADDC
		public static Offset<IQuestPreConditionDungeonId> Pack(FlatBufferBuilder builder, IQuestPreConditionDungeonIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPreConditionDungeonId>);
			}
			return IQuestPreConditionDungeonId.CreateIQuestPreConditionDungeonId(builder, _o.Type, _o.DungeonId);
		}

		// Token: 0x0400E18A RID: 57738
		private Table __p;
	}
}
