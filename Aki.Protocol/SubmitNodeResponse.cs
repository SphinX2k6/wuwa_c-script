using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001313 RID: 4883
	[NetMessage(EMessageId.SubmitNodeResponse)]
	public sealed class SubmitNodeResponse : IMessage<SubmitNodeResponse>, IMessage, IEquatable<SubmitNodeResponse>, IDeepCloneable<SubmitNodeResponse>, IBufferMessage
	{
		// Token: 0x0601A092 RID: 106642 RVA: 0x003CB71F File Offset: 0x003C991F
		[NullableContext(1)]
		public static SubmitNodeResponse Create()
		{
			return new SubmitNodeResponse();
		}

		// Token: 0x17005826 RID: 22566
		// (get) Token: 0x0601A093 RID: 106643 RVA: 0x003CB726 File Offset: 0x003C9926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005827 RID: 22567
		// (get) Token: 0x0601A094 RID: 106644 RVA: 0x003CB729 File Offset: 0x003C9929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitNodeResponse.Descriptor;
			}
		}

		// Token: 0x0601A095 RID: 106645 RVA: 0x003CB730 File Offset: 0x003C9930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeResponse()
		{
		}

		// Token: 0x0601A096 RID: 106646 RVA: 0x003CB738 File Offset: 0x003C9938
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

		// Token: 0x0601A097 RID: 106647 RVA: 0x003CB78C File Offset: 0x003C998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitNodeResponse Clone()
		{
			return new SubmitNodeResponse(this);
		}

		// Token: 0x17005828 RID: 22568
		// (get) Token: 0x0601A098 RID: 106648 RVA: 0x003CB794 File Offset: 0x003C9994
		// (set) Token: 0x0601A099 RID: 106649 RVA: 0x003CB79C File Offset: 0x003C999C
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

		// Token: 0x17005829 RID: 22569
		// (get) Token: 0x0601A09A RID: 106650 RVA: 0x003CB7A5 File Offset: 0x003C99A5
		// (set) Token: 0x0601A09B RID: 106651 RVA: 0x003CB7AD File Offset: 0x003C99AD
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

		// Token: 0x1700582A RID: 22570
		// (get) Token: 0x0601A09C RID: 106652 RVA: 0x003CB7B6 File Offset: 0x003C99B6
		// (set) Token: 0x0601A09D RID: 106653 RVA: 0x003CB7BE File Offset: 0x003C99BE
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

		// Token: 0x1700582B RID: 22571
		// (get) Token: 0x0601A09E RID: 106654 RVA: 0x003CB7C7 File Offset: 0x003C99C7
		// (set) Token: 0x0601A09F RID: 106655 RVA: 0x003CB7CF File Offset: 0x003C99CF
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

		// Token: 0x0601A0A0 RID: 106656 RVA: 0x003CB7D8 File Offset: 0x003C99D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitNodeResponse);
		}

		// Token: 0x0601A0A1 RID: 106657 RVA: 0x003CB7E8 File Offset: 0x003C99E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitNodeResponse other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && this.NodeId == other.NodeId && this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0A2 RID: 106658 RVA: 0x003CB854 File Offset: 0x003C9A54
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

		// Token: 0x0601A0A3 RID: 106659 RVA: 0x003CB8E4 File Offset: 0x003C9AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0A4 RID: 106660 RVA: 0x003CB8F1 File Offset: 0x003C9AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0A5 RID: 106661 RVA: 0x003CB8FC File Offset: 0x003C9AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this.NodeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.NodeId);
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

		// Token: 0x0601A0A6 RID: 106662 RVA: 0x003CB990 File Offset: 0x003C9B90
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

		// Token: 0x0601A0A7 RID: 106663 RVA: 0x003CBA18 File Offset: 0x003C9C18
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

		// Token: 0x0601A0A8 RID: 106664 RVA: 0x003CBA90 File Offset: 0x003C9C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0A9 RID: 106665 RVA: 0x003CBA9C File Offset: 0x003C9C9C
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
					if (num == 32U)
					{
						this.TreeIncId = input.ReadInt64();
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
					if (num == 72U)
					{
						this.NodeId = input.ReadInt32();
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

		// Token: 0x0400994C RID: 39244
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400994D RID: 39245
		public const int TreeOwnerIdFieldNumber = 15;

		// Token: 0x0400994E RID: 39246
		private int treeOwnerId_;

		// Token: 0x0400994F RID: 39247
		public const int TreeIncIdFieldNumber = 4;

		// Token: 0x04009950 RID: 39248
		private long treeIncId_;

		// Token: 0x04009951 RID: 39249
		public const int NodeIdFieldNumber = 9;

		// Token: 0x04009952 RID: 39250
		private int nodeId_;

		// Token: 0x04009953 RID: 39251
		public const int ErrorIdFieldNumber = 7;

		// Token: 0x04009954 RID: 39252
		private ErrorCode errorId_;
	}
}
