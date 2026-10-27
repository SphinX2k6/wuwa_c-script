using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EC RID: 2028
	[NetMessage(EMessageId.InfrPhoneTaskRewardResponse)]
	public sealed class InfrPhoneTaskRewardResponse : IMessage<InfrPhoneTaskRewardResponse>, IMessage, IEquatable<InfrPhoneTaskRewardResponse>, IDeepCloneable<InfrPhoneTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B5E7 RID: 46567 RVA: 0x001B262D File Offset: 0x001B082D
		[NullableContext(1)]
		public static InfrPhoneTaskRewardResponse Create()
		{
			return new InfrPhoneTaskRewardResponse();
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x0600B5E8 RID: 46568 RVA: 0x001B2634 File Offset: 0x001B0834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x0600B5E9 RID: 46569 RVA: 0x001B2637 File Offset: 0x001B0837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrPhoneTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x001B263E File Offset: 0x001B083E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardResponse()
		{
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x001B2646 File Offset: 0x001B0846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardResponse(InfrPhoneTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x001B266B File Offset: 0x001B086B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrPhoneTaskRewardResponse Clone()
		{
			return new InfrPhoneTaskRewardResponse(this);
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x0600B5ED RID: 46573 RVA: 0x001B2673 File Offset: 0x001B0873
		// (set) Token: 0x0600B5EE RID: 46574 RVA: 0x001B267B File Offset: 0x001B087B
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

		// Token: 0x0600B5EF RID: 46575 RVA: 0x001B2684 File Offset: 0x001B0884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrPhoneTaskRewardResponse);
		}

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x001B2692 File Offset: 0x001B0892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrPhoneTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B5F1 RID: 46577 RVA: 0x001B26C0 File Offset: 0x001B08C0
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

		// Token: 0x0600B5F2 RID: 46578 RVA: 0x001B2705 File Offset: 0x001B0905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5F3 RID: 46579 RVA: 0x001B2712 File Offset: 0x001B0912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5F4 RID: 46580 RVA: 0x001B271B File Offset: 0x001B091B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x001B2750 File Offset: 0x001B0950
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

		// Token: 0x0600B5F6 RID: 46582 RVA: 0x001B278E File Offset: 0x001B098E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrPhoneTaskRewardResponse other)
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

		// Token: 0x0600B5F7 RID: 46583 RVA: 0x001B27BF File Offset: 0x001B09BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5F8 RID: 46584 RVA: 0x001B27C8 File Offset: 0x001B09C8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040050A9 RID: 20649
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050AA RID: 20650
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040050AB RID: 20651
		private ErrorCode errorCode_;
	}
}
