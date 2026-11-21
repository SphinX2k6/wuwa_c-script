using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F4 RID: 1524
	[NetMessage(EMessageId.FlowTeleportToPlotPosResponse)]
	public sealed class FlowTeleportToPlotPosResponse : IMessage<FlowTeleportToPlotPosResponse>, IMessage, IEquatable<FlowTeleportToPlotPosResponse>, IDeepCloneable<FlowTeleportToPlotPosResponse>, IBufferMessage
	{
		// Token: 0x06008D79 RID: 36217 RVA: 0x00157A81 File Offset: 0x00155C81
		[NullableContext(1)]
		public static FlowTeleportToPlotPosResponse Create()
		{
			return new FlowTeleportToPlotPosResponse();
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06008D7A RID: 36218 RVA: 0x00157A88 File Offset: 0x00155C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06008D7B RID: 36219 RVA: 0x00157A8B File Offset: 0x00155C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowTeleportToPlotPosResponse.Descriptor;
			}
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x00157A92 File Offset: 0x00155C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosResponse()
		{
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x00157A9A File Offset: 0x00155C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosResponse(FlowTeleportToPlotPosResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x00157ABF File Offset: 0x00155CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosResponse Clone()
		{
			return new FlowTeleportToPlotPosResponse(this);
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06008D7F RID: 36223 RVA: 0x00157AC7 File Offset: 0x00155CC7
		// (set) Token: 0x06008D80 RID: 36224 RVA: 0x00157ACF File Offset: 0x00155CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x00157AD8 File Offset: 0x00155CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowTeleportToPlotPosResponse);
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x00157AE6 File Offset: 0x00155CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowTeleportToPlotPosResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x00157B14 File Offset: 0x00155D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x00157B59 File Offset: 0x00155D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x00157B66 File Offset: 0x00155D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x00157B6F File Offset: 0x00155D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D87 RID: 36231 RVA: 0x00157BA4 File Offset: 0x00155DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x00157BE2 File Offset: 0x00155DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowTeleportToPlotPosResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x00157C13 File Offset: 0x00155E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D8A RID: 36234 RVA: 0x00157C1C File Offset: 0x00155E1C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004578 RID: 17784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004579 RID: 17785
		public const int CodeFieldNumber = 14;

		// Token: 0x0400457A RID: 17786
		private ErrorCode code_;
	}
}
