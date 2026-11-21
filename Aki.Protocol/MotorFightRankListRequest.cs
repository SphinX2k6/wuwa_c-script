using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A40 RID: 2624
	[NetMessage(EMessageId.MotorFightRankListRequest)]
	public sealed class MotorFightRankListRequest : IMessage<MotorFightRankListRequest>, IMessage, IEquatable<MotorFightRankListRequest>, IDeepCloneable<MotorFightRankListRequest>, IBufferMessage
	{
		// Token: 0x0600E557 RID: 58711 RVA: 0x002188E1 File Offset: 0x00216AE1
		[NullableContext(1)]
		public static MotorFightRankListRequest Create()
		{
			return new MotorFightRankListRequest();
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0600E558 RID: 58712 RVA: 0x002188E8 File Offset: 0x00216AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0600E559 RID: 58713 RVA: 0x002188EB File Offset: 0x00216AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightRankListRequest.Descriptor;
			}
		}

		// Token: 0x0600E55A RID: 58714 RVA: 0x002188F2 File Offset: 0x00216AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListRequest()
		{
		}

		// Token: 0x0600E55B RID: 58715 RVA: 0x002188FA File Offset: 0x00216AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListRequest(MotorFightRankListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E55C RID: 58716 RVA: 0x0021891F File Offset: 0x00216B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightRankListRequest Clone()
		{
			return new MotorFightRankListRequest(this);
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0600E55D RID: 58717 RVA: 0x00218927 File Offset: 0x00216B27
		// (set) Token: 0x0600E55E RID: 58718 RVA: 0x0021892F File Offset: 0x00216B2F
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

		// Token: 0x0600E55F RID: 58719 RVA: 0x00218938 File Offset: 0x00216B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightRankListRequest);
		}

		// Token: 0x0600E560 RID: 58720 RVA: 0x00218946 File Offset: 0x00216B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightRankListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E561 RID: 58721 RVA: 0x00218974 File Offset: 0x00216B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E562 RID: 58722 RVA: 0x002189B3 File Offset: 0x00216BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E563 RID: 58723 RVA: 0x002189C0 File Offset: 0x00216BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E564 RID: 58724 RVA: 0x002189C9 File Offset: 0x00216BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E565 RID: 58725 RVA: 0x002189FC File Offset: 0x00216BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x00218A3A File Offset: 0x00216C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightRankListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E567 RID: 58727 RVA: 0x00218A6B File Offset: 0x00216C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E568 RID: 58728 RVA: 0x00218A74 File Offset: 0x00216C74
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005E0A RID: 24074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E0B RID: 24075
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04005E0C RID: 24076
		private int activityId_;
	}
}
