using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048E RID: 1166
	[NetMessage(EMessageId.EntityOnLandedNotify)]
	public sealed class EntityOnLandedNotify : IMessage<EntityOnLandedNotify>, IMessage, IEquatable<EntityOnLandedNotify>, IDeepCloneable<EntityOnLandedNotify>, IBufferMessage
	{
		// Token: 0x06006FDB RID: 28635 RVA: 0x00113405 File Offset: 0x00111605
		[NullableContext(1)]
		public static EntityOnLandedNotify Create()
		{
			return new EntityOnLandedNotify();
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06006FDC RID: 28636 RVA: 0x0011340C File Offset: 0x0011160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06006FDD RID: 28637 RVA: 0x0011340F File Offset: 0x0011160F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityOnLandedNotify.Descriptor;
			}
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x00113416 File Offset: 0x00111616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedNotify()
		{
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x0011341E File Offset: 0x0011161E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedNotify(EntityOnLandedNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x00113443 File Offset: 0x00111643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedNotify Clone()
		{
			return new EntityOnLandedNotify(this);
		}

		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x06006FE1 RID: 28641 RVA: 0x0011344B File Offset: 0x0011164B
		// (set) Token: 0x06006FE2 RID: 28642 RVA: 0x00113453 File Offset: 0x00111653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x0011345C File Offset: 0x0011165C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityOnLandedNotify);
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x0011346A File Offset: 0x0011166A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityOnLandedNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x00113498 File Offset: 0x00111698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x001134D7 File Offset: 0x001116D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x001134E4 File Offset: 0x001116E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x001134ED File Offset: 0x001116ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x00113520 File Offset: 0x00111720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x0011355E File Offset: 0x0011175E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityOnLandedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x0011358F File Offset: 0x0011178F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x00113598 File Offset: 0x00111798
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C73 RID: 15475
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C74 RID: 15476
		public const int IdFieldNumber = 8;

		// Token: 0x04003C75 RID: 15477
		private long id_;
	}
}
