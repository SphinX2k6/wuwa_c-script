using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C7 RID: 2247
	[NetMessage(EMessageId.KurotatoShopRewardLockResponse)]
	public sealed class KurotatoShopRewardLockResponse : IMessage<KurotatoShopRewardLockResponse>, IMessage, IEquatable<KurotatoShopRewardLockResponse>, IDeepCloneable<KurotatoShopRewardLockResponse>, IBufferMessage
	{
		// Token: 0x0600C736 RID: 50998 RVA: 0x001D7809 File Offset: 0x001D5A09
		[NullableContext(1)]
		public static KurotatoShopRewardLockResponse Create()
		{
			return new KurotatoShopRewardLockResponse();
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x0600C737 RID: 50999 RVA: 0x001D7810 File Offset: 0x001D5A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x0600C738 RID: 51000 RVA: 0x001D7813 File Offset: 0x001D5A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardLockResponse.Descriptor;
			}
		}

		// Token: 0x0600C739 RID: 51001 RVA: 0x001D781A File Offset: 0x001D5A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockResponse()
		{
		}

		// Token: 0x0600C73A RID: 51002 RVA: 0x001D7824 File Offset: 0x001D5A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockResponse(KurotatoShopRewardLockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x001D7870 File Offset: 0x001D5A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockResponse Clone()
		{
			return new KurotatoShopRewardLockResponse(this);
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x0600C73C RID: 51004 RVA: 0x001D7878 File Offset: 0x001D5A78
		// (set) Token: 0x0600C73D RID: 51005 RVA: 0x001D7880 File Offset: 0x001D5A80
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

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600C73E RID: 51006 RVA: 0x001D7889 File Offset: 0x001D5A89
		// (set) Token: 0x0600C73F RID: 51007 RVA: 0x001D7891 File Offset: 0x001D5A91
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

		// Token: 0x0600C740 RID: 51008 RVA: 0x001D789A File Offset: 0x001D5A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardLockResponse);
		}

		// Token: 0x0600C741 RID: 51009 RVA: 0x001D78A8 File Offset: 0x001D5AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardLockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C742 RID: 51010 RVA: 0x001D78F8 File Offset: 0x001D5AF8
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

		// Token: 0x0600C743 RID: 51011 RVA: 0x001D7953 File Offset: 0x001D5B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C744 RID: 51012 RVA: 0x001D7960 File Offset: 0x001D5B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C745 RID: 51013 RVA: 0x001D796C File Offset: 0x001D5B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C746 RID: 51014 RVA: 0x001D79C8 File Offset: 0x001D5BC8
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

		// Token: 0x0600C747 RID: 51015 RVA: 0x001D7A20 File Offset: 0x001D5C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardLockResponse other)
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

		// Token: 0x0600C748 RID: 51016 RVA: 0x001D7A88 File Offset: 0x001D5C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x001D7A94 File Offset: 0x001D5C94
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005572 RID: 21874
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005573 RID: 21875
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005574 RID: 21876
		private ErrorCode errorCode_;

		// Token: 0x04005575 RID: 21877
		public const int PanelPbDataFieldNumber = 15;

		// Token: 0x04005576 RID: 21878
		private KurotatoShopPanelPbData panelPbData_;
	}
}
