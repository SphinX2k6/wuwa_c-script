using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000886 RID: 2182
	[NetMessage(EMessageId.KurotatoAllItemUpdateNotify)]
	public sealed class KurotatoAllItemUpdateNotify : IMessage<KurotatoAllItemUpdateNotify>, IMessage, IEquatable<KurotatoAllItemUpdateNotify>, IDeepCloneable<KurotatoAllItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C239 RID: 49721 RVA: 0x001CD785 File Offset: 0x001CB985
		[NullableContext(1)]
		public static KurotatoAllItemUpdateNotify Create()
		{
			return new KurotatoAllItemUpdateNotify();
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x0600C23A RID: 49722 RVA: 0x001CD78C File Offset: 0x001CB98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x0600C23B RID: 49723 RVA: 0x001CD78F File Offset: 0x001CB98F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoAllItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C23C RID: 49724 RVA: 0x001CD796 File Offset: 0x001CB996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoAllItemUpdateNotify()
		{
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x001CD79E File Offset: 0x001CB99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoAllItemUpdateNotify(KurotatoAllItemUpdateNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C23E RID: 49726 RVA: 0x001CD7D3 File Offset: 0x001CB9D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoAllItemUpdateNotify Clone()
		{
			return new KurotatoAllItemUpdateNotify(this);
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600C23F RID: 49727 RVA: 0x001CD7DB File Offset: 0x001CB9DB
		// (set) Token: 0x0600C240 RID: 49728 RVA: 0x001CD7E3 File Offset: 0x001CB9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData PanelPbData
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

		// Token: 0x0600C241 RID: 49729 RVA: 0x001CD7EC File Offset: 0x001CB9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoAllItemUpdateNotify);
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x001CD7FA File Offset: 0x001CB9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoAllItemUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C243 RID: 49731 RVA: 0x001CD830 File Offset: 0x001CBA30
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

		// Token: 0x0600C244 RID: 49732 RVA: 0x001CD86C File Offset: 0x001CBA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x001CD879 File Offset: 0x001CBA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C246 RID: 49734 RVA: 0x001CD882 File Offset: 0x001CBA82
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

		// Token: 0x0600C247 RID: 49735 RVA: 0x001CD8B4 File Offset: 0x001CBAB4
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

		// Token: 0x0600C248 RID: 49736 RVA: 0x001CD8F4 File Offset: 0x001CBAF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoAllItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.panelPbData_ != null)
			{
				if (this.panelPbData_ == null)
				{
					this.PanelPbData = new KurotatoItemPanelPbData();
				}
				this.PanelPbData.MergeFrom(other.PanelPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C249 RID: 49737 RVA: 0x001CD948 File Offset: 0x001CBB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C24A RID: 49738 RVA: 0x001CD954 File Offset: 0x001CBB54
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
						this.PanelPbData = new KurotatoItemPanelPbData();
					}
					input.ReadMessage(this.PanelPbData);
				}
			}
		}

		// Token: 0x04005433 RID: 21555
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005434 RID: 21556
		public const int PanelPbDataFieldNumber = 15;

		// Token: 0x04005435 RID: 21557
		private KurotatoItemPanelPbData panelPbData_;
	}
}
