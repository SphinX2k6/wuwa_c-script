using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F1B RID: 3867
	[NetMessage(EMessageId.ReorderFormationRequest)]
	public sealed class ReorderFormationRequest : IMessage<ReorderFormationRequest>, IMessage, IEquatable<ReorderFormationRequest>, IDeepCloneable<ReorderFormationRequest>, IBufferMessage
	{
		// Token: 0x06014B28 RID: 84776 RVA: 0x00300D99 File Offset: 0x002FEF99
		[NullableContext(1)]
		public static ReorderFormationRequest Create()
		{
			return new ReorderFormationRequest();
		}

		// Token: 0x170044C9 RID: 17609
		// (get) Token: 0x06014B29 RID: 84777 RVA: 0x00300DA0 File Offset: 0x002FEFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044CA RID: 17610
		// (get) Token: 0x06014B2A RID: 84778 RVA: 0x00300DA3 File Offset: 0x002FEFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReorderFormationRequest.Descriptor;
			}
		}

		// Token: 0x06014B2B RID: 84779 RVA: 0x00300DAA File Offset: 0x002FEFAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationRequest()
		{
		}

		// Token: 0x06014B2C RID: 84780 RVA: 0x00300DB2 File Offset: 0x002FEFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationRequest(ReorderFormationRequest other) : this()
		{
			this.formationId_ = other.formationId_;
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B2D RID: 84781 RVA: 0x00300DE3 File Offset: 0x002FEFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationRequest Clone()
		{
			return new ReorderFormationRequest(this);
		}

		// Token: 0x170044CB RID: 17611
		// (get) Token: 0x06014B2E RID: 84782 RVA: 0x00300DEB File Offset: 0x002FEFEB
		// (set) Token: 0x06014B2F RID: 84783 RVA: 0x00300DF3 File Offset: 0x002FEFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x170044CC RID: 17612
		// (get) Token: 0x06014B30 RID: 84784 RVA: 0x00300DFC File Offset: 0x002FEFFC
		// (set) Token: 0x06014B31 RID: 84785 RVA: 0x00300E04 File Offset: 0x002FF004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x06014B32 RID: 84786 RVA: 0x00300E0D File Offset: 0x002FF00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReorderFormationRequest);
		}

		// Token: 0x06014B33 RID: 84787 RVA: 0x00300E1B File Offset: 0x002FF01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReorderFormationRequest other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B34 RID: 84788 RVA: 0x00300E5C File Offset: 0x002FF05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B35 RID: 84789 RVA: 0x00300EB4 File Offset: 0x002FF0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B36 RID: 84790 RVA: 0x00300EC1 File Offset: 0x002FF0C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B37 RID: 84791 RVA: 0x00300ECC File Offset: 0x002FF0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormationId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.FormationId);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B38 RID: 84792 RVA: 0x00300F28 File Offset: 0x002FF128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B39 RID: 84793 RVA: 0x00300F80 File Offset: 0x002FF180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReorderFormationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B3A RID: 84794 RVA: 0x00300FD0 File Offset: 0x002FF1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B3B RID: 84795 RVA: 0x00300FDC File Offset: 0x002FF1DC
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
				if (num != 72U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetId = input.ReadInt32();
					}
				}
				else
				{
					this.FormationId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D12 RID: 32018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D13 RID: 32019
		public const int FormationIdFieldNumber = 9;

		// Token: 0x04007D14 RID: 32020
		private int formationId_;

		// Token: 0x04007D15 RID: 32021
		public const int TargetIdFieldNumber = 15;

		// Token: 0x04007D16 RID: 32022
		private int targetId_;
	}
}
