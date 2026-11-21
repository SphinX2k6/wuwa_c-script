using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B79 RID: 2937
	public sealed class OneForgeInfo : IMessage<OneForgeInfo>, IMessage, IEquatable<OneForgeInfo>, IDeepCloneable<OneForgeInfo>, IBufferMessage
	{
		// Token: 0x0600FF0A RID: 65290 RVA: 0x00253D92 File Offset: 0x00251F92
		[NullableContext(1)]
		public static OneForgeInfo Create()
		{
			return new OneForgeInfo();
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600FF0B RID: 65291 RVA: 0x00253D99 File Offset: 0x00251F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneForgeInfo> Parser
		{
			get
			{
				return OneForgeInfo._parser;
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600FF0C RID: 65292 RVA: 0x00253DA0 File Offset: 0x00251FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600FF0D RID: 65293 RVA: 0x00253DA3 File Offset: 0x00251FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneForgeInfo.Descriptor;
			}
		}

		// Token: 0x0600FF0E RID: 65294 RVA: 0x00253DAA File Offset: 0x00251FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeInfo()
		{
		}

		// Token: 0x0600FF0F RID: 65295 RVA: 0x00253DB4 File Offset: 0x00251FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeInfo(OneForgeInfo other) : this()
		{
			this.id_ = other.id_;
			this.lastRoleId_ = other.lastRoleId_;
			this.limitCount_ = other.limitCount_;
			this.limitForgeCount_ = other.limitForgeCount_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF10 RID: 65296 RVA: 0x00253E20 File Offset: 0x00252020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeInfo Clone()
		{
			return new OneForgeInfo(this);
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600FF11 RID: 65297 RVA: 0x00253E28 File Offset: 0x00252028
		// (set) Token: 0x0600FF12 RID: 65298 RVA: 0x00253E30 File Offset: 0x00252030
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

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600FF13 RID: 65299 RVA: 0x00253E39 File Offset: 0x00252039
		// (set) Token: 0x0600FF14 RID: 65300 RVA: 0x00253E41 File Offset: 0x00252041
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

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600FF15 RID: 65301 RVA: 0x00253E4A File Offset: 0x0025204A
		// (set) Token: 0x0600FF16 RID: 65302 RVA: 0x00253E52 File Offset: 0x00252052
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

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600FF17 RID: 65303 RVA: 0x00253E5B File Offset: 0x0025205B
		// (set) Token: 0x0600FF18 RID: 65304 RVA: 0x00253E63 File Offset: 0x00252063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitForgeCount
		{
			get
			{
				return this.limitForgeCount_;
			}
			set
			{
				this.limitForgeCount_ = value;
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600FF19 RID: 65305 RVA: 0x00253E6C File Offset: 0x0025206C
		// (set) Token: 0x0600FF1A RID: 65306 RVA: 0x00253E74 File Offset: 0x00252074
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

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600FF1B RID: 65307 RVA: 0x00253E7D File Offset: 0x0025207D
		// (set) Token: 0x0600FF1C RID: 65308 RVA: 0x00253E85 File Offset: 0x00252085
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

		// Token: 0x0600FF1D RID: 65309 RVA: 0x00253E8E File Offset: 0x0025208E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneForgeInfo);
		}

		// Token: 0x0600FF1E RID: 65310 RVA: 0x00253E9C File Offset: 0x0025209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneForgeInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LastRoleId == other.LastRoleId && this.LimitCount == other.LimitCount && this.LimitForgeCount == other.LimitForgeCount && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF1F RID: 65311 RVA: 0x00253F28 File Offset: 0x00252128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LastRoleId != 0)
			{
				num ^= this.LastRoleId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.LimitForgeCount != 0)
			{
				num ^= this.LimitForgeCount.GetHashCode();
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

		// Token: 0x0600FF20 RID: 65312 RVA: 0x00253FE4 File Offset: 0x002521E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF21 RID: 65313 RVA: 0x00253FF1 File Offset: 0x002521F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF22 RID: 65314 RVA: 0x00253FFC File Offset: 0x002521FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
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
			if (this.LimitForgeCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitForgeCount);
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

		// Token: 0x0600FF23 RID: 65315 RVA: 0x002540C4 File Offset: 0x002522C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LastRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.LimitForgeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitForgeCount);
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

		// Token: 0x0600FF24 RID: 65316 RVA: 0x0025417C File Offset: 0x0025237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneForgeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LastRoleId != 0)
			{
				this.LastRoleId = other.LastRoleId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.LimitForgeCount != 0)
			{
				this.LimitForgeCount = other.LimitForgeCount;
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

		// Token: 0x0600FF25 RID: 65317 RVA: 0x0025421C File Offset: 0x0025241C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF26 RID: 65318 RVA: 0x00254228 File Offset: 0x00252428
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LastRoleId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.LimitCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.LimitForgeCount = input.ReadInt32();
						continue;
					}
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

		// Token: 0x04006618 RID: 26136
		private static readonly MessageParser<OneForgeInfo> _parser = new MessageParser<OneForgeInfo>(() => new OneForgeInfo());

		// Token: 0x04006619 RID: 26137
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400661A RID: 26138
		public const int IdFieldNumber = 1;

		// Token: 0x0400661B RID: 26139
		private int id_;

		// Token: 0x0400661C RID: 26140
		public const int LastRoleIdFieldNumber = 3;

		// Token: 0x0400661D RID: 26141
		private int lastRoleId_;

		// Token: 0x0400661E RID: 26142
		public const int LimitCountFieldNumber = 4;

		// Token: 0x0400661F RID: 26143
		private int limitCount_;

		// Token: 0x04006620 RID: 26144
		public const int LimitForgeCountFieldNumber = 5;

		// Token: 0x04006621 RID: 26145
		private int limitForgeCount_;

		// Token: 0x04006622 RID: 26146
		public const int LimitBeginTimeFieldNumber = 6;

		// Token: 0x04006623 RID: 26147
		private long limitBeginTime_;

		// Token: 0x04006624 RID: 26148
		public const int LimitEndTimeFieldNumber = 7;

		// Token: 0x04006625 RID: 26149
		private long limitEndTime_;
	}
}
