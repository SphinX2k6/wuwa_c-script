using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E9 RID: 1257
	[NetMessage(EMessageId.ExploreScoreRewardResponse)]
	public sealed class ExploreScoreRewardResponse : IMessage<ExploreScoreRewardResponse>, IMessage, IEquatable<ExploreScoreRewardResponse>, IDeepCloneable<ExploreScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600771D RID: 30493 RVA: 0x00122A4C File Offset: 0x00120C4C
		[NullableContext(1)]
		public static ExploreScoreRewardResponse Create()
		{
			return new ExploreScoreRewardResponse();
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x00122A53 File Offset: 0x00120C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x0600771F RID: 30495 RVA: 0x00122A56 File Offset: 0x00120C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00122A5D File Offset: 0x00120C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardResponse()
		{
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00122A65 File Offset: 0x00120C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardResponse(ExploreScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00122A8A File Offset: 0x00120C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardResponse Clone()
		{
			return new ExploreScoreRewardResponse(this);
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06007723 RID: 30499 RVA: 0x00122A92 File Offset: 0x00120C92
		// (set) Token: 0x06007724 RID: 30500 RVA: 0x00122A9A File Offset: 0x00120C9A
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

		// Token: 0x06007725 RID: 30501 RVA: 0x00122AA3 File Offset: 0x00120CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreScoreRewardResponse);
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00122AB1 File Offset: 0x00120CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00122AE0 File Offset: 0x00120CE0
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

		// Token: 0x06007728 RID: 30504 RVA: 0x00122B25 File Offset: 0x00120D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00122B32 File Offset: 0x00120D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00122B3B File Offset: 0x00120D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00122B70 File Offset: 0x00120D70
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

		// Token: 0x0600772C RID: 30508 RVA: 0x00122BAE File Offset: 0x00120DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreScoreRewardResponse other)
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

		// Token: 0x0600772D RID: 30509 RVA: 0x00122BDF File Offset: 0x00120DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00122BE8 File Offset: 0x00120DE8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003E65 RID: 15973
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E66 RID: 15974
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04003E67 RID: 15975
		private ErrorCode errorCode_;
	}
}
