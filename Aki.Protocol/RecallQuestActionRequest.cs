using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA5 RID: 3749
	[NetMessage(EMessageId.RecallQuestActionRequest)]
	public sealed class RecallQuestActionRequest : IMessage<RecallQuestActionRequest>, IMessage, IEquatable<RecallQuestActionRequest>, IDeepCloneable<RecallQuestActionRequest>, IBufferMessage
	{
		// Token: 0x0601424E RID: 82510 RVA: 0x002EED54 File Offset: 0x002ECF54
		[NullableContext(1)]
		public static RecallQuestActionRequest Create()
		{
			return new RecallQuestActionRequest();
		}

		// Token: 0x17004304 RID: 17156
		// (get) Token: 0x0601424F RID: 82511 RVA: 0x002EED5B File Offset: 0x002ECF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004305 RID: 17157
		// (get) Token: 0x06014250 RID: 82512 RVA: 0x002EED5E File Offset: 0x002ECF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestActionRequest.Descriptor;
			}
		}

		// Token: 0x06014251 RID: 82513 RVA: 0x002EED65 File Offset: 0x002ECF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionRequest()
		{
		}

		// Token: 0x06014252 RID: 82514 RVA: 0x002EED70 File Offset: 0x002ECF70
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

		// Token: 0x06014253 RID: 82515 RVA: 0x002EEDC4 File Offset: 0x002ECFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestActionRequest Clone()
		{
			return new RecallQuestActionRequest(this);
		}

		// Token: 0x17004306 RID: 17158
		// (get) Token: 0x06014254 RID: 82516 RVA: 0x002EEDCC File Offset: 0x002ECFCC
		// (set) Token: 0x06014255 RID: 82517 RVA: 0x002EEDD4 File Offset: 0x002ECFD4
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

		// Token: 0x17004307 RID: 17159
		// (get) Token: 0x06014256 RID: 82518 RVA: 0x002EEDDD File Offset: 0x002ECFDD
		// (set) Token: 0x06014257 RID: 82519 RVA: 0x002EEDE5 File Offset: 0x002ECFE5
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

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x06014258 RID: 82520 RVA: 0x002EEDEE File Offset: 0x002ECFEE
		// (set) Token: 0x06014259 RID: 82521 RVA: 0x002EEDF6 File Offset: 0x002ECFF6
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

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x0601425A RID: 82522 RVA: 0x002EEDFF File Offset: 0x002ECFFF
		// (set) Token: 0x0601425B RID: 82523 RVA: 0x002EEE07 File Offset: 0x002ED007
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

		// Token: 0x0601425C RID: 82524 RVA: 0x002EEE10 File Offset: 0x002ED010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestActionRequest);
		}

		// Token: 0x0601425D RID: 82525 RVA: 0x002EEE20 File Offset: 0x002ED020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestActionRequest other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601425E RID: 82526 RVA: 0x002EEE8C File Offset: 0x002ED08C
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

		// Token: 0x0601425F RID: 82527 RVA: 0x002EEF1C File Offset: 0x002ED11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014260 RID: 82528 RVA: 0x002EEF29 File Offset: 0x002ED129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014261 RID: 82529 RVA: 0x002EEF34 File Offset: 0x002ED134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ActTime);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NodeId);
			}
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014262 RID: 82530 RVA: 0x002EEFC4 File Offset: 0x002ED1C4
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

		// Token: 0x06014263 RID: 82531 RVA: 0x002EF04C File Offset: 0x002ED24C
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

		// Token: 0x06014264 RID: 82532 RVA: 0x002EF0C4 File Offset: 0x002ED2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014265 RID: 82533 RVA: 0x002EF0D0 File Offset: 0x002ED2D0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.RecallQuestId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B1E RID: 31518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B1F RID: 31519
		public const int RecallQuestIdFieldNumber = 8;

		// Token: 0x04007B20 RID: 31520
		private int recallQuestId_;

		// Token: 0x04007B21 RID: 31521
		public const int NodeIdFieldNumber = 2;

		// Token: 0x04007B22 RID: 31522
		private int nodeId_;

		// Token: 0x04007B23 RID: 31523
		public const int ActionIdFieldNumber = 13;

		// Token: 0x04007B24 RID: 31524
		private int actionId_;

		// Token: 0x04007B25 RID: 31525
		public const int ActTimeFieldNumber = 1;

		// Token: 0x04007B26 RID: 31526
		private ActionTime actTime_;
	}
}
