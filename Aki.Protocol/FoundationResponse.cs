using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063C RID: 1596
	[NetMessage(EMessageId.FoundationResponse)]
	public sealed class FoundationResponse : IMessage<FoundationResponse>, IMessage, IEquatable<FoundationResponse>, IDeepCloneable<FoundationResponse>, IBufferMessage
	{
		// Token: 0x0600930F RID: 37647 RVA: 0x00163E0C File Offset: 0x0016200C
		[NullableContext(1)]
		public static FoundationResponse Create()
		{
			return new FoundationResponse();
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06009310 RID: 37648 RVA: 0x00163E13 File Offset: 0x00162013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06009311 RID: 37649 RVA: 0x00163E16 File Offset: 0x00162016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationResponse.Descriptor;
			}
		}

		// Token: 0x06009312 RID: 37650 RVA: 0x00163E1D File Offset: 0x0016201D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationResponse()
		{
		}

		// Token: 0x06009313 RID: 37651 RVA: 0x00163E25 File Offset: 0x00162025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationResponse(FoundationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activeOperate_ = other.activeOperate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009314 RID: 37652 RVA: 0x00163E56 File Offset: 0x00162056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationResponse Clone()
		{
			return new FoundationResponse(this);
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x00163E5E File Offset: 0x0016205E
		// (set) Token: 0x06009316 RID: 37654 RVA: 0x00163E66 File Offset: 0x00162066
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

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06009317 RID: 37655 RVA: 0x00163E6F File Offset: 0x0016206F
		// (set) Token: 0x06009318 RID: 37656 RVA: 0x00163E77 File Offset: 0x00162077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveOperate
		{
			get
			{
				return this.activeOperate_;
			}
			set
			{
				this.activeOperate_ = value;
			}
		}

		// Token: 0x06009319 RID: 37657 RVA: 0x00163E80 File Offset: 0x00162080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationResponse);
		}

		// Token: 0x0600931A RID: 37658 RVA: 0x00163E8E File Offset: 0x0016208E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActiveOperate == other.ActiveOperate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600931B RID: 37659 RVA: 0x00163ECC File Offset: 0x001620CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActiveOperate != 0)
			{
				num ^= this.ActiveOperate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600931C RID: 37660 RVA: 0x00163F2A File Offset: 0x0016212A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x00163F37 File Offset: 0x00162137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600931E RID: 37662 RVA: 0x00163F40 File Offset: 0x00162140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActiveOperate != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActiveOperate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600931F RID: 37663 RVA: 0x00163F9C File Offset: 0x0016219C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActiveOperate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveOperate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009320 RID: 37664 RVA: 0x00163FF4 File Offset: 0x001621F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActiveOperate != 0)
			{
				this.ActiveOperate = other.ActiveOperate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009321 RID: 37665 RVA: 0x00164044 File Offset: 0x00162244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009322 RID: 37666 RVA: 0x00164050 File Offset: 0x00162250
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActiveOperate = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040046CE RID: 18126
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046CF RID: 18127
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040046D0 RID: 18128
		private ErrorCode errorCode_;

		// Token: 0x040046D1 RID: 18129
		public const int ActiveOperateFieldNumber = 7;

		// Token: 0x040046D2 RID: 18130
		private int activeOperate_;
	}
}
