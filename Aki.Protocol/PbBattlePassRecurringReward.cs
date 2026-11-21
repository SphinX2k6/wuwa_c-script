using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEE RID: 3054
	public sealed class PbBattlePassRecurringReward : IMessage<PbBattlePassRecurringReward>, IMessage, IEquatable<PbBattlePassRecurringReward>, IDeepCloneable<PbBattlePassRecurringReward>, IBufferMessage
	{
		// Token: 0x060109A6 RID: 68006 RVA: 0x0026EF0B File Offset: 0x0026D10B
		[NullableContext(1)]
		public static PbBattlePassRecurringReward Create()
		{
			return new PbBattlePassRecurringReward();
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x060109A7 RID: 68007 RVA: 0x0026EF12 File Offset: 0x0026D112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbBattlePassRecurringReward> Parser
		{
			get
			{
				return PbBattlePassRecurringReward._parser;
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x060109A8 RID: 68008 RVA: 0x0026EF19 File Offset: 0x0026D119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x060109A9 RID: 68009 RVA: 0x0026EF1C File Offset: 0x0026D11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePassRecurringReward.Descriptor;
			}
		}

		// Token: 0x060109AA RID: 68010 RVA: 0x0026EF23 File Offset: 0x0026D123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassRecurringReward()
		{
		}

		// Token: 0x060109AB RID: 68011 RVA: 0x0026EF2B File Offset: 0x0026D12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassRecurringReward(PbBattlePassRecurringReward other) : this()
		{
			this.type_ = other.type_;
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060109AC RID: 68012 RVA: 0x0026EF68 File Offset: 0x0026D168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassRecurringReward Clone()
		{
			return new PbBattlePassRecurringReward(this);
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x060109AD RID: 68013 RVA: 0x0026EF70 File Offset: 0x0026D170
		// (set) Token: 0x060109AE RID: 68014 RVA: 0x0026EF78 File Offset: 0x0026D178
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

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x060109AF RID: 68015 RVA: 0x0026EF81 File Offset: 0x0026D181
		// (set) Token: 0x060109B0 RID: 68016 RVA: 0x0026EF89 File Offset: 0x0026D189
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

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x060109B1 RID: 68017 RVA: 0x0026EF92 File Offset: 0x0026D192
		// (set) Token: 0x060109B2 RID: 68018 RVA: 0x0026EF9A File Offset: 0x0026D19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x060109B3 RID: 68019 RVA: 0x0026EFA3 File Offset: 0x0026D1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePassRecurringReward);
		}

		// Token: 0x060109B4 RID: 68020 RVA: 0x0026EFB4 File Offset: 0x0026D1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePassRecurringReward other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060109B5 RID: 68021 RVA: 0x0026F010 File Offset: 0x0026D210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != BattlePassType.Free)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060109B6 RID: 68022 RVA: 0x0026F087 File Offset: 0x0026D287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060109B7 RID: 68023 RVA: 0x0026F094 File Offset: 0x0026D294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060109B8 RID: 68024 RVA: 0x0026F0A0 File Offset: 0x0026D2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != BattlePassType.Free)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060109B9 RID: 68025 RVA: 0x0026F114 File Offset: 0x0026D314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != BattlePassType.Free)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060109BA RID: 68026 RVA: 0x0026F184 File Offset: 0x0026D384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbBattlePassRecurringReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != BattlePassType.Free)
			{
				this.Type = other.Type;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060109BB RID: 68027 RVA: 0x0026F1E8 File Offset: 0x0026D3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109BC RID: 68028 RVA: 0x0026F1F4 File Offset: 0x0026D3F4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Count = input.ReadInt32();
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

		// Token: 0x04006A09 RID: 27145
		private static readonly MessageParser<PbBattlePassRecurringReward> _parser = new MessageParser<PbBattlePassRecurringReward>(() => new PbBattlePassRecurringReward());

		// Token: 0x04006A0A RID: 27146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A0B RID: 27147
		public const int TypeFieldNumber = 1;

		// Token: 0x04006A0C RID: 27148
		private BattlePassType type_;

		// Token: 0x04006A0D RID: 27149
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04006A0E RID: 27150
		private int itemId_;

		// Token: 0x04006A0F RID: 27151
		public const int CountFieldNumber = 3;

		// Token: 0x04006A10 RID: 27152
		private int count_;
	}
}
