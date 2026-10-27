using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D7 RID: 5335
	[NetMessage(EMessageId.VehicleRequest)]
	public sealed class VehicleRequest : IMessage<VehicleRequest>, IMessage, IEquatable<VehicleRequest>, IDeepCloneable<VehicleRequest>, IBufferMessage
	{
		// Token: 0x0601C353 RID: 115539 RVA: 0x004137A5 File Offset: 0x004119A5
		[NullableContext(1)]
		public static VehicleRequest Create()
		{
			return new VehicleRequest();
		}

		// Token: 0x17005F14 RID: 24340
		// (get) Token: 0x0601C354 RID: 115540 RVA: 0x004137AC File Offset: 0x004119AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F15 RID: 24341
		// (get) Token: 0x0601C355 RID: 115541 RVA: 0x004137AF File Offset: 0x004119AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleRequest.Descriptor;
			}
		}

		// Token: 0x0601C356 RID: 115542 RVA: 0x004137B6 File Offset: 0x004119B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRequest()
		{
		}

		// Token: 0x0601C357 RID: 115543 RVA: 0x004137CC File Offset: 0x004119CC
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

		// Token: 0x0601C358 RID: 115544 RVA: 0x00413850 File Offset: 0x00411A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRequest Clone()
		{
			return new VehicleRequest(this);
		}

		// Token: 0x17005F16 RID: 24342
		// (get) Token: 0x0601C359 RID: 115545 RVA: 0x00413858 File Offset: 0x00411A58
		// (set) Token: 0x0601C35A RID: 115546 RVA: 0x00413860 File Offset: 0x00411A60
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

		// Token: 0x17005F17 RID: 24343
		// (get) Token: 0x0601C35B RID: 115547 RVA: 0x00413869 File Offset: 0x00411A69
		// (set) Token: 0x0601C35C RID: 115548 RVA: 0x00413871 File Offset: 0x00411A71
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

		// Token: 0x17005F18 RID: 24344
		// (get) Token: 0x0601C35D RID: 115549 RVA: 0x0041387A File Offset: 0x00411A7A
		// (set) Token: 0x0601C35E RID: 115550 RVA: 0x00413882 File Offset: 0x00411A82
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

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x0601C35F RID: 115551 RVA: 0x0041388B File Offset: 0x00411A8B
		// (set) Token: 0x0601C360 RID: 115552 RVA: 0x00413893 File Offset: 0x00411A93
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

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x0601C361 RID: 115553 RVA: 0x0041389C File Offset: 0x00411A9C
		// (set) Token: 0x0601C362 RID: 115554 RVA: 0x004138B4 File Offset: 0x00411AB4
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

		// Token: 0x17005F1B RID: 24347
		// (get) Token: 0x0601C363 RID: 115555 RVA: 0x004138CB File Offset: 0x00411ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasExitType
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601C364 RID: 115556 RVA: 0x004138D8 File Offset: 0x00411AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExitType()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17005F1C RID: 24348
		// (get) Token: 0x0601C365 RID: 115557 RVA: 0x004138E9 File Offset: 0x00411AE9
		// (set) Token: 0x0601C366 RID: 115558 RVA: 0x004138F1 File Offset: 0x00411AF1
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

		// Token: 0x17005F1D RID: 24349
		// (get) Token: 0x0601C367 RID: 115559 RVA: 0x004138FA File Offset: 0x00411AFA
		// (set) Token: 0x0601C368 RID: 115560 RVA: 0x00413902 File Offset: 0x00411B02
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

		// Token: 0x0601C369 RID: 115561 RVA: 0x00413915 File Offset: 0x00411B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleRequest);
		}

		// Token: 0x0601C36A RID: 115562 RVA: 0x00413924 File Offset: 0x00411B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HostPlayerId == other.HostPlayerId && this.IsGetOn == other.IsGetOn && this.SeatId == other.SeatId && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && !(this.ReasonMsg != other.ReasonMsg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C36B RID: 115563 RVA: 0x004139C4 File Offset: 0x00411BC4
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

		// Token: 0x0601C36C RID: 115564 RVA: 0x00413AA2 File Offset: 0x00411CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C36D RID: 115565 RVA: 0x00413AAF File Offset: 0x00411CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C36E RID: 115566 RVA: 0x00413AB8 File Offset: 0x00411CB8
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
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.IsGetOn)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsGetOn);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SeatId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.ClientPredicted);
			}
			if (this.ReasonMsg.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.ReasonMsg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C36F RID: 115567 RVA: 0x00413BA4 File Offset: 0x00411DA4
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

		// Token: 0x0601C370 RID: 115568 RVA: 0x00413C60 File Offset: 0x00411E60
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

		// Token: 0x0601C371 RID: 115569 RVA: 0x00413D19 File Offset: 0x00411F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C372 RID: 115570 RVA: 0x00413D24 File Offset: 0x00411F24
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
					if (num == 24U)
					{
						this.ExitType = (ExitVehicleType)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.IsGetOn = input.ReadBool();
						continue;
					}
				}
				else if (num <= 64U)
				{
					if (num == 56U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.HostPlayerId = input.ReadInt32();
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
					if (num == 98U)
					{
						this.ReasonMsg = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A1B8 RID: 41400
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1B9 RID: 41401
		private int _hasBits0;

		// Token: 0x0400A1BA RID: 41402
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400A1BB RID: 41403
		private long entityId_;

		// Token: 0x0400A1BC RID: 41404
		public const int HostPlayerIdFieldNumber = 8;

		// Token: 0x0400A1BD RID: 41405
		private int hostPlayerId_;

		// Token: 0x0400A1BE RID: 41406
		public const int IsGetOnFieldNumber = 5;

		// Token: 0x0400A1BF RID: 41407
		private bool isGetOn_;

		// Token: 0x0400A1C0 RID: 41408
		public const int SeatIdFieldNumber = 7;

		// Token: 0x0400A1C1 RID: 41409
		private int seatId_;

		// Token: 0x0400A1C2 RID: 41410
		public const int ExitTypeFieldNumber = 3;

		// Token: 0x0400A1C3 RID: 41411
		private static readonly ExitVehicleType ExitTypeDefaultValue;

		// Token: 0x0400A1C4 RID: 41412
		private ExitVehicleType exitType_;

		// Token: 0x0400A1C5 RID: 41413
		public const int ClientPredictedFieldNumber = 11;

		// Token: 0x0400A1C6 RID: 41414
		private bool clientPredicted_;

		// Token: 0x0400A1C7 RID: 41415
		public const int ReasonMsgFieldNumber = 12;

		// Token: 0x0400A1C8 RID: 41416
		private string reasonMsg_ = "";
	}
}
