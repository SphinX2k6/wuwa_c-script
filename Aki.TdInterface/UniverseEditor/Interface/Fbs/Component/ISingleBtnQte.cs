using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005914 RID: 22804
	public struct ISingleBtnQte : IFlatbufferObject
	{
		// Token: 0x1700AAEE RID: 43758
		// (get) Token: 0x060268A6 RID: 157862 RVA: 0x0054F198 File Offset: 0x0054D398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060268A7 RID: 157863 RVA: 0x0054F1A5 File Offset: 0x0054D3A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060268A8 RID: 157864 RVA: 0x0054F1AC File Offset: 0x0054D3AC
		public static ISingleBtnQte GetRootAsISingleBtnQte(ByteBuffer _bb)
		{
			return ISingleBtnQte.GetRootAsISingleBtnQte(_bb, default(ISingleBtnQte));
		}

		// Token: 0x060268A9 RID: 157865 RVA: 0x0054F1C8 File Offset: 0x0054D3C8
		public static ISingleBtnQte GetRootAsISingleBtnQte(ByteBuffer _bb, ISingleBtnQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060268AA RID: 157866 RVA: 0x0054F1E5 File Offset: 0x0054D3E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060268AB RID: 157867 RVA: 0x0054F1F4 File Offset: 0x0054D3F4
		public ISingleBtnQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAEF RID: 43759
		// (get) Token: 0x060268AC RID: 157868 RVA: 0x0054F204 File Offset: 0x0054D404
		public EQteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQteType.SingleBtn;
				}
				return (EQteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAF0 RID: 43760
		// (get) Token: 0x060268AD RID: 157869 RVA: 0x0054F240 File Offset: 0x0054D440
		public int QteId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AAF1 RID: 43761
		// (get) Token: 0x060268AE RID: 157870 RVA: 0x0054F27C File Offset: 0x0054D47C
		public IQteCallback? SuccessCallback
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IQteCallback?(default(IQteCallback).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AAF2 RID: 43762
		// (get) Token: 0x060268AF RID: 157871 RVA: 0x0054F2DC File Offset: 0x0054D4DC
		public IQteCallback? FailureCallback
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IQteCallback?(default(IQteCallback).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060268B0 RID: 157872 RVA: 0x0054F33A File Offset: 0x0054D53A
		public static Offset<ISingleBtnQte> CreateISingleBtnQte(FlatBufferBuilder builder, EQteType Type = EQteType.SingleBtn, int QteId = 0, Offset<IQteCallback> SuccessCallbackOffset = default(Offset<IQteCallback>), Offset<IQteCallback> FailureCallbackOffset = default(Offset<IQteCallback>))
		{
			builder.StartTable(4);
			ISingleBtnQte.AddFailureCallback(builder, FailureCallbackOffset);
			ISingleBtnQte.AddSuccessCallback(builder, SuccessCallbackOffset);
			ISingleBtnQte.AddQteId(builder, QteId);
			ISingleBtnQte.AddType(builder, Type);
			return ISingleBtnQte.EndISingleBtnQte(builder);
		}

		// Token: 0x060268B1 RID: 157873 RVA: 0x0054F366 File Offset: 0x0054D566
		public static void StartISingleBtnQte(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060268B2 RID: 157874 RVA: 0x0054F36F File Offset: 0x0054D56F
		public static void AddType(FlatBufferBuilder builder, EQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060268B3 RID: 157875 RVA: 0x0054F37A File Offset: 0x0054D57A
		public static void AddQteId(FlatBufferBuilder builder, int qteId)
		{
			builder.AddInt(1, qteId, 0);
		}

		// Token: 0x060268B4 RID: 157876 RVA: 0x0054F385 File Offset: 0x0054D585
		public static void AddSuccessCallback(FlatBufferBuilder builder, Offset<IQteCallback> successCallbackOffset)
		{
			builder.AddOffset(2, successCallbackOffset.Value, 0);
		}

		// Token: 0x060268B5 RID: 157877 RVA: 0x0054F395 File Offset: 0x0054D595
		public static void AddFailureCallback(FlatBufferBuilder builder, Offset<IQteCallback> failureCallbackOffset)
		{
			builder.AddOffset(3, failureCallbackOffset.Value, 0);
		}

		// Token: 0x060268B6 RID: 157878 RVA: 0x0054F3A5 File Offset: 0x0054D5A5
		public static Offset<ISingleBtnQte> EndISingleBtnQte(FlatBufferBuilder builder)
		{
			return new Offset<ISingleBtnQte>(builder.EndTable());
		}

		// Token: 0x060268B7 RID: 157879 RVA: 0x0054F3B4 File Offset: 0x0054D5B4
		public ISingleBtnQteT UnPack()
		{
			ISingleBtnQteT singleBtnQteT = new ISingleBtnQteT();
			this.UnPackTo(singleBtnQteT);
			return singleBtnQteT;
		}

		// Token: 0x060268B8 RID: 157880 RVA: 0x0054F3D0 File Offset: 0x0054D5D0
		public void UnPackTo(ISingleBtnQteT _o)
		{
			_o.Type = this.Type;
			_o.QteId = this.QteId;
			_o.SuccessCallback = ((this.SuccessCallback != null) ? this.SuccessCallback.Value.UnPack() : null);
			_o.FailureCallback = ((this.FailureCallback != null) ? this.FailureCallback.Value.UnPack() : null);
		}

		// Token: 0x060268B9 RID: 157881 RVA: 0x0054F454 File Offset: 0x0054D654
		public static Offset<ISingleBtnQte> Pack(FlatBufferBuilder builder, ISingleBtnQteT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISingleBtnQte>);
			}
			Offset<IQteCallback> successCallbackOffset = (_o.SuccessCallback == null) ? default(Offset<IQteCallback>) : IQteCallback.Pack(builder, _o.SuccessCallback);
			Offset<IQteCallback> failureCallbackOffset = (_o.FailureCallback == null) ? default(Offset<IQteCallback>) : IQteCallback.Pack(builder, _o.FailureCallback);
			return ISingleBtnQte.CreateISingleBtnQte(builder, _o.Type, _o.QteId, successCallbackOffset, failureCallbackOffset);
		}

		// Token: 0x0400EEB7 RID: 61111
		private Table __p;
	}
}
