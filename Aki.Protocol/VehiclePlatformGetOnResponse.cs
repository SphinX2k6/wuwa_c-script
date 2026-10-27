using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D4 RID: 5332
	[NetMessage(EMessageId.VehiclePlatformGetOnResponse)]
	public sealed class VehiclePlatformGetOnResponse : IMessage<VehiclePlatformGetOnResponse>, IMessage, IEquatable<VehiclePlatformGetOnResponse>, IDeepCloneable<VehiclePlatformGetOnResponse>, IBufferMessage
	{
		// Token: 0x0601C31D RID: 115485 RVA: 0x0041320C File Offset: 0x0041140C
		[NullableContext(1)]
		public static VehiclePlatformGetOnResponse Create()
		{
			return new VehiclePlatformGetOnResponse();
		}

		// Token: 0x17005F0B RID: 24331
		// (get) Token: 0x0601C31E RID: 115486 RVA: 0x00413213 File Offset: 0x00411413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F0C RID: 24332
		// (get) Token: 0x0601C31F RID: 115487 RVA: 0x00413216 File Offset: 0x00411416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePlatformGetOnResponse.Descriptor;
			}
		}

		// Token: 0x0601C320 RID: 115488 RVA: 0x0041321D File Offset: 0x0041141D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnResponse()
		{
		}

		// Token: 0x0601C321 RID: 115489 RVA: 0x00413225 File Offset: 0x00411425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnResponse(VehiclePlatformGetOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C322 RID: 115490 RVA: 0x0041324A File Offset: 0x0041144A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnResponse Clone()
		{
			return new VehiclePlatformGetOnResponse(this);
		}

		// Token: 0x17005F0D RID: 24333
		// (get) Token: 0x0601C323 RID: 115491 RVA: 0x00413252 File Offset: 0x00411452
		// (set) Token: 0x0601C324 RID: 115492 RVA: 0x0041325A File Offset: 0x0041145A
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

		// Token: 0x0601C325 RID: 115493 RVA: 0x00413263 File Offset: 0x00411463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePlatformGetOnResponse);
		}

		// Token: 0x0601C326 RID: 115494 RVA: 0x00413271 File Offset: 0x00411471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePlatformGetOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C327 RID: 115495 RVA: 0x004132A0 File Offset: 0x004114A0
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

		// Token: 0x0601C328 RID: 115496 RVA: 0x004132E5 File Offset: 0x004114E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C329 RID: 115497 RVA: 0x004132F2 File Offset: 0x004114F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C32A RID: 115498 RVA: 0x004132FB File Offset: 0x004114FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C32B RID: 115499 RVA: 0x00413330 File Offset: 0x00411530
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

		// Token: 0x0601C32C RID: 115500 RVA: 0x0041336E File Offset: 0x0041156E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehiclePlatformGetOnResponse other)
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

		// Token: 0x0601C32D RID: 115501 RVA: 0x0041339F File Offset: 0x0041159F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C32E RID: 115502 RVA: 0x004133A8 File Offset: 0x004115A8
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A1AF RID: 41391
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1B0 RID: 41392
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400A1B1 RID: 41393
		private ErrorCode errorCode_;
	}
}
