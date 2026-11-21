using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014BD RID: 5309
	public sealed class TrapDefenseSlot : IMessage<TrapDefenseSlot>, IMessage, IEquatable<TrapDefenseSlot>, IDeepCloneable<TrapDefenseSlot>, IBufferMessage
	{
		// Token: 0x0601C2B3 RID: 115379 RVA: 0x00416CA0 File Offset: 0x00414EA0
		[NullableContext(1)]
		public static TrapDefenseSlot Create()
		{
			return new TrapDefenseSlot();
		}

		// Token: 0x17005F59 RID: 24409
		// (get) Token: 0x0601C2B4 RID: 115380 RVA: 0x00416CA7 File Offset: 0x00414EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseSlot> Parser
		{
			get
			{
				return TrapDefenseSlot._parser;
			}
		}

		// Token: 0x17005F5A RID: 24410
		// (get) Token: 0x0601C2B5 RID: 115381 RVA: 0x00416CAE File Offset: 0x00414EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F5B RID: 24411
		// (get) Token: 0x0601C2B6 RID: 115382 RVA: 0x00416CB1 File Offset: 0x00414EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSlot.Descriptor;
			}
		}

		// Token: 0x0601C2B7 RID: 115383 RVA: 0x00416CB8 File Offset: 0x00414EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlot()
		{
		}

		// Token: 0x0601C2B8 RID: 115384 RVA: 0x00416CC0 File Offset: 0x00414EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlot(TrapDefenseSlot other) : this()
		{
			this.slot_ = other.slot_;
			TrapDefenseSlot.EquipOneofCase equipCase = other.EquipCase;
			if (equipCase != TrapDefenseSlot.EquipOneofCase.Building)
			{
				if (equipCase == TrapDefenseSlot.EquipOneofCase.Auxiliary)
				{
					this.Auxiliary = other.Auxiliary.Clone();
				}
			}
			else
			{
				this.Building = other.Building.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2B9 RID: 115385 RVA: 0x00416D25 File Offset: 0x00414F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlot Clone()
		{
			return new TrapDefenseSlot(this);
		}

		// Token: 0x17005F5C RID: 24412
		// (get) Token: 0x0601C2BA RID: 115386 RVA: 0x00416D2D File Offset: 0x00414F2D
		// (set) Token: 0x0601C2BB RID: 115387 RVA: 0x00416D35 File Offset: 0x00414F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x17005F5D RID: 24413
		// (get) Token: 0x0601C2BC RID: 115388 RVA: 0x00416D3E File Offset: 0x00414F3E
		// (set) Token: 0x0601C2BD RID: 115389 RVA: 0x00416D56 File Offset: 0x00414F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingInfo Building
		{
			get
			{
				if (this.equipCase_ != TrapDefenseSlot.EquipOneofCase.Building)
				{
					return null;
				}
				return (TrapDefenseBuildingInfo)this.equip_;
			}
			set
			{
				this.equip_ = value;
				this.equipCase_ = ((value == null) ? TrapDefenseSlot.EquipOneofCase.None : TrapDefenseSlot.EquipOneofCase.Building);
			}
		}

		// Token: 0x17005F5E RID: 24414
		// (get) Token: 0x0601C2BE RID: 115390 RVA: 0x00416D6C File Offset: 0x00414F6C
		// (set) Token: 0x0601C2BF RID: 115391 RVA: 0x00416D84 File Offset: 0x00414F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryInfo Auxiliary
		{
			get
			{
				if (this.equipCase_ != TrapDefenseSlot.EquipOneofCase.Auxiliary)
				{
					return null;
				}
				return (TrapDefenseAuxiliaryInfo)this.equip_;
			}
			set
			{
				this.equip_ = value;
				this.equipCase_ = ((value == null) ? TrapDefenseSlot.EquipOneofCase.None : TrapDefenseSlot.EquipOneofCase.Auxiliary);
			}
		}

		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x0601C2C0 RID: 115392 RVA: 0x00416D9A File Offset: 0x00414F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlot.EquipOneofCase EquipCase
		{
			get
			{
				return this.equipCase_;
			}
		}

		// Token: 0x0601C2C1 RID: 115393 RVA: 0x00416DA2 File Offset: 0x00414FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEquip()
		{
			this.equipCase_ = TrapDefenseSlot.EquipOneofCase.None;
			this.equip_ = null;
		}

		// Token: 0x0601C2C2 RID: 115394 RVA: 0x00416DB2 File Offset: 0x00414FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSlot);
		}

		// Token: 0x0601C2C3 RID: 115395 RVA: 0x00416DC0 File Offset: 0x00414FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSlot other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && object.Equals(this.Building, other.Building) && object.Equals(this.Auxiliary, other.Auxiliary) && this.EquipCase == other.EquipCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2C4 RID: 115396 RVA: 0x00416E34 File Offset: 0x00415034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Building)
			{
				num ^= this.Building.GetHashCode();
			}
			if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Auxiliary)
			{
				num ^= this.Auxiliary.GetHashCode();
			}
			num ^= (int)this.equipCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C2C5 RID: 115397 RVA: 0x00416EAA File Offset: 0x004150AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2C6 RID: 115398 RVA: 0x00416EB7 File Offset: 0x004150B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2C7 RID: 115399 RVA: 0x00416EC0 File Offset: 0x004150C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Slot);
			}
			if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Building)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Building);
			}
			if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Auxiliary)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Auxiliary);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C2C8 RID: 115400 RVA: 0x00416F38 File Offset: 0x00415138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Slot);
			}
			if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Building)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Building);
			}
			if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Auxiliary)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Auxiliary);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C2C9 RID: 115401 RVA: 0x00416FA8 File Offset: 0x004151A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSlot other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0)
			{
				this.Slot = other.Slot;
			}
			TrapDefenseSlot.EquipOneofCase equipCase = other.EquipCase;
			if (equipCase != TrapDefenseSlot.EquipOneofCase.Building)
			{
				if (equipCase == TrapDefenseSlot.EquipOneofCase.Auxiliary)
				{
					if (this.Auxiliary == null)
					{
						this.Auxiliary = new TrapDefenseAuxiliaryInfo();
					}
					this.Auxiliary.MergeFrom(other.Auxiliary);
				}
			}
			else
			{
				if (this.Building == null)
				{
					this.Building = new TrapDefenseBuildingInfo();
				}
				this.Building.MergeFrom(other.Building);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C2CA RID: 115402 RVA: 0x0041703F File Offset: 0x0041523F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2CB RID: 115403 RVA: 0x00417048 File Offset: 0x00415248
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
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							TrapDefenseAuxiliaryInfo trapDefenseAuxiliaryInfo = new TrapDefenseAuxiliaryInfo();
							if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Auxiliary)
							{
								trapDefenseAuxiliaryInfo.MergeFrom(this.Auxiliary);
							}
							input.ReadMessage(trapDefenseAuxiliaryInfo);
							this.Auxiliary = trapDefenseAuxiliaryInfo;
						}
					}
					else
					{
						TrapDefenseBuildingInfo trapDefenseBuildingInfo = new TrapDefenseBuildingInfo();
						if (this.equipCase_ == TrapDefenseSlot.EquipOneofCase.Building)
						{
							trapDefenseBuildingInfo.MergeFrom(this.Building);
						}
						input.ReadMessage(trapDefenseBuildingInfo);
						this.Building = trapDefenseBuildingInfo;
					}
				}
				else
				{
					this.Slot = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A2F5 RID: 41717
		private static readonly MessageParser<TrapDefenseSlot> _parser = new MessageParser<TrapDefenseSlot>(() => new TrapDefenseSlot());

		// Token: 0x0400A2F6 RID: 41718
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2F7 RID: 41719
		public const int SlotFieldNumber = 1;

		// Token: 0x0400A2F8 RID: 41720
		private int slot_;

		// Token: 0x0400A2F9 RID: 41721
		public const int BuildingFieldNumber = 2;

		// Token: 0x0400A2FA RID: 41722
		public const int AuxiliaryFieldNumber = 3;

		// Token: 0x0400A2FB RID: 41723
		private object equip_;

		// Token: 0x0400A2FC RID: 41724
		private TrapDefenseSlot.EquipOneofCase equipCase_;

		// Token: 0x02001A81 RID: 6785
		public enum EquipOneofCase
		{
			// Token: 0x0400D01D RID: 53277
			None,
			// Token: 0x0400D01E RID: 53278
			Building = 2,
			// Token: 0x0400D01F RID: 53279
			Auxiliary
		}
	}
}
