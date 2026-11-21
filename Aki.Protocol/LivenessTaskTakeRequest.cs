using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000925 RID: 2341
	[NetMessage(EMessageId.LivenessTaskTakeRequest)]
	public sealed class LivenessTaskTakeRequest : IMessage<LivenessTaskTakeRequest>, IMessage, IEquatable<LivenessTaskTakeRequest>, IDeepCloneable<LivenessTaskTakeRequest>, IBufferMessage
	{
		// Token: 0x0600CEC0 RID: 52928 RVA: 0x001E7734 File Offset: 0x001E5934
		[NullableContext(1)]
		public static LivenessTaskTakeRequest Create()
		{
			return new LivenessTaskTakeRequest();
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x0600CEC1 RID: 52929 RVA: 0x001E773B File Offset: 0x001E593B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x0600CEC2 RID: 52930 RVA: 0x001E773E File Offset: 0x001E593E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTaskTakeRequest.Descriptor;
			}
		}

		// Token: 0x0600CEC3 RID: 52931 RVA: 0x001E7745 File Offset: 0x001E5945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeRequest()
		{
		}

		// Token: 0x0600CEC4 RID: 52932 RVA: 0x001E7758 File Offset: 0x001E5958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeRequest(LivenessTaskTakeRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEC5 RID: 52933 RVA: 0x001E7782 File Offset: 0x001E5982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeRequest Clone()
		{
			return new LivenessTaskTakeRequest(this);
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x0600CEC6 RID: 52934 RVA: 0x001E778A File Offset: 0x001E598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600CEC7 RID: 52935 RVA: 0x001E7792 File Offset: 0x001E5992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTaskTakeRequest);
		}

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x001E77A0 File Offset: 0x001E59A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTaskTakeRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x001E77D4 File Offset: 0x001E59D4
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

		// Token: 0x0600CECA RID: 52938 RVA: 0x001E7808 File Offset: 0x001E5A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x001E7815 File Offset: 0x001E5A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CECC RID: 52940 RVA: 0x001E781E File Offset: 0x001E5A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, LivenessTaskTakeRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CECD RID: 52941 RVA: 0x001E7848 File Offset: 0x001E5A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(LivenessTaskTakeRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CECE RID: 52942 RVA: 0x001E7881 File Offset: 0x001E5A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTaskTakeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CECF RID: 52943 RVA: 0x001E78AF File Offset: 0x001E5AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CED0 RID: 52944 RVA: 0x001E78B8 File Offset: 0x001E5AB8
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, LivenessTaskTakeRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040057AE RID: 22446
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057AF RID: 22447
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x040057B0 RID: 22448
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040057B1 RID: 22449
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
