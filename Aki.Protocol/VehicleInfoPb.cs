using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CF RID: 5327
	public sealed class VehicleInfoPb : IMessage<VehicleInfoPb>, IMessage, IEquatable<VehicleInfoPb>, IDeepCloneable<VehicleInfoPb>, IBufferMessage
	{
		// Token: 0x0601C2B7 RID: 115383 RVA: 0x00412481 File Offset: 0x00410681
		[NullableContext(1)]
		public static VehicleInfoPb Create()
		{
			return new VehicleInfoPb();
		}

		// Token: 0x17005EF6 RID: 24310
		// (get) Token: 0x0601C2B8 RID: 115384 RVA: 0x00412488 File Offset: 0x00410688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EF7 RID: 24311
		// (get) Token: 0x0601C2B9 RID: 115385 RVA: 0x0041248B File Offset: 0x0041068B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleInfoPb.Descriptor;
			}
		}

		// Token: 0x0601C2BA RID: 115386 RVA: 0x00412492 File Offset: 0x00410692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleInfoPb()
		{
		}

		// Token: 0x0601C2BB RID: 115387 RVA: 0x0041249A File Offset: 0x0041069A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleInfoPb(VehicleInfoPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this.seatId_ = other.seatId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2BC RID: 115388 RVA: 0x004124CB File Offset: 0x004106CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleInfoPb Clone()
		{
			return new VehicleInfoPb(this);
		}

		// Token: 0x17005EF8 RID: 24312
		// (get) Token: 0x0601C2BD RID: 115389 RVA: 0x004124D3 File Offset: 0x004106D3
		// (set) Token: 0x0601C2BE RID: 115390 RVA: 0x004124DB File Offset: 0x004106DB
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

		// Token: 0x17005EF9 RID: 24313
		// (get) Token: 0x0601C2BF RID: 115391 RVA: 0x004124E4 File Offset: 0x004106E4
		// (set) Token: 0x0601C2C0 RID: 115392 RVA: 0x004124EC File Offset: 0x004106EC
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

		// Token: 0x0601C2C1 RID: 115393 RVA: 0x004124F5 File Offset: 0x004106F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleInfoPb);
		}

		// Token: 0x0601C2C2 RID: 115394 RVA: 0x00412503 File Offset: 0x00410703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleInfoPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SeatId == other.SeatId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2C3 RID: 115395 RVA: 0x00412544 File Offset: 0x00410744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
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

		// Token: 0x0601C2C4 RID: 115396 RVA: 0x0041259C File Offset: 0x0041079C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2C5 RID: 115397 RVA: 0x004125A9 File Offset: 0x004107A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2C6 RID: 115398 RVA: 0x004125B4 File Offset: 0x004107B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
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

		// Token: 0x0601C2C7 RID: 115399 RVA: 0x0041260C File Offset: 0x0041080C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
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

		// Token: 0x0601C2C8 RID: 115400 RVA: 0x00412664 File Offset: 0x00410864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SeatId != 0)
			{
				this.SeatId = other.SeatId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C2C9 RID: 115401 RVA: 0x004126B4 File Offset: 0x004108B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2CA RID: 115402 RVA: 0x004126C0 File Offset: 0x004108C0
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A194 RID: 41364
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A195 RID: 41365
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400A196 RID: 41366
		private long entityId_;

		// Token: 0x0400A197 RID: 41367
		public const int SeatIdFieldNumber = 2;

		// Token: 0x0400A198 RID: 41368
		private int seatId_;
	}
}
