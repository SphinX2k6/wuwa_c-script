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
		// Token: 0x060014B9 RID: 5305 RVA: 0x0003748C File Offset: 0x0003568C
		[NullableContext(1)]
		public static AcceptEntrustResponse Create()
		{
			return new AcceptEntrustResponse();
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x00037493 File Offset: 0x00035693
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
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00037496 File Offset: 0x00035696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptEntrustResponse.Descriptor;
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0003749D File Offset: 0x0003569D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustResponse()
		{
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000374BC File Offset: 0x000356BC
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

		// Token: 0x060014BE RID: 5310 RVA: 0x00037572 File Offset: 0x00035772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptEntrustResponse Clone()
		{
			return new AcceptEntrustResponse(this);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0003757A File Offset: 0x0003577A
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x00037582 File Offset: 0x00035782
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
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0003758B File Offset: 0x0003578B
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x00037593 File Offset: 0x00035793
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
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0003759C File Offset: 0x0003579C
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
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000375A4 File Offset: 0x000357A4
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
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x000375AC File Offset: 0x000357AC
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x000375B4 File Offset: 0x000357B4
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
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x000375BD File Offset: 0x000357BD
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x000375C5 File Offset: 0x000357C5
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
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000375CE File Offset: 0x000357CE
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x000375D6 File Offset: 0x000357D6
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
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x000375DF File Offset: 0x000357DF
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x000375E7 File Offset: 0x000357E7
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
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x000375F0 File Offset: 0x000357F0
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x000375F8 File Offset: 0x000357F8
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
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x00037601 File Offset: 0x00035801
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x00037609 File Offset: 0x00035809
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

		// Token: 0x060014D1 RID: 5329 RVA: 0x00037612 File Offset: 0x00035812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptEntrustResponse);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00037620 File Offset: 0x00035820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptEntrustResponse other)
		{
			return other != null && (other == this || (this.TriggerIdea == other.TriggerIdea && this.EvaluationLevel == other.EvaluationLevel && this.roleProperSettle_.Equals(other.roleProperSettle_) && this.roleGoods_.Equals(other.roleGoods_) && this.Gold == other.Gold && this.Wish == other.Wish && this.Heat == other.Heat && this.TriggerIdeaRole == other.TriggerIdeaRole && object.Equals(this.AddEntrust, other.AddEntrust) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000376F8 File Offset: 0x000358F8
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

		// Token: 0x060014D4 RID: 5332 RVA: 0x00037805 File Offset: 0x00035A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00037812 File Offset: 0x00035A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0003781C File Offset: 0x00035A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.addEntrust_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AddEntrust);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.roleProperSettle_.WriteTo(ref output, AcceptEntrustResponse._repeated_roleProperSettle_codec);
			if (this.TriggerIdeaRole != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TriggerIdeaRole);
			}
			if (this.Wish != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Wish);
			}
			if (this.Gold != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Gold);
			}
			if (this.Heat != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Heat);
			}
			if (this.TriggerIdea)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.TriggerIdea);
			}
			this.roleGoods_.WriteTo(ref output, AcceptEntrustResponse._repeated_roleGoods_codec);
			if (this.EvaluationLevel != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EvaluationLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00037940 File Offset: 0x00035B40
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

		// Token: 0x060014D8 RID: 5336 RVA: 0x00037A40 File Offset: 0x00035C40
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

		// Token: 0x060014D9 RID: 5337 RVA: 0x00037B42 File Offset: 0x00035D42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00037B4C File Offset: 0x00035D4C
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
				if (num <= 56U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							if (this.addEntrust_ == null)
							{
								this.AddEntrust = new EntrustInfo();
							}
							input.ReadMessage(this.AddEntrust);
							continue;
						}
						if (num == 16U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.roleProperSettle_.AddEntriesFrom(ref input, AcceptEntrustResponse._repeated_roleProperSettle_codec);
							continue;
						}
						if (num == 40U)
						{
							this.TriggerIdeaRole = input.ReadInt32();
							continue;
						}
						if (num == 56U)
						{
							this.Wish = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 64U)
					{
						this.Gold = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Heat = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.TriggerIdea = input.ReadBool();
						continue;
					}
					if (num == 114U)
					{
						this.roleGoods_.AddEntriesFrom(ref input, AcceptEntrustResponse._repeated_roleGoods_codec);
						continue;
					}
					if (num == 120U)
					{
						this.EvaluationLevel = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020B2 RID: 8370
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020B3 RID: 8371
		public const int TriggerIdeaFieldNumber = 13;

		// Token: 0x040020B4 RID: 8372
		private bool triggerIdea_;

		// Token: 0x040020B5 RID: 8373
		public const int EvaluationLevelFieldNumber = 15;

		// Token: 0x040020B6 RID: 8374
		private int evaluationLevel_;

		// Token: 0x040020B7 RID: 8375
		public const int RoleProperSettleFieldNumber = 4;

		// Token: 0x040020B8 RID: 8376
		private static readonly FieldCodec<RoleProperSettle> _repeated_roleProperSettle_codec = FieldCodec.ForMessage<RoleProperSettle>(34U, Aki.Protocol.RoleProperSettle.Parser);

		// Token: 0x040020B9 RID: 8377
		private readonly RepeatedField<RoleProperSettle> roleProperSettle_ = new RepeatedField<RoleProperSettle>();

		// Token: 0x040020BA RID: 8378
		public const int RoleGoodsFieldNumber = 14;

		// Token: 0x040020BB RID: 8379
		private static readonly FieldCodec<RoleGood> _repeated_roleGoods_codec = FieldCodec.ForMessage<RoleGood>(114U, RoleGood.Parser);

		// Token: 0x040020BC RID: 8380
		private readonly RepeatedField<RoleGood> roleGoods_ = new RepeatedField<RoleGood>();

		// Token: 0x040020BD RID: 8381
		public const int GoldFieldNumber = 8;

		// Token: 0x040020BE RID: 8382
		private int gold_;

		// Token: 0x040020BF RID: 8383
		public const int WishFieldNumber = 7;

		// Token: 0x040020C0 RID: 8384
		private int wish_;

		// Token: 0x040020C1 RID: 8385
		public const int HeatFieldNumber = 12;

		// Token: 0x040020C2 RID: 8386
		private int heat_;

		// Token: 0x040020C3 RID: 8387
		public const int TriggerIdeaRoleFieldNumber = 5;

		// Token: 0x040020C4 RID: 8388
		private int triggerIdeaRole_;

		// Token: 0x040020C5 RID: 8389
		public const int AddEntrustFieldNumber = 1;

		// Token: 0x040020C6 RID: 8390
		private EntrustInfo addEntrust_;

		// Token: 0x040020C7 RID: 8391
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040020C8 RID: 8392
		private ErrorCode errorCode_;
	}
}
