using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000589 RID: 1417
	[NetMessage(EMessageId.FlagChallengeTaskInfoUpdateNotify)]
	public sealed class FlagChallengeTaskInfoUpdateNotify : IMessage<FlagChallengeTaskInfoUpdateNotify>, IMessage, IEquatable<FlagChallengeTaskInfoUpdateNotify>, IDeepCloneable<FlagChallengeTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060083AB RID: 33707 RVA: 0x0013D51B File Offset: 0x0013B71B
		[NullableContext(1)]
		public static FlagChallengeTaskInfoUpdateNotify Create()
		{
			return new FlagChallengeTaskInfoUpdateNotify();
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x060083AC RID: 33708 RVA: 0x0013D522 File Offset: 0x0013B722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x060083AD RID: 33709 RVA: 0x0013D525 File Offset: 0x0013B725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x0013D52C File Offset: 0x0013B72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTaskInfoUpdateNotify()
		{
		}

		// Token: 0x060083AF RID: 33711 RVA: 0x0013D53F File Offset: 0x0013B73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTaskInfoUpdateNotify(FlagChallengeTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x0013D569 File Offset: 0x0013B769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeTaskInfoUpdateNotify Clone()
		{
			return new FlagChallengeTaskInfoUpdateNotify(this);
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x060083B1 RID: 33713 RVA: 0x0013D571 File Offset: 0x0013B771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x0013D579 File Offset: 0x0013B779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeTaskInfoUpdateNotify);
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0013D587 File Offset: 0x0013B787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x0013D5BC File Offset: 0x0013B7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x0013D5F0 File Offset: 0x0013B7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x0013D5FD File Offset: 0x0013B7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x0013D606 File Offset: 0x0013B806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, FlagChallengeTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x0013D630 File Offset: 0x0013B830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(FlagChallengeTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x0013D669 File Offset: 0x0013B869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x0013D697 File Offset: 0x0013B897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x0013D6A0 File Offset: 0x0013B8A0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, FlagChallengeTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x040041DB RID: 16859
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041DC RID: 16860
		public const int ConditionTasksFieldNumber = 15;

		// Token: 0x040041DD RID: 16861
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(122U, ConditionTask.Parser);

		// Token: 0x040041DE RID: 16862
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
