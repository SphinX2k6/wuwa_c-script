using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0C RID: 3852
	[NetMessage(EMessageId.ReorderFormationResponse)]
	public sealed class ReorderFormationResponse : IMessage<ReorderFormationResponse>, IMessage, IEquatable<ReorderFormationResponse>, IDeepCloneable<ReorderFormationResponse>, IBufferMessage
	{
		// Token: 0x06014A57 RID: 84567 RVA: 0x002FF978 File Offset: 0x002FDB78
		[NullableContext(1)]
		public static ReorderFormationResponse Create()
		{
			return new ReorderFormationResponse();
		}

		// Token: 0x170044A3 RID: 17571
		// (get) Token: 0x06014A58 RID: 84568 RVA: 0x002FF97F File Offset: 0x002FDB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044A4 RID: 17572
		// (get) Token: 0x06014A59 RID: 84569 RVA: 0x002FF982 File Offset: 0x002FDB82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReorderFormationResponse.Descriptor;
			}
		}

		// Token: 0x06014A5A RID: 84570 RVA: 0x002FF989 File Offset: 0x002FDB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationResponse()
		{
		}

		// Token: 0x06014A5B RID: 84571 RVA: 0x002FF991 File Offset: 0x002FDB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationResponse(ReorderFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A5C RID: 84572 RVA: 0x002FF9B6 File Offset: 0x002FDBB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationResponse Clone()
		{
			return new ReorderFormationResponse(this);
		}

		// Token: 0x170044A5 RID: 17573
		// (get) Token: 0x06014A5D RID: 84573 RVA: 0x002FF9BE File Offset: 0x002FDBBE
		// (set) Token: 0x06014A5E RID: 84574 RVA: 0x002FF9C6 File Offset: 0x002FDBC6
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

		// Token: 0x06014A5F RID: 84575 RVA: 0x002FF9CF File Offset: 0x002FDBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReorderFormationResponse);
		}

		// Token: 0x06014A60 RID: 84576 RVA: 0x002FF9DD File Offset: 0x002FDBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReorderFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A61 RID: 84577 RVA: 0x002FFA0C File Offset: 0x002FDC0C
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

		// Token: 0x06014A62 RID: 84578 RVA: 0x002FFA51 File Offset: 0x002FDC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A63 RID: 84579 RVA: 0x002FFA5E File Offset: 0x002FDC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A64 RID: 84580 RVA: 0x002FFA67 File Offset: 0x002FDC67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A65 RID: 84581 RVA: 0x002FFA9C File Offset: 0x002FDC9C
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

		// Token: 0x06014A66 RID: 84582 RVA: 0x002FFADA File Offset: 0x002FDCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReorderFormationResponse other)
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

		// Token: 0x06014A67 RID: 84583 RVA: 0x002FFB0B File Offset: 0x002FDD0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A68 RID: 84584 RVA: 0x002FFB14 File Offset: 0x002FDD14
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D41 RID: 32065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D42 RID: 32066
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007D43 RID: 32067
		private ErrorCode errorCode_;
	}
}
