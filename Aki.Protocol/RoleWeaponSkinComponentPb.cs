using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D5 RID: 4309
	public sealed class RoleWeaponSkinComponentPb : IMessage<RoleWeaponSkinComponentPb>, IMessage, IEquatable<RoleWeaponSkinComponentPb>, IDeepCloneable<RoleWeaponSkinComponentPb>, IBufferMessage
	{
		// Token: 0x06016FD4 RID: 94164 RVA: 0x0035633F File Offset: 0x0035453F
		[NullableContext(1)]
		public static RoleWeaponSkinComponentPb Create()
		{
			return new RoleWeaponSkinComponentPb();
		}

		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x06016FD5 RID: 94165 RVA: 0x00356346 File Offset: 0x00354546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x06016FD6 RID: 94166 RVA: 0x00356349 File Offset: 0x00354549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleWeaponSkinComponentPb.Descriptor;
			}
		}

		// Token: 0x06016FD7 RID: 94167 RVA: 0x00356350 File Offset: 0x00354550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb()
		{
		}

		// Token: 0x06016FD8 RID: 94168 RVA: 0x00356358 File Offset: 0x00354558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb(RoleWeaponSkinComponentPb other) : this()
		{
			this.weaponSkinId_ = other.weaponSkinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016FD9 RID: 94169 RVA: 0x0035637D File Offset: 0x0035457D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb Clone()
		{
			return new RoleWeaponSkinComponentPb(this);
		}

		// Token: 0x17004D03 RID: 19715
		// (get) Token: 0x06016FDA RID: 94170 RVA: 0x00356385 File Offset: 0x00354585
		// (set) Token: 0x06016FDB RID: 94171 RVA: 0x0035638D File Offset: 0x0035458D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponSkinId
		{
			get
			{
				return this.weaponSkinId_;
			}
			set
			{
				this.weaponSkinId_ = value;
			}
		}

		// Token: 0x06016FDC RID: 94172 RVA: 0x00356396 File Offset: 0x00354596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleWeaponSkinComponentPb);
		}

		// Token: 0x06016FDD RID: 94173 RVA: 0x003563A4 File Offset: 0x003545A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleWeaponSkinComponentPb other)
		{
			return other != null && (other == this || (this.WeaponSkinId == other.WeaponSkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016FDE RID: 94174 RVA: 0x003563D4 File Offset: 0x003545D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponSkinId != 0)
			{
				num ^= this.WeaponSkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016FDF RID: 94175 RVA: 0x00356413 File Offset: 0x00354613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016FE0 RID: 94176 RVA: 0x00356420 File Offset: 0x00354620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016FE1 RID: 94177 RVA: 0x00356429 File Offset: 0x00354629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponSkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016FE2 RID: 94178 RVA: 0x0035645C File Offset: 0x0035465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponSkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016FE3 RID: 94179 RVA: 0x0035649A File Offset: 0x0035469A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleWeaponSkinComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponSkinId != 0)
			{
				this.WeaponSkinId = other.WeaponSkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016FE4 RID: 94180 RVA: 0x003564CB File Offset: 0x003546CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016FE5 RID: 94181 RVA: 0x003564D4 File Offset: 0x003546D4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeaponSkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040088E5 RID: 35045
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088E6 RID: 35046
		public const int WeaponSkinIdFieldNumber = 1;

		// Token: 0x040088E7 RID: 35047
		private int weaponSkinId_;
	}
}
