using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000125 RID: 293
	[NetMessage(EMessageId.AttributeChangedResponse)]
	public sealed class AttributeChangedResponse : IMessage<AttributeChangedResponse>, IMessage, IEquatable<AttributeChangedResponse>, IDeepCloneable<AttributeChangedResponse>, IBufferMessage
	{
		// Token: 0x0600274B RID: 10059 RVA: 0x000680FB File Offset: 0x000662FB
		[NullableContext(1)]
		public static AttributeChangedResponse Create()
		{
			return new AttributeChangedResponse();
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x00068102 File Offset: 0x00066302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x00068105 File Offset: 0x00066305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttributeChangedResponse.Descriptor;
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x0006810C File Offset: 0x0006630C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedResponse()
		{
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00068114 File Offset: 0x00066314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedResponse(AttributeChangedResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00068139 File Offset: 0x00066339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttributeChangedResponse Clone()
		{
			return new AttributeChangedResponse(this);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x00068141 File Offset: 0x00066341
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x00068149 File Offset: 0x00066349
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

		// Token: 0x06002753 RID: 10067 RVA: 0x00068152 File Offset: 0x00066352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttributeChangedResponse);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00068160 File Offset: 0x00066360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttributeChangedResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00068190 File Offset: 0x00066390
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

		// Token: 0x06002756 RID: 10070 RVA: 0x000681D5 File Offset: 0x000663D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x000681E2 File Offset: 0x000663E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000681EB File Offset: 0x000663EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00068220 File Offset: 0x00066420
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

		// Token: 0x0600275A RID: 10074 RVA: 0x0006825E File Offset: 0x0006645E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttributeChangedResponse other)
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

		// Token: 0x0600275B RID: 10075 RVA: 0x0006828F File Offset: 0x0006648F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00068298 File Offset: 0x00066498
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002656 RID: 9814
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002657 RID: 9815
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04002658 RID: 9816
		private ErrorCode errorCode_;
	}
}
