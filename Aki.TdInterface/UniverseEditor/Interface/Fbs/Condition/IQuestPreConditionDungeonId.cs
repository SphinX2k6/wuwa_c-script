using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CA6 RID: 19622
	public struct IQuestPreConditionDungeonId : IFlatbufferObject
	{
		// Token: 0x17008E72 RID: 36466
		// (get) Token: 0x0601F1F9 RID: 127481 RVA: 0x00458F22 File Offset: 0x00457122
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F1FA RID: 127482 RVA: 0x00458F2F File Offset: 0x0045712F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F1FB RID: 127483 RVA: 0x00458F38 File Offset: 0x00457138
		public static IQuestPreConditionDungeonId GetRootAsIQuestPreConditionDungeonId(ByteBuffer _bb)
		{
			return IQuestPreConditionDungeonId.GetRootAsIQuestPreConditionDungeonId(_bb, default(IQuestPreConditionDungeonId));
		}

		// Token: 0x0601F1FC RID: 127484 RVA: 0x00458F54 File Offset: 0x00457154
		public static IQuestPreConditionDungeonId GetRootAsIQuestPreConditionDungeonId(ByteBuffer _bb, IQuestPreConditionDungeonId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F1FD RID: 127485 RVA: 0x00458F71 File Offset: 0x00457171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F1FE RID: 127486 RVA: 0x00458F80 File Offset: 0x00457180
		public IQuestPreConditionDungeonId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E73 RID: 36467
		// (get) Token: 0x0601F1FF RID: 127487 RVA: 0x00458F90 File Offset: 0x00457190
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

		// Token: 0x17008E74 RID: 36468
		// (get) Token: 0x0601F200 RID: 127488 RVA: 0x00458FCC File Offset: 0x004571CC
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

		// Token: 0x0601F201 RID: 127489 RVA: 0x00459008 File Offset: 0x00457208
		public static Offset<IQuestPreConditionDungeonId> CreateIQuestPreConditionDungeonId(FlatBufferBuilder builder, EQuestPreConditionDungeonType Type = EQuestPreConditionDungeonType.DungeonId, int DungeonId = 0)
		{
			builder.StartTable(2);
			IQuestPreConditionDungeonId.AddDungeonId(builder, DungeonId);
			IQuestPreConditionDungeonId.AddType(builder, Type);
			return IQuestPreConditionDungeonId.EndIQuestPreConditionDungeonId(builder);
		}

		// Token: 0x0601F202 RID: 127490 RVA: 0x00459025 File Offset: 0x00457225
		public static void StartIQuestPreConditionDungeonId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F203 RID: 127491 RVA: 0x0045902E File Offset: 0x0045722E
		public static void AddType(FlatBufferBuilder builder, EQuestPreConditionDungeonType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F204 RID: 127492 RVA: 0x00459039 File Offset: 0x00457239
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601F205 RID: 127493 RVA: 0x00459044 File Offset: 0x00457244
		public static Offset<IQuestPreConditionDungeonId> EndIQuestPreConditionDungeonId(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPreConditionDungeonId>(builder.EndTable());
		}

		// Token: 0x0601F206 RID: 127494 RVA: 0x00459054 File Offset: 0x00457254
		public IQuestPreConditionDungeonIdT UnPack()
		{
			IQuestPreConditionDungeonIdT questPreConditionDungeonIdT = new IQuestPreConditionDungeonIdT();
			this.UnPackTo(questPreConditionDungeonIdT);
			return questPreConditionDungeonIdT;
		}

		// Token: 0x0601F207 RID: 127495 RVA: 0x0045906F File Offset: 0x0045726F
		public void UnPackTo(IQuestPreConditionDungeonIdT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
		}

		// Token: 0x0601F208 RID: 127496 RVA: 0x0045908C File Offset: 0x0045728C
		public static Offset<IQuestPreConditionDungeonId> Pack(FlatBufferBuilder builder, IQuestPreConditionDungeonIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPreConditionDungeonId>);
			}
			return IQuestPreConditionDungeonId.CreateIQuestPreConditionDungeonId(builder, _o.Type, _o.DungeonId);
		}

		// Token: 0x0400D663 RID: 54883
		private Table __p;
	}
}
