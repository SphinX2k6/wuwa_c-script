using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B81 RID: 2945
	public sealed class OneSynthesisInfo : IMessage<OneSynthesisInfo>, IMessage, IEquatable<OneSynthesisInfo>, IDeepCloneable<OneSynthesisInfo>, IBufferMessage
	{
		// Token: 0x0600FFCA RID: 65482 RVA: 0x00255A6E File Offset: 0x00253C6E
		[NullableContext(1)]
		public static OneSynthesisInfo Create()
		{
			return new OneSynthesisInfo();
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600FFCB RID: 65483 RVA: 0x00255A75 File Offset: 0x00253C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneSynthesisInfo> Parser
		{
			get
			{
				return OneSynthesisInfo._parser;
			}
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600FFCC RID: 65484 RVA: 0x00255A7C File Offset: 0x00253C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600FFCD RID: 65485 RVA: 0x00255A7F File Offset: 0x00253C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneSynthesisInfo.Descriptor;
			}
		}

		// Token: 0x0600FFCE RID: 65486 RVA: 0x00255A86 File Offset: 0x00253C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisInfo()
		{
		}

		// Token: 0x0600FFCF RID: 65487 RVA: 0x00255A90 File Offset: 0x00253C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisInfo(OneSynthesisInfo other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.lastRoleId_ = other.lastRoleId_;
			this.limitCount_ = other.limitCount_;
			this.limitSynthesisCount_ = other.limitSynthesisCount_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FFD0 RID: 65488 RVA: 0x00255B08 File Offset: 0x00253D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisInfo Clone()
		{
			return new OneSynthesisInfo(this);
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600FFD1 RID: 65489 RVA: 0x00255B10 File Offset: 0x00253D10
		// (set) Token: 0x0600FFD2 RID: 65490 RVA: 0x00255B18 File Offset: 0x00253D18
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

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600FFD3 RID: 65491 RVA: 0x00255B21 File Offset: 0x00253D21
		// (set) Token: 0x0600FFD4 RID: 65492 RVA: 0x00255B29 File Offset: 0x00253D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600FFD5 RID: 65493 RVA: 0x00255B32 File Offset: 0x00253D32
		// (set) Token: 0x0600FFD6 RID: 65494 RVA: 0x00255B3A File Offset: 0x00253D3A
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

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600FFD7 RID: 65495 RVA: 0x00255B43 File Offset: 0x00253D43
		// (set) Token: 0x0600FFD8 RID: 65496 RVA: 0x00255B4B File Offset: 0x00253D4B
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

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600FFD9 RID: 65497 RVA: 0x00255B54 File Offset: 0x00253D54
		// (set) Token: 0x0600FFDA RID: 65498 RVA: 0x00255B5C File Offset: 0x00253D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LimitSynthesisCount
		{
			get
			{
				return this.limitSynthesisCount_;
			}
			set
			{
				this.limitSynthesisCount_ = value;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600FFDB RID: 65499 RVA: 0x00255B65 File Offset: 0x00253D65
		// (set) Token: 0x0600FFDC RID: 65500 RVA: 0x00255B6D File Offset: 0x00253D6D
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

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600FFDD RID: 65501 RVA: 0x00255B76 File Offset: 0x00253D76
		// (set) Token: 0x0600FFDE RID: 65502 RVA: 0x00255B7E File Offset: 0x00253D7E
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

		// Token: 0x0600FFDF RID: 65503 RVA: 0x00255B87 File Offset: 0x00253D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneSynthesisInfo);
		}

		// Token: 0x0600FFE0 RID: 65504 RVA: 0x00255B98 File Offset: 0x00253D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneSynthesisInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.LastRoleId == other.LastRoleId && this.LimitCount == other.LimitCount && this.LimitSynthesisCount == other.LimitSynthesisCount && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FFE1 RID: 65505 RVA: 0x00255C34 File Offset: 0x00253E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.LastRoleId != 0)
			{
				num ^= this.LastRoleId.GetHashCode();
			}
			if (this.LimitCount != 0)
			{
				num ^= this.LimitCount.GetHashCode();
			}
			if (this.LimitSynthesisCount != 0)
			{
				num ^= this.LimitSynthesisCount.GetHashCode();
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

		// Token: 0x0600FFE2 RID: 65506 RVA: 0x00255D09 File Offset: 0x00253F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FFE3 RID: 65507 RVA: 0x00255D16 File Offset: 0x00253F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FFE4 RID: 65508 RVA: 0x00255D20 File Offset: 0x00253F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
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
			if (this.LimitSynthesisCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LimitSynthesisCount);
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

		// Token: 0x0600FFE5 RID: 65509 RVA: 0x00255E04 File Offset: 0x00254004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.LastRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRoleId);
			}
			if (this.LimitCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitCount);
			}
			if (this.LimitSynthesisCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LimitSynthesisCount);
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

		// Token: 0x0600FFE6 RID: 65510 RVA: 0x00255ED4 File Offset: 0x002540D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneSynthesisInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.LastRoleId != 0)
			{
				this.LastRoleId = other.LastRoleId;
			}
			if (other.LimitCount != 0)
			{
				this.LimitCount = other.LimitCount;
			}
			if (other.LimitSynthesisCount != 0)
			{
				this.LimitSynthesisCount = other.LimitSynthesisCount;
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

		// Token: 0x0600FFE7 RID: 65511 RVA: 0x00255F88 File Offset: 0x00254188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FFE8 RID: 65512 RVA: 0x00255F94 File Offset: 0x00254194
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
						this.Count = input.ReadInt32();
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
						this.LimitSynthesisCount = input.ReadInt32();
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

		// Token: 0x04006660 RID: 26208
		private static readonly MessageParser<OneSynthesisInfo> _parser = new MessageParser<OneSynthesisInfo>(() => new OneSynthesisInfo());

		// Token: 0x04006661 RID: 26209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006662 RID: 26210
		public const int IdFieldNumber = 1;

		// Token: 0x04006663 RID: 26211
		private int id_;

		// Token: 0x04006664 RID: 26212
		public const int CountFieldNumber = 2;

		// Token: 0x04006665 RID: 26213
		private int count_;

		// Token: 0x04006666 RID: 26214
		public const int LastRoleIdFieldNumber = 3;

		// Token: 0x04006667 RID: 26215
		private int lastRoleId_;

		// Token: 0x04006668 RID: 26216
		public const int LimitCountFieldNumber = 4;

		// Token: 0x04006669 RID: 26217
		private int limitCount_;

		// Token: 0x0400666A RID: 26218
		public const int LimitSynthesisCountFieldNumber = 5;

		// Token: 0x0400666B RID: 26219
		private int limitSynthesisCount_;

		// Token: 0x0400666C RID: 26220
		public const int LimitBeginTimeFieldNumber = 6;

		// Token: 0x0400666D RID: 26221
		private long limitBeginTime_;

		// Token: 0x0400666E RID: 26222
		public const int LimitEndTimeFieldNumber = 7;

		// Token: 0x0400666F RID: 26223
		private long limitEndTime_;
	}
}
