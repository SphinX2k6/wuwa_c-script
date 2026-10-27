using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0B RID: 2571
	[NetMessage(EMessageId.MonthCardDailyRewardNotify)]
	public sealed class MonthCardDailyRewardNotify : IMessage<MonthCardDailyRewardNotify>, IMessage, IEquatable<MonthCardDailyRewardNotify>, IDeepCloneable<MonthCardDailyRewardNotify>, IBufferMessage
	{
		// Token: 0x0600E0F0 RID: 57584 RVA: 0x0020F382 File Offset: 0x0020D582
		[NullableContext(1)]
		public static MonthCardDailyRewardNotify Create()
		{
			return new MonthCardDailyRewardNotify();
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600E0F1 RID: 57585 RVA: 0x0020F389 File Offset: 0x0020D589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600E0F2 RID: 57586 RVA: 0x0020F38C File Offset: 0x0020D58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardDailyRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x0020F393 File Offset: 0x0020D593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardDailyRewardNotify()
		{
		}

		// Token: 0x0600E0F4 RID: 57588 RVA: 0x0020F39B File Offset: 0x0020D59B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardDailyRewardNotify(MonthCardDailyRewardNotify other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.days_ = other.days_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0F5 RID: 57589 RVA: 0x0020F3D8 File Offset: 0x0020D5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardDailyRewardNotify Clone()
		{
			return new MonthCardDailyRewardNotify(this);
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600E0F6 RID: 57590 RVA: 0x0020F3E0 File Offset: 0x0020D5E0
		// (set) Token: 0x0600E0F7 RID: 57591 RVA: 0x0020F3E8 File Offset: 0x0020D5E8
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

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x0020F3F1 File Offset: 0x0020D5F1
		// (set) Token: 0x0600E0F9 RID: 57593 RVA: 0x0020F3F9 File Offset: 0x0020D5F9
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

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x0600E0FA RID: 57594 RVA: 0x0020F402 File Offset: 0x0020D602
		// (set) Token: 0x0600E0FB RID: 57595 RVA: 0x0020F40A File Offset: 0x0020D60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Days
		{
			get
			{
				return this.days_;
			}
			set
			{
				this.days_ = value;
			}
		}

		// Token: 0x0600E0FC RID: 57596 RVA: 0x0020F413 File Offset: 0x0020D613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardDailyRewardNotify);
		}

		// Token: 0x0600E0FD RID: 57597 RVA: 0x0020F424 File Offset: 0x0020D624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardDailyRewardNotify other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.Days == other.Days && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0FE RID: 57598 RVA: 0x0020F480 File Offset: 0x0020D680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.Days != 0)
			{
				num ^= this.Days.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0FF RID: 57599 RVA: 0x0020F4F1 File Offset: 0x0020D6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E100 RID: 57600 RVA: 0x0020F4FE File Offset: 0x0020D6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E101 RID: 57601 RVA: 0x0020F508 File Offset: 0x0020D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Days != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Days);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E102 RID: 57602 RVA: 0x0020F57C File Offset: 0x0020D77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.Days != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Days);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E103 RID: 57603 RVA: 0x0020F5EC File Offset: 0x0020D7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonthCardDailyRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.Days != 0)
			{
				this.Days = other.Days;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E104 RID: 57604 RVA: 0x0020F650 File Offset: 0x0020D850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E105 RID: 57605 RVA: 0x0020F65C File Offset: 0x0020D85C
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
					if (num != 64U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Count = input.ReadInt32();
						}
					}
					else
					{
						this.Days = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C83 RID: 23683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C84 RID: 23684
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04005C85 RID: 23685
		private int itemId_;

		// Token: 0x04005C86 RID: 23686
		public const int CountFieldNumber = 14;

		// Token: 0x04005C87 RID: 23687
		private int count_;

		// Token: 0x04005C88 RID: 23688
		public const int DaysFieldNumber = 8;

		// Token: 0x04005C89 RID: 23689
		private int days_;
	}
}
