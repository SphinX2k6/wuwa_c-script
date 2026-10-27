using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B77 RID: 27511
	public struct IMowingTowerGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700CC80 RID: 52352
		// (get) Token: 0x060304FC RID: 197884 RVA: 0x00690790 File Offset: 0x0068E990
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060304FD RID: 197885 RVA: 0x0069079D File Offset: 0x0068E99D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060304FE RID: 197886 RVA: 0x006907A4 File Offset: 0x0068E9A4
		public static IMowingTowerGotoNextFloor GetRootAsIMowingTowerGotoNextFloor(ByteBuffer _bb)
		{
			return IMowingTowerGotoNextFloor.GetRootAsIMowingTowerGotoNextFloor(_bb, default(IMowingTowerGotoNextFloor));
		}

		// Token: 0x060304FF RID: 197887 RVA: 0x006907C0 File Offset: 0x0068E9C0
		public static IMowingTowerGotoNextFloor GetRootAsIMowingTowerGotoNextFloor(ByteBuffer _bb, IMowingTowerGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030500 RID: 197888 RVA: 0x006907DD File Offset: 0x0068E9DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030501 RID: 197889 RVA: 0x006907EC File Offset: 0x0068E9EC
		public IMowingTowerGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030502 RID: 197890 RVA: 0x006907FC File Offset: 0x0068E9FC
		public static void StartIMowingTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06030503 RID: 197891 RVA: 0x00690805 File Offset: 0x0068EA05
		public static Offset<IMowingTowerGotoNextFloor> EndIMowingTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IMowingTowerGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x06030504 RID: 197892 RVA: 0x00690814 File Offset: 0x0068EA14
		public IMowingTowerGotoNextFloorT UnPack()
		{
			IMowingTowerGotoNextFloorT mowingTowerGotoNextFloorT = new IMowingTowerGotoNextFloorT();
			this.UnPackTo(mowingTowerGotoNextFloorT);
			return mowingTowerGotoNextFloorT;
		}

		// Token: 0x06030505 RID: 197893 RVA: 0x0069082F File Offset: 0x0068EA2F
		public void UnPackTo(IMowingTowerGotoNextFloorT _o)
		{
		}

		// Token: 0x06030506 RID: 197894 RVA: 0x00690834 File Offset: 0x0068EA34
		public static Offset<IMowingTowerGotoNextFloor> Pack(FlatBufferBuilder builder, IMowingTowerGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMowingTowerGotoNextFloor>);
			}
			IMowingTowerGotoNextFloor.StartIMowingTowerGotoNextFloor(builder);
			return IMowingTowerGotoNextFloor.EndIMowingTowerGotoNextFloor(builder);
		}

		// Token: 0x04011433 RID: 70707
		private Table __p;
	}
}
