using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000238 RID: 568
	[NetMessage(EMessageId.CancelQuestFocusModeRequest)]
	public sealed class CancelQuestFocusModeRequest : IMessage<CancelQuestFocusModeRequest>, IMessage, IEquatable<CancelQuestFocusModeRequest>, IDeepCloneable<CancelQuestFocusModeRequest>, IBufferMessage
	{
		// Token: 0x06003D90 RID: 15760 RVA: 0x00098DD1 File Offset: 0x00096FD1
		[NullableContext(1)]
		public static CancelQuestFocusModeRequest Create()
		{
			return new CancelQuestFocusModeRequest();
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06003D91 RID: 15761 RVA: 0x00098DD8 File Offset: 0x00096FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06003D92 RID: 15762 RVA: 0x00098DDB File Offset: 0x00096FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelQuestFocusModeRequest.Descriptor;
			}
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00098DE2 File Offset: 0x00096FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeRequest()
		{
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00098DEA File Offset: 0x00096FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeRequest(CancelQuestFocusModeRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x00098E0F File Offset: 0x0009700F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelQuestFocusModeRequest Clone()
		{
			return new CancelQuestFocusModeRequest(this);
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06003D96 RID: 15766 RVA: 0x00098E17 File Offset: 0x00097017
		// (set) Token: 0x06003D97 RID: 15767 RVA: 0x00098E1F File Offset: 0x0009701F
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

		// Token: 0x06003D98 RID: 15768 RVA: 0x00098E28 File Offset: 0x00097028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelQuestFocusModeRequest);
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00098E36 File Offset: 0x00097036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelQuestFocusModeRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00098E64 File Offset: 0x00097064
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

		// Token: 0x06003D9B RID: 15771 RVA: 0x00098EA3 File Offset: 0x000970A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00098EB0 File Offset: 0x000970B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x00098EB9 File Offset: 0x000970B9
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

		// Token: 0x06003D9E RID: 15774 RVA: 0x00098EEC File Offset: 0x000970EC
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

		// Token: 0x06003D9F RID: 15775 RVA: 0x00098F2A File Offset: 0x0009712A
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

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00098F5B File Offset: 0x0009715B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00098F64 File Offset: 0x00097164
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

		// Token: 0x04002D0C RID: 11532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D0D RID: 11533
		public const int QuestIdFieldNumber = 13;

		// Token: 0x04002D0E RID: 11534
		private int questId_;
	}
}
