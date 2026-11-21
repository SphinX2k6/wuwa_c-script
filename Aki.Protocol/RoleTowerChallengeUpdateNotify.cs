using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C2 RID: 4290
	[NetMessage(EMessageId.RoleTowerChallengeUpdateNotify)]
	public sealed class RoleTowerChallengeUpdateNotify : IMessage<RoleTowerChallengeUpdateNotify>, IMessage, IEquatable<RoleTowerChallengeUpdateNotify>, IDeepCloneable<RoleTowerChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016EE9 RID: 93929 RVA: 0x00355D0B File Offset: 0x00353F0B
		[NullableContext(1)]
		public static RoleTowerChallengeUpdateNotify Create()
		{
			return new RoleTowerChallengeUpdateNotify();
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x06016EEA RID: 93930 RVA: 0x00355D12 File Offset: 0x00353F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x06016EEB RID: 93931 RVA: 0x00355D15 File Offset: 0x00353F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016EEC RID: 93932 RVA: 0x00355D1C File Offset: 0x00353F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeUpdateNotify()
		{
		}

		// Token: 0x06016EED RID: 93933 RVA: 0x00355D2F File Offset: 0x00353F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeUpdateNotify(RoleTowerChallengeUpdateNotify other) : this()
		{
			this.challengeInfos_ = other.challengeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016EEE RID: 93934 RVA: 0x00355D59 File Offset: 0x00353F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerChallengeUpdateNotify Clone()
		{
			return new RoleTowerChallengeUpdateNotify(this);
		}

		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x06016EEF RID: 93935 RVA: 0x00355D61 File Offset: 0x00353F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleTowerChallengeInfo> ChallengeInfos
		{
			get
			{
				return this.challengeInfos_;
			}
		}

		// Token: 0x06016EF0 RID: 93936 RVA: 0x00355D69 File Offset: 0x00353F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerChallengeUpdateNotify);
		}

		// Token: 0x06016EF1 RID: 93937 RVA: 0x00355D77 File Offset: 0x00353F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.challengeInfos_.Equals(other.challengeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016EF2 RID: 93938 RVA: 0x00355DAC File Offset: 0x00353FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016EF3 RID: 93939 RVA: 0x00355DE0 File Offset: 0x00353FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016EF4 RID: 93940 RVA: 0x00355DED File Offset: 0x00353FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016EF5 RID: 93941 RVA: 0x00355DF6 File Offset: 0x00353FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeInfos_.WriteTo(ref output, RoleTowerChallengeUpdateNotify._repeated_challengeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016EF6 RID: 93942 RVA: 0x00355E20 File Offset: 0x00354020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeInfos_.CalculateSize(RoleTowerChallengeUpdateNotify._repeated_challengeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016EF7 RID: 93943 RVA: 0x00355E59 File Offset: 0x00354059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerChallengeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeInfos_.Add(other.challengeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016EF8 RID: 93944 RVA: 0x00355E87 File Offset: 0x00354087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016EF9 RID: 93945 RVA: 0x00355E90 File Offset: 0x00354090
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.challengeInfos_.AddEntriesFrom(ref input, RoleTowerChallengeUpdateNotify._repeated_challengeInfos_codec);
				}
			}
		}

		// Token: 0x04008949 RID: 35145
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400894A RID: 35146
		public const int ChallengeInfosFieldNumber = 9;

		// Token: 0x0400894B RID: 35147
		private static readonly FieldCodec<RoleTowerChallengeInfo> _repeated_challengeInfos_codec = FieldCodec.ForMessage<RoleTowerChallengeInfo>(74U, RoleTowerChallengeInfo.Parser);

		// Token: 0x0400894C RID: 35148
		private readonly RepeatedField<RoleTowerChallengeInfo> challengeInfos_ = new RepeatedField<RoleTowerChallengeInfo>();
	}
}
