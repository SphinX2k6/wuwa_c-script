using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x0200172E RID: 5934
	[NetMessage(EMessageId.AiHateResponse)]
	public sealed class AiHateResponse : IMessage<AiHateResponse>, IMessage, IEquatable<AiHateResponse>, IDeepCloneable<AiHateResponse>, IBufferMessage
	{
		// Token: 0x0601DC8E RID: 121998 RVA: 0x0045E159 File Offset: 0x0045C359
		[NullableContext(1)]
		public static AiHateResponse Create()
		{
			return new AiHateResponse();
		}

		// Token: 0x17006565 RID: 25957
		// (get) Token: 0x0601DC8F RID: 121999 RVA: 0x0045E160 File Offset: 0x0045C360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006566 RID: 25958
		// (get) Token: 0x0601DC90 RID: 122000 RVA: 0x0045E163 File Offset: 0x0045C363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiHateResponse.Descriptor;
			}
		}

		// Token: 0x0601DC91 RID: 122001 RVA: 0x0045E16A File Offset: 0x0045C36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateResponse()
		{
		}

		// Token: 0x0601DC92 RID: 122002 RVA: 0x0045E172 File Offset: 0x0045C372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateResponse(AiHateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DC93 RID: 122003 RVA: 0x0045E197 File Offset: 0x0045C397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiHateResponse Clone()
		{
			return new AiHateResponse(this);
		}

		// Token: 0x17006567 RID: 25959
		// (get) Token: 0x0601DC94 RID: 122004 RVA: 0x0045E19F File Offset: 0x0045C39F
		// (set) Token: 0x0601DC95 RID: 122005 RVA: 0x0045E1A7 File Offset: 0x0045C3A7
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

		// Token: 0x0601DC96 RID: 122006 RVA: 0x0045E1B0 File Offset: 0x0045C3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiHateResponse);
		}

		// Token: 0x0601DC97 RID: 122007 RVA: 0x0045E1BE File Offset: 0x0045C3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiHateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DC98 RID: 122008 RVA: 0x0045E1EC File Offset: 0x0045C3EC
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

		// Token: 0x0601DC99 RID: 122009 RVA: 0x0045E231 File Offset: 0x0045C431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DC9A RID: 122010 RVA: 0x0045E23E File Offset: 0x0045C43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DC9B RID: 122011 RVA: 0x0045E247 File Offset: 0x0045C447
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

		// Token: 0x0601DC9C RID: 122012 RVA: 0x0045E27C File Offset: 0x0045C47C
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

		// Token: 0x0601DC9D RID: 122013 RVA: 0x0045E2BA File Offset: 0x0045C4BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiHateResponse other)
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

		// Token: 0x0601DC9E RID: 122014 RVA: 0x0045E2EB File Offset: 0x0045C4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DC9F RID: 122015 RVA: 0x0045E2F4 File Offset: 0x0045C4F4
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

		// Token: 0x0400C97B RID: 51579
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C97C RID: 51580
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400C97D RID: 51581
		private ErrorCode errorCode_;
	}
}
