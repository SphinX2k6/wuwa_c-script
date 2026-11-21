using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200146B RID: 5227
	public sealed class TransitionFlowPb : IMessage<TransitionFlowPb>, IMessage, IEquatable<TransitionFlowPb>, IDeepCloneable<TransitionFlowPb>, IBufferMessage
	{
		// Token: 0x0601BBEC RID: 113644 RVA: 0x00407313 File Offset: 0x00405513
		[NullableContext(1)]
		public static TransitionFlowPb Create()
		{
			return new TransitionFlowPb();
		}

		// Token: 0x17005DDA RID: 24026
		// (get) Token: 0x0601BBED RID: 113645 RVA: 0x0040731A File Offset: 0x0040551A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DDB RID: 24027
		// (get) Token: 0x0601BBEE RID: 113646 RVA: 0x0040731D File Offset: 0x0040551D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionFlowPb.Descriptor;
			}
		}

		// Token: 0x0601BBEF RID: 113647 RVA: 0x00407324 File Offset: 0x00405524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionFlowPb()
		{
		}

		// Token: 0x0601BBF0 RID: 113648 RVA: 0x00407337 File Offset: 0x00405537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionFlowPb(TransitionFlowPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BBF1 RID: 113649 RVA: 0x00407374 File Offset: 0x00405574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionFlowPb Clone()
		{
			return new TransitionFlowPb(this);
		}

		// Token: 0x17005DDC RID: 24028
		// (get) Token: 0x0601BBF2 RID: 113650 RVA: 0x0040737C File Offset: 0x0040557C
		// (set) Token: 0x0601BBF3 RID: 113651 RVA: 0x00407384 File Offset: 0x00405584
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

		// Token: 0x17005DDD RID: 24029
		// (get) Token: 0x0601BBF4 RID: 113652 RVA: 0x00407397 File Offset: 0x00405597
		// (set) Token: 0x0601BBF5 RID: 113653 RVA: 0x0040739F File Offset: 0x0040559F
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

		// Token: 0x17005DDE RID: 24030
		// (get) Token: 0x0601BBF6 RID: 113654 RVA: 0x004073A8 File Offset: 0x004055A8
		// (set) Token: 0x0601BBF7 RID: 113655 RVA: 0x004073B0 File Offset: 0x004055B0
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

		// Token: 0x0601BBF8 RID: 113656 RVA: 0x004073B9 File Offset: 0x004055B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionFlowPb);
		}

		// Token: 0x0601BBF9 RID: 113657 RVA: 0x004073C8 File Offset: 0x004055C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionFlowPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BBFA RID: 113658 RVA: 0x00407428 File Offset: 0x00405628
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

		// Token: 0x0601BBFB RID: 113659 RVA: 0x0040749B File Offset: 0x0040569B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BBFC RID: 113660 RVA: 0x004074A8 File Offset: 0x004056A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BBFD RID: 113661 RVA: 0x004074B4 File Offset: 0x004056B4
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

		// Token: 0x0601BBFE RID: 113662 RVA: 0x00407530 File Offset: 0x00405730
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

		// Token: 0x0601BBFF RID: 113663 RVA: 0x004075A4 File Offset: 0x004057A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TransitionFlowPb other)
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

		// Token: 0x0601BC00 RID: 113664 RVA: 0x0040760D File Offset: 0x0040580D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC01 RID: 113665 RVA: 0x00407618 File Offset: 0x00405818
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

		// Token: 0x0400A0F2 RID: 41202
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0F3 RID: 41203
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x0400A0F4 RID: 41204
		private string flowListName_ = "";

		// Token: 0x0400A0F5 RID: 41205
		public const int FlowIdFieldNumber = 2;

		// Token: 0x0400A0F6 RID: 41206
		private int flowId_;

		// Token: 0x0400A0F7 RID: 41207
		public const int StateIdFieldNumber = 3;

		// Token: 0x0400A0F8 RID: 41208
		private int stateId_;
	}
}
