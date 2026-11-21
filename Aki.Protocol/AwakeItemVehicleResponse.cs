using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013E RID: 318
	[NetMessage(EMessageId.AwakeItemVehicleResponse)]
	public sealed class AwakeItemVehicleResponse : IMessage<AwakeItemVehicleResponse>, IMessage, IEquatable<AwakeItemVehicleResponse>, IDeepCloneable<AwakeItemVehicleResponse>, IBufferMessage
	{
		// Token: 0x0600298C RID: 10636 RVA: 0x0006D3EB File Offset: 0x0006B5EB
		[NullableContext(1)]
		public static AwakeItemVehicleResponse Create()
		{
			return new AwakeItemVehicleResponse();
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600298D RID: 10637 RVA: 0x0006D3F2 File Offset: 0x0006B5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x0006D3F5 File Offset: 0x0006B5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeItemVehicleResponse.Descriptor;
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x0006D3FC File Offset: 0x0006B5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleResponse()
		{
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x0006D404 File Offset: 0x0006B604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleResponse(AwakeItemVehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0006D429 File Offset: 0x0006B629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleResponse Clone()
		{
			return new AwakeItemVehicleResponse(this);
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x0006D431 File Offset: 0x0006B631
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x0006D439 File Offset: 0x0006B639
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

		// Token: 0x06002994 RID: 10644 RVA: 0x0006D442 File Offset: 0x0006B642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeItemVehicleResponse);
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x0006D450 File Offset: 0x0006B650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeItemVehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x0006D480 File Offset: 0x0006B680
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

		// Token: 0x06002997 RID: 10647 RVA: 0x0006D4C5 File Offset: 0x0006B6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x0006D4D2 File Offset: 0x0006B6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0006D4DB File Offset: 0x0006B6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0006D510 File Offset: 0x0006B710
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

		// Token: 0x0600299B RID: 10651 RVA: 0x0006D54E File Offset: 0x0006B74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AwakeItemVehicleResponse other)
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

		// Token: 0x0600299C RID: 10652 RVA: 0x0006D57F File Offset: 0x0006B77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0006D588 File Offset: 0x0006B788
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400274D RID: 10061
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400274E RID: 10062
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400274F RID: 10063
		private ErrorCode errorCode_;
	}
}
