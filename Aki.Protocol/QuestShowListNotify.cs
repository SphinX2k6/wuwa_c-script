using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E2F RID: 3631
	[NetMessage(EMessageId.QuestShowListNotify)]
	public sealed class QuestShowListNotify : IMessage<QuestShowListNotify>, IMessage, IEquatable<QuestShowListNotify>, IDeepCloneable<QuestShowListNotify>, IBufferMessage
	{
		// Token: 0x060137F0 RID: 79856 RVA: 0x002D5598 File Offset: 0x002D3798
		[NullableContext(1)]
		public static QuestShowListNotify Create()
		{
			return new QuestShowListNotify();
		}

		// Token: 0x170040A4 RID: 16548
		// (get) Token: 0x060137F1 RID: 79857 RVA: 0x002D559F File Offset: 0x002D379F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040A5 RID: 16549
		// (get) Token: 0x060137F2 RID: 79858 RVA: 0x002D55A2 File Offset: 0x002D37A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestShowListNotify.Descriptor;
			}
		}

		// Token: 0x060137F3 RID: 79859 RVA: 0x002D55A9 File Offset: 0x002D37A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestShowListNotify()
		{
		}

		// Token: 0x060137F4 RID: 79860 RVA: 0x002D55BC File Offset: 0x002D37BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestShowListNotify(QuestShowListNotify other) : this()
		{
			this.questId_ = other.questId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060137F5 RID: 79861 RVA: 0x002D55E6 File Offset: 0x002D37E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestShowListNotify Clone()
		{
			return new QuestShowListNotify(this);
		}

		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x060137F6 RID: 79862 RVA: 0x002D55EE File Offset: 0x002D37EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> QuestId
		{
			get
			{
				return this.questId_;
			}
		}

		// Token: 0x060137F7 RID: 79863 RVA: 0x002D55F6 File Offset: 0x002D37F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestShowListNotify);
		}

		// Token: 0x060137F8 RID: 79864 RVA: 0x002D5604 File Offset: 0x002D3804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestShowListNotify other)
		{
			return other != null && (other == this || (this.questId_.Equals(other.questId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060137F9 RID: 79865 RVA: 0x002D5638 File Offset: 0x002D3838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060137FA RID: 79866 RVA: 0x002D566C File Offset: 0x002D386C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060137FB RID: 79867 RVA: 0x002D5679 File Offset: 0x002D3879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060137FC RID: 79868 RVA: 0x002D5682 File Offset: 0x002D3882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questId_.WriteTo(ref output, QuestShowListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060137FD RID: 79869 RVA: 0x002D56AC File Offset: 0x002D38AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questId_.CalculateSize(QuestShowListNotify._repeated_questId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060137FE RID: 79870 RVA: 0x002D56E5 File Offset: 0x002D38E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestShowListNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.questId_.Add(other.questId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060137FF RID: 79871 RVA: 0x002D5713 File Offset: 0x002D3913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013800 RID: 79872 RVA: 0x002D571C File Offset: 0x002D391C
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.questId_.AddEntriesFrom(ref input, QuestShowListNotify._repeated_questId_codec);
				}
			}
		}

		// Token: 0x0400776A RID: 30570
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400776B RID: 30571
		public const int QuestIdFieldNumber = 12;

		// Token: 0x0400776C RID: 30572
		private static readonly FieldCodec<int> _repeated_questId_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400776D RID: 30573
		private readonly RepeatedField<int> questId_ = new RepeatedField<int>();
	}
}
