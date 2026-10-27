using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000369 RID: 873
	[NetMessage(EMessageId.DangoBrawlScoreRewardResponse)]
	public sealed class DangoBrawlScoreRewardResponse : IMessage<DangoBrawlScoreRewardResponse>, IMessage, IEquatable<DangoBrawlScoreRewardResponse>, IDeepCloneable<DangoBrawlScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x060056FA RID: 22266 RVA: 0x000D48EC File Offset: 0x000D2AEC
		[NullableContext(1)]
		public static DangoBrawlScoreRewardResponse Create()
		{
			return new DangoBrawlScoreRewardResponse();
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x000D48F3 File Offset: 0x000D2AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x000D48F6 File Offset: 0x000D2AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x000D48FD File Offset: 0x000D2AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardResponse()
		{
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x000D4905 File Offset: 0x000D2B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardResponse(DangoBrawlScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x000D492A File Offset: 0x000D2B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlScoreRewardResponse Clone()
		{
			return new DangoBrawlScoreRewardResponse(this);
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x000D4932 File Offset: 0x000D2B32
		// (set) Token: 0x06005701 RID: 22273 RVA: 0x000D493A File Offset: 0x000D2B3A
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

		// Token: 0x06005702 RID: 22274 RVA: 0x000D4943 File Offset: 0x000D2B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlScoreRewardResponse);
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x000D4951 File Offset: 0x000D2B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x000D4980 File Offset: 0x000D2B80
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

		// Token: 0x06005705 RID: 22277 RVA: 0x000D49C5 File Offset: 0x000D2BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x000D49D2 File Offset: 0x000D2BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x000D49DB File Offset: 0x000D2BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x000D4A10 File Offset: 0x000D2C10
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

		// Token: 0x06005709 RID: 22281 RVA: 0x000D4A4E File Offset: 0x000D2C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlScoreRewardResponse other)
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

		// Token: 0x0600570A RID: 22282 RVA: 0x000D4A7F File Offset: 0x000D2C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x000D4A88 File Offset: 0x000D2C88
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040034B0 RID: 13488
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034B1 RID: 13489
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x040034B2 RID: 13490
		private ErrorCode errCode_;
	}
}
