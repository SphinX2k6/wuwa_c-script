using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000329 RID: 809
	[NetMessage(EMessageId.DailyAdventureTaskUpdateNotify)]
	public sealed class DailyAdventureTaskUpdateNotify : IMessage<DailyAdventureTaskUpdateNotify>, IMessage, IEquatable<DailyAdventureTaskUpdateNotify>, IDeepCloneable<DailyAdventureTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005183 RID: 20867 RVA: 0x000C6C51 File Offset: 0x000C4E51
		[NullableContext(1)]
		public static DailyAdventureTaskUpdateNotify Create()
		{
			return new DailyAdventureTaskUpdateNotify();
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x000C6C58 File Offset: 0x000C4E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06005185 RID: 20869 RVA: 0x000C6C5B File Offset: 0x000C4E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventureTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x000C6C62 File Offset: 0x000C4E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskUpdateNotify()
		{
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x000C6C75 File Offset: 0x000C4E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskUpdateNotify(DailyAdventureTaskUpdateNotify other) : this()
		{
			this.dailyAdventureActivityTasks_ = other.dailyAdventureActivityTasks_.Clone();
			this.resetDaily_ = other.resetDaily_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x000C6CAB File Offset: 0x000C4EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventureTaskUpdateNotify Clone()
		{
			return new DailyAdventureTaskUpdateNotify(this);
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06005189 RID: 20873 RVA: 0x000C6CB3 File Offset: 0x000C4EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyAdventureActivityTask> DailyAdventureActivityTasks
		{
			get
			{
				return this.dailyAdventureActivityTasks_;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x000C6CBB File Offset: 0x000C4EBB
		// (set) Token: 0x0600518B RID: 20875 RVA: 0x000C6CC3 File Offset: 0x000C4EC3
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

		// Token: 0x0600518C RID: 20876 RVA: 0x000C6CCC File Offset: 0x000C4ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventureTaskUpdateNotify);
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x000C6CDC File Offset: 0x000C4EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventureTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.dailyAdventureActivityTasks_.Equals(other.dailyAdventureActivityTasks_) && this.ResetDaily == other.ResetDaily && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x000C6D2C File Offset: 0x000C4F2C
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

		// Token: 0x0600518F RID: 20879 RVA: 0x000C6D79 File Offset: 0x000C4F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x000C6D86 File Offset: 0x000C4F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x000C6D90 File Offset: 0x000C4F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dailyAdventureActivityTasks_.WriteTo(ref output, DailyAdventureTaskUpdateNotify._repeated_dailyAdventureActivityTasks_codec);
			if (this.ResetDaily)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.ResetDaily);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x000C6DE0 File Offset: 0x000C4FE0
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

		// Token: 0x06005193 RID: 20883 RVA: 0x000C6E28 File Offset: 0x000C5028
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

		// Token: 0x06005194 RID: 20884 RVA: 0x000C6E75 File Offset: 0x000C5075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x000C6E80 File Offset: 0x000C5080
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
				if (num != 42U)
				{
					if (num != 56U)
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

		// Token: 0x04003308 RID: 13064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003309 RID: 13065
		public const int DailyAdventureActivityTasksFieldNumber = 5;

		// Token: 0x0400330A RID: 13066
		private static readonly FieldCodec<DailyAdventureActivityTask> _repeated_dailyAdventureActivityTasks_codec = FieldCodec.ForMessage<DailyAdventureActivityTask>(42U, DailyAdventureActivityTask.Parser);

		// Token: 0x0400330B RID: 13067
		private readonly RepeatedField<DailyAdventureActivityTask> dailyAdventureActivityTasks_ = new RepeatedField<DailyAdventureActivityTask>();

		// Token: 0x0400330C RID: 13068
		public const int ResetDailyFieldNumber = 7;

		// Token: 0x0400330D RID: 13069
		private bool resetDaily_;
	}
}
