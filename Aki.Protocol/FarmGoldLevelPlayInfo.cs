using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050C RID: 1292
	public sealed class FarmGoldLevelPlayInfo : IMessage<FarmGoldLevelPlayInfo>, IMessage, IEquatable<FarmGoldLevelPlayInfo>, IDeepCloneable<FarmGoldLevelPlayInfo>, IBufferMessage
	{
		// Token: 0x060079D4 RID: 31188 RVA: 0x001283B3 File Offset: 0x001265B3
		[NullableContext(1)]
		public static FarmGoldLevelPlayInfo Create()
		{
			return new FarmGoldLevelPlayInfo();
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x060079D5 RID: 31189 RVA: 0x001283BA File Offset: 0x001265BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FarmGoldLevelPlayInfo> Parser
		{
			get
			{
				return FarmGoldLevelPlayInfo._parser;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x060079D6 RID: 31190 RVA: 0x001283C1 File Offset: 0x001265C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x001283C4 File Offset: 0x001265C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldLevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x001283CB File Offset: 0x001265CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayInfo()
		{
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x001283D4 File Offset: 0x001265D4
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

		// Token: 0x060079DA RID: 31194 RVA: 0x00128440 File Offset: 0x00126640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldLevelPlayInfo Clone()
		{
			return new FarmGoldLevelPlayInfo(this);
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x060079DB RID: 31195 RVA: 0x00128448 File Offset: 0x00126648
		// (set) Token: 0x060079DC RID: 31196 RVA: 0x00128450 File Offset: 0x00126650
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

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x060079DD RID: 31197 RVA: 0x00128459 File Offset: 0x00126659
		// (set) Token: 0x060079DE RID: 31198 RVA: 0x00128461 File Offset: 0x00126661
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

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x0012846A File Offset: 0x0012666A
		// (set) Token: 0x060079E0 RID: 31200 RVA: 0x00128472 File Offset: 0x00126672
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

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x060079E1 RID: 31201 RVA: 0x0012847B File Offset: 0x0012667B
		// (set) Token: 0x060079E2 RID: 31202 RVA: 0x00128483 File Offset: 0x00126683
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

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x0012848C File Offset: 0x0012668C
		// (set) Token: 0x060079E4 RID: 31204 RVA: 0x00128494 File Offset: 0x00126694
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

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x0012849D File Offset: 0x0012669D
		// (set) Token: 0x060079E6 RID: 31206 RVA: 0x001284A5 File Offset: 0x001266A5
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

		// Token: 0x060079E7 RID: 31207 RVA: 0x001284AE File Offset: 0x001266AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldLevelPlayInfo);
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x001284BC File Offset: 0x001266BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldLevelPlayInfo other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.StartTime == other.StartTime && this.IsOpen == other.IsOpen && this.Point == other.Point && this.LevelRewardGet == other.LevelRewardGet && this.Difficulty == other.Difficulty && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00128548 File Offset: 0x00126748
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

		// Token: 0x060079EA RID: 31210 RVA: 0x00128604 File Offset: 0x00126804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x00128611 File Offset: 0x00126811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x0012861C File Offset: 0x0012681C
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

		// Token: 0x060079ED RID: 31213 RVA: 0x001286E4 File Offset: 0x001268E4
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

		// Token: 0x060079EE RID: 31214 RVA: 0x00128784 File Offset: 0x00126984
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

		// Token: 0x060079EF RID: 31215 RVA: 0x00128824 File Offset: 0x00126A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x00128830 File Offset: 0x00126A30
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

		// Token: 0x04003F12 RID: 16146
		private static readonly MessageParser<FarmGoldLevelPlayInfo> _parser = new MessageParser<FarmGoldLevelPlayInfo>(() => new FarmGoldLevelPlayInfo());

		// Token: 0x04003F13 RID: 16147
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F14 RID: 16148
		public const int InstIdFieldNumber = 1;

		// Token: 0x04003F15 RID: 16149
		private int instId_;

		// Token: 0x04003F16 RID: 16150
		public const int StartTimeFieldNumber = 2;

		// Token: 0x04003F17 RID: 16151
		private int startTime_;

		// Token: 0x04003F18 RID: 16152
		public const int IsOpenFieldNumber = 3;

		// Token: 0x04003F19 RID: 16153
		private bool isOpen_;

		// Token: 0x04003F1A RID: 16154
		public const int PointFieldNumber = 4;

		// Token: 0x04003F1B RID: 16155
		private int point_;

		// Token: 0x04003F1C RID: 16156
		public const int LevelRewardGetFieldNumber = 5;

		// Token: 0x04003F1D RID: 16157
		private bool levelRewardGet_;

		// Token: 0x04003F1E RID: 16158
		public const int DifficultyFieldNumber = 6;

		// Token: 0x04003F1F RID: 16159
		private int difficulty_;
	}
}
