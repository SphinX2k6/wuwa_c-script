using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001550 RID: 5456
	[NetMessage(EMessageId.VehicleUpdateEntityNotify)]
	public sealed class VehicleUpdateEntityNotify : IMessage<VehicleUpdateEntityNotify>, IMessage, IEquatable<VehicleUpdateEntityNotify>, IDeepCloneable<VehicleUpdateEntityNotify>, IBufferMessage
	{
		// Token: 0x0601CE64 RID: 118372 RVA: 0x0042FE8D File Offset: 0x0042E08D
		[NullableContext(1)]
		public static VehicleUpdateEntityNotify Create()
		{
			return new VehicleUpdateEntityNotify();
		}

		// Token: 0x170061C8 RID: 25032
		// (get) Token: 0x0601CE65 RID: 118373 RVA: 0x0042FE94 File Offset: 0x0042E094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061C9 RID: 25033
		// (get) Token: 0x0601CE66 RID: 118374 RVA: 0x0042FE97 File Offset: 0x0042E097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleUpdateEntityNotify.Descriptor;
			}
		}

		// Token: 0x0601CE67 RID: 118375 RVA: 0x0042FE9E File Offset: 0x0042E09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateEntityNotify()
		{
		}

		// Token: 0x0601CE68 RID: 118376 RVA: 0x0042FEA8 File Offset: 0x0042E0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateEntityNotify(VehicleUpdateEntityNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.vehicleId_ = other.vehicleId_;
			this.seatId_ = other.seatId_;
			this.isGetOn_ = other.isGetOn_;
			this.exitType_ = other.exitType_;
			this.clientPredicted_ = other.clientPredicted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CE69 RID: 118377 RVA: 0x0042FF14 File Offset: 0x0042E114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateEntityNotify Clone()
		{
			return new VehicleUpdateEntityNotify(this);
		}

		// Token: 0x170061CA RID: 25034
		// (get) Token: 0x0601CE6A RID: 118378 RVA: 0x0042FF1C File Offset: 0x0042E11C
		// (set) Token: 0x0601CE6B RID: 118379 RVA: 0x0042FF24 File Offset: 0x0042E124
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

		// Token: 0x170061CB RID: 25035
		// (get) Token: 0x0601CE6C RID: 118380 RVA: 0x0042FF2D File Offset: 0x0042E12D
		// (set) Token: 0x0601CE6D RID: 118381 RVA: 0x0042FF35 File Offset: 0x0042E135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long VehicleId
		{
			get
			{
				return this.vehicleId_;
			}
			set
			{
				this.vehicleId_ = value;
			}
		}

		// Token: 0x170061CC RID: 25036
		// (get) Token: 0x0601CE6E RID: 118382 RVA: 0x0042FF3E File Offset: 0x0042E13E
		// (set) Token: 0x0601CE6F RID: 118383 RVA: 0x0042FF46 File Offset: 0x0042E146
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

		// Token: 0x170061CD RID: 25037
		// (get) Token: 0x0601CE70 RID: 118384 RVA: 0x0042FF4F File Offset: 0x0042E14F
		// (set) Token: 0x0601CE71 RID: 118385 RVA: 0x0042FF57 File Offset: 0x0042E157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGetOn
		{
			get
			{
				return this.isGetOn_;
			}
			set
			{
				this.isGetOn_ = value;
			}
		}

		// Token: 0x170061CE RID: 25038
		// (get) Token: 0x0601CE72 RID: 118386 RVA: 0x0042FF60 File Offset: 0x0042E160
		// (set) Token: 0x0601CE73 RID: 118387 RVA: 0x0042FF68 File Offset: 0x0042E168
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

		// Token: 0x170061CF RID: 25039
		// (get) Token: 0x0601CE74 RID: 118388 RVA: 0x0042FF71 File Offset: 0x0042E171
		// (set) Token: 0x0601CE75 RID: 118389 RVA: 0x0042FF79 File Offset: 0x0042E179
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

		// Token: 0x0601CE76 RID: 118390 RVA: 0x0042FF82 File Offset: 0x0042E182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleUpdateEntityNotify);
		}

		// Token: 0x0601CE77 RID: 118391 RVA: 0x0042FF90 File Offset: 0x0042E190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleUpdateEntityNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.VehicleId == other.VehicleId && this.SeatId == other.SeatId && this.IsGetOn == other.IsGetOn && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE78 RID: 118392 RVA: 0x0043001C File Offset: 0x0042E21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.VehicleId != 0L)
			{
				num ^= this.VehicleId.GetHashCode();
			}
			if (this.SeatId != 0)
			{
				num ^= this.SeatId.GetHashCode();
			}
			if (this.IsGetOn)
			{
				num ^= this.IsGetOn.GetHashCode();
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

		// Token: 0x0601CE79 RID: 118393 RVA: 0x004300DF File Offset: 0x0042E2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE7A RID: 118394 RVA: 0x004300EC File Offset: 0x0042E2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE7B RID: 118395 RVA: 0x004300F8 File Offset: 0x0042E2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VehicleId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.VehicleId);
			}
			if (this.IsGetOn)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsGetOn);
			}
			if (this.ExitType != ExitVehicleType.Launch)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SeatId);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.ClientPredicted);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE7C RID: 118396 RVA: 0x004301C4 File Offset: 0x0042E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.VehicleId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VehicleId);
			}
			if (this.SeatId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeatId);
			}
			if (this.IsGetOn)
			{
				num += 2;
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

		// Token: 0x0601CE7D RID: 118397 RVA: 0x00430264 File Offset: 0x0042E464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleUpdateEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.VehicleId != 0L)
			{
				this.VehicleId = other.VehicleId;
			}
			if (other.SeatId != 0)
			{
				this.SeatId = other.SeatId;
			}
			if (other.IsGetOn)
			{
				this.IsGetOn = other.IsGetOn;
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

		// Token: 0x0601CE7E RID: 118398 RVA: 0x00430304 File Offset: 0x0042E504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE7F RID: 118399 RVA: 0x00430310 File Offset: 0x0042E510
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
					if (num == 32U)
					{
						this.VehicleId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.IsGetOn = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.ExitType = (ExitVehicleType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ClientPredicted = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A62E RID: 42542
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A62F RID: 42543
		public const int EntityIdFieldNumber = 12;

		// Token: 0x0400A630 RID: 42544
		private long entityId_;

		// Token: 0x0400A631 RID: 42545
		public const int VehicleIdFieldNumber = 4;

		// Token: 0x0400A632 RID: 42546
		private long vehicleId_;

		// Token: 0x0400A633 RID: 42547
		public const int SeatIdFieldNumber = 10;

		// Token: 0x0400A634 RID: 42548
		private int seatId_;

		// Token: 0x0400A635 RID: 42549
		public const int IsGetOnFieldNumber = 5;

		// Token: 0x0400A636 RID: 42550
		private bool isGetOn_;

		// Token: 0x0400A637 RID: 42551
		public const int ExitTypeFieldNumber = 7;

		// Token: 0x0400A638 RID: 42552
		private ExitVehicleType exitType_;

		// Token: 0x0400A639 RID: 42553
		public const int ClientPredictedFieldNumber = 11;

		// Token: 0x0400A63A RID: 42554
		private bool clientPredicted_;
	}
}
