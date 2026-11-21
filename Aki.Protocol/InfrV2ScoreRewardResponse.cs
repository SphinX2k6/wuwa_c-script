using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F1 RID: 2033
	[NetMessage(EMessageId.InfrV2ScoreRewardResponse)]
	public sealed class InfrV2ScoreRewardResponse : IMessage<InfrV2ScoreRewardResponse>, IMessage, IEquatable<InfrV2ScoreRewardResponse>, IDeepCloneable<InfrV2ScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B672 RID: 46706 RVA: 0x001B37F9 File Offset: 0x001B19F9
		[NullableContext(1)]
		public static InfrV2ScoreRewardResponse Create()
		{
			return new InfrV2ScoreRewardResponse();
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x0600B673 RID: 46707 RVA: 0x001B3800 File Offset: 0x001B1A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0600B674 RID: 46708 RVA: 0x001B3803 File Offset: 0x001B1A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x001B380A File Offset: 0x001B1A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardResponse()
		{
		}

		// Token: 0x0600B676 RID: 46710 RVA: 0x001B3812 File Offset: 0x001B1A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardResponse(InfrV2ScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x001B3837 File Offset: 0x001B1A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardResponse Clone()
		{
			return new InfrV2ScoreRewardResponse(this);
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0600B678 RID: 46712 RVA: 0x001B383F File Offset: 0x001B1A3F
		// (set) Token: 0x0600B679 RID: 46713 RVA: 0x001B3847 File Offset: 0x001B1A47
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

		// Token: 0x0600B67A RID: 46714 RVA: 0x001B3850 File Offset: 0x001B1A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ScoreRewardResponse);
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x001B385E File Offset: 0x001B1A5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x001B388C File Offset: 0x001B1A8C
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

		// Token: 0x0600B67D RID: 46717 RVA: 0x001B38D1 File Offset: 0x001B1AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B67E RID: 46718 RVA: 0x001B38DE File Offset: 0x001B1ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B67F RID: 46719 RVA: 0x001B38E7 File Offset: 0x001B1AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x001B391C File Offset: 0x001B1B1C
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

		// Token: 0x0600B681 RID: 46721 RVA: 0x001B395A File Offset: 0x001B1B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ScoreRewardResponse other)
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

		// Token: 0x0600B682 RID: 46722 RVA: 0x001B398B File Offset: 0x001B1B8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B683 RID: 46723 RVA: 0x001B3994 File Offset: 0x001B1B94
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005114 RID: 20756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005115 RID: 20757
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x04005116 RID: 20758
		private ErrorCode errCode_;
	}
}
