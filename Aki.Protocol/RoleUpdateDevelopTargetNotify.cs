using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D0 RID: 4304
	[NetMessage(EMessageId.RoleUpdateDevelopTargetNotify)]
	public sealed class RoleUpdateDevelopTargetNotify : IMessage<RoleUpdateDevelopTargetNotify>, IMessage, IEquatable<RoleUpdateDevelopTargetNotify>, IDeepCloneable<RoleUpdateDevelopTargetNotify>, IBufferMessage
	{
		// Token: 0x06016F68 RID: 94056 RVA: 0x003554AE File Offset: 0x003536AE
		[NullableContext(1)]
		public static RoleUpdateDevelopTargetNotify Create()
		{
			return new RoleUpdateDevelopTargetNotify();
		}

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x06016F69 RID: 94057 RVA: 0x003554B5 File Offset: 0x003536B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x06016F6A RID: 94058 RVA: 0x003554B8 File Offset: 0x003536B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleUpdateDevelopTargetNotify.Descriptor;
			}
		}

		// Token: 0x06016F6B RID: 94059 RVA: 0x003554BF File Offset: 0x003536BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetNotify()
		{
		}

		// Token: 0x06016F6C RID: 94060 RVA: 0x003554C7 File Offset: 0x003536C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetNotify(RoleUpdateDevelopTargetNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.planId_ = other.planId_;
			this.firstPhantomId_ = other.firstPhantomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016F6D RID: 94061 RVA: 0x00355504 File Offset: 0x00353704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleUpdateDevelopTargetNotify Clone()
		{
			return new RoleUpdateDevelopTargetNotify(this);
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x06016F6E RID: 94062 RVA: 0x0035550C File Offset: 0x0035370C
		// (set) Token: 0x06016F6F RID: 94063 RVA: 0x00355514 File Offset: 0x00353714
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

		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x06016F70 RID: 94064 RVA: 0x0035551D File Offset: 0x0035371D
		// (set) Token: 0x06016F71 RID: 94065 RVA: 0x00355525 File Offset: 0x00353725
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

		// Token: 0x17004CED RID: 19693
		// (get) Token: 0x06016F72 RID: 94066 RVA: 0x0035552E File Offset: 0x0035372E
		// (set) Token: 0x06016F73 RID: 94067 RVA: 0x00355536 File Offset: 0x00353736
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

		// Token: 0x06016F74 RID: 94068 RVA: 0x0035553F File Offset: 0x0035373F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleUpdateDevelopTargetNotify);
		}

		// Token: 0x06016F75 RID: 94069 RVA: 0x00355550 File Offset: 0x00353750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleUpdateDevelopTargetNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.PlanId == other.PlanId && this.FirstPhantomId == other.FirstPhantomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F76 RID: 94070 RVA: 0x003555AC File Offset: 0x003537AC
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

		// Token: 0x06016F77 RID: 94071 RVA: 0x0035561D File Offset: 0x0035381D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F78 RID: 94072 RVA: 0x0035562A File Offset: 0x0035382A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F79 RID: 94073 RVA: 0x00355634 File Offset: 0x00353834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FirstPhantomId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FirstPhantomId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			if (this.PlanId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlanId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F7A RID: 94074 RVA: 0x003556AC File Offset: 0x003538AC
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

		// Token: 0x06016F7B RID: 94075 RVA: 0x0035571C File Offset: 0x0035391C
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

		// Token: 0x06016F7C RID: 94076 RVA: 0x00355780 File Offset: 0x00353980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F7D RID: 94077 RVA: 0x0035578C File Offset: 0x0035398C
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
				if (num != 24U)
				{
					if (num != 88U)
					{
						if (num != 96U)
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

		// Token: 0x040088C6 RID: 35014
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088C7 RID: 35015
		public const int RoleIdFieldNumber = 11;

		// Token: 0x040088C8 RID: 35016
		private int roleId_;

		// Token: 0x040088C9 RID: 35017
		public const int PlanIdFieldNumber = 12;

		// Token: 0x040088CA RID: 35018
		private int planId_;

		// Token: 0x040088CB RID: 35019
		public const int FirstPhantomIdFieldNumber = 3;

		// Token: 0x040088CC RID: 35020
		private int firstPhantomId_;
	}
}
