using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200013B RID: 315
	[NetMessage(EMessageId.AwakeItemVehicleResponse)]
	public sealed class AwakeItemVehicleResponse : IMessage<AwakeItemVehicleResponse>, IMessage, IEquatable<AwakeItemVehicleResponse>, IDeepCloneable<AwakeItemVehicleResponse>, IBufferMessage
	{
		// Token: 0x06002915 RID: 10517 RVA: 0x0006BFB7 File Offset: 0x0006A1B7
		[NullableContext(1)]
		public static AwakeItemVehicleResponse Create()
		{
			return new AwakeItemVehicleResponse();
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x0006BFBE File Offset: 0x0006A1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x0006BFC1 File Offset: 0x0006A1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AwakeItemVehicleResponse.Descriptor;
			}
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x0006BFC8 File Offset: 0x0006A1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleResponse()
		{
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0006BFD0 File Offset: 0x0006A1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleResponse(AwakeItemVehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0006BFF5 File Offset: 0x0006A1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AwakeItemVehicleResponse Clone()
		{
			return new AwakeItemVehicleResponse(this);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x0006BFFD File Offset: 0x0006A1FD
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x0006C005 File Offset: 0x0006A205
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

		// Token: 0x0600291D RID: 10525 RVA: 0x0006C00E File Offset: 0x0006A20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AwakeItemVehicleResponse);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x0006C01C File Offset: 0x0006A21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AwakeItemVehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0006C04C File Offset: 0x0006A24C
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

		// Token: 0x06002920 RID: 10528 RVA: 0x0006C091 File Offset: 0x0006A291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x0006C09E File Offset: 0x0006A29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x0006C0A7 File Offset: 0x0006A2A7
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

		// Token: 0x06002923 RID: 10531 RVA: 0x0006C0DC File Offset: 0x0006A2DC
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

		// Token: 0x06002924 RID: 10532 RVA: 0x0006C11A File Offset: 0x0006A31A
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

		// Token: 0x06002925 RID: 10533 RVA: 0x0006C14B File Offset: 0x0006A34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0006C154 File Offset: 0x0006A354
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

		// Token: 0x040026D9 RID: 9945
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026DA RID: 9946
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040026DB RID: 9947
		private ErrorCode errorCode_;
	}
}
