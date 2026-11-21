using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028F RID: 655
	public sealed class ChildQuestNodeInfo : IMessage<ChildQuestNodeInfo>, IMessage, IEquatable<ChildQuestNodeInfo>, IDeepCloneable<ChildQuestNodeInfo>, IBufferMessage
	{
		// Token: 0x0600447B RID: 17531 RVA: 0x000A7D40 File Offset: 0x000A5F40
		[NullableContext(1)]
		public static ChildQuestNodeInfo Create()
		{
			return new ChildQuestNodeInfo();
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x000A7D47 File Offset: 0x000A5F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x000A7D4A File Offset: 0x000A5F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeInfo.Descriptor;
			}
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x000A7D51 File Offset: 0x000A5F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeInfo()
		{
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x000A7D5C File Offset: 0x000A5F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeInfo(ChildQuestNodeInfo other) : this()
		{
			this.status_ = other.status_;
			this.progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x000A7DA8 File Offset: 0x000A5FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeInfo Clone()
		{
			return new ChildQuestNodeInfo(this);
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x000A7DB0 File Offset: 0x000A5FB0
		// (set) Token: 0x06004482 RID: 17538 RVA: 0x000A7DB8 File Offset: 0x000A5FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeStatus Status
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x000A7DC1 File Offset: 0x000A5FC1
		// (set) Token: 0x06004484 RID: 17540 RVA: 0x000A7DC9 File Offset: 0x000A5FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x000A7DD2 File Offset: 0x000A5FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeInfo);
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x000A7DE0 File Offset: 0x000A5FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeInfo other)
		{
			return other != null && (other == this || (this.Status == other.Status && object.Equals(this.Progress, other.Progress) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x000A7E30 File Offset: 0x000A6030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.progress_ != null)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x000A7E8B File Offset: 0x000A608B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x000A7E98 File Offset: 0x000A6098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x000A7EA4 File Offset: 0x000A60A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Status);
			}
			if (this.progress_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x000A7EFC File Offset: 0x000A60FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.progress_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x000A7F54 File Offset: 0x000A6154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChildQuestNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != ChildQuestNodeStatus.CqnsNotActive)
			{
				this.Status = other.Status;
			}
			if (other.progress_ != null)
			{
				if (this.progress_ == null)
				{
					this.Progress = new ChildQuestNodeProgress();
				}
				this.Progress.MergeFrom(other.Progress);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x000A7FBC File Offset: 0x000A61BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x000A7FC8 File Offset: 0x000A61C8
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
						if (this.progress_ == null)
						{
							this.Progress = new ChildQuestNodeProgress();
						}
						input.ReadMessage(this.Progress);
					}
				}
				else
				{
					this.Status = (ChildQuestNodeStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002EE9 RID: 12009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EEA RID: 12010
		public const int StatusFieldNumber = 1;

		// Token: 0x04002EEB RID: 12011
		private ChildQuestNodeStatus status_;

		// Token: 0x04002EEC RID: 12012
		public const int ProgressFieldNumber = 2;

		// Token: 0x04002EED RID: 12013
		private ChildQuestNodeProgress progress_;
	}
}
