using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000166 RID: 358
	[NetMessage(EMessageId.BattleAntiCheatingLogNotify)]
	public sealed class BattleAntiCheatingLogNotify : IMessage<BattleAntiCheatingLogNotify>, IMessage, IEquatable<BattleAntiCheatingLogNotify>, IDeepCloneable<BattleAntiCheatingLogNotify>, IBufferMessage
	{
		// Token: 0x06002C89 RID: 11401 RVA: 0x00073B41 File Offset: 0x00071D41
		[NullableContext(1)]
		public static BattleAntiCheatingLogNotify Create()
		{
			return new BattleAntiCheatingLogNotify();
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002C8A RID: 11402 RVA: 0x00073B48 File Offset: 0x00071D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x00073B4B File Offset: 0x00071D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleAntiCheatingLogNotify.Descriptor;
			}
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00073B52 File Offset: 0x00071D52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAntiCheatingLogNotify()
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00073B5C File Offset: 0x00071D5C
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

		// Token: 0x06002C8E RID: 11406 RVA: 0x00073BC8 File Offset: 0x00071DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleAntiCheatingLogNotify Clone()
		{
			return new BattleAntiCheatingLogNotify(this);
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x00073BD0 File Offset: 0x00071DD0
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x00073BD8 File Offset: 0x00071DD8
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

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x00073BE1 File Offset: 0x00071DE1
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x00073BE9 File Offset: 0x00071DE9
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

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x00073BF2 File Offset: 0x00071DF2
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x00073BFA File Offset: 0x00071DFA
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

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x00073C03 File Offset: 0x00071E03
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x00073C0B File Offset: 0x00071E0B
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

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x00073C14 File Offset: 0x00071E14
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x00073C1C File Offset: 0x00071E1C
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

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x00073C25 File Offset: 0x00071E25
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x00073C2D File Offset: 0x00071E2D
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

		// Token: 0x06002C9B RID: 11419 RVA: 0x00073C36 File Offset: 0x00071E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleAntiCheatingLogNotify);
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x00073C44 File Offset: 0x00071E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleAntiCheatingLogNotify other)
		{
			return other != null && (other == this || (this.LogType == other.LogType && this.LogId == other.LogId && this.RoomId == other.RoomId && this.BattleId == other.BattleId && this.InstId == other.InstId && this.TimoutSpan == other.TimoutSpan && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00073CD0 File Offset: 0x00071ED0
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

		// Token: 0x06002C9E RID: 11422 RVA: 0x00073D8C File Offset: 0x00071F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x00073D99 File Offset: 0x00071F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x00073DA4 File Offset: 0x00071FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.RoomId);
			}
			if (this.LogType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LogType);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.InstId);
			}
			if (this.BattleId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.BattleId);
			}
			if (this.TimoutSpan != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TimoutSpan);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00073E6C File Offset: 0x0007206C
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

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00073F24 File Offset: 0x00072124
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

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00073FC4 File Offset: 0x000721C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00073FD0 File Offset: 0x000721D0
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.RoomId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.LogType = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.BattleId = input.ReadInt64();
						continue;
					}
					if (num == 88U)
					{
						this.TimoutSpan = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040027F9 RID: 10233
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027FA RID: 10234
		public const int LogTypeFieldNumber = 4;

		// Token: 0x040027FB RID: 10235
		private int logType_;

		// Token: 0x040027FC RID: 10236
		public const int LogIdFieldNumber = 15;

		// Token: 0x040027FD RID: 10237
		private long logId_;

		// Token: 0x040027FE RID: 10238
		public const int RoomIdFieldNumber = 1;

		// Token: 0x040027FF RID: 10239
		private long roomId_;

		// Token: 0x04002800 RID: 10240
		public const int BattleIdFieldNumber = 7;

		// Token: 0x04002801 RID: 10241
		private long battleId_;

		// Token: 0x04002802 RID: 10242
		public const int InstIdFieldNumber = 5;

		// Token: 0x04002803 RID: 10243
		private int instId_;

		// Token: 0x04002804 RID: 10244
		public const int TimoutSpanFieldNumber = 11;

		// Token: 0x04002805 RID: 10245
		private int timoutSpan_;
	}
}
