using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AE RID: 5038
	[NetMessage(EMessageId.TeleportFlowEndRequest)]
	public sealed class TeleportFlowEndRequest : IMessage<TeleportFlowEndRequest>, IMessage, IEquatable<TeleportFlowEndRequest>, IDeepCloneable<TeleportFlowEndRequest>, IBufferMessage
	{
		// Token: 0x0601ACF6 RID: 109814 RVA: 0x003E7545 File Offset: 0x003E5745
		[NullableContext(1)]
		public static TeleportFlowEndRequest Create()
		{
			return new TeleportFlowEndRequest();
		}

		// Token: 0x17005AC4 RID: 23236
		// (get) Token: 0x0601ACF7 RID: 109815 RVA: 0x003E754C File Offset: 0x003E574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC5 RID: 23237
		// (get) Token: 0x0601ACF8 RID: 109816 RVA: 0x003E754F File Offset: 0x003E574F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFlowEndRequest.Descriptor;
			}
		}

		// Token: 0x0601ACF9 RID: 109817 RVA: 0x003E7556 File Offset: 0x003E5756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndRequest()
		{
		}

		// Token: 0x0601ACFA RID: 109818 RVA: 0x003E7569 File Offset: 0x003E5769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndRequest(TeleportFlowEndRequest other) : this()
		{
			this.flowName_ = other.flowName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACFB RID: 109819 RVA: 0x003E758E File Offset: 0x003E578E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndRequest Clone()
		{
			return new TeleportFlowEndRequest(this);
		}

		// Token: 0x17005AC6 RID: 23238
		// (get) Token: 0x0601ACFC RID: 109820 RVA: 0x003E7596 File Offset: 0x003E5796
		// (set) Token: 0x0601ACFD RID: 109821 RVA: 0x003E759E File Offset: 0x003E579E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowName
		{
			get
			{
				return this.flowName_;
			}
			set
			{
				this.flowName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601ACFE RID: 109822 RVA: 0x003E75B1 File Offset: 0x003E57B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFlowEndRequest);
		}

		// Token: 0x0601ACFF RID: 109823 RVA: 0x003E75BF File Offset: 0x003E57BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFlowEndRequest other)
		{
			return other != null && (other == this || (!(this.FlowName != other.FlowName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD00 RID: 109824 RVA: 0x003E75F4 File Offset: 0x003E57F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowName.Length != 0)
			{
				num ^= this.FlowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AD01 RID: 109825 RVA: 0x003E7635 File Offset: 0x003E5835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD02 RID: 109826 RVA: 0x003E7642 File Offset: 0x003E5842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD03 RID: 109827 RVA: 0x003E764B File Offset: 0x003E584B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowName.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.FlowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD04 RID: 109828 RVA: 0x003E7684 File Offset: 0x003E5884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AD05 RID: 109829 RVA: 0x003E76C7 File Offset: 0x003E58C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFlowEndRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowName.Length != 0)
			{
				this.FlowName = other.FlowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AD06 RID: 109830 RVA: 0x003E76FD File Offset: 0x003E58FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD07 RID: 109831 RVA: 0x003E7708 File Offset: 0x003E5908
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowName = input.ReadString();
				}
			}
		}

		// Token: 0x04009CD6 RID: 40150
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CD7 RID: 40151
		public const int FlowNameFieldNumber = 12;

		// Token: 0x04009CD8 RID: 40152
		private string flowName_ = "";
	}
}
