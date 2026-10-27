using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EE RID: 494
	[NetMessage(EMessageId.BtRollbackNotify)]
	public sealed class BtRollbackNotify : IMessage<BtRollbackNotify>, IMessage, IEquatable<BtRollbackNotify>, IDeepCloneable<BtRollbackNotify>, IBufferMessage
	{
		// Token: 0x06003731 RID: 14129 RVA: 0x0008A16D File Offset: 0x0008836D
		[NullableContext(1)]
		public static BtRollbackNotify Create()
		{
			return new BtRollbackNotify();
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x0008A174 File Offset: 0x00088374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x0008A177 File Offset: 0x00088377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackNotify.Descriptor;
			}
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x0008A17E File Offset: 0x0008837E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackNotify()
		{
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x0008A188 File Offset: 0x00088388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackNotify(BtRollbackNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.failNodeId_ = other.failNodeId_;
			this.failReason_ = other.failReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x0008A1DC File Offset: 0x000883DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackNotify Clone()
		{
			return new BtRollbackNotify(this);
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x0008A1E4 File Offset: 0x000883E4
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x0008A1EC File Offset: 0x000883EC
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

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x0008A1F5 File Offset: 0x000883F5
		// (set) Token: 0x0600373A RID: 14138 RVA: 0x0008A1FD File Offset: 0x000883FD
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

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x0008A206 File Offset: 0x00088406
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x0008A20E File Offset: 0x0008840E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FailNodeId
		{
			get
			{
				return this.failNodeId_;
			}
			set
			{
				this.failNodeId_ = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x0008A217 File Offset: 0x00088417
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x0008A21F File Offset: 0x0008841F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailReason FailReason
		{
			get
			{
				return this.failReason_;
			}
			set
			{
				this.failReason_ = value;
			}
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x0008A228 File Offset: 0x00088428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackNotify);
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x0008A238 File Offset: 0x00088438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.FailNodeId == other.FailNodeId && this.FailReason == other.FailReason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x0008A2A4 File Offset: 0x000884A4
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
			if (this.FailNodeId != 0)
			{
				num ^= this.FailNodeId.GetHashCode();
			}
			if (this.FailReason != FailReason.DefaultFail)
			{
				num ^= this.FailReason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x0008A334 File Offset: 0x00088534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x0008A341 File Offset: 0x00088541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x0008A34C File Offset: 0x0008854C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.FailNodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FailNodeId);
			}
			if (this.FailReason != FailReason.DefaultFail)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.FailReason);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x0008A3DC File Offset: 0x000885DC
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
			if (this.FailNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FailNodeId);
			}
			if (this.FailReason != FailReason.DefaultFail)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FailReason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x0008A464 File Offset: 0x00088664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtRollbackNotify other)
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
			if (other.FailNodeId != 0)
			{
				this.FailNodeId = other.FailNodeId;
			}
			if (other.FailReason != FailReason.DefaultFail)
			{
				this.FailReason = other.FailReason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0008A4DC File Offset: 0x000886DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0008A4E8 File Offset: 0x000886E8
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.FailNodeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.FailReason = (FailReason)input.ReadEnum();
						continue;
					}
					if (num == 96U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002ACF RID: 10959
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AD0 RID: 10960
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002AD1 RID: 10961
		private int treeOwnerId_;

		// Token: 0x04002AD2 RID: 10962
		public const int TreeIncIdFieldNumber = 12;

		// Token: 0x04002AD3 RID: 10963
		private long treeIncId_;

		// Token: 0x04002AD4 RID: 10964
		public const int FailNodeIdFieldNumber = 3;

		// Token: 0x04002AD5 RID: 10965
		private int failNodeId_;

		// Token: 0x04002AD6 RID: 10966
		public const int FailReasonFieldNumber = 11;

		// Token: 0x04002AD7 RID: 10967
		private FailReason failReason_;
	}
}
