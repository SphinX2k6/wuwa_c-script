using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101D RID: 4125
	[NetMessage(EMessageId.RogueTowerTrialReChallengeResponse)]
	public sealed class RogueTowerTrialReChallengeResponse : IMessage<RogueTowerTrialReChallengeResponse>, IMessage, IEquatable<RogueTowerTrialReChallengeResponse>, IDeepCloneable<RogueTowerTrialReChallengeResponse>, IBufferMessage
	{
		// Token: 0x060160D6 RID: 90326 RVA: 0x00334755 File Offset: 0x00332955
		[NullableContext(1)]
		public static RogueTowerTrialReChallengeResponse Create()
		{
			return new RogueTowerTrialReChallengeResponse();
		}

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x060160D7 RID: 90327 RVA: 0x0033475C File Offset: 0x0033295C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x060160D8 RID: 90328 RVA: 0x0033475F File Offset: 0x0033295F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialReChallengeResponse.Descriptor;
			}
		}

		// Token: 0x060160D9 RID: 90329 RVA: 0x00334766 File Offset: 0x00332966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeResponse()
		{
		}

		// Token: 0x060160DA RID: 90330 RVA: 0x0033476E File Offset: 0x0033296E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeResponse(RogueTowerTrialReChallengeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160DB RID: 90331 RVA: 0x00334793 File Offset: 0x00332993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeResponse Clone()
		{
			return new RogueTowerTrialReChallengeResponse(this);
		}

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x060160DC RID: 90332 RVA: 0x0033479B File Offset: 0x0033299B
		// (set) Token: 0x060160DD RID: 90333 RVA: 0x003347A3 File Offset: 0x003329A3
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

		// Token: 0x060160DE RID: 90334 RVA: 0x003347AC File Offset: 0x003329AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialReChallengeResponse);
		}

		// Token: 0x060160DF RID: 90335 RVA: 0x003347BA File Offset: 0x003329BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialReChallengeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160E0 RID: 90336 RVA: 0x003347E8 File Offset: 0x003329E8
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

		// Token: 0x060160E1 RID: 90337 RVA: 0x0033482D File Offset: 0x00332A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160E2 RID: 90338 RVA: 0x0033483A File Offset: 0x00332A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160E3 RID: 90339 RVA: 0x00334843 File Offset: 0x00332A43
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

		// Token: 0x060160E4 RID: 90340 RVA: 0x00334878 File Offset: 0x00332A78
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

		// Token: 0x060160E5 RID: 90341 RVA: 0x003348B6 File Offset: 0x00332AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialReChallengeResponse other)
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

		// Token: 0x060160E6 RID: 90342 RVA: 0x003348E7 File Offset: 0x00332AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160E7 RID: 90343 RVA: 0x003348F0 File Offset: 0x00332AF0
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

		// Token: 0x04008430 RID: 33840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008431 RID: 33841
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04008432 RID: 33842
		private ErrorCode errorCode_;
	}
}
