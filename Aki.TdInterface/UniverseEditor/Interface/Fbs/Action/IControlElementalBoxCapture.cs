using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B36 RID: 27446
	public struct IControlElementalBoxCapture : IFlatbufferObject
	{
		// Token: 0x1700C995 RID: 51605
		// (get) Token: 0x0602F3AA RID: 193450 RVA: 0x00672FF4 File Offset: 0x006711F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F3AB RID: 193451 RVA: 0x00673001 File Offset: 0x00671201
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F3AC RID: 193452 RVA: 0x00673008 File Offset: 0x00671208
		public static IControlElementalBoxCapture GetRootAsIControlElementalBoxCapture(ByteBuffer _bb)
		{
			return IControlElementalBoxCapture.GetRootAsIControlElementalBoxCapture(_bb, default(IControlElementalBoxCapture));
		}

		// Token: 0x0602F3AD RID: 193453 RVA: 0x00673024 File Offset: 0x00671224
		public static IControlElementalBoxCapture GetRootAsIControlElementalBoxCapture(ByteBuffer _bb, IControlElementalBoxCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F3AE RID: 193454 RVA: 0x00673041 File Offset: 0x00671241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F3AF RID: 193455 RVA: 0x00673050 File Offset: 0x00671250
		public IControlElementalBoxCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C996 RID: 51606
		// (get) Token: 0x0602F3B0 RID: 193456 RVA: 0x00673060 File Offset: 0x00671260
		public EControlElementalBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControlElementalBoxType.Capture;
				}
				return (EControlElementalBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C997 RID: 51607
		// (get) Token: 0x0602F3B1 RID: 193457 RVA: 0x0067309C File Offset: 0x0067129C
		public string CaptureCompleteSeq
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F3B2 RID: 193458 RVA: 0x006730D3 File Offset: 0x006712D3
		public Span<byte> GetCaptureCompleteSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602F3B3 RID: 193459 RVA: 0x006730E2 File Offset: 0x006712E2
		public byte[] GetCaptureCompleteSeqArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602F3B4 RID: 193460 RVA: 0x006730F0 File Offset: 0x006712F0
		public static Offset<IControlElementalBoxCapture> CreateIControlElementalBoxCapture(FlatBufferBuilder builder, EControlElementalBoxType Type = EControlElementalBoxType.Capture, StringOffset CaptureCompleteSeqOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IControlElementalBoxCapture.AddCaptureCompleteSeq(builder, CaptureCompleteSeqOffset);
			IControlElementalBoxCapture.AddType(builder, Type);
			return IControlElementalBoxCapture.EndIControlElementalBoxCapture(builder);
		}

		// Token: 0x0602F3B5 RID: 193461 RVA: 0x0067310D File Offset: 0x0067130D
		public static void StartIControlElementalBoxCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F3B6 RID: 193462 RVA: 0x00673116 File Offset: 0x00671316
		public static void AddType(FlatBufferBuilder builder, EControlElementalBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F3B7 RID: 193463 RVA: 0x00673121 File Offset: 0x00671321
		public static void AddCaptureCompleteSeq(FlatBufferBuilder builder, StringOffset captureCompleteSeqOffset)
		{
			builder.AddOffset(1, captureCompleteSeqOffset.Value, 0);
		}

		// Token: 0x0602F3B8 RID: 193464 RVA: 0x00673131 File Offset: 0x00671331
		public static Offset<IControlElementalBoxCapture> EndIControlElementalBoxCapture(FlatBufferBuilder builder)
		{
			return new Offset<IControlElementalBoxCapture>(builder.EndTable());
		}

		// Token: 0x0602F3B9 RID: 193465 RVA: 0x00673140 File Offset: 0x00671340
		public IControlElementalBoxCaptureT UnPack()
		{
			IControlElementalBoxCaptureT controlElementalBoxCaptureT = new IControlElementalBoxCaptureT();
			this.UnPackTo(controlElementalBoxCaptureT);
			return controlElementalBoxCaptureT;
		}

		// Token: 0x0602F3BA RID: 193466 RVA: 0x0067315B File Offset: 0x0067135B
		public void UnPackTo(IControlElementalBoxCaptureT _o)
		{
			_o.Type = this.Type;
			_o.CaptureCompleteSeq = this.CaptureCompleteSeq;
		}

		// Token: 0x0602F3BB RID: 193467 RVA: 0x00673178 File Offset: 0x00671378
		public static Offset<IControlElementalBoxCapture> Pack(FlatBufferBuilder builder, IControlElementalBoxCaptureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlElementalBoxCapture>);
			}
			StringOffset captureCompleteSeqOffset = (_o.CaptureCompleteSeq == null) ? default(StringOffset) : builder.CreateString(_o.CaptureCompleteSeq);
			return IControlElementalBoxCapture.CreateIControlElementalBoxCapture(builder, _o.Type, captureCompleteSeqOffset);
		}

		// Token: 0x04011919 RID: 71961
		private Table __p;
	}
}
