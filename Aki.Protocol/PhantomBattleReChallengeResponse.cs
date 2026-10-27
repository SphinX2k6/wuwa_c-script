using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA0 RID: 3232
	[NetMessage(EMessageId.PhantomBattleReChallengeResponse)]
	public sealed class PhantomBattleReChallengeResponse : IMessage<PhantomBattleReChallengeResponse>, IMessage, IEquatable<PhantomBattleReChallengeResponse>, IDeepCloneable<PhantomBattleReChallengeResponse>, IBufferMessage
	{
		// Token: 0x06011835 RID: 71733 RVA: 0x00290C21 File Offset: 0x0028EE21
		[NullableContext(1)]
		public static PhantomBattleReChallengeResponse Create()
		{
			return new PhantomBattleReChallengeResponse();
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x06011836 RID: 71734 RVA: 0x00290C28 File Offset: 0x0028EE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x06011837 RID: 71735 RVA: 0x00290C2B File Offset: 0x0028EE2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReChallengeResponse.Descriptor;
			}
		}

		// Token: 0x06011838 RID: 71736 RVA: 0x00290C32 File Offset: 0x0028EE32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeResponse()
		{
		}

		// Token: 0x06011839 RID: 71737 RVA: 0x00290C3C File Offset: 0x0028EE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeResponse(PhantomBattleReChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.challengeId_ = other.challengeId_;
			this.phantomBattleNPCId_ = other.phantomBattleNPCId_;
			this.cardGroupId_ = other.cardGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601183A RID: 71738 RVA: 0x00290C90 File Offset: 0x0028EE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeResponse Clone()
		{
			return new PhantomBattleReChallengeResponse(this);
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0601183B RID: 71739 RVA: 0x00290C98 File Offset: 0x0028EE98
		// (set) Token: 0x0601183C RID: 71740 RVA: 0x00290CA0 File Offset: 0x0028EEA0
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

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0601183D RID: 71741 RVA: 0x00290CA9 File Offset: 0x0028EEA9
		// (set) Token: 0x0601183E RID: 71742 RVA: 0x00290CB1 File Offset: 0x0028EEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0601183F RID: 71743 RVA: 0x00290CBA File Offset: 0x0028EEBA
		// (set) Token: 0x06011840 RID: 71744 RVA: 0x00290CC2 File Offset: 0x0028EEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleNPCId
		{
			get
			{
				return this.phantomBattleNPCId_;
			}
			set
			{
				this.phantomBattleNPCId_ = value;
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x06011841 RID: 71745 RVA: 0x00290CCB File Offset: 0x0028EECB
		// (set) Token: 0x06011842 RID: 71746 RVA: 0x00290CD3 File Offset: 0x0028EED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardGroupId
		{
			get
			{
				return this.cardGroupId_;
			}
			set
			{
				this.cardGroupId_ = value;
			}
		}

		// Token: 0x06011843 RID: 71747 RVA: 0x00290CDC File Offset: 0x0028EEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReChallengeResponse);
		}

		// Token: 0x06011844 RID: 71748 RVA: 0x00290CEC File Offset: 0x0028EEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ChallengeId == other.ChallengeId && this.PhantomBattleNPCId == other.PhantomBattleNPCId && this.CardGroupId == other.CardGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011845 RID: 71749 RVA: 0x00290D58 File Offset: 0x0028EF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.PhantomBattleNPCId != 0)
			{
				num ^= this.PhantomBattleNPCId.GetHashCode();
			}
			if (this.CardGroupId != 0)
			{
				num ^= this.CardGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011846 RID: 71750 RVA: 0x00290DE8 File Offset: 0x0028EFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011847 RID: 71751 RVA: 0x00290DF5 File Offset: 0x0028EFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011848 RID: 71752 RVA: 0x00290E00 File Offset: 0x0028F000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PhantomBattleNPCId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.PhantomBattleNPCId);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.CardGroupId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CardGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011849 RID: 71753 RVA: 0x00290E94 File Offset: 0x0028F094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.PhantomBattleNPCId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleNPCId);
			}
			if (this.CardGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601184A RID: 71754 RVA: 0x00290F1C File Offset: 0x0028F11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReChallengeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.PhantomBattleNPCId != 0)
			{
				this.PhantomBattleNPCId = other.PhantomBattleNPCId;
			}
			if (other.CardGroupId != 0)
			{
				this.CardGroupId = other.CardGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601184B RID: 71755 RVA: 0x00290F94 File Offset: 0x0028F194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601184C RID: 71756 RVA: 0x00290FA0 File Offset: 0x0028F1A0
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
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.PhantomBattleNPCId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.CardGroupId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E6E RID: 28270
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E6F RID: 28271
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04006E70 RID: 28272
		private ErrorCode errorCode_;

		// Token: 0x04006E71 RID: 28273
		public const int ChallengeIdFieldNumber = 10;

		// Token: 0x04006E72 RID: 28274
		private int challengeId_;

		// Token: 0x04006E73 RID: 28275
		public const int PhantomBattleNPCIdFieldNumber = 9;

		// Token: 0x04006E74 RID: 28276
		private int phantomBattleNPCId_;

		// Token: 0x04006E75 RID: 28277
		public const int CardGroupIdFieldNumber = 13;

		// Token: 0x04006E76 RID: 28278
		private int cardGroupId_;
	}
}
