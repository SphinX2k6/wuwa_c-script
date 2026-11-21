using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemDeliver;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049A9 RID: 18857
	[NullableContext(1)]
	[Nullable(0)]
	public class DeliverBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F3BA RID: 193466 RVA: 0x00D2BC27 File Offset: 0x00D29E27
		public DeliverBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x17005F66 RID: 24422
		// (get) Token: 0x0602F3BB RID: 193467 RVA: 0x00D2BC46 File Offset: 0x00D29E46
		protected override List<int> CorrelativeEntities
		{
			get
			{
				return this.InnerCorrelativeEntities;
			}
		}

		// Token: 0x0602F3BC RID: 193468 RVA: 0x00D2BC50 File Offset: 0x00D29E50
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

		// Token: 0x0602F3BD RID: 193469 RVA: 0x00D2BD42 File Offset: 0x00D29F42
		protected override void OnDestroy()
		{
			this.InnerInteractOption = null;
			this.HandInItems = null;
			base.OnDestroy();
		}

		// Token: 0x0602F3BE RID: 193470 RVA: 0x00D2BD58 File Offset: 0x00D29F58
		protected override void AddEventsOnChildQuestStart()
		{
			base.AddEventsOnChildQuestStart();
			EventSystem.Instance.Add<string>(EEventName.DynamicInteractServerResponse, new Action<string>(this.OnDynamicInteract));
		}

		// Token: 0x0602F3BF RID: 193471 RVA: 0x00D2BD7C File Offset: 0x00D29F7C
		protected override void RemoveEventsOnChildQuestEnd()
		{
			EventSystem.Instance.Remove<string>(EEventName.DynamicInteractServerResponse, new Action<string>(this.OnDynamicInteract));
			base.RemoveEventsOnChildQuestEnd();
		}

		// Token: 0x0602F3C0 RID: 193472 RVA: 0x00D2BDA0 File Offset: 0x00D29FA0
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

		// Token: 0x040190CC RID: 102604
		private int InnerInteractEntityDataId;

		// Token: 0x040190CD RID: 102605
		[Nullable(2)]
		private IAddInteractOption InnerInteractOption;

		// Token: 0x040190CE RID: 102606
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IHandInItem> HandInItems;

		// Token: 0x040190CF RID: 102607
		[Nullable(2)]
		private IHandInGroup HandInGroup;

		// Token: 0x040190D0 RID: 102608
		private string DescText = "";

		// Token: 0x040190D1 RID: 102609
		[Nullable(2)]
		private string TitleText;

		// Token: 0x040190D2 RID: 102610
		public bool CanRepeat;

		// Token: 0x040190D3 RID: 102611
		private readonly List<int> InnerCorrelativeEntities = new List<int>();
	}
}
