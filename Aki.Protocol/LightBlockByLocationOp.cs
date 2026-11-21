using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090E RID: 2318
	public sealed class LightBlockByLocationOp : IMessage<LightBlockByLocationOp>, IMessage, IEquatable<LightBlockByLocationOp>, IDeepCloneable<LightBlockByLocationOp>, IBufferMessage
	{
		// Token: 0x0600CCE4 RID: 52452 RVA: 0x001E3661 File Offset: 0x001E1861
		[NullableContext(1)]
		public static LightBlockByLocationOp Create()
		{
			return new LightBlockByLocationOp();
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x0600CCE5 RID: 52453 RVA: 0x001E3668 File Offset: 0x001E1868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x0600CCE6 RID: 52454 RVA: 0x001E366B File Offset: 0x001E186B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LightBlockByLocationOp.Descriptor;
			}
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x001E3672 File Offset: 0x001E1872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationOp()
		{
		}

		// Token: 0x0600CCE8 RID: 52456 RVA: 0x001E3688 File Offset: 0x001E1888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationOp(LightBlockByLocationOp other) : this()
		{
			this.configId_ = other.configId_;
			this.gridIndex_ = other.gridIndex_;
			this.focusTime_ = other.focusTime_;
			this.backToPlayer_ = other.backToPlayer_;
			this.grids_ = other.grids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x001E36ED File Offset: 0x001E18ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationOp Clone()
		{
			return new LightBlockByLocationOp(this);
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x001E36F5 File Offset: 0x001E18F5
		// (set) Token: 0x0600CCEB RID: 52459 RVA: 0x001E36FD File Offset: 0x001E18FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x0600CCEC RID: 52460 RVA: 0x001E3706 File Offset: 0x001E1906
		// (set) Token: 0x0600CCED RID: 52461 RVA: 0x001E370E File Offset: 0x001E190E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridIndex
		{
			get
			{
				return this.gridIndex_;
			}
			set
			{
				this.gridIndex_ = value;
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x001E3717 File Offset: 0x001E1917
		// (set) Token: 0x0600CCEF RID: 52463 RVA: 0x001E371F File Offset: 0x001E191F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusTime
		{
			get
			{
				return this.focusTime_;
			}
			set
			{
				this.focusTime_ = value;
			}
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x0600CCF0 RID: 52464 RVA: 0x001E3728 File Offset: 0x001E1928
		// (set) Token: 0x0600CCF1 RID: 52465 RVA: 0x001E3730 File Offset: 0x001E1930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BackToPlayer
		{
			get
			{
				return this.backToPlayer_;
			}
			set
			{
				this.backToPlayer_ = value;
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x001E3739 File Offset: 0x001E1939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Grids
		{
			get
			{
				return this.grids_;
			}
		}

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x001E3741 File Offset: 0x001E1941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LightBlockByLocationOp);
		}

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x001E3750 File Offset: 0x001E1950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LightBlockByLocationOp other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.GridIndex == other.GridIndex && this.FocusTime == other.FocusTime && this.BackToPlayer == other.BackToPlayer && this.grids_.Equals(other.grids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCF5 RID: 52469 RVA: 0x001E37D0 File Offset: 0x001E19D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.GridIndex != 0)
			{
				num ^= this.GridIndex.GetHashCode();
			}
			if (this.FocusTime != 0)
			{
				num ^= this.FocusTime.GetHashCode();
			}
			if (this.BackToPlayer)
			{
				num ^= this.BackToPlayer.GetHashCode();
			}
			num ^= this.grids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCF6 RID: 52470 RVA: 0x001E3868 File Offset: 0x001E1A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCF7 RID: 52471 RVA: 0x001E3875 File Offset: 0x001E1A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCF8 RID: 52472 RVA: 0x001E3880 File Offset: 0x001E1A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.GridIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GridIndex);
			}
			if (this.FocusTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FocusTime);
			}
			if (this.BackToPlayer)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.BackToPlayer);
			}
			this.grids_.WriteTo(ref output, LightBlockByLocationOp._repeated_grids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x001E3924 File Offset: 0x001E1B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.GridIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridIndex);
			}
			if (this.FocusTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FocusTime);
			}
			if (this.BackToPlayer)
			{
				num += 2;
			}
			num += this.grids_.CalculateSize(LightBlockByLocationOp._repeated_grids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x001E39B4 File Offset: 0x001E1BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LightBlockByLocationOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.GridIndex != 0)
			{
				this.GridIndex = other.GridIndex;
			}
			if (other.FocusTime != 0)
			{
				this.FocusTime = other.FocusTime;
			}
			if (other.BackToPlayer)
			{
				this.BackToPlayer = other.BackToPlayer;
			}
			this.grids_.Add(other.grids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x001E3A3D File Offset: 0x001E1C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x001E3A48 File Offset: 0x001E1C48
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
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GridIndex = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.FocusTime = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.BackToPlayer = input.ReadBool();
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.grids_.AddEntriesFrom(ref input, LightBlockByLocationOp._repeated_grids_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005720 RID: 22304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005721 RID: 22305
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04005722 RID: 22306
		private int configId_;

		// Token: 0x04005723 RID: 22307
		public const int GridIndexFieldNumber = 2;

		// Token: 0x04005724 RID: 22308
		private int gridIndex_;

		// Token: 0x04005725 RID: 22309
		public const int FocusTimeFieldNumber = 3;

		// Token: 0x04005726 RID: 22310
		private int focusTime_;

		// Token: 0x04005727 RID: 22311
		public const int BackToPlayerFieldNumber = 4;

		// Token: 0x04005728 RID: 22312
		private bool backToPlayer_;

		// Token: 0x04005729 RID: 22313
		public const int GridsFieldNumber = 5;

		// Token: 0x0400572A RID: 22314
		private static readonly FieldCodec<int> _repeated_grids_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400572B RID: 22315
		private readonly RepeatedField<int> grids_ = new RepeatedField<int>();
	}
}
