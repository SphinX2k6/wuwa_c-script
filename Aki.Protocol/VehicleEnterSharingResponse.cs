using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CC RID: 5324
	[NetMessage(EMessageId.VehicleEnterSharingResponse)]
	public sealed class VehicleEnterSharingResponse : IMessage<VehicleEnterSharingResponse>, IMessage, IEquatable<VehicleEnterSharingResponse>, IDeepCloneable<VehicleEnterSharingResponse>, IBufferMessage
	{
		// Token: 0x0601C281 RID: 115329 RVA: 0x00411EE8 File Offset: 0x004100E8
		[NullableContext(1)]
		public static VehicleEnterSharingResponse Create()
		{
			return new VehicleEnterSharingResponse();
		}

		// Token: 0x17005EED RID: 24301
		// (get) Token: 0x0601C282 RID: 115330 RVA: 0x00411EEF File Offset: 0x004100EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EEE RID: 24302
		// (get) Token: 0x0601C283 RID: 115331 RVA: 0x00411EF2 File Offset: 0x004100F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleEnterSharingResponse.Descriptor;
			}
		}

		// Token: 0x0601C284 RID: 115332 RVA: 0x00411EF9 File Offset: 0x004100F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingResponse()
		{
		}

		// Token: 0x0601C285 RID: 115333 RVA: 0x00411F01 File Offset: 0x00410101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingResponse(VehicleEnterSharingResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C286 RID: 115334 RVA: 0x00411F26 File Offset: 0x00410126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleEnterSharingResponse Clone()
		{
			return new VehicleEnterSharingResponse(this);
		}

		// Token: 0x17005EEF RID: 24303
		// (get) Token: 0x0601C287 RID: 115335 RVA: 0x00411F2E File Offset: 0x0041012E
		// (set) Token: 0x0601C288 RID: 115336 RVA: 0x00411F36 File Offset: 0x00410136
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

		// Token: 0x0601C289 RID: 115337 RVA: 0x00411F3F File Offset: 0x0041013F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleEnterSharingResponse);
		}

		// Token: 0x0601C28A RID: 115338 RVA: 0x00411F4D File Offset: 0x0041014D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleEnterSharingResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C28B RID: 115339 RVA: 0x00411F7C File Offset: 0x0041017C
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

		// Token: 0x0601C28C RID: 115340 RVA: 0x00411FC1 File Offset: 0x004101C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C28D RID: 115341 RVA: 0x00411FCE File Offset: 0x004101CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C28E RID: 115342 RVA: 0x00411FD7 File Offset: 0x004101D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C28F RID: 115343 RVA: 0x0041200C File Offset: 0x0041020C
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

		// Token: 0x0601C290 RID: 115344 RVA: 0x0041204A File Offset: 0x0041024A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleEnterSharingResponse other)
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

		// Token: 0x0601C291 RID: 115345 RVA: 0x0041207B File Offset: 0x0041027B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C292 RID: 115346 RVA: 0x00412084 File Offset: 0x00410284
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A18B RID: 41355
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A18C RID: 41356
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400A18D RID: 41357
		private ErrorCode errorCode_;
	}
}
