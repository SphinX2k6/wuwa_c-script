using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBB RID: 4027
	[NetMessage(EMessageId.RoguelikeWriteCatLevelPlayRewardResponse)]
	public sealed class RoguelikeWriteCatLevelPlayRewardResponse : IMessage<RoguelikeWriteCatLevelPlayRewardResponse>, IMessage, IEquatable<RoguelikeWriteCatLevelPlayRewardResponse>, IDeepCloneable<RoguelikeWriteCatLevelPlayRewardResponse>, IBufferMessage
	{
		// Token: 0x060158E9 RID: 88297 RVA: 0x00321AA8 File Offset: 0x0031FCA8
		[NullableContext(1)]
		public static RoguelikeWriteCatLevelPlayRewardResponse Create()
		{
			return new RoguelikeWriteCatLevelPlayRewardResponse();
		}

		// Token: 0x170047E9 RID: 18409
		// (get) Token: 0x060158EA RID: 88298 RVA: 0x00321AAF File Offset: 0x0031FCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x060158EB RID: 88299 RVA: 0x00321AB2 File Offset: 0x0031FCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeWriteCatLevelPlayRewardResponse.Descriptor;
			}
		}

		// Token: 0x060158EC RID: 88300 RVA: 0x00321AB9 File Offset: 0x0031FCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardResponse()
		{
		}

		// Token: 0x060158ED RID: 88301 RVA: 0x00321AC1 File Offset: 0x0031FCC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardResponse(RoguelikeWriteCatLevelPlayRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060158EE RID: 88302 RVA: 0x00321AE6 File Offset: 0x0031FCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeWriteCatLevelPlayRewardResponse Clone()
		{
			return new RoguelikeWriteCatLevelPlayRewardResponse(this);
		}

		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x060158EF RID: 88303 RVA: 0x00321AEE File Offset: 0x0031FCEE
		// (set) Token: 0x060158F0 RID: 88304 RVA: 0x00321AF6 File Offset: 0x0031FCF6
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

		// Token: 0x060158F1 RID: 88305 RVA: 0x00321AFF File Offset: 0x0031FCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeWriteCatLevelPlayRewardResponse);
		}

		// Token: 0x060158F2 RID: 88306 RVA: 0x00321B0D File Offset: 0x0031FD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeWriteCatLevelPlayRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158F3 RID: 88307 RVA: 0x00321B3C File Offset: 0x0031FD3C
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

		// Token: 0x060158F4 RID: 88308 RVA: 0x00321B81 File Offset: 0x0031FD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158F5 RID: 88309 RVA: 0x00321B8E File Offset: 0x0031FD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158F6 RID: 88310 RVA: 0x00321B97 File Offset: 0x0031FD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158F7 RID: 88311 RVA: 0x00321BCC File Offset: 0x0031FDCC
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

		// Token: 0x060158F8 RID: 88312 RVA: 0x00321C0A File Offset: 0x0031FE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeWriteCatLevelPlayRewardResponse other)
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

		// Token: 0x060158F9 RID: 88313 RVA: 0x00321C3B File Offset: 0x0031FE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158FA RID: 88314 RVA: 0x00321C44 File Offset: 0x0031FE44
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040081F9 RID: 33273
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081FA RID: 33274
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040081FB RID: 33275
		private ErrorCode errorCode_;
	}
}
