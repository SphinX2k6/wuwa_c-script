using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013B RID: 315
	[NetMessage(EMessageId.AwakeDynamicPortalRequest)]
	public sealed class AwakeDynamicPortalRequest : IMessage<AwakeDynamicPortalRequest>, IMessage, IEquatable<AwakeDynamicPortalRequest>, IDeepCloneable<AwakeDynamicPortalRequest>, IBufferMessage
	{
		// Token: 0x0600294E RID: 10574 RVA: 0x0006CB61 File Offset: 0x0006AD61
		[NullableContext(1)]
		public static AwakeDynamicPortalRequest Create()
		{
			return new AwakeDynamicPortalRequest();
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600294F RID: 10575 RVA: 0x0006CB68 File Offset: 0x0006AD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x0006CB6B File Offset: 0x0006AD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeDynamicPortalRequest.Descriptor;
			}
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x0006CB72 File Offset: 0x0006AD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalRequest()
		{
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x0006CB7A File Offset: 0x0006AD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalRequest(AwakeDynamicPortalRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isAwake_ = other.isAwake_;
			this.bulletId_ = other.bulletId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0006CBB7 File Offset: 0x0006ADB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalRequest Clone()
		{
			return new AwakeDynamicPortalRequest(this);
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x0006CBBF File Offset: 0x0006ADBF
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x0006CBC7 File Offset: 0x0006ADC7
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x0006CBD0 File Offset: 0x0006ADD0
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x0006CBD8 File Offset: 0x0006ADD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAwake
		{
			get
			{
				return this.isAwake_;
			}
			set
			{
				this.isAwake_ = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x0006CBE1 File Offset: 0x0006ADE1
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x0006CBE9 File Offset: 0x0006ADE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BulletId
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

		// Token: 0x0600295A RID: 10586 RVA: 0x0006CBF2 File Offset: 0x0006ADF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeDynamicPortalRequest);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0006CC00 File Offset: 0x0006AE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeDynamicPortalRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsAwake == other.IsAwake && this.BulletId == other.BulletId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x0006CC5C File Offset: 0x0006AE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsAwake)
			{
				num ^= this.IsAwake.GetHashCode();
			}
			if (this.BulletId != 0)
			{
				num ^= this.BulletId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x0006CCCD File Offset: 0x0006AECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x0006CCDA File Offset: 0x0006AEDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x0006CCE4 File Offset: 0x0006AEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BulletId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BulletId);
			}
			if (this.IsAwake)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsAwake);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0006CD58 File Offset: 0x0006AF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsAwake)
			{
				num += 2;
			}
			if (this.BulletId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BulletId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0006CDBC File Offset: 0x0006AFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AwakeDynamicPortalRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsAwake)
			{
				this.IsAwake = other.IsAwake;
			}
			if (other.BulletId != 0)
			{
				this.BulletId = other.BulletId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x0006CE20 File Offset: 0x0006B020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0006CE2C File Offset: 0x0006B02C
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
					if (num != 40U)
					{
						if (num != 56U)
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
						this.IsAwake = input.ReadBool();
					}
				}
				else
				{
					this.BulletId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400273C RID: 10044
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400273D RID: 10045
		public const int EntityIdFieldNumber = 7;

		// Token: 0x0400273E RID: 10046
		private long entityId_;

		// Token: 0x0400273F RID: 10047
		public const int IsAwakeFieldNumber = 5;

		// Token: 0x04002740 RID: 10048
		private bool isAwake_;

		// Token: 0x04002741 RID: 10049
		public const int BulletIdFieldNumber = 1;

		// Token: 0x04002742 RID: 10050
		private int bulletId_;
	}
}
