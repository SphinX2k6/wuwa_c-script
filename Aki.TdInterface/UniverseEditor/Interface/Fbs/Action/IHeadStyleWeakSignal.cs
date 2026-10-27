using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D9 RID: 26841
	public struct IHeadStyleWeakSignal : IFlatbufferObject
	{
		// Token: 0x1700C724 RID: 50980
		// (get) Token: 0x0602ED04 RID: 191748 RVA: 0x006633A1 File Offset: 0x006615A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ED05 RID: 191749 RVA: 0x006633AE File Offset: 0x006615AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ED06 RID: 191750 RVA: 0x006633B8 File Offset: 0x006615B8
		public static IHeadStyleWeakSignal GetRootAsIHeadStyleWeakSignal(ByteBuffer _bb)
		{
			return IHeadStyleWeakSignal.GetRootAsIHeadStyleWeakSignal(_bb, default(IHeadStyleWeakSignal));
		}

		// Token: 0x0602ED07 RID: 191751 RVA: 0x006633D4 File Offset: 0x006615D4
		public static IHeadStyleWeakSignal GetRootAsIHeadStyleWeakSignal(ByteBuffer _bb, IHeadStyleWeakSignal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ED08 RID: 191752 RVA: 0x006633F1 File Offset: 0x006615F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ED09 RID: 191753 RVA: 0x00663400 File Offset: 0x00661600
		public IHeadStyleWeakSignal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C725 RID: 50981
		// (get) Token: 0x0602ED0A RID: 191754 RVA: 0x00663410 File Offset: 0x00661610
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602ED0B RID: 191755 RVA: 0x0066344C File Offset: 0x0066164C
		public static Offset<IHeadStyleWeakSignal> CreateIHeadStyleWeakSignal(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal)
		{
			builder.StartTable(1);
			IHeadStyleWeakSignal.AddType(builder, Type);
			return IHeadStyleWeakSignal.EndIHeadStyleWeakSignal(builder);
		}

		// Token: 0x0602ED0C RID: 191756 RVA: 0x00663462 File Offset: 0x00661662
		public static void StartIHeadStyleWeakSignal(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602ED0D RID: 191757 RVA: 0x0066346B File Offset: 0x0066166B
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ED0E RID: 191758 RVA: 0x00663476 File Offset: 0x00661676
		public static Offset<IHeadStyleWeakSignal> EndIHeadStyleWeakSignal(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleWeakSignal>(builder.EndTable());
		}

		// Token: 0x0602ED0F RID: 191759 RVA: 0x00663484 File Offset: 0x00661684
		public IHeadStyleWeakSignalT UnPack()
		{
			IHeadStyleWeakSignalT headStyleWeakSignalT = new IHeadStyleWeakSignalT();
			this.UnPackTo(headStyleWeakSignalT);
			return headStyleWeakSignalT;
		}

		// Token: 0x0602ED10 RID: 191760 RVA: 0x0066349F File Offset: 0x0066169F
		public void UnPackTo(IHeadStyleWeakSignalT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602ED11 RID: 191761 RVA: 0x006634B0 File Offset: 0x006616B0
		public static Offset<IHeadStyleWeakSignal> Pack(FlatBufferBuilder builder, IHeadStyleWeakSignalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleWeakSignal>);
			}
			return IHeadStyleWeakSignal.CreateIHeadStyleWeakSignal(builder, _o.Type);
		}

		// Token: 0x04011034 RID: 69684
		private Table __p;
	}
}
