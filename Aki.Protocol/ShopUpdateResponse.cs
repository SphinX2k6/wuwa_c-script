using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001237 RID: 4663
	[NetMessage(EMessageId.ShopUpdateResponse)]
	public sealed class ShopUpdateResponse : IMessage<ShopUpdateResponse>, IMessage, IEquatable<ShopUpdateResponse>, IDeepCloneable<ShopUpdateResponse>, IBufferMessage
	{
		// Token: 0x06018E81 RID: 102017 RVA: 0x003A19F9 File Offset: 0x0039FBF9
		[NullableContext(1)]
		public static ShopUpdateResponse Create()
		{
			return new ShopUpdateResponse();
		}

		// Token: 0x17005429 RID: 21545
		// (get) Token: 0x06018E82 RID: 102018 RVA: 0x003A1A00 File Offset: 0x0039FC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700542A RID: 21546
		// (get) Token: 0x06018E83 RID: 102019 RVA: 0x003A1A03 File Offset: 0x0039FC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06018E84 RID: 102020 RVA: 0x003A1A0A File Offset: 0x0039FC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateResponse()
		{
		}

		// Token: 0x06018E85 RID: 102021 RVA: 0x003A1A14 File Offset: 0x0039FC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateResponse(ShopUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E86 RID: 102022 RVA: 0x003A1A60 File Offset: 0x0039FC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateResponse Clone()
		{
			return new ShopUpdateResponse(this);
		}

		// Token: 0x1700542B RID: 21547
		// (get) Token: 0x06018E87 RID: 102023 RVA: 0x003A1A68 File Offset: 0x0039FC68
		// (set) Token: 0x06018E88 RID: 102024 RVA: 0x003A1A70 File Offset: 0x0039FC70
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

		// Token: 0x1700542C RID: 21548
		// (get) Token: 0x06018E89 RID: 102025 RVA: 0x003A1A79 File Offset: 0x0039FC79
		// (set) Token: 0x06018E8A RID: 102026 RVA: 0x003A1A81 File Offset: 0x0039FC81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06018E8B RID: 102027 RVA: 0x003A1A8A File Offset: 0x0039FC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopUpdateResponse);
		}

		// Token: 0x06018E8C RID: 102028 RVA: 0x003A1A98 File Offset: 0x0039FC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E8D RID: 102029 RVA: 0x003A1AE8 File Offset: 0x0039FCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E8E RID: 102030 RVA: 0x003A1B43 File Offset: 0x0039FD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E8F RID: 102031 RVA: 0x003A1B50 File Offset: 0x0039FD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E90 RID: 102032 RVA: 0x003A1B5C File Offset: 0x0039FD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E91 RID: 102033 RVA: 0x003A1BB4 File Offset: 0x0039FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E92 RID: 102034 RVA: 0x003A1C0C File Offset: 0x0039FE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ShopInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E93 RID: 102035 RVA: 0x003A1C74 File Offset: 0x0039FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E94 RID: 102036 RVA: 0x003A1C80 File Offset: 0x0039FE80
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
				if (num != 8U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new ShopInfo();
						}
						input.ReadMessage(this.Info);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040093C3 RID: 37827
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093C4 RID: 37828
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040093C5 RID: 37829
		private ErrorCode errorCode_;

		// Token: 0x040093C6 RID: 37830
		public const int InfoFieldNumber = 12;

		// Token: 0x040093C7 RID: 37831
		private ShopInfo info_;
	}
}
