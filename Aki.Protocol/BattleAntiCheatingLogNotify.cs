using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000169 RID: 361
	[NetMessage(EMessageId.BattleAntiCheatingLogNotify)]
	public sealed class BattleAntiCheatingLogNotify : IMessage<BattleAntiCheatingLogNotify>, IMessage, IEquatable<BattleAntiCheatingLogNotify>, IDeepCloneable<BattleAntiCheatingLogNotify>, IBufferMessage
	{
		// Token: 0x06002D00 RID: 11520 RVA: 0x00074F71 File Offset: 0x00073171
		[NullableContext(1)]
		public static BattleAntiCheatingLogNotify Create()
		{
			return new BattleAntiCheatingLogNotify();
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x00074F78 File Offset: 0x00073178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x00074F7B File Offset: 0x0007317B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleAntiCheatingLogNotify.Descriptor;
			}
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00074F82 File Offset: 0x00073182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAntiCheatingLogNotify()
		{
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00074F8C File Offset: 0x0007318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAntiCheatingLogNotify(BattleAntiCheatingLogNotify other) : this()
		{
			this.logType_ = other.logType_;
			this.logId_ = other.logId_;
			this.roomId_ = other.roomId_;
			this.battleId_ = other.battleId_;
			this.instId_ = other.instId_;
			this.timoutSpan_ = other.timoutSpan_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00074FF8 File Offset: 0x000731F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAntiCheatingLogNotify Clone()
		{
			return new BattleAntiCheatingLogNotify(this);
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x00075000 File Offset: 0x00073200
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x00075008 File Offset: 0x00073208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LogType
		{
			get
			{
				return this.logType_;
			}
			set
			{
				this.logType_ = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x00075011 File Offset: 0x00073211
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x00075019 File Offset: 0x00073219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x00075022 File Offset: 0x00073222
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x0007502A File Offset: 0x0007322A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x00075033 File Offset: 0x00073233
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x0007503B File Offset: 0x0007323B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BattleId
		{
			get
			{
				return this.battleId_;
			}
			set
			{
				this.battleId_ = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x00075044 File Offset: 0x00073244
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x0007504C File Offset: 0x0007324C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x00075055 File Offset: 0x00073255
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x0007505D File Offset: 0x0007325D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TimoutSpan
		{
			get
			{
				return this.timoutSpan_;
			}
			set
			{
				this.timoutSpan_ = value;
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00075066 File Offset: 0x00073266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleAntiCheatingLogNotify);
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00075074 File Offset: 0x00073274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleAntiCheatingLogNotify other)
		{
			return other != null && (other == this || (this.LogType == other.LogType && this.LogId == other.LogId && this.RoomId == other.RoomId && this.BattleId == other.BattleId && this.InstId == other.InstId && this.TimoutSpan == other.TimoutSpan && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00075100 File Offset: 0x00073300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogType != 0)
			{
				num ^= this.LogType.GetHashCode();
			}
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.RoomId != 0L)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.BattleId != 0L)
			{
				num ^= this.BattleId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.TimoutSpan != 0)
			{
				num ^= this.TimoutSpan.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000751BC File Offset: 0x000733BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000751C9 File Offset: 0x000733C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000751D4 File Offset: 0x000733D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LogType);
			}
			if (this.RoomId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.RoomId);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LogId);
			}
			if (this.BattleId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.BattleId);
			}
			if (this.TimoutSpan != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TimoutSpan);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x000752A0 File Offset: 0x000734A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LogType);
			}
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.RoomId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RoomId);
			}
			if (this.BattleId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BattleId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.TimoutSpan != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TimoutSpan);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00075358 File Offset: 0x00073558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleAntiCheatingLogNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogType != 0)
			{
				this.LogType = other.LogType;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.RoomId != 0L)
			{
				this.RoomId = other.RoomId;
			}
			if (other.BattleId != 0L)
			{
				this.BattleId = other.BattleId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.TimoutSpan != 0)
			{
				this.TimoutSpan = other.TimoutSpan;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000753F8 File Offset: 0x000735F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00075404 File Offset: 0x00073604
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.LogType = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.RoomId = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.BattleId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.TimoutSpan = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400286D RID: 10349
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400286E RID: 10350
		public const int LogTypeFieldNumber = 4;

		// Token: 0x0400286F RID: 10351
		private int logType_;

		// Token: 0x04002870 RID: 10352
		public const int LogIdFieldNumber = 7;

		// Token: 0x04002871 RID: 10353
		private long logId_;

		// Token: 0x04002872 RID: 10354
		public const int RoomIdFieldNumber = 6;

		// Token: 0x04002873 RID: 10355
		private long roomId_;

		// Token: 0x04002874 RID: 10356
		public const int BattleIdFieldNumber = 11;

		// Token: 0x04002875 RID: 10357
		private long battleId_;

		// Token: 0x04002876 RID: 10358
		public const int InstIdFieldNumber = 15;

		// Token: 0x04002877 RID: 10359
		private int instId_;

		// Token: 0x04002878 RID: 10360
		public const int TimoutSpanFieldNumber = 13;

		// Token: 0x04002879 RID: 10361
		private int timoutSpan_;
	}
}
