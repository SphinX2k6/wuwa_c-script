using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F73 RID: 3955
	[NetMessage(EMessageId.RoadBookTaskRewardRequest)]
	public sealed class RoadBookTaskRewardRequest : IMessage<RoadBookTaskRewardRequest>, IMessage, IEquatable<RoadBookTaskRewardRequest>, IDeepCloneable<RoadBookTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0601524C RID: 86604 RVA: 0x00310AF0 File Offset: 0x0030ECF0
		[NullableContext(1)]
		public static RoadBookTaskRewardRequest Create()
		{
			return new RoadBookTaskRewardRequest();
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x0601524D RID: 86605 RVA: 0x00310AF7 File Offset: 0x0030ECF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x0601524E RID: 86606 RVA: 0x00310AFA File Offset: 0x0030ECFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadBookTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601524F RID: 86607 RVA: 0x00310B01 File Offset: 0x0030ED01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardRequest()
		{
		}

		// Token: 0x06015250 RID: 86608 RVA: 0x00310B14 File Offset: 0x0030ED14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardRequest(RoadBookTaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015251 RID: 86609 RVA: 0x00310B3E File Offset: 0x0030ED3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadBookTaskRewardRequest Clone()
		{
			return new RoadBookTaskRewardRequest(this);
		}

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x06015252 RID: 86610 RVA: 0x00310B46 File Offset: 0x0030ED46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06015253 RID: 86611 RVA: 0x00310B4E File Offset: 0x0030ED4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadBookTaskRewardRequest);
		}

		// Token: 0x06015254 RID: 86612 RVA: 0x00310B5C File Offset: 0x0030ED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadBookTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015255 RID: 86613 RVA: 0x00310B90 File Offset: 0x0030ED90
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

		// Token: 0x06015256 RID: 86614 RVA: 0x00310BC4 File Offset: 0x0030EDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015257 RID: 86615 RVA: 0x00310BD1 File Offset: 0x0030EDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015258 RID: 86616 RVA: 0x00310BDA File Offset: 0x0030EDDA
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

		// Token: 0x06015259 RID: 86617 RVA: 0x00310C04 File Offset: 0x0030EE04
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

		// Token: 0x0601525A RID: 86618 RVA: 0x00310C3D File Offset: 0x0030EE3D
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

		// Token: 0x0601525B RID: 86619 RVA: 0x00310C6B File Offset: 0x0030EE6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601525C RID: 86620 RVA: 0x00310C74 File Offset: 0x0030EE74
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, RoadBookTaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x04007F2E RID: 32558
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F2F RID: 32559
		public const int TaskIdsFieldNumber = 5;

		// Token: 0x04007F30 RID: 32560
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04007F31 RID: 32561
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
