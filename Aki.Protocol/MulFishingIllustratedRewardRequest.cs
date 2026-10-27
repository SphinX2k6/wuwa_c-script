using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ADC RID: 2780
	[NetMessage(EMessageId.MulFishingIllustratedRewardRequest)]
	public sealed class MulFishingIllustratedRewardRequest : IMessage<MulFishingIllustratedRewardRequest>, IMessage, IEquatable<MulFishingIllustratedRewardRequest>, IDeepCloneable<MulFishingIllustratedRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F1E5 RID: 61925 RVA: 0x00235405 File Offset: 0x00233605
		[NullableContext(1)]
		public static MulFishingIllustratedRewardRequest Create()
		{
			return new MulFishingIllustratedRewardRequest();
		}

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0600F1E6 RID: 61926 RVA: 0x0023540C File Offset: 0x0023360C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0600F1E7 RID: 61927 RVA: 0x0023540F File Offset: 0x0023360F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulFishingIllustratedRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F1E8 RID: 61928 RVA: 0x00235416 File Offset: 0x00233616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardRequest()
		{
		}

		// Token: 0x0600F1E9 RID: 61929 RVA: 0x00235429 File Offset: 0x00233629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardRequest(MulFishingIllustratedRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1EA RID: 61930 RVA: 0x00235453 File Offset: 0x00233653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardRequest Clone()
		{
			return new MulFishingIllustratedRewardRequest(this);
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x0600F1EB RID: 61931 RVA: 0x0023545B File Offset: 0x0023365B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x0600F1EC RID: 61932 RVA: 0x00235463 File Offset: 0x00233663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulFishingIllustratedRewardRequest);
		}

		// Token: 0x0600F1ED RID: 61933 RVA: 0x00235471 File Offset: 0x00233671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulFishingIllustratedRewardRequest other)
		{
			return other != null && (other == this || (this.rewardId_.Equals(other.rewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1EE RID: 61934 RVA: 0x002354A4 File Offset: 0x002336A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F1EF RID: 61935 RVA: 0x002354D8 File Offset: 0x002336D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1F0 RID: 61936 RVA: 0x002354E5 File Offset: 0x002336E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1F1 RID: 61937 RVA: 0x002354EE File Offset: 0x002336EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardId_.WriteTo(ref output, MulFishingIllustratedRewardRequest._repeated_rewardId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1F2 RID: 61938 RVA: 0x00235518 File Offset: 0x00233718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardId_.CalculateSize(MulFishingIllustratedRewardRequest._repeated_rewardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F1F3 RID: 61939 RVA: 0x00235551 File Offset: 0x00233751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulFishingIllustratedRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardId_.Add(other.rewardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F1F4 RID: 61940 RVA: 0x0023557F File Offset: 0x0023377F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1F5 RID: 61941 RVA: 0x00235588 File Offset: 0x00233788
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardId_.AddEntriesFrom(ref input, MulFishingIllustratedRewardRequest._repeated_rewardId_codec);
				}
			}
		}

		// Token: 0x040061A8 RID: 25000
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061A9 RID: 25001
		public const int RewardIdFieldNumber = 1;

		// Token: 0x040061AA RID: 25002
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040061AB RID: 25003
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();
	}
}
