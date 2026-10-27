using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B87 RID: 2951
	public sealed class OneFishPointInfo : IMessage<OneFishPointInfo>, IMessage, IEquatable<OneFishPointInfo>, IDeepCloneable<OneFishPointInfo>, IBufferMessage
	{
		// Token: 0x0600FFD2 RID: 65490 RVA: 0x002551B2 File Offset: 0x002533B2
		[NullableContext(1)]
		public static OneFishPointInfo Create()
		{
			return new OneFishPointInfo();
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600FFD3 RID: 65491 RVA: 0x002551B9 File Offset: 0x002533B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFishPointInfo> Parser
		{
			get
			{
				return OneFishPointInfo._parser;
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600FFD4 RID: 65492 RVA: 0x002551C0 File Offset: 0x002533C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600FFD5 RID: 65493 RVA: 0x002551C3 File Offset: 0x002533C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFishPointInfo.Descriptor;
			}
		}

		// Token: 0x0600FFD6 RID: 65494 RVA: 0x002551CA File Offset: 0x002533CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishPointInfo()
		{
		}

		// Token: 0x0600FFD7 RID: 65495 RVA: 0x002551D4 File Offset: 0x002533D4
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

		// Token: 0x0600FFD8 RID: 65496 RVA: 0x00255264 File Offset: 0x00253464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishPointInfo Clone()
		{
			return new OneFishPointInfo(this);
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600FFD9 RID: 65497 RVA: 0x0025526C File Offset: 0x0025346C
		// (set) Token: 0x0600FFDA RID: 65498 RVA: 0x00255274 File Offset: 0x00253474
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

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600FFDB RID: 65499 RVA: 0x0025527D File Offset: 0x0025347D
		// (set) Token: 0x0600FFDC RID: 65500 RVA: 0x00255285 File Offset: 0x00253485
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

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600FFDD RID: 65501 RVA: 0x0025528E File Offset: 0x0025348E
		// (set) Token: 0x0600FFDE RID: 65502 RVA: 0x00255296 File Offset: 0x00253496
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

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600FFDF RID: 65503 RVA: 0x0025529F File Offset: 0x0025349F
		// (set) Token: 0x0600FFE0 RID: 65504 RVA: 0x002552A7 File Offset: 0x002534A7
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

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600FFE1 RID: 65505 RVA: 0x002552B0 File Offset: 0x002534B0
		// (set) Token: 0x0600FFE2 RID: 65506 RVA: 0x002552B8 File Offset: 0x002534B8
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

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600FFE3 RID: 65507 RVA: 0x002552C1 File Offset: 0x002534C1
		// (set) Token: 0x0600FFE4 RID: 65508 RVA: 0x002552C9 File Offset: 0x002534C9
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

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600FFE5 RID: 65509 RVA: 0x002552D2 File Offset: 0x002534D2
		// (set) Token: 0x0600FFE6 RID: 65510 RVA: 0x002552DA File Offset: 0x002534DA
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

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600FFE7 RID: 65511 RVA: 0x002552E3 File Offset: 0x002534E3
		// (set) Token: 0x0600FFE8 RID: 65512 RVA: 0x002552EB File Offset: 0x002534EB
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

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600FFE9 RID: 65513 RVA: 0x002552F4 File Offset: 0x002534F4
		// (set) Token: 0x0600FFEA RID: 65514 RVA: 0x002552FC File Offset: 0x002534FC
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

		// Token: 0x0600FFEB RID: 65515 RVA: 0x00255305 File Offset: 0x00253505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFishPointInfo);
		}

		// Token: 0x0600FFEC RID: 65516 RVA: 0x00255314 File Offset: 0x00253514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFishPointInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EntityConfigId == other.EntityConfigId && this.CurCount == other.CurCount && this.MaxCount == other.MaxCount && this.LastUpdateTime == other.LastUpdateTime && this.NextUpdateTime == other.NextUpdateTime && this.RefreshTime == other.RefreshTime && this.GamePlayId == other.GamePlayId && this.Interacted == other.Interacted && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FFED RID: 65517 RVA: 0x002553D0 File Offset: 0x002535D0
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

		// Token: 0x0600FFEE RID: 65518 RVA: 0x002554D7 File Offset: 0x002536D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FFEF RID: 65519 RVA: 0x002554E4 File Offset: 0x002536E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FFF0 RID: 65520 RVA: 0x002554F0 File Offset: 0x002536F0
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

		// Token: 0x0600FFF1 RID: 65521 RVA: 0x0025560C File Offset: 0x0025380C
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

		// Token: 0x0600FFF2 RID: 65522 RVA: 0x00255700 File Offset: 0x00253900
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

		// Token: 0x0600FFF3 RID: 65523 RVA: 0x002557DC File Offset: 0x002539DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FFF4 RID: 65524 RVA: 0x002557E8 File Offset: 0x002539E8
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

		// Token: 0x040065EC RID: 26092
		private static readonly MessageParser<OneFishPointInfo> _parser = new MessageParser<OneFishPointInfo>(() => new OneFishPointInfo());

		// Token: 0x040065ED RID: 26093
		private UnknownFieldSet _unknownFields;

		// Token: 0x040065EE RID: 26094
		public const int IdFieldNumber = 5;

		// Token: 0x040065EF RID: 26095
		private int id_;

		// Token: 0x040065F0 RID: 26096
		public const int EntityConfigIdFieldNumber = 1;

		// Token: 0x040065F1 RID: 26097
		private int entityConfigId_;

		// Token: 0x040065F2 RID: 26098
		public const int CurCountFieldNumber = 2;

		// Token: 0x040065F3 RID: 26099
		private int curCount_;

		// Token: 0x040065F4 RID: 26100
		public const int MaxCountFieldNumber = 3;

		// Token: 0x040065F5 RID: 26101
		private int maxCount_;

		// Token: 0x040065F6 RID: 26102
		public const int LastUpdateTimeFieldNumber = 4;

		// Token: 0x040065F7 RID: 26103
		private long lastUpdateTime_;

		// Token: 0x040065F8 RID: 26104
		public const int NextUpdateTimeFieldNumber = 6;

		// Token: 0x040065F9 RID: 26105
		private long nextUpdateTime_;

		// Token: 0x040065FA RID: 26106
		public const int RefreshTimeFieldNumber = 7;

		// Token: 0x040065FB RID: 26107
		private int refreshTime_;

		// Token: 0x040065FC RID: 26108
		public const int GamePlayIdFieldNumber = 8;

		// Token: 0x040065FD RID: 26109
		private int gamePlayId_;

		// Token: 0x040065FE RID: 26110
		public const int InteractedFieldNumber = 9;

		// Token: 0x040065FF RID: 26111
		private bool interacted_;
	}
}
