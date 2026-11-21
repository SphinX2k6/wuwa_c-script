using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B2E RID: 2862
	public sealed class NewTowerRecommendLevel : IMessage<NewTowerRecommendLevel>, IMessage, IEquatable<NewTowerRecommendLevel>, IDeepCloneable<NewTowerRecommendLevel>, IBufferMessage
	{
		// Token: 0x0600F8B2 RID: 63666 RVA: 0x00244995 File Offset: 0x00242B95
		[NullableContext(1)]
		public static NewTowerRecommendLevel Create()
		{
			return new NewTowerRecommendLevel();
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600F8B3 RID: 63667 RVA: 0x0024499C File Offset: 0x00242B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerRecommendLevel> Parser
		{
			get
			{
				return NewTowerRecommendLevel._parser;
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600F8B4 RID: 63668 RVA: 0x002449A3 File Offset: 0x00242BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600F8B5 RID: 63669 RVA: 0x002449A6 File Offset: 0x00242BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendLevel.Descriptor;
			}
		}

		// Token: 0x0600F8B6 RID: 63670 RVA: 0x002449AD File Offset: 0x00242BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendLevel()
		{
		}

		// Token: 0x0600F8B7 RID: 63671 RVA: 0x002449C0 File Offset: 0x00242BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendLevel(NewTowerRecommendLevel other) : this()
		{
			this.levelId_ = other.levelId_;
			this.recommendId_ = other.recommendId_;
			this.recommendTeams_ = other.recommendTeams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F8B8 RID: 63672 RVA: 0x00244A0D File Offset: 0x00242C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendLevel Clone()
		{
			return new NewTowerRecommendLevel(this);
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600F8B9 RID: 63673 RVA: 0x00244A15 File Offset: 0x00242C15
		// (set) Token: 0x0600F8BA RID: 63674 RVA: 0x00244A1D File Offset: 0x00242C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600F8BB RID: 63675 RVA: 0x00244A26 File Offset: 0x00242C26
		// (set) Token: 0x0600F8BC RID: 63676 RVA: 0x00244A2E File Offset: 0x00242C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecommendId
		{
			get
			{
				return this.recommendId_;
			}
			set
			{
				this.recommendId_ = value;
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600F8BD RID: 63677 RVA: 0x00244A37 File Offset: 0x00242C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerRecommendTeam> RecommendTeams
		{
			get
			{
				return this.recommendTeams_;
			}
		}

		// Token: 0x0600F8BE RID: 63678 RVA: 0x00244A3F File Offset: 0x00242C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendLevel);
		}

		// Token: 0x0600F8BF RID: 63679 RVA: 0x00244A50 File Offset: 0x00242C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendLevel other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.RecommendId == other.RecommendId && this.recommendTeams_.Equals(other.recommendTeams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8C0 RID: 63680 RVA: 0x00244AB0 File Offset: 0x00242CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.RecommendId != 0)
			{
				num ^= this.RecommendId.GetHashCode();
			}
			num ^= this.recommendTeams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F8C1 RID: 63681 RVA: 0x00244B16 File Offset: 0x00242D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8C2 RID: 63682 RVA: 0x00244B23 File Offset: 0x00242D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8C3 RID: 63683 RVA: 0x00244B2C File Offset: 0x00242D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.RecommendId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecommendId);
			}
			this.recommendTeams_.WriteTo(ref output, NewTowerRecommendLevel._repeated_recommendTeams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F8C4 RID: 63684 RVA: 0x00244B98 File Offset: 0x00242D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.RecommendId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecommendId);
			}
			num += this.recommendTeams_.CalculateSize(NewTowerRecommendLevel._repeated_recommendTeams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F8C5 RID: 63685 RVA: 0x00244C04 File Offset: 0x00242E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRecommendLevel other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.RecommendId != 0)
			{
				this.RecommendId = other.RecommendId;
			}
			this.recommendTeams_.Add(other.recommendTeams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F8C6 RID: 63686 RVA: 0x00244C65 File Offset: 0x00242E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F8C7 RID: 63687 RVA: 0x00244C70 File Offset: 0x00242E70
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.recommendTeams_.AddEntriesFrom(ref input, NewTowerRecommendLevel._repeated_recommendTeams_codec);
						}
					}
					else
					{
						this.RecommendId = input.ReadInt32();
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006412 RID: 25618
		private static readonly MessageParser<NewTowerRecommendLevel> _parser = new MessageParser<NewTowerRecommendLevel>(() => new NewTowerRecommendLevel());

		// Token: 0x04006413 RID: 25619
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006414 RID: 25620
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04006415 RID: 25621
		private int levelId_;

		// Token: 0x04006416 RID: 25622
		public const int RecommendIdFieldNumber = 2;

		// Token: 0x04006417 RID: 25623
		private int recommendId_;

		// Token: 0x04006418 RID: 25624
		public const int RecommendTeamsFieldNumber = 3;

		// Token: 0x04006419 RID: 25625
		private static readonly FieldCodec<NewTowerRecommendTeam> _repeated_recommendTeams_codec = FieldCodec.ForMessage<NewTowerRecommendTeam>(26U, NewTowerRecommendTeam.Parser);

		// Token: 0x0400641A RID: 25626
		private readonly RepeatedField<NewTowerRecommendTeam> recommendTeams_ = new RepeatedField<NewTowerRecommendTeam>();
	}
}
