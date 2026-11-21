using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF4 RID: 3828
	[NetMessage(EMessageId.RemovePreloadFlowsNotify)]
	public sealed class RemovePreloadFlowsNotify : IMessage<RemovePreloadFlowsNotify>, IMessage, IEquatable<RemovePreloadFlowsNotify>, IDeepCloneable<RemovePreloadFlowsNotify>, IBufferMessage
	{
		// Token: 0x06014889 RID: 84105 RVA: 0x002FC1AF File Offset: 0x002FA3AF
		[NullableContext(1)]
		public static RemovePreloadFlowsNotify Create()
		{
			return new RemovePreloadFlowsNotify();
		}

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x0601488A RID: 84106 RVA: 0x002FC1B6 File Offset: 0x002FA3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x0601488B RID: 84107 RVA: 0x002FC1B9 File Offset: 0x002FA3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemovePreloadFlowsNotify.Descriptor;
			}
		}

		// Token: 0x0601488C RID: 84108 RVA: 0x002FC1C0 File Offset: 0x002FA3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePreloadFlowsNotify()
		{
		}

		// Token: 0x0601488D RID: 84109 RVA: 0x002FC1E0 File Offset: 0x002FA3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePreloadFlowsNotify(RemovePreloadFlowsNotify other) : this()
		{
			this.flowId_ = other.flowId_;
			this.stateId_ = other.stateId_;
			this.flowListName_ = other.flowListName_;
			this.flowGuid_ = other.flowGuid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601488E RID: 84110 RVA: 0x002FC234 File Offset: 0x002FA434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemovePreloadFlowsNotify Clone()
		{
			return new RemovePreloadFlowsNotify(this);
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x0601488F RID: 84111 RVA: 0x002FC23C File Offset: 0x002FA43C
		// (set) Token: 0x06014890 RID: 84112 RVA: 0x002FC244 File Offset: 0x002FA444
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

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x06014891 RID: 84113 RVA: 0x002FC24D File Offset: 0x002FA44D
		// (set) Token: 0x06014892 RID: 84114 RVA: 0x002FC255 File Offset: 0x002FA455
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

		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x06014893 RID: 84115 RVA: 0x002FC25E File Offset: 0x002FA45E
		// (set) Token: 0x06014894 RID: 84116 RVA: 0x002FC266 File Offset: 0x002FA466
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

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x06014895 RID: 84117 RVA: 0x002FC279 File Offset: 0x002FA479
		// (set) Token: 0x06014896 RID: 84118 RVA: 0x002FC281 File Offset: 0x002FA481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowGuid
		{
			get
			{
				return this.flowGuid_;
			}
			set
			{
				this.flowGuid_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06014897 RID: 84119 RVA: 0x002FC294 File Offset: 0x002FA494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemovePreloadFlowsNotify);
		}

		// Token: 0x06014898 RID: 84120 RVA: 0x002FC2A4 File Offset: 0x002FA4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemovePreloadFlowsNotify other)
		{
			return other != null && (other == this || (this.FlowId == other.FlowId && this.StateId == other.StateId && !(this.FlowListName != other.FlowListName) && !(this.FlowGuid != other.FlowGuid) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014899 RID: 84121 RVA: 0x002FC318 File Offset: 0x002FA518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowId != 0)
			{
				num ^= this.FlowId.GetHashCode();
			}
			if (this.StateId != 0)
			{
				num ^= this.StateId.GetHashCode();
			}
			if (this.FlowListName.Length != 0)
			{
				num ^= this.FlowListName.GetHashCode();
			}
			if (this.FlowGuid.Length != 0)
			{
				num ^= this.FlowGuid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601489A RID: 84122 RVA: 0x002FC3A6 File Offset: 0x002FA5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601489B RID: 84123 RVA: 0x002FC3B3 File Offset: 0x002FA5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601489C RID: 84124 RVA: 0x002FC3BC File Offset: 0x002FA5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowListName.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.FlowListName);
			}
			if (this.StateId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.StateId);
			}
			if (this.FlowGuid.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.FlowGuid);
			}
			if (this.FlowId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FlowId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601489D RID: 84125 RVA: 0x002FC458 File Offset: 0x002FA658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlowId);
			}
			if (this.StateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StateId);
			}
			if (this.FlowListName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowListName);
			}
			if (this.FlowGuid.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowGuid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601489E RID: 84126 RVA: 0x002FC4E8 File Offset: 0x002FA6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemovePreloadFlowsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowId != 0)
			{
				this.FlowId = other.FlowId;
			}
			if (other.StateId != 0)
			{
				this.StateId = other.StateId;
			}
			if (other.FlowListName.Length != 0)
			{
				this.FlowListName = other.FlowListName;
			}
			if (other.FlowGuid.Length != 0)
			{
				this.FlowGuid = other.FlowGuid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601489F RID: 84127 RVA: 0x002FC56A File Offset: 0x002FA76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060148A0 RID: 84128 RVA: 0x002FC574 File Offset: 0x002FA774
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
					if (num == 50U)
					{
						this.FlowListName = input.ReadString();
						continue;
					}
					if (num == 56U)
					{
						this.StateId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.FlowGuid = input.ReadString();
						continue;
					}
					if (num == 104U)
					{
						this.FlowId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007CDA RID: 31962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CDB RID: 31963
		public const int FlowIdFieldNumber = 13;

		// Token: 0x04007CDC RID: 31964
		private int flowId_;

		// Token: 0x04007CDD RID: 31965
		public const int StateIdFieldNumber = 7;

		// Token: 0x04007CDE RID: 31966
		private int stateId_;

		// Token: 0x04007CDF RID: 31967
		public const int FlowListNameFieldNumber = 6;

		// Token: 0x04007CE0 RID: 31968
		private string flowListName_ = "";

		// Token: 0x04007CE1 RID: 31969
		public const int FlowGuidFieldNumber = 11;

		// Token: 0x04007CE2 RID: 31970
		private string flowGuid_ = "";
	}
}
