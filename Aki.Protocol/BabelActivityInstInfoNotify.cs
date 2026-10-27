using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000142 RID: 322
	[NetMessage(EMessageId.BabelActivityInstInfoNotify)]
	public sealed class BabelActivityInstInfoNotify : IMessage<BabelActivityInstInfoNotify>, IMessage, IEquatable<BabelActivityInstInfoNotify>, IDeepCloneable<BabelActivityInstInfoNotify>, IBufferMessage
	{
		// Token: 0x060029A3 RID: 10659 RVA: 0x0006D296 File Offset: 0x0006B496
		[NullableContext(1)]
		public static BabelActivityInstInfoNotify Create()
		{
			return new BabelActivityInstInfoNotify();
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x0006D29D File Offset: 0x0006B49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x0006D2A0 File Offset: 0x0006B4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityInstInfoNotify.Descriptor;
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0006D2A7 File Offset: 0x0006B4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInstInfoNotify()
		{
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInstInfoNotify(BabelActivityInstInfoNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.useReviveCount_ = other.useReviveCount_;
			this.buffSelection_ = other.buffSelection_.Clone();
			this.babelDeTermId_ = other.babelDeTermId_.Clone();
			this.roleCD_ = other.roleCD_;
			this.curStar_ = other.curStar_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x0006D33E File Offset: 0x0006B53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInstInfoNotify Clone()
		{
			return new BabelActivityInstInfoNotify(this);
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060029A9 RID: 10665 RVA: 0x0006D346 File Offset: 0x0006B546
		// (set) Token: 0x060029AA RID: 10666 RVA: 0x0006D34E File Offset: 0x0006B54E
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

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x0006D357 File Offset: 0x0006B557
		// (set) Token: 0x060029AC RID: 10668 RVA: 0x0006D35F File Offset: 0x0006B55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseReviveCount
		{
			get
			{
				return this.useReviveCount_;
			}
			set
			{
				this.useReviveCount_ = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x0006D368 File Offset: 0x0006B568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffSelection
		{
			get
			{
				return this.buffSelection_;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x0006D370 File Offset: 0x0006B570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BabelDeTermId
		{
			get
			{
				return this.babelDeTermId_;
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x0006D378 File Offset: 0x0006B578
		// (set) Token: 0x060029B0 RID: 10672 RVA: 0x0006D380 File Offset: 0x0006B580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleCD
		{
			get
			{
				return this.roleCD_;
			}
			set
			{
				this.roleCD_ = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x0006D389 File Offset: 0x0006B589
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x0006D391 File Offset: 0x0006B591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStar
		{
			get
			{
				return this.curStar_;
			}
			set
			{
				this.curStar_ = value;
			}
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x0006D39A File Offset: 0x0006B59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityInstInfoNotify);
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x0006D3A8 File Offset: 0x0006B5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityInstInfoNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.UseReviveCount == other.UseReviveCount && this.buffSelection_.Equals(other.buffSelection_) && this.babelDeTermId_.Equals(other.babelDeTermId_) && this.RoleCD == other.RoleCD && this.CurStar == other.CurStar && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x0006D43C File Offset: 0x0006B63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.UseReviveCount != 0)
			{
				num ^= this.UseReviveCount.GetHashCode();
			}
			num ^= this.buffSelection_.GetHashCode();
			num ^= this.babelDeTermId_.GetHashCode();
			if (this.RoleCD != 0)
			{
				num ^= this.RoleCD.GetHashCode();
			}
			if (this.CurStar != 0)
			{
				num ^= this.CurStar.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x0006D4E2 File Offset: 0x0006B6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x0006D4EF File Offset: 0x0006B6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x0006D4F8 File Offset: 0x0006B6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.babelDeTermId_.WriteTo(ref output, BabelActivityInstInfoNotify._repeated_babelDeTermId_codec);
			this.buffSelection_.WriteTo(ref output, BabelActivityInstInfoNotify._repeated_buffSelection_codec);
			if (this.RoleCD != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleCD);
			}
			if (this.CurStar != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.CurStar);
			}
			if (this.LevelId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.LevelId);
			}
			if (this.UseReviveCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.UseReviveCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x0006D5AC File Offset: 0x0006B7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.UseReviveCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseReviveCount);
			}
			num += this.buffSelection_.CalculateSize(BabelActivityInstInfoNotify._repeated_buffSelection_codec);
			num += this.babelDeTermId_.CalculateSize(BabelActivityInstInfoNotify._repeated_babelDeTermId_codec);
			if (this.RoleCD != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleCD);
			}
			if (this.CurStar != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStar);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x0006D658 File Offset: 0x0006B858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityInstInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.UseReviveCount != 0)
			{
				this.UseReviveCount = other.UseReviveCount;
			}
			this.buffSelection_.Add(other.buffSelection_);
			this.babelDeTermId_.Add(other.babelDeTermId_);
			if (other.RoleCD != 0)
			{
				this.RoleCD = other.RoleCD;
			}
			if (other.CurStar != 0)
			{
				this.CurStar = other.CurStar;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x0006D6F2 File Offset: 0x0006B8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0006D6FC File Offset: 0x0006B8FC
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
				if (num <= 18U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.babelDeTermId_.AddEntriesFrom(ref input, BabelActivityInstInfoNotify._repeated_babelDeTermId_codec);
							continue;
						}
					}
					else if (num == 16U || num == 18U)
					{
						this.buffSelection_.AddEntriesFrom(ref input, BabelActivityInstInfoNotify._repeated_buffSelection_codec);
						continue;
					}
				}
				else if (num <= 88U)
				{
					if (num == 32U)
					{
						this.RoleCD = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.CurStar = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.UseReviveCount = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002708 RID: 9992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002709 RID: 9993
		public const int LevelIdFieldNumber = 12;

		// Token: 0x0400270A RID: 9994
		private int levelId_;

		// Token: 0x0400270B RID: 9995
		public const int UseReviveCountFieldNumber = 13;

		// Token: 0x0400270C RID: 9996
		private int useReviveCount_;

		// Token: 0x0400270D RID: 9997
		public const int BuffSelectionFieldNumber = 2;

		// Token: 0x0400270E RID: 9998
		private static readonly FieldCodec<int> _repeated_buffSelection_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400270F RID: 9999
		private readonly RepeatedField<int> buffSelection_ = new RepeatedField<int>();

		// Token: 0x04002710 RID: 10000
		public const int BabelDeTermIdFieldNumber = 1;

		// Token: 0x04002711 RID: 10001
		private static readonly FieldCodec<int> _repeated_babelDeTermId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04002712 RID: 10002
		private readonly RepeatedField<int> babelDeTermId_ = new RepeatedField<int>();

		// Token: 0x04002713 RID: 10003
		public const int RoleCDFieldNumber = 4;

		// Token: 0x04002714 RID: 10004
		private int roleCD_;

		// Token: 0x04002715 RID: 10005
		public const int CurStarFieldNumber = 11;

		// Token: 0x04002716 RID: 10006
		private int curStar_;
	}
}
