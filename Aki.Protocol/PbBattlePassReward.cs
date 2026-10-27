using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFF RID: 3071
	public sealed class PbBattlePassReward : IMessage<PbBattlePassReward>, IMessage, IEquatable<PbBattlePassReward>, IDeepCloneable<PbBattlePassReward>, IBufferMessage
	{
		// Token: 0x06010ABE RID: 68286 RVA: 0x00270FE2 File Offset: 0x0026F1E2
		[NullableContext(1)]
		public static PbBattlePassReward Create()
		{
			return new PbBattlePassReward();
		}

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x06010ABF RID: 68287 RVA: 0x00270FE9 File Offset: 0x0026F1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbBattlePassReward> Parser
		{
			get
			{
				return PbBattlePassReward._parser;
			}
		}

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x06010AC0 RID: 68288 RVA: 0x00270FF0 File Offset: 0x0026F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x06010AC1 RID: 68289 RVA: 0x00270FF3 File Offset: 0x0026F1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePassReward.Descriptor;
			}
		}

		// Token: 0x06010AC2 RID: 68290 RVA: 0x00270FFA File Offset: 0x0026F1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassReward()
		{
		}

		// Token: 0x06010AC3 RID: 68291 RVA: 0x00271002 File Offset: 0x0026F202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassReward(PbBattlePassReward other) : this()
		{
			this.level_ = other.level_;
			this.itemId_ = other.itemId_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010AC4 RID: 68292 RVA: 0x0027103F File Offset: 0x0026F23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassReward Clone()
		{
			return new PbBattlePassReward(this);
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x06010AC5 RID: 68293 RVA: 0x00271047 File Offset: 0x0026F247
		// (set) Token: 0x06010AC6 RID: 68294 RVA: 0x0027104F File Offset: 0x0026F24F
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

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x06010AC7 RID: 68295 RVA: 0x00271058 File Offset: 0x0026F258
		// (set) Token: 0x06010AC8 RID: 68296 RVA: 0x00271060 File Offset: 0x0026F260
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

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x06010AC9 RID: 68297 RVA: 0x00271069 File Offset: 0x0026F269
		// (set) Token: 0x06010ACA RID: 68298 RVA: 0x00271071 File Offset: 0x0026F271
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

		// Token: 0x06010ACB RID: 68299 RVA: 0x0027107A File Offset: 0x0026F27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePassReward);
		}

		// Token: 0x06010ACC RID: 68300 RVA: 0x00271088 File Offset: 0x0026F288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePassReward other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.ItemId == other.ItemId && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010ACD RID: 68301 RVA: 0x002710E4 File Offset: 0x0026F2E4
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

		// Token: 0x06010ACE RID: 68302 RVA: 0x0027115B File Offset: 0x0026F35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010ACF RID: 68303 RVA: 0x00271168 File Offset: 0x0026F368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AD0 RID: 68304 RVA: 0x00271174 File Offset: 0x0026F374
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

		// Token: 0x06010AD1 RID: 68305 RVA: 0x002711E8 File Offset: 0x0026F3E8
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

		// Token: 0x06010AD2 RID: 68306 RVA: 0x00271258 File Offset: 0x0026F458
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

		// Token: 0x06010AD3 RID: 68307 RVA: 0x002712BC File Offset: 0x0026F4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010AD4 RID: 68308 RVA: 0x002712C8 File Offset: 0x0026F4C8
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

		// Token: 0x040069FD RID: 27133
		private static readonly MessageParser<PbBattlePassReward> _parser = new MessageParser<PbBattlePassReward>(() => new PbBattlePassReward());

		// Token: 0x040069FE RID: 27134
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069FF RID: 27135
		public const int LevelFieldNumber = 1;

		// Token: 0x04006A00 RID: 27136
		private int level_;

		// Token: 0x04006A01 RID: 27137
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04006A02 RID: 27138
		private int itemId_;

		// Token: 0x04006A03 RID: 27139
		public const int TypeFieldNumber = 3;

		// Token: 0x04006A04 RID: 27140
		private BattlePassType type_;
	}
}
