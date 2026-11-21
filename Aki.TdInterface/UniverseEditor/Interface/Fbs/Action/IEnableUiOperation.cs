using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D16 RID: 27926
	public struct IEnableUiOperation : IFlatbufferObject
	{
		// Token: 0x1700CCE7 RID: 52455
		// (get) Token: 0x0603029C RID: 197276 RVA: 0x0068CB02 File Offset: 0x0068AD02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603029D RID: 197277 RVA: 0x0068CB0F File Offset: 0x0068AD0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603029E RID: 197278 RVA: 0x0068CB18 File Offset: 0x0068AD18
		public static IEnableUiOperation GetRootAsIEnableUiOperation(ByteBuffer _bb)
		{
			return IEnableUiOperation.GetRootAsIEnableUiOperation(_bb, default(IEnableUiOperation));
		}

		// Token: 0x0603029F RID: 197279 RVA: 0x0068CB34 File Offset: 0x0068AD34
		public static IEnableUiOperation GetRootAsIEnableUiOperation(ByteBuffer _bb, IEnableUiOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302A0 RID: 197280 RVA: 0x0068CB51 File Offset: 0x0068AD51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302A1 RID: 197281 RVA: 0x0068CB60 File Offset: 0x0068AD60
		public IEnableUiOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCE8 RID: 52456
		// (get) Token: 0x060302A2 RID: 197282 RVA: 0x0068CB70 File Offset: 0x0068AD70
		public EUiOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUiOperationType.Enable;
				}
				return (EUiOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060302A3 RID: 197283 RVA: 0x0068CBAC File Offset: 0x0068ADAC
		public static Offset<IEnableUiOperation> CreateIEnableUiOperation(FlatBufferBuilder builder, EUiOperationType Type = EUiOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableUiOperation.AddType(builder, Type);
			return IEnableUiOperation.EndIEnableUiOperation(builder);
		}

		// Token: 0x060302A4 RID: 197284 RVA: 0x0068CBC2 File Offset: 0x0068ADC2
		public static void StartIEnableUiOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060302A5 RID: 197285 RVA: 0x0068CBCB File Offset: 0x0068ADCB
		public static void AddType(FlatBufferBuilder builder, EUiOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060302A6 RID: 197286 RVA: 0x0068CBD6 File Offset: 0x0068ADD6
		public static Offset<IEnableUiOperation> EndIEnableUiOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableUiOperation>(builder.EndTable());
		}

		// Token: 0x060302A7 RID: 197287 RVA: 0x0068CBE4 File Offset: 0x0068ADE4
		public IEnableUiOperationT UnPack()
		{
			IEnableUiOperationT enableUiOperationT = new IEnableUiOperationT();
			this.UnPackTo(enableUiOperationT);
			return enableUiOperationT;
		}

		// Token: 0x060302A8 RID: 197288 RVA: 0x0068CBFF File Offset: 0x0068ADFF
		public void UnPackTo(IEnableUiOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060302A9 RID: 197289 RVA: 0x0068CC10 File Offset: 0x0068AE10
		public static Offset<IEnableUiOperation> Pack(FlatBufferBuilder builder, IEnableUiOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableUiOperation>);
			}
			return IEnableUiOperation.CreateIEnableUiOperation(builder, _o.Type);
		}

		// Token: 0x04011B7D RID: 72573
		private Table __p;
	}
}
