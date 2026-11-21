using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F89 RID: 28553
	public struct IHeadStyleWeakSignal : IFlatbufferObject
	{
		// Token: 0x1700D11E RID: 53534
		// (get) Token: 0x060316B6 RID: 202422 RVA: 0x006B34E9 File Offset: 0x006B16E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316B7 RID: 202423 RVA: 0x006B34F6 File Offset: 0x006B16F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316B8 RID: 202424 RVA: 0x006B3500 File Offset: 0x006B1700
		public static IHeadStyleWeakSignal GetRootAsIHeadStyleWeakSignal(ByteBuffer _bb)
		{
			return IHeadStyleWeakSignal.GetRootAsIHeadStyleWeakSignal(_bb, default(IHeadStyleWeakSignal));
		}

		// Token: 0x060316B9 RID: 202425 RVA: 0x006B351C File Offset: 0x006B171C
		public static IHeadStyleWeakSignal GetRootAsIHeadStyleWeakSignal(ByteBuffer _bb, IHeadStyleWeakSignal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316BA RID: 202426 RVA: 0x006B3539 File Offset: 0x006B1739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316BB RID: 202427 RVA: 0x006B3548 File Offset: 0x006B1748
		public IHeadStyleWeakSignal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D11F RID: 53535
		// (get) Token: 0x060316BC RID: 202428 RVA: 0x006B3558 File Offset: 0x006B1758
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

		// Token: 0x060316BD RID: 202429 RVA: 0x006B3594 File Offset: 0x006B1794
		public static Offset<IHeadStyleWeakSignal> CreateIHeadStyleWeakSignal(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal)
		{
			builder.StartTable(1);
			IHeadStyleWeakSignal.AddType(builder, Type);
			return IHeadStyleWeakSignal.EndIHeadStyleWeakSignal(builder);
		}

		// Token: 0x060316BE RID: 202430 RVA: 0x006B35AA File Offset: 0x006B17AA
		public static void StartIHeadStyleWeakSignal(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060316BF RID: 202431 RVA: 0x006B35B3 File Offset: 0x006B17B3
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060316C0 RID: 202432 RVA: 0x006B35BE File Offset: 0x006B17BE
		public static Offset<IHeadStyleWeakSignal> EndIHeadStyleWeakSignal(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleWeakSignal>(builder.EndTable());
		}

		// Token: 0x060316C1 RID: 202433 RVA: 0x006B35CC File Offset: 0x006B17CC
		public IHeadStyleWeakSignalT UnPack()
		{
			IHeadStyleWeakSignalT headStyleWeakSignalT = new IHeadStyleWeakSignalT();
			this.UnPackTo(headStyleWeakSignalT);
			return headStyleWeakSignalT;
		}

		// Token: 0x060316C2 RID: 202434 RVA: 0x006B35E7 File Offset: 0x006B17E7
		public void UnPackTo(IHeadStyleWeakSignalT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060316C3 RID: 202435 RVA: 0x006B35F8 File Offset: 0x006B17F8
		public static Offset<IHeadStyleWeakSignal> Pack(FlatBufferBuilder builder, IHeadStyleWeakSignalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleWeakSignal>);
			}
			return IHeadStyleWeakSignal.CreateIHeadStyleWeakSignal(builder, _o.Type);
		}

		// Token: 0x04011E9B RID: 73371
		private Table __p;
	}
}
