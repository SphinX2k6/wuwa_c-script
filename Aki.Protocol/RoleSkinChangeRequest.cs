using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BA RID: 4282
	[NetMessage(EMessageId.RoleSkinChangeRequest)]
	public sealed class RoleSkinChangeRequest : IMessage<RoleSkinChangeRequest>, IMessage, IEquatable<RoleSkinChangeRequest>, IDeepCloneable<RoleSkinChangeRequest>, IBufferMessage
	{
		// Token: 0x06016DBD RID: 93629 RVA: 0x0035211C File Offset: 0x0035031C
		[NullableContext(1)]
		public static RoleSkinChangeRequest Create()
		{
			return new RoleSkinChangeRequest();
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x06016DBE RID: 93630 RVA: 0x00352123 File Offset: 0x00350323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C97 RID: 19607
		// (get) Token: 0x06016DBF RID: 93631 RVA: 0x00352126 File Offset: 0x00350326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinChangeRequest.Descriptor;
			}
		}

		// Token: 0x06016DC0 RID: 93632 RVA: 0x0035212D File Offset: 0x0035032D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeRequest()
		{
		}

		// Token: 0x06016DC1 RID: 93633 RVA: 0x00352135 File Offset: 0x00350335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeRequest(RoleSkinChangeRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this.signatureWeapon_ = other.signatureWeapon_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DC2 RID: 93634 RVA: 0x00352172 File Offset: 0x00350372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinChangeRequest Clone()
		{
			return new RoleSkinChangeRequest(this);
		}

		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x06016DC3 RID: 93635 RVA: 0x0035217A File Offset: 0x0035037A
		// (set) Token: 0x06016DC4 RID: 93636 RVA: 0x00352182 File Offset: 0x00350382
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

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x06016DC5 RID: 93637 RVA: 0x0035218B File Offset: 0x0035038B
		// (set) Token: 0x06016DC6 RID: 93638 RVA: 0x00352193 File Offset: 0x00350393
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

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x06016DC7 RID: 93639 RVA: 0x0035219C File Offset: 0x0035039C
		// (set) Token: 0x06016DC8 RID: 93640 RVA: 0x003521A4 File Offset: 0x003503A4
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

		// Token: 0x06016DC9 RID: 93641 RVA: 0x003521AD File Offset: 0x003503AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinChangeRequest);
		}

		// Token: 0x06016DCA RID: 93642 RVA: 0x003521BC File Offset: 0x003503BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinChangeRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && this.SignatureWeapon == other.SignatureWeapon && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DCB RID: 93643 RVA: 0x00352218 File Offset: 0x00350418
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

		// Token: 0x06016DCC RID: 93644 RVA: 0x00352289 File Offset: 0x00350489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DCD RID: 93645 RVA: 0x00352296 File Offset: 0x00350496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DCE RID: 93646 RVA: 0x003522A0 File Offset: 0x003504A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SignatureWeapon)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.SignatureWeapon);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkinId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DCF RID: 93647 RVA: 0x00352318 File Offset: 0x00350518
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

		// Token: 0x06016DD0 RID: 93648 RVA: 0x0035237C File Offset: 0x0035057C
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

		// Token: 0x06016DD1 RID: 93649 RVA: 0x003523E0 File Offset: 0x003505E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DD2 RID: 93650 RVA: 0x003523EC File Offset: 0x003505EC
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 112U)
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

		// Token: 0x0400885C RID: 34908
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400885D RID: 34909
		public const int RoleIdFieldNumber = 14;

		// Token: 0x0400885E RID: 34910
		private int roleId_;

		// Token: 0x0400885F RID: 34911
		public const int SkinIdFieldNumber = 4;

		// Token: 0x04008860 RID: 34912
		private int skinId_;

		// Token: 0x04008861 RID: 34913
		public const int SignatureWeaponFieldNumber = 2;

		// Token: 0x04008862 RID: 34914
		private bool signatureWeapon_;
	}
}
