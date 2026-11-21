using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D2 RID: 978
	[NetMessage(EMessageId.DollDeliveryResponse)]
	public sealed class DollDeliveryResponse : IMessage<DollDeliveryResponse>, IMessage, IEquatable<DollDeliveryResponse>, IDeepCloneable<DollDeliveryResponse>, IBufferMessage
	{
		// Token: 0x06005F97 RID: 24471 RVA: 0x000E7829 File Offset: 0x000E5A29
		[NullableContext(1)]
		public static DollDeliveryResponse Create()
		{
			return new DollDeliveryResponse();
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06005F98 RID: 24472 RVA: 0x000E7830 File Offset: 0x000E5A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x000E7833 File Offset: 0x000E5A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryResponse.Descriptor;
			}
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x000E783A File Offset: 0x000E5A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryResponse()
		{
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x000E784D File Offset: 0x000E5A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryResponse(DollDeliveryResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.itemIds_ = other.itemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x000E7883 File Offset: 0x000E5A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryResponse Clone()
		{
			return new DollDeliveryResponse(this);
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06005F9D RID: 24477 RVA: 0x000E788B File Offset: 0x000E5A8B
		// (set) Token: 0x06005F9E RID: 24478 RVA: 0x000E7893 File Offset: 0x000E5A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06005F9F RID: 24479 RVA: 0x000E789C File Offset: 0x000E5A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x000E78A4 File Offset: 0x000E5AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryResponse);
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x000E78B4 File Offset: 0x000E5AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.itemIds_.Equals(other.itemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x000E7904 File Offset: 0x000E5B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.itemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x000E7957 File Offset: 0x000E5B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x000E7964 File Offset: 0x000E5B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x000E7970 File Offset: 0x000E5B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemIds_.WriteTo(ref output, DollDeliveryResponse._repeated_itemIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x000E79C0 File Offset: 0x000E5BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.itemIds_.CalculateSize(DollDeliveryResponse._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x000E7A14 File Offset: 0x000E5C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollDeliveryResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.itemIds_.Add(other.itemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x000E7A61 File Offset: 0x000E5C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x000E7A6C File Offset: 0x000E5C6C
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
				if (num != 16U && num != 18U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemIds_.AddEntriesFrom(ref input, DollDeliveryResponse._repeated_itemIds_codec);
				}
			}
		}

		// Token: 0x0400377B RID: 14203
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400377C RID: 14204
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400377D RID: 14205
		private ErrorCode errorCode_;

		// Token: 0x0400377E RID: 14206
		public const int ItemIdsFieldNumber = 2;

		// Token: 0x0400377F RID: 14207
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003780 RID: 14208
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();
	}
}
