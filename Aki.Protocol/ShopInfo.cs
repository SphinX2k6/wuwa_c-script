using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F1 RID: 4593
	public sealed class ShopInfo : IMessage<ShopInfo>, IMessage, IEquatable<ShopInfo>, IDeepCloneable<ShopInfo>, IBufferMessage
	{
		// Token: 0x060187C2 RID: 100290 RVA: 0x0038F6C9 File Offset: 0x0038D8C9
		[NullableContext(1)]
		public static ShopInfo Create()
		{
			return new ShopInfo();
		}

		// Token: 0x17005274 RID: 21108
		// (get) Token: 0x060187C3 RID: 100291 RVA: 0x0038F6D0 File Offset: 0x0038D8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShopInfo> Parser
		{
			get
			{
				return ShopInfo._parser;
			}
		}

		// Token: 0x17005275 RID: 21109
		// (get) Token: 0x060187C4 RID: 100292 RVA: 0x0038F6D7 File Offset: 0x0038D8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005276 RID: 21110
		// (get) Token: 0x060187C5 RID: 100293 RVA: 0x0038F6DA File Offset: 0x0038D8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopInfo.Descriptor;
			}
		}

		// Token: 0x060187C6 RID: 100294 RVA: 0x0038F6E1 File Offset: 0x0038D8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo()
		{
		}

		// Token: 0x060187C7 RID: 100295 RVA: 0x0038F6F4 File Offset: 0x0038D8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo(ShopInfo other) : this()
		{
			this.shopId_ = other.shopId_;
			this.updateTime_ = other.updateTime_;
			this.itemInfoList_ = other.itemInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187C8 RID: 100296 RVA: 0x0038F741 File Offset: 0x0038D941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopInfo Clone()
		{
			return new ShopInfo(this);
		}

		// Token: 0x17005277 RID: 21111
		// (get) Token: 0x060187C9 RID: 100297 RVA: 0x0038F749 File Offset: 0x0038D949
		// (set) Token: 0x060187CA RID: 100298 RVA: 0x0038F751 File Offset: 0x0038D951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x17005278 RID: 21112
		// (get) Token: 0x060187CB RID: 100299 RVA: 0x0038F75A File Offset: 0x0038D95A
		// (set) Token: 0x060187CC RID: 100300 RVA: 0x0038F762 File Offset: 0x0038D962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UpdateTime
		{
			get
			{
				return this.updateTime_;
			}
			set
			{
				this.updateTime_ = value;
			}
		}

		// Token: 0x17005279 RID: 21113
		// (get) Token: 0x060187CD RID: 100301 RVA: 0x0038F76B File Offset: 0x0038D96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ShopItemInfoNew> ItemInfoList
		{
			get
			{
				return this.itemInfoList_;
			}
		}

		// Token: 0x060187CE RID: 100302 RVA: 0x0038F773 File Offset: 0x0038D973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopInfo);
		}

		// Token: 0x060187CF RID: 100303 RVA: 0x0038F784 File Offset: 0x0038D984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopInfo other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && this.UpdateTime == other.UpdateTime && this.itemInfoList_.Equals(other.itemInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187D0 RID: 100304 RVA: 0x0038F7E4 File Offset: 0x0038D9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this.UpdateTime != 0U)
			{
				num ^= this.UpdateTime.GetHashCode();
			}
			num ^= this.itemInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060187D1 RID: 100305 RVA: 0x0038F84A File Offset: 0x0038DA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187D2 RID: 100306 RVA: 0x0038F857 File Offset: 0x0038DA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187D3 RID: 100307 RVA: 0x0038F860 File Offset: 0x0038DA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShopId);
			}
			if (this.UpdateTime != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.UpdateTime);
			}
			this.itemInfoList_.WriteTo(ref output, ShopInfo._repeated_itemInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187D4 RID: 100308 RVA: 0x0038F8CC File Offset: 0x0038DACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this.UpdateTime != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UpdateTime);
			}
			num += this.itemInfoList_.CalculateSize(ShopInfo._repeated_itemInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060187D5 RID: 100309 RVA: 0x0038F938 File Offset: 0x0038DB38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			if (other.UpdateTime != 0U)
			{
				this.UpdateTime = other.UpdateTime;
			}
			this.itemInfoList_.Add(other.itemInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060187D6 RID: 100310 RVA: 0x0038F999 File Offset: 0x0038DB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187D7 RID: 100311 RVA: 0x0038F9A4 File Offset: 0x0038DBA4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemInfoList_.AddEntriesFrom(ref input, ShopInfo._repeated_itemInfoList_codec);
						}
					}
					else
					{
						this.UpdateTime = input.ReadUInt32();
					}
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040090BD RID: 37053
		private static readonly MessageParser<ShopInfo> _parser = new MessageParser<ShopInfo>(() => new ShopInfo());

		// Token: 0x040090BE RID: 37054
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090BF RID: 37055
		public const int ShopIdFieldNumber = 1;

		// Token: 0x040090C0 RID: 37056
		private int shopId_;

		// Token: 0x040090C1 RID: 37057
		public const int UpdateTimeFieldNumber = 2;

		// Token: 0x040090C2 RID: 37058
		private uint updateTime_;

		// Token: 0x040090C3 RID: 37059
		public const int ItemInfoListFieldNumber = 3;

		// Token: 0x040090C4 RID: 37060
		private static readonly FieldCodec<ShopItemInfoNew> _repeated_itemInfoList_codec = FieldCodec.ForMessage<ShopItemInfoNew>(26U, ShopItemInfoNew.Parser);

		// Token: 0x040090C5 RID: 37061
		private readonly RepeatedField<ShopItemInfoNew> itemInfoList_ = new RepeatedField<ShopItemInfoNew>();
	}
}
