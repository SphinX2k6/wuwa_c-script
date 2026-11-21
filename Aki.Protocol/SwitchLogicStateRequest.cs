using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136E RID: 4974
	[NetMessage(EMessageId.SwitchLogicStateRequest)]
	public sealed class SwitchLogicStateRequest : IMessage<SwitchLogicStateRequest>, IMessage, IEquatable<SwitchLogicStateRequest>, IDeepCloneable<SwitchLogicStateRequest>, IBufferMessage
	{
		// Token: 0x0601A7D6 RID: 108502 RVA: 0x003DC23F File Offset: 0x003DA43F
		[NullableContext(1)]
		public static SwitchLogicStateRequest Create()
		{
			return new SwitchLogicStateRequest();
		}

		// Token: 0x170059AF RID: 22959
		// (get) Token: 0x0601A7D7 RID: 108503 RVA: 0x003DC246 File Offset: 0x003DA446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059B0 RID: 22960
		// (get) Token: 0x0601A7D8 RID: 108504 RVA: 0x003DC249 File Offset: 0x003DA449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStateRequest.Descriptor;
			}
		}

		// Token: 0x0601A7D9 RID: 108505 RVA: 0x003DC250 File Offset: 0x003DA450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest()
		{
		}

		// Token: 0x0601A7DA RID: 108506 RVA: 0x003DC258 File Offset: 0x003DA458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest(SwitchLogicStateRequest other) : this()
		{
			this.states_ = ((other.states_ != null) ? other.states_.Clone() : null);
			this.clientEntityId_ = other.clientEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7DB RID: 108507 RVA: 0x003DC2A4 File Offset: 0x003DA4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest Clone()
		{
			return new SwitchLogicStateRequest(this);
		}

		// Token: 0x170059B1 RID: 22961
		// (get) Token: 0x0601A7DC RID: 108508 RVA: 0x003DC2AC File Offset: 0x003DA4AC
		// (set) Token: 0x0601A7DD RID: 108509 RVA: 0x003DC2B4 File Offset: 0x003DA4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateComponentPb States
		{
			get
			{
				return this.states_;
			}
			set
			{
				this.states_ = value;
			}
		}

		// Token: 0x170059B2 RID: 22962
		// (get) Token: 0x0601A7DE RID: 108510 RVA: 0x003DC2BD File Offset: 0x003DA4BD
		// (set) Token: 0x0601A7DF RID: 108511 RVA: 0x003DC2C5 File Offset: 0x003DA4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ClientEntityId
		{
			get
			{
				return this.clientEntityId_;
			}
			set
			{
				this.clientEntityId_ = value;
			}
		}

		// Token: 0x0601A7E0 RID: 108512 RVA: 0x003DC2CE File Offset: 0x003DA4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStateRequest);
		}

		// Token: 0x0601A7E1 RID: 108513 RVA: 0x003DC2DC File Offset: 0x003DA4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.States, other.States) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7E2 RID: 108514 RVA: 0x003DC32C File Offset: 0x003DA52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.states_ != null)
			{
				num ^= this.States.GetHashCode();
			}
			if (this.ClientEntityId != 0L)
			{
				num ^= this.ClientEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A7E3 RID: 108515 RVA: 0x003DC381 File Offset: 0x003DA581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7E4 RID: 108516 RVA: 0x003DC38E File Offset: 0x003DA58E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7E5 RID: 108517 RVA: 0x003DC398 File Offset: 0x003DA598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.states_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.States);
			}
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A7E6 RID: 108518 RVA: 0x003DC3F4 File Offset: 0x003DA5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.states_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.States);
			}
			if (this.ClientEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A7E7 RID: 108519 RVA: 0x003DC44C File Offset: 0x003DA64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLogicStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.states_ != null)
			{
				if (this.states_ == null)
				{
					this.States = new LogicStateComponentPb();
				}
				this.States.MergeFrom(other.States);
			}
			if (other.ClientEntityId != 0L)
			{
				this.ClientEntityId = other.ClientEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A7E8 RID: 108520 RVA: 0x003DC4B4 File Offset: 0x003DA6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7E9 RID: 108521 RVA: 0x003DC4C0 File Offset: 0x003DA6C0
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
				if (num != 74U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ClientEntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.states_ == null)
					{
						this.States = new LogicStateComponentPb();
					}
					input.ReadMessage(this.States);
				}
			}
		}

		// Token: 0x04009B5C RID: 39772
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B5D RID: 39773
		public const int StatesFieldNumber = 9;

		// Token: 0x04009B5E RID: 39774
		private LogicStateComponentPb states_;

		// Token: 0x04009B5F RID: 39775
		public const int ClientEntityIdFieldNumber = 15;

		// Token: 0x04009B60 RID: 39776
		private long clientEntityId_;
	}
}
