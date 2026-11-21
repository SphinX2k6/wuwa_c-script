using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001511 RID: 5393
	[NetMessage(EMessageId.UpdateNodeProgressNotify)]
	public sealed class UpdateNodeProgressNotify : IMessage<UpdateNodeProgressNotify>, IMessage, IEquatable<UpdateNodeProgressNotify>, IDeepCloneable<UpdateNodeProgressNotify>, IBufferMessage
	{
		// Token: 0x0601C930 RID: 117040 RVA: 0x00424174 File Offset: 0x00422374
		[NullableContext(1)]
		public static UpdateNodeProgressNotify Create()
		{
			return new UpdateNodeProgressNotify();
		}

		// Token: 0x170060A7 RID: 24743
		// (get) Token: 0x0601C931 RID: 117041 RVA: 0x0042417B File Offset: 0x0042237B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060A8 RID: 24744
		// (get) Token: 0x0601C932 RID: 117042 RVA: 0x0042417E File Offset: 0x0042237E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateNodeProgressNotify.Descriptor;
			}
		}

		// Token: 0x0601C933 RID: 117043 RVA: 0x00424185 File Offset: 0x00422385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeProgressNotify()
		{
		}

		// Token: 0x0601C934 RID: 117044 RVA: 0x00424190 File Offset: 0x00422390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeProgressNotify(UpdateNodeProgressNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C935 RID: 117045 RVA: 0x004241F4 File Offset: 0x004223F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateNodeProgressNotify Clone()
		{
			return new UpdateNodeProgressNotify(this);
		}

		// Token: 0x170060A9 RID: 24745
		// (get) Token: 0x0601C936 RID: 117046 RVA: 0x004241FC File Offset: 0x004223FC
		// (set) Token: 0x0601C937 RID: 117047 RVA: 0x00424204 File Offset: 0x00422404
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

		// Token: 0x170060AA RID: 24746
		// (get) Token: 0x0601C938 RID: 117048 RVA: 0x0042420D File Offset: 0x0042240D
		// (set) Token: 0x0601C939 RID: 117049 RVA: 0x00424215 File Offset: 0x00422415
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

		// Token: 0x170060AB RID: 24747
		// (get) Token: 0x0601C93A RID: 117050 RVA: 0x0042421E File Offset: 0x0042241E
		// (set) Token: 0x0601C93B RID: 117051 RVA: 0x00424226 File Offset: 0x00422426
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

		// Token: 0x170060AC RID: 24748
		// (get) Token: 0x0601C93C RID: 117052 RVA: 0x0042422F File Offset: 0x0042242F
		// (set) Token: 0x0601C93D RID: 117053 RVA: 0x00424237 File Offset: 0x00422437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x0601C93E RID: 117054 RVA: 0x00424240 File Offset: 0x00422440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateNodeProgressNotify);
		}

		// Token: 0x0601C93F RID: 117055 RVA: 0x00424250 File Offset: 0x00422450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateNodeProgressNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this.Progress, other.Progress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C940 RID: 117056 RVA: 0x004242C0 File Offset: 0x004224C0
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
			if (this.progress_ != null)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C941 RID: 117057 RVA: 0x00424347 File Offset: 0x00422547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C942 RID: 117058 RVA: 0x00424354 File Offset: 0x00422554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C943 RID: 117059 RVA: 0x00424360 File Offset: 0x00422560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.progress_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Progress);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C944 RID: 117060 RVA: 0x004243F4 File Offset: 0x004225F4
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
			if (this.progress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C945 RID: 117061 RVA: 0x0042447C File Offset: 0x0042267C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateNodeProgressNotify other)
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
			if (other.progress_ != null)
			{
				if (this.progress_ == null)
				{
					this.Progress = new ChildQuestNodeProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C946 RID: 117062 RVA: 0x0042450C File Offset: 0x0042270C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C947 RID: 117063 RVA: 0x00424518 File Offset: 0x00422718
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
				if (num <= 56U)
				{
					if (num == 50U)
					{
						if (this.progress_ == null)
						{
							this.Progress = new ChildQuestNodeProgress();
						}
						input.ReadMessage(this.Progress);
						continue;
					}
					if (num == 56U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A4B1 RID: 42161
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4B2 RID: 42162
		public const int TreeOwnerIdFieldNumber = 11;

		// Token: 0x0400A4B3 RID: 42163
		private int treeOwnerId_;

		// Token: 0x0400A4B4 RID: 42164
		public const int TreeIncIdFieldNumber = 7;

		// Token: 0x0400A4B5 RID: 42165
		private long treeIncId_;

		// Token: 0x0400A4B6 RID: 42166
		public const int NodeIdFieldNumber = 14;

		// Token: 0x0400A4B7 RID: 42167
		private int nodeId_;

		// Token: 0x0400A4B8 RID: 42168
		public const int ProgressFieldNumber = 6;

		// Token: 0x0400A4B9 RID: 42169
		private ChildQuestNodeProgress progress_;
	}
}
