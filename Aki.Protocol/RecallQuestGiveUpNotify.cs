using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC0 RID: 3776
	[NetMessage(EMessageId.RecallQuestGiveUpNotify)]
	public sealed class RecallQuestGiveUpNotify : IMessage<RecallQuestGiveUpNotify>, IMessage, IEquatable<RecallQuestGiveUpNotify>, IDeepCloneable<RecallQuestGiveUpNotify>, IBufferMessage
	{
		// Token: 0x06014405 RID: 82949 RVA: 0x002F1CD1 File Offset: 0x002EFED1
		[NullableContext(1)]
		public static RecallQuestGiveUpNotify Create()
		{
			return new RecallQuestGiveUpNotify();
		}

		// Token: 0x17004355 RID: 17237
		// (get) Token: 0x06014406 RID: 82950 RVA: 0x002F1CD8 File Offset: 0x002EFED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x06014407 RID: 82951 RVA: 0x002F1CDB File Offset: 0x002EFEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestGiveUpNotify.Descriptor;
			}
		}

		// Token: 0x06014408 RID: 82952 RVA: 0x002F1CE2 File Offset: 0x002EFEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestGiveUpNotify()
		{
		}

		// Token: 0x06014409 RID: 82953 RVA: 0x002F1CF8 File Offset: 0x002EFEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestGiveUpNotify(RecallQuestGiveUpNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.treeIncId_ = other.treeIncId_;
			this.flowIncIds_ = other.flowIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601440A RID: 82954 RVA: 0x002F1D45 File Offset: 0x002EFF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestGiveUpNotify Clone()
		{
			return new RecallQuestGiveUpNotify(this);
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x0601440B RID: 82955 RVA: 0x002F1D4D File Offset: 0x002EFF4D
		// (set) Token: 0x0601440C RID: 82956 RVA: 0x002F1D55 File Offset: 0x002EFF55
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

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x0601440D RID: 82957 RVA: 0x002F1D5E File Offset: 0x002EFF5E
		// (set) Token: 0x0601440E RID: 82958 RVA: 0x002F1D66 File Offset: 0x002EFF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x0601440F RID: 82959 RVA: 0x002F1D6F File Offset: 0x002EFF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> FlowIncIds
		{
			get
			{
				return this.flowIncIds_;
			}
		}

		// Token: 0x06014410 RID: 82960 RVA: 0x002F1D77 File Offset: 0x002EFF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestGiveUpNotify);
		}

		// Token: 0x06014411 RID: 82961 RVA: 0x002F1D88 File Offset: 0x002EFF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestGiveUpNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.TreeIncId == other.TreeIncId && this.flowIncIds_.Equals(other.flowIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014412 RID: 82962 RVA: 0x002F1DE8 File Offset: 0x002EFFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			num ^= this.flowIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014413 RID: 82963 RVA: 0x002F1E4E File Offset: 0x002F004E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014414 RID: 82964 RVA: 0x002F1E5B File Offset: 0x002F005B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014415 RID: 82965 RVA: 0x002F1E64 File Offset: 0x002F0064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flowIncIds_.WriteTo(ref output, RecallQuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014416 RID: 82966 RVA: 0x002F1ED0 File Offset: 0x002F00D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			num += this.flowIncIds_.CalculateSize(RecallQuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014417 RID: 82967 RVA: 0x002F1F3C File Offset: 0x002F013C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestGiveUpNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this.flowIncIds_.Add(other.flowIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014418 RID: 82968 RVA: 0x002F1F9D File Offset: 0x002F019D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014419 RID: 82969 RVA: 0x002F1FA8 File Offset: 0x002F01A8
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.flowIncIds_.AddEntriesFrom(ref input, RecallQuestGiveUpNotify._repeated_flowIncIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.RecallQuestId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B24 RID: 31524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B25 RID: 31525
		public const int RecallQuestIdFieldNumber = 6;

		// Token: 0x04007B26 RID: 31526
		private int recallQuestId_;

		// Token: 0x04007B27 RID: 31527
		public const int TreeIncIdFieldNumber = 8;

		// Token: 0x04007B28 RID: 31528
		private long treeIncId_;

		// Token: 0x04007B29 RID: 31529
		public const int FlowIncIdsFieldNumber = 3;

		// Token: 0x04007B2A RID: 31530
		private static readonly FieldCodec<long> _repeated_flowIncIds_codec = FieldCodec.ForInt64(26U);

		// Token: 0x04007B2B RID: 31531
		private readonly RepeatedField<long> flowIncIds_ = new RepeatedField<long>();
	}
}
