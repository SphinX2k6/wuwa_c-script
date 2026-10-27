using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000236 RID: 566
	[NetMessage(EMessageId.CaptureBatchEntityResponse)]
	public sealed class CaptureBatchEntityResponse : IMessage<CaptureBatchEntityResponse>, IMessage, IEquatable<CaptureBatchEntityResponse>, IDeepCloneable<CaptureBatchEntityResponse>, IBufferMessage
	{
		// Token: 0x06003D23 RID: 15651 RVA: 0x00097818 File Offset: 0x00095A18
		[NullableContext(1)]
		public static CaptureBatchEntityResponse Create()
		{
			return new CaptureBatchEntityResponse();
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x0009781F File Offset: 0x00095A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x00097822 File Offset: 0x00095A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CaptureBatchEntityResponse.Descriptor;
			}
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x00097829 File Offset: 0x00095A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityResponse()
		{
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x0009783C File Offset: 0x00095A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityResponse(CaptureBatchEntityResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00097872 File Offset: 0x00095A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CaptureBatchEntityResponse Clone()
		{
			return new CaptureBatchEntityResponse(this);
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x0009787A File Offset: 0x00095A7A
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x00097882 File Offset: 0x00095A82
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

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x0009788B File Offset: 0x00095A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x00097893 File Offset: 0x00095A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CaptureBatchEntityResponse);
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x000978A4 File Offset: 0x00095AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CaptureBatchEntityResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x000978F4 File Offset: 0x00095AF4
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

		// Token: 0x06003D2F RID: 15663 RVA: 0x00097947 File Offset: 0x00095B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00097954 File Offset: 0x00095B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00097960 File Offset: 0x00095B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, CaptureBatchEntityResponse._repeated_ids_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x000979B0 File Offset: 0x00095BB0
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

		// Token: 0x06003D33 RID: 15667 RVA: 0x00097A04 File Offset: 0x00095C04
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

		// Token: 0x06003D34 RID: 15668 RVA: 0x00097A51 File Offset: 0x00095C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00097A5C File Offset: 0x00095C5C
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
				if (num != 80U && num != 82U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, CaptureBatchEntityResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04002C96 RID: 11414
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C97 RID: 11415
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x04002C98 RID: 11416
		private ErrorCode errCode_;

		// Token: 0x04002C99 RID: 11417
		public const int IdsFieldNumber = 10;

		// Token: 0x04002C9A RID: 11418
		private static readonly FieldCodec<long> _repeated_ids_codec = FieldCodec.ForInt64(82U);

		// Token: 0x04002C9B RID: 11419
		private readonly RepeatedField<long> ids_ = new RepeatedField<long>();
	}
}
