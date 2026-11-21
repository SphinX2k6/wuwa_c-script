using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD9 RID: 4057
	[NetMessage(EMessageId.RogueResIllustrationAwardResponse)]
	public sealed class RogueResIllustrationAwardResponse : IMessage<RogueResIllustrationAwardResponse>, IMessage, IEquatable<RogueResIllustrationAwardResponse>, IDeepCloneable<RogueResIllustrationAwardResponse>, IBufferMessage
	{
		// Token: 0x06015B72 RID: 88946 RVA: 0x00327E15 File Offset: 0x00326015
		[NullableContext(1)]
		public static RogueResIllustrationAwardResponse Create()
		{
			return new RogueResIllustrationAwardResponse();
		}

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x06015B73 RID: 88947 RVA: 0x00327E1C File Offset: 0x0032601C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x06015B74 RID: 88948 RVA: 0x00327E1F File Offset: 0x0032601F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResIllustrationAwardResponse.Descriptor;
			}
		}

		// Token: 0x06015B75 RID: 88949 RVA: 0x00327E26 File Offset: 0x00326026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardResponse()
		{
		}

		// Token: 0x06015B76 RID: 88950 RVA: 0x00327E2E File Offset: 0x0032602E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardResponse(RogueResIllustrationAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.isFull_ = other.isFull_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015B77 RID: 88951 RVA: 0x00327E5F File Offset: 0x0032605F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResIllustrationAwardResponse Clone()
		{
			return new RogueResIllustrationAwardResponse(this);
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x06015B78 RID: 88952 RVA: 0x00327E67 File Offset: 0x00326067
		// (set) Token: 0x06015B79 RID: 88953 RVA: 0x00327E6F File Offset: 0x0032606F
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

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x06015B7A RID: 88954 RVA: 0x00327E78 File Offset: 0x00326078
		// (set) Token: 0x06015B7B RID: 88955 RVA: 0x00327E80 File Offset: 0x00326080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFull
		{
			get
			{
				return this.isFull_;
			}
			set
			{
				this.isFull_ = value;
			}
		}

		// Token: 0x06015B7C RID: 88956 RVA: 0x00327E89 File Offset: 0x00326089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResIllustrationAwardResponse);
		}

		// Token: 0x06015B7D RID: 88957 RVA: 0x00327E97 File Offset: 0x00326097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResIllustrationAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IsFull == other.IsFull && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015B7E RID: 88958 RVA: 0x00327ED8 File Offset: 0x003260D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.IsFull)
			{
				num ^= this.IsFull.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015B7F RID: 88959 RVA: 0x00327F36 File Offset: 0x00326136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015B80 RID: 88960 RVA: 0x00327F43 File Offset: 0x00326143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015B81 RID: 88961 RVA: 0x00327F4C File Offset: 0x0032614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsFull)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsFull);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015B82 RID: 88962 RVA: 0x00327FA8 File Offset: 0x003261A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.IsFull)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015B83 RID: 88963 RVA: 0x00327FF4 File Offset: 0x003261F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResIllustrationAwardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.IsFull)
			{
				this.IsFull = other.IsFull;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015B84 RID: 88964 RVA: 0x00328044 File Offset: 0x00326244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015B85 RID: 88965 RVA: 0x00328050 File Offset: 0x00326250
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsFull = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040082CF RID: 33487
		private UnknownFieldSet _unknownFields;

		// Token: 0x040082D0 RID: 33488
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040082D1 RID: 33489
		private ErrorCode errorCode_;

		// Token: 0x040082D2 RID: 33490
		public const int IsFullFieldNumber = 12;

		// Token: 0x040082D3 RID: 33491
		private bool isFull_;
	}
}
