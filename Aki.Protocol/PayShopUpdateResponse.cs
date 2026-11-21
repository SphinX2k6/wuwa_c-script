using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BEA RID: 3050
	[NetMessage(EMessageId.PayShopUpdateResponse)]
	public sealed class PayShopUpdateResponse : IMessage<PayShopUpdateResponse>, IMessage, IEquatable<PayShopUpdateResponse>, IDeepCloneable<PayShopUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601093C RID: 67900 RVA: 0x0026DBF5 File Offset: 0x0026BDF5
		[NullableContext(1)]
		public static PayShopUpdateResponse Create()
		{
			return new PayShopUpdateResponse();
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0601093D RID: 67901 RVA: 0x0026DBFC File Offset: 0x0026BDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0601093E RID: 67902 RVA: 0x0026DBFF File Offset: 0x0026BDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601093F RID: 67903 RVA: 0x0026DC06 File Offset: 0x0026BE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateResponse()
		{
		}

		// Token: 0x06010940 RID: 67904 RVA: 0x0026DC10 File Offset: 0x0026BE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateResponse(PayShopUpdateResponse other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010941 RID: 67905 RVA: 0x0026DC5C File Offset: 0x0026BE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateResponse Clone()
		{
			return new PayShopUpdateResponse(this);
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x06010942 RID: 67906 RVA: 0x0026DC64 File Offset: 0x0026BE64
		// (set) Token: 0x06010943 RID: 67907 RVA: 0x0026DC6C File Offset: 0x0026BE6C
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

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x06010944 RID: 67908 RVA: 0x0026DC75 File Offset: 0x0026BE75
		// (set) Token: 0x06010945 RID: 67909 RVA: 0x0026DC7D File Offset: 0x0026BE7D
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

		// Token: 0x06010946 RID: 67910 RVA: 0x0026DC86 File Offset: 0x0026BE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopUpdateResponse);
		}

		// Token: 0x06010947 RID: 67911 RVA: 0x0026DC94 File Offset: 0x0026BE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopUpdateResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010948 RID: 67912 RVA: 0x0026DCE4 File Offset: 0x0026BEE4
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

		// Token: 0x06010949 RID: 67913 RVA: 0x0026DD3F File Offset: 0x0026BF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601094A RID: 67914 RVA: 0x0026DD4C File Offset: 0x0026BF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601094B RID: 67915 RVA: 0x0026DD58 File Offset: 0x0026BF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Info);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601094C RID: 67916 RVA: 0x0026DDB4 File Offset: 0x0026BFB4
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

		// Token: 0x0601094D RID: 67917 RVA: 0x0026DE0C File Offset: 0x0026C00C
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

		// Token: 0x0601094E RID: 67918 RVA: 0x0026DE74 File Offset: 0x0026C074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601094F RID: 67919 RVA: 0x0026DE80 File Offset: 0x0026C080
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
				if (num != 50U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x040069D8 RID: 27096
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069D9 RID: 27097
		public const int InfoFieldNumber = 6;

		// Token: 0x040069DA RID: 27098
		private PayShopInfo info_;

		// Token: 0x040069DB RID: 27099
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040069DC RID: 27100
		private ErrorCode errorCode_;
	}
}
