using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E8 RID: 5352
	[NetMessage(EMessageId.WeaponAddNotify)]
	public sealed class WeaponAddNotify : IMessage<WeaponAddNotify>, IMessage, IEquatable<WeaponAddNotify>, IDeepCloneable<WeaponAddNotify>, IBufferMessage
	{
		// Token: 0x0601C4C3 RID: 115907 RVA: 0x00416CD9 File Offset: 0x00414ED9
		[NullableContext(1)]
		public static WeaponAddNotify Create()
		{
			return new WeaponAddNotify();
		}

		// Token: 0x17005F66 RID: 24422
		// (get) Token: 0x0601C4C4 RID: 115908 RVA: 0x00416CE0 File Offset: 0x00414EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F67 RID: 24423
		// (get) Token: 0x0601C4C5 RID: 115909 RVA: 0x00416CE3 File Offset: 0x00414EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponAddNotify.Descriptor;
			}
		}

		// Token: 0x0601C4C6 RID: 115910 RVA: 0x00416CEA File Offset: 0x00414EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAddNotify()
		{
		}

		// Token: 0x0601C4C7 RID: 115911 RVA: 0x00416CF2 File Offset: 0x00414EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAddNotify(WeaponAddNotify other) : this()
		{
			this.weaponInfo_ = ((other.weaponInfo_ != null) ? other.weaponInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4C8 RID: 115912 RVA: 0x00416D27 File Offset: 0x00414F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAddNotify Clone()
		{
			return new WeaponAddNotify(this);
		}

		// Token: 0x17005F68 RID: 24424
		// (get) Token: 0x0601C4C9 RID: 115913 RVA: 0x00416D2F File Offset: 0x00414F2F
		// (set) Token: 0x0601C4CA RID: 115914 RVA: 0x00416D37 File Offset: 0x00414F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneWeaponItemInfo WeaponInfo
		{
			get
			{
				return this.weaponInfo_;
			}
			set
			{
				this.weaponInfo_ = value;
			}
		}

		// Token: 0x0601C4CB RID: 115915 RVA: 0x00416D40 File Offset: 0x00414F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponAddNotify);
		}

		// Token: 0x0601C4CC RID: 115916 RVA: 0x00416D4E File Offset: 0x00414F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponAddNotify other)
		{
			return other != null && (other == this || (object.Equals(this.WeaponInfo, other.WeaponInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4CD RID: 115917 RVA: 0x00416D84 File Offset: 0x00414F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.weaponInfo_ != null)
			{
				num ^= this.WeaponInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C4CE RID: 115918 RVA: 0x00416DC0 File Offset: 0x00414FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4CF RID: 115919 RVA: 0x00416DCD File Offset: 0x00414FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4D0 RID: 115920 RVA: 0x00416DD6 File Offset: 0x00414FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.weaponInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.WeaponInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4D1 RID: 115921 RVA: 0x00416E08 File Offset: 0x00415008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.weaponInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WeaponInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C4D2 RID: 115922 RVA: 0x00416E48 File Offset: 0x00415048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.weaponInfo_ != null)
			{
				if (this.weaponInfo_ == null)
				{
					this.WeaponInfo = new OneWeaponItemInfo();
				}
				this.WeaponInfo.MergeFrom(other.WeaponInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C4D3 RID: 115923 RVA: 0x00416E9C File Offset: 0x0041509C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4D4 RID: 115924 RVA: 0x00416EA8 File Offset: 0x004150A8
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.weaponInfo_ == null)
					{
						this.WeaponInfo = new OneWeaponItemInfo();
					}
					input.ReadMessage(this.WeaponInfo);
				}
			}
		}

		// Token: 0x0400A22B RID: 41515
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A22C RID: 41516
		public const int WeaponInfoFieldNumber = 3;

		// Token: 0x0400A22D RID: 41517
		private OneWeaponItemInfo weaponInfo_;
	}
}
