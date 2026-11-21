using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E08 RID: 3592
	public sealed class QuestInfo : IMessage<QuestInfo>, IMessage, IEquatable<QuestInfo>, IDeepCloneable<QuestInfo>, IBufferMessage
	{
		// Token: 0x0601353E RID: 79166 RVA: 0x002D065D File Offset: 0x002CE85D
		[NullableContext(1)]
		public static QuestInfo Create()
		{
			return new QuestInfo();
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x0601353F RID: 79167 RVA: 0x002D0664 File Offset: 0x002CE864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuestInfo> Parser
		{
			get
			{
				return QuestInfo._parser;
			}
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x06013540 RID: 79168 RVA: 0x002D066B File Offset: 0x002CE86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x06013541 RID: 79169 RVA: 0x002D066E File Offset: 0x002CE86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestInfo.Descriptor;
			}
		}

		// Token: 0x06013542 RID: 79170 RVA: 0x002D0675 File Offset: 0x002CE875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestInfo()
		{
		}

		// Token: 0x06013543 RID: 79171 RVA: 0x002D067D File Offset: 0x002CE87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestInfo(QuestInfo other) : this()
		{
			this.questId_ = other.questId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013544 RID: 79172 RVA: 0x002D06AE File Offset: 0x002CE8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestInfo Clone()
		{
			return new QuestInfo(this);
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x06013545 RID: 79173 RVA: 0x002D06B6 File Offset: 0x002CE8B6
		// (set) Token: 0x06013546 RID: 79174 RVA: 0x002D06BE File Offset: 0x002CE8BE
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

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x06013547 RID: 79175 RVA: 0x002D06C7 File Offset: 0x002CE8C7
		// (set) Token: 0x06013548 RID: 79176 RVA: 0x002D06CF File Offset: 0x002CE8CF
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

		// Token: 0x06013549 RID: 79177 RVA: 0x002D06D8 File Offset: 0x002CE8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestInfo);
		}

		// Token: 0x0601354A RID: 79178 RVA: 0x002D06E6 File Offset: 0x002CE8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestInfo other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601354B RID: 79179 RVA: 0x002D0724 File Offset: 0x002CE924
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

		// Token: 0x0601354C RID: 79180 RVA: 0x002D0782 File Offset: 0x002CE982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601354D RID: 79181 RVA: 0x002D078F File Offset: 0x002CE98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601354E RID: 79182 RVA: 0x002D0798 File Offset: 0x002CE998
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

		// Token: 0x0601354F RID: 79183 RVA: 0x002D07F0 File Offset: 0x002CE9F0
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

		// Token: 0x06013550 RID: 79184 RVA: 0x002D0848 File Offset: 0x002CEA48
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

		// Token: 0x06013551 RID: 79185 RVA: 0x002D0898 File Offset: 0x002CEA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013552 RID: 79186 RVA: 0x002D08A4 File Offset: 0x002CEAA4
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

		// Token: 0x0400771C RID: 30492
		private static readonly MessageParser<QuestInfo> _parser = new MessageParser<QuestInfo>(() => new QuestInfo());

		// Token: 0x0400771D RID: 30493
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400771E RID: 30494
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400771F RID: 30495
		private int questId_;

		// Token: 0x04007720 RID: 30496
		public const int StatusFieldNumber = 2;

		// Token: 0x04007721 RID: 30497
		private QuestState status_;
	}
}
