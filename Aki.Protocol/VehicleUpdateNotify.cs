using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001551 RID: 5457
	[NetMessage(EMessageId.VehicleUpdateNotify)]
	public sealed class VehicleUpdateNotify : IMessage<VehicleUpdateNotify>, IMessage, IEquatable<VehicleUpdateNotify>, IDeepCloneable<VehicleUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601CE80 RID: 118400 RVA: 0x004303C1 File Offset: 0x0042E5C1
		[NullableContext(1)]
		public static VehicleUpdateNotify Create()
		{
			return new VehicleUpdateNotify();
		}

		// Token: 0x170061D0 RID: 25040
		// (get) Token: 0x0601CE81 RID: 118401 RVA: 0x004303C8 File Offset: 0x0042E5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061D1 RID: 25041
		// (get) Token: 0x0601CE82 RID: 118402 RVA: 0x004303CB File Offset: 0x0042E5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601CE83 RID: 118403 RVA: 0x004303D2 File Offset: 0x0042E5D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateNotify()
		{
		}

		// Token: 0x0601CE84 RID: 118404 RVA: 0x004303DC File Offset: 0x0042E5DC
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

		// Token: 0x0601CE85 RID: 118405 RVA: 0x0043043C File Offset: 0x0042E63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleUpdateNotify Clone()
		{
			return new VehicleUpdateNotify(this);
		}

		// Token: 0x170061D2 RID: 25042
		// (get) Token: 0x0601CE86 RID: 118406 RVA: 0x00430444 File Offset: 0x0042E644
		// (set) Token: 0x0601CE87 RID: 118407 RVA: 0x0043044C File Offset: 0x0042E64C
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

		// Token: 0x170061D3 RID: 25043
		// (get) Token: 0x0601CE88 RID: 118408 RVA: 0x00430455 File Offset: 0x0042E655
		// (set) Token: 0x0601CE89 RID: 118409 RVA: 0x0043045D File Offset: 0x0042E65D
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

		// Token: 0x170061D4 RID: 25044
		// (get) Token: 0x0601CE8A RID: 118410 RVA: 0x00430466 File Offset: 0x0042E666
		// (set) Token: 0x0601CE8B RID: 118411 RVA: 0x0043046E File Offset: 0x0042E66E
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

		// Token: 0x170061D5 RID: 25045
		// (get) Token: 0x0601CE8C RID: 118412 RVA: 0x00430477 File Offset: 0x0042E677
		// (set) Token: 0x0601CE8D RID: 118413 RVA: 0x0043047F File Offset: 0x0042E67F
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

		// Token: 0x170061D6 RID: 25046
		// (get) Token: 0x0601CE8E RID: 118414 RVA: 0x00430488 File Offset: 0x0042E688
		// (set) Token: 0x0601CE8F RID: 118415 RVA: 0x00430490 File Offset: 0x0042E690
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

		// Token: 0x0601CE90 RID: 118416 RVA: 0x00430499 File Offset: 0x0042E699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleUpdateNotify);
		}

		// Token: 0x0601CE91 RID: 118417 RVA: 0x004304A8 File Offset: 0x0042E6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && this.SeatId == other.SeatId && this.ExitType == other.ExitType && this.ClientPredicted == other.ClientPredicted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE92 RID: 118418 RVA: 0x00430524 File Offset: 0x0042E724
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

		// Token: 0x0601CE93 RID: 118419 RVA: 0x004305CE File Offset: 0x0042E7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE94 RID: 118420 RVA: 0x004305DB File Offset: 0x0042E7DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE95 RID: 118421 RVA: 0x004305E4 File Offset: 0x0042E7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExitType != ExitVehicleType.Launch)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ExitType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PlayerId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SeatId);
			}
			if (this.ClientPredicted)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.ClientPredicted);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE96 RID: 118422 RVA: 0x00430694 File Offset: 0x0042E894
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

		// Token: 0x0601CE97 RID: 118423 RVA: 0x00430728 File Offset: 0x0042E928
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

		// Token: 0x0601CE98 RID: 118424 RVA: 0x004307B4 File Offset: 0x0042E9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE99 RID: 118425 RVA: 0x004307C0 File Offset: 0x0042E9C0
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
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.ExitType = (ExitVehicleType)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ClientPredicted = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A63B RID: 42555
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A63C RID: 42556
		public const int PlayerIdFieldNumber = 10;

		// Token: 0x0400A63D RID: 42557
		private int playerId_;

		// Token: 0x0400A63E RID: 42558
		public const int EntityIdFieldNumber = 6;

		// Token: 0x0400A63F RID: 42559
		private long entityId_;

		// Token: 0x0400A640 RID: 42560
		public const int SeatIdFieldNumber = 12;

		// Token: 0x0400A641 RID: 42561
		private int seatId_;

		// Token: 0x0400A642 RID: 42562
		public const int ExitTypeFieldNumber = 3;

		// Token: 0x0400A643 RID: 42563
		private ExitVehicleType exitType_;

		// Token: 0x0400A644 RID: 42564
		public const int ClientPredictedFieldNumber = 15;

		// Token: 0x0400A645 RID: 42565
		private bool clientPredicted_;
	}
}
