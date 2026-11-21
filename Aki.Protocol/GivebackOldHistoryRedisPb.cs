using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DF RID: 1759
	public sealed class GivebackOldHistoryRedisPb : IMessage<GivebackOldHistoryRedisPb>, IMessage, IEquatable<GivebackOldHistoryRedisPb>, IDeepCloneable<GivebackOldHistoryRedisPb>, IBufferMessage
	{
		// Token: 0x0600A0C9 RID: 41161 RVA: 0x001856FA File Offset: 0x001838FA
		[NullableContext(1)]
		public static GivebackOldHistoryRedisPb Create()
		{
			return new GivebackOldHistoryRedisPb();
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x0600A0CA RID: 41162 RVA: 0x00185701 File Offset: 0x00183901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x00185704 File Offset: 0x00183904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackOldHistoryRedisPb.Descriptor;
			}
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x0018570B File Offset: 0x0018390B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackOldHistoryRedisPb()
		{
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x00185734 File Offset: 0x00183934
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

		// Token: 0x0600A0CE RID: 41166 RVA: 0x001857C7 File Offset: 0x001839C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackOldHistoryRedisPb Clone()
		{
			return new GivebackOldHistoryRedisPb(this);
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x0600A0CF RID: 41167 RVA: 0x001857CF File Offset: 0x001839CF
		// (set) Token: 0x0600A0D0 RID: 41168 RVA: 0x001857D7 File Offset: 0x001839D7
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

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x0600A0D1 RID: 41169 RVA: 0x001857E0 File Offset: 0x001839E0
		// (set) Token: 0x0600A0D2 RID: 41170 RVA: 0x001857E8 File Offset: 0x001839E8
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

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x0600A0D3 RID: 41171 RVA: 0x001857F1 File Offset: 0x001839F1
		// (set) Token: 0x0600A0D4 RID: 41172 RVA: 0x001857F9 File Offset: 0x001839F9
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

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x0600A0D5 RID: 41173 RVA: 0x00185802 File Offset: 0x00183A02
		// (set) Token: 0x0600A0D6 RID: 41174 RVA: 0x0018580A File Offset: 0x00183A0A
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

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600A0D7 RID: 41175 RVA: 0x00185813 File Offset: 0x00183A13
		// (set) Token: 0x0600A0D8 RID: 41176 RVA: 0x0018581B File Offset: 0x00183A1B
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

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x0600A0D9 RID: 41177 RVA: 0x00185824 File Offset: 0x00183A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GivebackMainRoleActiveTimePb> MainRoleActiveTime
		{
			get
			{
				return this.mainRoleActiveTime_;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x0600A0DA RID: 41178 RVA: 0x0018582C File Offset: 0x00183A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GivebackNormalItemHistoryRecordPb> NormalItemHistoryRecords
		{
			get
			{
				return this.normalItemHistoryRecords_;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x0600A0DB RID: 41179 RVA: 0x00185834 File Offset: 0x00183A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, long> MainQuestFinishAt
		{
			get
			{
				return this.mainQuestFinishAt_;
			}
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x0018583C File Offset: 0x00183A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackOldHistoryRedisPb);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x0018584C File Offset: 0x00183A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackOldHistoryRedisPb other)
		{
			return other != null && (other == this || (this.MaxContinueLogin == other.MaxContinueLogin && this.ContinueLoginEndAtVer3 == other.ContinueLoginEndAtVer3 && this.OnlineTotalTime == other.OnlineTotalTime && this.Role5StarGachaCount == other.Role5StarGachaCount && this.Weapon5StarGachaCount == other.Weapon5StarGachaCount && this.mainRoleActiveTime_.Equals(other.mainRoleActiveTime_) && this.normalItemHistoryRecords_.Equals(other.normalItemHistoryRecords_) && this.MainQuestFinishAt.Equals(other.MainQuestFinishAt) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00185904 File Offset: 0x00183B04
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

		// Token: 0x0600A0DF RID: 41183 RVA: 0x001859D1 File Offset: 0x00183BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x001859DE File Offset: 0x00183BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x001859E8 File Offset: 0x00183BE8
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

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x00185AC8 File Offset: 0x00183CC8
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

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x00185BA0 File Offset: 0x00183DA0
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

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x00185C5F File Offset: 0x00183E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x00185C68 File Offset: 0x00183E68
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

		// Token: 0x04004B22 RID: 19234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B23 RID: 19235
		public const int MaxContinueLoginFieldNumber = 1;

		// Token: 0x04004B24 RID: 19236
		private int maxContinueLogin_;

		// Token: 0x04004B25 RID: 19237
		public const int ContinueLoginEndAtVer3FieldNumber = 2;

		// Token: 0x04004B26 RID: 19238
		private int continueLoginEndAtVer3_;

		// Token: 0x04004B27 RID: 19239
		public const int OnlineTotalTimeFieldNumber = 3;

		// Token: 0x04004B28 RID: 19240
		private int onlineTotalTime_;

		// Token: 0x04004B29 RID: 19241
		public const int Role5StarGachaCountFieldNumber = 4;

		// Token: 0x04004B2A RID: 19242
		private int role5StarGachaCount_;

		// Token: 0x04004B2B RID: 19243
		public const int Weapon5StarGachaCountFieldNumber = 5;

		// Token: 0x04004B2C RID: 19244
		private int weapon5StarGachaCount_;

		// Token: 0x04004B2D RID: 19245
		public const int MainRoleActiveTimeFieldNumber = 6;

		// Token: 0x04004B2E RID: 19246
		private static readonly FieldCodec<GivebackMainRoleActiveTimePb> _repeated_mainRoleActiveTime_codec = FieldCodec.ForMessage<GivebackMainRoleActiveTimePb>(50U, GivebackMainRoleActiveTimePb.Parser);

		// Token: 0x04004B2F RID: 19247
		private readonly RepeatedField<GivebackMainRoleActiveTimePb> mainRoleActiveTime_ = new RepeatedField<GivebackMainRoleActiveTimePb>();

		// Token: 0x04004B30 RID: 19248
		public const int NormalItemHistoryRecordsFieldNumber = 7;

		// Token: 0x04004B31 RID: 19249
		private static readonly FieldCodec<GivebackNormalItemHistoryRecordPb> _repeated_normalItemHistoryRecords_codec = FieldCodec.ForMessage<GivebackNormalItemHistoryRecordPb>(58U, GivebackNormalItemHistoryRecordPb.Parser);

		// Token: 0x04004B32 RID: 19250
		private readonly RepeatedField<GivebackNormalItemHistoryRecordPb> normalItemHistoryRecords_ = new RepeatedField<GivebackNormalItemHistoryRecordPb>();

		// Token: 0x04004B33 RID: 19251
		public const int MainQuestFinishAtFieldNumber = 8;

		// Token: 0x04004B34 RID: 19252
		private static readonly MapField<int, long>.Codec _map_mainQuestFinishAt_codec = new MapField<int, long>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt64(16U, 0L), 66U);

		// Token: 0x04004B35 RID: 19253
		private readonly MapField<int, long> mainQuestFinishAt_ = new MapField<int, long>();
	}
}
