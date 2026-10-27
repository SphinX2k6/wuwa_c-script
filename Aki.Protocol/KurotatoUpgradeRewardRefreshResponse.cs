using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D9 RID: 2265
	[NetMessage(EMessageId.KurotatoUpgradeRewardRefreshResponse)]
	public sealed class KurotatoUpgradeRewardRefreshResponse : IMessage<KurotatoUpgradeRewardRefreshResponse>, IMessage, IEquatable<KurotatoUpgradeRewardRefreshResponse>, IDeepCloneable<KurotatoUpgradeRewardRefreshResponse>, IBufferMessage
	{
		// Token: 0x0600C894 RID: 51348 RVA: 0x001DA892 File Offset: 0x001D8A92
		[NullableContext(1)]
		public static KurotatoUpgradeRewardRefreshResponse Create()
		{
			return new KurotatoUpgradeRewardRefreshResponse();
		}

		// Token: 0x17002888 RID: 10376
		// (get) Token: 0x0600C895 RID: 51349 RVA: 0x001DA899 File Offset: 0x001D8A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002889 RID: 10377
		// (get) Token: 0x0600C896 RID: 51350 RVA: 0x001DA89C File Offset: 0x001D8A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardRefreshResponse.Descriptor;
			}
		}

		// Token: 0x0600C897 RID: 51351 RVA: 0x001DA8A3 File Offset: 0x001D8AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshResponse()
		{
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x001DA8AC File Offset: 0x001D8AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshResponse(KurotatoUpgradeRewardRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x001DA8F8 File Offset: 0x001D8AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshResponse Clone()
		{
			return new KurotatoUpgradeRewardRefreshResponse(this);
		}

		// Token: 0x1700288A RID: 10378
		// (get) Token: 0x0600C89A RID: 51354 RVA: 0x001DA900 File Offset: 0x001D8B00
		// (set) Token: 0x0600C89B RID: 51355 RVA: 0x001DA908 File Offset: 0x001D8B08
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

		// Token: 0x1700288B RID: 10379
		// (get) Token: 0x0600C89C RID: 51356 RVA: 0x001DA911 File Offset: 0x001D8B11
		// (set) Token: 0x0600C89D RID: 51357 RVA: 0x001DA919 File Offset: 0x001D8B19
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

		// Token: 0x0600C89E RID: 51358 RVA: 0x001DA922 File Offset: 0x001D8B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardRefreshResponse);
		}

		// Token: 0x0600C89F RID: 51359 RVA: 0x001DA930 File Offset: 0x001D8B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x001DA980 File Offset: 0x001D8B80
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

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x001DA9DB File Offset: 0x001D8BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8A2 RID: 51362 RVA: 0x001DA9E8 File Offset: 0x001D8BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x001DA9F4 File Offset: 0x001D8BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PanelPbData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x001DAA50 File Offset: 0x001D8C50
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

		// Token: 0x0600C8A5 RID: 51365 RVA: 0x001DAAA8 File Offset: 0x001D8CA8
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

		// Token: 0x0600C8A6 RID: 51366 RVA: 0x001DAB10 File Offset: 0x001D8D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8A7 RID: 51367 RVA: 0x001DAB1C File Offset: 0x001D8D1C
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
				if (num != 10U)
				{
					if (num != 32U)
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
						this.PanelPbData = new KurotatoItemRewardPanelPbData();
					}
					input.ReadMessage(this.PanelPbData);
				}
			}
		}

		// Token: 0x040055C0 RID: 21952
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055C1 RID: 21953
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040055C2 RID: 21954
		private ErrorCode errorCode_;

		// Token: 0x040055C3 RID: 21955
		public const int PanelPbDataFieldNumber = 1;

		// Token: 0x040055C4 RID: 21956
		private KurotatoItemRewardPanelPbData panelPbData_;
	}
}
