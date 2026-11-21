using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF3 RID: 3571
	[NetMessage(EMessageId.QuestActionRequest)]
	public sealed class QuestActionRequest : IMessage<QuestActionRequest>, IMessage, IEquatable<QuestActionRequest>, IDeepCloneable<QuestActionRequest>, IBufferMessage
	{
		// Token: 0x060133A8 RID: 78760 RVA: 0x002CD320 File Offset: 0x002CB520
		[NullableContext(1)]
		public static QuestActionRequest Create()
		{
			return new QuestActionRequest();
		}

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x060133A9 RID: 78761 RVA: 0x002CD327 File Offset: 0x002CB527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x060133AA RID: 78762 RVA: 0x002CD32A File Offset: 0x002CB52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestActionRequest.Descriptor;
			}
		}

		// Token: 0x060133AB RID: 78763 RVA: 0x002CD331 File Offset: 0x002CB531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionRequest()
		{
		}

		// Token: 0x060133AC RID: 78764 RVA: 0x002CD33C File Offset: 0x002CB53C
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

		// Token: 0x060133AD RID: 78765 RVA: 0x002CD390 File Offset: 0x002CB590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActionRequest Clone()
		{
			return new QuestActionRequest(this);
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x060133AE RID: 78766 RVA: 0x002CD398 File Offset: 0x002CB598
		// (set) Token: 0x060133AF RID: 78767 RVA: 0x002CD3A0 File Offset: 0x002CB5A0
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

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x060133B0 RID: 78768 RVA: 0x002CD3A9 File Offset: 0x002CB5A9
		// (set) Token: 0x060133B1 RID: 78769 RVA: 0x002CD3B1 File Offset: 0x002CB5B1
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

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x060133B2 RID: 78770 RVA: 0x002CD3BA File Offset: 0x002CB5BA
		// (set) Token: 0x060133B3 RID: 78771 RVA: 0x002CD3C2 File Offset: 0x002CB5C2
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

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x060133B4 RID: 78772 RVA: 0x002CD3CB File Offset: 0x002CB5CB
		// (set) Token: 0x060133B5 RID: 78773 RVA: 0x002CD3D3 File Offset: 0x002CB5D3
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

		// Token: 0x060133B6 RID: 78774 RVA: 0x002CD3DC File Offset: 0x002CB5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestActionRequest);
		}

		// Token: 0x060133B7 RID: 78775 RVA: 0x002CD3EC File Offset: 0x002CB5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestActionRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133B8 RID: 78776 RVA: 0x002CD458 File Offset: 0x002CB658
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

		// Token: 0x060133B9 RID: 78777 RVA: 0x002CD4E8 File Offset: 0x002CB6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133BA RID: 78778 RVA: 0x002CD4F5 File Offset: 0x002CB6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133BB RID: 78779 RVA: 0x002CD500 File Offset: 0x002CB700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NodeId);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActionId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ActTime);
			}
			if (this.QuestId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133BC RID: 78780 RVA: 0x002CD594 File Offset: 0x002CB794
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

		// Token: 0x060133BD RID: 78781 RVA: 0x002CD61C File Offset: 0x002CB81C
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

		// Token: 0x060133BE RID: 78782 RVA: 0x002CD694 File Offset: 0x002CB894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133BF RID: 78783 RVA: 0x002CD6A0 File Offset: 0x002CB8A0
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.QuestId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040076B8 RID: 30392
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076B9 RID: 30393
		public const int QuestIdFieldNumber = 14;

		// Token: 0x040076BA RID: 30394
		private int questId_;

		// Token: 0x040076BB RID: 30395
		public const int NodeIdFieldNumber = 2;

		// Token: 0x040076BC RID: 30396
		private int nodeId_;

		// Token: 0x040076BD RID: 30397
		public const int ActionIdFieldNumber = 3;

		// Token: 0x040076BE RID: 30398
		private int actionId_;

		// Token: 0x040076BF RID: 30399
		public const int ActTimeFieldNumber = 13;

		// Token: 0x040076C0 RID: 30400
		private ActionTime actTime_;
	}
}
