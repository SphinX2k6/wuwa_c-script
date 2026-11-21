using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054A RID: 1354
	[NetMessage(EMessageId.FishingHandInResponse)]
	public sealed class FishingHandInResponse : IMessage<FishingHandInResponse>, IMessage, IEquatable<FishingHandInResponse>, IDeepCloneable<FishingHandInResponse>, IBufferMessage
	{
		// Token: 0x06007ED0 RID: 32464 RVA: 0x00132FA4 File Offset: 0x001311A4
		[NullableContext(1)]
		public static FishingHandInResponse Create()
		{
			return new FishingHandInResponse();
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06007ED1 RID: 32465 RVA: 0x00132FAB File Offset: 0x001311AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06007ED2 RID: 32466 RVA: 0x00132FAE File Offset: 0x001311AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingHandInResponse.Descriptor;
			}
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x00132FB5 File Offset: 0x001311B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInResponse()
		{
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x00132FBD File Offset: 0x001311BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInResponse(FishingHandInResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.handInComplete_ = other.handInComplete_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x00132FEE File Offset: 0x001311EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingHandInResponse Clone()
		{
			return new FishingHandInResponse(this);
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06007ED6 RID: 32470 RVA: 0x00132FF6 File Offset: 0x001311F6
		// (set) Token: 0x06007ED7 RID: 32471 RVA: 0x00132FFE File Offset: 0x001311FE
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

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06007ED8 RID: 32472 RVA: 0x00133007 File Offset: 0x00131207
		// (set) Token: 0x06007ED9 RID: 32473 RVA: 0x0013300F File Offset: 0x0013120F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HandInComplete
		{
			get
			{
				return this.handInComplete_;
			}
			set
			{
				this.handInComplete_ = value;
			}
		}

		// Token: 0x06007EDA RID: 32474 RVA: 0x00133018 File Offset: 0x00131218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingHandInResponse);
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x00133026 File Offset: 0x00131226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingHandInResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.HandInComplete == other.HandInComplete && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x00133064 File Offset: 0x00131264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.HandInComplete)
			{
				num ^= this.HandInComplete.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x001330C2 File Offset: 0x001312C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x001330CF File Offset: 0x001312CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x001330D8 File Offset: 0x001312D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandInComplete)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.HandInComplete);
			}
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

		// Token: 0x06007EE0 RID: 32480 RVA: 0x00133134 File Offset: 0x00131334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.HandInComplete)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x00133180 File Offset: 0x00131380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingHandInResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.HandInComplete)
			{
				this.HandInComplete = other.HandInComplete;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007EE2 RID: 32482 RVA: 0x001331D0 File Offset: 0x001313D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x001331DC File Offset: 0x001313DC
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
				if (num != 104U)
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
					this.HandInComplete = input.ReadBool();
				}
			}
		}

		// Token: 0x04004087 RID: 16519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004088 RID: 16520
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004089 RID: 16521
		private ErrorCode errorCode_;

		// Token: 0x0400408A RID: 16522
		public const int HandInCompleteFieldNumber = 13;

		// Token: 0x0400408B RID: 16523
		private bool handInComplete_;
	}
}
