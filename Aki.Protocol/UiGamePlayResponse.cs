using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147F RID: 5247
	[NetMessage(EMessageId.UiGamePlayResponse)]
	public sealed class UiGamePlayResponse : IMessage<UiGamePlayResponse>, IMessage, IEquatable<UiGamePlayResponse>, IDeepCloneable<UiGamePlayResponse>, IBufferMessage
	{
		// Token: 0x0601BC51 RID: 113745 RVA: 0x00404812 File Offset: 0x00402A12
		[NullableContext(1)]
		public static UiGamePlayResponse Create()
		{
			return new UiGamePlayResponse();
		}

		// Token: 0x17005DA1 RID: 23969
		// (get) Token: 0x0601BC52 RID: 113746 RVA: 0x00404819 File Offset: 0x00402A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DA2 RID: 23970
		// (get) Token: 0x0601BC53 RID: 113747 RVA: 0x0040481C File Offset: 0x00402A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UiGamePlayResponse.Descriptor;
			}
		}

		// Token: 0x0601BC54 RID: 113748 RVA: 0x00404823 File Offset: 0x00402A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayResponse()
		{
		}

		// Token: 0x0601BC55 RID: 113749 RVA: 0x0040482B File Offset: 0x00402A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayResponse(UiGamePlayResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC56 RID: 113750 RVA: 0x00404850 File Offset: 0x00402A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UiGamePlayResponse Clone()
		{
			return new UiGamePlayResponse(this);
		}

		// Token: 0x17005DA3 RID: 23971
		// (get) Token: 0x0601BC57 RID: 113751 RVA: 0x00404858 File Offset: 0x00402A58
		// (set) Token: 0x0601BC58 RID: 113752 RVA: 0x00404860 File Offset: 0x00402A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601BC59 RID: 113753 RVA: 0x00404869 File Offset: 0x00402A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UiGamePlayResponse);
		}

		// Token: 0x0601BC5A RID: 113754 RVA: 0x00404877 File Offset: 0x00402A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UiGamePlayResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC5B RID: 113755 RVA: 0x004048A8 File Offset: 0x00402AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BC5C RID: 113756 RVA: 0x004048ED File Offset: 0x00402AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC5D RID: 113757 RVA: 0x004048FA File Offset: 0x00402AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC5E RID: 113758 RVA: 0x00404903 File Offset: 0x00402B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC5F RID: 113759 RVA: 0x00404938 File Offset: 0x00402B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BC60 RID: 113760 RVA: 0x00404976 File Offset: 0x00402B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UiGamePlayResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BC61 RID: 113761 RVA: 0x004049A7 File Offset: 0x00402BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC62 RID: 113762 RVA: 0x004049B0 File Offset: 0x00402BB0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009FDC RID: 40924
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FDD RID: 40925
		public const int ErrorIdFieldNumber = 9;

		// Token: 0x04009FDE RID: 40926
		private ErrorCode errorId_;
	}
}
