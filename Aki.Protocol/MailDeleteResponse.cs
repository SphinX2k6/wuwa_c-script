using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000967 RID: 2407
	[NetMessage(EMessageId.MailDeleteResponse)]
	public sealed class MailDeleteResponse : IMessage<MailDeleteResponse>, IMessage, IEquatable<MailDeleteResponse>, IDeepCloneable<MailDeleteResponse>, IBufferMessage
	{
		// Token: 0x0600D426 RID: 54310 RVA: 0x001F3DD4 File Offset: 0x001F1FD4
		[NullableContext(1)]
		public static MailDeleteResponse Create()
		{
			return new MailDeleteResponse();
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x0600D427 RID: 54311 RVA: 0x001F3DDB File Offset: 0x001F1FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x001F3DDE File Offset: 0x001F1FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailDeleteResponse.Descriptor;
			}
		}

		// Token: 0x0600D429 RID: 54313 RVA: 0x001F3DE5 File Offset: 0x001F1FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteResponse()
		{
		}

		// Token: 0x0600D42A RID: 54314 RVA: 0x001F3DF8 File Offset: 0x001F1FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteResponse(MailDeleteResponse other) : this()
		{
			this.successIds_ = other.successIds_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D42B RID: 54315 RVA: 0x001F3E2E File Offset: 0x001F202E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailDeleteResponse Clone()
		{
			return new MailDeleteResponse(this);
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600D42C RID: 54316 RVA: 0x001F3E36 File Offset: 0x001F2036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> SuccessIds
		{
			get
			{
				return this.successIds_;
			}
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x0600D42D RID: 54317 RVA: 0x001F3E3E File Offset: 0x001F203E
		// (set) Token: 0x0600D42E RID: 54318 RVA: 0x001F3E46 File Offset: 0x001F2046
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

		// Token: 0x0600D42F RID: 54319 RVA: 0x001F3E4F File Offset: 0x001F204F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailDeleteResponse);
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x001F3E60 File Offset: 0x001F2060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailDeleteResponse other)
		{
			return other != null && (other == this || (this.successIds_.Equals(other.successIds_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D431 RID: 54321 RVA: 0x001F3EB0 File Offset: 0x001F20B0
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

		// Token: 0x0600D432 RID: 54322 RVA: 0x001F3F03 File Offset: 0x001F2103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x001F3F10 File Offset: 0x001F2110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x001F3F1C File Offset: 0x001F211C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.successIds_.WriteTo(ref output, MailDeleteResponse._repeated_successIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D435 RID: 54325 RVA: 0x001F3F6C File Offset: 0x001F216C
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

		// Token: 0x0600D436 RID: 54326 RVA: 0x001F3FC0 File Offset: 0x001F21C0
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

		// Token: 0x0600D437 RID: 54327 RVA: 0x001F400D File Offset: 0x001F220D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x001F4018 File Offset: 0x001F2218
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
				if (num != 16U)
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

		// Token: 0x04005952 RID: 22866
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005953 RID: 22867
		public const int SuccessIdsFieldNumber = 11;

		// Token: 0x04005954 RID: 22868
		private static readonly FieldCodec<string> _repeated_successIds_codec = FieldCodec.ForString(90U);

		// Token: 0x04005955 RID: 22869
		private readonly RepeatedField<string> successIds_ = new RepeatedField<string>();

		// Token: 0x04005956 RID: 22870
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005957 RID: 22871
		private ErrorCode errorCode_;
	}
}
