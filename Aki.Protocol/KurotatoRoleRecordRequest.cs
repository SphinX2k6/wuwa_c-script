using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A7 RID: 2215
	[NetMessage(EMessageId.KurotatoRoleRecordRequest)]
	public sealed class KurotatoRoleRecordRequest : IMessage<KurotatoRoleRecordRequest>, IMessage, IEquatable<KurotatoRoleRecordRequest>, IDeepCloneable<KurotatoRoleRecordRequest>, IBufferMessage
	{
		// Token: 0x0600C4EB RID: 50411 RVA: 0x001D2B53 File Offset: 0x001D0D53
		[NullableContext(1)]
		public static KurotatoRoleRecordRequest Create()
		{
			return new KurotatoRoleRecordRequest();
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x0600C4EC RID: 50412 RVA: 0x001D2B5A File Offset: 0x001D0D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600C4ED RID: 50413 RVA: 0x001D2B5D File Offset: 0x001D0D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600C4EE RID: 50414 RVA: 0x001D2B64 File Offset: 0x001D0D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordRequest()
		{
		}

		// Token: 0x0600C4EF RID: 50415 RVA: 0x001D2B6C File Offset: 0x001D0D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordRequest(KurotatoRoleRecordRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4F0 RID: 50416 RVA: 0x001D2B85 File Offset: 0x001D0D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordRequest Clone()
		{
			return new KurotatoRoleRecordRequest(this);
		}

		// Token: 0x0600C4F1 RID: 50417 RVA: 0x001D2B8D File Offset: 0x001D0D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleRecordRequest);
		}

		// Token: 0x0600C4F2 RID: 50418 RVA: 0x001D2B9B File Offset: 0x001D0D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleRecordRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C4F3 RID: 50419 RVA: 0x001D2BBC File Offset: 0x001D0DBC
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

		// Token: 0x0600C4F4 RID: 50420 RVA: 0x001D2BE2 File Offset: 0x001D0DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4F5 RID: 50421 RVA: 0x001D2BEF File Offset: 0x001D0DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4F6 RID: 50422 RVA: 0x001D2BF8 File Offset: 0x001D0DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x001D2C10 File Offset: 0x001D0E10
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

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x001D2C36 File Offset: 0x001D0E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRoleRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x001D2C53 File Offset: 0x001D0E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4FA RID: 50426 RVA: 0x001D2C5C File Offset: 0x001D0E5C
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

		// Token: 0x04005524 RID: 21796
		private UnknownFieldSet _unknownFields;
	}
}
