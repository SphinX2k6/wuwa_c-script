using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012E8 RID: 4840
	[NetMessage(EMessageId.SurvivorsStepAdvanceResponse)]
	public sealed class SurvivorsStepAdvanceResponse : IMessage<SurvivorsStepAdvanceResponse>, IMessage, IEquatable<SurvivorsStepAdvanceResponse>, IDeepCloneable<SurvivorsStepAdvanceResponse>, IBufferMessage
	{
		// Token: 0x06019BD8 RID: 105432 RVA: 0x003BDCAE File Offset: 0x003BBEAE
		[NullableContext(1)]
		public static SurvivorsStepAdvanceResponse Create()
		{
			return new SurvivorsStepAdvanceResponse();
		}

		// Token: 0x170056D3 RID: 22227
		// (get) Token: 0x06019BD9 RID: 105433 RVA: 0x003BDCB5 File Offset: 0x003BBEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056D4 RID: 22228
		// (get) Token: 0x06019BDA RID: 105434 RVA: 0x003BDCB8 File Offset: 0x003BBEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsStepAdvanceResponse.Descriptor;
			}
		}

		// Token: 0x06019BDB RID: 105435 RVA: 0x003BDCBF File Offset: 0x003BBEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceResponse()
		{
		}

		// Token: 0x06019BDC RID: 105436 RVA: 0x003BDCC7 File Offset: 0x003BBEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceResponse(SurvivorsStepAdvanceResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BDD RID: 105437 RVA: 0x003BDCEC File Offset: 0x003BBEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsStepAdvanceResponse Clone()
		{
			return new SurvivorsStepAdvanceResponse(this);
		}

		// Token: 0x170056D5 RID: 22229
		// (get) Token: 0x06019BDE RID: 105438 RVA: 0x003BDCF4 File Offset: 0x003BBEF4
		// (set) Token: 0x06019BDF RID: 105439 RVA: 0x003BDCFC File Offset: 0x003BBEFC
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

		// Token: 0x06019BE0 RID: 105440 RVA: 0x003BDD05 File Offset: 0x003BBF05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsStepAdvanceResponse);
		}

		// Token: 0x06019BE1 RID: 105441 RVA: 0x003BDD13 File Offset: 0x003BBF13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsStepAdvanceResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BE2 RID: 105442 RVA: 0x003BDD44 File Offset: 0x003BBF44
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

		// Token: 0x06019BE3 RID: 105443 RVA: 0x003BDD89 File Offset: 0x003BBF89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BE4 RID: 105444 RVA: 0x003BDD96 File Offset: 0x003BBF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BE5 RID: 105445 RVA: 0x003BDD9F File Offset: 0x003BBF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019BE6 RID: 105446 RVA: 0x003BDDD4 File Offset: 0x003BBFD4
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

		// Token: 0x06019BE7 RID: 105447 RVA: 0x003BDE12 File Offset: 0x003BC012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsStepAdvanceResponse other)
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

		// Token: 0x06019BE8 RID: 105448 RVA: 0x003BDE43 File Offset: 0x003BC043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BE9 RID: 105449 RVA: 0x003BDE4C File Offset: 0x003BC04C
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040096BF RID: 38591
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096C0 RID: 38592
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x040096C1 RID: 38593
		private ErrorCode errCode_;
	}
}
