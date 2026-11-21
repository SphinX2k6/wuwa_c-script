using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F21 RID: 24353
	public struct ISingleBtnQte : IFlatbufferObject
	{
		// Token: 0x1700B422 RID: 46114
		// (get) Token: 0x06028E10 RID: 167440 RVA: 0x00595E04 File Offset: 0x00594004
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E11 RID: 167441 RVA: 0x00595E11 File Offset: 0x00594011
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E12 RID: 167442 RVA: 0x00595E18 File Offset: 0x00594018
		public static ISingleBtnQte GetRootAsISingleBtnQte(ByteBuffer _bb)
		{
			return ISingleBtnQte.GetRootAsISingleBtnQte(_bb, default(ISingleBtnQte));
		}

		// Token: 0x06028E13 RID: 167443 RVA: 0x00595E34 File Offset: 0x00594034
		public static ISingleBtnQte GetRootAsISingleBtnQte(ByteBuffer _bb, ISingleBtnQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E14 RID: 167444 RVA: 0x00595E51 File Offset: 0x00594051
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E15 RID: 167445 RVA: 0x00595E60 File Offset: 0x00594060
		public ISingleBtnQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B423 RID: 46115
		// (get) Token: 0x06028E16 RID: 167446 RVA: 0x00595E70 File Offset: 0x00594070
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

		// Token: 0x1700B424 RID: 46116
		// (get) Token: 0x06028E17 RID: 167447 RVA: 0x00595EAC File Offset: 0x005940AC
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

		// Token: 0x1700B425 RID: 46117
		// (get) Token: 0x06028E18 RID: 167448 RVA: 0x00595EE8 File Offset: 0x005940E8
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

		// Token: 0x1700B426 RID: 46118
		// (get) Token: 0x06028E19 RID: 167449 RVA: 0x00595F48 File Offset: 0x00594148
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

		// Token: 0x06028E1A RID: 167450 RVA: 0x00595FA6 File Offset: 0x005941A6
		public static Offset<ISingleBtnQte> CreateISingleBtnQte(FlatBufferBuilder builder, EQteType Type = EQteType.SingleBtn, int QteId = 0, Offset<IQteCallback> SuccessCallbackOffset = default(Offset<IQteCallback>), Offset<IQteCallback> FailureCallbackOffset = default(Offset<IQteCallback>))
		{
			builder.StartTable(4);
			ISingleBtnQte.AddFailureCallback(builder, FailureCallbackOffset);
			ISingleBtnQte.AddSuccessCallback(builder, SuccessCallbackOffset);
			ISingleBtnQte.AddQteId(builder, QteId);
			ISingleBtnQte.AddType(builder, Type);
			return ISingleBtnQte.EndISingleBtnQte(builder);
		}

		// Token: 0x06028E1B RID: 167451 RVA: 0x00595FD2 File Offset: 0x005941D2
		public static void StartISingleBtnQte(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028E1C RID: 167452 RVA: 0x00595FDB File Offset: 0x005941DB
		public static void AddType(FlatBufferBuilder builder, EQteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028E1D RID: 167453 RVA: 0x00595FE6 File Offset: 0x005941E6
		public static void AddQteId(FlatBufferBuilder builder, int qteId)
		{
			builder.AddInt(1, qteId, 0);
		}

		// Token: 0x06028E1E RID: 167454 RVA: 0x00595FF1 File Offset: 0x005941F1
		public static void AddSuccessCallback(FlatBufferBuilder builder, Offset<IQteCallback> successCallbackOffset)
		{
			builder.AddOffset(2, successCallbackOffset.Value, 0);
		}

		// Token: 0x06028E1F RID: 167455 RVA: 0x00596001 File Offset: 0x00594201
		public static void AddFailureCallback(FlatBufferBuilder builder, Offset<IQteCallback> failureCallbackOffset)
		{
			builder.AddOffset(3, failureCallbackOffset.Value, 0);
		}

		// Token: 0x06028E20 RID: 167456 RVA: 0x00596011 File Offset: 0x00594211
		public static Offset<ISingleBtnQte> EndISingleBtnQte(FlatBufferBuilder builder)
		{
			return new Offset<ISingleBtnQte>(builder.EndTable());
		}

		// Token: 0x06028E21 RID: 167457 RVA: 0x00596020 File Offset: 0x00594220
		public ISingleBtnQteT UnPack()
		{
			ISingleBtnQteT singleBtnQteT = new ISingleBtnQteT();
			this.UnPackTo(singleBtnQteT);
			return singleBtnQteT;
		}

		// Token: 0x06028E22 RID: 167458 RVA: 0x0059603C File Offset: 0x0059423C
		public void UnPackTo(ISingleBtnQteT _o)
		{
			_o.Type = this.Type;
			_o.QteId = this.QteId;
			_o.SuccessCallback = ((this.SuccessCallback != null) ? this.SuccessCallback.Value.UnPack() : null);
			_o.FailureCallback = ((this.FailureCallback != null) ? this.FailureCallback.Value.UnPack() : null);
		}

		// Token: 0x06028E23 RID: 167459 RVA: 0x005960C0 File Offset: 0x005942C0
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

		// Token: 0x0400FBAC RID: 64428
		private Table __p;
	}
}
