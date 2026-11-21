using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200155E RID: 5470
	[NetMessage(EMessageId.WeaponAddNotify)]
	public sealed class WeaponAddNotify : IMessage<WeaponAddNotify>, IMessage, IEquatable<WeaponAddNotify>, IDeepCloneable<WeaponAddNotify>, IBufferMessage
	{
		// Token: 0x0601CF8A RID: 118666 RVA: 0x00432795 File Offset: 0x00430995
		[NullableContext(1)]
		public static WeaponAddNotify Create()
		{
			return new WeaponAddNotify();
		}

		// Token: 0x17006207 RID: 25095
		// (get) Token: 0x0601CF8B RID: 118667 RVA: 0x0043279C File Offset: 0x0043099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006208 RID: 25096
		// (get) Token: 0x0601CF8C RID: 118668 RVA: 0x0043279F File Offset: 0x0043099F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponAddNotify.Descriptor;
			}
		}

		// Token: 0x0601CF8D RID: 118669 RVA: 0x004327A6 File Offset: 0x004309A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAddNotify()
		{
		}

		// Token: 0x0601CF8E RID: 118670 RVA: 0x004327AE File Offset: 0x004309AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAddNotify(WeaponAddNotify other) : this()
		{
			this.weaponInfo_ = ((other.weaponInfo_ != null) ? other.weaponInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF8F RID: 118671 RVA: 0x004327E3 File Offset: 0x004309E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponAddNotify Clone()
		{
			return new WeaponAddNotify(this);
		}

		// Token: 0x17006209 RID: 25097
		// (get) Token: 0x0601CF90 RID: 118672 RVA: 0x004327EB File Offset: 0x004309EB
		// (set) Token: 0x0601CF91 RID: 118673 RVA: 0x004327F3 File Offset: 0x004309F3
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

		// Token: 0x0601CF92 RID: 118674 RVA: 0x004327FC File Offset: 0x004309FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponAddNotify);
		}

		// Token: 0x0601CF93 RID: 118675 RVA: 0x0043280A File Offset: 0x00430A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponAddNotify other)
		{
			return other != null && (other == this || (object.Equals(this.WeaponInfo, other.WeaponInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF94 RID: 118676 RVA: 0x00432840 File Offset: 0x00430A40
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

		// Token: 0x0601CF95 RID: 118677 RVA: 0x0043287C File Offset: 0x00430A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF96 RID: 118678 RVA: 0x00432889 File Offset: 0x00430A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF97 RID: 118679 RVA: 0x00432892 File Offset: 0x00430A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.weaponInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.WeaponInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF98 RID: 118680 RVA: 0x004328C4 File Offset: 0x00430AC4
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

		// Token: 0x0601CF99 RID: 118681 RVA: 0x00432904 File Offset: 0x00430B04
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

		// Token: 0x0601CF9A RID: 118682 RVA: 0x00432958 File Offset: 0x00430B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF9B RID: 118683 RVA: 0x00432964 File Offset: 0x00430B64
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
				if (num != 18U)
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

		// Token: 0x0400A684 RID: 42628
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A685 RID: 42629
		public const int WeaponInfoFieldNumber = 2;

		// Token: 0x0400A686 RID: 42630
		private OneWeaponItemInfo weaponInfo_;
	}
}
