using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBD RID: 3773
	[NetMessage(EMessageId.RecallQuestFinishActionRequest)]
	public sealed class RecallQuestFinishActionRequest : IMessage<RecallQuestFinishActionRequest>, IMessage, IEquatable<RecallQuestFinishActionRequest>, IDeepCloneable<RecallQuestFinishActionRequest>, IBufferMessage
	{
		// Token: 0x060143C9 RID: 82889 RVA: 0x002F150D File Offset: 0x002EF70D
		[NullableContext(1)]
		public static RecallQuestFinishActionRequest Create()
		{
			return new RecallQuestFinishActionRequest();
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x060143CA RID: 82890 RVA: 0x002F1514 File Offset: 0x002EF714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x060143CB RID: 82891 RVA: 0x002F1517 File Offset: 0x002EF717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestFinishActionRequest.Descriptor;
			}
		}

		// Token: 0x060143CC RID: 82892 RVA: 0x002F151E File Offset: 0x002EF71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionRequest()
		{
		}

		// Token: 0x060143CD RID: 82893 RVA: 0x002F1528 File Offset: 0x002EF728
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

		// Token: 0x060143CE RID: 82894 RVA: 0x002F157C File Offset: 0x002EF77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestFinishActionRequest Clone()
		{
			return new RecallQuestFinishActionRequest(this);
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x060143CF RID: 82895 RVA: 0x002F1584 File Offset: 0x002EF784
		// (set) Token: 0x060143D0 RID: 82896 RVA: 0x002F158C File Offset: 0x002EF78C
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

		// Token: 0x1700434C RID: 17228
		// (get) Token: 0x060143D1 RID: 82897 RVA: 0x002F1595 File Offset: 0x002EF795
		// (set) Token: 0x060143D2 RID: 82898 RVA: 0x002F159D File Offset: 0x002EF79D
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

		// Token: 0x1700434D RID: 17229
		// (get) Token: 0x060143D3 RID: 82899 RVA: 0x002F15A6 File Offset: 0x002EF7A6
		// (set) Token: 0x060143D4 RID: 82900 RVA: 0x002F15AE File Offset: 0x002EF7AE
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

		// Token: 0x1700434E RID: 17230
		// (get) Token: 0x060143D5 RID: 82901 RVA: 0x002F15B7 File Offset: 0x002EF7B7
		// (set) Token: 0x060143D6 RID: 82902 RVA: 0x002F15BF File Offset: 0x002EF7BF
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

		// Token: 0x060143D7 RID: 82903 RVA: 0x002F15C8 File Offset: 0x002EF7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestFinishActionRequest);
		}

		// Token: 0x060143D8 RID: 82904 RVA: 0x002F15D8 File Offset: 0x002EF7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestFinishActionRequest other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.NodeId == other.NodeId && this.ActionId == other.ActionId && this.ActTime == other.ActTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060143D9 RID: 82905 RVA: 0x002F1644 File Offset: 0x002EF844
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

		// Token: 0x060143DA RID: 82906 RVA: 0x002F16D4 File Offset: 0x002EF8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060143DB RID: 82907 RVA: 0x002F16E1 File Offset: 0x002EF8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060143DC RID: 82908 RVA: 0x002F16EC File Offset: 0x002EF8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.NodeId);
			}
			if (this.ActionId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActionId);
			}
			if (this.ActTime != ActionTime.Enter)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ActTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060143DD RID: 82909 RVA: 0x002F1780 File Offset: 0x002EF980
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

		// Token: 0x060143DE RID: 82910 RVA: 0x002F1808 File Offset: 0x002EFA08
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

		// Token: 0x060143DF RID: 82911 RVA: 0x002F1880 File Offset: 0x002EFA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060143E0 RID: 82912 RVA: 0x002F188C File Offset: 0x002EFA8C
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
				if (num <= 56U)
				{
					if (num == 48U)
					{
						this.RecallQuestId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ActTime = (ActionTime)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B14 RID: 31508
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B15 RID: 31509
		public const int RecallQuestIdFieldNumber = 6;

		// Token: 0x04007B16 RID: 31510
		private int recallQuestId_;

		// Token: 0x04007B17 RID: 31511
		public const int NodeIdFieldNumber = 7;

		// Token: 0x04007B18 RID: 31512
		private int nodeId_;

		// Token: 0x04007B19 RID: 31513
		public const int ActionIdFieldNumber = 8;

		// Token: 0x04007B1A RID: 31514
		private int actionId_;

		// Token: 0x04007B1B RID: 31515
		public const int ActTimeFieldNumber = 14;

		// Token: 0x04007B1C RID: 31516
		private ActionTime actTime_;
	}
}
