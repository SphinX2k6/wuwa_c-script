using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FD RID: 2301
	public sealed class LevelPlayInfo : IMessage<LevelPlayInfo>, IMessage, IEquatable<LevelPlayInfo>, IDeepCloneable<LevelPlayInfo>, IBufferMessage
	{
		// Token: 0x0600CB48 RID: 52040 RVA: 0x001DFCCF File Offset: 0x001DDECF
		[NullableContext(1)]
		public static LevelPlayInfo Create()
		{
			return new LevelPlayInfo();
		}

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x0600CB49 RID: 52041 RVA: 0x001DFCD6 File Offset: 0x001DDED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayInfo> Parser
		{
			get
			{
				return LevelPlayInfo._parser;
			}
		}

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x0600CB4A RID: 52042 RVA: 0x001DFCDD File Offset: 0x001DDEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x0600CB4B RID: 52043 RVA: 0x001DFCE0 File Offset: 0x001DDEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayInfo.Descriptor;
			}
		}

		// Token: 0x0600CB4C RID: 52044 RVA: 0x001DFCE7 File Offset: 0x001DDEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfo()
		{
		}

		// Token: 0x0600CB4D RID: 52045 RVA: 0x001DFCF0 File Offset: 0x001DDEF0
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

		// Token: 0x0600CB4E RID: 52046 RVA: 0x001DFD50 File Offset: 0x001DDF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayInfo Clone()
		{
			return new LevelPlayInfo(this);
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x0600CB4F RID: 52047 RVA: 0x001DFD58 File Offset: 0x001DDF58
		// (set) Token: 0x0600CB50 RID: 52048 RVA: 0x001DFD60 File Offset: 0x001DDF60
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

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x0600CB51 RID: 52049 RVA: 0x001DFD69 File Offset: 0x001DDF69
		// (set) Token: 0x0600CB52 RID: 52050 RVA: 0x001DFD71 File Offset: 0x001DDF71
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

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x0600CB53 RID: 52051 RVA: 0x001DFD7A File Offset: 0x001DDF7A
		// (set) Token: 0x0600CB54 RID: 52052 RVA: 0x001DFD82 File Offset: 0x001DDF82
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

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x0600CB55 RID: 52053 RVA: 0x001DFD8B File Offset: 0x001DDF8B
		// (set) Token: 0x0600CB56 RID: 52054 RVA: 0x001DFD93 File Offset: 0x001DDF93
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

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x0600CB57 RID: 52055 RVA: 0x001DFD9C File Offset: 0x001DDF9C
		// (set) Token: 0x0600CB58 RID: 52056 RVA: 0x001DFDA4 File Offset: 0x001DDFA4
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

		// Token: 0x0600CB59 RID: 52057 RVA: 0x001DFDAD File Offset: 0x001DDFAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayInfo);
		}

		// Token: 0x0600CB5A RID: 52058 RVA: 0x001DFDBC File Offset: 0x001DDFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsFirst == other.IsFirst && this.State == other.State && this.UpdateTime == other.UpdateTime && this.GetRewardCount == other.GetRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x001DFE38 File Offset: 0x001DE038
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

		// Token: 0x0600CB5C RID: 52060 RVA: 0x001DFEDB File Offset: 0x001DE0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB5D RID: 52061 RVA: 0x001DFEE8 File Offset: 0x001DE0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x001DFEF4 File Offset: 0x001DE0F4
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

		// Token: 0x0600CB5F RID: 52063 RVA: 0x001DFFA0 File Offset: 0x001DE1A0
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

		// Token: 0x0600CB60 RID: 52064 RVA: 0x001E0034 File Offset: 0x001DE234
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

		// Token: 0x0600CB61 RID: 52065 RVA: 0x001E00C0 File Offset: 0x001DE2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB62 RID: 52066 RVA: 0x001E00CC File Offset: 0x001DE2CC
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

		// Token: 0x0400565D RID: 22109
		private static readonly MessageParser<LevelPlayInfo> _parser = new MessageParser<LevelPlayInfo>(() => new LevelPlayInfo());

		// Token: 0x0400565E RID: 22110
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400565F RID: 22111
		public const int IdFieldNumber = 1;

		// Token: 0x04005660 RID: 22112
		private int id_;

		// Token: 0x04005661 RID: 22113
		public const int IsFirstFieldNumber = 2;

		// Token: 0x04005662 RID: 22114
		private bool isFirst_;

		// Token: 0x04005663 RID: 22115
		public const int StateFieldNumber = 3;

		// Token: 0x04005664 RID: 22116
		private int state_;

		// Token: 0x04005665 RID: 22117
		public const int UpdateTimeFieldNumber = 4;

		// Token: 0x04005666 RID: 22118
		private long updateTime_;

		// Token: 0x04005667 RID: 22119
		public const int GetRewardCountFieldNumber = 5;

		// Token: 0x04005668 RID: 22120
		private int getRewardCount_;
	}
}
