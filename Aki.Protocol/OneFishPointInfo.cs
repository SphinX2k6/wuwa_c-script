using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B77 RID: 2935
	public sealed class OneFishPointInfo : IMessage<OneFishPointInfo>, IMessage, IEquatable<OneFishPointInfo>, IDeepCloneable<OneFishPointInfo>, IBufferMessage
	{
		// Token: 0x0600FECE RID: 65230 RVA: 0x002532E2 File Offset: 0x002514E2
		[NullableContext(1)]
		public static OneFishPointInfo Create()
		{
			return new OneFishPointInfo();
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600FECF RID: 65231 RVA: 0x002532E9 File Offset: 0x002514E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFishPointInfo> Parser
		{
			get
			{
				return OneFishPointInfo._parser;
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600FED0 RID: 65232 RVA: 0x002532F0 File Offset: 0x002514F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600FED1 RID: 65233 RVA: 0x002532F3 File Offset: 0x002514F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFishPointInfo.Descriptor;
			}
		}

		// Token: 0x0600FED2 RID: 65234 RVA: 0x002532FA File Offset: 0x002514FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishPointInfo()
		{
		}

		// Token: 0x0600FED3 RID: 65235 RVA: 0x00253304 File Offset: 0x00251504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishPointInfo(OneFishPointInfo other) : this()
		{
			this.id_ = other.id_;
			this.entityConfigId_ = other.entityConfigId_;
			this.curCount_ = other.curCount_;
			this.maxCount_ = other.maxCount_;
			this.lastUpdateTime_ = other.lastUpdateTime_;
			this.nextUpdateTime_ = other.nextUpdateTime_;
			this.refreshTime_ = other.refreshTime_;
			this.gamePlayId_ = other.gamePlayId_;
			this.interacted_ = other.interacted_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FED4 RID: 65236 RVA: 0x00253394 File Offset: 0x00251594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishPointInfo Clone()
		{
			return new OneFishPointInfo(this);
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600FED5 RID: 65237 RVA: 0x0025339C File Offset: 0x0025159C
		// (set) Token: 0x0600FED6 RID: 65238 RVA: 0x002533A4 File Offset: 0x002515A4
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

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600FED7 RID: 65239 RVA: 0x002533AD File Offset: 0x002515AD
		// (set) Token: 0x0600FED8 RID: 65240 RVA: 0x002533B5 File Offset: 0x002515B5
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

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600FED9 RID: 65241 RVA: 0x002533BE File Offset: 0x002515BE
		// (set) Token: 0x0600FEDA RID: 65242 RVA: 0x002533C6 File Offset: 0x002515C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCount
		{
			get
			{
				return this.curCount_;
			}
			set
			{
				this.curCount_ = value;
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600FEDB RID: 65243 RVA: 0x002533CF File Offset: 0x002515CF
		// (set) Token: 0x0600FEDC RID: 65244 RVA: 0x002533D7 File Offset: 0x002515D7
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

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600FEDD RID: 65245 RVA: 0x002533E0 File Offset: 0x002515E0
		// (set) Token: 0x0600FEDE RID: 65246 RVA: 0x002533E8 File Offset: 0x002515E8
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

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600FEDF RID: 65247 RVA: 0x002533F1 File Offset: 0x002515F1
		// (set) Token: 0x0600FEE0 RID: 65248 RVA: 0x002533F9 File Offset: 0x002515F9
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

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600FEE1 RID: 65249 RVA: 0x00253402 File Offset: 0x00251602
		// (set) Token: 0x0600FEE2 RID: 65250 RVA: 0x0025340A File Offset: 0x0025160A
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

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600FEE3 RID: 65251 RVA: 0x00253413 File Offset: 0x00251613
		// (set) Token: 0x0600FEE4 RID: 65252 RVA: 0x0025341B File Offset: 0x0025161B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayId
		{
			get
			{
				return this.gamePlayId_;
			}
			set
			{
				this.gamePlayId_ = value;
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600FEE5 RID: 65253 RVA: 0x00253424 File Offset: 0x00251624
		// (set) Token: 0x0600FEE6 RID: 65254 RVA: 0x0025342C File Offset: 0x0025162C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Interacted
		{
			get
			{
				return this.interacted_;
			}
			set
			{
				this.interacted_ = value;
			}
		}

		// Token: 0x0600FEE7 RID: 65255 RVA: 0x00253435 File Offset: 0x00251635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFishPointInfo);
		}

		// Token: 0x0600FEE8 RID: 65256 RVA: 0x00253444 File Offset: 0x00251644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFishPointInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EntityConfigId == other.EntityConfigId && this.CurCount == other.CurCount && this.MaxCount == other.MaxCount && this.LastUpdateTime == other.LastUpdateTime && this.NextUpdateTime == other.NextUpdateTime && this.RefreshTime == other.RefreshTime && this.GamePlayId == other.GamePlayId && this.Interacted == other.Interacted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FEE9 RID: 65257 RVA: 0x00253500 File Offset: 0x00251700
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
			if (this.CurCount != 0)
			{
				num ^= this.CurCount.GetHashCode();
			}
			if (this.MaxCount != 0)
			{
				num ^= this.MaxCount.GetHashCode();
			}
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
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.Interacted)
			{
				num ^= this.Interacted.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FEEA RID: 65258 RVA: 0x00253607 File Offset: 0x00251807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FEEB RID: 65259 RVA: 0x00253614 File Offset: 0x00251814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FEEC RID: 65260 RVA: 0x00253620 File Offset: 0x00251820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.CurCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurCount);
			}
			if (this.MaxCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxCount);
			}
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
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.GamePlayId);
			}
			if (this.Interacted)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Interacted);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FEED RID: 65261 RVA: 0x0025373C File Offset: 0x0025193C
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
			if (this.CurCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCount);
			}
			if (this.MaxCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxCount);
			}
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
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.Interacted)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FEEE RID: 65262 RVA: 0x00253830 File Offset: 0x00251A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneFishPointInfo other)
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
			if (other.CurCount != 0)
			{
				this.CurCount = other.CurCount;
			}
			if (other.MaxCount != 0)
			{
				this.MaxCount = other.MaxCount;
			}
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
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.Interacted)
			{
				this.Interacted = other.Interacted;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FEEF RID: 65263 RVA: 0x0025390C File Offset: 0x00251B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FEF0 RID: 65264 RVA: 0x00253918 File Offset: 0x00251B18
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
							this.EntityConfigId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.CurCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.MaxCount = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.LastUpdateTime = input.ReadInt64();
							continue;
						}
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.NextUpdateTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.RefreshTime = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.GamePlayId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.Interacted = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040065FC RID: 26108
		private static readonly MessageParser<OneFishPointInfo> _parser = new MessageParser<OneFishPointInfo>(() => new OneFishPointInfo());

		// Token: 0x040065FD RID: 26109
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065FE RID: 26110
		public const int IdFieldNumber = 5;

		// Token: 0x040065FF RID: 26111
		private int id_;

		// Token: 0x04006600 RID: 26112
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x04006601 RID: 26113
		private int entityConfigId_;

		// Token: 0x04006602 RID: 26114
		public const int CurCountFieldNumber = 2;

		// Token: 0x04006603 RID: 26115
		private int curCount_;

		// Token: 0x04006604 RID: 26116
		public const int MaxCountFieldNumber = 3;

		// Token: 0x04006605 RID: 26117
		private int maxCount_;

		// Token: 0x04006606 RID: 26118
		public const int LastUpdateTimeFieldNumber = 4;

		// Token: 0x04006607 RID: 26119
		private long lastUpdateTime_;

		// Token: 0x04006608 RID: 26120
		public const int NextUpdateTimeFieldNumber = 6;

		// Token: 0x04006609 RID: 26121
		private long nextUpdateTime_;

		// Token: 0x0400660A RID: 26122
		public const int RefreshTimeFieldNumber = 7;

		// Token: 0x0400660B RID: 26123
		private int refreshTime_;

		// Token: 0x0400660C RID: 26124
		public const int GamePlayIdFieldNumber = 8;

		// Token: 0x0400660D RID: 26125
		private int gamePlayId_;

		// Token: 0x0400660E RID: 26126
		public const int InteractedFieldNumber = 9;

		// Token: 0x0400660F RID: 26127
		private bool interacted_;
	}
}
