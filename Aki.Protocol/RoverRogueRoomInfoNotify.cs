using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111F RID: 4383
	[NetMessage(EMessageId.RoverRogueRoomInfoNotify)]
	public sealed class RoverRogueRoomInfoNotify : IMessage<RoverRogueRoomInfoNotify>, IMessage, IEquatable<RoverRogueRoomInfoNotify>, IDeepCloneable<RoverRogueRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x06017616 RID: 95766 RVA: 0x00365653 File Offset: 0x00363853
		[NullableContext(1)]
		public static RoverRogueRoomInfoNotify Create()
		{
			return new RoverRogueRoomInfoNotify();
		}

		// Token: 0x17004E75 RID: 20085
		// (get) Token: 0x06017617 RID: 95767 RVA: 0x0036565A File Offset: 0x0036385A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E76 RID: 20086
		// (get) Token: 0x06017618 RID: 95768 RVA: 0x0036565D File Offset: 0x0036385D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06017619 RID: 95769 RVA: 0x00365664 File Offset: 0x00363864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRoomInfoNotify()
		{
		}

		// Token: 0x0601761A RID: 95770 RVA: 0x00365678 File Offset: 0x00363878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRoomInfoNotify(RoverRogueRoomInfoNotify other) : this()
		{
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.roomTypeId_ = other.roomTypeId_;
			this.roomId_ = other.roomId_;
			this.nextRoomEntries_ = other.nextRoomEntries_.Clone();
			this.shopEntityIncId_ = other.shopEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601761B RID: 95771 RVA: 0x003656E9 File Offset: 0x003638E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRoomInfoNotify Clone()
		{
			return new RoverRogueRoomInfoNotify(this);
		}

		// Token: 0x17004E77 RID: 20087
		// (get) Token: 0x0601761C RID: 95772 RVA: 0x003656F1 File Offset: 0x003638F1
		// (set) Token: 0x0601761D RID: 95773 RVA: 0x003656F9 File Offset: 0x003638F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x17004E78 RID: 20088
		// (get) Token: 0x0601761E RID: 95774 RVA: 0x00365702 File Offset: 0x00363902
		// (set) Token: 0x0601761F RID: 95775 RVA: 0x0036570A File Offset: 0x0036390A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLayer
		{
			get
			{
				return this.maxLayer_;
			}
			set
			{
				this.maxLayer_ = value;
			}
		}

		// Token: 0x17004E79 RID: 20089
		// (get) Token: 0x06017620 RID: 95776 RVA: 0x00365713 File Offset: 0x00363913
		// (set) Token: 0x06017621 RID: 95777 RVA: 0x0036571B File Offset: 0x0036391B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomTypeId
		{
			get
			{
				return this.roomTypeId_;
			}
			set
			{
				this.roomTypeId_ = value;
			}
		}

		// Token: 0x17004E7A RID: 20090
		// (get) Token: 0x06017622 RID: 95778 RVA: 0x00365724 File Offset: 0x00363924
		// (set) Token: 0x06017623 RID: 95779 RVA: 0x0036572C File Offset: 0x0036392C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x17004E7B RID: 20091
		// (get) Token: 0x06017624 RID: 95780 RVA: 0x00365735 File Offset: 0x00363935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueNextRoomEntry> NextRoomEntries
		{
			get
			{
				return this.nextRoomEntries_;
			}
		}

		// Token: 0x17004E7C RID: 20092
		// (get) Token: 0x06017625 RID: 95781 RVA: 0x0036573D File Offset: 0x0036393D
		// (set) Token: 0x06017626 RID: 95782 RVA: 0x00365745 File Offset: 0x00363945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopEntityIncId
		{
			get
			{
				return this.shopEntityIncId_;
			}
			set
			{
				this.shopEntityIncId_ = value;
			}
		}

		// Token: 0x06017627 RID: 95783 RVA: 0x0036574E File Offset: 0x0036394E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueRoomInfoNotify);
		}

		// Token: 0x06017628 RID: 95784 RVA: 0x0036575C File Offset: 0x0036395C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoomTypeId == other.RoomTypeId && this.RoomId == other.RoomId && this.nextRoomEntries_.Equals(other.nextRoomEntries_) && this.ShopEntityIncId == other.ShopEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017629 RID: 95785 RVA: 0x003657EC File Offset: 0x003639EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.RoomTypeId != 0)
			{
				num ^= this.RoomTypeId.GetHashCode();
			}
			if (this.RoomId != 0)
			{
				num ^= this.RoomId.GetHashCode();
			}
			num ^= this.nextRoomEntries_.GetHashCode();
			if (this.ShopEntityIncId != 0)
			{
				num ^= this.ShopEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601762A RID: 95786 RVA: 0x0036589D File Offset: 0x00363A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601762B RID: 95787 RVA: 0x003658AA File Offset: 0x00363AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601762C RID: 95788 RVA: 0x003658B4 File Offset: 0x00363AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopEntityIncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ShopEntityIncId);
			}
			this.nextRoomEntries_.WriteTo(ref output, RoverRogueRoomInfoNotify._repeated_nextRoomEntries_codec);
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.RoomTypeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoomTypeId);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoomId);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CurLayer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601762D RID: 95789 RVA: 0x00365974 File Offset: 0x00363B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.RoomTypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomTypeId);
			}
			if (this.RoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoomId);
			}
			num += this.nextRoomEntries_.CalculateSize(RoverRogueRoomInfoNotify._repeated_nextRoomEntries_codec);
			if (this.ShopEntityIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601762E RID: 95790 RVA: 0x00365A28 File Offset: 0x00363C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueRoomInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.RoomTypeId != 0)
			{
				this.RoomTypeId = other.RoomTypeId;
			}
			if (other.RoomId != 0)
			{
				this.RoomId = other.RoomId;
			}
			this.nextRoomEntries_.Add(other.nextRoomEntries_);
			if (other.ShopEntityIncId != 0)
			{
				this.ShopEntityIncId = other.ShopEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601762F RID: 95791 RVA: 0x00365AC5 File Offset: 0x00363CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017630 RID: 95792 RVA: 0x00365AD0 File Offset: 0x00363CD0
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.ShopEntityIncId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.nextRoomEntries_.AddEntriesFrom(ref input, RoverRogueRoomInfoNotify._repeated_nextRoomEntries_codec);
						continue;
					}
					if (num == 56U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.RoomTypeId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoomId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B15 RID: 35605
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B16 RID: 35606
		public const int CurLayerFieldNumber = 12;

		// Token: 0x04008B17 RID: 35607
		private int curLayer_;

		// Token: 0x04008B18 RID: 35608
		public const int MaxLayerFieldNumber = 7;

		// Token: 0x04008B19 RID: 35609
		private int maxLayer_;

		// Token: 0x04008B1A RID: 35610
		public const int RoomTypeIdFieldNumber = 9;

		// Token: 0x04008B1B RID: 35611
		private int roomTypeId_;

		// Token: 0x04008B1C RID: 35612
		public const int RoomIdFieldNumber = 10;

		// Token: 0x04008B1D RID: 35613
		private int roomId_;

		// Token: 0x04008B1E RID: 35614
		public const int NextRoomEntriesFieldNumber = 4;

		// Token: 0x04008B1F RID: 35615
		private static readonly FieldCodec<RoverRogueNextRoomEntry> _repeated_nextRoomEntries_codec = FieldCodec.ForMessage<RoverRogueNextRoomEntry>(34U, RoverRogueNextRoomEntry.Parser);

		// Token: 0x04008B20 RID: 35616
		private readonly RepeatedField<RoverRogueNextRoomEntry> nextRoomEntries_ = new RepeatedField<RoverRogueNextRoomEntry>();

		// Token: 0x04008B21 RID: 35617
		public const int ShopEntityIncIdFieldNumber = 3;

		// Token: 0x04008B22 RID: 35618
		private int shopEntityIncId_;
	}
}
