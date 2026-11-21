using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AB RID: 1195
	public sealed class EntityStateChangeResult : IMessage<EntityStateChangeResult>, IMessage, IEquatable<EntityStateChangeResult>, IDeepCloneable<EntityStateChangeResult>, IBufferMessage
	{
		// Token: 0x06007244 RID: 29252 RVA: 0x00118C80 File Offset: 0x00116E80
		[NullableContext(1)]
		public static EntityStateChangeResult Create()
		{
			return new EntityStateChangeResult();
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x06007245 RID: 29253 RVA: 0x00118C87 File Offset: 0x00116E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityStateChangeResult> Parser
		{
			get
			{
				return EntityStateChangeResult._parser;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06007246 RID: 29254 RVA: 0x00118C8E File Offset: 0x00116E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06007247 RID: 29255 RVA: 0x00118C91 File Offset: 0x00116E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStateChangeResult.Descriptor;
			}
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00118C98 File Offset: 0x00116E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateChangeResult()
		{
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x00118CA0 File Offset: 0x00116EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateChangeResult(EntityStateChangeResult other) : this()
		{
			this.entityId_ = other.entityId_;
			this.stateTagId_ = other.stateTagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00118CD1 File Offset: 0x00116ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateChangeResult Clone()
		{
			return new EntityStateChangeResult(this);
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x00118CD9 File Offset: 0x00116ED9
		// (set) Token: 0x0600724C RID: 29260 RVA: 0x00118CE1 File Offset: 0x00116EE1
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

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600724D RID: 29261 RVA: 0x00118CEA File Offset: 0x00116EEA
		// (set) Token: 0x0600724E RID: 29262 RVA: 0x00118CF2 File Offset: 0x00116EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateTagId
		{
			get
			{
				return this.stateTagId_;
			}
			set
			{
				this.stateTagId_ = value;
			}
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00118CFB File Offset: 0x00116EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStateChangeResult);
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x00118D09 File Offset: 0x00116F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStateChangeResult other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.StateTagId == other.StateTagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x00118D48 File Offset: 0x00116F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.StateTagId != 0)
			{
				num ^= this.StateTagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x00118DA0 File Offset: 0x00116FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00118DAD File Offset: 0x00116FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00118DB8 File Offset: 0x00116FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.StateTagId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00118E10 File Offset: 0x00117010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.StateTagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateTagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x00118E68 File Offset: 0x00117068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStateChangeResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.StateTagId != 0)
			{
				this.StateTagId = other.StateTagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x00118EB8 File Offset: 0x001170B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00118EC4 File Offset: 0x001170C4
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
						this.StateTagId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D2B RID: 15659
		private static readonly MessageParser<EntityStateChangeResult> _parser = new MessageParser<EntityStateChangeResult>(() => new EntityStateChangeResult());

		// Token: 0x04003D2C RID: 15660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D2D RID: 15661
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003D2E RID: 15662
		private long entityId_;

		// Token: 0x04003D2F RID: 15663
		public const int StateTagIdFieldNumber = 2;

		// Token: 0x04003D30 RID: 15664
		private int stateTagId_;
	}
}
