using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B07 RID: 2823
	public sealed class NewBieCourseActivity : IMessage<NewBieCourseActivity>, IMessage, IEquatable<NewBieCourseActivity>, IDeepCloneable<NewBieCourseActivity>, IBufferMessage
	{
		// Token: 0x0600F550 RID: 62800 RVA: 0x0023CCC2 File Offset: 0x0023AEC2
		[NullableContext(1)]
		public static NewBieCourseActivity Create()
		{
			return new NewBieCourseActivity();
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600F551 RID: 62801 RVA: 0x0023CCC9 File Offset: 0x0023AEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600F552 RID: 62802 RVA: 0x0023CCCC File Offset: 0x0023AECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewBieCourseActivity.Descriptor;
			}
		}

		// Token: 0x0600F553 RID: 62803 RVA: 0x0023CCD3 File Offset: 0x0023AED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseActivity()
		{
		}

		// Token: 0x0600F554 RID: 62804 RVA: 0x0023CCE6 File Offset: 0x0023AEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseActivity(NewBieCourseActivity other) : this()
		{
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F555 RID: 62805 RVA: 0x0023CD10 File Offset: 0x0023AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewBieCourseActivity Clone()
		{
			return new NewBieCourseActivity(this);
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600F556 RID: 62806 RVA: 0x0023CD18 File Offset: 0x0023AF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x0600F557 RID: 62807 RVA: 0x0023CD20 File Offset: 0x0023AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewBieCourseActivity);
		}

		// Token: 0x0600F558 RID: 62808 RVA: 0x0023CD2E File Offset: 0x0023AF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewBieCourseActivity other)
		{
			return other != null && (other == this || (this.hadTakeReward_.Equals(other.hadTakeReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F559 RID: 62809 RVA: 0x0023CD64 File Offset: 0x0023AF64
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

		// Token: 0x0600F55A RID: 62810 RVA: 0x0023CD98 File Offset: 0x0023AF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F55B RID: 62811 RVA: 0x0023CDA5 File Offset: 0x0023AFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F55C RID: 62812 RVA: 0x0023CDAE File Offset: 0x0023AFAE
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

		// Token: 0x0600F55D RID: 62813 RVA: 0x0023CDD8 File Offset: 0x0023AFD8
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

		// Token: 0x0600F55E RID: 62814 RVA: 0x0023CE11 File Offset: 0x0023B011
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

		// Token: 0x0600F55F RID: 62815 RVA: 0x0023CE3F File Offset: 0x0023B03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F560 RID: 62816 RVA: 0x0023CE48 File Offset: 0x0023B048
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

		// Token: 0x040062AC RID: 25260
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062AD RID: 25261
		public const int HadTakeRewardFieldNumber = 1;

		// Token: 0x040062AE RID: 25262
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040062AF RID: 25263
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();
	}
}
