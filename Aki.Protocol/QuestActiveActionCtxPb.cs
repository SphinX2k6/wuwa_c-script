using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF5 RID: 3573
	public sealed class QuestActiveActionCtxPb : IMessage<QuestActiveActionCtxPb>, IMessage, IEquatable<QuestActiveActionCtxPb>, IDeepCloneable<QuestActiveActionCtxPb>, IBufferMessage
	{
		// Token: 0x060133D2 RID: 78802 RVA: 0x002CD900 File Offset: 0x002CBB00
		[NullableContext(1)]
		public static QuestActiveActionCtxPb Create()
		{
			return new QuestActiveActionCtxPb();
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x060133D3 RID: 78803 RVA: 0x002CD907 File Offset: 0x002CBB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x060133D4 RID: 78804 RVA: 0x002CD90A File Offset: 0x002CBB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestActiveActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060133D5 RID: 78805 RVA: 0x002CD911 File Offset: 0x002CBB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActiveActionCtxPb()
		{
		}

		// Token: 0x060133D6 RID: 78806 RVA: 0x002CD919 File Offset: 0x002CBB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActiveActionCtxPb(QuestActiveActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133D7 RID: 78807 RVA: 0x002CD93E File Offset: 0x002CBB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestActiveActionCtxPb Clone()
		{
			return new QuestActiveActionCtxPb(this);
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x060133D8 RID: 78808 RVA: 0x002CD946 File Offset: 0x002CBB46
		// (set) Token: 0x060133D9 RID: 78809 RVA: 0x002CD94E File Offset: 0x002CBB4E
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

		// Token: 0x060133DA RID: 78810 RVA: 0x002CD957 File Offset: 0x002CBB57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestActiveActionCtxPb);
		}

		// Token: 0x060133DB RID: 78811 RVA: 0x002CD965 File Offset: 0x002CBB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestActiveActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133DC RID: 78812 RVA: 0x002CD994 File Offset: 0x002CBB94
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

		// Token: 0x060133DD RID: 78813 RVA: 0x002CD9D3 File Offset: 0x002CBBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133DE RID: 78814 RVA: 0x002CD9E0 File Offset: 0x002CBBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133DF RID: 78815 RVA: 0x002CD9E9 File Offset: 0x002CBBE9
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

		// Token: 0x060133E0 RID: 78816 RVA: 0x002CDA1C File Offset: 0x002CBC1C
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

		// Token: 0x060133E1 RID: 78817 RVA: 0x002CDA5A File Offset: 0x002CBC5A
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

		// Token: 0x060133E2 RID: 78818 RVA: 0x002CDA8B File Offset: 0x002CBC8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133E3 RID: 78819 RVA: 0x002CDA94 File Offset: 0x002CBC94
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

		// Token: 0x040076C4 RID: 30404
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076C5 RID: 30405
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040076C6 RID: 30406
		private int questId_;
	}
}
