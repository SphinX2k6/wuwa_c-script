using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E60 RID: 3680
	public sealed class RacingBetsGroupMatchesInfo : IMessage<RacingBetsGroupMatchesInfo>, IMessage, IEquatable<RacingBetsGroupMatchesInfo>, IDeepCloneable<RacingBetsGroupMatchesInfo>, IBufferMessage
	{
		// Token: 0x06013C14 RID: 80916 RVA: 0x002DF19F File Offset: 0x002DD39F
		[NullableContext(1)]
		public static RacingBetsGroupMatchesInfo Create()
		{
			return new RacingBetsGroupMatchesInfo();
		}

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x06013C15 RID: 80917 RVA: 0x002DF1A6 File Offset: 0x002DD3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsGroupMatchesInfo> Parser
		{
			get
			{
				return RacingBetsGroupMatchesInfo._parser;
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x06013C16 RID: 80918 RVA: 0x002DF1AD File Offset: 0x002DD3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x06013C17 RID: 80919 RVA: 0x002DF1B0 File Offset: 0x002DD3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGroupMatchesInfo.Descriptor;
			}
		}

		// Token: 0x06013C18 RID: 80920 RVA: 0x002DF1B7 File Offset: 0x002DD3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGroupMatchesInfo()
		{
		}

		// Token: 0x06013C19 RID: 80921 RVA: 0x002DF1E0 File Offset: 0x002DD3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGroupMatchesInfo(RacingBetsGroupMatchesInfo other) : this()
		{
			this.groupMatchId_ = other.groupMatchId_;
			this.groupMatchTime_ = ((other.groupMatchTime_ != null) ? other.groupMatchTime_.Clone() : null);
			this.legMatchesInfo_ = other.legMatchesInfo_.Clone();
			this.promoteDangos_ = other.promoteDangos_.Clone();
			this.dangos_ = other.dangos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013C1A RID: 80922 RVA: 0x002DF25F File Offset: 0x002DD45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGroupMatchesInfo Clone()
		{
			return new RacingBetsGroupMatchesInfo(this);
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x06013C1B RID: 80923 RVA: 0x002DF267 File Offset: 0x002DD467
		// (set) Token: 0x06013C1C RID: 80924 RVA: 0x002DF26F File Offset: 0x002DD46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupMatchId
		{
			get
			{
				return this.groupMatchId_;
			}
			set
			{
				this.groupMatchId_ = value;
			}
		}

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x06013C1D RID: 80925 RVA: 0x002DF278 File Offset: 0x002DD478
		// (set) Token: 0x06013C1E RID: 80926 RVA: 0x002DF280 File Offset: 0x002DD480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsTimeTuple GroupMatchTime
		{
			get
			{
				return this.groupMatchTime_;
			}
			set
			{
				this.groupMatchTime_ = value;
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x06013C1F RID: 80927 RVA: 0x002DF289 File Offset: 0x002DD489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsLegMatchesInfo> LegMatchesInfo
		{
			get
			{
				return this.legMatchesInfo_;
			}
		}

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x06013C20 RID: 80928 RVA: 0x002DF291 File Offset: 0x002DD491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PromoteDangos
		{
			get
			{
				return this.promoteDangos_;
			}
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x06013C21 RID: 80929 RVA: 0x002DF299 File Offset: 0x002DD499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Dangos
		{
			get
			{
				return this.dangos_;
			}
		}

		// Token: 0x06013C22 RID: 80930 RVA: 0x002DF2A1 File Offset: 0x002DD4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGroupMatchesInfo);
		}

		// Token: 0x06013C23 RID: 80931 RVA: 0x002DF2B0 File Offset: 0x002DD4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGroupMatchesInfo other)
		{
			return other != null && (other == this || (this.GroupMatchId == other.GroupMatchId && object.Equals(this.GroupMatchTime, other.GroupMatchTime) && this.legMatchesInfo_.Equals(other.legMatchesInfo_) && this.promoteDangos_.Equals(other.promoteDangos_) && this.dangos_.Equals(other.dangos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013C24 RID: 80932 RVA: 0x002DF340 File Offset: 0x002DD540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupMatchId != 0)
			{
				num ^= this.GroupMatchId.GetHashCode();
			}
			if (this.groupMatchTime_ != null)
			{
				num ^= this.GroupMatchTime.GetHashCode();
			}
			num ^= this.legMatchesInfo_.GetHashCode();
			num ^= this.promoteDangos_.GetHashCode();
			num ^= this.dangos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013C25 RID: 80933 RVA: 0x002DF3BF File Offset: 0x002DD5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013C26 RID: 80934 RVA: 0x002DF3CC File Offset: 0x002DD5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013C27 RID: 80935 RVA: 0x002DF3D8 File Offset: 0x002DD5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupMatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupMatchId);
			}
			if (this.groupMatchTime_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GroupMatchTime);
			}
			this.legMatchesInfo_.WriteTo(ref output, RacingBetsGroupMatchesInfo._repeated_legMatchesInfo_codec);
			this.promoteDangos_.WriteTo(ref output, RacingBetsGroupMatchesInfo._repeated_promoteDangos_codec);
			this.dangos_.WriteTo(ref output, RacingBetsGroupMatchesInfo._repeated_dangos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013C28 RID: 80936 RVA: 0x002DF464 File Offset: 0x002DD664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupMatchId);
			}
			if (this.groupMatchTime_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GroupMatchTime);
			}
			num += this.legMatchesInfo_.CalculateSize(RacingBetsGroupMatchesInfo._repeated_legMatchesInfo_codec);
			num += this.promoteDangos_.CalculateSize(RacingBetsGroupMatchesInfo._repeated_promoteDangos_codec);
			num += this.dangos_.CalculateSize(RacingBetsGroupMatchesInfo._repeated_dangos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013C29 RID: 80937 RVA: 0x002DF4F4 File Offset: 0x002DD6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGroupMatchesInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupMatchId != 0)
			{
				this.GroupMatchId = other.GroupMatchId;
			}
			if (other.groupMatchTime_ != null)
			{
				if (this.groupMatchTime_ == null)
				{
					this.GroupMatchTime = new RacingBetsTimeTuple();
				}
				this.GroupMatchTime.MergeFrom(other.GroupMatchTime);
			}
			this.legMatchesInfo_.Add(other.legMatchesInfo_);
			this.promoteDangos_.Add(other.promoteDangos_);
			this.dangos_.Add(other.dangos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013C2A RID: 80938 RVA: 0x002DF58F File Offset: 0x002DD78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013C2B RID: 80939 RVA: 0x002DF598 File Offset: 0x002DD798
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.GroupMatchId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						if (this.groupMatchTime_ == null)
						{
							this.GroupMatchTime = new RacingBetsTimeTuple();
						}
						input.ReadMessage(this.GroupMatchTime);
						continue;
					}
					if (num == 26U)
					{
						this.legMatchesInfo_.AddEntriesFrom(ref input, RacingBetsGroupMatchesInfo._repeated_legMatchesInfo_codec);
						continue;
					}
				}
				else if (num <= 34U)
				{
					if (num == 32U || num == 34U)
					{
						this.promoteDangos_.AddEntriesFrom(ref input, RacingBetsGroupMatchesInfo._repeated_promoteDangos_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.dangos_.AddEntriesFrom(ref input, RacingBetsGroupMatchesInfo._repeated_dangos_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040078C7 RID: 30919
		private static readonly MessageParser<RacingBetsGroupMatchesInfo> _parser = new MessageParser<RacingBetsGroupMatchesInfo>(() => new RacingBetsGroupMatchesInfo());

		// Token: 0x040078C8 RID: 30920
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078C9 RID: 30921
		public const int GroupMatchIdFieldNumber = 1;

		// Token: 0x040078CA RID: 30922
		private int groupMatchId_;

		// Token: 0x040078CB RID: 30923
		public const int GroupMatchTimeFieldNumber = 2;

		// Token: 0x040078CC RID: 30924
		private RacingBetsTimeTuple groupMatchTime_;

		// Token: 0x040078CD RID: 30925
		public const int LegMatchesInfoFieldNumber = 3;

		// Token: 0x040078CE RID: 30926
		private static readonly FieldCodec<RacingBetsLegMatchesInfo> _repeated_legMatchesInfo_codec = FieldCodec.ForMessage<RacingBetsLegMatchesInfo>(26U, RacingBetsLegMatchesInfo.Parser);

		// Token: 0x040078CF RID: 30927
		private readonly RepeatedField<RacingBetsLegMatchesInfo> legMatchesInfo_ = new RepeatedField<RacingBetsLegMatchesInfo>();

		// Token: 0x040078D0 RID: 30928
		public const int PromoteDangosFieldNumber = 4;

		// Token: 0x040078D1 RID: 30929
		private static readonly FieldCodec<int> _repeated_promoteDangos_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040078D2 RID: 30930
		private readonly RepeatedField<int> promoteDangos_ = new RepeatedField<int>();

		// Token: 0x040078D3 RID: 30931
		public const int DangosFieldNumber = 5;

		// Token: 0x040078D4 RID: 30932
		private static readonly FieldCodec<int> _repeated_dangos_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040078D5 RID: 30933
		private readonly RepeatedField<int> dangos_ = new RepeatedField<int>();
	}
}
