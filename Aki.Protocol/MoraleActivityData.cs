using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A15 RID: 2581
	public sealed class MoraleActivityData : IMessage<MoraleActivityData>, IMessage, IEquatable<MoraleActivityData>, IDeepCloneable<MoraleActivityData>, IBufferMessage
	{
		// Token: 0x0600E1BC RID: 57788 RVA: 0x00210E86 File Offset: 0x0020F086
		[NullableContext(1)]
		public static MoraleActivityData Create()
		{
			return new MoraleActivityData();
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600E1BD RID: 57789 RVA: 0x00210E8D File Offset: 0x0020F08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x0600E1BE RID: 57790 RVA: 0x00210E90 File Offset: 0x0020F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleActivityData.Descriptor;
			}
		}

		// Token: 0x0600E1BF RID: 57791 RVA: 0x00210E97 File Offset: 0x0020F097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleActivityData()
		{
		}

		// Token: 0x0600E1C0 RID: 57792 RVA: 0x00210EC0 File Offset: 0x0020F0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleActivityData(MoraleActivityData other) : this()
		{
			this.moraleAreaInfos_ = other.moraleAreaInfos_.Clone();
			this.rewardedIds_ = other.rewardedIds_.Clone();
			this.flagToBoxInfos_ = other.flagToBoxInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1C1 RID: 57793 RVA: 0x00210F17 File Offset: 0x0020F117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleActivityData Clone()
		{
			return new MoraleActivityData(this);
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600E1C2 RID: 57794 RVA: 0x00210F1F File Offset: 0x0020F11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoraleAreaInfo> MoraleAreaInfos
		{
			get
			{
				return this.moraleAreaInfos_;
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0600E1C3 RID: 57795 RVA: 0x00210F27 File Offset: 0x0020F127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedIds
		{
			get
			{
				return this.rewardedIds_;
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0600E1C4 RID: 57796 RVA: 0x00210F2F File Offset: 0x0020F12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagToBoxInfo> FlagToBoxInfos
		{
			get
			{
				return this.flagToBoxInfos_;
			}
		}

		// Token: 0x0600E1C5 RID: 57797 RVA: 0x00210F37 File Offset: 0x0020F137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleActivityData);
		}

		// Token: 0x0600E1C6 RID: 57798 RVA: 0x00210F48 File Offset: 0x0020F148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleActivityData other)
		{
			return other != null && (other == this || (this.moraleAreaInfos_.Equals(other.moraleAreaInfos_) && this.rewardedIds_.Equals(other.rewardedIds_) && this.flagToBoxInfos_.Equals(other.flagToBoxInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1C7 RID: 57799 RVA: 0x00210FB0 File Offset: 0x0020F1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.moraleAreaInfos_.GetHashCode();
			num ^= this.rewardedIds_.GetHashCode();
			num ^= this.flagToBoxInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E1C8 RID: 57800 RVA: 0x00211000 File Offset: 0x0020F200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1C9 RID: 57801 RVA: 0x0021100D File Offset: 0x0020F20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1CA RID: 57802 RVA: 0x00211018 File Offset: 0x0020F218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.moraleAreaInfos_.WriteTo(ref output, MoraleActivityData._repeated_moraleAreaInfos_codec);
			this.rewardedIds_.WriteTo(ref output, MoraleActivityData._repeated_rewardedIds_codec);
			this.flagToBoxInfos_.WriteTo(ref output, MoraleActivityData._repeated_flagToBoxInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E1CB RID: 57803 RVA: 0x0021106C File Offset: 0x0020F26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.moraleAreaInfos_.CalculateSize(MoraleActivityData._repeated_moraleAreaInfos_codec);
			num += this.rewardedIds_.CalculateSize(MoraleActivityData._repeated_rewardedIds_codec);
			num += this.flagToBoxInfos_.CalculateSize(MoraleActivityData._repeated_flagToBoxInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E1CC RID: 57804 RVA: 0x002110CC File Offset: 0x0020F2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.moraleAreaInfos_.Add(other.moraleAreaInfos_);
			this.rewardedIds_.Add(other.rewardedIds_);
			this.flagToBoxInfos_.Add(other.flagToBoxInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x00211127 File Offset: 0x0020F327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1CE RID: 57806 RVA: 0x00211130 File Offset: 0x0020F330
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.moraleAreaInfos_.AddEntriesFrom(ref input, MoraleActivityData._repeated_moraleAreaInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_4B;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4B;
					}
					if (num == 34U)
					{
						this.flagToBoxInfos_.AddEntriesFrom(ref input, MoraleActivityData._repeated_flagToBoxInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4B:
				this.rewardedIds_.AddEntriesFrom(ref input, MoraleActivityData._repeated_rewardedIds_codec);
			}
		}

		// Token: 0x04005CB9 RID: 23737
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CBA RID: 23738
		public const int MoraleAreaInfosFieldNumber = 1;

		// Token: 0x04005CBB RID: 23739
		private static readonly FieldCodec<MoraleAreaInfo> _repeated_moraleAreaInfos_codec = FieldCodec.ForMessage<MoraleAreaInfo>(10U, MoraleAreaInfo.Parser);

		// Token: 0x04005CBC RID: 23740
		private readonly RepeatedField<MoraleAreaInfo> moraleAreaInfos_ = new RepeatedField<MoraleAreaInfo>();

		// Token: 0x04005CBD RID: 23741
		public const int RewardedIdsFieldNumber = 2;

		// Token: 0x04005CBE RID: 23742
		private static readonly FieldCodec<int> _repeated_rewardedIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005CBF RID: 23743
		private readonly RepeatedField<int> rewardedIds_ = new RepeatedField<int>();

		// Token: 0x04005CC0 RID: 23744
		public const int FlagToBoxInfosFieldNumber = 4;

		// Token: 0x04005CC1 RID: 23745
		private static readonly FieldCodec<FlagToBoxInfo> _repeated_flagToBoxInfos_codec = FieldCodec.ForMessage<FlagToBoxInfo>(34U, FlagToBoxInfo.Parser);

		// Token: 0x04005CC2 RID: 23746
		private readonly RepeatedField<FlagToBoxInfo> flagToBoxInfos_ = new RepeatedField<FlagToBoxInfo>();
	}
}
