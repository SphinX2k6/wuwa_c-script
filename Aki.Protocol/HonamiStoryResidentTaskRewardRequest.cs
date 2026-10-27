using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079A RID: 1946
	[NetMessage(EMessageId.HonamiStoryResidentTaskRewardRequest)]
	public sealed class HonamiStoryResidentTaskRewardRequest : IMessage<HonamiStoryResidentTaskRewardRequest>, IMessage, IEquatable<HonamiStoryResidentTaskRewardRequest>, IDeepCloneable<HonamiStoryResidentTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AF85 RID: 44933 RVA: 0x001A53FD File Offset: 0x001A35FD
		[NullableContext(1)]
		public static HonamiStoryResidentTaskRewardRequest Create()
		{
			return new HonamiStoryResidentTaskRewardRequest();
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x0600AF86 RID: 44934 RVA: 0x001A5404 File Offset: 0x001A3604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x0600AF87 RID: 44935 RVA: 0x001A5407 File Offset: 0x001A3607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryResidentTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AF88 RID: 44936 RVA: 0x001A540E File Offset: 0x001A360E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardRequest()
		{
		}

		// Token: 0x0600AF89 RID: 44937 RVA: 0x001A5421 File Offset: 0x001A3621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardRequest(HonamiStoryResidentTaskRewardRequest other) : this()
		{
			this.residentTaskIds_ = other.residentTaskIds_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x001A5457 File Offset: 0x001A3657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskRewardRequest Clone()
		{
			return new HonamiStoryResidentTaskRewardRequest(this);
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x0600AF8B RID: 44939 RVA: 0x001A545F File Offset: 0x001A365F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ResidentTaskIds
		{
			get
			{
				return this.residentTaskIds_;
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x0600AF8C RID: 44940 RVA: 0x001A5467 File Offset: 0x001A3667
		// (set) Token: 0x0600AF8D RID: 44941 RVA: 0x001A546F File Offset: 0x001A366F
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

		// Token: 0x0600AF8E RID: 44942 RVA: 0x001A5478 File Offset: 0x001A3678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryResidentTaskRewardRequest);
		}

		// Token: 0x0600AF8F RID: 44943 RVA: 0x001A5488 File Offset: 0x001A3688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryResidentTaskRewardRequest other)
		{
			return other != null && (other == this || (this.residentTaskIds_.Equals(other.residentTaskIds_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x001A54D8 File Offset: 0x001A36D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.residentTaskIds_.GetHashCode();
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

		// Token: 0x0600AF91 RID: 44945 RVA: 0x001A5525 File Offset: 0x001A3725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x001A5532 File Offset: 0x001A3732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x001A553C File Offset: 0x001A373C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			this.residentTaskIds_.WriteTo(ref output, HonamiStoryResidentTaskRewardRequest._repeated_residentTaskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x001A558C File Offset: 0x001A378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.residentTaskIds_.CalculateSize(HonamiStoryResidentTaskRewardRequest._repeated_residentTaskIds_codec);
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

		// Token: 0x0600AF95 RID: 44949 RVA: 0x001A55E0 File Offset: 0x001A37E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryResidentTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.residentTaskIds_.Add(other.residentTaskIds_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF96 RID: 44950 RVA: 0x001A562D File Offset: 0x001A382D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF97 RID: 44951 RVA: 0x001A5638 File Offset: 0x001A3838
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
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.residentTaskIds_.AddEntriesFrom(ref input, HonamiStoryResidentTaskRewardRequest._repeated_residentTaskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EFF RID: 20223
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F00 RID: 20224
		public const int ResidentTaskIdsFieldNumber = 7;

		// Token: 0x04004F01 RID: 20225
		private static readonly FieldCodec<int> _repeated_residentTaskIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04004F02 RID: 20226
		private readonly RepeatedField<int> residentTaskIds_ = new RepeatedField<int>();

		// Token: 0x04004F03 RID: 20227
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004F04 RID: 20228
		private int activityId_;
	}
}
