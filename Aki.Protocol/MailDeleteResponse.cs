using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000978 RID: 2424
	[NetMessage(EMessageId.MailDeleteResponse)]
	public sealed class MailDeleteResponse : IMessage<MailDeleteResponse>, IMessage, IEquatable<MailDeleteResponse>, IDeepCloneable<MailDeleteResponse>, IBufferMessage
	{
		// Token: 0x0600D540 RID: 54592 RVA: 0x001F5FBC File Offset: 0x001F41BC
		[NullableContext(1)]
		public static MailDeleteResponse Create()
		{
			return new MailDeleteResponse();
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x0600D541 RID: 54593 RVA: 0x001F5FC3 File Offset: 0x001F41C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x0600D542 RID: 54594 RVA: 0x001F5FC6 File Offset: 0x001F41C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailDeleteResponse.Descriptor;
			}
		}

		// Token: 0x0600D543 RID: 54595 RVA: 0x001F5FCD File Offset: 0x001F41CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteResponse()
		{
		}

		// Token: 0x0600D544 RID: 54596 RVA: 0x001F5FE0 File Offset: 0x001F41E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteResponse(MailDeleteResponse other) : this()
		{
			this.successIds_ = other.successIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D545 RID: 54597 RVA: 0x001F6016 File Offset: 0x001F4216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteResponse Clone()
		{
			return new MailDeleteResponse(this);
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x0600D546 RID: 54598 RVA: 0x001F601E File Offset: 0x001F421E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> SuccessIds
		{
			get
			{
				return this.successIds_;
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x0600D547 RID: 54599 RVA: 0x001F6026 File Offset: 0x001F4226
		// (set) Token: 0x0600D548 RID: 54600 RVA: 0x001F602E File Offset: 0x001F422E
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

		// Token: 0x0600D549 RID: 54601 RVA: 0x001F6037 File Offset: 0x001F4237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailDeleteResponse);
		}

		// Token: 0x0600D54A RID: 54602 RVA: 0x001F6048 File Offset: 0x001F4248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailDeleteResponse other)
		{
			return other != null && (other == this || (this.successIds_.Equals(other.successIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D54B RID: 54603 RVA: 0x001F6098 File Offset: 0x001F4298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.successIds_.GetHashCode();
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

		// Token: 0x0600D54C RID: 54604 RVA: 0x001F60EB File Offset: 0x001F42EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D54D RID: 54605 RVA: 0x001F60F8 File Offset: 0x001F42F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D54E RID: 54606 RVA: 0x001F6104 File Offset: 0x001F4304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.successIds_.WriteTo(ref output, MailDeleteResponse._repeated_successIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D54F RID: 54607 RVA: 0x001F6154 File Offset: 0x001F4354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.successIds_.CalculateSize(MailDeleteResponse._repeated_successIds_codec);
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

		// Token: 0x0600D550 RID: 54608 RVA: 0x001F61A8 File Offset: 0x001F43A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailDeleteResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.successIds_.Add(other.successIds_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D551 RID: 54609 RVA: 0x001F61F5 File Offset: 0x001F43F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D552 RID: 54610 RVA: 0x001F6200 File Offset: 0x001F4400
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
				if (num != 56U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.successIds_.AddEntriesFrom(ref input, MailDeleteResponse._repeated_successIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005949 RID: 22857
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400594A RID: 22858
		public const int SuccessIdsFieldNumber = 11;

		// Token: 0x0400594B RID: 22859
		private static readonly FieldCodec<string> _repeated_successIds_codec = FieldCodec.ForString(90U);

		// Token: 0x0400594C RID: 22860
		private readonly RepeatedField<string> successIds_ = new RepeatedField<string>();

		// Token: 0x0400594D RID: 22861
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400594E RID: 22862
		private ErrorCode errorCode_;
	}
}
