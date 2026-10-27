using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144A RID: 5194
	public sealed class TrapDefenseSlot : IMessage<TrapDefenseSlot>, IMessage, IEquatable<TrapDefenseSlot>, IDeepCloneable<TrapDefenseSlot>, IBufferMessage
	{
		// Token: 0x0601B828 RID: 112680 RVA: 0x003FB9CC File Offset: 0x003F9BCC
		[NullableContext(1)]
		public static TrapDefenseSlot Create()
		{
			return new TrapDefenseSlot();
		}

		// Token: 0x17005CC4 RID: 23748
		// (get) Token: 0x0601B829 RID: 112681 RVA: 0x003FB9D3 File Offset: 0x003F9BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TrapDefenseSlot> Parser
		{
			get
			{
				return TrapDefenseSlot._parser;
			}
		}

		// Token: 0x17005CC5 RID: 23749
		// (get) Token: 0x0601B82A RID: 112682 RVA: 0x003FB9DA File Offset: 0x003F9BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CC6 RID: 23750
		// (get) Token: 0x0601B82B RID: 112683 RVA: 0x003FB9DD File Offset: 0x003F9BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSlot.Descriptor;
			}
		}

		// Token: 0x0601B82C RID: 112684 RVA: 0x003FB9E4 File Offset: 0x003F9BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlot()
		{
		}

		// Token: 0x0601B82D RID: 112685 RVA: 0x003FB9EC File Offset: 0x003F9BEC
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

		// Token: 0x0601B82E RID: 112686 RVA: 0x003FBA51 File Offset: 0x003F9C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlot Clone()
		{
			return new TrapDefenseSlot(this);
		}

		// Token: 0x17005CC7 RID: 23751
		// (get) Token: 0x0601B82F RID: 112687 RVA: 0x003FBA59 File Offset: 0x003F9C59
		// (set) Token: 0x0601B830 RID: 112688 RVA: 0x003FBA61 File Offset: 0x003F9C61
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

		// Token: 0x17005CC8 RID: 23752
		// (get) Token: 0x0601B831 RID: 112689 RVA: 0x003FBA6A File Offset: 0x003F9C6A
		// (set) Token: 0x0601B832 RID: 112690 RVA: 0x003FBA82 File Offset: 0x003F9C82
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

		// Token: 0x17005CC9 RID: 23753
		// (get) Token: 0x0601B833 RID: 112691 RVA: 0x003FBA98 File Offset: 0x003F9C98
		// (set) Token: 0x0601B834 RID: 112692 RVA: 0x003FBAB0 File Offset: 0x003F9CB0
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

		// Token: 0x17005CCA RID: 23754
		// (get) Token: 0x0601B835 RID: 112693 RVA: 0x003FBAC6 File Offset: 0x003F9CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSlot.EquipOneofCase EquipCase
		{
			get
			{
				return this.equipCase_;
			}
		}

		// Token: 0x0601B836 RID: 112694 RVA: 0x003FBACE File Offset: 0x003F9CCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEquip()
		{
			this.equipCase_ = TrapDefenseSlot.EquipOneofCase.None;
			this.equip_ = null;
		}

		// Token: 0x0601B837 RID: 112695 RVA: 0x003FBADE File Offset: 0x003F9CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSlot);
		}

		// Token: 0x0601B838 RID: 112696 RVA: 0x003FBAEC File Offset: 0x003F9CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSlot other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && object.Equals(this.Building, other.Building) && object.Equals(this.Auxiliary, other.Auxiliary) && this.EquipCase == other.EquipCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B839 RID: 112697 RVA: 0x003FBB60 File Offset: 0x003F9D60
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

		// Token: 0x0601B83A RID: 112698 RVA: 0x003FBBD6 File Offset: 0x003F9DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B83B RID: 112699 RVA: 0x003FBBE3 File Offset: 0x003F9DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B83C RID: 112700 RVA: 0x003FBBEC File Offset: 0x003F9DEC
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

		// Token: 0x0601B83D RID: 112701 RVA: 0x003FBC64 File Offset: 0x003F9E64
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

		// Token: 0x0601B83E RID: 112702 RVA: 0x003FBCD4 File Offset: 0x003F9ED4
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

		// Token: 0x0601B83F RID: 112703 RVA: 0x003FBD6B File Offset: 0x003F9F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B840 RID: 112704 RVA: 0x003FBD74 File Offset: 0x003F9F74
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

		// Token: 0x04009EAE RID: 40622
		private static readonly MessageParser<TrapDefenseSlot> _parser = new MessageParser<TrapDefenseSlot>(() => new TrapDefenseSlot());

		// Token: 0x04009EAF RID: 40623
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EB0 RID: 40624
		public const int SlotFieldNumber = 1;

		// Token: 0x04009EB1 RID: 40625
		private int slot_;

		// Token: 0x04009EB2 RID: 40626
		public const int BuildingFieldNumber = 2;

		// Token: 0x04009EB3 RID: 40627
		public const int AuxiliaryFieldNumber = 3;

		// Token: 0x04009EB4 RID: 40628
		private object equip_;

		// Token: 0x04009EB5 RID: 40629
		private TrapDefenseSlot.EquipOneofCase equipCase_;

		// Token: 0x020019DF RID: 6623
		public enum EquipOneofCase
		{
			// Token: 0x0400CAB2 RID: 51890
			None,
			// Token: 0x0400CAB3 RID: 51891
			Building = 2,
			// Token: 0x0400CAB4 RID: 51892
			Auxiliary
		}
	}
}
