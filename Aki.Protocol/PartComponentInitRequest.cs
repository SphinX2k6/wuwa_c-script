using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB2 RID: 2994
	[NetMessage(EMessageId.PartComponentInitRequest)]
	public sealed class PartComponentInitRequest : IMessage<PartComponentInitRequest>, IMessage, IEquatable<PartComponentInitRequest>, IDeepCloneable<PartComponentInitRequest>, IBufferMessage
	{
		// Token: 0x060103F1 RID: 66545 RVA: 0x0025F44F File Offset: 0x0025D64F
		[NullableContext(1)]
		public static PartComponentInitRequest Create()
		{
			return new PartComponentInitRequest();
		}

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x060103F2 RID: 66546 RVA: 0x0025F456 File Offset: 0x0025D656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x060103F3 RID: 66547 RVA: 0x0025F459 File Offset: 0x0025D659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentInitRequest.Descriptor;
			}
		}

		// Token: 0x060103F4 RID: 66548 RVA: 0x0025F460 File Offset: 0x0025D660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitRequest()
		{
		}

		// Token: 0x060103F5 RID: 66549 RVA: 0x0025F468 File Offset: 0x0025D668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitRequest(PartComponentInitRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.partComponent_ = ((other.partComponent_ != null) ? other.partComponent_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060103F6 RID: 66550 RVA: 0x0025F4B4 File Offset: 0x0025D6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentInitRequest Clone()
		{
			return new PartComponentInitRequest(this);
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x060103F7 RID: 66551 RVA: 0x0025F4BC File Offset: 0x0025D6BC
		// (set) Token: 0x060103F8 RID: 66552 RVA: 0x0025F4C4 File Offset: 0x0025D6C4
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

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x060103F9 RID: 66553 RVA: 0x0025F4CD File Offset: 0x0025D6CD
		// (set) Token: 0x060103FA RID: 66554 RVA: 0x0025F4D5 File Offset: 0x0025D6D5
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

		// Token: 0x060103FB RID: 66555 RVA: 0x0025F4DE File Offset: 0x0025D6DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentInitRequest);
		}

		// Token: 0x060103FC RID: 66556 RVA: 0x0025F4EC File Offset: 0x0025D6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentInitRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.PartComponent, other.PartComponent) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060103FD RID: 66557 RVA: 0x0025F53C File Offset: 0x0025D73C
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

		// Token: 0x060103FE RID: 66558 RVA: 0x0025F591 File Offset: 0x0025D791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060103FF RID: 66559 RVA: 0x0025F59E File Offset: 0x0025D79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010400 RID: 66560 RVA: 0x0025F5A8 File Offset: 0x0025D7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.partComponent_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PartComponent);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010401 RID: 66561 RVA: 0x0025F604 File Offset: 0x0025D804
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

		// Token: 0x06010402 RID: 66562 RVA: 0x0025F65C File Offset: 0x0025D85C
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

		// Token: 0x06010403 RID: 66563 RVA: 0x0025F6C4 File Offset: 0x0025D8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010404 RID: 66564 RVA: 0x0025F6D0 File Offset: 0x0025D8D0
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
				if (num != 34U)
				{
					if (num != 64U)
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

		// Token: 0x040067BB RID: 26555
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067BC RID: 26556
		public const int EntityIdFieldNumber = 8;

		// Token: 0x040067BD RID: 26557
		private long entityId_;

		// Token: 0x040067BE RID: 26558
		public const int PartComponentFieldNumber = 4;

		// Token: 0x040067BF RID: 26559
		private PartComponentPb partComponent_;
	}
}
