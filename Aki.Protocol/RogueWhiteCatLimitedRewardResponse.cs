using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001040 RID: 4160
	[NetMessage(EMessageId.RogueWhiteCatLimitedRewardResponse)]
	public sealed class RogueWhiteCatLimitedRewardResponse : IMessage<RogueWhiteCatLimitedRewardResponse>, IMessage, IEquatable<RogueWhiteCatLimitedRewardResponse>, IDeepCloneable<RogueWhiteCatLimitedRewardResponse>, IBufferMessage
	{
		// Token: 0x06016427 RID: 91175 RVA: 0x0033CC91 File Offset: 0x0033AE91
		[NullableContext(1)]
		public static RogueWhiteCatLimitedRewardResponse Create()
		{
			return new RogueWhiteCatLimitedRewardResponse();
		}

		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x06016428 RID: 91176 RVA: 0x0033CC98 File Offset: 0x0033AE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x06016429 RID: 91177 RVA: 0x0033CC9B File Offset: 0x0033AE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatLimitedRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601642A RID: 91178 RVA: 0x0033CCA2 File Offset: 0x0033AEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardResponse()
		{
		}

		// Token: 0x0601642B RID: 91179 RVA: 0x0033CCAA File Offset: 0x0033AEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardResponse(RogueWhiteCatLimitedRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601642C RID: 91180 RVA: 0x0033CCCF File Offset: 0x0033AECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardResponse Clone()
		{
			return new RogueWhiteCatLimitedRewardResponse(this);
		}

		// Token: 0x17004A7D RID: 19069
		// (get) Token: 0x0601642D RID: 91181 RVA: 0x0033CCD7 File Offset: 0x0033AED7
		// (set) Token: 0x0601642E RID: 91182 RVA: 0x0033CCDF File Offset: 0x0033AEDF
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

		// Token: 0x0601642F RID: 91183 RVA: 0x0033CCE8 File Offset: 0x0033AEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatLimitedRewardResponse);
		}

		// Token: 0x06016430 RID: 91184 RVA: 0x0033CCF6 File Offset: 0x0033AEF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatLimitedRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016431 RID: 91185 RVA: 0x0033CD24 File Offset: 0x0033AF24
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

		// Token: 0x06016432 RID: 91186 RVA: 0x0033CD69 File Offset: 0x0033AF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016433 RID: 91187 RVA: 0x0033CD76 File Offset: 0x0033AF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016434 RID: 91188 RVA: 0x0033CD7F File Offset: 0x0033AF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016435 RID: 91189 RVA: 0x0033CDB4 File Offset: 0x0033AFB4
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

		// Token: 0x06016436 RID: 91190 RVA: 0x0033CDF2 File Offset: 0x0033AFF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWhiteCatLimitedRewardResponse other)
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

		// Token: 0x06016437 RID: 91191 RVA: 0x0033CE23 File Offset: 0x0033B023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016438 RID: 91192 RVA: 0x0033CE2C File Offset: 0x0033B02C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040085AF RID: 34223
		private UnknownFieldSet _unknownFields;

		// Token: 0x040085B0 RID: 34224
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040085B1 RID: 34225
		private ErrorCode errorCode_;
	}
}
