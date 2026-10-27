using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B3F RID: 2879
	public sealed class NewTowerRecommendLevel : IMessage<NewTowerRecommendLevel>, IMessage, IEquatable<NewTowerRecommendLevel>, IDeepCloneable<NewTowerRecommendLevel>, IBufferMessage
	{
		// Token: 0x0600F9CC RID: 63948 RVA: 0x00246BB1 File Offset: 0x00244DB1
		[NullableContext(1)]
		public static NewTowerRecommendLevel Create()
		{
			return new NewTowerRecommendLevel();
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600F9CD RID: 63949 RVA: 0x00246BB8 File Offset: 0x00244DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerRecommendLevel> Parser
		{
			get
			{
				return NewTowerRecommendLevel._parser;
			}
		}

		// Token: 0x170032ED RID: 13037
		// (get) Token: 0x0600F9CE RID: 63950 RVA: 0x00246BBF File Offset: 0x00244DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600F9CF RID: 63951 RVA: 0x00246BC2 File Offset: 0x00244DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendLevel.Descriptor;
			}
		}

		// Token: 0x0600F9D0 RID: 63952 RVA: 0x00246BC9 File Offset: 0x00244DC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendLevel()
		{
		}

		// Token: 0x0600F9D1 RID: 63953 RVA: 0x00246BDC File Offset: 0x00244DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendLevel(NewTowerRecommendLevel other) : this()
		{
			this.levelId_ = other.levelId_;
			this.recommendId_ = other.recommendId_;
			this.recommendTeams_ = other.recommendTeams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F9D2 RID: 63954 RVA: 0x00246C29 File Offset: 0x00244E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendLevel Clone()
		{
			return new NewTowerRecommendLevel(this);
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600F9D3 RID: 63955 RVA: 0x00246C31 File Offset: 0x00244E31
		// (set) Token: 0x0600F9D4 RID: 63956 RVA: 0x00246C39 File Offset: 0x00244E39
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

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600F9D5 RID: 63957 RVA: 0x00246C42 File Offset: 0x00244E42
		// (set) Token: 0x0600F9D6 RID: 63958 RVA: 0x00246C4A File Offset: 0x00244E4A
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

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600F9D7 RID: 63959 RVA: 0x00246C53 File Offset: 0x00244E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTowerRecommendTeam> RecommendTeams
		{
			get
			{
				return this.recommendTeams_;
			}
		}

		// Token: 0x0600F9D8 RID: 63960 RVA: 0x00246C5B File Offset: 0x00244E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendLevel);
		}

		// Token: 0x0600F9D9 RID: 63961 RVA: 0x00246C6C File Offset: 0x00244E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendLevel other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.RecommendId == other.RecommendId && this.recommendTeams_.Equals(other.recommendTeams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F9DA RID: 63962 RVA: 0x00246CCC File Offset: 0x00244ECC
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

		// Token: 0x0600F9DB RID: 63963 RVA: 0x00246D32 File Offset: 0x00244F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9DC RID: 63964 RVA: 0x00246D3F File Offset: 0x00244F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9DD RID: 63965 RVA: 0x00246D48 File Offset: 0x00244F48
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

		// Token: 0x0600F9DE RID: 63966 RVA: 0x00246DB4 File Offset: 0x00244FB4
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

		// Token: 0x0600F9DF RID: 63967 RVA: 0x00246E20 File Offset: 0x00245020
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

		// Token: 0x0600F9E0 RID: 63968 RVA: 0x00246E81 File Offset: 0x00245081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9E1 RID: 63969 RVA: 0x00246E8C File Offset: 0x0024508C
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

		// Token: 0x04006409 RID: 25609
		private static readonly MessageParser<NewTowerRecommendLevel> _parser = new MessageParser<NewTowerRecommendLevel>(() => new NewTowerRecommendLevel());

		// Token: 0x0400640A RID: 25610
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400640B RID: 25611
		public const int LevelIdFieldNumber = 1;

		// Token: 0x0400640C RID: 25612
		private int levelId_;

		// Token: 0x0400640D RID: 25613
		public const int RecommendIdFieldNumber = 2;

		// Token: 0x0400640E RID: 25614
		private int recommendId_;

		// Token: 0x0400640F RID: 25615
		public const int RecommendTeamsFieldNumber = 3;

		// Token: 0x04006410 RID: 25616
		private static readonly FieldCodec<NewTowerRecommendTeam> _repeated_recommendTeams_codec = FieldCodec.ForMessage<NewTowerRecommendTeam>(26U, NewTowerRecommendTeam.Parser);

		// Token: 0x04006411 RID: 25617
		private readonly RepeatedField<NewTowerRecommendTeam> recommendTeams_ = new RepeatedField<NewTowerRecommendTeam>();
	}
}
