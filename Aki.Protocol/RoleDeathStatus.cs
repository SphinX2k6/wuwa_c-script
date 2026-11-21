using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001053 RID: 4179
	public sealed class RoleDeathStatus : IMessage<RoleDeathStatus>, IMessage, IEquatable<RoleDeathStatus>, IDeepCloneable<RoleDeathStatus>, IBufferMessage
	{
		// Token: 0x060165B2 RID: 91570 RVA: 0x00340415 File Offset: 0x0033E615
		[NullableContext(1)]
		public static RoleDeathStatus Create()
		{
			return new RoleDeathStatus();
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x060165B3 RID: 91571 RVA: 0x0034041C File Offset: 0x0033E61C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x060165B4 RID: 91572 RVA: 0x0034041F File Offset: 0x0033E61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleDeathStatus.Descriptor;
			}
		}

		// Token: 0x060165B5 RID: 91573 RVA: 0x00340426 File Offset: 0x0033E626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDeathStatus()
		{
		}

		// Token: 0x060165B6 RID: 91574 RVA: 0x0034042E File Offset: 0x0033E62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDeathStatus(RoleDeathStatus other) : this()
		{
			this.entityId_ = other.entityId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060165B7 RID: 91575 RVA: 0x0034045F File Offset: 0x0033E65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleDeathStatus Clone()
		{
			return new RoleDeathStatus(this);
		}

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x060165B8 RID: 91576 RVA: 0x00340467 File Offset: 0x0033E667
		// (set) Token: 0x060165B9 RID: 91577 RVA: 0x0034046F File Offset: 0x0033E66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x060165BA RID: 91578 RVA: 0x00340478 File Offset: 0x0033E678
		// (set) Token: 0x060165BB RID: 91579 RVA: 0x00340480 File Offset: 0x0033E680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x060165BC RID: 91580 RVA: 0x00340489 File Offset: 0x0033E689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleDeathStatus);
		}

		// Token: 0x060165BD RID: 91581 RVA: 0x00340497 File Offset: 0x0033E697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleDeathStatus other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060165BE RID: 91582 RVA: 0x003404D8 File Offset: 0x0033E6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Status)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060165BF RID: 91583 RVA: 0x00340530 File Offset: 0x0033E730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060165C0 RID: 91584 RVA: 0x0034053D File Offset: 0x0033E73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060165C1 RID: 91585 RVA: 0x00340548 File Offset: 0x0033E748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.Status)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060165C2 RID: 91586 RVA: 0x003405A0 File Offset: 0x0033E7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Status)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060165C3 RID: 91587 RVA: 0x003405EC File Offset: 0x0033E7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleDeathStatus other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Status)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060165C4 RID: 91588 RVA: 0x0034063C File Offset: 0x0033E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060165C5 RID: 91589 RVA: 0x00340648 File Offset: 0x0033E848
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400862C RID: 34348
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400862D RID: 34349
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400862E RID: 34350
		private long entityId_;

		// Token: 0x0400862F RID: 34351
		public const int StatusFieldNumber = 2;

		// Token: 0x04008630 RID: 34352
		private bool status_;
	}
}
