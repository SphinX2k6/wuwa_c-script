using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001570 RID: 5488
	[NetMessage(EMessageId.WeaponSkinUnLoadNotify)]
	public sealed class WeaponSkinUnLoadNotify : IMessage<WeaponSkinUnLoadNotify>, IMessage, IEquatable<WeaponSkinUnLoadNotify>, IDeepCloneable<WeaponSkinUnLoadNotify>, IBufferMessage
	{
		// Token: 0x0601D101 RID: 119041 RVA: 0x00435A87 File Offset: 0x00433C87
		[NullableContext(1)]
		public static WeaponSkinUnLoadNotify Create()
		{
			return new WeaponSkinUnLoadNotify();
		}

		// Token: 0x17006257 RID: 25175
		// (get) Token: 0x0601D102 RID: 119042 RVA: 0x00435A8E File Offset: 0x00433C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006258 RID: 25176
		// (get) Token: 0x0601D103 RID: 119043 RVA: 0x00435A91 File Offset: 0x00433C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSkinUnLoadNotify.Descriptor;
			}
		}

		// Token: 0x0601D104 RID: 119044 RVA: 0x00435A98 File Offset: 0x00433C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUnLoadNotify()
		{
		}

		// Token: 0x0601D105 RID: 119045 RVA: 0x00435AA0 File Offset: 0x00433CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUnLoadNotify(WeaponSkinUnLoadNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D106 RID: 119046 RVA: 0x00435AD1 File Offset: 0x00433CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUnLoadNotify Clone()
		{
			return new WeaponSkinUnLoadNotify(this);
		}

		// Token: 0x17006259 RID: 25177
		// (get) Token: 0x0601D107 RID: 119047 RVA: 0x00435AD9 File Offset: 0x00433CD9
		// (set) Token: 0x0601D108 RID: 119048 RVA: 0x00435AE1 File Offset: 0x00433CE1
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

		// Token: 0x1700625A RID: 25178
		// (get) Token: 0x0601D109 RID: 119049 RVA: 0x00435AEA File Offset: 0x00433CEA
		// (set) Token: 0x0601D10A RID: 119050 RVA: 0x00435AF2 File Offset: 0x00433CF2
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

		// Token: 0x0601D10B RID: 119051 RVA: 0x00435AFB File Offset: 0x00433CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSkinUnLoadNotify);
		}

		// Token: 0x0601D10C RID: 119052 RVA: 0x00435B09 File Offset: 0x00433D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSkinUnLoadNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D10D RID: 119053 RVA: 0x00435B48 File Offset: 0x00433D48
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D10E RID: 119054 RVA: 0x00435BA0 File Offset: 0x00433DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D10F RID: 119055 RVA: 0x00435BAD File Offset: 0x00433DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D110 RID: 119056 RVA: 0x00435BB8 File Offset: 0x00433DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D111 RID: 119057 RVA: 0x00435C14 File Offset: 0x00433E14
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D112 RID: 119058 RVA: 0x00435C6C File Offset: 0x00433E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponSkinUnLoadNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D113 RID: 119059 RVA: 0x00435CBC File Offset: 0x00433EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D114 RID: 119060 RVA: 0x00435CC8 File Offset: 0x00433EC8
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A6F4 RID: 42740
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6F5 RID: 42741
		public const int RoleIdFieldNumber = 2;

		// Token: 0x0400A6F6 RID: 42742
		private int roleId_;

		// Token: 0x0400A6F7 RID: 42743
		public const int SkinIdFieldNumber = 10;

		// Token: 0x0400A6F8 RID: 42744
		private int skinId_;
	}
}
