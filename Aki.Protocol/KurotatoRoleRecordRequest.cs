using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B8 RID: 2232
	[NetMessage(EMessageId.KurotatoRoleRecordRequest)]
	public sealed class KurotatoRoleRecordRequest : IMessage<KurotatoRoleRecordRequest>, IMessage, IEquatable<KurotatoRoleRecordRequest>, IDeepCloneable<KurotatoRoleRecordRequest>, IBufferMessage
	{
		// Token: 0x0600C607 RID: 50695 RVA: 0x001D4E3B File Offset: 0x001D303B
		[NullableContext(1)]
		public static KurotatoRoleRecordRequest Create()
		{
			return new KurotatoRoleRecordRequest();
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x0600C608 RID: 50696 RVA: 0x001D4E42 File Offset: 0x001D3042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0600C609 RID: 50697 RVA: 0x001D4E45 File Offset: 0x001D3045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRoleRecordRequest.Descriptor;
			}
		}

		// Token: 0x0600C60A RID: 50698 RVA: 0x001D4E4C File Offset: 0x001D304C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordRequest()
		{
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x001D4E54 File Offset: 0x001D3054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordRequest(KurotatoRoleRecordRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C60C RID: 50700 RVA: 0x001D4E6D File Offset: 0x001D306D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRoleRecordRequest Clone()
		{
			return new KurotatoRoleRecordRequest(this);
		}

		// Token: 0x0600C60D RID: 50701 RVA: 0x001D4E75 File Offset: 0x001D3075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRoleRecordRequest);
		}

		// Token: 0x0600C60E RID: 50702 RVA: 0x001D4E83 File Offset: 0x001D3083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRoleRecordRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x001D4EA4 File Offset: 0x001D30A4
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

		// Token: 0x0600C610 RID: 50704 RVA: 0x001D4ECA File Offset: 0x001D30CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C611 RID: 50705 RVA: 0x001D4ED7 File Offset: 0x001D30D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C612 RID: 50706 RVA: 0x001D4EE0 File Offset: 0x001D30E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C613 RID: 50707 RVA: 0x001D4EF8 File Offset: 0x001D30F8
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

		// Token: 0x0600C614 RID: 50708 RVA: 0x001D4F1E File Offset: 0x001D311E
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

		// Token: 0x0600C615 RID: 50709 RVA: 0x001D4F3B File Offset: 0x001D313B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C616 RID: 50710 RVA: 0x001D4F44 File Offset: 0x001D3144
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

		// Token: 0x0400551D RID: 21789
		private UnknownFieldSet _unknownFields;
	}
}
