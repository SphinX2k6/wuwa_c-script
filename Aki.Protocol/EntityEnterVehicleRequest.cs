using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000488 RID: 1160
	[NetMessage(EMessageId.EntityEnterVehicleRequest)]
	public sealed class EntityEnterVehicleRequest : IMessage<EntityEnterVehicleRequest>, IMessage, IEquatable<EntityEnterVehicleRequest>, IDeepCloneable<EntityEnterVehicleRequest>, IBufferMessage
	{
		// Token: 0x06006EFE RID: 28414 RVA: 0x001107E0 File Offset: 0x0010E9E0
		[NullableContext(1)]
		public static EntityEnterVehicleRequest Create()
		{
			return new EntityEnterVehicleRequest();
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x001107E7 File Offset: 0x0010E9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06006F00 RID: 28416 RVA: 0x001107EA File Offset: 0x0010E9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEnterVehicleRequest.Descriptor;
			}
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x001107F1 File Offset: 0x0010E9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleRequest()
		{
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x00110804 File Offset: 0x0010EA04
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

		// Token: 0x06006F03 RID: 28419 RVA: 0x00110894 File Offset: 0x0010EA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleRequest Clone()
		{
			return new EntityEnterVehicleRequest(this);
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06006F04 RID: 28420 RVA: 0x0011089C File Offset: 0x0010EA9C
		// (set) Token: 0x06006F05 RID: 28421 RVA: 0x001108A4 File Offset: 0x0010EAA4
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

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x001108AD File Offset: 0x0010EAAD
		// (set) Token: 0x06006F07 RID: 28423 RVA: 0x001108B5 File Offset: 0x0010EAB5
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

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x001108BE File Offset: 0x0010EABE
		// (set) Token: 0x06006F09 RID: 28425 RVA: 0x001108C6 File Offset: 0x0010EAC6
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

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x001108CF File Offset: 0x0010EACF
		// (set) Token: 0x06006F0B RID: 28427 RVA: 0x001108D7 File Offset: 0x0010EAD7
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

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06006F0C RID: 28428 RVA: 0x001108E0 File Offset: 0x0010EAE0
		// (set) Token: 0x06006F0D RID: 28429 RVA: 0x001108E8 File Offset: 0x0010EAE8
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

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x001108F1 File Offset: 0x0010EAF1
		// (set) Token: 0x06006F0F RID: 28431 RVA: 0x00110909 File Offset: 0x0010EB09
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

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x00110920 File Offset: 0x0010EB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExitType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x0011092D File Offset: 0x0010EB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExitType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06006F12 RID: 28434 RVA: 0x0011093E File Offset: 0x0010EB3E
		// (set) Token: 0x06006F13 RID: 28435 RVA: 0x00110946 File Offset: 0x0010EB46
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

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x0011094F File Offset: 0x0010EB4F
		// (set) Token: 0x06006F15 RID: 28437 RVA: 0x00110957 File Offset: 0x0010EB57
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

		// Token: 0x06006F16 RID: 28438 RVA: 0x0011096A File Offset: 0x0010EB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEnterVehicleRequest);
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x00110978 File Offset: 0x0010EB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEnterVehicleRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.VehicleId == other.VehicleId && this.HostPlayerId == other.HostPlayerId && this.IsGetOn == other.IsGetOn && this.SeatId == other.SeatId && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && !(this.ReasonMsg != other.ReasonMsg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F18 RID: 28440 RVA: 0x00110A28 File Offset: 0x0010EC28
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

		// Token: 0x06006F19 RID: 28441 RVA: 0x00110B1F File Offset: 0x0010ED1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x00110B2C File Offset: 0x0010ED2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x00110B38 File Offset: 0x0010ED38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ClientPredicted);
			}
			if (this.HasExitType)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.VehicleId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.VehicleId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SeatId);
			}
			if (this.IsGetOn)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsGetOn);
			}
			if (this.ReasonMsg.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.ReasonMsg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x00110C40 File Offset: 0x0010EE40
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

		// Token: 0x06006F1D RID: 28445 RVA: 0x00110D14 File Offset: 0x0010EF14
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

		// Token: 0x06006F1E RID: 28446 RVA: 0x00110DE1 File Offset: 0x0010EFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00110DEC File Offset: 0x0010EFEC
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
				if (num <= 72U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.HostPlayerId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ClientPredicted = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 40U)
						{
							this.ExitType = (ExitVehicleType)input.ReadEnum();
							continue;
						}
						if (num == 72U)
						{
							this.EntityId = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 80U)
					{
						this.VehicleId = input.ReadInt64();
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
					if (num == 112U)
					{
						this.IsGetOn = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						this.ReasonMsg = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003BC7 RID: 15303
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BC8 RID: 15304
		private int _hasBits0;

		// Token: 0x04003BC9 RID: 15305
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003BCA RID: 15306
		private long entityId_;

		// Token: 0x04003BCB RID: 15307
		public const int VehicleIdFieldNumber = 10;

		// Token: 0x04003BCC RID: 15308
		private long vehicleId_;

		// Token: 0x04003BCD RID: 15309
		public const int HostPlayerIdFieldNumber = 1;

		// Token: 0x04003BCE RID: 15310
		private int hostPlayerId_;

		// Token: 0x04003BCF RID: 15311
		public const int IsGetOnFieldNumber = 14;

		// Token: 0x04003BD0 RID: 15312
		private bool isGetOn_;

		// Token: 0x04003BD1 RID: 15313
		public const int SeatIdFieldNumber = 12;

		// Token: 0x04003BD2 RID: 15314
		private int seatId_;

		// Token: 0x04003BD3 RID: 15315
		public const int ExitTypeFieldNumber = 5;

		// Token: 0x04003BD4 RID: 15316
		private static readonly ExitVehicleType ExitTypeDefaultValue;

		// Token: 0x04003BD5 RID: 15317
		private ExitVehicleType exitType_;

		// Token: 0x04003BD6 RID: 15318
		public const int ClientPredictedFieldNumber = 2;

		// Token: 0x04003BD7 RID: 15319
		private bool clientPredicted_;

		// Token: 0x04003BD8 RID: 15320
		public const int ReasonMsgFieldNumber = 15;

		// Token: 0x04003BD9 RID: 15321
		private string reasonMsg_ = "";
	}
}
