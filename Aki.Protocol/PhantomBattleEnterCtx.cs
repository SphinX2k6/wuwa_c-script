using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C82 RID: 3202
	public sealed class PhantomBattleEnterCtx : IMessage<PhantomBattleEnterCtx>, IMessage, IEquatable<PhantomBattleEnterCtx>, IDeepCloneable<PhantomBattleEnterCtx>, IBufferMessage
	{
		// Token: 0x060115BE RID: 71102 RVA: 0x0028B303 File Offset: 0x00289503
		[NullableContext(1)]
		public static PhantomBattleEnterCtx Create()
		{
			return new PhantomBattleEnterCtx();
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x060115BF RID: 71103 RVA: 0x0028B30A File Offset: 0x0028950A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x060115C0 RID: 71104 RVA: 0x0028B30D File Offset: 0x0028950D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEnterCtx.Descriptor;
			}
		}

		// Token: 0x060115C1 RID: 71105 RVA: 0x0028B314 File Offset: 0x00289514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterCtx()
		{
		}

		// Token: 0x060115C2 RID: 71106 RVA: 0x0028B31C File Offset: 0x0028951C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterCtx(PhantomBattleEnterCtx other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.cardRoleId_ = other.cardRoleId_;
			this.cardGroupIndex_ = other.cardGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060115C3 RID: 71107 RVA: 0x0028B359 File Offset: 0x00289559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterCtx Clone()
		{
			return new PhantomBattleEnterCtx(this);
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x060115C4 RID: 71108 RVA: 0x0028B361 File Offset: 0x00289561
		// (set) Token: 0x060115C5 RID: 71109 RVA: 0x0028B369 File Offset: 0x00289569
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

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x060115C6 RID: 71110 RVA: 0x0028B372 File Offset: 0x00289572
		// (set) Token: 0x060115C7 RID: 71111 RVA: 0x0028B37A File Offset: 0x0028957A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardRoleId
		{
			get
			{
				return this.cardRoleId_;
			}
			set
			{
				this.cardRoleId_ = value;
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x060115C8 RID: 71112 RVA: 0x0028B383 File Offset: 0x00289583
		// (set) Token: 0x060115C9 RID: 71113 RVA: 0x0028B38B File Offset: 0x0028958B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardGroupIndex
		{
			get
			{
				return this.cardGroupIndex_;
			}
			set
			{
				this.cardGroupIndex_ = value;
			}
		}

		// Token: 0x060115CA RID: 71114 RVA: 0x0028B394 File Offset: 0x00289594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEnterCtx);
		}

		// Token: 0x060115CB RID: 71115 RVA: 0x0028B3A4 File Offset: 0x002895A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEnterCtx other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.CardRoleId == other.CardRoleId && this.CardGroupIndex == other.CardGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060115CC RID: 71116 RVA: 0x0028B400 File Offset: 0x00289600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.CardRoleId != 0)
			{
				num ^= this.CardRoleId.GetHashCode();
			}
			if (this.CardGroupIndex != 0)
			{
				num ^= this.CardGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060115CD RID: 71117 RVA: 0x0028B471 File Offset: 0x00289671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060115CE RID: 71118 RVA: 0x0028B47E File Offset: 0x0028967E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060115CF RID: 71119 RVA: 0x0028B488 File Offset: 0x00289688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.CardRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardRoleId);
			}
			if (this.CardGroupIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060115D0 RID: 71120 RVA: 0x0028B4FC File Offset: 0x002896FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.CardRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardRoleId);
			}
			if (this.CardGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060115D1 RID: 71121 RVA: 0x0028B56C File Offset: 0x0028976C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.CardRoleId != 0)
			{
				this.CardRoleId = other.CardRoleId;
			}
			if (other.CardGroupIndex != 0)
			{
				this.CardGroupIndex = other.CardGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060115D2 RID: 71122 RVA: 0x0028B5D0 File Offset: 0x002897D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060115D3 RID: 71123 RVA: 0x0028B5DC File Offset: 0x002897DC
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
							this.CardGroupIndex = input.ReadInt32();
						}
					}
					else
					{
						this.CardRoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006DB2 RID: 28082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DB3 RID: 28083
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04006DB4 RID: 28084
		private int challengeId_;

		// Token: 0x04006DB5 RID: 28085
		public const int CardRoleIdFieldNumber = 2;

		// Token: 0x04006DB6 RID: 28086
		private int cardRoleId_;

		// Token: 0x04006DB7 RID: 28087
		public const int CardGroupIndexFieldNumber = 3;

		// Token: 0x04006DB8 RID: 28088
		private int cardGroupIndex_;
	}
}
