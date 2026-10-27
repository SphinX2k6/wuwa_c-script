using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200097C RID: 2428
	[NetMessage(EMessageId.MailGetAttachmentResponse)]
	public sealed class MailGetAttachmentResponse : IMessage<MailGetAttachmentResponse>, IMessage, IEquatable<MailGetAttachmentResponse>, IDeepCloneable<MailGetAttachmentResponse>, IBufferMessage
	{
		// Token: 0x0600D592 RID: 54674 RVA: 0x001F6B2C File Offset: 0x001F4D2C
		[NullableContext(1)]
		public static MailGetAttachmentResponse Create()
		{
			return new MailGetAttachmentResponse();
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600D593 RID: 54675 RVA: 0x001F6B33 File Offset: 0x001F4D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x0600D594 RID: 54676 RVA: 0x001F6B36 File Offset: 0x001F4D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailGetAttachmentResponse.Descriptor;
			}
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x001F6B3D File Offset: 0x001F4D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentResponse()
		{
		}

		// Token: 0x0600D596 RID: 54678 RVA: 0x001F6B50 File Offset: 0x001F4D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentResponse(MailGetAttachmentResponse other) : this()
		{
			this.successIdMap_ = other.successIdMap_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x001F6B86 File Offset: 0x001F4D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailGetAttachmentResponse Clone()
		{
			return new MailGetAttachmentResponse(this);
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600D598 RID: 54680 RVA: 0x001F6B8E File Offset: 0x001F4D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, int> SuccessIdMap
		{
			get
			{
				return this.successIdMap_;
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x0600D599 RID: 54681 RVA: 0x001F6B96 File Offset: 0x001F4D96
		// (set) Token: 0x0600D59A RID: 54682 RVA: 0x001F6B9E File Offset: 0x001F4D9E
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

		// Token: 0x0600D59B RID: 54683 RVA: 0x001F6BA7 File Offset: 0x001F4DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailGetAttachmentResponse);
		}

		// Token: 0x0600D59C RID: 54684 RVA: 0x001F6BB8 File Offset: 0x001F4DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailGetAttachmentResponse other)
		{
			return other != null && (other == this || (this.SuccessIdMap.Equals(other.SuccessIdMap) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D59D RID: 54685 RVA: 0x001F6C08 File Offset: 0x001F4E08
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

		// Token: 0x0600D59E RID: 54686 RVA: 0x001F6C5B File Offset: 0x001F4E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D59F RID: 54687 RVA: 0x001F6C68 File Offset: 0x001F4E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x001F6C74 File Offset: 0x001F4E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.successIdMap_.WriteTo(ref output, MailGetAttachmentResponse._map_successIdMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x001F6CC4 File Offset: 0x001F4EC4
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

		// Token: 0x0600D5A2 RID: 54690 RVA: 0x001F6D18 File Offset: 0x001F4F18
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

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x001F6D65 File Offset: 0x001F4F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x001F6D70 File Offset: 0x001F4F70
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
				if (num != 34U)
				{
					if (num != 112U)
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
					this.successIdMap_.AddEntriesFrom(ref input, MailGetAttachmentResponse._map_successIdMap_codec);
				}
			}
		}

		// Token: 0x04005961 RID: 22881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005962 RID: 22882
		public const int SuccessIdMapFieldNumber = 4;

		// Token: 0x04005963 RID: 22883
		private static readonly MapField<string, int>.Codec _map_successIdMap_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04005964 RID: 22884
		private readonly MapField<string, int> successIdMap_ = new MapField<string, int>();

		// Token: 0x04005965 RID: 22885
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005966 RID: 22886
		private ErrorCode errorCode_;
	}
}
