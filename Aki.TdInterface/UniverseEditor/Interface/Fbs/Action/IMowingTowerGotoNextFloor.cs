using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BD RID: 29373
	public struct IMowingTowerGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700D765 RID: 55141
		// (get) Token: 0x06033354 RID: 209748 RVA: 0x006E8DB0 File Offset: 0x006E6FB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033355 RID: 209749 RVA: 0x006E8DBD File Offset: 0x006E6FBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033356 RID: 209750 RVA: 0x006E8DC4 File Offset: 0x006E6FC4
		public static IMowingTowerGotoNextFloor GetRootAsIMowingTowerGotoNextFloor(ByteBuffer _bb)
		{
			return IMowingTowerGotoNextFloor.GetRootAsIMowingTowerGotoNextFloor(_bb, default(IMowingTowerGotoNextFloor));
		}

		// Token: 0x06033357 RID: 209751 RVA: 0x006E8DE0 File Offset: 0x006E6FE0
		public static IMowingTowerGotoNextFloor GetRootAsIMowingTowerGotoNextFloor(ByteBuffer _bb, IMowingTowerGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033358 RID: 209752 RVA: 0x006E8DFD File Offset: 0x006E6FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033359 RID: 209753 RVA: 0x006E8E0C File Offset: 0x006E700C
		public IMowingTowerGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603335A RID: 209754 RVA: 0x006E8E1C File Offset: 0x006E701C
		public static void StartIMowingTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603335B RID: 209755 RVA: 0x006E8E25 File Offset: 0x006E7025
		public static Offset<IMowingTowerGotoNextFloor> EndIMowingTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IMowingTowerGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x0603335C RID: 209756 RVA: 0x006E8E34 File Offset: 0x006E7034
		public IMowingTowerGotoNextFloorT UnPack()
		{
			IMowingTowerGotoNextFloorT mowingTowerGotoNextFloorT = new IMowingTowerGotoNextFloorT();
			this.UnPackTo(mowingTowerGotoNextFloorT);
			return mowingTowerGotoNextFloorT;
		}

		// Token: 0x0603335D RID: 209757 RVA: 0x006E8E4F File Offset: 0x006E704F
		public void UnPackTo(IMowingTowerGotoNextFloorT _o)
		{
		}

		// Token: 0x0603335E RID: 209758 RVA: 0x006E8E54 File Offset: 0x006E7054
		public static Offset<IMowingTowerGotoNextFloor> Pack(FlatBufferBuilder builder, IMowingTowerGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMowingTowerGotoNextFloor>);
			}
			IMowingTowerGotoNextFloor.StartIMowingTowerGotoNextFloor(builder);
			return IMowingTowerGotoNextFloor.EndIMowingTowerGotoNextFloor(builder);
		}

		// Token: 0x0401235C RID: 74588
		private Table __p;
	}
}
