using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B0 RID: 5040
	[NetMessage(EMessageId.TeleportFlowNotify)]
	public sealed class TeleportFlowNotify : IMessage<TeleportFlowNotify>, IMessage, IEquatable<TeleportFlowNotify>, IDeepCloneable<TeleportFlowNotify>, IBufferMessage
	{
		// Token: 0x0601AD1A RID: 109850 RVA: 0x003E792D File Offset: 0x003E5B2D
		[NullableContext(1)]
		public static TeleportFlowNotify Create()
		{
			return new TeleportFlowNotify();
		}

		// Token: 0x17005ACA RID: 23242
		// (get) Token: 0x0601AD1B RID: 109851 RVA: 0x003E7934 File Offset: 0x003E5B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ACB RID: 23243
		// (get) Token: 0x0601AD1C RID: 109852 RVA: 0x003E7937 File Offset: 0x003E5B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFlowNotify.Descriptor;
			}
		}

		// Token: 0x0601AD1D RID: 109853 RVA: 0x003E793E File Offset: 0x003E5B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowNotify()
		{
		}

		// Token: 0x0601AD1E RID: 109854 RVA: 0x003E7951 File Offset: 0x003E5B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowNotify(TeleportFlowNotify other) : this()
		{
			this.flowName_ = other.flowName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD1F RID: 109855 RVA: 0x003E7976 File Offset: 0x003E5B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowNotify Clone()
		{
			return new TeleportFlowNotify(this);
		}

		// Token: 0x17005ACC RID: 23244
		// (get) Token: 0x0601AD20 RID: 109856 RVA: 0x003E797E File Offset: 0x003E5B7E
		// (set) Token: 0x0601AD21 RID: 109857 RVA: 0x003E7986 File Offset: 0x003E5B86
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

		// Token: 0x0601AD22 RID: 109858 RVA: 0x003E7999 File Offset: 0x003E5B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFlowNotify);
		}

		// Token: 0x0601AD23 RID: 109859 RVA: 0x003E79A7 File Offset: 0x003E5BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFlowNotify other)
		{
			return other != null && (other == this || (!(this.FlowName != other.FlowName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD24 RID: 109860 RVA: 0x003E79DC File Offset: 0x003E5BDC
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

		// Token: 0x0601AD25 RID: 109861 RVA: 0x003E7A1D File Offset: 0x003E5C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD26 RID: 109862 RVA: 0x003E7A2A File Offset: 0x003E5C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD27 RID: 109863 RVA: 0x003E7A33 File Offset: 0x003E5C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.FlowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD28 RID: 109864 RVA: 0x003E7A6C File Offset: 0x003E5C6C
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

		// Token: 0x0601AD29 RID: 109865 RVA: 0x003E7AAF File Offset: 0x003E5CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFlowNotify other)
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

		// Token: 0x0601AD2A RID: 109866 RVA: 0x003E7AE5 File Offset: 0x003E5CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD2B RID: 109867 RVA: 0x003E7AF0 File Offset: 0x003E5CF0
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowName = input.ReadString();
				}
			}
		}

		// Token: 0x04009CDC RID: 40156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CDD RID: 40157
		public const int FlowNameFieldNumber = 3;

		// Token: 0x04009CDE RID: 40158
		private string flowName_ = "";
	}
}
