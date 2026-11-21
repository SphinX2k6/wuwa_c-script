using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F6B RID: 3947
	public sealed class RogueArchiveInfo : IMessage<RogueArchiveInfo>, IMessage, IEquatable<RogueArchiveInfo>, IDeepCloneable<RogueArchiveInfo>, IBufferMessage
	{
		// Token: 0x06015213 RID: 86547 RVA: 0x00310DD8 File Offset: 0x0030EFD8
		[NullableContext(1)]
		public static RogueArchiveInfo Create()
		{
			return new RogueArchiveInfo();
		}

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x06015214 RID: 86548 RVA: 0x00310DDF File Offset: 0x0030EFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArchiveInfo> Parser
		{
			get
			{
				return RogueArchiveInfo._parser;
			}
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x06015215 RID: 86549 RVA: 0x00310DE6 File Offset: 0x0030EFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x06015216 RID: 86550 RVA: 0x00310DE9 File Offset: 0x0030EFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArchiveInfo.Descriptor;
			}
		}

		// Token: 0x06015217 RID: 86551 RVA: 0x00310DF0 File Offset: 0x0030EFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveInfo()
		{
		}

		// Token: 0x06015218 RID: 86552 RVA: 0x00310E10 File Offset: 0x0030F010
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

		// Token: 0x06015219 RID: 86553 RVA: 0x00310EAE File Offset: 0x0030F0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArchiveInfo Clone()
		{
			return new RogueArchiveInfo(this);
		}

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x0601521A RID: 86554 RVA: 0x00310EB6 File Offset: 0x0030F0B6
		// (set) Token: 0x0601521B RID: 86555 RVA: 0x00310EBE File Offset: 0x0030F0BE
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

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x0601521C RID: 86556 RVA: 0x00310EC7 File Offset: 0x0030F0C7
		// (set) Token: 0x0601521D RID: 86557 RVA: 0x00310ECF File Offset: 0x0030F0CF
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

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x0601521E RID: 86558 RVA: 0x00310ED8 File Offset: 0x0030F0D8
		// (set) Token: 0x0601521F RID: 86559 RVA: 0x00310EE0 File Offset: 0x0030F0E0
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

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x06015220 RID: 86560 RVA: 0x00310EE9 File Offset: 0x0030F0E9
		// (set) Token: 0x06015221 RID: 86561 RVA: 0x00310EF1 File Offset: 0x0030F0F1
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

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x06015222 RID: 86562 RVA: 0x00310EFA File Offset: 0x0030F0FA
		// (set) Token: 0x06015223 RID: 86563 RVA: 0x00310F02 File Offset: 0x0030F102
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

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x06015224 RID: 86564 RVA: 0x00310F0B File Offset: 0x0030F10B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x06015225 RID: 86565 RVA: 0x00310F13 File Offset: 0x0030F113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x06015226 RID: 86566 RVA: 0x00310F1B File Offset: 0x0030F11B
		// (set) Token: 0x06015227 RID: 86567 RVA: 0x00310F23 File Offset: 0x0030F123
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

		// Token: 0x06015228 RID: 86568 RVA: 0x00310F2C File Offset: 0x0030F12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArchiveInfo);
		}

		// Token: 0x06015229 RID: 86569 RVA: 0x00310F3C File Offset: 0x0030F13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArchiveInfo other)
		{
			return other != null && (other == this || (this.SlotId == other.SlotId && this.HasData == other.HasData && this.SaveTime == other.SaveTime && this.InstId == other.InstId && this.SeasonId == other.SeasonId && this.roleIds_.Equals(other.roleIds_) && this.Attributes.Equals(other.Attributes) && object.Equals(this.RoguelikeInstInfo, other.RoguelikeInstInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601522A RID: 86570 RVA: 0x00310FF4 File Offset: 0x0030F1F4
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

		// Token: 0x0601522B RID: 86571 RVA: 0x003110C9 File Offset: 0x0030F2C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601522C RID: 86572 RVA: 0x003110D6 File Offset: 0x0030F2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601522D RID: 86573 RVA: 0x003110E0 File Offset: 0x0030F2E0
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

		// Token: 0x0601522E RID: 86574 RVA: 0x003111CC File Offset: 0x0030F3CC
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

		// Token: 0x0601522F RID: 86575 RVA: 0x0031129C File Offset: 0x0030F49C
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

		// Token: 0x06015230 RID: 86576 RVA: 0x00311376 File Offset: 0x0030F576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015231 RID: 86577 RVA: 0x00311380 File Offset: 0x0030F580
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

		// Token: 0x04007F8E RID: 32654
		private static readonly MessageParser<RogueArchiveInfo> _parser = new MessageParser<RogueArchiveInfo>(() => new RogueArchiveInfo());

		// Token: 0x04007F8F RID: 32655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F90 RID: 32656
		public const int SlotIdFieldNumber = 1;

		// Token: 0x04007F91 RID: 32657
		private int slotId_;

		// Token: 0x04007F92 RID: 32658
		public const int HasDataFieldNumber = 2;

		// Token: 0x04007F93 RID: 32659
		private bool hasData_;

		// Token: 0x04007F94 RID: 32660
		public const int SaveTimeFieldNumber = 3;

		// Token: 0x04007F95 RID: 32661
		private long saveTime_;

		// Token: 0x04007F96 RID: 32662
		public const int InstIdFieldNumber = 4;

		// Token: 0x04007F97 RID: 32663
		private int instId_;

		// Token: 0x04007F98 RID: 32664
		public const int SeasonIdFieldNumber = 5;

		// Token: 0x04007F99 RID: 32665
		private int seasonId_;

		// Token: 0x04007F9A RID: 32666
		public const int RoleIdsFieldNumber = 6;

		// Token: 0x04007F9B RID: 32667
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007F9C RID: 32668
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04007F9D RID: 32669
		public const int AttributesFieldNumber = 7;

		// Token: 0x04007F9E RID: 32670
		private static readonly MapField<int, int>.Codec _map_attributes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x04007F9F RID: 32671
		private readonly MapField<int, int> attributes_ = new MapField<int, int>();

		// Token: 0x04007FA0 RID: 32672
		public const int RoguelikeInstInfoFieldNumber = 8;

		// Token: 0x04007FA1 RID: 32673
		private RoguelikeInstInfo roguelikeInstInfo_;
	}
}
