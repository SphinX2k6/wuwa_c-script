using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000164 RID: 356
	[NetMessage(EMessageId.BathPhotoRequest)]
	public sealed class BathPhotoRequest : IMessage<BathPhotoRequest>, IMessage, IEquatable<BathPhotoRequest>, IDeepCloneable<BathPhotoRequest>, IBufferMessage
	{
		// Token: 0x06002C67 RID: 11367 RVA: 0x00073825 File Offset: 0x00071A25
		[NullableContext(1)]
		public static BathPhotoRequest Create()
		{
			return new BathPhotoRequest();
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x0007382C File Offset: 0x00071A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x0007382F File Offset: 0x00071A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathPhotoRequest.Descriptor;
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00073836 File Offset: 0x00071A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoRequest()
		{
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x0007383E File Offset: 0x00071A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoRequest(BathPhotoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00073857 File Offset: 0x00071A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoRequest Clone()
		{
			return new BathPhotoRequest(this);
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0007385F File Offset: 0x00071A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathPhotoRequest);
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x0007386D File Offset: 0x00071A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathPhotoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x0007388C File Offset: 0x00071A8C
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

		// Token: 0x06002C70 RID: 11376 RVA: 0x000738B2 File Offset: 0x00071AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000738BF File Offset: 0x00071ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000738C8 File Offset: 0x00071AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000738E0 File Offset: 0x00071AE0
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

		// Token: 0x06002C74 RID: 11380 RVA: 0x00073906 File Offset: 0x00071B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BathPhotoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00073923 File Offset: 0x00071B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x0007392C File Offset: 0x00071B2C
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

		// Token: 0x040027F5 RID: 10229
		private UnknownFieldSet _unknownFields;
	}
}
