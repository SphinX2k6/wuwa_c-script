using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B59 RID: 2905
	public sealed class NodeInfo : IMessage<NodeInfo>, IMessage, IEquatable<NodeInfo>, IDeepCloneable<NodeInfo>, IBufferMessage
	{
		// Token: 0x0600FBCC RID: 64460 RVA: 0x0024AE3B File Offset: 0x0024903B
		[NullableContext(1)]
		public static NodeInfo Create()
		{
			return new NodeInfo();
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600FBCD RID: 64461 RVA: 0x0024AE42 File Offset: 0x00249042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NodeInfo> Parser
		{
			get
			{
				return NodeInfo._parser;
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600FBCE RID: 64462 RVA: 0x0024AE49 File Offset: 0x00249049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600FBCF RID: 64463 RVA: 0x0024AE4C File Offset: 0x0024904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NodeInfo.Descriptor;
			}
		}

		// Token: 0x0600FBD0 RID: 64464 RVA: 0x0024AE53 File Offset: 0x00249053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeInfo()
		{
		}

		// Token: 0x0600FBD1 RID: 64465 RVA: 0x0024AE5B File Offset: 0x0024905B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeInfo(NodeInfo other) : this()
		{
			this.status_ = other.status_;
			if (other.ExtraInfoCase == NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo)
			{
				this.ChildQuestNodeInfo = other.ChildQuestNodeInfo.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBD2 RID: 64466 RVA: 0x0024AE9A File Offset: 0x0024909A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeInfo Clone()
		{
			return new NodeInfo(this);
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600FBD3 RID: 64467 RVA: 0x0024AEA2 File Offset: 0x002490A2
		// (set) Token: 0x0600FBD4 RID: 64468 RVA: 0x0024AEAA File Offset: 0x002490AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600FBD5 RID: 64469 RVA: 0x0024AEB3 File Offset: 0x002490B3
		// (set) Token: 0x0600FBD6 RID: 64470 RVA: 0x0024AECB File Offset: 0x002490CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeInfo ChildQuestNodeInfo
		{
			get
			{
				if (this.extraInfoCase_ != NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo)
				{
					return null;
				}
				return (ChildQuestNodeInfo)this.extraInfo_;
			}
			set
			{
				this.extraInfo_ = value;
				this.extraInfoCase_ = ((value == null) ? NodeInfo.ExtraInfoOneofCase.None : NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo);
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600FBD7 RID: 64471 RVA: 0x0024AEE1 File Offset: 0x002490E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeInfo.ExtraInfoOneofCase ExtraInfoCase
		{
			get
			{
				return this.extraInfoCase_;
			}
		}

		// Token: 0x0600FBD8 RID: 64472 RVA: 0x0024AEE9 File Offset: 0x002490E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExtraInfo()
		{
			this.extraInfoCase_ = NodeInfo.ExtraInfoOneofCase.None;
			this.extraInfo_ = null;
		}

		// Token: 0x0600FBD9 RID: 64473 RVA: 0x0024AEF9 File Offset: 0x002490F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NodeInfo);
		}

		// Token: 0x0600FBDA RID: 64474 RVA: 0x0024AF08 File Offset: 0x00249108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NodeInfo other)
		{
			return other != null && (other == this || (this.Status == other.Status && object.Equals(this.ChildQuestNodeInfo, other.ChildQuestNodeInfo) && this.ExtraInfoCase == other.ExtraInfoCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBDB RID: 64475 RVA: 0x0024AF68 File Offset: 0x00249168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != NodeStatus.NotActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.extraInfoCase_ == NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo)
			{
				num ^= this.ChildQuestNodeInfo.GetHashCode();
			}
			num ^= (int)this.extraInfoCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FBDC RID: 64476 RVA: 0x0024AFCD File Offset: 0x002491CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBDD RID: 64477 RVA: 0x0024AFDA File Offset: 0x002491DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBDE RID: 64478 RVA: 0x0024AFE4 File Offset: 0x002491E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != NodeStatus.NotActive)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Status);
			}
			if (this.extraInfoCase_ == NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChildQuestNodeInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FBDF RID: 64479 RVA: 0x0024B040 File Offset: 0x00249240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != NodeStatus.NotActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.extraInfoCase_ == NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChildQuestNodeInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FBE0 RID: 64480 RVA: 0x0024B098 File Offset: 0x00249298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != NodeStatus.NotActive)
			{
				this.Status = other.Status;
			}
			if (other.ExtraInfoCase == NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo)
			{
				if (this.ChildQuestNodeInfo == null)
				{
					this.ChildQuestNodeInfo = new ChildQuestNodeInfo();
				}
				this.ChildQuestNodeInfo.MergeFrom(other.ChildQuestNodeInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FBE1 RID: 64481 RVA: 0x0024B101 File Offset: 0x00249301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBE2 RID: 64482 RVA: 0x0024B10C File Offset: 0x0024930C
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						ChildQuestNodeInfo childQuestNodeInfo = new ChildQuestNodeInfo();
						if (this.extraInfoCase_ == NodeInfo.ExtraInfoOneofCase.ChildQuestNodeInfo)
						{
							childQuestNodeInfo.MergeFrom(this.ChildQuestNodeInfo);
						}
						input.ReadMessage(childQuestNodeInfo);
						this.ChildQuestNodeInfo = childQuestNodeInfo;
					}
				}
				else
				{
					this.Status = (NodeStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400649B RID: 25755
		private static readonly MessageParser<NodeInfo> _parser = new MessageParser<NodeInfo>(() => new NodeInfo());

		// Token: 0x0400649C RID: 25756
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400649D RID: 25757
		public const int StatusFieldNumber = 1;

		// Token: 0x0400649E RID: 25758
		private NodeStatus status_;

		// Token: 0x0400649F RID: 25759
		public const int ChildQuestNodeInfoFieldNumber = 2;

		// Token: 0x040064A0 RID: 25760
		private object extraInfo_;

		// Token: 0x040064A1 RID: 25761
		private NodeInfo.ExtraInfoOneofCase extraInfoCase_;

		// Token: 0x02001869 RID: 6249
		public enum ExtraInfoOneofCase
		{
			// Token: 0x0400C844 RID: 51268
			None,
			// Token: 0x0400C845 RID: 51269
			ChildQuestNodeInfo = 2
		}
	}
}
