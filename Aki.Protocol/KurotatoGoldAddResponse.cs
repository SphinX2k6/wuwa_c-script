using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000887 RID: 2183
	[NetMessage(EMessageId.KurotatoGoldAddResponse)]
	public sealed class KurotatoGoldAddResponse : IMessage<KurotatoGoldAddResponse>, IMessage, IEquatable<KurotatoGoldAddResponse>, IDeepCloneable<KurotatoGoldAddResponse>, IBufferMessage
	{
		// Token: 0x0600C261 RID: 49761 RVA: 0x001CD6D1 File Offset: 0x001CB8D1
		[NullableContext(1)]
		public static KurotatoGoldAddResponse Create()
		{
			return new KurotatoGoldAddResponse();
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x0600C262 RID: 49762 RVA: 0x001CD6D8 File Offset: 0x001CB8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x0600C263 RID: 49763 RVA: 0x001CD6DB File Offset: 0x001CB8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoGoldAddResponse.Descriptor;
			}
		}

		// Token: 0x0600C264 RID: 49764 RVA: 0x001CD6E2 File Offset: 0x001CB8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddResponse()
		{
		}

		// Token: 0x0600C265 RID: 49765 RVA: 0x001CD6EA File Offset: 0x001CB8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddResponse(KurotatoGoldAddResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C266 RID: 49766 RVA: 0x001CD70F File Offset: 0x001CB90F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoGoldAddResponse Clone()
		{
			return new KurotatoGoldAddResponse(this);
		}

		// Token: 0x17002742 RID: 10050
		// (get) Token: 0x0600C267 RID: 49767 RVA: 0x001CD717 File Offset: 0x001CB917
		// (set) Token: 0x0600C268 RID: 49768 RVA: 0x001CD71F File Offset: 0x001CB91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x001CD728 File Offset: 0x001CB928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoGoldAddResponse);
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x001CD736 File Offset: 0x001CB936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoGoldAddResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x001CD764 File Offset: 0x001CB964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x001CD7A9 File Offset: 0x001CB9A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C26D RID: 49773 RVA: 0x001CD7B6 File Offset: 0x001CB9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C26E RID: 49774 RVA: 0x001CD7BF File Offset: 0x001CB9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C26F RID: 49775 RVA: 0x001CD7F4 File Offset: 0x001CB9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x001CD832 File Offset: 0x001CBA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoGoldAddResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x001CD863 File Offset: 0x001CBA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C272 RID: 49778 RVA: 0x001CD86C File Offset: 0x001CBA6C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005471 RID: 21617
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005472 RID: 21618
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04005473 RID: 21619
		private ErrorCode errorCode_;
	}
}
