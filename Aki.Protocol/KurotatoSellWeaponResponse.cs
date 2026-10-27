using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BE RID: 2238
	[NetMessage(EMessageId.KurotatoSellWeaponResponse)]
	public sealed class KurotatoSellWeaponResponse : IMessage<KurotatoSellWeaponResponse>, IMessage, IEquatable<KurotatoSellWeaponResponse>, IDeepCloneable<KurotatoSellWeaponResponse>, IBufferMessage
	{
		// Token: 0x0600C671 RID: 50801 RVA: 0x001D58D1 File Offset: 0x001D3AD1
		[NullableContext(1)]
		public static KurotatoSellWeaponResponse Create()
		{
			return new KurotatoSellWeaponResponse();
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x0600C672 RID: 50802 RVA: 0x001D58D8 File Offset: 0x001D3AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x0600C673 RID: 50803 RVA: 0x001D58DB File Offset: 0x001D3ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoSellWeaponResponse.Descriptor;
			}
		}

		// Token: 0x0600C674 RID: 50804 RVA: 0x001D58E2 File Offset: 0x001D3AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponResponse()
		{
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x001D58EC File Offset: 0x001D3AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponResponse(KurotatoSellWeaponResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C676 RID: 50806 RVA: 0x001D5938 File Offset: 0x001D3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoSellWeaponResponse Clone()
		{
			return new KurotatoSellWeaponResponse(this);
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x0600C677 RID: 50807 RVA: 0x001D5940 File Offset: 0x001D3B40
		// (set) Token: 0x0600C678 RID: 50808 RVA: 0x001D5948 File Offset: 0x001D3B48
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

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x0600C679 RID: 50809 RVA: 0x001D5951 File Offset: 0x001D3B51
		// (set) Token: 0x0600C67A RID: 50810 RVA: 0x001D5959 File Offset: 0x001D3B59
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

		// Token: 0x0600C67B RID: 50811 RVA: 0x001D5962 File Offset: 0x001D3B62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoSellWeaponResponse);
		}

		// Token: 0x0600C67C RID: 50812 RVA: 0x001D5970 File Offset: 0x001D3B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoSellWeaponResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x001D59C0 File Offset: 0x001D3BC0
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

		// Token: 0x0600C67E RID: 50814 RVA: 0x001D5A1B File Offset: 0x001D3C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C67F RID: 50815 RVA: 0x001D5A28 File Offset: 0x001D3C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C680 RID: 50816 RVA: 0x001D5A34 File Offset: 0x001D3C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PanelPbData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C681 RID: 50817 RVA: 0x001D5A90 File Offset: 0x001D3C90
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

		// Token: 0x0600C682 RID: 50818 RVA: 0x001D5AE8 File Offset: 0x001D3CE8
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

		// Token: 0x0600C683 RID: 50819 RVA: 0x001D5B50 File Offset: 0x001D3D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C684 RID: 50820 RVA: 0x001D5B5C File Offset: 0x001D3D5C
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
				if (num != 66U)
				{
					if (num != 120U)
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
						this.PanelPbData = new KurotatoWeaponPanelPbData();
					}
					input.ReadMessage(this.PanelPbData);
				}
			}
		}

		// Token: 0x0400552F RID: 21807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005530 RID: 21808
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005531 RID: 21809
		private ErrorCode errorCode_;

		// Token: 0x04005532 RID: 21810
		public const int PanelPbDataFieldNumber = 8;

		// Token: 0x04005533 RID: 21811
		private KurotatoWeaponPanelPbData panelPbData_;
	}
}
