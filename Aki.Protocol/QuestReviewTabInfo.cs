using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E1D RID: 3613
	public sealed class QuestReviewTabInfo : IMessage<QuestReviewTabInfo>, IMessage, IEquatable<QuestReviewTabInfo>, IDeepCloneable<QuestReviewTabInfo>, IBufferMessage
	{
		// Token: 0x060136E1 RID: 79585 RVA: 0x002D3990 File Offset: 0x002D1B90
		[NullableContext(1)]
		public static QuestReviewTabInfo Create()
		{
			return new QuestReviewTabInfo();
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x060136E2 RID: 79586 RVA: 0x002D3997 File Offset: 0x002D1B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestReviewTabInfo> Parser
		{
			get
			{
				return QuestReviewTabInfo._parser;
			}
		}

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x060136E3 RID: 79587 RVA: 0x002D399E File Offset: 0x002D1B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x060136E4 RID: 79588 RVA: 0x002D39A1 File Offset: 0x002D1BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReviewTabInfo.Descriptor;
			}
		}

		// Token: 0x060136E5 RID: 79589 RVA: 0x002D39A8 File Offset: 0x002D1BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewTabInfo()
		{
		}

		// Token: 0x060136E6 RID: 79590 RVA: 0x002D39B0 File Offset: 0x002D1BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewTabInfo(QuestReviewTabInfo other) : this()
		{
			this.tabId_ = other.tabId_;
			this.unlockCondition_ = other.unlockCondition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060136E7 RID: 79591 RVA: 0x002D39E1 File Offset: 0x002D1BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReviewTabInfo Clone()
		{
			return new QuestReviewTabInfo(this);
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x060136E8 RID: 79592 RVA: 0x002D39E9 File Offset: 0x002D1BE9
		// (set) Token: 0x060136E9 RID: 79593 RVA: 0x002D39F1 File Offset: 0x002D1BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabId
		{
			get
			{
				return this.tabId_;
			}
			set
			{
				this.tabId_ = value;
			}
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x060136EA RID: 79594 RVA: 0x002D39FA File Offset: 0x002D1BFA
		// (set) Token: 0x060136EB RID: 79595 RVA: 0x002D3A02 File Offset: 0x002D1C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UnlockCondition
		{
			get
			{
				return this.unlockCondition_;
			}
			set
			{
				this.unlockCondition_ = value;
			}
		}

		// Token: 0x060136EC RID: 79596 RVA: 0x002D3A0B File Offset: 0x002D1C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReviewTabInfo);
		}

		// Token: 0x060136ED RID: 79597 RVA: 0x002D3A19 File Offset: 0x002D1C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReviewTabInfo other)
		{
			return other != null && (other == this || (this.TabId == other.TabId && this.UnlockCondition == other.UnlockCondition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060136EE RID: 79598 RVA: 0x002D3A58 File Offset: 0x002D1C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TabId != 0)
			{
				num ^= this.TabId.GetHashCode();
			}
			if (this.UnlockCondition)
			{
				num ^= this.UnlockCondition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060136EF RID: 79599 RVA: 0x002D3AB0 File Offset: 0x002D1CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060136F0 RID: 79600 RVA: 0x002D3ABD File Offset: 0x002D1CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060136F1 RID: 79601 RVA: 0x002D3AC8 File Offset: 0x002D1CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TabId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TabId);
			}
			if (this.UnlockCondition)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.UnlockCondition);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060136F2 RID: 79602 RVA: 0x002D3B20 File Offset: 0x002D1D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TabId);
			}
			if (this.UnlockCondition)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060136F3 RID: 79603 RVA: 0x002D3B6C File Offset: 0x002D1D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReviewTabInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TabId != 0)
			{
				this.TabId = other.TabId;
			}
			if (other.UnlockCondition)
			{
				this.UnlockCondition = other.UnlockCondition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060136F4 RID: 79604 RVA: 0x002D3BBC File Offset: 0x002D1DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060136F5 RID: 79605 RVA: 0x002D3BC8 File Offset: 0x002D1DC8
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
						this.UnlockCondition = input.ReadBool();
					}
				}
				else
				{
					this.TabId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007789 RID: 30601
		private static readonly MessageParser<QuestReviewTabInfo> _parser = new MessageParser<QuestReviewTabInfo>(() => new QuestReviewTabInfo());

		// Token: 0x0400778A RID: 30602
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400778B RID: 30603
		public const int TabIdFieldNumber = 1;

		// Token: 0x0400778C RID: 30604
		private int tabId_;

		// Token: 0x0400778D RID: 30605
		public const int UnlockConditionFieldNumber = 2;

		// Token: 0x0400778E RID: 30606
		private bool unlockCondition_;
	}
}
