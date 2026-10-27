using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F71 RID: 3953
	[NetMessage(EMessageId.RoadBookMotorRewardRequest)]
	public sealed class RoadBookMotorRewardRequest : IMessage<RoadBookMotorRewardRequest>, IMessage, IEquatable<RoadBookMotorRewardRequest>, IDeepCloneable<RoadBookMotorRewardRequest>, IBufferMessage
	{
		// Token: 0x06015226 RID: 86566 RVA: 0x0031065B File Offset: 0x0030E85B
		[NullableContext(1)]
		public static RoadBookMotorRewardRequest Create()
		{
			return new RoadBookMotorRewardRequest();
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x06015227 RID: 86567 RVA: 0x00310662 File Offset: 0x0030E862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x06015228 RID: 86568 RVA: 0x00310665 File Offset: 0x0030E865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookMotorRewardRequest.Descriptor;
			}
		}

		// Token: 0x06015229 RID: 86569 RVA: 0x0031066C File Offset: 0x0030E86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardRequest()
		{
		}

		// Token: 0x0601522A RID: 86570 RVA: 0x0031067F File Offset: 0x0030E87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardRequest(RoadBookMotorRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601522B RID: 86571 RVA: 0x003106A9 File Offset: 0x0030E8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookMotorRewardRequest Clone()
		{
			return new RoadBookMotorRewardRequest(this);
		}

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x0601522C RID: 86572 RVA: 0x003106B1 File Offset: 0x0030E8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0601522D RID: 86573 RVA: 0x003106B9 File Offset: 0x0030E8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookMotorRewardRequest);
		}

		// Token: 0x0601522E RID: 86574 RVA: 0x003106C7 File Offset: 0x0030E8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookMotorRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601522F RID: 86575 RVA: 0x003106FC File Offset: 0x0030E8FC
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

		// Token: 0x06015230 RID: 86576 RVA: 0x00310730 File Offset: 0x0030E930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015231 RID: 86577 RVA: 0x0031073D File Offset: 0x0030E93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015232 RID: 86578 RVA: 0x00310746 File Offset: 0x0030E946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, RoadBookMotorRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015233 RID: 86579 RVA: 0x00310770 File Offset: 0x0030E970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(RoadBookMotorRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015234 RID: 86580 RVA: 0x003107A9 File Offset: 0x0030E9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadBookMotorRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015235 RID: 86581 RVA: 0x003107D7 File Offset: 0x0030E9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015236 RID: 86582 RVA: 0x003107E0 File Offset: 0x0030E9E0
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, RoadBookMotorRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007F24 RID: 32548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F25 RID: 32549
		public const int TaskIdsFieldNumber = 13;

		// Token: 0x04007F26 RID: 32550
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04007F27 RID: 32551
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
