using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F0 RID: 2032
	[NetMessage(EMessageId.InfrV2ScoreRewardRequest)]
	public sealed class InfrV2ScoreRewardRequest : IMessage<InfrV2ScoreRewardRequest>, IMessage, IEquatable<InfrV2ScoreRewardRequest>, IDeepCloneable<InfrV2ScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B660 RID: 46688 RVA: 0x001B3616 File Offset: 0x001B1816
		[NullableContext(1)]
		public static InfrV2ScoreRewardRequest Create()
		{
			return new InfrV2ScoreRewardRequest();
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x0600B661 RID: 46689 RVA: 0x001B361D File Offset: 0x001B181D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x0600B662 RID: 46690 RVA: 0x001B3620 File Offset: 0x001B1820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x001B3627 File Offset: 0x001B1827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardRequest()
		{
		}

		// Token: 0x0600B664 RID: 46692 RVA: 0x001B363A File Offset: 0x001B183A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardRequest(InfrV2ScoreRewardRequest other) : this()
		{
			this.scoreIds_ = other.scoreIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B665 RID: 46693 RVA: 0x001B3664 File Offset: 0x001B1864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardRequest Clone()
		{
			return new InfrV2ScoreRewardRequest(this);
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x0600B666 RID: 46694 RVA: 0x001B366C File Offset: 0x001B186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIds
		{
			get
			{
				return this.scoreIds_;
			}
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x001B3674 File Offset: 0x001B1874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ScoreRewardRequest);
		}

		// Token: 0x0600B668 RID: 46696 RVA: 0x001B3682 File Offset: 0x001B1882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ScoreRewardRequest other)
		{
			return other != null && (other == this || (this.scoreIds_.Equals(other.scoreIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B669 RID: 46697 RVA: 0x001B36B8 File Offset: 0x001B18B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scoreIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B66A RID: 46698 RVA: 0x001B36EC File Offset: 0x001B18EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B66B RID: 46699 RVA: 0x001B36F9 File Offset: 0x001B18F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B66C RID: 46700 RVA: 0x001B3702 File Offset: 0x001B1902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreIds_.WriteTo(ref output, InfrV2ScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x001B372C File Offset: 0x001B192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scoreIds_.CalculateSize(InfrV2ScoreRewardRequest._repeated_scoreIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B66E RID: 46702 RVA: 0x001B3765 File Offset: 0x001B1965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.scoreIds_.Add(other.scoreIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B66F RID: 46703 RVA: 0x001B3793 File Offset: 0x001B1993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B670 RID: 46704 RVA: 0x001B379C File Offset: 0x001B199C
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.scoreIds_.AddEntriesFrom(ref input, InfrV2ScoreRewardRequest._repeated_scoreIds_codec);
				}
			}
		}

		// Token: 0x04005110 RID: 20752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005111 RID: 20753
		public const int ScoreIdsFieldNumber = 6;

		// Token: 0x04005112 RID: 20754
		private static readonly FieldCodec<int> _repeated_scoreIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04005113 RID: 20755
		private readonly RepeatedField<int> scoreIds_ = new RepeatedField<int>();
	}
}
