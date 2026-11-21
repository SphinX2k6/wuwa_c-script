using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115C RID: 4444
	[NetMessage(EMessageId.RoverRogueShopBuyResponse)]
	public sealed class RoverRogueShopBuyResponse : IMessage<RoverRogueShopBuyResponse>, IMessage, IEquatable<RoverRogueShopBuyResponse>, IDeepCloneable<RoverRogueShopBuyResponse>, IBufferMessage
	{
		// Token: 0x06017BFD RID: 97277 RVA: 0x00375434 File Offset: 0x00373634
		[NullableContext(1)]
		public static RoverRogueShopBuyResponse Create()
		{
			return new RoverRogueShopBuyResponse();
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x06017BFE RID: 97278 RVA: 0x0037543B File Offset: 0x0037363B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x06017BFF RID: 97279 RVA: 0x0037543E File Offset: 0x0037363E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopBuyResponse.Descriptor;
			}
		}

		// Token: 0x06017C00 RID: 97280 RVA: 0x00375445 File Offset: 0x00373645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyResponse()
		{
		}

		// Token: 0x06017C01 RID: 97281 RVA: 0x0037544D File Offset: 0x0037364D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyResponse(RoverRogueShopBuyResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C02 RID: 97282 RVA: 0x00375472 File Offset: 0x00373672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyResponse Clone()
		{
			return new RoverRogueShopBuyResponse(this);
		}

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x06017C03 RID: 97283 RVA: 0x0037547A File Offset: 0x0037367A
		// (set) Token: 0x06017C04 RID: 97284 RVA: 0x00375482 File Offset: 0x00373682
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

		// Token: 0x06017C05 RID: 97285 RVA: 0x0037548B File Offset: 0x0037368B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopBuyResponse);
		}

		// Token: 0x06017C06 RID: 97286 RVA: 0x00375499 File Offset: 0x00373699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopBuyResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C07 RID: 97287 RVA: 0x003754C8 File Offset: 0x003736C8
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

		// Token: 0x06017C08 RID: 97288 RVA: 0x0037550D File Offset: 0x0037370D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C09 RID: 97289 RVA: 0x0037551A File Offset: 0x0037371A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C0A RID: 97290 RVA: 0x00375523 File Offset: 0x00373723
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

		// Token: 0x06017C0B RID: 97291 RVA: 0x00375558 File Offset: 0x00373758
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

		// Token: 0x06017C0C RID: 97292 RVA: 0x00375596 File Offset: 0x00373796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopBuyResponse other)
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

		// Token: 0x06017C0D RID: 97293 RVA: 0x003755C7 File Offset: 0x003737C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C0E RID: 97294 RVA: 0x003755D0 File Offset: 0x003737D0
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

		// Token: 0x04008DC1 RID: 36289
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DC2 RID: 36290
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04008DC3 RID: 36291
		private ErrorCode errorCode_;
	}
}
