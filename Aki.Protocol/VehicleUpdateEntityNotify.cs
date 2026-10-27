using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014DA RID: 5338
	[NetMessage(EMessageId.VehicleUpdateEntityNotify)]
	public sealed class VehicleUpdateEntityNotify : IMessage<VehicleUpdateEntityNotify>, IMessage, IEquatable<VehicleUpdateEntityNotify>, IDeepCloneable<VehicleUpdateEntityNotify>, IBufferMessage
	{
		// Token: 0x0601C39D RID: 115613 RVA: 0x004143D1 File Offset: 0x004125D1
		[NullableContext(1)]
		public static VehicleUpdateEntityNotify Create()
		{
			return new VehicleUpdateEntityNotify();
		}

		// Token: 0x17005F27 RID: 24359
		// (get) Token: 0x0601C39E RID: 115614 RVA: 0x004143D8 File Offset: 0x004125D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F28 RID: 24360
		// (get) Token: 0x0601C39F RID: 115615 RVA: 0x004143DB File Offset: 0x004125DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleUpdateEntityNotify.Descriptor;
			}
		}

		// Token: 0x0601C3A0 RID: 115616 RVA: 0x004143E2 File Offset: 0x004125E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateEntityNotify()
		{
		}

		// Token: 0x0601C3A1 RID: 115617 RVA: 0x004143EC File Offset: 0x004125EC
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

		// Token: 0x0601C3A2 RID: 115618 RVA: 0x00414458 File Offset: 0x00412658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateEntityNotify Clone()
		{
			return new VehicleUpdateEntityNotify(this);
		}

		// Token: 0x17005F29 RID: 24361
		// (get) Token: 0x0601C3A3 RID: 115619 RVA: 0x00414460 File Offset: 0x00412660
		// (set) Token: 0x0601C3A4 RID: 115620 RVA: 0x00414468 File Offset: 0x00412668
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

		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x0601C3A5 RID: 115621 RVA: 0x00414471 File Offset: 0x00412671
		// (set) Token: 0x0601C3A6 RID: 115622 RVA: 0x00414479 File Offset: 0x00412679
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

		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x0601C3A7 RID: 115623 RVA: 0x00414482 File Offset: 0x00412682
		// (set) Token: 0x0601C3A8 RID: 115624 RVA: 0x0041448A File Offset: 0x0041268A
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

		// Token: 0x17005F2C RID: 24364
		// (get) Token: 0x0601C3A9 RID: 115625 RVA: 0x00414493 File Offset: 0x00412693
		// (set) Token: 0x0601C3AA RID: 115626 RVA: 0x0041449B File Offset: 0x0041269B
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

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x0601C3AB RID: 115627 RVA: 0x004144A4 File Offset: 0x004126A4
		// (set) Token: 0x0601C3AC RID: 115628 RVA: 0x004144AC File Offset: 0x004126AC
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

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x0601C3AD RID: 115629 RVA: 0x004144B5 File Offset: 0x004126B5
		// (set) Token: 0x0601C3AE RID: 115630 RVA: 0x004144BD File Offset: 0x004126BD
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

		// Token: 0x0601C3AF RID: 115631 RVA: 0x004144C6 File Offset: 0x004126C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleUpdateEntityNotify);
		}

		// Token: 0x0601C3B0 RID: 115632 RVA: 0x004144D4 File Offset: 0x004126D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleUpdateEntityNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.VehicleId == other.VehicleId && this.SeatId == other.SeatId && this.IsGetOn == other.IsGetOn && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3B1 RID: 115633 RVA: 0x00414560 File Offset: 0x00412760
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

		// Token: 0x0601C3B2 RID: 115634 RVA: 0x00414623 File Offset: 0x00412823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3B3 RID: 115635 RVA: 0x00414630 File Offset: 0x00412830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3B4 RID: 115636 RVA: 0x0041463C File Offset: 0x0041283C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeatId);
			}
			if (this.ExitType != ExitVehicleType.Launch)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.ClientPredicted);
			}
			if (this.VehicleId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.VehicleId);
			}
			if (this.IsGetOn)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsGetOn);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3B5 RID: 115637 RVA: 0x00414708 File Offset: 0x00412908
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

		// Token: 0x0601C3B6 RID: 115638 RVA: 0x004147A8 File Offset: 0x004129A8
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

		// Token: 0x0601C3B7 RID: 115639 RVA: 0x00414848 File Offset: 0x00412A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3B8 RID: 115640 RVA: 0x00414854 File Offset: 0x00412A54
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
				if (num <= 80U)
				{
					if (num == 16U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.ExitType = (ExitVehicleType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ClientPredicted = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.VehicleId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.IsGetOn = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A1D5 RID: 41429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1D6 RID: 41430
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400A1D7 RID: 41431
		private long entityId_;

		// Token: 0x0400A1D8 RID: 41432
		public const int VehicleIdFieldNumber = 13;

		// Token: 0x0400A1D9 RID: 41433
		private long vehicleId_;

		// Token: 0x0400A1DA RID: 41434
		public const int SeatIdFieldNumber = 3;

		// Token: 0x0400A1DB RID: 41435
		private int seatId_;

		// Token: 0x0400A1DC RID: 41436
		public const int IsGetOnFieldNumber = 14;

		// Token: 0x0400A1DD RID: 41437
		private bool isGetOn_;

		// Token: 0x0400A1DE RID: 41438
		public const int ExitTypeFieldNumber = 10;

		// Token: 0x0400A1DF RID: 41439
		private ExitVehicleType exitType_;

		// Token: 0x0400A1E0 RID: 41440
		public const int ClientPredictedFieldNumber = 11;

		// Token: 0x0400A1E1 RID: 41441
		private bool clientPredicted_;
	}
}
