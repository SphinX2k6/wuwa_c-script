using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000330 RID: 816
	public sealed class DailyQuestReward : IMessage<DailyQuestReward>, IMessage, IEquatable<DailyQuestReward>, IDeepCloneable<DailyQuestReward>, IBufferMessage
	{
		// Token: 0x06005209 RID: 21001 RVA: 0x000C7C68 File Offset: 0x000C5E68
		[NullableContext(1)]
		public static DailyQuestReward Create()
		{
			return new DailyQuestReward();
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x000C7C6F File Offset: 0x000C5E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DailyQuestReward> Parser
		{
			get
			{
				return DailyQuestReward._parser;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x000C7C76 File Offset: 0x000C5E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x000C7C79 File Offset: 0x000C5E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestReward.Descriptor;
			}
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x000C7C80 File Offset: 0x000C5E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestReward()
		{
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x000C7C88 File Offset: 0x000C5E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestReward(DailyQuestReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x000C7CB9 File Offset: 0x000C5EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestReward Clone()
		{
			return new DailyQuestReward(this);
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x000C7CC1 File Offset: 0x000C5EC1
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x000C7CC9 File Offset: 0x000C5EC9
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

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x000C7CD2 File Offset: 0x000C5ED2
		// (set) Token: 0x06005213 RID: 21011 RVA: 0x000C7CDA File Offset: 0x000C5EDA
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

		// Token: 0x06005214 RID: 21012 RVA: 0x000C7CE3 File Offset: 0x000C5EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestReward);
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x000C7CF1 File Offset: 0x000C5EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x000C7D30 File Offset: 0x000C5F30
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

		// Token: 0x06005217 RID: 21015 RVA: 0x000C7D88 File Offset: 0x000C5F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x000C7D95 File Offset: 0x000C5F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x000C7DA0 File Offset: 0x000C5FA0
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

		// Token: 0x0600521A RID: 21018 RVA: 0x000C7DF8 File Offset: 0x000C5FF8
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

		// Token: 0x0600521B RID: 21019 RVA: 0x000C7E50 File Offset: 0x000C6050
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

		// Token: 0x0600521C RID: 21020 RVA: 0x000C7EA0 File Offset: 0x000C60A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x000C7EAC File Offset: 0x000C60AC
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

		// Token: 0x04003329 RID: 13097
		private static readonly MessageParser<DailyQuestReward> _parser = new MessageParser<DailyQuestReward>(() => new DailyQuestReward());

		// Token: 0x0400332A RID: 13098
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400332B RID: 13099
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400332C RID: 13100
		private int itemId_;

		// Token: 0x0400332D RID: 13101
		public const int ItemCountFieldNumber = 2;

		// Token: 0x0400332E RID: 13102
		private int itemCount_;
	}
}
