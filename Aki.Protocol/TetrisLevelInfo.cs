using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001355 RID: 4949
	public sealed class TetrisLevelInfo : IMessage<TetrisLevelInfo>, IMessage, IEquatable<TetrisLevelInfo>, IDeepCloneable<TetrisLevelInfo>, IBufferMessage
	{
		// Token: 0x0601A4AE RID: 107694 RVA: 0x003D1E01 File Offset: 0x003D0001
		[NullableContext(1)]
		public static TetrisLevelInfo Create()
		{
			return new TetrisLevelInfo();
		}

		// Token: 0x170058B5 RID: 22709
		// (get) Token: 0x0601A4AF RID: 107695 RVA: 0x003D1E08 File Offset: 0x003D0008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TetrisLevelInfo> Parser
		{
			get
			{
				return TetrisLevelInfo._parser;
			}
		}

		// Token: 0x170058B6 RID: 22710
		// (get) Token: 0x0601A4B0 RID: 107696 RVA: 0x003D1E0F File Offset: 0x003D000F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058B7 RID: 22711
		// (get) Token: 0x0601A4B1 RID: 107697 RVA: 0x003D1E12 File Offset: 0x003D0012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisLevelInfo.Descriptor;
			}
		}

		// Token: 0x0601A4B2 RID: 107698 RVA: 0x003D1E19 File Offset: 0x003D0019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisLevelInfo()
		{
		}

		// Token: 0x0601A4B3 RID: 107699 RVA: 0x003D1E2C File Offset: 0x003D002C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisLevelInfo(TetrisLevelInfo other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.difficultyIdx_ = other.difficultyIdx_;
			this.state_ = other.state_;
			this.unlockTime_ = other.unlockTime_;
			this.results_ = other.results_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4B4 RID: 107700 RVA: 0x003D1E9D File Offset: 0x003D009D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisLevelInfo Clone()
		{
			return new TetrisLevelInfo(this);
		}

		// Token: 0x170058B8 RID: 22712
		// (get) Token: 0x0601A4B5 RID: 107701 RVA: 0x003D1EA5 File Offset: 0x003D00A5
		// (set) Token: 0x0601A4B6 RID: 107702 RVA: 0x003D1EAD File Offset: 0x003D00AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170058B9 RID: 22713
		// (get) Token: 0x0601A4B7 RID: 107703 RVA: 0x003D1EB6 File Offset: 0x003D00B6
		// (set) Token: 0x0601A4B8 RID: 107704 RVA: 0x003D1ECE File Offset: 0x003D00CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DifficultyIdx
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.difficultyIdx_;
				}
				return TetrisLevelInfo.DifficultyIdxDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.difficultyIdx_ = value;
			}
		}

		// Token: 0x170058BA RID: 22714
		// (get) Token: 0x0601A4B9 RID: 107705 RVA: 0x003D1EE5 File Offset: 0x003D00E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDifficultyIdx
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601A4BA RID: 107706 RVA: 0x003D1EF2 File Offset: 0x003D00F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDifficultyIdx()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170058BB RID: 22715
		// (get) Token: 0x0601A4BB RID: 107707 RVA: 0x003D1F03 File Offset: 0x003D0103
		// (set) Token: 0x0601A4BC RID: 107708 RVA: 0x003D1F1B File Offset: 0x003D011B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisState State
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.state_;
				}
				return TetrisLevelInfo.StateDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.state_ = value;
			}
		}

		// Token: 0x170058BC RID: 22716
		// (get) Token: 0x0601A4BD RID: 107709 RVA: 0x003D1F32 File Offset: 0x003D0132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasState
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0601A4BE RID: 107710 RVA: 0x003D1F3F File Offset: 0x003D013F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearState()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170058BD RID: 22717
		// (get) Token: 0x0601A4BF RID: 107711 RVA: 0x003D1F50 File Offset: 0x003D0150
		// (set) Token: 0x0601A4C0 RID: 107712 RVA: 0x003D1F68 File Offset: 0x003D0168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				if ((this._hasBits0 & 4) != 0)
				{
					return this.unlockTime_;
				}
				return TetrisLevelInfo.UnlockTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.unlockTime_ = value;
			}
		}

		// Token: 0x170058BE RID: 22718
		// (get) Token: 0x0601A4C1 RID: 107713 RVA: 0x003D1F7F File Offset: 0x003D017F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0601A4C2 RID: 107714 RVA: 0x003D1F8C File Offset: 0x003D018C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x170058BF RID: 22719
		// (get) Token: 0x0601A4C3 RID: 107715 RVA: 0x003D1F9D File Offset: 0x003D019D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Results
		{
			get
			{
				return this.results_;
			}
		}

		// Token: 0x0601A4C4 RID: 107716 RVA: 0x003D1FA5 File Offset: 0x003D01A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisLevelInfo);
		}

		// Token: 0x0601A4C5 RID: 107717 RVA: 0x003D1FB4 File Offset: 0x003D01B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.DifficultyIdx == other.DifficultyIdx && this.State == other.State && this.UnlockTime == other.UnlockTime && this.Results.Equals(other.Results) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4C6 RID: 107718 RVA: 0x003D2034 File Offset: 0x003D0234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.HasDifficultyIdx)
			{
				num ^= this.DifficultyIdx.GetHashCode();
			}
			if (this.HasState)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.HasUnlockTime)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			num ^= this.Results.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A4C7 RID: 107719 RVA: 0x003D20D2 File Offset: 0x003D02D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4C8 RID: 107720 RVA: 0x003D20DF File Offset: 0x003D02DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4C9 RID: 107721 RVA: 0x003D20E8 File Offset: 0x003D02E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.HasDifficultyIdx)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DifficultyIdx);
			}
			if (this.HasState)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.State);
			}
			if (this.HasUnlockTime)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.UnlockTime);
			}
			this.results_.WriteTo(ref output, TetrisLevelInfo._map_results_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4CA RID: 107722 RVA: 0x003D218C File Offset: 0x003D038C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.HasDifficultyIdx)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DifficultyIdx);
			}
			if (this.HasState)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this.HasUnlockTime)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			num += this.results_.CalculateSize(TetrisLevelInfo._map_results_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A4CB RID: 107723 RVA: 0x003D2228 File Offset: 0x003D0428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.HasDifficultyIdx)
			{
				this.DifficultyIdx = other.DifficultyIdx;
			}
			if (other.HasState)
			{
				this.State = other.State;
			}
			if (other.HasUnlockTime)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this.results_.MergeFrom(other.results_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A4CC RID: 107724 RVA: 0x003D22B1 File Offset: 0x003D04B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4CD RID: 107725 RVA: 0x003D22BC File Offset: 0x003D04BC
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DifficultyIdx = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.State = (TetrisState)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.UnlockTime = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.results_.AddEntriesFrom(ref input, TetrisLevelInfo._map_results_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009951 RID: 39249
		private static readonly MessageParser<TetrisLevelInfo> _parser = new MessageParser<TetrisLevelInfo>(() => new TetrisLevelInfo());

		// Token: 0x04009952 RID: 39250
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009953 RID: 39251
		private int _hasBits0;

		// Token: 0x04009954 RID: 39252
		public const int IdFieldNumber = 1;

		// Token: 0x04009955 RID: 39253
		private int id_;

		// Token: 0x04009956 RID: 39254
		public const int DifficultyIdxFieldNumber = 2;

		// Token: 0x04009957 RID: 39255
		private static readonly int DifficultyIdxDefaultValue = 0;

		// Token: 0x04009958 RID: 39256
		private int difficultyIdx_;

		// Token: 0x04009959 RID: 39257
		public const int StateFieldNumber = 3;

		// Token: 0x0400995A RID: 39258
		private static readonly TetrisState StateDefaultValue = TetrisState.TetrisLocked;

		// Token: 0x0400995B RID: 39259
		private TetrisState state_;

		// Token: 0x0400995C RID: 39260
		public const int UnlockTimeFieldNumber = 4;

		// Token: 0x0400995D RID: 39261
		private static readonly long UnlockTimeDefaultValue = 0L;

		// Token: 0x0400995E RID: 39262
		private long unlockTime_;

		// Token: 0x0400995F RID: 39263
		public const int ResultsFieldNumber = 5;

		// Token: 0x04009960 RID: 39264
		private static readonly MapField<int, int>.Codec _map_results_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04009961 RID: 39265
		private readonly MapField<int, int> results_ = new MapField<int, int>();
	}
}
