using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004E RID: 78
	[NetMessage(EMessageId.AcceptFocusWaitQuestRequest)]
	public sealed class AcceptFocusWaitQuestRequest : IMessage<AcceptFocusWaitQuestRequest>, IMessage, IEquatable<AcceptFocusWaitQuestRequest>, IDeepCloneable<AcceptFocusWaitQuestRequest>, IBufferMessage
	{
		// Token: 0x060014DC RID: 5340 RVA: 0x00037CB9 File Offset: 0x00035EB9
		[NullableContext(1)]
		public static AcceptFocusWaitQuestRequest Create()
		{
			return new AcceptFocusWaitQuestRequest();
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00037CC0 File Offset: 0x00035EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x00037CC3 File Offset: 0x00035EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptFocusWaitQuestRequest.Descriptor;
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00037CCA File Offset: 0x00035ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestRequest()
		{
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00037CD2 File Offset: 0x00035ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestRequest(AcceptFocusWaitQuestRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00037CF7 File Offset: 0x00035EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestRequest Clone()
		{
			return new AcceptFocusWaitQuestRequest(this);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00037CFF File Offset: 0x00035EFF
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x00037D07 File Offset: 0x00035F07
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

		// Token: 0x060014E4 RID: 5348 RVA: 0x00037D10 File Offset: 0x00035F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptFocusWaitQuestRequest);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00037D1E File Offset: 0x00035F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptFocusWaitQuestRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00037D4C File Offset: 0x00035F4C
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

		// Token: 0x060014E7 RID: 5351 RVA: 0x00037D8B File Offset: 0x00035F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00037D98 File Offset: 0x00035F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00037DA1 File Offset: 0x00035FA1
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

		// Token: 0x060014EA RID: 5354 RVA: 0x00037DD4 File Offset: 0x00035FD4
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

		// Token: 0x060014EB RID: 5355 RVA: 0x00037E12 File Offset: 0x00036012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptFocusWaitQuestRequest other)
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

		// Token: 0x060014EC RID: 5356 RVA: 0x00037E43 File Offset: 0x00036043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00037E4C File Offset: 0x0003604C
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

		// Token: 0x040020C9 RID: 8393
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020CA RID: 8394
		public const int QuestIdFieldNumber = 13;

		// Token: 0x040020CB RID: 8395
		private int questId_;
	}
}
