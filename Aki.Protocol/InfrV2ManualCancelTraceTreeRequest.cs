using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007FE RID: 2046
	[NetMessage(EMessageId.InfrV2ManualCancelTraceTreeRequest)]
	public sealed class InfrV2ManualCancelTraceTreeRequest : IMessage<InfrV2ManualCancelTraceTreeRequest>, IMessage, IEquatable<InfrV2ManualCancelTraceTreeRequest>, IDeepCloneable<InfrV2ManualCancelTraceTreeRequest>, IBufferMessage
	{
		// Token: 0x0600B73C RID: 46908 RVA: 0x001B4F91 File Offset: 0x001B3191
		[NullableContext(1)]
		public static InfrV2ManualCancelTraceTreeRequest Create()
		{
			return new InfrV2ManualCancelTraceTreeRequest();
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x0600B73D RID: 46909 RVA: 0x001B4F98 File Offset: 0x001B3198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x0600B73E RID: 46910 RVA: 0x001B4F9B File Offset: 0x001B319B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ManualCancelTraceTreeRequest.Descriptor;
			}
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x001B4FA2 File Offset: 0x001B31A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeRequest()
		{
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x001B4FAA File Offset: 0x001B31AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeRequest(InfrV2ManualCancelTraceTreeRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x001B4FC3 File Offset: 0x001B31C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ManualCancelTraceTreeRequest Clone()
		{
			return new InfrV2ManualCancelTraceTreeRequest(this);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x001B4FCB File Offset: 0x001B31CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ManualCancelTraceTreeRequest);
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x001B4FD9 File Offset: 0x001B31D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ManualCancelTraceTreeRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x001B4FF8 File Offset: 0x001B31F8
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

		// Token: 0x0600B745 RID: 46917 RVA: 0x001B501E File Offset: 0x001B321E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x001B502B File Offset: 0x001B322B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x001B5034 File Offset: 0x001B3234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x001B504C File Offset: 0x001B324C
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

		// Token: 0x0600B749 RID: 46921 RVA: 0x001B5072 File Offset: 0x001B3272
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

		// Token: 0x0600B74A RID: 46922 RVA: 0x001B508F File Offset: 0x001B328F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x001B5098 File Offset: 0x001B3298
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

		// Token: 0x040050F3 RID: 20723
		private UnknownFieldSet _unknownFields;
	}
}
