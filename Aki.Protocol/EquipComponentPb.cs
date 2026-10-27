using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D4 RID: 1236
	public sealed class EquipComponentPb : IMessage<EquipComponentPb>, IMessage, IEquatable<EquipComponentPb>, IDeepCloneable<EquipComponentPb>, IBufferMessage
	{
		// Token: 0x06007560 RID: 30048 RVA: 0x0011F643 File Offset: 0x0011D843
		[NullableContext(1)]
		public static EquipComponentPb Create()
		{
			return new EquipComponentPb();
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06007561 RID: 30049 RVA: 0x0011F64A File Offset: 0x0011D84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06007562 RID: 30050 RVA: 0x0011F64D File Offset: 0x0011D84D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquipComponentPb.Descriptor;
			}
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x0011F654 File Offset: 0x0011D854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb()
		{
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x0011F65C File Offset: 0x0011D85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb(EquipComponentPb other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.weaponBreachLevel_ = other.weaponBreachLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x0011F68D File Offset: 0x0011D88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EquipComponentPb Clone()
		{
			return new EquipComponentPb(this);
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06007566 RID: 30054 RVA: 0x0011F695 File Offset: 0x0011D895
		// (set) Token: 0x06007567 RID: 30055 RVA: 0x0011F69D File Offset: 0x0011D89D
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

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06007568 RID: 30056 RVA: 0x0011F6A6 File Offset: 0x0011D8A6
		// (set) Token: 0x06007569 RID: 30057 RVA: 0x0011F6AE File Offset: 0x0011D8AE
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

		// Token: 0x0600756A RID: 30058 RVA: 0x0011F6B7 File Offset: 0x0011D8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquipComponentPb);
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x0011F6C5 File Offset: 0x0011D8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EquipComponentPb other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.WeaponBreachLevel == other.WeaponBreachLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x0011F704 File Offset: 0x0011D904
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

		// Token: 0x0600756D RID: 30061 RVA: 0x0011F75C File Offset: 0x0011D95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x0011F769 File Offset: 0x0011D969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x0011F774 File Offset: 0x0011D974
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

		// Token: 0x06007570 RID: 30064 RVA: 0x0011F7CC File Offset: 0x0011D9CC
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

		// Token: 0x06007571 RID: 30065 RVA: 0x0011F824 File Offset: 0x0011DA24
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

		// Token: 0x06007572 RID: 30066 RVA: 0x0011F874 File Offset: 0x0011DA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x0011F880 File Offset: 0x0011DA80
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

		// Token: 0x04003DAE RID: 15790
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DAF RID: 15791
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04003DB0 RID: 15792
		private int weaponId_;

		// Token: 0x04003DB1 RID: 15793
		public const int WeaponBreachLevelFieldNumber = 2;

		// Token: 0x04003DB2 RID: 15794
		private int weaponBreachLevel_;
	}
}
