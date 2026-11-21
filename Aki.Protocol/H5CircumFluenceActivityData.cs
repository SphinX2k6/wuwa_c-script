using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000716 RID: 1814
	public sealed class H5CircumFluenceActivityData : IMessage<H5CircumFluenceActivityData>, IMessage, IEquatable<H5CircumFluenceActivityData>, IDeepCloneable<H5CircumFluenceActivityData>, IBufferMessage
	{
		// Token: 0x0600A52C RID: 42284 RVA: 0x0018EA9B File Offset: 0x0018CC9B
		[NullableContext(1)]
		public static H5CircumFluenceActivityData Create()
		{
			return new H5CircumFluenceActivityData();
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x0600A52D RID: 42285 RVA: 0x0018EAA2 File Offset: 0x0018CCA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x0600A52E RID: 42286 RVA: 0x0018EAA5 File Offset: 0x0018CCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return H5CircumFluenceActivityData.Descriptor;
			}
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x0018EAAC File Offset: 0x0018CCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityData()
		{
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x0018EAC0 File Offset: 0x0018CCC0
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

		// Token: 0x0600A531 RID: 42289 RVA: 0x0018EB14 File Offset: 0x0018CD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public H5CircumFluenceActivityData Clone()
		{
			return new H5CircumFluenceActivityData(this);
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x0600A532 RID: 42290 RVA: 0x0018EB1C File Offset: 0x0018CD1C
		// (set) Token: 0x0600A533 RID: 42291 RVA: 0x0018EB24 File Offset: 0x0018CD24
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

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x0600A534 RID: 42292 RVA: 0x0018EB37 File Offset: 0x0018CD37
		// (set) Token: 0x0600A535 RID: 42293 RVA: 0x0018EB3F File Offset: 0x0018CD3F
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

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x0600A536 RID: 42294 RVA: 0x0018EB48 File Offset: 0x0018CD48
		// (set) Token: 0x0600A537 RID: 42295 RVA: 0x0018EB50 File Offset: 0x0018CD50
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

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x0600A538 RID: 42296 RVA: 0x0018EB59 File Offset: 0x0018CD59
		// (set) Token: 0x0600A539 RID: 42297 RVA: 0x0018EB61 File Offset: 0x0018CD61
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

		// Token: 0x0600A53A RID: 42298 RVA: 0x0018EB6A File Offset: 0x0018CD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as H5CircumFluenceActivityData);
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x0018EB78 File Offset: 0x0018CD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(H5CircumFluenceActivityData other)
		{
			return other != null && (other == this || (!(this.InviteCode != other.InviteCode) && this.Score == other.Score && this.RedDot == other.RedDot && this.AllRewardClaimed == other.AllRewardClaimed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x0018EBE8 File Offset: 0x0018CDE8
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

		// Token: 0x0600A53D RID: 42301 RVA: 0x0018EC74 File Offset: 0x0018CE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x0018EC81 File Offset: 0x0018CE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x0018EC8C File Offset: 0x0018CE8C
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

		// Token: 0x0600A540 RID: 42304 RVA: 0x0018ED24 File Offset: 0x0018CF24
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

		// Token: 0x0600A541 RID: 42305 RVA: 0x0018ED98 File Offset: 0x0018CF98
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

		// Token: 0x0600A542 RID: 42306 RVA: 0x0018EE15 File Offset: 0x0018D015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x0018EE20 File Offset: 0x0018D020
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

		// Token: 0x04004C54 RID: 19540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C55 RID: 19541
		public const int InviteCodeFieldNumber = 1;

		// Token: 0x04004C56 RID: 19542
		private string inviteCode_ = "";

		// Token: 0x04004C57 RID: 19543
		public const int ScoreFieldNumber = 2;

		// Token: 0x04004C58 RID: 19544
		private int score_;

		// Token: 0x04004C59 RID: 19545
		public const int RedDotFieldNumber = 3;

		// Token: 0x04004C5A RID: 19546
		private bool redDot_;

		// Token: 0x04004C5B RID: 19547
		public const int AllRewardClaimedFieldNumber = 4;

		// Token: 0x04004C5C RID: 19548
		private bool allRewardClaimed_;
	}
}
