using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000374 RID: 884
	[NetMessage(EMessageId.DangoBrawlSettleResponse)]
	public sealed class DangoBrawlSettleResponse : IMessage<DangoBrawlSettleResponse>, IMessage, IEquatable<DangoBrawlSettleResponse>, IDeepCloneable<DangoBrawlSettleResponse>, IBufferMessage
	{
		// Token: 0x06005823 RID: 22563 RVA: 0x000D772A File Offset: 0x000D592A
		[NullableContext(1)]
		public static DangoBrawlSettleResponse Create()
		{
			return new DangoBrawlSettleResponse();
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x000D7731 File Offset: 0x000D5931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06005825 RID: 22565 RVA: 0x000D7734 File Offset: 0x000D5934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSettleResponse.Descriptor;
			}
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x000D773B File Offset: 0x000D593B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleResponse()
		{
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x000D7743 File Offset: 0x000D5943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleResponse(DangoBrawlSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x000D7768 File Offset: 0x000D5968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleResponse Clone()
		{
			return new DangoBrawlSettleResponse(this);
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x000D7770 File Offset: 0x000D5970
		// (set) Token: 0x0600582A RID: 22570 RVA: 0x000D7778 File Offset: 0x000D5978
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

		// Token: 0x0600582B RID: 22571 RVA: 0x000D7781 File Offset: 0x000D5981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSettleResponse);
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x000D778F File Offset: 0x000D598F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x000D77C0 File Offset: 0x000D59C0
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

		// Token: 0x0600582E RID: 22574 RVA: 0x000D7805 File Offset: 0x000D5A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x000D7812 File Offset: 0x000D5A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x000D781B File Offset: 0x000D5A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x000D7850 File Offset: 0x000D5A50
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

		// Token: 0x06005832 RID: 22578 RVA: 0x000D788E File Offset: 0x000D5A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlSettleResponse other)
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

		// Token: 0x06005833 RID: 22579 RVA: 0x000D78BF File Offset: 0x000D5ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x000D78C8 File Offset: 0x000D5AC8
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400355C RID: 13660
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400355D RID: 13661
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400355E RID: 13662
		private ErrorCode errorCode_;
	}
}
