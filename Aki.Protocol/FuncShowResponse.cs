using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000664 RID: 1636
	[NetMessage(EMessageId.FuncShowResponse)]
	public sealed class FuncShowResponse : IMessage<FuncShowResponse>, IMessage, IEquatable<FuncShowResponse>, IDeepCloneable<FuncShowResponse>, IBufferMessage
	{
		// Token: 0x06009671 RID: 38513 RVA: 0x0016B575 File Offset: 0x00169775
		[NullableContext(1)]
		public static FuncShowResponse Create()
		{
			return new FuncShowResponse();
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06009672 RID: 38514 RVA: 0x0016B57C File Offset: 0x0016977C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06009673 RID: 38515 RVA: 0x0016B57F File Offset: 0x0016977F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FuncShowResponse.Descriptor;
			}
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x0016B586 File Offset: 0x00169786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowResponse()
		{
		}

		// Token: 0x06009675 RID: 38517 RVA: 0x0016B58E File Offset: 0x0016978E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowResponse(FuncShowResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x0016B5B3 File Offset: 0x001697B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FuncShowResponse Clone()
		{
			return new FuncShowResponse(this);
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06009677 RID: 38519 RVA: 0x0016B5BB File Offset: 0x001697BB
		// (set) Token: 0x06009678 RID: 38520 RVA: 0x0016B5C3 File Offset: 0x001697C3
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

		// Token: 0x06009679 RID: 38521 RVA: 0x0016B5CC File Offset: 0x001697CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FuncShowResponse);
		}

		// Token: 0x0600967A RID: 38522 RVA: 0x0016B5DA File Offset: 0x001697DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FuncShowResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600967B RID: 38523 RVA: 0x0016B608 File Offset: 0x00169808
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

		// Token: 0x0600967C RID: 38524 RVA: 0x0016B64D File Offset: 0x0016984D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600967D RID: 38525 RVA: 0x0016B65A File Offset: 0x0016985A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600967E RID: 38526 RVA: 0x0016B663 File Offset: 0x00169863
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

		// Token: 0x0600967F RID: 38527 RVA: 0x0016B698 File Offset: 0x00169898
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

		// Token: 0x06009680 RID: 38528 RVA: 0x0016B6D6 File Offset: 0x001698D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FuncShowResponse other)
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

		// Token: 0x06009681 RID: 38529 RVA: 0x0016B707 File Offset: 0x00169907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x0016B710 File Offset: 0x00169910
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

		// Token: 0x0400480F RID: 18447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004810 RID: 18448
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04004811 RID: 18449
		private ErrorCode errorCode_;
	}
}
