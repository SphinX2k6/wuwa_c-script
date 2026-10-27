using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA0 RID: 4000
	[NetMessage(EMessageId.RoguelikeInfoNotify)]
	public sealed class RoguelikeInfoNotify : IMessage<RoguelikeInfoNotify>, IMessage, IEquatable<RoguelikeInfoNotify>, IDeepCloneable<RoguelikeInfoNotify>, IBufferMessage
	{
		// Token: 0x06015639 RID: 87609 RVA: 0x0031A859 File Offset: 0x00318A59
		[NullableContext(1)]
		public static RoguelikeInfoNotify Create()
		{
			return new RoguelikeInfoNotify();
		}

		// Token: 0x17004747 RID: 18247
		// (get) Token: 0x0601563A RID: 87610 RVA: 0x0031A860 File Offset: 0x00318A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004748 RID: 18248
		// (get) Token: 0x0601563B RID: 87611 RVA: 0x0031A863 File Offset: 0x00318A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601563C RID: 87612 RVA: 0x0031A86A File Offset: 0x00318A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInfoNotify()
		{
		}

		// Token: 0x0601563D RID: 87613 RVA: 0x0031A894 File Offset: 0x00318A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInfoNotify(RoguelikeInfoNotify other) : this()
		{
			this.roleEntry_ = ((other.roleEntry_ != null) ? other.roleEntry_.Clone() : null);
			this.phantomEntry_ = ((other.phantomEntry_ != null) ? other.phantomEntry_.Clone() : null);
			this.buffEntryList_ = other.buffEntryList_.Clone();
			this.elementDict_ = other.elementDict_.Clone();
			this.miraclecreationList_ = other.miraclecreationList_.Clone();
			this.roguelikeInstInfo_ = ((other.roguelikeInstInfo_ != null) ? other.roguelikeInstInfo_.Clone() : null);
			this.modeType_ = other.modeType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601563E RID: 87614 RVA: 0x0031A94B File Offset: 0x00318B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInfoNotify Clone()
		{
			return new RoguelikeInfoNotify(this);
		}

		// Token: 0x17004749 RID: 18249
		// (get) Token: 0x0601563F RID: 87615 RVA: 0x0031A953 File Offset: 0x00318B53
		// (set) Token: 0x06015640 RID: 87616 RVA: 0x0031A95B File Offset: 0x00318B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry RoleEntry
		{
			get
			{
				return this.roleEntry_;
			}
			set
			{
				this.roleEntry_ = value;
			}
		}

		// Token: 0x1700474A RID: 18250
		// (get) Token: 0x06015641 RID: 87617 RVA: 0x0031A964 File Offset: 0x00318B64
		// (set) Token: 0x06015642 RID: 87618 RVA: 0x0031A96C File Offset: 0x00318B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGainEntry PhantomEntry
		{
			get
			{
				return this.phantomEntry_;
			}
			set
			{
				this.phantomEntry_ = value;
			}
		}

		// Token: 0x1700474B RID: 18251
		// (get) Token: 0x06015643 RID: 87619 RVA: 0x0031A975 File Offset: 0x00318B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> BuffEntryList
		{
			get
			{
				return this.buffEntryList_;
			}
		}

		// Token: 0x1700474C RID: 18252
		// (get) Token: 0x06015644 RID: 87620 RVA: 0x0031A97D File Offset: 0x00318B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x1700474D RID: 18253
		// (get) Token: 0x06015645 RID: 87621 RVA: 0x0031A985 File Offset: 0x00318B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> MiraclecreationList
		{
			get
			{
				return this.miraclecreationList_;
			}
		}

		// Token: 0x1700474E RID: 18254
		// (get) Token: 0x06015646 RID: 87622 RVA: 0x0031A98D File Offset: 0x00318B8D
		// (set) Token: 0x06015647 RID: 87623 RVA: 0x0031A995 File Offset: 0x00318B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo RoguelikeInstInfo
		{
			get
			{
				return this.roguelikeInstInfo_;
			}
			set
			{
				this.roguelikeInstInfo_ = value;
			}
		}

		// Token: 0x1700474F RID: 18255
		// (get) Token: 0x06015648 RID: 87624 RVA: 0x0031A99E File Offset: 0x00318B9E
		// (set) Token: 0x06015649 RID: 87625 RVA: 0x0031A9A6 File Offset: 0x00318BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueChallengeModeType ModeType
		{
			get
			{
				return this.modeType_;
			}
			set
			{
				this.modeType_ = value;
			}
		}

		// Token: 0x0601564A RID: 87626 RVA: 0x0031A9AF File Offset: 0x00318BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeInfoNotify);
		}

		// Token: 0x0601564B RID: 87627 RVA: 0x0031A9C0 File Offset: 0x00318BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoleEntry, other.RoleEntry) && object.Equals(this.PhantomEntry, other.PhantomEntry) && this.buffEntryList_.Equals(other.buffEntryList_) && this.ElementDict.Equals(other.ElementDict) && this.miraclecreationList_.Equals(other.miraclecreationList_) && object.Equals(this.RoguelikeInstInfo, other.RoguelikeInstInfo) && this.ModeType == other.ModeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601564C RID: 87628 RVA: 0x0031AA78 File Offset: 0x00318C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleEntry_ != null)
			{
				num ^= this.RoleEntry.GetHashCode();
			}
			if (this.phantomEntry_ != null)
			{
				num ^= this.PhantomEntry.GetHashCode();
			}
			num ^= this.buffEntryList_.GetHashCode();
			num ^= this.ElementDict.GetHashCode();
			num ^= this.miraclecreationList_.GetHashCode();
			if (this.roguelikeInstInfo_ != null)
			{
				num ^= this.RoguelikeInstInfo.GetHashCode();
			}
			if (this.ModeType != RogueChallengeModeType.None)
			{
				num ^= this.ModeType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601564D RID: 87629 RVA: 0x0031AB29 File Offset: 0x00318D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601564E RID: 87630 RVA: 0x0031AB36 File Offset: 0x00318D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601564F RID: 87631 RVA: 0x0031AB40 File Offset: 0x00318D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomEntry_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhantomEntry);
			}
			this.buffEntryList_.WriteTo(ref output, RoguelikeInfoNotify._repeated_buffEntryList_codec);
			this.elementDict_.WriteTo(ref output, RoguelikeInfoNotify._map_elementDict_codec);
			if (this.ModeType != RogueChallengeModeType.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ModeType);
			}
			if (this.roleEntry_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RoleEntry);
			}
			this.miraclecreationList_.WriteTo(ref output, RoguelikeInfoNotify._repeated_miraclecreationList_codec);
			if (this.roguelikeInstInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RoguelikeInstInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015650 RID: 87632 RVA: 0x0031AC04 File Offset: 0x00318E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleEntry);
			}
			if (this.phantomEntry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomEntry);
			}
			num += this.buffEntryList_.CalculateSize(RoguelikeInfoNotify._repeated_buffEntryList_codec);
			num += this.elementDict_.CalculateSize(RoguelikeInfoNotify._map_elementDict_codec);
			num += this.miraclecreationList_.CalculateSize(RoguelikeInfoNotify._repeated_miraclecreationList_codec);
			if (this.roguelikeInstInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoguelikeInstInfo);
			}
			if (this.ModeType != RogueChallengeModeType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ModeType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015651 RID: 87633 RVA: 0x0031ACC4 File Offset: 0x00318EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleEntry_ != null)
			{
				if (this.roleEntry_ == null)
				{
					this.RoleEntry = new RogueGainEntry();
				}
				this.RoleEntry.MergeFrom(other.RoleEntry);
			}
			if (other.phantomEntry_ != null)
			{
				if (this.phantomEntry_ == null)
				{
					this.PhantomEntry = new RogueGainEntry();
				}
				this.PhantomEntry.MergeFrom(other.PhantomEntry);
			}
			this.buffEntryList_.Add(other.buffEntryList_);
			this.elementDict_.MergeFrom(other.elementDict_);
			this.miraclecreationList_.Add(other.miraclecreationList_);
			if (other.roguelikeInstInfo_ != null)
			{
				if (this.roguelikeInstInfo_ == null)
				{
					this.RoguelikeInstInfo = new RoguelikeInstInfo();
				}
				this.RoguelikeInstInfo.MergeFrom(other.RoguelikeInstInfo);
			}
			if (other.ModeType != RogueChallengeModeType.None)
			{
				this.ModeType = other.ModeType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015652 RID: 87634 RVA: 0x0031ADB7 File Offset: 0x00318FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015653 RID: 87635 RVA: 0x0031ADC0 File Offset: 0x00318FC0
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
				if (num <= 66U)
				{
					if (num == 18U)
					{
						if (this.phantomEntry_ == null)
						{
							this.PhantomEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.PhantomEntry);
						continue;
					}
					if (num == 34U)
					{
						this.buffEntryList_.AddEntriesFrom(ref input, RoguelikeInfoNotify._repeated_buffEntryList_codec);
						continue;
					}
					if (num == 66U)
					{
						this.elementDict_.AddEntriesFrom(ref input, RoguelikeInfoNotify._map_elementDict_codec);
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 72U)
					{
						this.ModeType = (RogueChallengeModeType)input.ReadEnum();
						continue;
					}
					if (num == 98U)
					{
						if (this.roleEntry_ == null)
						{
							this.RoleEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.RoleEntry);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.miraclecreationList_.AddEntriesFrom(ref input, RoguelikeInfoNotify._repeated_miraclecreationList_codec);
						continue;
					}
					if (num == 114U)
					{
						if (this.roguelikeInstInfo_ == null)
						{
							this.RoguelikeInstInfo = new RoguelikeInstInfo();
						}
						input.ReadMessage(this.RoguelikeInstInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080A4 RID: 32932
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080A5 RID: 32933
		public const int RoleEntryFieldNumber = 12;

		// Token: 0x040080A6 RID: 32934
		private RogueGainEntry roleEntry_;

		// Token: 0x040080A7 RID: 32935
		public const int PhantomEntryFieldNumber = 2;

		// Token: 0x040080A8 RID: 32936
		private RogueGainEntry phantomEntry_;

		// Token: 0x040080A9 RID: 32937
		public const int BuffEntryListFieldNumber = 4;

		// Token: 0x040080AA RID: 32938
		private static readonly FieldCodec<RogueGainEntry> _repeated_buffEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(34U, RogueGainEntry.Parser);

		// Token: 0x040080AB RID: 32939
		private readonly RepeatedField<RogueGainEntry> buffEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080AC RID: 32940
		public const int ElementDictFieldNumber = 8;

		// Token: 0x040080AD RID: 32941
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x040080AE RID: 32942
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();

		// Token: 0x040080AF RID: 32943
		public const int MiraclecreationListFieldNumber = 13;

		// Token: 0x040080B0 RID: 32944
		private static readonly FieldCodec<RogueGainEntry> _repeated_miraclecreationList_codec = FieldCodec.ForMessage<RogueGainEntry>(106U, RogueGainEntry.Parser);

		// Token: 0x040080B1 RID: 32945
		private readonly RepeatedField<RogueGainEntry> miraclecreationList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080B2 RID: 32946
		public const int RoguelikeInstInfoFieldNumber = 14;

		// Token: 0x040080B3 RID: 32947
		private RoguelikeInstInfo roguelikeInstInfo_;

		// Token: 0x040080B4 RID: 32948
		public const int ModeTypeFieldNumber = 9;

		// Token: 0x040080B5 RID: 32949
		private RogueChallengeModeType modeType_;
	}
}
