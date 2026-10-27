using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE6 RID: 2790
	[NetMessage(EMessageId.MulRoguelikeWriteCatRewardRequest)]
	public sealed class MulRoguelikeWriteCatRewardRequest : IMessage<MulRoguelikeWriteCatRewardRequest>, IMessage, IEquatable<MulRoguelikeWriteCatRewardRequest>, IDeepCloneable<MulRoguelikeWriteCatRewardRequest>, IBufferMessage
	{
		// Token: 0x0600F2A5 RID: 62117 RVA: 0x00236BAF File Offset: 0x00234DAF
		[NullableContext(1)]
		public static MulRoguelikeWriteCatRewardRequest Create()
		{
			return new MulRoguelikeWriteCatRewardRequest();
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x0600F2A6 RID: 62118 RVA: 0x00236BB6 File Offset: 0x00234DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0600F2A7 RID: 62119 RVA: 0x00236BB9 File Offset: 0x00234DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulRoguelikeWriteCatRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600F2A8 RID: 62120 RVA: 0x00236BC0 File Offset: 0x00234DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardRequest()
		{
		}

		// Token: 0x0600F2A9 RID: 62121 RVA: 0x00236BD3 File Offset: 0x00234DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardRequest(MulRoguelikeWriteCatRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2AA RID: 62122 RVA: 0x00236C09 File Offset: 0x00234E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulRoguelikeWriteCatRewardRequest Clone()
		{
			return new MulRoguelikeWriteCatRewardRequest(this);
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0600F2AB RID: 62123 RVA: 0x00236C11 File Offset: 0x00234E11
		// (set) Token: 0x0600F2AC RID: 62124 RVA: 0x00236C19 File Offset: 0x00234E19
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

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600F2AD RID: 62125 RVA: 0x00236C22 File Offset: 0x00234E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Index
		{
			get
			{
				return this.index_;
			}
		}

		// Token: 0x0600F2AE RID: 62126 RVA: 0x00236C2A File Offset: 0x00234E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulRoguelikeWriteCatRewardRequest);
		}

		// Token: 0x0600F2AF RID: 62127 RVA: 0x00236C38 File Offset: 0x00234E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulRoguelikeWriteCatRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.index_.Equals(other.index_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x00236C88 File Offset: 0x00234E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.index_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F2B1 RID: 62129 RVA: 0x00236CD5 File Offset: 0x00234ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2B2 RID: 62130 RVA: 0x00236CE2 File Offset: 0x00234EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2B3 RID: 62131 RVA: 0x00236CEC File Offset: 0x00234EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			this.index_.WriteTo(ref output, MulRoguelikeWriteCatRewardRequest._repeated_index_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2B4 RID: 62132 RVA: 0x00236D3C File Offset: 0x00234F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.index_.CalculateSize(MulRoguelikeWriteCatRewardRequest._repeated_index_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F2B5 RID: 62133 RVA: 0x00236D90 File Offset: 0x00234F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulRoguelikeWriteCatRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.index_.Add(other.index_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F2B6 RID: 62134 RVA: 0x00236DDD File Offset: 0x00234FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2B7 RID: 62135 RVA: 0x00236DE8 File Offset: 0x00234FE8
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
					if (num != 40U && num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.index_.AddEntriesFrom(ref input, MulRoguelikeWriteCatRewardRequest._repeated_index_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040061DC RID: 25052
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061DD RID: 25053
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040061DE RID: 25054
		private int activityId_;

		// Token: 0x040061DF RID: 25055
		public const int IndexFieldNumber = 5;

		// Token: 0x040061E0 RID: 25056
		private static readonly FieldCodec<int> _repeated_index_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040061E1 RID: 25057
		private readonly RepeatedField<int> index_ = new RepeatedField<int>();
	}
}
