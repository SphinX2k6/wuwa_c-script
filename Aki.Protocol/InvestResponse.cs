using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200082B RID: 2091
	[NetMessage(EMessageId.InvestResponse)]
	public sealed class InvestResponse : IMessage<InvestResponse>, IMessage, IEquatable<InvestResponse>, IDeepCloneable<InvestResponse>, IBufferMessage
	{
		// Token: 0x0600BB24 RID: 47908 RVA: 0x001BDDFC File Offset: 0x001BBFFC
		[NullableContext(1)]
		public static InvestResponse Create()
		{
			return new InvestResponse();
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x0600BB25 RID: 47909 RVA: 0x001BDE03 File Offset: 0x001BC003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x0600BB26 RID: 47910 RVA: 0x001BDE06 File Offset: 0x001BC006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InvestResponse.Descriptor;
			}
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x001BDE0D File Offset: 0x001BC00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestResponse()
		{
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x001BDE20 File Offset: 0x001BC020
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

		// Token: 0x0600BB29 RID: 47913 RVA: 0x001BDE9D File Offset: 0x001BC09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InvestResponse Clone()
		{
			return new InvestResponse(this);
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x0600BB2A RID: 47914 RVA: 0x001BDEA5 File Offset: 0x001BC0A5
		// (set) Token: 0x0600BB2B RID: 47915 RVA: 0x001BDEAD File Offset: 0x001BC0AD
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

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x0600BB2C RID: 47916 RVA: 0x001BDEB6 File Offset: 0x001BC0B6
		// (set) Token: 0x0600BB2D RID: 47917 RVA: 0x001BDEBE File Offset: 0x001BC0BE
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

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x0600BB2E RID: 47918 RVA: 0x001BDEC7 File Offset: 0x001BC0C7
		// (set) Token: 0x0600BB2F RID: 47919 RVA: 0x001BDECF File Offset: 0x001BC0CF
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

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x001BDED8 File Offset: 0x001BC0D8
		// (set) Token: 0x0600BB31 RID: 47921 RVA: 0x001BDEE0 File Offset: 0x001BC0E0
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

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x001BDEE9 File Offset: 0x001BC0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleProperSettle> RoleProperSettle
		{
			get
			{
				return this.roleProperSettle_;
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x0600BB33 RID: 47923 RVA: 0x001BDEF1 File Offset: 0x001BC0F1
		// (set) Token: 0x0600BB34 RID: 47924 RVA: 0x001BDEF9 File Offset: 0x001BC0F9
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

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x0600BB35 RID: 47925 RVA: 0x001BDF02 File Offset: 0x001BC102
		// (set) Token: 0x0600BB36 RID: 47926 RVA: 0x001BDF0A File Offset: 0x001BC10A
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

		// Token: 0x0600BB37 RID: 47927 RVA: 0x001BDF13 File Offset: 0x001BC113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InvestResponse);
		}

		// Token: 0x0600BB38 RID: 47928 RVA: 0x001BDF24 File Offset: 0x001BC124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InvestResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Gold == other.Gold && this.Success == other.Success && this.EvaluationLevel == other.EvaluationLevel && this.roleProperSettle_.Equals(other.roleProperSettle_) && this.Heat == other.Heat && this.BaseGold == other.BaseGold && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB39 RID: 47929 RVA: 0x001BDFC4 File Offset: 0x001BC1C4
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

		// Token: 0x0600BB3A RID: 47930 RVA: 0x001BE094 File Offset: 0x001BC294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BB3B RID: 47931 RVA: 0x001BE0A1 File Offset: 0x001BC2A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB3C RID: 47932 RVA: 0x001BE0AC File Offset: 0x001BC2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Heat != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Heat);
			}
			this.roleProperSettle_.WriteTo(ref output, InvestResponse._repeated_roleProperSettle_codec);
			if (this.EvaluationLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EvaluationLevel);
			}
			if (this.BaseGold != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.BaseGold);
			}
			if (this.Gold != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Gold);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Success)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.Success);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB3D RID: 47933 RVA: 0x001BE188 File Offset: 0x001BC388
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

		// Token: 0x0600BB3E RID: 47934 RVA: 0x001BE248 File Offset: 0x001BC448
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

		// Token: 0x0600BB3F RID: 47935 RVA: 0x001BE2F9 File Offset: 0x001BC4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x001BE304 File Offset: 0x001BC504
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
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.Heat = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.roleProperSettle_.AddEntriesFrom(ref input, InvestResponse._repeated_roleProperSettle_codec);
						continue;
					}
					if (num == 64U)
					{
						this.EvaluationLevel = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U)
					{
						this.BaseGold = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Gold = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.Success = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400527F RID: 21119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005280 RID: 21120
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005281 RID: 21121
		private ErrorCode errorCode_;

		// Token: 0x04005282 RID: 21122
		public const int GoldFieldNumber = 10;

		// Token: 0x04005283 RID: 21123
		private int gold_;

		// Token: 0x04005284 RID: 21124
		public const int SuccessFieldNumber = 14;

		// Token: 0x04005285 RID: 21125
		private bool success_;

		// Token: 0x04005286 RID: 21126
		public const int EvaluationLevelFieldNumber = 8;

		// Token: 0x04005287 RID: 21127
		private int evaluationLevel_;

		// Token: 0x04005288 RID: 21128
		public const int RoleProperSettleFieldNumber = 2;

		// Token: 0x04005289 RID: 21129
		private static readonly FieldCodec<RoleProperSettle> _repeated_roleProperSettle_codec = FieldCodec.ForMessage<RoleProperSettle>(18U, Aki.Protocol.RoleProperSettle.Parser);

		// Token: 0x0400528A RID: 21130
		private readonly RepeatedField<RoleProperSettle> roleProperSettle_ = new RepeatedField<RoleProperSettle>();

		// Token: 0x0400528B RID: 21131
		public const int HeatFieldNumber = 1;

		// Token: 0x0400528C RID: 21132
		private int heat_;

		// Token: 0x0400528D RID: 21133
		public const int BaseGoldFieldNumber = 9;

		// Token: 0x0400528E RID: 21134
		private int baseGold_;
	}
}
