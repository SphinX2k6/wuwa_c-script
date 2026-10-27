using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200112E RID: 4398
	[NetMessage(EMessageId.RoverRogueTalentUnlockRequest)]
	public sealed class RoverRogueTalentUnlockRequest : IMessage<RoverRogueTalentUnlockRequest>, IMessage, IEquatable<RoverRogueTalentUnlockRequest>, IDeepCloneable<RoverRogueTalentUnlockRequest>, IBufferMessage
	{
		// Token: 0x06017762 RID: 96098 RVA: 0x00368878 File Offset: 0x00366A78
		[NullableContext(1)]
		public static RoverRogueTalentUnlockRequest Create()
		{
			return new RoverRogueTalentUnlockRequest();
		}

		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x06017763 RID: 96099 RVA: 0x0036887F File Offset: 0x00366A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EC3 RID: 20163
		// (get) Token: 0x06017764 RID: 96100 RVA: 0x00368882 File Offset: 0x00366A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTalentUnlockRequest.Descriptor;
			}
		}

		// Token: 0x06017765 RID: 96101 RVA: 0x00368889 File Offset: 0x00366A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockRequest()
		{
		}

		// Token: 0x06017766 RID: 96102 RVA: 0x00368891 File Offset: 0x00366A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockRequest(RoverRogueTalentUnlockRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017767 RID: 96103 RVA: 0x003688C2 File Offset: 0x00366AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTalentUnlockRequest Clone()
		{
			return new RoverRogueTalentUnlockRequest(this);
		}

		// Token: 0x17004EC4 RID: 20164
		// (get) Token: 0x06017768 RID: 96104 RVA: 0x003688CA File Offset: 0x00366ACA
		// (set) Token: 0x06017769 RID: 96105 RVA: 0x003688D2 File Offset: 0x00366AD2
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

		// Token: 0x17004EC5 RID: 20165
		// (get) Token: 0x0601776A RID: 96106 RVA: 0x003688DB File Offset: 0x00366ADB
		// (set) Token: 0x0601776B RID: 96107 RVA: 0x003688E3 File Offset: 0x00366AE3
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

		// Token: 0x0601776C RID: 96108 RVA: 0x003688EC File Offset: 0x00366AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTalentUnlockRequest);
		}

		// Token: 0x0601776D RID: 96109 RVA: 0x003688FA File Offset: 0x00366AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTalentUnlockRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601776E RID: 96110 RVA: 0x00368938 File Offset: 0x00366B38
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

		// Token: 0x0601776F RID: 96111 RVA: 0x00368990 File Offset: 0x00366B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017770 RID: 96112 RVA: 0x0036899D File Offset: 0x00366B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017771 RID: 96113 RVA: 0x003689A8 File Offset: 0x00366BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this.TalentId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017772 RID: 96114 RVA: 0x00368A04 File Offset: 0x00366C04
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

		// Token: 0x06017773 RID: 96115 RVA: 0x00368A5C File Offset: 0x00366C5C
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

		// Token: 0x06017774 RID: 96116 RVA: 0x00368AAC File Offset: 0x00366CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017775 RID: 96117 RVA: 0x00368AB8 File Offset: 0x00366CB8
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TalentId = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B87 RID: 35719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B88 RID: 35720
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04008B89 RID: 35721
		private int activityId_;

		// Token: 0x04008B8A RID: 35722
		public const int TalentIdFieldNumber = 5;

		// Token: 0x04008B8B RID: 35723
		private int talentId_;
	}
}
