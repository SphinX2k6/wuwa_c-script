using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000936 RID: 2358
	[NetMessage(EMessageId.LivenessTaskTakeRequest)]
	public sealed class LivenessTaskTakeRequest : IMessage<LivenessTaskTakeRequest>, IMessage, IEquatable<LivenessTaskTakeRequest>, IDeepCloneable<LivenessTaskTakeRequest>, IBufferMessage
	{
		// Token: 0x0600CFDC RID: 53212 RVA: 0x001E9A08 File Offset: 0x001E7C08
		[NullableContext(1)]
		public static LivenessTaskTakeRequest Create()
		{
			return new LivenessTaskTakeRequest();
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x0600CFDD RID: 53213 RVA: 0x001E9A0F File Offset: 0x001E7C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0600CFDE RID: 53214 RVA: 0x001E9A12 File Offset: 0x001E7C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTaskTakeRequest.Descriptor;
			}
		}

		// Token: 0x0600CFDF RID: 53215 RVA: 0x001E9A19 File Offset: 0x001E7C19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeRequest()
		{
		}

		// Token: 0x0600CFE0 RID: 53216 RVA: 0x001E9A2C File Offset: 0x001E7C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeRequest(LivenessTaskTakeRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFE1 RID: 53217 RVA: 0x001E9A56 File Offset: 0x001E7C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTaskTakeRequest Clone()
		{
			return new LivenessTaskTakeRequest(this);
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600CFE2 RID: 53218 RVA: 0x001E9A5E File Offset: 0x001E7C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600CFE3 RID: 53219 RVA: 0x001E9A66 File Offset: 0x001E7C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTaskTakeRequest);
		}

		// Token: 0x0600CFE4 RID: 53220 RVA: 0x001E9A74 File Offset: 0x001E7C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTaskTakeRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CFE5 RID: 53221 RVA: 0x001E9AA8 File Offset: 0x001E7CA8
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

		// Token: 0x0600CFE6 RID: 53222 RVA: 0x001E9ADC File Offset: 0x001E7CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CFE7 RID: 53223 RVA: 0x001E9AE9 File Offset: 0x001E7CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CFE8 RID: 53224 RVA: 0x001E9AF2 File Offset: 0x001E7CF2
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

		// Token: 0x0600CFE9 RID: 53225 RVA: 0x001E9B1C File Offset: 0x001E7D1C
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

		// Token: 0x0600CFEA RID: 53226 RVA: 0x001E9B55 File Offset: 0x001E7D55
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

		// Token: 0x0600CFEB RID: 53227 RVA: 0x001E9B83 File Offset: 0x001E7D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CFEC RID: 53228 RVA: 0x001E9B8C File Offset: 0x001E7D8C
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, LivenessTaskTakeRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040057A7 RID: 22439
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057A8 RID: 22440
		public const int TaskIdsFieldNumber = 12;

		// Token: 0x040057A9 RID: 22441
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x040057AA RID: 22442
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
