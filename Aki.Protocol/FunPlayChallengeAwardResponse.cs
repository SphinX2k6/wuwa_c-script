using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000668 RID: 1640
	[NetMessage(EMessageId.FunPlayChallengeAwardResponse)]
	public sealed class FunPlayChallengeAwardResponse : IMessage<FunPlayChallengeAwardResponse>, IMessage, IEquatable<FunPlayChallengeAwardResponse>, IDeepCloneable<FunPlayChallengeAwardResponse>, IBufferMessage
	{
		// Token: 0x060096BD RID: 38589 RVA: 0x0016BDC5 File Offset: 0x00169FC5
		[NullableContext(1)]
		public static FunPlayChallengeAwardResponse Create()
		{
			return new FunPlayChallengeAwardResponse();
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x060096BE RID: 38590 RVA: 0x0016BDCC File Offset: 0x00169FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x060096BF RID: 38591 RVA: 0x0016BDCF File Offset: 0x00169FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FunPlayChallengeAwardResponse.Descriptor;
			}
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x0016BDD6 File Offset: 0x00169FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardResponse()
		{
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x0016BDDE File Offset: 0x00169FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardResponse(FunPlayChallengeAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096C2 RID: 38594 RVA: 0x0016BE03 File Offset: 0x0016A003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FunPlayChallengeAwardResponse Clone()
		{
			return new FunPlayChallengeAwardResponse(this);
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x060096C3 RID: 38595 RVA: 0x0016BE0B File Offset: 0x0016A00B
		// (set) Token: 0x060096C4 RID: 38596 RVA: 0x0016BE13 File Offset: 0x0016A013
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

		// Token: 0x060096C5 RID: 38597 RVA: 0x0016BE1C File Offset: 0x0016A01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FunPlayChallengeAwardResponse);
		}

		// Token: 0x060096C6 RID: 38598 RVA: 0x0016BE2A File Offset: 0x0016A02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FunPlayChallengeAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096C7 RID: 38599 RVA: 0x0016BE58 File Offset: 0x0016A058
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

		// Token: 0x060096C8 RID: 38600 RVA: 0x0016BE9D File Offset: 0x0016A09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060096C9 RID: 38601 RVA: 0x0016BEAA File Offset: 0x0016A0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096CA RID: 38602 RVA: 0x0016BEB3 File Offset: 0x0016A0B3
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

		// Token: 0x060096CB RID: 38603 RVA: 0x0016BEE8 File Offset: 0x0016A0E8
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

		// Token: 0x060096CC RID: 38604 RVA: 0x0016BF26 File Offset: 0x0016A126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FunPlayChallengeAwardResponse other)
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

		// Token: 0x060096CD RID: 38605 RVA: 0x0016BF57 File Offset: 0x0016A157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x0016BF60 File Offset: 0x0016A160
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

		// Token: 0x0400481F RID: 18463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004820 RID: 18464
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004821 RID: 18465
		private ErrorCode errorCode_;
	}
}
