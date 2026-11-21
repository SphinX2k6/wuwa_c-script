using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E0F RID: 3599
	[NetMessage(EMessageId.QuestReadyForGiveUpRequest)]
	public sealed class QuestReadyForGiveUpRequest : IMessage<QuestReadyForGiveUpRequest>, IMessage, IEquatable<QuestReadyForGiveUpRequest>, IDeepCloneable<QuestReadyForGiveUpRequest>, IBufferMessage
	{
		// Token: 0x060135CA RID: 79306 RVA: 0x002D16B1 File Offset: 0x002CF8B1
		[NullableContext(1)]
		public static QuestReadyForGiveUpRequest Create()
		{
			return new QuestReadyForGiveUpRequest();
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x060135CB RID: 79307 RVA: 0x002D16B8 File Offset: 0x002CF8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x060135CC RID: 79308 RVA: 0x002D16BB File Offset: 0x002CF8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestReadyForGiveUpRequest.Descriptor;
			}
		}

		// Token: 0x060135CD RID: 79309 RVA: 0x002D16C2 File Offset: 0x002CF8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpRequest()
		{
		}

		// Token: 0x060135CE RID: 79310 RVA: 0x002D16CA File Offset: 0x002CF8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpRequest(QuestReadyForGiveUpRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060135CF RID: 79311 RVA: 0x002D16EF File Offset: 0x002CF8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestReadyForGiveUpRequest Clone()
		{
			return new QuestReadyForGiveUpRequest(this);
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x060135D0 RID: 79312 RVA: 0x002D16F7 File Offset: 0x002CF8F7
		// (set) Token: 0x060135D1 RID: 79313 RVA: 0x002D16FF File Offset: 0x002CF8FF
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

		// Token: 0x060135D2 RID: 79314 RVA: 0x002D1708 File Offset: 0x002CF908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestReadyForGiveUpRequest);
		}

		// Token: 0x060135D3 RID: 79315 RVA: 0x002D1716 File Offset: 0x002CF916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestReadyForGiveUpRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060135D4 RID: 79316 RVA: 0x002D1744 File Offset: 0x002CF944
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

		// Token: 0x060135D5 RID: 79317 RVA: 0x002D1783 File Offset: 0x002CF983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060135D6 RID: 79318 RVA: 0x002D1790 File Offset: 0x002CF990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060135D7 RID: 79319 RVA: 0x002D1799 File Offset: 0x002CF999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060135D8 RID: 79320 RVA: 0x002D17CC File Offset: 0x002CF9CC
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

		// Token: 0x060135D9 RID: 79321 RVA: 0x002D180A File Offset: 0x002CFA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestReadyForGiveUpRequest other)
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

		// Token: 0x060135DA RID: 79322 RVA: 0x002D183B File Offset: 0x002CFA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060135DB RID: 79323 RVA: 0x002D1844 File Offset: 0x002CFA44
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400773E RID: 30526
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400773F RID: 30527
		public const int QuestIdFieldNumber = 6;

		// Token: 0x04007740 RID: 30528
		private int questId_;
	}
}
