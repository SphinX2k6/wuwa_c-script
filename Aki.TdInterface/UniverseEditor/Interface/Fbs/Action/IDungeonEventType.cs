using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C86 RID: 27782
	public struct IDungeonEventType : IFlatbufferObject
	{
		// Token: 0x1700CBD3 RID: 52179
		// (get) Token: 0x0602FDF8 RID: 196088 RVA: 0x00684D28 File Offset: 0x00682F28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FDF9 RID: 196089 RVA: 0x00684D35 File Offset: 0x00682F35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FDFA RID: 196090 RVA: 0x00684D3C File Offset: 0x00682F3C
		public static IDungeonEventType GetRootAsIDungeonEventType(ByteBuffer _bb)
		{
			return IDungeonEventType.GetRootAsIDungeonEventType(_bb, default(IDungeonEventType));
		}

		// Token: 0x0602FDFB RID: 196091 RVA: 0x00684D58 File Offset: 0x00682F58
		public static IDungeonEventType GetRootAsIDungeonEventType(ByteBuffer _bb, IDungeonEventType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FDFC RID: 196092 RVA: 0x00684D75 File Offset: 0x00682F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FDFD RID: 196093 RVA: 0x00684D84 File Offset: 0x00682F84
		public IDungeonEventType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBD4 RID: 52180
		// (get) Token: 0x0602FDFE RID: 196094 RVA: 0x00684D94 File Offset: 0x00682F94
		public EDungeonEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDungeonEventType.RecordTimeStamp;
				}
				return (EDungeonEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FDFF RID: 196095 RVA: 0x00684DD0 File Offset: 0x00682FD0
		public static Offset<IDungeonEventType> CreateIDungeonEventType(FlatBufferBuilder builder, EDungeonEventType Type = EDungeonEventType.RecordTimeStamp)
		{
			builder.StartTable(1);
			IDungeonEventType.AddType(builder, Type);
			return IDungeonEventType.EndIDungeonEventType(builder);
		}

		// Token: 0x0602FE00 RID: 196096 RVA: 0x00684DE6 File Offset: 0x00682FE6
		public static void StartIDungeonEventType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602FE01 RID: 196097 RVA: 0x00684DEF File Offset: 0x00682FEF
		public static void AddType(FlatBufferBuilder builder, EDungeonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE02 RID: 196098 RVA: 0x00684DFA File Offset: 0x00682FFA
		public static Offset<IDungeonEventType> EndIDungeonEventType(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonEventType>(builder.EndTable());
		}

		// Token: 0x0602FE03 RID: 196099 RVA: 0x00684E08 File Offset: 0x00683008
		public IDungeonEventTypeT UnPack()
		{
			IDungeonEventTypeT dungeonEventTypeT = new IDungeonEventTypeT();
			this.UnPackTo(dungeonEventTypeT);
			return dungeonEventTypeT;
		}

		// Token: 0x0602FE04 RID: 196100 RVA: 0x00684E23 File Offset: 0x00683023
		public void UnPackTo(IDungeonEventTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602FE05 RID: 196101 RVA: 0x00684E34 File Offset: 0x00683034
		public static Offset<IDungeonEventType> Pack(FlatBufferBuilder builder, IDungeonEventTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonEventType>);
			}
			return IDungeonEventType.CreateIDungeonEventType(builder, _o.Type);
		}

		// Token: 0x04011ABC RID: 72380
		private Table __p;
	}
}
