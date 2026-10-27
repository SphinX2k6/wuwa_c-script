using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142E RID: 5166
	[NetMessage(EMessageId.TrapDefenseItemUpdateNotify)]
	public sealed class TrapDefenseItemUpdateNotify : IMessage<TrapDefenseItemUpdateNotify>, IMessage, IEquatable<TrapDefenseItemUpdateNotify>, IDeepCloneable<TrapDefenseItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B5F3 RID: 112115 RVA: 0x003F6DE2 File Offset: 0x003F4FE2
		[NullableContext(1)]
		public static TrapDefenseItemUpdateNotify Create()
		{
			return new TrapDefenseItemUpdateNotify();
		}

		// Token: 0x17005C4E RID: 23630
		// (get) Token: 0x0601B5F4 RID: 112116 RVA: 0x003F6DE9 File Offset: 0x003F4FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C4F RID: 23631
		// (get) Token: 0x0601B5F5 RID: 112117 RVA: 0x003F6DEC File Offset: 0x003F4FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B5F6 RID: 112118 RVA: 0x003F6DF3 File Offset: 0x003F4FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemUpdateNotify()
		{
		}

		// Token: 0x0601B5F7 RID: 112119 RVA: 0x003F6E06 File Offset: 0x003F5006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemUpdateNotify(TrapDefenseItemUpdateNotify other) : this()
		{
			this.itemDatas_ = other.itemDatas_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5F8 RID: 112120 RVA: 0x003F6E30 File Offset: 0x003F5030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseItemUpdateNotify Clone()
		{
			return new TrapDefenseItemUpdateNotify(this);
		}

		// Token: 0x17005C50 RID: 23632
		// (get) Token: 0x0601B5F9 RID: 112121 RVA: 0x003F6E38 File Offset: 0x003F5038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseItemPbData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x0601B5FA RID: 112122 RVA: 0x003F6E40 File Offset: 0x003F5040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseItemUpdateNotify);
		}

		// Token: 0x0601B5FB RID: 112123 RVA: 0x003F6E4E File Offset: 0x003F504E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseItemUpdateNotify other)
		{
			return other != null && (other == this || (this.itemDatas_.Equals(other.itemDatas_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5FC RID: 112124 RVA: 0x003F6E84 File Offset: 0x003F5084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemDatas_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B5FD RID: 112125 RVA: 0x003F6EB8 File Offset: 0x003F50B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5FE RID: 112126 RVA: 0x003F6EC5 File Offset: 0x003F50C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5FF RID: 112127 RVA: 0x003F6ECE File Offset: 0x003F50CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemDatas_.WriteTo(ref output, TrapDefenseItemUpdateNotify._repeated_itemDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B600 RID: 112128 RVA: 0x003F6EF8 File Offset: 0x003F50F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemDatas_.CalculateSize(TrapDefenseItemUpdateNotify._repeated_itemDatas_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B601 RID: 112129 RVA: 0x003F6F31 File Offset: 0x003F5131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemDatas_.Add(other.itemDatas_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B602 RID: 112130 RVA: 0x003F6F5F File Offset: 0x003F515F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B603 RID: 112131 RVA: 0x003F6F68 File Offset: 0x003F5168
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
					this.itemDatas_.AddEntriesFrom(ref input, TrapDefenseItemUpdateNotify._repeated_itemDatas_codec);
				}
			}
		}

		// Token: 0x04009E0F RID: 40463
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E10 RID: 40464
		public const int ItemDatasFieldNumber = 1;

		// Token: 0x04009E11 RID: 40465
		private static readonly FieldCodec<TrapDefenseItemPbData> _repeated_itemDatas_codec = FieldCodec.ForMessage<TrapDefenseItemPbData>(10U, TrapDefenseItemPbData.Parser);

		// Token: 0x04009E12 RID: 40466
		private readonly RepeatedField<TrapDefenseItemPbData> itemDatas_ = new RepeatedField<TrapDefenseItemPbData>();
	}
}
