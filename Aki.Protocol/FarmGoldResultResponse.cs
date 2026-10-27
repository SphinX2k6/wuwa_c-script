using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052C RID: 1324
	[NetMessage(EMessageId.FarmGoldResultResponse)]
	public sealed class FarmGoldResultResponse : IMessage<FarmGoldResultResponse>, IMessage, IEquatable<FarmGoldResultResponse>, IDeepCloneable<FarmGoldResultResponse>, IBufferMessage
	{
		// Token: 0x06007C1A RID: 31770 RVA: 0x0012CC3A File Offset: 0x0012AE3A
		[NullableContext(1)]
		public static FarmGoldResultResponse Create()
		{
			return new FarmGoldResultResponse();
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06007C1B RID: 31771 RVA: 0x0012CC41 File Offset: 0x0012AE41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06007C1C RID: 31772 RVA: 0x0012CC44 File Offset: 0x0012AE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldResultResponse.Descriptor;
			}
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x0012CC4B File Offset: 0x0012AE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultResponse()
		{
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x0012CC53 File Offset: 0x0012AE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultResponse(FarmGoldResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x0012CC78 File Offset: 0x0012AE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultResponse Clone()
		{
			return new FarmGoldResultResponse(this);
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06007C20 RID: 31776 RVA: 0x0012CC80 File Offset: 0x0012AE80
		// (set) Token: 0x06007C21 RID: 31777 RVA: 0x0012CC88 File Offset: 0x0012AE88
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

		// Token: 0x06007C22 RID: 31778 RVA: 0x0012CC91 File Offset: 0x0012AE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldResultResponse);
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x0012CC9F File Offset: 0x0012AE9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x0012CCD0 File Offset: 0x0012AED0
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

		// Token: 0x06007C25 RID: 31781 RVA: 0x0012CD15 File Offset: 0x0012AF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x0012CD22 File Offset: 0x0012AF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x0012CD2B File Offset: 0x0012AF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x0012CD60 File Offset: 0x0012AF60
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

		// Token: 0x06007C29 RID: 31785 RVA: 0x0012CD9E File Offset: 0x0012AF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldResultResponse other)
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

		// Token: 0x06007C2A RID: 31786 RVA: 0x0012CDCF File Offset: 0x0012AFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x0012CDD8 File Offset: 0x0012AFD8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F56 RID: 16214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F57 RID: 16215
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04003F58 RID: 16216
		private ErrorCode errorCode_;
	}
}
