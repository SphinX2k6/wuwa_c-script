using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEB RID: 4075
	[NetMessage(EMessageId.RogueResInstGlobalDataNotify)]
	public sealed class RogueResInstGlobalDataNotify : IMessage<RogueResInstGlobalDataNotify>, IMessage, IEquatable<RogueResInstGlobalDataNotify>, IDeepCloneable<RogueResInstGlobalDataNotify>, IBufferMessage
	{
		// Token: 0x06015C7D RID: 89213 RVA: 0x00329967 File Offset: 0x00327B67
		[NullableContext(1)]
		public static RogueResInstGlobalDataNotify Create()
		{
			return new RogueResInstGlobalDataNotify();
		}

		// Token: 0x170048AF RID: 18607
		// (get) Token: 0x06015C7E RID: 89214 RVA: 0x0032996E File Offset: 0x00327B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048B0 RID: 18608
		// (get) Token: 0x06015C7F RID: 89215 RVA: 0x00329971 File Offset: 0x00327B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResInstGlobalDataNotify.Descriptor;
			}
		}

		// Token: 0x06015C80 RID: 89216 RVA: 0x00329978 File Offset: 0x00327B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstGlobalDataNotify()
		{
		}

		// Token: 0x06015C81 RID: 89217 RVA: 0x00329998 File Offset: 0x00327B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstGlobalDataNotify(RogueResInstGlobalDataNotify other) : this()
		{
			this.instId_ = other.instId_;
			this.randomSeedId_ = other.randomSeedId_;
			this.rogueResGridDatas_ = other.rogueResGridDatas_.Clone();
			this.index_ = other.index_;
			this.inBattle_ = other.inBattle_;
			this.fov_ = other.fov_;
			this.mood_ = other.mood_;
			this.moodRuleId_ = other.moodRuleId_;
			this.roleMaxStar_ = other.roleMaxStar_;
			this.roleLevel_ = other.roleLevel_;
			this.goldItem_ = other.goldItem_;
			this.columns_ = other.columns_;
			this.rows_ = other.rows_;
			this.showType_ = other.showType_;
			this.maxMood_ = other.maxMood_;
			this.minMood_ = other.minMood_;
			this.teamLevel_ = other.teamLevel_;
			this.rogueResFormations_ = other.rogueResFormations_.Clone();
			this.rogueResOpDataNotify_ = ((other.rogueResOpDataNotify_ != null) ? other.rogueResOpDataNotify_.Clone() : null);
			this.rogueResInstOptionsNotify_ = ((other.rogueResInstOptionsNotify_ != null) ? other.rogueResInstOptionsNotify_.Clone() : null);
			this.rogueResGainDataTotalNotify_ = ((other.rogueResGainDataTotalNotify_ != null) ? other.rogueResGainDataTotalNotify_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C82 RID: 89218 RVA: 0x00329AF2 File Offset: 0x00327CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstGlobalDataNotify Clone()
		{
			return new RogueResInstGlobalDataNotify(this);
		}

		// Token: 0x170048B1 RID: 18609
		// (get) Token: 0x06015C83 RID: 89219 RVA: 0x00329AFA File Offset: 0x00327CFA
		// (set) Token: 0x06015C84 RID: 89220 RVA: 0x00329B02 File Offset: 0x00327D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x06015C85 RID: 89221 RVA: 0x00329B0B File Offset: 0x00327D0B
		// (set) Token: 0x06015C86 RID: 89222 RVA: 0x00329B13 File Offset: 0x00327D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RandomSeedId
		{
			get
			{
				return this.randomSeedId_;
			}
			set
			{
				this.randomSeedId_ = value;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x06015C87 RID: 89223 RVA: 0x00329B1C File Offset: 0x00327D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResGridData> RogueResGridDatas
		{
			get
			{
				return this.rogueResGridDatas_;
			}
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x06015C88 RID: 89224 RVA: 0x00329B24 File Offset: 0x00327D24
		// (set) Token: 0x06015C89 RID: 89225 RVA: 0x00329B2C File Offset: 0x00327D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x06015C8A RID: 89226 RVA: 0x00329B35 File Offset: 0x00327D35
		// (set) Token: 0x06015C8B RID: 89227 RVA: 0x00329B3D File Offset: 0x00327D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool InBattle
		{
			get
			{
				return this.inBattle_;
			}
			set
			{
				this.inBattle_ = value;
			}
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x06015C8C RID: 89228 RVA: 0x00329B46 File Offset: 0x00327D46
		// (set) Token: 0x06015C8D RID: 89229 RVA: 0x00329B4E File Offset: 0x00327D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Fov
		{
			get
			{
				return this.fov_;
			}
			set
			{
				this.fov_ = value;
			}
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x06015C8E RID: 89230 RVA: 0x00329B57 File Offset: 0x00327D57
		// (set) Token: 0x06015C8F RID: 89231 RVA: 0x00329B5F File Offset: 0x00327D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Mood
		{
			get
			{
				return this.mood_;
			}
			set
			{
				this.mood_ = value;
			}
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x06015C90 RID: 89232 RVA: 0x00329B68 File Offset: 0x00327D68
		// (set) Token: 0x06015C91 RID: 89233 RVA: 0x00329B70 File Offset: 0x00327D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoodRuleId
		{
			get
			{
				return this.moodRuleId_;
			}
			set
			{
				this.moodRuleId_ = value;
			}
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x06015C92 RID: 89234 RVA: 0x00329B79 File Offset: 0x00327D79
		// (set) Token: 0x06015C93 RID: 89235 RVA: 0x00329B81 File Offset: 0x00327D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleMaxStar
		{
			get
			{
				return this.roleMaxStar_;
			}
			set
			{
				this.roleMaxStar_ = value;
			}
		}

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x06015C94 RID: 89236 RVA: 0x00329B8A File Offset: 0x00327D8A
		// (set) Token: 0x06015C95 RID: 89237 RVA: 0x00329B92 File Offset: 0x00327D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x06015C96 RID: 89238 RVA: 0x00329B9B File Offset: 0x00327D9B
		// (set) Token: 0x06015C97 RID: 89239 RVA: 0x00329BA3 File Offset: 0x00327DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoldItem
		{
			get
			{
				return this.goldItem_;
			}
			set
			{
				this.goldItem_ = value;
			}
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x06015C98 RID: 89240 RVA: 0x00329BAC File Offset: 0x00327DAC
		// (set) Token: 0x06015C99 RID: 89241 RVA: 0x00329BB4 File Offset: 0x00327DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Columns
		{
			get
			{
				return this.columns_;
			}
			set
			{
				this.columns_ = value;
			}
		}

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x06015C9A RID: 89242 RVA: 0x00329BBD File Offset: 0x00327DBD
		// (set) Token: 0x06015C9B RID: 89243 RVA: 0x00329BC5 File Offset: 0x00327DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rows
		{
			get
			{
				return this.rows_;
			}
			set
			{
				this.rows_ = value;
			}
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x06015C9C RID: 89244 RVA: 0x00329BCE File Offset: 0x00327DCE
		// (set) Token: 0x06015C9D RID: 89245 RVA: 0x00329BD6 File Offset: 0x00327DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowType
		{
			get
			{
				return this.showType_;
			}
			set
			{
				this.showType_ = value;
			}
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x06015C9E RID: 89246 RVA: 0x00329BDF File Offset: 0x00327DDF
		// (set) Token: 0x06015C9F RID: 89247 RVA: 0x00329BE7 File Offset: 0x00327DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxMood
		{
			get
			{
				return this.maxMood_;
			}
			set
			{
				this.maxMood_ = value;
			}
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x06015CA0 RID: 89248 RVA: 0x00329BF0 File Offset: 0x00327DF0
		// (set) Token: 0x06015CA1 RID: 89249 RVA: 0x00329BF8 File Offset: 0x00327DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinMood
		{
			get
			{
				return this.minMood_;
			}
			set
			{
				this.minMood_ = value;
			}
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x06015CA2 RID: 89250 RVA: 0x00329C01 File Offset: 0x00327E01
		// (set) Token: 0x06015CA3 RID: 89251 RVA: 0x00329C09 File Offset: 0x00327E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeamLevel
		{
			get
			{
				return this.teamLevel_;
			}
			set
			{
				this.teamLevel_ = value;
			}
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x06015CA4 RID: 89252 RVA: 0x00329C12 File Offset: 0x00327E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResFormation> RogueResFormations
		{
			get
			{
				return this.rogueResFormations_;
			}
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x06015CA5 RID: 89253 RVA: 0x00329C1A File Offset: 0x00327E1A
		// (set) Token: 0x06015CA6 RID: 89254 RVA: 0x00329C22 File Offset: 0x00327E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDataNotify RogueResOpDataNotify
		{
			get
			{
				return this.rogueResOpDataNotify_;
			}
			set
			{
				this.rogueResOpDataNotify_ = value;
			}
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x06015CA7 RID: 89255 RVA: 0x00329C2B File Offset: 0x00327E2B
		// (set) Token: 0x06015CA8 RID: 89256 RVA: 0x00329C33 File Offset: 0x00327E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResInstOptionsNotify RogueResInstOptionsNotify
		{
			get
			{
				return this.rogueResInstOptionsNotify_;
			}
			set
			{
				this.rogueResInstOptionsNotify_ = value;
			}
		}

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x06015CA9 RID: 89257 RVA: 0x00329C3C File Offset: 0x00327E3C
		// (set) Token: 0x06015CAA RID: 89258 RVA: 0x00329C44 File Offset: 0x00327E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGainDataTotalNotify RogueResGainDataTotalNotify
		{
			get
			{
				return this.rogueResGainDataTotalNotify_;
			}
			set
			{
				this.rogueResGainDataTotalNotify_ = value;
			}
		}

		// Token: 0x06015CAB RID: 89259 RVA: 0x00329C4D File Offset: 0x00327E4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResInstGlobalDataNotify);
		}

		// Token: 0x06015CAC RID: 89260 RVA: 0x00329C5C File Offset: 0x00327E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResInstGlobalDataNotify other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.RandomSeedId == other.RandomSeedId && this.rogueResGridDatas_.Equals(other.rogueResGridDatas_) && this.Index == other.Index && this.InBattle == other.InBattle && this.Fov == other.Fov && this.Mood == other.Mood && this.MoodRuleId == other.MoodRuleId && this.RoleMaxStar == other.RoleMaxStar && this.RoleLevel == other.RoleLevel && this.GoldItem == other.GoldItem && this.Columns == other.Columns && this.Rows == other.Rows && this.ShowType == other.ShowType && this.MaxMood == other.MaxMood && this.MinMood == other.MinMood && this.TeamLevel == other.TeamLevel && this.rogueResFormations_.Equals(other.rogueResFormations_) && object.Equals(this.RogueResOpDataNotify, other.RogueResOpDataNotify) && object.Equals(this.RogueResInstOptionsNotify, other.RogueResInstOptionsNotify) && object.Equals(this.RogueResGainDataTotalNotify, other.RogueResGainDataTotalNotify) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015CAD RID: 89261 RVA: 0x00329DF0 File Offset: 0x00327FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.RandomSeedId != 0)
			{
				num ^= this.RandomSeedId.GetHashCode();
			}
			num ^= this.rogueResGridDatas_.GetHashCode();
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.InBattle)
			{
				num ^= this.InBattle.GetHashCode();
			}
			if (this.Fov != 0)
			{
				num ^= this.Fov.GetHashCode();
			}
			if (this.Mood != 0)
			{
				num ^= this.Mood.GetHashCode();
			}
			if (this.MoodRuleId != 0)
			{
				num ^= this.MoodRuleId.GetHashCode();
			}
			if (this.RoleMaxStar != 0)
			{
				num ^= this.RoleMaxStar.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.GoldItem != 0)
			{
				num ^= this.GoldItem.GetHashCode();
			}
			if (this.Columns != 0)
			{
				num ^= this.Columns.GetHashCode();
			}
			if (this.Rows != 0)
			{
				num ^= this.Rows.GetHashCode();
			}
			if (this.ShowType != 0)
			{
				num ^= this.ShowType.GetHashCode();
			}
			if (this.MaxMood != 0)
			{
				num ^= this.MaxMood.GetHashCode();
			}
			if (this.MinMood != 0)
			{
				num ^= this.MinMood.GetHashCode();
			}
			if (this.TeamLevel != 0)
			{
				num ^= this.TeamLevel.GetHashCode();
			}
			num ^= this.rogueResFormations_.GetHashCode();
			if (this.rogueResOpDataNotify_ != null)
			{
				num ^= this.RogueResOpDataNotify.GetHashCode();
			}
			if (this.rogueResInstOptionsNotify_ != null)
			{
				num ^= this.RogueResInstOptionsNotify.GetHashCode();
			}
			if (this.rogueResGainDataTotalNotify_ != null)
			{
				num ^= this.RogueResGainDataTotalNotify.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015CAE RID: 89262 RVA: 0x0032A004 File Offset: 0x00328204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015CAF RID: 89263 RVA: 0x0032A011 File Offset: 0x00328211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015CB0 RID: 89264 RVA: 0x0032A01C File Offset: 0x0032821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResGainDataTotalNotify_ != null)
			{
				output.WriteRawTag(202, 1);
				output.WriteMessage(this.RogueResGainDataTotalNotify);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(160, 2);
				output.WriteInt32(this.InstId);
			}
			this.rogueResGridDatas_.WriteTo(ref output, RogueResInstGlobalDataNotify._repeated_rogueResGridDatas_codec);
			if (this.rogueResOpDataNotify_ != null)
			{
				output.WriteRawTag(234, 2);
				output.WriteMessage(this.RogueResOpDataNotify);
			}
			if (this.Rows != 0)
			{
				output.WriteRawTag(240, 3);
				output.WriteInt32(this.Rows);
			}
			if (this.ShowType != 0)
			{
				output.WriteRawTag(152, 4);
				output.WriteInt32(this.ShowType);
			}
			if (this.Fov != 0)
			{
				output.WriteRawTag(176, 4);
				output.WriteInt32(this.Fov);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(200, 5);
				output.WriteInt32(this.Index);
			}
			if (this.RandomSeedId != 0)
			{
				output.WriteRawTag(128, 6);
				output.WriteInt32(this.RandomSeedId);
			}
			if (this.MoodRuleId != 0)
			{
				output.WriteRawTag(216, 7);
				output.WriteInt32(this.MoodRuleId);
			}
			if (this.RoleMaxStar != 0)
			{
				output.WriteRawTag(176, 9);
				output.WriteInt32(this.RoleMaxStar);
			}
			if (this.rogueResInstOptionsNotify_ != null)
			{
				output.WriteRawTag(162, 10);
				output.WriteMessage(this.RogueResInstOptionsNotify);
			}
			if (this.MaxMood != 0)
			{
				output.WriteRawTag(136, 11);
				output.WriteInt32(this.MaxMood);
			}
			if (this.GoldItem != 0)
			{
				output.WriteRawTag(184, 11);
				output.WriteInt32(this.GoldItem);
			}
			this.rogueResFormations_.WriteTo(ref output, RogueResInstGlobalDataNotify._repeated_rogueResFormations_codec);
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(128, 12);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.InBattle)
			{
				output.WriteRawTag(144, 12);
				output.WriteBool(this.InBattle);
			}
			if (this.MinMood != 0)
			{
				output.WriteRawTag(240, 12);
				output.WriteInt32(this.MinMood);
			}
			if (this.TeamLevel != 0)
			{
				output.WriteRawTag(200, 13);
				output.WriteInt32(this.TeamLevel);
			}
			if (this.Columns != 0)
			{
				output.WriteRawTag(240, 13);
				output.WriteInt32(this.Columns);
			}
			if (this.Mood != 0)
			{
				output.WriteRawTag(200, 15);
				output.WriteInt32(this.Mood);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015CB1 RID: 89265 RVA: 0x0032A2CC File Offset: 0x003284CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.RandomSeedId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RandomSeedId);
			}
			num += this.rogueResGridDatas_.CalculateSize(RogueResInstGlobalDataNotify._repeated_rogueResGridDatas_codec);
			if (this.Index != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.InBattle)
			{
				num += 3;
			}
			if (this.Fov != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Fov);
			}
			if (this.Mood != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Mood);
			}
			if (this.MoodRuleId != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MoodRuleId);
			}
			if (this.RoleMaxStar != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoleMaxStar);
			}
			if (this.RoleLevel != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.GoldItem != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.GoldItem);
			}
			if (this.Columns != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Columns);
			}
			if (this.Rows != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.Rows);
			}
			if (this.ShowType != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.ShowType);
			}
			if (this.MaxMood != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MaxMood);
			}
			if (this.MinMood != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.MinMood);
			}
			if (this.TeamLevel != 0)
			{
				num += 2 + CodedOutputStream.ComputeInt32Size(this.TeamLevel);
			}
			num += this.rogueResFormations_.CalculateSize(RogueResInstGlobalDataNotify._repeated_rogueResFormations_codec);
			if (this.rogueResOpDataNotify_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueResOpDataNotify);
			}
			if (this.rogueResInstOptionsNotify_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueResInstOptionsNotify);
			}
			if (this.rogueResGainDataTotalNotify_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueResGainDataTotalNotify);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015CB2 RID: 89266 RVA: 0x0032A4D4 File Offset: 0x003286D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResInstGlobalDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.RandomSeedId != 0)
			{
				this.RandomSeedId = other.RandomSeedId;
			}
			this.rogueResGridDatas_.Add(other.rogueResGridDatas_);
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.InBattle)
			{
				this.InBattle = other.InBattle;
			}
			if (other.Fov != 0)
			{
				this.Fov = other.Fov;
			}
			if (other.Mood != 0)
			{
				this.Mood = other.Mood;
			}
			if (other.MoodRuleId != 0)
			{
				this.MoodRuleId = other.MoodRuleId;
			}
			if (other.RoleMaxStar != 0)
			{
				this.RoleMaxStar = other.RoleMaxStar;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.GoldItem != 0)
			{
				this.GoldItem = other.GoldItem;
			}
			if (other.Columns != 0)
			{
				this.Columns = other.Columns;
			}
			if (other.Rows != 0)
			{
				this.Rows = other.Rows;
			}
			if (other.ShowType != 0)
			{
				this.ShowType = other.ShowType;
			}
			if (other.MaxMood != 0)
			{
				this.MaxMood = other.MaxMood;
			}
			if (other.MinMood != 0)
			{
				this.MinMood = other.MinMood;
			}
			if (other.TeamLevel != 0)
			{
				this.TeamLevel = other.TeamLevel;
			}
			this.rogueResFormations_.Add(other.rogueResFormations_);
			if (other.rogueResOpDataNotify_ != null)
			{
				if (this.rogueResOpDataNotify_ == null)
				{
					this.RogueResOpDataNotify = new RogueResOpDataNotify();
				}
				this.RogueResOpDataNotify.MergeFrom(other.RogueResOpDataNotify);
			}
			if (other.rogueResInstOptionsNotify_ != null)
			{
				if (this.rogueResInstOptionsNotify_ == null)
				{
					this.RogueResInstOptionsNotify = new RogueResInstOptionsNotify();
				}
				this.RogueResInstOptionsNotify.MergeFrom(other.RogueResInstOptionsNotify);
			}
			if (other.rogueResGainDataTotalNotify_ != null)
			{
				if (this.rogueResGainDataTotalNotify_ == null)
				{
					this.RogueResGainDataTotalNotify = new RogueResGainDataTotalNotify();
				}
				this.RogueResGainDataTotalNotify.MergeFrom(other.RogueResGainDataTotalNotify);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015CB3 RID: 89267 RVA: 0x0032A6E2 File Offset: 0x003288E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015CB4 RID: 89268 RVA: 0x0032A6EC File Offset: 0x003288EC
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
				if (num <= 984U)
				{
					if (num <= 496U)
					{
						if (num <= 288U)
						{
							if (num == 202U)
							{
								if (this.rogueResGainDataTotalNotify_ == null)
								{
									this.RogueResGainDataTotalNotify = new RogueResGainDataTotalNotify();
								}
								input.ReadMessage(this.RogueResGainDataTotalNotify);
								continue;
							}
							if (num == 288U)
							{
								this.InstId = input.ReadInt32();
								continue;
							}
						}
						else
						{
							if (num == 330U)
							{
								this.rogueResGridDatas_.AddEntriesFrom(ref input, RogueResInstGlobalDataNotify._repeated_rogueResGridDatas_codec);
								continue;
							}
							if (num == 362U)
							{
								if (this.rogueResOpDataNotify_ == null)
								{
									this.RogueResOpDataNotify = new RogueResOpDataNotify();
								}
								input.ReadMessage(this.RogueResOpDataNotify);
								continue;
							}
							if (num == 496U)
							{
								this.Rows = input.ReadInt32();
								continue;
							}
						}
					}
					else if (num <= 560U)
					{
						if (num == 536U)
						{
							this.ShowType = input.ReadInt32();
							continue;
						}
						if (num == 560U)
						{
							this.Fov = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 712U)
						{
							this.Index = input.ReadInt32();
							continue;
						}
						if (num == 768U)
						{
							this.RandomSeedId = input.ReadInt32();
							continue;
						}
						if (num == 984U)
						{
							this.MoodRuleId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 1514U)
				{
					if (num <= 1314U)
					{
						if (num == 1200U)
						{
							this.RoleMaxStar = input.ReadInt32();
							continue;
						}
						if (num == 1314U)
						{
							if (this.rogueResInstOptionsNotify_ == null)
							{
								this.RogueResInstOptionsNotify = new RogueResInstOptionsNotify();
							}
							input.ReadMessage(this.RogueResInstOptionsNotify);
							continue;
						}
					}
					else
					{
						if (num == 1416U)
						{
							this.MaxMood = input.ReadInt32();
							continue;
						}
						if (num == 1464U)
						{
							this.GoldItem = input.ReadInt32();
							continue;
						}
						if (num == 1514U)
						{
							this.rogueResFormations_.AddEntriesFrom(ref input, RogueResInstGlobalDataNotify._repeated_rogueResFormations_codec);
							continue;
						}
					}
				}
				else if (num <= 1648U)
				{
					if (num == 1536U)
					{
						this.RoleLevel = input.ReadInt32();
						continue;
					}
					if (num == 1552U)
					{
						this.InBattle = input.ReadBool();
						continue;
					}
					if (num == 1648U)
					{
						this.MinMood = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 1736U)
					{
						this.TeamLevel = input.ReadInt32();
						continue;
					}
					if (num == 1776U)
					{
						this.Columns = input.ReadInt32();
						continue;
					}
					if (num == 1992U)
					{
						this.Mood = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040082AE RID: 33454
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082AF RID: 33455
		public const int InstIdFieldNumber = 36;

		// Token: 0x040082B0 RID: 33456
		private int instId_;

		// Token: 0x040082B1 RID: 33457
		public const int RandomSeedIdFieldNumber = 96;

		// Token: 0x040082B2 RID: 33458
		private int randomSeedId_;

		// Token: 0x040082B3 RID: 33459
		public const int RogueResGridDatasFieldNumber = 41;

		// Token: 0x040082B4 RID: 33460
		private static readonly FieldCodec<RogueResGridData> _repeated_rogueResGridDatas_codec = FieldCodec.ForMessage<RogueResGridData>(330U, RogueResGridData.Parser);

		// Token: 0x040082B5 RID: 33461
		private readonly RepeatedField<RogueResGridData> rogueResGridDatas_ = new RepeatedField<RogueResGridData>();

		// Token: 0x040082B6 RID: 33462
		public const int IndexFieldNumber = 89;

		// Token: 0x040082B7 RID: 33463
		private int index_;

		// Token: 0x040082B8 RID: 33464
		public const int InBattleFieldNumber = 194;

		// Token: 0x040082B9 RID: 33465
		private bool inBattle_;

		// Token: 0x040082BA RID: 33466
		public const int FovFieldNumber = 70;

		// Token: 0x040082BB RID: 33467
		private int fov_;

		// Token: 0x040082BC RID: 33468
		public const int MoodFieldNumber = 249;

		// Token: 0x040082BD RID: 33469
		private int mood_;

		// Token: 0x040082BE RID: 33470
		public const int MoodRuleIdFieldNumber = 123;

		// Token: 0x040082BF RID: 33471
		private int moodRuleId_;

		// Token: 0x040082C0 RID: 33472
		public const int RoleMaxStarFieldNumber = 150;

		// Token: 0x040082C1 RID: 33473
		private int roleMaxStar_;

		// Token: 0x040082C2 RID: 33474
		public const int RoleLevelFieldNumber = 192;

		// Token: 0x040082C3 RID: 33475
		private int roleLevel_;

		// Token: 0x040082C4 RID: 33476
		public const int GoldItemFieldNumber = 183;

		// Token: 0x040082C5 RID: 33477
		private int goldItem_;

		// Token: 0x040082C6 RID: 33478
		public const int ColumnsFieldNumber = 222;

		// Token: 0x040082C7 RID: 33479
		private int columns_;

		// Token: 0x040082C8 RID: 33480
		public const int RowsFieldNumber = 62;

		// Token: 0x040082C9 RID: 33481
		private int rows_;

		// Token: 0x040082CA RID: 33482
		public const int ShowTypeFieldNumber = 67;

		// Token: 0x040082CB RID: 33483
		private int showType_;

		// Token: 0x040082CC RID: 33484
		public const int MaxMoodFieldNumber = 177;

		// Token: 0x040082CD RID: 33485
		private int maxMood_;

		// Token: 0x040082CE RID: 33486
		public const int MinMoodFieldNumber = 206;

		// Token: 0x040082CF RID: 33487
		private int minMood_;

		// Token: 0x040082D0 RID: 33488
		public const int TeamLevelFieldNumber = 217;

		// Token: 0x040082D1 RID: 33489
		private int teamLevel_;

		// Token: 0x040082D2 RID: 33490
		public const int RogueResFormationsFieldNumber = 189;

		// Token: 0x040082D3 RID: 33491
		private static readonly FieldCodec<RogueResFormation> _repeated_rogueResFormations_codec = FieldCodec.ForMessage<RogueResFormation>(1514U, RogueResFormation.Parser);

		// Token: 0x040082D4 RID: 33492
		private readonly RepeatedField<RogueResFormation> rogueResFormations_ = new RepeatedField<RogueResFormation>();

		// Token: 0x040082D5 RID: 33493
		public const int RogueResOpDataNotifyFieldNumber = 45;

		// Token: 0x040082D6 RID: 33494
		private RogueResOpDataNotify rogueResOpDataNotify_;

		// Token: 0x040082D7 RID: 33495
		public const int RogueResInstOptionsNotifyFieldNumber = 164;

		// Token: 0x040082D8 RID: 33496
		private RogueResInstOptionsNotify rogueResInstOptionsNotify_;

		// Token: 0x040082D9 RID: 33497
		public const int RogueResGainDataTotalNotifyFieldNumber = 25;

		// Token: 0x040082DA RID: 33498
		private RogueResGainDataTotalNotify rogueResGainDataTotalNotify_;
	}
}
