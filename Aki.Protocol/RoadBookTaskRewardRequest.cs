using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F63 RID: 3939
	[NetMessage(EMessageId.RoadBookTaskRewardRequest)]
	public sealed class RoadBookTaskRewardRequest : IMessage<RoadBookTaskRewardRequest>, IMessage, IEquatable<RoadBookTaskRewardRequest>, IDeepCloneable<RoadBookTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06015167 RID: 86375 RVA: 0x0030F440 File Offset: 0x0030D640
		[NullableContext(1)]
		public static RoadBookTaskRewardRequest Create()
		{
			return new RoadBookTaskRewardRequest();
		}

		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x06015168 RID: 86376 RVA: 0x0030F447 File Offset: 0x0030D647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x06015169 RID: 86377 RVA: 0x0030F44A File Offset: 0x0030D64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601516A RID: 86378 RVA: 0x0030F451 File Offset: 0x0030D651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardRequest()
		{
		}

		// Token: 0x0601516B RID: 86379 RVA: 0x0030F464 File Offset: 0x0030D664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardRequest(RoadBookTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601516C RID: 86380 RVA: 0x0030F48E File Offset: 0x0030D68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardRequest Clone()
		{
			return new RoadBookTaskRewardRequest(this);
		}

		// Token: 0x1700462D RID: 17965
		// (get) Token: 0x0601516D RID: 86381 RVA: 0x0030F496 File Offset: 0x0030D696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0601516E RID: 86382 RVA: 0x0030F49E File Offset: 0x0030D69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookTaskRewardRequest);
		}

		// Token: 0x0601516F RID: 86383 RVA: 0x0030F4AC File Offset: 0x0030D6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015170 RID: 86384 RVA: 0x0030F4E0 File Offset: 0x0030D6E0
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

		// Token: 0x06015171 RID: 86385 RVA: 0x0030F514 File Offset: 0x0030D714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015172 RID: 86386 RVA: 0x0030F521 File Offset: 0x0030D721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015173 RID: 86387 RVA: 0x0030F52A File Offset: 0x0030D72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RoadBookTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015174 RID: 86388 RVA: 0x0030F554 File Offset: 0x0030D754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(RoadBookTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015175 RID: 86389 RVA: 0x0030F58D File Offset: 0x0030D78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015176 RID: 86390 RVA: 0x0030F5BB File Offset: 0x0030D7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015177 RID: 86391 RVA: 0x0030F5C4 File Offset: 0x0030D7C4
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, RoadBookTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007F58 RID: 32600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F59 RID: 32601
		public const int TaskIdsFieldNumber = 14;

		// Token: 0x04007F5A RID: 32602
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04007F5B RID: 32603
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
