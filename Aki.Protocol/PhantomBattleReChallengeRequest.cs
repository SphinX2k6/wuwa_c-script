using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9F RID: 3231
	[NetMessage(EMessageId.PhantomBattleReChallengeRequest)]
	public sealed class PhantomBattleReChallengeRequest : IMessage<PhantomBattleReChallengeRequest>, IMessage, IEquatable<PhantomBattleReChallengeRequest>, IDeepCloneable<PhantomBattleReChallengeRequest>, IBufferMessage
	{
		// Token: 0x06011823 RID: 71715 RVA: 0x00290A46 File Offset: 0x0028EC46
		[NullableContext(1)]
		public static PhantomBattleReChallengeRequest Create()
		{
			return new PhantomBattleReChallengeRequest();
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x06011824 RID: 71716 RVA: 0x00290A4D File Offset: 0x0028EC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x06011825 RID: 71717 RVA: 0x00290A50 File Offset: 0x0028EC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReChallengeRequest.Descriptor;
			}
		}

		// Token: 0x06011826 RID: 71718 RVA: 0x00290A57 File Offset: 0x0028EC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeRequest()
		{
		}

		// Token: 0x06011827 RID: 71719 RVA: 0x00290A5F File Offset: 0x0028EC5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeRequest(PhantomBattleReChallengeRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011828 RID: 71720 RVA: 0x00290A84 File Offset: 0x0028EC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReChallengeRequest Clone()
		{
			return new PhantomBattleReChallengeRequest(this);
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x06011829 RID: 71721 RVA: 0x00290A8C File Offset: 0x0028EC8C
		// (set) Token: 0x0601182A RID: 71722 RVA: 0x00290A94 File Offset: 0x0028EC94
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

		// Token: 0x0601182B RID: 71723 RVA: 0x00290A9D File Offset: 0x0028EC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReChallengeRequest);
		}

		// Token: 0x0601182C RID: 71724 RVA: 0x00290AAB File Offset: 0x0028ECAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReChallengeRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601182D RID: 71725 RVA: 0x00290ADC File Offset: 0x0028ECDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601182E RID: 71726 RVA: 0x00290B1B File Offset: 0x0028ED1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601182F RID: 71727 RVA: 0x00290B28 File Offset: 0x0028ED28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011830 RID: 71728 RVA: 0x00290B31 File Offset: 0x0028ED31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011831 RID: 71729 RVA: 0x00290B64 File Offset: 0x0028ED64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011832 RID: 71730 RVA: 0x00290BA2 File Offset: 0x0028EDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011833 RID: 71731 RVA: 0x00290BD3 File Offset: 0x0028EDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011834 RID: 71732 RVA: 0x00290BDC File Offset: 0x0028EDDC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E6B RID: 28267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E6C RID: 28268
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x04006E6D RID: 28269
		private int challengeId_;
	}
}
