using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007663 RID: 30307
	public struct IRogueGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700DE82 RID: 56962
		// (get) Token: 0x060352BA RID: 217786 RVA: 0x00723366 File Offset: 0x00721566
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060352BB RID: 217787 RVA: 0x00723373 File Offset: 0x00721573
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060352BC RID: 217788 RVA: 0x0072337C File Offset: 0x0072157C
		public static IRogueGotoNextFloor GetRootAsIRogueGotoNextFloor(ByteBuffer _bb)
		{
			return IRogueGotoNextFloor.GetRootAsIRogueGotoNextFloor(_bb, default(IRogueGotoNextFloor));
		}

		// Token: 0x060352BD RID: 217789 RVA: 0x00723398 File Offset: 0x00721598
		public static IRogueGotoNextFloor GetRootAsIRogueGotoNextFloor(ByteBuffer _bb, IRogueGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060352BE RID: 217790 RVA: 0x007233B5 File Offset: 0x007215B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060352BF RID: 217791 RVA: 0x007233C4 File Offset: 0x007215C4
		public IRogueGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060352C0 RID: 217792 RVA: 0x007233D4 File Offset: 0x007215D4
		public static void StartIRogueGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060352C1 RID: 217793 RVA: 0x007233DD File Offset: 0x007215DD
		public static Offset<IRogueGotoNextFloor> EndIRogueGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRogueGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x060352C2 RID: 217794 RVA: 0x007233EC File Offset: 0x007215EC
		public IRogueGotoNextFloorT UnPack()
		{
			IRogueGotoNextFloorT rogueGotoNextFloorT = new IRogueGotoNextFloorT();
			this.UnPackTo(rogueGotoNextFloorT);
			return rogueGotoNextFloorT;
		}

		// Token: 0x060352C3 RID: 217795 RVA: 0x00723407 File Offset: 0x00721607
		public void UnPackTo(IRogueGotoNextFloorT _o)
		{
		}

		// Token: 0x060352C4 RID: 217796 RVA: 0x0072340C File Offset: 0x0072160C
		public static Offset<IRogueGotoNextFloor> Pack(FlatBufferBuilder builder, IRogueGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueGotoNextFloor>);
			}
			IRogueGotoNextFloor.StartIRogueGotoNextFloor(builder);
			return IRogueGotoNextFloor.EndIRogueGotoNextFloor(builder);
		}

		// Token: 0x04012858 RID: 75864
		private Table __p;
	}
}
