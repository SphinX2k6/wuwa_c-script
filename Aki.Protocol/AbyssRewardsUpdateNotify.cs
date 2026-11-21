using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000042 RID: 66
	[NetMessage(EMessageId.AbyssRewardsUpdateNotify)]
	public sealed class AbyssRewardsUpdateNotify : IMessage<AbyssRewardsUpdateNotify>, IMessage, IEquatable<AbyssRewardsUpdateNotify>, IDeepCloneable<AbyssRewardsUpdateNotify>, IBufferMessage
	{
		// Token: 0x060013E7 RID: 5095 RVA: 0x00035BED File Offset: 0x00033DED
		[NullableContext(1)]
		public static AbyssRewardsUpdateNotify Create()
		{
			return new AbyssRewardsUpdateNotify();
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00035BF4 File Offset: 0x00033DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00035BF7 File Offset: 0x00033DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardsUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00035BFE File Offset: 0x00033DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardsUpdateNotify()
		{
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00035C11 File Offset: 0x00033E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardsUpdateNotify(AbyssRewardsUpdateNotify other) : this()
		{
			this.rewardInfos_ = other.rewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00035C3B File Offset: 0x00033E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardsUpdateNotify Clone()
		{
			return new AbyssRewardsUpdateNotify(this);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00035C43 File Offset: 0x00033E43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRewardInfo> RewardInfos
		{
			get
			{
				return this.rewardInfos_;
			}
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00035C4B File Offset: 0x00033E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardsUpdateNotify);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00035C59 File Offset: 0x00033E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardsUpdateNotify other)
		{
			return other != null && (other == this || (this.rewardInfos_.Equals(other.rewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00035C8C File Offset: 0x00033E8C
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

		// Token: 0x060013F1 RID: 5105 RVA: 0x00035CC0 File Offset: 0x00033EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00035CCD File Offset: 0x00033ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00035CD6 File Offset: 0x00033ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardInfos_.WriteTo(ref output, AbyssRewardsUpdateNotify._repeated_rewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00035D00 File Offset: 0x00033F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardInfos_.CalculateSize(AbyssRewardsUpdateNotify._repeated_rewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00035D39 File Offset: 0x00033F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRewardsUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardInfos_.Add(other.rewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00035D67 File Offset: 0x00033F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00035D70 File Offset: 0x00033F70
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardInfos_.AddEntriesFrom(ref input, AbyssRewardsUpdateNotify._repeated_rewardInfos_codec);
				}
			}
		}

		// Token: 0x0400207D RID: 8317
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400207E RID: 8318
		public const int RewardInfosFieldNumber = 14;

		// Token: 0x0400207F RID: 8319
		private static readonly FieldCodec<AbyssRewardInfo> _repeated_rewardInfos_codec = FieldCodec.ForMessage<AbyssRewardInfo>(114U, AbyssRewardInfo.Parser);

		// Token: 0x04002080 RID: 8320
		private readonly RepeatedField<AbyssRewardInfo> rewardInfos_ = new RepeatedField<AbyssRewardInfo>();
	}
}
