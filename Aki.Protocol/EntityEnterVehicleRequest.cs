using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000471 RID: 1137
	[NetMessage(EMessageId.EntityEnterVehicleRequest)]
	public sealed class EntityEnterVehicleRequest : IMessage<EntityEnterVehicleRequest>, IMessage, IEquatable<EntityEnterVehicleRequest>, IDeepCloneable<EntityEnterVehicleRequest>, IBufferMessage
	{
		// Token: 0x06006D70 RID: 28016 RVA: 0x0010D76C File Offset: 0x0010B96C
		[NullableContext(1)]
		public static EntityEnterVehicleRequest Create()
		{
			return new EntityEnterVehicleRequest();
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x0010D773 File Offset: 0x0010B973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06006D72 RID: 28018 RVA: 0x0010D776 File Offset: 0x0010B976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEnterVehicleRequest.Descriptor;
			}
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x0010D77D File Offset: 0x0010B97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleRequest()
		{
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x0010D790 File Offset: 0x0010B990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleRequest(EntityEnterVehicleRequest other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = other.entityId_;
			this.vehicleId_ = other.vehicleId_;
			this.hostPlayerId_ = other.hostPlayerId_;
			this.isGetOn_ = other.isGetOn_;
			this.seatId_ = other.seatId_;
			this.exitType_ = other.exitType_;
			this.clientPredicted_ = other.clientPredicted_;
			this.reasonMsg_ = other.reasonMsg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x0010D820 File Offset: 0x0010BA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleRequest Clone()
		{
			return new EntityEnterVehicleRequest(this);
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06006D76 RID: 28022 RVA: 0x0010D828 File Offset: 0x0010BA28
		// (set) Token: 0x06006D77 RID: 28023 RVA: 0x0010D830 File Offset: 0x0010BA30
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

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06006D78 RID: 28024 RVA: 0x0010D839 File Offset: 0x0010BA39
		// (set) Token: 0x06006D79 RID: 28025 RVA: 0x0010D841 File Offset: 0x0010BA41
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

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06006D7A RID: 28026 RVA: 0x0010D84A File Offset: 0x0010BA4A
		// (set) Token: 0x06006D7B RID: 28027 RVA: 0x0010D852 File Offset: 0x0010BA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06006D7C RID: 28028 RVA: 0x0010D85B File Offset: 0x0010BA5B
		// (set) Token: 0x06006D7D RID: 28029 RVA: 0x0010D863 File Offset: 0x0010BA63
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

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06006D7E RID: 28030 RVA: 0x0010D86C File Offset: 0x0010BA6C
		// (set) Token: 0x06006D7F RID: 28031 RVA: 0x0010D874 File Offset: 0x0010BA74
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

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06006D80 RID: 28032 RVA: 0x0010D87D File Offset: 0x0010BA7D
		// (set) Token: 0x06006D81 RID: 28033 RVA: 0x0010D895 File Offset: 0x0010BA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitVehicleType ExitType
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.exitType_;
				}
				return EntityEnterVehicleRequest.ExitTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.exitType_ = value;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06006D82 RID: 28034 RVA: 0x0010D8AC File Offset: 0x0010BAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExitType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x0010D8B9 File Offset: 0x0010BAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExitType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x06006D84 RID: 28036 RVA: 0x0010D8CA File Offset: 0x0010BACA
		// (set) Token: 0x06006D85 RID: 28037 RVA: 0x0010D8D2 File Offset: 0x0010BAD2
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

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06006D86 RID: 28038 RVA: 0x0010D8DB File Offset: 0x0010BADB
		// (set) Token: 0x06006D87 RID: 28039 RVA: 0x0010D8E3 File Offset: 0x0010BAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReasonMsg
		{
			get
			{
				return this.reasonMsg_;
			}
			set
			{
				this.reasonMsg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x0010D8F6 File Offset: 0x0010BAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEnterVehicleRequest);
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x0010D904 File Offset: 0x0010BB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEnterVehicleRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.VehicleId == other.VehicleId && this.HostPlayerId == other.HostPlayerId && this.IsGetOn == other.IsGetOn && this.SeatId == other.SeatId && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && !(this.ReasonMsg != other.ReasonMsg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x0010D9B4 File Offset: 0x0010BBB4
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
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.IsGetOn)
			{
				num ^= this.IsGetOn.GetHashCode();
			}
			if (this.SeatId != 0)
			{
				num ^= this.SeatId.GetHashCode();
			}
			if (this.HasExitType)
			{
				num ^= this.ExitType.GetHashCode();
			}
			if (this.ClientPredicted)
			{
				num ^= this.ClientPredicted.GetHashCode();
			}
			if (this.ReasonMsg.Length != 0)
			{
				num ^= this.ReasonMsg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x0010DAAB File Offset: 0x0010BCAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x0010DAB8 File Offset: 0x0010BCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x0010DAC4 File Offset: 0x0010BCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsGetOn)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsGetOn);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ClientPredicted);
			}
			if (this.HasExitType)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.EntityId);
			}
			if (this.ReasonMsg.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.ReasonMsg);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SeatId);
			}
			if (this.VehicleId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.VehicleId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x0010DBCC File Offset: 0x0010BDCC
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
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.IsGetOn)
			{
				num += 2;
			}
			if (this.SeatId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeatId);
			}
			if (this.HasExitType)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExitType);
			}
			if (this.ClientPredicted)
			{
				num += 2;
			}
			if (this.ReasonMsg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReasonMsg);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x0010DCA0 File Offset: 0x0010BEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityEnterVehicleRequest other)
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
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.IsGetOn)
			{
				this.IsGetOn = other.IsGetOn;
			}
			if (other.SeatId != 0)
			{
				this.SeatId = other.SeatId;
			}
			if (other.HasExitType)
			{
				this.ExitType = other.ExitType;
			}
			if (other.ClientPredicted)
			{
				this.ClientPredicted = other.ClientPredicted;
			}
			if (other.ReasonMsg.Length != 0)
			{
				this.ReasonMsg = other.ReasonMsg;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x0010DD6D File Offset: 0x0010BF6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x0010DD78 File Offset: 0x0010BF78
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
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.IsGetOn = input.ReadBool();
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
						if (num == 32U)
						{
							this.ExitType = (ExitVehicleType)input.ReadEnum();
							continue;
						}
						if (num == 80U)
						{
							this.EntityId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 90U)
					{
						this.ReasonMsg = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.VehicleId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003BB5 RID: 15285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BB6 RID: 15286
		private int _hasBits0;

		// Token: 0x04003BB7 RID: 15287
		public const int EntityIdFieldNumber = 10;

		// Token: 0x04003BB8 RID: 15288
		private long entityId_;

		// Token: 0x04003BB9 RID: 15289
		public const int VehicleIdFieldNumber = 13;

		// Token: 0x04003BBA RID: 15290
		private long vehicleId_;

		// Token: 0x04003BBB RID: 15291
		public const int HostPlayerIdFieldNumber = 14;

		// Token: 0x04003BBC RID: 15292
		private int hostPlayerId_;

		// Token: 0x04003BBD RID: 15293
		public const int IsGetOnFieldNumber = 2;

		// Token: 0x04003BBE RID: 15294
		private bool isGetOn_;

		// Token: 0x04003BBF RID: 15295
		public const int SeatIdFieldNumber = 12;

		// Token: 0x04003BC0 RID: 15296
		private int seatId_;

		// Token: 0x04003BC1 RID: 15297
		public const int ExitTypeFieldNumber = 4;

		// Token: 0x04003BC2 RID: 15298
		private static readonly ExitVehicleType ExitTypeDefaultValue;

		// Token: 0x04003BC3 RID: 15299
		private ExitVehicleType exitType_;

		// Token: 0x04003BC4 RID: 15300
		public const int ClientPredictedFieldNumber = 3;

		// Token: 0x04003BC5 RID: 15301
		private bool clientPredicted_;

		// Token: 0x04003BC6 RID: 15302
		public const int ReasonMsgFieldNumber = 11;

		// Token: 0x04003BC7 RID: 15303
		private string reasonMsg_ = "";
	}
}
