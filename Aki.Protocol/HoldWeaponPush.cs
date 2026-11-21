using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000747 RID: 1863
	[NetMessage(EMessageId.HoldWeaponPush)]
	public sealed class HoldWeaponPush : IMessage<HoldWeaponPush>, IMessage, IEquatable<HoldWeaponPush>, IDeepCloneable<HoldWeaponPush>, IBufferMessage
	{
		// Token: 0x0600A924 RID: 43300 RVA: 0x00197920 File Offset: 0x00195B20
		[NullableContext(1)]
		public static HoldWeaponPush Create()
		{
			return new HoldWeaponPush();
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x0600A925 RID: 43301 RVA: 0x00197927 File Offset: 0x00195B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x0019792A File Offset: 0x00195B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldWeaponPush.Descriptor;
			}
		}

		// Token: 0x0600A927 RID: 43303 RVA: 0x00197931 File Offset: 0x00195B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponPush()
		{
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x00197939 File Offset: 0x00195B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponPush(HoldWeaponPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.weaponEntityId_ = other.weaponEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x0019796A File Offset: 0x00195B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldWeaponPush Clone()
		{
			return new HoldWeaponPush(this);
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x0600A92A RID: 43306 RVA: 0x00197972 File Offset: 0x00195B72
		// (set) Token: 0x0600A92B RID: 43307 RVA: 0x0019797A File Offset: 0x00195B7A
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

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x0600A92C RID: 43308 RVA: 0x00197983 File Offset: 0x00195B83
		// (set) Token: 0x0600A92D RID: 43309 RVA: 0x0019798B File Offset: 0x00195B8B
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

		// Token: 0x0600A92E RID: 43310 RVA: 0x00197994 File Offset: 0x00195B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldWeaponPush);
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x001979A2 File Offset: 0x00195BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldWeaponPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.WeaponEntityId == other.WeaponEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x001979E0 File Offset: 0x00195BE0
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

		// Token: 0x0600A931 RID: 43313 RVA: 0x00197A38 File Offset: 0x00195C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x00197A45 File Offset: 0x00195C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x00197A50 File Offset: 0x00195C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.WeaponEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.WeaponEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x00197AAC File Offset: 0x00195CAC
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

		// Token: 0x0600A935 RID: 43317 RVA: 0x00197B04 File Offset: 0x00195D04
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

		// Token: 0x0600A936 RID: 43318 RVA: 0x00197B54 File Offset: 0x00195D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x00197B60 File Offset: 0x00195D60
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
				if (num != 48U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WeaponEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004D76 RID: 19830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D77 RID: 19831
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04004D78 RID: 19832
		private long entityId_;

		// Token: 0x04004D79 RID: 19833
		public const int WeaponEntityIdFieldNumber = 8;

		// Token: 0x04004D7A RID: 19834
		private long weaponEntityId_;
	}
}
