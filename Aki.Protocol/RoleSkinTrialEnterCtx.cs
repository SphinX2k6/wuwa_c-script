using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010BF RID: 4287
	public sealed class RoleSkinTrialEnterCtx : IMessage<RoleSkinTrialEnterCtx>, IMessage, IEquatable<RoleSkinTrialEnterCtx>, IDeepCloneable<RoleSkinTrialEnterCtx>, IBufferMessage
	{
		// Token: 0x06016E1D RID: 93725 RVA: 0x00352C0D File Offset: 0x00350E0D
		[NullableContext(1)]
		public static RoleSkinTrialEnterCtx Create()
		{
			return new RoleSkinTrialEnterCtx();
		}

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x06016E1E RID: 93726 RVA: 0x00352C14 File Offset: 0x00350E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x06016E1F RID: 93727 RVA: 0x00352C17 File Offset: 0x00350E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialEnterCtx.Descriptor;
			}
		}

		// Token: 0x06016E20 RID: 93728 RVA: 0x00352C1E File Offset: 0x00350E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialEnterCtx()
		{
		}

		// Token: 0x06016E21 RID: 93729 RVA: 0x00352C26 File Offset: 0x00350E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialEnterCtx(RoleSkinTrialEnterCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleSkinTrialInfoId_ = other.roleSkinTrialInfoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E22 RID: 93730 RVA: 0x00352C57 File Offset: 0x00350E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialEnterCtx Clone()
		{
			return new RoleSkinTrialEnterCtx(this);
		}

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x06016E23 RID: 93731 RVA: 0x00352C5F File Offset: 0x00350E5F
		// (set) Token: 0x06016E24 RID: 93732 RVA: 0x00352C67 File Offset: 0x00350E67
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

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x06016E25 RID: 93733 RVA: 0x00352C70 File Offset: 0x00350E70
		// (set) Token: 0x06016E26 RID: 93734 RVA: 0x00352C78 File Offset: 0x00350E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinTrialInfoId
		{
			get
			{
				return this.roleSkinTrialInfoId_;
			}
			set
			{
				this.roleSkinTrialInfoId_ = value;
			}
		}

		// Token: 0x06016E27 RID: 93735 RVA: 0x00352C81 File Offset: 0x00350E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialEnterCtx);
		}

		// Token: 0x06016E28 RID: 93736 RVA: 0x00352C8F File Offset: 0x00350E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialEnterCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RoleSkinTrialInfoId == other.RoleSkinTrialInfoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E29 RID: 93737 RVA: 0x00352CD0 File Offset: 0x00350ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.RoleSkinTrialInfoId != 0)
			{
				num ^= this.RoleSkinTrialInfoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E2A RID: 93738 RVA: 0x00352D28 File Offset: 0x00350F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E2B RID: 93739 RVA: 0x00352D35 File Offset: 0x00350F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E2C RID: 93740 RVA: 0x00352D40 File Offset: 0x00350F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.RoleSkinTrialInfoId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleSkinTrialInfoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E2D RID: 93741 RVA: 0x00352D98 File Offset: 0x00350F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.RoleSkinTrialInfoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinTrialInfoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E2E RID: 93742 RVA: 0x00352DF0 File Offset: 0x00350FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinTrialEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.RoleSkinTrialInfoId != 0)
			{
				this.RoleSkinTrialInfoId = other.RoleSkinTrialInfoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E2F RID: 93743 RVA: 0x00352E40 File Offset: 0x00351040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E30 RID: 93744 RVA: 0x00352E4C File Offset: 0x0035104C
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
						this.RoleSkinTrialInfoId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008871 RID: 34929
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008872 RID: 34930
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04008873 RID: 34931
		private int activityId_;

		// Token: 0x04008874 RID: 34932
		public const int RoleSkinTrialInfoIdFieldNumber = 2;

		// Token: 0x04008875 RID: 34933
		private int roleSkinTrialInfoId_;
	}
}
