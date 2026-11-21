using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FA RID: 2554
	[NetMessage(EMessageId.MonthCardDailyRewardNotify)]
	public sealed class MonthCardDailyRewardNotify : IMessage<MonthCardDailyRewardNotify>, IMessage, IEquatable<MonthCardDailyRewardNotify>, IDeepCloneable<MonthCardDailyRewardNotify>, IBufferMessage
	{
		// Token: 0x0600DFD6 RID: 57302 RVA: 0x0020D196 File Offset: 0x0020B396
		[NullableContext(1)]
		public static MonthCardDailyRewardNotify Create()
		{
			return new MonthCardDailyRewardNotify();
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0600DFD7 RID: 57303 RVA: 0x0020D19D File Offset: 0x0020B39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x0020D1A0 File Offset: 0x0020B3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardDailyRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x0020D1A7 File Offset: 0x0020B3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardDailyRewardNotify()
		{
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x0020D1AF File Offset: 0x0020B3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardDailyRewardNotify(MonthCardDailyRewardNotify other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.days_ = other.days_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFDB RID: 57307 RVA: 0x0020D1EC File Offset: 0x0020B3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardDailyRewardNotify Clone()
		{
			return new MonthCardDailyRewardNotify(this);
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x0020D1F4 File Offset: 0x0020B3F4
		// (set) Token: 0x0600DFDD RID: 57309 RVA: 0x0020D1FC File Offset: 0x0020B3FC
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

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0600DFDE RID: 57310 RVA: 0x0020D205 File Offset: 0x0020B405
		// (set) Token: 0x0600DFDF RID: 57311 RVA: 0x0020D20D File Offset: 0x0020B40D
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

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0600DFE0 RID: 57312 RVA: 0x0020D216 File Offset: 0x0020B416
		// (set) Token: 0x0600DFE1 RID: 57313 RVA: 0x0020D21E File Offset: 0x0020B41E
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

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x0020D227 File Offset: 0x0020B427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardDailyRewardNotify);
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x0020D238 File Offset: 0x0020B438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardDailyRewardNotify other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.Days == other.Days && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x0020D294 File Offset: 0x0020B494
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

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x0020D305 File Offset: 0x0020B505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFE6 RID: 57318 RVA: 0x0020D312 File Offset: 0x0020B512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFE7 RID: 57319 RVA: 0x0020D31C File Offset: 0x0020B51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Days != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Days);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFE8 RID: 57320 RVA: 0x0020D390 File Offset: 0x0020B590
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

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x0020D400 File Offset: 0x0020B600
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

		// Token: 0x0600DFEA RID: 57322 RVA: 0x0020D464 File Offset: 0x0020B664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFEB RID: 57323 RVA: 0x0020D470 File Offset: 0x0020B670
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
					if (num != 112U)
					{
						if (num != 120U)
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
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.Days = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C8C RID: 23692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C8D RID: 23693
		public const int ItemIdFieldNumber = 14;

		// Token: 0x04005C8E RID: 23694
		private int itemId_;

		// Token: 0x04005C8F RID: 23695
		public const int CountFieldNumber = 15;

		// Token: 0x04005C90 RID: 23696
		private int count_;

		// Token: 0x04005C91 RID: 23697
		public const int DaysFieldNumber = 1;

		// Token: 0x04005C92 RID: 23698
		private int days_;
	}
}
