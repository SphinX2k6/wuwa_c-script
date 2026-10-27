using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DB RID: 5339
	[NetMessage(EMessageId.VehicleUpdateNotify)]
	public sealed class VehicleUpdateNotify : IMessage<VehicleUpdateNotify>, IMessage, IEquatable<VehicleUpdateNotify>, IDeepCloneable<VehicleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C3B9 RID: 115641 RVA: 0x00414905 File Offset: 0x00412B05
		[NullableContext(1)]
		public static VehicleUpdateNotify Create()
		{
			return new VehicleUpdateNotify();
		}

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x0601C3BA RID: 115642 RVA: 0x0041490C File Offset: 0x00412B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F30 RID: 24368
		// (get) Token: 0x0601C3BB RID: 115643 RVA: 0x0041490F File Offset: 0x00412B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C3BC RID: 115644 RVA: 0x00414916 File Offset: 0x00412B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateNotify()
		{
		}

		// Token: 0x0601C3BD RID: 115645 RVA: 0x00414920 File Offset: 0x00412B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateNotify(VehicleUpdateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityId_ = other.entityId_;
			this.seatId_ = other.seatId_;
			this.exitType_ = other.exitType_;
			this.clientPredicted_ = other.clientPredicted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3BE RID: 115646 RVA: 0x00414980 File Offset: 0x00412B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateNotify Clone()
		{
			return new VehicleUpdateNotify(this);
		}

		// Token: 0x17005F31 RID: 24369
		// (get) Token: 0x0601C3BF RID: 115647 RVA: 0x00414988 File Offset: 0x00412B88
		// (set) Token: 0x0601C3C0 RID: 115648 RVA: 0x00414990 File Offset: 0x00412B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17005F32 RID: 24370
		// (get) Token: 0x0601C3C1 RID: 115649 RVA: 0x00414999 File Offset: 0x00412B99
		// (set) Token: 0x0601C3C2 RID: 115650 RVA: 0x004149A1 File Offset: 0x00412BA1
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

		// Token: 0x17005F33 RID: 24371
		// (get) Token: 0x0601C3C3 RID: 115651 RVA: 0x004149AA File Offset: 0x00412BAA
		// (set) Token: 0x0601C3C4 RID: 115652 RVA: 0x004149B2 File Offset: 0x00412BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeatId
		{
			get
			{
				return this.seatId_;
			}
			set
			{
				this.seatId_ = value;
			}
		}

		// Token: 0x17005F34 RID: 24372
		// (get) Token: 0x0601C3C5 RID: 115653 RVA: 0x004149BB File Offset: 0x00412BBB
		// (set) Token: 0x0601C3C6 RID: 115654 RVA: 0x004149C3 File Offset: 0x00412BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitVehicleType ExitType
		{
			get
			{
				return this.exitType_;
			}
			set
			{
				this.exitType_ = value;
			}
		}

		// Token: 0x17005F35 RID: 24373
		// (get) Token: 0x0601C3C7 RID: 115655 RVA: 0x004149CC File Offset: 0x00412BCC
		// (set) Token: 0x0601C3C8 RID: 115656 RVA: 0x004149D4 File Offset: 0x00412BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ClientPredicted
		{
			get
			{
				return this.clientPredicted_;
			}
			set
			{
				this.clientPredicted_ = value;
			}
		}

		// Token: 0x0601C3C9 RID: 115657 RVA: 0x004149DD File Offset: 0x00412BDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleUpdateNotify);
		}

		// Token: 0x0601C3CA RID: 115658 RVA: 0x004149EC File Offset: 0x00412BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && this.SeatId == other.SeatId && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3CB RID: 115659 RVA: 0x00414A68 File Offset: 0x00412C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SeatId != 0)
			{
				num ^= this.SeatId.GetHashCode();
			}
			if (this.ExitType != ExitVehicleType.Launch)
			{
				num ^= this.ExitType.GetHashCode();
			}
			if (this.ClientPredicted)
			{
				num ^= this.ClientPredicted.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C3CC RID: 115660 RVA: 0x00414B12 File Offset: 0x00412D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3CD RID: 115661 RVA: 0x00414B1F File Offset: 0x00412D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3CE RID: 115662 RVA: 0x00414B28 File Offset: 0x00412D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ClientPredicted);
			}
			if (this.ExitType != ExitVehicleType.Launch)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SeatId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3CF RID: 115663 RVA: 0x00414BD8 File Offset: 0x00412DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SeatId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeatId);
			}
			if (this.ExitType != ExitVehicleType.Launch)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExitType);
			}
			if (this.ClientPredicted)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C3D0 RID: 115664 RVA: 0x00414C6C File Offset: 0x00412E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SeatId != 0)
			{
				this.SeatId = other.SeatId;
			}
			if (other.ExitType != ExitVehicleType.Launch)
			{
				this.ExitType = other.ExitType;
			}
			if (other.ClientPredicted)
			{
				this.ClientPredicted = other.ClientPredicted;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C3D1 RID: 115665 RVA: 0x00414CF8 File Offset: 0x00412EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3D2 RID: 115666 RVA: 0x00414D04 File Offset: 0x00412F04
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.ClientPredicted = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.ExitType = (ExitVehicleType)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A1E2 RID: 41442
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1E3 RID: 41443
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x0400A1E4 RID: 41444
		private int playerId_;

		// Token: 0x0400A1E5 RID: 41445
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400A1E6 RID: 41446
		private long entityId_;

		// Token: 0x0400A1E7 RID: 41447
		public const int SeatIdFieldNumber = 13;

		// Token: 0x0400A1E8 RID: 41448
		private int seatId_;

		// Token: 0x0400A1E9 RID: 41449
		public const int ExitTypeFieldNumber = 6;

		// Token: 0x0400A1EA RID: 41450
		private ExitVehicleType exitType_;

		// Token: 0x0400A1EB RID: 41451
		public const int ClientPredictedFieldNumber = 3;

		// Token: 0x0400A1EC RID: 41452
		private bool clientPredicted_;
	}
}
