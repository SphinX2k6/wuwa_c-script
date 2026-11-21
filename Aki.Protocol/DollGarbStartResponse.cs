using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D6 RID: 982
	[NetMessage(EMessageId.DollGarbStartResponse)]
	public sealed class DollGarbStartResponse : IMessage<DollGarbStartResponse>, IMessage, IEquatable<DollGarbStartResponse>, IDeepCloneable<DollGarbStartResponse>, IBufferMessage
	{
		// Token: 0x06005FE1 RID: 24545 RVA: 0x000E806D File Offset: 0x000E626D
		[NullableContext(1)]
		public static DollGarbStartResponse Create()
		{
			return new DollGarbStartResponse();
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06005FE2 RID: 24546 RVA: 0x000E8074 File Offset: 0x000E6274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x000E8077 File Offset: 0x000E6277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGarbStartResponse.Descriptor;
			}
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x000E807E File Offset: 0x000E627E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartResponse()
		{
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x000E8086 File Offset: 0x000E6286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartResponse(DollGarbStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x000E80AB File Offset: 0x000E62AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGarbStartResponse Clone()
		{
			return new DollGarbStartResponse(this);
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x000E80B3 File Offset: 0x000E62B3
		// (set) Token: 0x06005FE8 RID: 24552 RVA: 0x000E80BB File Offset: 0x000E62BB
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

		// Token: 0x06005FE9 RID: 24553 RVA: 0x000E80C4 File Offset: 0x000E62C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGarbStartResponse);
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x000E80D2 File Offset: 0x000E62D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGarbStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x000E8100 File Offset: 0x000E6300
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

		// Token: 0x06005FEC RID: 24556 RVA: 0x000E8145 File Offset: 0x000E6345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x000E8152 File Offset: 0x000E6352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x000E815B File Offset: 0x000E635B
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

		// Token: 0x06005FEF RID: 24559 RVA: 0x000E8190 File Offset: 0x000E6390
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

		// Token: 0x06005FF0 RID: 24560 RVA: 0x000E81CE File Offset: 0x000E63CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGarbStartResponse other)
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

		// Token: 0x06005FF1 RID: 24561 RVA: 0x000E81FF File Offset: 0x000E63FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x000E8208 File Offset: 0x000E6408
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

		// Token: 0x0400378A RID: 14218
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400378B RID: 14219
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400378C RID: 14220
		private ErrorCode errorCode_;
	}
}
