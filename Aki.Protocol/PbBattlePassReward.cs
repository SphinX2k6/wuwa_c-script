using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEF RID: 3055
	public sealed class PbBattlePassReward : IMessage<PbBattlePassReward>, IMessage, IEquatable<PbBattlePassReward>, IDeepCloneable<PbBattlePassReward>, IBufferMessage
	{
		// Token: 0x060109BE RID: 68030 RVA: 0x0026F27A File Offset: 0x0026D47A
		[NullableContext(1)]
		public static PbBattlePassReward Create()
		{
			return new PbBattlePassReward();
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x060109BF RID: 68031 RVA: 0x0026F281 File Offset: 0x0026D481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbBattlePassReward> Parser
		{
			get
			{
				return PbBattlePassReward._parser;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x060109C0 RID: 68032 RVA: 0x0026F288 File Offset: 0x0026D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x060109C1 RID: 68033 RVA: 0x0026F28B File Offset: 0x0026D48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePassReward.Descriptor;
			}
		}

		// Token: 0x060109C2 RID: 68034 RVA: 0x0026F292 File Offset: 0x0026D492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassReward()
		{
		}

		// Token: 0x060109C3 RID: 68035 RVA: 0x0026F29A File Offset: 0x0026D49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassReward(PbBattlePassReward other) : this()
		{
			this.level_ = other.level_;
			this.itemId_ = other.itemId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060109C4 RID: 68036 RVA: 0x0026F2D7 File Offset: 0x0026D4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassReward Clone()
		{
			return new PbBattlePassReward(this);
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x060109C5 RID: 68037 RVA: 0x0026F2DF File Offset: 0x0026D4DF
		// (set) Token: 0x060109C6 RID: 68038 RVA: 0x0026F2E7 File Offset: 0x0026D4E7
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

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x060109C7 RID: 68039 RVA: 0x0026F2F0 File Offset: 0x0026D4F0
		// (set) Token: 0x060109C8 RID: 68040 RVA: 0x0026F2F8 File Offset: 0x0026D4F8
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

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x060109C9 RID: 68041 RVA: 0x0026F301 File Offset: 0x0026D501
		// (set) Token: 0x060109CA RID: 68042 RVA: 0x0026F309 File Offset: 0x0026D509
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

		// Token: 0x060109CB RID: 68043 RVA: 0x0026F312 File Offset: 0x0026D512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePassReward);
		}

		// Token: 0x060109CC RID: 68044 RVA: 0x0026F320 File Offset: 0x0026D520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePassReward other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.ItemId == other.ItemId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060109CD RID: 68045 RVA: 0x0026F37C File Offset: 0x0026D57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Type != BattlePassType.Free)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060109CE RID: 68046 RVA: 0x0026F3F3 File Offset: 0x0026D5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060109CF RID: 68047 RVA: 0x0026F400 File Offset: 0x0026D600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060109D0 RID: 68048 RVA: 0x0026F40C File Offset: 0x0026D60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this.Type != BattlePassType.Free)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060109D1 RID: 68049 RVA: 0x0026F480 File Offset: 0x0026D680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Type != BattlePassType.Free)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060109D2 RID: 68050 RVA: 0x0026F4F0 File Offset: 0x0026D6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbBattlePassReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Type != BattlePassType.Free)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060109D3 RID: 68051 RVA: 0x0026F554 File Offset: 0x0026D754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109D4 RID: 68052 RVA: 0x0026F560 File Offset: 0x0026D760
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
							this.Type = (BattlePassType)input.ReadEnum();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006A11 RID: 27153
		private static readonly MessageParser<PbBattlePassReward> _parser = new MessageParser<PbBattlePassReward>(() => new PbBattlePassReward());

		// Token: 0x04006A12 RID: 27154
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A13 RID: 27155
		public const int LevelFieldNumber = 1;

		// Token: 0x04006A14 RID: 27156
		private int level_;

		// Token: 0x04006A15 RID: 27157
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04006A16 RID: 27158
		private int itemId_;

		// Token: 0x04006A17 RID: 27159
		public const int TypeFieldNumber = 3;

		// Token: 0x04006A18 RID: 27160
		private BattlePassType type_;
	}
}
