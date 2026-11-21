using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007EA RID: 2026
	[NetMessage(EMessageId.InfrV2ManualCancelTraceTreeRequest)]
	public sealed class InfrV2ManualCancelTraceTreeRequest : IMessage<InfrV2ManualCancelTraceTreeRequest>, IMessage, IEquatable<InfrV2ManualCancelTraceTreeRequest>, IDeepCloneable<InfrV2ManualCancelTraceTreeRequest>, IBufferMessage
	{
		// Token: 0x0600B5E6 RID: 46566 RVA: 0x001B2554 File Offset: 0x001B0754
		[NullableContext(1)]
		public static InfrV2ManualCancelTraceTreeRequest Create()
		{
			return new InfrV2ManualCancelTraceTreeRequest();
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x0600B5E7 RID: 46567 RVA: 0x001B255B File Offset: 0x001B075B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x0600B5E8 RID: 46568 RVA: 0x001B255E File Offset: 0x001B075E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualCancelTraceTreeRequest.Descriptor;
			}
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x001B2565 File Offset: 0x001B0765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeRequest()
		{
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x001B256D File Offset: 0x001B076D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeRequest(InfrV2ManualCancelTraceTreeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x001B2586 File Offset: 0x001B0786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeRequest Clone()
		{
			return new InfrV2ManualCancelTraceTreeRequest(this);
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x001B258E File Offset: 0x001B078E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualCancelTraceTreeRequest);
		}

		// Token: 0x0600B5ED RID: 46573 RVA: 0x001B259C File Offset: 0x001B079C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualCancelTraceTreeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B5EE RID: 46574 RVA: 0x001B25BC File Offset: 0x001B07BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B5EF RID: 46575 RVA: 0x001B25E2 File Offset: 0x001B07E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x001B25EF File Offset: 0x001B07EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5F1 RID: 46577 RVA: 0x001B25F8 File Offset: 0x001B07F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5F2 RID: 46578 RVA: 0x001B2610 File Offset: 0x001B0810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B5F3 RID: 46579 RVA: 0x001B2636 File Offset: 0x001B0836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ManualCancelTraceTreeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5F4 RID: 46580 RVA: 0x001B2653 File Offset: 0x001B0853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5F5 RID: 46581 RVA: 0x001B265C File Offset: 0x001B085C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050EC RID: 20716
		private UnknownFieldSet _unknownFields;
	}
}
