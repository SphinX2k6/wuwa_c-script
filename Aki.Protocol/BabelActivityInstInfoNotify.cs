using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000145 RID: 325
	[NetMessage(EMessageId.BabelActivityInstInfoNotify)]
	public sealed class BabelActivityInstInfoNotify : IMessage<BabelActivityInstInfoNotify>, IMessage, IEquatable<BabelActivityInstInfoNotify>, IDeepCloneable<BabelActivityInstInfoNotify>, IBufferMessage
	{
		// Token: 0x06002A1A RID: 10778 RVA: 0x0006E6CA File Offset: 0x0006C8CA
		[NullableContext(1)]
		public static BabelActivityInstInfoNotify Create()
		{
			return new BabelActivityInstInfoNotify();
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x0006E6D1 File Offset: 0x0006C8D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x0006E6D4 File Offset: 0x0006C8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityInstInfoNotify.Descriptor;
			}
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x0006E6DB File Offset: 0x0006C8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInstInfoNotify()
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x0006E6FC File Offset: 0x0006C8FC
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

		// Token: 0x06002A1F RID: 10783 RVA: 0x0006E772 File Offset: 0x0006C972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityInstInfoNotify Clone()
		{
			return new BabelActivityInstInfoNotify(this);
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x0006E77A File Offset: 0x0006C97A
		// (set) Token: 0x06002A21 RID: 10785 RVA: 0x0006E782 File Offset: 0x0006C982
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

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x0006E78B File Offset: 0x0006C98B
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x0006E793 File Offset: 0x0006C993
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

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x0006E79C File Offset: 0x0006C99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffSelection
		{
			get
			{
				return this.buffSelection_;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BabelDeTermId
		{
			get
			{
				return this.babelDeTermId_;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x0006E7AC File Offset: 0x0006C9AC
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
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

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x0006E7BD File Offset: 0x0006C9BD
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x0006E7C5 File Offset: 0x0006C9C5
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

		// Token: 0x06002A2A RID: 10794 RVA: 0x0006E7CE File Offset: 0x0006C9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityInstInfoNotify);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0006E7DC File Offset: 0x0006C9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityInstInfoNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.UseReviveCount == other.UseReviveCount && this.buffSelection_.Equals(other.buffSelection_) && this.babelDeTermId_.Equals(other.babelDeTermId_) && this.RoleCD == other.RoleCD && this.CurStar == other.CurStar && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0006E870 File Offset: 0x0006CA70
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

		// Token: 0x06002A2D RID: 10797 RVA: 0x0006E916 File Offset: 0x0006CB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x0006E923 File Offset: 0x0006CB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x0006E92C File Offset: 0x0006CB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleCD != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleCD);
			}
			if (this.UseReviveCount != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.UseReviveCount);
			}
			if (this.CurStar != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.CurStar);
			}
			this.buffSelection_.WriteTo(ref output, BabelActivityInstInfoNotify._repeated_buffSelection_codec);
			if (this.LevelId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.LevelId);
			}
			this.babelDeTermId_.WriteTo(ref output, BabelActivityInstInfoNotify._repeated_babelDeTermId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0006E9E0 File Offset: 0x0006CBE0
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

		// Token: 0x06002A31 RID: 10801 RVA: 0x0006EA8C File Offset: 0x0006CC8C
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

		// Token: 0x06002A32 RID: 10802 RVA: 0x0006EB26 File Offset: 0x0006CD26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0006EB30 File Offset: 0x0006CD30
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
				if (num <= 80U)
				{
					if (num <= 48U)
					{
						if (num == 32U)
						{
							this.RoleCD = input.ReadInt32();
							continue;
						}
						if (num == 48U)
						{
							this.UseReviveCount = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 56U)
						{
							this.CurStar = input.ReadInt32();
							continue;
						}
						if (num == 80U)
						{
							goto IL_87;
						}
					}
				}
				else if (num <= 88U)
				{
					if (num == 82U)
					{
						goto IL_87;
					}
					if (num == 88U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.babelDeTermId_.AddEntriesFrom(ref input, BabelActivityInstInfoNotify._repeated_babelDeTermId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_87:
				this.buffSelection_.AddEntriesFrom(ref input, BabelActivityInstInfoNotify._repeated_buffSelection_codec);
			}
		}

		// Token: 0x0400277C RID: 10108
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400277D RID: 10109
		public const int LevelIdFieldNumber = 11;

		// Token: 0x0400277E RID: 10110
		private int levelId_;

		// Token: 0x0400277F RID: 10111
		public const int UseReviveCountFieldNumber = 6;

		// Token: 0x04002780 RID: 10112
		private int useReviveCount_;

		// Token: 0x04002781 RID: 10113
		public const int BuffSelectionFieldNumber = 10;

		// Token: 0x04002782 RID: 10114
		private static readonly FieldCodec<int> _repeated_buffSelection_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04002783 RID: 10115
		private readonly RepeatedField<int> buffSelection_ = new RepeatedField<int>();

		// Token: 0x04002784 RID: 10116
		public const int BabelDeTermIdFieldNumber = 15;

		// Token: 0x04002785 RID: 10117
		private static readonly FieldCodec<int> _repeated_babelDeTermId_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04002786 RID: 10118
		private readonly RepeatedField<int> babelDeTermId_ = new RepeatedField<int>();

		// Token: 0x04002787 RID: 10119
		public const int RoleCDFieldNumber = 4;

		// Token: 0x04002788 RID: 10120
		private int roleCD_;

		// Token: 0x04002789 RID: 10121
		public const int CurStarFieldNumber = 7;

		// Token: 0x0400278A RID: 10122
		private int curStar_;
	}
}
