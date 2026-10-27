using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050B RID: 1291
	[NetMessage(EMessageId.ExploreSkillRouletteSetResponse)]
	public sealed class ExploreSkillRouletteSetResponse : IMessage<ExploreSkillRouletteSetResponse>, IMessage, IEquatable<ExploreSkillRouletteSetResponse>, IDeepCloneable<ExploreSkillRouletteSetResponse>, IBufferMessage
	{
		// Token: 0x06007980 RID: 31104 RVA: 0x001275B2 File Offset: 0x001257B2
		[NullableContext(1)]
		public static ExploreSkillRouletteSetResponse Create()
		{
			return new ExploreSkillRouletteSetResponse();
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06007981 RID: 31105 RVA: 0x001275B9 File Offset: 0x001257B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06007982 RID: 31106 RVA: 0x001275BC File Offset: 0x001257BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRouletteSetResponse.Descriptor;
			}
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x001275C3 File Offset: 0x001257C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetResponse()
		{
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x001275D8 File Offset: 0x001257D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetResponse(ExploreSkillRouletteSetResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.skillRoulette_ = ((other.skillRoulette_ != null) ? other.skillRoulette_.Clone() : null);
			this.rouletteType_ = other.rouletteType_;
			this.skillRoulettes_ = other.skillRoulettes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x00127641 File Offset: 0x00125841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetResponse Clone()
		{
			return new ExploreSkillRouletteSetResponse(this);
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06007986 RID: 31110 RVA: 0x00127649 File Offset: 0x00125849
		// (set) Token: 0x06007987 RID: 31111 RVA: 0x00127651 File Offset: 0x00125851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06007988 RID: 31112 RVA: 0x0012765A File Offset: 0x0012585A
		// (set) Token: 0x06007989 RID: 31113 RVA: 0x00127662 File Offset: 0x00125862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette SkillRoulette
		{
			get
			{
				return this.skillRoulette_;
			}
			set
			{
				this.skillRoulette_ = value;
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600798A RID: 31114 RVA: 0x0012766B File Offset: 0x0012586B
		// (set) Token: 0x0600798B RID: 31115 RVA: 0x00127673 File Offset: 0x00125873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RouletteType RouletteType
		{
			get
			{
				return this.rouletteType_;
			}
			set
			{
				this.rouletteType_ = value;
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x0012767C File Offset: 0x0012587C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreSkillRoulette> SkillRoulettes
		{
			get
			{
				return this.skillRoulettes_;
			}
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x00127684 File Offset: 0x00125884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRouletteSetResponse);
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x00127694 File Offset: 0x00125894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRouletteSetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.SkillRoulette, other.SkillRoulette) && this.RouletteType == other.RouletteType && this.skillRoulettes_.Equals(other.skillRoulettes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x00127708 File Offset: 0x00125908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.skillRoulette_ != null)
			{
				num ^= this.SkillRoulette.GetHashCode();
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num ^= this.RouletteType.GetHashCode();
			}
			num ^= this.skillRoulettes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x00127790 File Offset: 0x00125990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x0012779D File Offset: 0x0012599D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x001277A8 File Offset: 0x001259A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.skillRoulette_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SkillRoulette);
			}
			this.skillRoulettes_.WriteTo(ref output, ExploreSkillRouletteSetResponse._repeated_skillRoulettes_codec);
			if (this.RouletteType != RouletteType.Explore)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.RouletteType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00127830 File Offset: 0x00125A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.skillRoulette_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillRoulette);
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RouletteType);
			}
			num += this.skillRoulettes_.CalculateSize(ExploreSkillRouletteSetResponse._repeated_skillRoulettes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x001278B4 File Offset: 0x00125AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillRouletteSetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.skillRoulette_ != null)
			{
				if (this.skillRoulette_ == null)
				{
					this.SkillRoulette = new ExploreSkillRoulette();
				}
				this.SkillRoulette.MergeFrom(other.SkillRoulette);
			}
			if (other.RouletteType != RouletteType.Explore)
			{
				this.RouletteType = other.RouletteType;
			}
			this.skillRoulettes_.Add(other.skillRoulettes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x00127941 File Offset: 0x00125B41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x0012794C File Offset: 0x00125B4C
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
						this.ErrCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 26U)
					{
						if (this.skillRoulette_ == null)
						{
							this.SkillRoulette = new ExploreSkillRoulette();
						}
						input.ReadMessage(this.SkillRoulette);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.skillRoulettes_.AddEntriesFrom(ref input, ExploreSkillRouletteSetResponse._repeated_skillRoulettes_codec);
						continue;
					}
					if (num == 120U)
					{
						this.RouletteType = (RouletteType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003EA9 RID: 16041
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EAA RID: 16042
		public const int ErrCodeFieldNumber = 1;

		// Token: 0x04003EAB RID: 16043
		private ErrorCode errCode_;

		// Token: 0x04003EAC RID: 16044
		public const int SkillRouletteFieldNumber = 3;

		// Token: 0x04003EAD RID: 16045
		private ExploreSkillRoulette skillRoulette_;

		// Token: 0x04003EAE RID: 16046
		public const int RouletteTypeFieldNumber = 15;

		// Token: 0x04003EAF RID: 16047
		private RouletteType rouletteType_;

		// Token: 0x04003EB0 RID: 16048
		public const int SkillRoulettesFieldNumber = 6;

		// Token: 0x04003EB1 RID: 16049
		private static readonly FieldCodec<ExploreSkillRoulette> _repeated_skillRoulettes_codec = FieldCodec.ForMessage<ExploreSkillRoulette>(50U, ExploreSkillRoulette.Parser);

		// Token: 0x04003EB2 RID: 16050
		private readonly RepeatedField<ExploreSkillRoulette> skillRoulettes_ = new RepeatedField<ExploreSkillRoulette>();
	}
}
