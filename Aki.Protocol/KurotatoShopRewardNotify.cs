using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B7 RID: 2231
	[NetMessage(EMessageId.KurotatoShopRewardNotify)]
	public sealed class KurotatoShopRewardNotify : IMessage<KurotatoShopRewardNotify>, IMessage, IEquatable<KurotatoShopRewardNotify>, IDeepCloneable<KurotatoShopRewardNotify>, IBufferMessage
	{
		// Token: 0x0600C62E RID: 50734 RVA: 0x001D5813 File Offset: 0x001D3A13
		[NullableContext(1)]
		public static KurotatoShopRewardNotify Create()
		{
			return new KurotatoShopRewardNotify();
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600C62F RID: 50735 RVA: 0x001D581A File Offset: 0x001D3A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600C630 RID: 50736 RVA: 0x001D581D File Offset: 0x001D3A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x001D5824 File Offset: 0x001D3A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardNotify()
		{
		}

		// Token: 0x0600C632 RID: 50738 RVA: 0x001D582C File Offset: 0x001D3A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardNotify(KurotatoShopRewardNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x001D5861 File Offset: 0x001D3A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardNotify Clone()
		{
			return new KurotatoShopRewardNotify(this);
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600C634 RID: 50740 RVA: 0x001D5869 File Offset: 0x001D3A69
		// (set) Token: 0x0600C635 RID: 50741 RVA: 0x001D5871 File Offset: 0x001D3A71
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

		// Token: 0x0600C636 RID: 50742 RVA: 0x001D587A File Offset: 0x001D3A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardNotify);
		}

		// Token: 0x0600C637 RID: 50743 RVA: 0x001D5888 File Offset: 0x001D3A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C638 RID: 50744 RVA: 0x001D58BC File Offset: 0x001D3ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C639 RID: 50745 RVA: 0x001D58F8 File Offset: 0x001D3AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C63A RID: 50746 RVA: 0x001D5905 File Offset: 0x001D3B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C63B RID: 50747 RVA: 0x001D590E File Offset: 0x001D3B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600C63C RID: 50748 RVA: 0x001D5940 File Offset: 0x001D3B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C63D RID: 50749 RVA: 0x001D5980 File Offset: 0x001D3B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600C63E RID: 50750 RVA: 0x001D59D4 File Offset: 0x001D3BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C63F RID: 50751 RVA: 0x001D59E0 File Offset: 0x001D3BE0
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
		}

		// Token: 0x0400557E RID: 21886
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400557F RID: 21887
		public const int PanelPbDataFieldNumber = 15;

		// Token: 0x04005580 RID: 21888
		private KurotatoShopPanelPbData panelPbData_;
	}
}
