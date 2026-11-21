using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF6 RID: 2806
	public sealed class NewBieCourseActivity : IMessage<NewBieCourseActivity>, IMessage, IEquatable<NewBieCourseActivity>, IDeepCloneable<NewBieCourseActivity>, IBufferMessage
	{
		// Token: 0x0600F436 RID: 62518 RVA: 0x0023AAB6 File Offset: 0x00238CB6
		[NullableContext(1)]
		public static NewBieCourseActivity Create()
		{
			return new NewBieCourseActivity();
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600F437 RID: 62519 RVA: 0x0023AABD File Offset: 0x00238CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600F438 RID: 62520 RVA: 0x0023AAC0 File Offset: 0x00238CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseActivity.Descriptor;
			}
		}

		// Token: 0x0600F439 RID: 62521 RVA: 0x0023AAC7 File Offset: 0x00238CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseActivity()
		{
		}

		// Token: 0x0600F43A RID: 62522 RVA: 0x0023AADA File Offset: 0x00238CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseActivity(NewBieCourseActivity other) : this()
		{
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F43B RID: 62523 RVA: 0x0023AB04 File Offset: 0x00238D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseActivity Clone()
		{
			return new NewBieCourseActivity(this);
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600F43C RID: 62524 RVA: 0x0023AB0C File Offset: 0x00238D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x0600F43D RID: 62525 RVA: 0x0023AB14 File Offset: 0x00238D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseActivity);
		}

		// Token: 0x0600F43E RID: 62526 RVA: 0x0023AB22 File Offset: 0x00238D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseActivity other)
		{
			return other != null && (other == this || (this.hadTakeReward_.Equals(other.hadTakeReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F43F RID: 62527 RVA: 0x0023AB58 File Offset: 0x00238D58
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

		// Token: 0x0600F440 RID: 62528 RVA: 0x0023AB8C File Offset: 0x00238D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F441 RID: 62529 RVA: 0x0023AB99 File Offset: 0x00238D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F442 RID: 62530 RVA: 0x0023ABA2 File Offset: 0x00238DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hadTakeReward_.WriteTo(ref output, NewBieCourseActivity._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F443 RID: 62531 RVA: 0x0023ABCC File Offset: 0x00238DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hadTakeReward_.CalculateSize(NewBieCourseActivity._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F444 RID: 62532 RVA: 0x0023AC05 File Offset: 0x00238E05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewBieCourseActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.hadTakeReward_.Add(other.hadTakeReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F445 RID: 62533 RVA: 0x0023AC33 File Offset: 0x00238E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F446 RID: 62534 RVA: 0x0023AC3C File Offset: 0x00238E3C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.hadTakeReward_.AddEntriesFrom(ref input, NewBieCourseActivity._repeated_hadTakeReward_codec);
				}
			}
		}

		// Token: 0x040062B5 RID: 25269
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062B6 RID: 25270
		public const int HadTakeRewardFieldNumber = 1;

		// Token: 0x040062B7 RID: 25271
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040062B8 RID: 25272
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();
	}
}
