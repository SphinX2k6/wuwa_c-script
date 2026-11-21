using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200110A RID: 4362
	[NetMessage(EMessageId.RoleUpdateDevelopTargetNotify)]
	public sealed class RoleUpdateDevelopTargetNotify : IMessage<RoleUpdateDevelopTargetNotify>, IMessage, IEquatable<RoleUpdateDevelopTargetNotify>, IDeepCloneable<RoleUpdateDevelopTargetNotify>, IBufferMessage
	{
		// Token: 0x06017507 RID: 95495 RVA: 0x00364762 File Offset: 0x00362962
		[NullableContext(1)]
		public static RoleUpdateDevelopTargetNotify Create()
		{
			return new RoleUpdateDevelopTargetNotify();
		}

		// Token: 0x17004E54 RID: 20052
		// (get) Token: 0x06017508 RID: 95496 RVA: 0x00364769 File Offset: 0x00362969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E55 RID: 20053
		// (get) Token: 0x06017509 RID: 95497 RVA: 0x0036476C File Offset: 0x0036296C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleUpdateDevelopTargetNotify.Descriptor;
			}
		}

		// Token: 0x0601750A RID: 95498 RVA: 0x00364773 File Offset: 0x00362973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetNotify()
		{
		}

		// Token: 0x0601750B RID: 95499 RVA: 0x0036477B File Offset: 0x0036297B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetNotify(RoleUpdateDevelopTargetNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.planId_ = other.planId_;
			this.firstPhantomId_ = other.firstPhantomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601750C RID: 95500 RVA: 0x003647B8 File Offset: 0x003629B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetNotify Clone()
		{
			return new RoleUpdateDevelopTargetNotify(this);
		}

		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x0601750D RID: 95501 RVA: 0x003647C0 File Offset: 0x003629C0
		// (set) Token: 0x0601750E RID: 95502 RVA: 0x003647C8 File Offset: 0x003629C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004E57 RID: 20055
		// (get) Token: 0x0601750F RID: 95503 RVA: 0x003647D1 File Offset: 0x003629D1
		// (set) Token: 0x06017510 RID: 95504 RVA: 0x003647D9 File Offset: 0x003629D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlanId
		{
			get
			{
				return this.planId_;
			}
			set
			{
				this.planId_ = value;
			}
		}

		// Token: 0x17004E58 RID: 20056
		// (get) Token: 0x06017511 RID: 95505 RVA: 0x003647E2 File Offset: 0x003629E2
		// (set) Token: 0x06017512 RID: 95506 RVA: 0x003647EA File Offset: 0x003629EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstPhantomId
		{
			get
			{
				return this.firstPhantomId_;
			}
			set
			{
				this.firstPhantomId_ = value;
			}
		}

		// Token: 0x06017513 RID: 95507 RVA: 0x003647F3 File Offset: 0x003629F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleUpdateDevelopTargetNotify);
		}

		// Token: 0x06017514 RID: 95508 RVA: 0x00364804 File Offset: 0x00362A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleUpdateDevelopTargetNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.PlanId == other.PlanId && this.FirstPhantomId == other.FirstPhantomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017515 RID: 95509 RVA: 0x00364860 File Offset: 0x00362A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.PlanId != 0)
			{
				num ^= this.PlanId.GetHashCode();
			}
			if (this.FirstPhantomId != 0)
			{
				num ^= this.FirstPhantomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017516 RID: 95510 RVA: 0x003648D1 File Offset: 0x00362AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017517 RID: 95511 RVA: 0x003648DE File Offset: 0x00362ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017518 RID: 95512 RVA: 0x003648E8 File Offset: 0x00362AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FirstPhantomId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FirstPhantomId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RoleId);
			}
			if (this.PlanId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PlanId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017519 RID: 95513 RVA: 0x0036495C File Offset: 0x00362B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.PlanId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlanId);
			}
			if (this.FirstPhantomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FirstPhantomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601751A RID: 95514 RVA: 0x003649CC File Offset: 0x00362BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleUpdateDevelopTargetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.PlanId != 0)
			{
				this.PlanId = other.PlanId;
			}
			if (other.FirstPhantomId != 0)
			{
				this.FirstPhantomId = other.FirstPhantomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601751B RID: 95515 RVA: 0x00364A30 File Offset: 0x00362C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601751C RID: 95516 RVA: 0x00364A3C File Offset: 0x00362C3C
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
					if (num != 40U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlanId = input.ReadInt32();
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.FirstPhantomId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B57 RID: 35671
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B58 RID: 35672
		public const int RoleIdFieldNumber = 5;

		// Token: 0x04008B59 RID: 35673
		private int roleId_;

		// Token: 0x04008B5A RID: 35674
		public const int PlanIdFieldNumber = 14;

		// Token: 0x04008B5B RID: 35675
		private int planId_;

		// Token: 0x04008B5C RID: 35676
		public const int FirstPhantomIdFieldNumber = 1;

		// Token: 0x04008B5D RID: 35677
		private int firstPhantomId_;
	}
}
