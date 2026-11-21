using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E2 RID: 4578
	[NetMessage(EMessageId.SeamlessTeleportVehicleRequest)]
	public sealed class SeamlessTeleportVehicleRequest : IMessage<SeamlessTeleportVehicleRequest>, IMessage, IEquatable<SeamlessTeleportVehicleRequest>, IDeepCloneable<SeamlessTeleportVehicleRequest>, IBufferMessage
	{
		// Token: 0x060186FB RID: 100091 RVA: 0x0038E979 File Offset: 0x0038CB79
		[NullableContext(1)]
		public static SeamlessTeleportVehicleRequest Create()
		{
			return new SeamlessTeleportVehicleRequest();
		}

		// Token: 0x1700525F RID: 21087
		// (get) Token: 0x060186FC RID: 100092 RVA: 0x0038E980 File Offset: 0x0038CB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005260 RID: 21088
		// (get) Token: 0x060186FD RID: 100093 RVA: 0x0038E983 File Offset: 0x0038CB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeamlessTeleportVehicleRequest.Descriptor;
			}
		}

		// Token: 0x060186FE RID: 100094 RVA: 0x0038E98A File Offset: 0x0038CB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleRequest()
		{
		}

		// Token: 0x060186FF RID: 100095 RVA: 0x0038E994 File Offset: 0x0038CB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleRequest(SeamlessTeleportVehicleRequest other) : this()
		{
			this.vehicleEntityId_ = other.vehicleEntityId_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018700 RID: 100096 RVA: 0x0038E9FC File Offset: 0x0038CBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeamlessTeleportVehicleRequest Clone()
		{
			return new SeamlessTeleportVehicleRequest(this);
		}

		// Token: 0x17005261 RID: 21089
		// (get) Token: 0x06018701 RID: 100097 RVA: 0x0038EA04 File Offset: 0x0038CC04
		// (set) Token: 0x06018702 RID: 100098 RVA: 0x0038EA0C File Offset: 0x0038CC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long VehicleEntityId
		{
			get
			{
				return this.vehicleEntityId_;
			}
			set
			{
				this.vehicleEntityId_ = value;
			}
		}

		// Token: 0x17005262 RID: 21090
		// (get) Token: 0x06018703 RID: 100099 RVA: 0x0038EA15 File Offset: 0x0038CC15
		// (set) Token: 0x06018704 RID: 100100 RVA: 0x0038EA1D File Offset: 0x0038CC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17005263 RID: 21091
		// (get) Token: 0x06018705 RID: 100101 RVA: 0x0038EA26 File Offset: 0x0038CC26
		// (set) Token: 0x06018706 RID: 100102 RVA: 0x0038EA2E File Offset: 0x0038CC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x06018707 RID: 100103 RVA: 0x0038EA37 File Offset: 0x0038CC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeamlessTeleportVehicleRequest);
		}

		// Token: 0x06018708 RID: 100104 RVA: 0x0038EA48 File Offset: 0x0038CC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeamlessTeleportVehicleRequest other)
		{
			return other != null && (other == this || (this.VehicleEntityId == other.VehicleEntityId && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018709 RID: 100105 RVA: 0x0038EAAC File Offset: 0x0038CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VehicleEntityId != 0L)
			{
				num ^= this.VehicleEntityId.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601870A RID: 100106 RVA: 0x0038EB17 File Offset: 0x0038CD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601870B RID: 100107 RVA: 0x0038EB24 File Offset: 0x0038CD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601870C RID: 100108 RVA: 0x0038EB30 File Offset: 0x0038CD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VehicleEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.VehicleEntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601870D RID: 100109 RVA: 0x0038EBA8 File Offset: 0x0038CDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VehicleEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.VehicleEntityId);
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601870E RID: 100110 RVA: 0x0038EC18 File Offset: 0x0038CE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeamlessTeleportVehicleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VehicleEntityId != 0L)
			{
				this.VehicleEntityId = other.VehicleEntityId;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601870F RID: 100111 RVA: 0x0038ECAC File Offset: 0x0038CEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018710 RID: 100112 RVA: 0x0038ECB8 File Offset: 0x0038CEB8
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
				if (num != 32U)
				{
					if (num != 42U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.rotation_ == null)
							{
								this.Rotation = new Rotator();
							}
							input.ReadMessage(this.Rotation);
						}
					}
					else
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
					}
				}
				else
				{
					this.VehicleEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009120 RID: 37152
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009121 RID: 37153
		public const int VehicleEntityIdFieldNumber = 4;

		// Token: 0x04009122 RID: 37154
		private long vehicleEntityId_;

		// Token: 0x04009123 RID: 37155
		public const int LocationFieldNumber = 5;

		// Token: 0x04009124 RID: 37156
		private Vector location_;

		// Token: 0x04009125 RID: 37157
		public const int RotationFieldNumber = 7;

		// Token: 0x04009126 RID: 37158
		private Rotator rotation_;
	}
}
