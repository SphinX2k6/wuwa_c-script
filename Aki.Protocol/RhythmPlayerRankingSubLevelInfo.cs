using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F2E RID: 3886
	public sealed class RhythmPlayerRankingSubLevelInfo : IMessage<RhythmPlayerRankingSubLevelInfo>, IMessage, IEquatable<RhythmPlayerRankingSubLevelInfo>, IDeepCloneable<RhythmPlayerRankingSubLevelInfo>, IBufferMessage
	{
		// Token: 0x06014D22 RID: 85282 RVA: 0x00305DC4 File Offset: 0x00303FC4
		[NullableContext(1)]
		public static RhythmPlayerRankingSubLevelInfo Create()
		{
			return new RhythmPlayerRankingSubLevelInfo();
		}

		// Token: 0x1700453F RID: 17727
		// (get) Token: 0x06014D23 RID: 85283 RVA: 0x00305DCB File Offset: 0x00303FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmPlayerRankingSubLevelInfo> Parser
		{
			get
			{
				return RhythmPlayerRankingSubLevelInfo._parser;
			}
		}

		// Token: 0x17004540 RID: 17728
		// (get) Token: 0x06014D24 RID: 85284 RVA: 0x00305DD2 File Offset: 0x00303FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004541 RID: 17729
		// (get) Token: 0x06014D25 RID: 85285 RVA: 0x00305DD5 File Offset: 0x00303FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmPlayerRankingSubLevelInfo.Descriptor;
			}
		}

		// Token: 0x06014D26 RID: 85286 RVA: 0x00305DDC File Offset: 0x00303FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingSubLevelInfo()
		{
		}

		// Token: 0x06014D27 RID: 85287 RVA: 0x00305DE4 File Offset: 0x00303FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingSubLevelInfo(RhythmPlayerRankingSubLevelInfo other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.rhythmRoleId_ = other.rhythmRoleId_;
			this.score_ = other.score_;
			this.accuracy_ = other.accuracy_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014D28 RID: 85288 RVA: 0x00305E38 File Offset: 0x00304038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmPlayerRankingSubLevelInfo Clone()
		{
			return new RhythmPlayerRankingSubLevelInfo(this);
		}

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x06014D29 RID: 85289 RVA: 0x00305E40 File Offset: 0x00304040
		// (set) Token: 0x06014D2A RID: 85290 RVA: 0x00305E48 File Offset: 0x00304048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelId
		{
			get
			{
				return this.subLevelId_;
			}
			set
			{
				this.subLevelId_ = value;
			}
		}

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x06014D2B RID: 85291 RVA: 0x00305E51 File Offset: 0x00304051
		// (set) Token: 0x06014D2C RID: 85292 RVA: 0x00305E59 File Offset: 0x00304059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RhythmRoleId
		{
			get
			{
				return this.rhythmRoleId_;
			}
			set
			{
				this.rhythmRoleId_ = value;
			}
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x06014D2D RID: 85293 RVA: 0x00305E62 File Offset: 0x00304062
		// (set) Token: 0x06014D2E RID: 85294 RVA: 0x00305E6A File Offset: 0x0030406A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x06014D2F RID: 85295 RVA: 0x00305E73 File Offset: 0x00304073
		// (set) Token: 0x06014D30 RID: 85296 RVA: 0x00305E7B File Offset: 0x0030407B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Accuracy
		{
			get
			{
				return this.accuracy_;
			}
			set
			{
				this.accuracy_ = value;
			}
		}

		// Token: 0x06014D31 RID: 85297 RVA: 0x00305E84 File Offset: 0x00304084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmPlayerRankingSubLevelInfo);
		}

		// Token: 0x06014D32 RID: 85298 RVA: 0x00305E94 File Offset: 0x00304094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmPlayerRankingSubLevelInfo other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.RhythmRoleId == other.RhythmRoleId && this.Score == other.Score && this.Accuracy == other.Accuracy && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014D33 RID: 85299 RVA: 0x00305F00 File Offset: 0x00304100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this.RhythmRoleId != 0)
			{
				num ^= this.RhythmRoleId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.Accuracy != 0)
			{
				num ^= this.Accuracy.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014D34 RID: 85300 RVA: 0x00305F8A File Offset: 0x0030418A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014D35 RID: 85301 RVA: 0x00305F97 File Offset: 0x00304197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014D36 RID: 85302 RVA: 0x00305FA0 File Offset: 0x003041A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubLevelId);
			}
			if (this.RhythmRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RhythmRoleId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Score);
			}
			if (this.Accuracy != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Accuracy);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014D37 RID: 85303 RVA: 0x00306030 File Offset: 0x00304230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this.RhythmRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RhythmRoleId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.Accuracy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Accuracy);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014D38 RID: 85304 RVA: 0x003060B8 File Offset: 0x003042B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmPlayerRankingSubLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			if (other.RhythmRoleId != 0)
			{
				this.RhythmRoleId = other.RhythmRoleId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.Accuracy != 0)
			{
				this.Accuracy = other.Accuracy;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014D39 RID: 85305 RVA: 0x00306130 File Offset: 0x00304330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014D3A RID: 85306 RVA: 0x0030613C File Offset: 0x0030433C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SubLevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RhythmRoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Accuracy = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007E15 RID: 32277
		private static readonly MessageParser<RhythmPlayerRankingSubLevelInfo> _parser = new MessageParser<RhythmPlayerRankingSubLevelInfo>(() => new RhythmPlayerRankingSubLevelInfo());

		// Token: 0x04007E16 RID: 32278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E17 RID: 32279
		public const int SubLevelIdFieldNumber = 1;

		// Token: 0x04007E18 RID: 32280
		private int subLevelId_;

		// Token: 0x04007E19 RID: 32281
		public const int RhythmRoleIdFieldNumber = 2;

		// Token: 0x04007E1A RID: 32282
		private int rhythmRoleId_;

		// Token: 0x04007E1B RID: 32283
		public const int ScoreFieldNumber = 3;

		// Token: 0x04007E1C RID: 32284
		private int score_;

		// Token: 0x04007E1D RID: 32285
		public const int AccuracyFieldNumber = 4;

		// Token: 0x04007E1E RID: 32286
		private int accuracy_;
	}
}
