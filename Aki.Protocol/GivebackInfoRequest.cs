using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006EE RID: 1774
	[NetMessage(EMessageId.GivebackInfoRequest)]
	public sealed class GivebackInfoRequest : IMessage<GivebackInfoRequest>, IMessage, IEquatable<GivebackInfoRequest>, IDeepCloneable<GivebackInfoRequest>, IBufferMessage
	{
		// Token: 0x0600A1BD RID: 41405 RVA: 0x001875CE File Offset: 0x001857CE
		[NullableContext(1)]
		public static GivebackInfoRequest Create()
		{
			return new GivebackInfoRequest();
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x0600A1BE RID: 41406 RVA: 0x001875D5 File Offset: 0x001857D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x001875D8 File Offset: 0x001857D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GivebackInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x001875DF File Offset: 0x001857DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoRequest()
		{
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x001875E7 File Offset: 0x001857E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoRequest(GivebackInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x00187600 File Offset: 0x00185800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GivebackInfoRequest Clone()
		{
			return new GivebackInfoRequest(this);
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x00187608 File Offset: 0x00185808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GivebackInfoRequest);
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x00187616 File Offset: 0x00185816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GivebackInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x00187634 File Offset: 0x00185834
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

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x0018765A File Offset: 0x0018585A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x00187667 File Offset: 0x00185867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x00187670 File Offset: 0x00185870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x00187688 File Offset: 0x00185888
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

		// Token: 0x0600A1CA RID: 41418 RVA: 0x001876AE File Offset: 0x001858AE
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

		// Token: 0x0600A1CB RID: 41419 RVA: 0x001876CB File Offset: 0x001858CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x001876D4 File Offset: 0x001858D4
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

		// Token: 0x04004B14 RID: 19220
		private UnknownFieldSet _unknownFields;
	}
}
