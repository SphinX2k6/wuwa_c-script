using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001545 RID: 5445
	public sealed class VehicleInfoPb : IMessage<VehicleInfoPb>, IMessage, IEquatable<VehicleInfoPb>, IDeepCloneable<VehicleInfoPb>, IBufferMessage
	{
		// Token: 0x0601CD7E RID: 118142 RVA: 0x0042DF3D File Offset: 0x0042C13D
		[NullableContext(1)]
		public static VehicleInfoPb Create()
		{
			return new VehicleInfoPb();
		}

		// Token: 0x17006197 RID: 24983
		// (get) Token: 0x0601CD7F RID: 118143 RVA: 0x0042DF44 File Offset: 0x0042C144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006198 RID: 24984
		// (get) Token: 0x0601CD80 RID: 118144 RVA: 0x0042DF47 File Offset: 0x0042C147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleInfoPb.Descriptor;
			}
		}

		// Token: 0x0601CD81 RID: 118145 RVA: 0x0042DF4E File Offset: 0x0042C14E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleInfoPb()
		{
		}

		// Token: 0x0601CD82 RID: 118146 RVA: 0x0042DF56 File Offset: 0x0042C156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleInfoPb(VehicleInfoPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this.seatId_ = other.seatId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD83 RID: 118147 RVA: 0x0042DF87 File Offset: 0x0042C187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleInfoPb Clone()
		{
			return new VehicleInfoPb(this);
		}

		// Token: 0x17006199 RID: 24985
		// (get) Token: 0x0601CD84 RID: 118148 RVA: 0x0042DF8F File Offset: 0x0042C18F
		// (set) Token: 0x0601CD85 RID: 118149 RVA: 0x0042DF97 File Offset: 0x0042C197
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

		// Token: 0x1700619A RID: 24986
		// (get) Token: 0x0601CD86 RID: 118150 RVA: 0x0042DFA0 File Offset: 0x0042C1A0
		// (set) Token: 0x0601CD87 RID: 118151 RVA: 0x0042DFA8 File Offset: 0x0042C1A8
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

		// Token: 0x0601CD88 RID: 118152 RVA: 0x0042DFB1 File Offset: 0x0042C1B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleInfoPb);
		}

		// Token: 0x0601CD89 RID: 118153 RVA: 0x0042DFBF File Offset: 0x0042C1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleInfoPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SeatId == other.SeatId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD8A RID: 118154 RVA: 0x0042E000 File Offset: 0x0042C200
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

		// Token: 0x0601CD8B RID: 118155 RVA: 0x0042E058 File Offset: 0x0042C258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD8C RID: 118156 RVA: 0x0042E065 File Offset: 0x0042C265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD8D RID: 118157 RVA: 0x0042E070 File Offset: 0x0042C270
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

		// Token: 0x0601CD8E RID: 118158 RVA: 0x0042E0C8 File Offset: 0x0042C2C8
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

		// Token: 0x0601CD8F RID: 118159 RVA: 0x0042E120 File Offset: 0x0042C320
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

		// Token: 0x0601CD90 RID: 118160 RVA: 0x0042E170 File Offset: 0x0042C370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD91 RID: 118161 RVA: 0x0042E17C File Offset: 0x0042C37C
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

		// Token: 0x0400A5ED RID: 42477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5EE RID: 42478
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400A5EF RID: 42479
		private long entityId_;

		// Token: 0x0400A5F0 RID: 42480
		public const int SeatIdFieldNumber = 2;

		// Token: 0x0400A5F1 RID: 42481
		private int seatId_;
	}
}
