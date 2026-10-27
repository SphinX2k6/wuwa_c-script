using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACB RID: 2763
	[NetMessage(EMessageId.MowTowerFirstScoreNotify)]
	public sealed class MowTowerFirstScoreNotify : IMessage<MowTowerFirstScoreNotify>, IMessage, IEquatable<MowTowerFirstScoreNotify>, IDeepCloneable<MowTowerFirstScoreNotify>, IBufferMessage
	{
		// Token: 0x0600F08D RID: 61581 RVA: 0x00232497 File Offset: 0x00230697
		[NullableContext(1)]
		public static MowTowerFirstScoreNotify Create()
		{
			return new MowTowerFirstScoreNotify();
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x0600F08E RID: 61582 RVA: 0x0023249E File Offset: 0x0023069E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0600F08F RID: 61583 RVA: 0x002324A1 File Offset: 0x002306A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerFirstScoreNotify.Descriptor;
			}
		}

		// Token: 0x0600F090 RID: 61584 RVA: 0x002324A8 File Offset: 0x002306A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerFirstScoreNotify()
		{
		}

		// Token: 0x0600F091 RID: 61585 RVA: 0x002324B0 File Offset: 0x002306B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerFirstScoreNotify(MowTowerFirstScoreNotify other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.firstKilMonsterScore_ = other.firstKilMonsterScore_;
			this.firstTimerScore_ = other.firstTimerScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F092 RID: 61586 RVA: 0x002324ED File Offset: 0x002306ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerFirstScoreNotify Clone()
		{
			return new MowTowerFirstScoreNotify(this);
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0600F093 RID: 61587 RVA: 0x002324F5 File Offset: 0x002306F5
		// (set) Token: 0x0600F094 RID: 61588 RVA: 0x002324FD File Offset: 0x002306FD
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

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0600F095 RID: 61589 RVA: 0x00232506 File Offset: 0x00230706
		// (set) Token: 0x0600F096 RID: 61590 RVA: 0x0023250E File Offset: 0x0023070E
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

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0600F097 RID: 61591 RVA: 0x00232517 File Offset: 0x00230717
		// (set) Token: 0x0600F098 RID: 61592 RVA: 0x0023251F File Offset: 0x0023071F
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

		// Token: 0x0600F099 RID: 61593 RVA: 0x00232528 File Offset: 0x00230728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerFirstScoreNotify);
		}

		// Token: 0x0600F09A RID: 61594 RVA: 0x00232538 File Offset: 0x00230738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerFirstScoreNotify other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.FirstKilMonsterScore == other.FirstKilMonsterScore && this.FirstTimerScore == other.FirstTimerScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F09B RID: 61595 RVA: 0x00232594 File Offset: 0x00230794
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

		// Token: 0x0600F09C RID: 61596 RVA: 0x00232605 File Offset: 0x00230805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F09D RID: 61597 RVA: 0x00232612 File Offset: 0x00230812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F09E RID: 61598 RVA: 0x0023261C File Offset: 0x0023081C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LevelsId);
			}
			if (this.FirstKilMonsterScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FirstKilMonsterScore);
			}
			if (this.FirstTimerScore != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FirstTimerScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F09F RID: 61599 RVA: 0x00232694 File Offset: 0x00230894
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

		// Token: 0x0600F0A0 RID: 61600 RVA: 0x00232704 File Offset: 0x00230904
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

		// Token: 0x0600F0A1 RID: 61601 RVA: 0x00232768 File Offset: 0x00230968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0A2 RID: 61602 RVA: 0x00232774 File Offset: 0x00230974
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
					if (num != 40U)
					{
						if (num != 72U)
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

		// Token: 0x0400613C RID: 24892
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400613D RID: 24893
		public const int LevelsIdFieldNumber = 2;

		// Token: 0x0400613E RID: 24894
		private int levelsId_;

		// Token: 0x0400613F RID: 24895
		public const int FirstKilMonsterScoreFieldNumber = 5;

		// Token: 0x04006140 RID: 24896
		private int firstKilMonsterScore_;

		// Token: 0x04006141 RID: 24897
		public const int FirstTimerScoreFieldNumber = 9;

		// Token: 0x04006142 RID: 24898
		private int firstTimerScore_;
	}
}
