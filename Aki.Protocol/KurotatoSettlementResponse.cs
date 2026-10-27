using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C2 RID: 2242
	[NetMessage(EMessageId.KurotatoSettlementResponse)]
	public sealed class KurotatoSettlementResponse : IMessage<KurotatoSettlementResponse>, IMessage, IEquatable<KurotatoSettlementResponse>, IDeepCloneable<KurotatoSettlementResponse>, IBufferMessage
	{
		// Token: 0x0600C6C8 RID: 50888 RVA: 0x001D67C6 File Offset: 0x001D49C6
		[NullableContext(1)]
		public static KurotatoSettlementResponse Create()
		{
			return new KurotatoSettlementResponse();
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600C6C9 RID: 50889 RVA: 0x001D67CD File Offset: 0x001D49CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x001D67D0 File Offset: 0x001D49D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSettlementResponse.Descriptor;
			}
		}

		// Token: 0x0600C6CB RID: 50891 RVA: 0x001D67D7 File Offset: 0x001D49D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementResponse()
		{
		}

		// Token: 0x0600C6CC RID: 50892 RVA: 0x001D67E0 File Offset: 0x001D49E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementResponse(KurotatoSettlementResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.kurotatoSettlementInfo_ = ((other.kurotatoSettlementInfo_ != null) ? other.kurotatoSettlementInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6CD RID: 50893 RVA: 0x001D682C File Offset: 0x001D4A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementResponse Clone()
		{
			return new KurotatoSettlementResponse(this);
		}

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0600C6CE RID: 50894 RVA: 0x001D6834 File Offset: 0x001D4A34
		// (set) Token: 0x0600C6CF RID: 50895 RVA: 0x001D683C File Offset: 0x001D4A3C
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

		// Token: 0x1700282E RID: 10286
		// (get) Token: 0x0600C6D0 RID: 50896 RVA: 0x001D6845 File Offset: 0x001D4A45
		// (set) Token: 0x0600C6D1 RID: 50897 RVA: 0x001D684D File Offset: 0x001D4A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSettlementInfo KurotatoSettlementInfo
		{
			get
			{
				return this.kurotatoSettlementInfo_;
			}
			set
			{
				this.kurotatoSettlementInfo_ = value;
			}
		}

		// Token: 0x0600C6D2 RID: 50898 RVA: 0x001D6856 File Offset: 0x001D4A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSettlementResponse);
		}

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x001D6864 File Offset: 0x001D4A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSettlementResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.KurotatoSettlementInfo, other.KurotatoSettlementInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x001D68B4 File Offset: 0x001D4AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.kurotatoSettlementInfo_ != null)
			{
				num ^= this.KurotatoSettlementInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x001D690F File Offset: 0x001D4B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C6D6 RID: 50902 RVA: 0x001D691C File Offset: 0x001D4B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6D7 RID: 50903 RVA: 0x001D6928 File Offset: 0x001D4B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.kurotatoSettlementInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.KurotatoSettlementInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6D8 RID: 50904 RVA: 0x001D6984 File Offset: 0x001D4B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.kurotatoSettlementInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KurotatoSettlementInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6D9 RID: 50905 RVA: 0x001D69DC File Offset: 0x001D4BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSettlementResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.kurotatoSettlementInfo_ != null)
			{
				if (this.kurotatoSettlementInfo_ == null)
				{
					this.KurotatoSettlementInfo = new KurotatoSettlementInfo();
				}
				this.KurotatoSettlementInfo.MergeFrom(other.KurotatoSettlementInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6DA RID: 50906 RVA: 0x001D6A44 File Offset: 0x001D4C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6DB RID: 50907 RVA: 0x001D6A50 File Offset: 0x001D4C50
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
				if (num != 88U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.kurotatoSettlementInfo_ == null)
						{
							this.KurotatoSettlementInfo = new KurotatoSettlementInfo();
						}
						input.ReadMessage(this.KurotatoSettlementInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005551 RID: 21841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005552 RID: 21842
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005553 RID: 21843
		private ErrorCode errorCode_;

		// Token: 0x04005554 RID: 21844
		public const int KurotatoSettlementInfoFieldNumber = 12;

		// Token: 0x04005555 RID: 21845
		private KurotatoSettlementInfo kurotatoSettlementInfo_;
	}
}
