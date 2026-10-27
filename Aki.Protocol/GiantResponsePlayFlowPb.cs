using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E5 RID: 1765
	public sealed class GiantResponsePlayFlowPb : IMessage<GiantResponsePlayFlowPb>, IMessage, IEquatable<GiantResponsePlayFlowPb>, IDeepCloneable<GiantResponsePlayFlowPb>, IBufferMessage
	{
		// Token: 0x0600A108 RID: 41224 RVA: 0x00185CF8 File Offset: 0x00183EF8
		[NullableContext(1)]
		public static GiantResponsePlayFlowPb Create()
		{
			return new GiantResponsePlayFlowPb();
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x0600A109 RID: 41225 RVA: 0x00185CFF File Offset: 0x00183EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x0600A10A RID: 41226 RVA: 0x00185D02 File Offset: 0x00183F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponsePlayFlowPb.Descriptor;
			}
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x00185D09 File Offset: 0x00183F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayFlowPb()
		{
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x00185D1C File Offset: 0x00183F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayFlowPb(GiantResponsePlayFlowPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A10D RID: 41229 RVA: 0x00185D59 File Offset: 0x00183F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayFlowPb Clone()
		{
			return new GiantResponsePlayFlowPb(this);
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x00185D61 File Offset: 0x00183F61
		// (set) Token: 0x0600A10F RID: 41231 RVA: 0x00185D69 File Offset: 0x00183F69
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

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x0600A110 RID: 41232 RVA: 0x00185D7C File Offset: 0x00183F7C
		// (set) Token: 0x0600A111 RID: 41233 RVA: 0x00185D84 File Offset: 0x00183F84
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

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x0600A112 RID: 41234 RVA: 0x00185D8D File Offset: 0x00183F8D
		// (set) Token: 0x0600A113 RID: 41235 RVA: 0x00185D95 File Offset: 0x00183F95
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

		// Token: 0x0600A114 RID: 41236 RVA: 0x00185D9E File Offset: 0x00183F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponsePlayFlowPb);
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x00185DAC File Offset: 0x00183FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponsePlayFlowPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x00185E0C File Offset: 0x0018400C
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x00185E7F File Offset: 0x0018407F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x00185E8C File Offset: 0x0018408C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A119 RID: 41241 RVA: 0x00185E98 File Offset: 0x00184098
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
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A11A RID: 41242 RVA: 0x00185F14 File Offset: 0x00184114
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A11B RID: 41243 RVA: 0x00185F88 File Offset: 0x00184188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantResponsePlayFlowPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A11C RID: 41244 RVA: 0x00185FF1 File Offset: 0x001841F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A11D RID: 41245 RVA: 0x00185FFC File Offset: 0x001841FC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StateId = input.ReadInt32();
						}
					}
					else
					{
						this.FlowId = input.ReadInt32();
					}
				}
				else
				{
					this.FlowListName = input.ReadString();
				}
			}
		}

		// Token: 0x04004ADB RID: 19163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ADC RID: 19164
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x04004ADD RID: 19165
		private string flowListName_ = "";

		// Token: 0x04004ADE RID: 19166
		public const int FlowIdFieldNumber = 2;

		// Token: 0x04004ADF RID: 19167
		private int flowId_;

		// Token: 0x04004AE0 RID: 19168
		public const int StateIdFieldNumber = 3;

		// Token: 0x04004AE1 RID: 19169
		private int stateId_;
	}
}
