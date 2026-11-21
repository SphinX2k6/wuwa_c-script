using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD7 RID: 2775
	[NetMessage(EMessageId.MulRogueWeeklyRewardRequest)]
	public sealed class MulRogueWeeklyRewardRequest : IMessage<MulRogueWeeklyRewardRequest>, IMessage, IEquatable<MulRogueWeeklyRewardRequest>, IDeepCloneable<MulRogueWeeklyRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F1B3 RID: 61875 RVA: 0x00234F00 File Offset: 0x00233100
		[NullableContext(1)]
		public static MulRogueWeeklyRewardRequest Create()
		{
			return new MulRogueWeeklyRewardRequest();
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0600F1B4 RID: 61876 RVA: 0x00234F07 File Offset: 0x00233107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0600F1B5 RID: 61877 RVA: 0x00234F0A File Offset: 0x0023310A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRogueWeeklyRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F1B6 RID: 61878 RVA: 0x00234F11 File Offset: 0x00233111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardRequest()
		{
		}

		// Token: 0x0600F1B7 RID: 61879 RVA: 0x00234F24 File Offset: 0x00233124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardRequest(MulRogueWeeklyRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.configId_ = other.configId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F1B8 RID: 61880 RVA: 0x00234F5A File Offset: 0x0023315A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRogueWeeklyRewardRequest Clone()
		{
			return new MulRogueWeeklyRewardRequest(this);
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0600F1B9 RID: 61881 RVA: 0x00234F62 File Offset: 0x00233162
		// (set) Token: 0x0600F1BA RID: 61882 RVA: 0x00234F6A File Offset: 0x0023316A
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

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600F1BB RID: 61883 RVA: 0x00234F73 File Offset: 0x00233173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ConfigId
		{
			get
			{
				return this.configId_;
			}
		}

		// Token: 0x0600F1BC RID: 61884 RVA: 0x00234F7B File Offset: 0x0023317B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRogueWeeklyRewardRequest);
		}

		// Token: 0x0600F1BD RID: 61885 RVA: 0x00234F8C File Offset: 0x0023318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRogueWeeklyRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.configId_.Equals(other.configId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F1BE RID: 61886 RVA: 0x00234FDC File Offset: 0x002331DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.configId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F1BF RID: 61887 RVA: 0x00235029 File Offset: 0x00233229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F1C0 RID: 61888 RVA: 0x00235036 File Offset: 0x00233236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F1C1 RID: 61889 RVA: 0x00235040 File Offset: 0x00233240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.configId_.WriteTo(ref output, MulRogueWeeklyRewardRequest._repeated_configId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F1C2 RID: 61890 RVA: 0x00235090 File Offset: 0x00233290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.configId_.CalculateSize(MulRogueWeeklyRewardRequest._repeated_configId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F1C3 RID: 61891 RVA: 0x002350E4 File Offset: 0x002332E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulRogueWeeklyRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.configId_.Add(other.configId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F1C4 RID: 61892 RVA: 0x00235131 File Offset: 0x00233331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F1C5 RID: 61893 RVA: 0x0023513C File Offset: 0x0023333C
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
				if (num != 40U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.configId_.AddEntriesFrom(ref input, MulRogueWeeklyRewardRequest._repeated_configId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040061F1 RID: 25073
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061F2 RID: 25074
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x040061F3 RID: 25075
		private int activityId_;

		// Token: 0x040061F4 RID: 25076
		public const int ConfigIdFieldNumber = 7;

		// Token: 0x040061F5 RID: 25077
		private static readonly FieldCodec<int> _repeated_configId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x040061F6 RID: 25078
		private readonly RepeatedField<int> configId_ = new RepeatedField<int>();
	}
}
