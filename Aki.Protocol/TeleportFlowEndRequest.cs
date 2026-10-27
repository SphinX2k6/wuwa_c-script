using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133B RID: 4923
	[NetMessage(EMessageId.TeleportFlowEndRequest)]
	public sealed class TeleportFlowEndRequest : IMessage<TeleportFlowEndRequest>, IMessage, IEquatable<TeleportFlowEndRequest>, IDeepCloneable<TeleportFlowEndRequest>, IBufferMessage
	{
		// Token: 0x0601A26F RID: 107119 RVA: 0x003CC411 File Offset: 0x003CA611
		[NullableContext(1)]
		public static TeleportFlowEndRequest Create()
		{
			return new TeleportFlowEndRequest();
		}

		// Token: 0x17005831 RID: 22577
		// (get) Token: 0x0601A270 RID: 107120 RVA: 0x003CC418 File Offset: 0x003CA618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005832 RID: 22578
		// (get) Token: 0x0601A271 RID: 107121 RVA: 0x003CC41B File Offset: 0x003CA61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFlowEndRequest.Descriptor;
			}
		}

		// Token: 0x0601A272 RID: 107122 RVA: 0x003CC422 File Offset: 0x003CA622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndRequest()
		{
		}

		// Token: 0x0601A273 RID: 107123 RVA: 0x003CC435 File Offset: 0x003CA635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndRequest(TeleportFlowEndRequest other) : this()
		{
			this.flowName_ = other.flowName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A274 RID: 107124 RVA: 0x003CC45A File Offset: 0x003CA65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFlowEndRequest Clone()
		{
			return new TeleportFlowEndRequest(this);
		}

		// Token: 0x17005833 RID: 22579
		// (get) Token: 0x0601A275 RID: 107125 RVA: 0x003CC462 File Offset: 0x003CA662
		// (set) Token: 0x0601A276 RID: 107126 RVA: 0x003CC46A File Offset: 0x003CA66A
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

		// Token: 0x0601A277 RID: 107127 RVA: 0x003CC47D File Offset: 0x003CA67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFlowEndRequest);
		}

		// Token: 0x0601A278 RID: 107128 RVA: 0x003CC48B File Offset: 0x003CA68B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFlowEndRequest other)
		{
			return other != null && (other == this || (!(this.FlowName != other.FlowName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A279 RID: 107129 RVA: 0x003CC4C0 File Offset: 0x003CA6C0
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

		// Token: 0x0601A27A RID: 107130 RVA: 0x003CC501 File Offset: 0x003CA701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A27B RID: 107131 RVA: 0x003CC50E File Offset: 0x003CA70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A27C RID: 107132 RVA: 0x003CC517 File Offset: 0x003CA717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlowName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.FlowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A27D RID: 107133 RVA: 0x003CC550 File Offset: 0x003CA750
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

		// Token: 0x0601A27E RID: 107134 RVA: 0x003CC593 File Offset: 0x003CA793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFlowEndRequest other)
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

		// Token: 0x0601A27F RID: 107135 RVA: 0x003CC5C9 File Offset: 0x003CA7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A280 RID: 107136 RVA: 0x003CC5D4 File Offset: 0x003CA7D4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlowName = input.ReadString();
				}
			}
		}

		// Token: 0x04009894 RID: 39060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009895 RID: 39061
		public const int FlowNameFieldNumber = 1;

		// Token: 0x04009896 RID: 39062
		private string flowName_ = "";
	}
}
