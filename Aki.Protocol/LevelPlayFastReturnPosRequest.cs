using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E7 RID: 2279
	[NetMessage(EMessageId.LevelPlayFastReturnPosRequest)]
	public sealed class LevelPlayFastReturnPosRequest : IMessage<LevelPlayFastReturnPosRequest>, IMessage, IEquatable<LevelPlayFastReturnPosRequest>, IDeepCloneable<LevelPlayFastReturnPosRequest>, IBufferMessage
	{
		// Token: 0x0600C9CA RID: 51658 RVA: 0x001DCD98 File Offset: 0x001DAF98
		[NullableContext(1)]
		public static LevelPlayFastReturnPosRequest Create()
		{
			return new LevelPlayFastReturnPosRequest();
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x0600C9CB RID: 51659 RVA: 0x001DCD9F File Offset: 0x001DAF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x0600C9CC RID: 51660 RVA: 0x001DCDA2 File Offset: 0x001DAFA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayFastReturnPosRequest.Descriptor;
			}
		}

		// Token: 0x0600C9CD RID: 51661 RVA: 0x001DCDA9 File Offset: 0x001DAFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosRequest()
		{
		}

		// Token: 0x0600C9CE RID: 51662 RVA: 0x001DCDB4 File Offset: 0x001DAFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosRequest(LevelPlayFastReturnPosRequest other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C9CF RID: 51663 RVA: 0x001DCE08 File Offset: 0x001DB008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosRequest Clone()
		{
			return new LevelPlayFastReturnPosRequest(this);
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x0600C9D0 RID: 51664 RVA: 0x001DCE10 File Offset: 0x001DB010
		// (set) Token: 0x0600C9D1 RID: 51665 RVA: 0x001DCE18 File Offset: 0x001DB018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x0600C9D2 RID: 51666 RVA: 0x001DCE21 File Offset: 0x001DB021
		// (set) Token: 0x0600C9D3 RID: 51667 RVA: 0x001DCE29 File Offset: 0x001DB029
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

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x0600C9D4 RID: 51668 RVA: 0x001DCE32 File Offset: 0x001DB032
		// (set) Token: 0x0600C9D5 RID: 51669 RVA: 0x001DCE3A File Offset: 0x001DB03A
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

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x0600C9D6 RID: 51670 RVA: 0x001DCE43 File Offset: 0x001DB043
		// (set) Token: 0x0600C9D7 RID: 51671 RVA: 0x001DCE4B File Offset: 0x001DB04B
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

		// Token: 0x0600C9D8 RID: 51672 RVA: 0x001DCE54 File Offset: 0x001DB054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayFastReturnPosRequest);
		}

		// Token: 0x0600C9D9 RID: 51673 RVA: 0x001DCE64 File Offset: 0x001DB064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayFastReturnPosRequest other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x001DCED0 File Offset: 0x001DB0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C9DB RID: 51675 RVA: 0x001DCF5A File Offset: 0x001DB15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C9DC RID: 51676 RVA: 0x001DCF67 File Offset: 0x001DB167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x001DCF70 File Offset: 0x001DB170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.NodeId);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C9DE RID: 51678 RVA: 0x001DD004 File Offset: 0x001DB204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C9DF RID: 51679 RVA: 0x001DD08C File Offset: 0x001DB28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayFastReturnPosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C9E0 RID: 51680 RVA: 0x001DD104 File Offset: 0x001DB304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C9E1 RID: 51681 RVA: 0x001DD110 File Offset: 0x001DB310
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
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.LevelPlayId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005649 RID: 22089
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400564A RID: 22090
		public const int LevelPlayIdFieldNumber = 7;

		// Token: 0x0400564B RID: 22091
		private int levelPlayId_;

		// Token: 0x0400564C RID: 22092
		public const int TreeOwnerIdFieldNumber = 3;

		// Token: 0x0400564D RID: 22093
		private int treeOwnerId_;

		// Token: 0x0400564E RID: 22094
		public const int TreeIncIdFieldNumber = 8;

		// Token: 0x0400564F RID: 22095
		private long treeIncId_;

		// Token: 0x04005650 RID: 22096
		public const int NodeIdFieldNumber = 4;

		// Token: 0x04005651 RID: 22097
		private int nodeId_;
	}
}
