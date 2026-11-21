using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005F2 RID: 1522
	public sealed class FlowStartTeleportCtxPb : IMessage<FlowStartTeleportCtxPb>, IMessage, IEquatable<FlowStartTeleportCtxPb>, IDeepCloneable<FlowStartTeleportCtxPb>, IBufferMessage
	{
		// Token: 0x06008D51 RID: 36177 RVA: 0x00157537 File Offset: 0x00155737
		[NullableContext(1)]
		public static FlowStartTeleportCtxPb Create()
		{
			return new FlowStartTeleportCtxPb();
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06008D52 RID: 36178 RVA: 0x0015753E File Offset: 0x0015573E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06008D53 RID: 36179 RVA: 0x00157541 File Offset: 0x00155741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlowStartTeleportCtxPb.Descriptor;
			}
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x00157548 File Offset: 0x00155748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartTeleportCtxPb()
		{
		}

		// Token: 0x06008D55 RID: 36181 RVA: 0x0015755B File Offset: 0x0015575B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartTeleportCtxPb(FlowStartTeleportCtxPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x00157598 File Offset: 0x00155798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlowStartTeleportCtxPb Clone()
		{
			return new FlowStartTeleportCtxPb(this);
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06008D57 RID: 36183 RVA: 0x001575A0 File Offset: 0x001557A0
		// (set) Token: 0x06008D58 RID: 36184 RVA: 0x001575A8 File Offset: 0x001557A8
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

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06008D59 RID: 36185 RVA: 0x001575BB File Offset: 0x001557BB
		// (set) Token: 0x06008D5A RID: 36186 RVA: 0x001575C3 File Offset: 0x001557C3
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

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06008D5B RID: 36187 RVA: 0x001575CC File Offset: 0x001557CC
		// (set) Token: 0x06008D5C RID: 36188 RVA: 0x001575D4 File Offset: 0x001557D4
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

		// Token: 0x06008D5D RID: 36189 RVA: 0x001575DD File Offset: 0x001557DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlowStartTeleportCtxPb);
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x001575EC File Offset: 0x001557EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlowStartTeleportCtxPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x0015764C File Offset: 0x0015584C
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

		// Token: 0x06008D60 RID: 36192 RVA: 0x001576BF File Offset: 0x001558BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x001576CC File Offset: 0x001558CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x001576D8 File Offset: 0x001558D8
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

		// Token: 0x06008D63 RID: 36195 RVA: 0x00157754 File Offset: 0x00155954
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

		// Token: 0x06008D64 RID: 36196 RVA: 0x001577C8 File Offset: 0x001559C8
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

		// Token: 0x06008D65 RID: 36197 RVA: 0x00157831 File Offset: 0x00155A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x0015783C File Offset: 0x00155A3C
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

		// Token: 0x0400456E RID: 17774
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400456F RID: 17775
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x04004570 RID: 17776
		private string flowListName_ = "";

		// Token: 0x04004571 RID: 17777
		public const int FlowIdFieldNumber = 2;

		// Token: 0x04004572 RID: 17778
		private int flowId_;

		// Token: 0x04004573 RID: 17779
		public const int StateIdFieldNumber = 3;

		// Token: 0x04004574 RID: 17780
		private int stateId_;
	}
}
