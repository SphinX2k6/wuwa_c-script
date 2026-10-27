using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000804 RID: 2052
	[NetMessage(EMessageId.InfrV2ScoreRewardRequest)]
	public sealed class InfrV2ScoreRewardRequest : IMessage<InfrV2ScoreRewardRequest>, IMessage, IEquatable<InfrV2ScoreRewardRequest>, IDeepCloneable<InfrV2ScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B7B6 RID: 47030 RVA: 0x001B6056 File Offset: 0x001B4256
		[NullableContext(1)]
		public static InfrV2ScoreRewardRequest Create()
		{
			return new InfrV2ScoreRewardRequest();
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x0600B7B7 RID: 47031 RVA: 0x001B605D File Offset: 0x001B425D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x0600B7B8 RID: 47032 RVA: 0x001B6060 File Offset: 0x001B4260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x001B6067 File Offset: 0x001B4267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardRequest()
		{
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x001B607A File Offset: 0x001B427A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardRequest(InfrV2ScoreRewardRequest other) : this()
		{
			this.scoreIds_ = other.scoreIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x001B60A4 File Offset: 0x001B42A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardRequest Clone()
		{
			return new InfrV2ScoreRewardRequest(this);
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x0600B7BC RID: 47036 RVA: 0x001B60AC File Offset: 0x001B42AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreIds
		{
			get
			{
				return this.scoreIds_;
			}
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x001B60B4 File Offset: 0x001B42B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ScoreRewardRequest);
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x001B60C2 File Offset: 0x001B42C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ScoreRewardRequest other)
		{
			return other != null && (other == this || (this.scoreIds_.Equals(other.scoreIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x001B60F8 File Offset: 0x001B42F8
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

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x001B612C File Offset: 0x001B432C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x001B6139 File Offset: 0x001B4339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x001B6142 File Offset: 0x001B4342
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

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x001B616C File Offset: 0x001B436C
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

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x001B61A5 File Offset: 0x001B43A5
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

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x001B61D3 File Offset: 0x001B43D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x001B61DC File Offset: 0x001B43DC
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
					this.scoreIds_.AddEntriesFrom(ref input, InfrV2ScoreRewardRequest._repeated_scoreIds_codec);
				}
			}
		}

		// Token: 0x04005117 RID: 20759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005118 RID: 20760
		public const int ScoreIdsFieldNumber = 10;

		// Token: 0x04005119 RID: 20761
		private static readonly FieldCodec<int> _repeated_scoreIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400511A RID: 20762
		private readonly RepeatedField<int> scoreIds_ = new RepeatedField<int>();
	}
}
