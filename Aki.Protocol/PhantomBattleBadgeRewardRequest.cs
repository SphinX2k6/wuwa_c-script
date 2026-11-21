using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C23 RID: 3107
	[NetMessage(EMessageId.PhantomBattleBadgeRewardRequest)]
	public sealed class PhantomBattleBadgeRewardRequest : IMessage<PhantomBattleBadgeRewardRequest>, IMessage, IEquatable<PhantomBattleBadgeRewardRequest>, IDeepCloneable<PhantomBattleBadgeRewardRequest>, IBufferMessage
	{
		// Token: 0x06010E0A RID: 69130 RVA: 0x00279195 File Offset: 0x00277395
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardRequest Create()
		{
			return new PhantomBattleBadgeRewardRequest();
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x06010E0B RID: 69131 RVA: 0x0027919C File Offset: 0x0027739C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x06010E0C RID: 69132 RVA: 0x0027919F File Offset: 0x0027739F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardRequest.Descriptor;
			}
		}

		// Token: 0x06010E0D RID: 69133 RVA: 0x002791A6 File Offset: 0x002773A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardRequest()
		{
		}

		// Token: 0x06010E0E RID: 69134 RVA: 0x002791B9 File Offset: 0x002773B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardRequest(PhantomBattleBadgeRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.badgeRewardId_ = other.badgeRewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E0F RID: 69135 RVA: 0x002791EF File Offset: 0x002773EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardRequest Clone()
		{
			return new PhantomBattleBadgeRewardRequest(this);
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x06010E10 RID: 69136 RVA: 0x002791F7 File Offset: 0x002773F7
		// (set) Token: 0x06010E11 RID: 69137 RVA: 0x002791FF File Offset: 0x002773FF
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

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x06010E12 RID: 69138 RVA: 0x00279208 File Offset: 0x00277408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BadgeRewardId
		{
			get
			{
				return this.badgeRewardId_;
			}
		}

		// Token: 0x06010E13 RID: 69139 RVA: 0x00279210 File Offset: 0x00277410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardRequest);
		}

		// Token: 0x06010E14 RID: 69140 RVA: 0x00279220 File Offset: 0x00277420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.badgeRewardId_.Equals(other.badgeRewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E15 RID: 69141 RVA: 0x00279270 File Offset: 0x00277470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.badgeRewardId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010E16 RID: 69142 RVA: 0x002792BD File Offset: 0x002774BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E17 RID: 69143 RVA: 0x002792CA File Offset: 0x002774CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E18 RID: 69144 RVA: 0x002792D4 File Offset: 0x002774D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			this.badgeRewardId_.WriteTo(ref output, PhantomBattleBadgeRewardRequest._repeated_badgeRewardId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E19 RID: 69145 RVA: 0x00279324 File Offset: 0x00277524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.badgeRewardId_.CalculateSize(PhantomBattleBadgeRewardRequest._repeated_badgeRewardId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010E1A RID: 69146 RVA: 0x00279378 File Offset: 0x00277578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBadgeRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.badgeRewardId_.Add(other.badgeRewardId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010E1B RID: 69147 RVA: 0x002793C5 File Offset: 0x002775C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E1C RID: 69148 RVA: 0x002793D0 File Offset: 0x002775D0
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
				if (num != 56U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.badgeRewardId_.AddEntriesFrom(ref input, PhantomBattleBadgeRewardRequest._repeated_badgeRewardId_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006B83 RID: 27523
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B84 RID: 27524
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x04006B85 RID: 27525
		private int activityId_;

		// Token: 0x04006B86 RID: 27526
		public const int BadgeRewardIdFieldNumber = 8;

		// Token: 0x04006B87 RID: 27527
		private static readonly FieldCodec<int> _repeated_badgeRewardId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006B88 RID: 27528
		private readonly RepeatedField<int> badgeRewardId_ = new RepeatedField<int>();
	}
}
