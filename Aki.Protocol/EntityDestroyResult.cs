using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000482 RID: 1154
	public sealed class EntityDestroyResult : IMessage<EntityDestroyResult>, IMessage, IEquatable<EntityDestroyResult>, IDeepCloneable<EntityDestroyResult>, IBufferMessage
	{
		// Token: 0x06006E86 RID: 28294 RVA: 0x0010F837 File Offset: 0x0010DA37
		[NullableContext(1)]
		public static EntityDestroyResult Create()
		{
			return new EntityDestroyResult();
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x0010F83E File Offset: 0x0010DA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityDestroyResult> Parser
		{
			get
			{
				return EntityDestroyResult._parser;
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06006E88 RID: 28296 RVA: 0x0010F845 File Offset: 0x0010DA45
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
		// (get) Token: 0x06006E89 RID: 28297 RVA: 0x0010F848 File Offset: 0x0010DA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDestroyResult.Descriptor;
			}
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x0010F84F File Offset: 0x0010DA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestroyResult()
		{
		}

		// Token: 0x06006E8B RID: 28299 RVA: 0x0010F857 File Offset: 0x0010DA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestroyResult(EntityDestroyResult other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isDestroyed_ = other.isDestroyed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x0010F888 File Offset: 0x0010DA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestroyResult Clone()
		{
			return new EntityDestroyResult(this);
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x0010F890 File Offset: 0x0010DA90
		// (set) Token: 0x06006E8E RID: 28302 RVA: 0x0010F898 File Offset: 0x0010DA98
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
		// (get) Token: 0x06006E8F RID: 28303 RVA: 0x0010F8A1 File Offset: 0x0010DAA1
		// (set) Token: 0x06006E90 RID: 28304 RVA: 0x0010F8A9 File Offset: 0x0010DAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDestroyed
		{
			get
			{
				return this.isDestroyed_;
			}
			set
			{
				this.isDestroyed_ = value;
			}
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x0010F8B2 File Offset: 0x0010DAB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDestroyResult);
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x0010F8C0 File Offset: 0x0010DAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDestroyResult other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsDestroyed == other.IsDestroyed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x0010F900 File Offset: 0x0010DB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsDestroyed)
			{
				num ^= this.IsDestroyed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x0010F958 File Offset: 0x0010DB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x0010F965 File Offset: 0x0010DB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x0010F970 File Offset: 0x0010DB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsDestroyed)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsDestroyed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x0010F9C8 File Offset: 0x0010DBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsDestroyed)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x0010FA14 File Offset: 0x0010DC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityDestroyResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsDestroyed)
			{
				this.IsDestroyed = other.IsDestroyed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x0010FA64 File Offset: 0x0010DC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x0010FA70 File Offset: 0x0010DC70
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsDestroyed = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003BAA RID: 15274
		private static readonly MessageParser<EntityDestroyResult> _parser = new MessageParser<EntityDestroyResult>(() => new EntityDestroyResult());

		// Token: 0x04003BAB RID: 15275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BAC RID: 15276
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003BAD RID: 15277
		private long entityId_;

		// Token: 0x04003BAE RID: 15278
		public const int IsDestroyedFieldNumber = 2;

		// Token: 0x04003BAF RID: 15279
		private bool isDestroyed_;
	}
}
