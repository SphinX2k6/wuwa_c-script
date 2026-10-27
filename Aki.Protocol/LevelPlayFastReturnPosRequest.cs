using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F8 RID: 2296
	[NetMessage(EMessageId.LevelPlayFastReturnPosRequest)]
	public sealed class LevelPlayFastReturnPosRequest : IMessage<LevelPlayFastReturnPosRequest>, IMessage, IEquatable<LevelPlayFastReturnPosRequest>, IDeepCloneable<LevelPlayFastReturnPosRequest>, IBufferMessage
	{
		// Token: 0x0600CAE6 RID: 51942 RVA: 0x001DF074 File Offset: 0x001DD274
		[NullableContext(1)]
		public static LevelPlayFastReturnPosRequest Create()
		{
			return new LevelPlayFastReturnPosRequest();
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600CAE7 RID: 51943 RVA: 0x001DF07B File Offset: 0x001DD27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x0600CAE8 RID: 51944 RVA: 0x001DF07E File Offset: 0x001DD27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayFastReturnPosRequest.Descriptor;
			}
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x001DF085 File Offset: 0x001DD285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosRequest()
		{
		}

		// Token: 0x0600CAEA RID: 51946 RVA: 0x001DF090 File Offset: 0x001DD290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosRequest(LevelPlayFastReturnPosRequest other) : this()
		{
			this.levelPlayId_ = other.levelPlayId_;
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAEB RID: 51947 RVA: 0x001DF0E4 File Offset: 0x001DD2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayFastReturnPosRequest Clone()
		{
			return new LevelPlayFastReturnPosRequest(this);
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x0600CAEC RID: 51948 RVA: 0x001DF0EC File Offset: 0x001DD2EC
		// (set) Token: 0x0600CAED RID: 51949 RVA: 0x001DF0F4 File Offset: 0x001DD2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayId
		{
			get
			{
				return this.levelPlayId_;
			}
			set
			{
				this.levelPlayId_ = value;
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600CAEE RID: 51950 RVA: 0x001DF0FD File Offset: 0x001DD2FD
		// (set) Token: 0x0600CAEF RID: 51951 RVA: 0x001DF105 File Offset: 0x001DD305
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

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600CAF0 RID: 51952 RVA: 0x001DF10E File Offset: 0x001DD30E
		// (set) Token: 0x0600CAF1 RID: 51953 RVA: 0x001DF116 File Offset: 0x001DD316
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

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600CAF2 RID: 51954 RVA: 0x001DF11F File Offset: 0x001DD31F
		// (set) Token: 0x0600CAF3 RID: 51955 RVA: 0x001DF127 File Offset: 0x001DD327
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

		// Token: 0x0600CAF4 RID: 51956 RVA: 0x001DF130 File Offset: 0x001DD330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayFastReturnPosRequest);
		}

		// Token: 0x0600CAF5 RID: 51957 RVA: 0x001DF140 File Offset: 0x001DD340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayFastReturnPosRequest other)
		{
			return other != null && (other == this || (this.LevelPlayId == other.LevelPlayId && this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAF6 RID: 51958 RVA: 0x001DF1AC File Offset: 0x001DD3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelPlayId != 0)
			{
				num ^= this.LevelPlayId.GetHashCode();
			}
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

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x001DF236 File Offset: 0x001DD436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CAF8 RID: 51960 RVA: 0x001DF243 File Offset: 0x001DD443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CAF9 RID: 51961 RVA: 0x001DF24C File Offset: 0x001DD44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.LevelPlayId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LevelPlayId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CAFA RID: 51962 RVA: 0x001DF2E0 File Offset: 0x001DD4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelPlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayId);
			}
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

		// Token: 0x0600CAFB RID: 51963 RVA: 0x001DF368 File Offset: 0x001DD568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayFastReturnPosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelPlayId != 0)
			{
				this.LevelPlayId = other.LevelPlayId;
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

		// Token: 0x0600CAFC RID: 51964 RVA: 0x001DF3E0 File Offset: 0x001DD5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAFD RID: 51965 RVA: 0x001DF3EC File Offset: 0x001DD5EC
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
				if (num <= 96U)
				{
					if (num == 40U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.LevelPlayId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005642 RID: 22082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005643 RID: 22083
		public const int LevelPlayIdFieldNumber = 12;

		// Token: 0x04005644 RID: 22084
		private int levelPlayId_;

		// Token: 0x04005645 RID: 22085
		public const int TreeOwnerIdFieldNumber = 13;

		// Token: 0x04005646 RID: 22086
		private int treeOwnerId_;

		// Token: 0x04005647 RID: 22087
		public const int TreeIncIdFieldNumber = 5;

		// Token: 0x04005648 RID: 22088
		private long treeIncId_;

		// Token: 0x04005649 RID: 22089
		public const int NodeIdFieldNumber = 15;

		// Token: 0x0400564A RID: 22090
		private int nodeId_;
	}
}
