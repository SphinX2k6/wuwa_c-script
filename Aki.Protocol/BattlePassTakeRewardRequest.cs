using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000174 RID: 372
	[NetMessage(EMessageId.BattlePassTakeRewardRequest)]
	public sealed class BattlePassTakeRewardRequest : IMessage<BattlePassTakeRewardRequest>, IMessage, IEquatable<BattlePassTakeRewardRequest>, IDeepCloneable<BattlePassTakeRewardRequest>, IBufferMessage
	{
		// Token: 0x06002D99 RID: 11673 RVA: 0x00075E01 File Offset: 0x00074001
		[NullableContext(1)]
		public static BattlePassTakeRewardRequest Create()
		{
			return new BattlePassTakeRewardRequest();
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00075E08 File Offset: 0x00074008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x00075E0B File Offset: 0x0007400B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTakeRewardRequest.Descriptor;
			}
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00075E12 File Offset: 0x00074012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardRequest()
		{
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x00075E1A File Offset: 0x0007401A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardRequest(BattlePassTakeRewardRequest other) : this()
		{
			this.type_ = other.type_;
			this.level_ = other.level_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x00075E57 File Offset: 0x00074057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTakeRewardRequest Clone()
		{
			return new BattlePassTakeRewardRequest(this);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x00075E5F File Offset: 0x0007405F
		// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x00075E67 File Offset: 0x00074067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x00075E70 File Offset: 0x00074070
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x00075E78 File Offset: 0x00074078
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

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x00075E81 File Offset: 0x00074081
		// (set) Token: 0x06002DA4 RID: 11684 RVA: 0x00075E89 File Offset: 0x00074089
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

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00075E92 File Offset: 0x00074092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTakeRewardRequest);
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00075EA0 File Offset: 0x000740A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTakeRewardRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Level == other.Level && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00075EFC File Offset: 0x000740FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != BattlePassType.Free)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00075F73 File Offset: 0x00074173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00075F80 File Offset: 0x00074180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00075F8C File Offset: 0x0007418C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != BattlePassType.Free)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00076004 File Offset: 0x00074204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != BattlePassType.Free)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00076074 File Offset: 0x00074274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTakeRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != BattlePassType.Free)
			{
				this.Type = other.Type;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000760D8 File Offset: 0x000742D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000760E4 File Offset: 0x000742E4
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
					if (num != 72U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (BattlePassType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400283E RID: 10302
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400283F RID: 10303
		public const int TypeFieldNumber = 2;

		// Token: 0x04002840 RID: 10304
		private BattlePassType type_;

		// Token: 0x04002841 RID: 10305
		public const int LevelFieldNumber = 12;

		// Token: 0x04002842 RID: 10306
		private int level_;

		// Token: 0x04002843 RID: 10307
		public const int ItemIdFieldNumber = 9;

		// Token: 0x04002844 RID: 10308
		private int itemId_;
	}
}
