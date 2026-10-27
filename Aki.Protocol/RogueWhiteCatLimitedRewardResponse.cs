using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001050 RID: 4176
	[NetMessage(EMessageId.RogueWhiteCatLimitedRewardResponse)]
	public sealed class RogueWhiteCatLimitedRewardResponse : IMessage<RogueWhiteCatLimitedRewardResponse>, IMessage, IEquatable<RogueWhiteCatLimitedRewardResponse>, IDeepCloneable<RogueWhiteCatLimitedRewardResponse>, IBufferMessage
	{
		// Token: 0x0601650C RID: 91404 RVA: 0x0033E35D File Offset: 0x0033C55D
		[NullableContext(1)]
		public static RogueWhiteCatLimitedRewardResponse Create()
		{
			return new RogueWhiteCatLimitedRewardResponse();
		}

		// Token: 0x17004AA5 RID: 19109
		// (get) Token: 0x0601650D RID: 91405 RVA: 0x0033E364 File Offset: 0x0033C564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AA6 RID: 19110
		// (get) Token: 0x0601650E RID: 91406 RVA: 0x0033E367 File Offset: 0x0033C567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWhiteCatLimitedRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601650F RID: 91407 RVA: 0x0033E36E File Offset: 0x0033C56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardResponse()
		{
		}

		// Token: 0x06016510 RID: 91408 RVA: 0x0033E376 File Offset: 0x0033C576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardResponse(RogueWhiteCatLimitedRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016511 RID: 91409 RVA: 0x0033E39B File Offset: 0x0033C59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWhiteCatLimitedRewardResponse Clone()
		{
			return new RogueWhiteCatLimitedRewardResponse(this);
		}

		// Token: 0x17004AA7 RID: 19111
		// (get) Token: 0x06016512 RID: 91410 RVA: 0x0033E3A3 File Offset: 0x0033C5A3
		// (set) Token: 0x06016513 RID: 91411 RVA: 0x0033E3AB File Offset: 0x0033C5AB
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

		// Token: 0x06016514 RID: 91412 RVA: 0x0033E3B4 File Offset: 0x0033C5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWhiteCatLimitedRewardResponse);
		}

		// Token: 0x06016515 RID: 91413 RVA: 0x0033E3C2 File Offset: 0x0033C5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWhiteCatLimitedRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016516 RID: 91414 RVA: 0x0033E3F0 File Offset: 0x0033C5F0
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

		// Token: 0x06016517 RID: 91415 RVA: 0x0033E435 File Offset: 0x0033C635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016518 RID: 91416 RVA: 0x0033E442 File Offset: 0x0033C642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016519 RID: 91417 RVA: 0x0033E44B File Offset: 0x0033C64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601651A RID: 91418 RVA: 0x0033E480 File Offset: 0x0033C680
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

		// Token: 0x0601651B RID: 91419 RVA: 0x0033E4BE File Offset: 0x0033C6BE
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

		// Token: 0x0601651C RID: 91420 RVA: 0x0033E4EF File Offset: 0x0033C6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601651D RID: 91421 RVA: 0x0033E4F8 File Offset: 0x0033C6F8
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008585 RID: 34181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008586 RID: 34182
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008587 RID: 34183
		private ErrorCode errorCode_;
	}
}
