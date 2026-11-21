using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136D RID: 4973
	[NetMessage(EMessageId.SwitchLogicStatePush)]
	public sealed class SwitchLogicStatePush : IMessage<SwitchLogicStatePush>, IMessage, IEquatable<SwitchLogicStatePush>, IDeepCloneable<SwitchLogicStatePush>, IBufferMessage
	{
		// Token: 0x0601A7C2 RID: 108482 RVA: 0x003DBF50 File Offset: 0x003DA150
		[NullableContext(1)]
		public static SwitchLogicStatePush Create()
		{
			return new SwitchLogicStatePush();
		}

		// Token: 0x170059AB RID: 22955
		// (get) Token: 0x0601A7C3 RID: 108483 RVA: 0x003DBF57 File Offset: 0x003DA157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059AC RID: 22956
		// (get) Token: 0x0601A7C4 RID: 108484 RVA: 0x003DBF5A File Offset: 0x003DA15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStatePush.Descriptor;
			}
		}

		// Token: 0x0601A7C5 RID: 108485 RVA: 0x003DBF61 File Offset: 0x003DA161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStatePush()
		{
		}

		// Token: 0x0601A7C6 RID: 108486 RVA: 0x003DBF6C File Offset: 0x003DA16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStatePush(SwitchLogicStatePush other) : this()
		{
			this.states_ = ((other.states_ != null) ? other.states_.Clone() : null);
			this.clientEntityId_ = other.clientEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7C7 RID: 108487 RVA: 0x003DBFB8 File Offset: 0x003DA1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStatePush Clone()
		{
			return new SwitchLogicStatePush(this);
		}

		// Token: 0x170059AD RID: 22957
		// (get) Token: 0x0601A7C8 RID: 108488 RVA: 0x003DBFC0 File Offset: 0x003DA1C0
		// (set) Token: 0x0601A7C9 RID: 108489 RVA: 0x003DBFC8 File Offset: 0x003DA1C8
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

		// Token: 0x170059AE RID: 22958
		// (get) Token: 0x0601A7CA RID: 108490 RVA: 0x003DBFD1 File Offset: 0x003DA1D1
		// (set) Token: 0x0601A7CB RID: 108491 RVA: 0x003DBFD9 File Offset: 0x003DA1D9
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

		// Token: 0x0601A7CC RID: 108492 RVA: 0x003DBFE2 File Offset: 0x003DA1E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStatePush);
		}

		// Token: 0x0601A7CD RID: 108493 RVA: 0x003DBFF0 File Offset: 0x003DA1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStatePush other)
		{
			return other != null && (other == this || (object.Equals(this.States, other.States) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7CE RID: 108494 RVA: 0x003DC040 File Offset: 0x003DA240
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

		// Token: 0x0601A7CF RID: 108495 RVA: 0x003DC095 File Offset: 0x003DA295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7D0 RID: 108496 RVA: 0x003DC0A2 File Offset: 0x003DA2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7D1 RID: 108497 RVA: 0x003DC0AC File Offset: 0x003DA2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.states_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.States);
			}
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A7D2 RID: 108498 RVA: 0x003DC108 File Offset: 0x003DA308
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

		// Token: 0x0601A7D3 RID: 108499 RVA: 0x003DC160 File Offset: 0x003DA360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchLogicStatePush other)
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

		// Token: 0x0601A7D4 RID: 108500 RVA: 0x003DC1C8 File Offset: 0x003DA3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7D5 RID: 108501 RVA: 0x003DC1D4 File Offset: 0x003DA3D4
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
				if (num != 50U)
				{
					if (num != 112U)
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

		// Token: 0x04009B57 RID: 39767
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B58 RID: 39768
		public const int StatesFieldNumber = 6;

		// Token: 0x04009B59 RID: 39769
		private LogicStateComponentPb states_;

		// Token: 0x04009B5A RID: 39770
		public const int ClientEntityIdFieldNumber = 14;

		// Token: 0x04009B5B RID: 39771
		private long clientEntityId_;
	}
}
