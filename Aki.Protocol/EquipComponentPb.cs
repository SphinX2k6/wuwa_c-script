using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BD RID: 1213
	public sealed class EquipComponentPb : IMessage<EquipComponentPb>, IMessage, IEquatable<EquipComponentPb>, IDeepCloneable<EquipComponentPb>, IBufferMessage
	{
		// Token: 0x060073D0 RID: 29648 RVA: 0x0011C52B File Offset: 0x0011A72B
		[NullableContext(1)]
		public static EquipComponentPb Create()
		{
			return new EquipComponentPb();
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x060073D1 RID: 29649 RVA: 0x0011C532 File Offset: 0x0011A732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x060073D2 RID: 29650 RVA: 0x0011C535 File Offset: 0x0011A735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipComponentPb.Descriptor;
			}
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x0011C53C File Offset: 0x0011A73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb()
		{
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x0011C544 File Offset: 0x0011A744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb(EquipComponentPb other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.weaponBreachLevel_ = other.weaponBreachLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x0011C575 File Offset: 0x0011A775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb Clone()
		{
			return new EquipComponentPb(this);
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x060073D6 RID: 29654 RVA: 0x0011C57D File Offset: 0x0011A77D
		// (set) Token: 0x060073D7 RID: 29655 RVA: 0x0011C585 File Offset: 0x0011A785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x060073D8 RID: 29656 RVA: 0x0011C58E File Offset: 0x0011A78E
		// (set) Token: 0x060073D9 RID: 29657 RVA: 0x0011C596 File Offset: 0x0011A796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponBreachLevel
		{
			get
			{
				return this.weaponBreachLevel_;
			}
			set
			{
				this.weaponBreachLevel_ = value;
			}
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x0011C59F File Offset: 0x0011A79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipComponentPb);
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x0011C5AD File Offset: 0x0011A7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipComponentPb other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.WeaponBreachLevel == other.WeaponBreachLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x0011C5EC File Offset: 0x0011A7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.WeaponBreachLevel != 0)
			{
				num ^= this.WeaponBreachLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x0011C644 File Offset: 0x0011A844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x0011C651 File Offset: 0x0011A851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x0011C65C File Offset: 0x0011A85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.WeaponBreachLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WeaponBreachLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x0011C6B4 File Offset: 0x0011A8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.WeaponBreachLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponBreachLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x0011C70C File Offset: 0x0011A90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EquipComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.WeaponBreachLevel != 0)
			{
				this.WeaponBreachLevel = other.WeaponBreachLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x0011C75C File Offset: 0x0011A95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x0011C768 File Offset: 0x0011A968
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WeaponBreachLevel = input.ReadInt32();
					}
				}
				else
				{
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003D9A RID: 15770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D9B RID: 15771
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04003D9C RID: 15772
		private int weaponId_;

		// Token: 0x04003D9D RID: 15773
		public const int WeaponBreachLevelFieldNumber = 2;

		// Token: 0x04003D9E RID: 15774
		private int weaponBreachLevel_;
	}
}
