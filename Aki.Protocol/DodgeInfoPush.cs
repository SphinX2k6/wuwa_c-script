using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CD RID: 973
	[NetMessage(EMessageId.DodgeInfoPush)]
	public sealed class DodgeInfoPush : IMessage<DodgeInfoPush>, IMessage, IEquatable<DodgeInfoPush>, IDeepCloneable<DodgeInfoPush>, IBufferMessage
	{
		// Token: 0x06005F37 RID: 24375 RVA: 0x000E6C31 File Offset: 0x000E4E31
		[NullableContext(1)]
		public static DodgeInfoPush Create()
		{
			return new DodgeInfoPush();
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06005F38 RID: 24376 RVA: 0x000E6C38 File Offset: 0x000E4E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06005F39 RID: 24377 RVA: 0x000E6C3B File Offset: 0x000E4E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DodgeInfoPush.Descriptor;
			}
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x000E6C42 File Offset: 0x000E4E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DodgeInfoPush()
		{
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x000E6C4A File Offset: 0x000E4E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DodgeInfoPush(DodgeInfoPush other) : this()
		{
			this.bulletOwnerId_ = other.bulletOwnerId_;
			this.bulletId_ = other.bulletId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x000E6C7B File Offset: 0x000E4E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DodgeInfoPush Clone()
		{
			return new DodgeInfoPush(this);
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06005F3D RID: 24381 RVA: 0x000E6C83 File Offset: 0x000E4E83
		// (set) Token: 0x06005F3E RID: 24382 RVA: 0x000E6C8B File Offset: 0x000E4E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletOwnerId
		{
			get
			{
				return this.bulletOwnerId_;
			}
			set
			{
				this.bulletOwnerId_ = value;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06005F3F RID: 24383 RVA: 0x000E6C94 File Offset: 0x000E4E94
		// (set) Token: 0x06005F40 RID: 24384 RVA: 0x000E6C9C File Offset: 0x000E4E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BulletId
		{
			get
			{
				return this.bulletId_;
			}
			set
			{
				this.bulletId_ = value;
			}
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x000E6CA5 File Offset: 0x000E4EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DodgeInfoPush);
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x000E6CB3 File Offset: 0x000E4EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DodgeInfoPush other)
		{
			return other != null && (other == this || (this.BulletOwnerId == other.BulletOwnerId && this.BulletId == other.BulletId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x000E6CF4 File Offset: 0x000E4EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BulletOwnerId != 0L)
			{
				num ^= this.BulletOwnerId.GetHashCode();
			}
			if (this.BulletId != 0L)
			{
				num ^= this.BulletId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x000E6D4C File Offset: 0x000E4F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x000E6D59 File Offset: 0x000E4F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x000E6D64 File Offset: 0x000E4F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletOwnerId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.BulletOwnerId);
			}
			if (this.BulletId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.BulletId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x000E6DC0 File Offset: 0x000E4FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BulletOwnerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletOwnerId);
			}
			if (this.BulletId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BulletId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x000E6E18 File Offset: 0x000E5018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DodgeInfoPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BulletOwnerId != 0L)
			{
				this.BulletOwnerId = other.BulletOwnerId;
			}
			if (other.BulletId != 0L)
			{
				this.BulletId = other.BulletId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x000E6E68 File Offset: 0x000E5068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x000E6E74 File Offset: 0x000E5074
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
				if (num != 32U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BulletId = input.ReadInt64();
					}
				}
				else
				{
					this.BulletOwnerId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003762 RID: 14178
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003763 RID: 14179
		public const int BulletOwnerIdFieldNumber = 4;

		// Token: 0x04003764 RID: 14180
		private long bulletOwnerId_;

		// Token: 0x04003765 RID: 14181
		public const int BulletIdFieldNumber = 12;

		// Token: 0x04003766 RID: 14182
		private long bulletId_;
	}
}
