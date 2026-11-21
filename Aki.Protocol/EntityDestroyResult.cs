using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046B RID: 1131
	public sealed class EntityDestroyResult : IMessage<EntityDestroyResult>, IMessage, IEquatable<EntityDestroyResult>, IDeepCloneable<EntityDestroyResult>, IBufferMessage
	{
		// Token: 0x06006CF8 RID: 27896 RVA: 0x0010C7C3 File Offset: 0x0010A9C3
		[NullableContext(1)]
		public static EntityDestroyResult Create()
		{
			return new EntityDestroyResult();
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06006CF9 RID: 27897 RVA: 0x0010C7CA File Offset: 0x0010A9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityDestroyResult> Parser
		{
			get
			{
				return EntityDestroyResult._parser;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x0010C7D1 File Offset: 0x0010A9D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x0010C7D4 File Offset: 0x0010A9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDestroyResult.Descriptor;
			}
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x0010C7DB File Offset: 0x0010A9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestroyResult()
		{
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x0010C7E3 File Offset: 0x0010A9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestroyResult(EntityDestroyResult other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isDestroyed_ = other.isDestroyed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x0010C814 File Offset: 0x0010AA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDestroyResult Clone()
		{
			return new EntityDestroyResult(this);
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x0010C81C File Offset: 0x0010AA1C
		// (set) Token: 0x06006D00 RID: 27904 RVA: 0x0010C824 File Offset: 0x0010AA24
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

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x0010C82D File Offset: 0x0010AA2D
		// (set) Token: 0x06006D02 RID: 27906 RVA: 0x0010C835 File Offset: 0x0010AA35
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

		// Token: 0x06006D03 RID: 27907 RVA: 0x0010C83E File Offset: 0x0010AA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDestroyResult);
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x0010C84C File Offset: 0x0010AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDestroyResult other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsDestroyed == other.IsDestroyed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x0010C88C File Offset: 0x0010AA8C
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

		// Token: 0x06006D06 RID: 27910 RVA: 0x0010C8E4 File Offset: 0x0010AAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x0010C8F1 File Offset: 0x0010AAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x0010C8FC File Offset: 0x0010AAFC
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

		// Token: 0x06006D09 RID: 27913 RVA: 0x0010C954 File Offset: 0x0010AB54
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

		// Token: 0x06006D0A RID: 27914 RVA: 0x0010C9A0 File Offset: 0x0010ABA0
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

		// Token: 0x06006D0B RID: 27915 RVA: 0x0010C9F0 File Offset: 0x0010ABF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x0010C9FC File Offset: 0x0010ABFC
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

		// Token: 0x04003B98 RID: 15256
		private static readonly MessageParser<EntityDestroyResult> _parser = new MessageParser<EntityDestroyResult>(() => new EntityDestroyResult());

		// Token: 0x04003B99 RID: 15257
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B9A RID: 15258
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003B9B RID: 15259
		private long entityId_;

		// Token: 0x04003B9C RID: 15260
		public const int IsDestroyedFieldNumber = 2;

		// Token: 0x04003B9D RID: 15261
		private bool isDestroyed_;
	}
}
