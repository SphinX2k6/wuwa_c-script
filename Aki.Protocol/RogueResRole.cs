using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001001 RID: 4097
	public sealed class RogueResRole : IMessage<RogueResRole>, IMessage, IEquatable<RogueResRole>, IDeepCloneable<RogueResRole>, IBufferMessage
	{
		// Token: 0x06015E77 RID: 89719 RVA: 0x0032EFB0 File Offset: 0x0032D1B0
		[NullableContext(1)]
		public static RogueResRole Create()
		{
			return new RogueResRole();
		}

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x06015E78 RID: 89720 RVA: 0x0032EFB7 File Offset: 0x0032D1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x06015E79 RID: 89721 RVA: 0x0032EFBA File Offset: 0x0032D1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRole.Descriptor;
			}
		}

		// Token: 0x06015E7A RID: 89722 RVA: 0x0032EFC1 File Offset: 0x0032D1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole()
		{
		}

		// Token: 0x06015E7B RID: 89723 RVA: 0x0032EFD4 File Offset: 0x0032D1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole(RogueResRole other) : this()
		{
			this.isNew_ = other.isNew_;
			this.level_ = other.level_;
			this.roleAffixs_ = other.roleAffixs_.Clone();
			this.sourcePrice_ = other.sourcePrice_;
			this.curPrice_ = other.curPrice_;
			this.itemId_ = other.itemId_;
			this.isSell_ = other.isSell_;
			this.index_ = other.index_;
			this.roleIdOrTrialRoleId_ = other.roleIdOrTrialRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E7C RID: 89724 RVA: 0x0032F069 File Offset: 0x0032D269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole Clone()
		{
			return new RogueResRole(this);
		}

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x06015E7D RID: 89725 RVA: 0x0032F071 File Offset: 0x0032D271
		// (set) Token: 0x06015E7E RID: 89726 RVA: 0x0032F079 File Offset: 0x0032D279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x06015E7F RID: 89727 RVA: 0x0032F082 File Offset: 0x0032D282
		// (set) Token: 0x06015E80 RID: 89728 RVA: 0x0032F08A File Offset: 0x0032D28A
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

		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x06015E81 RID: 89729 RVA: 0x0032F093 File Offset: 0x0032D293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleAffixs
		{
			get
			{
				return this.roleAffixs_;
			}
		}

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x06015E82 RID: 89730 RVA: 0x0032F09B File Offset: 0x0032D29B
		// (set) Token: 0x06015E83 RID: 89731 RVA: 0x0032F0A3 File Offset: 0x0032D2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SourcePrice
		{
			get
			{
				return this.sourcePrice_;
			}
			set
			{
				this.sourcePrice_ = value;
			}
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x06015E84 RID: 89732 RVA: 0x0032F0AC File Offset: 0x0032D2AC
		// (set) Token: 0x06015E85 RID: 89733 RVA: 0x0032F0B4 File Offset: 0x0032D2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPrice
		{
			get
			{
				return this.curPrice_;
			}
			set
			{
				this.curPrice_ = value;
			}
		}

		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x06015E86 RID: 89734 RVA: 0x0032F0BD File Offset: 0x0032D2BD
		// (set) Token: 0x06015E87 RID: 89735 RVA: 0x0032F0C5 File Offset: 0x0032D2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x06015E88 RID: 89736 RVA: 0x0032F0CE File Offset: 0x0032D2CE
		// (set) Token: 0x06015E89 RID: 89737 RVA: 0x0032F0D6 File Offset: 0x0032D2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSell
		{
			get
			{
				return this.isSell_;
			}
			set
			{
				this.isSell_ = value;
			}
		}

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x06015E8A RID: 89738 RVA: 0x0032F0DF File Offset: 0x0032D2DF
		// (set) Token: 0x06015E8B RID: 89739 RVA: 0x0032F0E7 File Offset: 0x0032D2E7
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

		// Token: 0x17004935 RID: 18741
		// (get) Token: 0x06015E8C RID: 89740 RVA: 0x0032F0F0 File Offset: 0x0032D2F0
		// (set) Token: 0x06015E8D RID: 89741 RVA: 0x0032F0F8 File Offset: 0x0032D2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleIdOrTrialRoleId
		{
			get
			{
				return this.roleIdOrTrialRoleId_;
			}
			set
			{
				this.roleIdOrTrialRoleId_ = value;
			}
		}

		// Token: 0x06015E8E RID: 89742 RVA: 0x0032F101 File Offset: 0x0032D301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRole);
		}

		// Token: 0x06015E8F RID: 89743 RVA: 0x0032F110 File Offset: 0x0032D310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRole other)
		{
			return other != null && (other == this || (this.IsNew == other.IsNew && this.Level == other.Level && this.roleAffixs_.Equals(other.roleAffixs_) && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && this.ItemId == other.ItemId && this.IsSell == other.IsSell && this.Index == other.Index && this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E90 RID: 89744 RVA: 0x0032F1D0 File Offset: 0x0032D3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.roleAffixs_.GetHashCode();
			if (this.SourcePrice != 0)
			{
				num ^= this.SourcePrice.GetHashCode();
			}
			if (this.CurPrice != 0)
			{
				num ^= this.CurPrice.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IsSell)
			{
				num ^= this.IsSell.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num ^= this.RoleIdOrTrialRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015E91 RID: 89745 RVA: 0x0032F2CC File Offset: 0x0032D4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E92 RID: 89746 RVA: 0x0032F2D9 File Offset: 0x0032D4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E93 RID: 89747 RVA: 0x0032F2E4 File Offset: 0x0032D4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			this.roleAffixs_.WriteTo(ref output, RogueResRole._repeated_roleAffixs_codec);
			if (this.SourcePrice != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurPrice);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemId);
			}
			if (this.IsSell)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsSell);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Index);
			}
			if (this.RoleIdOrTrialRoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleIdOrTrialRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E94 RID: 89748 RVA: 0x0032F3F8 File Offset: 0x0032D5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			num += this.roleAffixs_.CalculateSize(RogueResRole._repeated_roleAffixs_codec);
			if (this.SourcePrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SourcePrice);
			}
			if (this.CurPrice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPrice);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IsSell)
			{
				num += 2;
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.RoleIdOrTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleIdOrTrialRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015E95 RID: 89749 RVA: 0x0032F4DC File Offset: 0x0032D6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResRole other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this.roleAffixs_.Add(other.roleAffixs_);
			if (other.SourcePrice != 0)
			{
				this.SourcePrice = other.SourcePrice;
			}
			if (other.CurPrice != 0)
			{
				this.CurPrice = other.CurPrice;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IsSell)
			{
				this.IsSell = other.IsSell;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.RoleIdOrTrialRoleId != 0)
			{
				this.RoleIdOrTrialRoleId = other.RoleIdOrTrialRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015E96 RID: 89750 RVA: 0x0032F5B5 File Offset: 0x0032D7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E97 RID: 89751 RVA: 0x0032F5C0 File Offset: 0x0032D7C0
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
				if (num <= 40U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.IsNew = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U || num == 34U)
						{
							this.roleAffixs_.AddEntriesFrom(ref input, RogueResRole._repeated_roleAffixs_codec);
							continue;
						}
						if (num == 40U)
						{
							this.SourcePrice = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.CurPrice = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ItemId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.IsSell = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoleIdOrTrialRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008365 RID: 33637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008366 RID: 33638
		public const int IsNewFieldNumber = 2;

		// Token: 0x04008367 RID: 33639
		private bool isNew_;

		// Token: 0x04008368 RID: 33640
		public const int LevelFieldNumber = 3;

		// Token: 0x04008369 RID: 33641
		private int level_;

		// Token: 0x0400836A RID: 33642
		public const int RoleAffixsFieldNumber = 4;

		// Token: 0x0400836B RID: 33643
		private static readonly FieldCodec<int> _repeated_roleAffixs_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400836C RID: 33644
		private readonly RepeatedField<int> roleAffixs_ = new RepeatedField<int>();

		// Token: 0x0400836D RID: 33645
		public const int SourcePriceFieldNumber = 5;

		// Token: 0x0400836E RID: 33646
		private int sourcePrice_;

		// Token: 0x0400836F RID: 33647
		public const int CurPriceFieldNumber = 6;

		// Token: 0x04008370 RID: 33648
		private int curPrice_;

		// Token: 0x04008371 RID: 33649
		public const int ItemIdFieldNumber = 7;

		// Token: 0x04008372 RID: 33650
		private int itemId_;

		// Token: 0x04008373 RID: 33651
		public const int IsSellFieldNumber = 8;

		// Token: 0x04008374 RID: 33652
		private bool isSell_;

		// Token: 0x04008375 RID: 33653
		public const int IndexFieldNumber = 9;

		// Token: 0x04008376 RID: 33654
		private int index_;

		// Token: 0x04008377 RID: 33655
		public const int RoleIdOrTrialRoleIdFieldNumber = 10;

		// Token: 0x04008378 RID: 33656
		private int roleIdOrTrialRoleId_;
	}
}
