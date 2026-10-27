using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101C RID: 4124
	[NetMessage(EMessageId.RogueTowerTrialReChallengeRequest)]
	public sealed class RogueTowerTrialReChallengeRequest : IMessage<RogueTowerTrialReChallengeRequest>, IMessage, IEquatable<RogueTowerTrialReChallengeRequest>, IDeepCloneable<RogueTowerTrialReChallengeRequest>, IBufferMessage
	{
		// Token: 0x060160C4 RID: 90308 RVA: 0x00334586 File Offset: 0x00332786
		[NullableContext(1)]
		public static RogueTowerTrialReChallengeRequest Create()
		{
			return new RogueTowerTrialReChallengeRequest();
		}

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x060160C5 RID: 90309 RVA: 0x0033458D File Offset: 0x0033278D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x060160C6 RID: 90310 RVA: 0x00334590 File Offset: 0x00332790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialReChallengeRequest.Descriptor;
			}
		}

		// Token: 0x060160C7 RID: 90311 RVA: 0x00334597 File Offset: 0x00332797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeRequest()
		{
		}

		// Token: 0x060160C8 RID: 90312 RVA: 0x0033459F File Offset: 0x0033279F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeRequest(RogueTowerTrialReChallengeRequest other) : this()
		{
			this.isReChallenge_ = other.isReChallenge_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060160C9 RID: 90313 RVA: 0x003345C4 File Offset: 0x003327C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeRequest Clone()
		{
			return new RogueTowerTrialReChallengeRequest(this);
		}

		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x060160CA RID: 90314 RVA: 0x003345CC File Offset: 0x003327CC
		// (set) Token: 0x060160CB RID: 90315 RVA: 0x003345D4 File Offset: 0x003327D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReChallenge
		{
			get
			{
				return this.isReChallenge_;
			}
			set
			{
				this.isReChallenge_ = value;
			}
		}

		// Token: 0x060160CC RID: 90316 RVA: 0x003345DD File Offset: 0x003327DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialReChallengeRequest);
		}

		// Token: 0x060160CD RID: 90317 RVA: 0x003345EB File Offset: 0x003327EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialReChallengeRequest other)
		{
			return other != null && (other == this || (this.IsReChallenge == other.IsReChallenge && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060160CE RID: 90318 RVA: 0x0033461C File Offset: 0x0033281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsReChallenge)
			{
				num ^= this.IsReChallenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060160CF RID: 90319 RVA: 0x0033465B File Offset: 0x0033285B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060160D0 RID: 90320 RVA: 0x00334668 File Offset: 0x00332868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060160D1 RID: 90321 RVA: 0x00334671 File Offset: 0x00332871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsReChallenge)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsReChallenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060160D2 RID: 90322 RVA: 0x003346A4 File Offset: 0x003328A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsReChallenge)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060160D3 RID: 90323 RVA: 0x003346D6 File Offset: 0x003328D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialReChallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsReChallenge)
			{
				this.IsReChallenge = other.IsReChallenge;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060160D4 RID: 90324 RVA: 0x00334707 File Offset: 0x00332907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060160D5 RID: 90325 RVA: 0x00334710 File Offset: 0x00332910
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsReChallenge = input.ReadBool();
				}
			}
		}

		// Token: 0x0400842D RID: 33837
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400842E RID: 33838
		public const int IsReChallengeFieldNumber = 6;

		// Token: 0x0400842F RID: 33839
		private bool isReChallenge_;
	}
}
