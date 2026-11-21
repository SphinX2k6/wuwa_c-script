using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF2 RID: 3314
	[NetMessage(EMessageId.PhantomSettingRequest)]
	public sealed class PhantomSettingRequest : IMessage<PhantomSettingRequest>, IMessage, IEquatable<PhantomSettingRequest>, IDeepCloneable<PhantomSettingRequest>, IBufferMessage
	{
		// Token: 0x06011F04 RID: 73476 RVA: 0x0029FEE7 File Offset: 0x0029E0E7
		[NullableContext(1)]
		public static PhantomSettingRequest Create()
		{
			return new PhantomSettingRequest();
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x06011F05 RID: 73477 RVA: 0x0029FEEE File Offset: 0x0029E0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x06011F06 RID: 73478 RVA: 0x0029FEF1 File Offset: 0x0029E0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomSettingRequest.Descriptor;
			}
		}

		// Token: 0x06011F07 RID: 73479 RVA: 0x0029FEF8 File Offset: 0x0029E0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingRequest()
		{
		}

		// Token: 0x06011F08 RID: 73480 RVA: 0x0029FF00 File Offset: 0x0029E100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingRequest(PhantomSettingRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F09 RID: 73481 RVA: 0x0029FF19 File Offset: 0x0029E119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomSettingRequest Clone()
		{
			return new PhantomSettingRequest(this);
		}

		// Token: 0x06011F0A RID: 73482 RVA: 0x0029FF21 File Offset: 0x0029E121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomSettingRequest);
		}

		// Token: 0x06011F0B RID: 73483 RVA: 0x0029FF2F File Offset: 0x0029E12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomSettingRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06011F0C RID: 73484 RVA: 0x0029FF50 File Offset: 0x0029E150
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

		// Token: 0x06011F0D RID: 73485 RVA: 0x0029FF76 File Offset: 0x0029E176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F0E RID: 73486 RVA: 0x0029FF83 File Offset: 0x0029E183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F0F RID: 73487 RVA: 0x0029FF8C File Offset: 0x0029E18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F10 RID: 73488 RVA: 0x0029FFA4 File Offset: 0x0029E1A4
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

		// Token: 0x06011F11 RID: 73489 RVA: 0x0029FFCA File Offset: 0x0029E1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomSettingRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F12 RID: 73490 RVA: 0x0029FFE7 File Offset: 0x0029E1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F13 RID: 73491 RVA: 0x0029FFF0 File Offset: 0x0029E1F0
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

		// Token: 0x040070DE RID: 28894
		private UnknownFieldSet _unknownFields;
	}
}
