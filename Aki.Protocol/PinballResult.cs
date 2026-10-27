using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D56 RID: 3414
	public sealed class PinballResult : IMessage<PinballResult>, IMessage, IEquatable<PinballResult>, IDeepCloneable<PinballResult>, IBufferMessage
	{
		// Token: 0x060126A1 RID: 75425 RVA: 0x002AFE57 File Offset: 0x002AE057
		[NullableContext(1)]
		public static PinballResult Create()
		{
			return new PinballResult();
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x060126A2 RID: 75426 RVA: 0x002AFE5E File Offset: 0x002AE05E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x060126A3 RID: 75427 RVA: 0x002AFE61 File Offset: 0x002AE061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballResult.Descriptor;
			}
		}

		// Token: 0x060126A4 RID: 75428 RVA: 0x002AFE68 File Offset: 0x002AE068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResult()
		{
		}

		// Token: 0x060126A5 RID: 75429 RVA: 0x002AFE88 File Offset: 0x002AE088
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

		// Token: 0x060126A6 RID: 75430 RVA: 0x002AFF0A File Offset: 0x002AE10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballResult Clone()
		{
			return new PinballResult(this);
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x060126A7 RID: 75431 RVA: 0x002AFF12 File Offset: 0x002AE112
		// (set) Token: 0x060126A8 RID: 75432 RVA: 0x002AFF1A File Offset: 0x002AE11A
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

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x060126A9 RID: 75433 RVA: 0x002AFF23 File Offset: 0x002AE123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PinballResultRolePb> RolePbs
		{
			get
			{
				return this.rolePbs_;
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x060126AA RID: 75434 RVA: 0x002AFF2B File Offset: 0x002AE12B
		// (set) Token: 0x060126AB RID: 75435 RVA: 0x002AFF33 File Offset: 0x002AE133
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

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x060126AC RID: 75436 RVA: 0x002AFF3C File Offset: 0x002AE13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> StarInfo
		{
			get
			{
				return this.starInfo_;
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x060126AD RID: 75437 RVA: 0x002AFF44 File Offset: 0x002AE144
		// (set) Token: 0x060126AE RID: 75438 RVA: 0x002AFF4C File Offset: 0x002AE14C
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

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x060126AF RID: 75439 RVA: 0x002AFF55 File Offset: 0x002AE155
		// (set) Token: 0x060126B0 RID: 75440 RVA: 0x002AFF5D File Offset: 0x002AE15D
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

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x060126B1 RID: 75441 RVA: 0x002AFF66 File Offset: 0x002AE166
		// (set) Token: 0x060126B2 RID: 75442 RVA: 0x002AFF6E File Offset: 0x002AE16E
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

		// Token: 0x060126B3 RID: 75443 RVA: 0x002AFF77 File Offset: 0x002AE177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballResult);
		}

		// Token: 0x060126B4 RID: 75444 RVA: 0x002AFF88 File Offset: 0x002AE188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballResult other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.rolePbs_.Equals(other.rolePbs_) && this.MvpRoleId == other.MvpRoleId && this.starInfo_.Equals(other.starInfo_) && this.Score == other.Score && this.CostTime == other.CostTime && this.FirstPass == other.FirstPass && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126B5 RID: 75445 RVA: 0x002B002C File Offset: 0x002AE22C
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

		// Token: 0x060126B6 RID: 75446 RVA: 0x002B00EB File Offset: 0x002AE2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126B7 RID: 75447 RVA: 0x002B00F8 File Offset: 0x002AE2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126B8 RID: 75448 RVA: 0x002B0104 File Offset: 0x002AE304
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

		// Token: 0x060126B9 RID: 75449 RVA: 0x002B01D4 File Offset: 0x002AE3D4
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

		// Token: 0x060126BA RID: 75450 RVA: 0x002B028C File Offset: 0x002AE48C
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

		// Token: 0x060126BB RID: 75451 RVA: 0x002B033A File Offset: 0x002AE53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126BC RID: 75452 RVA: 0x002B0344 File Offset: 0x002AE544
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

		// Token: 0x0400729E RID: 29342
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400729F RID: 29343
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040072A0 RID: 29344
		private int levelId_;

		// Token: 0x040072A1 RID: 29345
		public const int RolePbsFieldNumber = 2;

		// Token: 0x040072A2 RID: 29346
		private static readonly FieldCodec<PinballResultRolePb> _repeated_rolePbs_codec = FieldCodec.ForMessage<PinballResultRolePb>(18U, PinballResultRolePb.Parser);

		// Token: 0x040072A3 RID: 29347
		private readonly RepeatedField<PinballResultRolePb> rolePbs_ = new RepeatedField<PinballResultRolePb>();

		// Token: 0x040072A4 RID: 29348
		public const int MvpRoleIdFieldNumber = 3;

		// Token: 0x040072A5 RID: 29349
		private int mvpRoleId_;

		// Token: 0x040072A6 RID: 29350
		public const int StarInfoFieldNumber = 4;

		// Token: 0x040072A7 RID: 29351
		private static readonly FieldCodec<int> _repeated_starInfo_codec = FieldCodec.ForInt32(34U);

		// Token: 0x040072A8 RID: 29352
		private readonly RepeatedField<int> starInfo_ = new RepeatedField<int>();

		// Token: 0x040072A9 RID: 29353
		public const int ScoreFieldNumber = 5;

		// Token: 0x040072AA RID: 29354
		private int score_;

		// Token: 0x040072AB RID: 29355
		public const int CostTimeFieldNumber = 6;

		// Token: 0x040072AC RID: 29356
		private int costTime_;

		// Token: 0x040072AD RID: 29357
		public const int FirstPassFieldNumber = 7;

		// Token: 0x040072AE RID: 29358
		private bool firstPass_;
	}
}
