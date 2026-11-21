using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E6 RID: 1254
	[NetMessage(EMessageId.ExploreProgressRewardResponse)]
	public sealed class ExploreProgressRewardResponse : IMessage<ExploreProgressRewardResponse>, IMessage, IEquatable<ExploreProgressRewardResponse>, IDeepCloneable<ExploreProgressRewardResponse>, IBufferMessage
	{
		// Token: 0x060076E2 RID: 30434 RVA: 0x00122309 File Offset: 0x00120509
		[NullableContext(1)]
		public static ExploreProgressRewardResponse Create()
		{
			return new ExploreProgressRewardResponse();
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x00122310 File Offset: 0x00120510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x060076E4 RID: 30436 RVA: 0x00122313 File Offset: 0x00120513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreProgressRewardResponse.Descriptor;
			}
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x0012231A File Offset: 0x0012051A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardResponse()
		{
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x0012232D File Offset: 0x0012052D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardResponse(ExploreProgressRewardResponse other) : this()
		{
			this.rewardIds_ = other.rewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00122357 File Offset: 0x00120557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreProgressRewardResponse Clone()
		{
			return new ExploreProgressRewardResponse(this);
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x0012235F File Offset: 0x0012055F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIds
		{
			get
			{
				return this.rewardIds_;
			}
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00122367 File Offset: 0x00120567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreProgressRewardResponse);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00122375 File Offset: 0x00120575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreProgressRewardResponse other)
		{
			return other != null && (other == this || (this.rewardIds_.Equals(other.rewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x001223A8 File Offset: 0x001205A8
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

		// Token: 0x060076EC RID: 30444 RVA: 0x001223DC File Offset: 0x001205DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x001223E9 File Offset: 0x001205E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x001223F2 File Offset: 0x001205F2
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

		// Token: 0x060076EF RID: 30447 RVA: 0x0012241C File Offset: 0x0012061C
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

		// Token: 0x060076F0 RID: 30448 RVA: 0x00122455 File Offset: 0x00120655
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

		// Token: 0x060076F1 RID: 30449 RVA: 0x00122483 File Offset: 0x00120683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x0012248C File Offset: 0x0012068C
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
					this.rewardIds_.AddEntriesFrom(ref input, ExploreProgressRewardResponse._repeated_rewardIds_codec);
				}
			}
		}

		// Token: 0x04003E55 RID: 15957
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E56 RID: 15958
		public const int RewardIdsFieldNumber = 1;

		// Token: 0x04003E57 RID: 15959
		private static readonly FieldCodec<int> _repeated_rewardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003E58 RID: 15960
		private readonly RepeatedField<int> rewardIds_ = new RepeatedField<int>();
	}
}
