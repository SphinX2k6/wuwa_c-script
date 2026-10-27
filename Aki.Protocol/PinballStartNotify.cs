using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D62 RID: 3426
	[NetMessage(EMessageId.PinballStartNotify)]
	public sealed class PinballStartNotify : IMessage<PinballStartNotify>, IMessage, IEquatable<PinballStartNotify>, IDeepCloneable<PinballStartNotify>, IBufferMessage
	{
		// Token: 0x060127A8 RID: 75688 RVA: 0x002B24C4 File Offset: 0x002B06C4
		[NullableContext(1)]
		public static PinballStartNotify Create()
		{
			return new PinballStartNotify();
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x060127A9 RID: 75689 RVA: 0x002B24CB File Offset: 0x002B06CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x060127AA RID: 75690 RVA: 0x002B24CE File Offset: 0x002B06CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballStartNotify.Descriptor;
			}
		}

		// Token: 0x060127AB RID: 75691 RVA: 0x002B24D5 File Offset: 0x002B06D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballStartNotify()
		{
		}

		// Token: 0x060127AC RID: 75692 RVA: 0x002B24E0 File Offset: 0x002B06E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballStartNotify(PinballStartNotify other) : this()
		{
			this.realLevelId_ = other.realLevelId_;
			this.inProgressPb_ = ((other.inProgressPb_ != null) ? other.inProgressPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060127AD RID: 75693 RVA: 0x002B252C File Offset: 0x002B072C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballStartNotify Clone()
		{
			return new PinballStartNotify(this);
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x060127AE RID: 75694 RVA: 0x002B2534 File Offset: 0x002B0734
		// (set) Token: 0x060127AF RID: 75695 RVA: 0x002B253C File Offset: 0x002B073C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RealLevelId
		{
			get
			{
				return this.realLevelId_;
			}
			set
			{
				this.realLevelId_ = value;
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x060127B0 RID: 75696 RVA: 0x002B2545 File Offset: 0x002B0745
		// (set) Token: 0x060127B1 RID: 75697 RVA: 0x002B254D File Offset: 0x002B074D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballInProgressPb InProgressPb
		{
			get
			{
				return this.inProgressPb_;
			}
			set
			{
				this.inProgressPb_ = value;
			}
		}

		// Token: 0x060127B2 RID: 75698 RVA: 0x002B2556 File Offset: 0x002B0756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballStartNotify);
		}

		// Token: 0x060127B3 RID: 75699 RVA: 0x002B2564 File Offset: 0x002B0764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballStartNotify other)
		{
			return other != null && (other == this || (this.RealLevelId == other.RealLevelId && object.Equals(this.InProgressPb, other.InProgressPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060127B4 RID: 75700 RVA: 0x002B25B4 File Offset: 0x002B07B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RealLevelId != 0)
			{
				num ^= this.RealLevelId.GetHashCode();
			}
			if (this.inProgressPb_ != null)
			{
				num ^= this.InProgressPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060127B5 RID: 75701 RVA: 0x002B2609 File Offset: 0x002B0809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060127B6 RID: 75702 RVA: 0x002B2616 File Offset: 0x002B0816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060127B7 RID: 75703 RVA: 0x002B2620 File Offset: 0x002B0820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inProgressPb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.InProgressPb);
			}
			if (this.RealLevelId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RealLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060127B8 RID: 75704 RVA: 0x002B267C File Offset: 0x002B087C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RealLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RealLevelId);
			}
			if (this.inProgressPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InProgressPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060127B9 RID: 75705 RVA: 0x002B26D4 File Offset: 0x002B08D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RealLevelId != 0)
			{
				this.RealLevelId = other.RealLevelId;
			}
			if (other.inProgressPb_ != null)
			{
				if (this.inProgressPb_ == null)
				{
					this.InProgressPb = new PinballInProgressPb();
				}
				this.InProgressPb.MergeFrom(other.InProgressPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060127BA RID: 75706 RVA: 0x002B273C File Offset: 0x002B093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060127BB RID: 75707 RVA: 0x002B2748 File Offset: 0x002B0948
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
				if (num != 10U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RealLevelId = input.ReadInt32();
					}
				}
				else
				{
					if (this.inProgressPb_ == null)
					{
						this.InProgressPb = new PinballInProgressPb();
					}
					input.ReadMessage(this.InProgressPb);
				}
			}
		}

		// Token: 0x040072F4 RID: 29428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072F5 RID: 29429
		public const int RealLevelIdFieldNumber = 10;

		// Token: 0x040072F6 RID: 29430
		private int realLevelId_;

		// Token: 0x040072F7 RID: 29431
		public const int InProgressPbFieldNumber = 1;

		// Token: 0x040072F8 RID: 29432
		private PinballInProgressPb inProgressPb_;
	}
}
