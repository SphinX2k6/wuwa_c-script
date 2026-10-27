using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001290 RID: 4752
	[NetMessage(EMessageId.StartSetQuestFocusNotify)]
	public sealed class StartSetQuestFocusNotify : IMessage<StartSetQuestFocusNotify>, IMessage, IEquatable<StartSetQuestFocusNotify>, IDeepCloneable<StartSetQuestFocusNotify>, IBufferMessage
	{
		// Token: 0x060194D6 RID: 103638 RVA: 0x003ADEA7 File Offset: 0x003AC0A7
		[NullableContext(1)]
		public static StartSetQuestFocusNotify Create()
		{
			return new StartSetQuestFocusNotify();
		}

		// Token: 0x17005559 RID: 21849
		// (get) Token: 0x060194D7 RID: 103639 RVA: 0x003ADEAE File Offset: 0x003AC0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700555A RID: 21850
		// (get) Token: 0x060194D8 RID: 103640 RVA: 0x003ADEB1 File Offset: 0x003AC0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartSetQuestFocusNotify.Descriptor;
			}
		}

		// Token: 0x060194D9 RID: 103641 RVA: 0x003ADEB8 File Offset: 0x003AC0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartSetQuestFocusNotify()
		{
		}

		// Token: 0x060194DA RID: 103642 RVA: 0x003ADEC0 File Offset: 0x003AC0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartSetQuestFocusNotify(StartSetQuestFocusNotify other) : this()
		{
			this.focusQuestId_ = other.focusQuestId_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194DB RID: 103643 RVA: 0x003ADEF1 File Offset: 0x003AC0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartSetQuestFocusNotify Clone()
		{
			return new StartSetQuestFocusNotify(this);
		}

		// Token: 0x1700555B RID: 21851
		// (get) Token: 0x060194DC RID: 103644 RVA: 0x003ADEF9 File Offset: 0x003AC0F9
		// (set) Token: 0x060194DD RID: 103645 RVA: 0x003ADF01 File Offset: 0x003AC101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusQuestId
		{
			get
			{
				return this.focusQuestId_;
			}
			set
			{
				this.focusQuestId_ = value;
			}
		}

		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x060194DE RID: 103646 RVA: 0x003ADF0A File Offset: 0x003AC10A
		// (set) Token: 0x060194DF RID: 103647 RVA: 0x003ADF12 File Offset: 0x003AC112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestFocusReason Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x060194E0 RID: 103648 RVA: 0x003ADF1B File Offset: 0x003AC11B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartSetQuestFocusNotify);
		}

		// Token: 0x060194E1 RID: 103649 RVA: 0x003ADF29 File Offset: 0x003AC129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartSetQuestFocusNotify other)
		{
			return other != null && (other == this || (this.FocusQuestId == other.FocusQuestId && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194E2 RID: 103650 RVA: 0x003ADF68 File Offset: 0x003AC168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FocusQuestId != 0)
			{
				num ^= this.FocusQuestId.GetHashCode();
			}
			if (this.Reason != QuestFocusReason.Request)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060194E3 RID: 103651 RVA: 0x003ADFC6 File Offset: 0x003AC1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194E4 RID: 103652 RVA: 0x003ADFD3 File Offset: 0x003AC1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194E5 RID: 103653 RVA: 0x003ADFDC File Offset: 0x003AC1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != QuestFocusReason.Request)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Reason);
			}
			if (this.FocusQuestId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FocusQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194E6 RID: 103654 RVA: 0x003AE038 File Offset: 0x003AC238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FocusQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FocusQuestId);
			}
			if (this.Reason != QuestFocusReason.Request)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060194E7 RID: 103655 RVA: 0x003AE090 File Offset: 0x003AC290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartSetQuestFocusNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FocusQuestId != 0)
			{
				this.FocusQuestId = other.FocusQuestId;
			}
			if (other.Reason != QuestFocusReason.Request)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060194E8 RID: 103656 RVA: 0x003AE0E0 File Offset: 0x003AC2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194E9 RID: 103657 RVA: 0x003AE0EC File Offset: 0x003AC2EC
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
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FocusQuestId = input.ReadInt32();
					}
				}
				else
				{
					this.Reason = (QuestFocusReason)input.ReadEnum();
				}
			}
		}

		// Token: 0x040094BF RID: 38079
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094C0 RID: 38080
		public const int FocusQuestIdFieldNumber = 11;

		// Token: 0x040094C1 RID: 38081
		private int focusQuestId_;

		// Token: 0x040094C2 RID: 38082
		public const int ReasonFieldNumber = 5;

		// Token: 0x040094C3 RID: 38083
		private QuestFocusReason reason_;
	}
}
