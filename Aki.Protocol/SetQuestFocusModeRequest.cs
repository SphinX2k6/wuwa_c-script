using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001216 RID: 4630
	[NetMessage(EMessageId.SetQuestFocusModeRequest)]
	public sealed class SetQuestFocusModeRequest : IMessage<SetQuestFocusModeRequest>, IMessage, IEquatable<SetQuestFocusModeRequest>, IDeepCloneable<SetQuestFocusModeRequest>, IBufferMessage
	{
		// Token: 0x06018BA3 RID: 101283 RVA: 0x0039AB91 File Offset: 0x00398D91
		[NullableContext(1)]
		public static SetQuestFocusModeRequest Create()
		{
			return new SetQuestFocusModeRequest();
		}

		// Token: 0x1700537C RID: 21372
		// (get) Token: 0x06018BA4 RID: 101284 RVA: 0x0039AB98 File Offset: 0x00398D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700537D RID: 21373
		// (get) Token: 0x06018BA5 RID: 101285 RVA: 0x0039AB9B File Offset: 0x00398D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestFocusModeRequest.Descriptor;
			}
		}

		// Token: 0x06018BA6 RID: 101286 RVA: 0x0039ABA2 File Offset: 0x00398DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeRequest()
		{
		}

		// Token: 0x06018BA7 RID: 101287 RVA: 0x0039ABAA File Offset: 0x00398DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeRequest(SetQuestFocusModeRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BA8 RID: 101288 RVA: 0x0039ABCF File Offset: 0x00398DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeRequest Clone()
		{
			return new SetQuestFocusModeRequest(this);
		}

		// Token: 0x1700537E RID: 21374
		// (get) Token: 0x06018BA9 RID: 101289 RVA: 0x0039ABD7 File Offset: 0x00398DD7
		// (set) Token: 0x06018BAA RID: 101290 RVA: 0x0039ABDF File Offset: 0x00398DDF
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

		// Token: 0x06018BAB RID: 101291 RVA: 0x0039ABE8 File Offset: 0x00398DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestFocusModeRequest);
		}

		// Token: 0x06018BAC RID: 101292 RVA: 0x0039ABF6 File Offset: 0x00398DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestFocusModeRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BAD RID: 101293 RVA: 0x0039AC24 File Offset: 0x00398E24
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

		// Token: 0x06018BAE RID: 101294 RVA: 0x0039AC63 File Offset: 0x00398E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BAF RID: 101295 RVA: 0x0039AC70 File Offset: 0x00398E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BB0 RID: 101296 RVA: 0x0039AC79 File Offset: 0x00398E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018BB1 RID: 101297 RVA: 0x0039ACAC File Offset: 0x00398EAC
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

		// Token: 0x06018BB2 RID: 101298 RVA: 0x0039ACEA File Offset: 0x00398EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetQuestFocusModeRequest other)
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

		// Token: 0x06018BB3 RID: 101299 RVA: 0x0039AD1B File Offset: 0x00398F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BB4 RID: 101300 RVA: 0x0039AD24 File Offset: 0x00398F24
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040092C1 RID: 37569
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092C2 RID: 37570
		public const int QuestIdFieldNumber = 13;

		// Token: 0x040092C3 RID: 37571
		private int questId_;
	}
}
