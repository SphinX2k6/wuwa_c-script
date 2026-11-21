using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F0B RID: 3851
	[NetMessage(EMessageId.ReorderFormationRequest)]
	public sealed class ReorderFormationRequest : IMessage<ReorderFormationRequest>, IMessage, IEquatable<ReorderFormationRequest>, IDeepCloneable<ReorderFormationRequest>, IBufferMessage
	{
		// Token: 0x06014A43 RID: 84547 RVA: 0x002FF6DD File Offset: 0x002FD8DD
		[NullableContext(1)]
		public static ReorderFormationRequest Create()
		{
			return new ReorderFormationRequest();
		}

		// Token: 0x1700449F RID: 17567
		// (get) Token: 0x06014A44 RID: 84548 RVA: 0x002FF6E4 File Offset: 0x002FD8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044A0 RID: 17568
		// (get) Token: 0x06014A45 RID: 84549 RVA: 0x002FF6E7 File Offset: 0x002FD8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReorderFormationRequest.Descriptor;
			}
		}

		// Token: 0x06014A46 RID: 84550 RVA: 0x002FF6EE File Offset: 0x002FD8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationRequest()
		{
		}

		// Token: 0x06014A47 RID: 84551 RVA: 0x002FF6F6 File Offset: 0x002FD8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationRequest(ReorderFormationRequest other) : this()
		{
			this.formationId_ = other.formationId_;
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014A48 RID: 84552 RVA: 0x002FF727 File Offset: 0x002FD927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReorderFormationRequest Clone()
		{
			return new ReorderFormationRequest(this);
		}

		// Token: 0x170044A1 RID: 17569
		// (get) Token: 0x06014A49 RID: 84553 RVA: 0x002FF72F File Offset: 0x002FD92F
		// (set) Token: 0x06014A4A RID: 84554 RVA: 0x002FF737 File Offset: 0x002FD937
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

		// Token: 0x170044A2 RID: 17570
		// (get) Token: 0x06014A4B RID: 84555 RVA: 0x002FF740 File Offset: 0x002FD940
		// (set) Token: 0x06014A4C RID: 84556 RVA: 0x002FF748 File Offset: 0x002FD948
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

		// Token: 0x06014A4D RID: 84557 RVA: 0x002FF751 File Offset: 0x002FD951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReorderFormationRequest);
		}

		// Token: 0x06014A4E RID: 84558 RVA: 0x002FF75F File Offset: 0x002FD95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReorderFormationRequest other)
		{
			return other != null && (other == this || (this.FormationId == other.FormationId && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014A4F RID: 84559 RVA: 0x002FF7A0 File Offset: 0x002FD9A0
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

		// Token: 0x06014A50 RID: 84560 RVA: 0x002FF7F8 File Offset: 0x002FD9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014A51 RID: 84561 RVA: 0x002FF805 File Offset: 0x002FDA05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014A52 RID: 84562 RVA: 0x002FF810 File Offset: 0x002FDA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormationId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FormationId);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014A53 RID: 84563 RVA: 0x002FF86C File Offset: 0x002FDA6C
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

		// Token: 0x06014A54 RID: 84564 RVA: 0x002FF8C4 File Offset: 0x002FDAC4
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

		// Token: 0x06014A55 RID: 84565 RVA: 0x002FF914 File Offset: 0x002FDB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014A56 RID: 84566 RVA: 0x002FF920 File Offset: 0x002FDB20
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
					if (num != 96U)
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

		// Token: 0x04007D3C RID: 32060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D3D RID: 32061
		public const int FormationIdFieldNumber = 2;

		// Token: 0x04007D3E RID: 32062
		private int formationId_;

		// Token: 0x04007D3F RID: 32063
		public const int TargetIdFieldNumber = 12;

		// Token: 0x04007D40 RID: 32064
		private int targetId_;
	}
}
