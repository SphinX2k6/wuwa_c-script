using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02007086 RID: 28806
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelTagComponent : BaseTagComponent
	{
		// Token: 0x17009C1F RID: 39967
		// (get) Token: 0x06046288 RID: 287368 RVA: 0x01186EBC File Offset: 0x011850BC
		// (set) Token: 0x06046289 RID: 287369 RVA: 0x01186EC4 File Offset: 0x011850C4
		public long NotifyLock
		{
			get
			{
				return this.NotifyLockInternal;
			}
			set
			{
				if (value == this.NotifyLockInternal)
				{
					return;
				}
				this.NotifyLockInternal = value;
				if (this.NotifyLockInternal == 0L)
				{
					this.NotifyTagChanged();
				}
			}
		}

		// Token: 0x0604628A RID: 287370 RVA: 0x01186EE8 File Offset: 0x011850E8
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			base.OnInitData(args);
			this.OldCountMap.Clear();
			this.CreatureDataComponent = base.Entity.GetComponent<CreatureDataComponent>();
			if (this.CreatureDataComponent != null)
			{
				this.CreatureDataComponent.GetPbDataId();
				this.CreatureDataComponent.GetCreatureDataId();
				foreach (int tagId in this.CreatureDataComponent.GetEntityCommonTags())
				{
					this.AddServerTagInternal(tagId);
				}
			}
			return true;
		}

		// Token: 0x0604628B RID: 287371 RVA: 0x01186F88 File Offset: 0x01185188
		protected unsafe override bool OnStart()
		{
			base.OnStart();
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			if (component != null && component.IsConcealed)
			{
				this.AddTag(new int?(GameplayTagDefine.EGameplayTagId["物体.表现.隐匿"]));
			}
			List<int> list;
			if (component == null)
			{
				list = null;
			}
			else
			{
				ModelComponent modelComponent = component.GetModelComponent();
				list = ((modelComponent != null) ? modelComponent.PerformanceTags : null);
			}
			List<int> list2 = list;
			if (list2 != null)
			{
				foreach (int num in list2)
				{
					if (!GameplayTagUtils.IsChildTag(num, GameplayTagDefine.EGameplayTagId["关卡.Common.表现"]))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Entity;
						ELogAuthor author = ELogAuthor.ZYL;
						string message = "实体配置了非【关卡.Common.表现】子Tag的客户端模型表现Tag，请检查配置";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
						string item = "pbDataId";
						CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
						ptr = new ValueTuple<string, object>(item, (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
						ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
						string item2 = "creatureDataId";
						CreatureDataComponent creatureDataComponent2 = this.CreatureDataComponent;
						ptr2 = new ValueTuple<string, object>(item2, (creatureDataComponent2 != null) ? new long?(creatureDataComponent2.GetCreatureDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("tagId", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("tagName", GameplayTagUtils.GetNameByTagId(num));
						instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					}
					else
					{
						this.AddTag(new int?(num));
					}
				}
			}
			return true;
		}

		// Token: 0x0604628C RID: 287372 RVA: 0x0118713C File Offset: 0x0118533C
		protected unsafe override void OnTick(float delta)
		{
			if (this.NotifyLock != 0L)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.YZH;
				string message = "Notifylock在Tick结束时不为0";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "pbDataId";
				CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
				ptr = new ValueTuple<string, object>(item, (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LockCount", this.NotifyLock);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.NotifyLock = 0L;
			}
		}

		// Token: 0x0604628D RID: 287373 RVA: 0x011871DC File Offset: 0x011853DC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] GetTagNames()
		{
			if (!GlobalData.IsPlayInEditor)
			{
				return null;
			}
			List<string> list = new List<string>();
			foreach (int tagId in this.GetTagIds())
			{
				string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
				if (nameByTagId != null && !list.Contains(nameByTagId))
				{
					list.Add(nameByTagId);
				}
			}
			return list.ToArray();
		}

		// Token: 0x0604628E RID: 287374 RVA: 0x01187250 File Offset: 0x01185450
		public bool ContainsTag(FGameplayTag tag)
		{
			int num = tag.TagId();
			return num != 0 && this.HasTag(num);
		}

		// Token: 0x0604628F RID: 287375 RVA: 0x01187270 File Offset: 0x01185470
		public bool ContainsTagByName(string tagName)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
			return tagIdByName != 0 && this.HasTag(tagIdByName);
		}

		// Token: 0x06046290 RID: 287376 RVA: 0x01187290 File Offset: 0x01185490
		public override void AddTag(int? tagId)
		{
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			base.AddTag(tagId);
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x06046291 RID: 287377 RVA: 0x011872C8 File Offset: 0x011854C8
		public override bool RemoveTag(int? tagId)
		{
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			bool result = base.RemoveTag(tagId);
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
			return result;
		}

		// Token: 0x06046292 RID: 287378 RVA: 0x01187300 File Offset: 0x01185500
		public void ChangeLocalLevelTag(int tagAdd, int tagRemove)
		{
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			this.RemoveTag(new int?(tagRemove));
			this.AddTag(new int?(tagAdd));
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x06046293 RID: 287379 RVA: 0x01187348 File Offset: 0x01185548
		private void AddServerTagInternal(int tagId)
		{
			if (this.HasTag(tagId))
			{
				return;
			}
			if (GameplayTagUtils.GetNameByTagId(tagId) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Entity;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "要添加的tagId找不到对应的gameplayTag";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagId", tagId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			this.TagContainer.AddExactTag(ETagChannel.LevelServer, tagId);
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x06046294 RID: 287380 RVA: 0x011873C4 File Offset: 0x011855C4
		private void RemoveServerTagInternal(int tagId)
		{
			if (this.TagContainer.GetRawTagCount(ETagChannel.LevelServer, tagId) <= 0)
			{
				return;
			}
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			this.TagContainer.RemoveExactTag(ETagChannel.LevelServer, tagId);
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x06046295 RID: 287381 RVA: 0x01187414 File Offset: 0x01185614
		public void SyncTagsFromServer(IList<CommonTagData> tags)
		{
			foreach (CommonTagData commonTagData in tags)
			{
				int tagId = commonTagData.TagId;
				if (!commonTagData.IsAdd)
				{
					this.RemoveServerTagInternal(tagId);
				}
				else
				{
					this.AddServerTagInternal(tagId);
				}
			}
		}

		// Token: 0x06046296 RID: 287382 RVA: 0x01187474 File Offset: 0x01185674
		public void AddServerTagByIdLocal(int tagId, string reason)
		{
			this.AddServerTagInternal(tagId);
		}

		// Token: 0x06046297 RID: 287383 RVA: 0x0118747D File Offset: 0x0118567D
		public void RemoveServerTagByIdLocal(int tagId, string reason)
		{
			this.RemoveServerTagInternal(tagId);
		}

		// Token: 0x06046298 RID: 287384 RVA: 0x01187488 File Offset: 0x01185688
		public void NotifyTagChanged()
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			foreach (int num in this.OldCountMap.Keys)
			{
				int num2 = this.OldCountMap[num];
				int tagCount = base.GetTagCount(num);
				if (num2 > 0 && tagCount <= 0)
				{
					list2.Add(num);
				}
				else if (num2 <= 0 && tagCount > 0)
				{
					list.Add(num);
				}
			}
			this.OldCountMap.Clear();
			bool flag = false;
			if (list.Count > 0)
			{
				foreach (int tagId in list)
				{
					if (this.IsTagShouldNotify(tagId))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag && list2.Count > 0)
			{
				foreach (int tagId2 in list2)
				{
					if (this.IsTagShouldNotify(tagId2))
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				EventSystem.Instance.EmitWithTarget<IReadOnlyList<int>, IReadOnlyList<int>>(base.Entity, EEventName.OnLevelTagChanged, list, list2);
			}
		}

		// Token: 0x06046299 RID: 287385 RVA: 0x011875F0 File Offset: 0x011857F0
		public IEnumerable<int> GetTagIds()
		{
			LevelTagComponent.<GetTagIds>d__22 <GetTagIds>d__ = new LevelTagComponent.<GetTagIds>d__22(-2);
			<GetTagIds>d__.<>4__this = this;
			return <GetTagIds>d__;
		}

		// Token: 0x0604629A RID: 287386 RVA: 0x01187600 File Offset: 0x01185800
		protected override void OnAnyTagChanged(int tagId, int newCount, int oldCount, int exactTagId)
		{
			if (tagId == 0 || oldCount == newCount)
			{
				return;
			}
			base.OnAnyTagChanged(tagId, newCount, oldCount, exactTagId);
			if (!this.OldCountMap.ContainsKey(tagId))
			{
				this.OldCountMap[tagId] = oldCount;
			}
		}

		// Token: 0x0604629B RID: 287387 RVA: 0x01187630 File Offset: 0x01185830
		private bool IsTagShouldNotify(int tagId)
		{
			foreach (int tagB in LevelTagComponent.shouldNotifyTagType)
			{
				if (GameplayTagUtils.IsChildTag(tagId, tagB))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604629C RID: 287388 RVA: 0x01187664 File Offset: 0x01185864
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			LevelTagComponent levelTagComponent = (LevelTagComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComponent"))
			{
				if (levelTagComponent.CreatureDataComponent == null)
				{
					this.CreatureDataComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComponent), "CreatureDataComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OldCountMap") && levelTagComponent.OldCountMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, int>>(this.OldCountMap), "OldCountMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("NotifyLockInternal"))
			{
				this.NotifyLockInternal = levelTagComponent.NotifyLockInternal;
			}
			return true;
		}

		// Token: 0x04024C09 RID: 150537
		[StaticVariableRuleIgnore]
		public static readonly int[] shouldNotifyTagType = new int[]
		{
			GameplayTagDefine.EGameplayTagId["物体"],
			GameplayTagDefine.EGameplayTagId["关卡"]
		};

		// Token: 0x04024C0A RID: 150538
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x04024C0B RID: 150539
		private readonly Dictionary<int, int> OldCountMap = new Dictionary<int, int>();

		// Token: 0x04024C0C RID: 150540
		private long NotifyLockInternal;
	}
}
