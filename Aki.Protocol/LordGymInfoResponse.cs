using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000950 RID: 2384
	[NetMessage(EMessageId.LordGymInfoResponse)]
	public sealed class LordGymInfoResponse : IMessage<LordGymInfoResponse>, IMessage, IEquatable<LordGymInfoResponse>, IDeepCloneable<LordGymInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D269 RID: 53865 RVA: 0x001F059A File Offset: 0x001EE79A
		[NullableContext(1)]
		public static LordGymInfoResponse Create()
		{
			return new LordGymInfoResponse();
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x0600D26A RID: 53866 RVA: 0x001F05A1 File Offset: 0x001EE7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0600D26B RID: 53867 RVA: 0x001F05A4 File Offset: 0x001EE7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D26C RID: 53868 RVA: 0x001F05AB File Offset: 0x001EE7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoResponse()
		{
		}

		// Token: 0x0600D26D RID: 53869 RVA: 0x001F05EC File Offset: 0x001EE7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoResponse(LordGymInfoResponse other) : this()
		{
			this.unlockLoadGymIds_ = other.unlockLoadGymIds_.Clone();
			this.readLoadGymIds_ = other.readLoadGymIds_.Clone();
			this.lordGymPassRecords_ = other.lordGymPassRecords_.Clone();
			this.entranceInfos_ = other.entranceInfos_.Clone();
			this.lordGymGroupInfos_ = other.lordGymGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D26E RID: 53870 RVA: 0x001F0665 File Offset: 0x001EE865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoResponse Clone()
		{
			return new LordGymInfoResponse(this);
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x0600D26F RID: 53871 RVA: 0x001F066D File Offset: 0x001EE86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockLoadGymIds
		{
			get
			{
				return this.unlockLoadGymIds_;
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0600D270 RID: 53872 RVA: 0x001F0675 File Offset: 0x001EE875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadLoadGymIds
		{
			get
			{
				return this.readLoadGymIds_;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0600D271 RID: 53873 RVA: 0x001F067D File Offset: 0x001EE87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymPassRecord> LordGymPassRecords
		{
			get
			{
				return this.lordGymPassRecords_;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0600D272 RID: 53874 RVA: 0x001F0685 File Offset: 0x001EE885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymEntranceInfo> EntranceInfos
		{
			get
			{
				return this.entranceInfos_;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0600D273 RID: 53875 RVA: 0x001F068D File Offset: 0x001EE88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymGroupInfo> LordGymGroupInfos
		{
			get
			{
				return this.lordGymGroupInfos_;
			}
		}

		// Token: 0x0600D274 RID: 53876 RVA: 0x001F0695 File Offset: 0x001EE895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymInfoResponse);
		}

		// Token: 0x0600D275 RID: 53877 RVA: 0x001F06A4 File Offset: 0x001EE8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymInfoResponse other)
		{
			return other != null && (other == this || (this.unlockLoadGymIds_.Equals(other.unlockLoadGymIds_) && this.readLoadGymIds_.Equals(other.readLoadGymIds_) && this.lordGymPassRecords_.Equals(other.lordGymPassRecords_) && this.entranceInfos_.Equals(other.entranceInfos_) && this.lordGymGroupInfos_.Equals(other.lordGymGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x001F0738 File Offset: 0x001EE938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockLoadGymIds_.GetHashCode();
			num ^= this.readLoadGymIds_.GetHashCode();
			num ^= this.lordGymPassRecords_.GetHashCode();
			num ^= this.entranceInfos_.GetHashCode();
			num ^= this.lordGymGroupInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D277 RID: 53879 RVA: 0x001F07A4 File Offset: 0x001EE9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D278 RID: 53880 RVA: 0x001F07B1 File Offset: 0x001EE9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D279 RID: 53881 RVA: 0x001F07BC File Offset: 0x001EE9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entranceInfos_.WriteTo(ref output, LordGymInfoResponse._repeated_entranceInfos_codec);
			this.readLoadGymIds_.WriteTo(ref output, LordGymInfoResponse._repeated_readLoadGymIds_codec);
			this.lordGymGroupInfos_.WriteTo(ref output, LordGymInfoResponse._repeated_lordGymGroupInfos_codec);
			this.unlockLoadGymIds_.WriteTo(ref output, LordGymInfoResponse._repeated_unlockLoadGymIds_codec);
			this.lordGymPassRecords_.WriteTo(ref output, LordGymInfoResponse._repeated_lordGymPassRecords_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D27A RID: 53882 RVA: 0x001F0834 File Offset: 0x001EEA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockLoadGymIds_.CalculateSize(LordGymInfoResponse._repeated_unlockLoadGymIds_codec);
			num += this.readLoadGymIds_.CalculateSize(LordGymInfoResponse._repeated_readLoadGymIds_codec);
			num += this.lordGymPassRecords_.CalculateSize(LordGymInfoResponse._repeated_lordGymPassRecords_codec);
			num += this.entranceInfos_.CalculateSize(LordGymInfoResponse._repeated_entranceInfos_codec);
			num += this.lordGymGroupInfos_.CalculateSize(LordGymInfoResponse._repeated_lordGymGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D27B RID: 53883 RVA: 0x001F08BC File Offset: 0x001EEABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockLoadGymIds_.Add(other.unlockLoadGymIds_);
			this.readLoadGymIds_.Add(other.readLoadGymIds_);
			this.lordGymPassRecords_.Add(other.lordGymPassRecords_);
			this.entranceInfos_.Add(other.entranceInfos_);
			this.lordGymGroupInfos_.Add(other.lordGymGroupInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D27C RID: 53884 RVA: 0x001F0939 File Offset: 0x001EEB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D27D RID: 53885 RVA: 0x001F0944 File Offset: 0x001EEB44
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
				if (num > 90U)
				{
					if (num <= 104U)
					{
						if (num == 98U)
						{
							this.lordGymGroupInfos_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_lordGymGroupInfos_codec);
							continue;
						}
						if (num != 104U)
						{
							goto IL_3D;
						}
					}
					else if (num != 106U)
					{
						if (num != 122U)
						{
							goto IL_3D;
						}
						this.lordGymPassRecords_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_lordGymPassRecords_codec);
						continue;
					}
					this.unlockLoadGymIds_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_unlockLoadGymIds_codec);
					continue;
				}
				if (num == 42U)
				{
					this.entranceInfos_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_entranceInfos_codec);
					continue;
				}
				if (num == 88U || num == 90U)
				{
					this.readLoadGymIds_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_readLoadGymIds_codec);
					continue;
				}
				IL_3D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058E1 RID: 22753
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058E2 RID: 22754
		public const int UnlockLoadGymIdsFieldNumber = 13;

		// Token: 0x040058E3 RID: 22755
		private static readonly FieldCodec<int> _repeated_unlockLoadGymIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040058E4 RID: 22756
		private readonly RepeatedField<int> unlockLoadGymIds_ = new RepeatedField<int>();

		// Token: 0x040058E5 RID: 22757
		public const int ReadLoadGymIdsFieldNumber = 11;

		// Token: 0x040058E6 RID: 22758
		private static readonly FieldCodec<int> _repeated_readLoadGymIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x040058E7 RID: 22759
		private readonly RepeatedField<int> readLoadGymIds_ = new RepeatedField<int>();

		// Token: 0x040058E8 RID: 22760
		public const int LordGymPassRecordsFieldNumber = 15;

		// Token: 0x040058E9 RID: 22761
		private static readonly FieldCodec<LordGymPassRecord> _repeated_lordGymPassRecords_codec = FieldCodec.ForMessage<LordGymPassRecord>(122U, LordGymPassRecord.Parser);

		// Token: 0x040058EA RID: 22762
		private readonly RepeatedField<LordGymPassRecord> lordGymPassRecords_ = new RepeatedField<LordGymPassRecord>();

		// Token: 0x040058EB RID: 22763
		public const int EntranceInfosFieldNumber = 5;

		// Token: 0x040058EC RID: 22764
		private static readonly FieldCodec<LordGymEntranceInfo> _repeated_entranceInfos_codec = FieldCodec.ForMessage<LordGymEntranceInfo>(42U, LordGymEntranceInfo.Parser);

		// Token: 0x040058ED RID: 22765
		private readonly RepeatedField<LordGymEntranceInfo> entranceInfos_ = new RepeatedField<LordGymEntranceInfo>();

		// Token: 0x040058EE RID: 22766
		public const int LordGymGroupInfosFieldNumber = 12;

		// Token: 0x040058EF RID: 22767
		private static readonly FieldCodec<LordGymGroupInfo> _repeated_lordGymGroupInfos_codec = FieldCodec.ForMessage<LordGymGroupInfo>(98U, LordGymGroupInfo.Parser);

		// Token: 0x040058F0 RID: 22768
		private readonly RepeatedField<LordGymGroupInfo> lordGymGroupInfos_ = new RepeatedField<LordGymGroupInfo>();
	}
}
