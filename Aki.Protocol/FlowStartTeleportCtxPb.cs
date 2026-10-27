using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000607 RID: 1543
	public sealed class FlowStartTeleportCtxPb : IMessage<FlowStartTeleportCtxPb>, IMessage, IEquatable<FlowStartTeleportCtxPb>, IDeepCloneable<FlowStartTeleportCtxPb>, IBufferMessage
	{
		// Token: 0x06008EB9 RID: 36537 RVA: 0x0015A13B File Offset: 0x0015833B
		[NullableContext(1)]
		public static FlowStartTeleportCtxPb Create()
		{
			return new FlowStartTeleportCtxPb();
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06008EBA RID: 36538 RVA: 0x0015A142 File Offset: 0x00158342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06008EBB RID: 36539 RVA: 0x0015A145 File Offset: 0x00158345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowStartTeleportCtxPb.Descriptor;
			}
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x0015A14C File Offset: 0x0015834C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartTeleportCtxPb()
		{
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x0015A15F File Offset: 0x0015835F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartTeleportCtxPb(FlowStartTeleportCtxPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x0015A19C File Offset: 0x0015839C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartTeleportCtxPb Clone()
		{
			return new FlowStartTeleportCtxPb(this);
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06008EBF RID: 36543 RVA: 0x0015A1A4 File Offset: 0x001583A4
		// (set) Token: 0x06008EC0 RID: 36544 RVA: 0x0015A1AC File Offset: 0x001583AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowListName
		{
			get
			{
				return this.flowListName_;
			}
			set
			{
				this.flowListName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06008EC1 RID: 36545 RVA: 0x0015A1BF File Offset: 0x001583BF
		// (set) Token: 0x06008EC2 RID: 36546 RVA: 0x0015A1C7 File Offset: 0x001583C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlowId
		{
			get
			{
				return this.flowId_;
			}
			set
			{
				this.flowId_ = value;
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06008EC3 RID: 36547 RVA: 0x0015A1D0 File Offset: 0x001583D0
		// (set) Token: 0x06008EC4 RID: 36548 RVA: 0x0015A1D8 File Offset: 0x001583D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StateId
		{
			get
			{
				return this.stateId_;
			}
			set
			{
				this.stateId_ = value;
			}
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x0015A1E1 File Offset: 0x001583E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowStartTeleportCtxPb);
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x0015A1F0 File Offset: 0x001583F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowStartTeleportCtxPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x0015A250 File Offset: 0x00158450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowListName.Length != 0)
			{
				num ^= this.FlowListName.GetHashCode();
			}
			if (this.FlowId != 0)
			{
				num ^= this.FlowId.GetHashCode();
			}
			if (this.StateId != 0)
			{
				num ^= this.StateId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EC8 RID: 36552 RVA: 0x0015A2C3 File Offset: 0x001584C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x0015A2D0 File Offset: 0x001584D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x0015A2DC File Offset: 0x001584DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FlowId);
			}
			if (this.StateId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.StateId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x0015A358 File Offset: 0x00158558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowListName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowListName);
			}
			if (this.FlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlowId);
			}
			if (this.StateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x0015A3CC File Offset: 0x001585CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowStartTeleportCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowListName.Length != 0)
			{
				this.FlowListName = other.FlowListName;
			}
			if (other.FlowId != 0)
			{
				this.FlowId = other.FlowId;
			}
			if (other.StateId != 0)
			{
				this.StateId = other.StateId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x0015A435 File Offset: 0x00158635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008ECE RID: 36558 RVA: 0x0015A440 File Offset: 0x00158640
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.StateId = input.ReadInt32();
						}
					}
					else
					{
						this.FlowId = input.ReadInt32();
					}
				}
				else
				{
					this.FlowListName = input.ReadString();
				}
			}
		}

		// Token: 0x04004578 RID: 17784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004579 RID: 17785
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x0400457A RID: 17786
		private string flowListName_ = "";

		// Token: 0x0400457B RID: 17787
		public const int FlowIdFieldNumber = 2;

		// Token: 0x0400457C RID: 17788
		private int flowId_;

		// Token: 0x0400457D RID: 17789
		public const int StateIdFieldNumber = 3;

		// Token: 0x0400457E RID: 17790
		private int stateId_;
	}
}
