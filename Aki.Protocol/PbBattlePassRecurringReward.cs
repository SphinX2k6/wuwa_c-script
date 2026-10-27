using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFE RID: 3070
	public sealed class PbBattlePassRecurringReward : IMessage<PbBattlePassRecurringReward>, IMessage, IEquatable<PbBattlePassRecurringReward>, IDeepCloneable<PbBattlePassRecurringReward>, IBufferMessage
	{
		// Token: 0x06010AA6 RID: 68262 RVA: 0x00270C73 File Offset: 0x0026EE73
		[NullableContext(1)]
		public static PbBattlePassRecurringReward Create()
		{
			return new PbBattlePassRecurringReward();
		}

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x06010AA7 RID: 68263 RVA: 0x00270C7A File Offset: 0x0026EE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbBattlePassRecurringReward> Parser
		{
			get
			{
				return PbBattlePassRecurringReward._parser;
			}
		}

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x06010AA8 RID: 68264 RVA: 0x00270C81 File Offset: 0x0026EE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x06010AA9 RID: 68265 RVA: 0x00270C84 File Offset: 0x0026EE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePassRecurringReward.Descriptor;
			}
		}

		// Token: 0x06010AAA RID: 68266 RVA: 0x00270C8B File Offset: 0x0026EE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassRecurringReward()
		{
		}

		// Token: 0x06010AAB RID: 68267 RVA: 0x00270C93 File Offset: 0x0026EE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassRecurringReward(PbBattlePassRecurringReward other) : this()
		{
			this.type_ = other.type_;
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AAC RID: 68268 RVA: 0x00270CD0 File Offset: 0x0026EED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassRecurringReward Clone()
		{
			return new PbBattlePassRecurringReward(this);
		}

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x06010AAD RID: 68269 RVA: 0x00270CD8 File Offset: 0x0026EED8
		// (set) Token: 0x06010AAE RID: 68270 RVA: 0x00270CE0 File Offset: 0x0026EEE0
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

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x06010AAF RID: 68271 RVA: 0x00270CE9 File Offset: 0x0026EEE9
		// (set) Token: 0x06010AB0 RID: 68272 RVA: 0x00270CF1 File Offset: 0x0026EEF1
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

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x06010AB1 RID: 68273 RVA: 0x00270CFA File Offset: 0x0026EEFA
		// (set) Token: 0x06010AB2 RID: 68274 RVA: 0x00270D02 File Offset: 0x0026EF02
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

		// Token: 0x06010AB3 RID: 68275 RVA: 0x00270D0B File Offset: 0x0026EF0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePassRecurringReward);
		}

		// Token: 0x06010AB4 RID: 68276 RVA: 0x00270D1C File Offset: 0x0026EF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePassRecurringReward other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010AB5 RID: 68277 RVA: 0x00270D78 File Offset: 0x0026EF78
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

		// Token: 0x06010AB6 RID: 68278 RVA: 0x00270DEF File Offset: 0x0026EFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010AB7 RID: 68279 RVA: 0x00270DFC File Offset: 0x0026EFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AB8 RID: 68280 RVA: 0x00270E08 File Offset: 0x0026F008
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

		// Token: 0x06010AB9 RID: 68281 RVA: 0x00270E7C File Offset: 0x0026F07C
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

		// Token: 0x06010ABA RID: 68282 RVA: 0x00270EEC File Offset: 0x0026F0EC
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

		// Token: 0x06010ABB RID: 68283 RVA: 0x00270F50 File Offset: 0x0026F150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010ABC RID: 68284 RVA: 0x00270F5C File Offset: 0x0026F15C
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

		// Token: 0x040069F5 RID: 27125
		private static readonly MessageParser<PbBattlePassRecurringReward> _parser = new MessageParser<PbBattlePassRecurringReward>(() => new PbBattlePassRecurringReward());

		// Token: 0x040069F6 RID: 27126
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069F7 RID: 27127
		public const int TypeFieldNumber = 1;

		// Token: 0x040069F8 RID: 27128
		private BattlePassType type_;

		// Token: 0x040069F9 RID: 27129
		public const int ItemIdFieldNumber = 2;

		// Token: 0x040069FA RID: 27130
		private int itemId_;

		// Token: 0x040069FB RID: 27131
		public const int CountFieldNumber = 3;

		// Token: 0x040069FC RID: 27132
		private int count_;
	}
}
