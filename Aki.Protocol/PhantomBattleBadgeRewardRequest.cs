using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C33 RID: 3123
	[NetMessage(EMessageId.PhantomBattleBadgeRewardRequest)]
	public sealed class PhantomBattleBadgeRewardRequest : IMessage<PhantomBattleBadgeRewardRequest>, IMessage, IEquatable<PhantomBattleBadgeRewardRequest>, IDeepCloneable<PhantomBattleBadgeRewardRequest>, IBufferMessage
	{
		// Token: 0x06010F0A RID: 69386 RVA: 0x0027AEF9 File Offset: 0x002790F9
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardRequest Create()
		{
			return new PhantomBattleBadgeRewardRequest();
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x06010F0B RID: 69387 RVA: 0x0027AF00 File Offset: 0x00279100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x06010F0C RID: 69388 RVA: 0x0027AF03 File Offset: 0x00279103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardRequest.Descriptor;
			}
		}

		// Token: 0x06010F0D RID: 69389 RVA: 0x0027AF0A File Offset: 0x0027910A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardRequest()
		{
		}

		// Token: 0x06010F0E RID: 69390 RVA: 0x0027AF1D File Offset: 0x0027911D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardRequest(PhantomBattleBadgeRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.badgeRewardId_ = other.badgeRewardId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010F0F RID: 69391 RVA: 0x0027AF53 File Offset: 0x00279153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardRequest Clone()
		{
			return new PhantomBattleBadgeRewardRequest(this);
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x06010F10 RID: 69392 RVA: 0x0027AF5B File Offset: 0x0027915B
		// (set) Token: 0x06010F11 RID: 69393 RVA: 0x0027AF63 File Offset: 0x00279163
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

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x06010F12 RID: 69394 RVA: 0x0027AF6C File Offset: 0x0027916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BadgeRewardId
		{
			get
			{
				return this.badgeRewardId_;
			}
		}

		// Token: 0x06010F13 RID: 69395 RVA: 0x0027AF74 File Offset: 0x00279174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardRequest);
		}

		// Token: 0x06010F14 RID: 69396 RVA: 0x0027AF84 File Offset: 0x00279184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.badgeRewardId_.Equals(other.badgeRewardId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F15 RID: 69397 RVA: 0x0027AFD4 File Offset: 0x002791D4
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

		// Token: 0x06010F16 RID: 69398 RVA: 0x0027B021 File Offset: 0x00279221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F17 RID: 69399 RVA: 0x0027B02E File Offset: 0x0027922E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F18 RID: 69400 RVA: 0x0027B038 File Offset: 0x00279238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.badgeRewardId_.WriteTo(ref output, PhantomBattleBadgeRewardRequest._repeated_badgeRewardId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F19 RID: 69401 RVA: 0x0027B088 File Offset: 0x00279288
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

		// Token: 0x06010F1A RID: 69402 RVA: 0x0027B0DC File Offset: 0x002792DC
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

		// Token: 0x06010F1B RID: 69403 RVA: 0x0027B129 File Offset: 0x00279329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F1C RID: 69404 RVA: 0x0027B134 File Offset: 0x00279334
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
				if (num != 48U && num != 50U)
				{
					if (num != 104U)
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
					this.badgeRewardId_.AddEntriesFrom(ref input, PhantomBattleBadgeRewardRequest._repeated_badgeRewardId_codec);
				}
			}
		}

		// Token: 0x04006B6F RID: 27503
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B70 RID: 27504
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04006B71 RID: 27505
		private int activityId_;

		// Token: 0x04006B72 RID: 27506
		public const int BadgeRewardIdFieldNumber = 6;

		// Token: 0x04006B73 RID: 27507
		private static readonly FieldCodec<int> _repeated_badgeRewardId_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006B74 RID: 27508
		private readonly RepeatedField<int> badgeRewardId_ = new RepeatedField<int>();
	}
}
