using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001269 RID: 4713
	public sealed class SingleFoodFormulaInfo : IMessage<SingleFoodFormulaInfo>, IMessage, IEquatable<SingleFoodFormulaInfo>, IDeepCloneable<SingleFoodFormulaInfo>, IBufferMessage
	{
		// Token: 0x06019291 RID: 103057 RVA: 0x003AB73C File Offset: 0x003A993C
		[NullableContext(1)]
		public static SingleFoodFormulaInfo Create()
		{
			return new SingleFoodFormulaInfo();
		}

		// Token: 0x1700550D RID: 21773
		// (get) Token: 0x06019292 RID: 103058 RVA: 0x003AB743 File Offset: 0x003A9943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleFoodFormulaInfo> Parser
		{
			get
			{
				return SingleFoodFormulaInfo._parser;
			}
		}

		// Token: 0x1700550E RID: 21774
		// (get) Token: 0x06019293 RID: 103059 RVA: 0x003AB74A File Offset: 0x003A994A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700550F RID: 21775
		// (get) Token: 0x06019294 RID: 103060 RVA: 0x003AB74D File Offset: 0x003A994D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleFoodFormulaInfo.Descriptor;
			}
		}

		// Token: 0x06019295 RID: 103061 RVA: 0x003AB754 File Offset: 0x003A9954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleFoodFormulaInfo()
		{
		}

		// Token: 0x06019296 RID: 103062 RVA: 0x003AB75C File Offset: 0x003A995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleFoodFormulaInfo(SingleFoodFormulaInfo other) : this()
		{
			this.id_ = other.id_;
			this.cookCount_ = other.cookCount_;
			this.lastRoleId_ = other.lastRoleId_;
			this.limitCount_ = other.limitCount_;
			this.limitCookCount_ = other.limitCookCount_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019297 RID: 103063 RVA: 0x003AB7D4 File Offset: 0x003A99D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleFoodFormulaInfo Clone()
		{
			return new SingleFoodFormulaInfo(this);
		}

		// Token: 0x17005510 RID: 21776
		// (get) Token: 0x06019298 RID: 103064 RVA: 0x003AB7DC File Offset: 0x003A99DC
		// (set) Token: 0x06019299 RID: 103065 RVA: 0x003AB7E4 File Offset: 0x003A99E4
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

		// Token: 0x17005511 RID: 21777
		// (get) Token: 0x0601929A RID: 103066 RVA: 0x003AB7ED File Offset: 0x003A99ED
		// (set) Token: 0x0601929B RID: 103067 RVA: 0x003AB7F5 File Offset: 0x003A99F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookCount
		{
			get
			{
				return this.cookCount_;
			}
			set
			{
				this.cookCount_ = value;
			}
		}

		// Token: 0x17005512 RID: 21778
		// (get) Token: 0x0601929C RID: 103068 RVA: 0x003AB7FE File Offset: 0x003A99FE
		// (set) Token: 0x0601929D RID: 103069 RVA: 0x003AB806 File Offset: 0x003A9A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastRoleId
		{
			get
			{
				return this.lastRoleId_;
			}
			set
			{
				this.lastRoleId_ = value;
			}
		}

		// Token: 0x17005513 RID: 21779
		// (get) Token: 0x0601929E RID: 103070 RVA: 0x003AB80F File Offset: 0x003A9A0F
		// (set) Token: 0x0601929F RID: 103071 RVA: 0x003AB817 File Offset: 0x003A9A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitCount
		{
			get
			{
				return this.limitCount_;
			}
			set
			{
				this.limitCount_ = value;
			}
		}

		// Token: 0x17005514 RID: 21780
		// (get) Token: 0x060192A0 RID: 103072 RVA: 0x003AB820 File Offset: 0x003A9A20
		// (set) Token: 0x060192A1 RID: 103073 RVA: 0x003AB828 File Offset: 0x003A9A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitCookCount
		{
			get
			{
				return this.limitCookCount_;
			}
			set
			{
				this.limitCookCount_ = value;
			}
		}

		// Token: 0x17005515 RID: 21781
		// (get) Token: 0x060192A2 RID: 103074 RVA: 0x003AB831 File Offset: 0x003A9A31
		// (set) Token: 0x060192A3 RID: 103075 RVA: 0x003AB839 File Offset: 0x003A9A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17005516 RID: 21782
		// (get) Token: 0x060192A4 RID: 103076 RVA: 0x003AB842 File Offset: 0x003A9A42
		// (set) Token: 0x060192A5 RID: 103077 RVA: 0x003AB84A File Offset: 0x003A9A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x060192A6 RID: 103078 RVA: 0x003AB853 File Offset: 0x003A9A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleFoodFormulaInfo);
		}

		// Token: 0x060192A7 RID: 103079 RVA: 0x003AB864 File Offset: 0x003A9A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleFoodFormulaInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CookCount == other.CookCount && this.LastRoleId == other.LastRoleId && this.LimitCount == other.LimitCount && this.LimitCookCount == other.LimitCookCount && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192A8 RID: 103080 RVA: 0x003AB900 File Offset: 0x003A9B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CookCount != 0)
			{
				num ^= this.CookCount.GetHashCode();
			}
			if (this.LastRoleId != 0)
			{
				num ^= this.LastRoleId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.LimitCookCount != 0)
			{
				num ^= this.LimitCookCount.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060192A9 RID: 103081 RVA: 0x003AB9D5 File Offset: 0x003A9BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192AA RID: 103082 RVA: 0x003AB9E2 File Offset: 0x003A9BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192AB RID: 103083 RVA: 0x003AB9EC File Offset: 0x003A9BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CookCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CookCount);
			}
			if (this.LastRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LimitCount);
			}
			if (this.LimitCookCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitCookCount);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060192AC RID: 103084 RVA: 0x003ABAD0 File Offset: 0x003A9CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CookCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookCount);
			}
			if (this.LastRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.LimitCookCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCookCount);
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060192AD RID: 103085 RVA: 0x003ABBA0 File Offset: 0x003A9DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleFoodFormulaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CookCount != 0)
			{
				this.CookCount = other.CookCount;
			}
			if (other.LastRoleId != 0)
			{
				this.LastRoleId = other.LastRoleId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.LimitCookCount != 0)
			{
				this.LimitCookCount = other.LimitCookCount;
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060192AE RID: 103086 RVA: 0x003ABC54 File Offset: 0x003A9E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060192AF RID: 103087 RVA: 0x003ABC60 File Offset: 0x003A9E60
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CookCount = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LastRoleId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.LimitCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LimitCookCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.LimitBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.LimitEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040094F4 RID: 38132
		private static readonly MessageParser<SingleFoodFormulaInfo> _parser = new MessageParser<SingleFoodFormulaInfo>(() => new SingleFoodFormulaInfo());

		// Token: 0x040094F5 RID: 38133
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094F6 RID: 38134
		public const int IdFieldNumber = 1;

		// Token: 0x040094F7 RID: 38135
		private int id_;

		// Token: 0x040094F8 RID: 38136
		public const int CookCountFieldNumber = 2;

		// Token: 0x040094F9 RID: 38137
		private int cookCount_;

		// Token: 0x040094FA RID: 38138
		public const int LastRoleIdFieldNumber = 3;

		// Token: 0x040094FB RID: 38139
		private int lastRoleId_;

		// Token: 0x040094FC RID: 38140
		public const int LimitCountFieldNumber = 4;

		// Token: 0x040094FD RID: 38141
		private int limitCount_;

		// Token: 0x040094FE RID: 38142
		public const int LimitCookCountFieldNumber = 5;

		// Token: 0x040094FF RID: 38143
		private int limitCookCount_;

		// Token: 0x04009500 RID: 38144
		public const int LimitBeginTimeFieldNumber = 6;

		// Token: 0x04009501 RID: 38145
		private long limitBeginTime_;

		// Token: 0x04009502 RID: 38146
		public const int LimitEndTimeFieldNumber = 7;

		// Token: 0x04009503 RID: 38147
		private long limitEndTime_;
	}
}
