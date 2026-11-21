using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004232 RID: 16946
	public struct IEnterDungeon : IFlatbufferObject
	{
		// Token: 0x17007387 RID: 29575
		// (get) Token: 0x0601791E RID: 96542 RVA: 0x0035CFEE File Offset: 0x0035B1EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601791F RID: 96543 RVA: 0x0035CFFB File Offset: 0x0035B1FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017920 RID: 96544 RVA: 0x0035D004 File Offset: 0x0035B204
		public static IEnterDungeon GetRootAsIEnterDungeon(ByteBuffer _bb)
		{
			return IEnterDungeon.GetRootAsIEnterDungeon(_bb, default(IEnterDungeon));
		}

		// Token: 0x06017921 RID: 96545 RVA: 0x0035D020 File Offset: 0x0035B220
		public static IEnterDungeon GetRootAsIEnterDungeon(ByteBuffer _bb, IEnterDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017922 RID: 96546 RVA: 0x0035D03D File Offset: 0x0035B23D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017923 RID: 96547 RVA: 0x0035D04C File Offset: 0x0035B24C
		public IEnterDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007388 RID: 29576
		// (get) Token: 0x06017924 RID: 96548 RVA: 0x0035D05C File Offset: 0x0035B25C
		public EDungeonConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDungeonConditionType.DungeonSubType;
				}
				return (EDungeonConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017925 RID: 96549 RVA: 0x0035D098 File Offset: 0x0035B298
		public static Offset<IEnterDungeon> CreateIEnterDungeon(FlatBufferBuilder builder, EDungeonConditionType Type = EDungeonConditionType.DungeonSubType)
		{
			builder.StartTable(1);
			IEnterDungeon.AddType(builder, Type);
			return IEnterDungeon.EndIEnterDungeon(builder);
		}

		// Token: 0x06017926 RID: 96550 RVA: 0x0035D0AE File Offset: 0x0035B2AE
		public static void StartIEnterDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017927 RID: 96551 RVA: 0x0035D0B7 File Offset: 0x0035B2B7
		public static void AddType(FlatBufferBuilder builder, EDungeonConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017928 RID: 96552 RVA: 0x0035D0C2 File Offset: 0x0035B2C2
		public static Offset<IEnterDungeon> EndIEnterDungeon(FlatBufferBuilder builder)
		{
			return new Offset<IEnterDungeon>(builder.EndTable());
		}

		// Token: 0x06017929 RID: 96553 RVA: 0x0035D0D0 File Offset: 0x0035B2D0
		public IEnterDungeonT UnPack()
		{
			IEnterDungeonT enterDungeonT = new IEnterDungeonT();
			this.UnPackTo(enterDungeonT);
			return enterDungeonT;
		}

		// Token: 0x0601792A RID: 96554 RVA: 0x0035D0EB File Offset: 0x0035B2EB
		public void UnPackTo(IEnterDungeonT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601792B RID: 96555 RVA: 0x0035D0FC File Offset: 0x0035B2FC
		public static Offset<IEnterDungeon> Pack(FlatBufferBuilder builder, IEnterDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterDungeon>);
			}
			return IEnterDungeon.CreateIEnterDungeon(builder, _o.Type);
		}

		// Token: 0x0400C13A RID: 49466
		private Table __p;
	}
}
