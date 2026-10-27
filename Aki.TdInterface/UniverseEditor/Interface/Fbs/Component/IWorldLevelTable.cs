using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B98 RID: 23448
	public struct IWorldLevelTable : IFlatbufferObject
	{
		// Token: 0x1700B131 RID: 45361
		// (get) Token: 0x06028245 RID: 164421 RVA: 0x005845F8 File Offset: 0x005827F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028246 RID: 164422 RVA: 0x00584605 File Offset: 0x00582805
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028247 RID: 164423 RVA: 0x0058460C File Offset: 0x0058280C
		public static IWorldLevelTable GetRootAsIWorldLevelTable(ByteBuffer _bb)
		{
			return IWorldLevelTable.GetRootAsIWorldLevelTable(_bb, default(IWorldLevelTable));
		}

		// Token: 0x06028248 RID: 164424 RVA: 0x00584628 File Offset: 0x00582828
		public static IWorldLevelTable GetRootAsIWorldLevelTable(ByteBuffer _bb, IWorldLevelTable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028249 RID: 164425 RVA: 0x00584645 File Offset: 0x00582845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602824A RID: 164426 RVA: 0x00584654 File Offset: 0x00582854
		public IWorldLevelTable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B132 RID: 45362
		// (get) Token: 0x0602824B RID: 164427 RVA: 0x00584664 File Offset: 0x00582864
		public EWorldLevelBonus Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return (EWorldLevelBonus)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B133 RID: 45363
		// (get) Token: 0x0602824C RID: 164428 RVA: 0x005846A0 File Offset: 0x005828A0
		public int WorldLevelBonusId
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

		// Token: 0x1700B134 RID: 45364
		// (get) Token: 0x0602824D RID: 164429 RVA: 0x005846DC File Offset: 0x005828DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602824E RID: 164430 RVA: 0x00584718 File Offset: 0x00582918
		public static Offset<IWorldLevelTable> CreateIWorldLevelTable(FlatBufferBuilder builder, EWorldLevelBonus Type = EWorldLevelBonus.WorldLevelTable, int WorldLevelBonusId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IWorldLevelTable.AddWorldLevelBonusId(builder, WorldLevelBonusId);
			IWorldLevelTable.AddNullMask(builder, NullMask);
			IWorldLevelTable.AddType(builder, Type);
			return IWorldLevelTable.EndIWorldLevelTable(builder);
		}

		// Token: 0x0602824F RID: 164431 RVA: 0x0058473C File Offset: 0x0058293C
		public static void StartIWorldLevelTable(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028250 RID: 164432 RVA: 0x00584745 File Offset: 0x00582945
		public static void AddType(FlatBufferBuilder builder, EWorldLevelBonus type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028251 RID: 164433 RVA: 0x00584750 File Offset: 0x00582950
		public static void AddWorldLevelBonusId(FlatBufferBuilder builder, int worldLevelBonusId)
		{
			builder.AddInt(1, worldLevelBonusId, 0);
		}

		// Token: 0x06028252 RID: 164434 RVA: 0x0058475B File Offset: 0x0058295B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06028253 RID: 164435 RVA: 0x00584766 File Offset: 0x00582966
		public static Offset<IWorldLevelTable> EndIWorldLevelTable(FlatBufferBuilder builder)
		{
			return new Offset<IWorldLevelTable>(builder.EndTable());
		}

		// Token: 0x06028254 RID: 164436 RVA: 0x00584774 File Offset: 0x00582974
		public IWorldLevelTableT UnPack()
		{
			IWorldLevelTableT worldLevelTableT = new IWorldLevelTableT();
			this.UnPackTo(worldLevelTableT);
			return worldLevelTableT;
		}

		// Token: 0x06028255 RID: 164437 RVA: 0x0058478F File Offset: 0x0058298F
		public void UnPackTo(IWorldLevelTableT _o)
		{
			_o.Type = this.Type;
			_o.WorldLevelBonusId = this.WorldLevelBonusId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028256 RID: 164438 RVA: 0x005847B8 File Offset: 0x005829B8
		public static Offset<IWorldLevelTable> Pack(FlatBufferBuilder builder, IWorldLevelTableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWorldLevelTable>);
			}
			return IWorldLevelTable.CreateIWorldLevelTable(builder, _o.Type, _o.WorldLevelBonusId, _o.NullMask);
		}

		// Token: 0x0400F2FD RID: 62205
		private Table __p;
	}
}
