using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACA RID: 2762
	[NetMessage(EMessageId.MulExploreScoreRewardResponse)]
	public sealed class MulExploreScoreRewardResponse : IMessage<MulExploreScoreRewardResponse>, IMessage, IEquatable<MulExploreScoreRewardResponse>, IDeepCloneable<MulExploreScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F0B9 RID: 61625 RVA: 0x00233017 File Offset: 0x00231217
		[NullableContext(1)]
		public static MulExploreScoreRewardResponse Create()
		{
			return new MulExploreScoreRewardResponse();
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x0600F0BA RID: 61626 RVA: 0x0023301E File Offset: 0x0023121E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x0600F0BB RID: 61627 RVA: 0x00233021 File Offset: 0x00231221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulExploreScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F0BC RID: 61628 RVA: 0x00233028 File Offset: 0x00231228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardResponse()
		{
		}

		// Token: 0x0600F0BD RID: 61629 RVA: 0x00233030 File Offset: 0x00231230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardResponse(MulExploreScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0BE RID: 61630 RVA: 0x00233055 File Offset: 0x00231255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulExploreScoreRewardResponse Clone()
		{
			return new MulExploreScoreRewardResponse(this);
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x0600F0BF RID: 61631 RVA: 0x0023305D File Offset: 0x0023125D
		// (set) Token: 0x0600F0C0 RID: 61632 RVA: 0x00233065 File Offset: 0x00231265
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

		// Token: 0x0600F0C1 RID: 61633 RVA: 0x0023306E File Offset: 0x0023126E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulExploreScoreRewardResponse);
		}

		// Token: 0x0600F0C2 RID: 61634 RVA: 0x0023307C File Offset: 0x0023127C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulExploreScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0C3 RID: 61635 RVA: 0x002330AC File Offset: 0x002312AC
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

		// Token: 0x0600F0C4 RID: 61636 RVA: 0x002330F1 File Offset: 0x002312F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0C5 RID: 61637 RVA: 0x002330FE File Offset: 0x002312FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0C6 RID: 61638 RVA: 0x00233107 File Offset: 0x00231307
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

		// Token: 0x0600F0C7 RID: 61639 RVA: 0x0023313C File Offset: 0x0023133C
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

		// Token: 0x0600F0C8 RID: 61640 RVA: 0x0023317A File Offset: 0x0023137A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulExploreScoreRewardResponse other)
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

		// Token: 0x0600F0C9 RID: 61641 RVA: 0x002331AB File Offset: 0x002313AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0CA RID: 61642 RVA: 0x002331B4 File Offset: 0x002313B4
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

		// Token: 0x040061AE RID: 25006
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061AF RID: 25007
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040061B0 RID: 25008
		private ErrorCode errorCode_;
	}
}
