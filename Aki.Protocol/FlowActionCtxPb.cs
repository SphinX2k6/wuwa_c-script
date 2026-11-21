using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DF RID: 1503
	public sealed class FlowActionCtxPb : IMessage<FlowActionCtxPb>, IMessage, IEquatable<FlowActionCtxPb>, IDeepCloneable<FlowActionCtxPb>, IBufferMessage
	{
		// Token: 0x06008BB4 RID: 35764 RVA: 0x0015389A File Offset: 0x00151A9A
		[NullableContext(1)]
		public static FlowActionCtxPb Create()
		{
			return new FlowActionCtxPb();
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06008BB5 RID: 35765 RVA: 0x001538A1 File Offset: 0x00151AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x001538A4 File Offset: 0x00151AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06008BB7 RID: 35767 RVA: 0x001538AB File Offset: 0x00151AAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionCtxPb()
		{
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x001538C0 File Offset: 0x00151AC0
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

		// Token: 0x06008BB9 RID: 35769 RVA: 0x00153914 File Offset: 0x00151B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowActionCtxPb Clone()
		{
			return new FlowActionCtxPb(this);
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06008BBA RID: 35770 RVA: 0x0015391C File Offset: 0x00151B1C
		// (set) Token: 0x06008BBB RID: 35771 RVA: 0x00153924 File Offset: 0x00151B24
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

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06008BBC RID: 35772 RVA: 0x00153937 File Offset: 0x00151B37
		// (set) Token: 0x06008BBD RID: 35773 RVA: 0x0015393F File Offset: 0x00151B3F
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

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06008BBE RID: 35774 RVA: 0x00153948 File Offset: 0x00151B48
		// (set) Token: 0x06008BBF RID: 35775 RVA: 0x00153950 File Offset: 0x00151B50
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

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06008BC0 RID: 35776 RVA: 0x00153959 File Offset: 0x00151B59
		// (set) Token: 0x06008BC1 RID: 35777 RVA: 0x00153961 File Offset: 0x00151B61
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

		// Token: 0x06008BC2 RID: 35778 RVA: 0x0015396A File Offset: 0x00151B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowActionCtxPb);
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x00153978 File Offset: 0x00151B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowActionCtxPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && this.ActionId == other.ActionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x001539E8 File Offset: 0x00151BE8
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

		// Token: 0x06008BC5 RID: 35781 RVA: 0x00153A74 File Offset: 0x00151C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x00153A81 File Offset: 0x00151C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x00153A8C File Offset: 0x00151C8C
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

		// Token: 0x06008BC8 RID: 35784 RVA: 0x00153B24 File Offset: 0x00151D24
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

		// Token: 0x06008BC9 RID: 35785 RVA: 0x00153BB0 File Offset: 0x00151DB0
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

		// Token: 0x06008BCA RID: 35786 RVA: 0x00153C2D File Offset: 0x00151E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x00153C38 File Offset: 0x00151E38
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

		// Token: 0x040044EB RID: 17643
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044EC RID: 17644
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x040044ED RID: 17645
		private string flowListName_ = "";

		// Token: 0x040044EE RID: 17646
		public const int FlowIdFieldNumber = 2;

		// Token: 0x040044EF RID: 17647
		private int flowId_;

		// Token: 0x040044F0 RID: 17648
		public const int StateIdFieldNumber = 3;

		// Token: 0x040044F1 RID: 17649
		private int stateId_;

		// Token: 0x040044F2 RID: 17650
		public const int ActionIdFieldNumber = 4;

		// Token: 0x040044F3 RID: 17651
		private int actionId_;
	}
}
