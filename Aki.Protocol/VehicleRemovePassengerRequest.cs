using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154B RID: 5451
	[NetMessage(EMessageId.VehicleRemovePassengerRequest)]
	public sealed class VehicleRemovePassengerRequest : IMessage<VehicleRemovePassengerRequest>, IMessage, IEquatable<VehicleRemovePassengerRequest>, IDeepCloneable<VehicleRemovePassengerRequest>, IBufferMessage
	{
		// Token: 0x0601CDF6 RID: 118262 RVA: 0x0042EEA9 File Offset: 0x0042D0A9
		[NullableContext(1)]
		public static VehicleRemovePassengerRequest Create()
		{
			return new VehicleRemovePassengerRequest();
		}

		// Token: 0x170061AF RID: 25007
		// (get) Token: 0x0601CDF7 RID: 118263 RVA: 0x0042EEB0 File Offset: 0x0042D0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061B0 RID: 25008
		// (get) Token: 0x0601CDF8 RID: 118264 RVA: 0x0042EEB3 File Offset: 0x0042D0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleRemovePassengerRequest.Descriptor;
			}
		}

		// Token: 0x0601CDF9 RID: 118265 RVA: 0x0042EEBA File Offset: 0x0042D0BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerRequest()
		{
		}

		// Token: 0x0601CDFA RID: 118266 RVA: 0x0042EEC2 File Offset: 0x0042D0C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerRequest(VehicleRemovePassengerRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CDFB RID: 118267 RVA: 0x0042EEE7 File Offset: 0x0042D0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerRequest Clone()
		{
			return new VehicleRemovePassengerRequest(this);
		}

		// Token: 0x170061B1 RID: 25009
		// (get) Token: 0x0601CDFC RID: 118268 RVA: 0x0042EEEF File Offset: 0x0042D0EF
		// (set) Token: 0x0601CDFD RID: 118269 RVA: 0x0042EEF7 File Offset: 0x0042D0F7
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

		// Token: 0x0601CDFE RID: 118270 RVA: 0x0042EF00 File Offset: 0x0042D100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleRemovePassengerRequest);
		}

		// Token: 0x0601CDFF RID: 118271 RVA: 0x0042EF0E File Offset: 0x0042D10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleRemovePassengerRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE00 RID: 118272 RVA: 0x0042EF3C File Offset: 0x0042D13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CE01 RID: 118273 RVA: 0x0042EF7B File Offset: 0x0042D17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE02 RID: 118274 RVA: 0x0042EF88 File Offset: 0x0042D188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE03 RID: 118275 RVA: 0x0042EF91 File Offset: 0x0042D191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE04 RID: 118276 RVA: 0x0042EFC4 File Offset: 0x0042D1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CE05 RID: 118277 RVA: 0x0042F002 File Offset: 0x0042D202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleRemovePassengerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CE06 RID: 118278 RVA: 0x0042F033 File Offset: 0x0042D233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE07 RID: 118279 RVA: 0x0042F03C File Offset: 0x0042D23C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A60B RID: 42507
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A60C RID: 42508
		public const int RoleIdFieldNumber = 7;

		// Token: 0x0400A60D RID: 42509
		private int roleId_;
	}
}
