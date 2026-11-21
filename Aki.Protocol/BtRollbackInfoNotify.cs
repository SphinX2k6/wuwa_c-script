using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F2 RID: 498
	[NetMessage(EMessageId.BtRollbackInfoNotify)]
	public sealed class BtRollbackInfoNotify : IMessage<BtRollbackInfoNotify>, IMessage, IEquatable<BtRollbackInfoNotify>, IDeepCloneable<BtRollbackInfoNotify>, IBufferMessage
	{
		// Token: 0x060037BE RID: 14270 RVA: 0x0008B905 File Offset: 0x00089B05
		[NullableContext(1)]
		public static BtRollbackInfoNotify Create()
		{
			return new BtRollbackInfoNotify();
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x0008B90C File Offset: 0x00089B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x0008B90F File Offset: 0x00089B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackInfoNotify.Descriptor;
			}
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x0008B916 File Offset: 0x00089B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfoNotify()
		{
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x0008B920 File Offset: 0x00089B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfoNotify(BtRollbackInfoNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.treeInfo_ = ((other.treeInfo_ != null) ? other.treeInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x0008B978 File Offset: 0x00089B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfoNotify Clone()
		{
			return new BtRollbackInfoNotify(this);
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x0008B980 File Offset: 0x00089B80
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x0008B988 File Offset: 0x00089B88
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x0008B991 File Offset: 0x00089B91
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x0008B999 File Offset: 0x00089B99
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

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x0008B9A2 File Offset: 0x00089BA2
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x0008B9AA File Offset: 0x00089BAA
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

		// Token: 0x060037CA RID: 14282 RVA: 0x0008B9B3 File Offset: 0x00089BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackInfoNotify);
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x0008B9C4 File Offset: 0x00089BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackInfoNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && object.Equals(this.TreeInfo, other.TreeInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0008BA24 File Offset: 0x00089C24
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

		// Token: 0x060037CD RID: 14285 RVA: 0x0008BA92 File Offset: 0x00089C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0008BA9F File Offset: 0x00089C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0008BAA8 File Offset: 0x00089CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.treeInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TreeInfo);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0008BB20 File Offset: 0x00089D20
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

		// Token: 0x060037D1 RID: 14289 RVA: 0x0008BB90 File Offset: 0x00089D90
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

		// Token: 0x060037D2 RID: 14290 RVA: 0x0008BC0C File Offset: 0x00089E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x0008BC18 File Offset: 0x00089E18
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
				if (num != 82U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeIncId = input.ReadInt64();
						}
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
		}

		// Token: 0x04002B48 RID: 11080
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B49 RID: 11081
		public const int TreeOwnerIdFieldNumber = 12;

		// Token: 0x04002B4A RID: 11082
		private int treeOwnerId_;

		// Token: 0x04002B4B RID: 11083
		public const int TreeIncIdFieldNumber = 15;

		// Token: 0x04002B4C RID: 11084
		private long treeIncId_;

		// Token: 0x04002B4D RID: 11085
		public const int TreeInfoFieldNumber = 10;

		// Token: 0x04002B4E RID: 11086
		private TreeInfo treeInfo_;
	}
}
