using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000451 RID: 1105
	[NetMessage(EMessageId.EnterBigWorldInstResponse)]
	public sealed class EnterBigWorldInstResponse : IMessage<EnterBigWorldInstResponse>, IMessage, IEquatable<EnterBigWorldInstResponse>, IDeepCloneable<EnterBigWorldInstResponse>, IBufferMessage
	{
		// Token: 0x0600697D RID: 27005 RVA: 0x000FCFC4 File Offset: 0x000FB1C4
		[NullableContext(1)]
		public static EnterBigWorldInstResponse Create()
		{
			return new EnterBigWorldInstResponse();
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x0600697E RID: 27006 RVA: 0x000FCFCB File Offset: 0x000FB1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x0600697F RID: 27007 RVA: 0x000FCFCE File Offset: 0x000FB1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterBigWorldInstResponse.Descriptor;
			}
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x000FCFD5 File Offset: 0x000FB1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstResponse()
		{
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x000FCFDD File Offset: 0x000FB1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstResponse(EnterBigWorldInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x000FD002 File Offset: 0x000FB202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstResponse Clone()
		{
			return new EnterBigWorldInstResponse(this);
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x06006983 RID: 27011 RVA: 0x000FD00A File Offset: 0x000FB20A
		// (set) Token: 0x06006984 RID: 27012 RVA: 0x000FD012 File Offset: 0x000FB212
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

		// Token: 0x06006985 RID: 27013 RVA: 0x000FD01B File Offset: 0x000FB21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterBigWorldInstResponse);
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x000FD029 File Offset: 0x000FB229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterBigWorldInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x000FD058 File Offset: 0x000FB258
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

		// Token: 0x06006988 RID: 27016 RVA: 0x000FD09D File Offset: 0x000FB29D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x000FD0AA File Offset: 0x000FB2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x000FD0B3 File Offset: 0x000FB2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x000FD0E8 File Offset: 0x000FB2E8
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

		// Token: 0x0600698C RID: 27020 RVA: 0x000FD126 File Offset: 0x000FB326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterBigWorldInstResponse other)
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

		// Token: 0x0600698D RID: 27021 RVA: 0x000FD157 File Offset: 0x000FB357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x000FD160 File Offset: 0x000FB360
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040039F6 RID: 14838
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039F7 RID: 14839
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040039F8 RID: 14840
		private ErrorCode errorCode_;
	}
}
