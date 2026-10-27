using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BC RID: 188
	public sealed class AdventureManualData : IMessage<AdventureManualData>, IMessage, IEquatable<AdventureManualData>, IDeepCloneable<AdventureManualData>, IBufferMessage
	{
		// Token: 0x06001E6B RID: 7787 RVA: 0x00052F73 File Offset: 0x00051173
		[NullableContext(1)]
		public static AdventureManualData Create()
		{
			return new AdventureManualData();
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x00052F7A File Offset: 0x0005117A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureManualData> Parser
		{
			get
			{
				return AdventureManualData._parser;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00052F81 File Offset: 0x00051181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x00052F84 File Offset: 0x00051184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualData.Descriptor;
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00052F8B File Offset: 0x0005118B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualData()
		{
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00052FB4 File Offset: 0x000511B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualData(AdventureManualData other) : this()
		{
			this.adventreTask_ = other.adventreTask_.Clone();
			this.nowChapter_ = other.nowChapter_;
			this.receivedChapter_ = other.receivedChapter_;
			this.unLockChapters_ = other.unLockChapters_.Clone();
			this.rewardChapters_ = other.rewardChapters_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00053023 File Offset: 0x00051223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualData Clone()
		{
			return new AdventureManualData(this);
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0005302B File Offset: 0x0005122B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventreTask> AdventreTask
		{
			get
			{
				return this.adventreTask_;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00053033 File Offset: 0x00051233
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x0005303B File Offset: 0x0005123B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NowChapter
		{
			get
			{
				return this.nowChapter_;
			}
			set
			{
				this.nowChapter_ = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x00053044 File Offset: 0x00051244
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x0005304C File Offset: 0x0005124C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReceivedChapter
		{
			get
			{
				return this.receivedChapter_;
			}
			set
			{
				this.receivedChapter_ = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00053055 File Offset: 0x00051255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockChapters
		{
			get
			{
				return this.unLockChapters_;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0005305D File Offset: 0x0005125D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardChapters
		{
			get
			{
				return this.rewardChapters_;
			}
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00053065 File Offset: 0x00051265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualData);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00053074 File Offset: 0x00051274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualData other)
		{
			return other != null && (other == this || (this.adventreTask_.Equals(other.adventreTask_) && this.NowChapter == other.NowChapter && this.ReceivedChapter == other.ReceivedChapter && this.unLockChapters_.Equals(other.unLockChapters_) && this.rewardChapters_.Equals(other.rewardChapters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000530FC File Offset: 0x000512FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.adventreTask_.GetHashCode();
			if (this.NowChapter != 0)
			{
				num ^= this.NowChapter.GetHashCode();
			}
			if (this.ReceivedChapter != 0)
			{
				num ^= this.ReceivedChapter.GetHashCode();
			}
			num ^= this.unLockChapters_.GetHashCode();
			num ^= this.rewardChapters_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0005317E File Offset: 0x0005137E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0005318B File Offset: 0x0005138B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00053194 File Offset: 0x00051394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.adventreTask_.WriteTo(ref output, AdventureManualData._repeated_adventreTask_codec);
			if (this.NowChapter != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NowChapter);
			}
			if (this.ReceivedChapter != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ReceivedChapter);
			}
			this.unLockChapters_.WriteTo(ref output, AdventureManualData._repeated_unLockChapters_codec);
			this.rewardChapters_.WriteTo(ref output, AdventureManualData._repeated_rewardChapters_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00053220 File Offset: 0x00051420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.adventreTask_.CalculateSize(AdventureManualData._repeated_adventreTask_codec);
			if (this.NowChapter != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NowChapter);
			}
			if (this.ReceivedChapter != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReceivedChapter);
			}
			num += this.unLockChapters_.CalculateSize(AdventureManualData._repeated_unLockChapters_codec);
			num += this.rewardChapters_.CalculateSize(AdventureManualData._repeated_rewardChapters_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000532B0 File Offset: 0x000514B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureManualData other)
		{
			if (other == null)
			{
				return;
			}
			this.adventreTask_.Add(other.adventreTask_);
			if (other.NowChapter != 0)
			{
				this.NowChapter = other.NowChapter;
			}
			if (other.ReceivedChapter != 0)
			{
				this.ReceivedChapter = other.ReceivedChapter;
			}
			this.unLockChapters_.Add(other.unLockChapters_);
			this.rewardChapters_.Add(other.rewardChapters_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00053333 File Offset: 0x00051533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0005333C File Offset: 0x0005153C
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.adventreTask_.AddEntriesFrom(ref input, AdventureManualData._repeated_adventreTask_codec);
						continue;
					}
					if (num == 16U)
					{
						this.NowChapter = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ReceivedChapter = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.unLockChapters_.AddEntriesFrom(ref input, AdventureManualData._repeated_unLockChapters_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.rewardChapters_.AddEntriesFrom(ref input, AdventureManualData._repeated_rewardChapters_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400235B RID: 9051
		private static readonly MessageParser<AdventureManualData> _parser = new MessageParser<AdventureManualData>(() => new AdventureManualData());

		// Token: 0x0400235C RID: 9052
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400235D RID: 9053
		public const int AdventreTaskFieldNumber = 1;

		// Token: 0x0400235E RID: 9054
		private static readonly FieldCodec<AdventreTask> _repeated_adventreTask_codec = FieldCodec.ForMessage<AdventreTask>(10U, Aki.Protocol.AdventreTask.Parser);

		// Token: 0x0400235F RID: 9055
		private readonly RepeatedField<AdventreTask> adventreTask_ = new RepeatedField<AdventreTask>();

		// Token: 0x04002360 RID: 9056
		public const int NowChapterFieldNumber = 2;

		// Token: 0x04002361 RID: 9057
		private int nowChapter_;

		// Token: 0x04002362 RID: 9058
		public const int ReceivedChapterFieldNumber = 3;

		// Token: 0x04002363 RID: 9059
		private int receivedChapter_;

		// Token: 0x04002364 RID: 9060
		public const int UnLockChaptersFieldNumber = 4;

		// Token: 0x04002365 RID: 9061
		private static readonly FieldCodec<int> _repeated_unLockChapters_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04002366 RID: 9062
		private readonly RepeatedField<int> unLockChapters_ = new RepeatedField<int>();

		// Token: 0x04002367 RID: 9063
		public const int RewardChaptersFieldNumber = 5;

		// Token: 0x04002368 RID: 9064
		private static readonly FieldCodec<int> _repeated_rewardChapters_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04002369 RID: 9065
		private readonly RepeatedField<int> rewardChapters_ = new RepeatedField<int>();
	}
}
