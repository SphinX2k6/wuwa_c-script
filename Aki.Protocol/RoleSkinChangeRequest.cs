using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AA RID: 4266
	[NetMessage(EMessageId.RoleSkinChangeRequest)]
	public sealed class RoleSkinChangeRequest : IMessage<RoleSkinChangeRequest>, IMessage, IEquatable<RoleSkinChangeRequest>, IDeepCloneable<RoleSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x06016CD8 RID: 93400 RVA: 0x00350A40 File Offset: 0x0034EC40
		[NullableContext(1)]
		public static RoleSkinChangeRequest Create()
		{
			return new RoleSkinChangeRequest();
		}

		// Token: 0x17004C6C RID: 19564
		// (get) Token: 0x06016CD9 RID: 93401 RVA: 0x00350A47 File Offset: 0x0034EC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C6D RID: 19565
		// (get) Token: 0x06016CDA RID: 93402 RVA: 0x00350A4A File Offset: 0x0034EC4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x06016CDB RID: 93403 RVA: 0x00350A51 File Offset: 0x0034EC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeRequest()
		{
		}

		// Token: 0x06016CDC RID: 93404 RVA: 0x00350A59 File Offset: 0x0034EC59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeRequest(RoleSkinChangeRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this.signatureWeapon_ = other.signatureWeapon_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016CDD RID: 93405 RVA: 0x00350A96 File Offset: 0x0034EC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeRequest Clone()
		{
			return new RoleSkinChangeRequest(this);
		}

		// Token: 0x17004C6E RID: 19566
		// (get) Token: 0x06016CDE RID: 93406 RVA: 0x00350A9E File Offset: 0x0034EC9E
		// (set) Token: 0x06016CDF RID: 93407 RVA: 0x00350AA6 File Offset: 0x0034ECA6
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

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x06016CE0 RID: 93408 RVA: 0x00350AAF File Offset: 0x0034ECAF
		// (set) Token: 0x06016CE1 RID: 93409 RVA: 0x00350AB7 File Offset: 0x0034ECB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17004C70 RID: 19568
		// (get) Token: 0x06016CE2 RID: 93410 RVA: 0x00350AC0 File Offset: 0x0034ECC0
		// (set) Token: 0x06016CE3 RID: 93411 RVA: 0x00350AC8 File Offset: 0x0034ECC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool SignatureWeapon
		{
			get
			{
				return this.signatureWeapon_;
			}
			set
			{
				this.signatureWeapon_ = value;
			}
		}

		// Token: 0x06016CE4 RID: 93412 RVA: 0x00350AD1 File Offset: 0x0034ECD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinChangeRequest);
		}

		// Token: 0x06016CE5 RID: 93413 RVA: 0x00350AE0 File Offset: 0x0034ECE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinChangeRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && this.SignatureWeapon == other.SignatureWeapon && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016CE6 RID: 93414 RVA: 0x00350B3C File Offset: 0x0034ED3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this.SignatureWeapon)
			{
				num ^= this.SignatureWeapon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016CE7 RID: 93415 RVA: 0x00350BAD File Offset: 0x0034EDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016CE8 RID: 93416 RVA: 0x00350BBA File Offset: 0x0034EDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016CE9 RID: 93417 RVA: 0x00350BC4 File Offset: 0x0034EDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SignatureWeapon)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.SignatureWeapon);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkinId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016CEA RID: 93418 RVA: 0x00350C3C File Offset: 0x0034EE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this.SignatureWeapon)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016CEB RID: 93419 RVA: 0x00350CA0 File Offset: 0x0034EEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			if (other.SignatureWeapon)
			{
				this.SignatureWeapon = other.SignatureWeapon;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016CEC RID: 93420 RVA: 0x00350D04 File Offset: 0x0034EF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016CED RID: 93421 RVA: 0x00350D10 File Offset: 0x0034EF10
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
				if (num != 32U)
				{
					if (num != 64U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.SignatureWeapon = input.ReadBool();
				}
			}
		}

		// Token: 0x04008886 RID: 34950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008887 RID: 34951
		public const int RoleIdFieldNumber = 9;

		// Token: 0x04008888 RID: 34952
		private int roleId_;

		// Token: 0x04008889 RID: 34953
		public const int SkinIdFieldNumber = 8;

		// Token: 0x0400888A RID: 34954
		private int skinId_;

		// Token: 0x0400888B RID: 34955
		public const int SignatureWeaponFieldNumber = 4;

		// Token: 0x0400888C RID: 34956
		private bool signatureWeapon_;
	}
}
