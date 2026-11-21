using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000139 RID: 313
	[NetMessage(EMessageId.AvoidBlockSubmitOverNodeRequest)]
	public sealed class AvoidBlockSubmitOverNodeRequest : IMessage<AvoidBlockSubmitOverNodeRequest>, IMessage, IEquatable<AvoidBlockSubmitOverNodeRequest>, IDeepCloneable<AvoidBlockSubmitOverNodeRequest>, IBufferMessage
	{
		// Token: 0x06002922 RID: 10530 RVA: 0x0006C4E8 File Offset: 0x0006A6E8
		[NullableContext(1)]
		public static AvoidBlockSubmitOverNodeRequest Create()
		{
			return new AvoidBlockSubmitOverNodeRequest();
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x0006C4EF File Offset: 0x0006A6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x0006C4F2 File Offset: 0x0006A6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvoidBlockSubmitOverNodeRequest.Descriptor;
			}
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x0006C4F9 File Offset: 0x0006A6F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeRequest()
		{
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0006C504 File Offset: 0x0006A704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeRequest(AvoidBlockSubmitOverNodeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.win_ = other.win_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0006C564 File Offset: 0x0006A764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvoidBlockSubmitOverNodeRequest Clone()
		{
			return new AvoidBlockSubmitOverNodeRequest(this);
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x0006C56C File Offset: 0x0006A76C
		// (set) Token: 0x06002929 RID: 10537 RVA: 0x0006C574 File Offset: 0x0006A774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x0006C57D File Offset: 0x0006A77D
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x0006C585 File Offset: 0x0006A785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x0006C58E File Offset: 0x0006A78E
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x0006C596 File Offset: 0x0006A796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x0006C59F File Offset: 0x0006A79F
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x0006C5A7 File Offset: 0x0006A7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x0006C5B0 File Offset: 0x0006A7B0
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x0006C5B8 File Offset: 0x0006A7B8
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

		// Token: 0x06002932 RID: 10546 RVA: 0x0006C5C1 File Offset: 0x0006A7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvoidBlockSubmitOverNodeRequest);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0006C5D0 File Offset: 0x0006A7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvoidBlockSubmitOverNodeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.Win == other.Win && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0006C64C File Offset: 0x0006A84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0006C6EF File Offset: 0x0006A8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x0006C6FC File Offset: 0x0006A8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x0006C708 File Offset: 0x0006A908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.Win)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Win);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.NodeId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x0006C7B8 File Offset: 0x0006A9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this.Win)
			{
				num += 2;
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x0006C84C File Offset: 0x0006AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvoidBlockSubmitOverNodeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x0006C8D8 File Offset: 0x0006AAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x0006C8E4 File Offset: 0x0006AAE4
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Win = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400272E RID: 10030
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400272F RID: 10031
		public const int TreeOwnerIdFieldNumber = 4;

		// Token: 0x04002730 RID: 10032
		private int treeOwnerId_;

		// Token: 0x04002731 RID: 10033
		public const int TreeIncIdFieldNumber = 3;

		// Token: 0x04002732 RID: 10034
		private long treeIncId_;

		// Token: 0x04002733 RID: 10035
		public const int NodeIdFieldNumber = 10;

		// Token: 0x04002734 RID: 10036
		private int nodeId_;

		// Token: 0x04002735 RID: 10037
		public const int WinFieldNumber = 9;

		// Token: 0x04002736 RID: 10038
		private bool win_;

		// Token: 0x04002737 RID: 10039
		public const int ScoreFieldNumber = 15;

		// Token: 0x04002738 RID: 10040
		private int score_;
	}
}
