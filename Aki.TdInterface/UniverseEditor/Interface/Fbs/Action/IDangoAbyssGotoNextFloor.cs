using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200652E RID: 25902
	public struct IDangoAbyssGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700C096 RID: 49302
		// (get) Token: 0x0602CF01 RID: 184065 RVA: 0x0062BB9A File Offset: 0x00629D9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF02 RID: 184066 RVA: 0x0062BBA7 File Offset: 0x00629DA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF03 RID: 184067 RVA: 0x0062BBB0 File Offset: 0x00629DB0
		public static IDangoAbyssGotoNextFloor GetRootAsIDangoAbyssGotoNextFloor(ByteBuffer _bb)
		{
			return IDangoAbyssGotoNextFloor.GetRootAsIDangoAbyssGotoNextFloor(_bb, default(IDangoAbyssGotoNextFloor));
		}

		// Token: 0x0602CF04 RID: 184068 RVA: 0x0062BBCC File Offset: 0x00629DCC
		public static IDangoAbyssGotoNextFloor GetRootAsIDangoAbyssGotoNextFloor(ByteBuffer _bb, IDangoAbyssGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF05 RID: 184069 RVA: 0x0062BBE9 File Offset: 0x00629DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF06 RID: 184070 RVA: 0x0062BBF8 File Offset: 0x00629DF8
		public IDangoAbyssGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CF07 RID: 184071 RVA: 0x0062BC08 File Offset: 0x00629E08
		public static void StartIDangoAbyssGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602CF08 RID: 184072 RVA: 0x0062BC11 File Offset: 0x00629E11
		public static Offset<IDangoAbyssGotoNextFloor> EndIDangoAbyssGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IDangoAbyssGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x0602CF09 RID: 184073 RVA: 0x0062BC20 File Offset: 0x00629E20
		public IDangoAbyssGotoNextFloorT UnPack()
		{
			IDangoAbyssGotoNextFloorT dangoAbyssGotoNextFloorT = new IDangoAbyssGotoNextFloorT();
			this.UnPackTo(dangoAbyssGotoNextFloorT);
			return dangoAbyssGotoNextFloorT;
		}

		// Token: 0x0602CF0A RID: 184074 RVA: 0x0062BC3B File Offset: 0x00629E3B
		public void UnPackTo(IDangoAbyssGotoNextFloorT _o)
		{
		}

		// Token: 0x0602CF0B RID: 184075 RVA: 0x0062BC40 File Offset: 0x00629E40
		public static Offset<IDangoAbyssGotoNextFloor> Pack(FlatBufferBuilder builder, IDangoAbyssGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDangoAbyssGotoNextFloor>);
			}
			IDangoAbyssGotoNextFloor.StartIDangoAbyssGotoNextFloor(builder);
			return IDangoAbyssGotoNextFloor.EndIDangoAbyssGotoNextFloor(builder);
		}

		// Token: 0x04010B7A RID: 68474
		private Table __p;
	}
}
