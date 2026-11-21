using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153F RID: 5439
	[NetMessage(EMessageId.VehicleChangePassengerRequest)]
	public sealed class VehicleChangePassengerRequest : IMessage<VehicleChangePassengerRequest>, IMessage, IEquatable<VehicleChangePassengerRequest>, IDeepCloneable<VehicleChangePassengerRequest>, IBufferMessage
	{
		// Token: 0x0601CD0E RID: 118030 RVA: 0x0042D295 File Offset: 0x0042B495
		[NullableContext(1)]
		public static VehicleChangePassengerRequest Create()
		{
			return new VehicleChangePassengerRequest();
		}

		// Token: 0x17006183 RID: 24963
		// (get) Token: 0x0601CD0F RID: 118031 RVA: 0x0042D29C File Offset: 0x0042B49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006184 RID: 24964
		// (get) Token: 0x0601CD10 RID: 118032 RVA: 0x0042D29F File Offset: 0x0042B49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleChangePassengerRequest.Descriptor;
			}
		}

		// Token: 0x0601CD11 RID: 118033 RVA: 0x0042D2A6 File Offset: 0x0042B4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerRequest()
		{
		}

		// Token: 0x0601CD12 RID: 118034 RVA: 0x0042D2AE File Offset: 0x0042B4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerRequest(VehicleChangePassengerRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.seatId_ = other.seatId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD13 RID: 118035 RVA: 0x0042D2DF File Offset: 0x0042B4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerRequest Clone()
		{
			return new VehicleChangePassengerRequest(this);
		}

		// Token: 0x17006185 RID: 24965
		// (get) Token: 0x0601CD14 RID: 118036 RVA: 0x0042D2E7 File Offset: 0x0042B4E7
		// (set) Token: 0x0601CD15 RID: 118037 RVA: 0x0042D2EF File Offset: 0x0042B4EF
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

		// Token: 0x17006186 RID: 24966
		// (get) Token: 0x0601CD16 RID: 118038 RVA: 0x0042D2F8 File Offset: 0x0042B4F8
		// (set) Token: 0x0601CD17 RID: 118039 RVA: 0x0042D300 File Offset: 0x0042B500
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

		// Token: 0x0601CD18 RID: 118040 RVA: 0x0042D309 File Offset: 0x0042B509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleChangePassengerRequest);
		}

		// Token: 0x0601CD19 RID: 118041 RVA: 0x0042D317 File Offset: 0x0042B517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleChangePassengerRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SeatId == other.SeatId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD1A RID: 118042 RVA: 0x0042D358 File Offset: 0x0042B558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
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

		// Token: 0x0601CD1B RID: 118043 RVA: 0x0042D3B0 File Offset: 0x0042B5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD1C RID: 118044 RVA: 0x0042D3BD File Offset: 0x0042B5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD1D RID: 118045 RVA: 0x0042D3C8 File Offset: 0x0042B5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeatId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SeatId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD1E RID: 118046 RVA: 0x0042D424 File Offset: 0x0042B624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
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

		// Token: 0x0601CD1F RID: 118047 RVA: 0x0042D47C File Offset: 0x0042B67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleChangePassengerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SeatId != 0)
			{
				this.SeatId = other.SeatId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CD20 RID: 118048 RVA: 0x0042D4CC File Offset: 0x0042B6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD21 RID: 118049 RVA: 0x0042D4D8 File Offset: 0x0042B6D8
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
				if (num != 56U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.SeatId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A5D7 RID: 42455
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5D8 RID: 42456
		public const int RoleIdFieldNumber = 12;

		// Token: 0x0400A5D9 RID: 42457
		private int roleId_;

		// Token: 0x0400A5DA RID: 42458
		public const int SeatIdFieldNumber = 7;

		// Token: 0x0400A5DB RID: 42459
		private int seatId_;
	}
}
