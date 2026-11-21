using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BA RID: 1978
	[NetMessage(EMessageId.IllustratedUnlockResponse)]
	public sealed class IllustratedUnlockResponse : IMessage<IllustratedUnlockResponse>, IMessage, IEquatable<IllustratedUnlockResponse>, IDeepCloneable<IllustratedUnlockResponse>, IBufferMessage
	{
		// Token: 0x0600B250 RID: 45648 RVA: 0x001AB453 File Offset: 0x001A9653
		[NullableContext(1)]
		public static IllustratedUnlockResponse Create()
		{
			return new IllustratedUnlockResponse();
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x0600B251 RID: 45649 RVA: 0x001AB45A File Offset: 0x001A965A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600B252 RID: 45650 RVA: 0x001AB45D File Offset: 0x001A965D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x001AB464 File Offset: 0x001A9664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockResponse()
		{
		}

		// Token: 0x0600B254 RID: 45652 RVA: 0x001AB478 File Offset: 0x001A9678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockResponse(IllustratedUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.entry_ = ((other.entry_ != null) ? other.entry_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x001AB4D5 File Offset: 0x001A96D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockResponse Clone()
		{
			return new IllustratedUnlockResponse(this);
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x0600B256 RID: 45654 RVA: 0x001AB4DD File Offset: 0x001A96DD
		// (set) Token: 0x0600B257 RID: 45655 RVA: 0x001AB4E5 File Offset: 0x001A96E5
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

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600B258 RID: 45656 RVA: 0x001AB4EE File Offset: 0x001A96EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600B259 RID: 45657 RVA: 0x001AB4F6 File Offset: 0x001A96F6
		// (set) Token: 0x0600B25A RID: 45658 RVA: 0x001AB4FE File Offset: 0x001A96FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry Entry
		{
			get
			{
				return this.entry_;
			}
			set
			{
				this.entry_ = value;
			}
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x001AB507 File Offset: 0x001A9707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedUnlockResponse);
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x001AB518 File Offset: 0x001A9718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.Entry, other.Entry) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x001AB57C File Offset: 0x001A977C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this.entry_ != null)
			{
				num ^= this.Entry.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B25E RID: 45662 RVA: 0x001AB5E5 File Offset: 0x001A97E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B25F RID: 45663 RVA: 0x001AB5F2 File Offset: 0x001A97F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B260 RID: 45664 RVA: 0x001AB5FC File Offset: 0x001A97FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entry_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Entry);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, IllustratedUnlockResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x001AB668 File Offset: 0x001A9868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(IllustratedUnlockResponse._repeated_errorParams_codec);
			if (this.entry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entry);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x001AB6D4 File Offset: 0x001A98D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			if (other.entry_ != null)
			{
				if (this.entry_ == null)
				{
					this.Entry = new IllustratedEntry();
				}
				this.Entry.MergeFrom(other.Entry);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x001AB74D File Offset: 0x001A994D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B264 RID: 45668 RVA: 0x001AB758 File Offset: 0x001A9958
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.errorParams_.AddEntriesFrom(ref input, IllustratedUnlockResponse._repeated_errorParams_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.entry_ == null)
					{
						this.Entry = new IllustratedEntry();
					}
					input.ReadMessage(this.Entry);
				}
			}
		}

		// Token: 0x04005015 RID: 20501
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005016 RID: 20502
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005017 RID: 20503
		private ErrorCode errorCode_;

		// Token: 0x04005018 RID: 20504
		public const int ErrorParamsFieldNumber = 3;

		// Token: 0x04005019 RID: 20505
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(26U);

		// Token: 0x0400501A RID: 20506
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x0400501B RID: 20507
		public const int EntryFieldNumber = 1;

		// Token: 0x0400501C RID: 20508
		private IllustratedEntry entry_;
	}
}
