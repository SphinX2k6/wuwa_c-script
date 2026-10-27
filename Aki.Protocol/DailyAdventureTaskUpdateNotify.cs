using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000322 RID: 802
	[NetMessage(EMessageId.DailyAdventureTaskUpdateNotify)]
	public sealed class DailyAdventureTaskUpdateNotify : IMessage<DailyAdventureTaskUpdateNotify>, IMessage, IEquatable<DailyAdventureTaskUpdateNotify>, IDeepCloneable<DailyAdventureTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x060050AA RID: 20650 RVA: 0x000C4861 File Offset: 0x000C2A61
		[NullableContext(1)]
		public static DailyAdventureTaskUpdateNotify Create()
		{
			return new DailyAdventureTaskUpdateNotify();
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x000C4868 File Offset: 0x000C2A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x000C486B File Offset: 0x000C2A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060050AD RID: 20653 RVA: 0x000C4872 File Offset: 0x000C2A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskUpdateNotify()
		{
		}

		// Token: 0x060050AE RID: 20654 RVA: 0x000C4885 File Offset: 0x000C2A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskUpdateNotify(DailyAdventureTaskUpdateNotify other) : this()
		{
			this.dailyAdventureActivityTasks_ = other.dailyAdventureActivityTasks_.Clone();
			this.resetDaily_ = other.resetDaily_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060050AF RID: 20655 RVA: 0x000C48BB File Offset: 0x000C2ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskUpdateNotify Clone()
		{
			return new DailyAdventureTaskUpdateNotify(this);
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x000C48C3 File Offset: 0x000C2AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyAdventureActivityTask> DailyAdventureActivityTasks
		{
			get
			{
				return this.dailyAdventureActivityTasks_;
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x000C48CB File Offset: 0x000C2ACB
		// (set) Token: 0x060050B2 RID: 20658 RVA: 0x000C48D3 File Offset: 0x000C2AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ResetDaily
		{
			get
			{
				return this.resetDaily_;
			}
			set
			{
				this.resetDaily_ = value;
			}
		}

		// Token: 0x060050B3 RID: 20659 RVA: 0x000C48DC File Offset: 0x000C2ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureTaskUpdateNotify);
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x000C48EC File Offset: 0x000C2AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.dailyAdventureActivityTasks_.Equals(other.dailyAdventureActivityTasks_) && this.ResetDaily == other.ResetDaily && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060050B5 RID: 20661 RVA: 0x000C493C File Offset: 0x000C2B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dailyAdventureActivityTasks_.GetHashCode();
			if (this.ResetDaily)
			{
				num ^= this.ResetDaily.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x000C4989 File Offset: 0x000C2B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060050B7 RID: 20663 RVA: 0x000C4996 File Offset: 0x000C2B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050B8 RID: 20664 RVA: 0x000C49A0 File Offset: 0x000C2BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dailyAdventureActivityTasks_.WriteTo(ref output, DailyAdventureTaskUpdateNotify._repeated_dailyAdventureActivityTasks_codec);
			if (this.ResetDaily)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ResetDaily);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050B9 RID: 20665 RVA: 0x000C49F0 File Offset: 0x000C2BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dailyAdventureActivityTasks_.CalculateSize(DailyAdventureTaskUpdateNotify._repeated_dailyAdventureActivityTasks_codec);
			if (this.ResetDaily)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060050BA RID: 20666 RVA: 0x000C4A38 File Offset: 0x000C2C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventureTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dailyAdventureActivityTasks_.Add(other.dailyAdventureActivityTasks_);
			if (other.ResetDaily)
			{
				this.ResetDaily = other.ResetDaily;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050BB RID: 20667 RVA: 0x000C4A85 File Offset: 0x000C2C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050BC RID: 20668 RVA: 0x000C4A90 File Offset: 0x000C2C90
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
				if (num != 26U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ResetDaily = input.ReadBool();
					}
				}
				else
				{
					this.dailyAdventureActivityTasks_.AddEntriesFrom(ref input, DailyAdventureTaskUpdateNotify._repeated_dailyAdventureActivityTasks_codec);
				}
			}
		}

		// Token: 0x04003271 RID: 12913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003272 RID: 12914
		public const int DailyAdventureActivityTasksFieldNumber = 3;

		// Token: 0x04003273 RID: 12915
		private static readonly FieldCodec<DailyAdventureActivityTask> _repeated_dailyAdventureActivityTasks_codec = FieldCodec.ForMessage<DailyAdventureActivityTask>(26U, DailyAdventureActivityTask.Parser);

		// Token: 0x04003274 RID: 12916
		private readonly RepeatedField<DailyAdventureActivityTask> dailyAdventureActivityTasks_ = new RepeatedField<DailyAdventureActivityTask>();

		// Token: 0x04003275 RID: 12917
		public const int ResetDailyFieldNumber = 4;

		// Token: 0x04003276 RID: 12918
		private bool resetDaily_;
	}
}
