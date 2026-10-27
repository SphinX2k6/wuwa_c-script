using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200018D RID: 397
	[NetMessage(EMessageId.BeControlledResponse)]
	public sealed class BeControlledResponse : IMessage<BeControlledResponse>, IMessage, IEquatable<BeControlledResponse>, IDeepCloneable<BeControlledResponse>, IBufferMessage
	{
		// Token: 0x06002F85 RID: 12165 RVA: 0x00079BC0 File Offset: 0x00077DC0
		[NullableContext(1)]
		public static BeControlledResponse Create()
		{
			return new BeControlledResponse();
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x00079BC7 File Offset: 0x00077DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00079BCA File Offset: 0x00077DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BeControlledResponse.Descriptor;
			}
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00079BD1 File Offset: 0x00077DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledResponse()
		{
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00079BD9 File Offset: 0x00077DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledResponse(BeControlledResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00079BFE File Offset: 0x00077DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BeControlledResponse Clone()
		{
			return new BeControlledResponse(this);
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x00079C06 File Offset: 0x00077E06
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x00079C0E File Offset: 0x00077E0E
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

		// Token: 0x06002F8D RID: 12173 RVA: 0x00079C17 File Offset: 0x00077E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BeControlledResponse);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00079C25 File Offset: 0x00077E25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BeControlledResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00079C54 File Offset: 0x00077E54
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

		// Token: 0x06002F90 RID: 12176 RVA: 0x00079C99 File Offset: 0x00077E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00079CA6 File Offset: 0x00077EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00079CAF File Offset: 0x00077EAF
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

		// Token: 0x06002F93 RID: 12179 RVA: 0x00079CE4 File Offset: 0x00077EE4
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

		// Token: 0x06002F94 RID: 12180 RVA: 0x00079D22 File Offset: 0x00077F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BeControlledResponse other)
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

		// Token: 0x06002F95 RID: 12181 RVA: 0x00079D53 File Offset: 0x00077F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x00079D5C File Offset: 0x00077F5C
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

		// Token: 0x040028B7 RID: 10423
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028B8 RID: 10424
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040028B9 RID: 10425
		private ErrorCode errorCode_;
	}
}
