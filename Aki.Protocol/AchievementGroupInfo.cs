using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005F RID: 95
	public sealed class AchievementGroupInfo : IMessage<AchievementGroupInfo>, IMessage, IEquatable<AchievementGroupInfo>, IDeepCloneable<AchievementGroupInfo>, IBufferMessage
	{
		// Token: 0x06001633 RID: 5683 RVA: 0x0003A8EE File Offset: 0x00038AEE
		[NullableContext(1)]
		public static AchievementGroupInfo Create()
		{
			return new AchievementGroupInfo();
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x0003A8F5 File Offset: 0x00038AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AchievementGroupInfo> Parser
		{
			get
			{
				return AchievementGroupInfo._parser;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x0003A8FC File Offset: 0x00038AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x0003A8FF File Offset: 0x00038AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementGroupInfo.Descriptor;
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0003A906 File Offset: 0x00038B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupInfo()
		{
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0003A91C File Offset: 0x00038B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupInfo(AchievementGroupInfo other) : this()
		{
			this.achievementGroupEntry_ = ((other.achievementGroupEntry_ != null) ? other.achievementGroupEntry_.Clone() : null);
			this.achievementEntryList_ = other.achievementEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0003A96D File Offset: 0x00038B6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupInfo Clone()
		{
			return new AchievementGroupInfo(this);
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x0003A975 File Offset: 0x00038B75
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x0003A97D File Offset: 0x00038B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementGroupEntry AchievementGroupEntry
		{
			get
			{
				return this.achievementGroupEntry_;
			}
			set
			{
				this.achievementGroupEntry_ = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x0003A986 File Offset: 0x00038B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementEntry> AchievementEntryList
		{
			get
			{
				return this.achievementEntryList_;
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0003A98E File Offset: 0x00038B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementGroupInfo);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0003A99C File Offset: 0x00038B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementGroupInfo other)
		{
			return other != null && (other == this || (object.Equals(this.AchievementGroupEntry, other.AchievementGroupEntry) && this.achievementEntryList_.Equals(other.achievementEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.achievementGroupEntry_ != null)
			{
				num ^= this.AchievementGroupEntry.GetHashCode();
			}
			num ^= this.achievementEntryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0003AA3A File Offset: 0x00038C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0003AA47 File Offset: 0x00038C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0003AA50 File Offset: 0x00038C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.achievementGroupEntry_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AchievementGroupEntry);
			}
			this.achievementEntryList_.WriteTo(ref output, AchievementGroupInfo._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0003AAA0 File Offset: 0x00038CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.achievementGroupEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AchievementGroupEntry);
			}
			num += this.achievementEntryList_.CalculateSize(AchievementGroupInfo._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.achievementGroupEntry_ != null)
			{
				if (this.achievementGroupEntry_ == null)
				{
					this.AchievementGroupEntry = new AchievementGroupEntry();
				}
				this.AchievementGroupEntry.MergeFrom(other.AchievementGroupEntry);
			}
			this.achievementEntryList_.Add(other.achievementEntryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0003AB59 File Offset: 0x00038D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0003AB64 File Offset: 0x00038D64
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.achievementEntryList_.AddEntriesFrom(ref input, AchievementGroupInfo._repeated_achievementEntryList_codec);
					}
				}
				else
				{
					if (this.achievementGroupEntry_ == null)
					{
						this.AchievementGroupEntry = new AchievementGroupEntry();
					}
					input.ReadMessage(this.AchievementGroupEntry);
				}
			}
		}

		// Token: 0x04002121 RID: 8481
		private static readonly MessageParser<AchievementGroupInfo> _parser = new MessageParser<AchievementGroupInfo>(() => new AchievementGroupInfo());

		// Token: 0x04002122 RID: 8482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002123 RID: 8483
		public const int AchievementGroupEntryFieldNumber = 1;

		// Token: 0x04002124 RID: 8484
		private AchievementGroupEntry achievementGroupEntry_;

		// Token: 0x04002125 RID: 8485
		public const int AchievementEntryListFieldNumber = 2;

		// Token: 0x04002126 RID: 8486
		private static readonly FieldCodec<AchievementEntry> _repeated_achievementEntryList_codec = FieldCodec.ForMessage<AchievementEntry>(18U, AchievementEntry.Parser);

		// Token: 0x04002127 RID: 8487
		private readonly RepeatedField<AchievementEntry> achievementEntryList_ = new RepeatedField<AchievementEntry>();
	}
}
