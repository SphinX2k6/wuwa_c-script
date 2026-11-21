using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000290 RID: 656
	public sealed class ChildQuestNodeProgress : IMessage<ChildQuestNodeProgress>, IMessage, IEquatable<ChildQuestNodeProgress>, IDeepCloneable<ChildQuestNodeProgress>, IBufferMessage
	{
		// Token: 0x0600448F RID: 17551 RVA: 0x000A8032 File Offset: 0x000A6232
		[NullableContext(1)]
		public static ChildQuestNodeProgress Create()
		{
			return new ChildQuestNodeProgress();
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x000A8039 File Offset: 0x000A6239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x000A803C File Offset: 0x000A623C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeProgress.Descriptor;
			}
		}

		// Token: 0x06004492 RID: 17554 RVA: 0x000A8043 File Offset: 0x000A6243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress()
		{
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x000A804C File Offset: 0x000A624C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress(ChildQuestNodeProgress other) : this()
		{
			switch (other.ProgressCase)
			{
			case ChildQuestNodeProgress.ProgressOneofCase.Kill:
				this.Kill = other.Kill.Clone();
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.GetItem:
				this.GetItem = other.GetItem.Clone();
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator:
				this.MonsterCreator = other.MonsterCreator.Clone();
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.UseItem:
				this.UseItem = other.UseItem.Clone();
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.LevelPlayCount:
				this.LevelPlayCount = other.LevelPlayCount;
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.Interact:
				this.Interact = other.Interact.Clone();
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.CompleteInst:
				this.CompleteInst = other.CompleteInst.Clone();
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.EntityStateList:
				this.EntityStateList = other.EntityStateList.Clone();
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.GpuMonster:
				this.GpuMonster = other.GpuMonster.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x000A814F File Offset: 0x000A634F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress Clone()
		{
			return new ChildQuestNodeProgress(this);
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x000A8157 File Offset: 0x000A6357
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x000A816F File Offset: 0x000A636F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillProgress Kill
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.Kill)
				{
					return null;
				}
				return (KillProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.Kill);
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x000A8185 File Offset: 0x000A6385
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x000A819D File Offset: 0x000A639D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetItemProgress GetItem
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.GetItem)
				{
					return null;
				}
				return (GetItemProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.GetItem);
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x000A81B3 File Offset: 0x000A63B3
		// (set) Token: 0x0600449A RID: 17562 RVA: 0x000A81CB File Offset: 0x000A63CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCreatorProgress MonsterCreator
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator)
				{
					return null;
				}
				return (MonsterCreatorProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator);
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x000A81E1 File Offset: 0x000A63E1
		// (set) Token: 0x0600449C RID: 17564 RVA: 0x000A81F9 File Offset: 0x000A63F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseItemProgress UseItem
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.UseItem)
				{
					return null;
				}
				return (UseItemProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.UseItem);
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x000A820F File Offset: 0x000A640F
		// (set) Token: 0x0600449E RID: 17566 RVA: 0x000A8226 File Offset: 0x000A6426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelPlayCount
		{
			get
			{
				if (!this.HasLevelPlayCount)
				{
					return 0;
				}
				return (int)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ChildQuestNodeProgress.ProgressOneofCase.LevelPlayCount;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x000A823B File Offset: 0x000A643B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLevelPlayCount
		{
			get
			{
				return this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.LevelPlayCount;
			}
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x000A8246 File Offset: 0x000A6446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLevelPlayCount()
		{
			if (this.HasLevelPlayCount)
			{
				this.ClearProgress();
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x000A8256 File Offset: 0x000A6456
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x000A826E File Offset: 0x000A646E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractProgress Interact
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.Interact)
				{
					return null;
				}
				return (InteractProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.Interact);
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x000A8284 File Offset: 0x000A6484
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x000A829C File Offset: 0x000A649C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteInstProgress CompleteInst
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.CompleteInst)
				{
					return null;
				}
				return (CompleteInstProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.CompleteInst);
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x000A82B2 File Offset: 0x000A64B2
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x000A82CA File Offset: 0x000A64CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStateProgress EntityStateList
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.EntityStateList)
				{
					return null;
				}
				return (EntityStateProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.EntityStateList);
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x000A82E0 File Offset: 0x000A64E0
		// (set) Token: 0x060044A8 RID: 17576 RVA: 0x000A82F9 File Offset: 0x000A64F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterProgress GpuMonster
		{
			get
			{
				if (this.progressCase_ != ChildQuestNodeProgress.ProgressOneofCase.GpuMonster)
				{
					return null;
				}
				return (GpuMonsterProgress)this.progress_;
			}
			set
			{
				this.progress_ = value;
				this.progressCase_ = ((value == null) ? ChildQuestNodeProgress.ProgressOneofCase.None : ChildQuestNodeProgress.ProgressOneofCase.GpuMonster);
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x000A8310 File Offset: 0x000A6510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress.ProgressOneofCase ProgressCase
		{
			get
			{
				return this.progressCase_;
			}
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x000A8318 File Offset: 0x000A6518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProgress()
		{
			this.progressCase_ = ChildQuestNodeProgress.ProgressOneofCase.None;
			this.progress_ = null;
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x000A8328 File Offset: 0x000A6528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeProgress);
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x000A8338 File Offset: 0x000A6538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeProgress other)
		{
			return other != null && (other == this || (object.Equals(this.Kill, other.Kill) && object.Equals(this.GetItem, other.GetItem) && object.Equals(this.MonsterCreator, other.MonsterCreator) && object.Equals(this.UseItem, other.UseItem) && this.LevelPlayCount == other.LevelPlayCount && object.Equals(this.Interact, other.Interact) && object.Equals(this.CompleteInst, other.CompleteInst) && object.Equals(this.EntityStateList, other.EntityStateList) && object.Equals(this.GpuMonster, other.GpuMonster) && this.ProgressCase == other.ProgressCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x000A842C File Offset: 0x000A662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Kill)
			{
				num ^= this.Kill.GetHashCode();
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GetItem)
			{
				num ^= this.GetItem.GetHashCode();
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator)
			{
				num ^= this.MonsterCreator.GetHashCode();
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.UseItem)
			{
				num ^= this.UseItem.GetHashCode();
			}
			if (this.HasLevelPlayCount)
			{
				num ^= this.LevelPlayCount.GetHashCode();
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Interact)
			{
				num ^= this.Interact.GetHashCode();
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.CompleteInst)
			{
				num ^= this.CompleteInst.GetHashCode();
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.EntityStateList)
			{
				num ^= this.EntityStateList.GetHashCode();
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GpuMonster)
			{
				num ^= this.GpuMonster.GetHashCode();
			}
			num ^= (int)this.progressCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060044AE RID: 17582 RVA: 0x000A852D File Offset: 0x000A672D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x000A853A File Offset: 0x000A673A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x000A8544 File Offset: 0x000A6744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Kill)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Kill);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GetItem)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GetItem);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MonsterCreator);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.UseItem)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.UseItem);
			}
			if (this.HasLevelPlayCount)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LevelPlayCount);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Interact)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Interact);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.CompleteInst)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CompleteInst);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.EntityStateList)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.EntityStateList);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GpuMonster)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.GpuMonster);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x000A866C File Offset: 0x000A686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Kill)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Kill);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GetItem)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GetItem);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonsterCreator);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.UseItem)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseItem);
			}
			if (this.HasLevelPlayCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelPlayCount);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Interact)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Interact);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.CompleteInst)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CompleteInst);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.EntityStateList)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityStateList);
			}
			if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GpuMonster)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GpuMonster);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x000A8774 File Offset: 0x000A6974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChildQuestNodeProgress other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.ProgressCase)
			{
			case ChildQuestNodeProgress.ProgressOneofCase.Kill:
				if (this.Kill == null)
				{
					this.Kill = new KillProgress();
				}
				this.Kill.MergeFrom(other.Kill);
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.GetItem:
				if (this.GetItem == null)
				{
					this.GetItem = new GetItemProgress();
				}
				this.GetItem.MergeFrom(other.GetItem);
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator:
				if (this.MonsterCreator == null)
				{
					this.MonsterCreator = new MonsterCreatorProgress();
				}
				this.MonsterCreator.MergeFrom(other.MonsterCreator);
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.UseItem:
				if (this.UseItem == null)
				{
					this.UseItem = new UseItemProgress();
				}
				this.UseItem.MergeFrom(other.UseItem);
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.LevelPlayCount:
				this.LevelPlayCount = other.LevelPlayCount;
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.Interact:
				if (this.Interact == null)
				{
					this.Interact = new InteractProgress();
				}
				this.Interact.MergeFrom(other.Interact);
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.CompleteInst:
				if (this.CompleteInst == null)
				{
					this.CompleteInst = new CompleteInstProgress();
				}
				this.CompleteInst.MergeFrom(other.CompleteInst);
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.EntityStateList:
				if (this.EntityStateList == null)
				{
					this.EntityStateList = new EntityStateProgress();
				}
				this.EntityStateList.MergeFrom(other.EntityStateList);
				break;
			case ChildQuestNodeProgress.ProgressOneofCase.GpuMonster:
				if (this.GpuMonster == null)
				{
					this.GpuMonster = new GpuMonsterProgress();
				}
				this.GpuMonster.MergeFrom(other.GpuMonster);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x000A891F File Offset: 0x000A6B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x000A8928 File Offset: 0x000A6B28
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
				if (num <= 34U)
				{
					if (num <= 18U)
					{
						if (num == 10U)
						{
							KillProgress killProgress = new KillProgress();
							if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Kill)
							{
								killProgress.MergeFrom(this.Kill);
							}
							input.ReadMessage(killProgress);
							this.Kill = killProgress;
							continue;
						}
						if (num == 18U)
						{
							GetItemProgress getItemProgress = new GetItemProgress();
							if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GetItem)
							{
								getItemProgress.MergeFrom(this.GetItem);
							}
							input.ReadMessage(getItemProgress);
							this.GetItem = getItemProgress;
							continue;
						}
					}
					else
					{
						if (num == 26U)
						{
							MonsterCreatorProgress monsterCreatorProgress = new MonsterCreatorProgress();
							if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.MonsterCreator)
							{
								monsterCreatorProgress.MergeFrom(this.MonsterCreator);
							}
							input.ReadMessage(monsterCreatorProgress);
							this.MonsterCreator = monsterCreatorProgress;
							continue;
						}
						if (num == 34U)
						{
							UseItemProgress useItemProgress = new UseItemProgress();
							if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.UseItem)
							{
								useItemProgress.MergeFrom(this.UseItem);
							}
							input.ReadMessage(useItemProgress);
							this.UseItem = useItemProgress;
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 40U)
					{
						this.LevelPlayCount = input.ReadInt32();
						continue;
					}
					if (num == 50U)
					{
						InteractProgress interactProgress = new InteractProgress();
						if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.Interact)
						{
							interactProgress.MergeFrom(this.Interact);
						}
						input.ReadMessage(interactProgress);
						this.Interact = interactProgress;
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						CompleteInstProgress completeInstProgress = new CompleteInstProgress();
						if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.CompleteInst)
						{
							completeInstProgress.MergeFrom(this.CompleteInst);
						}
						input.ReadMessage(completeInstProgress);
						this.CompleteInst = completeInstProgress;
						continue;
					}
					if (num == 66U)
					{
						EntityStateProgress entityStateProgress = new EntityStateProgress();
						if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.EntityStateList)
						{
							entityStateProgress.MergeFrom(this.EntityStateList);
						}
						input.ReadMessage(entityStateProgress);
						this.EntityStateList = entityStateProgress;
						continue;
					}
					if (num == 74U)
					{
						GpuMonsterProgress gpuMonsterProgress = new GpuMonsterProgress();
						if (this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.GpuMonster)
						{
							gpuMonsterProgress.MergeFrom(this.GpuMonster);
						}
						input.ReadMessage(gpuMonsterProgress);
						this.GpuMonster = gpuMonsterProgress;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002EEE RID: 12014
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EEF RID: 12015
		public const int KillFieldNumber = 1;

		// Token: 0x04002EF0 RID: 12016
		public const int GetItemFieldNumber = 2;

		// Token: 0x04002EF1 RID: 12017
		public const int MonsterCreatorFieldNumber = 3;

		// Token: 0x04002EF2 RID: 12018
		public const int UseItemFieldNumber = 4;

		// Token: 0x04002EF3 RID: 12019
		public const int LevelPlayCountFieldNumber = 5;

		// Token: 0x04002EF4 RID: 12020
		public const int InteractFieldNumber = 6;

		// Token: 0x04002EF5 RID: 12021
		public const int CompleteInstFieldNumber = 7;

		// Token: 0x04002EF6 RID: 12022
		public const int EntityStateListFieldNumber = 8;

		// Token: 0x04002EF7 RID: 12023
		public const int GpuMonsterFieldNumber = 9;

		// Token: 0x04002EF8 RID: 12024
		private object progress_;

		// Token: 0x04002EF9 RID: 12025
		private ChildQuestNodeProgress.ProgressOneofCase progressCase_;

		// Token: 0x02001790 RID: 6032
		public enum ProgressOneofCase
		{
			// Token: 0x0400CA98 RID: 51864
			None,
			// Token: 0x0400CA99 RID: 51865
			Kill,
			// Token: 0x0400CA9A RID: 51866
			GetItem,
			// Token: 0x0400CA9B RID: 51867
			MonsterCreator,
			// Token: 0x0400CA9C RID: 51868
			UseItem,
			// Token: 0x0400CA9D RID: 51869
			LevelPlayCount,
			// Token: 0x0400CA9E RID: 51870
			Interact,
			// Token: 0x0400CA9F RID: 51871
			CompleteInst,
			// Token: 0x0400CAA0 RID: 51872
			EntityStateList,
			// Token: 0x0400CAA1 RID: 51873
			GpuMonster
		}
	}
}
