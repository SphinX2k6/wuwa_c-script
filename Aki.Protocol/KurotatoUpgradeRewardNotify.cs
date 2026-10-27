using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D7 RID: 2263
	[NetMessage(EMessageId.KurotatoUpgradeRewardNotify)]
	public sealed class KurotatoUpgradeRewardNotify : IMessage<KurotatoUpgradeRewardNotify>, IMessage, IEquatable<KurotatoUpgradeRewardNotify>, IDeepCloneable<KurotatoUpgradeRewardNotify>, IBufferMessage
	{
		// Token: 0x0600C872 RID: 51314 RVA: 0x001DA532 File Offset: 0x001D8732
		[NullableContext(1)]
		public static KurotatoUpgradeRewardNotify Create()
		{
			return new KurotatoUpgradeRewardNotify();
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x0600C873 RID: 51315 RVA: 0x001DA539 File Offset: 0x001D8739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x0600C874 RID: 51316 RVA: 0x001DA53C File Offset: 0x001D873C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x001DA543 File Offset: 0x001D8743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardNotify()
		{
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x001DA54B File Offset: 0x001D874B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardNotify(KurotatoUpgradeRewardNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C877 RID: 51319 RVA: 0x001DA580 File Offset: 0x001D8780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardNotify Clone()
		{
			return new KurotatoUpgradeRewardNotify(this);
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600C878 RID: 51320 RVA: 0x001DA588 File Offset: 0x001D8788
		// (set) Token: 0x0600C879 RID: 51321 RVA: 0x001DA590 File Offset: 0x001D8790
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

		// Token: 0x0600C87A RID: 51322 RVA: 0x001DA599 File Offset: 0x001D8799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardNotify);
		}

		// Token: 0x0600C87B RID: 51323 RVA: 0x001DA5A7 File Offset: 0x001D87A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C87C RID: 51324 RVA: 0x001DA5DC File Offset: 0x001D87DC
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

		// Token: 0x0600C87D RID: 51325 RVA: 0x001DA618 File Offset: 0x001D8818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C87E RID: 51326 RVA: 0x001DA625 File Offset: 0x001D8825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x001DA62E File Offset: 0x001D882E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600C880 RID: 51328 RVA: 0x001DA660 File Offset: 0x001D8860
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

		// Token: 0x0600C881 RID: 51329 RVA: 0x001DA6A0 File Offset: 0x001D88A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpgradeRewardNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0600C882 RID: 51330 RVA: 0x001DA6F4 File Offset: 0x001D88F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C883 RID: 51331 RVA: 0x001DA700 File Offset: 0x001D8900
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
		}

		// Token: 0x040055BC RID: 21948
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055BD RID: 21949
		public const int PanelPbDataFieldNumber = 12;

		// Token: 0x040055BE RID: 21950
		private KurotatoItemRewardPanelPbData panelPbData_;
	}
}
