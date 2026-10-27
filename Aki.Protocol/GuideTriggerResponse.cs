using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000729 RID: 1833
	[NetMessage(EMessageId.GuideTriggerResponse)]
	public sealed class GuideTriggerResponse : IMessage<GuideTriggerResponse>, IMessage, IEquatable<GuideTriggerResponse>, IDeepCloneable<GuideTriggerResponse>, IBufferMessage
	{
		// Token: 0x0600A66E RID: 42606 RVA: 0x00191221 File Offset: 0x0018F421
		[NullableContext(1)]
		public static GuideTriggerResponse Create()
		{
			return new GuideTriggerResponse();
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x00191228 File Offset: 0x0018F428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x0600A670 RID: 42608 RVA: 0x0019122B File Offset: 0x0018F42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GuideTriggerResponse.Descriptor;
			}
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x00191232 File Offset: 0x0018F432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerResponse()
		{
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x00191245 File Offset: 0x0018F445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerResponse(GuideTriggerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A673 RID: 42611 RVA: 0x0019127B File Offset: 0x0018F47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GuideTriggerResponse Clone()
		{
			return new GuideTriggerResponse(this);
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x00191283 File Offset: 0x0018F483
		// (set) Token: 0x0600A675 RID: 42613 RVA: 0x0019128B File Offset: 0x0018F48B
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

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x00191294 File Offset: 0x0018F494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x0019129C File Offset: 0x0018F49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GuideTriggerResponse);
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x001912AC File Offset: 0x0018F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GuideTriggerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x001912FC File Offset: 0x0018F4FC
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x0019134F File Offset: 0x0018F54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A67B RID: 42619 RVA: 0x0019135C File Offset: 0x0018F55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A67C RID: 42620 RVA: 0x00191368 File Offset: 0x0018F568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, GuideTriggerResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x001913B8 File Offset: 0x0018F5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(GuideTriggerResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x0019140C File Offset: 0x0018F60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GuideTriggerResponse other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A67F RID: 42623 RVA: 0x00191459 File Offset: 0x0018F659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x00191464 File Offset: 0x0018F664
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
				if (num != 64U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, GuideTriggerResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004C55 RID: 19541
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C56 RID: 19542
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004C57 RID: 19543
		private ErrorCode errorCode_;

		// Token: 0x04004C58 RID: 19544
		public const int ErrorParamsFieldNumber = 9;

		// Token: 0x04004C59 RID: 19545
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(74U);

		// Token: 0x04004C5A RID: 19546
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
