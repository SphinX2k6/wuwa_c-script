using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007E6 RID: 2022
	[NetMessage(EMessageId.InfrV2InfoRequest)]
	public sealed class InfrV2InfoRequest : IMessage<InfrV2InfoRequest>, IMessage, IEquatable<InfrV2InfoRequest>, IDeepCloneable<InfrV2InfoRequest>, IBufferMessage
	{
		// Token: 0x0600B5A0 RID: 46496 RVA: 0x001B1E0C File Offset: 0x001B000C
		[NullableContext(1)]
		public static InfrV2InfoRequest Create()
		{
			return new InfrV2InfoRequest();
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x0600B5A1 RID: 46497 RVA: 0x001B1E13 File Offset: 0x001B0013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x0600B5A2 RID: 46498 RVA: 0x001B1E16 File Offset: 0x001B0016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2InfoRequest.Descriptor;
			}
		}

		// Token: 0x0600B5A3 RID: 46499 RVA: 0x001B1E1D File Offset: 0x001B001D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoRequest()
		{
		}

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x001B1E25 File Offset: 0x001B0025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoRequest(InfrV2InfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B5A5 RID: 46501 RVA: 0x001B1E3E File Offset: 0x001B003E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2InfoRequest Clone()
		{
			return new InfrV2InfoRequest(this);
		}

		// Token: 0x0600B5A6 RID: 46502 RVA: 0x001B1E46 File Offset: 0x001B0046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2InfoRequest);
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x001B1E54 File Offset: 0x001B0054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2InfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x001B1E74 File Offset: 0x001B0074
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

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x001B1E9A File Offset: 0x001B009A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x001B1EA7 File Offset: 0x001B00A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x001B1EB0 File Offset: 0x001B00B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x001B1EC8 File Offset: 0x001B00C8
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

		// Token: 0x0600B5AD RID: 46509 RVA: 0x001B1EEE File Offset: 0x001B00EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2InfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B5AE RID: 46510 RVA: 0x001B1F0B File Offset: 0x001B010B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x001B1F14 File Offset: 0x001B0114
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

		// Token: 0x040050E2 RID: 20706
		private UnknownFieldSet _unknownFields;
	}
}
