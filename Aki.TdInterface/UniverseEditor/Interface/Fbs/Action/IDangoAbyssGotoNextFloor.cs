using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9C RID: 27548
	public struct IDangoAbyssGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700CA28 RID: 51752
		// (get) Token: 0x0602F69F RID: 194207 RVA: 0x00678046 File Offset: 0x00676246
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F6A0 RID: 194208 RVA: 0x00678053 File Offset: 0x00676253
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F6A1 RID: 194209 RVA: 0x0067805C File Offset: 0x0067625C
		public static IDangoAbyssGotoNextFloor GetRootAsIDangoAbyssGotoNextFloor(ByteBuffer _bb)
		{
			return IDangoAbyssGotoNextFloor.GetRootAsIDangoAbyssGotoNextFloor(_bb, default(IDangoAbyssGotoNextFloor));
		}

		// Token: 0x0602F6A2 RID: 194210 RVA: 0x00678078 File Offset: 0x00676278
		public static IDangoAbyssGotoNextFloor GetRootAsIDangoAbyssGotoNextFloor(ByteBuffer _bb, IDangoAbyssGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F6A3 RID: 194211 RVA: 0x00678095 File Offset: 0x00676295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F6A4 RID: 194212 RVA: 0x006780A4 File Offset: 0x006762A4
		public IDangoAbyssGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F6A5 RID: 194213 RVA: 0x006780B4 File Offset: 0x006762B4
		public static void StartIDangoAbyssGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602F6A6 RID: 194214 RVA: 0x006780BD File Offset: 0x006762BD
		public static Offset<IDangoAbyssGotoNextFloor> EndIDangoAbyssGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x0602F6A7 RID: 194215 RVA: 0x006780CC File Offset: 0x006762CC
		public IDangoAbyssGotoNextFloorT UnPack()
		{
			IDangoAbyssGotoNextFloorT dangoAbyssGotoNextFloorT = new IDangoAbyssGotoNextFloorT();
			this.UnPackTo(dangoAbyssGotoNextFloorT);
			return dangoAbyssGotoNextFloorT;
		}

		// Token: 0x0602F6A8 RID: 194216 RVA: 0x006780E7 File Offset: 0x006762E7
		public void UnPackTo(IDangoAbyssGotoNextFloorT _o)
		{
		}

		// Token: 0x0602F6A9 RID: 194217 RVA: 0x006780EC File Offset: 0x006762EC
		public static Offset<IDangoAbyssGotoNextFloor> Pack(FlatBufferBuilder builder, IDangoAbyssGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssGotoNextFloor>);
			}
			IDangoAbyssGotoNextFloor.StartIDangoAbyssGotoNextFloor(builder);
			return IDangoAbyssGotoNextFloor.EndIDangoAbyssGotoNextFloor(builder);
		}

		// Token: 0x04011993 RID: 72083
		private Table __p;
	}
}
