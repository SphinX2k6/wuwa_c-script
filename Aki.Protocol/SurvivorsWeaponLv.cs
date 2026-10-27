using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F4 RID: 4852
	public sealed class SurvivorsWeaponLv : IMessage<SurvivorsWeaponLv>, IMessage, IEquatable<SurvivorsWeaponLv>, IDeepCloneable<SurvivorsWeaponLv>, IBufferMessage
	{
		// Token: 0x06019CC3 RID: 105667 RVA: 0x003BFBEF File Offset: 0x003BDDEF
		[NullableContext(1)]
		public static SurvivorsWeaponLv Create()
		{
			return new SurvivorsWeaponLv();
		}

		// Token: 0x17005701 RID: 22273
		// (get) Token: 0x06019CC4 RID: 105668 RVA: 0x003BFBF6 File Offset: 0x003BDDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005702 RID: 22274
		// (get) Token: 0x06019CC5 RID: 105669 RVA: 0x003BFBF9 File Offset: 0x003BDDF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponLv.Descriptor;
			}
		}

		// Token: 0x06019CC6 RID: 105670 RVA: 0x003BFC00 File Offset: 0x003BDE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponLv()
		{
		}

		// Token: 0x06019CC7 RID: 105671 RVA: 0x003BFC08 File Offset: 0x003BDE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponLv(SurvivorsWeaponLv other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.survivorsWeapon_ = ((other.survivorsWeapon_ != null) ? other.survivorsWeapon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CC8 RID: 105672 RVA: 0x003BFC54 File Offset: 0x003BDE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponLv Clone()
		{
			return new SurvivorsWeaponLv(this);
		}

		// Token: 0x17005703 RID: 22275
		// (get) Token: 0x06019CC9 RID: 105673 RVA: 0x003BFC5C File Offset: 0x003BDE5C
		// (set) Token: 0x06019CCA RID: 105674 RVA: 0x003BFC64 File Offset: 0x003BDE64
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

		// Token: 0x17005704 RID: 22276
		// (get) Token: 0x06019CCB RID: 105675 RVA: 0x003BFC6D File Offset: 0x003BDE6D
		// (set) Token: 0x06019CCC RID: 105676 RVA: 0x003BFC75 File Offset: 0x003BDE75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeapon SurvivorsWeapon
		{
			get
			{
				return this.survivorsWeapon_;
			}
			set
			{
				this.survivorsWeapon_ = value;
			}
		}

		// Token: 0x06019CCD RID: 105677 RVA: 0x003BFC7E File Offset: 0x003BDE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponLv);
		}

		// Token: 0x06019CCE RID: 105678 RVA: 0x003BFC8C File Offset: 0x003BDE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponLv other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && object.Equals(this.SurvivorsWeapon, other.SurvivorsWeapon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019CCF RID: 105679 RVA: 0x003BFCDC File Offset: 0x003BDEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.survivorsWeapon_ != null)
			{
				num ^= this.SurvivorsWeapon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019CD0 RID: 105680 RVA: 0x003BFD31 File Offset: 0x003BDF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CD1 RID: 105681 RVA: 0x003BFD3E File Offset: 0x003BDF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CD2 RID: 105682 RVA: 0x003BFD48 File Offset: 0x003BDF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.survivorsWeapon_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.SurvivorsWeapon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019CD3 RID: 105683 RVA: 0x003BFDA0 File Offset: 0x003BDFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.survivorsWeapon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SurvivorsWeapon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019CD4 RID: 105684 RVA: 0x003BFDF8 File Offset: 0x003BDFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponLv other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.survivorsWeapon_ != null)
			{
				if (this.survivorsWeapon_ == null)
				{
					this.SurvivorsWeapon = new SurvivorsWeapon();
				}
				this.SurvivorsWeapon.MergeFrom(other.SurvivorsWeapon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019CD5 RID: 105685 RVA: 0x003BFE60 File Offset: 0x003BE060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CD6 RID: 105686 RVA: 0x003BFE6C File Offset: 0x003BE06C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.survivorsWeapon_ == null)
						{
							this.SurvivorsWeapon = new SurvivorsWeapon();
						}
						input.ReadMessage(this.SurvivorsWeapon);
					}
				}
				else
				{
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096F7 RID: 38647
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096F8 RID: 38648
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x040096F9 RID: 38649
		private int weaponId_;

		// Token: 0x040096FA RID: 38650
		public const int SurvivorsWeaponFieldNumber = 2;

		// Token: 0x040096FB RID: 38651
		private SurvivorsWeapon survivorsWeapon_;
	}
}
