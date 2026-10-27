using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031C RID: 796
	public sealed class DailyAdventureActivityData : IMessage<DailyAdventureActivityData>, IMessage, IEquatable<DailyAdventureActivityData>, IDeepCloneable<DailyAdventureActivityData>, IBufferMessage
	{
		// Token: 0x06005035 RID: 20533 RVA: 0x000C3A3D File Offset: 0x000C1C3D
		[NullableContext(1)]
		public static DailyAdventureActivityData Create()
		{
			return new DailyAdventureActivityData();
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x000C3A44 File Offset: 0x000C1C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06005037 RID: 20535 RVA: 0x000C3A47 File Offset: 0x000C1C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureActivityData.Descriptor;
			}
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x000C3A4E File Offset: 0x000C1C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityData()
		{
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x000C3A6C File Offset: 0x000C1C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityData(DailyAdventureActivityData other) : this()
		{
			this.dailyAdventureActivityTasks_ = other.dailyAdventureActivityTasks_.Clone();
			this.ptRewardTaken_ = other.ptRewardTaken_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x000C3AA7 File Offset: 0x000C1CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureActivityData Clone()
		{
			return new DailyAdventureActivityData(this);
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x0600503B RID: 20539 RVA: 0x000C3AAF File Offset: 0x000C1CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyAdventureActivityTask> DailyAdventureActivityTasks
		{
			get
			{
				return this.dailyAdventureActivityTasks_;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x000C3AB7 File Offset: 0x000C1CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PtRewardTaken
		{
			get
			{
				return this.ptRewardTaken_;
			}
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x000C3ABF File Offset: 0x000C1CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureActivityData);
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x000C3AD0 File Offset: 0x000C1CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureActivityData other)
		{
			return other != null && (other == this || (this.dailyAdventureActivityTasks_.Equals(other.dailyAdventureActivityTasks_) && this.ptRewardTaken_.Equals(other.ptRewardTaken_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x000C3B24 File Offset: 0x000C1D24
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

		// Token: 0x06005040 RID: 20544 RVA: 0x000C3B66 File Offset: 0x000C1D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x000C3B73 File Offset: 0x000C1D73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x000C3B7C File Offset: 0x000C1D7C
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

		// Token: 0x06005043 RID: 20547 RVA: 0x000C3BB4 File Offset: 0x000C1DB4
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

		// Token: 0x06005044 RID: 20548 RVA: 0x000C3C00 File Offset: 0x000C1E00
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

		// Token: 0x06005045 RID: 20549 RVA: 0x000C3C3F File Offset: 0x000C1E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x000C3C48 File Offset: 0x000C1E48
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

		// Token: 0x04003254 RID: 12884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003255 RID: 12885
		public const int DailyAdventureActivityTasksFieldNumber = 1;

		// Token: 0x04003256 RID: 12886
		private static readonly FieldCodec<DailyAdventureActivityTask> _repeated_dailyAdventureActivityTasks_codec = FieldCodec.ForMessage<DailyAdventureActivityTask>(10U, DailyAdventureActivityTask.Parser);

		// Token: 0x04003257 RID: 12887
		private readonly RepeatedField<DailyAdventureActivityTask> dailyAdventureActivityTasks_ = new RepeatedField<DailyAdventureActivityTask>();

		// Token: 0x04003258 RID: 12888
		public const int PtRewardTakenFieldNumber = 2;

		// Token: 0x04003259 RID: 12889
		private static readonly FieldCodec<int> _repeated_ptRewardTaken_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400325A RID: 12890
		private readonly RepeatedField<int> ptRewardTaken_ = new RepeatedField<int>();
	}
}
