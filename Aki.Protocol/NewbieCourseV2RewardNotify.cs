using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0C RID: 2828
	[NetMessage(EMessageId.NewbieCourseV2RewardNotify)]
	public sealed class NewbieCourseV2RewardNotify : IMessage<NewbieCourseV2RewardNotify>, IMessage, IEquatable<NewbieCourseV2RewardNotify>, IDeepCloneable<NewbieCourseV2RewardNotify>, IBufferMessage
	{
		// Token: 0x0600F5AC RID: 62892 RVA: 0x0023D6E7 File Offset: 0x0023B8E7
		[NullableContext(1)]
		public static NewbieCourseV2RewardNotify Create()
		{
			return new NewbieCourseV2RewardNotify();
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0600F5AD RID: 62893 RVA: 0x0023D6EE File Offset: 0x0023B8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0600F5AE RID: 62894 RVA: 0x0023D6F1 File Offset: 0x0023B8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2RewardNotify.Descriptor;
			}
		}

		// Token: 0x0600F5AF RID: 62895 RVA: 0x0023D6F8 File Offset: 0x0023B8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardNotify()
		{
		}

		// Token: 0x0600F5B0 RID: 62896 RVA: 0x0023D70B File Offset: 0x0023B90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardNotify(NewbieCourseV2RewardNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5B1 RID: 62897 RVA: 0x0023D741 File Offset: 0x0023B941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardNotify Clone()
		{
			return new NewbieCourseV2RewardNotify(this);
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600F5B2 RID: 62898 RVA: 0x0023D749 File Offset: 0x0023B949
		// (set) Token: 0x0600F5B3 RID: 62899 RVA: 0x0023D751 File Offset: 0x0023B951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600F5B4 RID: 62900 RVA: 0x0023D75A File Offset: 0x0023B95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x0600F5B5 RID: 62901 RVA: 0x0023D762 File Offset: 0x0023B962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2RewardNotify);
		}

		// Token: 0x0600F5B6 RID: 62902 RVA: 0x0023D770 File Offset: 0x0023B970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2RewardNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.hadTakeReward_.Equals(other.hadTakeReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5B7 RID: 62903 RVA: 0x0023D7C0 File Offset: 0x0023B9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.hadTakeReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F5B8 RID: 62904 RVA: 0x0023D80D File Offset: 0x0023BA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5B9 RID: 62905 RVA: 0x0023D81A File Offset: 0x0023BA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5BA RID: 62906 RVA: 0x0023D824 File Offset: 0x0023BA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			this.hadTakeReward_.WriteTo(ref output, NewbieCourseV2RewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F5BB RID: 62907 RVA: 0x0023D874 File Offset: 0x0023BA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.hadTakeReward_.CalculateSize(NewbieCourseV2RewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F5BC RID: 62908 RVA: 0x0023D8C8 File Offset: 0x0023BAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCourseV2RewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.hadTakeReward_.Add(other.hadTakeReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F5BD RID: 62909 RVA: 0x0023D915 File Offset: 0x0023BB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5BE RID: 62910 RVA: 0x0023D920 File Offset: 0x0023BB20
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
				if (num != 96U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.hadTakeReward_.AddEntriesFrom(ref input, NewbieCourseV2RewardNotify._repeated_hadTakeReward_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062C0 RID: 25280
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062C1 RID: 25281
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040062C2 RID: 25282
		private int activityId_;

		// Token: 0x040062C3 RID: 25283
		public const int HadTakeRewardFieldNumber = 13;

		// Token: 0x040062C4 RID: 25284
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040062C5 RID: 25285
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();
	}
}
