using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000919 RID: 2329
	[NetMessage(EMessageId.LinkageRewardResponse)]
	public sealed class LinkageRewardResponse : IMessage<LinkageRewardResponse>, IMessage, IEquatable<LinkageRewardResponse>, IDeepCloneable<LinkageRewardResponse>, IBufferMessage
	{
		// Token: 0x0600CDC9 RID: 52681 RVA: 0x001E5584 File Offset: 0x001E3784
		[NullableContext(1)]
		public static LinkageRewardResponse Create()
		{
			return new LinkageRewardResponse();
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600CDCA RID: 52682 RVA: 0x001E558B File Offset: 0x001E378B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600CDCB RID: 52683 RVA: 0x001E558E File Offset: 0x001E378E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600CDCC RID: 52684 RVA: 0x001E5595 File Offset: 0x001E3795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardResponse()
		{
		}

		// Token: 0x0600CDCD RID: 52685 RVA: 0x001E559D File Offset: 0x001E379D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardResponse(LinkageRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDCE RID: 52686 RVA: 0x001E55C2 File Offset: 0x001E37C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageRewardResponse Clone()
		{
			return new LinkageRewardResponse(this);
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600CDCF RID: 52687 RVA: 0x001E55CA File Offset: 0x001E37CA
		// (set) Token: 0x0600CDD0 RID: 52688 RVA: 0x001E55D2 File Offset: 0x001E37D2
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

		// Token: 0x0600CDD1 RID: 52689 RVA: 0x001E55DB File Offset: 0x001E37DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageRewardResponse);
		}

		// Token: 0x0600CDD2 RID: 52690 RVA: 0x001E55E9 File Offset: 0x001E37E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDD3 RID: 52691 RVA: 0x001E5618 File Offset: 0x001E3818
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

		// Token: 0x0600CDD4 RID: 52692 RVA: 0x001E565D File Offset: 0x001E385D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDD5 RID: 52693 RVA: 0x001E566A File Offset: 0x001E386A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDD6 RID: 52694 RVA: 0x001E5673 File Offset: 0x001E3873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDD7 RID: 52695 RVA: 0x001E56A8 File Offset: 0x001E38A8
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

		// Token: 0x0600CDD8 RID: 52696 RVA: 0x001E56E6 File Offset: 0x001E38E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkageRewardResponse other)
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

		// Token: 0x0600CDD9 RID: 52697 RVA: 0x001E5717 File Offset: 0x001E3917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDDA RID: 52698 RVA: 0x001E5720 File Offset: 0x001E3920
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005766 RID: 22374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005767 RID: 22375
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005768 RID: 22376
		private ErrorCode errorCode_;
	}
}
