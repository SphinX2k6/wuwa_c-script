using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F6 RID: 502
	[NetMessage(EMessageId.BtRollbackStartNotify)]
	public sealed class BtRollbackStartNotify : IMessage<BtRollbackStartNotify>, IMessage, IEquatable<BtRollbackStartNotify>, IDeepCloneable<BtRollbackStartNotify>, IBufferMessage
	{
		// Token: 0x06003816 RID: 14358 RVA: 0x0008C69D File Offset: 0x0008A89D
		[NullableContext(1)]
		public static BtRollbackStartNotify Create()
		{
			return new BtRollbackStartNotify();
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x0008C6A4 File Offset: 0x0008A8A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x0008C6A7 File Offset: 0x0008A8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackStartNotify.Descriptor;
			}
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x0008C6AE File Offset: 0x0008A8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackStartNotify()
		{
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x0008C6B8 File Offset: 0x0008A8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackStartNotify(BtRollbackStartNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.isRollbackSubLevel_ = other.isRollbackSubLevel_;
			this.isRollbackPos_ = other.isRollbackPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x0008C70C File Offset: 0x0008A90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackStartNotify Clone()
		{
			return new BtRollbackStartNotify(this);
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x0008C714 File Offset: 0x0008A914
		// (set) Token: 0x0600381D RID: 14365 RVA: 0x0008C71C File Offset: 0x0008A91C
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

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x0008C725 File Offset: 0x0008A925
		// (set) Token: 0x0600381F RID: 14367 RVA: 0x0008C72D File Offset: 0x0008A92D
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

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x0008C736 File Offset: 0x0008A936
		// (set) Token: 0x06003821 RID: 14369 RVA: 0x0008C73E File Offset: 0x0008A93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRollbackSubLevel
		{
			get
			{
				return this.isRollbackSubLevel_;
			}
			set
			{
				this.isRollbackSubLevel_ = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x0008C747 File Offset: 0x0008A947
		// (set) Token: 0x06003823 RID: 14371 RVA: 0x0008C74F File Offset: 0x0008A94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRollbackPos
		{
			get
			{
				return this.isRollbackPos_;
			}
			set
			{
				this.isRollbackPos_ = value;
			}
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x0008C758 File Offset: 0x0008A958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackStartNotify);
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x0008C768 File Offset: 0x0008A968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackStartNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.IsRollbackSubLevel == other.IsRollbackSubLevel && this.IsRollbackPos == other.IsRollbackPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x0008C7D4 File Offset: 0x0008A9D4
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
			if (this.IsRollbackSubLevel)
			{
				num ^= this.IsRollbackSubLevel.GetHashCode();
			}
			if (this.IsRollbackPos)
			{
				num ^= this.IsRollbackPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x0008C85E File Offset: 0x0008AA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x0008C86B File Offset: 0x0008AA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x0008C874 File Offset: 0x0008AA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.IsRollbackSubLevel)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsRollbackSubLevel);
			}
			if (this.IsRollbackPos)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsRollbackPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x0008C908 File Offset: 0x0008AB08
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
			if (this.IsRollbackSubLevel)
			{
				num += 2;
			}
			if (this.IsRollbackPos)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x0008C978 File Offset: 0x0008AB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRollbackStartNotify other)
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
			if (other.IsRollbackSubLevel)
			{
				this.IsRollbackSubLevel = other.IsRollbackSubLevel;
			}
			if (other.IsRollbackPos)
			{
				this.IsRollbackPos = other.IsRollbackPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x0008C9F0 File Offset: 0x0008ABF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x0008C9FC File Offset: 0x0008ABFC
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
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.IsRollbackSubLevel = input.ReadBool();
						continue;
					}
					if (num == 88U)
					{
						this.IsRollbackPos = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B64 RID: 11108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B65 RID: 11109
		public const int TreeOwnerIdFieldNumber = 4;

		// Token: 0x04002B66 RID: 11110
		private int treeOwnerId_;

		// Token: 0x04002B67 RID: 11111
		public const int TreeIncIdFieldNumber = 8;

		// Token: 0x04002B68 RID: 11112
		private long treeIncId_;

		// Token: 0x04002B69 RID: 11113
		public const int IsRollbackSubLevelFieldNumber = 10;

		// Token: 0x04002B6A RID: 11114
		private bool isRollbackSubLevel_;

		// Token: 0x04002B6B RID: 11115
		public const int IsRollbackPosFieldNumber = 11;

		// Token: 0x04002B6C RID: 11116
		private bool isRollbackPos_;
	}
}
