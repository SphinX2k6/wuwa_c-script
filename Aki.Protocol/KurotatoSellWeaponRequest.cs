using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BD RID: 2237
	[NetMessage(EMessageId.KurotatoSellWeaponRequest)]
	public sealed class KurotatoSellWeaponRequest : IMessage<KurotatoSellWeaponRequest>, IMessage, IEquatable<KurotatoSellWeaponRequest>, IDeepCloneable<KurotatoSellWeaponRequest>, IBufferMessage
	{
		// Token: 0x0600C65F RID: 50783 RVA: 0x001D56F9 File Offset: 0x001D38F9
		[NullableContext(1)]
		public static KurotatoSellWeaponRequest Create()
		{
			return new KurotatoSellWeaponRequest();
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x0600C660 RID: 50784 RVA: 0x001D5700 File Offset: 0x001D3900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x0600C661 RID: 50785 RVA: 0x001D5703 File Offset: 0x001D3903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSellWeaponRequest.Descriptor;
			}
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x001D570A File Offset: 0x001D390A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponRequest()
		{
		}

		// Token: 0x0600C663 RID: 50787 RVA: 0x001D5712 File Offset: 0x001D3912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponRequest(KurotatoSellWeaponRequest other) : this()
		{
			this.weaponIncId_ = other.weaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C664 RID: 50788 RVA: 0x001D5737 File Offset: 0x001D3937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponRequest Clone()
		{
			return new KurotatoSellWeaponRequest(this);
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x0600C665 RID: 50789 RVA: 0x001D573F File Offset: 0x001D393F
		// (set) Token: 0x0600C666 RID: 50790 RVA: 0x001D5747 File Offset: 0x001D3947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponIncId
		{
			get
			{
				return this.weaponIncId_;
			}
			set
			{
				this.weaponIncId_ = value;
			}
		}

		// Token: 0x0600C667 RID: 50791 RVA: 0x001D5750 File Offset: 0x001D3950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSellWeaponRequest);
		}

		// Token: 0x0600C668 RID: 50792 RVA: 0x001D575E File Offset: 0x001D395E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSellWeaponRequest other)
		{
			return other != null && (other == this || (this.WeaponIncId == other.WeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C669 RID: 50793 RVA: 0x001D578C File Offset: 0x001D398C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponIncId != 0)
			{
				num ^= this.WeaponIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C66A RID: 50794 RVA: 0x001D57CB File Offset: 0x001D39CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C66B RID: 50795 RVA: 0x001D57D8 File Offset: 0x001D39D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x001D57E1 File Offset: 0x001D39E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponIncId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x001D5814 File Offset: 0x001D3A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x001D5852 File Offset: 0x001D3A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSellWeaponRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponIncId != 0)
			{
				this.WeaponIncId = other.WeaponIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x001D5883 File Offset: 0x001D3A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C670 RID: 50800 RVA: 0x001D588C File Offset: 0x001D3A8C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeaponIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400552C RID: 21804
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400552D RID: 21805
		public const int WeaponIncIdFieldNumber = 11;

		// Token: 0x0400552E RID: 21806
		private int weaponIncId_;
	}
}
