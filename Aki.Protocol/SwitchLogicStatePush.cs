using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001300 RID: 4864
	[NetMessage(EMessageId.SwitchLogicStatePush)]
	public sealed class SwitchLogicStatePush : IMessage<SwitchLogicStatePush>, IMessage, IEquatable<SwitchLogicStatePush>, IDeepCloneable<SwitchLogicStatePush>, IBufferMessage
	{
		// Token: 0x06019DB2 RID: 105906 RVA: 0x003C1C9C File Offset: 0x003BFE9C
		[NullableContext(1)]
		public static SwitchLogicStatePush Create()
		{
			return new SwitchLogicStatePush();
		}

		// Token: 0x17005731 RID: 22321
		// (get) Token: 0x06019DB3 RID: 105907 RVA: 0x003C1CA3 File Offset: 0x003BFEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005732 RID: 22322
		// (get) Token: 0x06019DB4 RID: 105908 RVA: 0x003C1CA6 File Offset: 0x003BFEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStatePush.Descriptor;
			}
		}

		// Token: 0x06019DB5 RID: 105909 RVA: 0x003C1CAD File Offset: 0x003BFEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStatePush()
		{
		}

		// Token: 0x06019DB6 RID: 105910 RVA: 0x003C1CB8 File Offset: 0x003BFEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStatePush(SwitchLogicStatePush other) : this()
		{
			this.states_ = ((other.states_ != null) ? other.states_.Clone() : null);
			this.clientEntityId_ = other.clientEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DB7 RID: 105911 RVA: 0x003C1D04 File Offset: 0x003BFF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStatePush Clone()
		{
			return new SwitchLogicStatePush(this);
		}

		// Token: 0x17005733 RID: 22323
		// (get) Token: 0x06019DB8 RID: 105912 RVA: 0x003C1D0C File Offset: 0x003BFF0C
		// (set) Token: 0x06019DB9 RID: 105913 RVA: 0x003C1D14 File Offset: 0x003BFF14
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

		// Token: 0x17005734 RID: 22324
		// (get) Token: 0x06019DBA RID: 105914 RVA: 0x003C1D1D File Offset: 0x003BFF1D
		// (set) Token: 0x06019DBB RID: 105915 RVA: 0x003C1D25 File Offset: 0x003BFF25
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

		// Token: 0x06019DBC RID: 105916 RVA: 0x003C1D2E File Offset: 0x003BFF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStatePush);
		}

		// Token: 0x06019DBD RID: 105917 RVA: 0x003C1D3C File Offset: 0x003BFF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStatePush other)
		{
			return other != null && (other == this || (object.Equals(this.States, other.States) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DBE RID: 105918 RVA: 0x003C1D8C File Offset: 0x003BFF8C
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

		// Token: 0x06019DBF RID: 105919 RVA: 0x003C1DE1 File Offset: 0x003BFFE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DC0 RID: 105920 RVA: 0x003C1DEE File Offset: 0x003BFFEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DC1 RID: 105921 RVA: 0x003C1DF8 File Offset: 0x003BFFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this.states_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.States);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DC2 RID: 105922 RVA: 0x003C1E54 File Offset: 0x003C0054
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

		// Token: 0x06019DC3 RID: 105923 RVA: 0x003C1EAC File Offset: 0x003C00AC
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

		// Token: 0x06019DC4 RID: 105924 RVA: 0x003C1F14 File Offset: 0x003C0114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DC5 RID: 105925 RVA: 0x003C1F20 File Offset: 0x003C0120
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
				if (num != 88U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ClientEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009735 RID: 38709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009736 RID: 38710
		public const int StatesFieldNumber = 14;

		// Token: 0x04009737 RID: 38711
		private LogicStateComponentPb states_;

		// Token: 0x04009738 RID: 38712
		public const int ClientEntityIdFieldNumber = 11;

		// Token: 0x04009739 RID: 38713
		private long clientEntityId_;
	}
}
