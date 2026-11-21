using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000122 RID: 290
	[NetMessage(EMessageId.AttachEntityResponse)]
	public sealed class AttachEntityResponse : IMessage<AttachEntityResponse>, IMessage, IEquatable<AttachEntityResponse>, IDeepCloneable<AttachEntityResponse>, IBufferMessage
	{
		// Token: 0x0600274C RID: 10060 RVA: 0x00068607 File Offset: 0x00066807
		[NullableContext(1)]
		public static AttachEntityResponse Create()
		{
			return new AttachEntityResponse();
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x0006860E File Offset: 0x0006680E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x00068611 File Offset: 0x00066811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachEntityResponse.Descriptor;
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00068618 File Offset: 0x00066818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityResponse()
		{
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00068620 File Offset: 0x00066820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityResponse(AttachEntityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00068645 File Offset: 0x00066845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityResponse Clone()
		{
			return new AttachEntityResponse(this);
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x0006864D File Offset: 0x0006684D
		// (set) Token: 0x06002753 RID: 10067 RVA: 0x00068655 File Offset: 0x00066855
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

		// Token: 0x06002754 RID: 10068 RVA: 0x0006865E File Offset: 0x0006685E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachEntityResponse);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0006866C File Offset: 0x0006686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachEntityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0006869C File Offset: 0x0006689C
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

		// Token: 0x06002757 RID: 10071 RVA: 0x000686E1 File Offset: 0x000668E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000686EE File Offset: 0x000668EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000686F7 File Offset: 0x000668F7
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

		// Token: 0x0600275A RID: 10074 RVA: 0x0006872C File Offset: 0x0006692C
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

		// Token: 0x0600275B RID: 10075 RVA: 0x0006876A File Offset: 0x0006696A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttachEntityResponse other)
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

		// Token: 0x0600275C RID: 10076 RVA: 0x0006879B File Offset: 0x0006699B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000687A4 File Offset: 0x000669A4
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

		// Token: 0x040026AB RID: 9899
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026AC RID: 9900
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040026AD RID: 9901
		private ErrorCode errorCode_;
	}
}
