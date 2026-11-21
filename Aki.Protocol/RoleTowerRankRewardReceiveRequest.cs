using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010DC RID: 4316
	[NetMessage(EMessageId.RoleTowerRankRewardReceiveRequest)]
	public sealed class RoleTowerRankRewardReceiveRequest : IMessage<RoleTowerRankRewardReceiveRequest>, IMessage, IEquatable<RoleTowerRankRewardReceiveRequest>, IDeepCloneable<RoleTowerRankRewardReceiveRequest>, IBufferMessage
	{
		// Token: 0x0601713A RID: 94522 RVA: 0x0035BBAC File Offset: 0x00359DAC
		[NullableContext(1)]
		public static RoleTowerRankRewardReceiveRequest Create()
		{
			return new RoleTowerRankRewardReceiveRequest();
		}

		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x0601713B RID: 94523 RVA: 0x0035BBB3 File Offset: 0x00359DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x0601713C RID: 94524 RVA: 0x0035BBB6 File Offset: 0x00359DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerRankRewardReceiveRequest.Descriptor;
			}
		}

		// Token: 0x0601713D RID: 94525 RVA: 0x0035BBBD File Offset: 0x00359DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRewardReceiveRequest()
		{
		}

		// Token: 0x0601713E RID: 94526 RVA: 0x0035BBD0 File Offset: 0x00359DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRewardReceiveRequest(RoleTowerRankRewardReceiveRequest other) : this()
		{
			this.challengeIds_ = other.challengeIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601713F RID: 94527 RVA: 0x0035BBFA File Offset: 0x00359DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerRankRewardReceiveRequest Clone()
		{
			return new RoleTowerRankRewardReceiveRequest(this);
		}

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x06017140 RID: 94528 RVA: 0x0035BC02 File Offset: 0x00359E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ChallengeIds
		{
			get
			{
				return this.challengeIds_;
			}
		}

		// Token: 0x06017141 RID: 94529 RVA: 0x0035BC0A File Offset: 0x00359E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerRankRewardReceiveRequest);
		}

		// Token: 0x06017142 RID: 94530 RVA: 0x0035BC18 File Offset: 0x00359E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerRankRewardReceiveRequest other)
		{
			return other != null && (other == this || (this.challengeIds_.Equals(other.challengeIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017143 RID: 94531 RVA: 0x0035BC4C File Offset: 0x00359E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017144 RID: 94532 RVA: 0x0035BC80 File Offset: 0x00359E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017145 RID: 94533 RVA: 0x0035BC8D File Offset: 0x00359E8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017146 RID: 94534 RVA: 0x0035BC96 File Offset: 0x00359E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeIds_.WriteTo(ref output, RoleTowerRankRewardReceiveRequest._repeated_challengeIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017147 RID: 94535 RVA: 0x0035BCC0 File Offset: 0x00359EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeIds_.CalculateSize(RoleTowerRankRewardReceiveRequest._repeated_challengeIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017148 RID: 94536 RVA: 0x0035BCF9 File Offset: 0x00359EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerRankRewardReceiveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeIds_.Add(other.challengeIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017149 RID: 94537 RVA: 0x0035BD27 File Offset: 0x00359F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601714A RID: 94538 RVA: 0x0035BD30 File Offset: 0x00359F30
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challengeIds_.AddEntriesFrom(ref input, RoleTowerRankRewardReceiveRequest._repeated_challengeIds_codec);
				}
			}
		}

		// Token: 0x04008A2E RID: 35374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A2F RID: 35375
		public const int ChallengeIdsFieldNumber = 12;

		// Token: 0x04008A30 RID: 35376
		private static readonly FieldCodec<int> _repeated_challengeIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04008A31 RID: 35377
		private readonly RepeatedField<int> challengeIds_ = new RepeatedField<int>();
	}
}
