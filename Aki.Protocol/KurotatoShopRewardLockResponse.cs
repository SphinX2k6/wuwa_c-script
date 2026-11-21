using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B6 RID: 2230
	[NetMessage(EMessageId.KurotatoShopRewardLockResponse)]
	public sealed class KurotatoShopRewardLockResponse : IMessage<KurotatoShopRewardLockResponse>, IMessage, IEquatable<KurotatoShopRewardLockResponse>, IDeepCloneable<KurotatoShopRewardLockResponse>, IBufferMessage
	{
		// Token: 0x0600C61A RID: 50714 RVA: 0x001D551D File Offset: 0x001D371D
		[NullableContext(1)]
		public static KurotatoShopRewardLockResponse Create()
		{
			return new KurotatoShopRewardLockResponse();
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x0600C61B RID: 50715 RVA: 0x001D5524 File Offset: 0x001D3724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0600C61C RID: 50716 RVA: 0x001D5527 File Offset: 0x001D3727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardLockResponse.Descriptor;
			}
		}

		// Token: 0x0600C61D RID: 50717 RVA: 0x001D552E File Offset: 0x001D372E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockResponse()
		{
		}

		// Token: 0x0600C61E RID: 50718 RVA: 0x001D5538 File Offset: 0x001D3738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockResponse(KurotatoShopRewardLockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C61F RID: 50719 RVA: 0x001D5584 File Offset: 0x001D3784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockResponse Clone()
		{
			return new KurotatoShopRewardLockResponse(this);
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0600C620 RID: 50720 RVA: 0x001D558C File Offset: 0x001D378C
		// (set) Token: 0x0600C621 RID: 50721 RVA: 0x001D5594 File Offset: 0x001D3794
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

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x0600C622 RID: 50722 RVA: 0x001D559D File Offset: 0x001D379D
		// (set) Token: 0x0600C623 RID: 50723 RVA: 0x001D55A5 File Offset: 0x001D37A5
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

		// Token: 0x0600C624 RID: 50724 RVA: 0x001D55AE File Offset: 0x001D37AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardLockResponse);
		}

		// Token: 0x0600C625 RID: 50725 RVA: 0x001D55BC File Offset: 0x001D37BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardLockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C626 RID: 50726 RVA: 0x001D560C File Offset: 0x001D380C
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

		// Token: 0x0600C627 RID: 50727 RVA: 0x001D5667 File Offset: 0x001D3867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C628 RID: 50728 RVA: 0x001D5674 File Offset: 0x001D3874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C629 RID: 50729 RVA: 0x001D5680 File Offset: 0x001D3880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(98);
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

		// Token: 0x0600C62A RID: 50730 RVA: 0x001D56DC File Offset: 0x001D38DC
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

		// Token: 0x0600C62B RID: 50731 RVA: 0x001D5734 File Offset: 0x001D3934
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

		// Token: 0x0600C62C RID: 50732 RVA: 0x001D579C File Offset: 0x001D399C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x001D57A8 File Offset: 0x001D39A8
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
				if (num != 98U)
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

		// Token: 0x04005579 RID: 21881
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400557A RID: 21882
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400557B RID: 21883
		private ErrorCode errorCode_;

		// Token: 0x0400557C RID: 21884
		public const int PanelPbDataFieldNumber = 12;

		// Token: 0x0400557D RID: 21885
		private KurotatoShopPanelPbData panelPbData_;
	}
}
