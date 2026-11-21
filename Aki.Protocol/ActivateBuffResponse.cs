using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007E RID: 126
	[NetMessage(EMessageId.ActivateBuffResponse)]
	public sealed class ActivateBuffResponse : IMessage<ActivateBuffResponse>, IMessage, IEquatable<ActivateBuffResponse>, IDeepCloneable<ActivateBuffResponse>, IBufferMessage
	{
		// Token: 0x060018C4 RID: 6340 RVA: 0x00040C34 File Offset: 0x0003EE34
		[NullableContext(1)]
		public static ActivateBuffResponse Create()
		{
			return new ActivateBuffResponse();
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x00040C3B File Offset: 0x0003EE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x00040C3E File Offset: 0x0003EE3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffResponse.Descriptor;
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00040C45 File Offset: 0x0003EE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffResponse()
		{
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00040C4D File Offset: 0x0003EE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffResponse(ActivateBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00040C72 File Offset: 0x0003EE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffResponse Clone()
		{
			return new ActivateBuffResponse(this);
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00040C7A File Offset: 0x0003EE7A
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x00040C82 File Offset: 0x0003EE82
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

		// Token: 0x060018CC RID: 6348 RVA: 0x00040C8B File Offset: 0x0003EE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffResponse);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00040C99 File Offset: 0x0003EE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00040CC8 File Offset: 0x0003EEC8
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

		// Token: 0x060018CF RID: 6351 RVA: 0x00040D0D File Offset: 0x0003EF0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00040D1A File Offset: 0x0003EF1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00040D23 File Offset: 0x0003EF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00040D58 File Offset: 0x0003EF58
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

		// Token: 0x060018D3 RID: 6355 RVA: 0x00040D96 File Offset: 0x0003EF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivateBuffResponse other)
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

		// Token: 0x060018D4 RID: 6356 RVA: 0x00040DC7 File Offset: 0x0003EFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00040DD0 File Offset: 0x0003EFD0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040021E3 RID: 8675
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021E4 RID: 8676
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040021E5 RID: 8677
		private ErrorCode errorCode_;
	}
}
