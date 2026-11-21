using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A04 RID: 2564
	public sealed class MoraleActivityData : IMessage<MoraleActivityData>, IMessage, IEquatable<MoraleActivityData>, IDeepCloneable<MoraleActivityData>, IBufferMessage
	{
		// Token: 0x0600E0A2 RID: 57506 RVA: 0x0020EC92 File Offset: 0x0020CE92
		[NullableContext(1)]
		public static MoraleActivityData Create()
		{
			return new MoraleActivityData();
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600E0A3 RID: 57507 RVA: 0x0020EC99 File Offset: 0x0020CE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x0020EC9C File Offset: 0x0020CE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleActivityData.Descriptor;
			}
		}

		// Token: 0x0600E0A5 RID: 57509 RVA: 0x0020ECA3 File Offset: 0x0020CEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleActivityData()
		{
		}

		// Token: 0x0600E0A6 RID: 57510 RVA: 0x0020ECCC File Offset: 0x0020CECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleActivityData(MoraleActivityData other) : this()
		{
			this.moraleAreaInfos_ = other.moraleAreaInfos_.Clone();
			this.rewardedIds_ = other.rewardedIds_.Clone();
			this.flagToBoxInfos_ = other.flagToBoxInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0A7 RID: 57511 RVA: 0x0020ED23 File Offset: 0x0020CF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleActivityData Clone()
		{
			return new MoraleActivityData(this);
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x0020ED2B File Offset: 0x0020CF2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MoraleAreaInfo> MoraleAreaInfos
		{
			get
			{
				return this.moraleAreaInfos_;
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x0020ED33 File Offset: 0x0020CF33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardedIds
		{
			get
			{
				return this.rewardedIds_;
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600E0AA RID: 57514 RVA: 0x0020ED3B File Offset: 0x0020CF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FlagToBoxInfo> FlagToBoxInfos
		{
			get
			{
				return this.flagToBoxInfos_;
			}
		}

		// Token: 0x0600E0AB RID: 57515 RVA: 0x0020ED43 File Offset: 0x0020CF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleActivityData);
		}

		// Token: 0x0600E0AC RID: 57516 RVA: 0x0020ED54 File Offset: 0x0020CF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleActivityData other)
		{
			return other != null && (other == this || (this.moraleAreaInfos_.Equals(other.moraleAreaInfos_) && this.rewardedIds_.Equals(other.rewardedIds_) && this.flagToBoxInfos_.Equals(other.flagToBoxInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0AD RID: 57517 RVA: 0x0020EDBC File Offset: 0x0020CFBC
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

		// Token: 0x0600E0AE RID: 57518 RVA: 0x0020EE0C File Offset: 0x0020D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0AF RID: 57519 RVA: 0x0020EE19 File Offset: 0x0020D019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0B0 RID: 57520 RVA: 0x0020EE24 File Offset: 0x0020D024
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

		// Token: 0x0600E0B1 RID: 57521 RVA: 0x0020EE78 File Offset: 0x0020D078
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

		// Token: 0x0600E0B2 RID: 57522 RVA: 0x0020EED8 File Offset: 0x0020D0D8
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

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x0020EF33 File Offset: 0x0020D133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x0020EF3C File Offset: 0x0020D13C
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

		// Token: 0x04005CC2 RID: 23746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CC3 RID: 23747
		public const int MoraleAreaInfosFieldNumber = 1;

		// Token: 0x04005CC4 RID: 23748
		private static readonly FieldCodec<MoraleAreaInfo> _repeated_moraleAreaInfos_codec = FieldCodec.ForMessage<MoraleAreaInfo>(10U, MoraleAreaInfo.Parser);

		// Token: 0x04005CC5 RID: 23749
		private readonly RepeatedField<MoraleAreaInfo> moraleAreaInfos_ = new RepeatedField<MoraleAreaInfo>();

		// Token: 0x04005CC6 RID: 23750
		public const int RewardedIdsFieldNumber = 2;

		// Token: 0x04005CC7 RID: 23751
		private static readonly FieldCodec<int> _repeated_rewardedIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005CC8 RID: 23752
		private readonly RepeatedField<int> rewardedIds_ = new RepeatedField<int>();

		// Token: 0x04005CC9 RID: 23753
		public const int FlagToBoxInfosFieldNumber = 4;

		// Token: 0x04005CCA RID: 23754
		private static readonly FieldCodec<FlagToBoxInfo> _repeated_flagToBoxInfos_codec = FieldCodec.ForMessage<FlagToBoxInfo>(34U, FlagToBoxInfo.Parser);

		// Token: 0x04005CCB RID: 23755
		private readonly RepeatedField<FlagToBoxInfo> flagToBoxInfos_ = new RepeatedField<FlagToBoxInfo>();
	}
}
