using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000608 RID: 1544
	[NetMessage(EMessageId.FlowTeleportToPlotPosRequest)]
	public sealed class FlowTeleportToPlotPosRequest : IMessage<FlowTeleportToPlotPosRequest>, IMessage, IEquatable<FlowTeleportToPlotPosRequest>, IDeepCloneable<FlowTeleportToPlotPosRequest>, IBufferMessage
	{
		// Token: 0x06008ECF RID: 36559 RVA: 0x0015A4AB File Offset: 0x001586AB
		[NullableContext(1)]
		public static FlowTeleportToPlotPosRequest Create()
		{
			return new FlowTeleportToPlotPosRequest();
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06008ED0 RID: 36560 RVA: 0x0015A4B2 File Offset: 0x001586B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06008ED1 RID: 36561 RVA: 0x0015A4B5 File Offset: 0x001586B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowTeleportToPlotPosRequest.Descriptor;
			}
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x0015A4BC File Offset: 0x001586BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosRequest()
		{
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x0015A4C4 File Offset: 0x001586C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosRequest(FlowTeleportToPlotPosRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x0015A4E9 File Offset: 0x001586E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosRequest Clone()
		{
			return new FlowTeleportToPlotPosRequest(this);
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06008ED5 RID: 36565 RVA: 0x0015A4F1 File Offset: 0x001586F1
		// (set) Token: 0x06008ED6 RID: 36566 RVA: 0x0015A4F9 File Offset: 0x001586F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long FlowIncId
		{
			get
			{
				return this.flowIncId_;
			}
			set
			{
				this.flowIncId_ = value;
			}
		}

		// Token: 0x06008ED7 RID: 36567 RVA: 0x0015A502 File Offset: 0x00158702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowTeleportToPlotPosRequest);
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x0015A510 File Offset: 0x00158710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowTeleportToPlotPosRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0015A540 File Offset: 0x00158740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowIncId != 0L)
			{
				num ^= this.FlowIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x0015A57F File Offset: 0x0015877F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x0015A58C File Offset: 0x0015878C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x0015A595 File Offset: 0x00158795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.FlowIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x0015A5C8 File Offset: 0x001587C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.FlowIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x0015A606 File Offset: 0x00158806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowTeleportToPlotPosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowIncId != 0L)
			{
				this.FlowIncId = other.FlowIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008EDF RID: 36575 RVA: 0x0015A637 File Offset: 0x00158837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EE0 RID: 36576 RVA: 0x0015A640 File Offset: 0x00158840
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400457F RID: 17791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004580 RID: 17792
		public const int FlowIncIdFieldNumber = 2;

		// Token: 0x04004581 RID: 17793
		private long flowIncId_;
	}
}
