using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D46 RID: 3398
	public sealed class PinballResult : IMessage<PinballResult>, IMessage, IEquatable<PinballResult>, IDeepCloneable<PinballResult>, IBufferMessage
	{
		// Token: 0x060125A5 RID: 75173 RVA: 0x002AE237 File Offset: 0x002AC437
		[NullableContext(1)]
		public static PinballResult Create()
		{
			return new PinballResult();
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x060125A6 RID: 75174 RVA: 0x002AE23E File Offset: 0x002AC43E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x060125A7 RID: 75175 RVA: 0x002AE241 File Offset: 0x002AC441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballResult.Descriptor;
			}
		}

		// Token: 0x060125A8 RID: 75176 RVA: 0x002AE248 File Offset: 0x002AC448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResult()
		{
		}

		// Token: 0x060125A9 RID: 75177 RVA: 0x002AE268 File Offset: 0x002AC468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResult(PinballResult other) : this()
		{
			this.levelId_ = other.levelId_;
			this.rolePbs_ = other.rolePbs_.Clone();
			this.mvpRoleId_ = other.mvpRoleId_;
			this.starInfo_ = other.starInfo_.Clone();
			this.score_ = other.score_;
			this.costTime_ = other.costTime_;
			this.firstPass_ = other.firstPass_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060125AA RID: 75178 RVA: 0x002AE2EA File Offset: 0x002AC4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResult Clone()
		{
			return new PinballResult(this);
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x060125AB RID: 75179 RVA: 0x002AE2F2 File Offset: 0x002AC4F2
		// (set) Token: 0x060125AC RID: 75180 RVA: 0x002AE2FA File Offset: 0x002AC4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x060125AD RID: 75181 RVA: 0x002AE303 File Offset: 0x002AC503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballResultRolePb> RolePbs
		{
			get
			{
				return this.rolePbs_;
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x060125AE RID: 75182 RVA: 0x002AE30B File Offset: 0x002AC50B
		// (set) Token: 0x060125AF RID: 75183 RVA: 0x002AE313 File Offset: 0x002AC513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MvpRoleId
		{
			get
			{
				return this.mvpRoleId_;
			}
			set
			{
				this.mvpRoleId_ = value;
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x060125B0 RID: 75184 RVA: 0x002AE31C File Offset: 0x002AC51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarInfo
		{
			get
			{
				return this.starInfo_;
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x060125B1 RID: 75185 RVA: 0x002AE324 File Offset: 0x002AC524
		// (set) Token: 0x060125B2 RID: 75186 RVA: 0x002AE32C File Offset: 0x002AC52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x060125B3 RID: 75187 RVA: 0x002AE335 File Offset: 0x002AC535
		// (set) Token: 0x060125B4 RID: 75188 RVA: 0x002AE33D File Offset: 0x002AC53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CostTime
		{
			get
			{
				return this.costTime_;
			}
			set
			{
				this.costTime_ = value;
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x060125B5 RID: 75189 RVA: 0x002AE346 File Offset: 0x002AC546
		// (set) Token: 0x060125B6 RID: 75190 RVA: 0x002AE34E File Offset: 0x002AC54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FirstPass
		{
			get
			{
				return this.firstPass_;
			}
			set
			{
				this.firstPass_ = value;
			}
		}

		// Token: 0x060125B7 RID: 75191 RVA: 0x002AE357 File Offset: 0x002AC557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballResult);
		}

		// Token: 0x060125B8 RID: 75192 RVA: 0x002AE368 File Offset: 0x002AC568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballResult other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.rolePbs_.Equals(other.rolePbs_) && this.MvpRoleId == other.MvpRoleId && this.starInfo_.Equals(other.starInfo_) && this.Score == other.Score && this.CostTime == other.CostTime && this.FirstPass == other.FirstPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060125B9 RID: 75193 RVA: 0x002AE40C File Offset: 0x002AC60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.rolePbs_.GetHashCode();
			if (this.MvpRoleId != 0)
			{
				num ^= this.MvpRoleId.GetHashCode();
			}
			num ^= this.starInfo_.GetHashCode();
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.CostTime != 0)
			{
				num ^= this.CostTime.GetHashCode();
			}
			if (this.FirstPass)
			{
				num ^= this.FirstPass.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060125BA RID: 75194 RVA: 0x002AE4CB File Offset: 0x002AC6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060125BB RID: 75195 RVA: 0x002AE4D8 File Offset: 0x002AC6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060125BC RID: 75196 RVA: 0x002AE4E4 File Offset: 0x002AC6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.rolePbs_.WriteTo(ref output, PinballResult._repeated_rolePbs_codec);
			if (this.MvpRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MvpRoleId);
			}
			this.starInfo_.WriteTo(ref output, PinballResult._repeated_starInfo_codec);
			if (this.Score != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Score);
			}
			if (this.CostTime != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CostTime);
			}
			if (this.FirstPass)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.FirstPass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060125BD RID: 75197 RVA: 0x002AE5B4 File Offset: 0x002AC7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.rolePbs_.CalculateSize(PinballResult._repeated_rolePbs_codec);
			if (this.MvpRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MvpRoleId);
			}
			num += this.starInfo_.CalculateSize(PinballResult._repeated_starInfo_codec);
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.CostTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CostTime);
			}
			if (this.FirstPass)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060125BE RID: 75198 RVA: 0x002AE66C File Offset: 0x002AC86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.rolePbs_.Add(other.rolePbs_);
			if (other.MvpRoleId != 0)
			{
				this.MvpRoleId = other.MvpRoleId;
			}
			this.starInfo_.Add(other.starInfo_);
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.CostTime != 0)
			{
				this.CostTime = other.CostTime;
			}
			if (other.FirstPass)
			{
				this.FirstPass = other.FirstPass;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060125BF RID: 75199 RVA: 0x002AE71A File Offset: 0x002AC91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060125C0 RID: 75200 RVA: 0x002AE724 File Offset: 0x002AC924
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
					if (num <= 18U)
					{
						if (num == 8U)
						{
							this.LevelId = input.ReadInt32();
							continue;
						}
						if (num == 18U)
						{
							this.rolePbs_.AddEntriesFrom(ref input, PinballResult._repeated_rolePbs_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.MvpRoleId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							goto IL_8B;
						}
					}
				}
				else if (num <= 40U)
				{
					if (num == 34U)
					{
						goto IL_8B;
					}
					if (num == 40U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CostTime = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.FirstPass = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_8B:
				this.starInfo_.AddEntriesFrom(ref input, PinballResult._repeated_starInfo_codec);
			}
		}

		// Token: 0x040072B6 RID: 29366
		private UnknownFieldSet _unknownFields;

		// Token: 0x040072B7 RID: 29367
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040072B8 RID: 29368
		private int levelId_;

		// Token: 0x040072B9 RID: 29369
		public const int RolePbsFieldNumber = 2;

		// Token: 0x040072BA RID: 29370
		private static readonly FieldCodec<PinballResultRolePb> _repeated_rolePbs_codec = FieldCodec.ForMessage<PinballResultRolePb>(18U, PinballResultRolePb.Parser);

		// Token: 0x040072BB RID: 29371
		private readonly RepeatedField<PinballResultRolePb> rolePbs_ = new RepeatedField<PinballResultRolePb>();

		// Token: 0x040072BC RID: 29372
		public const int MvpRoleIdFieldNumber = 3;

		// Token: 0x040072BD RID: 29373
		private int mvpRoleId_;

		// Token: 0x040072BE RID: 29374
		public const int StarInfoFieldNumber = 4;

		// Token: 0x040072BF RID: 29375
		private static readonly FieldCodec<int> _repeated_starInfo_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040072C0 RID: 29376
		private readonly RepeatedField<int> starInfo_ = new RepeatedField<int>();

		// Token: 0x040072C1 RID: 29377
		public const int ScoreFieldNumber = 5;

		// Token: 0x040072C2 RID: 29378
		private int score_;

		// Token: 0x040072C3 RID: 29379
		public const int CostTimeFieldNumber = 6;

		// Token: 0x040072C4 RID: 29380
		private int costTime_;

		// Token: 0x040072C5 RID: 29381
		public const int FirstPassFieldNumber = 7;

		// Token: 0x040072C6 RID: 29382
		private bool firstPass_;
	}
}
