using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CA RID: 2250
	[NetMessage(EMessageId.KurotatoShopRewardRefreshResponse)]
	public sealed class KurotatoShopRewardRefreshResponse : IMessage<KurotatoShopRewardRefreshResponse>, IMessage, IEquatable<KurotatoShopRewardRefreshResponse>, IDeepCloneable<KurotatoShopRewardRefreshResponse>, IBufferMessage
	{
		// Token: 0x0600C76C RID: 51052 RVA: 0x001D7E5E File Offset: 0x001D605E
		[NullableContext(1)]
		public static KurotatoShopRewardRefreshResponse Create()
		{
			return new KurotatoShopRewardRefreshResponse();
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x0600C76D RID: 51053 RVA: 0x001D7E65 File Offset: 0x001D6065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x0600C76E RID: 51054 RVA: 0x001D7E68 File Offset: 0x001D6068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardRefreshResponse.Descriptor;
			}
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x001D7E6F File Offset: 0x001D606F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshResponse()
		{
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x001D7E78 File Offset: 0x001D6078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshResponse(KurotatoShopRewardRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x001D7EC4 File Offset: 0x001D60C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshResponse Clone()
		{
			return new KurotatoShopRewardRefreshResponse(this);
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0600C772 RID: 51058 RVA: 0x001D7ECC File Offset: 0x001D60CC
		// (set) Token: 0x0600C773 RID: 51059 RVA: 0x001D7ED4 File Offset: 0x001D60D4
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

		// Token: 0x17002850 RID: 10320
		// (get) Token: 0x0600C774 RID: 51060 RVA: 0x001D7EDD File Offset: 0x001D60DD
		// (set) Token: 0x0600C775 RID: 51061 RVA: 0x001D7EE5 File Offset: 0x001D60E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData PanelPbData
		{
			get
			{
				return this.panelPbData_;
			}
			set
			{
				this.panelPbData_ = value;
			}
		}

		// Token: 0x0600C776 RID: 51062 RVA: 0x001D7EEE File Offset: 0x001D60EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardRefreshResponse);
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x001D7EFC File Offset: 0x001D60FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x001D7F4C File Offset: 0x001D614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.panelPbData_ != null)
			{
				num ^= this.PanelPbData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x001D7FA7 File Offset: 0x001D61A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x001D7FB4 File Offset: 0x001D61B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x001D7FC0 File Offset: 0x001D61C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PanelPbData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x001D801C File Offset: 0x001D621C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.panelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C77D RID: 51069 RVA: 0x001D8074 File Offset: 0x001D6274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardRefreshResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.panelPbData_ != null)
			{
				if (this.panelPbData_ == null)
				{
					this.PanelPbData = new KurotatoShopPanelPbData();
				}
				this.PanelPbData.MergeFrom(other.PanelPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C77E RID: 51070 RVA: 0x001D80DC File Offset: 0x001D62DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C77F RID: 51071 RVA: 0x001D80E8 File Offset: 0x001D62E8
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
				if (num != 82U)
				{
					if (num != 112U)
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
					if (this.panelPbData_ == null)
					{
						this.PanelPbData = new KurotatoShopPanelPbData();
					}
					input.ReadMessage(this.PanelPbData);
				}
			}
		}

		// Token: 0x0400557B RID: 21883
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400557C RID: 21884
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400557D RID: 21885
		private ErrorCode errorCode_;

		// Token: 0x0400557E RID: 21886
		public const int PanelPbDataFieldNumber = 10;

		// Token: 0x0400557F RID: 21887
		private KurotatoShopPanelPbData panelPbData_;
	}
}
