using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004DE RID: 1246
	[NetMessage(EMessageId.ExploreActivityTaskRewardResponse)]
	public sealed class ExploreActivityTaskRewardResponse : IMessage<ExploreActivityTaskRewardResponse>, IMessage, IEquatable<ExploreActivityTaskRewardResponse>, IDeepCloneable<ExploreActivityTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600764E RID: 30286 RVA: 0x00121281 File Offset: 0x0011F481
		[NullableContext(1)]
		public static ExploreActivityTaskRewardResponse Create()
		{
			return new ExploreActivityTaskRewardResponse();
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x00121288 File Offset: 0x0011F488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x06007650 RID: 30288 RVA: 0x0012128B File Offset: 0x0011F48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreActivityTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00121292 File Offset: 0x0011F492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardResponse()
		{
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x0012129A File Offset: 0x0011F49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardResponse(ExploreActivityTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x001212BF File Offset: 0x0011F4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreActivityTaskRewardResponse Clone()
		{
			return new ExploreActivityTaskRewardResponse(this);
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x06007654 RID: 30292 RVA: 0x001212C7 File Offset: 0x0011F4C7
		// (set) Token: 0x06007655 RID: 30293 RVA: 0x001212CF File Offset: 0x0011F4CF
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

		// Token: 0x06007656 RID: 30294 RVA: 0x001212D8 File Offset: 0x0011F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreActivityTaskRewardResponse);
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x001212E6 File Offset: 0x0011F4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreActivityTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x00121314 File Offset: 0x0011F514
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

		// Token: 0x06007659 RID: 30297 RVA: 0x00121359 File Offset: 0x0011F559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x00121366 File Offset: 0x0011F566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x0012136F File Offset: 0x0011F56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x001213A4 File Offset: 0x0011F5A4
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

		// Token: 0x0600765D RID: 30301 RVA: 0x001213E2 File Offset: 0x0011F5E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreActivityTaskRewardResponse other)
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

		// Token: 0x0600765E RID: 30302 RVA: 0x00121413 File Offset: 0x0011F613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x0012141C File Offset: 0x0011F61C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E33 RID: 15923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E34 RID: 15924
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04003E35 RID: 15925
		private ErrorCode errorCode_;
	}
}
