using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200007D RID: 125
	[NetMessage(EMessageId.ActivateBuffResponse)]
	public sealed class ActivateBuffResponse : IMessage<ActivateBuffResponse>, IMessage, IEquatable<ActivateBuffResponse>, IDeepCloneable<ActivateBuffResponse>, IBufferMessage
	{
		// Token: 0x06001881 RID: 6273 RVA: 0x00040283 File Offset: 0x0003E483
		[NullableContext(1)]
		public static ActivateBuffResponse Create()
		{
			return new ActivateBuffResponse();
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0004028A File Offset: 0x0003E48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0004028D File Offset: 0x0003E48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateBuffResponse.Descriptor;
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00040294 File Offset: 0x0003E494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffResponse()
		{
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0004029C File Offset: 0x0003E49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffResponse(ActivateBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000402C1 File Offset: 0x0003E4C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateBuffResponse Clone()
		{
			return new ActivateBuffResponse(this);
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x000402C9 File Offset: 0x0003E4C9
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x000402D1 File Offset: 0x0003E4D1
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

		// Token: 0x06001889 RID: 6281 RVA: 0x000402DA File Offset: 0x0003E4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateBuffResponse);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000402E8 File Offset: 0x0003E4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00040318 File Offset: 0x0003E518
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

		// Token: 0x0600188C RID: 6284 RVA: 0x0004035D File Offset: 0x0003E55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0004036A File Offset: 0x0003E56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00040373 File Offset: 0x0003E573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x000403A8 File Offset: 0x0003E5A8
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

		// Token: 0x06001890 RID: 6288 RVA: 0x000403E6 File Offset: 0x0003E5E6
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

		// Token: 0x06001891 RID: 6289 RVA: 0x00040417 File Offset: 0x0003E617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00040420 File Offset: 0x0003E620
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002184 RID: 8580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002185 RID: 8581
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04002186 RID: 8582
		private ErrorCode errorCode_;
	}
}
