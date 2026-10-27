using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B1 RID: 2225
	[NetMessage(EMessageId.KurotatoRefineWeaponResponse)]
	public sealed class KurotatoRefineWeaponResponse : IMessage<KurotatoRefineWeaponResponse>, IMessage, IEquatable<KurotatoRefineWeaponResponse>, IDeepCloneable<KurotatoRefineWeaponResponse>, IBufferMessage
	{
		// Token: 0x0600C57B RID: 50555 RVA: 0x001D3C21 File Offset: 0x001D1E21
		[NullableContext(1)]
		public static KurotatoRefineWeaponResponse Create()
		{
			return new KurotatoRefineWeaponResponse();
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x0600C57C RID: 50556 RVA: 0x001D3C28 File Offset: 0x001D1E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x0600C57D RID: 50557 RVA: 0x001D3C2B File Offset: 0x001D1E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoRefineWeaponResponse.Descriptor;
			}
		}

		// Token: 0x0600C57E RID: 50558 RVA: 0x001D3C32 File Offset: 0x001D1E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponResponse()
		{
		}

		// Token: 0x0600C57F RID: 50559 RVA: 0x001D3C3C File Offset: 0x001D1E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponResponse(KurotatoRefineWeaponResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C580 RID: 50560 RVA: 0x001D3C88 File Offset: 0x001D1E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoRefineWeaponResponse Clone()
		{
			return new KurotatoRefineWeaponResponse(this);
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x0600C581 RID: 50561 RVA: 0x001D3C90 File Offset: 0x001D1E90
		// (set) Token: 0x0600C582 RID: 50562 RVA: 0x001D3C98 File Offset: 0x001D1E98
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

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x0600C583 RID: 50563 RVA: 0x001D3CA1 File Offset: 0x001D1EA1
		// (set) Token: 0x0600C584 RID: 50564 RVA: 0x001D3CA9 File Offset: 0x001D1EA9
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

		// Token: 0x0600C585 RID: 50565 RVA: 0x001D3CB2 File Offset: 0x001D1EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoRefineWeaponResponse);
		}

		// Token: 0x0600C586 RID: 50566 RVA: 0x001D3CC0 File Offset: 0x001D1EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoRefineWeaponResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C587 RID: 50567 RVA: 0x001D3D10 File Offset: 0x001D1F10
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

		// Token: 0x0600C588 RID: 50568 RVA: 0x001D3D6B File Offset: 0x001D1F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C589 RID: 50569 RVA: 0x001D3D78 File Offset: 0x001D1F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C58A RID: 50570 RVA: 0x001D3D84 File Offset: 0x001D1F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
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

		// Token: 0x0600C58B RID: 50571 RVA: 0x001D3DE0 File Offset: 0x001D1FE0
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

		// Token: 0x0600C58C RID: 50572 RVA: 0x001D3E38 File Offset: 0x001D2038
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

		// Token: 0x0600C58D RID: 50573 RVA: 0x001D3EA0 File Offset: 0x001D20A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C58E RID: 50574 RVA: 0x001D3EAC File Offset: 0x001D20AC
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
				if (num != 40U)
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

		// Token: 0x040054F8 RID: 21752
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054F9 RID: 21753
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040054FA RID: 21754
		private ErrorCode errorCode_;

		// Token: 0x040054FB RID: 21755
		public const int PanelPbDataFieldNumber = 9;

		// Token: 0x040054FC RID: 21756
		private KurotatoWeaponPanelPbData panelPbData_;
	}
}
