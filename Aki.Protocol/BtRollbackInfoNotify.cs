using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001ED RID: 493
	[NetMessage(EMessageId.BtRollbackInfoNotify)]
	public sealed class BtRollbackInfoNotify : IMessage<BtRollbackInfoNotify>, IMessage, IEquatable<BtRollbackInfoNotify>, IDeepCloneable<BtRollbackInfoNotify>, IBufferMessage
	{
		// Token: 0x0600371B RID: 14107 RVA: 0x00089DE1 File Offset: 0x00087FE1
		[NullableContext(1)]
		public static BtRollbackInfoNotify Create()
		{
			return new BtRollbackInfoNotify();
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x00089DE8 File Offset: 0x00087FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x00089DEB File Offset: 0x00087FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00089DF2 File Offset: 0x00087FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfoNotify()
		{
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00089DFC File Offset: 0x00087FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfoNotify(BtRollbackInfoNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.treeInfo_ = ((other.treeInfo_ != null) ? other.treeInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00089E54 File Offset: 0x00088054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfoNotify Clone()
		{
			return new BtRollbackInfoNotify(this);
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x00089E5C File Offset: 0x0008805C
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x00089E64 File Offset: 0x00088064
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

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x00089E6D File Offset: 0x0008806D
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x00089E75 File Offset: 0x00088075
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

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x00089E7E File Offset: 0x0008807E
		// (set) Token: 0x06003726 RID: 14118 RVA: 0x00089E86 File Offset: 0x00088086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreeInfo TreeInfo
		{
			get
			{
				return this.treeInfo_;
			}
			set
			{
				this.treeInfo_ = value;
			}
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00089E8F File Offset: 0x0008808F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackInfoNotify);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00089EA0 File Offset: 0x000880A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackInfoNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && object.Equals(this.TreeInfo, other.TreeInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00089F00 File Offset: 0x00088100
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
			if (this.treeInfo_ != null)
			{
				num ^= this.TreeInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00089F6E File Offset: 0x0008816E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00089F7B File Offset: 0x0008817B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00089F84 File Offset: 0x00088184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.treeInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TreeInfo);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00089FF8 File Offset: 0x000881F8
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
			if (this.treeInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TreeInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x0008A068 File Offset: 0x00088268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRollbackInfoNotify other)
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
			if (other.treeInfo_ != null)
			{
				if (this.treeInfo_ == null)
				{
					this.TreeInfo = new TreeInfo();
				}
				this.TreeInfo.MergeFrom(other.TreeInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0008A0E4 File Offset: 0x000882E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x0008A0F0 File Offset: 0x000882F0
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
					if (num != 50U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeOwnerId = input.ReadInt32();
						}
					}
					else
					{
						if (this.treeInfo_ == null)
						{
							this.TreeInfo = new TreeInfo();
						}
						input.ReadMessage(this.TreeInfo);
					}
				}
				else
				{
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002AC8 RID: 10952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AC9 RID: 10953
		public const int TreeOwnerIdFieldNumber = 12;

		// Token: 0x04002ACA RID: 10954
		private int treeOwnerId_;

		// Token: 0x04002ACB RID: 10955
		public const int TreeIncIdFieldNumber = 1;

		// Token: 0x04002ACC RID: 10956
		private long treeIncId_;

		// Token: 0x04002ACD RID: 10957
		public const int TreeInfoFieldNumber = 6;

		// Token: 0x04002ACE RID: 10958
		private TreeInfo treeInfo_;
	}
}
