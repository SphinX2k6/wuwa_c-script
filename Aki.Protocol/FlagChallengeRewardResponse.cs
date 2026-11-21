using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000586 RID: 1414
	[NetMessage(EMessageId.FlagChallengeRewardResponse)]
	public sealed class FlagChallengeRewardResponse : IMessage<FlagChallengeRewardResponse>, IMessage, IEquatable<FlagChallengeRewardResponse>, IDeepCloneable<FlagChallengeRewardResponse>, IBufferMessage
	{
		// Token: 0x06008371 RID: 33649 RVA: 0x0013CDB8 File Offset: 0x0013AFB8
		[NullableContext(1)]
		public static FlagChallengeRewardResponse Create()
		{
			return new FlagChallengeRewardResponse();
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06008372 RID: 33650 RVA: 0x0013CDBF File Offset: 0x0013AFBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06008373 RID: 33651 RVA: 0x0013CDC2 File Offset: 0x0013AFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeRewardResponse.Descriptor;
			}
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x0013CDC9 File Offset: 0x0013AFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardResponse()
		{
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x0013CDD1 File Offset: 0x0013AFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardResponse(FlagChallengeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0013CDF6 File Offset: 0x0013AFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardResponse Clone()
		{
			return new FlagChallengeRewardResponse(this);
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06008377 RID: 33655 RVA: 0x0013CDFE File Offset: 0x0013AFFE
		// (set) Token: 0x06008378 RID: 33656 RVA: 0x0013CE06 File Offset: 0x0013B006
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

		// Token: 0x06008379 RID: 33657 RVA: 0x0013CE0F File Offset: 0x0013B00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeRewardResponse);
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x0013CE1D File Offset: 0x0013B01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600837B RID: 33659 RVA: 0x0013CE4C File Offset: 0x0013B04C
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

		// Token: 0x0600837C RID: 33660 RVA: 0x0013CE91 File Offset: 0x0013B091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x0013CE9E File Offset: 0x0013B09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x0013CEA7 File Offset: 0x0013B0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600837F RID: 33663 RVA: 0x0013CEDC File Offset: 0x0013B0DC
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

		// Token: 0x06008380 RID: 33664 RVA: 0x0013CF1A File Offset: 0x0013B11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeRewardResponse other)
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

		// Token: 0x06008381 RID: 33665 RVA: 0x0013CF4B File Offset: 0x0013B14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008382 RID: 33666 RVA: 0x0013CF54 File Offset: 0x0013B154
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040041CE RID: 16846
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041CF RID: 16847
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040041D0 RID: 16848
		private ErrorCode errorCode_;
	}
}
