using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CC RID: 972
	[NetMessage(EMessageId.DissolveCombineRelationResponse)]
	public sealed class DissolveCombineRelationResponse : IMessage<DissolveCombineRelationResponse>, IMessage, IEquatable<DissolveCombineRelationResponse>, IDeepCloneable<DissolveCombineRelationResponse>, IBufferMessage
	{
		// Token: 0x06005F25 RID: 24357 RVA: 0x000E6A50 File Offset: 0x000E4C50
		[NullableContext(1)]
		public static DissolveCombineRelationResponse Create()
		{
			return new DissolveCombineRelationResponse();
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x000E6A57 File Offset: 0x000E4C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06005F27 RID: 24359 RVA: 0x000E6A5A File Offset: 0x000E4C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DissolveCombineRelationResponse.Descriptor;
			}
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x000E6A61 File Offset: 0x000E4C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationResponse()
		{
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x000E6A69 File Offset: 0x000E4C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationResponse(DissolveCombineRelationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x000E6A8E File Offset: 0x000E4C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DissolveCombineRelationResponse Clone()
		{
			return new DissolveCombineRelationResponse(this);
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06005F2B RID: 24363 RVA: 0x000E6A96 File Offset: 0x000E4C96
		// (set) Token: 0x06005F2C RID: 24364 RVA: 0x000E6A9E File Offset: 0x000E4C9E
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

		// Token: 0x06005F2D RID: 24365 RVA: 0x000E6AA7 File Offset: 0x000E4CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DissolveCombineRelationResponse);
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x000E6AB5 File Offset: 0x000E4CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DissolveCombineRelationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x000E6AE4 File Offset: 0x000E4CE4
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

		// Token: 0x06005F30 RID: 24368 RVA: 0x000E6B29 File Offset: 0x000E4D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x000E6B36 File Offset: 0x000E4D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x000E6B3F File Offset: 0x000E4D3F
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

		// Token: 0x06005F33 RID: 24371 RVA: 0x000E6B74 File Offset: 0x000E4D74
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

		// Token: 0x06005F34 RID: 24372 RVA: 0x000E6BB2 File Offset: 0x000E4DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DissolveCombineRelationResponse other)
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

		// Token: 0x06005F35 RID: 24373 RVA: 0x000E6BE3 File Offset: 0x000E4DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x000E6BEC File Offset: 0x000E4DEC
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

		// Token: 0x0400375F RID: 14175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003760 RID: 14176
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04003761 RID: 14177
		private ErrorCode errorCode_;
	}
}
