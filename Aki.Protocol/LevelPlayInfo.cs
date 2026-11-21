using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EC RID: 2284
	public sealed class LevelPlayInfo : IMessage<LevelPlayInfo>, IMessage, IEquatable<LevelPlayInfo>, IDeepCloneable<LevelPlayInfo>, IBufferMessage
	{
		// Token: 0x0600CA2C RID: 51756 RVA: 0x001DD9F3 File Offset: 0x001DBBF3
		[NullableContext(1)]
		public static LevelPlayInfo Create()
		{
			return new LevelPlayInfo();
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x0600CA2D RID: 51757 RVA: 0x001DD9FA File Offset: 0x001DBBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayInfo> Parser
		{
			get
			{
				return LevelPlayInfo._parser;
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600CA2E RID: 51758 RVA: 0x001DDA01 File Offset: 0x001DBC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x0600CA2F RID: 51759 RVA: 0x001DDA04 File Offset: 0x001DBC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x0600CA30 RID: 51760 RVA: 0x001DDA0B File Offset: 0x001DBC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfo()
		{
		}

		// Token: 0x0600CA31 RID: 51761 RVA: 0x001DDA14 File Offset: 0x001DBC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfo(LevelPlayInfo other) : this()
		{
			this.id_ = other.id_;
			this.isFirst_ = other.isFirst_;
			this.state_ = other.state_;
			this.updateTime_ = other.updateTime_;
			this.getRewardCount_ = other.getRewardCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA32 RID: 51762 RVA: 0x001DDA74 File Offset: 0x001DBC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfo Clone()
		{
			return new LevelPlayInfo(this);
		}

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x0600CA33 RID: 51763 RVA: 0x001DDA7C File Offset: 0x001DBC7C
		// (set) Token: 0x0600CA34 RID: 51764 RVA: 0x001DDA84 File Offset: 0x001DBC84
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

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x0600CA35 RID: 51765 RVA: 0x001DDA8D File Offset: 0x001DBC8D
		// (set) Token: 0x0600CA36 RID: 51766 RVA: 0x001DDA95 File Offset: 0x001DBC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFirst
		{
			get
			{
				return this.isFirst_;
			}
			set
			{
				this.isFirst_ = value;
			}
		}

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x0600CA37 RID: 51767 RVA: 0x001DDA9E File Offset: 0x001DBC9E
		// (set) Token: 0x0600CA38 RID: 51768 RVA: 0x001DDAA6 File Offset: 0x001DBCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x0600CA39 RID: 51769 RVA: 0x001DDAAF File Offset: 0x001DBCAF
		// (set) Token: 0x0600CA3A RID: 51770 RVA: 0x001DDAB7 File Offset: 0x001DBCB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpdateTime
		{
			get
			{
				return this.updateTime_;
			}
			set
			{
				this.updateTime_ = value;
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600CA3B RID: 51771 RVA: 0x001DDAC0 File Offset: 0x001DBCC0
		// (set) Token: 0x0600CA3C RID: 51772 RVA: 0x001DDAC8 File Offset: 0x001DBCC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GetRewardCount
		{
			get
			{
				return this.getRewardCount_;
			}
			set
			{
				this.getRewardCount_ = value;
			}
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x001DDAD1 File Offset: 0x001DBCD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayInfo);
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x001DDAE0 File Offset: 0x001DBCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsFirst == other.IsFirst && this.State == other.State && this.UpdateTime == other.UpdateTime && this.GetRewardCount == other.GetRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA3F RID: 51775 RVA: 0x001DDB5C File Offset: 0x001DBD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsFirst)
			{
				num ^= this.IsFirst.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.UpdateTime != 0L)
			{
				num ^= this.UpdateTime.GetHashCode();
			}
			if (this.GetRewardCount != 0)
			{
				num ^= this.GetRewardCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x001DDBFF File Offset: 0x001DBDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA41 RID: 51777 RVA: 0x001DDC0C File Offset: 0x001DBE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA42 RID: 51778 RVA: 0x001DDC18 File Offset: 0x001DBE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsFirst)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsFirst);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.State);
			}
			if (this.UpdateTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.UpdateTime);
			}
			if (this.GetRewardCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GetRewardCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA43 RID: 51779 RVA: 0x001DDCC4 File Offset: 0x001DBEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsFirst)
			{
				num += 2;
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.UpdateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpdateTime);
			}
			if (this.GetRewardCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GetRewardCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA44 RID: 51780 RVA: 0x001DDD58 File Offset: 0x001DBF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsFirst)
			{
				this.IsFirst = other.IsFirst;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.UpdateTime != 0L)
			{
				this.UpdateTime = other.UpdateTime;
			}
			if (other.GetRewardCount != 0)
			{
				this.GetRewardCount = other.GetRewardCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x001DDDE4 File Offset: 0x001DBFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x001DDDF0 File Offset: 0x001DBFF0
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsFirst = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.State = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.UpdateTime = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.GetRewardCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005664 RID: 22116
		private static readonly MessageParser<LevelPlayInfo> _parser = new MessageParser<LevelPlayInfo>(() => new LevelPlayInfo());

		// Token: 0x04005665 RID: 22117
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005666 RID: 22118
		public const int IdFieldNumber = 1;

		// Token: 0x04005667 RID: 22119
		private int id_;

		// Token: 0x04005668 RID: 22120
		public const int IsFirstFieldNumber = 2;

		// Token: 0x04005669 RID: 22121
		private bool isFirst_;

		// Token: 0x0400566A RID: 22122
		public const int StateFieldNumber = 3;

		// Token: 0x0400566B RID: 22123
		private int state_;

		// Token: 0x0400566C RID: 22124
		public const int UpdateTimeFieldNumber = 4;

		// Token: 0x0400566D RID: 22125
		private long updateTime_;

		// Token: 0x0400566E RID: 22126
		public const int GetRewardCountFieldNumber = 5;

		// Token: 0x0400566F RID: 22127
		private int getRewardCount_;
	}
}
