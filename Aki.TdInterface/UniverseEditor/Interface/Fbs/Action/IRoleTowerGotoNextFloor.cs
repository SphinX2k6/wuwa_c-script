using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767E RID: 30334
	public struct IRoleTowerGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700DEA8 RID: 57000
		// (get) Token: 0x06035373 RID: 217971 RVA: 0x0072458A File Offset: 0x0072278A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035374 RID: 217972 RVA: 0x00724597 File Offset: 0x00722797
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035375 RID: 217973 RVA: 0x007245A0 File Offset: 0x007227A0
		public static IRoleTowerGotoNextFloor GetRootAsIRoleTowerGotoNextFloor(ByteBuffer _bb)
		{
			return IRoleTowerGotoNextFloor.GetRootAsIRoleTowerGotoNextFloor(_bb, default(IRoleTowerGotoNextFloor));
		}

		// Token: 0x06035376 RID: 217974 RVA: 0x007245BC File Offset: 0x007227BC
		public static IRoleTowerGotoNextFloor GetRootAsIRoleTowerGotoNextFloor(ByteBuffer _bb, IRoleTowerGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035377 RID: 217975 RVA: 0x007245D9 File Offset: 0x007227D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035378 RID: 217976 RVA: 0x007245E8 File Offset: 0x007227E8
		public IRoleTowerGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06035379 RID: 217977 RVA: 0x007245F8 File Offset: 0x007227F8
		public static void StartIRoleTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603537A RID: 217978 RVA: 0x00724601 File Offset: 0x00722801
		public static Offset<IRoleTowerGotoNextFloor> EndIRoleTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x0603537B RID: 217979 RVA: 0x00724610 File Offset: 0x00722810
		public IRoleTowerGotoNextFloorT UnPack()
		{
			IRoleTowerGotoNextFloorT roleTowerGotoNextFloorT = new IRoleTowerGotoNextFloorT();
			this.UnPackTo(roleTowerGotoNextFloorT);
			return roleTowerGotoNextFloorT;
		}

		// Token: 0x0603537C RID: 217980 RVA: 0x0072462B File Offset: 0x0072282B
		public void UnPackTo(IRoleTowerGotoNextFloorT _o)
		{
		}

		// Token: 0x0603537D RID: 217981 RVA: 0x00724630 File Offset: 0x00722830
		public static Offset<IRoleTowerGotoNextFloor> Pack(FlatBufferBuilder builder, IRoleTowerGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerGotoNextFloor>);
			}
			IRoleTowerGotoNextFloor.StartIRoleTowerGotoNextFloor(builder);
			return IRoleTowerGotoNextFloor.EndIRoleTowerGotoNextFloor(builder);
		}

		// Token: 0x04012874 RID: 75892
		private Table __p;
	}
}
