using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D0 RID: 5328
	public sealed class VehiclePassengerComponentPb : IMessage<VehiclePassengerComponentPb>, IMessage, IEquatable<VehiclePassengerComponentPb>, IDeepCloneable<VehiclePassengerComponentPb>, IBufferMessage
	{
		// Token: 0x0601C2CB RID: 115403 RVA: 0x00412717 File Offset: 0x00410917
		[NullableContext(1)]
		public static VehiclePassengerComponentPb Create()
		{
			return new VehiclePassengerComponentPb();
		}

		// Token: 0x17005EFA RID: 24314
		// (get) Token: 0x0601C2CC RID: 115404 RVA: 0x0041271E File Offset: 0x0041091E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EFB RID: 24315
		// (get) Token: 0x0601C2CD RID: 115405 RVA: 0x00412721 File Offset: 0x00410921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePassengerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601C2CE RID: 115406 RVA: 0x00412728 File Offset: 0x00410928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerComponentPb()
		{
		}

		// Token: 0x0601C2CF RID: 115407 RVA: 0x00412730 File Offset: 0x00410930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerComponentPb(VehiclePassengerComponentPb other) : this()
		{
			this.vehicleId_ = other.vehicleId_;
			this.seatId_ = other.seatId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2D0 RID: 115408 RVA: 0x00412761 File Offset: 0x00410961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerComponentPb Clone()
		{
			return new VehiclePassengerComponentPb(this);
		}

		// Token: 0x17005EFC RID: 24316
		// (get) Token: 0x0601C2D1 RID: 115409 RVA: 0x00412769 File Offset: 0x00410969
		// (set) Token: 0x0601C2D2 RID: 115410 RVA: 0x00412771 File Offset: 0x00410971
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

		// Token: 0x17005EFD RID: 24317
		// (get) Token: 0x0601C2D3 RID: 115411 RVA: 0x0041277A File Offset: 0x0041097A
		// (set) Token: 0x0601C2D4 RID: 115412 RVA: 0x00412782 File Offset: 0x00410982
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

		// Token: 0x0601C2D5 RID: 115413 RVA: 0x0041278B File Offset: 0x0041098B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePassengerComponentPb);
		}

		// Token: 0x0601C2D6 RID: 115414 RVA: 0x00412799 File Offset: 0x00410999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePassengerComponentPb other)
		{
			return other != null && (other == this || (this.VehicleId == other.VehicleId && this.SeatId == other.SeatId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2D7 RID: 115415 RVA: 0x004127D8 File Offset: 0x004109D8
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

		// Token: 0x0601C2D8 RID: 115416 RVA: 0x00412830 File Offset: 0x00410A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2D9 RID: 115417 RVA: 0x0041283D File Offset: 0x00410A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2DA RID: 115418 RVA: 0x00412848 File Offset: 0x00410A48
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

		// Token: 0x0601C2DB RID: 115419 RVA: 0x004128A0 File Offset: 0x00410AA0
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

		// Token: 0x0601C2DC RID: 115420 RVA: 0x004128F8 File Offset: 0x00410AF8
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

		// Token: 0x0601C2DD RID: 115421 RVA: 0x00412948 File Offset: 0x00410B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2DE RID: 115422 RVA: 0x00412954 File Offset: 0x00410B54
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

		// Token: 0x0400A199 RID: 41369
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A19A RID: 41370
		public const int VehicleIdFieldNumber = 1;

		// Token: 0x0400A19B RID: 41371
		private long vehicleId_;

		// Token: 0x0400A19C RID: 41372
		public const int SeatIdFieldNumber = 2;

		// Token: 0x0400A19D RID: 41373
		private int seatId_;
	}
}
