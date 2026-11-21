using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F5 RID: 1269
	[NetMessage(EMessageId.ExploreSkillRouletteSetResponse)]
	public sealed class ExploreSkillRouletteSetResponse : IMessage<ExploreSkillRouletteSetResponse>, IMessage, IEquatable<ExploreSkillRouletteSetResponse>, IDeepCloneable<ExploreSkillRouletteSetResponse>, IBufferMessage
	{
		// Token: 0x06007804 RID: 30724 RVA: 0x0012471E File Offset: 0x0012291E
		[NullableContext(1)]
		public static ExploreSkillRouletteSetResponse Create()
		{
			return new ExploreSkillRouletteSetResponse();
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06007805 RID: 30725 RVA: 0x00124725 File Offset: 0x00122925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06007806 RID: 30726 RVA: 0x00124728 File Offset: 0x00122928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRouletteSetResponse.Descriptor;
			}
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x0012472F File Offset: 0x0012292F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetResponse()
		{
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00124744 File Offset: 0x00122944
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

		// Token: 0x06007809 RID: 30729 RVA: 0x001247AD File Offset: 0x001229AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetResponse Clone()
		{
			return new ExploreSkillRouletteSetResponse(this);
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x001247B5 File Offset: 0x001229B5
		// (set) Token: 0x0600780B RID: 30731 RVA: 0x001247BD File Offset: 0x001229BD
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

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x001247C6 File Offset: 0x001229C6
		// (set) Token: 0x0600780D RID: 30733 RVA: 0x001247CE File Offset: 0x001229CE
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

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x001247D7 File Offset: 0x001229D7
		// (set) Token: 0x0600780F RID: 30735 RVA: 0x001247DF File Offset: 0x001229DF
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

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06007810 RID: 30736 RVA: 0x001247E8 File Offset: 0x001229E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreSkillRoulette> SkillRoulettes
		{
			get
			{
				return this.skillRoulettes_;
			}
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x001247F0 File Offset: 0x001229F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRouletteSetResponse);
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x00124800 File Offset: 0x00122A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRouletteSetResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.SkillRoulette, other.SkillRoulette) && this.RouletteType == other.RouletteType && this.skillRoulettes_.Equals(other.skillRoulettes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x00124874 File Offset: 0x00122A74
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

		// Token: 0x06007814 RID: 30740 RVA: 0x001248FC File Offset: 0x00122AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x00124909 File Offset: 0x00122B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00124914 File Offset: 0x00122B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RouletteType != RouletteType.Explore)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.RouletteType);
			}
			if (this.skillRoulette_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SkillRoulette);
			}
			this.skillRoulettes_.WriteTo(ref output, ExploreSkillRouletteSetResponse._repeated_skillRoulettes_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x0012499C File Offset: 0x00122B9C
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

		// Token: 0x06007818 RID: 30744 RVA: 0x00124A20 File Offset: 0x00122C20
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

		// Token: 0x06007819 RID: 30745 RVA: 0x00124AAD File Offset: 0x00122CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00124AB8 File Offset: 0x00122CB8
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
				if (num <= 90U)
				{
					if (num == 8U)
					{
						this.RouletteType = (RouletteType)input.ReadEnum();
						continue;
					}
					if (num == 90U)
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
					if (num == 98U)
					{
						this.skillRoulettes_.AddEntriesFrom(ref input, ExploreSkillRouletteSetResponse._repeated_skillRoulettes_codec);
						continue;
					}
					if (num == 112U)
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003E9A RID: 16026
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E9B RID: 16027
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04003E9C RID: 16028
		private ErrorCode errCode_;

		// Token: 0x04003E9D RID: 16029
		public const int SkillRouletteFieldNumber = 11;

		// Token: 0x04003E9E RID: 16030
		private ExploreSkillRoulette skillRoulette_;

		// Token: 0x04003E9F RID: 16031
		public const int RouletteTypeFieldNumber = 1;

		// Token: 0x04003EA0 RID: 16032
		private RouletteType rouletteType_;

		// Token: 0x04003EA1 RID: 16033
		public const int SkillRoulettesFieldNumber = 12;

		// Token: 0x04003EA2 RID: 16034
		private static readonly FieldCodec<ExploreSkillRoulette> _repeated_skillRoulettes_codec = FieldCodec.ForMessage<ExploreSkillRoulette>(98U, ExploreSkillRoulette.Parser);

		// Token: 0x04003EA3 RID: 16035
		private readonly RepeatedField<ExploreSkillRoulette> skillRoulettes_ = new RepeatedField<ExploreSkillRoulette>();
	}
}
