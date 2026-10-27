using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA1 RID: 4001
	public sealed class RoguelikeInstInfo : IMessage<RoguelikeInstInfo>, IMessage, IEquatable<RoguelikeInstInfo>, IDeepCloneable<RoguelikeInstInfo>, IBufferMessage
	{
		// Token: 0x06015655 RID: 87637 RVA: 0x0031AF21 File Offset: 0x00319121
		[NullableContext(1)]
		public static RoguelikeInstInfo Create()
		{
			return new RoguelikeInstInfo();
		}

		// Token: 0x17004750 RID: 18256
		// (get) Token: 0x06015656 RID: 87638 RVA: 0x0031AF28 File Offset: 0x00319128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004751 RID: 18257
		// (get) Token: 0x06015657 RID: 87639 RVA: 0x0031AF2B File Offset: 0x0031912B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeInstInfo.Descriptor;
			}
		}

		// Token: 0x06015658 RID: 87640 RVA: 0x0031AF32 File Offset: 0x00319132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo()
		{
		}

		// Token: 0x06015659 RID: 87641 RVA: 0x0031AF5C File Offset: 0x0031915C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo(RoguelikeInstInfo other) : this()
		{
			this.roleEntry_ = ((other.roleEntry_ != null) ? other.roleEntry_.Clone() : null);
			this.phantomEntry_ = ((other.phantomEntry_ != null) ? other.phantomEntry_.Clone() : null);
			this.buffEntryList_ = other.buffEntryList_.Clone();
			this.elementDict_ = other.elementDict_.Clone();
			this.miraclecreationList_ = other.miraclecreationList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601565A RID: 87642 RVA: 0x0031AFEB File Offset: 0x003191EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInstInfo Clone()
		{
			return new RoguelikeInstInfo(this);
		}

		// Token: 0x17004752 RID: 18258
		// (get) Token: 0x0601565B RID: 87643 RVA: 0x0031AFF3 File Offset: 0x003191F3
		// (set) Token: 0x0601565C RID: 87644 RVA: 0x0031AFFB File Offset: 0x003191FB
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

		// Token: 0x17004753 RID: 18259
		// (get) Token: 0x0601565D RID: 87645 RVA: 0x0031B004 File Offset: 0x00319204
		// (set) Token: 0x0601565E RID: 87646 RVA: 0x0031B00C File Offset: 0x0031920C
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

		// Token: 0x17004754 RID: 18260
		// (get) Token: 0x0601565F RID: 87647 RVA: 0x0031B015 File Offset: 0x00319215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> BuffEntryList
		{
			get
			{
				return this.buffEntryList_;
			}
		}

		// Token: 0x17004755 RID: 18261
		// (get) Token: 0x06015660 RID: 87648 RVA: 0x0031B01D File Offset: 0x0031921D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x17004756 RID: 18262
		// (get) Token: 0x06015661 RID: 87649 RVA: 0x0031B025 File Offset: 0x00319225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> MiraclecreationList
		{
			get
			{
				return this.miraclecreationList_;
			}
		}

		// Token: 0x06015662 RID: 87650 RVA: 0x0031B02D File Offset: 0x0031922D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeInstInfo);
		}

		// Token: 0x06015663 RID: 87651 RVA: 0x0031B03C File Offset: 0x0031923C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeInstInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RoleEntry, other.RoleEntry) && object.Equals(this.PhantomEntry, other.PhantomEntry) && this.buffEntryList_.Equals(other.buffEntryList_) && this.ElementDict.Equals(other.ElementDict) && this.miraclecreationList_.Equals(other.miraclecreationList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015664 RID: 87652 RVA: 0x0031B0D0 File Offset: 0x003192D0
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015665 RID: 87653 RVA: 0x0031B14C File Offset: 0x0031934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015666 RID: 87654 RVA: 0x0031B159 File Offset: 0x00319359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015667 RID: 87655 RVA: 0x0031B164 File Offset: 0x00319364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleEntry_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoleEntry);
			}
			if (this.phantomEntry_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhantomEntry);
			}
			this.buffEntryList_.WriteTo(ref output, RoguelikeInstInfo._repeated_buffEntryList_codec);
			this.elementDict_.WriteTo(ref output, RoguelikeInstInfo._map_elementDict_codec);
			this.miraclecreationList_.WriteTo(ref output, RoguelikeInstInfo._repeated_miraclecreationList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015668 RID: 87656 RVA: 0x0031B1F0 File Offset: 0x003193F0
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
			num += this.buffEntryList_.CalculateSize(RoguelikeInstInfo._repeated_buffEntryList_codec);
			num += this.elementDict_.CalculateSize(RoguelikeInstInfo._map_elementDict_codec);
			num += this.miraclecreationList_.CalculateSize(RoguelikeInstInfo._repeated_miraclecreationList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015669 RID: 87657 RVA: 0x0031B280 File Offset: 0x00319480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeInstInfo other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601566A RID: 87658 RVA: 0x0031B333 File Offset: 0x00319533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601566B RID: 87659 RVA: 0x0031B33C File Offset: 0x0031953C
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						if (this.roleEntry_ == null)
						{
							this.RoleEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.RoleEntry);
						continue;
					}
					if (num == 18U)
					{
						if (this.phantomEntry_ == null)
						{
							this.PhantomEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.PhantomEntry);
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.buffEntryList_.AddEntriesFrom(ref input, RoguelikeInstInfo._repeated_buffEntryList_codec);
						continue;
					}
					if (num == 34U)
					{
						this.elementDict_.AddEntriesFrom(ref input, RoguelikeInstInfo._map_elementDict_codec);
						continue;
					}
					if (num == 42U)
					{
						this.miraclecreationList_.AddEntriesFrom(ref input, RoguelikeInstInfo._repeated_miraclecreationList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080B6 RID: 32950
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080B7 RID: 32951
		public const int RoleEntryFieldNumber = 1;

		// Token: 0x040080B8 RID: 32952
		private RogueGainEntry roleEntry_;

		// Token: 0x040080B9 RID: 32953
		public const int PhantomEntryFieldNumber = 2;

		// Token: 0x040080BA RID: 32954
		private RogueGainEntry phantomEntry_;

		// Token: 0x040080BB RID: 32955
		public const int BuffEntryListFieldNumber = 3;

		// Token: 0x040080BC RID: 32956
		private static readonly FieldCodec<RogueGainEntry> _repeated_buffEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(26U, RogueGainEntry.Parser);

		// Token: 0x040080BD RID: 32957
		private readonly RepeatedField<RogueGainEntry> buffEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080BE RID: 32958
		public const int ElementDictFieldNumber = 4;

		// Token: 0x040080BF RID: 32959
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x040080C0 RID: 32960
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();

		// Token: 0x040080C1 RID: 32961
		public const int MiraclecreationListFieldNumber = 5;

		// Token: 0x040080C2 RID: 32962
		private static readonly FieldCodec<RogueGainEntry> _repeated_miraclecreationList_codec = FieldCodec.ForMessage<RogueGainEntry>(42U, RogueGainEntry.Parser);

		// Token: 0x040080C3 RID: 32963
		private readonly RepeatedField<RogueGainEntry> miraclecreationList_ = new RepeatedField<RogueGainEntry>();
	}
}
