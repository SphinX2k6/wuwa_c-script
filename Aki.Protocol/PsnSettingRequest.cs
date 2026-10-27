using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DED RID: 3565
	[NetMessage(EMessageId.PsnSettingRequest)]
	public sealed class PsnSettingRequest : IMessage<PsnSettingRequest>, IMessage, IEquatable<PsnSettingRequest>, IDeepCloneable<PsnSettingRequest>, IBufferMessage
	{
		// Token: 0x060132D7 RID: 78551 RVA: 0x002CB0EE File Offset: 0x002C92EE
		[NullableContext(1)]
		public static PsnSettingRequest Create()
		{
			return new PsnSettingRequest();
		}

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x060132D8 RID: 78552 RVA: 0x002CB0F5 File Offset: 0x002C92F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x060132D9 RID: 78553 RVA: 0x002CB0F8 File Offset: 0x002C92F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PsnSettingRequest.Descriptor;
			}
		}

		// Token: 0x060132DA RID: 78554 RVA: 0x002CB0FF File Offset: 0x002C92FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingRequest()
		{
		}

		// Token: 0x060132DB RID: 78555 RVA: 0x002CB107 File Offset: 0x002C9307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingRequest(PsnSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060132DC RID: 78556 RVA: 0x002CB120 File Offset: 0x002C9320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PsnSettingRequest Clone()
		{
			return new PsnSettingRequest(this);
		}

		// Token: 0x060132DD RID: 78557 RVA: 0x002CB128 File Offset: 0x002C9328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PsnSettingRequest);
		}

		// Token: 0x060132DE RID: 78558 RVA: 0x002CB136 File Offset: 0x002C9336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PsnSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060132DF RID: 78559 RVA: 0x002CB154 File Offset: 0x002C9354
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

		// Token: 0x060132E0 RID: 78560 RVA: 0x002CB17A File Offset: 0x002C937A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132E1 RID: 78561 RVA: 0x002CB187 File Offset: 0x002C9387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132E2 RID: 78562 RVA: 0x002CB190 File Offset: 0x002C9390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060132E3 RID: 78563 RVA: 0x002CB1A8 File Offset: 0x002C93A8
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

		// Token: 0x060132E4 RID: 78564 RVA: 0x002CB1CE File Offset: 0x002C93CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PsnSettingRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060132E5 RID: 78565 RVA: 0x002CB1EB File Offset: 0x002C93EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132E6 RID: 78566 RVA: 0x002CB1F4 File Offset: 0x002C93F4
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

		// Token: 0x0400761A RID: 30234
		private UnknownFieldSet _unknownFields;
	}
}
