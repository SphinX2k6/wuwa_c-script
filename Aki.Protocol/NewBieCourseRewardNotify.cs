using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF7 RID: 2807
	[NetMessage(EMessageId.NewBieCourseRewardNotify)]
	public sealed class NewBieCourseRewardNotify : IMessage<NewBieCourseRewardNotify>, IMessage, IEquatable<NewBieCourseRewardNotify>, IDeepCloneable<NewBieCourseRewardNotify>, IBufferMessage
	{
		// Token: 0x0600F448 RID: 62536 RVA: 0x0023AC98 File Offset: 0x00238E98
		[NullableContext(1)]
		public static NewBieCourseRewardNotify Create()
		{
			return new NewBieCourseRewardNotify();
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600F449 RID: 62537 RVA: 0x0023AC9F File Offset: 0x00238E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031BE RID: 12734
		// (get) Token: 0x0600F44A RID: 62538 RVA: 0x0023ACA2 File Offset: 0x00238EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600F44B RID: 62539 RVA: 0x0023ACA9 File Offset: 0x00238EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardNotify()
		{
		}

		// Token: 0x0600F44C RID: 62540 RVA: 0x0023ACBC File Offset: 0x00238EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardNotify(NewBieCourseRewardNotify other) : this()
		{
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F44D RID: 62541 RVA: 0x0023ACE6 File Offset: 0x00238EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseRewardNotify Clone()
		{
			return new NewBieCourseRewardNotify(this);
		}

		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600F44E RID: 62542 RVA: 0x0023ACEE File Offset: 0x00238EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x0600F44F RID: 62543 RVA: 0x0023ACF6 File Offset: 0x00238EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseRewardNotify);
		}

		// Token: 0x0600F450 RID: 62544 RVA: 0x0023AD04 File Offset: 0x00238F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseRewardNotify other)
		{
			return other != null && (other == this || (this.hadTakeReward_.Equals(other.hadTakeReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F451 RID: 62545 RVA: 0x0023AD38 File Offset: 0x00238F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hadTakeReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F452 RID: 62546 RVA: 0x0023AD6C File Offset: 0x00238F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F453 RID: 62547 RVA: 0x0023AD79 File Offset: 0x00238F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F454 RID: 62548 RVA: 0x0023AD82 File Offset: 0x00238F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hadTakeReward_.WriteTo(ref output, NewBieCourseRewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F455 RID: 62549 RVA: 0x0023ADAC File Offset: 0x00238FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hadTakeReward_.CalculateSize(NewBieCourseRewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F456 RID: 62550 RVA: 0x0023ADE5 File Offset: 0x00238FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewBieCourseRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.hadTakeReward_.Add(other.hadTakeReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F457 RID: 62551 RVA: 0x0023AE13 File Offset: 0x00239013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F458 RID: 62552 RVA: 0x0023AE1C File Offset: 0x0023901C
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hadTakeReward_.AddEntriesFrom(ref input, NewBieCourseRewardNotify._repeated_hadTakeReward_codec);
				}
			}
		}

		// Token: 0x040062B9 RID: 25273
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062BA RID: 25274
		public const int HadTakeRewardFieldNumber = 4;

		// Token: 0x040062BB RID: 25275
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040062BC RID: 25276
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();
	}
}
