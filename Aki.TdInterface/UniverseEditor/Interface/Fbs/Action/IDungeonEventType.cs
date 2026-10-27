using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006615 RID: 26133
	public struct IDungeonEventType : IFlatbufferObject
	{
		// Token: 0x1700C235 RID: 49717
		// (get) Token: 0x0602D627 RID: 185895 RVA: 0x006381C0 File Offset: 0x006363C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D628 RID: 185896 RVA: 0x006381CD File Offset: 0x006363CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D629 RID: 185897 RVA: 0x006381D4 File Offset: 0x006363D4
		public static IDungeonEventType GetRootAsIDungeonEventType(ByteBuffer _bb)
		{
			return IDungeonEventType.GetRootAsIDungeonEventType(_bb, default(IDungeonEventType));
		}

		// Token: 0x0602D62A RID: 185898 RVA: 0x006381F0 File Offset: 0x006363F0
		public static IDungeonEventType GetRootAsIDungeonEventType(ByteBuffer _bb, IDungeonEventType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D62B RID: 185899 RVA: 0x0063820D File Offset: 0x0063640D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D62C RID: 185900 RVA: 0x0063821C File Offset: 0x0063641C
		public IDungeonEventType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C236 RID: 49718
		// (get) Token: 0x0602D62D RID: 185901 RVA: 0x0063822C File Offset: 0x0063642C
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

		// Token: 0x0602D62E RID: 185902 RVA: 0x00638268 File Offset: 0x00636468
		public static Offset<IDungeonEventType> CreateIDungeonEventType(FlatBufferBuilder builder, EDungeonEventType Type = EDungeonEventType.RecordTimeStamp)
		{
			builder.StartTable(1);
			IDungeonEventType.AddType(builder, Type);
			return IDungeonEventType.EndIDungeonEventType(builder);
		}

		// Token: 0x0602D62F RID: 185903 RVA: 0x0063827E File Offset: 0x0063647E
		public static void StartIDungeonEventType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D630 RID: 185904 RVA: 0x00638287 File Offset: 0x00636487
		public static void AddType(FlatBufferBuilder builder, EDungeonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D631 RID: 185905 RVA: 0x00638292 File Offset: 0x00636492
		public static Offset<IDungeonEventType> EndIDungeonEventType(FlatBufferBuilder builder)
		{
			return new Offset<IDungeonEventType>(builder.EndTable());
		}

		// Token: 0x0602D632 RID: 185906 RVA: 0x006382A0 File Offset: 0x006364A0
		public IDungeonEventTypeT UnPack()
		{
			IDungeonEventTypeT dungeonEventTypeT = new IDungeonEventTypeT();
			this.UnPackTo(dungeonEventTypeT);
			return dungeonEventTypeT;
		}

		// Token: 0x0602D633 RID: 185907 RVA: 0x006382BB File Offset: 0x006364BB
		public void UnPackTo(IDungeonEventTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602D634 RID: 185908 RVA: 0x006382CC File Offset: 0x006364CC
		public static Offset<IDungeonEventType> Pack(FlatBufferBuilder builder, IDungeonEventTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDungeonEventType>);
			}
			return IDungeonEventType.CreateIDungeonEventType(builder, _o.Type);
		}

		// Token: 0x04010CA1 RID: 68769
		private Table __p;
	}
}
