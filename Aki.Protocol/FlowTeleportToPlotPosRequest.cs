using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F3 RID: 1523
	[NetMessage(EMessageId.FlowTeleportToPlotPosRequest)]
	public sealed class FlowTeleportToPlotPosRequest : IMessage<FlowTeleportToPlotPosRequest>, IMessage, IEquatable<FlowTeleportToPlotPosRequest>, IDeepCloneable<FlowTeleportToPlotPosRequest>, IBufferMessage
	{
		// Token: 0x06008D67 RID: 36199 RVA: 0x001578A7 File Offset: 0x00155AA7
		[NullableContext(1)]
		public static FlowTeleportToPlotPosRequest Create()
		{
			return new FlowTeleportToPlotPosRequest();
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06008D68 RID: 36200 RVA: 0x001578AE File Offset: 0x00155AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06008D69 RID: 36201 RVA: 0x001578B1 File Offset: 0x00155AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowTeleportToPlotPosRequest.Descriptor;
			}
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x001578B8 File Offset: 0x00155AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosRequest()
		{
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x001578C0 File Offset: 0x00155AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosRequest(FlowTeleportToPlotPosRequest other) : this()
		{
			this.flowIncId_ = other.flowIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x001578E5 File Offset: 0x00155AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowTeleportToPlotPosRequest Clone()
		{
			return new FlowTeleportToPlotPosRequest(this);
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06008D6D RID: 36205 RVA: 0x001578ED File Offset: 0x00155AED
		// (set) Token: 0x06008D6E RID: 36206 RVA: 0x001578F5 File Offset: 0x00155AF5
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

		// Token: 0x06008D6F RID: 36207 RVA: 0x001578FE File Offset: 0x00155AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowTeleportToPlotPosRequest);
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x0015790C File Offset: 0x00155B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowTeleportToPlotPosRequest other)
		{
			return other != null && (other == this || (this.FlowIncId == other.FlowIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D71 RID: 36209 RVA: 0x0015793C File Offset: 0x00155B3C
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

		// Token: 0x06008D72 RID: 36210 RVA: 0x0015797B File Offset: 0x00155B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x00157988 File Offset: 0x00155B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x00157991 File Offset: 0x00155B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowIncId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.FlowIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x001579C4 File Offset: 0x00155BC4
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

		// Token: 0x06008D76 RID: 36214 RVA: 0x00157A02 File Offset: 0x00155C02
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

		// Token: 0x06008D77 RID: 36215 RVA: 0x00157A33 File Offset: 0x00155C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x00157A3C File Offset: 0x00155C3C
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004575 RID: 17781
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004576 RID: 17782
		public const int FlowIncIdFieldNumber = 8;

		// Token: 0x04004577 RID: 17783
		private long flowIncId_;
	}
}
