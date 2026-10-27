using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200106C RID: 4204
	public sealed class RoleFavor : IMessage<RoleFavor>, IMessage, IEquatable<RoleFavor>, IDeepCloneable<RoleFavor>, IBufferMessage
	{
		// Token: 0x06016770 RID: 92016 RVA: 0x00344034 File Offset: 0x00342234
		[NullableContext(1)]
		public static RoleFavor Create()
		{
			return new RoleFavor();
		}

		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x06016771 RID: 92017 RVA: 0x0034403B File Offset: 0x0034223B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleFavor> Parser
		{
			get
			{
				return RoleFavor._parser;
			}
		}

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x06016772 RID: 92018 RVA: 0x00344042 File Offset: 0x00342242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x06016773 RID: 92019 RVA: 0x00344045 File Offset: 0x00342245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavor.Descriptor;
			}
		}

		// Token: 0x06016774 RID: 92020 RVA: 0x0034404C File Offset: 0x0034224C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavor()
		{
		}

		// Token: 0x06016775 RID: 92021 RVA: 0x00344078 File Offset: 0x00342278
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

		// Token: 0x06016776 RID: 92022 RVA: 0x0034410F File Offset: 0x0034230F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavor Clone()
		{
			return new RoleFavor(this);
		}

		// Token: 0x17004B37 RID: 19255
		// (get) Token: 0x06016777 RID: 92023 RVA: 0x00344117 File Offset: 0x00342317
		// (set) Token: 0x06016778 RID: 92024 RVA: 0x0034411F File Offset: 0x0034231F
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

		// Token: 0x17004B38 RID: 19256
		// (get) Token: 0x06016779 RID: 92025 RVA: 0x00344128 File Offset: 0x00342328
		// (set) Token: 0x0601677A RID: 92026 RVA: 0x00344130 File Offset: 0x00342330
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

		// Token: 0x17004B39 RID: 19257
		// (get) Token: 0x0601677B RID: 92027 RVA: 0x00344139 File Offset: 0x00342339
		// (set) Token: 0x0601677C RID: 92028 RVA: 0x00344141 File Offset: 0x00342341
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

		// Token: 0x17004B3A RID: 19258
		// (get) Token: 0x0601677D RID: 92029 RVA: 0x0034414A File Offset: 0x0034234A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> WordIds
		{
			get
			{
				return this.wordIds_;
			}
		}

		// Token: 0x17004B3B RID: 19259
		// (get) Token: 0x0601677E RID: 92030 RVA: 0x00344152 File Offset: 0x00342352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> StoryIds
		{
			get
			{
				return this.storyIds_;
			}
		}

		// Token: 0x17004B3C RID: 19260
		// (get) Token: 0x0601677F RID: 92031 RVA: 0x0034415A File Offset: 0x0034235A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FavorItem> GoodsIds
		{
			get
			{
				return this.goodsIds_;
			}
		}

		// Token: 0x17004B3D RID: 19261
		// (get) Token: 0x06016780 RID: 92032 RVA: 0x00344162 File Offset: 0x00342362
		// (set) Token: 0x06016781 RID: 92033 RVA: 0x0034416A File Offset: 0x0034236A
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

		// Token: 0x06016782 RID: 92034 RVA: 0x00344173 File Offset: 0x00342373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavor);
		}

		// Token: 0x06016783 RID: 92035 RVA: 0x00344184 File Offset: 0x00342384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavor other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && this.Exp == other.Exp && this.wordIds_.Equals(other.wordIds_) && this.storyIds_.Equals(other.storyIds_) && this.goodsIds_.Equals(other.goodsIds_) && object.Equals(this.FavorQuest, other.FavorQuest) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016784 RID: 92036 RVA: 0x00344234 File Offset: 0x00342434
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

		// Token: 0x06016785 RID: 92037 RVA: 0x003442E5 File Offset: 0x003424E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016786 RID: 92038 RVA: 0x003442F2 File Offset: 0x003424F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016787 RID: 92039 RVA: 0x003442FC File Offset: 0x003424FC
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

		// Token: 0x06016788 RID: 92040 RVA: 0x003443C0 File Offset: 0x003425C0
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

		// Token: 0x06016789 RID: 92041 RVA: 0x00344480 File Offset: 0x00342680
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

		// Token: 0x0601678A RID: 92042 RVA: 0x00344543 File Offset: 0x00342743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601678B RID: 92043 RVA: 0x0034454C File Offset: 0x0034274C
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

		// Token: 0x0400865D RID: 34397
		private static readonly MessageParser<RoleFavor> _parser = new MessageParser<RoleFavor>(() => new RoleFavor());

		// Token: 0x0400865E RID: 34398
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400865F RID: 34399
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008660 RID: 34400
		private int roleId_;

		// Token: 0x04008661 RID: 34401
		public const int LevelFieldNumber = 2;

		// Token: 0x04008662 RID: 34402
		private int level_;

		// Token: 0x04008663 RID: 34403
		public const int ExpFieldNumber = 3;

		// Token: 0x04008664 RID: 34404
		private int exp_;

		// Token: 0x04008665 RID: 34405
		public const int WordIdsFieldNumber = 4;

		// Token: 0x04008666 RID: 34406
		private static readonly FieldCodec<FavorItem> _repeated_wordIds_codec = FieldCodec.ForMessage<FavorItem>(34U, FavorItem.Parser);

		// Token: 0x04008667 RID: 34407
		private readonly RepeatedField<FavorItem> wordIds_ = new RepeatedField<FavorItem>();

		// Token: 0x04008668 RID: 34408
		public const int StoryIdsFieldNumber = 5;

		// Token: 0x04008669 RID: 34409
		private static readonly FieldCodec<FavorItem> _repeated_storyIds_codec = FieldCodec.ForMessage<FavorItem>(42U, FavorItem.Parser);

		// Token: 0x0400866A RID: 34410
		private readonly RepeatedField<FavorItem> storyIds_ = new RepeatedField<FavorItem>();

		// Token: 0x0400866B RID: 34411
		public const int GoodsIdsFieldNumber = 6;

		// Token: 0x0400866C RID: 34412
		private static readonly FieldCodec<FavorItem> _repeated_goodsIds_codec = FieldCodec.ForMessage<FavorItem>(50U, FavorItem.Parser);

		// Token: 0x0400866D RID: 34413
		private readonly RepeatedField<FavorItem> goodsIds_ = new RepeatedField<FavorItem>();

		// Token: 0x0400866E RID: 34414
		public const int FavorQuestFieldNumber = 7;

		// Token: 0x0400866F RID: 34415
		private FavorQuest favorQuest_;
	}
}
