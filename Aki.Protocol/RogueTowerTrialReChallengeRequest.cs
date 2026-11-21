using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100C RID: 4108
	[NetMessage(EMessageId.RogueTowerTrialReChallengeRequest)]
	public sealed class RogueTowerTrialReChallengeRequest : IMessage<RogueTowerTrialReChallengeRequest>, IMessage, IEquatable<RogueTowerTrialReChallengeRequest>, IDeepCloneable<RogueTowerTrialReChallengeRequest>, IBufferMessage
	{
		// Token: 0x06015FDF RID: 90079 RVA: 0x00332EC6 File Offset: 0x003310C6
		[NullableContext(1)]
		public static RogueTowerTrialReChallengeRequest Create()
		{
			return new RogueTowerTrialReChallengeRequest();
		}

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x06015FE0 RID: 90080 RVA: 0x00332ECD File Offset: 0x003310CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x06015FE1 RID: 90081 RVA: 0x00332ED0 File Offset: 0x003310D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialReChallengeRequest.Descriptor;
			}
		}

		// Token: 0x06015FE2 RID: 90082 RVA: 0x00332ED7 File Offset: 0x003310D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeRequest()
		{
		}

		// Token: 0x06015FE3 RID: 90083 RVA: 0x00332EDF File Offset: 0x003310DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeRequest(RogueTowerTrialReChallengeRequest other) : this()
		{
			this.isReChallenge_ = other.isReChallenge_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FE4 RID: 90084 RVA: 0x00332F04 File Offset: 0x00331104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialReChallengeRequest Clone()
		{
			return new RogueTowerTrialReChallengeRequest(this);
		}

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x06015FE5 RID: 90085 RVA: 0x00332F0C File Offset: 0x0033110C
		// (set) Token: 0x06015FE6 RID: 90086 RVA: 0x00332F14 File Offset: 0x00331114
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

		// Token: 0x06015FE7 RID: 90087 RVA: 0x00332F1D File Offset: 0x0033111D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialReChallengeRequest);
		}

		// Token: 0x06015FE8 RID: 90088 RVA: 0x00332F2B File Offset: 0x0033112B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialReChallengeRequest other)
		{
			return other != null && (other == this || (this.IsReChallenge == other.IsReChallenge && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FE9 RID: 90089 RVA: 0x00332F5C File Offset: 0x0033115C
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

		// Token: 0x06015FEA RID: 90090 RVA: 0x00332F9B File Offset: 0x0033119B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FEB RID: 90091 RVA: 0x00332FA8 File Offset: 0x003311A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FEC RID: 90092 RVA: 0x00332FB1 File Offset: 0x003311B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsReChallenge)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsReChallenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FED RID: 90093 RVA: 0x00332FE4 File Offset: 0x003311E4
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

		// Token: 0x06015FEE RID: 90094 RVA: 0x00333016 File Offset: 0x00331216
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

		// Token: 0x06015FEF RID: 90095 RVA: 0x00333047 File Offset: 0x00331247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FF0 RID: 90096 RVA: 0x00333050 File Offset: 0x00331250
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
					this.IsReChallenge = input.ReadBool();
				}
			}
		}

		// Token: 0x04008457 RID: 33879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008458 RID: 33880
		public const int IsReChallengeFieldNumber = 9;

		// Token: 0x04008459 RID: 33881
		private bool isReChallenge_;
	}
}
