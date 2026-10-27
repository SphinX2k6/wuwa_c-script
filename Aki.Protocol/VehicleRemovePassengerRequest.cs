using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D5 RID: 5333
	[NetMessage(EMessageId.VehicleRemovePassengerRequest)]
	public sealed class VehicleRemovePassengerRequest : IMessage<VehicleRemovePassengerRequest>, IMessage, IEquatable<VehicleRemovePassengerRequest>, IDeepCloneable<VehicleRemovePassengerRequest>, IBufferMessage
	{
		// Token: 0x0601C32F RID: 115503 RVA: 0x004133ED File Offset: 0x004115ED
		[NullableContext(1)]
		public static VehicleRemovePassengerRequest Create()
		{
			return new VehicleRemovePassengerRequest();
		}

		// Token: 0x17005F0E RID: 24334
		// (get) Token: 0x0601C330 RID: 115504 RVA: 0x004133F4 File Offset: 0x004115F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F0F RID: 24335
		// (get) Token: 0x0601C331 RID: 115505 RVA: 0x004133F7 File Offset: 0x004115F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleRemovePassengerRequest.Descriptor;
			}
		}

		// Token: 0x0601C332 RID: 115506 RVA: 0x004133FE File Offset: 0x004115FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerRequest()
		{
		}

		// Token: 0x0601C333 RID: 115507 RVA: 0x00413406 File Offset: 0x00411606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerRequest(VehicleRemovePassengerRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C334 RID: 115508 RVA: 0x0041342B File Offset: 0x0041162B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleRemovePassengerRequest Clone()
		{
			return new VehicleRemovePassengerRequest(this);
		}

		// Token: 0x17005F10 RID: 24336
		// (get) Token: 0x0601C335 RID: 115509 RVA: 0x00413433 File Offset: 0x00411633
		// (set) Token: 0x0601C336 RID: 115510 RVA: 0x0041343B File Offset: 0x0041163B
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

		// Token: 0x0601C337 RID: 115511 RVA: 0x00413444 File Offset: 0x00411644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleRemovePassengerRequest);
		}

		// Token: 0x0601C338 RID: 115512 RVA: 0x00413452 File Offset: 0x00411652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleRemovePassengerRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C339 RID: 115513 RVA: 0x00413480 File Offset: 0x00411680
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

		// Token: 0x0601C33A RID: 115514 RVA: 0x004134BF File Offset: 0x004116BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C33B RID: 115515 RVA: 0x004134CC File Offset: 0x004116CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C33C RID: 115516 RVA: 0x004134D5 File Offset: 0x004116D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C33D RID: 115517 RVA: 0x00413508 File Offset: 0x00411708
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

		// Token: 0x0601C33E RID: 115518 RVA: 0x00413546 File Offset: 0x00411746
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

		// Token: 0x0601C33F RID: 115519 RVA: 0x00413577 File Offset: 0x00411777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C340 RID: 115520 RVA: 0x00413580 File Offset: 0x00411780
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A1B2 RID: 41394
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1B3 RID: 41395
		public const int RoleIdFieldNumber = 2;

		// Token: 0x0400A1B4 RID: 41396
		private int roleId_;
	}
}
