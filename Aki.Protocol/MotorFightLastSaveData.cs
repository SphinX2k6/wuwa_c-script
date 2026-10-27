using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A45 RID: 2629
	public sealed class MotorFightLastSaveData : IMessage<MotorFightLastSaveData>, IMessage, IEquatable<MotorFightLastSaveData>, IDeepCloneable<MotorFightLastSaveData>, IBufferMessage
	{
		// Token: 0x0600E57B RID: 58747 RVA: 0x00218AD1 File Offset: 0x00216CD1
		[NullableContext(1)]
		public static MotorFightLastSaveData Create()
		{
			return new MotorFightLastSaveData();
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x0600E57C RID: 58748 RVA: 0x00218AD8 File Offset: 0x00216CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600E57D RID: 58749 RVA: 0x00218ADB File Offset: 0x00216CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLastSaveData.Descriptor;
			}
		}

		// Token: 0x0600E57E RID: 58750 RVA: 0x00218AE2 File Offset: 0x00216CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveData()
		{
		}

		// Token: 0x0600E57F RID: 58751 RVA: 0x00218AEA File Offset: 0x00216CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveData(MotorFightLastSaveData other) : this()
		{
			this.levelId_ = other.levelId_;
			this.costTime_ = other.costTime_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E580 RID: 58752 RVA: 0x00218B27 File Offset: 0x00216D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveData Clone()
		{
			return new MotorFightLastSaveData(this);
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600E581 RID: 58753 RVA: 0x00218B2F File Offset: 0x00216D2F
		// (set) Token: 0x0600E582 RID: 58754 RVA: 0x00218B37 File Offset: 0x00216D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600E583 RID: 58755 RVA: 0x00218B40 File Offset: 0x00216D40
		// (set) Token: 0x0600E584 RID: 58756 RVA: 0x00218B48 File Offset: 0x00216D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x0600E585 RID: 58757 RVA: 0x00218B51 File Offset: 0x00216D51
		// (set) Token: 0x0600E586 RID: 58758 RVA: 0x00218B59 File Offset: 0x00216D59
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

		// Token: 0x0600E587 RID: 58759 RVA: 0x00218B62 File Offset: 0x00216D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLastSaveData);
		}

		// Token: 0x0600E588 RID: 58760 RVA: 0x00218B70 File Offset: 0x00216D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLastSaveData other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.CostTime == other.CostTime && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E589 RID: 58761 RVA: 0x00218BCC File Offset: 0x00216DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.CostTime != 0L)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E58A RID: 58762 RVA: 0x00218C3D File Offset: 0x00216E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E58B RID: 58763 RVA: 0x00218C4A File Offset: 0x00216E4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E58C RID: 58764 RVA: 0x00218C54 File Offset: 0x00216E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.CostTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.CostTime);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E58D RID: 58765 RVA: 0x00218CC8 File Offset: 0x00216EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.CostTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CostTime);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E58E RID: 58766 RVA: 0x00218D38 File Offset: 0x00216F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightLastSaveData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.CostTime != 0L)
			{
				this.CostTime = other.CostTime;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E58F RID: 58767 RVA: 0x00218D9C File Offset: 0x00216F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E590 RID: 58768 RVA: 0x00218DA8 File Offset: 0x00216FA8
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Score = input.ReadInt32();
						}
					}
					else
					{
						this.CostTime = input.ReadInt64();
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005DC0 RID: 24000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DC1 RID: 24001
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005DC2 RID: 24002
		private int levelId_;

		// Token: 0x04005DC3 RID: 24003
		public const int CostTimeFieldNumber = 2;

		// Token: 0x04005DC4 RID: 24004
		private long costTime_;

		// Token: 0x04005DC5 RID: 24005
		public const int ScoreFieldNumber = 3;

		// Token: 0x04005DC6 RID: 24006
		private int score_;
	}
}
