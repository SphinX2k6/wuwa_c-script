using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F4 RID: 1524
	public sealed class FlowActionCtxPb : IMessage<FlowActionCtxPb>, IMessage, IEquatable<FlowActionCtxPb>, IDeepCloneable<FlowActionCtxPb>, IBufferMessage
	{
		// Token: 0x06008D1C RID: 36124 RVA: 0x001564A2 File Offset: 0x001546A2
		[NullableContext(1)]
		public static FlowActionCtxPb Create()
		{
			return new FlowActionCtxPb();
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06008D1D RID: 36125 RVA: 0x001564A9 File Offset: 0x001546A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06008D1E RID: 36126 RVA: 0x001564AC File Offset: 0x001546AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x001564B3 File Offset: 0x001546B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionCtxPb()
		{
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x001564C8 File Offset: 0x001546C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionCtxPb(FlowActionCtxPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this.actionId_ = other.actionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D21 RID: 36129 RVA: 0x0015651C File Offset: 0x0015471C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionCtxPb Clone()
		{
			return new FlowActionCtxPb(this);
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06008D22 RID: 36130 RVA: 0x00156524 File Offset: 0x00154724
		// (set) Token: 0x06008D23 RID: 36131 RVA: 0x0015652C File Offset: 0x0015472C
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

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06008D24 RID: 36132 RVA: 0x0015653F File Offset: 0x0015473F
		// (set) Token: 0x06008D25 RID: 36133 RVA: 0x00156547 File Offset: 0x00154747
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

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06008D26 RID: 36134 RVA: 0x00156550 File Offset: 0x00154750
		// (set) Token: 0x06008D27 RID: 36135 RVA: 0x00156558 File Offset: 0x00154758
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

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06008D28 RID: 36136 RVA: 0x00156561 File Offset: 0x00154761
		// (set) Token: 0x06008D29 RID: 36137 RVA: 0x00156569 File Offset: 0x00154769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionId
		{
			get
			{
				return this.actionId_;
			}
			set
			{
				this.actionId_ = value;
			}
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x00156572 File Offset: 0x00154772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowActionCtxPb);
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x00156580 File Offset: 0x00154780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowActionCtxPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && this.ActionId == other.ActionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D2C RID: 36140 RVA: 0x001565F0 File Offset: 0x001547F0
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
			if (this.ActionId != 0)
			{
				num ^= this.ActionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D2D RID: 36141 RVA: 0x0015667C File Offset: 0x0015487C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D2E RID: 36142 RVA: 0x00156689 File Offset: 0x00154889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x00156694 File Offset: 0x00154894
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
			if (this.ActionId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D30 RID: 36144 RVA: 0x0015672C File Offset: 0x0015492C
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
			if (this.ActionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D31 RID: 36145 RVA: 0x001567B8 File Offset: 0x001549B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlowActionCtxPb other)
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
			if (other.ActionId != 0)
			{
				this.ActionId = other.ActionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x00156835 File Offset: 0x00154A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x00156840 File Offset: 0x00154A40
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.FlowListName = input.ReadString();
						continue;
					}
					if (num == 16U)
					{
						this.FlowId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.StateId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ActionId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044F5 RID: 17653
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044F6 RID: 17654
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x040044F7 RID: 17655
		private string flowListName_ = "";

		// Token: 0x040044F8 RID: 17656
		public const int FlowIdFieldNumber = 2;

		// Token: 0x040044F9 RID: 17657
		private int flowId_;

		// Token: 0x040044FA RID: 17658
		public const int StateIdFieldNumber = 3;

		// Token: 0x040044FB RID: 17659
		private int stateId_;

		// Token: 0x040044FC RID: 17660
		public const int ActionIdFieldNumber = 4;

		// Token: 0x040044FD RID: 17661
		private int actionId_;
	}
}
