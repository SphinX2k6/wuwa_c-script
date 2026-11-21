using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF1 RID: 4081
	public sealed class RogueResRole : IMessage<RogueResRole>, IMessage, IEquatable<RogueResRole>, IDeepCloneable<RogueResRole>, IBufferMessage
	{
		// Token: 0x06015D92 RID: 89490 RVA: 0x0032D8F1 File Offset: 0x0032BAF1
		[NullableContext(1)]
		public static RogueResRole Create()
		{
			return new RogueResRole();
		}

		// Token: 0x17004901 RID: 18689
		// (get) Token: 0x06015D93 RID: 89491 RVA: 0x0032D8F8 File Offset: 0x0032BAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004902 RID: 18690
		// (get) Token: 0x06015D94 RID: 89492 RVA: 0x0032D8FB File Offset: 0x0032BAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRole.Descriptor;
			}
		}

		// Token: 0x06015D95 RID: 89493 RVA: 0x0032D902 File Offset: 0x0032BB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole()
		{
		}

		// Token: 0x06015D96 RID: 89494 RVA: 0x0032D918 File Offset: 0x0032BB18
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

		// Token: 0x06015D97 RID: 89495 RVA: 0x0032D9AD File Offset: 0x0032BBAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRole Clone()
		{
			return new RogueResRole(this);
		}

		// Token: 0x17004903 RID: 18691
		// (get) Token: 0x06015D98 RID: 89496 RVA: 0x0032D9B5 File Offset: 0x0032BBB5
		// (set) Token: 0x06015D99 RID: 89497 RVA: 0x0032D9BD File Offset: 0x0032BBBD
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

		// Token: 0x17004904 RID: 18692
		// (get) Token: 0x06015D9A RID: 89498 RVA: 0x0032D9C6 File Offset: 0x0032BBC6
		// (set) Token: 0x06015D9B RID: 89499 RVA: 0x0032D9CE File Offset: 0x0032BBCE
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

		// Token: 0x17004905 RID: 18693
		// (get) Token: 0x06015D9C RID: 89500 RVA: 0x0032D9D7 File Offset: 0x0032BBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleAffixs
		{
			get
			{
				return this.roleAffixs_;
			}
		}

		// Token: 0x17004906 RID: 18694
		// (get) Token: 0x06015D9D RID: 89501 RVA: 0x0032D9DF File Offset: 0x0032BBDF
		// (set) Token: 0x06015D9E RID: 89502 RVA: 0x0032D9E7 File Offset: 0x0032BBE7
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

		// Token: 0x17004907 RID: 18695
		// (get) Token: 0x06015D9F RID: 89503 RVA: 0x0032D9F0 File Offset: 0x0032BBF0
		// (set) Token: 0x06015DA0 RID: 89504 RVA: 0x0032D9F8 File Offset: 0x0032BBF8
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

		// Token: 0x17004908 RID: 18696
		// (get) Token: 0x06015DA1 RID: 89505 RVA: 0x0032DA01 File Offset: 0x0032BC01
		// (set) Token: 0x06015DA2 RID: 89506 RVA: 0x0032DA09 File Offset: 0x0032BC09
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

		// Token: 0x17004909 RID: 18697
		// (get) Token: 0x06015DA3 RID: 89507 RVA: 0x0032DA12 File Offset: 0x0032BC12
		// (set) Token: 0x06015DA4 RID: 89508 RVA: 0x0032DA1A File Offset: 0x0032BC1A
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

		// Token: 0x1700490A RID: 18698
		// (get) Token: 0x06015DA5 RID: 89509 RVA: 0x0032DA23 File Offset: 0x0032BC23
		// (set) Token: 0x06015DA6 RID: 89510 RVA: 0x0032DA2B File Offset: 0x0032BC2B
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

		// Token: 0x1700490B RID: 18699
		// (get) Token: 0x06015DA7 RID: 89511 RVA: 0x0032DA34 File Offset: 0x0032BC34
		// (set) Token: 0x06015DA8 RID: 89512 RVA: 0x0032DA3C File Offset: 0x0032BC3C
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

		// Token: 0x06015DA9 RID: 89513 RVA: 0x0032DA45 File Offset: 0x0032BC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRole);
		}

		// Token: 0x06015DAA RID: 89514 RVA: 0x0032DA54 File Offset: 0x0032BC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRole other)
		{
			return other != null && (other == this || (this.IsNew == other.IsNew && this.Level == other.Level && this.roleAffixs_.Equals(other.roleAffixs_) && this.SourcePrice == other.SourcePrice && this.CurPrice == other.CurPrice && this.ItemId == other.ItemId && this.IsSell == other.IsSell && this.Index == other.Index && this.RoleIdOrTrialRoleId == other.RoleIdOrTrialRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DAB RID: 89515 RVA: 0x0032DB14 File Offset: 0x0032BD14
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

		// Token: 0x06015DAC RID: 89516 RVA: 0x0032DC10 File Offset: 0x0032BE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DAD RID: 89517 RVA: 0x0032DC1D File Offset: 0x0032BE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DAE RID: 89518 RVA: 0x0032DC28 File Offset: 0x0032BE28
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

		// Token: 0x06015DAF RID: 89519 RVA: 0x0032DD3C File Offset: 0x0032BF3C
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

		// Token: 0x06015DB0 RID: 89520 RVA: 0x0032DE20 File Offset: 0x0032C020
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

		// Token: 0x06015DB1 RID: 89521 RVA: 0x0032DEF9 File Offset: 0x0032C0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DB2 RID: 89522 RVA: 0x0032DF04 File Offset: 0x0032C104
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

		// Token: 0x0400838F RID: 33679
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008390 RID: 33680
		public const int IsNewFieldNumber = 2;

		// Token: 0x04008391 RID: 33681
		private bool isNew_;

		// Token: 0x04008392 RID: 33682
		public const int LevelFieldNumber = 3;

		// Token: 0x04008393 RID: 33683
		private int level_;

		// Token: 0x04008394 RID: 33684
		public const int RoleAffixsFieldNumber = 4;

		// Token: 0x04008395 RID: 33685
		private static readonly FieldCodec<int> _repeated_roleAffixs_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008396 RID: 33686
		private readonly RepeatedField<int> roleAffixs_ = new RepeatedField<int>();

		// Token: 0x04008397 RID: 33687
		public const int SourcePriceFieldNumber = 5;

		// Token: 0x04008398 RID: 33688
		private int sourcePrice_;

		// Token: 0x04008399 RID: 33689
		public const int CurPriceFieldNumber = 6;

		// Token: 0x0400839A RID: 33690
		private int curPrice_;

		// Token: 0x0400839B RID: 33691
		public const int ItemIdFieldNumber = 7;

		// Token: 0x0400839C RID: 33692
		private int itemId_;

		// Token: 0x0400839D RID: 33693
		public const int IsSellFieldNumber = 8;

		// Token: 0x0400839E RID: 33694
		private bool isSell_;

		// Token: 0x0400839F RID: 33695
		public const int IndexFieldNumber = 9;

		// Token: 0x040083A0 RID: 33696
		private int index_;

		// Token: 0x040083A1 RID: 33697
		public const int RoleIdOrTrialRoleIdFieldNumber = 10;

		// Token: 0x040083A2 RID: 33698
		private int roleIdOrTrialRoleId_;
	}
}
