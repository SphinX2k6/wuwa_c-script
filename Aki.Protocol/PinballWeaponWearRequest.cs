using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5F RID: 3423
	[NetMessage(EMessageId.PinballWeaponWearRequest)]
	public sealed class PinballWeaponWearRequest : IMessage<PinballWeaponWearRequest>, IMessage, IEquatable<PinballWeaponWearRequest>, IDeepCloneable<PinballWeaponWearRequest>, IBufferMessage
	{
		// Token: 0x060127A8 RID: 75688 RVA: 0x002B28D1 File Offset: 0x002B0AD1
		[NullableContext(1)]
		public static PinballWeaponWearRequest Create()
		{
			return new PinballWeaponWearRequest();
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x060127A9 RID: 75689 RVA: 0x002B28D8 File Offset: 0x002B0AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x060127AA RID: 75690 RVA: 0x002B28DB File Offset: 0x002B0ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeaponWearRequest.Descriptor;
			}
		}

		// Token: 0x060127AB RID: 75691 RVA: 0x002B28E2 File Offset: 0x002B0AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearRequest()
		{
		}

		// Token: 0x060127AC RID: 75692 RVA: 0x002B28EA File Offset: 0x002B0AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearRequest(PinballWeaponWearRequest other) : this()
		{
			this.weaponInc_ = other.weaponInc_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127AD RID: 75693 RVA: 0x002B291B File Offset: 0x002B0B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeaponWearRequest Clone()
		{
			return new PinballWeaponWearRequest(this);
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x060127AE RID: 75694 RVA: 0x002B2923 File Offset: 0x002B0B23
		// (set) Token: 0x060127AF RID: 75695 RVA: 0x002B292B File Offset: 0x002B0B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponInc
		{
			get
			{
				return this.weaponInc_;
			}
			set
			{
				this.weaponInc_ = value;
			}
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x060127B0 RID: 75696 RVA: 0x002B2934 File Offset: 0x002B0B34
		// (set) Token: 0x060127B1 RID: 75697 RVA: 0x002B293C File Offset: 0x002B0B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x060127B2 RID: 75698 RVA: 0x002B2945 File Offset: 0x002B0B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeaponWearRequest);
		}

		// Token: 0x060127B3 RID: 75699 RVA: 0x002B2953 File Offset: 0x002B0B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeaponWearRequest other)
		{
			return other != null && (other == this || (this.WeaponInc == other.WeaponInc && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127B4 RID: 75700 RVA: 0x002B2994 File Offset: 0x002B0B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponInc != 0)
			{
				num ^= this.WeaponInc.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060127B5 RID: 75701 RVA: 0x002B29EC File Offset: 0x002B0BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127B6 RID: 75702 RVA: 0x002B29F9 File Offset: 0x002B0BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127B7 RID: 75703 RVA: 0x002B2A04 File Offset: 0x002B0C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.WeaponInc != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WeaponInc);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127B8 RID: 75704 RVA: 0x002B2A5C File Offset: 0x002B0C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponInc != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponInc);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060127B9 RID: 75705 RVA: 0x002B2AB4 File Offset: 0x002B0CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeaponWearRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponInc != 0)
			{
				this.WeaponInc = other.WeaponInc;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060127BA RID: 75706 RVA: 0x002B2B04 File Offset: 0x002B0D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127BB RID: 75707 RVA: 0x002B2B10 File Offset: 0x002B0D10
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WeaponInc = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007342 RID: 29506
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007343 RID: 29507
		public const int WeaponIncFieldNumber = 8;

		// Token: 0x04007344 RID: 29508
		private int weaponInc_;

		// Token: 0x04007345 RID: 29509
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04007346 RID: 29510
		private int roleId_;
	}
}
