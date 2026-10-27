using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000752 RID: 1874
	[NetMessage(EMessageId.HitEndResponse)]
	public sealed class HitEndResponse : IMessage<HitEndResponse>, IMessage, IEquatable<HitEndResponse>, IDeepCloneable<HitEndResponse>, IBufferMessage
	{
		// Token: 0x0600A996 RID: 43414 RVA: 0x0019798E File Offset: 0x00195B8E
		[NullableContext(1)]
		public static HitEndResponse Create()
		{
			return new HitEndResponse();
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600A997 RID: 43415 RVA: 0x00197995 File Offset: 0x00195B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0600A998 RID: 43416 RVA: 0x00197998 File Offset: 0x00195B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitEndResponse.Descriptor;
			}
		}

		// Token: 0x0600A999 RID: 43417 RVA: 0x0019799F File Offset: 0x00195B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndResponse()
		{
		}

		// Token: 0x0600A99A RID: 43418 RVA: 0x001979A7 File Offset: 0x00195BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndResponse(HitEndResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A99B RID: 43419 RVA: 0x001979CC File Offset: 0x00195BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndResponse Clone()
		{
			return new HitEndResponse(this);
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0600A99C RID: 43420 RVA: 0x001979D4 File Offset: 0x00195BD4
		// (set) Token: 0x0600A99D RID: 43421 RVA: 0x001979DC File Offset: 0x00195BDC
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

		// Token: 0x0600A99E RID: 43422 RVA: 0x001979E5 File Offset: 0x00195BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitEndResponse);
		}

		// Token: 0x0600A99F RID: 43423 RVA: 0x001979F3 File Offset: 0x00195BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitEndResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x00197A24 File Offset: 0x00195C24
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

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x00197A69 File Offset: 0x00195C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x00197A76 File Offset: 0x00195C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x00197A7F File Offset: 0x00195C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x00197AB4 File Offset: 0x00195CB4
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

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x00197AF2 File Offset: 0x00195CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitEndResponse other)
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

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x00197B23 File Offset: 0x00195D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x00197B2C File Offset: 0x00195D2C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004D20 RID: 19744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D21 RID: 19745
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004D22 RID: 19746
		private ErrorCode errorCode_;
	}
}
