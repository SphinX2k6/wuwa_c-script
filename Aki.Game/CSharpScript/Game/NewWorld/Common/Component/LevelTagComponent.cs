using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006207 RID: 25095
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelTagComponent : BaseTagComponent
	{
		// Token: 0x170071C9 RID: 29129
		// (get) Token: 0x0603C4A7 RID: 246951 RVA: 0x011303FC File Offset: 0x0112E5FC
		// (set) Token: 0x0603C4A8 RID: 246952 RVA: 0x01130404 File Offset: 0x0112E604
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

		// Token: 0x0603C4A9 RID: 246953 RVA: 0x01130428 File Offset: 0x0112E628
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

		// Token: 0x0603C4AA RID: 246954 RVA: 0x011304C8 File Offset: 0x0112E6C8
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

		// Token: 0x0603C4AB RID: 246955 RVA: 0x0113067C File Offset: 0x0112E87C
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

		// Token: 0x0603C4AC RID: 246956 RVA: 0x0113071C File Offset: 0x0112E91C
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

		// Token: 0x0603C4AD RID: 246957 RVA: 0x01130790 File Offset: 0x0112E990
		public bool ContainsTag(FGameplayTag tag)
		{
			int num = tag.TagId();
			return num != 0 && this.HasTag(num);
		}

		// Token: 0x0603C4AE RID: 246958 RVA: 0x011307B0 File Offset: 0x0112E9B0
		public bool ContainsTagByName(string tagName)
		{
			int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
			return tagIdByName != 0 && this.HasTag(tagIdByName);
		}

		// Token: 0x0603C4AF RID: 246959 RVA: 0x011307D0 File Offset: 0x0112E9D0
		public override void AddTag(int? tagId)
		{
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			base.AddTag(tagId);
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x0603C4B0 RID: 246960 RVA: 0x01130808 File Offset: 0x0112EA08
		public override bool RemoveTag(int? tagId)
		{
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			bool result = base.RemoveTag(tagId);
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
			return result;
		}

		// Token: 0x0603C4B1 RID: 246961 RVA: 0x01130840 File Offset: 0x0112EA40
		public void ChangeLocalLevelTag(int tagAdd, int tagRemove)
		{
			long notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock + 1L;
			this.RemoveTag(new int?(tagRemove));
			this.AddTag(new int?(tagAdd));
			notifyLock = this.NotifyLock;
			this.NotifyLock = notifyLock - 1L;
		}

		// Token: 0x0603C4B2 RID: 246962 RVA: 0x01130888 File Offset: 0x0112EA88
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

		// Token: 0x0603C4B3 RID: 246963 RVA: 0x01130904 File Offset: 0x0112EB04
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

		// Token: 0x0603C4B4 RID: 246964 RVA: 0x01130954 File Offset: 0x0112EB54
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

		// Token: 0x0603C4B5 RID: 246965 RVA: 0x011309B4 File Offset: 0x0112EBB4
		public void AddServerTagByIdLocal(int tagId, string reason)
		{
			this.AddServerTagInternal(tagId);
		}

		// Token: 0x0603C4B6 RID: 246966 RVA: 0x011309BD File Offset: 0x0112EBBD
		public void RemoveServerTagByIdLocal(int tagId, string reason)
		{
			this.RemoveServerTagInternal(tagId);
		}

		// Token: 0x0603C4B7 RID: 246967 RVA: 0x011309C8 File Offset: 0x0112EBC8
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

		// Token: 0x0603C4B8 RID: 246968 RVA: 0x01130B30 File Offset: 0x0112ED30
		public IEnumerable<int> GetTagIds()
		{
			LevelTagComponent.<GetTagIds>d__22 <GetTagIds>d__ = new LevelTagComponent.<GetTagIds>d__22(-2);
			<GetTagIds>d__.<>4__this = this;
			return <GetTagIds>d__;
		}

		// Token: 0x0603C4B9 RID: 246969 RVA: 0x01130B40 File Offset: 0x0112ED40
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

		// Token: 0x0603C4BA RID: 246970 RVA: 0x01130B70 File Offset: 0x0112ED70
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

		// Token: 0x0603C4BB RID: 246971 RVA: 0x01130BA4 File Offset: 0x0112EDA4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			LevelTagComponent levelTagComponent = (LevelTagComponent)componentTemplate;
			if (levelTagComponent.CreatureDataComponent == null)
			{
				this.CreatureDataComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComponent), "CreatureDataComponent"))
			{
				return false;
			}
			if (levelTagComponent.OldCountMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.OldCountMap), "OldCountMap"))
			{
				return false;
			}
			this.NotifyLockInternal = levelTagComponent.NotifyLockInternal;
			return true;
		}

		// Token: 0x170071CA RID: 29130
		// (get) Token: 0x0603C4BC RID: 246972 RVA: 0x01130C1D File Offset: 0x0112EE1D
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071CB RID: 29131
		// (get) Token: 0x0603C4BD RID: 246973 RVA: 0x01130C20 File Offset: 0x0112EE20
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071CC RID: 29132
		// (get) Token: 0x0603C4BE RID: 246974 RVA: 0x01130C23 File Offset: 0x0112EE23
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071CD RID: 29133
		// (get) Token: 0x0603C4BF RID: 246975 RVA: 0x01130C26 File Offset: 0x0112EE26
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEC4 RID: 130756
		[StaticVariableRuleIgnore]
		public static readonly int[] shouldNotifyTagType = new int[]
		{
			GameplayTagDefine.EGameplayTagId["物体"],
			GameplayTagDefine.EGameplayTagId["关卡"]
		};

		// Token: 0x0401FEC5 RID: 130757
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x0401FEC6 RID: 130758
		private readonly Dictionary<int, int> OldCountMap = new Dictionary<int, int>();

		// Token: 0x0401FEC7 RID: 130759
		private long NotifyLockInternal;
	}
}
