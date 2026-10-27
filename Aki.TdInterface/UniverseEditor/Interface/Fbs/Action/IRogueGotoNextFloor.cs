using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDF RID: 28383
	public struct IRogueGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700D32B RID: 54059
		// (get) Token: 0x0603227A RID: 205434 RVA: 0x006C7632 File Offset: 0x006C5832
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603227B RID: 205435 RVA: 0x006C763F File Offset: 0x006C583F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603227C RID: 205436 RVA: 0x006C7648 File Offset: 0x006C5848
		public static IRogueGotoNextFloor GetRootAsIRogueGotoNextFloor(ByteBuffer _bb)
		{
			return IRogueGotoNextFloor.GetRootAsIRogueGotoNextFloor(_bb, default(IRogueGotoNextFloor));
		}

		// Token: 0x0603227D RID: 205437 RVA: 0x006C7664 File Offset: 0x006C5864
		public static IRogueGotoNextFloor GetRootAsIRogueGotoNextFloor(ByteBuffer _bb, IRogueGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603227E RID: 205438 RVA: 0x006C7681 File Offset: 0x006C5881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603227F RID: 205439 RVA: 0x006C7690 File Offset: 0x006C5890
		public IRogueGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032280 RID: 205440 RVA: 0x006C76A0 File Offset: 0x006C58A0
		public static void StartIRogueGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06032281 RID: 205441 RVA: 0x006C76A9 File Offset: 0x006C58A9
		public static Offset<IRogueGotoNextFloor> EndIRogueGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRogueGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x06032282 RID: 205442 RVA: 0x006C76B8 File Offset: 0x006C58B8
		public IRogueGotoNextFloorT UnPack()
		{
			IRogueGotoNextFloorT rogueGotoNextFloorT = new IRogueGotoNextFloorT();
			this.UnPackTo(rogueGotoNextFloorT);
			return rogueGotoNextFloorT;
		}

		// Token: 0x06032283 RID: 205443 RVA: 0x006C76D3 File Offset: 0x006C58D3
		public void UnPackTo(IRogueGotoNextFloorT _o)
		{
		}

		// Token: 0x06032284 RID: 205444 RVA: 0x006C76D8 File Offset: 0x006C58D8
		public static Offset<IRogueGotoNextFloor> Pack(FlatBufferBuilder builder, IRogueGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueGotoNextFloor>);
			}
			IRogueGotoNextFloor.StartIRogueGotoNextFloor(builder);
			return IRogueGotoNextFloor.EndIRogueGotoNextFloor(builder);
		}

		// Token: 0x040118D3 RID: 71891
		private Table __p;
	}
}
