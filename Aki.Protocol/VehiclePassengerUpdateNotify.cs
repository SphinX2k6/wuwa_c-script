using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001547 RID: 5447
	[NetMessage(EMessageId.VehiclePassengerUpdateNotify)]
	public sealed class VehiclePassengerUpdateNotify : IMessage<VehiclePassengerUpdateNotify>, IMessage, IEquatable<VehiclePassengerUpdateNotify>, IDeepCloneable<VehiclePassengerUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601CDA6 RID: 118182 RVA: 0x0042E467 File Offset: 0x0042C667
		[NullableContext(1)]
		public static VehiclePassengerUpdateNotify Create()
		{
			return new VehiclePassengerUpdateNotify();
		}

		// Token: 0x1700619F RID: 24991
		// (get) Token: 0x0601CDA7 RID: 118183 RVA: 0x0042E46E File Offset: 0x0042C66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061A0 RID: 24992
		// (get) Token: 0x0601CDA8 RID: 118184 RVA: 0x0042E471 File Offset: 0x0042C671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePassengerUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601CDA9 RID: 118185 RVA: 0x0042E478 File Offset: 0x0042C678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerUpdateNotify()
		{
		}

		// Token: 0x0601CDAA RID: 118186 RVA: 0x0042E480 File Offset: 0x0042C680
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

		// Token: 0x0601CDAB RID: 118187 RVA: 0x0042E4D4 File Offset: 0x0042C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePassengerUpdateNotify Clone()
		{
			return new VehiclePassengerUpdateNotify(this);
		}

		// Token: 0x170061A1 RID: 24993
		// (get) Token: 0x0601CDAC RID: 118188 RVA: 0x0042E4DC File Offset: 0x0042C6DC
		// (set) Token: 0x0601CDAD RID: 118189 RVA: 0x0042E4E4 File Offset: 0x0042C6E4
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

		// Token: 0x170061A2 RID: 24994
		// (get) Token: 0x0601CDAE RID: 118190 RVA: 0x0042E4ED File Offset: 0x0042C6ED
		// (set) Token: 0x0601CDAF RID: 118191 RVA: 0x0042E4F5 File Offset: 0x0042C6F5
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

		// Token: 0x170061A3 RID: 24995
		// (get) Token: 0x0601CDB0 RID: 118192 RVA: 0x0042E4FE File Offset: 0x0042C6FE
		// (set) Token: 0x0601CDB1 RID: 118193 RVA: 0x0042E506 File Offset: 0x0042C706
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

		// Token: 0x170061A4 RID: 24996
		// (get) Token: 0x0601CDB2 RID: 118194 RVA: 0x0042E50F File Offset: 0x0042C70F
		// (set) Token: 0x0601CDB3 RID: 118195 RVA: 0x0042E517 File Offset: 0x0042C717
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

		// Token: 0x0601CDB4 RID: 118196 RVA: 0x0042E520 File Offset: 0x0042C720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePassengerUpdateNotify);
		}

		// Token: 0x0601CDB5 RID: 118197 RVA: 0x0042E530 File Offset: 0x0042C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePassengerUpdateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RoleId == other.RoleId && this.SeatId == other.SeatId && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CDB6 RID: 118198 RVA: 0x0042E59C File Offset: 0x0042C79C
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

		// Token: 0x0601CDB7 RID: 118199 RVA: 0x0042E626 File Offset: 0x0042C826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CDB8 RID: 118200 RVA: 0x0042E633 File Offset: 0x0042C833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CDB9 RID: 118201 RVA: 0x0042E63C File Offset: 0x0042C83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.PlayerId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this.SeatId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SeatId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CDBA RID: 118202 RVA: 0x0042E6D0 File Offset: 0x0042C8D0
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

		// Token: 0x0601CDBB RID: 118203 RVA: 0x0042E758 File Offset: 0x0042C958
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

		// Token: 0x0601CDBC RID: 118204 RVA: 0x0042E7D0 File Offset: 0x0042C9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CDBD RID: 118205 RVA: 0x0042E7DC File Offset: 0x0042C9DC
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
				if (num <= 80U)
				{
					if (num == 48U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.SeatId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A5F7 RID: 42487
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5F8 RID: 42488
		public const int PlayerIdFieldNumber = 6;

		// Token: 0x0400A5F9 RID: 42489
		private int playerId_;

		// Token: 0x0400A5FA RID: 42490
		public const int RoleIdFieldNumber = 10;

		// Token: 0x0400A5FB RID: 42491
		private int roleId_;

		// Token: 0x0400A5FC RID: 42492
		public const int SeatIdFieldNumber = 14;

		// Token: 0x0400A5FD RID: 42493
		private int seatId_;

		// Token: 0x0400A5FE RID: 42494
		public const int EntityIdFieldNumber = 12;

		// Token: 0x0400A5FF RID: 42495
		private long entityId_;
	}
}
