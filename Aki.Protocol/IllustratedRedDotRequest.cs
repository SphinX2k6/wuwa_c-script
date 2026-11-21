using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B6 RID: 1974
	[NetMessage(EMessageId.IllustratedRedDotRequest)]
	public sealed class IllustratedRedDotRequest : IMessage<IllustratedRedDotRequest>, IMessage, IEquatable<IllustratedRedDotRequest>, IDeepCloneable<IllustratedRedDotRequest>, IBufferMessage
	{
		// Token: 0x0600B204 RID: 45572 RVA: 0x001AAAF3 File Offset: 0x001A8CF3
		[NullableContext(1)]
		public static IllustratedRedDotRequest Create()
		{
			return new IllustratedRedDotRequest();
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600B205 RID: 45573 RVA: 0x001AAAFA File Offset: 0x001A8CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600B206 RID: 45574 RVA: 0x001AAAFD File Offset: 0x001A8CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedRedDotRequest.Descriptor;
			}
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x001AAB04 File Offset: 0x001A8D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotRequest()
		{
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x001AAB0C File Offset: 0x001A8D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotRequest(IllustratedRedDotRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x001AAB25 File Offset: 0x001A8D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedRedDotRequest Clone()
		{
			return new IllustratedRedDotRequest(this);
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x001AAB2D File Offset: 0x001A8D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedRedDotRequest);
		}

		// Token: 0x0600B20B RID: 45579 RVA: 0x001AAB3B File Offset: 0x001A8D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedRedDotRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x001AAB5C File Offset: 0x001A8D5C
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

		// Token: 0x0600B20D RID: 45581 RVA: 0x001AAB82 File Offset: 0x001A8D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x001AAB8F File Offset: 0x001A8D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x001AAB98 File Offset: 0x001A8D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x001AABB0 File Offset: 0x001A8DB0
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

		// Token: 0x0600B211 RID: 45585 RVA: 0x001AABD6 File Offset: 0x001A8DD6
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

		// Token: 0x0600B212 RID: 45586 RVA: 0x001AABF3 File Offset: 0x001A8DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x001AABFC File Offset: 0x001A8DFC
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

		// Token: 0x04005004 RID: 20484
		private UnknownFieldSet _unknownFields;
	}
}
