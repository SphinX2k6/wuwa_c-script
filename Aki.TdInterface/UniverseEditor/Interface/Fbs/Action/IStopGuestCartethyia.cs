using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CC RID: 29132
	public struct IStopGuestCartethyia : IFlatbufferObject
	{
		// Token: 0x1700D872 RID: 55410
		// (get) Token: 0x06033AD9 RID: 211673 RVA: 0x006F572E File Offset: 0x006F392E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033ADA RID: 211674 RVA: 0x006F573B File Offset: 0x006F393B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033ADB RID: 211675 RVA: 0x006F5744 File Offset: 0x006F3944
		public static IStopGuestCartethyia GetRootAsIStopGuestCartethyia(ByteBuffer _bb)
		{
			return IStopGuestCartethyia.GetRootAsIStopGuestCartethyia(_bb, default(IStopGuestCartethyia));
		}

		// Token: 0x06033ADC RID: 211676 RVA: 0x006F5760 File Offset: 0x006F3960
		public static IStopGuestCartethyia GetRootAsIStopGuestCartethyia(ByteBuffer _bb, IStopGuestCartethyia obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033ADD RID: 211677 RVA: 0x006F577D File Offset: 0x006F397D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033ADE RID: 211678 RVA: 0x006F578C File Offset: 0x006F398C
		public IStopGuestCartethyia __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D873 RID: 55411
		// (get) Token: 0x06033ADF RID: 211679 RVA: 0x006F579C File Offset: 0x006F399C
		public EGuestUiAnimationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGuestUiAnimationType.GuestCartethyia;
				}
				return (EGuestUiAnimationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033AE0 RID: 211680 RVA: 0x006F57D8 File Offset: 0x006F39D8
		public static Offset<IStopGuestCartethyia> CreateIStopGuestCartethyia(FlatBufferBuilder builder, EGuestUiAnimationType Type = EGuestUiAnimationType.GuestCartethyia)
		{
			builder.StartTable(1);
			IStopGuestCartethyia.AddType(builder, Type);
			return IStopGuestCartethyia.EndIStopGuestCartethyia(builder);
		}

		// Token: 0x06033AE1 RID: 211681 RVA: 0x006F57EE File Offset: 0x006F39EE
		public static void StartIStopGuestCartethyia(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033AE2 RID: 211682 RVA: 0x006F57F7 File Offset: 0x006F39F7
		public static void AddType(FlatBufferBuilder builder, EGuestUiAnimationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033AE3 RID: 211683 RVA: 0x006F5802 File Offset: 0x006F3A02
		public static Offset<IStopGuestCartethyia> EndIStopGuestCartethyia(FlatBufferBuilder builder)
		{
			return new Offset<IStopGuestCartethyia>(builder.EndTable());
		}

		// Token: 0x06033AE4 RID: 211684 RVA: 0x006F5810 File Offset: 0x006F3A10
		public IStopGuestCartethyiaT UnPack()
		{
			IStopGuestCartethyiaT stopGuestCartethyiaT = new IStopGuestCartethyiaT();
			this.UnPackTo(stopGuestCartethyiaT);
			return stopGuestCartethyiaT;
		}

		// Token: 0x06033AE5 RID: 211685 RVA: 0x006F582B File Offset: 0x006F3A2B
		public void UnPackTo(IStopGuestCartethyiaT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033AE6 RID: 211686 RVA: 0x006F583C File Offset: 0x006F3A3C
		public static Offset<IStopGuestCartethyia> Pack(FlatBufferBuilder builder, IStopGuestCartethyiaT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopGuestCartethyia>);
			}
			return IStopGuestCartethyia.CreateIStopGuestCartethyia(builder, _o.Type);
		}

		// Token: 0x04011CAE RID: 72878
		private Table __p;
	}
}
