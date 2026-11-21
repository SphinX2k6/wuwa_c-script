using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000323 RID: 803
	public sealed class DailyAdventureActivityData : IMessage<DailyAdventureActivityData>, IMessage, IEquatable<DailyAdventureActivityData>, IDeepCloneable<DailyAdventureActivityData>, IBufferMessage
	{
		// Token: 0x0600510E RID: 20750 RVA: 0x000C5E2D File Offset: 0x000C402D
		[NullableContext(1)]
		public static DailyAdventureActivityData Create()
		{
			return new DailyAdventureActivityData();
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x0600510F RID: 20751 RVA: 0x000C5E34 File Offset: 0x000C4034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x000C5E37 File Offset: 0x000C4037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureActivityData.Descriptor;
			}
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x000C5E3E File Offset: 0x000C403E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityData()
		{
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x000C5E5C File Offset: 0x000C405C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityData(DailyAdventureActivityData other) : this()
		{
			this.dailyAdventureActivityTasks_ = other.dailyAdventureActivityTasks_.Clone();
			this.ptRewardTaken_ = other.ptRewardTaken_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x000C5E97 File Offset: 0x000C4097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityData Clone()
		{
			return new DailyAdventureActivityData(this);
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x000C5E9F File Offset: 0x000C409F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyAdventureActivityTask> DailyAdventureActivityTasks
		{
			get
			{
				return this.dailyAdventureActivityTasks_;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06005115 RID: 20757 RVA: 0x000C5EA7 File Offset: 0x000C40A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PtRewardTaken
		{
			get
			{
				return this.ptRewardTaken_;
			}
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x000C5EAF File Offset: 0x000C40AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureActivityData);
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x000C5EC0 File Offset: 0x000C40C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureActivityData other)
		{
			return other != null && (other == this || (this.dailyAdventureActivityTasks_.Equals(other.dailyAdventureActivityTasks_) && this.ptRewardTaken_.Equals(other.ptRewardTaken_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x000C5F14 File Offset: 0x000C4114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dailyAdventureActivityTasks_.GetHashCode();
			num ^= this.ptRewardTaken_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x000C5F56 File Offset: 0x000C4156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x000C5F63 File Offset: 0x000C4163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x000C5F6C File Offset: 0x000C416C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dailyAdventureActivityTasks_.WriteTo(ref output, DailyAdventureActivityData._repeated_dailyAdventureActivityTasks_codec);
			this.ptRewardTaken_.WriteTo(ref output, DailyAdventureActivityData._repeated_ptRewardTaken_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x000C5FA4 File Offset: 0x000C41A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dailyAdventureActivityTasks_.CalculateSize(DailyAdventureActivityData._repeated_dailyAdventureActivityTasks_codec);
			num += this.ptRewardTaken_.CalculateSize(DailyAdventureActivityData._repeated_ptRewardTaken_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x000C5FF0 File Offset: 0x000C41F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventureActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.dailyAdventureActivityTasks_.Add(other.dailyAdventureActivityTasks_);
			this.ptRewardTaken_.Add(other.ptRewardTaken_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x000C602F File Offset: 0x000C422F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x000C6038 File Offset: 0x000C4238
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ptRewardTaken_.AddEntriesFrom(ref input, DailyAdventureActivityData._repeated_ptRewardTaken_codec);
					}
				}
				else
				{
					this.dailyAdventureActivityTasks_.AddEntriesFrom(ref input, DailyAdventureActivityData._repeated_dailyAdventureActivityTasks_codec);
				}
			}
		}

		// Token: 0x040032EB RID: 13035
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032EC RID: 13036
		public const int DailyAdventureActivityTasksFieldNumber = 1;

		// Token: 0x040032ED RID: 13037
		private static readonly FieldCodec<DailyAdventureActivityTask> _repeated_dailyAdventureActivityTasks_codec = FieldCodec.ForMessage<DailyAdventureActivityTask>(10U, DailyAdventureActivityTask.Parser);

		// Token: 0x040032EE RID: 13038
		private readonly RepeatedField<DailyAdventureActivityTask> dailyAdventureActivityTasks_ = new RepeatedField<DailyAdventureActivityTask>();

		// Token: 0x040032EF RID: 13039
		public const int PtRewardTakenFieldNumber = 2;

		// Token: 0x040032F0 RID: 13040
		private static readonly FieldCodec<int> _repeated_ptRewardTaken_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040032F1 RID: 13041
		private readonly RepeatedField<int> ptRewardTaken_ = new RepeatedField<int>();
	}
}
