using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A4 RID: 4772
	[NetMessage(EMessageId.SubmitNodeResponse)]
	public sealed class SubmitNodeResponse : IMessage<SubmitNodeResponse>, IMessage, IEquatable<SubmitNodeResponse>, IDeepCloneable<SubmitNodeResponse>, IBufferMessage
	{
		// Token: 0x0601965C RID: 104028 RVA: 0x003B0FEB File Offset: 0x003AF1EB
		[NullableContext(1)]
		public static SubmitNodeResponse Create()
		{
			return new SubmitNodeResponse();
		}

		// Token: 0x170055A5 RID: 21925
		// (get) Token: 0x0601965D RID: 104029 RVA: 0x003B0FF2 File Offset: 0x003AF1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055A6 RID: 21926
		// (get) Token: 0x0601965E RID: 104030 RVA: 0x003B0FF5 File Offset: 0x003AF1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitNodeResponse.Descriptor;
			}
		}

		// Token: 0x0601965F RID: 104031 RVA: 0x003B0FFC File Offset: 0x003AF1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeResponse()
		{
		}

		// Token: 0x06019660 RID: 104032 RVA: 0x003B1004 File Offset: 0x003AF204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeResponse(SubmitNodeResponse other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.nodeId_ = other.nodeId_;
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019661 RID: 104033 RVA: 0x003B1058 File Offset: 0x003AF258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeResponse Clone()
		{
			return new SubmitNodeResponse(this);
		}

		// Token: 0x170055A7 RID: 21927
		// (get) Token: 0x06019662 RID: 104034 RVA: 0x003B1060 File Offset: 0x003AF260
		// (set) Token: 0x06019663 RID: 104035 RVA: 0x003B1068 File Offset: 0x003AF268
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

		// Token: 0x170055A8 RID: 21928
		// (get) Token: 0x06019664 RID: 104036 RVA: 0x003B1071 File Offset: 0x003AF271
		// (set) Token: 0x06019665 RID: 104037 RVA: 0x003B1079 File Offset: 0x003AF279
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

		// Token: 0x170055A9 RID: 21929
		// (get) Token: 0x06019666 RID: 104038 RVA: 0x003B1082 File Offset: 0x003AF282
		// (set) Token: 0x06019667 RID: 104039 RVA: 0x003B108A File Offset: 0x003AF28A
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

		// Token: 0x170055AA RID: 21930
		// (get) Token: 0x06019668 RID: 104040 RVA: 0x003B1093 File Offset: 0x003AF293
		// (set) Token: 0x06019669 RID: 104041 RVA: 0x003B109B File Offset: 0x003AF29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601966A RID: 104042 RVA: 0x003B10A4 File Offset: 0x003AF2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitNodeResponse);
		}

		// Token: 0x0601966B RID: 104043 RVA: 0x003B10B4 File Offset: 0x003AF2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitNodeResponse other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601966C RID: 104044 RVA: 0x003B1120 File Offset: 0x003AF320
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
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601966D RID: 104045 RVA: 0x003B11B0 File Offset: 0x003AF3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601966E RID: 104046 RVA: 0x003B11BD File Offset: 0x003AF3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601966F RID: 104047 RVA: 0x003B11C8 File Offset: 0x003AF3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.NodeId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019670 RID: 104048 RVA: 0x003B125C File Offset: 0x003AF45C
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
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019671 RID: 104049 RVA: 0x003B12E4 File Offset: 0x003AF4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitNodeResponse other)
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
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019672 RID: 104050 RVA: 0x003B135C File Offset: 0x003AF55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019673 RID: 104051 RVA: 0x003B1368 File Offset: 0x003AF568
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
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ErrorId = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.NodeId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009522 RID: 38178
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009523 RID: 38179
		public const int TreeOwnerIdFieldNumber = 5;

		// Token: 0x04009524 RID: 38180
		private int treeOwnerId_;

		// Token: 0x04009525 RID: 38181
		public const int TreeIncIdFieldNumber = 14;

		// Token: 0x04009526 RID: 38182
		private long treeIncId_;

		// Token: 0x04009527 RID: 38183
		public const int NodeIdFieldNumber = 12;

		// Token: 0x04009528 RID: 38184
		private int nodeId_;

		// Token: 0x04009529 RID: 38185
		public const int ErrorIdFieldNumber = 7;

		// Token: 0x0400952A RID: 38186
		private ErrorCode errorId_;
	}
}
