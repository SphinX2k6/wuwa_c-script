using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EFA RID: 28410
	public struct IRoleTowerGotoNextFloor : IFlatbufferObject
	{
		// Token: 0x1700D351 RID: 54097
		// (get) Token: 0x06032333 RID: 205619 RVA: 0x006C8856 File Offset: 0x006C6A56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032334 RID: 205620 RVA: 0x006C8863 File Offset: 0x006C6A63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032335 RID: 205621 RVA: 0x006C886C File Offset: 0x006C6A6C
		public static IRoleTowerGotoNextFloor GetRootAsIRoleTowerGotoNextFloor(ByteBuffer _bb)
		{
			return IRoleTowerGotoNextFloor.GetRootAsIRoleTowerGotoNextFloor(_bb, default(IRoleTowerGotoNextFloor));
		}

		// Token: 0x06032336 RID: 205622 RVA: 0x006C8888 File Offset: 0x006C6A88
		public static IRoleTowerGotoNextFloor GetRootAsIRoleTowerGotoNextFloor(ByteBuffer _bb, IRoleTowerGotoNextFloor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032337 RID: 205623 RVA: 0x006C88A5 File Offset: 0x006C6AA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032338 RID: 205624 RVA: 0x006C88B4 File Offset: 0x006C6AB4
		public IRoleTowerGotoNextFloor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032339 RID: 205625 RVA: 0x006C88C4 File Offset: 0x006C6AC4
		public static void StartIRoleTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603233A RID: 205626 RVA: 0x006C88CD File Offset: 0x006C6ACD
		public static Offset<IRoleTowerGotoNextFloor> EndIRoleTowerGotoNextFloor(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerGotoNextFloor>(builder.EndTable());
		}

		// Token: 0x0603233B RID: 205627 RVA: 0x006C88DC File Offset: 0x006C6ADC
		public IRoleTowerGotoNextFloorT UnPack()
		{
			IRoleTowerGotoNextFloorT roleTowerGotoNextFloorT = new IRoleTowerGotoNextFloorT();
			this.UnPackTo(roleTowerGotoNextFloorT);
			return roleTowerGotoNextFloorT;
		}

		// Token: 0x0603233C RID: 205628 RVA: 0x006C88F7 File Offset: 0x006C6AF7
		public void UnPackTo(IRoleTowerGotoNextFloorT _o)
		{
		}

		// Token: 0x0603233D RID: 205629 RVA: 0x006C88FC File Offset: 0x006C6AFC
		public static Offset<IRoleTowerGotoNextFloor> Pack(FlatBufferBuilder builder, IRoleTowerGotoNextFloorT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerGotoNextFloor>);
			}
			IRoleTowerGotoNextFloor.StartIRoleTowerGotoNextFloor(builder);
			return IRoleTowerGotoNextFloor.EndIRoleTowerGotoNextFloor(builder);
		}

		// Token: 0x040118EF RID: 71919
		private Table __p;
	}
}
