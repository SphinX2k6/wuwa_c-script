using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200154E RID: 5454
	[NetMessage(EMessageId.VehicleResponse)]
	public sealed class VehicleResponse : IMessage<VehicleResponse>, IMessage, IEquatable<VehicleResponse>, IDeepCloneable<VehicleResponse>, IBufferMessage
	{
		// Token: 0x0601CE3A RID: 118330 RVA: 0x0042F8AA File Offset: 0x0042DAAA
		[NullableContext(1)]
		public static VehicleResponse Create()
		{
			return new VehicleResponse();
		}

		// Token: 0x170061BF RID: 25023
		// (get) Token: 0x0601CE3B RID: 118331 RVA: 0x0042F8B1 File Offset: 0x0042DAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170061C0 RID: 25024
		// (get) Token: 0x0601CE3C RID: 118332 RVA: 0x0042F8B4 File Offset: 0x0042DAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleResponse.Descriptor;
			}
		}

		// Token: 0x0601CE3D RID: 118333 RVA: 0x0042F8BB File Offset: 0x0042DABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleResponse()
		{
		}

		// Token: 0x0601CE3E RID: 118334 RVA: 0x0042F8C3 File Offset: 0x0042DAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleResponse(VehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CE3F RID: 118335 RVA: 0x0042F8E8 File Offset: 0x0042DAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleResponse Clone()
		{
			return new VehicleResponse(this);
		}

		// Token: 0x170061C1 RID: 25025
		// (get) Token: 0x0601CE40 RID: 118336 RVA: 0x0042F8F0 File Offset: 0x0042DAF0
		// (set) Token: 0x0601CE41 RID: 118337 RVA: 0x0042F8F8 File Offset: 0x0042DAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601CE42 RID: 118338 RVA: 0x0042F901 File Offset: 0x0042DB01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleResponse);
		}

		// Token: 0x0601CE43 RID: 118339 RVA: 0x0042F90F File Offset: 0x0042DB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CE44 RID: 118340 RVA: 0x0042F940 File Offset: 0x0042DB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CE45 RID: 118341 RVA: 0x0042F985 File Offset: 0x0042DB85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CE46 RID: 118342 RVA: 0x0042F992 File Offset: 0x0042DB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CE47 RID: 118343 RVA: 0x0042F99B File Offset: 0x0042DB9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CE48 RID: 118344 RVA: 0x0042F9D0 File Offset: 0x0042DBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CE49 RID: 118345 RVA: 0x0042FA0E File Offset: 0x0042DC0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CE4A RID: 118346 RVA: 0x0042FA3F File Offset: 0x0042DC3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CE4B RID: 118347 RVA: 0x0042FA48 File Offset: 0x0042DC48
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A622 RID: 42530
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A623 RID: 42531
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A624 RID: 42532
		private ErrorCode errorCode_;
	}
}
