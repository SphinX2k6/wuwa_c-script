using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000329 RID: 809
	public sealed class DailyQuestReward : IMessage<DailyQuestReward>, IMessage, IEquatable<DailyQuestReward>, IDeepCloneable<DailyQuestReward>, IBufferMessage
	{
		// Token: 0x06005130 RID: 20784 RVA: 0x000C5874 File Offset: 0x000C3A74
		[NullableContext(1)]
		public static DailyQuestReward Create()
		{
			return new DailyQuestReward();
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06005131 RID: 20785 RVA: 0x000C587B File Offset: 0x000C3A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyQuestReward> Parser
		{
			get
			{
				return DailyQuestReward._parser;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06005132 RID: 20786 RVA: 0x000C5882 File Offset: 0x000C3A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06005133 RID: 20787 RVA: 0x000C5885 File Offset: 0x000C3A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestReward.Descriptor;
			}
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x000C588C File Offset: 0x000C3A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestReward()
		{
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x000C5894 File Offset: 0x000C3A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestReward(DailyQuestReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x000C58C5 File Offset: 0x000C3AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestReward Clone()
		{
			return new DailyQuestReward(this);
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06005137 RID: 20791 RVA: 0x000C58CD File Offset: 0x000C3ACD
		// (set) Token: 0x06005138 RID: 20792 RVA: 0x000C58D5 File Offset: 0x000C3AD5
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

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06005139 RID: 20793 RVA: 0x000C58DE File Offset: 0x000C3ADE
		// (set) Token: 0x0600513A RID: 20794 RVA: 0x000C58E6 File Offset: 0x000C3AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x000C58EF File Offset: 0x000C3AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestReward);
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x000C58FD File Offset: 0x000C3AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x000C593C File Offset: 0x000C3B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x000C5994 File Offset: 0x000C3B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x000C59A1 File Offset: 0x000C3BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x000C59AC File Offset: 0x000C3BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x000C5A04 File Offset: 0x000C3C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x000C5A5C File Offset: 0x000C3C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x000C5AAC File Offset: 0x000C3CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x000C5AB8 File Offset: 0x000C3CB8
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003292 RID: 12946
		private static readonly MessageParser<DailyQuestReward> _parser = new MessageParser<DailyQuestReward>(() => new DailyQuestReward());

		// Token: 0x04003293 RID: 12947
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003294 RID: 12948
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003295 RID: 12949
		private int itemId_;

		// Token: 0x04003296 RID: 12950
		public const int ItemCountFieldNumber = 2;

		// Token: 0x04003297 RID: 12951
		private int itemCount_;
	}
}
