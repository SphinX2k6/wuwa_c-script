using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008AD RID: 2221
	[NetMessage(EMessageId.KurotatoSellWeaponResponse)]
	public sealed class KurotatoSellWeaponResponse : IMessage<KurotatoSellWeaponResponse>, IMessage, IEquatable<KurotatoSellWeaponResponse>, IDeepCloneable<KurotatoSellWeaponResponse>, IBufferMessage
	{
		// Token: 0x0600C555 RID: 50517 RVA: 0x001D35E9 File Offset: 0x001D17E9
		[NullableContext(1)]
		public static KurotatoSellWeaponResponse Create()
		{
			return new KurotatoSellWeaponResponse();
		}

		// Token: 0x170027D7 RID: 10199
		// (get) Token: 0x0600C556 RID: 50518 RVA: 0x001D35F0 File Offset: 0x001D17F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027D8 RID: 10200
		// (get) Token: 0x0600C557 RID: 50519 RVA: 0x001D35F3 File Offset: 0x001D17F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSellWeaponResponse.Descriptor;
			}
		}

		// Token: 0x0600C558 RID: 50520 RVA: 0x001D35FA File Offset: 0x001D17FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponResponse()
		{
		}

		// Token: 0x0600C559 RID: 50521 RVA: 0x001D3604 File Offset: 0x001D1804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponResponse(KurotatoSellWeaponResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C55A RID: 50522 RVA: 0x001D3650 File Offset: 0x001D1850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponResponse Clone()
		{
			return new KurotatoSellWeaponResponse(this);
		}

		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x0600C55B RID: 50523 RVA: 0x001D3658 File Offset: 0x001D1858
		// (set) Token: 0x0600C55C RID: 50524 RVA: 0x001D3660 File Offset: 0x001D1860
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

		// Token: 0x170027DA RID: 10202
		// (get) Token: 0x0600C55D RID: 50525 RVA: 0x001D3669 File Offset: 0x001D1869
		// (set) Token: 0x0600C55E RID: 50526 RVA: 0x001D3671 File Offset: 0x001D1871
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

		// Token: 0x0600C55F RID: 50527 RVA: 0x001D367A File Offset: 0x001D187A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSellWeaponResponse);
		}

		// Token: 0x0600C560 RID: 50528 RVA: 0x001D3688 File Offset: 0x001D1888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSellWeaponResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C561 RID: 50529 RVA: 0x001D36D8 File Offset: 0x001D18D8
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

		// Token: 0x0600C562 RID: 50530 RVA: 0x001D3733 File Offset: 0x001D1933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C563 RID: 50531 RVA: 0x001D3740 File Offset: 0x001D1940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C564 RID: 50532 RVA: 0x001D374C File Offset: 0x001D194C
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
				output.WriteRawTag(42);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C565 RID: 50533 RVA: 0x001D37A8 File Offset: 0x001D19A8
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

		// Token: 0x0600C566 RID: 50534 RVA: 0x001D3800 File Offset: 0x001D1A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoSellWeaponResponse other)
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

		// Token: 0x0600C567 RID: 50535 RVA: 0x001D3868 File Offset: 0x001D1A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C568 RID: 50536 RVA: 0x001D3874 File Offset: 0x001D1A74
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
					if (num != 42U)
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

		// Token: 0x04005536 RID: 21814
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005537 RID: 21815
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005538 RID: 21816
		private ErrorCode errorCode_;

		// Token: 0x04005539 RID: 21817
		public const int PanelPbDataFieldNumber = 5;

		// Token: 0x0400553A RID: 21818
		private KurotatoWeaponPanelPbData panelPbData_;
	}
}
