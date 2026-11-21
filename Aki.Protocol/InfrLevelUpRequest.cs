using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CC RID: 1996
	[NetMessage(EMessageId.InfrLevelUpRequest)]
	public sealed class InfrLevelUpRequest : IMessage<InfrLevelUpRequest>, IMessage, IEquatable<InfrLevelUpRequest>, IDeepCloneable<InfrLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600B3A4 RID: 45988 RVA: 0x001ADD47 File Offset: 0x001ABF47
		[NullableContext(1)]
		public static InfrLevelUpRequest Create()
		{
			return new InfrLevelUpRequest();
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x0600B3A5 RID: 45989 RVA: 0x001ADD4E File Offset: 0x001ABF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x0600B3A6 RID: 45990 RVA: 0x001ADD51 File Offset: 0x001ABF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x001ADD58 File Offset: 0x001ABF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpRequest()
		{
		}

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x001ADD60 File Offset: 0x001ABF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpRequest(InfrLevelUpRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x001ADD79 File Offset: 0x001ABF79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrLevelUpRequest Clone()
		{
			return new InfrLevelUpRequest(this);
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x001ADD81 File Offset: 0x001ABF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrLevelUpRequest);
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x001ADD8F File Offset: 0x001ABF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrLevelUpRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B3AC RID: 45996 RVA: 0x001ADDB0 File Offset: 0x001ABFB0
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

		// Token: 0x0600B3AD RID: 45997 RVA: 0x001ADDD6 File Offset: 0x001ABFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3AE RID: 45998 RVA: 0x001ADDE3 File Offset: 0x001ABFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3AF RID: 45999 RVA: 0x001ADDEC File Offset: 0x001ABFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3B0 RID: 46000 RVA: 0x001ADE04 File Offset: 0x001AC004
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

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x001ADE2A File Offset: 0x001AC02A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3B2 RID: 46002 RVA: 0x001ADE47 File Offset: 0x001AC047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x001ADE50 File Offset: 0x001AC050
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

		// Token: 0x04005062 RID: 20578
		private UnknownFieldSet _unknownFields;
	}
}
