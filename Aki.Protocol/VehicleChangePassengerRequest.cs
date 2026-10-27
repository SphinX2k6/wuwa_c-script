using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C9 RID: 5321
	[NetMessage(EMessageId.VehicleChangePassengerRequest)]
	public sealed class VehicleChangePassengerRequest : IMessage<VehicleChangePassengerRequest>, IMessage, IEquatable<VehicleChangePassengerRequest>, IDeepCloneable<VehicleChangePassengerRequest>, IBufferMessage
	{
		// Token: 0x0601C247 RID: 115271 RVA: 0x004117D9 File Offset: 0x0040F9D9
		[NullableContext(1)]
		public static VehicleChangePassengerRequest Create()
		{
			return new VehicleChangePassengerRequest();
		}

		// Token: 0x17005EE2 RID: 24290
		// (get) Token: 0x0601C248 RID: 115272 RVA: 0x004117E0 File Offset: 0x0040F9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EE3 RID: 24291
		// (get) Token: 0x0601C249 RID: 115273 RVA: 0x004117E3 File Offset: 0x0040F9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleChangePassengerRequest.Descriptor;
			}
		}

		// Token: 0x0601C24A RID: 115274 RVA: 0x004117EA File Offset: 0x0040F9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerRequest()
		{
		}

		// Token: 0x0601C24B RID: 115275 RVA: 0x004117F2 File Offset: 0x0040F9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerRequest(VehicleChangePassengerRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.seatId_ = other.seatId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C24C RID: 115276 RVA: 0x00411823 File Offset: 0x0040FA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleChangePassengerRequest Clone()
		{
			return new VehicleChangePassengerRequest(this);
		}

		// Token: 0x17005EE4 RID: 24292
		// (get) Token: 0x0601C24D RID: 115277 RVA: 0x0041182B File Offset: 0x0040FA2B
		// (set) Token: 0x0601C24E RID: 115278 RVA: 0x00411833 File Offset: 0x0040FA33
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

		// Token: 0x17005EE5 RID: 24293
		// (get) Token: 0x0601C24F RID: 115279 RVA: 0x0041183C File Offset: 0x0040FA3C
		// (set) Token: 0x0601C250 RID: 115280 RVA: 0x00411844 File Offset: 0x0040FA44
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

		// Token: 0x0601C251 RID: 115281 RVA: 0x0041184D File Offset: 0x0040FA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleChangePassengerRequest);
		}

		// Token: 0x0601C252 RID: 115282 RVA: 0x0041185B File Offset: 0x0040FA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleChangePassengerRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SeatId == other.SeatId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C253 RID: 115283 RVA: 0x0041189C File Offset: 0x0040FA9C
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

		// Token: 0x0601C254 RID: 115284 RVA: 0x004118F4 File Offset: 0x0040FAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C255 RID: 115285 RVA: 0x00411901 File Offset: 0x0040FB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C256 RID: 115286 RVA: 0x0041190C File Offset: 0x0040FB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeatId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SeatId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C257 RID: 115287 RVA: 0x00411968 File Offset: 0x0040FB68
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

		// Token: 0x0601C258 RID: 115288 RVA: 0x004119C0 File Offset: 0x0040FBC0
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

		// Token: 0x0601C259 RID: 115289 RVA: 0x00411A10 File Offset: 0x0040FC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C25A RID: 115290 RVA: 0x00411A1C File Offset: 0x0040FC1C
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
				if (num != 24U)
				{
					if (num != 48U)
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

		// Token: 0x0400A17E RID: 41342
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A17F RID: 41343
		public const int RoleIdFieldNumber = 6;

		// Token: 0x0400A180 RID: 41344
		private int roleId_;

		// Token: 0x0400A181 RID: 41345
		public const int SeatIdFieldNumber = 3;

		// Token: 0x0400A182 RID: 41346
		private int seatId_;
	}
}
