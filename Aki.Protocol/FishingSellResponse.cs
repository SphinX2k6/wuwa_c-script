using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057C RID: 1404
	[NetMessage(EMessageId.FishingSellResponse)]
	public sealed class FishingSellResponse : IMessage<FishingSellResponse>, IMessage, IEquatable<FishingSellResponse>, IDeepCloneable<FishingSellResponse>, IBufferMessage
	{
		// Token: 0x0600827C RID: 33404 RVA: 0x0013AC91 File Offset: 0x00138E91
		[NullableContext(1)]
		public static FishingSellResponse Create()
		{
			return new FishingSellResponse();
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x0600827D RID: 33405 RVA: 0x0013AC98 File Offset: 0x00138E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x0600827E RID: 33406 RVA: 0x0013AC9B File Offset: 0x00138E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSellResponse.Descriptor;
			}
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x0013ACA2 File Offset: 0x00138EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellResponse()
		{
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x0013ACAA File Offset: 0x00138EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellResponse(FishingSellResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008281 RID: 33409 RVA: 0x0013ACCF File Offset: 0x00138ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSellResponse Clone()
		{
			return new FishingSellResponse(this);
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06008282 RID: 33410 RVA: 0x0013ACD7 File Offset: 0x00138ED7
		// (set) Token: 0x06008283 RID: 33411 RVA: 0x0013ACDF File Offset: 0x00138EDF
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

		// Token: 0x06008284 RID: 33412 RVA: 0x0013ACE8 File Offset: 0x00138EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSellResponse);
		}

		// Token: 0x06008285 RID: 33413 RVA: 0x0013ACF6 File Offset: 0x00138EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSellResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008286 RID: 33414 RVA: 0x0013AD24 File Offset: 0x00138F24
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

		// Token: 0x06008287 RID: 33415 RVA: 0x0013AD69 File Offset: 0x00138F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x0013AD76 File Offset: 0x00138F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008289 RID: 33417 RVA: 0x0013AD7F File Offset: 0x00138F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600828A RID: 33418 RVA: 0x0013ADB4 File Offset: 0x00138FB4
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

		// Token: 0x0600828B RID: 33419 RVA: 0x0013ADF2 File Offset: 0x00138FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSellResponse other)
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

		// Token: 0x0600828C RID: 33420 RVA: 0x0013AE23 File Offset: 0x00139023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600828D RID: 33421 RVA: 0x0013AE2C File Offset: 0x0013902C
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004143 RID: 16707
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004144 RID: 16708
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004145 RID: 16709
		private ErrorCode errorCode_;
	}
}
