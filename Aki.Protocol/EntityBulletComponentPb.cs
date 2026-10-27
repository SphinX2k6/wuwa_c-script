using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000479 RID: 1145
	public sealed class EntityBulletComponentPb : IMessage<EntityBulletComponentPb>, IMessage, IEquatable<EntityBulletComponentPb>, IDeepCloneable<EntityBulletComponentPb>, IBufferMessage
	{
		// Token: 0x06006D0C RID: 27916 RVA: 0x00107161 File Offset: 0x00105361
		[NullableContext(1)]
		public static EntityBulletComponentPb Create()
		{
			return new EntityBulletComponentPb();
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x00107168 File Offset: 0x00105368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06006D0E RID: 27918 RVA: 0x0010716B File Offset: 0x0010536B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBulletComponentPb.Descriptor;
			}
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x00107172 File Offset: 0x00105372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBulletComponentPb()
		{
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x0010717A File Offset: 0x0010537A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBulletComponentPb(EntityBulletComponentPb other) : this()
		{
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x0010719F File Offset: 0x0010539F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBulletComponentPb Clone()
		{
			return new EntityBulletComponentPb(this);
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x06006D12 RID: 27922 RVA: 0x001071A7 File Offset: 0x001053A7
		// (set) Token: 0x06006D13 RID: 27923 RVA: 0x001071AF File Offset: 0x001053AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x001071B8 File Offset: 0x001053B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBulletComponentPb);
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x001071C6 File Offset: 0x001053C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBulletComponentPb other)
		{
			return other != null && (other == this || (this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D16 RID: 27926 RVA: 0x001071F4 File Offset: 0x001053F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x00107233 File Offset: 0x00105433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x00107240 File Offset: 0x00105440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x00107249 File Offset: 0x00105449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x0010727C File Offset: 0x0010547C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x001072BA File Offset: 0x001054BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBulletComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D1C RID: 27932 RVA: 0x001072EB File Offset: 0x001054EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x001072F4 File Offset: 0x001054F4
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
					this.ContextId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B19 RID: 15129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B1A RID: 15130
		public const int ContextIdFieldNumber = 1;

		// Token: 0x04003B1B RID: 15131
		private long contextId_;
	}
}
