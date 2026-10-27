using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000138 RID: 312
	[NetMessage(EMessageId.AwakeDynamicPortalRequest)]
	public sealed class AwakeDynamicPortalRequest : IMessage<AwakeDynamicPortalRequest>, IMessage, IEquatable<AwakeDynamicPortalRequest>, IDeepCloneable<AwakeDynamicPortalRequest>, IBufferMessage
	{
		// Token: 0x060028D7 RID: 10455 RVA: 0x0006B729 File Offset: 0x00069929
		[NullableContext(1)]
		public static AwakeDynamicPortalRequest Create()
		{
			return new AwakeDynamicPortalRequest();
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x0006B730 File Offset: 0x00069930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x0006B733 File Offset: 0x00069933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeDynamicPortalRequest.Descriptor;
			}
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0006B73A File Offset: 0x0006993A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalRequest()
		{
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0006B742 File Offset: 0x00069942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalRequest(AwakeDynamicPortalRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isAwake_ = other.isAwake_;
			this.bulletId_ = other.bulletId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0006B77F File Offset: 0x0006997F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeDynamicPortalRequest Clone()
		{
			return new AwakeDynamicPortalRequest(this);
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x0006B787 File Offset: 0x00069987
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x0006B78F File Offset: 0x0006998F
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x0006B798 File Offset: 0x00069998
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x0006B7A0 File Offset: 0x000699A0
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0006B7A9 File Offset: 0x000699A9
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x0006B7B1 File Offset: 0x000699B1
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

		// Token: 0x060028E3 RID: 10467 RVA: 0x0006B7BA File Offset: 0x000699BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeDynamicPortalRequest);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x0006B7C8 File Offset: 0x000699C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeDynamicPortalRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsAwake == other.IsAwake && this.BulletId == other.BulletId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0006B824 File Offset: 0x00069A24
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

		// Token: 0x060028E6 RID: 10470 RVA: 0x0006B895 File Offset: 0x00069A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0006B8A2 File Offset: 0x00069AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0006B8AC File Offset: 0x00069AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAwake)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsAwake);
			}
			if (this.BulletId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BulletId);
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

		// Token: 0x060028E9 RID: 10473 RVA: 0x0006B924 File Offset: 0x00069B24
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

		// Token: 0x060028EA RID: 10474 RVA: 0x0006B988 File Offset: 0x00069B88
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

		// Token: 0x060028EB RID: 10475 RVA: 0x0006B9EC File Offset: 0x00069BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0006B9F8 File Offset: 0x00069BF8
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
					if (num != 32U)
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
						this.BulletId = input.ReadInt32();
					}
				}
				else
				{
					this.IsAwake = input.ReadBool();
				}
			}
		}

		// Token: 0x040026C8 RID: 9928
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026C9 RID: 9929
		public const int EntityIdFieldNumber = 9;

		// Token: 0x040026CA RID: 9930
		private long entityId_;

		// Token: 0x040026CB RID: 9931
		public const int IsAwakeFieldNumber = 3;

		// Token: 0x040026CC RID: 9932
		private bool isAwake_;

		// Token: 0x040026CD RID: 9933
		public const int BulletIdFieldNumber = 4;

		// Token: 0x040026CE RID: 9934
		private int bulletId_;
	}
}
