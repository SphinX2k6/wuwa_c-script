using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C3 RID: 1987
	[NetMessage(EMessageId.InfrArchiveTaskRewardResponse)]
	public sealed class InfrArchiveTaskRewardResponse : IMessage<InfrArchiveTaskRewardResponse>, IMessage, IEquatable<InfrArchiveTaskRewardResponse>, IDeepCloneable<InfrArchiveTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B2FA RID: 45818 RVA: 0x001AC871 File Offset: 0x001AAA71
		[NullableContext(1)]
		public static InfrArchiveTaskRewardResponse Create()
		{
			return new InfrArchiveTaskRewardResponse();
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600B2FB RID: 45819 RVA: 0x001AC878 File Offset: 0x001AAA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600B2FC RID: 45820 RVA: 0x001AC87B File Offset: 0x001AAA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B2FD RID: 45821 RVA: 0x001AC882 File Offset: 0x001AAA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardResponse()
		{
		}

		// Token: 0x0600B2FE RID: 45822 RVA: 0x001AC88A File Offset: 0x001AAA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardResponse(InfrArchiveTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x001AC8AF File Offset: 0x001AAAAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardResponse Clone()
		{
			return new InfrArchiveTaskRewardResponse(this);
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x001AC8B7 File Offset: 0x001AAAB7
		// (set) Token: 0x0600B301 RID: 45825 RVA: 0x001AC8BF File Offset: 0x001AAABF
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

		// Token: 0x0600B302 RID: 45826 RVA: 0x001AC8C8 File Offset: 0x001AAAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveTaskRewardResponse);
		}

		// Token: 0x0600B303 RID: 45827 RVA: 0x001AC8D6 File Offset: 0x001AAAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x001AC904 File Offset: 0x001AAB04
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

		// Token: 0x0600B305 RID: 45829 RVA: 0x001AC949 File Offset: 0x001AAB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B306 RID: 45830 RVA: 0x001AC956 File Offset: 0x001AAB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B307 RID: 45831 RVA: 0x001AC95F File Offset: 0x001AAB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B308 RID: 45832 RVA: 0x001AC994 File Offset: 0x001AAB94
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

		// Token: 0x0600B309 RID: 45833 RVA: 0x001AC9D2 File Offset: 0x001AABD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrArchiveTaskRewardResponse other)
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

		// Token: 0x0600B30A RID: 45834 RVA: 0x001ACA03 File Offset: 0x001AAC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x001ACA0C File Offset: 0x001AAC0C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400503E RID: 20542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400503F RID: 20543
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005040 RID: 20544
		private ErrorCode errorCode_;
	}
}
