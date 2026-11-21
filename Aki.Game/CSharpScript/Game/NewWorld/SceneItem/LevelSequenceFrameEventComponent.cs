using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200621C RID: 25116
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelSequenceFrameEventComponent : EntityComponent
	{
		// Token: 0x0603C62E RID: 247342 RVA: 0x0113AF88 File Offset: 0x01139188
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			CreateEntityData p = args.GetP1<CreateEntityData>();
			LevelSequenceFrameEventComponent config = p.GetParam<LevelSequenceFrameEventComponent>() as LevelSequenceFrameEventComponent;
			this.Config = config;
			this.CreatureDataId = p.CreatureDataId;
			this.PbDataId = (long)p.PbDataId;
			List<ILevelSequenceSectionInfo> list = new List<ILevelSequenceSectionInfo>(this.Config.ForwardSections);
			list.Sort((ILevelSequenceSectionInfo a, ILevelSequenceSectionInfo b) => a.FrameId - b.FrameId);
			List<ILevelSequenceSectionInfo> list2 = new List<ILevelSequenceSectionInfo>(this.Config.BackWardSections);
			list2.Sort((ILevelSequenceSectionInfo a, ILevelSequenceSectionInfo b) => b.FrameId - a.FrameId);
			foreach (ValueTuple<List<ILevelSequenceSectionInfo>, Dictionary<string, int>> valueTuple in new List<ValueTuple<List<ILevelSequenceSectionInfo>, Dictionary<string, int>>>
			{
				new ValueTuple<List<ILevelSequenceSectionInfo>, Dictionary<string, int>>(list, this.MarkIndexMapFront),
				new ValueTuple<List<ILevelSequenceSectionInfo>, Dictionary<string, int>>(list2, this.MarkIndexMapBack)
			})
			{
				List<ILevelSequenceSectionInfo> item = valueTuple.Item1;
				Dictionary<string, int> item2 = valueTuple.Item2;
				foreach (ILevelSequenceSectionInfo levelSequenceSectionInfo in item)
				{
					if (levelSequenceSectionInfo.Type == ELevelSequenceSectionType.EventMark)
					{
						if (this.FrameMap.ContainsKey(levelSequenceSectionInfo.Key))
						{
							Log.Instance.Error(ELogModule.Entity, ELogAuthor.FZX, "[SceneItemReference][EventComp] 场景引用实体帧事件组件key重复", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
						else
						{
							this.FrameMap[levelSequenceSectionInfo.Key] = levelSequenceSectionInfo;
						}
					}
					else if (levelSequenceSectionInfo.Type == ELevelSequenceSectionType.Mark)
					{
						if (item2.ContainsKey(levelSequenceSectionInfo.Key))
						{
							Log.Instance.Error(ELogModule.Entity, ELogAuthor.FZX, "[SceneItemReference][EventComp] 场景引用实体帧事件组件key重复", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
						else
						{
							item2[levelSequenceSectionInfo.Key] = item.IndexOf(levelSequenceSectionInfo);
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0603C62F RID: 247343 RVA: 0x0113B190 File Offset: 0x01139390
		protected override bool OnClear()
		{
			this.Config = null;
			this.FrameMap.Clear();
			return true;
		}

		// Token: 0x0603C630 RID: 247344 RVA: 0x0113B1A8 File Offset: 0x011393A8
		public unsafe void ExecuteEvent(string key)
		{
			ILevelSequenceSectionInfo levelSequenceSectionInfo;
			this.FrameMap.TryGetValue(key, out levelSequenceSectionInfo);
			if (levelSequenceSectionInfo == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[SceneItemReference][EventComp] 找不到key";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("id", this.PbDataId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			ILevelSequenceSectionInfo levelSequenceSectionInfo2;
			if (this.EventPendingList.Count <= 0)
			{
				levelSequenceSectionInfo2 = null;
			}
			else
			{
				List<ILevelSequenceSectionInfo> eventPendingList = this.EventPendingList;
				levelSequenceSectionInfo2 = eventPendingList[eventPendingList.Count - 1];
			}
			ILevelSequenceSectionInfo levelSequenceSectionInfo3 = levelSequenceSectionInfo2;
			if (this.EventPendingList.Count > 0)
			{
				this.EventPendingList.RemoveAt(this.EventPendingList.Count - 1);
			}
			if (levelSequenceSectionInfo3 == null || levelSequenceSectionInfo3.Key != key)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelPlay;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "[SceneItemReference][EventComp] 帧事件执行顺序有错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("id", this.PbDataId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			}
			if (levelSequenceSectionInfo.ActionList != null)
			{
				EntityContext entityContext = EntityContext.Create(base.Entity.Id, null);
				entityContext.ClientExecuteActions = true;
				entityContext.SequencePath = this.CurrentSequencePath;
				LevelGeneralController.Instance.ExecuteActionsNew(levelSequenceSectionInfo.ActionList, entityContext, null);
				this.RequestAction(key);
			}
		}

		// Token: 0x0603C631 RID: 247345 RVA: 0x0113B334 File Offset: 0x01139534
		public void OnSequencePlayToMark(string mark, int frame, bool isInit, string sequencePath)
		{
			this.CurrentSequencePath = sequencePath;
			string currentMark = this.CurrentMark;
			this.CurrentMark = mark;
			if (isInit || currentMark == null || currentMark == this.CurrentMark)
			{
				return;
			}
			bool flag = this.MarkIndexMapFront[currentMark] < this.MarkIndexMapFront[this.CurrentMark];
			Dictionary<string, int> dictionary = flag ? this.MarkIndexMapFront : this.MarkIndexMapBack;
			List<ILevelSequenceSectionInfo> list = flag ? this.Config.ForwardSections : this.Config.BackWardSections.ToList<ILevelSequenceSectionInfo>();
			if (!flag)
			{
				list.Reverse();
			}
			ILevelSequenceSectionInfo levelSequenceSectionInfo = null;
			this.EventPendingList = new List<ILevelSequenceSectionInfo>();
			int num;
			int num2;
			if (dictionary.TryGetValue(this.CurrentMark, out num) && dictionary.TryGetValue(currentMark, out num2))
			{
				for (int i = num - 1; i > num2; i--)
				{
					if (list[i].Type != ELevelSequenceSectionType.Mark)
					{
						if (flag ? (frame > list[i].FrameId) : (frame < list[i].FrameId))
						{
							levelSequenceSectionInfo = list[i];
							break;
						}
						this.EventPendingList.Add(list[i]);
					}
				}
			}
			if (levelSequenceSectionInfo != null)
			{
				this.RequestAction(levelSequenceSectionInfo.Key);
			}
		}

		// Token: 0x0603C632 RID: 247346 RVA: 0x0113B46C File Offset: 0x0113966C
		public unsafe void OnSequencePaused()
		{
			while (this.EventPendingList.Count > 0)
			{
				List<ILevelSequenceSectionInfo> eventPendingList = this.EventPendingList;
				ILevelSequenceSectionInfo levelSequenceSectionInfo = eventPendingList[eventPendingList.Count - 1];
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[SceneItemReference][EventComp] 补做遗漏的帧事件";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", levelSequenceSectionInfo.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("id", this.PbDataId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				if (this.FrameMap.ContainsKey(levelSequenceSectionInfo.Key))
				{
					this.ExecuteEvent(levelSequenceSectionInfo.Key);
				}
				else
				{
					this.EventPendingList.RemoveAt(this.EventPendingList.Count - 1);
				}
			}
			this.EventPendingList = new List<ILevelSequenceSectionInfo>();
		}

		// Token: 0x0603C633 RID: 247347 RVA: 0x0113B54C File Offset: 0x0113974C
		private void RequestAction(string key)
		{
			LevelSequenceFrameEventActionRequest levelSequenceFrameEventActionRequest = LevelSequenceFrameEventActionRequest.Create();
			levelSequenceFrameEventActionRequest.HostPlayerId = CreatureModel.Instance.GetWorldOwner();
			levelSequenceFrameEventActionRequest.EntityId = this.CreatureDataId;
			levelSequenceFrameEventActionRequest.Key = key;
			Net.Instance.Call(ERequestMessageId.LevelSequenceFrameEventActionRequest, levelSequenceFrameEventActionRequest, null, 0);
		}

		// Token: 0x0603C634 RID: 247348 RVA: 0x0113B594 File Offset: 0x01139794
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			LevelSequenceFrameEventComponent levelSequenceFrameEventComponent = (LevelSequenceFrameEventComponent)componentTemplate;
			if (levelSequenceFrameEventComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			this.CreatureDataId = levelSequenceFrameEventComponent.CreatureDataId;
			this.PbDataId = levelSequenceFrameEventComponent.PbDataId;
			if (levelSequenceFrameEventComponent.FrameMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.FrameMap), "FrameMap"))
			{
				return false;
			}
			this.CurrentMark = levelSequenceFrameEventComponent.CurrentMark;
			if (levelSequenceFrameEventComponent.MarkIndexMapFront != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MarkIndexMapFront), "MarkIndexMapFront"))
			{
				return false;
			}
			if (levelSequenceFrameEventComponent.MarkIndexMapBack != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MarkIndexMapBack), "MarkIndexMapBack"))
			{
				return false;
			}
			if (levelSequenceFrameEventComponent.EventPendingList == null)
			{
				this.EventPendingList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EventPendingList), "EventPendingList"))
			{
				return false;
			}
			this.CurrentSequencePath = levelSequenceFrameEventComponent.CurrentSequencePath;
			return true;
		}

		// Token: 0x1700720A RID: 29194
		// (get) Token: 0x0603C635 RID: 247349 RVA: 0x0113B6A0 File Offset: 0x011398A0
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FF92 RID: 130962
		[Nullable(2)]
		private LevelSequenceFrameEventComponent Config;

		// Token: 0x0401FF93 RID: 130963
		private long CreatureDataId;

		// Token: 0x0401FF94 RID: 130964
		private long PbDataId;

		// Token: 0x0401FF95 RID: 130965
		private readonly Dictionary<string, ILevelSequenceSectionInfo> FrameMap = new Dictionary<string, ILevelSequenceSectionInfo>();

		// Token: 0x0401FF96 RID: 130966
		[Nullable(2)]
		private string CurrentMark;

		// Token: 0x0401FF97 RID: 130967
		private readonly Dictionary<string, int> MarkIndexMapFront = new Dictionary<string, int>();

		// Token: 0x0401FF98 RID: 130968
		private readonly Dictionary<string, int> MarkIndexMapBack = new Dictionary<string, int>();

		// Token: 0x0401FF99 RID: 130969
		private List<ILevelSequenceSectionInfo> EventPendingList = new List<ILevelSequenceSectionInfo>();

		// Token: 0x0401FF9A RID: 130970
		[Nullable(2)]
		private string CurrentSequencePath;
	}
}
