using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFA RID: 3066
	[NetMessage(EMessageId.PayShopUpdateResponse)]
	public sealed class PayShopUpdateResponse : IMessage<PayShopUpdateResponse>, IMessage, IEquatable<PayShopUpdateResponse>, IDeepCloneable<PayShopUpdateResponse>, IBufferMessage
	{
		// Token: 0x06010A3C RID: 68156 RVA: 0x0026F95D File Offset: 0x0026DB5D
		[NullableContext(1)]
		public static PayShopUpdateResponse Create()
		{
			return new PayShopUpdateResponse();
		}

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x06010A3D RID: 68157 RVA: 0x0026F964 File Offset: 0x0026DB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x06010A3E RID: 68158 RVA: 0x0026F967 File Offset: 0x0026DB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06010A3F RID: 68159 RVA: 0x0026F96E File Offset: 0x0026DB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateResponse()
		{
		}

		// Token: 0x06010A40 RID: 68160 RVA: 0x0026F978 File Offset: 0x0026DB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateResponse(PayShopUpdateResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010A41 RID: 68161 RVA: 0x0026F9C4 File Offset: 0x0026DBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateResponse Clone()
		{
			return new PayShopUpdateResponse(this);
		}

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x06010A42 RID: 68162 RVA: 0x0026F9CC File Offset: 0x0026DBCC
		// (set) Token: 0x06010A43 RID: 68163 RVA: 0x0026F9D4 File Offset: 0x0026DBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopInfo Info
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

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x06010A44 RID: 68164 RVA: 0x0026F9DD File Offset: 0x0026DBDD
		// (set) Token: 0x06010A45 RID: 68165 RVA: 0x0026F9E5 File Offset: 0x0026DBE5
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

		// Token: 0x06010A46 RID: 68166 RVA: 0x0026F9EE File Offset: 0x0026DBEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopUpdateResponse);
		}

		// Token: 0x06010A47 RID: 68167 RVA: 0x0026F9FC File Offset: 0x0026DBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopUpdateResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010A48 RID: 68168 RVA: 0x0026FA4C File Offset: 0x0026DC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
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

		// Token: 0x06010A49 RID: 68169 RVA: 0x0026FAA7 File Offset: 0x0026DCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010A4A RID: 68170 RVA: 0x0026FAB4 File Offset: 0x0026DCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010A4B RID: 68171 RVA: 0x0026FAC0 File Offset: 0x0026DCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010A4C RID: 68172 RVA: 0x0026FB1C File Offset: 0x0026DD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
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

		// Token: 0x06010A4D RID: 68173 RVA: 0x0026FB74 File Offset: 0x0026DD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PayShopInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010A4E RID: 68174 RVA: 0x0026FBDC File Offset: 0x0026DDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010A4F RID: 68175 RVA: 0x0026FBE8 File Offset: 0x0026DDE8
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.info_ == null)
						{
							this.Info = new PayShopInfo();
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

		// Token: 0x040069C4 RID: 27076
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069C5 RID: 27077
		public const int InfoFieldNumber = 14;

		// Token: 0x040069C6 RID: 27078
		private PayShopInfo info_;

		// Token: 0x040069C7 RID: 27079
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040069C8 RID: 27080
		private ErrorCode errorCode_;
	}
}
