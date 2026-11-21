using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F4 RID: 2036
	[NetMessage(EMessageId.InfrV2TaskRewardResponse)]
	public sealed class InfrV2TaskRewardResponse : IMessage<InfrV2TaskRewardResponse>, IMessage, IEquatable<InfrV2TaskRewardResponse>, IDeepCloneable<InfrV2TaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B6A8 RID: 46760 RVA: 0x001B3DE1 File Offset: 0x001B1FE1
		[NullableContext(1)]
		public static InfrV2TaskRewardResponse Create()
		{
			return new InfrV2TaskRewardResponse();
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x0600B6A9 RID: 46761 RVA: 0x001B3DE8 File Offset: 0x001B1FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x0600B6AA RID: 46762 RVA: 0x001B3DEB File Offset: 0x001B1FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x001B3DF2 File Offset: 0x001B1FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardResponse()
		{
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x001B3DFA File Offset: 0x001B1FFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardResponse(InfrV2TaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x001B3E1F File Offset: 0x001B201F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardResponse Clone()
		{
			return new InfrV2TaskRewardResponse(this);
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x0600B6AE RID: 46766 RVA: 0x001B3E27 File Offset: 0x001B2027
		// (set) Token: 0x0600B6AF RID: 46767 RVA: 0x001B3E2F File Offset: 0x001B202F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x001B3E38 File Offset: 0x001B2038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TaskRewardResponse);
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x001B3E46 File Offset: 0x001B2046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x001B3E74 File Offset: 0x001B2074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x001B3EB9 File Offset: 0x001B20B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x001B3EC6 File Offset: 0x001B20C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x001B3ECF File Offset: 0x001B20CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x001B3F04 File Offset: 0x001B2104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x001B3F42 File Offset: 0x001B2142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x001B3F73 File Offset: 0x001B2173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x001B3F7C File Offset: 0x001B217C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400511E RID: 20766
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400511F RID: 20767
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04005120 RID: 20768
		private ErrorCode errCode_;
	}
}
