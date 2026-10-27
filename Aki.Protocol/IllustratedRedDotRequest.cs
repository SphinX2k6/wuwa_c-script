using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CA RID: 1994
	[NetMessage(EMessageId.IllustratedRedDotRequest)]
	public sealed class IllustratedRedDotRequest : IMessage<IllustratedRedDotRequest>, IMessage, IEquatable<IllustratedRedDotRequest>, IDeepCloneable<IllustratedRedDotRequest>, IBufferMessage
	{
		// Token: 0x0600B35A RID: 45914 RVA: 0x001AD522 File Offset: 0x001AB722
		[NullableContext(1)]
		public static IllustratedRedDotRequest Create()
		{
			return new IllustratedRedDotRequest();
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x0600B35B RID: 45915 RVA: 0x001AD529 File Offset: 0x001AB729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x0600B35C RID: 45916 RVA: 0x001AD52C File Offset: 0x001AB72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedRedDotRequest.Descriptor;
			}
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x001AD533 File Offset: 0x001AB733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotRequest()
		{
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x001AD53B File Offset: 0x001AB73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotRequest(IllustratedRedDotRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x001AD554 File Offset: 0x001AB754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotRequest Clone()
		{
			return new IllustratedRedDotRequest(this);
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x001AD55C File Offset: 0x001AB75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedRedDotRequest);
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x001AD56A File Offset: 0x001AB76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedRedDotRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B362 RID: 45922 RVA: 0x001AD588 File Offset: 0x001AB788
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

		// Token: 0x0600B363 RID: 45923 RVA: 0x001AD5AE File Offset: 0x001AB7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x001AD5BB File Offset: 0x001AB7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x001AD5C4 File Offset: 0x001AB7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x001AD5DC File Offset: 0x001AB7DC
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

		// Token: 0x0600B367 RID: 45927 RVA: 0x001AD602 File Offset: 0x001AB802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedRedDotRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B368 RID: 45928 RVA: 0x001AD61F File Offset: 0x001AB81F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B369 RID: 45929 RVA: 0x001AD628 File Offset: 0x001AB828
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

		// Token: 0x0400500B RID: 20491
		private UnknownFieldSet _unknownFields;
	}
}
