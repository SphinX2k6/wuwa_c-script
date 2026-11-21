using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BD RID: 2237
	public sealed class KurotatoShopWeaponProductPbData : IMessage<KurotatoShopWeaponProductPbData>, IMessage, IEquatable<KurotatoShopWeaponProductPbData>, IDeepCloneable<KurotatoShopWeaponProductPbData>, IBufferMessage
	{
		// Token: 0x0600C69E RID: 50846 RVA: 0x001D65C3 File Offset: 0x001D47C3
		[NullableContext(1)]
		public static KurotatoShopWeaponProductPbData Create()
		{
			return new KurotatoShopWeaponProductPbData();
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x0600C69F RID: 50847 RVA: 0x001D65CA File Offset: 0x001D47CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600C6A0 RID: 50848 RVA: 0x001D65CD File Offset: 0x001D47CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopWeaponProductPbData.Descriptor;
			}
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x001D65D4 File Offset: 0x001D47D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopWeaponProductPbData()
		{
		}

		// Token: 0x0600C6A2 RID: 50850 RVA: 0x001D65DC File Offset: 0x001D47DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopWeaponProductPbData(KurotatoShopWeaponProductPbData other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x001D6601 File Offset: 0x001D4801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopWeaponProductPbData Clone()
		{
			return new KurotatoShopWeaponProductPbData(this);
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x0600C6A4 RID: 50852 RVA: 0x001D6609 File Offset: 0x001D4809
		// (set) Token: 0x0600C6A5 RID: 50853 RVA: 0x001D6611 File Offset: 0x001D4811
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

		// Token: 0x0600C6A6 RID: 50854 RVA: 0x001D661A File Offset: 0x001D481A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopWeaponProductPbData);
		}

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x001D6628 File Offset: 0x001D4828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopWeaponProductPbData other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6A8 RID: 50856 RVA: 0x001D6658 File Offset: 0x001D4858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6A9 RID: 50857 RVA: 0x001D6697 File Offset: 0x001D4897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6AA RID: 50858 RVA: 0x001D66A4 File Offset: 0x001D48A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6AB RID: 50859 RVA: 0x001D66AD File Offset: 0x001D48AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6AC RID: 50860 RVA: 0x001D66E0 File Offset: 0x001D48E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6AD RID: 50861 RVA: 0x001D671E File Offset: 0x001D491E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopWeaponProductPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6AE RID: 50862 RVA: 0x001D674F File Offset: 0x001D494F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6AF RID: 50863 RVA: 0x001D6758 File Offset: 0x001D4958
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
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005594 RID: 21908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005595 RID: 21909
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x04005596 RID: 21910
		private int weaponId_;
	}
}
