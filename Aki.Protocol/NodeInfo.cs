using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B48 RID: 2888
	public sealed class NodeInfo : IMessage<NodeInfo>, IMessage, IEquatable<NodeInfo>, IDeepCloneable<NodeInfo>, IBufferMessage
	{
		// Token: 0x0600FAB2 RID: 64178 RVA: 0x00248C27 File Offset: 0x00246E27
		[NullableContext(1)]
		public static NodeInfo Create()
		{
			return new NodeInfo();
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600FAB3 RID: 64179 RVA: 0x00248C2E File Offset: 0x00246E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NodeInfo> Parser
		{
			get
			{
				return NodeInfo._parser;
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600FAB4 RID: 64180 RVA: 0x00248C35 File Offset: 0x00246E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600FAB5 RID: 64181 RVA: 0x00248C38 File Offset: 0x00246E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NodeInfo.Descriptor;
			}
		}

		// Token: 0x0600FAB6 RID: 64182 RVA: 0x00248C3F File Offset: 0x00246E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeInfo()
		{
		}

		// Token: 0x0600FAB7 RID: 64183 RVA: 0x00248C47 File Offset: 0x00246E47
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

		// Token: 0x0600FAB8 RID: 64184 RVA: 0x00248C86 File Offset: 0x00246E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeInfo Clone()
		{
			return new NodeInfo(this);
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600FAB9 RID: 64185 RVA: 0x00248C8E File Offset: 0x00246E8E
		// (set) Token: 0x0600FABA RID: 64186 RVA: 0x00248C96 File Offset: 0x00246E96
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

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600FABB RID: 64187 RVA: 0x00248C9F File Offset: 0x00246E9F
		// (set) Token: 0x0600FABC RID: 64188 RVA: 0x00248CB7 File Offset: 0x00246EB7
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

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600FABD RID: 64189 RVA: 0x00248CCD File Offset: 0x00246ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NodeInfo.ExtraInfoOneofCase ExtraInfoCase
		{
			get
			{
				return this.extraInfoCase_;
			}
		}

		// Token: 0x0600FABE RID: 64190 RVA: 0x00248CD5 File Offset: 0x00246ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearExtraInfo()
		{
			this.extraInfoCase_ = NodeInfo.ExtraInfoOneofCase.None;
			this.extraInfo_ = null;
		}

		// Token: 0x0600FABF RID: 64191 RVA: 0x00248CE5 File Offset: 0x00246EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NodeInfo);
		}

		// Token: 0x0600FAC0 RID: 64192 RVA: 0x00248CF4 File Offset: 0x00246EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NodeInfo other)
		{
			return other != null && (other == this || (this.Status == other.Status && object.Equals(this.ChildQuestNodeInfo, other.ChildQuestNodeInfo) && this.ExtraInfoCase == other.ExtraInfoCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAC1 RID: 64193 RVA: 0x00248D54 File Offset: 0x00246F54
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

		// Token: 0x0600FAC2 RID: 64194 RVA: 0x00248DB9 File Offset: 0x00246FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FAC3 RID: 64195 RVA: 0x00248DC6 File Offset: 0x00246FC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FAC4 RID: 64196 RVA: 0x00248DD0 File Offset: 0x00246FD0
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

		// Token: 0x0600FAC5 RID: 64197 RVA: 0x00248E2C File Offset: 0x0024702C
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

		// Token: 0x0600FAC6 RID: 64198 RVA: 0x00248E84 File Offset: 0x00247084
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

		// Token: 0x0600FAC7 RID: 64199 RVA: 0x00248EED File Offset: 0x002470ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAC8 RID: 64200 RVA: 0x00248EF8 File Offset: 0x002470F8
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

		// Token: 0x040064A4 RID: 25764
		private static readonly MessageParser<NodeInfo> _parser = new MessageParser<NodeInfo>(() => new NodeInfo());

		// Token: 0x040064A5 RID: 25765
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064A6 RID: 25766
		public const int StatusFieldNumber = 1;

		// Token: 0x040064A7 RID: 25767
		private NodeStatus status_;

		// Token: 0x040064A8 RID: 25768
		public const int ChildQuestNodeInfoFieldNumber = 2;

		// Token: 0x040064A9 RID: 25769
		private object extraInfo_;

		// Token: 0x040064AA RID: 25770
		private NodeInfo.ExtraInfoOneofCase extraInfoCase_;

		// Token: 0x020018E1 RID: 6369
		public enum ExtraInfoOneofCase
		{
			// Token: 0x0400CD6F RID: 52591
			None,
			// Token: 0x0400CD70 RID: 52592
			ChildQuestNodeInfo = 2
		}
	}
}
