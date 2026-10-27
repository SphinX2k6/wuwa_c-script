using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F3 RID: 1779
	public sealed class GivebackOldHistoryRedisPb : IMessage<GivebackOldHistoryRedisPb>, IMessage, IEquatable<GivebackOldHistoryRedisPb>, IDeepCloneable<GivebackOldHistoryRedisPb>, IBufferMessage
	{
		// Token: 0x0600A21F RID: 41503 RVA: 0x0018812E File Offset: 0x0018632E
		[NullableContext(1)]
		public static GivebackOldHistoryRedisPb Create()
		{
			return new GivebackOldHistoryRedisPb();
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x0600A220 RID: 41504 RVA: 0x00188135 File Offset: 0x00186335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x00188138 File Offset: 0x00186338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackOldHistoryRedisPb.Descriptor;
			}
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x0018813F File Offset: 0x0018633F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackOldHistoryRedisPb()
		{
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x00188168 File Offset: 0x00186368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackOldHistoryRedisPb(GivebackOldHistoryRedisPb other) : this()
		{
			this.maxContinueLogin_ = other.maxContinueLogin_;
			this.continueLoginEndAtVer3_ = other.continueLoginEndAtVer3_;
			this.onlineTotalTime_ = other.onlineTotalTime_;
			this.role5StarGachaCount_ = other.role5StarGachaCount_;
			this.weapon5StarGachaCount_ = other.weapon5StarGachaCount_;
			this.mainRoleActiveTime_ = other.mainRoleActiveTime_.Clone();
			this.normalItemHistoryRecords_ = other.normalItemHistoryRecords_.Clone();
			this.mainQuestFinishAt_ = other.mainQuestFinishAt_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x001881FB File Offset: 0x001863FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackOldHistoryRedisPb Clone()
		{
			return new GivebackOldHistoryRedisPb(this);
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x0600A225 RID: 41509 RVA: 0x00188203 File Offset: 0x00186403
		// (set) Token: 0x0600A226 RID: 41510 RVA: 0x0018820B File Offset: 0x0018640B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxContinueLogin
		{
			get
			{
				return this.maxContinueLogin_;
			}
			set
			{
				this.maxContinueLogin_ = value;
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x0600A227 RID: 41511 RVA: 0x00188214 File Offset: 0x00186414
		// (set) Token: 0x0600A228 RID: 41512 RVA: 0x0018821C File Offset: 0x0018641C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ContinueLoginEndAtVer3
		{
			get
			{
				return this.continueLoginEndAtVer3_;
			}
			set
			{
				this.continueLoginEndAtVer3_ = value;
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x0600A229 RID: 41513 RVA: 0x00188225 File Offset: 0x00186425
		// (set) Token: 0x0600A22A RID: 41514 RVA: 0x0018822D File Offset: 0x0018642D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OnlineTotalTime
		{
			get
			{
				return this.onlineTotalTime_;
			}
			set
			{
				this.onlineTotalTime_ = value;
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x0600A22B RID: 41515 RVA: 0x00188236 File Offset: 0x00186436
		// (set) Token: 0x0600A22C RID: 41516 RVA: 0x0018823E File Offset: 0x0018643E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Role5StarGachaCount
		{
			get
			{
				return this.role5StarGachaCount_;
			}
			set
			{
				this.role5StarGachaCount_ = value;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x0600A22D RID: 41517 RVA: 0x00188247 File Offset: 0x00186447
		// (set) Token: 0x0600A22E RID: 41518 RVA: 0x0018824F File Offset: 0x0018644F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Weapon5StarGachaCount
		{
			get
			{
				return this.weapon5StarGachaCount_;
			}
			set
			{
				this.weapon5StarGachaCount_ = value;
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x0600A22F RID: 41519 RVA: 0x00188258 File Offset: 0x00186458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GivebackMainRoleActiveTimePb> MainRoleActiveTime
		{
			get
			{
				return this.mainRoleActiveTime_;
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600A230 RID: 41520 RVA: 0x00188260 File Offset: 0x00186460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GivebackNormalItemHistoryRecordPb> NormalItemHistoryRecords
		{
			get
			{
				return this.normalItemHistoryRecords_;
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x0600A231 RID: 41521 RVA: 0x00188268 File Offset: 0x00186468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> MainQuestFinishAt
		{
			get
			{
				return this.mainQuestFinishAt_;
			}
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x00188270 File Offset: 0x00186470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackOldHistoryRedisPb);
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x00188280 File Offset: 0x00186480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackOldHistoryRedisPb other)
		{
			return other != null && (other == this || (this.MaxContinueLogin == other.MaxContinueLogin && this.ContinueLoginEndAtVer3 == other.ContinueLoginEndAtVer3 && this.OnlineTotalTime == other.OnlineTotalTime && this.Role5StarGachaCount == other.Role5StarGachaCount && this.Weapon5StarGachaCount == other.Weapon5StarGachaCount && this.mainRoleActiveTime_.Equals(other.mainRoleActiveTime_) && this.normalItemHistoryRecords_.Equals(other.normalItemHistoryRecords_) && this.MainQuestFinishAt.Equals(other.MainQuestFinishAt) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x00188338 File Offset: 0x00186538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxContinueLogin != 0)
			{
				num ^= this.MaxContinueLogin.GetHashCode();
			}
			if (this.ContinueLoginEndAtVer3 != 0)
			{
				num ^= this.ContinueLoginEndAtVer3.GetHashCode();
			}
			if (this.OnlineTotalTime != 0)
			{
				num ^= this.OnlineTotalTime.GetHashCode();
			}
			if (this.Role5StarGachaCount != 0)
			{
				num ^= this.Role5StarGachaCount.GetHashCode();
			}
			if (this.Weapon5StarGachaCount != 0)
			{
				num ^= this.Weapon5StarGachaCount.GetHashCode();
			}
			num ^= this.mainRoleActiveTime_.GetHashCode();
			num ^= this.normalItemHistoryRecords_.GetHashCode();
			num ^= this.MainQuestFinishAt.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x00188405 File Offset: 0x00186605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x00188412 File Offset: 0x00186612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x0018841C File Offset: 0x0018661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxContinueLogin != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxContinueLogin);
			}
			if (this.ContinueLoginEndAtVer3 != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ContinueLoginEndAtVer3);
			}
			if (this.OnlineTotalTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.OnlineTotalTime);
			}
			if (this.Role5StarGachaCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Role5StarGachaCount);
			}
			if (this.Weapon5StarGachaCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Weapon5StarGachaCount);
			}
			this.mainRoleActiveTime_.WriteTo(ref output, GivebackOldHistoryRedisPb._repeated_mainRoleActiveTime_codec);
			this.normalItemHistoryRecords_.WriteTo(ref output, GivebackOldHistoryRedisPb._repeated_normalItemHistoryRecords_codec);
			this.mainQuestFinishAt_.WriteTo(ref output, GivebackOldHistoryRedisPb._map_mainQuestFinishAt_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x001884FC File Offset: 0x001866FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxContinueLogin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxContinueLogin);
			}
			if (this.ContinueLoginEndAtVer3 != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ContinueLoginEndAtVer3);
			}
			if (this.OnlineTotalTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OnlineTotalTime);
			}
			if (this.Role5StarGachaCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Role5StarGachaCount);
			}
			if (this.Weapon5StarGachaCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Weapon5StarGachaCount);
			}
			num += this.mainRoleActiveTime_.CalculateSize(GivebackOldHistoryRedisPb._repeated_mainRoleActiveTime_codec);
			num += this.normalItemHistoryRecords_.CalculateSize(GivebackOldHistoryRedisPb._repeated_normalItemHistoryRecords_codec);
			num += this.mainQuestFinishAt_.CalculateSize(GivebackOldHistoryRedisPb._map_mainQuestFinishAt_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x001885D4 File Offset: 0x001867D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackOldHistoryRedisPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxContinueLogin != 0)
			{
				this.MaxContinueLogin = other.MaxContinueLogin;
			}
			if (other.ContinueLoginEndAtVer3 != 0)
			{
				this.ContinueLoginEndAtVer3 = other.ContinueLoginEndAtVer3;
			}
			if (other.OnlineTotalTime != 0)
			{
				this.OnlineTotalTime = other.OnlineTotalTime;
			}
			if (other.Role5StarGachaCount != 0)
			{
				this.Role5StarGachaCount = other.Role5StarGachaCount;
			}
			if (other.Weapon5StarGachaCount != 0)
			{
				this.Weapon5StarGachaCount = other.Weapon5StarGachaCount;
			}
			this.mainRoleActiveTime_.Add(other.mainRoleActiveTime_);
			this.normalItemHistoryRecords_.Add(other.normalItemHistoryRecords_);
			this.mainQuestFinishAt_.MergeFrom(other.mainQuestFinishAt_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x00188693 File Offset: 0x00186893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x0018869C File Offset: 0x0018689C
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.MaxContinueLogin = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.ContinueLoginEndAtVer3 = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.OnlineTotalTime = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.Role5StarGachaCount = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.Weapon5StarGachaCount = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						this.mainRoleActiveTime_.AddEntriesFrom(ref input, GivebackOldHistoryRedisPb._repeated_mainRoleActiveTime_codec);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.normalItemHistoryRecords_.AddEntriesFrom(ref input, GivebackOldHistoryRedisPb._repeated_normalItemHistoryRecords_codec);
						continue;
					}
					if (num == 66U)
					{
						this.mainQuestFinishAt_.AddEntriesFrom(ref input, GivebackOldHistoryRedisPb._map_mainQuestFinishAt_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004B29 RID: 19241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B2A RID: 19242
		public const int MaxContinueLoginFieldNumber = 1;

		// Token: 0x04004B2B RID: 19243
		private int maxContinueLogin_;

		// Token: 0x04004B2C RID: 19244
		public const int ContinueLoginEndAtVer3FieldNumber = 2;

		// Token: 0x04004B2D RID: 19245
		private int continueLoginEndAtVer3_;

		// Token: 0x04004B2E RID: 19246
		public const int OnlineTotalTimeFieldNumber = 3;

		// Token: 0x04004B2F RID: 19247
		private int onlineTotalTime_;

		// Token: 0x04004B30 RID: 19248
		public const int Role5StarGachaCountFieldNumber = 4;

		// Token: 0x04004B31 RID: 19249
		private int role5StarGachaCount_;

		// Token: 0x04004B32 RID: 19250
		public const int Weapon5StarGachaCountFieldNumber = 5;

		// Token: 0x04004B33 RID: 19251
		private int weapon5StarGachaCount_;

		// Token: 0x04004B34 RID: 19252
		public const int MainRoleActiveTimeFieldNumber = 6;

		// Token: 0x04004B35 RID: 19253
		private static readonly FieldCodec<GivebackMainRoleActiveTimePb> _repeated_mainRoleActiveTime_codec = FieldCodec.ForMessage<GivebackMainRoleActiveTimePb>(50U, GivebackMainRoleActiveTimePb.Parser);

		// Token: 0x04004B36 RID: 19254
		private readonly RepeatedField<GivebackMainRoleActiveTimePb> mainRoleActiveTime_ = new RepeatedField<GivebackMainRoleActiveTimePb>();

		// Token: 0x04004B37 RID: 19255
		public const int NormalItemHistoryRecordsFieldNumber = 7;

		// Token: 0x04004B38 RID: 19256
		private static readonly FieldCodec<GivebackNormalItemHistoryRecordPb> _repeated_normalItemHistoryRecords_codec = FieldCodec.ForMessage<GivebackNormalItemHistoryRecordPb>(58U, GivebackNormalItemHistoryRecordPb.Parser);

		// Token: 0x04004B39 RID: 19257
		private readonly RepeatedField<GivebackNormalItemHistoryRecordPb> normalItemHistoryRecords_ = new RepeatedField<GivebackNormalItemHistoryRecordPb>();

		// Token: 0x04004B3A RID: 19258
		public const int MainQuestFinishAtFieldNumber = 8;

		// Token: 0x04004B3B RID: 19259
		private static readonly MapField<int, long>.Codec _map_mainQuestFinishAt_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 66U);

		// Token: 0x04004B3C RID: 19260
		private readonly MapField<int, long> mainQuestFinishAt_ = new MapField<int, long>();
	}
}
