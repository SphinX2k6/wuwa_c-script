using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154D RID: 5453
	[NetMessage(EMessageId.VehicleRequest)]
	public sealed class VehicleRequest : IMessage<VehicleRequest>, IMessage, IEquatable<VehicleRequest>, IDeepCloneable<VehicleRequest>, IBufferMessage
	{
		// Token: 0x0601CE1A RID: 118298 RVA: 0x0042F261 File Offset: 0x0042D461
		[NullableContext(1)]
		public static VehicleRequest Create()
		{
			return new VehicleRequest();
		}

		// Token: 0x170061B5 RID: 25013
		// (get) Token: 0x0601CE1B RID: 118299 RVA: 0x0042F268 File Offset: 0x0042D468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061B6 RID: 25014
		// (get) Token: 0x0601CE1C RID: 118300 RVA: 0x0042F26B File Offset: 0x0042D46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleRequest.Descriptor;
			}
		}

		// Token: 0x0601CE1D RID: 118301 RVA: 0x0042F272 File Offset: 0x0042D472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRequest()
		{
		}

		// Token: 0x0601CE1E RID: 118302 RVA: 0x0042F288 File Offset: 0x0042D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRequest(VehicleRequest other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.entityId_ = other.entityId_;
			this.hostPlayerId_ = other.hostPlayerId_;
			this.isGetOn_ = other.isGetOn_;
			this.seatId_ = other.seatId_;
			this.exitType_ = other.exitType_;
			this.clientPredicted_ = other.clientPredicted_;
			this.reasonMsg_ = other.reasonMsg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CE1F RID: 118303 RVA: 0x0042F30C File Offset: 0x0042D50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRequest Clone()
		{
			return new VehicleRequest(this);
		}

		// Token: 0x170061B7 RID: 25015
		// (get) Token: 0x0601CE20 RID: 118304 RVA: 0x0042F314 File Offset: 0x0042D514
		// (set) Token: 0x0601CE21 RID: 118305 RVA: 0x0042F31C File Offset: 0x0042D51C
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

		// Token: 0x170061B8 RID: 25016
		// (get) Token: 0x0601CE22 RID: 118306 RVA: 0x0042F325 File Offset: 0x0042D525
		// (set) Token: 0x0601CE23 RID: 118307 RVA: 0x0042F32D File Offset: 0x0042D52D
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

		// Token: 0x170061B9 RID: 25017
		// (get) Token: 0x0601CE24 RID: 118308 RVA: 0x0042F336 File Offset: 0x0042D536
		// (set) Token: 0x0601CE25 RID: 118309 RVA: 0x0042F33E File Offset: 0x0042D53E
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

		// Token: 0x170061BA RID: 25018
		// (get) Token: 0x0601CE26 RID: 118310 RVA: 0x0042F347 File Offset: 0x0042D547
		// (set) Token: 0x0601CE27 RID: 118311 RVA: 0x0042F34F File Offset: 0x0042D54F
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

		// Token: 0x170061BB RID: 25019
		// (get) Token: 0x0601CE28 RID: 118312 RVA: 0x0042F358 File Offset: 0x0042D558
		// (set) Token: 0x0601CE29 RID: 118313 RVA: 0x0042F370 File Offset: 0x0042D570
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
				return VehicleRequest.ExitTypeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.exitType_ = value;
			}
		}

		// Token: 0x170061BC RID: 25020
		// (get) Token: 0x0601CE2A RID: 118314 RVA: 0x0042F387 File Offset: 0x0042D587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExitType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601CE2B RID: 118315 RVA: 0x0042F394 File Offset: 0x0042D594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExitType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170061BD RID: 25021
		// (get) Token: 0x0601CE2C RID: 118316 RVA: 0x0042F3A5 File Offset: 0x0042D5A5
		// (set) Token: 0x0601CE2D RID: 118317 RVA: 0x0042F3AD File Offset: 0x0042D5AD
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

		// Token: 0x170061BE RID: 25022
		// (get) Token: 0x0601CE2E RID: 118318 RVA: 0x0042F3B6 File Offset: 0x0042D5B6
		// (set) Token: 0x0601CE2F RID: 118319 RVA: 0x0042F3BE File Offset: 0x0042D5BE
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

		// Token: 0x0601CE30 RID: 118320 RVA: 0x0042F3D1 File Offset: 0x0042D5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleRequest);
		}

		// Token: 0x0601CE31 RID: 118321 RVA: 0x0042F3E0 File Offset: 0x0042D5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HostPlayerId == other.HostPlayerId && this.IsGetOn == other.IsGetOn && this.SeatId == other.SeatId && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && !(this.ReasonMsg != other.ReasonMsg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE32 RID: 118322 RVA: 0x0042F480 File Offset: 0x0042D680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
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

		// Token: 0x0601CE33 RID: 118323 RVA: 0x0042F55E File Offset: 0x0042D75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE34 RID: 118324 RVA: 0x0042F56B File Offset: 0x0042D76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE35 RID: 118325 RVA: 0x0042F574 File Offset: 0x0042D774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.HasExitType)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.ClientPredicted);
			}
			if (this.IsGetOn)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsGetOn);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SeatId);
			}
			if (this.ReasonMsg.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ReasonMsg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE36 RID: 118326 RVA: 0x0042F660 File Offset: 0x0042D860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
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

		// Token: 0x0601CE37 RID: 118327 RVA: 0x0042F71C File Offset: 0x0042D91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
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

		// Token: 0x0601CE38 RID: 118328 RVA: 0x0042F7D5 File Offset: 0x0042D9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE39 RID: 118329 RVA: 0x0042F7E0 File Offset: 0x0042D9E0
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.ExitType = (ExitVehicleType)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.ClientPredicted = input.ReadBool();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.IsGetOn = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.HostPlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.ReasonMsg = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A611 RID: 42513
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A612 RID: 42514
		private int _hasBits0;

		// Token: 0x0400A613 RID: 42515
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400A614 RID: 42516
		private long entityId_;

		// Token: 0x0400A615 RID: 42517
		public const int HostPlayerIdFieldNumber = 9;

		// Token: 0x0400A616 RID: 42518
		private int hostPlayerId_;

		// Token: 0x0400A617 RID: 42519
		public const int IsGetOnFieldNumber = 8;

		// Token: 0x0400A618 RID: 42520
		private bool isGetOn_;

		// Token: 0x0400A619 RID: 42521
		public const int SeatIdFieldNumber = 11;

		// Token: 0x0400A61A RID: 42522
		private int seatId_;

		// Token: 0x0400A61B RID: 42523
		public const int ExitTypeFieldNumber = 4;

		// Token: 0x0400A61C RID: 42524
		private static readonly ExitVehicleType ExitTypeDefaultValue;

		// Token: 0x0400A61D RID: 42525
		private ExitVehicleType exitType_;

		// Token: 0x0400A61E RID: 42526
		public const int ClientPredictedFieldNumber = 5;

		// Token: 0x0400A61F RID: 42527
		private bool clientPredicted_;

		// Token: 0x0400A620 RID: 42528
		public const int ReasonMsgFieldNumber = 14;

		// Token: 0x0400A621 RID: 42529
		private string reasonMsg_ = "";
	}
}
