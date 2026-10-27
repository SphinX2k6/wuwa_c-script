using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200055A RID: 1370
	[NetMessage(EMessageId.FishingExitResponse)]
	public sealed class FishingExitResponse : IMessage<FishingExitResponse>, IMessage, IEquatable<FishingExitResponse>, IDeepCloneable<FishingExitResponse>, IBufferMessage
	{
		// Token: 0x06007FD3 RID: 32723 RVA: 0x00134EBA File Offset: 0x001330BA
		[NullableContext(1)]
		public static FishingExitResponse Create()
		{
			return new FishingExitResponse();
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06007FD4 RID: 32724 RVA: 0x00134EC1 File Offset: 0x001330C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x00134EC4 File Offset: 0x001330C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingExitResponse.Descriptor;
			}
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00134ECB File Offset: 0x001330CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitResponse()
		{
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x00134ED3 File Offset: 0x001330D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitResponse(FishingExitResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x00134EEC File Offset: 0x001330EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitResponse Clone()
		{
			return new FishingExitResponse(this);
		}

		// Token: 0x06007FD9 RID: 32729 RVA: 0x00134EF4 File Offset: 0x001330F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingExitResponse);
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x00134F02 File Offset: 0x00133102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingExitResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x00134F20 File Offset: 0x00133120
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

		// Token: 0x06007FDC RID: 32732 RVA: 0x00134F46 File Offset: 0x00133146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x00134F53 File Offset: 0x00133153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x00134F5C File Offset: 0x0013315C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x00134F74 File Offset: 0x00133174
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

		// Token: 0x06007FE0 RID: 32736 RVA: 0x00134F9A File Offset: 0x0013319A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingExitResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x00134FB7 File Offset: 0x001331B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x00134FC0 File Offset: 0x001331C0
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

		// Token: 0x04004075 RID: 16501
		private UnknownFieldSet _unknownFields;
	}
}
