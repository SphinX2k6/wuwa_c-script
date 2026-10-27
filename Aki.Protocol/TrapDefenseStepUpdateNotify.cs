using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001452 RID: 5202
	[NetMessage(EMessageId.TrapDefenseStepUpdateNotify)]
	public sealed class TrapDefenseStepUpdateNotify : IMessage<TrapDefenseStepUpdateNotify>, IMessage, IEquatable<TrapDefenseStepUpdateNotify>, IDeepCloneable<TrapDefenseStepUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B8C0 RID: 112832 RVA: 0x003FCB55 File Offset: 0x003FAD55
		[NullableContext(1)]
		public static TrapDefenseStepUpdateNotify Create()
		{
			return new TrapDefenseStepUpdateNotify();
		}

		// Token: 0x17005CE0 RID: 23776
		// (get) Token: 0x0601B8C1 RID: 112833 RVA: 0x003FCB5C File Offset: 0x003FAD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CE1 RID: 23777
		// (get) Token: 0x0601B8C2 RID: 112834 RVA: 0x003FCB5F File Offset: 0x003FAD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseStepUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B8C3 RID: 112835 RVA: 0x003FCB66 File Offset: 0x003FAD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify()
		{
		}

		// Token: 0x0601B8C4 RID: 112836 RVA: 0x003FCB70 File Offset: 0x003FAD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify(TrapDefenseStepUpdateNotify other) : this()
		{
			TrapDefenseStepUpdateNotify.StepPbDataOneofCase stepPbDataCase = other.StepPbDataCase;
			if (stepPbDataCase <= TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
			{
				if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
				{
					if (stepPbDataCase == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
					{
						this.MapChangeStepPbData = other.MapChangeStepPbData.Clone();
					}
				}
				else
				{
					this.RewardStepPbData = other.RewardStepPbData.Clone();
				}
			}
			else if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
			{
				if (stepPbDataCase == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
				{
					this.PreviewStepPbData = other.PreviewStepPbData.Clone();
				}
			}
			else
			{
				this.MonsterStepPbData = other.MonsterStepPbData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8C5 RID: 112837 RVA: 0x003FCBFF File Offset: 0x003FADFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify Clone()
		{
			return new TrapDefenseStepUpdateNotify(this);
		}

		// Token: 0x17005CE2 RID: 23778
		// (get) Token: 0x0601B8C6 RID: 112838 RVA: 0x003FCC07 File Offset: 0x003FAE07
		// (set) Token: 0x0601B8C7 RID: 112839 RVA: 0x003FCC1F File Offset: 0x003FAE1F
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

		// Token: 0x17005CE3 RID: 23779
		// (get) Token: 0x0601B8C8 RID: 112840 RVA: 0x003FCC35 File Offset: 0x003FAE35
		// (set) Token: 0x0601B8C9 RID: 112841 RVA: 0x003FCC4E File Offset: 0x003FAE4E
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

		// Token: 0x17005CE4 RID: 23780
		// (get) Token: 0x0601B8CA RID: 112842 RVA: 0x003FCC65 File Offset: 0x003FAE65
		// (set) Token: 0x0601B8CB RID: 112843 RVA: 0x003FCC7E File Offset: 0x003FAE7E
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

		// Token: 0x17005CE5 RID: 23781
		// (get) Token: 0x0601B8CC RID: 112844 RVA: 0x003FCC95 File Offset: 0x003FAE95
		// (set) Token: 0x0601B8CD RID: 112845 RVA: 0x003FCCAD File Offset: 0x003FAEAD
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

		// Token: 0x17005CE6 RID: 23782
		// (get) Token: 0x0601B8CE RID: 112846 RVA: 0x003FCCC3 File Offset: 0x003FAEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseStepUpdateNotify.StepPbDataOneofCase StepPbDataCase
		{
			get
			{
				return this.stepPbDataCase_;
			}
		}

		// Token: 0x0601B8CF RID: 112847 RVA: 0x003FCCCB File Offset: 0x003FAECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStepPbData()
		{
			this.stepPbDataCase_ = TrapDefenseStepUpdateNotify.StepPbDataOneofCase.None;
			this.stepPbData_ = null;
		}

		// Token: 0x0601B8D0 RID: 112848 RVA: 0x003FCCDB File Offset: 0x003FAEDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseStepUpdateNotify);
		}

		// Token: 0x0601B8D1 RID: 112849 RVA: 0x003FCCEC File Offset: 0x003FAEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseStepUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.MapChangeStepPbData, other.MapChangeStepPbData) && object.Equals(this.PreviewStepPbData, other.PreviewStepPbData) && object.Equals(this.MonsterStepPbData, other.MonsterStepPbData) && object.Equals(this.RewardStepPbData, other.RewardStepPbData) && this.StepPbDataCase == other.StepPbDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8D2 RID: 112850 RVA: 0x003FCD7C File Offset: 0x003FAF7C
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

		// Token: 0x0601B8D3 RID: 112851 RVA: 0x003FCE09 File Offset: 0x003FB009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8D4 RID: 112852 RVA: 0x003FCE16 File Offset: 0x003FB016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8D5 RID: 112853 RVA: 0x003FCE20 File Offset: 0x003FB020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RewardStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MapChangeStepPbData)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.MapChangeStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.MonsterStepPbData);
			}
			if (this.stepPbDataCase_ == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PreviewStepPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B8D6 RID: 112854 RVA: 0x003FCEB8 File Offset: 0x003FB0B8
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

		// Token: 0x0601B8D7 RID: 112855 RVA: 0x003FCF44 File Offset: 0x003FB144
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
				if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.RewardStepPbData)
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
					if (this.RewardStepPbData == null)
					{
						this.RewardStepPbData = new TrapDefenseRewardStepPbData();
					}
					this.RewardStepPbData.MergeFrom(other.RewardStepPbData);
				}
			}
			else if (stepPbDataCase != TrapDefenseStepUpdateNotify.StepPbDataOneofCase.MonsterStepPbData)
			{
				if (stepPbDataCase == TrapDefenseStepUpdateNotify.StepPbDataOneofCase.PreviewStepPbData)
				{
					if (this.PreviewStepPbData == null)
					{
						this.PreviewStepPbData = new TrapDefensePreviewStepPbData();
					}
					this.PreviewStepPbData.MergeFrom(other.PreviewStepPbData);
				}
			}
			else
			{
				if (this.MonsterStepPbData == null)
				{
					this.MonsterStepPbData = new TrapDefenseSpawnMonsterStepPbData();
				}
				this.MonsterStepPbData.MergeFrom(other.MonsterStepPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8D8 RID: 112856 RVA: 0x003FD02C File Offset: 0x003FB22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8D9 RID: 112857 RVA: 0x003FD038 File Offset: 0x003FB238
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
					if (num == 26U)
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
					if (num == 122U)
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009ECD RID: 40653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ECE RID: 40654
		public const int MapChangeStepPbDataFieldNumber = 6;

		// Token: 0x04009ECF RID: 40655
		public const int PreviewStepPbDataFieldNumber = 15;

		// Token: 0x04009ED0 RID: 40656
		public const int MonsterStepPbDataFieldNumber = 14;

		// Token: 0x04009ED1 RID: 40657
		public const int RewardStepPbDataFieldNumber = 3;

		// Token: 0x04009ED2 RID: 40658
		private object stepPbData_;

		// Token: 0x04009ED3 RID: 40659
		private TrapDefenseStepUpdateNotify.StepPbDataOneofCase stepPbDataCase_;

		// Token: 0x020019E1 RID: 6625
		public enum StepPbDataOneofCase
		{
			// Token: 0x0400CAB7 RID: 51895
			None,
			// Token: 0x0400CAB8 RID: 51896
			MapChangeStepPbData = 6,
			// Token: 0x0400CAB9 RID: 51897
			PreviewStepPbData = 15,
			// Token: 0x0400CABA RID: 51898
			MonsterStepPbData = 14,
			// Token: 0x0400CABB RID: 51899
			RewardStepPbData = 3
		}
	}
}
