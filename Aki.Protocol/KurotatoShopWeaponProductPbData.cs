using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CE RID: 2254
	public sealed class KurotatoShopWeaponProductPbData : IMessage<KurotatoShopWeaponProductPbData>, IMessage, IEquatable<KurotatoShopWeaponProductPbData>, IDeepCloneable<KurotatoShopWeaponProductPbData>, IBufferMessage
	{
		// Token: 0x0600C7BA RID: 51130 RVA: 0x001D88AF File Offset: 0x001D6AAF
		[NullableContext(1)]
		public static KurotatoShopWeaponProductPbData Create()
		{
			return new KurotatoShopWeaponProductPbData();
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x0600C7BB RID: 51131 RVA: 0x001D88B6 File Offset: 0x001D6AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x0600C7BC RID: 51132 RVA: 0x001D88B9 File Offset: 0x001D6AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopWeaponProductPbData.Descriptor;
			}
		}

		// Token: 0x0600C7BD RID: 51133 RVA: 0x001D88C0 File Offset: 0x001D6AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopWeaponProductPbData()
		{
		}

		// Token: 0x0600C7BE RID: 51134 RVA: 0x001D88C8 File Offset: 0x001D6AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopWeaponProductPbData(KurotatoShopWeaponProductPbData other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7BF RID: 51135 RVA: 0x001D88ED File Offset: 0x001D6AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopWeaponProductPbData Clone()
		{
			return new KurotatoShopWeaponProductPbData(this);
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x0600C7C0 RID: 51136 RVA: 0x001D88F5 File Offset: 0x001D6AF5
		// (set) Token: 0x0600C7C1 RID: 51137 RVA: 0x001D88FD File Offset: 0x001D6AFD
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

		// Token: 0x0600C7C2 RID: 51138 RVA: 0x001D8906 File Offset: 0x001D6B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopWeaponProductPbData);
		}

		// Token: 0x0600C7C3 RID: 51139 RVA: 0x001D8914 File Offset: 0x001D6B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopWeaponProductPbData other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7C4 RID: 51140 RVA: 0x001D8944 File Offset: 0x001D6B44
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

		// Token: 0x0600C7C5 RID: 51141 RVA: 0x001D8983 File Offset: 0x001D6B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7C6 RID: 51142 RVA: 0x001D8990 File Offset: 0x001D6B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7C7 RID: 51143 RVA: 0x001D8999 File Offset: 0x001D6B99
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

		// Token: 0x0600C7C8 RID: 51144 RVA: 0x001D89CC File Offset: 0x001D6BCC
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

		// Token: 0x0600C7C9 RID: 51145 RVA: 0x001D8A0A File Offset: 0x001D6C0A
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

		// Token: 0x0600C7CA RID: 51146 RVA: 0x001D8A3B File Offset: 0x001D6C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7CB RID: 51147 RVA: 0x001D8A44 File Offset: 0x001D6C44
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

		// Token: 0x0400558D RID: 21901
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400558E RID: 21902
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x0400558F RID: 21903
		private int weaponId_;
	}
}
