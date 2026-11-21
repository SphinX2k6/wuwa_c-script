using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E6 RID: 2278
	[NetMessage(EMessageId.LevelPlayerRewardHintNotify)]
	public sealed class LevelPlayerRewardHintNotify : IMessage<LevelPlayerRewardHintNotify>, IMessage, IEquatable<LevelPlayerRewardHintNotify>, IDeepCloneable<LevelPlayerRewardHintNotify>, IBufferMessage
	{
		// Token: 0x0600C9B6 RID: 51638 RVA: 0x001DCB00 File Offset: 0x001DAD00
		[NullableContext(1)]
		public static LevelPlayerRewardHintNotify Create()
		{
			return new LevelPlayerRewardHintNotify();
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600C9B7 RID: 51639 RVA: 0x001DCB07 File Offset: 0x001DAD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x0600C9B8 RID: 51640 RVA: 0x001DCB0A File Offset: 0x001DAD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayerRewardHintNotify.Descriptor;
			}
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x001DCB11 File Offset: 0x001DAD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayerRewardHintNotify()
		{
		}

		// Token: 0x0600C9BA RID: 51642 RVA: 0x001DCB19 File Offset: 0x001DAD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayerRewardHintNotify(LevelPlayerRewardHintNotify other) : this()
		{
			this.id_ = other.id_;
			this.resetTime_ = other.resetTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9BB RID: 51643 RVA: 0x001DCB4A File Offset: 0x001DAD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayerRewardHintNotify Clone()
		{
			return new LevelPlayerRewardHintNotify(this);
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x001DCB52 File Offset: 0x001DAD52
		// (set) Token: 0x0600C9BD RID: 51645 RVA: 0x001DCB5A File Offset: 0x001DAD5A
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

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x0600C9BE RID: 51646 RVA: 0x001DCB63 File Offset: 0x001DAD63
		// (set) Token: 0x0600C9BF RID: 51647 RVA: 0x001DCB6B File Offset: 0x001DAD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ResetTime
		{
			get
			{
				return this.resetTime_;
			}
			set
			{
				this.resetTime_ = value;
			}
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x001DCB74 File Offset: 0x001DAD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayerRewardHintNotify);
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x001DCB82 File Offset: 0x001DAD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayerRewardHintNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ResetTime == other.ResetTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x001DCBC0 File Offset: 0x001DADC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ResetTime != 0L)
			{
				num ^= this.ResetTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x001DCC18 File Offset: 0x001DAE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x001DCC25 File Offset: 0x001DAE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9C5 RID: 51653 RVA: 0x001DCC30 File Offset: 0x001DAE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this.ResetTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.ResetTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9C6 RID: 51654 RVA: 0x001DCC8C File Offset: 0x001DAE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ResetTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ResetTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9C7 RID: 51655 RVA: 0x001DCCE4 File Offset: 0x001DAEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayerRewardHintNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ResetTime != 0L)
			{
				this.ResetTime = other.ResetTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9C8 RID: 51656 RVA: 0x001DCD34 File Offset: 0x001DAF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9C9 RID: 51657 RVA: 0x001DCD40 File Offset: 0x001DAF40
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
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ResetTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005644 RID: 22084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005645 RID: 22085
		public const int IdFieldNumber = 2;

		// Token: 0x04005646 RID: 22086
		private int id_;

		// Token: 0x04005647 RID: 22087
		public const int ResetTimeFieldNumber = 13;

		// Token: 0x04005648 RID: 22088
		private long resetTime_;
	}
}
