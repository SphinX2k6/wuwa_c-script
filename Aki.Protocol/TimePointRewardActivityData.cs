using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200137E RID: 4990
	public sealed class TimePointRewardActivityData : IMessage<TimePointRewardActivityData>, IMessage, IEquatable<TimePointRewardActivityData>, IDeepCloneable<TimePointRewardActivityData>, IBufferMessage
	{
		// Token: 0x0601A7D9 RID: 108505 RVA: 0x003D84D7 File Offset: 0x003D66D7
		[NullableContext(1)]
		public static TimePointRewardActivityData Create()
		{
			return new TimePointRewardActivityData();
		}

		// Token: 0x17005957 RID: 22871
		// (get) Token: 0x0601A7DA RID: 108506 RVA: 0x003D84DE File Offset: 0x003D66DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005958 RID: 22872
		// (get) Token: 0x0601A7DB RID: 108507 RVA: 0x003D84E1 File Offset: 0x003D66E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointRewardActivityData.Descriptor;
			}
		}

		// Token: 0x0601A7DC RID: 108508 RVA: 0x003D84E8 File Offset: 0x003D66E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData()
		{
		}

		// Token: 0x0601A7DD RID: 108509 RVA: 0x003D84FB File Offset: 0x003D66FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData(TimePointRewardActivityData other) : this()
		{
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7DE RID: 108510 RVA: 0x003D8525 File Offset: 0x003D6725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData Clone()
		{
			return new TimePointRewardActivityData(this);
		}

		// Token: 0x17005959 RID: 22873
		// (get) Token: 0x0601A7DF RID: 108511 RVA: 0x003D852D File Offset: 0x003D672D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTimePointRewardActivityData> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x0601A7E0 RID: 108512 RVA: 0x003D8535 File Offset: 0x003D6735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointRewardActivityData);
		}

		// Token: 0x0601A7E1 RID: 108513 RVA: 0x003D8543 File Offset: 0x003D6743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointRewardActivityData other)
		{
			return other != null && (other == this || (this.rewards_.Equals(other.rewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7E2 RID: 108514 RVA: 0x003D8578 File Offset: 0x003D6778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A7E3 RID: 108515 RVA: 0x003D85AC File Offset: 0x003D67AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7E4 RID: 108516 RVA: 0x003D85B9 File Offset: 0x003D67B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7E5 RID: 108517 RVA: 0x003D85C2 File Offset: 0x003D67C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewards_.WriteTo(ref output, TimePointRewardActivityData._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A7E6 RID: 108518 RVA: 0x003D85EC File Offset: 0x003D67EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewards_.CalculateSize(TimePointRewardActivityData._repeated_rewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A7E7 RID: 108519 RVA: 0x003D8625 File Offset: 0x003D6825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TimePointRewardActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.rewards_.Add(other.rewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A7E8 RID: 108520 RVA: 0x003D8653 File Offset: 0x003D6853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7E9 RID: 108521 RVA: 0x003D865C File Offset: 0x003D685C
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
					this.rewards_.AddEntriesFrom(ref input, TimePointRewardActivityData._repeated_rewards_codec);
				}
			}
		}

		// Token: 0x04009A23 RID: 39459
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A24 RID: 39460
		public const int RewardsFieldNumber = 1;

		// Token: 0x04009A25 RID: 39461
		private static readonly FieldCodec<OneTimePointRewardActivityData> _repeated_rewards_codec = FieldCodec.ForMessage<OneTimePointRewardActivityData>(10U, OneTimePointRewardActivityData.Parser);

		// Token: 0x04009A26 RID: 39462
		private readonly RepeatedField<OneTimePointRewardActivityData> rewards_ = new RepeatedField<OneTimePointRewardActivityData>();
	}
}
