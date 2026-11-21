using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110F RID: 4367
	public sealed class RoleWeaponSkinComponentPb : IMessage<RoleWeaponSkinComponentPb>, IMessage, IEquatable<RoleWeaponSkinComponentPb>, IDeepCloneable<RoleWeaponSkinComponentPb>, IBufferMessage
	{
		// Token: 0x06017575 RID: 95605 RVA: 0x00365697 File Offset: 0x00363897
		[NullableContext(1)]
		public static RoleWeaponSkinComponentPb Create()
		{
			return new RoleWeaponSkinComponentPb();
		}

		// Token: 0x17004E6D RID: 20077
		// (get) Token: 0x06017576 RID: 95606 RVA: 0x0036569E File Offset: 0x0036389E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E6E RID: 20078
		// (get) Token: 0x06017577 RID: 95607 RVA: 0x003656A1 File Offset: 0x003638A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleWeaponSkinComponentPb.Descriptor;
			}
		}

		// Token: 0x06017578 RID: 95608 RVA: 0x003656A8 File Offset: 0x003638A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb()
		{
		}

		// Token: 0x06017579 RID: 95609 RVA: 0x003656B0 File Offset: 0x003638B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb(RoleWeaponSkinComponentPb other) : this()
		{
			this.weaponSkinId_ = other.weaponSkinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601757A RID: 95610 RVA: 0x003656D5 File Offset: 0x003638D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleWeaponSkinComponentPb Clone()
		{
			return new RoleWeaponSkinComponentPb(this);
		}

		// Token: 0x17004E6F RID: 20079
		// (get) Token: 0x0601757B RID: 95611 RVA: 0x003656DD File Offset: 0x003638DD
		// (set) Token: 0x0601757C RID: 95612 RVA: 0x003656E5 File Offset: 0x003638E5
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

		// Token: 0x0601757D RID: 95613 RVA: 0x003656EE File Offset: 0x003638EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleWeaponSkinComponentPb);
		}

		// Token: 0x0601757E RID: 95614 RVA: 0x003656FC File Offset: 0x003638FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleWeaponSkinComponentPb other)
		{
			return other != null && (other == this || (this.WeaponSkinId == other.WeaponSkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601757F RID: 95615 RVA: 0x0036572C File Offset: 0x0036392C
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

		// Token: 0x06017580 RID: 95616 RVA: 0x0036576B File Offset: 0x0036396B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017581 RID: 95617 RVA: 0x00365778 File Offset: 0x00363978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017582 RID: 95618 RVA: 0x00365781 File Offset: 0x00363981
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

		// Token: 0x06017583 RID: 95619 RVA: 0x003657B4 File Offset: 0x003639B4
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

		// Token: 0x06017584 RID: 95620 RVA: 0x003657F2 File Offset: 0x003639F2
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

		// Token: 0x06017585 RID: 95621 RVA: 0x00365823 File Offset: 0x00363A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017586 RID: 95622 RVA: 0x0036582C File Offset: 0x00363A2C
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

		// Token: 0x04008B78 RID: 35704
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B79 RID: 35705
		public const int WeaponSkinIdFieldNumber = 1;

		// Token: 0x04008B7A RID: 35706
		private int weaponSkinId_;
	}
}
