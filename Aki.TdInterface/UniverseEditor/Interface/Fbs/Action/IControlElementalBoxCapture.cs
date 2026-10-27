using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064CB RID: 25803
	public struct IControlElementalBoxCapture : IFlatbufferObject
	{
		// Token: 0x1700C008 RID: 49160
		// (get) Token: 0x0602CC26 RID: 183334 RVA: 0x00626ECC File Offset: 0x006250CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC27 RID: 183335 RVA: 0x00626ED9 File Offset: 0x006250D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC28 RID: 183336 RVA: 0x00626EE0 File Offset: 0x006250E0
		public static IControlElementalBoxCapture GetRootAsIControlElementalBoxCapture(ByteBuffer _bb)
		{
			return IControlElementalBoxCapture.GetRootAsIControlElementalBoxCapture(_bb, default(IControlElementalBoxCapture));
		}

		// Token: 0x0602CC29 RID: 183337 RVA: 0x00626EFC File Offset: 0x006250FC
		public static IControlElementalBoxCapture GetRootAsIControlElementalBoxCapture(ByteBuffer _bb, IControlElementalBoxCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC2A RID: 183338 RVA: 0x00626F19 File Offset: 0x00625119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC2B RID: 183339 RVA: 0x00626F28 File Offset: 0x00625128
		public IControlElementalBoxCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C009 RID: 49161
		// (get) Token: 0x0602CC2C RID: 183340 RVA: 0x00626F38 File Offset: 0x00625138
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

		// Token: 0x1700C00A RID: 49162
		// (get) Token: 0x0602CC2D RID: 183341 RVA: 0x00626F74 File Offset: 0x00625174
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

		// Token: 0x0602CC2E RID: 183342 RVA: 0x00626FAB File Offset: 0x006251AB
		public Span<byte> GetCaptureCompleteSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CC2F RID: 183343 RVA: 0x00626FBA File Offset: 0x006251BA
		public byte[] GetCaptureCompleteSeqArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CC30 RID: 183344 RVA: 0x00626FC8 File Offset: 0x006251C8
		public static Offset<IControlElementalBoxCapture> CreateIControlElementalBoxCapture(FlatBufferBuilder builder, EControlElementalBoxType Type = EControlElementalBoxType.Capture, StringOffset CaptureCompleteSeqOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IControlElementalBoxCapture.AddCaptureCompleteSeq(builder, CaptureCompleteSeqOffset);
			IControlElementalBoxCapture.AddType(builder, Type);
			return IControlElementalBoxCapture.EndIControlElementalBoxCapture(builder);
		}

		// Token: 0x0602CC31 RID: 183345 RVA: 0x00626FE5 File Offset: 0x006251E5
		public static void StartIControlElementalBoxCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CC32 RID: 183346 RVA: 0x00626FEE File Offset: 0x006251EE
		public static void AddType(FlatBufferBuilder builder, EControlElementalBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CC33 RID: 183347 RVA: 0x00626FF9 File Offset: 0x006251F9
		public static void AddCaptureCompleteSeq(FlatBufferBuilder builder, StringOffset captureCompleteSeqOffset)
		{
			builder.AddOffset(1, captureCompleteSeqOffset.Value, 0);
		}

		// Token: 0x0602CC34 RID: 183348 RVA: 0x00627009 File Offset: 0x00625209
		public static Offset<IControlElementalBoxCapture> EndIControlElementalBoxCapture(FlatBufferBuilder builder)
		{
			return new Offset<IControlElementalBoxCapture>(builder.EndTable());
		}

		// Token: 0x0602CC35 RID: 183349 RVA: 0x00627018 File Offset: 0x00625218
		public IControlElementalBoxCaptureT UnPack()
		{
			IControlElementalBoxCaptureT controlElementalBoxCaptureT = new IControlElementalBoxCaptureT();
			this.UnPackTo(controlElementalBoxCaptureT);
			return controlElementalBoxCaptureT;
		}

		// Token: 0x0602CC36 RID: 183350 RVA: 0x00627033 File Offset: 0x00625233
		public void UnPackTo(IControlElementalBoxCaptureT _o)
		{
			_o.Type = this.Type;
			_o.CaptureCompleteSeq = this.CaptureCompleteSeq;
		}

		// Token: 0x0602CC37 RID: 183351 RVA: 0x00627050 File Offset: 0x00625250
		public static Offset<IControlElementalBoxCapture> Pack(FlatBufferBuilder builder, IControlElementalBoxCaptureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IControlElementalBoxCapture>);
			}
			StringOffset captureCompleteSeqOffset = (_o.CaptureCompleteSeq == null) ? default(StringOffset) : builder.CreateString(_o.CaptureCompleteSeq);
			return IControlElementalBoxCapture.CreateIControlElementalBoxCapture(builder, _o.Type, captureCompleteSeqOffset);
		}

		// Token: 0x04010B03 RID: 68355
		private Table __p;
	}
}
