using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000609 RID: 1545
	[NetMessage(EMessageId.FlowTeleportToPlotPosResponse)]
	public sealed class FlowTeleportToPlotPosResponse : IMessage<FlowTeleportToPlotPosResponse>, IMessage, IEquatable<FlowTeleportToPlotPosResponse>, IDeepCloneable<FlowTeleportToPlotPosResponse>, IBufferMessage
	{
		// Token: 0x06008EE1 RID: 36577 RVA: 0x0015A685 File Offset: 0x00158885
		[NullableContext(1)]
		public static FlowTeleportToPlotPosResponse Create()
		{
			return new FlowTeleportToPlotPosResponse();
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06008EE2 RID: 36578 RVA: 0x0015A68C File Offset: 0x0015888C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x0015A68F File Offset: 0x0015888F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowTeleportToPlotPosResponse.Descriptor;
			}
		}

		// Token: 0x06008EE4 RID: 36580 RVA: 0x0015A696 File Offset: 0x00158896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosResponse()
		{
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x0015A69E File Offset: 0x0015889E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosResponse(FlowTeleportToPlotPosResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x0015A6C3 File Offset: 0x001588C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosResponse Clone()
		{
			return new FlowTeleportToPlotPosResponse(this);
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x0015A6CB File Offset: 0x001588CB
		// (set) Token: 0x06008EE8 RID: 36584 RVA: 0x0015A6D3 File Offset: 0x001588D3
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

		// Token: 0x06008EE9 RID: 36585 RVA: 0x0015A6DC File Offset: 0x001588DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowTeleportToPlotPosResponse);
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x0015A6EA File Offset: 0x001588EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowTeleportToPlotPosResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x0015A718 File Offset: 0x00158918
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

		// Token: 0x06008EEC RID: 36588 RVA: 0x0015A75D File Offset: 0x0015895D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x0015A76A File Offset: 0x0015896A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x0015A773 File Offset: 0x00158973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x0015A7A8 File Offset: 0x001589A8
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

		// Token: 0x06008EF0 RID: 36592 RVA: 0x0015A7E6 File Offset: 0x001589E6
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

		// Token: 0x06008EF1 RID: 36593 RVA: 0x0015A817 File Offset: 0x00158A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x0015A820 File Offset: 0x00158A20
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004582 RID: 17794
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004583 RID: 17795
		public const int CodeFieldNumber = 4;

		// Token: 0x04004584 RID: 17796
		private ErrorCode code_;
	}
}
