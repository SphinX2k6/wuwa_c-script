using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004FC RID: 1276
	[NetMessage(EMessageId.ExploreProgressRewardResponse)]
	public sealed class ExploreProgressRewardResponse : IMessage<ExploreProgressRewardResponse>, IMessage, IEquatable<ExploreProgressRewardResponse>, IDeepCloneable<ExploreProgressRewardResponse>, IBufferMessage
	{
		// Token: 0x0600785E RID: 30814 RVA: 0x0012519D File Offset: 0x0012339D
		[NullableContext(1)]
		public static ExploreProgressRewardResponse Create()
		{
			return new ExploreProgressRewardResponse();
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600785F RID: 30815 RVA: 0x001251A4 File Offset: 0x001233A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06007860 RID: 30816 RVA: 0x001251A7 File Offset: 0x001233A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x001251AE File Offset: 0x001233AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardResponse()
		{
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x001251C1 File Offset: 0x001233C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardResponse(ExploreProgressRewardResponse other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x001251EB File Offset: 0x001233EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardResponse Clone()
		{
			return new ExploreProgressRewardResponse(this);
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06007864 RID: 30820 RVA: 0x001251F3 File Offset: 0x001233F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x001251FB File Offset: 0x001233FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardResponse);
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00125209 File Offset: 0x00123409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardResponse other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x0012523C File Offset: 0x0012343C
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

		// Token: 0x06007868 RID: 30824 RVA: 0x00125270 File Offset: 0x00123470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x0012527D File Offset: 0x0012347D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00125286 File Offset: 0x00123486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIds_.WriteTo(ref output, ExploreProgressRewardResponse._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x001252B0 File Offset: 0x001234B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardIds_.CalculateSize(ExploreProgressRewardResponse._repeated_rewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x001252E9 File Offset: 0x001234E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreProgressRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardIds_.Add(other.rewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00125317 File Offset: 0x00123517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00125320 File Offset: 0x00123520
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardIds_.AddEntriesFrom(ref input, ExploreProgressRewardResponse._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04003E64 RID: 15972
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E65 RID: 15973
		public const int RewardIdsFieldNumber = 10;

		// Token: 0x04003E66 RID: 15974
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04003E67 RID: 15975
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
