using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B89 RID: 2953
	public sealed class OneForgeInfo : IMessage<OneForgeInfo>, IMessage, IEquatable<OneForgeInfo>, IDeepCloneable<OneForgeInfo>, IBufferMessage
	{
		// Token: 0x0601000E RID: 65550 RVA: 0x00255C62 File Offset: 0x00253E62
		[NullableContext(1)]
		public static OneForgeInfo Create()
		{
			return new OneForgeInfo();
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0601000F RID: 65551 RVA: 0x00255C69 File Offset: 0x00253E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneForgeInfo> Parser
		{
			get
			{
				return OneForgeInfo._parser;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x06010010 RID: 65552 RVA: 0x00255C70 File Offset: 0x00253E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x06010011 RID: 65553 RVA: 0x00255C73 File Offset: 0x00253E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneForgeInfo.Descriptor;
			}
		}

		// Token: 0x06010012 RID: 65554 RVA: 0x00255C7A File Offset: 0x00253E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeInfo()
		{
		}

		// Token: 0x06010013 RID: 65555 RVA: 0x00255C84 File Offset: 0x00253E84
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

		// Token: 0x06010014 RID: 65556 RVA: 0x00255CF0 File Offset: 0x00253EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeInfo Clone()
		{
			return new OneForgeInfo(this);
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x06010015 RID: 65557 RVA: 0x00255CF8 File Offset: 0x00253EF8
		// (set) Token: 0x06010016 RID: 65558 RVA: 0x00255D00 File Offset: 0x00253F00
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

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x06010017 RID: 65559 RVA: 0x00255D09 File Offset: 0x00253F09
		// (set) Token: 0x06010018 RID: 65560 RVA: 0x00255D11 File Offset: 0x00253F11
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

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x06010019 RID: 65561 RVA: 0x00255D1A File Offset: 0x00253F1A
		// (set) Token: 0x0601001A RID: 65562 RVA: 0x00255D22 File Offset: 0x00253F22
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

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0601001B RID: 65563 RVA: 0x00255D2B File Offset: 0x00253F2B
		// (set) Token: 0x0601001C RID: 65564 RVA: 0x00255D33 File Offset: 0x00253F33
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

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0601001D RID: 65565 RVA: 0x00255D3C File Offset: 0x00253F3C
		// (set) Token: 0x0601001E RID: 65566 RVA: 0x00255D44 File Offset: 0x00253F44
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

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0601001F RID: 65567 RVA: 0x00255D4D File Offset: 0x00253F4D
		// (set) Token: 0x06010020 RID: 65568 RVA: 0x00255D55 File Offset: 0x00253F55
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

		// Token: 0x06010021 RID: 65569 RVA: 0x00255D5E File Offset: 0x00253F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneForgeInfo);
		}

		// Token: 0x06010022 RID: 65570 RVA: 0x00255D6C File Offset: 0x00253F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneForgeInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LastRoleId == other.LastRoleId && this.LimitCount == other.LimitCount && this.LimitForgeCount == other.LimitForgeCount && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010023 RID: 65571 RVA: 0x00255DF8 File Offset: 0x00253FF8
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

		// Token: 0x06010024 RID: 65572 RVA: 0x00255EB4 File Offset: 0x002540B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010025 RID: 65573 RVA: 0x00255EC1 File Offset: 0x002540C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010026 RID: 65574 RVA: 0x00255ECC File Offset: 0x002540CC
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

		// Token: 0x06010027 RID: 65575 RVA: 0x00255F94 File Offset: 0x00254194
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

		// Token: 0x06010028 RID: 65576 RVA: 0x0025604C File Offset: 0x0025424C
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

		// Token: 0x06010029 RID: 65577 RVA: 0x002560EC File Offset: 0x002542EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601002A RID: 65578 RVA: 0x002560F8 File Offset: 0x002542F8
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

		// Token: 0x04006608 RID: 26120
		private static readonly MessageParser<OneForgeInfo> _parser = new MessageParser<OneForgeInfo>(() => new OneForgeInfo());

		// Token: 0x04006609 RID: 26121
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400660A RID: 26122
		public const int IdFieldNumber = 1;

		// Token: 0x0400660B RID: 26123
		private int id_;

		// Token: 0x0400660C RID: 26124
		public const int LastRoleIdFieldNumber = 3;

		// Token: 0x0400660D RID: 26125
		private int lastRoleId_;

		// Token: 0x0400660E RID: 26126
		public const int LimitCountFieldNumber = 4;

		// Token: 0x0400660F RID: 26127
		private int limitCount_;

		// Token: 0x04006610 RID: 26128
		public const int LimitForgeCountFieldNumber = 5;

		// Token: 0x04006611 RID: 26129
		private int limitForgeCount_;

		// Token: 0x04006612 RID: 26130
		public const int LimitBeginTimeFieldNumber = 6;

		// Token: 0x04006613 RID: 26131
		private long limitBeginTime_;

		// Token: 0x04006614 RID: 26132
		public const int LimitEndTimeFieldNumber = 7;

		// Token: 0x04006615 RID: 26133
		private long limitEndTime_;
	}
}
