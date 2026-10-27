using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E05 RID: 3589
	public sealed class QuestActiveActionCtxPb : IMessage<QuestActiveActionCtxPb>, IMessage, IEquatable<QuestActiveActionCtxPb>, IDeepCloneable<QuestActiveActionCtxPb>, IBufferMessage
	{
		// Token: 0x060134B7 RID: 79031 RVA: 0x002CEFC1 File Offset: 0x002CD1C1
		[NullableContext(1)]
		public static QuestActiveActionCtxPb Create()
		{
			return new QuestActiveActionCtxPb();
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x060134B8 RID: 79032 RVA: 0x002CEFC8 File Offset: 0x002CD1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x060134B9 RID: 79033 RVA: 0x002CEFCB File Offset: 0x002CD1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestActiveActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060134BA RID: 79034 RVA: 0x002CEFD2 File Offset: 0x002CD1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActiveActionCtxPb()
		{
		}

		// Token: 0x060134BB RID: 79035 RVA: 0x002CEFDA File Offset: 0x002CD1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActiveActionCtxPb(QuestActiveActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134BC RID: 79036 RVA: 0x002CEFFF File Offset: 0x002CD1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActiveActionCtxPb Clone()
		{
			return new QuestActiveActionCtxPb(this);
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x060134BD RID: 79037 RVA: 0x002CF007 File Offset: 0x002CD207
		// (set) Token: 0x060134BE RID: 79038 RVA: 0x002CF00F File Offset: 0x002CD20F
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

		// Token: 0x060134BF RID: 79039 RVA: 0x002CF018 File Offset: 0x002CD218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestActiveActionCtxPb);
		}

		// Token: 0x060134C0 RID: 79040 RVA: 0x002CF026 File Offset: 0x002CD226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestActiveActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134C1 RID: 79041 RVA: 0x002CF054 File Offset: 0x002CD254
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

		// Token: 0x060134C2 RID: 79042 RVA: 0x002CF093 File Offset: 0x002CD293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134C3 RID: 79043 RVA: 0x002CF0A0 File Offset: 0x002CD2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134C4 RID: 79044 RVA: 0x002CF0A9 File Offset: 0x002CD2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060134C5 RID: 79045 RVA: 0x002CF0DC File Offset: 0x002CD2DC
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

		// Token: 0x060134C6 RID: 79046 RVA: 0x002CF11A File Offset: 0x002CD31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestActiveActionCtxPb other)
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

		// Token: 0x060134C7 RID: 79047 RVA: 0x002CF14B File Offset: 0x002CD34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134C8 RID: 79048 RVA: 0x002CF154 File Offset: 0x002CD354
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400769A RID: 30362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400769B RID: 30363
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400769C RID: 30364
		private int questId_;
	}
}
