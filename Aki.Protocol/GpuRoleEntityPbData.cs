using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F8 RID: 1784
	public sealed class GpuRoleEntityPbData : IMessage<GpuRoleEntityPbData>, IMessage, IEquatable<GpuRoleEntityPbData>, IDeepCloneable<GpuRoleEntityPbData>, IBufferMessage
	{
		// Token: 0x0600A2D0 RID: 41680 RVA: 0x00189D18 File Offset: 0x00187F18
		[NullableContext(1)]
		public static GpuRoleEntityPbData Create()
		{
			return new GpuRoleEntityPbData();
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600A2D1 RID: 41681 RVA: 0x00189D1F File Offset: 0x00187F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x0600A2D2 RID: 41682 RVA: 0x00189D22 File Offset: 0x00187F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuRoleEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x00189D29 File Offset: 0x00187F29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuRoleEntityPbData()
		{
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x00189D31 File Offset: 0x00187F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuRoleEntityPbData(GpuRoleEntityPbData other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x00189D56 File Offset: 0x00187F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuRoleEntityPbData Clone()
		{
			return new GpuRoleEntityPbData(this);
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x0600A2D6 RID: 41686 RVA: 0x00189D5E File Offset: 0x00187F5E
		// (set) Token: 0x0600A2D7 RID: 41687 RVA: 0x00189D66 File Offset: 0x00187F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x00189D6F File Offset: 0x00187F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuRoleEntityPbData);
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x00189D7D File Offset: 0x00187F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuRoleEntityPbData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x00189DAC File Offset: 0x00187FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x00189DEB File Offset: 0x00187FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x00189DF8 File Offset: 0x00187FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x00189E01 File Offset: 0x00188001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x00189E34 File Offset: 0x00188034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x00189E72 File Offset: 0x00188072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GpuRoleEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x00189EA3 File Offset: 0x001880A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x00189EAC File Offset: 0x001880AC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004BB7 RID: 19383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BB8 RID: 19384
		public const int IncIdFieldNumber = 1;

		// Token: 0x04004BB9 RID: 19385
		private long incId_;
	}
}
