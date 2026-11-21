using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023B RID: 571
	[NetMessage(EMessageId.CaptureBatchEntityResponse)]
	public sealed class CaptureBatchEntityResponse : IMessage<CaptureBatchEntityResponse>, IMessage, IEquatable<CaptureBatchEntityResponse>, IDeepCloneable<CaptureBatchEntityResponse>, IBufferMessage
	{
		// Token: 0x06003DC8 RID: 15816 RVA: 0x00099434 File Offset: 0x00097634
		[NullableContext(1)]
		public static CaptureBatchEntityResponse Create()
		{
			return new CaptureBatchEntityResponse();
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x0009943B File Offset: 0x0009763B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x0009943E File Offset: 0x0009763E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureBatchEntityResponse.Descriptor;
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00099445 File Offset: 0x00097645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityResponse()
		{
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00099458 File Offset: 0x00097658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityResponse(CaptureBatchEntityResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x0009948E File Offset: 0x0009768E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityResponse Clone()
		{
			return new CaptureBatchEntityResponse(this);
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x00099496 File Offset: 0x00097696
		// (set) Token: 0x06003DCF RID: 15823 RVA: 0x0009949E File Offset: 0x0009769E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06003DD0 RID: 15824 RVA: 0x000994A7 File Offset: 0x000976A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06003DD1 RID: 15825 RVA: 0x000994AF File Offset: 0x000976AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureBatchEntityResponse);
		}

		// Token: 0x06003DD2 RID: 15826 RVA: 0x000994C0 File Offset: 0x000976C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureBatchEntityResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00099510 File Offset: 0x00097710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00099563 File Offset: 0x00097763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x00099570 File Offset: 0x00097770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x0009957C File Offset: 0x0009777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			this.ids_.WriteTo(ref output, CaptureBatchEntityResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x000995CC File Offset: 0x000977CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.ids_.CalculateSize(CaptureBatchEntityResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00099620 File Offset: 0x00097820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CaptureBatchEntityResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x0009966D File Offset: 0x0009786D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00099678 File Offset: 0x00097878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 96U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, CaptureBatchEntityResponse._repeated_ids_codec);
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002D18 RID: 11544
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D19 RID: 11545
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x04002D1A RID: 11546
		private ErrorCode errCode_;

		// Token: 0x04002D1B RID: 11547
		public const int IdsFieldNumber = 13;

		// Token: 0x04002D1C RID: 11548
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(106U);

		// Token: 0x04002D1D RID: 11549
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}
