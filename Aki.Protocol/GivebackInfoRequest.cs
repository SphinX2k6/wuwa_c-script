using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006DA RID: 1754
	[NetMessage(EMessageId.GivebackInfoRequest)]
	public sealed class GivebackInfoRequest : IMessage<GivebackInfoRequest>, IMessage, IEquatable<GivebackInfoRequest>, IDeepCloneable<GivebackInfoRequest>, IBufferMessage
	{
		// Token: 0x0600A067 RID: 41063 RVA: 0x00184B9A File Offset: 0x00182D9A
		[NullableContext(1)]
		public static GivebackInfoRequest Create()
		{
			return new GivebackInfoRequest();
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x0600A068 RID: 41064 RVA: 0x00184BA1 File Offset: 0x00182DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x00184BA4 File Offset: 0x00182DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x00184BAB File Offset: 0x00182DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoRequest()
		{
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x00184BB3 File Offset: 0x00182DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoRequest(GivebackInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x00184BCC File Offset: 0x00182DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoRequest Clone()
		{
			return new GivebackInfoRequest(this);
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x00184BD4 File Offset: 0x00182DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoRequest);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x00184BE2 File Offset: 0x00182DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A06F RID: 41071 RVA: 0x00184C00 File Offset: 0x00182E00
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

		// Token: 0x0600A070 RID: 41072 RVA: 0x00184C26 File Offset: 0x00182E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A071 RID: 41073 RVA: 0x00184C33 File Offset: 0x00182E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A072 RID: 41074 RVA: 0x00184C3C File Offset: 0x00182E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A073 RID: 41075 RVA: 0x00184C54 File Offset: 0x00182E54
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

		// Token: 0x0600A074 RID: 41076 RVA: 0x00184C7A File Offset: 0x00182E7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GivebackInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x00184C97 File Offset: 0x00182E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x00184CA0 File Offset: 0x00182EA0
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

		// Token: 0x04004B0D RID: 19213
		private UnknownFieldSet _unknownFields;
	}
}
