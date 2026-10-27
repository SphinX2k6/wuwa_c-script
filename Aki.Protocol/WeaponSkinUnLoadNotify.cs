using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FA RID: 5370
	[NetMessage(EMessageId.WeaponSkinUnLoadNotify)]
	public sealed class WeaponSkinUnLoadNotify : IMessage<WeaponSkinUnLoadNotify>, IMessage, IEquatable<WeaponSkinUnLoadNotify>, IDeepCloneable<WeaponSkinUnLoadNotify>, IBufferMessage
	{
		// Token: 0x0601C63A RID: 116282 RVA: 0x00419FC8 File Offset: 0x004181C8
		[NullableContext(1)]
		public static WeaponSkinUnLoadNotify Create()
		{
			return new WeaponSkinUnLoadNotify();
		}

		// Token: 0x17005FB6 RID: 24502
		// (get) Token: 0x0601C63B RID: 116283 RVA: 0x00419FCF File Offset: 0x004181CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB7 RID: 24503
		// (get) Token: 0x0601C63C RID: 116284 RVA: 0x00419FD2 File Offset: 0x004181D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponSkinUnLoadNotify.Descriptor;
			}
		}

		// Token: 0x0601C63D RID: 116285 RVA: 0x00419FD9 File Offset: 0x004181D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUnLoadNotify()
		{
		}

		// Token: 0x0601C63E RID: 116286 RVA: 0x00419FE1 File Offset: 0x004181E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUnLoadNotify(WeaponSkinUnLoadNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C63F RID: 116287 RVA: 0x0041A012 File Offset: 0x00418212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponSkinUnLoadNotify Clone()
		{
			return new WeaponSkinUnLoadNotify(this);
		}

		// Token: 0x17005FB8 RID: 24504
		// (get) Token: 0x0601C640 RID: 116288 RVA: 0x0041A01A File Offset: 0x0041821A
		// (set) Token: 0x0601C641 RID: 116289 RVA: 0x0041A022 File Offset: 0x00418222
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

		// Token: 0x17005FB9 RID: 24505
		// (get) Token: 0x0601C642 RID: 116290 RVA: 0x0041A02B File Offset: 0x0041822B
		// (set) Token: 0x0601C643 RID: 116291 RVA: 0x0041A033 File Offset: 0x00418233
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

		// Token: 0x0601C644 RID: 116292 RVA: 0x0041A03C File Offset: 0x0041823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponSkinUnLoadNotify);
		}

		// Token: 0x0601C645 RID: 116293 RVA: 0x0041A04A File Offset: 0x0041824A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponSkinUnLoadNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C646 RID: 116294 RVA: 0x0041A088 File Offset: 0x00418288
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

		// Token: 0x0601C647 RID: 116295 RVA: 0x0041A0E0 File Offset: 0x004182E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C648 RID: 116296 RVA: 0x0041A0ED File Offset: 0x004182ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C649 RID: 116297 RVA: 0x0041A0F8 File Offset: 0x004182F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C64A RID: 116298 RVA: 0x0041A154 File Offset: 0x00418354
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

		// Token: 0x0601C64B RID: 116299 RVA: 0x0041A1AC File Offset: 0x004183AC
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

		// Token: 0x0601C64C RID: 116300 RVA: 0x0041A1FC File Offset: 0x004183FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C64D RID: 116301 RVA: 0x0041A208 File Offset: 0x00418408
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
				if (num != 56U)
				{
					if (num != 112U)
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

		// Token: 0x0400A29B RID: 41627
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A29C RID: 41628
		public const int RoleIdFieldNumber = 7;

		// Token: 0x0400A29D RID: 41629
		private int roleId_;

		// Token: 0x0400A29E RID: 41630
		public const int SkinIdFieldNumber = 14;

		// Token: 0x0400A29F RID: 41631
		private int skinId_;
	}
}
