using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002FF RID: 767
	[NetMessage(EMessageId.CoopSpRewardRequest)]
	public sealed class CoopSpRewardRequest : IMessage<CoopSpRewardRequest>, IMessage, IEquatable<CoopSpRewardRequest>, IDeepCloneable<CoopSpRewardRequest>, IBufferMessage
	{
		// Token: 0x06004D87 RID: 19847 RVA: 0x000BC7B1 File Offset: 0x000BA9B1
		[NullableContext(1)]
		public static CoopSpRewardRequest Create()
		{
			return new CoopSpRewardRequest();
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x000BC7B8 File Offset: 0x000BA9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06004D89 RID: 19849 RVA: 0x000BC7BB File Offset: 0x000BA9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopSpRewardRequest.Descriptor;
			}
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x000BC7C2 File Offset: 0x000BA9C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardRequest()
		{
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x000BC7D5 File Offset: 0x000BA9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardRequest(CoopSpRewardRequest other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x000BC7FF File Offset: 0x000BA9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardRequest Clone()
		{
			return new CoopSpRewardRequest(this);
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06004D8D RID: 19853 RVA: 0x000BC807 File Offset: 0x000BAA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x000BC80F File Offset: 0x000BAA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopSpRewardRequest);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x000BC81D File Offset: 0x000BAA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopSpRewardRequest other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x000BC850 File Offset: 0x000BAA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x000BC884 File Offset: 0x000BAA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x000BC891 File Offset: 0x000BAA91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x000BC89A File Offset: 0x000BAA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, CoopSpRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x000BC8C4 File Offset: 0x000BAAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(CoopSpRewardRequest._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x000BC8FD File Offset: 0x000BAAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopSpRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x000BC92B File Offset: 0x000BAB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x000BC934 File Offset: 0x000BAB34
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
					this.rewardIds_.AddEntriesFrom(ref input, CoopSpRewardRequest._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04003151 RID: 12625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003152 RID: 12626
		public const int RewardIdsFieldNumber = 1;

		// Token: 0x04003153 RID: 12627
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003154 RID: 12628
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
