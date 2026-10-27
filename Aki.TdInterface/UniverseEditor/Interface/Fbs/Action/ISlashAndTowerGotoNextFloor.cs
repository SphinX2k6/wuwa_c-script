using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007136 RID: 28982
	public struct ISlashAndTowerGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700D760 RID: 55136
		// (get) Token: 0x06033615 RID: 210453 RVA: 0x006ECC56 File Offset: 0x006EAE56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033616 RID: 210454 RVA: 0x006ECC63 File Offset: 0x006EAE63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033617 RID: 210455 RVA: 0x006ECC6C File Offset: 0x006EAE6C
		public static ISlashAndTowerGotoNextFloor GetRootAsISlashAndTowerGotoNextFloor(ByteBuffer _bb)
		{
			return ISlashAndTowerGotoNextFloor.GetRootAsISlashAndTowerGotoNextFloor(_bb, default(ISlashAndTowerGotoNextFloor));
		}

		// Token: 0x06033618 RID: 210456 RVA: 0x006ECC88 File Offset: 0x006EAE88
		public static ISlashAndTowerGotoNextFloor GetRootAsISlashAndTowerGotoNextFloor(ByteBuffer _bb, ISlashAndTowerGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033619 RID: 210457 RVA: 0x006ECCA5 File Offset: 0x006EAEA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603361A RID: 210458 RVA: 0x006ECCB4 File Offset: 0x006EAEB4
		public ISlashAndTowerGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603361B RID: 210459 RVA: 0x006ECCC4 File Offset: 0x006EAEC4
		public static void StartISlashAndTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603361C RID: 210460 RVA: 0x006ECCCD File Offset: 0x006EAECD
		public static Offset<ISlashAndTowerGotoNextFloor> EndISlashAndTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<ISlashAndTowerGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x0603361D RID: 210461 RVA: 0x006ECCDC File Offset: 0x006EAEDC
		public ISlashAndTowerGotoNextFloorT UnPack()
		{
			ISlashAndTowerGotoNextFloorT slashAndTowerGotoNextFloorT = new ISlashAndTowerGotoNextFloorT();
			this.UnPackTo(slashAndTowerGotoNextFloorT);
			return slashAndTowerGotoNextFloorT;
		}

		// Token: 0x0603361E RID: 210462 RVA: 0x006ECCF7 File Offset: 0x006EAEF7
		public void UnPackTo(ISlashAndTowerGotoNextFloorT _o)
		{
		}

		// Token: 0x0603361F RID: 210463 RVA: 0x006ECCFC File Offset: 0x006EAEFC
		public static Offset<ISlashAndTowerGotoNextFloor> Pack(FlatBufferBuilder builder, ISlashAndTowerGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlashAndTowerGotoNextFloor>);
			}
			ISlashAndTowerGotoNextFloor.StartISlashAndTowerGotoNextFloor(builder);
			return ISlashAndTowerGotoNextFloor.EndISlashAndTowerGotoNextFloor(builder);
		}

		// Token: 0x04011BD3 RID: 72659
		private Table __p;
	}
}
