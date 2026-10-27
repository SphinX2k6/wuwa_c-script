using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200059B RID: 1435
	[NetMessage(EMessageId.FlagChallengeRewardResponse)]
	public sealed class FlagChallengeRewardResponse : IMessage<FlagChallengeRewardResponse>, IMessage, IEquatable<FlagChallengeRewardResponse>, IDeepCloneable<FlagChallengeRewardResponse>, IBufferMessage
	{
		// Token: 0x060084D9 RID: 34009 RVA: 0x0013F9C0 File Offset: 0x0013DBC0
		[NullableContext(1)]
		public static FlagChallengeRewardResponse Create()
		{
			return new FlagChallengeRewardResponse();
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x060084DA RID: 34010 RVA: 0x0013F9C7 File Offset: 0x0013DBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x060084DB RID: 34011 RVA: 0x0013F9CA File Offset: 0x0013DBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeRewardResponse.Descriptor;
			}
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x0013F9D1 File Offset: 0x0013DBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardResponse()
		{
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x0013F9D9 File Offset: 0x0013DBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardResponse(FlagChallengeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084DE RID: 34014 RVA: 0x0013F9FE File Offset: 0x0013DBFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeRewardResponse Clone()
		{
			return new FlagChallengeRewardResponse(this);
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x060084DF RID: 34015 RVA: 0x0013FA06 File Offset: 0x0013DC06
		// (set) Token: 0x060084E0 RID: 34016 RVA: 0x0013FA0E File Offset: 0x0013DC0E
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

		// Token: 0x060084E1 RID: 34017 RVA: 0x0013FA17 File Offset: 0x0013DC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeRewardResponse);
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x0013FA25 File Offset: 0x0013DC25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x0013FA54 File Offset: 0x0013DC54
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

		// Token: 0x060084E4 RID: 34020 RVA: 0x0013FA99 File Offset: 0x0013DC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x0013FAA6 File Offset: 0x0013DCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084E6 RID: 34022 RVA: 0x0013FAAF File Offset: 0x0013DCAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084E7 RID: 34023 RVA: 0x0013FAE4 File Offset: 0x0013DCE4
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

		// Token: 0x060084E8 RID: 34024 RVA: 0x0013FB22 File Offset: 0x0013DD22
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

		// Token: 0x060084E9 RID: 34025 RVA: 0x0013FB53 File Offset: 0x0013DD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x0013FB5C File Offset: 0x0013DD5C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040041D8 RID: 16856
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041D9 RID: 16857
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040041DA RID: 16858
		private ErrorCode errorCode_;
	}
}
