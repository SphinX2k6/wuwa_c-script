using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACB RID: 2763
	[NetMessage(EMessageId.MulFishingIllustratedRewardRequest)]
	public sealed class MulFishingIllustratedRewardRequest : IMessage<MulFishingIllustratedRewardRequest>, IMessage, IEquatable<MulFishingIllustratedRewardRequest>, IDeepCloneable<MulFishingIllustratedRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F0CB RID: 61643 RVA: 0x002331F9 File Offset: 0x002313F9
		[NullableContext(1)]
		public static MulFishingIllustratedRewardRequest Create()
		{
			return new MulFishingIllustratedRewardRequest();
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x0600F0CC RID: 61644 RVA: 0x00233200 File Offset: 0x00231400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x0600F0CD RID: 61645 RVA: 0x00233203 File Offset: 0x00231403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulFishingIllustratedRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F0CE RID: 61646 RVA: 0x0023320A File Offset: 0x0023140A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardRequest()
		{
		}

		// Token: 0x0600F0CF RID: 61647 RVA: 0x0023321D File Offset: 0x0023141D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardRequest(MulFishingIllustratedRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0D0 RID: 61648 RVA: 0x00233247 File Offset: 0x00231447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulFishingIllustratedRewardRequest Clone()
		{
			return new MulFishingIllustratedRewardRequest(this);
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x0600F0D1 RID: 61649 RVA: 0x0023324F File Offset: 0x0023144F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardId
		{
			get
			{
				return this.rewardId_;
			}
		}

		// Token: 0x0600F0D2 RID: 61650 RVA: 0x00233257 File Offset: 0x00231457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulFishingIllustratedRewardRequest);
		}

		// Token: 0x0600F0D3 RID: 61651 RVA: 0x00233265 File Offset: 0x00231465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulFishingIllustratedRewardRequest other)
		{
			return other != null && (other == this || (this.rewardId_.Equals(other.rewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0D4 RID: 61652 RVA: 0x00233298 File Offset: 0x00231498
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

		// Token: 0x0600F0D5 RID: 61653 RVA: 0x002332CC File Offset: 0x002314CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0D6 RID: 61654 RVA: 0x002332D9 File Offset: 0x002314D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0D7 RID: 61655 RVA: 0x002332E2 File Offset: 0x002314E2
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

		// Token: 0x0600F0D8 RID: 61656 RVA: 0x0023330C File Offset: 0x0023150C
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

		// Token: 0x0600F0D9 RID: 61657 RVA: 0x00233345 File Offset: 0x00231545
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

		// Token: 0x0600F0DA RID: 61658 RVA: 0x00233373 File Offset: 0x00231573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0DB RID: 61659 RVA: 0x0023337C File Offset: 0x0023157C
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
				if (num != 120U && num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardId_.AddEntriesFrom(ref input, MulFishingIllustratedRewardRequest._repeated_rewardId_codec);
				}
			}
		}

		// Token: 0x040061B1 RID: 25009
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061B2 RID: 25010
		public const int RewardIdFieldNumber = 15;

		// Token: 0x040061B3 RID: 25011
		private static readonly FieldCodec<int> _repeated_rewardId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040061B4 RID: 25012
		private readonly RepeatedField<int> rewardId_ = new RepeatedField<int>();
	}
}
