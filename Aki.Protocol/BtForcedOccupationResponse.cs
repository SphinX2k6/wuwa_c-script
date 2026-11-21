using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001EC RID: 492
	[NetMessage(EMessageId.BtForcedOccupationResponse)]
	public sealed class BtForcedOccupationResponse : IMessage<BtForcedOccupationResponse>, IMessage, IEquatable<BtForcedOccupationResponse>, IDeepCloneable<BtForcedOccupationResponse>, IBufferMessage
	{
		// Token: 0x06003744 RID: 14148 RVA: 0x0008A909 File Offset: 0x00088B09
		[NullableContext(1)]
		public static BtForcedOccupationResponse Create()
		{
			return new BtForcedOccupationResponse();
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x0008A910 File Offset: 0x00088B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x0008A913 File Offset: 0x00088B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtForcedOccupationResponse.Descriptor;
			}
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0008A91A File Offset: 0x00088B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationResponse()
		{
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0008A922 File Offset: 0x00088B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationResponse(BtForcedOccupationResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x0008A947 File Offset: 0x00088B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationResponse Clone()
		{
			return new BtForcedOccupationResponse(this);
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0008A94F File Offset: 0x00088B4F
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x0008A957 File Offset: 0x00088B57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0008A960 File Offset: 0x00088B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtForcedOccupationResponse);
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0008A96E File Offset: 0x00088B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtForcedOccupationResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0008A99C File Offset: 0x00088B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x0008A9E1 File Offset: 0x00088BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x0008A9EE File Offset: 0x00088BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x0008A9F7 File Offset: 0x00088BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x0008AA2C File Offset: 0x00088C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x0008AA6A File Offset: 0x00088C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtForcedOccupationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x0008AA9B File Offset: 0x00088C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x0008AAA4 File Offset: 0x00088CA4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002B2B RID: 11051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B2C RID: 11052
		public const int ErrorIdFieldNumber = 13;

		// Token: 0x04002B2D RID: 11053
		private ErrorCode errorId_;
	}
}
