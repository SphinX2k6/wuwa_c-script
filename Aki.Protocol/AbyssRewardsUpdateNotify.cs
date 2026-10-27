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
		// Token: 0x060013BC RID: 5052 RVA: 0x00035634 File Offset: 0x00033834
		[NullableContext(1)]
		public static AbyssRewardsUpdateNotify Create()
		{
			return new AbyssRewardsUpdateNotify();
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x0003563B File Offset: 0x0003383B
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
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0003563E File Offset: 0x0003383E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardsUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00035645 File Offset: 0x00033845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardsUpdateNotify()
		{
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00035658 File Offset: 0x00033858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardsUpdateNotify(AbyssRewardsUpdateNotify other) : this()
		{
			this.rewardInfos_ = other.rewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00035682 File Offset: 0x00033882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardsUpdateNotify Clone()
		{
			return new AbyssRewardsUpdateNotify(this);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0003568A File Offset: 0x0003388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRewardInfo> RewardInfos
		{
			get
			{
				return this.rewardInfos_;
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00035692 File Offset: 0x00033892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardsUpdateNotify);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000356A0 File Offset: 0x000338A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardsUpdateNotify other)
		{
			return other != null && (other == this || (this.rewardInfos_.Equals(other.rewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x000356D4 File Offset: 0x000338D4
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

		// Token: 0x060013C6 RID: 5062 RVA: 0x00035708 File Offset: 0x00033908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00035715 File Offset: 0x00033915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0003571E File Offset: 0x0003391E
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

		// Token: 0x060013C9 RID: 5065 RVA: 0x00035748 File Offset: 0x00033948
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

		// Token: 0x060013CA RID: 5066 RVA: 0x00035781 File Offset: 0x00033981
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

		// Token: 0x060013CB RID: 5067 RVA: 0x000357AF File Offset: 0x000339AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x000357B8 File Offset: 0x000339B8
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.rewardInfos_.AddEntriesFrom(ref input, AbyssRewardsUpdateNotify._repeated_rewardInfos_codec);
				}
			}
		}

		// Token: 0x04002027 RID: 8231
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002028 RID: 8232
		public const int RewardInfosFieldNumber = 13;

		// Token: 0x04002029 RID: 8233
		private static readonly FieldCodec<AbyssRewardInfo> _repeated_rewardInfos_codec = FieldCodec.ForMessage<AbyssRewardInfo>(106U, AbyssRewardInfo.Parser);

		// Token: 0x0400202A RID: 8234
		private readonly RepeatedField<AbyssRewardInfo> rewardInfos_ = new RepeatedField<AbyssRewardInfo>();
	}
}
