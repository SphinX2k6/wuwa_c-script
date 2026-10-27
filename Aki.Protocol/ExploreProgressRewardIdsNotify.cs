using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FA RID: 1274
	[NetMessage(EMessageId.ExploreProgressRewardIdsNotify)]
	public sealed class ExploreProgressRewardIdsNotify : IMessage<ExploreProgressRewardIdsNotify>, IMessage, IEquatable<ExploreProgressRewardIdsNotify>, IDeepCloneable<ExploreProgressRewardIdsNotify>, IBufferMessage
	{
		// Token: 0x0600783A RID: 30778 RVA: 0x00124DDD File Offset: 0x00122FDD
		[NullableContext(1)]
		public static ExploreProgressRewardIdsNotify Create()
		{
			return new ExploreProgressRewardIdsNotify();
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x0600783B RID: 30779 RVA: 0x00124DE4 File Offset: 0x00122FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x0600783C RID: 30780 RVA: 0x00124DE7 File Offset: 0x00122FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardIdsNotify.Descriptor;
			}
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00124DEE File Offset: 0x00122FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardIdsNotify()
		{
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00124E01 File Offset: 0x00123001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardIdsNotify(ExploreProgressRewardIdsNotify other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00124E2B File Offset: 0x0012302B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardIdsNotify Clone()
		{
			return new ExploreProgressRewardIdsNotify(this);
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06007840 RID: 30784 RVA: 0x00124E33 File Offset: 0x00123033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00124E3B File Offset: 0x0012303B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardIdsNotify);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x00124E49 File Offset: 0x00123049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardIdsNotify other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x00124E7C File Offset: 0x0012307C
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

		// Token: 0x06007844 RID: 30788 RVA: 0x00124EB0 File Offset: 0x001230B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x00124EBD File Offset: 0x001230BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00124EC6 File Offset: 0x001230C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, ExploreProgressRewardIdsNotify._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x00124EF0 File Offset: 0x001230F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(ExploreProgressRewardIdsNotify._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00124F29 File Offset: 0x00123129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressRewardIdsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00124F57 File Offset: 0x00123157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00124F60 File Offset: 0x00123160
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, ExploreProgressRewardIdsNotify._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04003E5C RID: 15964
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E5D RID: 15965
		public const int RewardIdsFieldNumber = 14;

		// Token: 0x04003E5E RID: 15966
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04003E5F RID: 15967
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
