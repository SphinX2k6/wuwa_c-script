using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ABA RID: 2746
	[NetMessage(EMessageId.MowTowerFirstScoreNotify)]
	public sealed class MowTowerFirstScoreNotify : IMessage<MowTowerFirstScoreNotify>, IMessage, IEquatable<MowTowerFirstScoreNotify>, IDeepCloneable<MowTowerFirstScoreNotify>, IBufferMessage
	{
		// Token: 0x0600EF73 RID: 61299 RVA: 0x0023028B File Offset: 0x0022E48B
		[NullableContext(1)]
		public static MowTowerFirstScoreNotify Create()
		{
			return new MowTowerFirstScoreNotify();
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x0600EF74 RID: 61300 RVA: 0x00230292 File Offset: 0x0022E492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x0600EF75 RID: 61301 RVA: 0x00230295 File Offset: 0x0022E495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerFirstScoreNotify.Descriptor;
			}
		}

		// Token: 0x0600EF76 RID: 61302 RVA: 0x0023029C File Offset: 0x0022E49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerFirstScoreNotify()
		{
		}

		// Token: 0x0600EF77 RID: 61303 RVA: 0x002302A4 File Offset: 0x0022E4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerFirstScoreNotify(MowTowerFirstScoreNotify other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.firstKilMonsterScore_ = other.firstKilMonsterScore_;
			this.firstTimerScore_ = other.firstTimerScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF78 RID: 61304 RVA: 0x002302E1 File Offset: 0x0022E4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerFirstScoreNotify Clone()
		{
			return new MowTowerFirstScoreNotify(this);
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x0600EF79 RID: 61305 RVA: 0x002302E9 File Offset: 0x0022E4E9
		// (set) Token: 0x0600EF7A RID: 61306 RVA: 0x002302F1 File Offset: 0x0022E4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelsId
		{
			get
			{
				return this.levelsId_;
			}
			set
			{
				this.levelsId_ = value;
			}
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x0600EF7B RID: 61307 RVA: 0x002302FA File Offset: 0x0022E4FA
		// (set) Token: 0x0600EF7C RID: 61308 RVA: 0x00230302 File Offset: 0x0022E502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstKilMonsterScore
		{
			get
			{
				return this.firstKilMonsterScore_;
			}
			set
			{
				this.firstKilMonsterScore_ = value;
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x0600EF7D RID: 61309 RVA: 0x0023030B File Offset: 0x0022E50B
		// (set) Token: 0x0600EF7E RID: 61310 RVA: 0x00230313 File Offset: 0x0022E513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstTimerScore
		{
			get
			{
				return this.firstTimerScore_;
			}
			set
			{
				this.firstTimerScore_ = value;
			}
		}

		// Token: 0x0600EF7F RID: 61311 RVA: 0x0023031C File Offset: 0x0022E51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerFirstScoreNotify);
		}

		// Token: 0x0600EF80 RID: 61312 RVA: 0x0023032C File Offset: 0x0022E52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerFirstScoreNotify other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.FirstKilMonsterScore == other.FirstKilMonsterScore && this.FirstTimerScore == other.FirstTimerScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF81 RID: 61313 RVA: 0x00230388 File Offset: 0x0022E588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			if (this.FirstKilMonsterScore != 0)
			{
				num ^= this.FirstKilMonsterScore.GetHashCode();
			}
			if (this.FirstTimerScore != 0)
			{
				num ^= this.FirstTimerScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EF82 RID: 61314 RVA: 0x002303F9 File Offset: 0x0022E5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF83 RID: 61315 RVA: 0x00230406 File Offset: 0x0022E606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF84 RID: 61316 RVA: 0x00230410 File Offset: 0x0022E610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelsId);
			}
			if (this.FirstKilMonsterScore != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FirstKilMonsterScore);
			}
			if (this.FirstTimerScore != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FirstTimerScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EF85 RID: 61317 RVA: 0x00230484 File Offset: 0x0022E684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			if (this.FirstKilMonsterScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstKilMonsterScore);
			}
			if (this.FirstTimerScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstTimerScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EF86 RID: 61318 RVA: 0x002304F4 File Offset: 0x0022E6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerFirstScoreNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			if (other.FirstKilMonsterScore != 0)
			{
				this.FirstKilMonsterScore = other.FirstKilMonsterScore;
			}
			if (other.FirstTimerScore != 0)
			{
				this.FirstTimerScore = other.FirstTimerScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EF87 RID: 61319 RVA: 0x00230558 File Offset: 0x0022E758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF88 RID: 61320 RVA: 0x00230564 File Offset: 0x0022E764
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
					if (num != 32U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FirstTimerScore = input.ReadInt32();
						}
					}
					else
					{
						this.FirstKilMonsterScore = input.ReadInt32();
					}
				}
				else
				{
					this.LevelsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006145 RID: 24901
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006146 RID: 24902
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x04006147 RID: 24903
		private int levelsId_;

		// Token: 0x04006148 RID: 24904
		public const int FirstKilMonsterScoreFieldNumber = 4;

		// Token: 0x04006149 RID: 24905
		private int firstKilMonsterScore_;

		// Token: 0x0400614A RID: 24906
		public const int FirstTimerScoreFieldNumber = 8;

		// Token: 0x0400614B RID: 24907
		private int firstTimerScore_;
	}
}
