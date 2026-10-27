using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC2 RID: 3010
	[NetMessage(EMessageId.PartComponentInitRequest)]
	public sealed class PartComponentInitRequest : IMessage<PartComponentInitRequest>, IMessage, IEquatable<PartComponentInitRequest>, IDeepCloneable<PartComponentInitRequest>, IBufferMessage
	{
		// Token: 0x060104F5 RID: 66805 RVA: 0x00261307 File Offset: 0x0025F507
		[NullableContext(1)]
		public static PartComponentInitRequest Create()
		{
			return new PartComponentInitRequest();
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x060104F6 RID: 66806 RVA: 0x0026130E File Offset: 0x0025F50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x060104F7 RID: 66807 RVA: 0x00261311 File Offset: 0x0025F511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentInitRequest.Descriptor;
			}
		}

		// Token: 0x060104F8 RID: 66808 RVA: 0x00261318 File Offset: 0x0025F518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitRequest()
		{
		}

		// Token: 0x060104F9 RID: 66809 RVA: 0x00261320 File Offset: 0x0025F520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitRequest(PartComponentInitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partComponent_ = ((other.partComponent_ != null) ? other.partComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060104FA RID: 66810 RVA: 0x0026136C File Offset: 0x0025F56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitRequest Clone()
		{
			return new PartComponentInitRequest(this);
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x060104FB RID: 66811 RVA: 0x00261374 File Offset: 0x0025F574
		// (set) Token: 0x060104FC RID: 66812 RVA: 0x0026137C File Offset: 0x0025F57C
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

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x060104FD RID: 66813 RVA: 0x00261385 File Offset: 0x0025F585
		// (set) Token: 0x060104FE RID: 66814 RVA: 0x0026138D File Offset: 0x0025F58D
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

		// Token: 0x060104FF RID: 66815 RVA: 0x00261396 File Offset: 0x0025F596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentInitRequest);
		}

		// Token: 0x06010500 RID: 66816 RVA: 0x002613A4 File Offset: 0x0025F5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentInitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.PartComponent, other.PartComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010501 RID: 66817 RVA: 0x002613F4 File Offset: 0x0025F5F4
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

		// Token: 0x06010502 RID: 66818 RVA: 0x00261449 File Offset: 0x0025F649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010503 RID: 66819 RVA: 0x00261456 File Offset: 0x0025F656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010504 RID: 66820 RVA: 0x00261460 File Offset: 0x0025F660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this.partComponent_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PartComponent);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010505 RID: 66821 RVA: 0x002614BC File Offset: 0x0025F6BC
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

		// Token: 0x06010506 RID: 66822 RVA: 0x00261514 File Offset: 0x0025F714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartComponentInitRequest other)
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

		// Token: 0x06010507 RID: 66823 RVA: 0x0026157C File Offset: 0x0025F77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010508 RID: 66824 RVA: 0x00261588 File Offset: 0x0025F788
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040067AB RID: 26539
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067AC RID: 26540
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040067AD RID: 26541
		private long entityId_;

		// Token: 0x040067AE RID: 26542
		public const int PartComponentFieldNumber = 12;

		// Token: 0x040067AF RID: 26543
		private PartComponentPb partComponent_;
	}
}
