using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004D RID: 77
	[NetMessage(EMessageId.AcceptEntrustResponse)]
	public sealed class AcceptEntrustResponse : IMessage<AcceptEntrustResponse>, IMessage, IEquatable<AcceptEntrustResponse>, IDeepCloneable<AcceptEntrustResponse>, IBufferMessage
	{
		// Token: 0x0600148E RID: 5262 RVA: 0x00036ED4 File Offset: 0x000350D4
		[NullableContext(1)]
		public static AcceptEntrustResponse Create()
		{
			return new AcceptEntrustResponse();
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x00036EDB File Offset: 0x000350DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x00036EDE File Offset: 0x000350DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptEntrustResponse.Descriptor;
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00036EE5 File Offset: 0x000350E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustResponse()
		{
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00036F04 File Offset: 0x00035104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustResponse(AcceptEntrustResponse other) : this()
		{
			this.triggerIdea_ = other.triggerIdea_;
			this.evaluationLevel_ = other.evaluationLevel_;
			this.roleProperSettle_ = other.roleProperSettle_.Clone();
			this.roleGoods_ = other.roleGoods_.Clone();
			this.gold_ = other.gold_;
			this.wish_ = other.wish_;
			this.heat_ = other.heat_;
			this.triggerIdeaRole_ = other.triggerIdeaRole_;
			this.addEntrust_ = ((other.addEntrust_ != null) ? other.addEntrust_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00036FBA File Offset: 0x000351BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustResponse Clone()
		{
			return new AcceptEntrustResponse(this);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00036FC2 File Offset: 0x000351C2
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x00036FCA File Offset: 0x000351CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool TriggerIdea
		{
			get
			{
				return this.triggerIdea_;
			}
			set
			{
				this.triggerIdea_ = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x00036FD3 File Offset: 0x000351D3
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x00036FDB File Offset: 0x000351DB
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x00036FE4 File Offset: 0x000351E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleProperSettle> RoleProperSettle
		{
			get
			{
				return this.roleProperSettle_;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00036FEC File Offset: 0x000351EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleGood> RoleGoods
		{
			get
			{
				return this.roleGoods_;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x00036FF4 File Offset: 0x000351F4
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x00036FFC File Offset: 0x000351FC
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x00037005 File Offset: 0x00035205
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0003700D File Offset: 0x0003520D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Wish
		{
			get
			{
				return this.wish_;
			}
			set
			{
				this.wish_ = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x00037016 File Offset: 0x00035216
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0003701E File Offset: 0x0003521E
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x00037027 File Offset: 0x00035227
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x0003702F File Offset: 0x0003522F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TriggerIdeaRole
		{
			get
			{
				return this.triggerIdeaRole_;
			}
			set
			{
				this.triggerIdeaRole_ = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x00037038 File Offset: 0x00035238
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x00037040 File Offset: 0x00035240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntrustInfo AddEntrust
		{
			get
			{
				return this.addEntrust_;
			}
			set
			{
				this.addEntrust_ = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00037049 File Offset: 0x00035249
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x00037051 File Offset: 0x00035251
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

		// Token: 0x060014A6 RID: 5286 RVA: 0x0003705A File Offset: 0x0003525A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptEntrustResponse);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00037068 File Offset: 0x00035268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptEntrustResponse other)
		{
			return other != null && (other == this || (this.TriggerIdea == other.TriggerIdea && this.EvaluationLevel == other.EvaluationLevel && this.roleProperSettle_.Equals(other.roleProperSettle_) && this.roleGoods_.Equals(other.roleGoods_) && this.Gold == other.Gold && this.Wish == other.Wish && this.Heat == other.Heat && this.TriggerIdeaRole == other.TriggerIdeaRole && object.Equals(this.AddEntrust, other.AddEntrust) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00037140 File Offset: 0x00035340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TriggerIdea)
			{
				num ^= this.TriggerIdea.GetHashCode();
			}
			if (this.EvaluationLevel != 0)
			{
				num ^= this.EvaluationLevel.GetHashCode();
			}
			num ^= this.roleProperSettle_.GetHashCode();
			num ^= this.roleGoods_.GetHashCode();
			if (this.Gold != 0)
			{
				num ^= this.Gold.GetHashCode();
			}
			if (this.Wish != 0)
			{
				num ^= this.Wish.GetHashCode();
			}
			if (this.Heat != 0)
			{
				num ^= this.Heat.GetHashCode();
			}
			if (this.TriggerIdeaRole != 0)
			{
				num ^= this.TriggerIdeaRole.GetHashCode();
			}
			if (this.addEntrust_ != null)
			{
				num ^= this.AddEntrust.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0003724D File Offset: 0x0003544D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0003725A File Offset: 0x0003545A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00037264 File Offset: 0x00035464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Gold != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Gold);
			}
			this.roleGoods_.WriteTo(ref output, AcceptEntrustResponse._repeated_roleGoods_codec);
			if (this.TriggerIdea)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.TriggerIdea);
			}
			if (this.EvaluationLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EvaluationLevel);
			}
			if (this.addEntrust_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.AddEntrust);
			}
			if (this.Wish != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Wish);
			}
			if (this.TriggerIdeaRole != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TriggerIdeaRole);
			}
			this.roleProperSettle_.WriteTo(ref output, AcceptEntrustResponse._repeated_roleProperSettle_codec);
			if (this.Heat != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Heat);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00037388 File Offset: 0x00035588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TriggerIdea)
			{
				num += 2;
			}
			if (this.EvaluationLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EvaluationLevel);
			}
			num += this.roleProperSettle_.CalculateSize(AcceptEntrustResponse._repeated_roleProperSettle_codec);
			num += this.roleGoods_.CalculateSize(AcceptEntrustResponse._repeated_roleGoods_codec);
			if (this.Gold != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Gold);
			}
			if (this.Wish != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Wish);
			}
			if (this.Heat != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Heat);
			}
			if (this.TriggerIdeaRole != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerIdeaRole);
			}
			if (this.addEntrust_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AddEntrust);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00037488 File Offset: 0x00035688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptEntrustResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TriggerIdea)
			{
				this.TriggerIdea = other.TriggerIdea;
			}
			if (other.EvaluationLevel != 0)
			{
				this.EvaluationLevel = other.EvaluationLevel;
			}
			this.roleProperSettle_.Add(other.roleProperSettle_);
			this.roleGoods_.Add(other.roleGoods_);
			if (other.Gold != 0)
			{
				this.Gold = other.Gold;
			}
			if (other.Wish != 0)
			{
				this.Wish = other.Wish;
			}
			if (other.Heat != 0)
			{
				this.Heat = other.Heat;
			}
			if (other.TriggerIdeaRole != 0)
			{
				this.TriggerIdeaRole = other.TriggerIdeaRole;
			}
			if (other.addEntrust_ != null)
			{
				if (this.addEntrust_ == null)
				{
					this.AddEntrust = new EntrustInfo();
				}
				this.AddEntrust.MergeFrom(other.AddEntrust);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0003758A File Offset: 0x0003578A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00037594 File Offset: 0x00035794
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
					if (num <= 32U)
					{
						if (num == 16U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
						if (num == 32U)
						{
							this.Gold = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 42U)
						{
							this.roleGoods_.AddEntriesFrom(ref input, AcceptEntrustResponse._repeated_roleGoods_codec);
							continue;
						}
						if (num == 56U)
						{
							this.TriggerIdea = input.ReadBool();
							continue;
						}
						if (num == 64U)
						{
							this.EvaluationLevel = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 74U)
					{
						if (this.addEntrust_ == null)
						{
							this.AddEntrust = new EntrustInfo();
						}
						input.ReadMessage(this.AddEntrust);
						continue;
					}
					if (num == 80U)
					{
						this.Wish = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.TriggerIdeaRole = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.roleProperSettle_.AddEntriesFrom(ref input, AcceptEntrustResponse._repeated_roleProperSettle_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Heat = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400205C RID: 8284
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400205D RID: 8285
		public const int TriggerIdeaFieldNumber = 7;

		// Token: 0x0400205E RID: 8286
		private bool triggerIdea_;

		// Token: 0x0400205F RID: 8287
		public const int EvaluationLevelFieldNumber = 8;

		// Token: 0x04002060 RID: 8288
		private int evaluationLevel_;

		// Token: 0x04002061 RID: 8289
		public const int RoleProperSettleFieldNumber = 14;

		// Token: 0x04002062 RID: 8290
		private static readonly FieldCodec<RoleProperSettle> _repeated_roleProperSettle_codec = FieldCodec.ForMessage<RoleProperSettle>(114U, Aki.Protocol.RoleProperSettle.Parser);

		// Token: 0x04002063 RID: 8291
		private readonly RepeatedField<RoleProperSettle> roleProperSettle_ = new RepeatedField<RoleProperSettle>();

		// Token: 0x04002064 RID: 8292
		public const int RoleGoodsFieldNumber = 5;

		// Token: 0x04002065 RID: 8293
		private static readonly FieldCodec<RoleGood> _repeated_roleGoods_codec = FieldCodec.ForMessage<RoleGood>(42U, RoleGood.Parser);

		// Token: 0x04002066 RID: 8294
		private readonly RepeatedField<RoleGood> roleGoods_ = new RepeatedField<RoleGood>();

		// Token: 0x04002067 RID: 8295
		public const int GoldFieldNumber = 4;

		// Token: 0x04002068 RID: 8296
		private int gold_;

		// Token: 0x04002069 RID: 8297
		public const int WishFieldNumber = 10;

		// Token: 0x0400206A RID: 8298
		private int wish_;

		// Token: 0x0400206B RID: 8299
		public const int HeatFieldNumber = 15;

		// Token: 0x0400206C RID: 8300
		private int heat_;

		// Token: 0x0400206D RID: 8301
		public const int TriggerIdeaRoleFieldNumber = 13;

		// Token: 0x0400206E RID: 8302
		private int triggerIdeaRole_;

		// Token: 0x0400206F RID: 8303
		public const int AddEntrustFieldNumber = 9;

		// Token: 0x04002070 RID: 8304
		private EntrustInfo addEntrust_;

		// Token: 0x04002071 RID: 8305
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04002072 RID: 8306
		private ErrorCode errorCode_;
	}
}
