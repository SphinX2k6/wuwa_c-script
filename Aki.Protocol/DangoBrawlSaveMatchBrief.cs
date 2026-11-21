using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036E RID: 878
	public sealed class DangoBrawlSaveMatchBrief : IMessage<DangoBrawlSaveMatchBrief>, IMessage, IEquatable<DangoBrawlSaveMatchBrief>, IDeepCloneable<DangoBrawlSaveMatchBrief>, IBufferMessage
	{
		// Token: 0x060057AB RID: 22443 RVA: 0x000D6760 File Offset: 0x000D4960
		[NullableContext(1)]
		public static DangoBrawlSaveMatchBrief Create()
		{
			return new DangoBrawlSaveMatchBrief();
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060057AC RID: 22444 RVA: 0x000D6767 File Offset: 0x000D4967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060057AD RID: 22445 RVA: 0x000D676A File Offset: 0x000D496A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSaveMatchBrief.Descriptor;
			}
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x000D6771 File Offset: 0x000D4971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief()
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x000D6779 File Offset: 0x000D4979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief(DangoBrawlSaveMatchBrief other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.roundNum_ = other.roundNum_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x000D67B6 File Offset: 0x000D49B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSaveMatchBrief Clone()
		{
			return new DangoBrawlSaveMatchBrief(this);
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x060057B1 RID: 22449 RVA: 0x000D67BE File Offset: 0x000D49BE
		// (set) Token: 0x060057B2 RID: 22450 RVA: 0x000D67C6 File Offset: 0x000D49C6
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

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x060057B3 RID: 22451 RVA: 0x000D67CF File Offset: 0x000D49CF
		// (set) Token: 0x060057B4 RID: 22452 RVA: 0x000D67D7 File Offset: 0x000D49D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x060057B5 RID: 22453 RVA: 0x000D67E0 File Offset: 0x000D49E0
		// (set) Token: 0x060057B6 RID: 22454 RVA: 0x000D67E8 File Offset: 0x000D49E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x000D67F1 File Offset: 0x000D49F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSaveMatchBrief);
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x000D6800 File Offset: 0x000D4A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSaveMatchBrief other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.RoundNum == other.RoundNum && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x000D685C File Offset: 0x000D4A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x000D68CD File Offset: 0x000D4ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x000D68DA File Offset: 0x000D4ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x000D68E4 File Offset: 0x000D4AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoundNum);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x000D6958 File Offset: 0x000D4B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x000D69C8 File Offset: 0x000D4BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlSaveMatchBrief other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060057BF RID: 22463 RVA: 0x000D6A2C File Offset: 0x000D4C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060057C0 RID: 22464 RVA: 0x000D6A38 File Offset: 0x000D4C38
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.RoundNum = input.ReadInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400353C RID: 13628
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400353D RID: 13629
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400353E RID: 13630
		private int challengeId_;

		// Token: 0x0400353F RID: 13631
		public const int RoundNumFieldNumber = 2;

		// Token: 0x04003540 RID: 13632
		private int roundNum_;

		// Token: 0x04003541 RID: 13633
		public const int RoleIdFieldNumber = 3;

		// Token: 0x04003542 RID: 13634
		private int roleId_;
	}
}
