using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000221 RID: 545
	[NetMessage(EMessageId.CalabashDevelopRewardUnlockNotify)]
	public sealed class CalabashDevelopRewardUnlockNotify : IMessage<CalabashDevelopRewardUnlockNotify>, IMessage, IEquatable<CalabashDevelopRewardUnlockNotify>, IDeepCloneable<CalabashDevelopRewardUnlockNotify>, IBufferMessage
	{
		// Token: 0x06003BC1 RID: 15297 RVA: 0x00094E81 File Offset: 0x00093081
		[NullableContext(1)]
		public static CalabashDevelopRewardUnlockNotify Create()
		{
			return new CalabashDevelopRewardUnlockNotify();
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x00094E88 File Offset: 0x00093088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x00094E8B File Offset: 0x0009308B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashDevelopRewardUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00094E92 File Offset: 0x00093092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopRewardUnlockNotify()
		{
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00094E9C File Offset: 0x0009309C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopRewardUnlockNotify(CalabashDevelopRewardUnlockNotify other) : this()
		{
			this.unlockedDevelopReward_ = ((other.unlockedDevelopReward_ != null) ? other.unlockedDevelopReward_.Clone() : null);
			this.itemId_ = other.itemId_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00094EF4 File Offset: 0x000930F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopRewardUnlockNotify Clone()
		{
			return new CalabashDevelopRewardUnlockNotify(this);
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x00094EFC File Offset: 0x000930FC
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x00094F04 File Offset: 0x00093104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopInfo UnlockedDevelopReward
		{
			get
			{
				return this.unlockedDevelopReward_;
			}
			set
			{
				this.unlockedDevelopReward_ = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x00094F0D File Offset: 0x0009310D
		// (set) Token: 0x06003BCA RID: 15306 RVA: 0x00094F15 File Offset: 0x00093115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06003BCB RID: 15307 RVA: 0x00094F1E File Offset: 0x0009311E
		// (set) Token: 0x06003BCC RID: 15308 RVA: 0x00094F26 File Offset: 0x00093126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00094F2F File Offset: 0x0009312F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashDevelopRewardUnlockNotify);
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00094F40 File Offset: 0x00093140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashDevelopRewardUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.UnlockedDevelopReward, other.UnlockedDevelopReward) && this.ItemId == other.ItemId && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00094FA0 File Offset: 0x000931A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.unlockedDevelopReward_ != null)
			{
				num ^= this.UnlockedDevelopReward.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x0009500E File Offset: 0x0009320E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x0009501B File Offset: 0x0009321B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00095024 File Offset: 0x00093224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unlockedDevelopReward_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.UnlockedDevelopReward);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.IncrId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x0009509C File Offset: 0x0009329C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.unlockedDevelopReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockedDevelopReward);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x0009510C File Offset: 0x0009330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashDevelopRewardUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.unlockedDevelopReward_ != null)
			{
				if (this.unlockedDevelopReward_ == null)
				{
					this.UnlockedDevelopReward = new CalabashDevelopInfo();
				}
				this.UnlockedDevelopReward.MergeFrom(other.UnlockedDevelopReward);
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00095188 File Offset: 0x00093388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00095194 File Offset: 0x00093394
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
				if (num != 58U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemId = input.ReadInt32();
						}
					}
					else
					{
						this.IncrId = input.ReadInt32();
					}
				}
				else
				{
					if (this.unlockedDevelopReward_ == null)
					{
						this.UnlockedDevelopReward = new CalabashDevelopInfo();
					}
					input.ReadMessage(this.UnlockedDevelopReward);
				}
			}
		}

		// Token: 0x04002C91 RID: 11409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C92 RID: 11410
		public const int UnlockedDevelopRewardFieldNumber = 7;

		// Token: 0x04002C93 RID: 11411
		private CalabashDevelopInfo unlockedDevelopReward_;

		// Token: 0x04002C94 RID: 11412
		public const int ItemIdFieldNumber = 13;

		// Token: 0x04002C95 RID: 11413
		private int itemId_;

		// Token: 0x04002C96 RID: 11414
		public const int IncrIdFieldNumber = 12;

		// Token: 0x04002C97 RID: 11415
		private int incrId_;
	}
}
