using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C8 RID: 2248
	[NetMessage(EMessageId.KurotatoShopRewardNotify)]
	public sealed class KurotatoShopRewardNotify : IMessage<KurotatoShopRewardNotify>, IMessage, IEquatable<KurotatoShopRewardNotify>, IDeepCloneable<KurotatoShopRewardNotify>, IBufferMessage
	{
		// Token: 0x0600C74A RID: 51018 RVA: 0x001D7AFF File Offset: 0x001D5CFF
		[NullableContext(1)]
		public static KurotatoShopRewardNotify Create()
		{
			return new KurotatoShopRewardNotify();
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600C74B RID: 51019 RVA: 0x001D7B06 File Offset: 0x001D5D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x0600C74C RID: 51020 RVA: 0x001D7B09 File Offset: 0x001D5D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardNotify.Descriptor;
			}
		}

		// Token: 0x0600C74D RID: 51021 RVA: 0x001D7B10 File Offset: 0x001D5D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardNotify()
		{
		}

		// Token: 0x0600C74E RID: 51022 RVA: 0x001D7B18 File Offset: 0x001D5D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardNotify(KurotatoShopRewardNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C74F RID: 51023 RVA: 0x001D7B4D File Offset: 0x001D5D4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardNotify Clone()
		{
			return new KurotatoShopRewardNotify(this);
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x0600C750 RID: 51024 RVA: 0x001D7B55 File Offset: 0x001D5D55
		// (set) Token: 0x0600C751 RID: 51025 RVA: 0x001D7B5D File Offset: 0x001D5D5D
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

		// Token: 0x0600C752 RID: 51026 RVA: 0x001D7B66 File Offset: 0x001D5D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardNotify);
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x001D7B74 File Offset: 0x001D5D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C754 RID: 51028 RVA: 0x001D7BA8 File Offset: 0x001D5DA8
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

		// Token: 0x0600C755 RID: 51029 RVA: 0x001D7BE4 File Offset: 0x001D5DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C756 RID: 51030 RVA: 0x001D7BF1 File Offset: 0x001D5DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C757 RID: 51031 RVA: 0x001D7BFA File Offset: 0x001D5DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C758 RID: 51032 RVA: 0x001D7C2C File Offset: 0x001D5E2C
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

		// Token: 0x0600C759 RID: 51033 RVA: 0x001D7C6C File Offset: 0x001D5E6C
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

		// Token: 0x0600C75A RID: 51034 RVA: 0x001D7CC0 File Offset: 0x001D5EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C75B RID: 51035 RVA: 0x001D7CCC File Offset: 0x001D5ECC
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
				if (num != 34U)
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

		// Token: 0x04005577 RID: 21879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005578 RID: 21880
		public const int PanelPbDataFieldNumber = 4;

		// Token: 0x04005579 RID: 21881
		private KurotatoShopPanelPbData panelPbData_;
	}
}
