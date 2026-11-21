using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AC RID: 2220
	[NetMessage(EMessageId.KurotatoSellWeaponRequest)]
	public sealed class KurotatoSellWeaponRequest : IMessage<KurotatoSellWeaponRequest>, IMessage, IEquatable<KurotatoSellWeaponRequest>, IDeepCloneable<KurotatoSellWeaponRequest>, IBufferMessage
	{
		// Token: 0x0600C543 RID: 50499 RVA: 0x001D3411 File Offset: 0x001D1611
		[NullableContext(1)]
		public static KurotatoSellWeaponRequest Create()
		{
			return new KurotatoSellWeaponRequest();
		}

		// Token: 0x170027D4 RID: 10196
		// (get) Token: 0x0600C544 RID: 50500 RVA: 0x001D3418 File Offset: 0x001D1618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027D5 RID: 10197
		// (get) Token: 0x0600C545 RID: 50501 RVA: 0x001D341B File Offset: 0x001D161B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSellWeaponRequest.Descriptor;
			}
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x001D3422 File Offset: 0x001D1622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponRequest()
		{
		}

		// Token: 0x0600C547 RID: 50503 RVA: 0x001D342A File Offset: 0x001D162A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponRequest(KurotatoSellWeaponRequest other) : this()
		{
			this.weaponIncId_ = other.weaponIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C548 RID: 50504 RVA: 0x001D344F File Offset: 0x001D164F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponRequest Clone()
		{
			return new KurotatoSellWeaponRequest(this);
		}

		// Token: 0x170027D6 RID: 10198
		// (get) Token: 0x0600C549 RID: 50505 RVA: 0x001D3457 File Offset: 0x001D1657
		// (set) Token: 0x0600C54A RID: 50506 RVA: 0x001D345F File Offset: 0x001D165F
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

		// Token: 0x0600C54B RID: 50507 RVA: 0x001D3468 File Offset: 0x001D1668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSellWeaponRequest);
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x001D3476 File Offset: 0x001D1676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSellWeaponRequest other)
		{
			return other != null && (other == this || (this.WeaponIncId == other.WeaponIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x001D34A4 File Offset: 0x001D16A4
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

		// Token: 0x0600C54E RID: 50510 RVA: 0x001D34E3 File Offset: 0x001D16E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C54F RID: 50511 RVA: 0x001D34F0 File Offset: 0x001D16F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C550 RID: 50512 RVA: 0x001D34F9 File Offset: 0x001D16F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponIncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WeaponIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x001D352C File Offset: 0x001D172C
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

		// Token: 0x0600C552 RID: 50514 RVA: 0x001D356A File Offset: 0x001D176A
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

		// Token: 0x0600C553 RID: 50515 RVA: 0x001D359B File Offset: 0x001D179B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C554 RID: 50516 RVA: 0x001D35A4 File Offset: 0x001D17A4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WeaponIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005533 RID: 21811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005534 RID: 21812
		public const int WeaponIncIdFieldNumber = 2;

		// Token: 0x04005535 RID: 21813
		private int weaponIncId_;
	}
}
