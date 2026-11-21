using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007902 RID: 30978
	public struct ISlashAndTowerGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700E343 RID: 58179
		// (get) Token: 0x060368B7 RID: 223415 RVA: 0x0074D262 File Offset: 0x0074B462
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060368B8 RID: 223416 RVA: 0x0074D26F File Offset: 0x0074B46F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060368B9 RID: 223417 RVA: 0x0074D278 File Offset: 0x0074B478
		public static ISlashAndTowerGotoNextFloor GetRootAsISlashAndTowerGotoNextFloor(ByteBuffer _bb)
		{
			return ISlashAndTowerGotoNextFloor.GetRootAsISlashAndTowerGotoNextFloor(_bb, default(ISlashAndTowerGotoNextFloor));
		}

		// Token: 0x060368BA RID: 223418 RVA: 0x0074D294 File Offset: 0x0074B494
		public static ISlashAndTowerGotoNextFloor GetRootAsISlashAndTowerGotoNextFloor(ByteBuffer _bb, ISlashAndTowerGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060368BB RID: 223419 RVA: 0x0074D2B1 File Offset: 0x0074B4B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060368BC RID: 223420 RVA: 0x0074D2C0 File Offset: 0x0074B4C0
		public ISlashAndTowerGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060368BD RID: 223421 RVA: 0x0074D2D0 File Offset: 0x0074B4D0
		public static void StartISlashAndTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060368BE RID: 223422 RVA: 0x0074D2D9 File Offset: 0x0074B4D9
		public static Offset<ISlashAndTowerGotoNextFloor> EndISlashAndTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<ISlashAndTowerGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x060368BF RID: 223423 RVA: 0x0074D2E8 File Offset: 0x0074B4E8
		public ISlashAndTowerGotoNextFloorT UnPack()
		{
			ISlashAndTowerGotoNextFloorT slashAndTowerGotoNextFloorT = new ISlashAndTowerGotoNextFloorT();
			this.UnPackTo(slashAndTowerGotoNextFloorT);
			return slashAndTowerGotoNextFloorT;
		}

		// Token: 0x060368C0 RID: 223424 RVA: 0x0074D303 File Offset: 0x0074B503
		public void UnPackTo(ISlashAndTowerGotoNextFloorT _o)
		{
		}

		// Token: 0x060368C1 RID: 223425 RVA: 0x0074D308 File Offset: 0x0074B508
		public static Offset<ISlashAndTowerGotoNextFloor> Pack(FlatBufferBuilder builder, ISlashAndTowerGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlashAndTowerGotoNextFloor>);
			}
			ISlashAndTowerGotoNextFloor.StartISlashAndTowerGotoNextFloor(builder);
			return ISlashAndTowerGotoNextFloor.EndISlashAndTowerGotoNextFloor(builder);
		}

		// Token: 0x04012BC1 RID: 76737
		private Table __p;
	}
}
