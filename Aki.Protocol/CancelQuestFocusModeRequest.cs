using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000233 RID: 563
	[NetMessage(EMessageId.CancelQuestFocusModeRequest)]
	public sealed class CancelQuestFocusModeRequest : IMessage<CancelQuestFocusModeRequest>, IMessage, IEquatable<CancelQuestFocusModeRequest>, IDeepCloneable<CancelQuestFocusModeRequest>, IBufferMessage
	{
		// Token: 0x06003CEB RID: 15595 RVA: 0x000971B5 File Offset: 0x000953B5
		[NullableContext(1)]
		public static CancelQuestFocusModeRequest Create()
		{
			return new CancelQuestFocusModeRequest();
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x000971BC File Offset: 0x000953BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x000971BF File Offset: 0x000953BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelQuestFocusModeRequest.Descriptor;
			}
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x000971C6 File Offset: 0x000953C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeRequest()
		{
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x000971CE File Offset: 0x000953CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeRequest(CancelQuestFocusModeRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x000971F3 File Offset: 0x000953F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeRequest Clone()
		{
			return new CancelQuestFocusModeRequest(this);
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x000971FB File Offset: 0x000953FB
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x00097203 File Offset: 0x00095403
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

		// Token: 0x06003CF3 RID: 15603 RVA: 0x0009720C File Offset: 0x0009540C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelQuestFocusModeRequest);
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0009721A File Offset: 0x0009541A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelQuestFocusModeRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x00097248 File Offset: 0x00095448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x00097287 File Offset: 0x00095487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00097294 File Offset: 0x00095494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0009729D File Offset: 0x0009549D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x000972D0 File Offset: 0x000954D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0009730E File Offset: 0x0009550E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelQuestFocusModeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x0009733F File Offset: 0x0009553F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00097348 File Offset: 0x00095548
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C8A RID: 11402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C8B RID: 11403
		public const int QuestIdFieldNumber = 10;

		// Token: 0x04002C8C RID: 11404
		private int questId_;
	}
}
