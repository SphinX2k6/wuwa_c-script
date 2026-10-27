using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052D RID: 1325
	[NetMessage(EMessageId.FastReturnDungeonRequest)]
	public sealed class FastReturnDungeonRequest : IMessage<FastReturnDungeonRequest>, IMessage, IEquatable<FastReturnDungeonRequest>, IDeepCloneable<FastReturnDungeonRequest>, IBufferMessage
	{
		// Token: 0x06007C2C RID: 31788 RVA: 0x0012CE1D File Offset: 0x0012B01D
		[NullableContext(1)]
		public static FastReturnDungeonRequest Create()
		{
			return new FastReturnDungeonRequest();
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06007C2D RID: 31789 RVA: 0x0012CE24 File Offset: 0x0012B024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06007C2E RID: 31790 RVA: 0x0012CE27 File Offset: 0x0012B027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FastReturnDungeonRequest.Descriptor;
			}
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x0012CE2E File Offset: 0x0012B02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonRequest()
		{
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x0012CE44 File Offset: 0x0012B044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonRequest(FastReturnDungeonRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.continueInst_ = other.continueInst_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x0012CEA9 File Offset: 0x0012B0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FastReturnDungeonRequest Clone()
		{
			return new FastReturnDungeonRequest(this);
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06007C32 RID: 31794 RVA: 0x0012CEB1 File Offset: 0x0012B0B1
		// (set) Token: 0x06007C33 RID: 31795 RVA: 0x0012CEB9 File Offset: 0x0012B0B9
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

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06007C34 RID: 31796 RVA: 0x0012CEC2 File Offset: 0x0012B0C2
		// (set) Token: 0x06007C35 RID: 31797 RVA: 0x0012CECA File Offset: 0x0012B0CA
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

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06007C36 RID: 31798 RVA: 0x0012CED3 File Offset: 0x0012B0D3
		// (set) Token: 0x06007C37 RID: 31799 RVA: 0x0012CEDB File Offset: 0x0012B0DB
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

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06007C38 RID: 31800 RVA: 0x0012CEE4 File Offset: 0x0012B0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06007C39 RID: 31801 RVA: 0x0012CEEC File Offset: 0x0012B0EC
		// (set) Token: 0x06007C3A RID: 31802 RVA: 0x0012CEF4 File Offset: 0x0012B0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueInst
		{
			get
			{
				return this.continueInst_;
			}
			set
			{
				this.continueInst_ = value;
			}
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x0012CEFD File Offset: 0x0012B0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FastReturnDungeonRequest);
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x0012CF0C File Offset: 0x0012B10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FastReturnDungeonRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.roleIds_.Equals(other.roleIds_) && this.ContinueInst == other.ContinueInst && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x0012CF8C File Offset: 0x0012B18C
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
			num ^= this.roleIds_.GetHashCode();
			if (this.ContinueInst)
			{
				num ^= this.ContinueInst.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x0012D024 File Offset: 0x0012B224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x0012D031 File Offset: 0x0012B231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x0012D03C File Offset: 0x0012B23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.NodeId);
			}
			if (this.ContinueInst)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ContinueInst);
			}
			this.roleIds_.WriteTo(ref output, FastReturnDungeonRequest._repeated_roleIds_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(64);
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

		// Token: 0x06007C41 RID: 31809 RVA: 0x0012D0E0 File Offset: 0x0012B2E0
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
			num += this.roleIds_.CalculateSize(FastReturnDungeonRequest._repeated_roleIds_codec);
			if (this.ContinueInst)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x0012D170 File Offset: 0x0012B370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FastReturnDungeonRequest other)
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
			this.roleIds_.Add(other.roleIds_);
			if (other.ContinueInst)
			{
				this.ContinueInst = other.ContinueInst;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x0012D1F9 File Offset: 0x0012B3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x0012D204 File Offset: 0x0012B404
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
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ContinueInst = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 42U)
					{
						goto IL_61;
					}
					if (num == 64U)
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
				continue;
				IL_61:
				this.roleIds_.AddEntriesFrom(ref input, FastReturnDungeonRequest._repeated_roleIds_codec);
			}
		}

		// Token: 0x04003F59 RID: 16217
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F5A RID: 16218
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x04003F5B RID: 16219
		private int treeOwnerId_;

		// Token: 0x04003F5C RID: 16220
		public const int TreeIncIdFieldNumber = 8;

		// Token: 0x04003F5D RID: 16221
		private long treeIncId_;

		// Token: 0x04003F5E RID: 16222
		public const int NodeIdFieldNumber = 3;

		// Token: 0x04003F5F RID: 16223
		private int nodeId_;

		// Token: 0x04003F60 RID: 16224
		public const int RoleIdsFieldNumber = 5;

		// Token: 0x04003F61 RID: 16225
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04003F62 RID: 16226
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04003F63 RID: 16227
		public const int ContinueInstFieldNumber = 4;

		// Token: 0x04003F64 RID: 16228
		private bool continueInst_;
	}
}
