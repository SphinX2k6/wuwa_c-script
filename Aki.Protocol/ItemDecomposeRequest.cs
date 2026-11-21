using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000833 RID: 2099
	[NetMessage(EMessageId.ItemDecomposeRequest)]
	public sealed class ItemDecomposeRequest : IMessage<ItemDecomposeRequest>, IMessage, IEquatable<ItemDecomposeRequest>, IDeepCloneable<ItemDecomposeRequest>, IBufferMessage
	{
		// Token: 0x0600BBC6 RID: 48070 RVA: 0x001BF30A File Offset: 0x001BD50A
		[NullableContext(1)]
		public static ItemDecomposeRequest Create()
		{
			return new ItemDecomposeRequest();
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x0600BBC7 RID: 48071 RVA: 0x001BF311 File Offset: 0x001BD511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x001BF314 File Offset: 0x001BD514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDecomposeRequest.Descriptor;
			}
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x001BF31B File Offset: 0x001BD51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeRequest()
		{
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x001BF32E File Offset: 0x001BD52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeRequest(ItemDecomposeRequest other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x001BF358 File Offset: 0x001BD558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDecomposeRequest Clone()
		{
			return new ItemDecomposeRequest(this);
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x001BF360 File Offset: 0x001BD560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecomposeItemInfo> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x001BF368 File Offset: 0x001BD568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDecomposeRequest);
		}

		// Token: 0x0600BBCE RID: 48078 RVA: 0x001BF376 File Offset: 0x001BD576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDecomposeRequest other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x001BF3AC File Offset: 0x001BD5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x001BF3E0 File Offset: 0x001BD5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x001BF3ED File Offset: 0x001BD5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x001BF3F6 File Offset: 0x001BD5F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, ItemDecomposeRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x001BF420 File Offset: 0x001BD620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(ItemDecomposeRequest._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x001BF459 File Offset: 0x001BD659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDecomposeRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x001BF487 File Offset: 0x001BD687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x001BF490 File Offset: 0x001BD690
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, ItemDecomposeRequest._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x040052AB RID: 21163
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052AC RID: 21164
		public const int ItemListFieldNumber = 13;

		// Token: 0x040052AD RID: 21165
		private static readonly FieldCodec<DecomposeItemInfo> _repeated_itemList_codec = FieldCodec.ForMessage<DecomposeItemInfo>(106U, DecomposeItemInfo.Parser);

		// Token: 0x040052AE RID: 21166
		private readonly RepeatedField<DecomposeItemInfo> itemList_ = new RepeatedField<DecomposeItemInfo>();
	}
}
