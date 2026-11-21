using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005199 RID: 20889
	public struct IQuestPreConditionDungeonBase : IFlatbufferObject
	{
		// Token: 0x1700959B RID: 38299
		// (get) Token: 0x06020DFD RID: 134653 RVA: 0x0048C7FE File Offset: 0x0048A9FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020DFE RID: 134654 RVA: 0x0048C80B File Offset: 0x0048AA0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020DFF RID: 134655 RVA: 0x0048C814 File Offset: 0x0048AA14
		public static IQuestPreConditionDungeonBase GetRootAsIQuestPreConditionDungeonBase(ByteBuffer _bb)
		{
			return IQuestPreConditionDungeonBase.GetRootAsIQuestPreConditionDungeonBase(_bb, default(IQuestPreConditionDungeonBase));
		}

		// Token: 0x06020E00 RID: 134656 RVA: 0x0048C830 File Offset: 0x0048AA30
		public static IQuestPreConditionDungeonBase GetRootAsIQuestPreConditionDungeonBase(ByteBuffer _bb, IQuestPreConditionDungeonBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020E01 RID: 134657 RVA: 0x0048C84D File Offset: 0x0048AA4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020E02 RID: 134658 RVA: 0x0048C85C File Offset: 0x0048AA5C
		public IQuestPreConditionDungeonBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700959C RID: 38300
		// (get) Token: 0x06020E03 RID: 134659 RVA: 0x0048C86C File Offset: 0x0048AA6C
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

		// Token: 0x06020E04 RID: 134660 RVA: 0x0048C8A8 File Offset: 0x0048AAA8
		public static Offset<IQuestPreConditionDungeonBase> CreateIQuestPreConditionDungeonBase(FlatBufferBuilder builder, EQuestPreConditionDungeonType Type = EQuestPreConditionDungeonType.DungeonId)
		{
			builder.StartTable(1);
			IQuestPreConditionDungeonBase.AddType(builder, Type);
			return IQuestPreConditionDungeonBase.EndIQuestPreConditionDungeonBase(builder);
		}

		// Token: 0x06020E05 RID: 134661 RVA: 0x0048C8BE File Offset: 0x0048AABE
		public static void StartIQuestPreConditionDungeonBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020E06 RID: 134662 RVA: 0x0048C8C7 File Offset: 0x0048AAC7
		public static void AddType(FlatBufferBuilder builder, EQuestPreConditionDungeonType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020E07 RID: 134663 RVA: 0x0048C8D2 File Offset: 0x0048AAD2
		public static Offset<IQuestPreConditionDungeonBase> EndIQuestPreConditionDungeonBase(FlatBufferBuilder builder)
		{
			return new Offset<IQuestPreConditionDungeonBase>(builder.EndTable());
		}

		// Token: 0x06020E08 RID: 134664 RVA: 0x0048C8E0 File Offset: 0x0048AAE0
		public IQuestPreConditionDungeonBaseT UnPack()
		{
			IQuestPreConditionDungeonBaseT questPreConditionDungeonBaseT = new IQuestPreConditionDungeonBaseT();
			this.UnPackTo(questPreConditionDungeonBaseT);
			return questPreConditionDungeonBaseT;
		}

		// Token: 0x06020E09 RID: 134665 RVA: 0x0048C8FB File Offset: 0x0048AAFB
		public void UnPackTo(IQuestPreConditionDungeonBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020E0A RID: 134666 RVA: 0x0048C90C File Offset: 0x0048AB0C
		public static Offset<IQuestPreConditionDungeonBase> Pack(FlatBufferBuilder builder, IQuestPreConditionDungeonBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestPreConditionDungeonBase>);
			}
			return IQuestPreConditionDungeonBase.CreateIQuestPreConditionDungeonBase(builder, _o.Type);
		}

		// Token: 0x0400E182 RID: 57730
		private Table __p;
	}
}
