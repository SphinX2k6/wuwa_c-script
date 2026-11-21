using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000875 RID: 2165
	[NetMessage(EMessageId.KurotatoAllItemUpdateNotify)]
	public sealed class KurotatoAllItemUpdateNotify : IMessage<KurotatoAllItemUpdateNotify>, IMessage, IEquatable<KurotatoAllItemUpdateNotify>, IDeepCloneable<KurotatoAllItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C11D RID: 49437 RVA: 0x001CB49D File Offset: 0x001C969D
		[NullableContext(1)]
		public static KurotatoAllItemUpdateNotify Create()
		{
			return new KurotatoAllItemUpdateNotify();
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x0600C11E RID: 49438 RVA: 0x001CB4A4 File Offset: 0x001C96A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700270B RID: 9995
		// (get) Token: 0x0600C11F RID: 49439 RVA: 0x001CB4A7 File Offset: 0x001C96A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoAllItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C120 RID: 49440 RVA: 0x001CB4AE File Offset: 0x001C96AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoAllItemUpdateNotify()
		{
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x001CB4B6 File Offset: 0x001C96B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoAllItemUpdateNotify(KurotatoAllItemUpdateNotify other) : this()
		{
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C122 RID: 49442 RVA: 0x001CB4EB File Offset: 0x001C96EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoAllItemUpdateNotify Clone()
		{
			return new KurotatoAllItemUpdateNotify(this);
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x0600C123 RID: 49443 RVA: 0x001CB4F3 File Offset: 0x001C96F3
		// (set) Token: 0x0600C124 RID: 49444 RVA: 0x001CB4FB File Offset: 0x001C96FB
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

		// Token: 0x0600C125 RID: 49445 RVA: 0x001CB504 File Offset: 0x001C9704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoAllItemUpdateNotify);
		}

		// Token: 0x0600C126 RID: 49446 RVA: 0x001CB512 File Offset: 0x001C9712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoAllItemUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C127 RID: 49447 RVA: 0x001CB548 File Offset: 0x001C9748
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

		// Token: 0x0600C128 RID: 49448 RVA: 0x001CB584 File Offset: 0x001C9784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C129 RID: 49449 RVA: 0x001CB591 File Offset: 0x001C9791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C12A RID: 49450 RVA: 0x001CB59A File Offset: 0x001C979A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C12B RID: 49451 RVA: 0x001CB5CC File Offset: 0x001C97CC
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

		// Token: 0x0600C12C RID: 49452 RVA: 0x001CB60C File Offset: 0x001C980C
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

		// Token: 0x0600C12D RID: 49453 RVA: 0x001CB660 File Offset: 0x001C9860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C12E RID: 49454 RVA: 0x001CB66C File Offset: 0x001C986C
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

		// Token: 0x0400543A RID: 21562
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400543B RID: 21563
		public const int PanelPbDataFieldNumber = 1;

		// Token: 0x0400543C RID: 21564
		private KurotatoItemPanelPbData panelPbData_;
	}
}
