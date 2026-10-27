using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F8 RID: 5112
	public sealed class TransitionFlowPb : IMessage<TransitionFlowPb>, IMessage, IEquatable<TransitionFlowPb>, IDeepCloneable<TransitionFlowPb>, IBufferMessage
	{
		// Token: 0x0601B161 RID: 110945 RVA: 0x003EC03F File Offset: 0x003EA23F
		[NullableContext(1)]
		public static TransitionFlowPb Create()
		{
			return new TransitionFlowPb();
		}

		// Token: 0x17005B45 RID: 23365
		// (get) Token: 0x0601B162 RID: 110946 RVA: 0x003EC046 File Offset: 0x003EA246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B46 RID: 23366
		// (get) Token: 0x0601B163 RID: 110947 RVA: 0x003EC049 File Offset: 0x003EA249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TransitionFlowPb.Descriptor;
			}
		}

		// Token: 0x0601B164 RID: 110948 RVA: 0x003EC050 File Offset: 0x003EA250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionFlowPb()
		{
		}

		// Token: 0x0601B165 RID: 110949 RVA: 0x003EC063 File Offset: 0x003EA263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionFlowPb(TransitionFlowPb other) : this()
		{
			this.flowListName_ = other.flowListName_;
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B166 RID: 110950 RVA: 0x003EC0A0 File Offset: 0x003EA2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TransitionFlowPb Clone()
		{
			return new TransitionFlowPb(this);
		}

		// Token: 0x17005B47 RID: 23367
		// (get) Token: 0x0601B167 RID: 110951 RVA: 0x003EC0A8 File Offset: 0x003EA2A8
		// (set) Token: 0x0601B168 RID: 110952 RVA: 0x003EC0B0 File Offset: 0x003EA2B0
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

		// Token: 0x17005B48 RID: 23368
		// (get) Token: 0x0601B169 RID: 110953 RVA: 0x003EC0C3 File Offset: 0x003EA2C3
		// (set) Token: 0x0601B16A RID: 110954 RVA: 0x003EC0CB File Offset: 0x003EA2CB
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

		// Token: 0x17005B49 RID: 23369
		// (get) Token: 0x0601B16B RID: 110955 RVA: 0x003EC0D4 File Offset: 0x003EA2D4
		// (set) Token: 0x0601B16C RID: 110956 RVA: 0x003EC0DC File Offset: 0x003EA2DC
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

		// Token: 0x0601B16D RID: 110957 RVA: 0x003EC0E5 File Offset: 0x003EA2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TransitionFlowPb);
		}

		// Token: 0x0601B16E RID: 110958 RVA: 0x003EC0F4 File Offset: 0x003EA2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TransitionFlowPb other)
		{
			return other != null && (other == this || (!(this.FlowListName != other.FlowListName) && this.FlowId == other.FlowId && this.StateId == other.StateId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B16F RID: 110959 RVA: 0x003EC154 File Offset: 0x003EA354
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

		// Token: 0x0601B170 RID: 110960 RVA: 0x003EC1C7 File Offset: 0x003EA3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B171 RID: 110961 RVA: 0x003EC1D4 File Offset: 0x003EA3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B172 RID: 110962 RVA: 0x003EC1E0 File Offset: 0x003EA3E0
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

		// Token: 0x0601B173 RID: 110963 RVA: 0x003EC25C File Offset: 0x003EA45C
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

		// Token: 0x0601B174 RID: 110964 RVA: 0x003EC2D0 File Offset: 0x003EA4D0
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

		// Token: 0x0601B175 RID: 110965 RVA: 0x003EC339 File Offset: 0x003EA539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B176 RID: 110966 RVA: 0x003EC344 File Offset: 0x003EA544
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

		// Token: 0x04009CAB RID: 40107
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CAC RID: 40108
		public const int FlowListNameFieldNumber = 1;

		// Token: 0x04009CAD RID: 40109
		private string flowListName_ = "";

		// Token: 0x04009CAE RID: 40110
		public const int FlowIdFieldNumber = 2;

		// Token: 0x04009CAF RID: 40111
		private int flowId_;

		// Token: 0x04009CB0 RID: 40112
		public const int StateIdFieldNumber = 3;

		// Token: 0x04009CB1 RID: 40113
		private int stateId_;
	}
}
