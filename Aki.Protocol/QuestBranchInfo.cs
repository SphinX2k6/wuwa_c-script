using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E06 RID: 3590
	public sealed class QuestBranchInfo : IMessage<QuestBranchInfo>, IMessage, IEquatable<QuestBranchInfo>, IDeepCloneable<QuestBranchInfo>, IBufferMessage
	{
		// Token: 0x060134C9 RID: 79049 RVA: 0x002CF198 File Offset: 0x002CD398
		[NullableContext(1)]
		public static QuestBranchInfo Create()
		{
			return new QuestBranchInfo();
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x060134CA RID: 79050 RVA: 0x002CF19F File Offset: 0x002CD39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x060134CB RID: 79051 RVA: 0x002CF1A2 File Offset: 0x002CD3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuestBranchInfo.Descriptor;
			}
		}

		// Token: 0x060134CC RID: 79052 RVA: 0x002CF1A9 File Offset: 0x002CD3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo()
		{
		}

		// Token: 0x060134CD RID: 79053 RVA: 0x002CF1D4 File Offset: 0x002CD3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo(QuestBranchInfo other) : this()
		{
			this.questBranchInfos_ = other.questBranchInfos_.Clone();
			this.unlockTimePoints_ = other.unlockTimePoints_.Clone();
			this.unlockBranchComponentsGroup_ = other.unlockBranchComponentsGroup_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060134CE RID: 79054 RVA: 0x002CF22B File Offset: 0x002CD42B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuestBranchInfo Clone()
		{
			return new QuestBranchInfo(this);
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x060134CF RID: 79055 RVA: 0x002CF233 File Offset: 0x002CD433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneQuestBranchPageInfo> QuestBranchInfos
		{
			get
			{
				return this.questBranchInfos_;
			}
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x060134D0 RID: 79056 RVA: 0x002CF23B File Offset: 0x002CD43B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockTimePoints
		{
			get
			{
				return this.unlockTimePoints_;
			}
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x060134D1 RID: 79057 RVA: 0x002CF243 File Offset: 0x002CD443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockBranchComponentsGroup
		{
			get
			{
				return this.unlockBranchComponentsGroup_;
			}
		}

		// Token: 0x060134D2 RID: 79058 RVA: 0x002CF24B File Offset: 0x002CD44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuestBranchInfo);
		}

		// Token: 0x060134D3 RID: 79059 RVA: 0x002CF25C File Offset: 0x002CD45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuestBranchInfo other)
		{
			return other != null && (other == this || (this.questBranchInfos_.Equals(other.questBranchInfos_) && this.unlockTimePoints_.Equals(other.unlockTimePoints_) && this.unlockBranchComponentsGroup_.Equals(other.unlockBranchComponentsGroup_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060134D4 RID: 79060 RVA: 0x002CF2C4 File Offset: 0x002CD4C4
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

		// Token: 0x060134D5 RID: 79061 RVA: 0x002CF314 File Offset: 0x002CD514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060134D6 RID: 79062 RVA: 0x002CF321 File Offset: 0x002CD521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060134D7 RID: 79063 RVA: 0x002CF32C File Offset: 0x002CD52C
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

		// Token: 0x060134D8 RID: 79064 RVA: 0x002CF380 File Offset: 0x002CD580
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

		// Token: 0x060134D9 RID: 79065 RVA: 0x002CF3E0 File Offset: 0x002CD5E0
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

		// Token: 0x060134DA RID: 79066 RVA: 0x002CF43B File Offset: 0x002CD63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060134DB RID: 79067 RVA: 0x002CF444 File Offset: 0x002CD644
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

		// Token: 0x0400769D RID: 30365
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400769E RID: 30366
		public const int QuestBranchInfosFieldNumber = 1;

		// Token: 0x0400769F RID: 30367
		private static readonly FieldCodec<OneQuestBranchPageInfo> _repeated_questBranchInfos_codec = FieldCodec.ForMessage<OneQuestBranchPageInfo>(10U, OneQuestBranchPageInfo.Parser);

		// Token: 0x040076A0 RID: 30368
		private readonly RepeatedField<OneQuestBranchPageInfo> questBranchInfos_ = new RepeatedField<OneQuestBranchPageInfo>();

		// Token: 0x040076A1 RID: 30369
		public const int UnlockTimePointsFieldNumber = 2;

		// Token: 0x040076A2 RID: 30370
		private static readonly FieldCodec<int> _repeated_unlockTimePoints_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040076A3 RID: 30371
		private readonly RepeatedField<int> unlockTimePoints_ = new RepeatedField<int>();

		// Token: 0x040076A4 RID: 30372
		public const int UnlockBranchComponentsGroupFieldNumber = 3;

		// Token: 0x040076A5 RID: 30373
		private static readonly FieldCodec<int> _repeated_unlockBranchComponentsGroup_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040076A6 RID: 30374
		private readonly RepeatedField<int> unlockBranchComponentsGroup_ = new RepeatedField<int>();
	}
}
