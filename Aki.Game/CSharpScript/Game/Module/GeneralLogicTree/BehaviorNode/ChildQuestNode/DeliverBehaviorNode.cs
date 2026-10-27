using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemDeliver;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059D0 RID: 22992
	[NullableContext(1)]
	[Nullable(0)]
	public class DeliverBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A493 RID: 238739 RVA: 0x00DDC447 File Offset: 0x00DDA647
		public DeliverBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17008B99 RID: 35737
		// (get) Token: 0x0603A494 RID: 238740 RVA: 0x00DDC466 File Offset: 0x00DDA666
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0603A495 RID: 238741 RVA: 0x00DDC470 File Offset: 0x00DDA670
		protected override bool OnCreate(IBtNode nodeConfig)
		{
			IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode == null)
			{
				return false;
			}
			if (!base.OnCreate(nodeConfig))
			{
				return false;
			}
			IHandInItemsCondition handInItemsCondition = childQuestBtNode.Condition as IHandInItemsCondition;
			if (handInItemsCondition == null)
			{
				return false;
			}
			IAddInteractOption addOption = handInItemsCondition.AddOption;
			if (addOption.Option.Type.Type != EInteractOption.Actions)
			{
				global::Log.Instance.Error(ELogModule.Quest, ELogAuthor.YSQ, "交付道具任务配置的交互类型错误，应配置行为序列类型的交互", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.HandInItems = handInItemsCondition.HandInItems.Items;
			this.HandInGroup = handInItemsCondition.HandInItems.GroupConfig;
			this.DescText = handInItemsCondition.HandInItems.TidDescText;
			this.TitleText = handInItemsCondition.HandInItems.TidTitleText;
			this.CanRepeat = handInItemsCondition.HandInItems.RepeatItems;
			this.InnerInteractEntityDataId = addOption.EntityId;
			this.InnerInteractOption = addOption;
			this.InnerCorrelativeEntities.Clear();
			this.InnerCorrelativeEntities.Add(addOption.EntityId);
			return true;
		}

		// Token: 0x0603A496 RID: 238742 RVA: 0x00DDC562 File Offset: 0x00DDA762
		protected override void OnDestroy()
		{
			this.InnerInteractOption = null;
			this.HandInItems = null;
			base.OnDestroy();
		}

		// Token: 0x0603A497 RID: 238743 RVA: 0x00DDC578 File Offset: 0x00DDA778
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<string>(EEventName.DynamicInteractServerResponse, new Action<string>(this.OnDynamicInteract));
		}

		// Token: 0x0603A498 RID: 238744 RVA: 0x00DDC59C File Offset: 0x00DDA79C
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<string>(EEventName.DynamicInteractServerResponse, new Action<string>(this.OnDynamicInteract));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0603A499 RID: 238745 RVA: 0x00DDC5C0 File Offset: 0x00DDA7C0
		private void OnDynamicInteract(string optionGuid)
		{
			if (this.InnerInteractOption == null || this.InnerInteractOption.Option.Guid != optionGuid)
			{
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.InnerInteractEntityDataId);
			if (entityByPbDataId == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Quest;
				ELogAuthor author = ELogAuthor.BB;
				string message = "交付道具的NPC不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("实体Id", this.InnerInteractEntityDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PawnInfoManageComponent component = entityByPbDataId.Entity.GetComponent<PawnInfoManageComponent>();
			string npcName = ((component != null) ? component.PawnName : null) ?? "";
			if (this.HandInItems != null)
			{
				ItemDeliverController.Instance.OpenItemDeliverViewByHandInItem(this.HandInItems, npcName, this.TitleText, this.DescText, this.Context);
				return;
			}
			if (this.HandInGroup != null)
			{
				ItemDeliverController.Instance.OpenItemDeliverViewByHandInGroup(this.HandInGroup, npcName, this.TitleText, this.DescText, this.Context);
			}
		}

		// Token: 0x0401E62D RID: 124461
		private int InnerInteractEntityDataId;

		// Token: 0x0401E62E RID: 124462
		[Nullable(2)]
		private IAddInteractOption InnerInteractOption;

		// Token: 0x0401E62F RID: 124463
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHandInItem> HandInItems;

		// Token: 0x0401E630 RID: 124464
		[Nullable(2)]
		private IHandInGroup HandInGroup;

		// Token: 0x0401E631 RID: 124465
		private string DescText = "";

		// Token: 0x0401E632 RID: 124466
		[Nullable(2)]
		private string TitleText;

		// Token: 0x0401E633 RID: 124467
		public bool CanRepeat;

		// Token: 0x0401E634 RID: 124468
		private readonly List<int> InnerCorrelativeEntities = new List<int>();
	}
}
