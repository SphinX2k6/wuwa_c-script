using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067C RID: 1660
	[NetMessage(EMessageId.FunPlayChallengeAwardResponse)]
	public sealed class FunPlayChallengeAwardResponse : IMessage<FunPlayChallengeAwardResponse>, IMessage, IEquatable<FunPlayChallengeAwardResponse>, IDeepCloneable<FunPlayChallengeAwardResponse>, IBufferMessage
	{
		// Token: 0x06009813 RID: 38931 RVA: 0x0016E7F9 File Offset: 0x0016C9F9
		[NullableContext(1)]
		public static FunPlayChallengeAwardResponse Create()
		{
			return new FunPlayChallengeAwardResponse();
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x06009814 RID: 38932 RVA: 0x0016E800 File Offset: 0x0016CA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x06009815 RID: 38933 RVA: 0x0016E803 File Offset: 0x0016CA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeAwardResponse.Descriptor;
			}
		}

		// Token: 0x06009816 RID: 38934 RVA: 0x0016E80A File Offset: 0x0016CA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardResponse()
		{
		}

		// Token: 0x06009817 RID: 38935 RVA: 0x0016E812 File Offset: 0x0016CA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardResponse(FunPlayChallengeAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009818 RID: 38936 RVA: 0x0016E837 File Offset: 0x0016CA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardResponse Clone()
		{
			return new FunPlayChallengeAwardResponse(this);
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x06009819 RID: 38937 RVA: 0x0016E83F File Offset: 0x0016CA3F
		// (set) Token: 0x0600981A RID: 38938 RVA: 0x0016E847 File Offset: 0x0016CA47
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

		// Token: 0x0600981B RID: 38939 RVA: 0x0016E850 File Offset: 0x0016CA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeAwardResponse);
		}

		// Token: 0x0600981C RID: 38940 RVA: 0x0016E85E File Offset: 0x0016CA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600981D RID: 38941 RVA: 0x0016E88C File Offset: 0x0016CA8C
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

		// Token: 0x0600981E RID: 38942 RVA: 0x0016E8D1 File Offset: 0x0016CAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x0016E8DE File Offset: 0x0016CADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x0016E8E7 File Offset: 0x0016CAE7
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

		// Token: 0x06009821 RID: 38945 RVA: 0x0016E91C File Offset: 0x0016CB1C
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

		// Token: 0x06009822 RID: 38946 RVA: 0x0016E95A File Offset: 0x0016CB5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeAwardResponse other)
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

		// Token: 0x06009823 RID: 38947 RVA: 0x0016E98B File Offset: 0x0016CB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009824 RID: 38948 RVA: 0x0016E994 File Offset: 0x0016CB94
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

		// Token: 0x04004826 RID: 18470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004827 RID: 18471
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004828 RID: 18472
		private ErrorCode errorCode_;
	}
}
