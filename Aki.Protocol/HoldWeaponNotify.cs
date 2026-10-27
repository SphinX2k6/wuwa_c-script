using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075A RID: 1882
	[NetMessage(EMessageId.HoldWeaponNotify)]
	public sealed class HoldWeaponNotify : IMessage<HoldWeaponNotify>, IMessage, IEquatable<HoldWeaponNotify>, IDeepCloneable<HoldWeaponNotify>, IBufferMessage
	{
		// Token: 0x0600AA66 RID: 43622 RVA: 0x0019A0B1 File Offset: 0x001982B1
		[NullableContext(1)]
		public static HoldWeaponNotify Create()
		{
			return new HoldWeaponNotify();
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0600AA67 RID: 43623 RVA: 0x0019A0B8 File Offset: 0x001982B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0600AA68 RID: 43624 RVA: 0x0019A0BB File Offset: 0x001982BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldWeaponNotify.Descriptor;
			}
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x0019A0C2 File Offset: 0x001982C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponNotify()
		{
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x0019A0CA File Offset: 0x001982CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponNotify(HoldWeaponNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.weaponConfId_ = other.weaponConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x0019A0FB File Offset: 0x001982FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponNotify Clone()
		{
			return new HoldWeaponNotify(this);
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x0600AA6C RID: 43628 RVA: 0x0019A103 File Offset: 0x00198303
		// (set) Token: 0x0600AA6D RID: 43629 RVA: 0x0019A10B File Offset: 0x0019830B
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

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x0600AA6E RID: 43630 RVA: 0x0019A114 File Offset: 0x00198314
		// (set) Token: 0x0600AA6F RID: 43631 RVA: 0x0019A11C File Offset: 0x0019831C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponConfId
		{
			get
			{
				return this.weaponConfId_;
			}
			set
			{
				this.weaponConfId_ = value;
			}
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x0019A125 File Offset: 0x00198325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldWeaponNotify);
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x0019A133 File Offset: 0x00198333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldWeaponNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.WeaponConfId == other.WeaponConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA72 RID: 43634 RVA: 0x0019A174 File Offset: 0x00198374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.WeaponConfId != 0)
			{
				num ^= this.WeaponConfId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA73 RID: 43635 RVA: 0x0019A1CC File Offset: 0x001983CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x0019A1D9 File Offset: 0x001983D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x0019A1E4 File Offset: 0x001983E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponConfId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.WeaponConfId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x0019A240 File Offset: 0x00198440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.WeaponConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponConfId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x0019A298 File Offset: 0x00198498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HoldWeaponNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.WeaponConfId != 0)
			{
				this.WeaponConfId = other.WeaponConfId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x0019A2E8 File Offset: 0x001984E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x0019A2F4 File Offset: 0x001984F4
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
				if (num != 64U)
				{
					if (num != 72U)
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
					this.WeaponConfId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004D78 RID: 19832
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D79 RID: 19833
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04004D7A RID: 19834
		private long entityId_;

		// Token: 0x04004D7B RID: 19835
		public const int WeaponConfIdFieldNumber = 8;

		// Token: 0x04004D7C RID: 19836
		private int weaponConfId_;
	}
}
