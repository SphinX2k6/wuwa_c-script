using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x020016B7 RID: 5815
	[NetMessage(EMessageId.AiInformationResponse)]
	public sealed class AiInformationResponse : IMessage<AiInformationResponse>, IMessage, IEquatable<AiInformationResponse>, IDeepCloneable<AiInformationResponse>, IBufferMessage
	{
		// Token: 0x0601D21B RID: 119323 RVA: 0x00442F80 File Offset: 0x00441180
		[NullableContext(1)]
		public static AiInformationResponse Create()
		{
			return new AiInformationResponse();
		}

		// Token: 0x170062D1 RID: 25297
		// (get) Token: 0x0601D21C RID: 119324 RVA: 0x00442F87 File Offset: 0x00441187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062D2 RID: 25298
		// (get) Token: 0x0601D21D RID: 119325 RVA: 0x00442F8A File Offset: 0x0044118A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationResponse.Descriptor;
			}
		}

		// Token: 0x0601D21E RID: 119326 RVA: 0x00442F91 File Offset: 0x00441191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationResponse()
		{
		}

		// Token: 0x0601D21F RID: 119327 RVA: 0x00442F99 File Offset: 0x00441199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationResponse(AiInformationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D220 RID: 119328 RVA: 0x00442FBE File Offset: 0x004411BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationResponse Clone()
		{
			return new AiInformationResponse(this);
		}

		// Token: 0x170062D3 RID: 25299
		// (get) Token: 0x0601D221 RID: 119329 RVA: 0x00442FC6 File Offset: 0x004411C6
		// (set) Token: 0x0601D222 RID: 119330 RVA: 0x00442FCE File Offset: 0x004411CE
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

		// Token: 0x0601D223 RID: 119331 RVA: 0x00442FD7 File Offset: 0x004411D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationResponse);
		}

		// Token: 0x0601D224 RID: 119332 RVA: 0x00442FE5 File Offset: 0x004411E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D225 RID: 119333 RVA: 0x00443014 File Offset: 0x00441214
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

		// Token: 0x0601D226 RID: 119334 RVA: 0x00443059 File Offset: 0x00441259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D227 RID: 119335 RVA: 0x00443066 File Offset: 0x00441266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D228 RID: 119336 RVA: 0x0044306F File Offset: 0x0044126F
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

		// Token: 0x0601D229 RID: 119337 RVA: 0x004430A4 File Offset: 0x004412A4
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

		// Token: 0x0601D22A RID: 119338 RVA: 0x004430E2 File Offset: 0x004412E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformationResponse other)
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

		// Token: 0x0601D22B RID: 119339 RVA: 0x00443113 File Offset: 0x00441313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D22C RID: 119340 RVA: 0x0044311C File Offset: 0x0044131C
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

		// Token: 0x0400C463 RID: 50275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C464 RID: 50276
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400C465 RID: 50277
		private ErrorCode errorCode_;
	}
}
