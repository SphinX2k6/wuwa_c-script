using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133D RID: 4925
	[NetMessage(EMessageId.TeleportFlowNotify)]
	public sealed class TeleportFlowNotify : IMessage<TeleportFlowNotify>, IMessage, IEquatable<TeleportFlowNotify>, IDeepCloneable<TeleportFlowNotify>, IBufferMessage
	{
		// Token: 0x0601A293 RID: 107155 RVA: 0x003CC7F9 File Offset: 0x003CA9F9
		[NullableContext(1)]
		public static TeleportFlowNotify Create()
		{
			return new TeleportFlowNotify();
		}

		// Token: 0x17005837 RID: 22583
		// (get) Token: 0x0601A294 RID: 107156 RVA: 0x003CC800 File Offset: 0x003CAA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005838 RID: 22584
		// (get) Token: 0x0601A295 RID: 107157 RVA: 0x003CC803 File Offset: 0x003CAA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFlowNotify.Descriptor;
			}
		}

		// Token: 0x0601A296 RID: 107158 RVA: 0x003CC80A File Offset: 0x003CAA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowNotify()
		{
		}

		// Token: 0x0601A297 RID: 107159 RVA: 0x003CC81D File Offset: 0x003CAA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowNotify(TeleportFlowNotify other) : this()
		{
			this.flowName_ = other.flowName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A298 RID: 107160 RVA: 0x003CC842 File Offset: 0x003CAA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowNotify Clone()
		{
			return new TeleportFlowNotify(this);
		}

		// Token: 0x17005839 RID: 22585
		// (get) Token: 0x0601A299 RID: 107161 RVA: 0x003CC84A File Offset: 0x003CAA4A
		// (set) Token: 0x0601A29A RID: 107162 RVA: 0x003CC852 File Offset: 0x003CAA52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FlowName
		{
			get
			{
				return this.flowName_;
			}
			set
			{
				this.flowName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601A29B RID: 107163 RVA: 0x003CC865 File Offset: 0x003CAA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFlowNotify);
		}

		// Token: 0x0601A29C RID: 107164 RVA: 0x003CC873 File Offset: 0x003CAA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFlowNotify other)
		{
			return other != null && (other == this || (!(this.FlowName != other.FlowName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A29D RID: 107165 RVA: 0x003CC8A8 File Offset: 0x003CAAA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlowName.Length != 0)
			{
				num ^= this.FlowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A29E RID: 107166 RVA: 0x003CC8E9 File Offset: 0x003CAAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A29F RID: 107167 RVA: 0x003CC8F6 File Offset: 0x003CAAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A2A0 RID: 107168 RVA: 0x003CC8FF File Offset: 0x003CAAFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowName.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.FlowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A2A1 RID: 107169 RVA: 0x003CC938 File Offset: 0x003CAB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlowName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FlowName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A2A2 RID: 107170 RVA: 0x003CC97B File Offset: 0x003CAB7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFlowNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlowName.Length != 0)
			{
				this.FlowName = other.FlowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A2A3 RID: 107171 RVA: 0x003CC9B1 File Offset: 0x003CABB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A2A4 RID: 107172 RVA: 0x003CC9BC File Offset: 0x003CABBC
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowName = input.ReadString();
				}
			}
		}

		// Token: 0x0400989A RID: 39066
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400989B RID: 39067
		public const int FlowNameFieldNumber = 3;

		// Token: 0x0400989C RID: 39068
		private string flowName_ = "";
	}
}
