using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000456 RID: 1110
	[NetMessage(EMessageId.EnterInstResponse)]
	public sealed class EnterInstResponse : IMessage<EnterInstResponse>, IMessage, IEquatable<EnterInstResponse>, IDeepCloneable<EnterInstResponse>, IBufferMessage
	{
		// Token: 0x06006A36 RID: 27190 RVA: 0x001009C0 File Offset: 0x000FEBC0
		[NullableContext(1)]
		public static EnterInstResponse Create()
		{
			return new EnterInstResponse();
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06006A37 RID: 27191 RVA: 0x001009C7 File Offset: 0x000FEBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x001009CA File Offset: 0x000FEBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterInstResponse.Descriptor;
			}
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x001009D1 File Offset: 0x000FEBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstResponse()
		{
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x001009D9 File Offset: 0x000FEBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstResponse(EnterInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x001009FE File Offset: 0x000FEBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterInstResponse Clone()
		{
			return new EnterInstResponse(this);
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06006A3C RID: 27196 RVA: 0x00100A06 File Offset: 0x000FEC06
		// (set) Token: 0x06006A3D RID: 27197 RVA: 0x00100A0E File Offset: 0x000FEC0E
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

		// Token: 0x06006A3E RID: 27198 RVA: 0x00100A17 File Offset: 0x000FEC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterInstResponse);
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x00100A25 File Offset: 0x000FEC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x00100A54 File Offset: 0x000FEC54
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

		// Token: 0x06006A41 RID: 27201 RVA: 0x00100A99 File Offset: 0x000FEC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x00100AA6 File Offset: 0x000FECA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00100AAF File Offset: 0x000FECAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x00100AE4 File Offset: 0x000FECE4
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

		// Token: 0x06006A45 RID: 27205 RVA: 0x00100B22 File Offset: 0x000FED22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterInstResponse other)
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

		// Token: 0x06006A46 RID: 27206 RVA: 0x00100B53 File Offset: 0x000FED53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00100B5C File Offset: 0x000FED5C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003A44 RID: 14916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A45 RID: 14917
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04003A46 RID: 14918
		private ErrorCode errorCode_;
	}
}
