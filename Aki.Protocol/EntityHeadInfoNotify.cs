using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047E RID: 1150
	[NetMessage(EMessageId.EntityHeadInfoNotify)]
	public sealed class EntityHeadInfoNotify : IMessage<EntityHeadInfoNotify>, IMessage, IEquatable<EntityHeadInfoNotify>, IDeepCloneable<EntityHeadInfoNotify>, IBufferMessage
	{
		// Token: 0x06006E84 RID: 28292 RVA: 0x001100A8 File Offset: 0x0010E2A8
		[NullableContext(1)]
		public static EntityHeadInfoNotify Create()
		{
			return new EntityHeadInfoNotify();
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06006E85 RID: 28293 RVA: 0x001100AF File Offset: 0x0010E2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06006E86 RID: 28294 RVA: 0x001100B2 File Offset: 0x0010E2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityHeadInfoNotify.Descriptor;
			}
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x001100B9 File Offset: 0x0010E2B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHeadInfoNotify()
		{
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x001100E4 File Offset: 0x0010E2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHeadInfoNotify(EntityHeadInfoNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.tidName_ = other.tidName_;
			this.icon_ = other.icon_;
			this.secondaryName_ = other.secondaryName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x00110138 File Offset: 0x0010E338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHeadInfoNotify Clone()
		{
			return new EntityHeadInfoNotify(this);
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06006E8A RID: 28298 RVA: 0x00110140 File Offset: 0x0010E340
		// (set) Token: 0x06006E8B RID: 28299 RVA: 0x00110148 File Offset: 0x0010E348
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

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06006E8C RID: 28300 RVA: 0x00110151 File Offset: 0x0010E351
		// (set) Token: 0x06006E8D RID: 28301 RVA: 0x00110159 File Offset: 0x0010E359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TidName
		{
			get
			{
				return this.tidName_;
			}
			set
			{
				this.tidName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x06006E8E RID: 28302 RVA: 0x0011016C File Offset: 0x0010E36C
		// (set) Token: 0x06006E8F RID: 28303 RVA: 0x00110174 File Offset: 0x0010E374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Icon
		{
			get
			{
				return this.icon_;
			}
			set
			{
				this.icon_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x00110187 File Offset: 0x0010E387
		// (set) Token: 0x06006E91 RID: 28305 RVA: 0x0011018F File Offset: 0x0010E38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SecondaryName
		{
			get
			{
				return this.secondaryName_;
			}
			set
			{
				this.secondaryName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x001101A2 File Offset: 0x0010E3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityHeadInfoNotify);
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x001101B0 File Offset: 0x0010E3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityHeadInfoNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.TidName != other.TidName) && !(this.Icon != other.Icon) && !(this.SecondaryName != other.SecondaryName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x00110228 File Offset: 0x0010E428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TidName.Length != 0)
			{
				num ^= this.TidName.GetHashCode();
			}
			if (this.Icon.Length != 0)
			{
				num ^= this.Icon.GetHashCode();
			}
			if (this.SecondaryName.Length != 0)
			{
				num ^= this.SecondaryName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x001102B8 File Offset: 0x0010E4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x001102C5 File Offset: 0x0010E4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x001102D0 File Offset: 0x0010E4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TidName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.TidName);
			}
			if (this.SecondaryName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.SecondaryName);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.Icon.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.Icon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x00110370 File Offset: 0x0010E570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.TidName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TidName);
			}
			if (this.Icon.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Icon);
			}
			if (this.SecondaryName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SecondaryName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x00110408 File Offset: 0x0010E608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityHeadInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TidName.Length != 0)
			{
				this.TidName = other.TidName;
			}
			if (other.Icon.Length != 0)
			{
				this.Icon = other.Icon;
			}
			if (other.SecondaryName.Length != 0)
			{
				this.SecondaryName = other.SecondaryName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x0011048F File Offset: 0x0010E68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x00110498 File Offset: 0x0010E698
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
				if (num <= 42U)
				{
					if (num == 26U)
					{
						this.TidName = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.SecondaryName = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 106U)
					{
						this.Icon = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C0B RID: 15371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C0C RID: 15372
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003C0D RID: 15373
		private long entityId_;

		// Token: 0x04003C0E RID: 15374
		public const int TidNameFieldNumber = 3;

		// Token: 0x04003C0F RID: 15375
		private string tidName_ = "";

		// Token: 0x04003C10 RID: 15376
		public const int IconFieldNumber = 13;

		// Token: 0x04003C11 RID: 15377
		private string icon_ = "";

		// Token: 0x04003C12 RID: 15378
		public const int SecondaryNameFieldNumber = 5;

		// Token: 0x04003C13 RID: 15379
		private string secondaryName_ = "";
	}
}
