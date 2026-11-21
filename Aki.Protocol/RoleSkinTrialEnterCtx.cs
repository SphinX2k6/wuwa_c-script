using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AF RID: 4271
	public sealed class RoleSkinTrialEnterCtx : IMessage<RoleSkinTrialEnterCtx>, IMessage, IEquatable<RoleSkinTrialEnterCtx>, IDeepCloneable<RoleSkinTrialEnterCtx>, IBufferMessage
	{
		// Token: 0x06016D38 RID: 93496 RVA: 0x00351531 File Offset: 0x0034F731
		[NullableContext(1)]
		public static RoleSkinTrialEnterCtx Create()
		{
			return new RoleSkinTrialEnterCtx();
		}

		// Token: 0x17004C7E RID: 19582
		// (get) Token: 0x06016D39 RID: 93497 RVA: 0x00351538 File Offset: 0x0034F738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C7F RID: 19583
		// (get) Token: 0x06016D3A RID: 93498 RVA: 0x0035153B File Offset: 0x0034F73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialEnterCtx.Descriptor;
			}
		}

		// Token: 0x06016D3B RID: 93499 RVA: 0x00351542 File Offset: 0x0034F742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialEnterCtx()
		{
		}

		// Token: 0x06016D3C RID: 93500 RVA: 0x0035154A File Offset: 0x0034F74A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialEnterCtx(RoleSkinTrialEnterCtx other) : this()
		{
			this.activityId_ = other.activityId_;
			this.roleSkinTrialInfoId_ = other.roleSkinTrialInfoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D3D RID: 93501 RVA: 0x0035157B File Offset: 0x0034F77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialEnterCtx Clone()
		{
			return new RoleSkinTrialEnterCtx(this);
		}

		// Token: 0x17004C80 RID: 19584
		// (get) Token: 0x06016D3E RID: 93502 RVA: 0x00351583 File Offset: 0x0034F783
		// (set) Token: 0x06016D3F RID: 93503 RVA: 0x0035158B File Offset: 0x0034F78B
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

		// Token: 0x17004C81 RID: 19585
		// (get) Token: 0x06016D40 RID: 93504 RVA: 0x00351594 File Offset: 0x0034F794
		// (set) Token: 0x06016D41 RID: 93505 RVA: 0x0035159C File Offset: 0x0034F79C
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

		// Token: 0x06016D42 RID: 93506 RVA: 0x003515A5 File Offset: 0x0034F7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialEnterCtx);
		}

		// Token: 0x06016D43 RID: 93507 RVA: 0x003515B3 File Offset: 0x0034F7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialEnterCtx other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.RoleSkinTrialInfoId == other.RoleSkinTrialInfoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016D44 RID: 93508 RVA: 0x003515F4 File Offset: 0x0034F7F4
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

		// Token: 0x06016D45 RID: 93509 RVA: 0x0035164C File Offset: 0x0034F84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D46 RID: 93510 RVA: 0x00351659 File Offset: 0x0034F859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D47 RID: 93511 RVA: 0x00351664 File Offset: 0x0034F864
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

		// Token: 0x06016D48 RID: 93512 RVA: 0x003516BC File Offset: 0x0034F8BC
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

		// Token: 0x06016D49 RID: 93513 RVA: 0x00351714 File Offset: 0x0034F914
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

		// Token: 0x06016D4A RID: 93514 RVA: 0x00351764 File Offset: 0x0034F964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D4B RID: 93515 RVA: 0x00351770 File Offset: 0x0034F970
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

		// Token: 0x0400889B RID: 34971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400889C RID: 34972
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x0400889D RID: 34973
		private int activityId_;

		// Token: 0x0400889E RID: 34974
		public const int RoleSkinTrialInfoIdFieldNumber = 2;

		// Token: 0x0400889F RID: 34975
		private int roleSkinTrialInfoId_;
	}
}
