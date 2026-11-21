using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000463 RID: 1123
	[NetMessage(EMessageId.EntityCalabashSkinChangeNotify)]
	public sealed class EntityCalabashSkinChangeNotify : IMessage<EntityCalabashSkinChangeNotify>, IMessage, IEquatable<EntityCalabashSkinChangeNotify>, IDeepCloneable<EntityCalabashSkinChangeNotify>, IBufferMessage
	{
		// Token: 0x06006B90 RID: 27536 RVA: 0x001042C4 File Offset: 0x001024C4
		[NullableContext(1)]
		public static EntityCalabashSkinChangeNotify Create()
		{
			return new EntityCalabashSkinChangeNotify();
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06006B91 RID: 27537 RVA: 0x001042CB File Offset: 0x001024CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06006B92 RID: 27538 RVA: 0x001042CE File Offset: 0x001024CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCalabashSkinChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x001042D5 File Offset: 0x001024D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCalabashSkinChangeNotify()
		{
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x001042E0 File Offset: 0x001024E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCalabashSkinChangeNotify(EntityCalabashSkinChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.calabashSkinComponent_ = ((other.calabashSkinComponent_ != null) ? other.calabashSkinComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x0010432C File Offset: 0x0010252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCalabashSkinChangeNotify Clone()
		{
			return new EntityCalabashSkinChangeNotify(this);
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06006B96 RID: 27542 RVA: 0x00104334 File Offset: 0x00102534
		// (set) Token: 0x06006B97 RID: 27543 RVA: 0x0010433C File Offset: 0x0010253C
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

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06006B98 RID: 27544 RVA: 0x00104345 File Offset: 0x00102545
		// (set) Token: 0x06006B99 RID: 27545 RVA: 0x0010434D File Offset: 0x0010254D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinComponentPb CalabashSkinComponent
		{
			get
			{
				return this.calabashSkinComponent_;
			}
			set
			{
				this.calabashSkinComponent_ = value;
			}
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00104356 File Offset: 0x00102556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCalabashSkinChangeNotify);
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00104364 File Offset: 0x00102564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCalabashSkinChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.CalabashSkinComponent, other.CalabashSkinComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x001043B4 File Offset: 0x001025B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.calabashSkinComponent_ != null)
			{
				num ^= this.CalabashSkinComponent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x00104409 File Offset: 0x00102609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x00104416 File Offset: 0x00102616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00104420 File Offset: 0x00102620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.calabashSkinComponent_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CalabashSkinComponent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x0010447C File Offset: 0x0010267C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.calabashSkinComponent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CalabashSkinComponent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x001044D4 File Offset: 0x001026D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityCalabashSkinChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.calabashSkinComponent_ != null)
			{
				if (this.calabashSkinComponent_ == null)
				{
					this.CalabashSkinComponent = new CalabashSkinComponentPb();
				}
				this.CalabashSkinComponent.MergeFrom(other.CalabashSkinComponent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x0010453C File Offset: 0x0010273C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x00104548 File Offset: 0x00102748
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.calabashSkinComponent_ == null)
						{
							this.CalabashSkinComponent = new CalabashSkinComponentPb();
						}
						input.ReadMessage(this.CalabashSkinComponent);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B0A RID: 15114
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B0B RID: 15115
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003B0C RID: 15116
		private long entityId_;

		// Token: 0x04003B0D RID: 15117
		public const int CalabashSkinComponentFieldNumber = 13;

		// Token: 0x04003B0E RID: 15118
		private CalabashSkinComponentPb calabashSkinComponent_;
	}
}
