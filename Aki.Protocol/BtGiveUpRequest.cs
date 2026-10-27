using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E9 RID: 489
	[NetMessage(EMessageId.BtGiveUpRequest)]
	public sealed class BtGiveUpRequest : IMessage<BtGiveUpRequest>, IMessage, IEquatable<BtGiveUpRequest>, IDeepCloneable<BtGiveUpRequest>, IBufferMessage
	{
		// Token: 0x060036C9 RID: 14025 RVA: 0x00089375 File Offset: 0x00087575
		[NullableContext(1)]
		public static BtGiveUpRequest Create()
		{
			return new BtGiveUpRequest();
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x0008937C File Offset: 0x0008757C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x0008937F File Offset: 0x0008757F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtGiveUpRequest.Descriptor;
			}
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00089386 File Offset: 0x00087586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpRequest()
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0008938E File Offset: 0x0008758E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpRequest(BtGiveUpRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x000893CB File Offset: 0x000875CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtGiveUpRequest Clone()
		{
			return new BtGiveUpRequest(this);
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060036CF RID: 14031 RVA: 0x000893D3 File Offset: 0x000875D3
		// (set) Token: 0x060036D0 RID: 14032 RVA: 0x000893DB File Offset: 0x000875DB
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

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060036D1 RID: 14033 RVA: 0x000893E4 File Offset: 0x000875E4
		// (set) Token: 0x060036D2 RID: 14034 RVA: 0x000893EC File Offset: 0x000875EC
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

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x000893F5 File Offset: 0x000875F5
		// (set) Token: 0x060036D4 RID: 14036 RVA: 0x000893FD File Offset: 0x000875FD
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

		// Token: 0x060036D5 RID: 14037 RVA: 0x00089406 File Offset: 0x00087606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtGiveUpRequest);
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x00089414 File Offset: 0x00087614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtGiveUpRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00089470 File Offset: 0x00087670
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x000894E1 File Offset: 0x000876E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x000894EE File Offset: 0x000876EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x000894F8 File Offset: 0x000876F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x0008956C File Offset: 0x0008776C
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x000895DC File Offset: 0x000877DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtGiveUpRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00089640 File Offset: 0x00087840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0008964C File Offset: 0x0008784C
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
					if (num != 16U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NodeId = input.ReadInt32();
						}
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
		}

		// Token: 0x04002AB3 RID: 10931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AB4 RID: 10932
		public const int TreeOwnerIdFieldNumber = 1;

		// Token: 0x04002AB5 RID: 10933
		private int treeOwnerId_;

		// Token: 0x04002AB6 RID: 10934
		public const int TreeIncIdFieldNumber = 2;

		// Token: 0x04002AB7 RID: 10935
		private long treeIncId_;

		// Token: 0x04002AB8 RID: 10936
		public const int NodeIdFieldNumber = 10;

		// Token: 0x04002AB9 RID: 10937
		private int nodeId_;
	}
}
