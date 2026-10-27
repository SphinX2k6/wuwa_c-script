using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E03 RID: 3587
	[NetMessage(EMessageId.QuestActionRequest)]
	public sealed class QuestActionRequest : IMessage<QuestActionRequest>, IMessage, IEquatable<QuestActionRequest>, IDeepCloneable<QuestActionRequest>, IBufferMessage
	{
		// Token: 0x0601348D RID: 78989 RVA: 0x002CE9DC File Offset: 0x002CCBDC
		[NullableContext(1)]
		public static QuestActionRequest Create()
		{
			return new QuestActionRequest();
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x0601348E RID: 78990 RVA: 0x002CE9E3 File Offset: 0x002CCBE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x0601348F RID: 78991 RVA: 0x002CE9E6 File Offset: 0x002CCBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestActionRequest.Descriptor;
			}
		}

		// Token: 0x06013490 RID: 78992 RVA: 0x002CE9ED File Offset: 0x002CCBED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionRequest()
		{
		}

		// Token: 0x06013491 RID: 78993 RVA: 0x002CE9F8 File Offset: 0x002CCBF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionRequest(QuestActionRequest other) : this()
		{
			this.questId_ = other.questId_;
			this.nodeId_ = other.nodeId_;
			this.actionId_ = other.actionId_;
			this.actTime_ = other.actTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013492 RID: 78994 RVA: 0x002CEA4C File Offset: 0x002CCC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionRequest Clone()
		{
			return new QuestActionRequest(this);
		}

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x06013493 RID: 78995 RVA: 0x002CEA54 File Offset: 0x002CCC54
		// (set) Token: 0x06013494 RID: 78996 RVA: 0x002CEA5C File Offset: 0x002CCC5C
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

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x06013495 RID: 78997 RVA: 0x002CEA65 File Offset: 0x002CCC65
		// (set) Token: 0x06013496 RID: 78998 RVA: 0x002CEA6D File Offset: 0x002CCC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x06013497 RID: 78999 RVA: 0x002CEA76 File Offset: 0x002CCC76
		// (set) Token: 0x06013498 RID: 79000 RVA: 0x002CEA7E File Offset: 0x002CCC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
		{
			get
			{
				return this.actionId_;
			}
			set
			{
				this.actionId_ = value;
			}
		}

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x06013499 RID: 79001 RVA: 0x002CEA87 File Offset: 0x002CCC87
		// (set) Token: 0x0601349A RID: 79002 RVA: 0x002CEA8F File Offset: 0x002CCC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionTime ActTime
		{
			get
			{
				return this.actTime_;
			}
			set
			{
				this.actTime_ = value;
			}
		}

		// Token: 0x0601349B RID: 79003 RVA: 0x002CEA98 File Offset: 0x002CCC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestActionRequest);
		}

		// Token: 0x0601349C RID: 79004 RVA: 0x002CEAA8 File Offset: 0x002CCCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestActionRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601349D RID: 79005 RVA: 0x002CEB14 File Offset: 0x002CCD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.ActionId != 0)
			{
				num ^= this.ActionId.GetHashCode();
			}
			if (this.ActTime != ActionTime.Enter)
			{
				num ^= this.ActTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601349E RID: 79006 RVA: 0x002CEBA4 File Offset: 0x002CCDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601349F RID: 79007 RVA: 0x002CEBB1 File Offset: 0x002CCDB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134A0 RID: 79008 RVA: 0x002CEBBC File Offset: 0x002CCDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.QuestId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.NodeId);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActionId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ActTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134A1 RID: 79009 RVA: 0x002CEC50 File Offset: 0x002CCE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.ActionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ActTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060134A2 RID: 79010 RVA: 0x002CECD8 File Offset: 0x002CCED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.ActionId != 0)
			{
				this.ActionId = other.ActionId;
			}
			if (other.ActTime != ActionTime.Enter)
			{
				this.ActTime = other.ActTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060134A3 RID: 79011 RVA: 0x002CED50 File Offset: 0x002CCF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134A4 RID: 79012 RVA: 0x002CED5C File Offset: 0x002CCF5C
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
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.QuestId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400768E RID: 30350
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400768F RID: 30351
		public const int QuestIdFieldNumber = 3;

		// Token: 0x04007690 RID: 30352
		private int questId_;

		// Token: 0x04007691 RID: 30353
		public const int NodeIdFieldNumber = 6;

		// Token: 0x04007692 RID: 30354
		private int nodeId_;

		// Token: 0x04007693 RID: 30355
		public const int ActionIdFieldNumber = 13;

		// Token: 0x04007694 RID: 30356
		private int actionId_;

		// Token: 0x04007695 RID: 30357
		public const int ActTimeFieldNumber = 15;

		// Token: 0x04007696 RID: 30358
		private ActionTime actTime_;
	}
}
