using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F18 RID: 3864
	[NetMessage(EMessageId.RenjuExitMatchedActionResponse)]
	public sealed class RenjuExitMatchedActionResponse : IMessage<RenjuExitMatchedActionResponse>, IMessage, IEquatable<RenjuExitMatchedActionResponse>, IDeepCloneable<RenjuExitMatchedActionResponse>, IBufferMessage
	{
		// Token: 0x06014AF2 RID: 84722 RVA: 0x00300801 File Offset: 0x002FEA01
		[NullableContext(1)]
		public static RenjuExitMatchedActionResponse Create()
		{
			return new RenjuExitMatchedActionResponse();
		}

		// Token: 0x170044C0 RID: 17600
		// (get) Token: 0x06014AF3 RID: 84723 RVA: 0x00300808 File Offset: 0x002FEA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044C1 RID: 17601
		// (get) Token: 0x06014AF4 RID: 84724 RVA: 0x0030080B File Offset: 0x002FEA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuExitMatchedActionResponse.Descriptor;
			}
		}

		// Token: 0x06014AF5 RID: 84725 RVA: 0x00300812 File Offset: 0x002FEA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionResponse()
		{
		}

		// Token: 0x06014AF6 RID: 84726 RVA: 0x0030081A File Offset: 0x002FEA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionResponse(RenjuExitMatchedActionResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014AF7 RID: 84727 RVA: 0x0030083F File Offset: 0x002FEA3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuExitMatchedActionResponse Clone()
		{
			return new RenjuExitMatchedActionResponse(this);
		}

		// Token: 0x170044C2 RID: 17602
		// (get) Token: 0x06014AF8 RID: 84728 RVA: 0x00300847 File Offset: 0x002FEA47
		// (set) Token: 0x06014AF9 RID: 84729 RVA: 0x0030084F File Offset: 0x002FEA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06014AFA RID: 84730 RVA: 0x00300858 File Offset: 0x002FEA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuExitMatchedActionResponse);
		}

		// Token: 0x06014AFB RID: 84731 RVA: 0x00300866 File Offset: 0x002FEA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuExitMatchedActionResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AFC RID: 84732 RVA: 0x00300894 File Offset: 0x002FEA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014AFD RID: 84733 RVA: 0x003008D9 File Offset: 0x002FEAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AFE RID: 84734 RVA: 0x003008E6 File Offset: 0x002FEAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AFF RID: 84735 RVA: 0x003008EF File Offset: 0x002FEAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B00 RID: 84736 RVA: 0x00300924 File Offset: 0x002FEB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B01 RID: 84737 RVA: 0x00300962 File Offset: 0x002FEB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuExitMatchedActionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B02 RID: 84738 RVA: 0x00300993 File Offset: 0x002FEB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B03 RID: 84739 RVA: 0x0030099C File Offset: 0x002FEB9C
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007D09 RID: 32009
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D0A RID: 32010
		public const int ErrCodeFieldNumber = 4;

		// Token: 0x04007D0B RID: 32011
		private ErrorCode errCode_;
	}
}
