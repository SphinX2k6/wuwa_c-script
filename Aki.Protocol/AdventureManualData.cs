using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BD RID: 189
	public sealed class AdventureManualData : IMessage<AdventureManualData>, IMessage, IEquatable<AdventureManualData>, IDeepCloneable<AdventureManualData>, IBufferMessage
	{
		// Token: 0x06001EB4 RID: 7860 RVA: 0x00053C27 File Offset: 0x00051E27
		[NullableContext(1)]
		public static AdventureManualData Create()
		{
			return new AdventureManualData();
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00053C2E File Offset: 0x00051E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureManualData> Parser
		{
			get
			{
				return AdventureManualData._parser;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00053C35 File Offset: 0x00051E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00053C38 File Offset: 0x00051E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureManualData.Descriptor;
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00053C3F File Offset: 0x00051E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualData()
		{
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00053C68 File Offset: 0x00051E68
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

		// Token: 0x06001EBA RID: 7866 RVA: 0x00053CD7 File Offset: 0x00051ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureManualData Clone()
		{
			return new AdventureManualData(this);
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00053CDF File Offset: 0x00051EDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AdventreTask> AdventreTask
		{
			get
			{
				return this.adventreTask_;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00053CE7 File Offset: 0x00051EE7
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00053CEF File Offset: 0x00051EEF
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

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00053CF8 File Offset: 0x00051EF8
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00053D00 File Offset: 0x00051F00
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00053D09 File Offset: 0x00051F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockChapters
		{
			get
			{
				return this.unLockChapters_;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00053D11 File Offset: 0x00051F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardChapters
		{
			get
			{
				return this.rewardChapters_;
			}
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00053D19 File Offset: 0x00051F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureManualData);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00053D28 File Offset: 0x00051F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureManualData other)
		{
			return other != null && (other == this || (this.adventreTask_.Equals(other.adventreTask_) && this.NowChapter == other.NowChapter && this.ReceivedChapter == other.ReceivedChapter && this.unLockChapters_.Equals(other.unLockChapters_) && this.rewardChapters_.Equals(other.rewardChapters_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00053DB0 File Offset: 0x00051FB0
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

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00053E32 File Offset: 0x00052032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00053E3F File Offset: 0x0005203F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00053E48 File Offset: 0x00052048
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

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00053ED4 File Offset: 0x000520D4
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

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00053F64 File Offset: 0x00052164
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

		// Token: 0x06001ECA RID: 7882 RVA: 0x00053FE7 File Offset: 0x000521E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00053FF0 File Offset: 0x000521F0
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

		// Token: 0x040023BE RID: 9150
		private static readonly MessageParser<AdventureManualData> _parser = new MessageParser<AdventureManualData>(() => new AdventureManualData());

		// Token: 0x040023BF RID: 9151
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023C0 RID: 9152
		public const int AdventreTaskFieldNumber = 1;

		// Token: 0x040023C1 RID: 9153
		private static readonly FieldCodec<AdventreTask> _repeated_adventreTask_codec = FieldCodec.ForMessage<AdventreTask>(10U, Aki.Protocol.AdventreTask.Parser);

		// Token: 0x040023C2 RID: 9154
		private readonly RepeatedField<AdventreTask> adventreTask_ = new RepeatedField<AdventreTask>();

		// Token: 0x040023C3 RID: 9155
		public const int NowChapterFieldNumber = 2;

		// Token: 0x040023C4 RID: 9156
		private int nowChapter_;

		// Token: 0x040023C5 RID: 9157
		public const int ReceivedChapterFieldNumber = 3;

		// Token: 0x040023C6 RID: 9158
		private int receivedChapter_;

		// Token: 0x040023C7 RID: 9159
		public const int UnLockChaptersFieldNumber = 4;

		// Token: 0x040023C8 RID: 9160
		private static readonly FieldCodec<int> _repeated_unLockChapters_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040023C9 RID: 9161
		private readonly RepeatedField<int> unLockChapters_ = new RepeatedField<int>();

		// Token: 0x040023CA RID: 9162
		public const int RewardChaptersFieldNumber = 5;

		// Token: 0x040023CB RID: 9163
		private static readonly FieldCodec<int> _repeated_rewardChapters_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040023CC RID: 9164
		private readonly RepeatedField<int> rewardChapters_ = new RepeatedField<int>();
	}
}
