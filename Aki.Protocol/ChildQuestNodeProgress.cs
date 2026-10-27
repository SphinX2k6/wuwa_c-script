using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028B RID: 651
	public sealed class ChildQuestNodeProgress : IMessage<ChildQuestNodeProgress>, IMessage, IEquatable<ChildQuestNodeProgress>, IDeepCloneable<ChildQuestNodeProgress>, IBufferMessage
	{
		// Token: 0x060043E8 RID: 17384 RVA: 0x000A636A File Offset: 0x000A456A
		[NullableContext(1)]
		public static ChildQuestNodeProgress Create()
		{
			return new ChildQuestNodeProgress();
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x000A6371 File Offset: 0x000A4571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060043EA RID: 17386 RVA: 0x000A6374 File Offset: 0x000A4574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeProgress.Descriptor;
			}
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x000A637B File Offset: 0x000A457B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress()
		{
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x000A6384 File Offset: 0x000A4584
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

		// Token: 0x060043ED RID: 17389 RVA: 0x000A6487 File Offset: 0x000A4687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress Clone()
		{
			return new ChildQuestNodeProgress(this);
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060043EE RID: 17390 RVA: 0x000A648F File Offset: 0x000A468F
		// (set) Token: 0x060043EF RID: 17391 RVA: 0x000A64A7 File Offset: 0x000A46A7
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

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060043F0 RID: 17392 RVA: 0x000A64BD File Offset: 0x000A46BD
		// (set) Token: 0x060043F1 RID: 17393 RVA: 0x000A64D5 File Offset: 0x000A46D5
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

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x000A64EB File Offset: 0x000A46EB
		// (set) Token: 0x060043F3 RID: 17395 RVA: 0x000A6503 File Offset: 0x000A4703
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

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060043F4 RID: 17396 RVA: 0x000A6519 File Offset: 0x000A4719
		// (set) Token: 0x060043F5 RID: 17397 RVA: 0x000A6531 File Offset: 0x000A4731
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

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060043F6 RID: 17398 RVA: 0x000A6547 File Offset: 0x000A4747
		// (set) Token: 0x060043F7 RID: 17399 RVA: 0x000A655E File Offset: 0x000A475E
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

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060043F8 RID: 17400 RVA: 0x000A6573 File Offset: 0x000A4773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasLevelPlayCount
		{
			get
			{
				return this.progressCase_ == ChildQuestNodeProgress.ProgressOneofCase.LevelPlayCount;
			}
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x000A657E File Offset: 0x000A477E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearLevelPlayCount()
		{
			if (this.HasLevelPlayCount)
			{
				this.ClearProgress();
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060043FA RID: 17402 RVA: 0x000A658E File Offset: 0x000A478E
		// (set) Token: 0x060043FB RID: 17403 RVA: 0x000A65A6 File Offset: 0x000A47A6
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

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060043FC RID: 17404 RVA: 0x000A65BC File Offset: 0x000A47BC
		// (set) Token: 0x060043FD RID: 17405 RVA: 0x000A65D4 File Offset: 0x000A47D4
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

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x000A65EA File Offset: 0x000A47EA
		// (set) Token: 0x060043FF RID: 17407 RVA: 0x000A6602 File Offset: 0x000A4802
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

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x000A6618 File Offset: 0x000A4818
		// (set) Token: 0x06004401 RID: 17409 RVA: 0x000A6631 File Offset: 0x000A4831
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

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x000A6648 File Offset: 0x000A4848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeProgress.ProgressOneofCase ProgressCase
		{
			get
			{
				return this.progressCase_;
			}
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x000A6650 File Offset: 0x000A4850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearProgress()
		{
			this.progressCase_ = ChildQuestNodeProgress.ProgressOneofCase.None;
			this.progress_ = null;
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x000A6660 File Offset: 0x000A4860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeProgress);
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x000A6670 File Offset: 0x000A4870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeProgress other)
		{
			return other != null && (other == this || (object.Equals(this.Kill, other.Kill) && object.Equals(this.GetItem, other.GetItem) && object.Equals(this.MonsterCreator, other.MonsterCreator) && object.Equals(this.UseItem, other.UseItem) && this.LevelPlayCount == other.LevelPlayCount && object.Equals(this.Interact, other.Interact) && object.Equals(this.CompleteInst, other.CompleteInst) && object.Equals(this.EntityStateList, other.EntityStateList) && object.Equals(this.GpuMonster, other.GpuMonster) && this.ProgressCase == other.ProgressCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x000A6764 File Offset: 0x000A4964
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

		// Token: 0x06004407 RID: 17415 RVA: 0x000A6865 File Offset: 0x000A4A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x000A6872 File Offset: 0x000A4A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x000A687C File Offset: 0x000A4A7C
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

		// Token: 0x0600440A RID: 17418 RVA: 0x000A69A4 File Offset: 0x000A4BA4
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

		// Token: 0x0600440B RID: 17419 RVA: 0x000A6AAC File Offset: 0x000A4CAC
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

		// Token: 0x0600440C RID: 17420 RVA: 0x000A6C57 File Offset: 0x000A4E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x000A6C60 File Offset: 0x000A4E60
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

		// Token: 0x04002E6A RID: 11882
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E6B RID: 11883
		public const int KillFieldNumber = 1;

		// Token: 0x04002E6C RID: 11884
		public const int GetItemFieldNumber = 2;

		// Token: 0x04002E6D RID: 11885
		public const int MonsterCreatorFieldNumber = 3;

		// Token: 0x04002E6E RID: 11886
		public const int UseItemFieldNumber = 4;

		// Token: 0x04002E6F RID: 11887
		public const int LevelPlayCountFieldNumber = 5;

		// Token: 0x04002E70 RID: 11888
		public const int InteractFieldNumber = 6;

		// Token: 0x04002E71 RID: 11889
		public const int CompleteInstFieldNumber = 7;

		// Token: 0x04002E72 RID: 11890
		public const int EntityStateListFieldNumber = 8;

		// Token: 0x04002E73 RID: 11891
		public const int GpuMonsterFieldNumber = 9;

		// Token: 0x04002E74 RID: 11892
		private object progress_;

		// Token: 0x04002E75 RID: 11893
		private ChildQuestNodeProgress.ProgressOneofCase progressCase_;

		// Token: 0x02001713 RID: 5907
		public enum ProgressOneofCase
		{
			// Token: 0x0400C563 RID: 50531
			None,
			// Token: 0x0400C564 RID: 50532
			Kill,
			// Token: 0x0400C565 RID: 50533
			GetItem,
			// Token: 0x0400C566 RID: 50534
			MonsterCreator,
			// Token: 0x0400C567 RID: 50535
			UseItem,
			// Token: 0x0400C568 RID: 50536
			LevelPlayCount,
			// Token: 0x0400C569 RID: 50537
			Interact,
			// Token: 0x0400C56A RID: 50538
			CompleteInst,
			// Token: 0x0400C56B RID: 50539
			EntityStateList,
			// Token: 0x0400C56C RID: 50540
			GpuMonster
		}
	}
}
