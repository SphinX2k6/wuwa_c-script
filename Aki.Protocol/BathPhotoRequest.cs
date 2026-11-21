using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000167 RID: 359
	[NetMessage(EMessageId.BathPhotoRequest)]
	public sealed class BathPhotoRequest : IMessage<BathPhotoRequest>, IMessage, IEquatable<BathPhotoRequest>, IDeepCloneable<BathPhotoRequest>, IBufferMessage
	{
		// Token: 0x06002CDE RID: 11486 RVA: 0x00074C55 File Offset: 0x00072E55
		[NullableContext(1)]
		public static BathPhotoRequest Create()
		{
			return new BathPhotoRequest();
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x00074C5C File Offset: 0x00072E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x00074C5F File Offset: 0x00072E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BathPhotoRequest.Descriptor;
			}
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x00074C66 File Offset: 0x00072E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoRequest()
		{
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00074C6E File Offset: 0x00072E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoRequest(BathPhotoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00074C87 File Offset: 0x00072E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BathPhotoRequest Clone()
		{
			return new BathPhotoRequest(this);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00074C8F File Offset: 0x00072E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BathPhotoRequest);
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x00074C9D File Offset: 0x00072E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BathPhotoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x00074CBC File Offset: 0x00072EBC
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

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00074CE2 File Offset: 0x00072EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00074CEF File Offset: 0x00072EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00074CF8 File Offset: 0x00072EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00074D10 File Offset: 0x00072F10
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

		// Token: 0x06002CEB RID: 11499 RVA: 0x00074D36 File Offset: 0x00072F36
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

		// Token: 0x06002CEC RID: 11500 RVA: 0x00074D53 File Offset: 0x00072F53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x00074D5C File Offset: 0x00072F5C
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

		// Token: 0x04002869 RID: 10345
		private UnknownFieldSet _unknownFields;
	}
}
