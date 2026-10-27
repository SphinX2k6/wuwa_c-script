using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075B RID: 1883
	[NetMessage(EMessageId.HoldWeaponPush)]
	public sealed class HoldWeaponPush : IMessage<HoldWeaponPush>, IMessage, IEquatable<HoldWeaponPush>, IDeepCloneable<HoldWeaponPush>, IBufferMessage
	{
		// Token: 0x0600AA7A RID: 43642 RVA: 0x0019A34C File Offset: 0x0019854C
		[NullableContext(1)]
		public static HoldWeaponPush Create()
		{
			return new HoldWeaponPush();
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x0600AA7B RID: 43643 RVA: 0x0019A353 File Offset: 0x00198553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x0600AA7C RID: 43644 RVA: 0x0019A356 File Offset: 0x00198556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldWeaponPush.Descriptor;
			}
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x0019A35D File Offset: 0x0019855D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponPush()
		{
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x0019A365 File Offset: 0x00198565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponPush(HoldWeaponPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.weaponEntityId_ = other.weaponEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x0019A396 File Offset: 0x00198596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponPush Clone()
		{
			return new HoldWeaponPush(this);
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x0600AA80 RID: 43648 RVA: 0x0019A39E File Offset: 0x0019859E
		// (set) Token: 0x0600AA81 RID: 43649 RVA: 0x0019A3A6 File Offset: 0x001985A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x0600AA82 RID: 43650 RVA: 0x0019A3AF File Offset: 0x001985AF
		// (set) Token: 0x0600AA83 RID: 43651 RVA: 0x0019A3B7 File Offset: 0x001985B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long WeaponEntityId
		{
			get
			{
				return this.weaponEntityId_;
			}
			set
			{
				this.weaponEntityId_ = value;
			}
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x0019A3C0 File Offset: 0x001985C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldWeaponPush);
		}

		// Token: 0x0600AA85 RID: 43653 RVA: 0x0019A3CE File Offset: 0x001985CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldWeaponPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.WeaponEntityId == other.WeaponEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x0019A40C File Offset: 0x0019860C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.WeaponEntityId != 0L)
			{
				num ^= this.WeaponEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA87 RID: 43655 RVA: 0x0019A464 File Offset: 0x00198664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x0019A471 File Offset: 0x00198671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA89 RID: 43657 RVA: 0x0019A47C File Offset: 0x0019867C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.WeaponEntityId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA8A RID: 43658 RVA: 0x0019A4D4 File Offset: 0x001986D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.WeaponEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.WeaponEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x0019A52C File Offset: 0x0019872C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HoldWeaponPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.WeaponEntityId != 0L)
			{
				this.WeaponEntityId = other.WeaponEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x0019A57C File Offset: 0x0019877C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x0019A588 File Offset: 0x00198788
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.WeaponEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004D7D RID: 19837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D7E RID: 19838
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04004D7F RID: 19839
		private long entityId_;

		// Token: 0x04004D80 RID: 19840
		public const int WeaponEntityIdFieldNumber = 1;

		// Token: 0x04004D81 RID: 19841
		private long weaponEntityId_;
	}
}
