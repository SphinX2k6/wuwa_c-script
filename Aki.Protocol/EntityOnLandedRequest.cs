using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048F RID: 1167
	[NetMessage(EMessageId.EntityOnLandedRequest)]
	public sealed class EntityOnLandedRequest : IMessage<EntityOnLandedRequest>, IMessage, IEquatable<EntityOnLandedRequest>, IDeepCloneable<EntityOnLandedRequest>, IBufferMessage
	{
		// Token: 0x06006FED RID: 28653 RVA: 0x001135DD File Offset: 0x001117DD
		[NullableContext(1)]
		public static EntityOnLandedRequest Create()
		{
			return new EntityOnLandedRequest();
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06006FEE RID: 28654 RVA: 0x001135E4 File Offset: 0x001117E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06006FEF RID: 28655 RVA: 0x001135E7 File Offset: 0x001117E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityOnLandedRequest.Descriptor;
			}
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x001135EE File Offset: 0x001117EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedRequest()
		{
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x001135F6 File Offset: 0x001117F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedRequest(EntityOnLandedRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x0011361B File Offset: 0x0011181B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityOnLandedRequest Clone()
		{
			return new EntityOnLandedRequest(this);
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x00113623 File Offset: 0x00111823
		// (set) Token: 0x06006FF4 RID: 28660 RVA: 0x0011362B File Offset: 0x0011182B
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

		// Token: 0x06006FF5 RID: 28661 RVA: 0x00113634 File Offset: 0x00111834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityOnLandedRequest);
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x00113642 File Offset: 0x00111842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityOnLandedRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x00113670 File Offset: 0x00111870
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

		// Token: 0x06006FF8 RID: 28664 RVA: 0x001136AF File Offset: 0x001118AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x001136BC File Offset: 0x001118BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x001136C5 File Offset: 0x001118C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x001136F8 File Offset: 0x001118F8
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

		// Token: 0x06006FFC RID: 28668 RVA: 0x00113736 File Offset: 0x00111936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityOnLandedRequest other)
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

		// Token: 0x06006FFD RID: 28669 RVA: 0x00113767 File Offset: 0x00111967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x00113770 File Offset: 0x00111970
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C76 RID: 15478
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C77 RID: 15479
		public const int IdFieldNumber = 3;

		// Token: 0x04003C78 RID: 15480
		private long id_;
	}
}
