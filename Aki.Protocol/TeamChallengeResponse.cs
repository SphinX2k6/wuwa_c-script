using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001323 RID: 4899
	[NetMessage(EMessageId.TeamChallengeResponse)]
	public sealed class TeamChallengeResponse : IMessage<TeamChallengeResponse>, IMessage, IEquatable<TeamChallengeResponse>, IDeepCloneable<TeamChallengeResponse>, IBufferMessage
	{
		// Token: 0x0601A08F RID: 106639 RVA: 0x003C85FA File Offset: 0x003C67FA
		[NullableContext(1)]
		public static TeamChallengeResponse Create()
		{
			return new TeamChallengeResponse();
		}

		// Token: 0x170057D1 RID: 22481
		// (get) Token: 0x0601A090 RID: 106640 RVA: 0x003C8601 File Offset: 0x003C6801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057D2 RID: 22482
		// (get) Token: 0x0601A091 RID: 106641 RVA: 0x003C8604 File Offset: 0x003C6804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeamChallengeResponse.Descriptor;
			}
		}

		// Token: 0x0601A092 RID: 106642 RVA: 0x003C860B File Offset: 0x003C680B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeResponse()
		{
		}

		// Token: 0x0601A093 RID: 106643 RVA: 0x003C8613 File Offset: 0x003C6813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeResponse(TeamChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A094 RID: 106644 RVA: 0x003C8638 File Offset: 0x003C6838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeamChallengeResponse Clone()
		{
			return new TeamChallengeResponse(this);
		}

		// Token: 0x170057D3 RID: 22483
		// (get) Token: 0x0601A095 RID: 106645 RVA: 0x003C8640 File Offset: 0x003C6840
		// (set) Token: 0x0601A096 RID: 106646 RVA: 0x003C8648 File Offset: 0x003C6848
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

		// Token: 0x0601A097 RID: 106647 RVA: 0x003C8651 File Offset: 0x003C6851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeamChallengeResponse);
		}

		// Token: 0x0601A098 RID: 106648 RVA: 0x003C865F File Offset: 0x003C685F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeamChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A099 RID: 106649 RVA: 0x003C8690 File Offset: 0x003C6890
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

		// Token: 0x0601A09A RID: 106650 RVA: 0x003C86D5 File Offset: 0x003C68D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A09B RID: 106651 RVA: 0x003C86E2 File Offset: 0x003C68E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A09C RID: 106652 RVA: 0x003C86EB File Offset: 0x003C68EB
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

		// Token: 0x0601A09D RID: 106653 RVA: 0x003C8720 File Offset: 0x003C6920
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

		// Token: 0x0601A09E RID: 106654 RVA: 0x003C875E File Offset: 0x003C695E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeamChallengeResponse other)
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

		// Token: 0x0601A09F RID: 106655 RVA: 0x003C878F File Offset: 0x003C698F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0A0 RID: 106656 RVA: 0x003C8798 File Offset: 0x003C6998
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

		// Token: 0x04009819 RID: 38937
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400981A RID: 38938
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400981B RID: 38939
		private ErrorCode errorCode_;
	}
}
