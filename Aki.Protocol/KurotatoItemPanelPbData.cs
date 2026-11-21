using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000889 RID: 2185
	public sealed class KurotatoItemPanelPbData : IMessage<KurotatoItemPanelPbData>, IMessage, IEquatable<KurotatoItemPanelPbData>, IDeepCloneable<KurotatoItemPanelPbData>, IBufferMessage
	{
		// Token: 0x0600C298 RID: 49816 RVA: 0x001CE14D File Offset: 0x001CC34D
		[NullableContext(1)]
		public static KurotatoItemPanelPbData Create()
		{
			return new KurotatoItemPanelPbData();
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x0600C299 RID: 49817 RVA: 0x001CE154 File Offset: 0x001CC354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x0600C29A RID: 49818 RVA: 0x001CE157 File Offset: 0x001CC357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemPanelPbData.Descriptor;
			}
		}

		// Token: 0x0600C29B RID: 49819 RVA: 0x001CE15E File Offset: 0x001CC35E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData()
		{
		}

		// Token: 0x0600C29C RID: 49820 RVA: 0x001CE171 File Offset: 0x001CC371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData(KurotatoItemPanelPbData other) : this()
		{
			this.itemPbDatas_ = other.itemPbDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x001CE19B File Offset: 0x001CC39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPanelPbData Clone()
		{
			return new KurotatoItemPanelPbData(this);
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x0600C29E RID: 49822 RVA: 0x001CE1A3 File Offset: 0x001CC3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KurotatoItemPbData> ItemPbDatas
		{
			get
			{
				return this.itemPbDatas_;
			}
		}

		// Token: 0x0600C29F RID: 49823 RVA: 0x001CE1AB File Offset: 0x001CC3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemPanelPbData);
		}

		// Token: 0x0600C2A0 RID: 49824 RVA: 0x001CE1B9 File Offset: 0x001CC3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemPanelPbData other)
		{
			return other != null && (other == this || (this.itemPbDatas_.Equals(other.itemPbDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2A1 RID: 49825 RVA: 0x001CE1EC File Offset: 0x001CC3EC
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

		// Token: 0x0600C2A2 RID: 49826 RVA: 0x001CE220 File Offset: 0x001CC420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2A3 RID: 49827 RVA: 0x001CE22D File Offset: 0x001CC42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2A4 RID: 49828 RVA: 0x001CE236 File Offset: 0x001CC436
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

		// Token: 0x0600C2A5 RID: 49829 RVA: 0x001CE260 File Offset: 0x001CC460
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

		// Token: 0x0600C2A6 RID: 49830 RVA: 0x001CE299 File Offset: 0x001CC499
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

		// Token: 0x0600C2A7 RID: 49831 RVA: 0x001CE2C7 File Offset: 0x001CC4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2A8 RID: 49832 RVA: 0x001CE2D0 File Offset: 0x001CC4D0
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

		// Token: 0x0400548B RID: 21643
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400548C RID: 21644
		public const int ItemPbDatasFieldNumber = 1;

		// Token: 0x0400548D RID: 21645
		private static readonly FieldCodec<KurotatoItemPbData> _repeated_itemPbDatas_codec = FieldCodec.ForMessage<KurotatoItemPbData>(10U, KurotatoItemPbData.Parser);

		// Token: 0x0400548E RID: 21646
		private readonly RepeatedField<KurotatoItemPbData> itemPbDatas_ = new RepeatedField<KurotatoItemPbData>();
	}
}
