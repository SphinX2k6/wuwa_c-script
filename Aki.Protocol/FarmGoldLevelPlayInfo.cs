using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000521 RID: 1313
	public sealed class FarmGoldLevelPlayInfo : IMessage<FarmGoldLevelPlayInfo>, IMessage, IEquatable<FarmGoldLevelPlayInfo>, IDeepCloneable<FarmGoldLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x06007B3C RID: 31548 RVA: 0x0012AFB3 File Offset: 0x001291B3
		[NullableContext(1)]
		public static FarmGoldLevelPlayInfo Create()
		{
			return new FarmGoldLevelPlayInfo();
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06007B3D RID: 31549 RVA: 0x0012AFBA File Offset: 0x001291BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FarmGoldLevelPlayInfo> Parser
		{
			get
			{
				return FarmGoldLevelPlayInfo._parser;
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06007B3E RID: 31550 RVA: 0x0012AFC1 File Offset: 0x001291C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06007B3F RID: 31551 RVA: 0x0012AFC4 File Offset: 0x001291C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x0012AFCB File Offset: 0x001291CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayInfo()
		{
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x0012AFD4 File Offset: 0x001291D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayInfo(FarmGoldLevelPlayInfo other) : this()
		{
			this.instId_ = other.instId_;
			this.startTime_ = other.startTime_;
			this.isOpen_ = other.isOpen_;
			this.point_ = other.point_;
			this.levelRewardGet_ = other.levelRewardGet_;
			this.difficulty_ = other.difficulty_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x0012B040 File Offset: 0x00129240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayInfo Clone()
		{
			return new FarmGoldLevelPlayInfo(this);
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06007B43 RID: 31555 RVA: 0x0012B048 File Offset: 0x00129248
		// (set) Token: 0x06007B44 RID: 31556 RVA: 0x0012B050 File Offset: 0x00129250
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

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06007B45 RID: 31557 RVA: 0x0012B059 File Offset: 0x00129259
		// (set) Token: 0x06007B46 RID: 31558 RVA: 0x0012B061 File Offset: 0x00129261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartTime
		{
			get
			{
				return this.startTime_;
			}
			set
			{
				this.startTime_ = value;
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06007B47 RID: 31559 RVA: 0x0012B06A File Offset: 0x0012926A
		// (set) Token: 0x06007B48 RID: 31560 RVA: 0x0012B072 File Offset: 0x00129272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06007B49 RID: 31561 RVA: 0x0012B07B File Offset: 0x0012927B
		// (set) Token: 0x06007B4A RID: 31562 RVA: 0x0012B083 File Offset: 0x00129283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06007B4B RID: 31563 RVA: 0x0012B08C File Offset: 0x0012928C
		// (set) Token: 0x06007B4C RID: 31564 RVA: 0x0012B094 File Offset: 0x00129294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LevelRewardGet
		{
			get
			{
				return this.levelRewardGet_;
			}
			set
			{
				this.levelRewardGet_ = value;
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06007B4D RID: 31565 RVA: 0x0012B09D File Offset: 0x0012929D
		// (set) Token: 0x06007B4E RID: 31566 RVA: 0x0012B0A5 File Offset: 0x001292A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Difficulty
		{
			get
			{
				return this.difficulty_;
			}
			set
			{
				this.difficulty_ = value;
			}
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x0012B0AE File Offset: 0x001292AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayInfo);
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x0012B0BC File Offset: 0x001292BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.StartTime == other.StartTime && this.IsOpen == other.IsOpen && this.Point == other.Point && this.LevelRewardGet == other.LevelRewardGet && this.Difficulty == other.Difficulty && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x0012B148 File Offset: 0x00129348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.StartTime != 0)
			{
				num ^= this.StartTime.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this.LevelRewardGet)
			{
				num ^= this.LevelRewardGet.GetHashCode();
			}
			if (this.Difficulty != 0)
			{
				num ^= this.Difficulty.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x0012B204 File Offset: 0x00129404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x0012B211 File Offset: 0x00129411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x0012B21C File Offset: 0x0012941C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.StartTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.StartTime);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsOpen);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Point);
			}
			if (this.LevelRewardGet)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.LevelRewardGet);
			}
			if (this.Difficulty != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Difficulty);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x0012B2E4 File Offset: 0x001294E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.StartTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartTime);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this.LevelRewardGet)
			{
				num += 2;
			}
			if (this.Difficulty != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Difficulty);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x0012B384 File Offset: 0x00129584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldLevelPlayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.StartTime != 0)
			{
				this.StartTime = other.StartTime;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			if (other.LevelRewardGet)
			{
				this.LevelRewardGet = other.LevelRewardGet;
			}
			if (other.Difficulty != 0)
			{
				this.Difficulty = other.Difficulty;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x0012B424 File Offset: 0x00129624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B58 RID: 31576 RVA: 0x0012B430 File Offset: 0x00129630
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.StartTime = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsOpen = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Point = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LevelRewardGet = input.ReadBool();
						continue;
					}
					if (num == 48U)
					{
						this.Difficulty = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F1C RID: 16156
		private static readonly MessageParser<FarmGoldLevelPlayInfo> _parser = new MessageParser<FarmGoldLevelPlayInfo>(() => new FarmGoldLevelPlayInfo());

		// Token: 0x04003F1D RID: 16157
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F1E RID: 16158
		public const int InstIdFieldNumber = 1;

		// Token: 0x04003F1F RID: 16159
		private int instId_;

		// Token: 0x04003F20 RID: 16160
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04003F21 RID: 16161
		private int startTime_;

		// Token: 0x04003F22 RID: 16162
		public const int IsOpenFieldNumber = 3;

		// Token: 0x04003F23 RID: 16163
		private bool isOpen_;

		// Token: 0x04003F24 RID: 16164
		public const int PointFieldNumber = 4;

		// Token: 0x04003F25 RID: 16165
		private int point_;

		// Token: 0x04003F26 RID: 16166
		public const int LevelRewardGetFieldNumber = 5;

		// Token: 0x04003F27 RID: 16167
		private bool levelRewardGet_;

		// Token: 0x04003F28 RID: 16168
		public const int DifficultyFieldNumber = 6;

		// Token: 0x04003F29 RID: 16169
		private int difficulty_;
	}
}
