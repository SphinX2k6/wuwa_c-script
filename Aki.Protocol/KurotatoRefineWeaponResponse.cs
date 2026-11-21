using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A0 RID: 2208
	[NetMessage(EMessageId.KurotatoRefineWeaponResponse)]
	public sealed class KurotatoRefineWeaponResponse : IMessage<KurotatoRefineWeaponResponse>, IMessage, IEquatable<KurotatoRefineWeaponResponse>, IDeepCloneable<KurotatoRefineWeaponResponse>, IBufferMessage
	{
		// Token: 0x0600C45F RID: 50271 RVA: 0x001D193D File Offset: 0x001CFB3D
		[NullableContext(1)]
		public static KurotatoRefineWeaponResponse Create()
		{
			return new KurotatoRefineWeaponResponse();
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x0600C460 RID: 50272 RVA: 0x001D1944 File Offset: 0x001CFB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x0600C461 RID: 50273 RVA: 0x001D1947 File Offset: 0x001CFB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRefineWeaponResponse.Descriptor;
			}
		}

		// Token: 0x0600C462 RID: 50274 RVA: 0x001D194E File Offset: 0x001CFB4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponResponse()
		{
		}

		// Token: 0x0600C463 RID: 50275 RVA: 0x001D1958 File Offset: 0x001CFB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponResponse(KurotatoRefineWeaponResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C464 RID: 50276 RVA: 0x001D19A4 File Offset: 0x001CFBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponResponse Clone()
		{
			return new KurotatoRefineWeaponResponse(this);
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x0600C465 RID: 50277 RVA: 0x001D19AC File Offset: 0x001CFBAC
		// (set) Token: 0x0600C466 RID: 50278 RVA: 0x001D19B4 File Offset: 0x001CFBB4
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

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x0600C467 RID: 50279 RVA: 0x001D19BD File Offset: 0x001CFBBD
		// (set) Token: 0x0600C468 RID: 50280 RVA: 0x001D19C5 File Offset: 0x001CFBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoWeaponPanelPbData PanelPbData
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

		// Token: 0x0600C469 RID: 50281 RVA: 0x001D19CE File Offset: 0x001CFBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRefineWeaponResponse);
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x001D19DC File Offset: 0x001CFBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRefineWeaponResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x001D1A2C File Offset: 0x001CFC2C
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

		// Token: 0x0600C46C RID: 50284 RVA: 0x001D1A87 File Offset: 0x001CFC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x001D1A94 File Offset: 0x001CFC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C46E RID: 50286 RVA: 0x001D1AA0 File Offset: 0x001CFCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x001D1AF8 File Offset: 0x001CFCF8
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

		// Token: 0x0600C470 RID: 50288 RVA: 0x001D1B50 File Offset: 0x001CFD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoRefineWeaponResponse other)
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
					this.PanelPbData = new KurotatoWeaponPanelPbData();
				}
				this.PanelPbData.MergeFrom(other.PanelPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C471 RID: 50289 RVA: 0x001D1BB8 File Offset: 0x001CFDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C472 RID: 50290 RVA: 0x001D1BC4 File Offset: 0x001CFDC4
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
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.panelPbData_ == null)
						{
							this.PanelPbData = new KurotatoWeaponPanelPbData();
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

		// Token: 0x040054FF RID: 21759
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005500 RID: 21760
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04005501 RID: 21761
		private ErrorCode errorCode_;

		// Token: 0x04005502 RID: 21762
		public const int PanelPbDataFieldNumber = 9;

		// Token: 0x04005503 RID: 21763
		private KurotatoWeaponPanelPbData panelPbData_;
	}
}
