using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001168 RID: 4456
	[NetMessage(EMessageId.RoverRogueTalentUnlockRequest)]
	public sealed class RoverRogueTalentUnlockRequest : IMessage<RoverRogueTalentUnlockRequest>, IMessage, IEquatable<RoverRogueTalentUnlockRequest>, IDeepCloneable<RoverRogueTalentUnlockRequest>, IBufferMessage
	{
		// Token: 0x06017D03 RID: 97539 RVA: 0x00377BC5 File Offset: 0x00375DC5
		[NullableContext(1)]
		public static RoverRogueTalentUnlockRequest Create()
		{
			return new RoverRogueTalentUnlockRequest();
		}

		// Token: 0x1700502E RID: 20526
		// (get) Token: 0x06017D04 RID: 97540 RVA: 0x00377BCC File Offset: 0x00375DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700502F RID: 20527
		// (get) Token: 0x06017D05 RID: 97541 RVA: 0x00377BCF File Offset: 0x00375DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06017D06 RID: 97542 RVA: 0x00377BD6 File Offset: 0x00375DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockRequest()
		{
		}

		// Token: 0x06017D07 RID: 97543 RVA: 0x00377BDE File Offset: 0x00375DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockRequest(RoverRogueTalentUnlockRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D08 RID: 97544 RVA: 0x00377C0F File Offset: 0x00375E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockRequest Clone()
		{
			return new RoverRogueTalentUnlockRequest(this);
		}

		// Token: 0x17005030 RID: 20528
		// (get) Token: 0x06017D09 RID: 97545 RVA: 0x00377C17 File Offset: 0x00375E17
		// (set) Token: 0x06017D0A RID: 97546 RVA: 0x00377C1F File Offset: 0x00375E1F
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

		// Token: 0x17005031 RID: 20529
		// (get) Token: 0x06017D0B RID: 97547 RVA: 0x00377C28 File Offset: 0x00375E28
		// (set) Token: 0x06017D0C RID: 97548 RVA: 0x00377C30 File Offset: 0x00375E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x06017D0D RID: 97549 RVA: 0x00377C39 File Offset: 0x00375E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentUnlockRequest);
		}

		// Token: 0x06017D0E RID: 97550 RVA: 0x00377C47 File Offset: 0x00375E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentUnlockRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D0F RID: 97551 RVA: 0x00377C88 File Offset: 0x00375E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.TalentId != 0)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D10 RID: 97552 RVA: 0x00377CE0 File Offset: 0x00375EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D11 RID: 97553 RVA: 0x00377CED File Offset: 0x00375EED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D12 RID: 97554 RVA: 0x00377CF8 File Offset: 0x00375EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TalentId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D13 RID: 97555 RVA: 0x00377D54 File Offset: 0x00375F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.TalentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D14 RID: 97556 RVA: 0x00377DAC File Offset: 0x00375FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTalentUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D15 RID: 97557 RVA: 0x00377DFC File Offset: 0x00375FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D16 RID: 97558 RVA: 0x00377E08 File Offset: 0x00376008
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
				if (num != 64U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.TalentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E1A RID: 36378
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E1B RID: 36379
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04008E1C RID: 36380
		private int activityId_;

		// Token: 0x04008E1D RID: 36381
		public const int TalentIdFieldNumber = 8;

		// Token: 0x04008E1E RID: 36382
		private int talentId_;
	}
}
