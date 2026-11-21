using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C5 RID: 5317
	[NetMessage(EMessageId.TrapDefenseStepUpdateNotify)]
	public sealed class TrapDefenseStepUpdateNotify : IMessage<TrapDefenseStepUpdateNotify>, IMessage, IEquatable<TrapDefenseStepUpdateNotify>, IDeepCloneable<TrapDefenseStepUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C34B RID: 115531 RVA: 0x00417E29 File Offset: 0x00416029
		[NullableContext(1)]
		public static TrapDefenseStepUpdateNotify Create()
		{
			return new TrapDefenseStepUpdateNotify();
		}

		// Token: 0x17005F75 RID: 24437
		// (get) Token: 0x0601C34C RID: 115532 RVA: 0x00417E30 File Offset: 0x00416030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F76 RID: 24438
		// (get) Token: 0x0601C34D RID: 115533 RVA: 0x00417E33 File Offset: 0x00416033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseStepUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C34E RID: 115534 RVA: 0x00417E3A File Offset: 0x0041603A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify()
		{
		}

		// Token: 0x0601C34F RID: 115535 RVA: 0x00417E44 File Offset: 0x00416044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify(TrapDefenseStepUpdateNotify other) : this()
		{
			TrapDefenseStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase <= TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
			{
				if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
				{
					if (stepPbDataCase == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
					{
						this.MapChangeStepPbData = other.MapChangeStepPbData.Clone();
					}
				}
				else
				{
					this.PreviewStepPbData = other.PreviewStepPbData.Clone();
				}
			}
			else if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				if (stepPbDataCase == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
				{
					this.MonsterStepPbData = other.MonsterStepPbData.Clone();
				}
			}
			else
			{
				this.RewardStepPbData = other.RewardStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C350 RID: 115536 RVA: 0x00417ED3 File Offset: 0x004160D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify Clone()
		{
			return new TrapDefenseStepUpdateNotify(this);
		}

		// Token: 0x17005F77 RID: 24439
		// (get) Token: 0x0601C351 RID: 115537 RVA: 0x00417EDB File Offset: 0x004160DB
		// (set) Token: 0x0601C352 RID: 115538 RVA: 0x00417EF3 File Offset: 0x004160F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMapChangeStepPbData MapChangeStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
				{
					return null;
				}
				return (TrapDefenseMapChangeStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? TrapDefenseStepUpdateNotify.StepPbDataOneofCase.None : TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData);
			}
		}

		// Token: 0x17005F78 RID: 24440
		// (get) Token: 0x0601C353 RID: 115539 RVA: 0x00417F09 File Offset: 0x00416109
		// (set) Token: 0x0601C354 RID: 115540 RVA: 0x00417F21 File Offset: 0x00416121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefensePreviewStepPbData PreviewStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
				{
					return null;
				}
				return (TrapDefensePreviewStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? TrapDefenseStepUpdateNotify.StepPbDataOneofCase.None : TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData);
			}
		}

		// Token: 0x17005F79 RID: 24441
		// (get) Token: 0x0601C355 RID: 115541 RVA: 0x00417F37 File Offset: 0x00416137
		// (set) Token: 0x0601C356 RID: 115542 RVA: 0x00417F50 File Offset: 0x00416150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterStepPbData MonsterStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
				{
					return null;
				}
				return (TrapDefenseSpawnMonsterStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? TrapDefenseStepUpdateNotify.StepPbDataOneofCase.None : TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData);
			}
		}

		// Token: 0x17005F7A RID: 24442
		// (get) Token: 0x0601C357 RID: 115543 RVA: 0x00417F67 File Offset: 0x00416167
		// (set) Token: 0x0601C358 RID: 115544 RVA: 0x00417F80 File Offset: 0x00416180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRewardStepPbData RewardStepPbData
		{
			get
			{
				if (this.stepPbDataCase_ != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
				{
					return null;
				}
				return (TrapDefenseRewardStepPbData)this.stepPbData_;
			}
			set
			{
				this.stepPbData_ = value;
				this.stepPbDataCase_ = ((value == null) ? TrapDefenseStepUpdateNotify.StepPbDataOneofCase.None : TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData);
			}
		}

		// Token: 0x17005F7B RID: 24443
		// (get) Token: 0x0601C359 RID: 115545 RVA: 0x00417F97 File Offset: 0x00416197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0601C35A RID: 115546 RVA: 0x00417F9F File Offset: 0x0041619F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = TrapDefenseStepUpdateNotify.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0601C35B RID: 115547 RVA: 0x00417FAF File Offset: 0x004161AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseStepUpdateNotify);
		}

		// Token: 0x0601C35C RID: 115548 RVA: 0x00417FC0 File Offset: 0x004161C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseStepUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MapChangeStepPbData, other.MapChangeStepPbData) && object.Equals(this.PreviewStepPbData, other.PreviewStepPbData) && object.Equals(this.MonsterStepPbData, other.MonsterStepPbData) && object.Equals(this.RewardStepPbData, other.RewardStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C35D RID: 115549 RVA: 0x00418050 File Offset: 0x00416250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
			{
				num ^= this.MapChangeStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
			{
				num ^= this.PreviewStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
			{
				num ^= this.MonsterStepPbData.GetHashCode();
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				num ^= this.RewardStepPbData.GetHashCode();
			}
			num ^= (int)this.stepPbDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C35E RID: 115550 RVA: 0x004180DD File Offset: 0x004162DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C35F RID: 115551 RVA: 0x004180EA File Offset: 0x004162EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C360 RID: 115552 RVA: 0x004180F4 File Offset: 0x004162F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PreviewStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MapChangeStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RewardStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MonsterStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C361 RID: 115553 RVA: 0x0041818C File Offset: 0x0041638C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MapChangeStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PreviewStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonsterStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardStepPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C362 RID: 115554 RVA: 0x00418218 File Offset: 0x00416418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseStepUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			TrapDefenseStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase <= TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
			{
				if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
				{
					if (stepPbDataCase == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
					{
						if (this.MapChangeStepPbData == null)
						{
							this.MapChangeStepPbData = new TrapDefenseMapChangeStepPbData();
						}
						this.MapChangeStepPbData.MergeFrom(other.MapChangeStepPbData);
					}
				}
				else
				{
					if (this.PreviewStepPbData == null)
					{
						this.PreviewStepPbData = new TrapDefensePreviewStepPbData();
					}
					this.PreviewStepPbData.MergeFrom(other.PreviewStepPbData);
				}
			}
			else if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				if (stepPbDataCase == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
				{
					if (this.MonsterStepPbData == null)
					{
						this.MonsterStepPbData = new TrapDefenseSpawnMonsterStepPbData();
					}
					this.MonsterStepPbData.MergeFrom(other.MonsterStepPbData);
				}
			}
			else
			{
				if (this.RewardStepPbData == null)
				{
					this.RewardStepPbData = new TrapDefenseRewardStepPbData();
				}
				this.RewardStepPbData.MergeFrom(other.RewardStepPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C363 RID: 115555 RVA: 0x004182FD File Offset: 0x004164FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C364 RID: 115556 RVA: 0x00418308 File Offset: 0x00416508
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
				if (num <= 50U)
				{
					if (num == 42U)
					{
						TrapDefensePreviewStepPbData trapDefensePreviewStepPbData = new TrapDefensePreviewStepPbData();
						if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
						{
							trapDefensePreviewStepPbData.MergeFrom(this.PreviewStepPbData);
						}
						input.ReadMessage(trapDefensePreviewStepPbData);
						this.PreviewStepPbData = trapDefensePreviewStepPbData;
						continue;
					}
					if (num == 50U)
					{
						TrapDefenseMapChangeStepPbData trapDefenseMapChangeStepPbData = new TrapDefenseMapChangeStepPbData();
						if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
						{
							trapDefenseMapChangeStepPbData.MergeFrom(this.MapChangeStepPbData);
						}
						input.ReadMessage(trapDefenseMapChangeStepPbData);
						this.MapChangeStepPbData = trapDefenseMapChangeStepPbData;
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						TrapDefenseRewardStepPbData trapDefenseRewardStepPbData = new TrapDefenseRewardStepPbData();
						if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
						{
							trapDefenseRewardStepPbData.MergeFrom(this.RewardStepPbData);
						}
						input.ReadMessage(trapDefenseRewardStepPbData);
						this.RewardStepPbData = trapDefenseRewardStepPbData;
						continue;
					}
					if (num == 114U)
					{
						TrapDefenseSpawnMonsterStepPbData trapDefenseSpawnMonsterStepPbData = new TrapDefenseSpawnMonsterStepPbData();
						if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
						{
							trapDefenseSpawnMonsterStepPbData.MergeFrom(this.MonsterStepPbData);
						}
						input.ReadMessage(trapDefenseSpawnMonsterStepPbData);
						this.MonsterStepPbData = trapDefenseSpawnMonsterStepPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A314 RID: 41748
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A315 RID: 41749
		public const int MapChangeStepPbDataFieldNumber = 6;

		// Token: 0x0400A316 RID: 41750
		public const int PreviewStepPbDataFieldNumber = 5;

		// Token: 0x0400A317 RID: 41751
		public const int MonsterStepPbDataFieldNumber = 14;

		// Token: 0x0400A318 RID: 41752
		public const int RewardStepPbDataFieldNumber = 12;

		// Token: 0x0400A319 RID: 41753
		private object stepPbData_;

		// Token: 0x0400A31A RID: 41754
		private TrapDefenseStepUpdateNotify.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x02001A83 RID: 6787
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400D022 RID: 53282
			None,
			// Token: 0x0400D023 RID: 53283
			MapChangeStepPbData = 6,
			// Token: 0x0400D024 RID: 53284
			PreviewStepPbData = 5,
			// Token: 0x0400D025 RID: 53285
			MonsterStepPbData = 14,
			// Token: 0x0400D026 RID: 53286
			RewardStepPbData = 12
		}
	}
}
