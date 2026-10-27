using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FC RID: 5116
	public sealed class TransitionPlayFlowActionParamPb : IMessage<TransitionPlayFlowActionParamPb>, IMessage, IEquatable<TransitionPlayFlowActionParamPb>, IDeepCloneable<TransitionPlayFlowActionParamPb>, IBufferMessage
	{
		// Token: 0x0601B1E9 RID: 111081 RVA: 0x003EDFB0 File Offset: 0x003EC1B0
		[NullableContext(1)]
		public static TransitionPlayFlowActionParamPb Create()
		{
			return new TransitionPlayFlowActionParamPb();
		}

		// Token: 0x17005B71 RID: 23409
		// (get) Token: 0x0601B1EA RID: 111082 RVA: 0x003EDFB7 File Offset: 0x003EC1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B72 RID: 23410
		// (get) Token: 0x0601B1EB RID: 111083 RVA: 0x003EDFBA File Offset: 0x003EC1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionPlayFlowActionParamPb.Descriptor;
			}
		}

		// Token: 0x0601B1EC RID: 111084 RVA: 0x003EDFC1 File Offset: 0x003EC1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowActionParamPb()
		{
		}

		// Token: 0x0601B1ED RID: 111085 RVA: 0x003EDFE0 File Offset: 0x003EC1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowActionParamPb(TransitionPlayFlowActionParamPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this.flowGuid_ = other.flowGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B1EE RID: 111086 RVA: 0x003EE034 File Offset: 0x003EC234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowActionParamPb Clone()
		{
			return new TransitionPlayFlowActionParamPb(this);
		}

		// Token: 0x17005B73 RID: 23411
		// (get) Token: 0x0601B1EF RID: 111087 RVA: 0x003EE03C File Offset: 0x003EC23C
		// (set) Token: 0x0601B1F0 RID: 111088 RVA: 0x003EE044 File Offset: 0x003EC244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowListName
		{
			get
			{
				return this.flowListName_;
			}
			set
			{
				this.flowListName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005B74 RID: 23412
		// (get) Token: 0x0601B1F1 RID: 111089 RVA: 0x003EE057 File Offset: 0x003EC257
		// (set) Token: 0x0601B1F2 RID: 111090 RVA: 0x003EE05F File Offset: 0x003EC25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlowId
		{
			get
			{
				return this.flowId_;
			}
			set
			{
				this.flowId_ = value;
			}
		}

		// Token: 0x17005B75 RID: 23413
		// (get) Token: 0x0601B1F3 RID: 111091 RVA: 0x003EE068 File Offset: 0x003EC268
		// (set) Token: 0x0601B1F4 RID: 111092 RVA: 0x003EE070 File Offset: 0x003EC270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateId
		{
			get
			{
				return this.stateId_;
			}
			set
			{
				this.stateId_ = value;
			}
		}

		// Token: 0x17005B76 RID: 23414
		// (get) Token: 0x0601B1F5 RID: 111093 RVA: 0x003EE079 File Offset: 0x003EC279
		// (set) Token: 0x0601B1F6 RID: 111094 RVA: 0x003EE081 File Offset: 0x003EC281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowGuid
		{
			get
			{
				return this.flowGuid_;
			}
			set
			{
				this.flowGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601B1F7 RID: 111095 RVA: 0x003EE094 File Offset: 0x003EC294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionPlayFlowActionParamPb);
		}

		// Token: 0x0601B1F8 RID: 111096 RVA: 0x003EE0A4 File Offset: 0x003EC2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionPlayFlowActionParamPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && !(this.FlowGuid != other.FlowGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B1F9 RID: 111097 RVA: 0x003EE118 File Offset: 0x003EC318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowListName.Length != 0)
			{
				num ^= this.FlowListName.GetHashCode();
			}
			if (this.FlowId != 0)
			{
				num ^= this.FlowId.GetHashCode();
			}
			if (this.StateId != 0)
			{
				num ^= this.StateId.GetHashCode();
			}
			if (this.FlowGuid.Length != 0)
			{
				num ^= this.FlowGuid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B1FA RID: 111098 RVA: 0x003EE1A6 File Offset: 0x003EC3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B1FB RID: 111099 RVA: 0x003EE1B3 File Offset: 0x003EC3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B1FC RID: 111100 RVA: 0x003EE1BC File Offset: 0x003EC3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FlowId);
			}
			if (this.StateId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StateId);
			}
			if (this.FlowGuid.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.FlowGuid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B1FD RID: 111101 RVA: 0x003EE258 File Offset: 0x003EC458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowListName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlowId);
			}
			if (this.StateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateId);
			}
			if (this.FlowGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowGuid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B1FE RID: 111102 RVA: 0x003EE2E8 File Offset: 0x003EC4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionPlayFlowActionParamPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowListName.Length != 0)
			{
				this.FlowListName = other.FlowListName;
			}
			if (other.FlowId != 0)
			{
				this.FlowId = other.FlowId;
			}
			if (other.StateId != 0)
			{
				this.StateId = other.StateId;
			}
			if (other.FlowGuid.Length != 0)
			{
				this.FlowGuid = other.FlowGuid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B1FF RID: 111103 RVA: 0x003EE36A File Offset: 0x003EC56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B200 RID: 111104 RVA: 0x003EE374 File Offset: 0x003EC574
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.FlowListName = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.FlowId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.StateId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.FlowGuid = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009CEB RID: 40171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CEC RID: 40172
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x04009CED RID: 40173
		private string flowListName_ = "";

		// Token: 0x04009CEE RID: 40174
		public const int FlowIdFieldNumber = 2;

		// Token: 0x04009CEF RID: 40175
		private int flowId_;

		// Token: 0x04009CF0 RID: 40176
		public const int StateIdFieldNumber = 3;

		// Token: 0x04009CF1 RID: 40177
		private int stateId_;

		// Token: 0x04009CF2 RID: 40178
		public const int FlowGuidFieldNumber = 4;

		// Token: 0x04009CF3 RID: 40179
		private string flowGuid_ = "";
	}
}
