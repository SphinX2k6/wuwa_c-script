using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001F9 RID: 505
	[NetMessage(EMessageId.BtSuspendNotify)]
	public sealed class BtSuspendNotify : IMessage<BtSuspendNotify>, IMessage, IEquatable<BtSuspendNotify>, IDeepCloneable<BtSuspendNotify>, IBufferMessage
	{
		// Token: 0x0600385C RID: 14428 RVA: 0x0008D1D5 File Offset: 0x0008B3D5
		[NullableContext(1)]
		public static BtSuspendNotify Create()
		{
			return new BtSuspendNotify();
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600385D RID: 14429 RVA: 0x0008D1DC File Offset: 0x0008B3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600385E RID: 14430 RVA: 0x0008D1DF File Offset: 0x0008B3DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtSuspendNotify.Descriptor;
			}
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x0008D1E6 File Offset: 0x0008B3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSuspendNotify()
		{
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0008D1FC File Offset: 0x0008B3FC
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

		// Token: 0x06003861 RID: 14433 RVA: 0x0008D26D File Offset: 0x0008B46D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtSuspendNotify Clone()
		{
			return new BtSuspendNotify(this);
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06003862 RID: 14434 RVA: 0x0008D275 File Offset: 0x0008B475
		// (set) Token: 0x06003863 RID: 14435 RVA: 0x0008D27D File Offset: 0x0008B47D
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

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06003864 RID: 14436 RVA: 0x0008D286 File Offset: 0x0008B486
		// (set) Token: 0x06003865 RID: 14437 RVA: 0x0008D28E File Offset: 0x0008B48E
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

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x0008D297 File Offset: 0x0008B497
		// (set) Token: 0x06003867 RID: 14439 RVA: 0x0008D29F File Offset: 0x0008B49F
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

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x0008D2A8 File Offset: 0x0008B4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x0008D2B0 File Offset: 0x0008B4B0
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
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

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x0008D2C1 File Offset: 0x0008B4C1
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x0008D2C9 File Offset: 0x0008B4C9
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

		// Token: 0x0600386D RID: 14445 RVA: 0x0008D2D2 File Offset: 0x0008B4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtSuspendNotify);
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x0008D2E0 File Offset: 0x0008B4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtSuspendNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.occupationInfo_.Equals(other.occupationInfo_) && this.SuspendType == other.SuspendType && this.IsScreenOccupy == other.IsScreenOccupy && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x0008D370 File Offset: 0x0008B570
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

		// Token: 0x06003870 RID: 14448 RVA: 0x0008D421 File Offset: 0x0008B621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x0008D42E File Offset: 0x0008B62E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x0008D438 File Offset: 0x0008B638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.NodeId);
			}
			if (this.SuspendType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SuspendType);
			}
			this.occupationInfo_.WriteTo(ref output, BtSuspendNotify._repeated_occupationInfo_codec);
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.IsScreenOccupy)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsScreenOccupy);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x0008D4F8 File Offset: 0x0008B6F8
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

		// Token: 0x06003874 RID: 14452 RVA: 0x0008D5A0 File Offset: 0x0008B7A0
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

		// Token: 0x06003875 RID: 14453 RVA: 0x0008D63D File Offset: 0x0008B83D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x0008D648 File Offset: 0x0008B848
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.SuspendType = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.occupationInfo_.AddEntriesFrom(ref input, BtSuspendNotify._repeated_occupationInfo_codec);
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
					if (num == 96U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.IsScreenOccupy = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B7D RID: 11133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B7E RID: 11134
		public const int TreeOwnerIdFieldNumber = 11;

		// Token: 0x04002B7F RID: 11135
		private int treeOwnerId_;

		// Token: 0x04002B80 RID: 11136
		public const int TreeIncIdFieldNumber = 12;

		// Token: 0x04002B81 RID: 11137
		private long treeIncId_;

		// Token: 0x04002B82 RID: 11138
		public const int NodeIdFieldNumber = 2;

		// Token: 0x04002B83 RID: 11139
		private int nodeId_;

		// Token: 0x04002B84 RID: 11140
		public const int OccupationInfoFieldNumber = 5;

		// Token: 0x04002B85 RID: 11141
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(42U, OccupationPbInfo.Parser);

		// Token: 0x04002B86 RID: 11142
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();

		// Token: 0x04002B87 RID: 11143
		public const int SuspendTypeFieldNumber = 3;

		// Token: 0x04002B88 RID: 11144
		private int suspendType_;

		// Token: 0x04002B89 RID: 11145
		public const int IsScreenOccupyFieldNumber = 13;

		// Token: 0x04002B8A RID: 11146
		private bool isScreenOccupy_;
	}
}
