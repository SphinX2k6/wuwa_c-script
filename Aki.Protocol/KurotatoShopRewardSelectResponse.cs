using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BB RID: 2235
	[NetMessage(EMessageId.KurotatoShopRewardSelectResponse)]
	public sealed class KurotatoShopRewardSelectResponse : IMessage<KurotatoShopRewardSelectResponse>, IMessage, IEquatable<KurotatoShopRewardSelectResponse>, IDeepCloneable<KurotatoShopRewardSelectResponse>, IBufferMessage
	{
		// Token: 0x0600C676 RID: 50806 RVA: 0x001D6040 File Offset: 0x001D4240
		[NullableContext(1)]
		public static KurotatoShopRewardSelectResponse Create()
		{
			return new KurotatoShopRewardSelectResponse();
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x0600C677 RID: 50807 RVA: 0x001D6047 File Offset: 0x001D4247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x0600C678 RID: 50808 RVA: 0x001D604A File Offset: 0x001D424A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600C679 RID: 50809 RVA: 0x001D6051 File Offset: 0x001D4251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectResponse()
		{
		}

		// Token: 0x0600C67A RID: 50810 RVA: 0x001D605C File Offset: 0x001D425C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectResponse(KurotatoShopRewardSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C67B RID: 50811 RVA: 0x001D60A8 File Offset: 0x001D42A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectResponse Clone()
		{
			return new KurotatoShopRewardSelectResponse(this);
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x0600C67C RID: 50812 RVA: 0x001D60B0 File Offset: 0x001D42B0
		// (set) Token: 0x0600C67D RID: 50813 RVA: 0x001D60B8 File Offset: 0x001D42B8
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

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x0600C67E RID: 50814 RVA: 0x001D60C1 File Offset: 0x001D42C1
		// (set) Token: 0x0600C67F RID: 50815 RVA: 0x001D60C9 File Offset: 0x001D42C9
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

		// Token: 0x0600C680 RID: 50816 RVA: 0x001D60D2 File Offset: 0x001D42D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardSelectResponse);
		}

		// Token: 0x0600C681 RID: 50817 RVA: 0x001D60E0 File Offset: 0x001D42E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C682 RID: 50818 RVA: 0x001D6130 File Offset: 0x001D4330
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

		// Token: 0x0600C683 RID: 50819 RVA: 0x001D618B File Offset: 0x001D438B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C684 RID: 50820 RVA: 0x001D6198 File Offset: 0x001D4398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C685 RID: 50821 RVA: 0x001D61A4 File Offset: 0x001D43A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x001D6200 File Offset: 0x001D4400
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

		// Token: 0x0600C687 RID: 50823 RVA: 0x001D6258 File Offset: 0x001D4458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardSelectResponse other)
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

		// Token: 0x0600C688 RID: 50824 RVA: 0x001D62C0 File Offset: 0x001D44C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C689 RID: 50825 RVA: 0x001D62CC File Offset: 0x001D44CC
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
					if (num != 90U)
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

		// Token: 0x0400558A RID: 21898
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400558B RID: 21899
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400558C RID: 21900
		private ErrorCode errorCode_;

		// Token: 0x0400558D RID: 21901
		public const int PanelPbDataFieldNumber = 11;

		// Token: 0x0400558E RID: 21902
		private KurotatoShopPanelPbData panelPbData_;
	}
}
