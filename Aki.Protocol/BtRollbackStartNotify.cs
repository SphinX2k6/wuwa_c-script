using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F1 RID: 497
	[NetMessage(EMessageId.BtRollbackStartNotify)]
	public sealed class BtRollbackStartNotify : IMessage<BtRollbackStartNotify>, IMessage, IEquatable<BtRollbackStartNotify>, IDeepCloneable<BtRollbackStartNotify>, IBufferMessage
	{
		// Token: 0x06003771 RID: 14193 RVA: 0x0008AA8C File Offset: 0x00088C8C
		[NullableContext(1)]
		public static BtRollbackStartNotify Create()
		{
			return new BtRollbackStartNotify();
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x0008AA93 File Offset: 0x00088C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06003773 RID: 14195 RVA: 0x0008AA96 File Offset: 0x00088C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackStartNotify.Descriptor;
			}
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x0008AA9D File Offset: 0x00088C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackStartNotify()
		{
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x0008AAA8 File Offset: 0x00088CA8
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

		// Token: 0x06003776 RID: 14198 RVA: 0x0008AAFC File Offset: 0x00088CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackStartNotify Clone()
		{
			return new BtRollbackStartNotify(this);
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x0008AB04 File Offset: 0x00088D04
		// (set) Token: 0x06003778 RID: 14200 RVA: 0x0008AB0C File Offset: 0x00088D0C
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

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x0008AB15 File Offset: 0x00088D15
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x0008AB1D File Offset: 0x00088D1D
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

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x0008AB26 File Offset: 0x00088D26
		// (set) Token: 0x0600377C RID: 14204 RVA: 0x0008AB2E File Offset: 0x00088D2E
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

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x0008AB37 File Offset: 0x00088D37
		// (set) Token: 0x0600377E RID: 14206 RVA: 0x0008AB3F File Offset: 0x00088D3F
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

		// Token: 0x0600377F RID: 14207 RVA: 0x0008AB48 File Offset: 0x00088D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackStartNotify);
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x0008AB58 File Offset: 0x00088D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackStartNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.IsRollbackSubLevel == other.IsRollbackSubLevel && this.IsRollbackPos == other.IsRollbackPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x0008ABC4 File Offset: 0x00088DC4
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

		// Token: 0x06003782 RID: 14210 RVA: 0x0008AC4E File Offset: 0x00088E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x0008AC5B File Offset: 0x00088E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0008AC64 File Offset: 0x00088E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.IsRollbackPos)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsRollbackPos);
			}
			if (this.IsRollbackSubLevel)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsRollbackSubLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x0008ACF8 File Offset: 0x00088EF8
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

		// Token: 0x06003786 RID: 14214 RVA: 0x0008AD68 File Offset: 0x00088F68
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

		// Token: 0x06003787 RID: 14215 RVA: 0x0008ADE0 File Offset: 0x00088FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x0008ADEC File Offset: 0x00088FEC
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
					if (num == 16U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.IsRollbackPos = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsRollbackSubLevel = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002AE2 RID: 10978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AE3 RID: 10979
		public const int TreeOwnerIdFieldNumber = 3;

		// Token: 0x04002AE4 RID: 10980
		private int treeOwnerId_;

		// Token: 0x04002AE5 RID: 10981
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x04002AE6 RID: 10982
		private long treeIncId_;

		// Token: 0x04002AE7 RID: 10983
		public const int IsRollbackSubLevelFieldNumber = 5;

		// Token: 0x04002AE8 RID: 10984
		private bool isRollbackSubLevel_;

		// Token: 0x04002AE9 RID: 10985
		public const int IsRollbackPosFieldNumber = 4;

		// Token: 0x04002AEA RID: 10986
		private bool isRollbackPos_;
	}
}
