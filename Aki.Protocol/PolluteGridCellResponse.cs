using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB7 RID: 3511
	[NetMessage(EMessageId.PolluteGridCellResponse)]
	public sealed class PolluteGridCellResponse : IMessage<PolluteGridCellResponse>, IMessage, IEquatable<PolluteGridCellResponse>, IDeepCloneable<PolluteGridCellResponse>, IBufferMessage
	{
		// Token: 0x06012EDD RID: 77533 RVA: 0x002C2F23 File Offset: 0x002C1123
		[NullableContext(1)]
		public static PolluteGridCellResponse Create()
		{
			return new PolluteGridCellResponse();
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x06012EDE RID: 77534 RVA: 0x002C2F2A File Offset: 0x002C112A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x06012EDF RID: 77535 RVA: 0x002C2F2D File Offset: 0x002C112D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PolluteGridCellResponse.Descriptor;
			}
		}

		// Token: 0x06012EE0 RID: 77536 RVA: 0x002C2F34 File Offset: 0x002C1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellResponse()
		{
		}

		// Token: 0x06012EE1 RID: 77537 RVA: 0x002C2F3C File Offset: 0x002C113C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellResponse(PolluteGridCellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EE2 RID: 77538 RVA: 0x002C2F61 File Offset: 0x002C1161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PolluteGridCellResponse Clone()
		{
			return new PolluteGridCellResponse(this);
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x06012EE3 RID: 77539 RVA: 0x002C2F69 File Offset: 0x002C1169
		// (set) Token: 0x06012EE4 RID: 77540 RVA: 0x002C2F71 File Offset: 0x002C1171
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

		// Token: 0x06012EE5 RID: 77541 RVA: 0x002C2F7A File Offset: 0x002C117A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PolluteGridCellResponse);
		}

		// Token: 0x06012EE6 RID: 77542 RVA: 0x002C2F88 File Offset: 0x002C1188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PolluteGridCellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012EE7 RID: 77543 RVA: 0x002C2FB8 File Offset: 0x002C11B8
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

		// Token: 0x06012EE8 RID: 77544 RVA: 0x002C2FFD File Offset: 0x002C11FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EE9 RID: 77545 RVA: 0x002C300A File Offset: 0x002C120A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EEA RID: 77546 RVA: 0x002C3013 File Offset: 0x002C1213
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

		// Token: 0x06012EEB RID: 77547 RVA: 0x002C3048 File Offset: 0x002C1248
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

		// Token: 0x06012EEC RID: 77548 RVA: 0x002C3086 File Offset: 0x002C1286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PolluteGridCellResponse other)
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

		// Token: 0x06012EED RID: 77549 RVA: 0x002C30B7 File Offset: 0x002C12B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EEE RID: 77550 RVA: 0x002C30C0 File Offset: 0x002C12C0
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

		// Token: 0x0400756A RID: 30058
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400756B RID: 30059
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400756C RID: 30060
		private ErrorCode errorCode_;
	}
}
