using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001234 RID: 4660
	[NetMessage(EMessageId.SitChairResponse)]
	public sealed class SitChairResponse : IMessage<SitChairResponse>, IMessage, IEquatable<SitChairResponse>, IDeepCloneable<SitChairResponse>, IBufferMessage
	{
		// Token: 0x06018D5B RID: 101723 RVA: 0x0039D2E1 File Offset: 0x0039B4E1
		[NullableContext(1)]
		public static SitChairResponse Create()
		{
			return new SitChairResponse();
		}

		// Token: 0x170053BA RID: 21434
		// (get) Token: 0x06018D5C RID: 101724 RVA: 0x0039D2E8 File Offset: 0x0039B4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053BB RID: 21435
		// (get) Token: 0x06018D5D RID: 101725 RVA: 0x0039D2EB File Offset: 0x0039B4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SitChairResponse.Descriptor;
			}
		}

		// Token: 0x06018D5E RID: 101726 RVA: 0x0039D2F2 File Offset: 0x0039B4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairResponse()
		{
		}

		// Token: 0x06018D5F RID: 101727 RVA: 0x0039D2FA File Offset: 0x0039B4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairResponse(SitChairResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D60 RID: 101728 RVA: 0x0039D31F File Offset: 0x0039B51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairResponse Clone()
		{
			return new SitChairResponse(this);
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x06018D61 RID: 101729 RVA: 0x0039D327 File Offset: 0x0039B527
		// (set) Token: 0x06018D62 RID: 101730 RVA: 0x0039D32F File Offset: 0x0039B52F
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

		// Token: 0x06018D63 RID: 101731 RVA: 0x0039D338 File Offset: 0x0039B538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SitChairResponse);
		}

		// Token: 0x06018D64 RID: 101732 RVA: 0x0039D346 File Offset: 0x0039B546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SitChairResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D65 RID: 101733 RVA: 0x0039D374 File Offset: 0x0039B574
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

		// Token: 0x06018D66 RID: 101734 RVA: 0x0039D3B9 File Offset: 0x0039B5B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D67 RID: 101735 RVA: 0x0039D3C6 File Offset: 0x0039B5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D68 RID: 101736 RVA: 0x0039D3CF File Offset: 0x0039B5CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D69 RID: 101737 RVA: 0x0039D404 File Offset: 0x0039B604
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

		// Token: 0x06018D6A RID: 101738 RVA: 0x0039D442 File Offset: 0x0039B642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SitChairResponse other)
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

		// Token: 0x06018D6B RID: 101739 RVA: 0x0039D473 File Offset: 0x0039B673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D6C RID: 101740 RVA: 0x0039D47C File Offset: 0x0039B67C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009283 RID: 37507
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009284 RID: 37508
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009285 RID: 37509
		private ErrorCode errorCode_;
	}
}
