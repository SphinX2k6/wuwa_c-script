using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200033F RID: 831
	public sealed class DangoBrawlDamageSegment : IMessage<DangoBrawlDamageSegment>, IMessage, IEquatable<DangoBrawlDamageSegment>, IDeepCloneable<DangoBrawlDamageSegment>, IBufferMessage
	{
		// Token: 0x06005345 RID: 21317 RVA: 0x000CB0B4 File Offset: 0x000C92B4
		[NullableContext(1)]
		public static DangoBrawlDamageSegment Create()
		{
			return new DangoBrawlDamageSegment();
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x000CB0BB File Offset: 0x000C92BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlDamageSegment> Parser
		{
			get
			{
				return DangoBrawlDamageSegment._parser;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x000CB0C2 File Offset: 0x000C92C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x000CB0C5 File Offset: 0x000C92C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlDamageSegment.Descriptor;
			}
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x000CB0CC File Offset: 0x000C92CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageSegment()
		{
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x000CB0D4 File Offset: 0x000C92D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageSegment(DangoBrawlDamageSegment other) : this()
		{
			this.damageType_ = other.damageType_;
			this.damage_ = other.damage_;
			this.itemUId_ = other.itemUId_;
			this.showType_ = other.showType_;
			this.buffConfigId_ = other.buffConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x000CB134 File Offset: 0x000C9334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageSegment Clone()
		{
			return new DangoBrawlDamageSegment(this);
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x000CB13C File Offset: 0x000C933C
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x000CB144 File Offset: 0x000C9344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlDamageType DamageType
		{
			get
			{
				return this.damageType_;
			}
			set
			{
				this.damageType_ = value;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x000CB14D File Offset: 0x000C934D
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x000CB155 File Offset: 0x000C9355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x000CB15E File Offset: 0x000C935E
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x000CB166 File Offset: 0x000C9366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUId
		{
			get
			{
				return this.itemUId_;
			}
			set
			{
				this.itemUId_ = value;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x000CB16F File Offset: 0x000C936F
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x000CB177 File Offset: 0x000C9377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowType
		{
			get
			{
				return this.showType_;
			}
			set
			{
				this.showType_ = value;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x000CB180 File Offset: 0x000C9380
		// (set) Token: 0x06005355 RID: 21333 RVA: 0x000CB188 File Offset: 0x000C9388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffConfigId
		{
			get
			{
				return this.buffConfigId_;
			}
			set
			{
				this.buffConfigId_ = value;
			}
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x000CB191 File Offset: 0x000C9391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlDamageSegment);
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x000CB1A0 File Offset: 0x000C93A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlDamageSegment other)
		{
			return other != null && (other == this || (this.DamageType == other.DamageType && this.Damage == other.Damage && this.ItemUId == other.ItemUId && this.ShowType == other.ShowType && this.BuffConfigId == other.BuffConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x000CB21C File Offset: 0x000C941C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				num ^= this.DamageType.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this.ItemUId != 0)
			{
				num ^= this.ItemUId.GetHashCode();
			}
			if (this.ShowType != 0)
			{
				num ^= this.ShowType.GetHashCode();
			}
			if (this.BuffConfigId != 0)
			{
				num ^= this.BuffConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x000CB2C5 File Offset: 0x000C94C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x000CB2D2 File Offset: 0x000C94D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x000CB2DC File Offset: 0x000C94DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.DamageType);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Damage);
			}
			if (this.ItemUId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemUId);
			}
			if (this.ShowType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ShowType);
			}
			if (this.BuffConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BuffConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x000CB388 File Offset: 0x000C9588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DamageType);
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Damage);
			}
			if (this.ItemUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUId);
			}
			if (this.ShowType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowType);
			}
			if (this.BuffConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x000CB428 File Offset: 0x000C9628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlDamageSegment other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DamageType != DangoBrawlDamageType.DangoBrawlDamageWeapon)
			{
				this.DamageType = other.DamageType;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			if (other.ItemUId != 0)
			{
				this.ItemUId = other.ItemUId;
			}
			if (other.ShowType != 0)
			{
				this.ShowType = other.ShowType;
			}
			if (other.BuffConfigId != 0)
			{
				this.BuffConfigId = other.BuffConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x000CB4B4 File Offset: 0x000C96B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x000CB4C0 File Offset: 0x000C96C0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.DamageType = (DangoBrawlDamageType)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.Damage = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ItemUId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ShowType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.BuffConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400336C RID: 13164
		private static readonly MessageParser<DangoBrawlDamageSegment> _parser = new MessageParser<DangoBrawlDamageSegment>(() => new DangoBrawlDamageSegment());

		// Token: 0x0400336D RID: 13165
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400336E RID: 13166
		public const int DamageTypeFieldNumber = 1;

		// Token: 0x0400336F RID: 13167
		private DangoBrawlDamageType damageType_;

		// Token: 0x04003370 RID: 13168
		public const int DamageFieldNumber = 2;

		// Token: 0x04003371 RID: 13169
		private int damage_;

		// Token: 0x04003372 RID: 13170
		public const int ItemUIdFieldNumber = 3;

		// Token: 0x04003373 RID: 13171
		private int itemUId_;

		// Token: 0x04003374 RID: 13172
		public const int ShowTypeFieldNumber = 4;

		// Token: 0x04003375 RID: 13173
		private int showType_;

		// Token: 0x04003376 RID: 13174
		public const int BuffConfigIdFieldNumber = 5;

		// Token: 0x04003377 RID: 13175
		private int buffConfigId_;
	}
}
