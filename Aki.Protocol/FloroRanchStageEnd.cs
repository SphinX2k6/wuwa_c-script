using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E5 RID: 1509
	public sealed class FloroRanchStageEnd : IMessage<FloroRanchStageEnd>, IMessage, IEquatable<FloroRanchStageEnd>, IDeepCloneable<FloroRanchStageEnd>, IBufferMessage
	{
		// Token: 0x06008BA2 RID: 35746 RVA: 0x00151CCE File Offset: 0x0014FECE
		[NullableContext(1)]
		public static FloroRanchStageEnd Create()
		{
			return new FloroRanchStageEnd();
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x00151CD5 File Offset: 0x0014FED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06008BA4 RID: 35748 RVA: 0x00151CD8 File Offset: 0x0014FED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStageEnd.Descriptor;
			}
		}

		// Token: 0x06008BA5 RID: 35749 RVA: 0x00151CDF File Offset: 0x0014FEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageEnd()
		{
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x00151CE8 File Offset: 0x0014FEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageEnd(FloroRanchStageEnd other) : this()
		{
			this.win_ = other.win_;
			this.totalCoin_ = other.totalCoin_;
			this.enableUnlimitedMode_ = other.enableUnlimitedMode_;
			this.isLastStage_ = other.isLastStage_;
			this.isUnlimitedMode_ = other.isUnlimitedMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x00151D48 File Offset: 0x0014FF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageEnd Clone()
		{
			return new FloroRanchStageEnd(this);
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06008BA8 RID: 35752 RVA: 0x00151D50 File Offset: 0x0014FF50
		// (set) Token: 0x06008BA9 RID: 35753 RVA: 0x00151D58 File Offset: 0x0014FF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06008BAA RID: 35754 RVA: 0x00151D61 File Offset: 0x0014FF61
		// (set) Token: 0x06008BAB RID: 35755 RVA: 0x00151D69 File Offset: 0x0014FF69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TotalCoin
		{
			get
			{
				return this.totalCoin_;
			}
			set
			{
				this.totalCoin_ = value;
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06008BAC RID: 35756 RVA: 0x00151D72 File Offset: 0x0014FF72
		// (set) Token: 0x06008BAD RID: 35757 RVA: 0x00151D7A File Offset: 0x0014FF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableUnlimitedMode
		{
			get
			{
				return this.enableUnlimitedMode_;
			}
			set
			{
				this.enableUnlimitedMode_ = value;
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06008BAE RID: 35758 RVA: 0x00151D83 File Offset: 0x0014FF83
		// (set) Token: 0x06008BAF RID: 35759 RVA: 0x00151D8B File Offset: 0x0014FF8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLastStage
		{
			get
			{
				return this.isLastStage_;
			}
			set
			{
				this.isLastStage_ = value;
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06008BB0 RID: 35760 RVA: 0x00151D94 File Offset: 0x0014FF94
		// (set) Token: 0x06008BB1 RID: 35761 RVA: 0x00151D9C File Offset: 0x0014FF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlimitedMode
		{
			get
			{
				return this.isUnlimitedMode_;
			}
			set
			{
				this.isUnlimitedMode_ = value;
			}
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x00151DA5 File Offset: 0x0014FFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStageEnd);
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x00151DB4 File Offset: 0x0014FFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStageEnd other)
		{
			return other != null && (other == this || (this.Win == other.Win && this.TotalCoin == other.TotalCoin && this.EnableUnlimitedMode == other.EnableUnlimitedMode && this.IsLastStage == other.IsLastStage && this.IsUnlimitedMode == other.IsUnlimitedMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x00151E30 File Offset: 0x00150030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.TotalCoin != 0L)
			{
				num ^= this.TotalCoin.GetHashCode();
			}
			if (this.EnableUnlimitedMode)
			{
				num ^= this.EnableUnlimitedMode.GetHashCode();
			}
			if (this.IsLastStage)
			{
				num ^= this.IsLastStage.GetHashCode();
			}
			if (this.IsUnlimitedMode)
			{
				num ^= this.IsUnlimitedMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x00151ED3 File Offset: 0x001500D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BB6 RID: 35766 RVA: 0x00151EE0 File Offset: 0x001500E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BB7 RID: 35767 RVA: 0x00151EEC File Offset: 0x001500EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Win)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Win);
			}
			if (this.TotalCoin != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TotalCoin);
			}
			if (this.EnableUnlimitedMode)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.EnableUnlimitedMode);
			}
			if (this.IsLastStage)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsLastStage);
			}
			if (this.IsUnlimitedMode)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsUnlimitedMode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x00151F98 File Offset: 0x00150198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Win)
			{
				num += 2;
			}
			if (this.TotalCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TotalCoin);
			}
			if (this.EnableUnlimitedMode)
			{
				num += 2;
			}
			if (this.IsLastStage)
			{
				num += 2;
			}
			if (this.IsUnlimitedMode)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x00152008 File Offset: 0x00150208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchStageEnd other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.TotalCoin != 0L)
			{
				this.TotalCoin = other.TotalCoin;
			}
			if (other.EnableUnlimitedMode)
			{
				this.EnableUnlimitedMode = other.EnableUnlimitedMode;
			}
			if (other.IsLastStage)
			{
				this.IsLastStage = other.IsLastStage;
			}
			if (other.IsUnlimitedMode)
			{
				this.IsUnlimitedMode = other.IsUnlimitedMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x00152094 File Offset: 0x00150294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x001520A0 File Offset: 0x001502A0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Win = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.TotalCoin = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EnableUnlimitedMode = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.IsLastStage = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsUnlimitedMode = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004475 RID: 17525
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004476 RID: 17526
		public const int WinFieldNumber = 1;

		// Token: 0x04004477 RID: 17527
		private bool win_;

		// Token: 0x04004478 RID: 17528
		public const int TotalCoinFieldNumber = 2;

		// Token: 0x04004479 RID: 17529
		private long totalCoin_;

		// Token: 0x0400447A RID: 17530
		public const int EnableUnlimitedModeFieldNumber = 3;

		// Token: 0x0400447B RID: 17531
		private bool enableUnlimitedMode_;

		// Token: 0x0400447C RID: 17532
		public const int IsLastStageFieldNumber = 4;

		// Token: 0x0400447D RID: 17533
		private bool isLastStage_;

		// Token: 0x0400447E RID: 17534
		public const int IsUnlimitedModeFieldNumber = 5;

		// Token: 0x0400447F RID: 17535
		private bool isUnlimitedMode_;
	}
}
