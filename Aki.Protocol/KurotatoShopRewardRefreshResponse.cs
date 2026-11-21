using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B9 RID: 2233
	[NetMessage(EMessageId.KurotatoShopRewardRefreshResponse)]
	public sealed class KurotatoShopRewardRefreshResponse : IMessage<KurotatoShopRewardRefreshResponse>, IMessage, IEquatable<KurotatoShopRewardRefreshResponse>, IDeepCloneable<KurotatoShopRewardRefreshResponse>, IBufferMessage
	{
		// Token: 0x0600C650 RID: 50768 RVA: 0x001D5B72 File Offset: 0x001D3D72
		[NullableContext(1)]
		public static KurotatoShopRewardRefreshResponse Create()
		{
			return new KurotatoShopRewardRefreshResponse();
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x0600C651 RID: 50769 RVA: 0x001D5B79 File Offset: 0x001D3D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x0600C652 RID: 50770 RVA: 0x001D5B7C File Offset: 0x001D3D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardRefreshResponse.Descriptor;
			}
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x001D5B83 File Offset: 0x001D3D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshResponse()
		{
		}

		// Token: 0x0600C654 RID: 50772 RVA: 0x001D5B8C File Offset: 0x001D3D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshResponse(KurotatoShopRewardRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x001D5BD8 File Offset: 0x001D3DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshResponse Clone()
		{
			return new KurotatoShopRewardRefreshResponse(this);
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x0600C656 RID: 50774 RVA: 0x001D5BE0 File Offset: 0x001D3DE0
		// (set) Token: 0x0600C657 RID: 50775 RVA: 0x001D5BE8 File Offset: 0x001D3DE8
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

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x0600C658 RID: 50776 RVA: 0x001D5BF1 File Offset: 0x001D3DF1
		// (set) Token: 0x0600C659 RID: 50777 RVA: 0x001D5BF9 File Offset: 0x001D3DF9
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

		// Token: 0x0600C65A RID: 50778 RVA: 0x001D5C02 File Offset: 0x001D3E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardRefreshResponse);
		}

		// Token: 0x0600C65B RID: 50779 RVA: 0x001D5C10 File Offset: 0x001D3E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C65C RID: 50780 RVA: 0x001D5C60 File Offset: 0x001D3E60
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

		// Token: 0x0600C65D RID: 50781 RVA: 0x001D5CBB File Offset: 0x001D3EBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x001D5CC8 File Offset: 0x001D3EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C65F RID: 50783 RVA: 0x001D5CD4 File Offset: 0x001D3ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PanelPbData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C660 RID: 50784 RVA: 0x001D5D30 File Offset: 0x001D3F30
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

		// Token: 0x0600C661 RID: 50785 RVA: 0x001D5D88 File Offset: 0x001D3F88
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

		// Token: 0x0600C662 RID: 50786 RVA: 0x001D5DF0 File Offset: 0x001D3FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C663 RID: 50787 RVA: 0x001D5DFC File Offset: 0x001D3FFC
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
				if (num != 18U)
				{
					if (num != 104U)
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

		// Token: 0x04005582 RID: 21890
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005583 RID: 21891
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04005584 RID: 21892
		private ErrorCode errorCode_;

		// Token: 0x04005585 RID: 21893
		public const int PanelPbDataFieldNumber = 2;

		// Token: 0x04005586 RID: 21894
		private KurotatoShopPanelPbData panelPbData_;
	}
}
