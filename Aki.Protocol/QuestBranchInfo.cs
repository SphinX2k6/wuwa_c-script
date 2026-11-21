using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF6 RID: 3574
	public sealed class QuestBranchInfo : IMessage<QuestBranchInfo>, IMessage, IEquatable<QuestBranchInfo>, IDeepCloneable<QuestBranchInfo>, IBufferMessage
	{
		// Token: 0x060133E4 RID: 78820 RVA: 0x002CDAD8 File Offset: 0x002CBCD8
		[NullableContext(1)]
		public static QuestBranchInfo Create()
		{
			return new QuestBranchInfo();
		}

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x060133E5 RID: 78821 RVA: 0x002CDADF File Offset: 0x002CBCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x060133E6 RID: 78822 RVA: 0x002CDAE2 File Offset: 0x002CBCE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchInfo.Descriptor;
			}
		}

		// Token: 0x060133E7 RID: 78823 RVA: 0x002CDAE9 File Offset: 0x002CBCE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo()
		{
		}

		// Token: 0x060133E8 RID: 78824 RVA: 0x002CDB14 File Offset: 0x002CBD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo(QuestBranchInfo other) : this()
		{
			this.questBranchInfos_ = other.questBranchInfos_.Clone();
			this.unlockTimePoints_ = other.unlockTimePoints_.Clone();
			this.unlockBranchComponentsGroup_ = other.unlockBranchComponentsGroup_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060133E9 RID: 78825 RVA: 0x002CDB6B File Offset: 0x002CBD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo Clone()
		{
			return new QuestBranchInfo(this);
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x060133EA RID: 78826 RVA: 0x002CDB73 File Offset: 0x002CBD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneQuestBranchPageInfo> QuestBranchInfos
		{
			get
			{
				return this.questBranchInfos_;
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x060133EB RID: 78827 RVA: 0x002CDB7B File Offset: 0x002CBD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTimePoints
		{
			get
			{
				return this.unlockTimePoints_;
			}
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x060133EC RID: 78828 RVA: 0x002CDB83 File Offset: 0x002CBD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBranchComponentsGroup
		{
			get
			{
				return this.unlockBranchComponentsGroup_;
			}
		}

		// Token: 0x060133ED RID: 78829 RVA: 0x002CDB8B File Offset: 0x002CBD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchInfo);
		}

		// Token: 0x060133EE RID: 78830 RVA: 0x002CDB9C File Offset: 0x002CBD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchInfo other)
		{
			return other != null && (other == this || (this.questBranchInfos_.Equals(other.questBranchInfos_) && this.unlockTimePoints_.Equals(other.unlockTimePoints_) && this.unlockBranchComponentsGroup_.Equals(other.unlockBranchComponentsGroup_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060133EF RID: 78831 RVA: 0x002CDC04 File Offset: 0x002CBE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.questBranchInfos_.GetHashCode();
			num ^= this.unlockTimePoints_.GetHashCode();
			num ^= this.unlockBranchComponentsGroup_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060133F0 RID: 78832 RVA: 0x002CDC54 File Offset: 0x002CBE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060133F1 RID: 78833 RVA: 0x002CDC61 File Offset: 0x002CBE61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060133F2 RID: 78834 RVA: 0x002CDC6C File Offset: 0x002CBE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.questBranchInfos_.WriteTo(ref output, QuestBranchInfo._repeated_questBranchInfos_codec);
			this.unlockTimePoints_.WriteTo(ref output, QuestBranchInfo._repeated_unlockTimePoints_codec);
			this.unlockBranchComponentsGroup_.WriteTo(ref output, QuestBranchInfo._repeated_unlockBranchComponentsGroup_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060133F3 RID: 78835 RVA: 0x002CDCC0 File Offset: 0x002CBEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.questBranchInfos_.CalculateSize(QuestBranchInfo._repeated_questBranchInfos_codec);
			num += this.unlockTimePoints_.CalculateSize(QuestBranchInfo._repeated_unlockTimePoints_codec);
			num += this.unlockBranchComponentsGroup_.CalculateSize(QuestBranchInfo._repeated_unlockBranchComponentsGroup_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060133F4 RID: 78836 RVA: 0x002CDD20 File Offset: 0x002CBF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuestBranchInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.questBranchInfos_.Add(other.questBranchInfos_);
			this.unlockTimePoints_.Add(other.unlockTimePoints_);
			this.unlockBranchComponentsGroup_.Add(other.unlockBranchComponentsGroup_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060133F5 RID: 78837 RVA: 0x002CDD7B File Offset: 0x002CBF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060133F6 RID: 78838 RVA: 0x002CDD84 File Offset: 0x002CBF84
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.questBranchInfos_.AddEntriesFrom(ref input, QuestBranchInfo._repeated_questBranchInfos_codec);
						continue;
					}
					if (num == 16U)
					{
						goto IL_50;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_50;
					}
					if (num == 24U || num == 26U)
					{
						this.unlockBranchComponentsGroup_.AddEntriesFrom(ref input, QuestBranchInfo._repeated_unlockBranchComponentsGroup_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_50:
				this.unlockTimePoints_.AddEntriesFrom(ref input, QuestBranchInfo._repeated_unlockTimePoints_codec);
			}
		}

		// Token: 0x040076C7 RID: 30407
		private UnknownFieldSet _unknownFields;

		// Token: 0x040076C8 RID: 30408
		public const int QuestBranchInfosFieldNumber = 1;

		// Token: 0x040076C9 RID: 30409
		private static readonly FieldCodec<OneQuestBranchPageInfo> _repeated_questBranchInfos_codec = FieldCodec.ForMessage<OneQuestBranchPageInfo>(10U, OneQuestBranchPageInfo.Parser);

		// Token: 0x040076CA RID: 30410
		private readonly RepeatedField<OneQuestBranchPageInfo> questBranchInfos_ = new RepeatedField<OneQuestBranchPageInfo>();

		// Token: 0x040076CB RID: 30411
		public const int UnlockTimePointsFieldNumber = 2;

		// Token: 0x040076CC RID: 30412
		private static readonly FieldCodec<int> _repeated_unlockTimePoints_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040076CD RID: 30413
		private readonly RepeatedField<int> unlockTimePoints_ = new RepeatedField<int>();

		// Token: 0x040076CE RID: 30414
		public const int UnlockBranchComponentsGroupFieldNumber = 3;

		// Token: 0x040076CF RID: 30415
		private static readonly FieldCodec<int> _repeated_unlockBranchComponentsGroup_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040076D0 RID: 30416
		private readonly RepeatedField<int> unlockBranchComponentsGroup_ = new RepeatedField<int>();
	}
}
