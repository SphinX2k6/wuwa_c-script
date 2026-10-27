using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B85 RID: 2949
	public sealed class OneFishCage : IMessage<OneFishCage>, IMessage, IEquatable<OneFishCage>, IDeepCloneable<OneFishCage>, IBufferMessage
	{
		// Token: 0x0600FF9B RID: 65435 RVA: 0x0025483A File Offset: 0x00252A3A
		[NullableContext(1)]
		public static OneFishCage Create()
		{
			return new OneFishCage();
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600FF9C RID: 65436 RVA: 0x00254841 File Offset: 0x00252A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFishCage> Parser
		{
			get
			{
				return OneFishCage._parser;
			}
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600FF9D RID: 65437 RVA: 0x00254848 File Offset: 0x00252A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600FF9E RID: 65438 RVA: 0x0025484B File Offset: 0x00252A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFishCage.Descriptor;
			}
		}

		// Token: 0x0600FF9F RID: 65439 RVA: 0x00254852 File Offset: 0x00252A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage()
		{
		}

		// Token: 0x0600FFA0 RID: 65440 RVA: 0x00254868 File Offset: 0x00252A68
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

		// Token: 0x0600FFA1 RID: 65441 RVA: 0x002548E5 File Offset: 0x00252AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage Clone()
		{
			return new OneFishCage(this);
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600FFA2 RID: 65442 RVA: 0x002548ED File Offset: 0x00252AED
		// (set) Token: 0x0600FFA3 RID: 65443 RVA: 0x002548F5 File Offset: 0x00252AF5
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

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600FFA4 RID: 65444 RVA: 0x002548FE File Offset: 0x00252AFE
		// (set) Token: 0x0600FFA5 RID: 65445 RVA: 0x00254906 File Offset: 0x00252B06
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

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600FFA6 RID: 65446 RVA: 0x0025490F File Offset: 0x00252B0F
		// (set) Token: 0x0600FFA7 RID: 65447 RVA: 0x00254917 File Offset: 0x00252B17
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

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600FFA8 RID: 65448 RVA: 0x00254920 File Offset: 0x00252B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600FFA9 RID: 65449 RVA: 0x00254928 File Offset: 0x00252B28
		// (set) Token: 0x0600FFAA RID: 65450 RVA: 0x00254930 File Offset: 0x00252B30
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

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600FFAB RID: 65451 RVA: 0x00254939 File Offset: 0x00252B39
		// (set) Token: 0x0600FFAC RID: 65452 RVA: 0x00254941 File Offset: 0x00252B41
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

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600FFAD RID: 65453 RVA: 0x0025494A File Offset: 0x00252B4A
		// (set) Token: 0x0600FFAE RID: 65454 RVA: 0x00254952 File Offset: 0x00252B52
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

		// Token: 0x0600FFAF RID: 65455 RVA: 0x0025495B File Offset: 0x00252B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFishCage);
		}

		// Token: 0x0600FFB0 RID: 65456 RVA: 0x0025496C File Offset: 0x00252B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFishCage other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EntityConfigId == other.EntityConfigId && this.MaxCount == other.MaxCount && this.items_.Equals(other.items_) && this.LastUpdateTime == other.LastUpdateTime && this.NextUpdateTime == other.NextUpdateTime && this.RefreshTime == other.RefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FFB1 RID: 65457 RVA: 0x00254A0C File Offset: 0x00252C0C
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

		// Token: 0x0600FFB2 RID: 65458 RVA: 0x00254AD6 File Offset: 0x00252CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FFB3 RID: 65459 RVA: 0x00254AE3 File Offset: 0x00252CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FFB4 RID: 65460 RVA: 0x00254AEC File Offset: 0x00252CEC
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

		// Token: 0x0600FFB5 RID: 65461 RVA: 0x00254BC8 File Offset: 0x00252DC8
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

		// Token: 0x0600FFB6 RID: 65462 RVA: 0x00254C94 File Offset: 0x00252E94
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

		// Token: 0x0600FFB7 RID: 65463 RVA: 0x00254D45 File Offset: 0x00252F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FFB8 RID: 65464 RVA: 0x00254D50 File Offset: 0x00252F50
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

		// Token: 0x040065D3 RID: 26067
		private static readonly MessageParser<OneFishCage> _parser = new MessageParser<OneFishCage>(() => new OneFishCage());

		// Token: 0x040065D4 RID: 26068
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065D5 RID: 26069
		public const int IdFieldNumber = 5;

		// Token: 0x040065D6 RID: 26070
		private int id_;

		// Token: 0x040065D7 RID: 26071
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x040065D8 RID: 26072
		private int entityConfigId_;

		// Token: 0x040065D9 RID: 26073
		public const int MaxCountFieldNumber = 2;

		// Token: 0x040065DA RID: 26074
		private int maxCount_;

		// Token: 0x040065DB RID: 26075
		public const int ItemsFieldNumber = 3;

		// Token: 0x040065DC RID: 26076
		private static readonly FieldCodec<FishingItemInfo> _repeated_items_codec = FieldCodec.ForMessage<FishingItemInfo>(26U, FishingItemInfo.Parser);

		// Token: 0x040065DD RID: 26077
		private readonly RepeatedField<FishingItemInfo> items_ = new RepeatedField<FishingItemInfo>();

		// Token: 0x040065DE RID: 26078
		public const int LastUpdateTimeFieldNumber = 4;

		// Token: 0x040065DF RID: 26079
		private long lastUpdateTime_;

		// Token: 0x040065E0 RID: 26080
		public const int NextUpdateTimeFieldNumber = 6;

		// Token: 0x040065E1 RID: 26081
		private long nextUpdateTime_;

		// Token: 0x040065E2 RID: 26082
		public const int RefreshTimeFieldNumber = 7;

		// Token: 0x040065E3 RID: 26083
		private int refreshTime_;
	}
}
