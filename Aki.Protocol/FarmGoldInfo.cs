using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000508 RID: 1288
	public sealed class FarmGoldInfo : IMessage<FarmGoldInfo>, IMessage, IEquatable<FarmGoldInfo>, IDeepCloneable<FarmGoldInfo>, IBufferMessage
	{
		// Token: 0x06007985 RID: 31109 RVA: 0x00127914 File Offset: 0x00125B14
		[NullableContext(1)]
		public static FarmGoldInfo Create()
		{
			return new FarmGoldInfo();
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06007986 RID: 31110 RVA: 0x0012791B File Offset: 0x00125B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06007987 RID: 31111 RVA: 0x0012791E File Offset: 0x00125B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldInfo.Descriptor;
			}
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x00127925 File Offset: 0x00125B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldInfo()
		{
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x00127943 File Offset: 0x00125B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldInfo(FarmGoldInfo other) : this()
		{
			this.pointsRewardGet_ = other.pointsRewardGet_.Clone();
			this.levelPlayTasks_ = other.levelPlayTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x0012797E File Offset: 0x00125B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldInfo Clone()
		{
			return new FarmGoldInfo(this);
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x00127986 File Offset: 0x00125B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PointsRewardGet
		{
			get
			{
				return this.pointsRewardGet_;
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x0012798E File Offset: 0x00125B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FarmGoldLevelPlayInfo> LevelPlayTasks
		{
			get
			{
				return this.levelPlayTasks_;
			}
		}

		// Token: 0x0600798D RID: 31117 RVA: 0x00127996 File Offset: 0x00125B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldInfo);
		}

		// Token: 0x0600798E RID: 31118 RVA: 0x001279A4 File Offset: 0x00125BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldInfo other)
		{
			return other != null && (other == this || (this.pointsRewardGet_.Equals(other.pointsRewardGet_) && this.levelPlayTasks_.Equals(other.levelPlayTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600798F RID: 31119 RVA: 0x001279F8 File Offset: 0x00125BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pointsRewardGet_.GetHashCode();
			num ^= this.levelPlayTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x00127A3A File Offset: 0x00125C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x00127A47 File Offset: 0x00125C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x00127A50 File Offset: 0x00125C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pointsRewardGet_.WriteTo(ref output, FarmGoldInfo._repeated_pointsRewardGet_codec);
			this.levelPlayTasks_.WriteTo(ref output, FarmGoldInfo._repeated_levelPlayTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00127A88 File Offset: 0x00125C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pointsRewardGet_.CalculateSize(FarmGoldInfo._repeated_pointsRewardGet_codec);
			num += this.levelPlayTasks_.CalculateSize(FarmGoldInfo._repeated_levelPlayTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007994 RID: 31124 RVA: 0x00127AD4 File Offset: 0x00125CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.pointsRewardGet_.Add(other.pointsRewardGet_);
			this.levelPlayTasks_.Add(other.levelPlayTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007995 RID: 31125 RVA: 0x00127B13 File Offset: 0x00125D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x00127B1C File Offset: 0x00125D1C
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
				if (num != 8U && num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.levelPlayTasks_.AddEntriesFrom(ref input, FarmGoldInfo._repeated_levelPlayTasks_codec);
					}
				}
				else
				{
					this.pointsRewardGet_.AddEntriesFrom(ref input, FarmGoldInfo._repeated_pointsRewardGet_codec);
				}
			}
		}

		// Token: 0x04003EFC RID: 16124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EFD RID: 16125
		public const int PointsRewardGetFieldNumber = 1;

		// Token: 0x04003EFE RID: 16126
		private static readonly FieldCodec<int> _repeated_pointsRewardGet_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04003EFF RID: 16127
		private readonly RepeatedField<int> pointsRewardGet_ = new RepeatedField<int>();

		// Token: 0x04003F00 RID: 16128
		public const int LevelPlayTasksFieldNumber = 2;

		// Token: 0x04003F01 RID: 16129
		private static readonly FieldCodec<FarmGoldLevelPlayInfo> _repeated_levelPlayTasks_codec = FieldCodec.ForMessage<FarmGoldLevelPlayInfo>(18U, FarmGoldLevelPlayInfo.Parser);

		// Token: 0x04003F02 RID: 16130
		private readonly RepeatedField<FarmGoldLevelPlayInfo> levelPlayTasks_ = new RepeatedField<FarmGoldLevelPlayInfo>();
	}
}
