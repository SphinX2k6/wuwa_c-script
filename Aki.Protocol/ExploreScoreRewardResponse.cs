using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FF RID: 1279
	[NetMessage(EMessageId.ExploreScoreRewardResponse)]
	public sealed class ExploreScoreRewardResponse : IMessage<ExploreScoreRewardResponse>, IMessage, IEquatable<ExploreScoreRewardResponse>, IDeepCloneable<ExploreScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x06007899 RID: 30873 RVA: 0x001258E4 File Offset: 0x00123AE4
		[NullableContext(1)]
		public static ExploreScoreRewardResponse Create()
		{
			return new ExploreScoreRewardResponse();
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x001258EB File Offset: 0x00123AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x0600789B RID: 30875 RVA: 0x001258EE File Offset: 0x00123AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x001258F5 File Offset: 0x00123AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardResponse()
		{
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x001258FD File Offset: 0x00123AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardResponse(ExploreScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00125922 File Offset: 0x00123B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreScoreRewardResponse Clone()
		{
			return new ExploreScoreRewardResponse(this);
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x0600789F RID: 30879 RVA: 0x0012592A File Offset: 0x00123B2A
		// (set) Token: 0x060078A0 RID: 30880 RVA: 0x00125932 File Offset: 0x00123B32
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

		// Token: 0x060078A1 RID: 30881 RVA: 0x0012593B File Offset: 0x00123B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreScoreRewardResponse);
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x00125949 File Offset: 0x00123B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078A3 RID: 30883 RVA: 0x00125978 File Offset: 0x00123B78
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

		// Token: 0x060078A4 RID: 30884 RVA: 0x001259BD File Offset: 0x00123BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x001259CA File Offset: 0x00123BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x001259D3 File Offset: 0x00123BD3
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

		// Token: 0x060078A7 RID: 30887 RVA: 0x00125A08 File Offset: 0x00123C08
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

		// Token: 0x060078A8 RID: 30888 RVA: 0x00125A46 File Offset: 0x00123C46
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

		// Token: 0x060078A9 RID: 30889 RVA: 0x00125A77 File Offset: 0x00123C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x00125A80 File Offset: 0x00123C80
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

		// Token: 0x04003E74 RID: 15988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E75 RID: 15989
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003E76 RID: 15990
		private ErrorCode errorCode_;
	}
}
