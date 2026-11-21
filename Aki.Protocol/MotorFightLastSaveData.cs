using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A34 RID: 2612
	public sealed class MotorFightLastSaveData : IMessage<MotorFightLastSaveData>, IMessage, IEquatable<MotorFightLastSaveData>, IDeepCloneable<MotorFightLastSaveData>, IBufferMessage
	{
		// Token: 0x0600E461 RID: 58465 RVA: 0x002168DD File Offset: 0x00214ADD
		[NullableContext(1)]
		public static MotorFightLastSaveData Create()
		{
			return new MotorFightLastSaveData();
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0600E462 RID: 58466 RVA: 0x002168E4 File Offset: 0x00214AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0600E463 RID: 58467 RVA: 0x002168E7 File Offset: 0x00214AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightLastSaveData.Descriptor;
			}
		}

		// Token: 0x0600E464 RID: 58468 RVA: 0x002168EE File Offset: 0x00214AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveData()
		{
		}

		// Token: 0x0600E465 RID: 58469 RVA: 0x002168F6 File Offset: 0x00214AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveData(MotorFightLastSaveData other) : this()
		{
			this.levelId_ = other.levelId_;
			this.costTime_ = other.costTime_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E466 RID: 58470 RVA: 0x00216933 File Offset: 0x00214B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightLastSaveData Clone()
		{
			return new MotorFightLastSaveData(this);
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x0600E467 RID: 58471 RVA: 0x0021693B File Offset: 0x00214B3B
		// (set) Token: 0x0600E468 RID: 58472 RVA: 0x00216943 File Offset: 0x00214B43
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

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600E469 RID: 58473 RVA: 0x0021694C File Offset: 0x00214B4C
		// (set) Token: 0x0600E46A RID: 58474 RVA: 0x00216954 File Offset: 0x00214B54
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

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600E46B RID: 58475 RVA: 0x0021695D File Offset: 0x00214B5D
		// (set) Token: 0x0600E46C RID: 58476 RVA: 0x00216965 File Offset: 0x00214B65
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

		// Token: 0x0600E46D RID: 58477 RVA: 0x0021696E File Offset: 0x00214B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightLastSaveData);
		}

		// Token: 0x0600E46E RID: 58478 RVA: 0x0021697C File Offset: 0x00214B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightLastSaveData other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.CostTime == other.CostTime && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E46F RID: 58479 RVA: 0x002169D8 File Offset: 0x00214BD8
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

		// Token: 0x0600E470 RID: 58480 RVA: 0x00216A49 File Offset: 0x00214C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E471 RID: 58481 RVA: 0x00216A56 File Offset: 0x00214C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E472 RID: 58482 RVA: 0x00216A60 File Offset: 0x00214C60
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

		// Token: 0x0600E473 RID: 58483 RVA: 0x00216AD4 File Offset: 0x00214CD4
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

		// Token: 0x0600E474 RID: 58484 RVA: 0x00216B44 File Offset: 0x00214D44
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

		// Token: 0x0600E475 RID: 58485 RVA: 0x00216BA8 File Offset: 0x00214DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E476 RID: 58486 RVA: 0x00216BB4 File Offset: 0x00214DB4
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

		// Token: 0x04005DC9 RID: 24009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DCA RID: 24010
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005DCB RID: 24011
		private int levelId_;

		// Token: 0x04005DCC RID: 24012
		public const int CostTimeFieldNumber = 2;

		// Token: 0x04005DCD RID: 24013
		private long costTime_;

		// Token: 0x04005DCE RID: 24014
		public const int ScoreFieldNumber = 3;

		// Token: 0x04005DCF RID: 24015
		private int score_;
	}
}
