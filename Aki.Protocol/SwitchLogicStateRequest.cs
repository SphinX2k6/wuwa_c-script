using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001301 RID: 4865
	[NetMessage(EMessageId.SwitchLogicStateRequest)]
	public sealed class SwitchLogicStateRequest : IMessage<SwitchLogicStateRequest>, IMessage, IEquatable<SwitchLogicStateRequest>, IDeepCloneable<SwitchLogicStateRequest>, IBufferMessage
	{
		// Token: 0x06019DC6 RID: 105926 RVA: 0x003C1F8B File Offset: 0x003C018B
		[NullableContext(1)]
		public static SwitchLogicStateRequest Create()
		{
			return new SwitchLogicStateRequest();
		}

		// Token: 0x17005735 RID: 22325
		// (get) Token: 0x06019DC7 RID: 105927 RVA: 0x003C1F92 File Offset: 0x003C0192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005736 RID: 22326
		// (get) Token: 0x06019DC8 RID: 105928 RVA: 0x003C1F95 File Offset: 0x003C0195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchLogicStateRequest.Descriptor;
			}
		}

		// Token: 0x06019DC9 RID: 105929 RVA: 0x003C1F9C File Offset: 0x003C019C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest()
		{
		}

		// Token: 0x06019DCA RID: 105930 RVA: 0x003C1FA4 File Offset: 0x003C01A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest(SwitchLogicStateRequest other) : this()
		{
			this.states_ = ((other.states_ != null) ? other.states_.Clone() : null);
			this.clientEntityId_ = other.clientEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019DCB RID: 105931 RVA: 0x003C1FF0 File Offset: 0x003C01F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchLogicStateRequest Clone()
		{
			return new SwitchLogicStateRequest(this);
		}

		// Token: 0x17005737 RID: 22327
		// (get) Token: 0x06019DCC RID: 105932 RVA: 0x003C1FF8 File Offset: 0x003C01F8
		// (set) Token: 0x06019DCD RID: 105933 RVA: 0x003C2000 File Offset: 0x003C0200
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

		// Token: 0x17005738 RID: 22328
		// (get) Token: 0x06019DCE RID: 105934 RVA: 0x003C2009 File Offset: 0x003C0209
		// (set) Token: 0x06019DCF RID: 105935 RVA: 0x003C2011 File Offset: 0x003C0211
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

		// Token: 0x06019DD0 RID: 105936 RVA: 0x003C201A File Offset: 0x003C021A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchLogicStateRequest);
		}

		// Token: 0x06019DD1 RID: 105937 RVA: 0x003C2028 File Offset: 0x003C0228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchLogicStateRequest other)
		{
			return other != null && (other == this || (object.Equals(this.States, other.States) && this.ClientEntityId == other.ClientEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019DD2 RID: 105938 RVA: 0x003C2078 File Offset: 0x003C0278
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

		// Token: 0x06019DD3 RID: 105939 RVA: 0x003C20CD File Offset: 0x003C02CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019DD4 RID: 105940 RVA: 0x003C20DA File Offset: 0x003C02DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019DD5 RID: 105941 RVA: 0x003C20E4 File Offset: 0x003C02E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.states_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.States);
			}
			if (this.ClientEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.ClientEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019DD6 RID: 105942 RVA: 0x003C2140 File Offset: 0x003C0340
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

		// Token: 0x06019DD7 RID: 105943 RVA: 0x003C2198 File Offset: 0x003C0398
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

		// Token: 0x06019DD8 RID: 105944 RVA: 0x003C2200 File Offset: 0x003C0400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019DD9 RID: 105945 RVA: 0x003C220C File Offset: 0x003C040C
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
				if (num != 42U)
				{
					if (num != 96U)
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

		// Token: 0x0400973A RID: 38714
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400973B RID: 38715
		public const int StatesFieldNumber = 5;

		// Token: 0x0400973C RID: 38716
		private LogicStateComponentPb states_;

		// Token: 0x0400973D RID: 38717
		public const int ClientEntityIdFieldNumber = 12;

		// Token: 0x0400973E RID: 38718
		private long clientEntityId_;
	}
}
