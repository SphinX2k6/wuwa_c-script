using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AC RID: 1452
	public sealed class FloroRanchDayStart : IMessage<FloroRanchDayStart>, IMessage, IEquatable<FloroRanchDayStart>, IDeepCloneable<FloroRanchDayStart>, IBufferMessage
	{
		// Token: 0x06008631 RID: 34353 RVA: 0x00142743 File Offset: 0x00140943
		[NullableContext(1)]
		public static FloroRanchDayStart Create()
		{
			return new FloroRanchDayStart();
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06008632 RID: 34354 RVA: 0x0014274A File Offset: 0x0014094A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06008633 RID: 34355 RVA: 0x0014274D File Offset: 0x0014094D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchDayStart.Descriptor;
			}
		}

		// Token: 0x06008634 RID: 34356 RVA: 0x00142754 File Offset: 0x00140954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchDayStart()
		{
		}

		// Token: 0x06008635 RID: 34357 RVA: 0x00142774 File Offset: 0x00140974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchDayStart(FloroRanchDayStart other) : this()
		{
			this.onStageUnit_ = other.onStageUnit_.Clone();
			this.curDay_ = other.curDay_;
			this.curStage_ = other.curStage_;
			this.isUnlimited_ = other.isUnlimited_;
			this.removeUintIncId_ = other.removeUintIncId_.Clone();
			this.totalDay_ = other.totalDay_;
			this.remainDay_ = other.remainDay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008636 RID: 34358 RVA: 0x001427F6 File Offset: 0x001409F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchDayStart Clone()
		{
			return new FloroRanchDayStart(this);
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06008637 RID: 34359 RVA: 0x001427FE File Offset: 0x001409FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> OnStageUnit
		{
			get
			{
				return this.onStageUnit_;
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06008638 RID: 34360 RVA: 0x00142806 File Offset: 0x00140A06
		// (set) Token: 0x06008639 RID: 34361 RVA: 0x0014280E File Offset: 0x00140A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurDay
		{
			get
			{
				return this.curDay_;
			}
			set
			{
				this.curDay_ = value;
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x0600863A RID: 34362 RVA: 0x00142817 File Offset: 0x00140A17
		// (set) Token: 0x0600863B RID: 34363 RVA: 0x0014281F File Offset: 0x00140A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStage
		{
			get
			{
				return this.curStage_;
			}
			set
			{
				this.curStage_ = value;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x0600863C RID: 34364 RVA: 0x00142828 File Offset: 0x00140A28
		// (set) Token: 0x0600863D RID: 34365 RVA: 0x00142830 File Offset: 0x00140A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlimited
		{
			get
			{
				return this.isUnlimited_;
			}
			set
			{
				this.isUnlimited_ = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600863E RID: 34366 RVA: 0x00142839 File Offset: 0x00140A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveUintIncId
		{
			get
			{
				return this.removeUintIncId_;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x00142841 File Offset: 0x00140A41
		// (set) Token: 0x06008640 RID: 34368 RVA: 0x00142849 File Offset: 0x00140A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalDay
		{
			get
			{
				return this.totalDay_;
			}
			set
			{
				this.totalDay_ = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06008641 RID: 34369 RVA: 0x00142852 File Offset: 0x00140A52
		// (set) Token: 0x06008642 RID: 34370 RVA: 0x0014285A File Offset: 0x00140A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainDay
		{
			get
			{
				return this.remainDay_;
			}
			set
			{
				this.remainDay_ = value;
			}
		}

		// Token: 0x06008643 RID: 34371 RVA: 0x00142863 File Offset: 0x00140A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchDayStart);
		}

		// Token: 0x06008644 RID: 34372 RVA: 0x00142874 File Offset: 0x00140A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchDayStart other)
		{
			return other != null && (other == this || (this.onStageUnit_.Equals(other.onStageUnit_) && this.CurDay == other.CurDay && this.CurStage == other.CurStage && this.IsUnlimited == other.IsUnlimited && this.removeUintIncId_.Equals(other.removeUintIncId_) && this.TotalDay == other.TotalDay && this.RemainDay == other.RemainDay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008645 RID: 34373 RVA: 0x00142918 File Offset: 0x00140B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.onStageUnit_.GetHashCode();
			if (this.CurDay != 0)
			{
				num ^= this.CurDay.GetHashCode();
			}
			if (this.CurStage != 0)
			{
				num ^= this.CurStage.GetHashCode();
			}
			if (this.IsUnlimited)
			{
				num ^= this.IsUnlimited.GetHashCode();
			}
			num ^= this.removeUintIncId_.GetHashCode();
			if (this.TotalDay != 0)
			{
				num ^= this.TotalDay.GetHashCode();
			}
			if (this.RemainDay != 0)
			{
				num ^= this.RemainDay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008646 RID: 34374 RVA: 0x001429D7 File Offset: 0x00140BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008647 RID: 34375 RVA: 0x001429E4 File Offset: 0x00140BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008648 RID: 34376 RVA: 0x001429F0 File Offset: 0x00140BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.onStageUnit_.WriteTo(ref output, FloroRanchDayStart._repeated_onStageUnit_codec);
			if (this.CurDay != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurDay);
			}
			if (this.CurStage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurStage);
			}
			if (this.IsUnlimited)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsUnlimited);
			}
			this.removeUintIncId_.WriteTo(ref output, FloroRanchDayStart._repeated_removeUintIncId_codec);
			if (this.TotalDay != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TotalDay);
			}
			if (this.RemainDay != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RemainDay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008649 RID: 34377 RVA: 0x00142AC0 File Offset: 0x00140CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.onStageUnit_.CalculateSize(FloroRanchDayStart._repeated_onStageUnit_codec);
			if (this.CurDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurDay);
			}
			if (this.CurStage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStage);
			}
			if (this.IsUnlimited)
			{
				num += 2;
			}
			num += this.removeUintIncId_.CalculateSize(FloroRanchDayStart._repeated_removeUintIncId_codec);
			if (this.TotalDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalDay);
			}
			if (this.RemainDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainDay);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600864A RID: 34378 RVA: 0x00142B78 File Offset: 0x00140D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchDayStart other)
		{
			if (other == null)
			{
				return;
			}
			this.onStageUnit_.Add(other.onStageUnit_);
			if (other.CurDay != 0)
			{
				this.CurDay = other.CurDay;
			}
			if (other.CurStage != 0)
			{
				this.CurStage = other.CurStage;
			}
			if (other.IsUnlimited)
			{
				this.IsUnlimited = other.IsUnlimited;
			}
			this.removeUintIncId_.Add(other.removeUintIncId_);
			if (other.TotalDay != 0)
			{
				this.TotalDay = other.TotalDay;
			}
			if (other.RemainDay != 0)
			{
				this.RemainDay = other.RemainDay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600864B RID: 34379 RVA: 0x00142C26 File Offset: 0x00140E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x00142C30 File Offset: 0x00140E30
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
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.onStageUnit_.AddEntriesFrom(ref input, FloroRanchDayStart._repeated_onStageUnit_codec);
							continue;
						}
						if (num == 16U)
						{
							this.CurDay = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.CurStage = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.IsUnlimited = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.removeUintIncId_.AddEntriesFrom(ref input, FloroRanchDayStart._repeated_removeUintIncId_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.TotalDay = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.RemainDay = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004234 RID: 16948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004235 RID: 16949
		public const int OnStageUnitFieldNumber = 1;

		// Token: 0x04004236 RID: 16950
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_onStageUnit_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(10U, FloroRanchPlayUnit.Parser);

		// Token: 0x04004237 RID: 16951
		private readonly RepeatedField<FloroRanchPlayUnit> onStageUnit_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x04004238 RID: 16952
		public const int CurDayFieldNumber = 2;

		// Token: 0x04004239 RID: 16953
		private int curDay_;

		// Token: 0x0400423A RID: 16954
		public const int CurStageFieldNumber = 3;

		// Token: 0x0400423B RID: 16955
		private int curStage_;

		// Token: 0x0400423C RID: 16956
		public const int IsUnlimitedFieldNumber = 4;

		// Token: 0x0400423D RID: 16957
		private bool isUnlimited_;

		// Token: 0x0400423E RID: 16958
		public const int RemoveUintIncIdFieldNumber = 5;

		// Token: 0x0400423F RID: 16959
		private static readonly FieldCodec<int> _repeated_removeUintIncId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004240 RID: 16960
		private readonly RepeatedField<int> removeUintIncId_ = new RepeatedField<int>();

		// Token: 0x04004241 RID: 16961
		public const int TotalDayFieldNumber = 6;

		// Token: 0x04004242 RID: 16962
		private int totalDay_;

		// Token: 0x04004243 RID: 16963
		public const int RemainDayFieldNumber = 7;

		// Token: 0x04004244 RID: 16964
		private int remainDay_;
	}
}
