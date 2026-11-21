using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EAD RID: 3757
	[NetMessage(EMessageId.RecallQuestFinishActionRequest)]
	public sealed class RecallQuestFinishActionRequest : IMessage<RecallQuestFinishActionRequest>, IMessage, IEquatable<RecallQuestFinishActionRequest>, IDeepCloneable<RecallQuestFinishActionRequest>, IBufferMessage
	{
		// Token: 0x060142E4 RID: 82660 RVA: 0x002EFE5D File Offset: 0x002EE05D
		[NullableContext(1)]
		public static RecallQuestFinishActionRequest Create()
		{
			return new RecallQuestFinishActionRequest();
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x060142E5 RID: 82661 RVA: 0x002EFE64 File Offset: 0x002EE064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x060142E6 RID: 82662 RVA: 0x002EFE67 File Offset: 0x002EE067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionRequest.Descriptor;
			}
		}

		// Token: 0x060142E7 RID: 82663 RVA: 0x002EFE6E File Offset: 0x002EE06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionRequest()
		{
		}

		// Token: 0x060142E8 RID: 82664 RVA: 0x002EFE78 File Offset: 0x002EE078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionRequest(RecallQuestFinishActionRequest other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.nodeId_ = other.nodeId_;
			this.actionId_ = other.actionId_;
			this.actTime_ = other.actTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060142E9 RID: 82665 RVA: 0x002EFECC File Offset: 0x002EE0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionRequest Clone()
		{
			return new RecallQuestFinishActionRequest(this);
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x060142EA RID: 82666 RVA: 0x002EFED4 File Offset: 0x002EE0D4
		// (set) Token: 0x060142EB RID: 82667 RVA: 0x002EFEDC File Offset: 0x002EE0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x060142EC RID: 82668 RVA: 0x002EFEE5 File Offset: 0x002EE0E5
		// (set) Token: 0x060142ED RID: 82669 RVA: 0x002EFEED File Offset: 0x002EE0ED
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

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x060142EE RID: 82670 RVA: 0x002EFEF6 File Offset: 0x002EE0F6
		// (set) Token: 0x060142EF RID: 82671 RVA: 0x002EFEFE File Offset: 0x002EE0FE
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

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x060142F0 RID: 82672 RVA: 0x002EFF07 File Offset: 0x002EE107
		// (set) Token: 0x060142F1 RID: 82673 RVA: 0x002EFF0F File Offset: 0x002EE10F
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

		// Token: 0x060142F2 RID: 82674 RVA: 0x002EFF18 File Offset: 0x002EE118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionRequest);
		}

		// Token: 0x060142F3 RID: 82675 RVA: 0x002EFF28 File Offset: 0x002EE128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionRequest other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060142F4 RID: 82676 RVA: 0x002EFF94 File Offset: 0x002EE194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
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

		// Token: 0x060142F5 RID: 82677 RVA: 0x002F0024 File Offset: 0x002EE224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060142F6 RID: 82678 RVA: 0x002F0031 File Offset: 0x002EE231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060142F7 RID: 82679 RVA: 0x002F003C File Offset: 0x002EE23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActionId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NodeId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ActTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060142F8 RID: 82680 RVA: 0x002F00D0 File Offset: 0x002EE2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
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

		// Token: 0x060142F9 RID: 82681 RVA: 0x002F0158 File Offset: 0x002EE358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestFinishActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
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

		// Token: 0x060142FA RID: 82682 RVA: 0x002F01D0 File Offset: 0x002EE3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060142FB RID: 82683 RVA: 0x002F01DC File Offset: 0x002EE3DC
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
						this.RecallQuestId = input.ReadInt32();
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
					if (num == 56U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B3E RID: 31550
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B3F RID: 31551
		public const int RecallQuestIdFieldNumber = 2;

		// Token: 0x04007B40 RID: 31552
		private int recallQuestId_;

		// Token: 0x04007B41 RID: 31553
		public const int NodeIdFieldNumber = 7;

		// Token: 0x04007B42 RID: 31554
		private int nodeId_;

		// Token: 0x04007B43 RID: 31555
		public const int ActionIdFieldNumber = 3;

		// Token: 0x04007B44 RID: 31556
		private int actionId_;

		// Token: 0x04007B45 RID: 31557
		public const int ActTimeFieldNumber = 9;

		// Token: 0x04007B46 RID: 31558
		private ActionTime actTime_;
	}
}
