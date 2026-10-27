using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7B RID: 3963
	public sealed class RogueArchiveInfo : IMessage<RogueArchiveInfo>, IMessage, IEquatable<RogueArchiveInfo>, IDeepCloneable<RogueArchiveInfo>, IBufferMessage
	{
		// Token: 0x060152F8 RID: 86776 RVA: 0x00312484 File Offset: 0x00310684
		[NullableContext(1)]
		public static RogueArchiveInfo Create()
		{
			return new RogueArchiveInfo();
		}

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x060152F9 RID: 86777 RVA: 0x0031248B File Offset: 0x0031068B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArchiveInfo> Parser
		{
			get
			{
				return RogueArchiveInfo._parser;
			}
		}

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x060152FA RID: 86778 RVA: 0x00312492 File Offset: 0x00310692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x060152FB RID: 86779 RVA: 0x00312495 File Offset: 0x00310695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveInfo.Descriptor;
			}
		}

		// Token: 0x060152FC RID: 86780 RVA: 0x0031249C File Offset: 0x0031069C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveInfo()
		{
		}

		// Token: 0x060152FD RID: 86781 RVA: 0x003124BC File Offset: 0x003106BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveInfo(RogueArchiveInfo other) : this()
		{
			this.slotId_ = other.slotId_;
			this.hasData_ = other.hasData_;
			this.saveTime_ = other.saveTime_;
			this.instId_ = other.instId_;
			this.seasonId_ = other.seasonId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.attributes_ = other.attributes_.Clone();
			this.roguelikeInstInfo_ = ((other.roguelikeInstInfo_ != null) ? other.roguelikeInstInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060152FE RID: 86782 RVA: 0x0031255A File Offset: 0x0031075A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveInfo Clone()
		{
			return new RogueArchiveInfo(this);
		}

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x060152FF RID: 86783 RVA: 0x00312562 File Offset: 0x00310762
		// (set) Token: 0x06015300 RID: 86784 RVA: 0x0031256A File Offset: 0x0031076A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotId
		{
			get
			{
				return this.slotId_;
			}
			set
			{
				this.slotId_ = value;
			}
		}

		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x06015301 RID: 86785 RVA: 0x00312573 File Offset: 0x00310773
		// (set) Token: 0x06015302 RID: 86786 RVA: 0x0031257B File Offset: 0x0031077B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasData
		{
			get
			{
				return this.hasData_;
			}
			set
			{
				this.hasData_ = value;
			}
		}

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x06015303 RID: 86787 RVA: 0x00312584 File Offset: 0x00310784
		// (set) Token: 0x06015304 RID: 86788 RVA: 0x0031258C File Offset: 0x0031078C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SaveTime
		{
			get
			{
				return this.saveTime_;
			}
			set
			{
				this.saveTime_ = value;
			}
		}

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x06015305 RID: 86789 RVA: 0x00312595 File Offset: 0x00310795
		// (set) Token: 0x06015306 RID: 86790 RVA: 0x0031259D File Offset: 0x0031079D
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

		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x06015307 RID: 86791 RVA: 0x003125A6 File Offset: 0x003107A6
		// (set) Token: 0x06015308 RID: 86792 RVA: 0x003125AE File Offset: 0x003107AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x06015309 RID: 86793 RVA: 0x003125B7 File Offset: 0x003107B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x0601530A RID: 86794 RVA: 0x003125BF File Offset: 0x003107BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x0601530B RID: 86795 RVA: 0x003125C7 File Offset: 0x003107C7
		// (set) Token: 0x0601530C RID: 86796 RVA: 0x003125CF File Offset: 0x003107CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo RoguelikeInstInfo
		{
			get
			{
				return this.roguelikeInstInfo_;
			}
			set
			{
				this.roguelikeInstInfo_ = value;
			}
		}

		// Token: 0x0601530D RID: 86797 RVA: 0x003125D8 File Offset: 0x003107D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveInfo);
		}

		// Token: 0x0601530E RID: 86798 RVA: 0x003125E8 File Offset: 0x003107E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveInfo other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.HasData == other.HasData && this.SaveTime == other.SaveTime && this.InstId == other.InstId && this.SeasonId == other.SeasonId && this.roleIds_.Equals(other.roleIds_) && this.Attributes.Equals(other.Attributes) && object.Equals(this.RoguelikeInstInfo, other.RoguelikeInstInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601530F RID: 86799 RVA: 0x003126A0 File Offset: 0x003108A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotId != 0)
			{
				num ^= this.SlotId.GetHashCode();
			}
			if (this.HasData)
			{
				num ^= this.HasData.GetHashCode();
			}
			if (this.SaveTime != 0L)
			{
				num ^= this.SaveTime.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			num ^= this.Attributes.GetHashCode();
			if (this.roguelikeInstInfo_ != null)
			{
				num ^= this.RoguelikeInstInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015310 RID: 86800 RVA: 0x00312775 File Offset: 0x00310975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015311 RID: 86801 RVA: 0x00312782 File Offset: 0x00310982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015312 RID: 86802 RVA: 0x0031278C File Offset: 0x0031098C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SlotId);
			}
			if (this.HasData)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.HasData);
			}
			if (this.SaveTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SaveTime);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SeasonId);
			}
			this.roleIds_.WriteTo(ref output, RogueArchiveInfo._repeated_roleIds_codec);
			this.attributes_.WriteTo(ref output, RogueArchiveInfo._map_attributes_codec);
			if (this.roguelikeInstInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RoguelikeInstInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015313 RID: 86803 RVA: 0x00312878 File Offset: 0x00310A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotId);
			}
			if (this.HasData)
			{
				num += 2;
			}
			if (this.SaveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SaveTime);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			num += this.roleIds_.CalculateSize(RogueArchiveInfo._repeated_roleIds_codec);
			num += this.attributes_.CalculateSize(RogueArchiveInfo._map_attributes_codec);
			if (this.roguelikeInstInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeInstInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015314 RID: 86804 RVA: 0x00312948 File Offset: 0x00310B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArchiveInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotId != 0)
			{
				this.SlotId = other.SlotId;
			}
			if (other.HasData)
			{
				this.HasData = other.HasData;
			}
			if (other.SaveTime != 0L)
			{
				this.SaveTime = other.SaveTime;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this.roleIds_.Add(other.roleIds_);
			this.attributes_.MergeFrom(other.attributes_);
			if (other.roguelikeInstInfo_ != null)
			{
				if (this.roguelikeInstInfo_ == null)
				{
					this.RoguelikeInstInfo = new RoguelikeInstInfo();
				}
				this.RoguelikeInstInfo.MergeFrom(other.RoguelikeInstInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015315 RID: 86805 RVA: 0x00312A22 File Offset: 0x00310C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015316 RID: 86806 RVA: 0x00312A2C File Offset: 0x00310C2C
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
				if (num > 32U)
				{
					if (num <= 48U)
					{
						if (num == 40U)
						{
							this.SeasonId = input.ReadInt32();
							continue;
						}
						if (num != 48U)
						{
							goto IL_50;
						}
					}
					else if (num != 50U)
					{
						if (num == 58U)
						{
							this.attributes_.AddEntriesFrom(ref input, RogueArchiveInfo._map_attributes_codec);
							continue;
						}
						if (num != 66U)
						{
							goto IL_50;
						}
						if (this.roguelikeInstInfo_ == null)
						{
							this.RoguelikeInstInfo = new RoguelikeInstInfo();
						}
						input.ReadMessage(this.RoguelikeInstInfo);
						continue;
					}
					this.roleIds_.AddEntriesFrom(ref input, RogueArchiveInfo._repeated_roleIds_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SlotId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.HasData = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.SaveTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				IL_50:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F64 RID: 32612
		private static readonly MessageParser<RogueArchiveInfo> _parser = new MessageParser<RogueArchiveInfo>(() => new RogueArchiveInfo());

		// Token: 0x04007F65 RID: 32613
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F66 RID: 32614
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04007F67 RID: 32615
		private int slotId_;

		// Token: 0x04007F68 RID: 32616
		public const int HasDataFieldNumber = 2;

		// Token: 0x04007F69 RID: 32617
		private bool hasData_;

		// Token: 0x04007F6A RID: 32618
		public const int SaveTimeFieldNumber = 3;

		// Token: 0x04007F6B RID: 32619
		private long saveTime_;

		// Token: 0x04007F6C RID: 32620
		public const int InstIdFieldNumber = 4;

		// Token: 0x04007F6D RID: 32621
		private int instId_;

		// Token: 0x04007F6E RID: 32622
		public const int SeasonIdFieldNumber = 5;

		// Token: 0x04007F6F RID: 32623
		private int seasonId_;

		// Token: 0x04007F70 RID: 32624
		public const int RoleIdsFieldNumber = 6;

		// Token: 0x04007F71 RID: 32625
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007F72 RID: 32626
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04007F73 RID: 32627
		public const int AttributesFieldNumber = 7;

		// Token: 0x04007F74 RID: 32628
		private static readonly MapField<int, int>.Codec _map_attributes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x04007F75 RID: 32629
		private readonly MapField<int, int> attributes_ = new MapField<int, int>();

		// Token: 0x04007F76 RID: 32630
		public const int RoguelikeInstInfoFieldNumber = 8;

		// Token: 0x04007F77 RID: 32631
		private RoguelikeInstInfo roguelikeInstInfo_;
	}
}
