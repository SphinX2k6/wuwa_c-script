using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089A RID: 2202
	public sealed class KurotatoItemPanelPbData : IMessage<KurotatoItemPanelPbData>, IMessage, IEquatable<KurotatoItemPanelPbData>, IDeepCloneable<KurotatoItemPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C3B4 RID: 50100 RVA: 0x001D0431 File Offset: 0x001CE631
		[NullableContext(1)]
		public static KurotatoItemPanelPbData Create()
		{
			return new KurotatoItemPanelPbData();
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x0600C3B5 RID: 50101 RVA: 0x001D0438 File Offset: 0x001CE638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x0600C3B6 RID: 50102 RVA: 0x001D043B File Offset: 0x001CE63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x001D0442 File Offset: 0x001CE642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData()
		{
		}

		// Token: 0x0600C3B8 RID: 50104 RVA: 0x001D0455 File Offset: 0x001CE655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData(KurotatoItemPanelPbData other) : this()
		{
			this.itemPbDatas_ = other.itemPbDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3B9 RID: 50105 RVA: 0x001D047F File Offset: 0x001CE67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData Clone()
		{
			return new KurotatoItemPanelPbData(this);
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x0600C3BA RID: 50106 RVA: 0x001D0487 File Offset: 0x001CE687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoItemPbData> ItemPbDatas
		{
			get
			{
				return this.itemPbDatas_;
			}
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x001D048F File Offset: 0x001CE68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemPanelPbData);
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x001D049D File Offset: 0x001CE69D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemPanelPbData other)
		{
			return other != null && (other == this || (this.itemPbDatas_.Equals(other.itemPbDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x001D04D0 File Offset: 0x001CE6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemPbDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3BE RID: 50110 RVA: 0x001D0504 File Offset: 0x001CE704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3BF RID: 50111 RVA: 0x001D0511 File Offset: 0x001CE711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3C0 RID: 50112 RVA: 0x001D051A File Offset: 0x001CE71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemPbDatas_.WriteTo(ref output, KurotatoItemPanelPbData._repeated_itemPbDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3C1 RID: 50113 RVA: 0x001D0544 File Offset: 0x001CE744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemPbDatas_.CalculateSize(KurotatoItemPanelPbData._repeated_itemPbDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3C2 RID: 50114 RVA: 0x001D057D File Offset: 0x001CE77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemPanelPbData other)
		{
			if (other == null)
			{
				return;
			}
			this.itemPbDatas_.Add(other.itemPbDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3C3 RID: 50115 RVA: 0x001D05AB File Offset: 0x001CE7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3C4 RID: 50116 RVA: 0x001D05B4 File Offset: 0x001CE7B4
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
					this.itemPbDatas_.AddEntriesFrom(ref input, KurotatoItemPanelPbData._repeated_itemPbDatas_codec);
				}
			}
		}

		// Token: 0x04005484 RID: 21636
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005485 RID: 21637
		public const int ItemPbDatasFieldNumber = 1;

		// Token: 0x04005486 RID: 21638
		private static readonly FieldCodec<KurotatoItemPbData> _repeated_itemPbDatas_codec = FieldCodec.ForMessage<KurotatoItemPbData>(10U, KurotatoItemPbData.Parser);

		// Token: 0x04005487 RID: 21639
		private readonly RepeatedField<KurotatoItemPbData> itemPbDatas_ = new RepeatedField<KurotatoItemPbData>();
	}
}
