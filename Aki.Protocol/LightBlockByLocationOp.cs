using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091F RID: 2335
	public sealed class LightBlockByLocationOp : IMessage<LightBlockByLocationOp>, IMessage, IEquatable<LightBlockByLocationOp>, IDeepCloneable<LightBlockByLocationOp>, IBufferMessage
	{
		// Token: 0x0600CE00 RID: 52736 RVA: 0x001E5931 File Offset: 0x001E3B31
		[NullableContext(1)]
		public static LightBlockByLocationOp Create()
		{
			return new LightBlockByLocationOp();
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x0600CE01 RID: 52737 RVA: 0x001E5938 File Offset: 0x001E3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x0600CE02 RID: 52738 RVA: 0x001E593B File Offset: 0x001E3B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LightBlockByLocationOp.Descriptor;
			}
		}

		// Token: 0x0600CE03 RID: 52739 RVA: 0x001E5942 File Offset: 0x001E3B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationOp()
		{
		}

		// Token: 0x0600CE04 RID: 52740 RVA: 0x001E5958 File Offset: 0x001E3B58
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

		// Token: 0x0600CE05 RID: 52741 RVA: 0x001E59BD File Offset: 0x001E3BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationOp Clone()
		{
			return new LightBlockByLocationOp(this);
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x0600CE06 RID: 52742 RVA: 0x001E59C5 File Offset: 0x001E3BC5
		// (set) Token: 0x0600CE07 RID: 52743 RVA: 0x001E59CD File Offset: 0x001E3BCD
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

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x0600CE08 RID: 52744 RVA: 0x001E59D6 File Offset: 0x001E3BD6
		// (set) Token: 0x0600CE09 RID: 52745 RVA: 0x001E59DE File Offset: 0x001E3BDE
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

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x0600CE0A RID: 52746 RVA: 0x001E59E7 File Offset: 0x001E3BE7
		// (set) Token: 0x0600CE0B RID: 52747 RVA: 0x001E59EF File Offset: 0x001E3BEF
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

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x0600CE0C RID: 52748 RVA: 0x001E59F8 File Offset: 0x001E3BF8
		// (set) Token: 0x0600CE0D RID: 52749 RVA: 0x001E5A00 File Offset: 0x001E3C00
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

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x0600CE0E RID: 52750 RVA: 0x001E5A09 File Offset: 0x001E3C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Grids
		{
			get
			{
				return this.grids_;
			}
		}

		// Token: 0x0600CE0F RID: 52751 RVA: 0x001E5A11 File Offset: 0x001E3C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LightBlockByLocationOp);
		}

		// Token: 0x0600CE10 RID: 52752 RVA: 0x001E5A20 File Offset: 0x001E3C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LightBlockByLocationOp other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.GridIndex == other.GridIndex && this.FocusTime == other.FocusTime && this.BackToPlayer == other.BackToPlayer && this.grids_.Equals(other.grids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE11 RID: 52753 RVA: 0x001E5AA0 File Offset: 0x001E3CA0
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

		// Token: 0x0600CE12 RID: 52754 RVA: 0x001E5B38 File Offset: 0x001E3D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE13 RID: 52755 RVA: 0x001E5B45 File Offset: 0x001E3D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE14 RID: 52756 RVA: 0x001E5B50 File Offset: 0x001E3D50
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

		// Token: 0x0600CE15 RID: 52757 RVA: 0x001E5BF4 File Offset: 0x001E3DF4
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

		// Token: 0x0600CE16 RID: 52758 RVA: 0x001E5C84 File Offset: 0x001E3E84
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

		// Token: 0x0600CE17 RID: 52759 RVA: 0x001E5D0D File Offset: 0x001E3F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE18 RID: 52760 RVA: 0x001E5D18 File Offset: 0x001E3F18
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

		// Token: 0x04005719 RID: 22297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400571A RID: 22298
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400571B RID: 22299
		private int configId_;

		// Token: 0x0400571C RID: 22300
		public const int GridIndexFieldNumber = 2;

		// Token: 0x0400571D RID: 22301
		private int gridIndex_;

		// Token: 0x0400571E RID: 22302
		public const int FocusTimeFieldNumber = 3;

		// Token: 0x0400571F RID: 22303
		private int focusTime_;

		// Token: 0x04005720 RID: 22304
		public const int BackToPlayerFieldNumber = 4;

		// Token: 0x04005721 RID: 22305
		private bool backToPlayer_;

		// Token: 0x04005722 RID: 22306
		public const int GridsFieldNumber = 5;

		// Token: 0x04005723 RID: 22307
		private static readonly FieldCodec<int> _repeated_grids_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04005724 RID: 22308
		private readonly RepeatedField<int> grids_ = new RepeatedField<int>();
	}
}
