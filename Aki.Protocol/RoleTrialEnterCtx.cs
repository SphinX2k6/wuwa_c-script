using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001103 RID: 4355
	public sealed class RoleTrialEnterCtx : IMessage<RoleTrialEnterCtx>, IMessage, IEquatable<RoleTrialEnterCtx>, IDeepCloneable<RoleTrialEnterCtx>, IBufferMessage
	{
		// Token: 0x0601747D RID: 95357 RVA: 0x003635E5 File Offset: 0x003617E5
		[NullableContext(1)]
		public static RoleTrialEnterCtx Create()
		{
			return new RoleTrialEnterCtx();
		}

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x0601747E RID: 95358 RVA: 0x003635EC File Offset: 0x003617EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x0601747F RID: 95359 RVA: 0x003635EF File Offset: 0x003617EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialEnterCtx.Descriptor;
			}
		}

		// Token: 0x06017480 RID: 95360 RVA: 0x003635F6 File Offset: 0x003617F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialEnterCtx()
		{
		}

		// Token: 0x06017481 RID: 95361 RVA: 0x003635FE File Offset: 0x003617FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialEnterCtx(RoleTrialEnterCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleId_ = other.roleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017482 RID: 95362 RVA: 0x0036362F File Offset: 0x0036182F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialEnterCtx Clone()
		{
			return new RoleTrialEnterCtx(this);
		}

		// Token: 0x17004E3A RID: 20026
		// (get) Token: 0x06017483 RID: 95363 RVA: 0x00363637 File Offset: 0x00361837
		// (set) Token: 0x06017484 RID: 95364 RVA: 0x0036363F File Offset: 0x0036183F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004E3B RID: 20027
		// (get) Token: 0x06017485 RID: 95365 RVA: 0x00363648 File Offset: 0x00361848
		// (set) Token: 0x06017486 RID: 95366 RVA: 0x00363650 File Offset: 0x00361850
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

		// Token: 0x06017487 RID: 95367 RVA: 0x00363659 File Offset: 0x00361859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialEnterCtx);
		}

		// Token: 0x06017488 RID: 95368 RVA: 0x00363667 File Offset: 0x00361867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialEnterCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RoleId == other.RoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017489 RID: 95369 RVA: 0x003636A8 File Offset: 0x003618A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601748A RID: 95370 RVA: 0x00363700 File Offset: 0x00361900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601748B RID: 95371 RVA: 0x0036370D File Offset: 0x0036190D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601748C RID: 95372 RVA: 0x00363718 File Offset: 0x00361918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601748D RID: 95373 RVA: 0x00363770 File Offset: 0x00361970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601748E RID: 95374 RVA: 0x003637C8 File Offset: 0x003619C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601748F RID: 95375 RVA: 0x00363818 File Offset: 0x00361A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017490 RID: 95376 RVA: 0x00363824 File Offset: 0x00361A24
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
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B31 RID: 35633
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B32 RID: 35634
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04008B33 RID: 35635
		private int activityId_;

		// Token: 0x04008B34 RID: 35636
		public const int RoleIdFieldNumber = 2;

		// Token: 0x04008B35 RID: 35637
		private int roleId_;
	}
}
