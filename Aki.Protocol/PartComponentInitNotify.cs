using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB1 RID: 2993
	[NetMessage(EMessageId.PartComponentInitNotify)]
	public sealed class PartComponentInitNotify : IMessage<PartComponentInitNotify>, IMessage, IEquatable<PartComponentInitNotify>, IDeepCloneable<PartComponentInitNotify>, IBufferMessage
	{
		// Token: 0x060103DD RID: 66525 RVA: 0x0025F161 File Offset: 0x0025D361
		[NullableContext(1)]
		public static PartComponentInitNotify Create()
		{
			return new PartComponentInitNotify();
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x060103DE RID: 66526 RVA: 0x0025F168 File Offset: 0x0025D368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x060103DF RID: 66527 RVA: 0x0025F16B File Offset: 0x0025D36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentInitNotify.Descriptor;
			}
		}

		// Token: 0x060103E0 RID: 66528 RVA: 0x0025F172 File Offset: 0x0025D372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitNotify()
		{
		}

		// Token: 0x060103E1 RID: 66529 RVA: 0x0025F17C File Offset: 0x0025D37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitNotify(PartComponentInitNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partComponent_ = ((other.partComponent_ != null) ? other.partComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103E2 RID: 66530 RVA: 0x0025F1C8 File Offset: 0x0025D3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitNotify Clone()
		{
			return new PartComponentInitNotify(this);
		}

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x060103E3 RID: 66531 RVA: 0x0025F1D0 File Offset: 0x0025D3D0
		// (set) Token: 0x060103E4 RID: 66532 RVA: 0x0025F1D8 File Offset: 0x0025D3D8
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

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x060103E5 RID: 66533 RVA: 0x0025F1E1 File Offset: 0x0025D3E1
		// (set) Token: 0x060103E6 RID: 66534 RVA: 0x0025F1E9 File Offset: 0x0025D3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb PartComponent
		{
			get
			{
				return this.partComponent_;
			}
			set
			{
				this.partComponent_ = value;
			}
		}

		// Token: 0x060103E7 RID: 66535 RVA: 0x0025F1F2 File Offset: 0x0025D3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentInitNotify);
		}

		// Token: 0x060103E8 RID: 66536 RVA: 0x0025F200 File Offset: 0x0025D400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentInitNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.PartComponent, other.PartComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103E9 RID: 66537 RVA: 0x0025F250 File Offset: 0x0025D450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.partComponent_ != null)
			{
				num ^= this.PartComponent.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060103EA RID: 66538 RVA: 0x0025F2A5 File Offset: 0x0025D4A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103EB RID: 66539 RVA: 0x0025F2B2 File Offset: 0x0025D4B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060103EC RID: 66540 RVA: 0x0025F2BC File Offset: 0x0025D4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.partComponent_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PartComponent);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060103ED RID: 66541 RVA: 0x0025F318 File Offset: 0x0025D518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.partComponent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PartComponent);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060103EE RID: 66542 RVA: 0x0025F370 File Offset: 0x0025D570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartComponentInitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.partComponent_ != null)
			{
				if (this.partComponent_ == null)
				{
					this.PartComponent = new PartComponentPb();
				}
				this.PartComponent.MergeFrom(other.PartComponent);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060103EF RID: 66543 RVA: 0x0025F3D8 File Offset: 0x0025D5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060103F0 RID: 66544 RVA: 0x0025F3E4 File Offset: 0x0025D5E4
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
				if (num != 18U)
				{
					if (num != 48U)
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
					if (this.partComponent_ == null)
					{
						this.PartComponent = new PartComponentPb();
					}
					input.ReadMessage(this.PartComponent);
				}
			}
		}

		// Token: 0x040067B6 RID: 26550
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067B7 RID: 26551
		public const int EntityIdFieldNumber = 6;

		// Token: 0x040067B8 RID: 26552
		private long entityId_;

		// Token: 0x040067B9 RID: 26553
		public const int PartComponentFieldNumber = 2;

		// Token: 0x040067BA RID: 26554
		private PartComponentPb partComponent_;
	}
}
