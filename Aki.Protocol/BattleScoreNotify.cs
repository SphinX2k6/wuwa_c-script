using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017F RID: 383
	[NetMessage(EMessageId.BattleScoreNotify)]
	public sealed class BattleScoreNotify : IMessage<BattleScoreNotify>, IMessage, IEquatable<BattleScoreNotify>, IDeepCloneable<BattleScoreNotify>, IBufferMessage
	{
		// Token: 0x06002EAC RID: 11948 RVA: 0x000785A0 File Offset: 0x000767A0
		[NullableContext(1)]
		public static BattleScoreNotify Create()
		{
			return new BattleScoreNotify();
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000785A7 File Offset: 0x000767A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000785AA File Offset: 0x000767AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleScoreNotify.Descriptor;
			}
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x000785B1 File Offset: 0x000767B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreNotify()
		{
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x000785B9 File Offset: 0x000767B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreNotify(BattleScoreNotify other) : this()
		{
			this.battleScoreConfId_ = other.battleScoreConfId_;
			this.scoreTotal_ = other.scoreTotal_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x000785EA File Offset: 0x000767EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleScoreNotify Clone()
		{
			return new BattleScoreNotify(this);
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x000785F2 File Offset: 0x000767F2
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x000785FA File Offset: 0x000767FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BattleScoreConfId
		{
			get
			{
				return this.battleScoreConfId_;
			}
			set
			{
				this.battleScoreConfId_ = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x00078603 File Offset: 0x00076803
		// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x0007860B File Offset: 0x0007680B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreTotal
		{
			get
			{
				return this.scoreTotal_;
			}
			set
			{
				this.scoreTotal_ = value;
			}
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00078614 File Offset: 0x00076814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleScoreNotify);
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00078622 File Offset: 0x00076822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleScoreNotify other)
		{
			return other != null && (other == this || (this.BattleScoreConfId == other.BattleScoreConfId && this.ScoreTotal == other.ScoreTotal && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00078660 File Offset: 0x00076860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BattleScoreConfId != 0)
			{
				num ^= this.BattleScoreConfId.GetHashCode();
			}
			if (this.ScoreTotal != 0)
			{
				num ^= this.ScoreTotal.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x000786B8 File Offset: 0x000768B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x000786C5 File Offset: 0x000768C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x000786D0 File Offset: 0x000768D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreTotal != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ScoreTotal);
			}
			if (this.BattleScoreConfId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BattleScoreConfId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x0007872C File Offset: 0x0007692C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BattleScoreConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleScoreConfId);
			}
			if (this.ScoreTotal != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreTotal);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00078784 File Offset: 0x00076984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleScoreNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BattleScoreConfId != 0)
			{
				this.BattleScoreConfId = other.BattleScoreConfId;
			}
			if (other.ScoreTotal != 0)
			{
				this.ScoreTotal = other.ScoreTotal;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x000787D4 File Offset: 0x000769D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x000787E0 File Offset: 0x000769E0
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BattleScoreConfId = input.ReadInt32();
					}
				}
				else
				{
					this.ScoreTotal = input.ReadInt32();
				}
			}
		}

		// Token: 0x040028DA RID: 10458
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028DB RID: 10459
		public const int BattleScoreConfIdFieldNumber = 9;

		// Token: 0x040028DC RID: 10460
		private int battleScoreConfId_;

		// Token: 0x040028DD RID: 10461
		public const int ScoreTotalFieldNumber = 2;

		// Token: 0x040028DE RID: 10462
		private int scoreTotal_;
	}
}
