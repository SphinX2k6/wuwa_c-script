using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001546 RID: 5446
	public sealed class VehiclePassengerComponentPb : IMessage<VehiclePassengerComponentPb>, IMessage, IEquatable<VehiclePassengerComponentPb>, IDeepCloneable<VehiclePassengerComponentPb>, IBufferMessage
	{
		// Token: 0x0601CD92 RID: 118162 RVA: 0x0042E1D3 File Offset: 0x0042C3D3
		[NullableContext(1)]
		public static VehiclePassengerComponentPb Create()
		{
			return new VehiclePassengerComponentPb();
		}

		// Token: 0x1700619B RID: 24987
		// (get) Token: 0x0601CD93 RID: 118163 RVA: 0x0042E1DA File Offset: 0x0042C3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700619C RID: 24988
		// (get) Token: 0x0601CD94 RID: 118164 RVA: 0x0042E1DD File Offset: 0x0042C3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePassengerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601CD95 RID: 118165 RVA: 0x0042E1E4 File Offset: 0x0042C3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerComponentPb()
		{
		}

		// Token: 0x0601CD96 RID: 118166 RVA: 0x0042E1EC File Offset: 0x0042C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerComponentPb(VehiclePassengerComponentPb other) : this()
		{
			this.vehicleId_ = other.vehicleId_;
			this.seatId_ = other.seatId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD97 RID: 118167 RVA: 0x0042E21D File Offset: 0x0042C41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerComponentPb Clone()
		{
			return new VehiclePassengerComponentPb(this);
		}

		// Token: 0x1700619D RID: 24989
		// (get) Token: 0x0601CD98 RID: 118168 RVA: 0x0042E225 File Offset: 0x0042C425
		// (set) Token: 0x0601CD99 RID: 118169 RVA: 0x0042E22D File Offset: 0x0042C42D
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

		// Token: 0x1700619E RID: 24990
		// (get) Token: 0x0601CD9A RID: 118170 RVA: 0x0042E236 File Offset: 0x0042C436
		// (set) Token: 0x0601CD9B RID: 118171 RVA: 0x0042E23E File Offset: 0x0042C43E
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

		// Token: 0x0601CD9C RID: 118172 RVA: 0x0042E247 File Offset: 0x0042C447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePassengerComponentPb);
		}

		// Token: 0x0601CD9D RID: 118173 RVA: 0x0042E255 File Offset: 0x0042C455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePassengerComponentPb other)
		{
			return other != null && (other == this || (this.VehicleId == other.VehicleId && this.SeatId == other.SeatId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD9E RID: 118174 RVA: 0x0042E294 File Offset: 0x0042C494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VehicleId != 0L)
			{
				num ^= this.VehicleId.GetHashCode();
			}
			if (this.SeatId != 0)
			{
				num ^= this.SeatId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CD9F RID: 118175 RVA: 0x0042E2EC File Offset: 0x0042C4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CDA0 RID: 118176 RVA: 0x0042E2F9 File Offset: 0x0042C4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CDA1 RID: 118177 RVA: 0x0042E304 File Offset: 0x0042C504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VehicleId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.VehicleId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SeatId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CDA2 RID: 118178 RVA: 0x0042E35C File Offset: 0x0042C55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VehicleId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VehicleId);
			}
			if (this.SeatId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeatId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CDA3 RID: 118179 RVA: 0x0042E3B4 File Offset: 0x0042C5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehiclePassengerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VehicleId != 0L)
			{
				this.VehicleId = other.VehicleId;
			}
			if (other.SeatId != 0)
			{
				this.SeatId = other.SeatId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CDA4 RID: 118180 RVA: 0x0042E404 File Offset: 0x0042C604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CDA5 RID: 118181 RVA: 0x0042E410 File Offset: 0x0042C610
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SeatId = input.ReadInt32();
					}
				}
				else
				{
					this.VehicleId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A5F2 RID: 42482
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5F3 RID: 42483
		public const int VehicleIdFieldNumber = 1;

		// Token: 0x0400A5F4 RID: 42484
		private long vehicleId_;

		// Token: 0x0400A5F5 RID: 42485
		public const int SeatIdFieldNumber = 2;

		// Token: 0x0400A5F6 RID: 42486
		private int seatId_;
	}
}
