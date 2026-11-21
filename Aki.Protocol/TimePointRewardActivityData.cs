using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F1 RID: 5105
	public sealed class TimePointRewardActivityData : IMessage<TimePointRewardActivityData>, IMessage, IEquatable<TimePointRewardActivityData>, IDeepCloneable<TimePointRewardActivityData>, IBufferMessage
	{
		// Token: 0x0601B262 RID: 111202 RVA: 0x003F36EB File Offset: 0x003F18EB
		[NullableContext(1)]
		public static TimePointRewardActivityData Create()
		{
			return new TimePointRewardActivityData();
		}

		// Token: 0x17005BEB RID: 23531
		// (get) Token: 0x0601B263 RID: 111203 RVA: 0x003F36F2 File Offset: 0x003F18F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BEC RID: 23532
		// (get) Token: 0x0601B264 RID: 111204 RVA: 0x003F36F5 File Offset: 0x003F18F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TimePointRewardActivityData.Descriptor;
			}
		}

		// Token: 0x0601B265 RID: 111205 RVA: 0x003F36FC File Offset: 0x003F18FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData()
		{
		}

		// Token: 0x0601B266 RID: 111206 RVA: 0x003F370F File Offset: 0x003F190F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData(TimePointRewardActivityData other) : this()
		{
			this.rewards_ = other.rewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B267 RID: 111207 RVA: 0x003F3739 File Offset: 0x003F1939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimePointRewardActivityData Clone()
		{
			return new TimePointRewardActivityData(this);
		}

		// Token: 0x17005BED RID: 23533
		// (get) Token: 0x0601B268 RID: 111208 RVA: 0x003F3741 File Offset: 0x003F1941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTimePointRewardActivityData> Rewards
		{
			get
			{
				return this.rewards_;
			}
		}

		// Token: 0x0601B269 RID: 111209 RVA: 0x003F3749 File Offset: 0x003F1949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TimePointRewardActivityData);
		}

		// Token: 0x0601B26A RID: 111210 RVA: 0x003F3757 File Offset: 0x003F1957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TimePointRewardActivityData other)
		{
			return other != null && (other == this || (this.rewards_.Equals(other.rewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B26B RID: 111211 RVA: 0x003F378C File Offset: 0x003F198C
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

		// Token: 0x0601B26C RID: 111212 RVA: 0x003F37C0 File Offset: 0x003F19C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B26D RID: 111213 RVA: 0x003F37CD File Offset: 0x003F19CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B26E RID: 111214 RVA: 0x003F37D6 File Offset: 0x003F19D6
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

		// Token: 0x0601B26F RID: 111215 RVA: 0x003F3800 File Offset: 0x003F1A00
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

		// Token: 0x0601B270 RID: 111216 RVA: 0x003F3839 File Offset: 0x003F1A39
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

		// Token: 0x0601B271 RID: 111217 RVA: 0x003F3867 File Offset: 0x003F1A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B272 RID: 111218 RVA: 0x003F3870 File Offset: 0x003F1A70
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

		// Token: 0x04009E68 RID: 40552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E69 RID: 40553
		public const int RewardsFieldNumber = 1;

		// Token: 0x04009E6A RID: 40554
		private static readonly FieldCodec<OneTimePointRewardActivityData> _repeated_rewards_codec = FieldCodec.ForMessage<OneTimePointRewardActivityData>(10U, OneTimePointRewardActivityData.Parser);

		// Token: 0x04009E6B RID: 40555
		private readonly RepeatedField<OneTimePointRewardActivityData> rewards_ = new RepeatedField<OneTimePointRewardActivityData>();
	}
}
