using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E5 RID: 485
	[NetMessage(EMessageId.BrochureRewardResponse)]
	public sealed class BrochureRewardResponse : IMessage<BrochureRewardResponse>, IMessage, IEquatable<BrochureRewardResponse>, IDeepCloneable<BrochureRewardResponse>, IBufferMessage
	{
		// Token: 0x06003681 RID: 13953 RVA: 0x00088C02 File Offset: 0x00086E02
		[NullableContext(1)]
		public static BrochureRewardResponse Create()
		{
			return new BrochureRewardResponse();
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x00088C09 File Offset: 0x00086E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x00088C0C File Offset: 0x00086E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BrochureRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00088C13 File Offset: 0x00086E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardResponse()
		{
		}

		// Token: 0x06003685 RID: 13957 RVA: 0x00088C1B File Offset: 0x00086E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardResponse(BrochureRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x00088C40 File Offset: 0x00086E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BrochureRewardResponse Clone()
		{
			return new BrochureRewardResponse(this);
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x00088C48 File Offset: 0x00086E48
		// (set) Token: 0x06003688 RID: 13960 RVA: 0x00088C50 File Offset: 0x00086E50
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

		// Token: 0x06003689 RID: 13961 RVA: 0x00088C59 File Offset: 0x00086E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BrochureRewardResponse);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00088C67 File Offset: 0x00086E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BrochureRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00088C98 File Offset: 0x00086E98
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

		// Token: 0x0600368C RID: 13964 RVA: 0x00088CDD File Offset: 0x00086EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00088CEA File Offset: 0x00086EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00088CF3 File Offset: 0x00086EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00088D28 File Offset: 0x00086F28
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

		// Token: 0x06003690 RID: 13968 RVA: 0x00088D66 File Offset: 0x00086F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BrochureRewardResponse other)
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

		// Token: 0x06003691 RID: 13969 RVA: 0x00088D97 File Offset: 0x00086F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00088DA0 File Offset: 0x00086FA0
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AA7 RID: 10919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AA8 RID: 10920
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04002AA9 RID: 10921
		private ErrorCode errCode_;
	}
}
