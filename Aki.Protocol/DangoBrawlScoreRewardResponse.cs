using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000371 RID: 881
	[NetMessage(EMessageId.DangoBrawlScoreRewardResponse)]
	public sealed class DangoBrawlScoreRewardResponse : IMessage<DangoBrawlScoreRewardResponse>, IMessage, IEquatable<DangoBrawlScoreRewardResponse>, IDeepCloneable<DangoBrawlScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x060057E7 RID: 22503 RVA: 0x000D6F74 File Offset: 0x000D5174
		[NullableContext(1)]
		public static DangoBrawlScoreRewardResponse Create()
		{
			return new DangoBrawlScoreRewardResponse();
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x060057E8 RID: 22504 RVA: 0x000D6F7B File Offset: 0x000D517B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x060057E9 RID: 22505 RVA: 0x000D6F7E File Offset: 0x000D517E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x000D6F85 File Offset: 0x000D5185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardResponse()
		{
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x000D6F8D File Offset: 0x000D518D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardResponse(DangoBrawlScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x000D6FB2 File Offset: 0x000D51B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardResponse Clone()
		{
			return new DangoBrawlScoreRewardResponse(this);
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x060057ED RID: 22509 RVA: 0x000D6FBA File Offset: 0x000D51BA
		// (set) Token: 0x060057EE RID: 22510 RVA: 0x000D6FC2 File Offset: 0x000D51C2
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

		// Token: 0x060057EF RID: 22511 RVA: 0x000D6FCB File Offset: 0x000D51CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlScoreRewardResponse);
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x000D6FD9 File Offset: 0x000D51D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x000D7008 File Offset: 0x000D5208
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

		// Token: 0x060057F2 RID: 22514 RVA: 0x000D704D File Offset: 0x000D524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x000D705A File Offset: 0x000D525A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x000D7063 File Offset: 0x000D5263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x000D7098 File Offset: 0x000D5298
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

		// Token: 0x060057F6 RID: 22518 RVA: 0x000D70D6 File Offset: 0x000D52D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlScoreRewardResponse other)
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

		// Token: 0x060057F7 RID: 22519 RVA: 0x000D7107 File Offset: 0x000D5307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x000D7110 File Offset: 0x000D5310
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400354C RID: 13644
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400354D RID: 13645
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x0400354E RID: 13646
		private ErrorCode errCode_;
	}
}
