using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200083F RID: 2111
	[NetMessage(EMessageId.InvestResponse)]
	public sealed class InvestResponse : IMessage<InvestResponse>, IMessage, IEquatable<InvestResponse>, IDeepCloneable<InvestResponse>, IBufferMessage
	{
		// Token: 0x0600BC7A RID: 48250 RVA: 0x001C0834 File Offset: 0x001BEA34
		[NullableContext(1)]
		public static InvestResponse Create()
		{
			return new InvestResponse();
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x0600BC7B RID: 48251 RVA: 0x001C083B File Offset: 0x001BEA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x0600BC7C RID: 48252 RVA: 0x001C083E File Offset: 0x001BEA3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvestResponse.Descriptor;
			}
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x001C0845 File Offset: 0x001BEA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestResponse()
		{
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x001C0858 File Offset: 0x001BEA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestResponse(InvestResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gold_ = other.gold_;
			this.success_ = other.success_;
			this.evaluationLevel_ = other.evaluationLevel_;
			this.roleProperSettle_ = other.roleProperSettle_.Clone();
			this.heat_ = other.heat_;
			this.baseGold_ = other.baseGold_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BC7F RID: 48255 RVA: 0x001C08D5 File Offset: 0x001BEAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestResponse Clone()
		{
			return new InvestResponse(this);
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x0600BC80 RID: 48256 RVA: 0x001C08DD File Offset: 0x001BEADD
		// (set) Token: 0x0600BC81 RID: 48257 RVA: 0x001C08E5 File Offset: 0x001BEAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x0600BC82 RID: 48258 RVA: 0x001C08EE File Offset: 0x001BEAEE
		// (set) Token: 0x0600BC83 RID: 48259 RVA: 0x001C08F6 File Offset: 0x001BEAF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Gold
		{
			get
			{
				return this.gold_;
			}
			set
			{
				this.gold_ = value;
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x0600BC84 RID: 48260 RVA: 0x001C08FF File Offset: 0x001BEAFF
		// (set) Token: 0x0600BC85 RID: 48261 RVA: 0x001C0907 File Offset: 0x001BEB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x0600BC86 RID: 48262 RVA: 0x001C0910 File Offset: 0x001BEB10
		// (set) Token: 0x0600BC87 RID: 48263 RVA: 0x001C0918 File Offset: 0x001BEB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EvaluationLevel
		{
			get
			{
				return this.evaluationLevel_;
			}
			set
			{
				this.evaluationLevel_ = value;
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x0600BC88 RID: 48264 RVA: 0x001C0921 File Offset: 0x001BEB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleProperSettle> RoleProperSettle
		{
			get
			{
				return this.roleProperSettle_;
			}
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x0600BC89 RID: 48265 RVA: 0x001C0929 File Offset: 0x001BEB29
		// (set) Token: 0x0600BC8A RID: 48266 RVA: 0x001C0931 File Offset: 0x001BEB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Heat
		{
			get
			{
				return this.heat_;
			}
			set
			{
				this.heat_ = value;
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x0600BC8B RID: 48267 RVA: 0x001C093A File Offset: 0x001BEB3A
		// (set) Token: 0x0600BC8C RID: 48268 RVA: 0x001C0942 File Offset: 0x001BEB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BaseGold
		{
			get
			{
				return this.baseGold_;
			}
			set
			{
				this.baseGold_ = value;
			}
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x001C094B File Offset: 0x001BEB4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvestResponse);
		}

		// Token: 0x0600BC8E RID: 48270 RVA: 0x001C095C File Offset: 0x001BEB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvestResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Gold == other.Gold && this.Success == other.Success && this.EvaluationLevel == other.EvaluationLevel && this.roleProperSettle_.Equals(other.roleProperSettle_) && this.Heat == other.Heat && this.BaseGold == other.BaseGold && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BC8F RID: 48271 RVA: 0x001C09FC File Offset: 0x001BEBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Gold != 0)
			{
				num ^= this.Gold.GetHashCode();
			}
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this.EvaluationLevel != 0)
			{
				num ^= this.EvaluationLevel.GetHashCode();
			}
			num ^= this.roleProperSettle_.GetHashCode();
			if (this.Heat != 0)
			{
				num ^= this.Heat.GetHashCode();
			}
			if (this.BaseGold != 0)
			{
				num ^= this.BaseGold.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BC90 RID: 48272 RVA: 0x001C0ACC File Offset: 0x001BECCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BC91 RID: 48273 RVA: 0x001C0AD9 File Offset: 0x001BECD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BC92 RID: 48274 RVA: 0x001C0AE4 File Offset: 0x001BECE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleProperSettle_.WriteTo(ref output, InvestResponse._repeated_roleProperSettle_codec);
			if (this.Gold != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Gold);
			}
			if (this.EvaluationLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EvaluationLevel);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.BaseGold != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BaseGold);
			}
			if (this.Success)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Success);
			}
			if (this.Heat != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Heat);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BC93 RID: 48275 RVA: 0x001C0BC0 File Offset: 0x001BEDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Gold != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Gold);
			}
			if (this.Success)
			{
				num += 2;
			}
			if (this.EvaluationLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EvaluationLevel);
			}
			num += this.roleProperSettle_.CalculateSize(InvestResponse._repeated_roleProperSettle_codec);
			if (this.Heat != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Heat);
			}
			if (this.BaseGold != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BaseGold);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x001C0C80 File Offset: 0x001BEE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InvestResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Gold != 0)
			{
				this.Gold = other.Gold;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			if (other.EvaluationLevel != 0)
			{
				this.EvaluationLevel = other.EvaluationLevel;
			}
			this.roleProperSettle_.Add(other.roleProperSettle_);
			if (other.Heat != 0)
			{
				this.Heat = other.Heat;
			}
			if (other.BaseGold != 0)
			{
				this.BaseGold = other.BaseGold;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BC95 RID: 48277 RVA: 0x001C0D31 File Offset: 0x001BEF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BC96 RID: 48278 RVA: 0x001C0D3C File Offset: 0x001BEF3C
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						this.roleProperSettle_.AddEntriesFrom(ref input, InvestResponse._repeated_roleProperSettle_codec);
						continue;
					}
					if (num == 24U)
					{
						this.Gold = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.EvaluationLevel = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.BaseGold = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Success = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.Heat = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005286 RID: 21126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005287 RID: 21127
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04005288 RID: 21128
		private ErrorCode errorCode_;

		// Token: 0x04005289 RID: 21129
		public const int GoldFieldNumber = 3;

		// Token: 0x0400528A RID: 21130
		private int gold_;

		// Token: 0x0400528B RID: 21131
		public const int SuccessFieldNumber = 11;

		// Token: 0x0400528C RID: 21132
		private bool success_;

		// Token: 0x0400528D RID: 21133
		public const int EvaluationLevelFieldNumber = 4;

		// Token: 0x0400528E RID: 21134
		private int evaluationLevel_;

		// Token: 0x0400528F RID: 21135
		public const int RoleProperSettleFieldNumber = 1;

		// Token: 0x04005290 RID: 21136
		private static readonly FieldCodec<RoleProperSettle> _repeated_roleProperSettle_codec = FieldCodec.ForMessage<RoleProperSettle>(10U, Aki.Protocol.RoleProperSettle.Parser);

		// Token: 0x04005291 RID: 21137
		private readonly RepeatedField<RoleProperSettle> roleProperSettle_ = new RepeatedField<RoleProperSettle>();

		// Token: 0x04005292 RID: 21138
		public const int HeatFieldNumber = 12;

		// Token: 0x04005293 RID: 21139
		private int heat_;

		// Token: 0x04005294 RID: 21140
		public const int BaseGoldFieldNumber = 9;

		// Token: 0x04005295 RID: 21141
		private int baseGold_;
	}
}
