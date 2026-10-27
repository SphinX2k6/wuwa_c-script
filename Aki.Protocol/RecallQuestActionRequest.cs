using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB5 RID: 3765
	[NetMessage(EMessageId.RecallQuestActionRequest)]
	public sealed class RecallQuestActionRequest : IMessage<RecallQuestActionRequest>, IMessage, IEquatable<RecallQuestActionRequest>, IDeepCloneable<RecallQuestActionRequest>, IBufferMessage
	{
		// Token: 0x06014333 RID: 82739 RVA: 0x002F0400 File Offset: 0x002EE600
		[NullableContext(1)]
		public static RecallQuestActionRequest Create()
		{
			return new RecallQuestActionRequest();
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x06014334 RID: 82740 RVA: 0x002F0407 File Offset: 0x002EE607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x06014335 RID: 82741 RVA: 0x002F040A File Offset: 0x002EE60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestActionRequest.Descriptor;
			}
		}

		// Token: 0x06014336 RID: 82742 RVA: 0x002F0411 File Offset: 0x002EE611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionRequest()
		{
		}

		// Token: 0x06014337 RID: 82743 RVA: 0x002F041C File Offset: 0x002EE61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionRequest(RecallQuestActionRequest other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.nodeId_ = other.nodeId_;
			this.actionId_ = other.actionId_;
			this.actTime_ = other.actTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014338 RID: 82744 RVA: 0x002F0470 File Offset: 0x002EE670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionRequest Clone()
		{
			return new RecallQuestActionRequest(this);
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x06014339 RID: 82745 RVA: 0x002F0478 File Offset: 0x002EE678
		// (set) Token: 0x0601433A RID: 82746 RVA: 0x002F0480 File Offset: 0x002EE680
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

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x0601433B RID: 82747 RVA: 0x002F0489 File Offset: 0x002EE689
		// (set) Token: 0x0601433C RID: 82748 RVA: 0x002F0491 File Offset: 0x002EE691
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

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x0601433D RID: 82749 RVA: 0x002F049A File Offset: 0x002EE69A
		// (set) Token: 0x0601433E RID: 82750 RVA: 0x002F04A2 File Offset: 0x002EE6A2
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

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x0601433F RID: 82751 RVA: 0x002F04AB File Offset: 0x002EE6AB
		// (set) Token: 0x06014340 RID: 82752 RVA: 0x002F04B3 File Offset: 0x002EE6B3
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

		// Token: 0x06014341 RID: 82753 RVA: 0x002F04BC File Offset: 0x002EE6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestActionRequest);
		}

		// Token: 0x06014342 RID: 82754 RVA: 0x002F04CC File Offset: 0x002EE6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestActionRequest other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014343 RID: 82755 RVA: 0x002F0538 File Offset: 0x002EE738
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

		// Token: 0x06014344 RID: 82756 RVA: 0x002F05C8 File Offset: 0x002EE7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014345 RID: 82757 RVA: 0x002F05D5 File Offset: 0x002EE7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014346 RID: 82758 RVA: 0x002F05E0 File Offset: 0x002EE7E0
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
				output.WriteRawTag(40);
				output.WriteInt32(this.ActionId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NodeId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ActTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014347 RID: 82759 RVA: 0x002F0674 File Offset: 0x002EE874
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

		// Token: 0x06014348 RID: 82760 RVA: 0x002F06FC File Offset: 0x002EE8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestActionRequest other)
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

		// Token: 0x06014349 RID: 82761 RVA: 0x002F0774 File Offset: 0x002EE974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601434A RID: 82762 RVA: 0x002F0780 File Offset: 0x002EE980
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
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.RecallQuestId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
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
					if (num == 64U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007AF4 RID: 31476
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AF5 RID: 31477
		public const int RecallQuestIdFieldNumber = 2;

		// Token: 0x04007AF6 RID: 31478
		private int recallQuestId_;

		// Token: 0x04007AF7 RID: 31479
		public const int NodeIdFieldNumber = 7;

		// Token: 0x04007AF8 RID: 31480
		private int nodeId_;

		// Token: 0x04007AF9 RID: 31481
		public const int ActionIdFieldNumber = 5;

		// Token: 0x04007AFA RID: 31482
		private int actionId_;

		// Token: 0x04007AFB RID: 31483
		public const int ActTimeFieldNumber = 8;

		// Token: 0x04007AFC RID: 31484
		private ActionTime actTime_;
	}
}
