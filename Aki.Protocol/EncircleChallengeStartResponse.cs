using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043C RID: 1084
	[NetMessage(EMessageId.EncircleChallengeStartResponse)]
	public sealed class EncircleChallengeStartResponse : IMessage<EncircleChallengeStartResponse>, IMessage, IEquatable<EncircleChallengeStartResponse>, IDeepCloneable<EncircleChallengeStartResponse>, IBufferMessage
	{
		// Token: 0x060067D3 RID: 26579 RVA: 0x000F945D File Offset: 0x000F765D
		[NullableContext(1)]
		public static EncircleChallengeStartResponse Create()
		{
			return new EncircleChallengeStartResponse();
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x000F9464 File Offset: 0x000F7664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x060067D5 RID: 26581 RVA: 0x000F9467 File Offset: 0x000F7667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeStartResponse.Descriptor;
			}
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x000F946E File Offset: 0x000F766E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartResponse()
		{
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x000F9476 File Offset: 0x000F7676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartResponse(EncircleChallengeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x000F949B File Offset: 0x000F769B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeStartResponse Clone()
		{
			return new EncircleChallengeStartResponse(this);
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x060067D9 RID: 26585 RVA: 0x000F94A3 File Offset: 0x000F76A3
		// (set) Token: 0x060067DA RID: 26586 RVA: 0x000F94AB File Offset: 0x000F76AB
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

		// Token: 0x060067DB RID: 26587 RVA: 0x000F94B4 File Offset: 0x000F76B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeStartResponse);
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x000F94C2 File Offset: 0x000F76C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x000F94F0 File Offset: 0x000F76F0
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

		// Token: 0x060067DE RID: 26590 RVA: 0x000F9535 File Offset: 0x000F7735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x000F9542 File Offset: 0x000F7742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x000F954B File Offset: 0x000F774B
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

		// Token: 0x060067E1 RID: 26593 RVA: 0x000F9580 File Offset: 0x000F7780
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

		// Token: 0x060067E2 RID: 26594 RVA: 0x000F95BE File Offset: 0x000F77BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleChallengeStartResponse other)
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

		// Token: 0x060067E3 RID: 26595 RVA: 0x000F95EF File Offset: 0x000F77EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x000F95F8 File Offset: 0x000F77F8
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

		// Token: 0x04003984 RID: 14724
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003985 RID: 14725
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04003986 RID: 14726
		private ErrorCode errorCode_;
	}
}
