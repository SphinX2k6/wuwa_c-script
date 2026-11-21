using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BF RID: 4287
	[NetMessage(EMessageId.RoleTowerChallengeSettleNotify)]
	public sealed class RoleTowerChallengeSettleNotify : IMessage<RoleTowerChallengeSettleNotify>, IMessage, IEquatable<RoleTowerChallengeSettleNotify>, IDeepCloneable<RoleTowerChallengeSettleNotify>, IBufferMessage
	{
		// Token: 0x06016EB1 RID: 93873 RVA: 0x00355615 File Offset: 0x00353815
		[NullableContext(1)]
		public static RoleTowerChallengeSettleNotify Create()
		{
			return new RoleTowerChallengeSettleNotify();
		}

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x06016EB2 RID: 93874 RVA: 0x0035561C File Offset: 0x0035381C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x06016EB3 RID: 93875 RVA: 0x0035561F File Offset: 0x0035381F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerChallengeSettleNotify.Descriptor;
			}
		}

		// Token: 0x06016EB4 RID: 93876 RVA: 0x00355626 File Offset: 0x00353826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleNotify()
		{
		}

		// Token: 0x06016EB5 RID: 93877 RVA: 0x0035562E File Offset: 0x0035382E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleNotify(RoleTowerChallengeSettleNotify other) : this()
		{
			this.challengeSettleInfo_ = ((other.challengeSettleInfo_ != null) ? other.challengeSettleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EB6 RID: 93878 RVA: 0x00355663 File Offset: 0x00353863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleNotify Clone()
		{
			return new RoleTowerChallengeSettleNotify(this);
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x06016EB7 RID: 93879 RVA: 0x0035566B File Offset: 0x0035386B
		// (set) Token: 0x06016EB8 RID: 93880 RVA: 0x00355673 File Offset: 0x00353873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeSettleInfo ChallengeSettleInfo
		{
			get
			{
				return this.challengeSettleInfo_;
			}
			set
			{
				this.challengeSettleInfo_ = value;
			}
		}

		// Token: 0x06016EB9 RID: 93881 RVA: 0x0035567C File Offset: 0x0035387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerChallengeSettleNotify);
		}

		// Token: 0x06016EBA RID: 93882 RVA: 0x0035568A File Offset: 0x0035388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerChallengeSettleNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ChallengeSettleInfo, other.ChallengeSettleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EBB RID: 93883 RVA: 0x003556C0 File Offset: 0x003538C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.challengeSettleInfo_ != null)
			{
				num ^= this.ChallengeSettleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016EBC RID: 93884 RVA: 0x003556FC File Offset: 0x003538FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EBD RID: 93885 RVA: 0x00355709 File Offset: 0x00353909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EBE RID: 93886 RVA: 0x00355712 File Offset: 0x00353912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.challengeSettleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ChallengeSettleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016EBF RID: 93887 RVA: 0x00355744 File Offset: 0x00353944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.challengeSettleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChallengeSettleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EC0 RID: 93888 RVA: 0x00355784 File Offset: 0x00353984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerChallengeSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.challengeSettleInfo_ != null)
			{
				if (this.challengeSettleInfo_ == null)
				{
					this.ChallengeSettleInfo = new RoleTowerChallengeSettleInfo();
				}
				this.ChallengeSettleInfo.MergeFrom(other.ChallengeSettleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EC1 RID: 93889 RVA: 0x003557D8 File Offset: 0x003539D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EC2 RID: 93890 RVA: 0x003557E4 File Offset: 0x003539E4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.challengeSettleInfo_ == null)
					{
						this.ChallengeSettleInfo = new RoleTowerChallengeSettleInfo();
					}
					input.ReadMessage(this.ChallengeSettleInfo);
				}
			}
		}

		// Token: 0x0400893E RID: 35134
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400893F RID: 35135
		public const int ChallengeSettleInfoFieldNumber = 1;

		// Token: 0x04008940 RID: 35136
		private RoleTowerChallengeSettleInfo challengeSettleInfo_;
	}
}
