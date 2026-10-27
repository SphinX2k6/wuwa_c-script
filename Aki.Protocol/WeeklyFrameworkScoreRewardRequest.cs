using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150E RID: 5390
	[NetMessage(EMessageId.WeeklyFrameworkScoreRewardRequest)]
	public sealed class WeeklyFrameworkScoreRewardRequest : IMessage<WeeklyFrameworkScoreRewardRequest>, IMessage, IEquatable<WeeklyFrameworkScoreRewardRequest>, IDeepCloneable<WeeklyFrameworkScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0601C7C9 RID: 116681 RVA: 0x0041D410 File Offset: 0x0041B610
		[NullableContext(1)]
		public static WeeklyFrameworkScoreRewardRequest Create()
		{
			return new WeeklyFrameworkScoreRewardRequest();
		}

		// Token: 0x17006007 RID: 24583
		// (get) Token: 0x0601C7CA RID: 116682 RVA: 0x0041D417 File Offset: 0x0041B617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006008 RID: 24584
		// (get) Token: 0x0601C7CB RID: 116683 RVA: 0x0041D41A File Offset: 0x0041B61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601C7CC RID: 116684 RVA: 0x0041D421 File Offset: 0x0041B621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardRequest()
		{
		}

		// Token: 0x0601C7CD RID: 116685 RVA: 0x0041D434 File Offset: 0x0041B634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardRequest(WeeklyFrameworkScoreRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7CE RID: 116686 RVA: 0x0041D45E File Offset: 0x0041B65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardRequest Clone()
		{
			return new WeeklyFrameworkScoreRewardRequest(this);
		}

		// Token: 0x17006009 RID: 24585
		// (get) Token: 0x0601C7CF RID: 116687 RVA: 0x0041D466 File Offset: 0x0041B666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0601C7D0 RID: 116688 RVA: 0x0041D46E File Offset: 0x0041B66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkScoreRewardRequest);
		}

		// Token: 0x0601C7D1 RID: 116689 RVA: 0x0041D47C File Offset: 0x0041B67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkScoreRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7D2 RID: 116690 RVA: 0x0041D4B0 File Offset: 0x0041B6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7D3 RID: 116691 RVA: 0x0041D4E4 File Offset: 0x0041B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7D4 RID: 116692 RVA: 0x0041D4F1 File Offset: 0x0041B6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7D5 RID: 116693 RVA: 0x0041D4FA File Offset: 0x0041B6FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, WeeklyFrameworkScoreRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7D6 RID: 116694 RVA: 0x0041D524 File Offset: 0x0041B724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(WeeklyFrameworkScoreRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7D7 RID: 116695 RVA: 0x0041D55D File Offset: 0x0041B75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7D8 RID: 116696 RVA: 0x0041D58B File Offset: 0x0041B78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7D9 RID: 116697 RVA: 0x0041D594 File Offset: 0x0041B794
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, WeeklyFrameworkScoreRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x0400A308 RID: 41736
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A309 RID: 41737
		public const int TaskIdsFieldNumber = 11;

		// Token: 0x0400A30A RID: 41738
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x0400A30B RID: 41739
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
