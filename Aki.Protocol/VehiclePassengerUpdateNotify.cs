using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D1 RID: 5329
	[NetMessage(EMessageId.VehiclePassengerUpdateNotify)]
	public sealed class VehiclePassengerUpdateNotify : IMessage<VehiclePassengerUpdateNotify>, IMessage, IEquatable<VehiclePassengerUpdateNotify>, IDeepCloneable<VehiclePassengerUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C2DF RID: 115423 RVA: 0x004129AB File Offset: 0x00410BAB
		[NullableContext(1)]
		public static VehiclePassengerUpdateNotify Create()
		{
			return new VehiclePassengerUpdateNotify();
		}

		// Token: 0x17005EFE RID: 24318
		// (get) Token: 0x0601C2E0 RID: 115424 RVA: 0x004129B2 File Offset: 0x00410BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EFF RID: 24319
		// (get) Token: 0x0601C2E1 RID: 115425 RVA: 0x004129B5 File Offset: 0x00410BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePassengerUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C2E2 RID: 115426 RVA: 0x004129BC File Offset: 0x00410BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerUpdateNotify()
		{
		}

		// Token: 0x0601C2E3 RID: 115427 RVA: 0x004129C4 File Offset: 0x00410BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerUpdateNotify(VehiclePassengerUpdateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleId_ = other.roleId_;
			this.seatId_ = other.seatId_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2E4 RID: 115428 RVA: 0x00412A18 File Offset: 0x00410C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerUpdateNotify Clone()
		{
			return new VehiclePassengerUpdateNotify(this);
		}

		// Token: 0x17005F00 RID: 24320
		// (get) Token: 0x0601C2E5 RID: 115429 RVA: 0x00412A20 File Offset: 0x00410C20
		// (set) Token: 0x0601C2E6 RID: 115430 RVA: 0x00412A28 File Offset: 0x00410C28
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

		// Token: 0x17005F01 RID: 24321
		// (get) Token: 0x0601C2E7 RID: 115431 RVA: 0x00412A31 File Offset: 0x00410C31
		// (set) Token: 0x0601C2E8 RID: 115432 RVA: 0x00412A39 File Offset: 0x00410C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17005F02 RID: 24322
		// (get) Token: 0x0601C2E9 RID: 115433 RVA: 0x00412A42 File Offset: 0x00410C42
		// (set) Token: 0x0601C2EA RID: 115434 RVA: 0x00412A4A File Offset: 0x00410C4A
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

		// Token: 0x17005F03 RID: 24323
		// (get) Token: 0x0601C2EB RID: 115435 RVA: 0x00412A53 File Offset: 0x00410C53
		// (set) Token: 0x0601C2EC RID: 115436 RVA: 0x00412A5B File Offset: 0x00410C5B
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

		// Token: 0x0601C2ED RID: 115437 RVA: 0x00412A64 File Offset: 0x00410C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePassengerUpdateNotify);
		}

		// Token: 0x0601C2EE RID: 115438 RVA: 0x00412A74 File Offset: 0x00410C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePassengerUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RoleId == other.RoleId && this.SeatId == other.SeatId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2EF RID: 115439 RVA: 0x00412AE0 File Offset: 0x00410CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SeatId != 0)
			{
				num ^= this.SeatId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C2F0 RID: 115440 RVA: 0x00412B6A File Offset: 0x00410D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2F1 RID: 115441 RVA: 0x00412B77 File Offset: 0x00410D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2F2 RID: 115442 RVA: 0x00412B80 File Offset: 0x00410D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EntityId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SeatId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C2F3 RID: 115443 RVA: 0x00412C14 File Offset: 0x00410E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SeatId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeatId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C2F4 RID: 115444 RVA: 0x00412C9C File Offset: 0x00410E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehiclePassengerUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SeatId != 0)
			{
				this.SeatId = other.SeatId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C2F5 RID: 115445 RVA: 0x00412D14 File Offset: 0x00410F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2F6 RID: 115446 RVA: 0x00412D20 File Offset: 0x00410F20
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A19E RID: 41374
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A19F RID: 41375
		public const int PlayerIdFieldNumber = 13;

		// Token: 0x0400A1A0 RID: 41376
		private int playerId_;

		// Token: 0x0400A1A1 RID: 41377
		public const int RoleIdFieldNumber = 6;

		// Token: 0x0400A1A2 RID: 41378
		private int roleId_;

		// Token: 0x0400A1A3 RID: 41379
		public const int SeatIdFieldNumber = 4;

		// Token: 0x0400A1A4 RID: 41380
		private int seatId_;

		// Token: 0x0400A1A5 RID: 41381
		public const int EntityIdFieldNumber = 3;

		// Token: 0x0400A1A6 RID: 41382
		private long entityId_;
	}
}
