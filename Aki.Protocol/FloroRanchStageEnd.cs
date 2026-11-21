using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D0 RID: 1488
	public sealed class FloroRanchStageEnd : IMessage<FloroRanchStageEnd>, IMessage, IEquatable<FloroRanchStageEnd>, IDeepCloneable<FloroRanchStageEnd>, IBufferMessage
	{
		// Token: 0x06008A3A RID: 35386 RVA: 0x0014F0BA File Offset: 0x0014D2BA
		[NullableContext(1)]
		public static FloroRanchStageEnd Create()
		{
			return new FloroRanchStageEnd();
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06008A3B RID: 35387 RVA: 0x0014F0C1 File Offset: 0x0014D2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06008A3C RID: 35388 RVA: 0x0014F0C4 File Offset: 0x0014D2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStageEnd.Descriptor;
			}
		}

		// Token: 0x06008A3D RID: 35389 RVA: 0x0014F0CB File Offset: 0x0014D2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageEnd()
		{
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x0014F0D4 File Offset: 0x0014D2D4
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

		// Token: 0x06008A3F RID: 35391 RVA: 0x0014F134 File Offset: 0x0014D334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStageEnd Clone()
		{
			return new FloroRanchStageEnd(this);
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06008A40 RID: 35392 RVA: 0x0014F13C File Offset: 0x0014D33C
		// (set) Token: 0x06008A41 RID: 35393 RVA: 0x0014F144 File Offset: 0x0014D344
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

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06008A42 RID: 35394 RVA: 0x0014F14D File Offset: 0x0014D34D
		// (set) Token: 0x06008A43 RID: 35395 RVA: 0x0014F155 File Offset: 0x0014D355
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

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06008A44 RID: 35396 RVA: 0x0014F15E File Offset: 0x0014D35E
		// (set) Token: 0x06008A45 RID: 35397 RVA: 0x0014F166 File Offset: 0x0014D366
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

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06008A46 RID: 35398 RVA: 0x0014F16F File Offset: 0x0014D36F
		// (set) Token: 0x06008A47 RID: 35399 RVA: 0x0014F177 File Offset: 0x0014D377
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

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06008A48 RID: 35400 RVA: 0x0014F180 File Offset: 0x0014D380
		// (set) Token: 0x06008A49 RID: 35401 RVA: 0x0014F188 File Offset: 0x0014D388
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

		// Token: 0x06008A4A RID: 35402 RVA: 0x0014F191 File Offset: 0x0014D391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStageEnd);
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x0014F1A0 File Offset: 0x0014D3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStageEnd other)
		{
			return other != null && (other == this || (this.Win == other.Win && this.TotalCoin == other.TotalCoin && this.EnableUnlimitedMode == other.EnableUnlimitedMode && this.IsLastStage == other.IsLastStage && this.IsUnlimitedMode == other.IsUnlimitedMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x0014F21C File Offset: 0x0014D41C
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

		// Token: 0x06008A4D RID: 35405 RVA: 0x0014F2BF File Offset: 0x0014D4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x0014F2CC File Offset: 0x0014D4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x0014F2D8 File Offset: 0x0014D4D8
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

		// Token: 0x06008A50 RID: 35408 RVA: 0x0014F384 File Offset: 0x0014D584
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

		// Token: 0x06008A51 RID: 35409 RVA: 0x0014F3F4 File Offset: 0x0014D5F4
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

		// Token: 0x06008A52 RID: 35410 RVA: 0x0014F480 File Offset: 0x0014D680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x0014F48C File Offset: 0x0014D68C
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

		// Token: 0x0400446B RID: 17515
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400446C RID: 17516
		public const int WinFieldNumber = 1;

		// Token: 0x0400446D RID: 17517
		private bool win_;

		// Token: 0x0400446E RID: 17518
		public const int TotalCoinFieldNumber = 2;

		// Token: 0x0400446F RID: 17519
		private long totalCoin_;

		// Token: 0x04004470 RID: 17520
		public const int EnableUnlimitedModeFieldNumber = 3;

		// Token: 0x04004471 RID: 17521
		private bool enableUnlimitedMode_;

		// Token: 0x04004472 RID: 17522
		public const int IsLastStageFieldNumber = 4;

		// Token: 0x04004473 RID: 17523
		private bool isLastStage_;

		// Token: 0x04004474 RID: 17524
		public const int IsUnlimitedModeFieldNumber = 5;

		// Token: 0x04004475 RID: 17525
		private bool isUnlimitedMode_;
	}
}
