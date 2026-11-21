using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F3 RID: 499
	[NetMessage(EMessageId.BtRollbackNotify)]
	public sealed class BtRollbackNotify : IMessage<BtRollbackNotify>, IMessage, IEquatable<BtRollbackNotify>, IDeepCloneable<BtRollbackNotify>, IBufferMessage
	{
		// Token: 0x060037D4 RID: 14292 RVA: 0x0008BC96 File Offset: 0x00089E96
		[NullableContext(1)]
		public static BtRollbackNotify Create()
		{
			return new BtRollbackNotify();
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x0008BC9D File Offset: 0x00089E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060037D6 RID: 14294 RVA: 0x0008BCA0 File Offset: 0x00089EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtRollbackNotify.Descriptor;
			}
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0008BCA7 File Offset: 0x00089EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackNotify()
		{
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0008BCB0 File Offset: 0x00089EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackNotify(BtRollbackNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.btRollbackInfo_ = ((other.btRollbackInfo_ != null) ? other.btRollbackInfo_.Clone() : null);
			this.failNodeId_ = other.failNodeId_;
			this.failReason_ = other.failReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x0008BD20 File Offset: 0x00089F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackNotify Clone()
		{
			return new BtRollbackNotify(this);
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x0008BD28 File Offset: 0x00089F28
		// (set) Token: 0x060037DB RID: 14299 RVA: 0x0008BD30 File Offset: 0x00089F30
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x0008BD39 File Offset: 0x00089F39
		// (set) Token: 0x060037DD RID: 14301 RVA: 0x0008BD41 File Offset: 0x00089F41
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

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x0008BD4A File Offset: 0x00089F4A
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x0008BD52 File Offset: 0x00089F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtRollbackInfo BtRollbackInfo
		{
			get
			{
				return this.btRollbackInfo_;
			}
			set
			{
				this.btRollbackInfo_ = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x0008BD5B File Offset: 0x00089F5B
		// (set) Token: 0x060037E1 RID: 14305 RVA: 0x0008BD63 File Offset: 0x00089F63
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x0008BD6C File Offset: 0x00089F6C
		// (set) Token: 0x060037E3 RID: 14307 RVA: 0x0008BD74 File Offset: 0x00089F74
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

		// Token: 0x060037E4 RID: 14308 RVA: 0x0008BD7D File Offset: 0x00089F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtRollbackNotify);
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x0008BD8C File Offset: 0x00089F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtRollbackNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && object.Equals(this.BtRollbackInfo, other.BtRollbackInfo) && this.FailNodeId == other.FailNodeId && this.FailReason == other.FailReason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x0008BE0C File Offset: 0x0008A00C
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
			if (this.btRollbackInfo_ != null)
			{
				num ^= this.BtRollbackInfo.GetHashCode();
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

		// Token: 0x060037E7 RID: 14311 RVA: 0x0008BEB2 File Offset: 0x0008A0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x0008BEBF File Offset: 0x0008A0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x0008BEC8 File Offset: 0x0008A0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.btRollbackInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BtRollbackInfo);
			}
			if (this.FailReason != FailReason.DefaultFail)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.FailReason);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.FailNodeId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.FailNodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x0008BF78 File Offset: 0x0008A178
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
			if (this.btRollbackInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BtRollbackInfo);
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

		// Token: 0x060037EB RID: 14315 RVA: 0x0008C018 File Offset: 0x0008A218
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
			if (other.btRollbackInfo_ != null)
			{
				if (this.btRollbackInfo_ == null)
				{
					this.BtRollbackInfo = new BtRollbackInfo();
				}
				this.BtRollbackInfo.MergeFrom(other.BtRollbackInfo);
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

		// Token: 0x060037EC RID: 14316 RVA: 0x0008C0BC File Offset: 0x0008A2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x0008C0C8 File Offset: 0x0008A2C8
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
					if (num == 26U)
					{
						if (this.btRollbackInfo_ == null)
						{
							this.BtRollbackInfo = new BtRollbackInfo();
						}
						input.ReadMessage(this.BtRollbackInfo);
						continue;
					}
					if (num == 32U)
					{
						this.FailReason = (FailReason)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.FailNodeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B4F RID: 11087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B50 RID: 11088
		public const int TreeOwnerIdFieldNumber = 9;

		// Token: 0x04002B51 RID: 11089
		private int treeOwnerId_;

		// Token: 0x04002B52 RID: 11090
		public const int TreeIncIdFieldNumber = 6;

		// Token: 0x04002B53 RID: 11091
		private long treeIncId_;

		// Token: 0x04002B54 RID: 11092
		public const int BtRollbackInfoFieldNumber = 3;

		// Token: 0x04002B55 RID: 11093
		private BtRollbackInfo btRollbackInfo_;

		// Token: 0x04002B56 RID: 11094
		public const int FailNodeIdFieldNumber = 15;

		// Token: 0x04002B57 RID: 11095
		private int failNodeId_;

		// Token: 0x04002B58 RID: 11096
		public const int FailReasonFieldNumber = 4;

		// Token: 0x04002B59 RID: 11097
		private FailReason failReason_;
	}
}
