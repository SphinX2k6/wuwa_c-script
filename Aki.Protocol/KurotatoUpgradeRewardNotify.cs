using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C6 RID: 2246
	[NetMessage(EMessageId.KurotatoUpgradeRewardNotify)]
	public sealed class KurotatoUpgradeRewardNotify : IMessage<KurotatoUpgradeRewardNotify>, IMessage, IEquatable<KurotatoUpgradeRewardNotify>, IDeepCloneable<KurotatoUpgradeRewardNotify>, IBufferMessage
	{
		// Token: 0x0600C756 RID: 51030 RVA: 0x001D8256 File Offset: 0x001D6456
		[NullableContext(1)]
		public static KurotatoUpgradeRewardNotify Create()
		{
			return new KurotatoUpgradeRewardNotify();
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x0600C757 RID: 51031 RVA: 0x001D825D File Offset: 0x001D645D
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
		// (get) Token: 0x0600C758 RID: 51032 RVA: 0x001D8260 File Offset: 0x001D6460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600C759 RID: 51033 RVA: 0x001D8267 File Offset: 0x001D6467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardNotify()
		{
		}

		// Token: 0x0600C75A RID: 51034 RVA: 0x001D826F File Offset: 0x001D646F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardNotify(KurotatoUpgradeRewardNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C75B RID: 51035 RVA: 0x001D82A4 File Offset: 0x001D64A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardNotify Clone()
		{
			return new KurotatoUpgradeRewardNotify(this);
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x0600C75C RID: 51036 RVA: 0x001D82AC File Offset: 0x001D64AC
		// (set) Token: 0x0600C75D RID: 51037 RVA: 0x001D82B4 File Offset: 0x001D64B4
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

		// Token: 0x0600C75E RID: 51038 RVA: 0x001D82BD File Offset: 0x001D64BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardNotify);
		}

		// Token: 0x0600C75F RID: 51039 RVA: 0x001D82CB File Offset: 0x001D64CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C760 RID: 51040 RVA: 0x001D8300 File Offset: 0x001D6500
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

		// Token: 0x0600C761 RID: 51041 RVA: 0x001D833C File Offset: 0x001D653C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C762 RID: 51042 RVA: 0x001D8349 File Offset: 0x001D6549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C763 RID: 51043 RVA: 0x001D8352 File Offset: 0x001D6552
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

		// Token: 0x0600C764 RID: 51044 RVA: 0x001D8384 File Offset: 0x001D6584
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

		// Token: 0x0600C765 RID: 51045 RVA: 0x001D83C4 File Offset: 0x001D65C4
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

		// Token: 0x0600C766 RID: 51046 RVA: 0x001D8418 File Offset: 0x001D6618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C767 RID: 51047 RVA: 0x001D8424 File Offset: 0x001D6624
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
						this.PanelPbData = new KurotatoItemRewardPanelPbData();
					}
					input.ReadMessage(this.PanelPbData);
				}
			}
		}

		// Token: 0x040055C3 RID: 21955
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055C4 RID: 21956
		public const int PanelPbDataFieldNumber = 15;

		// Token: 0x040055C5 RID: 21957
		private KurotatoItemRewardPanelPbData panelPbData_;
	}
}
