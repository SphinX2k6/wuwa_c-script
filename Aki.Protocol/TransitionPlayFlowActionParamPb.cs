using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146F RID: 5231
	public sealed class TransitionPlayFlowActionParamPb : IMessage<TransitionPlayFlowActionParamPb>, IMessage, IEquatable<TransitionPlayFlowActionParamPb>, IDeepCloneable<TransitionPlayFlowActionParamPb>, IBufferMessage
	{
		// Token: 0x0601BC74 RID: 113780 RVA: 0x00409284 File Offset: 0x00407484
		[NullableContext(1)]
		public static TransitionPlayFlowActionParamPb Create()
		{
			return new TransitionPlayFlowActionParamPb();
		}

		// Token: 0x17005E06 RID: 24070
		// (get) Token: 0x0601BC75 RID: 113781 RVA: 0x0040928B File Offset: 0x0040748B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E07 RID: 24071
		// (get) Token: 0x0601BC76 RID: 113782 RVA: 0x0040928E File Offset: 0x0040748E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionPlayFlowActionParamPb.Descriptor;
			}
		}

		// Token: 0x0601BC77 RID: 113783 RVA: 0x00409295 File Offset: 0x00407495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowActionParamPb()
		{
		}

		// Token: 0x0601BC78 RID: 113784 RVA: 0x004092B4 File Offset: 0x004074B4
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

		// Token: 0x0601BC79 RID: 113785 RVA: 0x00409308 File Offset: 0x00407508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionPlayFlowActionParamPb Clone()
		{
			return new TransitionPlayFlowActionParamPb(this);
		}

		// Token: 0x17005E08 RID: 24072
		// (get) Token: 0x0601BC7A RID: 113786 RVA: 0x00409310 File Offset: 0x00407510
		// (set) Token: 0x0601BC7B RID: 113787 RVA: 0x00409318 File Offset: 0x00407518
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

		// Token: 0x17005E09 RID: 24073
		// (get) Token: 0x0601BC7C RID: 113788 RVA: 0x0040932B File Offset: 0x0040752B
		// (set) Token: 0x0601BC7D RID: 113789 RVA: 0x00409333 File Offset: 0x00407533
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

		// Token: 0x17005E0A RID: 24074
		// (get) Token: 0x0601BC7E RID: 113790 RVA: 0x0040933C File Offset: 0x0040753C
		// (set) Token: 0x0601BC7F RID: 113791 RVA: 0x00409344 File Offset: 0x00407544
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

		// Token: 0x17005E0B RID: 24075
		// (get) Token: 0x0601BC80 RID: 113792 RVA: 0x0040934D File Offset: 0x0040754D
		// (set) Token: 0x0601BC81 RID: 113793 RVA: 0x00409355 File Offset: 0x00407555
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

		// Token: 0x0601BC82 RID: 113794 RVA: 0x00409368 File Offset: 0x00407568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionPlayFlowActionParamPb);
		}

		// Token: 0x0601BC83 RID: 113795 RVA: 0x00409378 File Offset: 0x00407578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionPlayFlowActionParamPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && !(this.FlowGuid != other.FlowGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC84 RID: 113796 RVA: 0x004093EC File Offset: 0x004075EC
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

		// Token: 0x0601BC85 RID: 113797 RVA: 0x0040947A File Offset: 0x0040767A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC86 RID: 113798 RVA: 0x00409487 File Offset: 0x00407687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC87 RID: 113799 RVA: 0x00409490 File Offset: 0x00407690
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

		// Token: 0x0601BC88 RID: 113800 RVA: 0x0040952C File Offset: 0x0040772C
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

		// Token: 0x0601BC89 RID: 113801 RVA: 0x004095BC File Offset: 0x004077BC
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

		// Token: 0x0601BC8A RID: 113802 RVA: 0x0040963E File Offset: 0x0040783E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC8B RID: 113803 RVA: 0x00409648 File Offset: 0x00407848
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

		// Token: 0x0400A132 RID: 41266
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A133 RID: 41267
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x0400A134 RID: 41268
		private string flowListName_ = "";

		// Token: 0x0400A135 RID: 41269
		public const int FlowIdFieldNumber = 2;

		// Token: 0x0400A136 RID: 41270
		private int flowId_;

		// Token: 0x0400A137 RID: 41271
		public const int StateIdFieldNumber = 3;

		// Token: 0x0400A138 RID: 41272
		private int stateId_;

		// Token: 0x0400A139 RID: 41273
		public const int FlowGuidFieldNumber = 4;

		// Token: 0x0400A13A RID: 41274
		private string flowGuid_ = "";
	}
}
