using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E18 RID: 3608
	public sealed class QuestInfo : IMessage<QuestInfo>, IMessage, IEquatable<QuestInfo>, IDeepCloneable<QuestInfo>, IBufferMessage
	{
		// Token: 0x06013623 RID: 79395 RVA: 0x002D1D1E File Offset: 0x002CFF1E
		[NullableContext(1)]
		public static QuestInfo Create()
		{
			return new QuestInfo();
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x06013624 RID: 79396 RVA: 0x002D1D25 File Offset: 0x002CFF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestInfo> Parser
		{
			get
			{
				return QuestInfo._parser;
			}
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x06013625 RID: 79397 RVA: 0x002D1D2C File Offset: 0x002CFF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x06013626 RID: 79398 RVA: 0x002D1D2F File Offset: 0x002CFF2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestInfo.Descriptor;
			}
		}

		// Token: 0x06013627 RID: 79399 RVA: 0x002D1D36 File Offset: 0x002CFF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestInfo()
		{
		}

		// Token: 0x06013628 RID: 79400 RVA: 0x002D1D3E File Offset: 0x002CFF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestInfo(QuestInfo other) : this()
		{
			this.questId_ = other.questId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013629 RID: 79401 RVA: 0x002D1D6F File Offset: 0x002CFF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestInfo Clone()
		{
			return new QuestInfo(this);
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x0601362A RID: 79402 RVA: 0x002D1D77 File Offset: 0x002CFF77
		// (set) Token: 0x0601362B RID: 79403 RVA: 0x002D1D7F File Offset: 0x002CFF7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x0601362C RID: 79404 RVA: 0x002D1D88 File Offset: 0x002CFF88
		// (set) Token: 0x0601362D RID: 79405 RVA: 0x002D1D90 File Offset: 0x002CFF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestState Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0601362E RID: 79406 RVA: 0x002D1D99 File Offset: 0x002CFF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestInfo);
		}

		// Token: 0x0601362F RID: 79407 RVA: 0x002D1DA7 File Offset: 0x002CFFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestInfo other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013630 RID: 79408 RVA: 0x002D1DE8 File Offset: 0x002CFFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.Status != QuestState.InActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013631 RID: 79409 RVA: 0x002D1E46 File Offset: 0x002D0046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013632 RID: 79410 RVA: 0x002D1E53 File Offset: 0x002D0053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013633 RID: 79411 RVA: 0x002D1E5C File Offset: 0x002D005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this.Status != QuestState.InActive)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013634 RID: 79412 RVA: 0x002D1EB4 File Offset: 0x002D00B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.Status != QuestState.InActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013635 RID: 79413 RVA: 0x002D1F0C File Offset: 0x002D010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.Status != QuestState.InActive)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013636 RID: 79414 RVA: 0x002D1F5C File Offset: 0x002D015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013637 RID: 79415 RVA: 0x002D1F68 File Offset: 0x002D0168
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
						this.Status = (QuestState)input.ReadEnum();
					}
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040076F2 RID: 30450
		private static readonly MessageParser<QuestInfo> _parser = new MessageParser<QuestInfo>(() => new QuestInfo());

		// Token: 0x040076F3 RID: 30451
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076F4 RID: 30452
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076F5 RID: 30453
		private int questId_;

		// Token: 0x040076F6 RID: 30454
		public const int StatusFieldNumber = 2;

		// Token: 0x040076F7 RID: 30455
		private QuestState status_;
	}
}
