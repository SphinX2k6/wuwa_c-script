using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072A RID: 1834
	public sealed class H5CircumFluenceActivityData : IMessage<H5CircumFluenceActivityData>, IMessage, IEquatable<H5CircumFluenceActivityData>, IDeepCloneable<H5CircumFluenceActivityData>, IBufferMessage
	{
		// Token: 0x0600A682 RID: 42626 RVA: 0x001914CF File Offset: 0x0018F6CF
		[NullableContext(1)]
		public static H5CircumFluenceActivityData Create()
		{
			return new H5CircumFluenceActivityData();
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x0600A683 RID: 42627 RVA: 0x001914D6 File Offset: 0x0018F6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x0600A684 RID: 42628 RVA: 0x001914D9 File Offset: 0x0018F6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityData.Descriptor;
			}
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x001914E0 File Offset: 0x0018F6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityData()
		{
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x001914F4 File Offset: 0x0018F6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityData(H5CircumFluenceActivityData other) : this()
		{
			this.inviteCode_ = other.inviteCode_;
			this.score_ = other.score_;
			this.redDot_ = other.redDot_;
			this.allRewardClaimed_ = other.allRewardClaimed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x00191548 File Offset: 0x0018F748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityData Clone()
		{
			return new H5CircumFluenceActivityData(this);
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x0600A688 RID: 42632 RVA: 0x00191550 File Offset: 0x0018F750
		// (set) Token: 0x0600A689 RID: 42633 RVA: 0x00191558 File Offset: 0x0018F758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string InviteCode
		{
			get
			{
				return this.inviteCode_;
			}
			set
			{
				this.inviteCode_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x0600A68A RID: 42634 RVA: 0x0019156B File Offset: 0x0018F76B
		// (set) Token: 0x0600A68B RID: 42635 RVA: 0x00191573 File Offset: 0x0018F773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x0600A68C RID: 42636 RVA: 0x0019157C File Offset: 0x0018F77C
		// (set) Token: 0x0600A68D RID: 42637 RVA: 0x00191584 File Offset: 0x0018F784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RedDot
		{
			get
			{
				return this.redDot_;
			}
			set
			{
				this.redDot_ = value;
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x0600A68E RID: 42638 RVA: 0x0019158D File Offset: 0x0018F78D
		// (set) Token: 0x0600A68F RID: 42639 RVA: 0x00191595 File Offset: 0x0018F795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AllRewardClaimed
		{
			get
			{
				return this.allRewardClaimed_;
			}
			set
			{
				this.allRewardClaimed_ = value;
			}
		}

		// Token: 0x0600A690 RID: 42640 RVA: 0x0019159E File Offset: 0x0018F79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityData);
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x001915AC File Offset: 0x0018F7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityData other)
		{
			return other != null && (other == this || (!(this.InviteCode != other.InviteCode) && this.Score == other.Score && this.RedDot == other.RedDot && this.AllRewardClaimed == other.AllRewardClaimed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A692 RID: 42642 RVA: 0x0019161C File Offset: 0x0018F81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InviteCode.Length != 0)
			{
				num ^= this.InviteCode.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.RedDot)
			{
				num ^= this.RedDot.GetHashCode();
			}
			if (this.AllRewardClaimed)
			{
				num ^= this.AllRewardClaimed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x001916A8 File Offset: 0x0018F8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x001916B5 File Offset: 0x0018F8B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x001916C0 File Offset: 0x0018F8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InviteCode.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.InviteCode);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.RedDot)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.RedDot);
			}
			if (this.AllRewardClaimed)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.AllRewardClaimed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A696 RID: 42646 RVA: 0x00191758 File Offset: 0x0018F958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InviteCode.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.InviteCode);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.RedDot)
			{
				num += 2;
			}
			if (this.AllRewardClaimed)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x001917CC File Offset: 0x0018F9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(H5CircumFluenceActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InviteCode.Length != 0)
			{
				this.InviteCode = other.InviteCode;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.RedDot)
			{
				this.RedDot = other.RedDot;
			}
			if (other.AllRewardClaimed)
			{
				this.AllRewardClaimed = other.AllRewardClaimed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A698 RID: 42648 RVA: 0x00191849 File Offset: 0x0018FA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x00191854 File Offset: 0x0018FA54
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.InviteCode = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RedDot = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.AllRewardClaimed = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004C5B RID: 19547
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C5C RID: 19548
		public const int InviteCodeFieldNumber = 1;

		// Token: 0x04004C5D RID: 19549
		private string inviteCode_ = "";

		// Token: 0x04004C5E RID: 19550
		public const int ScoreFieldNumber = 2;

		// Token: 0x04004C5F RID: 19551
		private int score_;

		// Token: 0x04004C60 RID: 19552
		public const int RedDotFieldNumber = 3;

		// Token: 0x04004C61 RID: 19553
		private bool redDot_;

		// Token: 0x04004C62 RID: 19554
		public const int AllRewardClaimedFieldNumber = 4;

		// Token: 0x04004C63 RID: 19555
		private bool allRewardClaimed_;
	}
}
