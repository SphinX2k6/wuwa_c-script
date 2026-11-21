using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F90 RID: 3984
	[NetMessage(EMessageId.RoguelikeInfoNotify)]
	public sealed class RoguelikeInfoNotify : IMessage<RoguelikeInfoNotify>, IMessage, IEquatable<RoguelikeInfoNotify>, IDeepCloneable<RoguelikeInfoNotify>, IBufferMessage
	{
		// Token: 0x06015554 RID: 87380 RVA: 0x003191AC File Offset: 0x003173AC
		[NullableContext(1)]
		public static RoguelikeInfoNotify Create()
		{
			return new RoguelikeInfoNotify();
		}

		// Token: 0x1700471D RID: 18205
		// (get) Token: 0x06015555 RID: 87381 RVA: 0x003191B3 File Offset: 0x003173B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700471E RID: 18206
		// (get) Token: 0x06015556 RID: 87382 RVA: 0x003191B6 File Offset: 0x003173B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeInfoNotify.Descriptor;
			}
		}

		// Token: 0x06015557 RID: 87383 RVA: 0x003191BD File Offset: 0x003173BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInfoNotify()
		{
		}

		// Token: 0x06015558 RID: 87384 RVA: 0x003191E8 File Offset: 0x003173E8
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

		// Token: 0x06015559 RID: 87385 RVA: 0x0031929F File Offset: 0x0031749F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeInfoNotify Clone()
		{
			return new RoguelikeInfoNotify(this);
		}

		// Token: 0x1700471F RID: 18207
		// (get) Token: 0x0601555A RID: 87386 RVA: 0x003192A7 File Offset: 0x003174A7
		// (set) Token: 0x0601555B RID: 87387 RVA: 0x003192AF File Offset: 0x003174AF
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

		// Token: 0x17004720 RID: 18208
		// (get) Token: 0x0601555C RID: 87388 RVA: 0x003192B8 File Offset: 0x003174B8
		// (set) Token: 0x0601555D RID: 87389 RVA: 0x003192C0 File Offset: 0x003174C0
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

		// Token: 0x17004721 RID: 18209
		// (get) Token: 0x0601555E RID: 87390 RVA: 0x003192C9 File Offset: 0x003174C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> BuffEntryList
		{
			get
			{
				return this.buffEntryList_;
			}
		}

		// Token: 0x17004722 RID: 18210
		// (get) Token: 0x0601555F RID: 87391 RVA: 0x003192D1 File Offset: 0x003174D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ElementDict
		{
			get
			{
				return this.elementDict_;
			}
		}

		// Token: 0x17004723 RID: 18211
		// (get) Token: 0x06015560 RID: 87392 RVA: 0x003192D9 File Offset: 0x003174D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGainEntry> MiraclecreationList
		{
			get
			{
				return this.miraclecreationList_;
			}
		}

		// Token: 0x17004724 RID: 18212
		// (get) Token: 0x06015561 RID: 87393 RVA: 0x003192E1 File Offset: 0x003174E1
		// (set) Token: 0x06015562 RID: 87394 RVA: 0x003192E9 File Offset: 0x003174E9
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

		// Token: 0x17004725 RID: 18213
		// (get) Token: 0x06015563 RID: 87395 RVA: 0x003192F2 File Offset: 0x003174F2
		// (set) Token: 0x06015564 RID: 87396 RVA: 0x003192FA File Offset: 0x003174FA
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

		// Token: 0x06015565 RID: 87397 RVA: 0x00319303 File Offset: 0x00317503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeInfoNotify);
		}

		// Token: 0x06015566 RID: 87398 RVA: 0x00319314 File Offset: 0x00317514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeInfoNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoleEntry, other.RoleEntry) && object.Equals(this.PhantomEntry, other.PhantomEntry) && this.buffEntryList_.Equals(other.buffEntryList_) && this.ElementDict.Equals(other.ElementDict) && this.miraclecreationList_.Equals(other.miraclecreationList_) && object.Equals(this.RoguelikeInstInfo, other.RoguelikeInstInfo) && this.ModeType == other.ModeType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015567 RID: 87399 RVA: 0x003193CC File Offset: 0x003175CC
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

		// Token: 0x06015568 RID: 87400 RVA: 0x0031947D File Offset: 0x0031767D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015569 RID: 87401 RVA: 0x0031948A File Offset: 0x0031768A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601556A RID: 87402 RVA: 0x00319494 File Offset: 0x00317694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.miraclecreationList_.WriteTo(ref output, RoguelikeInfoNotify._repeated_miraclecreationList_codec);
			if (this.roleEntry_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RoleEntry);
			}
			this.buffEntryList_.WriteTo(ref output, RoguelikeInfoNotify._repeated_buffEntryList_codec);
			if (this.ModeType != RogueChallengeModeType.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ModeType);
			}
			this.elementDict_.WriteTo(ref output, RoguelikeInfoNotify._map_elementDict_codec);
			if (this.roguelikeInstInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RoguelikeInstInfo);
			}
			if (this.phantomEntry_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PhantomEntry);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601556B RID: 87403 RVA: 0x00319558 File Offset: 0x00317758
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

		// Token: 0x0601556C RID: 87404 RVA: 0x00319618 File Offset: 0x00317818
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

		// Token: 0x0601556D RID: 87405 RVA: 0x0031970B File Offset: 0x0031790B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601556E RID: 87406 RVA: 0x00319714 File Offset: 0x00317914
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
				if (num <= 58U)
				{
					if (num == 10U)
					{
						this.miraclecreationList_.AddEntriesFrom(ref input, RoguelikeInfoNotify._repeated_miraclecreationList_codec);
						continue;
					}
					if (num == 26U)
					{
						if (this.roleEntry_ == null)
						{
							this.RoleEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.RoleEntry);
						continue;
					}
					if (num == 58U)
					{
						this.buffEntryList_.AddEntriesFrom(ref input, RoguelikeInfoNotify._repeated_buffEntryList_codec);
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 80U)
					{
						this.ModeType = (RogueChallengeModeType)input.ReadEnum();
						continue;
					}
					if (num == 98U)
					{
						this.elementDict_.AddEntriesFrom(ref input, RoguelikeInfoNotify._map_elementDict_codec);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.roguelikeInstInfo_ == null)
						{
							this.RoguelikeInstInfo = new RoguelikeInstInfo();
						}
						input.ReadMessage(this.RoguelikeInstInfo);
						continue;
					}
					if (num == 114U)
					{
						if (this.phantomEntry_ == null)
						{
							this.PhantomEntry = new RogueGainEntry();
						}
						input.ReadMessage(this.PhantomEntry);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040080CE RID: 32974
		private UnknownFieldSet _unknownFields;

		// Token: 0x040080CF RID: 32975
		public const int RoleEntryFieldNumber = 3;

		// Token: 0x040080D0 RID: 32976
		private RogueGainEntry roleEntry_;

		// Token: 0x040080D1 RID: 32977
		public const int PhantomEntryFieldNumber = 14;

		// Token: 0x040080D2 RID: 32978
		private RogueGainEntry phantomEntry_;

		// Token: 0x040080D3 RID: 32979
		public const int BuffEntryListFieldNumber = 7;

		// Token: 0x040080D4 RID: 32980
		private static readonly FieldCodec<RogueGainEntry> _repeated_buffEntryList_codec = FieldCodec.ForMessage<RogueGainEntry>(58U, RogueGainEntry.Parser);

		// Token: 0x040080D5 RID: 32981
		private readonly RepeatedField<RogueGainEntry> buffEntryList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080D6 RID: 32982
		public const int ElementDictFieldNumber = 12;

		// Token: 0x040080D7 RID: 32983
		private static readonly MapField<int, int>.Codec _map_elementDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 98U);

		// Token: 0x040080D8 RID: 32984
		private readonly MapField<int, int> elementDict_ = new MapField<int, int>();

		// Token: 0x040080D9 RID: 32985
		public const int MiraclecreationListFieldNumber = 1;

		// Token: 0x040080DA RID: 32986
		private static readonly FieldCodec<RogueGainEntry> _repeated_miraclecreationList_codec = FieldCodec.ForMessage<RogueGainEntry>(10U, RogueGainEntry.Parser);

		// Token: 0x040080DB RID: 32987
		private readonly RepeatedField<RogueGainEntry> miraclecreationList_ = new RepeatedField<RogueGainEntry>();

		// Token: 0x040080DC RID: 32988
		public const int RoguelikeInstInfoFieldNumber = 13;

		// Token: 0x040080DD RID: 32989
		private RoguelikeInstInfo roguelikeInstInfo_;

		// Token: 0x040080DE RID: 32990
		public const int ModeTypeFieldNumber = 10;

		// Token: 0x040080DF RID: 32991
		private RogueChallengeModeType modeType_;
	}
}
