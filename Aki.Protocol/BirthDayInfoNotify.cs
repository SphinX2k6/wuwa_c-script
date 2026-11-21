using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019E RID: 414
	[NetMessage(EMessageId.BirthDayInfoNotify)]
	public sealed class BirthDayInfoNotify : IMessage<BirthDayInfoNotify>, IMessage, IEquatable<BirthDayInfoNotify>, IDeepCloneable<BirthDayInfoNotify>, IBufferMessage
	{
		// Token: 0x06003114 RID: 12564 RVA: 0x0007D431 File Offset: 0x0007B631
		[NullableContext(1)]
		public static BirthDayInfoNotify Create()
		{
			return new BirthDayInfoNotify();
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x0007D438 File Offset: 0x0007B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x0007D43B File Offset: 0x0007B63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayInfoNotify.Descriptor;
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x0007D442 File Offset: 0x0007B642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayInfoNotify()
		{
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0007D458 File Offset: 0x0007B658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayInfoNotify(BirthDayInfoNotify other) : this()
		{
			this.birthDayReset_ = other.birthDayReset_;
			this.recentRewardTime_ = other.recentRewardTime_;
			this.roles_ = other.roles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x0007D4A5 File Offset: 0x0007B6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayInfoNotify Clone()
		{
			return new BirthDayInfoNotify(this);
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x0007D4AD File Offset: 0x0007B6AD
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x0007D4B5 File Offset: 0x0007B6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BirthDayReset
		{
			get
			{
				return this.birthDayReset_;
			}
			set
			{
				this.birthDayReset_ = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x0007D4BE File Offset: 0x0007B6BE
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x0007D4C6 File Offset: 0x0007B6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecentRewardTime
		{
			get
			{
				return this.recentRewardTime_;
			}
			set
			{
				this.recentRewardTime_ = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x0007D4CF File Offset: 0x0007B6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BirthRoleSelect> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x0007D4D7 File Offset: 0x0007B6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayInfoNotify);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x0007D4E8 File Offset: 0x0007B6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayInfoNotify other)
		{
			return other != null && (other == this || (this.BirthDayReset == other.BirthDayReset && this.RecentRewardTime == other.RecentRewardTime && this.roles_.Equals(other.roles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x0007D548 File Offset: 0x0007B748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BirthDayReset)
			{
				num ^= this.BirthDayReset.GetHashCode();
			}
			if (this.RecentRewardTime != 0)
			{
				num ^= this.RecentRewardTime.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x0007D5AE File Offset: 0x0007B7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x0007D5BB File Offset: 0x0007B7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x0007D5C4 File Offset: 0x0007B7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecentRewardTime != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecentRewardTime);
			}
			if (this.BirthDayReset)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.BirthDayReset);
			}
			this.roles_.WriteTo(ref output, BirthDayInfoNotify._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x0007D630 File Offset: 0x0007B830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BirthDayReset)
			{
				num += 2;
			}
			if (this.RecentRewardTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecentRewardTime);
			}
			num += this.roles_.CalculateSize(BirthDayInfoNotify._repeated_roles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x0007D690 File Offset: 0x0007B890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BirthDayReset)
			{
				this.BirthDayReset = other.BirthDayReset;
			}
			if (other.RecentRewardTime != 0)
			{
				this.RecentRewardTime = other.RecentRewardTime;
			}
			this.roles_.Add(other.roles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x0007D6F1 File Offset: 0x0007B8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x0007D6FC File Offset: 0x0007B8FC
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
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.roles_.AddEntriesFrom(ref input, BirthDayInfoNotify._repeated_roles_codec);
						}
					}
					else
					{
						this.BirthDayReset = input.ReadBool();
					}
				}
				else
				{
					this.RecentRewardTime = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002973 RID: 10611
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002974 RID: 10612
		public const int BirthDayResetFieldNumber = 2;

		// Token: 0x04002975 RID: 10613
		private bool birthDayReset_;

		// Token: 0x04002976 RID: 10614
		public const int RecentRewardTimeFieldNumber = 1;

		// Token: 0x04002977 RID: 10615
		private int recentRewardTime_;

		// Token: 0x04002978 RID: 10616
		public const int RolesFieldNumber = 11;

		// Token: 0x04002979 RID: 10617
		private static readonly FieldCodec<BirthRoleSelect> _repeated_roles_codec = FieldCodec.ForMessage<BirthRoleSelect>(90U, BirthRoleSelect.Parser);

		// Token: 0x0400297A RID: 10618
		private readonly RepeatedField<BirthRoleSelect> roles_ = new RepeatedField<BirthRoleSelect>();
	}
}
