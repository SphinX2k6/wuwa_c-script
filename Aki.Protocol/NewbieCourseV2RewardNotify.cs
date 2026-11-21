using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFB RID: 2811
	[NetMessage(EMessageId.NewbieCourseV2RewardNotify)]
	public sealed class NewbieCourseV2RewardNotify : IMessage<NewbieCourseV2RewardNotify>, IMessage, IEquatable<NewbieCourseV2RewardNotify>, IDeepCloneable<NewbieCourseV2RewardNotify>, IBufferMessage
	{
		// Token: 0x0600F492 RID: 62610 RVA: 0x0023B4DB File Offset: 0x002396DB
		[NullableContext(1)]
		public static NewbieCourseV2RewardNotify Create()
		{
			return new NewbieCourseV2RewardNotify();
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600F493 RID: 62611 RVA: 0x0023B4E2 File Offset: 0x002396E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600F494 RID: 62612 RVA: 0x0023B4E5 File Offset: 0x002396E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieCourseV2RewardNotify.Descriptor;
			}
		}

		// Token: 0x0600F495 RID: 62613 RVA: 0x0023B4EC File Offset: 0x002396EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardNotify()
		{
		}

		// Token: 0x0600F496 RID: 62614 RVA: 0x0023B4FF File Offset: 0x002396FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardNotify(NewbieCourseV2RewardNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.hadTakeReward_ = other.hadTakeReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F497 RID: 62615 RVA: 0x0023B535 File Offset: 0x00239735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieCourseV2RewardNotify Clone()
		{
			return new NewbieCourseV2RewardNotify(this);
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600F498 RID: 62616 RVA: 0x0023B53D File Offset: 0x0023973D
		// (set) Token: 0x0600F499 RID: 62617 RVA: 0x0023B545 File Offset: 0x00239745
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

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600F49A RID: 62618 RVA: 0x0023B54E File Offset: 0x0023974E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> HadTakeReward
		{
			get
			{
				return this.hadTakeReward_;
			}
		}

		// Token: 0x0600F49B RID: 62619 RVA: 0x0023B556 File Offset: 0x00239756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieCourseV2RewardNotify);
		}

		// Token: 0x0600F49C RID: 62620 RVA: 0x0023B564 File Offset: 0x00239764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieCourseV2RewardNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.hadTakeReward_.Equals(other.hadTakeReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F49D RID: 62621 RVA: 0x0023B5B4 File Offset: 0x002397B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.hadTakeReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F49E RID: 62622 RVA: 0x0023B601 File Offset: 0x00239801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F49F RID: 62623 RVA: 0x0023B60E File Offset: 0x0023980E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4A0 RID: 62624 RVA: 0x0023B618 File Offset: 0x00239818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			this.hadTakeReward_.WriteTo(ref output, NewbieCourseV2RewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F4A1 RID: 62625 RVA: 0x0023B668 File Offset: 0x00239868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.hadTakeReward_.CalculateSize(NewbieCourseV2RewardNotify._repeated_hadTakeReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F4A2 RID: 62626 RVA: 0x0023B6BC File Offset: 0x002398BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieCourseV2RewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.hadTakeReward_.Add(other.hadTakeReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F4A3 RID: 62627 RVA: 0x0023B709 File Offset: 0x00239909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4A4 RID: 62628 RVA: 0x0023B714 File Offset: 0x00239914
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
				if (num != 88U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.hadTakeReward_.AddEntriesFrom(ref input, NewbieCourseV2RewardNotify._repeated_hadTakeReward_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062C9 RID: 25289
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062CA RID: 25290
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x040062CB RID: 25291
		private int activityId_;

		// Token: 0x040062CC RID: 25292
		public const int HadTakeRewardFieldNumber = 13;

		// Token: 0x040062CD RID: 25293
		private static readonly FieldCodec<int> _repeated_hadTakeReward_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040062CE RID: 25294
		private readonly RepeatedField<int> hadTakeReward_ = new RepeatedField<int>();
	}
}
