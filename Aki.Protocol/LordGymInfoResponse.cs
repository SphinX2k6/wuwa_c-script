using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000961 RID: 2401
	[NetMessage(EMessageId.LordGymInfoResponse)]
	public sealed class LordGymInfoResponse : IMessage<LordGymInfoResponse>, IMessage, IEquatable<LordGymInfoResponse>, IDeepCloneable<LordGymInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D383 RID: 54147 RVA: 0x001F277E File Offset: 0x001F097E
		[NullableContext(1)]
		public static LordGymInfoResponse Create()
		{
			return new LordGymInfoResponse();
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x0600D384 RID: 54148 RVA: 0x001F2785 File Offset: 0x001F0985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x0600D385 RID: 54149 RVA: 0x001F2788 File Offset: 0x001F0988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D386 RID: 54150 RVA: 0x001F278F File Offset: 0x001F098F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoResponse()
		{
		}

		// Token: 0x0600D387 RID: 54151 RVA: 0x001F27D0 File Offset: 0x001F09D0
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

		// Token: 0x0600D388 RID: 54152 RVA: 0x001F2849 File Offset: 0x001F0A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymInfoResponse Clone()
		{
			return new LordGymInfoResponse(this);
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x0600D389 RID: 54153 RVA: 0x001F2851 File Offset: 0x001F0A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockLoadGymIds
		{
			get
			{
				return this.unlockLoadGymIds_;
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x0600D38A RID: 54154 RVA: 0x001F2859 File Offset: 0x001F0A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ReadLoadGymIds
		{
			get
			{
				return this.readLoadGymIds_;
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x0600D38B RID: 54155 RVA: 0x001F2861 File Offset: 0x001F0A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymPassRecord> LordGymPassRecords
		{
			get
			{
				return this.lordGymPassRecords_;
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0600D38C RID: 54156 RVA: 0x001F2869 File Offset: 0x001F0A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymEntranceInfo> EntranceInfos
		{
			get
			{
				return this.entranceInfos_;
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0600D38D RID: 54157 RVA: 0x001F2871 File Offset: 0x001F0A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LordGymGroupInfo> LordGymGroupInfos
		{
			get
			{
				return this.lordGymGroupInfos_;
			}
		}

		// Token: 0x0600D38E RID: 54158 RVA: 0x001F2879 File Offset: 0x001F0A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymInfoResponse);
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x001F2888 File Offset: 0x001F0A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymInfoResponse other)
		{
			return other != null && (other == this || (this.unlockLoadGymIds_.Equals(other.unlockLoadGymIds_) && this.readLoadGymIds_.Equals(other.readLoadGymIds_) && this.lordGymPassRecords_.Equals(other.lordGymPassRecords_) && this.entranceInfos_.Equals(other.entranceInfos_) && this.lordGymGroupInfos_.Equals(other.lordGymGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D390 RID: 54160 RVA: 0x001F291C File Offset: 0x001F0B1C
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

		// Token: 0x0600D391 RID: 54161 RVA: 0x001F2988 File Offset: 0x001F0B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D392 RID: 54162 RVA: 0x001F2995 File Offset: 0x001F0B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D393 RID: 54163 RVA: 0x001F29A0 File Offset: 0x001F0BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lordGymGroupInfos_.WriteTo(ref output, LordGymInfoResponse._repeated_lordGymGroupInfos_codec);
			this.readLoadGymIds_.WriteTo(ref output, LordGymInfoResponse._repeated_readLoadGymIds_codec);
			this.entranceInfos_.WriteTo(ref output, LordGymInfoResponse._repeated_entranceInfos_codec);
			this.lordGymPassRecords_.WriteTo(ref output, LordGymInfoResponse._repeated_lordGymPassRecords_codec);
			this.unlockLoadGymIds_.WriteTo(ref output, LordGymInfoResponse._repeated_unlockLoadGymIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D394 RID: 54164 RVA: 0x001F2A18 File Offset: 0x001F0C18
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

		// Token: 0x0600D395 RID: 54165 RVA: 0x001F2AA0 File Offset: 0x001F0CA0
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

		// Token: 0x0600D396 RID: 54166 RVA: 0x001F2B1D File Offset: 0x001F0D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D397 RID: 54167 RVA: 0x001F2B28 File Offset: 0x001F0D28
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
				if (num <= 34U)
				{
					if (num == 10U)
					{
						this.lordGymGroupInfos_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_lordGymGroupInfos_codec);
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.readLoadGymIds_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_readLoadGymIds_codec);
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 50U)
					{
						this.entranceInfos_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_entranceInfos_codec);
						continue;
					}
					if (num == 98U)
					{
						this.lordGymPassRecords_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_lordGymPassRecords_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.unlockLoadGymIds_.AddEntriesFrom(ref input, LordGymInfoResponse._repeated_unlockLoadGymIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058D8 RID: 22744
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058D9 RID: 22745
		public const int UnlockLoadGymIdsFieldNumber = 15;

		// Token: 0x040058DA RID: 22746
		private static readonly FieldCodec<int> _repeated_unlockLoadGymIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040058DB RID: 22747
		private readonly RepeatedField<int> unlockLoadGymIds_ = new RepeatedField<int>();

		// Token: 0x040058DC RID: 22748
		public const int ReadLoadGymIdsFieldNumber = 4;

		// Token: 0x040058DD RID: 22749
		private static readonly FieldCodec<int> _repeated_readLoadGymIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040058DE RID: 22750
		private readonly RepeatedField<int> readLoadGymIds_ = new RepeatedField<int>();

		// Token: 0x040058DF RID: 22751
		public const int LordGymPassRecordsFieldNumber = 12;

		// Token: 0x040058E0 RID: 22752
		private static readonly FieldCodec<LordGymPassRecord> _repeated_lordGymPassRecords_codec = FieldCodec.ForMessage<LordGymPassRecord>(98U, LordGymPassRecord.Parser);

		// Token: 0x040058E1 RID: 22753
		private readonly RepeatedField<LordGymPassRecord> lordGymPassRecords_ = new RepeatedField<LordGymPassRecord>();

		// Token: 0x040058E2 RID: 22754
		public const int EntranceInfosFieldNumber = 6;

		// Token: 0x040058E3 RID: 22755
		private static readonly FieldCodec<LordGymEntranceInfo> _repeated_entranceInfos_codec = FieldCodec.ForMessage<LordGymEntranceInfo>(50U, LordGymEntranceInfo.Parser);

		// Token: 0x040058E4 RID: 22756
		private readonly RepeatedField<LordGymEntranceInfo> entranceInfos_ = new RepeatedField<LordGymEntranceInfo>();

		// Token: 0x040058E5 RID: 22757
		public const int LordGymGroupInfosFieldNumber = 1;

		// Token: 0x040058E6 RID: 22758
		private static readonly FieldCodec<LordGymGroupInfo> _repeated_lordGymGroupInfos_codec = FieldCodec.ForMessage<LordGymGroupInfo>(10U, LordGymGroupInfo.Parser);

		// Token: 0x040058E7 RID: 22759
		private readonly RepeatedField<LordGymGroupInfo> lordGymGroupInfos_ = new RepeatedField<LordGymGroupInfo>();
	}
}
