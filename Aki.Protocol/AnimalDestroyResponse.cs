using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000E3 RID: 227
	[NetMessage(EMessageId.AnimalDestroyResponse)]
	public sealed class AnimalDestroyResponse : IMessage<AnimalDestroyResponse>, IMessage, IEquatable<AnimalDestroyResponse>, IDeepCloneable<AnimalDestroyResponse>, IBufferMessage
	{
		// Token: 0x06002176 RID: 8566 RVA: 0x0005993C File Offset: 0x00057B3C
		[NullableContext(1)]
		public static AnimalDestroyResponse Create()
		{
			return new AnimalDestroyResponse();
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x00059943 File Offset: 0x00057B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x00059946 File Offset: 0x00057B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AnimalDestroyResponse.Descriptor;
			}
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x0005994D File Offset: 0x00057B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyResponse()
		{
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x00059955 File Offset: 0x00057B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyResponse(AnimalDestroyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0005997A File Offset: 0x00057B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimalDestroyResponse Clone()
		{
			return new AnimalDestroyResponse(this);
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x00059982 File Offset: 0x00057B82
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x0005998A File Offset: 0x00057B8A
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

		// Token: 0x0600217E RID: 8574 RVA: 0x00059993 File Offset: 0x00057B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AnimalDestroyResponse);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000599A1 File Offset: 0x00057BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AnimalDestroyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000599D0 File Offset: 0x00057BD0
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

		// Token: 0x06002181 RID: 8577 RVA: 0x00059A15 File Offset: 0x00057C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00059A22 File Offset: 0x00057C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00059A2B File Offset: 0x00057C2B
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

		// Token: 0x06002184 RID: 8580 RVA: 0x00059A60 File Offset: 0x00057C60
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

		// Token: 0x06002185 RID: 8581 RVA: 0x00059A9E File Offset: 0x00057C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AnimalDestroyResponse other)
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

		// Token: 0x06002186 RID: 8582 RVA: 0x00059ACF File Offset: 0x00057CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00059AD8 File Offset: 0x00057CD8
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

		// Token: 0x0400243E RID: 9278
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400243F RID: 9279
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002440 RID: 9280
		private ErrorCode errorCode_;
	}
}
