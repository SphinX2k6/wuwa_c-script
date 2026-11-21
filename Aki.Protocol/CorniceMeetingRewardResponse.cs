using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030F RID: 783
	[NetMessage(EMessageId.CorniceMeetingRewardResponse)]
	public sealed class CorniceMeetingRewardResponse : IMessage<CorniceMeetingRewardResponse>, IMessage, IEquatable<CorniceMeetingRewardResponse>, IDeepCloneable<CorniceMeetingRewardResponse>, IBufferMessage
	{
		// Token: 0x06004F1F RID: 20255 RVA: 0x000C05FC File Offset: 0x000BE7FC
		[NullableContext(1)]
		public static CorniceMeetingRewardResponse Create()
		{
			return new CorniceMeetingRewardResponse();
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06004F20 RID: 20256 RVA: 0x000C0603 File Offset: 0x000BE803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x000C0606 File Offset: 0x000BE806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x000C060D File Offset: 0x000BE80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardResponse()
		{
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x000C0615 File Offset: 0x000BE815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardResponse(CorniceMeetingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x000C063A File Offset: 0x000BE83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardResponse Clone()
		{
			return new CorniceMeetingRewardResponse(this);
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06004F25 RID: 20261 RVA: 0x000C0642 File Offset: 0x000BE842
		// (set) Token: 0x06004F26 RID: 20262 RVA: 0x000C064A File Offset: 0x000BE84A
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

		// Token: 0x06004F27 RID: 20263 RVA: 0x000C0653 File Offset: 0x000BE853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingRewardResponse);
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x000C0661 File Offset: 0x000BE861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x000C0690 File Offset: 0x000BE890
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

		// Token: 0x06004F2A RID: 20266 RVA: 0x000C06D5 File Offset: 0x000BE8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x000C06E2 File Offset: 0x000BE8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x000C06EB File Offset: 0x000BE8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x000C0720 File Offset: 0x000BE920
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

		// Token: 0x06004F2E RID: 20270 RVA: 0x000C075E File Offset: 0x000BE95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceMeetingRewardResponse other)
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

		// Token: 0x06004F2F RID: 20271 RVA: 0x000C078F File Offset: 0x000BE98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x000C0798 File Offset: 0x000BE998
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003222 RID: 12834
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003223 RID: 12835
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003224 RID: 12836
		private ErrorCode errorCode_;
	}
}
