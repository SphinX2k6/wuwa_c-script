using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001242 RID: 4674
	public sealed class SkinRewardActivityData : IMessage<SkinRewardActivityData>, IMessage, IEquatable<SkinRewardActivityData>, IDeepCloneable<SkinRewardActivityData>, IBufferMessage
	{
		// Token: 0x06018E91 RID: 102033 RVA: 0x003A01FF File Offset: 0x0039E3FF
		[NullableContext(1)]
		public static SkinRewardActivityData Create()
		{
			return new SkinRewardActivityData();
		}

		// Token: 0x17005403 RID: 21507
		// (get) Token: 0x06018E92 RID: 102034 RVA: 0x003A0206 File Offset: 0x0039E406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005404 RID: 21508
		// (get) Token: 0x06018E93 RID: 102035 RVA: 0x003A0209 File Offset: 0x0039E409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardActivityData.Descriptor;
			}
		}

		// Token: 0x06018E94 RID: 102036 RVA: 0x003A0210 File Offset: 0x0039E410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityData()
		{
		}

		// Token: 0x06018E95 RID: 102037 RVA: 0x003A0223 File Offset: 0x0039E423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityData(SkinRewardActivityData other) : this()
		{
			this.rewardInfos_ = other.rewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E96 RID: 102038 RVA: 0x003A024D File Offset: 0x0039E44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardActivityData Clone()
		{
			return new SkinRewardActivityData(this);
		}

		// Token: 0x17005405 RID: 21509
		// (get) Token: 0x06018E97 RID: 102039 RVA: 0x003A0255 File Offset: 0x0039E455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SkinRewardActivityRewardInfo> RewardInfos
		{
			get
			{
				return this.rewardInfos_;
			}
		}

		// Token: 0x06018E98 RID: 102040 RVA: 0x003A025D File Offset: 0x0039E45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardActivityData);
		}

		// Token: 0x06018E99 RID: 102041 RVA: 0x003A026B File Offset: 0x0039E46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardActivityData other)
		{
			return other != null && (other == this || (this.rewardInfos_.Equals(other.rewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E9A RID: 102042 RVA: 0x003A02A0 File Offset: 0x0039E4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E9B RID: 102043 RVA: 0x003A02D4 File Offset: 0x0039E4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E9C RID: 102044 RVA: 0x003A02E1 File Offset: 0x0039E4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E9D RID: 102045 RVA: 0x003A02EA File Offset: 0x0039E4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardInfos_.WriteTo(ref output, SkinRewardActivityData._repeated_rewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E9E RID: 102046 RVA: 0x003A0314 File Offset: 0x0039E514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardInfos_.CalculateSize(SkinRewardActivityData._repeated_rewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E9F RID: 102047 RVA: 0x003A034D File Offset: 0x0039E54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardInfos_.Add(other.rewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018EA0 RID: 102048 RVA: 0x003A037B File Offset: 0x0039E57B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EA1 RID: 102049 RVA: 0x003A0384 File Offset: 0x0039E584
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardInfos_.AddEntriesFrom(ref input, SkinRewardActivityData._repeated_rewardInfos_codec);
				}
			}
		}

		// Token: 0x040092EC RID: 37612
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092ED RID: 37613
		public const int RewardInfosFieldNumber = 1;

		// Token: 0x040092EE RID: 37614
		private static readonly FieldCodec<SkinRewardActivityRewardInfo> _repeated_rewardInfos_codec = FieldCodec.ForMessage<SkinRewardActivityRewardInfo>(10U, SkinRewardActivityRewardInfo.Parser);

		// Token: 0x040092EF RID: 37615
		private readonly RepeatedField<SkinRewardActivityRewardInfo> rewardInfos_ = new RepeatedField<SkinRewardActivityRewardInfo>();
	}
}
