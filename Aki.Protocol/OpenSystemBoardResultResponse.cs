using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA3 RID: 2979
	[NetMessage(EMessageId.OpenSystemBoardResultResponse)]
	public sealed class OpenSystemBoardResultResponse : IMessage<OpenSystemBoardResultResponse>, IMessage, IEquatable<OpenSystemBoardResultResponse>, IDeepCloneable<OpenSystemBoardResultResponse>, IBufferMessage
	{
		// Token: 0x06010276 RID: 66166 RVA: 0x0025BB9A File Offset: 0x00259D9A
		[NullableContext(1)]
		public static OpenSystemBoardResultResponse Create()
		{
			return new OpenSystemBoardResultResponse();
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x06010277 RID: 66167 RVA: 0x0025BBA1 File Offset: 0x00259DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x06010278 RID: 66168 RVA: 0x0025BBA4 File Offset: 0x00259DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenSystemBoardResultResponse.Descriptor;
			}
		}

		// Token: 0x06010279 RID: 66169 RVA: 0x0025BBAB File Offset: 0x00259DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultResponse()
		{
		}

		// Token: 0x0601027A RID: 66170 RVA: 0x0025BBB3 File Offset: 0x00259DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultResponse(OpenSystemBoardResultResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601027B RID: 66171 RVA: 0x0025BBD8 File Offset: 0x00259DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenSystemBoardResultResponse Clone()
		{
			return new OpenSystemBoardResultResponse(this);
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0601027C RID: 66172 RVA: 0x0025BBE0 File Offset: 0x00259DE0
		// (set) Token: 0x0601027D RID: 66173 RVA: 0x0025BBE8 File Offset: 0x00259DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0601027E RID: 66174 RVA: 0x0025BBF1 File Offset: 0x00259DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenSystemBoardResultResponse);
		}

		// Token: 0x0601027F RID: 66175 RVA: 0x0025BBFF File Offset: 0x00259DFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenSystemBoardResultResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010280 RID: 66176 RVA: 0x0025BC30 File Offset: 0x00259E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010281 RID: 66177 RVA: 0x0025BC75 File Offset: 0x00259E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010282 RID: 66178 RVA: 0x0025BC82 File Offset: 0x00259E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010283 RID: 66179 RVA: 0x0025BC8B File Offset: 0x00259E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010284 RID: 66180 RVA: 0x0025BCC0 File Offset: 0x00259EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010285 RID: 66181 RVA: 0x0025BCFE File Offset: 0x00259EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenSystemBoardResultResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010286 RID: 66182 RVA: 0x0025BD2F File Offset: 0x00259F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010287 RID: 66183 RVA: 0x0025BD38 File Offset: 0x00259F38
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040066EC RID: 26348
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066ED RID: 26349
		public const int CodeFieldNumber = 4;

		// Token: 0x040066EE RID: 26350
		private ErrorCode code_;
	}
}
