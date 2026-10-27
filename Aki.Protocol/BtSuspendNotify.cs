using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F4 RID: 500
	[NetMessage(EMessageId.BtSuspendNotify)]
	public sealed class BtSuspendNotify : IMessage<BtSuspendNotify>, IMessage, IEquatable<BtSuspendNotify>, IDeepCloneable<BtSuspendNotify>, IBufferMessage
	{
		// Token: 0x060037B7 RID: 14263 RVA: 0x0008B5C5 File Offset: 0x000897C5
		[NullableContext(1)]
		public static BtSuspendNotify Create()
		{
			return new BtSuspendNotify();
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x0008B5CC File Offset: 0x000897CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x0008B5CF File Offset: 0x000897CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtSuspendNotify.Descriptor;
			}
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x0008B5D6 File Offset: 0x000897D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSuspendNotify()
		{
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x0008B5EC File Offset: 0x000897EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSuspendNotify(BtSuspendNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.occupationInfo_ = other.occupationInfo_.Clone();
			this.suspendType_ = other.suspendType_;
			this.isScreenOccupy_ = other.isScreenOccupy_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x0008B65D File Offset: 0x0008985D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSuspendNotify Clone()
		{
			return new BtSuspendNotify(this);
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x0008B665 File Offset: 0x00089865
		// (set) Token: 0x060037BE RID: 14270 RVA: 0x0008B66D File Offset: 0x0008986D
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

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x0008B676 File Offset: 0x00089876
		// (set) Token: 0x060037C0 RID: 14272 RVA: 0x0008B67E File Offset: 0x0008987E
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

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0008B687 File Offset: 0x00089887
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x0008B68F File Offset: 0x0008988F
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x0008B698 File Offset: 0x00089898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x0008B6A0 File Offset: 0x000898A0
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x0008B6A8 File Offset: 0x000898A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SuspendType
		{
			get
			{
				return this.suspendType_;
			}
			set
			{
				this.suspendType_ = value;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x0008B6B1 File Offset: 0x000898B1
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x0008B6B9 File Offset: 0x000898B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsScreenOccupy
		{
			get
			{
				return this.isScreenOccupy_;
			}
			set
			{
				this.isScreenOccupy_ = value;
			}
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x0008B6C2 File Offset: 0x000898C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtSuspendNotify);
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x0008B6D0 File Offset: 0x000898D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtSuspendNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.occupationInfo_.Equals(other.occupationInfo_) && this.SuspendType == other.SuspendType && this.IsScreenOccupy == other.IsScreenOccupy && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x0008B760 File Offset: 0x00089960
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
			num ^= this.occupationInfo_.GetHashCode();
			if (this.SuspendType != 0)
			{
				num ^= this.SuspendType.GetHashCode();
			}
			if (this.IsScreenOccupy)
			{
				num ^= this.IsScreenOccupy.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x0008B811 File Offset: 0x00089A11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x0008B81E File Offset: 0x00089A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x0008B828 File Offset: 0x00089A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.occupationInfo_.WriteTo(ref output, BtSuspendNotify._repeated_occupationInfo_codec);
			if (this.NodeId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.NodeId);
			}
			if (this.SuspendType != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SuspendType);
			}
			if (this.IsScreenOccupy)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsScreenOccupy);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x0008B8E8 File Offset: 0x00089AE8
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
			num += this.occupationInfo_.CalculateSize(BtSuspendNotify._repeated_occupationInfo_codec);
			if (this.SuspendType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SuspendType);
			}
			if (this.IsScreenOccupy)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x0008B990 File Offset: 0x00089B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtSuspendNotify other)
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
			this.occupationInfo_.Add(other.occupationInfo_);
			if (other.SuspendType != 0)
			{
				this.SuspendType = other.SuspendType;
			}
			if (other.IsScreenOccupy)
			{
				this.IsScreenOccupy = other.IsScreenOccupy;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x0008BA2D File Offset: 0x00089C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x0008BA38 File Offset: 0x00089C38
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
				if (num <= 48U)
				{
					if (num == 18U)
					{
						this.occupationInfo_.AddEntriesFrom(ref input, BtSuspendNotify._repeated_occupationInfo_codec);
						continue;
					}
					if (num == 40U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.SuspendType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.IsScreenOccupy = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002AFB RID: 11003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AFC RID: 11004
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x04002AFD RID: 11005
		private int treeOwnerId_;

		// Token: 0x04002AFE RID: 11006
		public const int TreeIncIdFieldNumber = 9;

		// Token: 0x04002AFF RID: 11007
		private long treeIncId_;

		// Token: 0x04002B00 RID: 11008
		public const int NodeIdFieldNumber = 5;

		// Token: 0x04002B01 RID: 11009
		private int nodeId_;

		// Token: 0x04002B02 RID: 11010
		public const int OccupationInfoFieldNumber = 2;

		// Token: 0x04002B03 RID: 11011
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(18U, OccupationPbInfo.Parser);

		// Token: 0x04002B04 RID: 11012
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();

		// Token: 0x04002B05 RID: 11013
		public const int SuspendTypeFieldNumber = 6;

		// Token: 0x04002B06 RID: 11014
		private int suspendType_;

		// Token: 0x04002B07 RID: 11015
		public const int IsScreenOccupyFieldNumber = 7;

		// Token: 0x04002B08 RID: 11016
		private bool isScreenOccupy_;
	}
}
