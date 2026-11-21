using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001CD RID: 461
	[NetMessage(EMessageId.BossPilingSettleNotify)]
	public sealed class BossPilingSettleNotify : IMessage<BossPilingSettleNotify>, IMessage, IEquatable<BossPilingSettleNotify>, IDeepCloneable<BossPilingSettleNotify>, IBufferMessage
	{
		// Token: 0x060034DC RID: 13532 RVA: 0x00085791 File Offset: 0x00083991
		[NullableContext(1)]
		public static BossPilingSettleNotify Create()
		{
			return new BossPilingSettleNotify();
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x00085798 File Offset: 0x00083998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x0008579B File Offset: 0x0008399B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossPilingSettleNotify.Descriptor;
			}
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000857A2 File Offset: 0x000839A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleNotify()
		{
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000857AC File Offset: 0x000839AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleNotify(BossPilingSettleNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.bossHpNum_ = other.bossHpNum_;
			this.isSuc_ = other.isSuc_;
			this.isUpdateBossHpNum_ = other.isUpdateBossHpNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x00085800 File Offset: 0x00083A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossPilingSettleNotify Clone()
		{
			return new BossPilingSettleNotify(this);
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x00085808 File Offset: 0x00083A08
		// (set) Token: 0x060034E3 RID: 13539 RVA: 0x00085810 File Offset: 0x00083A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeLevelId
		{
			get
			{
				return this.challengeLevelId_;
			}
			set
			{
				this.challengeLevelId_ = value;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x00085819 File Offset: 0x00083A19
		// (set) Token: 0x060034E5 RID: 13541 RVA: 0x00085821 File Offset: 0x00083A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BossHpNum
		{
			get
			{
				return this.bossHpNum_;
			}
			set
			{
				this.bossHpNum_ = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x0008582A File Offset: 0x00083A2A
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x00085832 File Offset: 0x00083A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuc
		{
			get
			{
				return this.isSuc_;
			}
			set
			{
				this.isSuc_ = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x0008583B File Offset: 0x00083A3B
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x00085843 File Offset: 0x00083A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUpdateBossHpNum
		{
			get
			{
				return this.isUpdateBossHpNum_;
			}
			set
			{
				this.isUpdateBossHpNum_ = value;
			}
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x0008584C File Offset: 0x00083A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossPilingSettleNotify);
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x0008585C File Offset: 0x00083A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossPilingSettleNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && this.BossHpNum == other.BossHpNum && this.IsSuc == other.IsSuc && this.IsUpdateBossHpNum == other.IsUpdateBossHpNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000858C8 File Offset: 0x00083AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.BossHpNum != 0)
			{
				num ^= this.BossHpNum.GetHashCode();
			}
			if (this.IsSuc)
			{
				num ^= this.IsSuc.GetHashCode();
			}
			if (this.IsUpdateBossHpNum)
			{
				num ^= this.IsUpdateBossHpNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00085952 File Offset: 0x00083B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x0008595F File Offset: 0x00083B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00085968 File Offset: 0x00083B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this.IsSuc)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSuc);
			}
			if (this.BossHpNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BossHpNum);
			}
			if (this.IsUpdateBossHpNum)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUpdateBossHpNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000859FC File Offset: 0x00083BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.BossHpNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BossHpNum);
			}
			if (this.IsSuc)
			{
				num += 2;
			}
			if (this.IsUpdateBossHpNum)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00085A6C File Offset: 0x00083C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossPilingSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.BossHpNum != 0)
			{
				this.BossHpNum = other.BossHpNum;
			}
			if (other.IsSuc)
			{
				this.IsSuc = other.IsSuc;
			}
			if (other.IsUpdateBossHpNum)
			{
				this.IsUpdateBossHpNum = other.IsUpdateBossHpNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00085AE4 File Offset: 0x00083CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00085AF0 File Offset: 0x00083CF0
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.ChallengeLevelId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.IsSuc = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.BossHpNum = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.IsUpdateBossHpNum = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002A79 RID: 10873
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A7A RID: 10874
		public const int ChallengeLevelIdFieldNumber = 2;

		// Token: 0x04002A7B RID: 10875
		private int challengeLevelId_;

		// Token: 0x04002A7C RID: 10876
		public const int BossHpNumFieldNumber = 6;

		// Token: 0x04002A7D RID: 10877
		private int bossHpNum_;

		// Token: 0x04002A7E RID: 10878
		public const int IsSucFieldNumber = 3;

		// Token: 0x04002A7F RID: 10879
		private bool isSuc_;

		// Token: 0x04002A80 RID: 10880
		public const int IsUpdateBossHpNumFieldNumber = 7;

		// Token: 0x04002A81 RID: 10881
		private bool isUpdateBossHpNum_;
	}
}
