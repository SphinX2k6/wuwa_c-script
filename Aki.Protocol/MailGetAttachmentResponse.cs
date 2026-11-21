using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096B RID: 2411
	[NetMessage(EMessageId.MailGetAttachmentResponse)]
	public sealed class MailGetAttachmentResponse : IMessage<MailGetAttachmentResponse>, IMessage, IEquatable<MailGetAttachmentResponse>, IDeepCloneable<MailGetAttachmentResponse>, IBufferMessage
	{
		// Token: 0x0600D478 RID: 54392 RVA: 0x001F4944 File Offset: 0x001F2B44
		[NullableContext(1)]
		public static MailGetAttachmentResponse Create()
		{
			return new MailGetAttachmentResponse();
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x0600D479 RID: 54393 RVA: 0x001F494B File Offset: 0x001F2B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x0600D47A RID: 54394 RVA: 0x001F494E File Offset: 0x001F2B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailGetAttachmentResponse.Descriptor;
			}
		}

		// Token: 0x0600D47B RID: 54395 RVA: 0x001F4955 File Offset: 0x001F2B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentResponse()
		{
		}

		// Token: 0x0600D47C RID: 54396 RVA: 0x001F4968 File Offset: 0x001F2B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentResponse(MailGetAttachmentResponse other) : this()
		{
			this.successIdMap_ = other.successIdMap_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x001F499E File Offset: 0x001F2B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentResponse Clone()
		{
			return new MailGetAttachmentResponse(this);
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0600D47E RID: 54398 RVA: 0x001F49A6 File Offset: 0x001F2BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> SuccessIdMap
		{
			get
			{
				return this.successIdMap_;
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x0600D47F RID: 54399 RVA: 0x001F49AE File Offset: 0x001F2BAE
		// (set) Token: 0x0600D480 RID: 54400 RVA: 0x001F49B6 File Offset: 0x001F2BB6
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

		// Token: 0x0600D481 RID: 54401 RVA: 0x001F49BF File Offset: 0x001F2BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailGetAttachmentResponse);
		}

		// Token: 0x0600D482 RID: 54402 RVA: 0x001F49D0 File Offset: 0x001F2BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailGetAttachmentResponse other)
		{
			return other != null && (other == this || (this.SuccessIdMap.Equals(other.SuccessIdMap) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D483 RID: 54403 RVA: 0x001F4A20 File Offset: 0x001F2C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.SuccessIdMap.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D484 RID: 54404 RVA: 0x001F4A73 File Offset: 0x001F2C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D485 RID: 54405 RVA: 0x001F4A80 File Offset: 0x001F2C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D486 RID: 54406 RVA: 0x001F4A8C File Offset: 0x001F2C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.successIdMap_.WriteTo(ref output, MailGetAttachmentResponse._map_successIdMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D487 RID: 54407 RVA: 0x001F4ADC File Offset: 0x001F2CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.successIdMap_.CalculateSize(MailGetAttachmentResponse._map_successIdMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D488 RID: 54408 RVA: 0x001F4B30 File Offset: 0x001F2D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailGetAttachmentResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.successIdMap_.MergeFrom(other.successIdMap_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D489 RID: 54409 RVA: 0x001F4B7D File Offset: 0x001F2D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D48A RID: 54410 RVA: 0x001F4B88 File Offset: 0x001F2D88
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
				if (num != 24U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.successIdMap_.AddEntriesFrom(ref input, MailGetAttachmentResponse._map_successIdMap_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400596A RID: 22890
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400596B RID: 22891
		public const int SuccessIdMapFieldNumber = 5;

		// Token: 0x0400596C RID: 22892
		private static readonly MapField<string, int>.Codec _map_successIdMap_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x0400596D RID: 22893
		private readonly MapField<string, int> successIdMap_ = new MapField<string, int>();

		// Token: 0x0400596E RID: 22894
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400596F RID: 22895
		private ErrorCode errorCode_;
	}
}
