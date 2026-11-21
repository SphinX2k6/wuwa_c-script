using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000746 RID: 1862
	[NetMessage(EMessageId.HoldWeaponNotify)]
	public sealed class HoldWeaponNotify : IMessage<HoldWeaponNotify>, IMessage, IEquatable<HoldWeaponNotify>, IDeepCloneable<HoldWeaponNotify>, IBufferMessage
	{
		// Token: 0x0600A910 RID: 43280 RVA: 0x00197685 File Offset: 0x00195885
		[NullableContext(1)]
		public static HoldWeaponNotify Create()
		{
			return new HoldWeaponNotify();
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600A911 RID: 43281 RVA: 0x0019768C File Offset: 0x0019588C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600A912 RID: 43282 RVA: 0x0019768F File Offset: 0x0019588F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldWeaponNotify.Descriptor;
			}
		}

		// Token: 0x0600A913 RID: 43283 RVA: 0x00197696 File Offset: 0x00195896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponNotify()
		{
		}

		// Token: 0x0600A914 RID: 43284 RVA: 0x0019769E File Offset: 0x0019589E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponNotify(HoldWeaponNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.weaponConfId_ = other.weaponConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A915 RID: 43285 RVA: 0x001976CF File Offset: 0x001958CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponNotify Clone()
		{
			return new HoldWeaponNotify(this);
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600A916 RID: 43286 RVA: 0x001976D7 File Offset: 0x001958D7
		// (set) Token: 0x0600A917 RID: 43287 RVA: 0x001976DF File Offset: 0x001958DF
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

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600A918 RID: 43288 RVA: 0x001976E8 File Offset: 0x001958E8
		// (set) Token: 0x0600A919 RID: 43289 RVA: 0x001976F0 File Offset: 0x001958F0
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

		// Token: 0x0600A91A RID: 43290 RVA: 0x001976F9 File Offset: 0x001958F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldWeaponNotify);
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x00197707 File Offset: 0x00195907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldWeaponNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.WeaponConfId == other.WeaponConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x00197748 File Offset: 0x00195948
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

		// Token: 0x0600A91D RID: 43293 RVA: 0x001977A0 File Offset: 0x001959A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A91E RID: 43294 RVA: 0x001977AD File Offset: 0x001959AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x001977B8 File Offset: 0x001959B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponConfId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.WeaponConfId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A920 RID: 43296 RVA: 0x00197814 File Offset: 0x00195A14
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

		// Token: 0x0600A921 RID: 43297 RVA: 0x0019786C File Offset: 0x00195A6C
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

		// Token: 0x0600A922 RID: 43298 RVA: 0x001978BC File Offset: 0x00195ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x001978C8 File Offset: 0x00195AC8
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
				if (num != 24U)
				{
					if (num != 40U)
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

		// Token: 0x04004D71 RID: 19825
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D72 RID: 19826
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04004D73 RID: 19827
		private long entityId_;

		// Token: 0x04004D74 RID: 19828
		public const int WeaponConfIdFieldNumber = 3;

		// Token: 0x04004D75 RID: 19829
		private int weaponConfId_;
	}
}
