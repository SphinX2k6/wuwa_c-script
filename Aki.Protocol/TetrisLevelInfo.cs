using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C8 RID: 5064
	public sealed class TetrisLevelInfo : IMessage<TetrisLevelInfo>, IMessage, IEquatable<TetrisLevelInfo>, IDeepCloneable<TetrisLevelInfo>, IBufferMessage
	{
		// Token: 0x0601AF35 RID: 110389 RVA: 0x003ECF35 File Offset: 0x003EB135
		[NullableContext(1)]
		public static TetrisLevelInfo Create()
		{
			return new TetrisLevelInfo();
		}

		// Token: 0x17005B48 RID: 23368
		// (get) Token: 0x0601AF36 RID: 110390 RVA: 0x003ECF3C File Offset: 0x003EB13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TetrisLevelInfo> Parser
		{
			get
			{
				return TetrisLevelInfo._parser;
			}
		}

		// Token: 0x17005B49 RID: 23369
		// (get) Token: 0x0601AF37 RID: 110391 RVA: 0x003ECF43 File Offset: 0x003EB143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B4A RID: 23370
		// (get) Token: 0x0601AF38 RID: 110392 RVA: 0x003ECF46 File Offset: 0x003EB146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisLevelInfo.Descriptor;
			}
		}

		// Token: 0x0601AF39 RID: 110393 RVA: 0x003ECF4D File Offset: 0x003EB14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisLevelInfo()
		{
		}

		// Token: 0x0601AF3A RID: 110394 RVA: 0x003ECF60 File Offset: 0x003EB160
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

		// Token: 0x0601AF3B RID: 110395 RVA: 0x003ECFD1 File Offset: 0x003EB1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisLevelInfo Clone()
		{
			return new TetrisLevelInfo(this);
		}

		// Token: 0x17005B4B RID: 23371
		// (get) Token: 0x0601AF3C RID: 110396 RVA: 0x003ECFD9 File Offset: 0x003EB1D9
		// (set) Token: 0x0601AF3D RID: 110397 RVA: 0x003ECFE1 File Offset: 0x003EB1E1
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

		// Token: 0x17005B4C RID: 23372
		// (get) Token: 0x0601AF3E RID: 110398 RVA: 0x003ECFEA File Offset: 0x003EB1EA
		// (set) Token: 0x0601AF3F RID: 110399 RVA: 0x003ED002 File Offset: 0x003EB202
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

		// Token: 0x17005B4D RID: 23373
		// (get) Token: 0x0601AF40 RID: 110400 RVA: 0x003ED019 File Offset: 0x003EB219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDifficultyIdx
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601AF41 RID: 110401 RVA: 0x003ED026 File Offset: 0x003EB226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDifficultyIdx()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17005B4E RID: 23374
		// (get) Token: 0x0601AF42 RID: 110402 RVA: 0x003ED037 File Offset: 0x003EB237
		// (set) Token: 0x0601AF43 RID: 110403 RVA: 0x003ED04F File Offset: 0x003EB24F
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

		// Token: 0x17005B4F RID: 23375
		// (get) Token: 0x0601AF44 RID: 110404 RVA: 0x003ED066 File Offset: 0x003EB266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasState
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0601AF45 RID: 110405 RVA: 0x003ED073 File Offset: 0x003EB273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearState()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17005B50 RID: 23376
		// (get) Token: 0x0601AF46 RID: 110406 RVA: 0x003ED084 File Offset: 0x003EB284
		// (set) Token: 0x0601AF47 RID: 110407 RVA: 0x003ED09C File Offset: 0x003EB29C
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

		// Token: 0x17005B51 RID: 23377
		// (get) Token: 0x0601AF48 RID: 110408 RVA: 0x003ED0B3 File Offset: 0x003EB2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasUnlockTime
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0601AF49 RID: 110409 RVA: 0x003ED0C0 File Offset: 0x003EB2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearUnlockTime()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17005B52 RID: 23378
		// (get) Token: 0x0601AF4A RID: 110410 RVA: 0x003ED0D1 File Offset: 0x003EB2D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> Results
		{
			get
			{
				return this.results_;
			}
		}

		// Token: 0x0601AF4B RID: 110411 RVA: 0x003ED0D9 File Offset: 0x003EB2D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisLevelInfo);
		}

		// Token: 0x0601AF4C RID: 110412 RVA: 0x003ED0E8 File Offset: 0x003EB2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisLevelInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.DifficultyIdx == other.DifficultyIdx && this.State == other.State && this.UnlockTime == other.UnlockTime && this.Results.Equals(other.Results) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF4D RID: 110413 RVA: 0x003ED168 File Offset: 0x003EB368
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

		// Token: 0x0601AF4E RID: 110414 RVA: 0x003ED206 File Offset: 0x003EB406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF4F RID: 110415 RVA: 0x003ED213 File Offset: 0x003EB413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF50 RID: 110416 RVA: 0x003ED21C File Offset: 0x003EB41C
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

		// Token: 0x0601AF51 RID: 110417 RVA: 0x003ED2C0 File Offset: 0x003EB4C0
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

		// Token: 0x0601AF52 RID: 110418 RVA: 0x003ED35C File Offset: 0x003EB55C
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

		// Token: 0x0601AF53 RID: 110419 RVA: 0x003ED3E5 File Offset: 0x003EB5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF54 RID: 110420 RVA: 0x003ED3F0 File Offset: 0x003EB5F0
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

		// Token: 0x04009D93 RID: 40339
		private static readonly MessageParser<TetrisLevelInfo> _parser = new MessageParser<TetrisLevelInfo>(() => new TetrisLevelInfo());

		// Token: 0x04009D94 RID: 40340
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D95 RID: 40341
		private int _hasBits0;

		// Token: 0x04009D96 RID: 40342
		public const int IdFieldNumber = 1;

		// Token: 0x04009D97 RID: 40343
		private int id_;

		// Token: 0x04009D98 RID: 40344
		public const int DifficultyIdxFieldNumber = 2;

		// Token: 0x04009D99 RID: 40345
		private static readonly int DifficultyIdxDefaultValue = 0;

		// Token: 0x04009D9A RID: 40346
		private int difficultyIdx_;

		// Token: 0x04009D9B RID: 40347
		public const int StateFieldNumber = 3;

		// Token: 0x04009D9C RID: 40348
		private static readonly TetrisState StateDefaultValue = TetrisState.TetrisLocked;

		// Token: 0x04009D9D RID: 40349
		private TetrisState state_;

		// Token: 0x04009D9E RID: 40350
		public const int UnlockTimeFieldNumber = 4;

		// Token: 0x04009D9F RID: 40351
		private static readonly long UnlockTimeDefaultValue = 0L;

		// Token: 0x04009DA0 RID: 40352
		private long unlockTime_;

		// Token: 0x04009DA1 RID: 40353
		public const int ResultsFieldNumber = 5;

		// Token: 0x04009DA2 RID: 40354
		private static readonly MapField<int, int>.Codec _map_results_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04009DA3 RID: 40355
		private readonly MapField<int, int> results_ = new MapField<int, int>();
	}
}
