using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200053E RID: 1342
	[NetMessage(EMessageId.FishingEntrustHandInResponse)]
	public sealed class FishingEntrustHandInResponse : IMessage<FishingEntrustHandInResponse>, IMessage, IEquatable<FishingEntrustHandInResponse>, IDeepCloneable<FishingEntrustHandInResponse>, IBufferMessage
	{
		// Token: 0x06007DE9 RID: 32233 RVA: 0x001313EC File Offset: 0x0012F5EC
		[NullableContext(1)]
		public static FishingEntrustHandInResponse Create()
		{
			return new FishingEntrustHandInResponse();
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06007DEA RID: 32234 RVA: 0x001313F3 File Offset: 0x0012F5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06007DEB RID: 32235 RVA: 0x001313F6 File Offset: 0x0012F5F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustHandInResponse.Descriptor;
			}
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x001313FD File Offset: 0x0012F5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInResponse()
		{
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x00131405 File Offset: 0x0012F605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInResponse(FishingEntrustHandInResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DEE RID: 32238 RVA: 0x0013142A File Offset: 0x0012F62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInResponse Clone()
		{
			return new FishingEntrustHandInResponse(this);
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06007DEF RID: 32239 RVA: 0x00131432 File Offset: 0x0012F632
		// (set) Token: 0x06007DF0 RID: 32240 RVA: 0x0013143A File Offset: 0x0012F63A
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

		// Token: 0x06007DF1 RID: 32241 RVA: 0x00131443 File Offset: 0x0012F643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustHandInResponse);
		}

		// Token: 0x06007DF2 RID: 32242 RVA: 0x00131451 File Offset: 0x0012F651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustHandInResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DF3 RID: 32243 RVA: 0x00131480 File Offset: 0x0012F680
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

		// Token: 0x06007DF4 RID: 32244 RVA: 0x001314C5 File Offset: 0x0012F6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007DF5 RID: 32245 RVA: 0x001314D2 File Offset: 0x0012F6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DF6 RID: 32246 RVA: 0x001314DB File Offset: 0x0012F6DB
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

		// Token: 0x06007DF7 RID: 32247 RVA: 0x00131510 File Offset: 0x0012F710
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

		// Token: 0x06007DF8 RID: 32248 RVA: 0x0013154E File Offset: 0x0012F74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustHandInResponse other)
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

		// Token: 0x06007DF9 RID: 32249 RVA: 0x0013157F File Offset: 0x0012F77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DFA RID: 32250 RVA: 0x00131588 File Offset: 0x0012F788
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

		// Token: 0x04004051 RID: 16465
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004052 RID: 16466
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004053 RID: 16467
		private ErrorCode errorCode_;
	}
}
