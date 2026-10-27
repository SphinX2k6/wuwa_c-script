using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E4 RID: 2020
	[NetMessage(EMessageId.InfrManualCancelTraceRoadRequest)]
	public sealed class InfrManualCancelTraceRoadRequest : IMessage<InfrManualCancelTraceRoadRequest>, IMessage, IEquatable<InfrManualCancelTraceRoadRequest>, IDeepCloneable<InfrManualCancelTraceRoadRequest>, IBufferMessage
	{
		// Token: 0x0600B543 RID: 46403 RVA: 0x001B108A File Offset: 0x001AF28A
		[NullableContext(1)]
		public static InfrManualCancelTraceRoadRequest Create()
		{
			return new InfrManualCancelTraceRoadRequest();
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600B544 RID: 46404 RVA: 0x001B1091 File Offset: 0x001AF291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x0600B545 RID: 46405 RVA: 0x001B1094 File Offset: 0x001AF294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrManualCancelTraceRoadRequest.Descriptor;
			}
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x001B109B File Offset: 0x001AF29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadRequest()
		{
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x001B10A3 File Offset: 0x001AF2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadRequest(InfrManualCancelTraceRoadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x001B10BC File Offset: 0x001AF2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrManualCancelTraceRoadRequest Clone()
		{
			return new InfrManualCancelTraceRoadRequest(this);
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x001B10C4 File Offset: 0x001AF2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrManualCancelTraceRoadRequest);
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x001B10D2 File Offset: 0x001AF2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrManualCancelTraceRoadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x001B10F0 File Offset: 0x001AF2F0
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

		// Token: 0x0600B54C RID: 46412 RVA: 0x001B1116 File Offset: 0x001AF316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x001B1123 File Offset: 0x001AF323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x001B112C File Offset: 0x001AF32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x001B1144 File Offset: 0x001AF344
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

		// Token: 0x0600B550 RID: 46416 RVA: 0x001B116A File Offset: 0x001AF36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrManualCancelTraceRoadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x001B1187 File Offset: 0x001AF387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B552 RID: 46418 RVA: 0x001B1190 File Offset: 0x001AF390
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

		// Token: 0x0400507E RID: 20606
		private UnknownFieldSet _unknownFields;
	}
}
