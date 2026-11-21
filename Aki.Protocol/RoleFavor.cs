using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200105C RID: 4188
	public sealed class RoleFavor : IMessage<RoleFavor>, IMessage, IEquatable<RoleFavor>, IDeepCloneable<RoleFavor>, IBufferMessage
	{
		// Token: 0x0601668B RID: 91787 RVA: 0x00342965 File Offset: 0x00340B65
		[NullableContext(1)]
		public static RoleFavor Create()
		{
			return new RoleFavor();
		}

		// Token: 0x17004B0A RID: 19210
		// (get) Token: 0x0601668C RID: 91788 RVA: 0x0034296C File Offset: 0x00340B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleFavor> Parser
		{
			get
			{
				return RoleFavor._parser;
			}
		}

		// Token: 0x17004B0B RID: 19211
		// (get) Token: 0x0601668D RID: 91789 RVA: 0x00342973 File Offset: 0x00340B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B0C RID: 19212
		// (get) Token: 0x0601668E RID: 91790 RVA: 0x00342976 File Offset: 0x00340B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavor.Descriptor;
			}
		}

		// Token: 0x0601668F RID: 91791 RVA: 0x0034297D File Offset: 0x00340B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavor()
		{
		}

		// Token: 0x06016690 RID: 91792 RVA: 0x003429A8 File Offset: 0x00340BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavor(RoleFavor other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this.exp_ = other.exp_;
			this.wordIds_ = other.wordIds_.Clone();
			this.storyIds_ = other.storyIds_.Clone();
			this.goodsIds_ = other.goodsIds_.Clone();
			this.favorQuest_ = ((other.favorQuest_ != null) ? other.favorQuest_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016691 RID: 91793 RVA: 0x00342A3F File Offset: 0x00340C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavor Clone()
		{
			return new RoleFavor(this);
		}

		// Token: 0x17004B0D RID: 19213
		// (get) Token: 0x06016692 RID: 91794 RVA: 0x00342A47 File Offset: 0x00340C47
		// (set) Token: 0x06016693 RID: 91795 RVA: 0x00342A4F File Offset: 0x00340C4F
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

		// Token: 0x17004B0E RID: 19214
		// (get) Token: 0x06016694 RID: 91796 RVA: 0x00342A58 File Offset: 0x00340C58
		// (set) Token: 0x06016695 RID: 91797 RVA: 0x00342A60 File Offset: 0x00340C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x06016696 RID: 91798 RVA: 0x00342A69 File Offset: 0x00340C69
		// (set) Token: 0x06016697 RID: 91799 RVA: 0x00342A71 File Offset: 0x00340C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x17004B10 RID: 19216
		// (get) Token: 0x06016698 RID: 91800 RVA: 0x00342A7A File Offset: 0x00340C7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> WordIds
		{
			get
			{
				return this.wordIds_;
			}
		}

		// Token: 0x17004B11 RID: 19217
		// (get) Token: 0x06016699 RID: 91801 RVA: 0x00342A82 File Offset: 0x00340C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> StoryIds
		{
			get
			{
				return this.storyIds_;
			}
		}

		// Token: 0x17004B12 RID: 19218
		// (get) Token: 0x0601669A RID: 91802 RVA: 0x00342A8A File Offset: 0x00340C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> GoodsIds
		{
			get
			{
				return this.goodsIds_;
			}
		}

		// Token: 0x17004B13 RID: 19219
		// (get) Token: 0x0601669B RID: 91803 RVA: 0x00342A92 File Offset: 0x00340C92
		// (set) Token: 0x0601669C RID: 91804 RVA: 0x00342A9A File Offset: 0x00340C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FavorQuest FavorQuest
		{
			get
			{
				return this.favorQuest_;
			}
			set
			{
				this.favorQuest_ = value;
			}
		}

		// Token: 0x0601669D RID: 91805 RVA: 0x00342AA3 File Offset: 0x00340CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavor);
		}

		// Token: 0x0601669E RID: 91806 RVA: 0x00342AB4 File Offset: 0x00340CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavor other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && this.Exp == other.Exp && this.wordIds_.Equals(other.wordIds_) && this.storyIds_.Equals(other.storyIds_) && this.goodsIds_.Equals(other.goodsIds_) && object.Equals(this.FavorQuest, other.FavorQuest) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601669F RID: 91807 RVA: 0x00342B64 File Offset: 0x00340D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Exp != 0)
			{
				num ^= this.Exp.GetHashCode();
			}
			num ^= this.wordIds_.GetHashCode();
			num ^= this.storyIds_.GetHashCode();
			num ^= this.goodsIds_.GetHashCode();
			if (this.favorQuest_ != null)
			{
				num ^= this.FavorQuest.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060166A0 RID: 91808 RVA: 0x00342C15 File Offset: 0x00340E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166A1 RID: 91809 RVA: 0x00342C22 File Offset: 0x00340E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166A2 RID: 91810 RVA: 0x00342C2C File Offset: 0x00340E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this.Exp != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Exp);
			}
			this.wordIds_.WriteTo(ref output, RoleFavor._repeated_wordIds_codec);
			this.storyIds_.WriteTo(ref output, RoleFavor._repeated_storyIds_codec);
			this.goodsIds_.WriteTo(ref output, RoleFavor._repeated_goodsIds_codec);
			if (this.favorQuest_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FavorQuest);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166A3 RID: 91811 RVA: 0x00342CF0 File Offset: 0x00340EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.Exp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Exp);
			}
			num += this.wordIds_.CalculateSize(RoleFavor._repeated_wordIds_codec);
			num += this.storyIds_.CalculateSize(RoleFavor._repeated_storyIds_codec);
			num += this.goodsIds_.CalculateSize(RoleFavor._repeated_goodsIds_codec);
			if (this.favorQuest_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FavorQuest);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060166A4 RID: 91812 RVA: 0x00342DB0 File Offset: 0x00340FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavor other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.Exp != 0)
			{
				this.Exp = other.Exp;
			}
			this.wordIds_.Add(other.wordIds_);
			this.storyIds_.Add(other.storyIds_);
			this.goodsIds_.Add(other.goodsIds_);
			if (other.favorQuest_ != null)
			{
				if (this.favorQuest_ == null)
				{
					this.FavorQuest = new FavorQuest();
				}
				this.FavorQuest.MergeFrom(other.FavorQuest);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060166A5 RID: 91813 RVA: 0x00342E73 File Offset: 0x00341073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166A6 RID: 91814 RVA: 0x00342E7C File Offset: 0x0034107C
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Exp = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 34U)
					{
						this.wordIds_.AddEntriesFrom(ref input, RoleFavor._repeated_wordIds_codec);
						continue;
					}
					if (num == 42U)
					{
						this.storyIds_.AddEntriesFrom(ref input, RoleFavor._repeated_storyIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.goodsIds_.AddEntriesFrom(ref input, RoleFavor._repeated_goodsIds_codec);
						continue;
					}
					if (num == 58U)
					{
						if (this.favorQuest_ == null)
						{
							this.FavorQuest = new FavorQuest();
						}
						input.ReadMessage(this.FavorQuest);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008687 RID: 34439
		private static readonly MessageParser<RoleFavor> _parser = new MessageParser<RoleFavor>(() => new RoleFavor());

		// Token: 0x04008688 RID: 34440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008689 RID: 34441
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400868A RID: 34442
		private int roleId_;

		// Token: 0x0400868B RID: 34443
		public const int LevelFieldNumber = 2;

		// Token: 0x0400868C RID: 34444
		private int level_;

		// Token: 0x0400868D RID: 34445
		public const int ExpFieldNumber = 3;

		// Token: 0x0400868E RID: 34446
		private int exp_;

		// Token: 0x0400868F RID: 34447
		public const int WordIdsFieldNumber = 4;

		// Token: 0x04008690 RID: 34448
		private static readonly FieldCodec<FavorItem> _repeated_wordIds_codec = FieldCodec.ForMessage<FavorItem>(34U, FavorItem.Parser);

		// Token: 0x04008691 RID: 34449
		private readonly RepeatedField<FavorItem> wordIds_ = new RepeatedField<FavorItem>();

		// Token: 0x04008692 RID: 34450
		public const int StoryIdsFieldNumber = 5;

		// Token: 0x04008693 RID: 34451
		private static readonly FieldCodec<FavorItem> _repeated_storyIds_codec = FieldCodec.ForMessage<FavorItem>(42U, FavorItem.Parser);

		// Token: 0x04008694 RID: 34452
		private readonly RepeatedField<FavorItem> storyIds_ = new RepeatedField<FavorItem>();

		// Token: 0x04008695 RID: 34453
		public const int GoodsIdsFieldNumber = 6;

		// Token: 0x04008696 RID: 34454
		private static readonly FieldCodec<FavorItem> _repeated_goodsIds_codec = FieldCodec.ForMessage<FavorItem>(50U, FavorItem.Parser);

		// Token: 0x04008697 RID: 34455
		private readonly RepeatedField<FavorItem> goodsIds_ = new RepeatedField<FavorItem>();

		// Token: 0x04008698 RID: 34456
		public const int FavorQuestFieldNumber = 7;

		// Token: 0x04008699 RID: 34457
		private FavorQuest favorQuest_;
	}
}
