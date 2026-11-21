using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C8 RID: 2248
	[NetMessage(EMessageId.KurotatoUpgradeRewardRefreshResponse)]
	public sealed class KurotatoUpgradeRewardRefreshResponse : IMessage<KurotatoUpgradeRewardRefreshResponse>, IMessage, IEquatable<KurotatoUpgradeRewardRefreshResponse>, IDeepCloneable<KurotatoUpgradeRewardRefreshResponse>, IBufferMessage
	{
		// Token: 0x0600C778 RID: 51064 RVA: 0x001D85B6 File Offset: 0x001D67B6
		[NullableContext(1)]
		public static KurotatoUpgradeRewardRefreshResponse Create()
		{
			return new KurotatoUpgradeRewardRefreshResponse();
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600C779 RID: 51065 RVA: 0x001D85BD File Offset: 0x001D67BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600C77A RID: 51066 RVA: 0x001D85C0 File Offset: 0x001D67C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardRefreshResponse.Descriptor;
			}
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x001D85C7 File Offset: 0x001D67C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshResponse()
		{
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x001D85D0 File Offset: 0x001D67D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshResponse(KurotatoUpgradeRewardRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C77D RID: 51069 RVA: 0x001D861C File Offset: 0x001D681C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshResponse Clone()
		{
			return new KurotatoUpgradeRewardRefreshResponse(this);
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600C77E RID: 51070 RVA: 0x001D8624 File Offset: 0x001D6824
		// (set) Token: 0x0600C77F RID: 51071 RVA: 0x001D862C File Offset: 0x001D682C
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

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x0600C780 RID: 51072 RVA: 0x001D8635 File Offset: 0x001D6835
		// (set) Token: 0x0600C781 RID: 51073 RVA: 0x001D863D File Offset: 0x001D683D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPanelPbData PanelPbData
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

		// Token: 0x0600C782 RID: 51074 RVA: 0x001D8646 File Offset: 0x001D6846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardRefreshResponse);
		}

		// Token: 0x0600C783 RID: 51075 RVA: 0x001D8654 File Offset: 0x001D6854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C784 RID: 51076 RVA: 0x001D86A4 File Offset: 0x001D68A4
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

		// Token: 0x0600C785 RID: 51077 RVA: 0x001D86FF File Offset: 0x001D68FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C786 RID: 51078 RVA: 0x001D870C File Offset: 0x001D690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C787 RID: 51079 RVA: 0x001D8718 File Offset: 0x001D6918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C788 RID: 51080 RVA: 0x001D8774 File Offset: 0x001D6974
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

		// Token: 0x0600C789 RID: 51081 RVA: 0x001D87CC File Offset: 0x001D69CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpgradeRewardRefreshResponse other)
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
					this.PanelPbData = new KurotatoItemRewardPanelPbData();
				}
				this.PanelPbData.MergeFrom(other.PanelPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C78A RID: 51082 RVA: 0x001D8834 File Offset: 0x001D6A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C78B RID: 51083 RVA: 0x001D8840 File Offset: 0x001D6A40
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
				if (num != 80U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.panelPbData_ == null)
						{
							this.PanelPbData = new KurotatoItemRewardPanelPbData();
						}
						input.ReadMessage(this.PanelPbData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040055C7 RID: 21959
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055C8 RID: 21960
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040055C9 RID: 21961
		private ErrorCode errorCode_;

		// Token: 0x040055CA RID: 21962
		public const int PanelPbDataFieldNumber = 12;

		// Token: 0x040055CB RID: 21963
		private KurotatoItemRewardPanelPbData panelPbData_;
	}
}
