using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D8 RID: 5336
	[NetMessage(EMessageId.VehicleResponse)]
	public sealed class VehicleResponse : IMessage<VehicleResponse>, IMessage, IEquatable<VehicleResponse>, IDeepCloneable<VehicleResponse>, IBufferMessage
	{
		// Token: 0x0601C373 RID: 115571 RVA: 0x00413DEE File Offset: 0x00411FEE
		[NullableContext(1)]
		public static VehicleResponse Create()
		{
			return new VehicleResponse();
		}

		// Token: 0x17005F1E RID: 24350
		// (get) Token: 0x0601C374 RID: 115572 RVA: 0x00413DF5 File Offset: 0x00411FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F1F RID: 24351
		// (get) Token: 0x0601C375 RID: 115573 RVA: 0x00413DF8 File Offset: 0x00411FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleResponse.Descriptor;
			}
		}

		// Token: 0x0601C376 RID: 115574 RVA: 0x00413DFF File Offset: 0x00411FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleResponse()
		{
		}

		// Token: 0x0601C377 RID: 115575 RVA: 0x00413E07 File Offset: 0x00412007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleResponse(VehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C378 RID: 115576 RVA: 0x00413E2C File Offset: 0x0041202C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleResponse Clone()
		{
			return new VehicleResponse(this);
		}

		// Token: 0x17005F20 RID: 24352
		// (get) Token: 0x0601C379 RID: 115577 RVA: 0x00413E34 File Offset: 0x00412034
		// (set) Token: 0x0601C37A RID: 115578 RVA: 0x00413E3C File Offset: 0x0041203C
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

		// Token: 0x0601C37B RID: 115579 RVA: 0x00413E45 File Offset: 0x00412045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleResponse);
		}

		// Token: 0x0601C37C RID: 115580 RVA: 0x00413E53 File Offset: 0x00412053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C37D RID: 115581 RVA: 0x00413E84 File Offset: 0x00412084
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

		// Token: 0x0601C37E RID: 115582 RVA: 0x00413EC9 File Offset: 0x004120C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C37F RID: 115583 RVA: 0x00413ED6 File Offset: 0x004120D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C380 RID: 115584 RVA: 0x00413EDF File Offset: 0x004120DF
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

		// Token: 0x0601C381 RID: 115585 RVA: 0x00413F14 File Offset: 0x00412114
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

		// Token: 0x0601C382 RID: 115586 RVA: 0x00413F52 File Offset: 0x00412152
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

		// Token: 0x0601C383 RID: 115587 RVA: 0x00413F83 File Offset: 0x00412183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C384 RID: 115588 RVA: 0x00413F8C File Offset: 0x0041218C
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

		// Token: 0x0400A1C9 RID: 41417
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1CA RID: 41418
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400A1CB RID: 41419
		private ErrorCode errorCode_;
	}
}
