using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B75 RID: 2933
	public sealed class OneFishCage : IMessage<OneFishCage>, IMessage, IEquatable<OneFishCage>, IDeepCloneable<OneFishCage>, IBufferMessage
	{
		// Token: 0x0600FE97 RID: 65175 RVA: 0x0025296A File Offset: 0x00250B6A
		[NullableContext(1)]
		public static OneFishCage Create()
		{
			return new OneFishCage();
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600FE98 RID: 65176 RVA: 0x00252971 File Offset: 0x00250B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFishCage> Parser
		{
			get
			{
				return OneFishCage._parser;
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600FE99 RID: 65177 RVA: 0x00252978 File Offset: 0x00250B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600FE9A RID: 65178 RVA: 0x0025297B File Offset: 0x00250B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFishCage.Descriptor;
			}
		}

		// Token: 0x0600FE9B RID: 65179 RVA: 0x00252982 File Offset: 0x00250B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage()
		{
		}

		// Token: 0x0600FE9C RID: 65180 RVA: 0x00252998 File Offset: 0x00250B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage(OneFishCage other) : this()
		{
			this.id_ = other.id_;
			this.entityConfigId_ = other.entityConfigId_;
			this.maxCount_ = other.maxCount_;
			this.items_ = other.items_.Clone();
			this.lastUpdateTime_ = other.lastUpdateTime_;
			this.nextUpdateTime_ = other.nextUpdateTime_;
			this.refreshTime_ = other.refreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE9D RID: 65181 RVA: 0x00252A15 File Offset: 0x00250C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage Clone()
		{
			return new OneFishCage(this);
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600FE9E RID: 65182 RVA: 0x00252A1D File Offset: 0x00250C1D
		// (set) Token: 0x0600FE9F RID: 65183 RVA: 0x00252A25 File Offset: 0x00250C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600FEA0 RID: 65184 RVA: 0x00252A2E File Offset: 0x00250C2E
		// (set) Token: 0x0600FEA1 RID: 65185 RVA: 0x00252A36 File Offset: 0x00250C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600FEA2 RID: 65186 RVA: 0x00252A3F File Offset: 0x00250C3F
		// (set) Token: 0x0600FEA3 RID: 65187 RVA: 0x00252A47 File Offset: 0x00250C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxCount
		{
			get
			{
				return this.maxCount_;
			}
			set
			{
				this.maxCount_ = value;
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600FEA4 RID: 65188 RVA: 0x00252A50 File Offset: 0x00250C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600FEA5 RID: 65189 RVA: 0x00252A58 File Offset: 0x00250C58
		// (set) Token: 0x0600FEA6 RID: 65190 RVA: 0x00252A60 File Offset: 0x00250C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LastUpdateTime
		{
			get
			{
				return this.lastUpdateTime_;
			}
			set
			{
				this.lastUpdateTime_ = value;
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600FEA7 RID: 65191 RVA: 0x00252A69 File Offset: 0x00250C69
		// (set) Token: 0x0600FEA8 RID: 65192 RVA: 0x00252A71 File Offset: 0x00250C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextUpdateTime
		{
			get
			{
				return this.nextUpdateTime_;
			}
			set
			{
				this.nextUpdateTime_ = value;
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600FEA9 RID: 65193 RVA: 0x00252A7A File Offset: 0x00250C7A
		// (set) Token: 0x0600FEAA RID: 65194 RVA: 0x00252A82 File Offset: 0x00250C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshTime
		{
			get
			{
				return this.refreshTime_;
			}
			set
			{
				this.refreshTime_ = value;
			}
		}

		// Token: 0x0600FEAB RID: 65195 RVA: 0x00252A8B File Offset: 0x00250C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFishCage);
		}

		// Token: 0x0600FEAC RID: 65196 RVA: 0x00252A9C File Offset: 0x00250C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFishCage other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EntityConfigId == other.EntityConfigId && this.MaxCount == other.MaxCount && this.items_.Equals(other.items_) && this.LastUpdateTime == other.LastUpdateTime && this.NextUpdateTime == other.NextUpdateTime && this.RefreshTime == other.RefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FEAD RID: 65197 RVA: 0x00252B3C File Offset: 0x00250D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.MaxCount != 0)
			{
				num ^= this.MaxCount.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this.LastUpdateTime != 0L)
			{
				num ^= this.LastUpdateTime.GetHashCode();
			}
			if (this.NextUpdateTime != 0L)
			{
				num ^= this.NextUpdateTime.GetHashCode();
			}
			if (this.RefreshTime != 0)
			{
				num ^= this.RefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FEAE RID: 65198 RVA: 0x00252C06 File Offset: 0x00250E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FEAF RID: 65199 RVA: 0x00252C13 File Offset: 0x00250E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FEB0 RID: 65200 RVA: 0x00252C1C File Offset: 0x00250E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.MaxCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MaxCount);
			}
			this.items_.WriteTo(ref output, OneFishCage._repeated_items_codec);
			if (this.LastUpdateTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.LastUpdateTime);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Id);
			}
			if (this.NextUpdateTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.NextUpdateTime);
			}
			if (this.RefreshTime != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FEB1 RID: 65201 RVA: 0x00252CF8 File Offset: 0x00250EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.MaxCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxCount);
			}
			num += this.items_.CalculateSize(OneFishCage._repeated_items_codec);
			if (this.LastUpdateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LastUpdateTime);
			}
			if (this.NextUpdateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextUpdateTime);
			}
			if (this.RefreshTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FEB2 RID: 65202 RVA: 0x00252DC4 File Offset: 0x00250FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneFishCage other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.MaxCount != 0)
			{
				this.MaxCount = other.MaxCount;
			}
			this.items_.Add(other.items_);
			if (other.LastUpdateTime != 0L)
			{
				this.LastUpdateTime = other.LastUpdateTime;
			}
			if (other.NextUpdateTime != 0L)
			{
				this.NextUpdateTime = other.NextUpdateTime;
			}
			if (other.RefreshTime != 0)
			{
				this.RefreshTime = other.RefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FEB3 RID: 65203 RVA: 0x00252E75 File Offset: 0x00251075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FEB4 RID: 65204 RVA: 0x00252E80 File Offset: 0x00251080
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MaxCount = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.items_.AddEntriesFrom(ref input, OneFishCage._repeated_items_codec);
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.LastUpdateTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.NextUpdateTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.RefreshTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040065E3 RID: 26083
		private static readonly MessageParser<OneFishCage> _parser = new MessageParser<OneFishCage>(() => new OneFishCage());

		// Token: 0x040065E4 RID: 26084
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065E5 RID: 26085
		public const int IdFieldNumber = 5;

		// Token: 0x040065E6 RID: 26086
		private int id_;

		// Token: 0x040065E7 RID: 26087
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x040065E8 RID: 26088
		private int entityConfigId_;

		// Token: 0x040065E9 RID: 26089
		public const int MaxCountFieldNumber = 2;

		// Token: 0x040065EA RID: 26090
		private int maxCount_;

		// Token: 0x040065EB RID: 26091
		public const int ItemsFieldNumber = 3;

		// Token: 0x040065EC RID: 26092
		private static readonly FieldCodec<FishingItemInfo> _repeated_items_codec = FieldCodec.ForMessage<FishingItemInfo>(26U, FishingItemInfo.Parser);

		// Token: 0x040065ED RID: 26093
		private readonly RepeatedField<FishingItemInfo> items_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x040065EE RID: 26094
		public const int LastUpdateTimeFieldNumber = 4;

		// Token: 0x040065EF RID: 26095
		private long lastUpdateTime_;

		// Token: 0x040065F0 RID: 26096
		public const int NextUpdateTimeFieldNumber = 6;

		// Token: 0x040065F1 RID: 26097
		private long nextUpdateTime_;

		// Token: 0x040065F2 RID: 26098
		public const int RefreshTimeFieldNumber = 7;

		// Token: 0x040065F3 RID: 26099
		private int refreshTime_;
	}
}
