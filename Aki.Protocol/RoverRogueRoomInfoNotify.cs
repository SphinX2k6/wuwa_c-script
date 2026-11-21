using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001159 RID: 4441
	[NetMessage(EMessageId.RoverRogueRoomInfoNotify)]
	public sealed class RoverRogueRoomInfoNotify : IMessage<RoverRogueRoomInfoNotify>, IMessage, IEquatable<RoverRogueRoomInfoNotify>, IDeepCloneable<RoverRogueRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x06017BB7 RID: 97207 RVA: 0x0037499E File Offset: 0x00372B9E
		[NullableContext(1)]
		public static RoverRogueRoomInfoNotify Create()
		{
			return new RoverRogueRoomInfoNotify();
		}

		// Token: 0x17004FE1 RID: 20449
		// (get) Token: 0x06017BB8 RID: 97208 RVA: 0x003749A5 File Offset: 0x00372BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FE2 RID: 20450
		// (get) Token: 0x06017BB9 RID: 97209 RVA: 0x003749A8 File Offset: 0x00372BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06017BBA RID: 97210 RVA: 0x003749AF File Offset: 0x00372BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRoomInfoNotify()
		{
		}

		// Token: 0x06017BBB RID: 97211 RVA: 0x003749C4 File Offset: 0x00372BC4
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

		// Token: 0x06017BBC RID: 97212 RVA: 0x00374A35 File Offset: 0x00372C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRoomInfoNotify Clone()
		{
			return new RoverRogueRoomInfoNotify(this);
		}

		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x06017BBD RID: 97213 RVA: 0x00374A3D File Offset: 0x00372C3D
		// (set) Token: 0x06017BBE RID: 97214 RVA: 0x00374A45 File Offset: 0x00372C45
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

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x06017BBF RID: 97215 RVA: 0x00374A4E File Offset: 0x00372C4E
		// (set) Token: 0x06017BC0 RID: 97216 RVA: 0x00374A56 File Offset: 0x00372C56
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

		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x06017BC1 RID: 97217 RVA: 0x00374A5F File Offset: 0x00372C5F
		// (set) Token: 0x06017BC2 RID: 97218 RVA: 0x00374A67 File Offset: 0x00372C67
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

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x06017BC3 RID: 97219 RVA: 0x00374A70 File Offset: 0x00372C70
		// (set) Token: 0x06017BC4 RID: 97220 RVA: 0x00374A78 File Offset: 0x00372C78
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

		// Token: 0x17004FE7 RID: 20455
		// (get) Token: 0x06017BC5 RID: 97221 RVA: 0x00374A81 File Offset: 0x00372C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueNextRoomEntry> NextRoomEntries
		{
			get
			{
				return this.nextRoomEntries_;
			}
		}

		// Token: 0x17004FE8 RID: 20456
		// (get) Token: 0x06017BC6 RID: 97222 RVA: 0x00374A89 File Offset: 0x00372C89
		// (set) Token: 0x06017BC7 RID: 97223 RVA: 0x00374A91 File Offset: 0x00372C91
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

		// Token: 0x06017BC8 RID: 97224 RVA: 0x00374A9A File Offset: 0x00372C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueRoomInfoNotify);
		}

		// Token: 0x06017BC9 RID: 97225 RVA: 0x00374AA8 File Offset: 0x00372CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoomTypeId == other.RoomTypeId && this.RoomId == other.RoomId && this.nextRoomEntries_.Equals(other.nextRoomEntries_) && this.ShopEntityIncId == other.ShopEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BCA RID: 97226 RVA: 0x00374B38 File Offset: 0x00372D38
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

		// Token: 0x06017BCB RID: 97227 RVA: 0x00374BE9 File Offset: 0x00372DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BCC RID: 97228 RVA: 0x00374BF6 File Offset: 0x00372DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BCD RID: 97229 RVA: 0x00374C00 File Offset: 0x00372E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopEntityIncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ShopEntityIncId);
			}
			if (this.RoomId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoomId);
			}
			this.nextRoomEntries_.WriteTo(ref output, RoverRogueRoomInfoNotify._repeated_nextRoomEntries_codec);
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.RoomTypeId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoomTypeId);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurLayer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017BCE RID: 97230 RVA: 0x00374CC0 File Offset: 0x00372EC0
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

		// Token: 0x06017BCF RID: 97231 RVA: 0x00374D74 File Offset: 0x00372F74
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

		// Token: 0x06017BD0 RID: 97232 RVA: 0x00374E11 File Offset: 0x00373011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BD1 RID: 97233 RVA: 0x00374E1C File Offset: 0x0037301C
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
				if (num <= 58U)
				{
					if (num == 32U)
					{
						this.ShopEntityIncId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.RoomId = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.nextRoomEntries_.AddEntriesFrom(ref input, RoverRogueRoomInfoNotify._repeated_nextRoomEntries_codec);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.RoomTypeId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008DA8 RID: 36264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DA9 RID: 36265
		public const int CurLayerFieldNumber = 15;

		// Token: 0x04008DAA RID: 36266
		private int curLayer_;

		// Token: 0x04008DAB RID: 36267
		public const int MaxLayerFieldNumber = 8;

		// Token: 0x04008DAC RID: 36268
		private int maxLayer_;

		// Token: 0x04008DAD RID: 36269
		public const int RoomTypeIdFieldNumber = 13;

		// Token: 0x04008DAE RID: 36270
		private int roomTypeId_;

		// Token: 0x04008DAF RID: 36271
		public const int RoomIdFieldNumber = 6;

		// Token: 0x04008DB0 RID: 36272
		private int roomId_;

		// Token: 0x04008DB1 RID: 36273
		public const int NextRoomEntriesFieldNumber = 7;

		// Token: 0x04008DB2 RID: 36274
		private static readonly FieldCodec<RoverRogueNextRoomEntry> _repeated_nextRoomEntries_codec = FieldCodec.ForMessage<RoverRogueNextRoomEntry>(58U, RoverRogueNextRoomEntry.Parser);

		// Token: 0x04008DB3 RID: 36275
		private readonly RepeatedField<RoverRogueNextRoomEntry> nextRoomEntries_ = new RepeatedField<RoverRogueNextRoomEntry>();

		// Token: 0x04008DB4 RID: 36276
		public const int ShopEntityIncIdFieldNumber = 4;

		// Token: 0x04008DB5 RID: 36277
		private int shopEntityIncId_;
	}
}
