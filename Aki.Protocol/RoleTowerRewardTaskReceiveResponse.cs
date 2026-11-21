using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E0 RID: 4320
	[NetMessage(EMessageId.RoleTowerRewardTaskReceiveResponse)]
	public sealed class RoleTowerRewardTaskReceiveResponse : IMessage<RoleTowerRewardTaskReceiveResponse>, IMessage, IEquatable<RoleTowerRewardTaskReceiveResponse>, IDeepCloneable<RoleTowerRewardTaskReceiveResponse>, IBufferMessage
	{
		// Token: 0x0601718A RID: 94602 RVA: 0x0035C545 File Offset: 0x0035A745
		[NullableContext(1)]
		public static RoleTowerRewardTaskReceiveResponse Create()
		{
			return new RoleTowerRewardTaskReceiveResponse();
		}

		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x0601718B RID: 94603 RVA: 0x0035C54C File Offset: 0x0035A74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x0601718C RID: 94604 RVA: 0x0035C54F File Offset: 0x0035A74F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRewardTaskReceiveResponse.Descriptor;
			}
		}

		// Token: 0x0601718D RID: 94605 RVA: 0x0035C556 File Offset: 0x0035A756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskReceiveResponse()
		{
		}

		// Token: 0x0601718E RID: 94606 RVA: 0x0035C55E File Offset: 0x0035A75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskReceiveResponse(RoleTowerRewardTaskReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601718F RID: 94607 RVA: 0x0035C583 File Offset: 0x0035A783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRewardTaskReceiveResponse Clone()
		{
			return new RoleTowerRewardTaskReceiveResponse(this);
		}

		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x06017190 RID: 94608 RVA: 0x0035C58B File Offset: 0x0035A78B
		// (set) Token: 0x06017191 RID: 94609 RVA: 0x0035C593 File Offset: 0x0035A793
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

		// Token: 0x06017192 RID: 94610 RVA: 0x0035C59C File Offset: 0x0035A79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRewardTaskReceiveResponse);
		}

		// Token: 0x06017193 RID: 94611 RVA: 0x0035C5AA File Offset: 0x0035A7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRewardTaskReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017194 RID: 94612 RVA: 0x0035C5D8 File Offset: 0x0035A7D8
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

		// Token: 0x06017195 RID: 94613 RVA: 0x0035C61D File Offset: 0x0035A81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017196 RID: 94614 RVA: 0x0035C62A File Offset: 0x0035A82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017197 RID: 94615 RVA: 0x0035C633 File Offset: 0x0035A833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06017198 RID: 94616 RVA: 0x0035C668 File Offset: 0x0035A868
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

		// Token: 0x06017199 RID: 94617 RVA: 0x0035C6A6 File Offset: 0x0035A8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRewardTaskReceiveResponse other)
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

		// Token: 0x0601719A RID: 94618 RVA: 0x0035C6D7 File Offset: 0x0035A8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601719B RID: 94619 RVA: 0x0035C6E0 File Offset: 0x0035A8E0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008A43 RID: 35395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A44 RID: 35396
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04008A45 RID: 35397
		private ErrorCode errorCode_;
	}
}
