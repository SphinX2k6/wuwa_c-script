using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD8 RID: 4056
	[NetMessage(EMessageId.RogueResEndingRewardResponse)]
	public sealed class RogueResEndingRewardResponse : IMessage<RogueResEndingRewardResponse>, IMessage, IEquatable<RogueResEndingRewardResponse>, IDeepCloneable<RogueResEndingRewardResponse>, IBufferMessage
	{
		// Token: 0x06015AD8 RID: 88792 RVA: 0x003255A4 File Offset: 0x003237A4
		[NullableContext(1)]
		public static RogueResEndingRewardResponse Create()
		{
			return new RogueResEndingRewardResponse();
		}

		// Token: 0x1700484A RID: 18506
		// (get) Token: 0x06015AD9 RID: 88793 RVA: 0x003255AB File Offset: 0x003237AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x06015ADA RID: 88794 RVA: 0x003255AE File Offset: 0x003237AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResEndingRewardResponse.Descriptor;
			}
		}

		// Token: 0x06015ADB RID: 88795 RVA: 0x003255B5 File Offset: 0x003237B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardResponse()
		{
		}

		// Token: 0x06015ADC RID: 88796 RVA: 0x003255BD File Offset: 0x003237BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardResponse(RogueResEndingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015ADD RID: 88797 RVA: 0x003255E2 File Offset: 0x003237E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResEndingRewardResponse Clone()
		{
			return new RogueResEndingRewardResponse(this);
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x06015ADE RID: 88798 RVA: 0x003255EA File Offset: 0x003237EA
		// (set) Token: 0x06015ADF RID: 88799 RVA: 0x003255F2 File Offset: 0x003237F2
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

		// Token: 0x06015AE0 RID: 88800 RVA: 0x003255FB File Offset: 0x003237FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResEndingRewardResponse);
		}

		// Token: 0x06015AE1 RID: 88801 RVA: 0x00325609 File Offset: 0x00323809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResEndingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015AE2 RID: 88802 RVA: 0x00325638 File Offset: 0x00323838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06015AE3 RID: 88803 RVA: 0x0032567D File Offset: 0x0032387D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AE4 RID: 88804 RVA: 0x0032568A File Offset: 0x0032388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AE5 RID: 88805 RVA: 0x00325693 File Offset: 0x00323893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AE6 RID: 88806 RVA: 0x003256C8 File Offset: 0x003238C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06015AE7 RID: 88807 RVA: 0x00325706 File Offset: 0x00323906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResEndingRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015AE8 RID: 88808 RVA: 0x00325737 File Offset: 0x00323937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015AE9 RID: 88809 RVA: 0x00325740 File Offset: 0x00323940
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400821A RID: 33306
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400821B RID: 33307
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400821C RID: 33308
		private ErrorCode errorCode_;
	}
}
