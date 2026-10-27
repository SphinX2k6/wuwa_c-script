using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000062 RID: 98
	[NetMessage(EMessageId.AchievementListProgressNotify)]
	public sealed class AchievementListProgressNotify : IMessage<AchievementListProgressNotify>, IMessage, IEquatable<AchievementListProgressNotify>, IDeepCloneable<AchievementListProgressNotify>, IBufferMessage
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x0003A916 File Offset: 0x00038B16
		[NullableContext(1)]
		public static AchievementListProgressNotify Create()
		{
			return new AchievementListProgressNotify();
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x0003A91D File Offset: 0x00038B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x0003A920 File Offset: 0x00038B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementListProgressNotify.Descriptor;
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0003A927 File Offset: 0x00038B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementListProgressNotify()
		{
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0003A93A File Offset: 0x00038B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementListProgressNotify(AchievementListProgressNotify other) : this()
		{
			this.achievementEntryList_ = other.achievementEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0003A964 File Offset: 0x00038B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementListProgressNotify Clone()
		{
			return new AchievementListProgressNotify(this);
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x0003A96C File Offset: 0x00038B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AchievementEntry> AchievementEntryList
		{
			get
			{
				return this.achievementEntryList_;
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0003A974 File Offset: 0x00038B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementListProgressNotify);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0003A982 File Offset: 0x00038B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementListProgressNotify other)
		{
			return other != null && (other == this || (this.achievementEntryList_.Equals(other.achievementEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0003A9B8 File Offset: 0x00038BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.achievementEntryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0003A9EC File Offset: 0x00038BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0003A9F9 File Offset: 0x00038BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0003AA02 File Offset: 0x00038C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.achievementEntryList_.WriteTo(ref output, AchievementListProgressNotify._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0003AA2C File Offset: 0x00038C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.achievementEntryList_.CalculateSize(AchievementListProgressNotify._repeated_achievementEntryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0003AA65 File Offset: 0x00038C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementListProgressNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.achievementEntryList_.Add(other.achievementEntryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0003AA93 File Offset: 0x00038C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0003AA9C File Offset: 0x00038C9C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.achievementEntryList_.AddEntriesFrom(ref input, AchievementListProgressNotify._repeated_achievementEntryList_codec);
				}
			}
		}

		// Token: 0x040020D5 RID: 8405
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020D6 RID: 8406
		public const int AchievementEntryListFieldNumber = 10;

		// Token: 0x040020D7 RID: 8407
		private static readonly FieldCodec<AchievementEntry> _repeated_achievementEntryList_codec = FieldCodec.ForMessage<AchievementEntry>(82U, AchievementEntry.Parser);

		// Token: 0x040020D8 RID: 8408
		private readonly RepeatedField<AchievementEntry> achievementEntryList_ = new RepeatedField<AchievementEntry>();
	}
}
