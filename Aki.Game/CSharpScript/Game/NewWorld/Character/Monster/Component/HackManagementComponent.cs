using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.GenericPrompt;

namespace CSharpScript.Game.NewWorld.Character.Monster.Component
{
	// Token: 0x020070A2 RID: 28834
	[NullableContext(1)]
	[Nullable(0)]
	public class HackManagementComponent : EntityComponent
	{
		// Token: 0x06046416 RID: 287766 RVA: 0x01194A9C File Offset: 0x01192C9C
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			object param = args.GetP1<CreateEntityData>().GetParam<HackManagementComponent>();
			this.Config = (param as HackManagementComponent);
			this.MaxHackCount = this.Config.MaxHackingCount;
			return true;
		}

		// Token: 0x06046417 RID: 287767 RVA: 0x01194AD4 File Offset: 0x01192CD4
		protected override bool OnStart()
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			if (((creatureDataComp != null) ? creatureDataComp.PbHackingEntities : null) != null)
			{
				foreach (long creatureDataId in this.CreatureDataComp.PbHackingEntities)
				{
					EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
					if (entity != null)
					{
						WorldEntity entity2 = entity.Entity;
						if (entity2 != null && entity2.Valid)
						{
							this.CurrentHackEntity.Add(entity.Entity);
						}
					}
				}
			}
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTag(new int?(HackManagementConstants.NUM_TAG_ID));
			}
			int remainingHackNumber = this.GetRemainingHackNumber();
			if (remainingHackNumber > 1)
			{
				BaseTagComponent tagComp2 = this.TagComp;
				if (tagComp2 != null)
				{
					tagComp2.TagContainer.UpdateExactTag(ETagChannel.Common, HackManagementConstants.NUM_TAG_ID, remainingHackNumber - 1);
				}
			}
			BaseTagComponent tagComp3 = this.TagComp;
			if (tagComp3 != null)
			{
				tagComp3.AddTagAddOrRemoveListener(HackManagementConstants.NUM_IS_EMPTY_TAG_ID, delegate(int tag, bool tagExist)
				{
					TimerSystem.Instance.Delay(delegate(float _)
					{
						this.HackNumIsEmpty = tagExist;
					}, 100f, null, null, true, 1f);
				}, null);
			}
			BaseTagComponent tagComp4 = this.TagComp;
			if (tagComp4 != null)
			{
				tagComp4.AddTagAddOrRemoveListener(HackManagementConstants.HACKING_TAG_ID, new BaseTagComponent.TTagSwitchedCallback(this.HackingTagListener), null);
			}
			return true;
		}

		// Token: 0x06046418 RID: 287768 RVA: 0x01194BFC File Offset: 0x01192DFC
		private void HackingTagListener(int tag, bool tagExist)
		{
			double num = Time.Instance.Now - this.LastShowTipTime;
			if (tagExist && this.HackNumIsEmpty && num > 1000.0)
			{
				this.LastShowTipTime = Time.Instance.Now;
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ClientErrorCode_0_Text", null);
				GenericPromptController.Instance.ShowPromptByItsType(EPromptSubViewType.FloatLinePrompt, null, null, new object[]
				{
					localTextNew
				}, null, null, null);
			}
		}

		// Token: 0x06046419 RID: 287769 RVA: 0x01194C71 File Offset: 0x01192E71
		public bool CanHack()
		{
			return this.CurrentHackEntity.Count < this.MaxHackCount;
		}

		// Token: 0x0604641A RID: 287770 RVA: 0x01194C86 File Offset: 0x01192E86
		public void AddHackEntity(Entity entity)
		{
			this.CurrentHackEntity.Add(entity);
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp == null)
			{
				return;
			}
			tagComp.TagContainer.UpdateExactTag(ETagChannel.Common, HackManagementConstants.NUM_TAG_ID, -1);
		}

		// Token: 0x0604641B RID: 287771 RVA: 0x01194CB0 File Offset: 0x01192EB0
		public void RemoveHackEntity(Entity entity)
		{
			int num = this.CurrentHackEntity.IndexOf(entity);
			if (num != -1)
			{
				this.CurrentHackEntity.RemoveAt(num);
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null)
				{
					return;
				}
				tagComp.TagContainer.UpdateExactTag(ETagChannel.Common, HackManagementConstants.NUM_TAG_ID, 1);
			}
		}

		// Token: 0x0604641C RID: 287772 RVA: 0x01194CF6 File Offset: 0x01192EF6
		public int GetRemainingHackNumber()
		{
			return Math.Max(0, this.MaxHackCount - this.CurrentHackEntity.Count);
		}

		// Token: 0x0604641D RID: 287773 RVA: 0x01194D10 File Offset: 0x01192F10
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			HackManagementComponent hackManagementComponent = (HackManagementComponent)componentTemplate;
			if (base.CanResetComponentProperty("Config"))
			{
				if (hackManagementComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<HackManagementComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (hackManagementComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (hackManagementComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MaxHackCount"))
			{
				this.MaxHackCount = hackManagementComponent.MaxHackCount;
			}
			if (base.CanResetComponentProperty("CurrentHackEntity") && hackManagementComponent.CurrentHackEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<Entity>>(this.CurrentHackEntity), "CurrentHackEntity"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("HackNumIsEmpty"))
			{
				this.HackNumIsEmpty = hackManagementComponent.HackNumIsEmpty;
			}
			if (base.CanResetComponentProperty("LastShowTipTime"))
			{
				this.LastShowTipTime = hackManagementComponent.LastShowTipTime;
			}
			return true;
		}

		// Token: 0x04024D09 RID: 150793
		[Nullable(2)]
		private HackManagementComponent Config;

		// Token: 0x04024D0A RID: 150794
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04024D0B RID: 150795
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x04024D0C RID: 150796
		private int MaxHackCount;

		// Token: 0x04024D0D RID: 150797
		private readonly List<Entity> CurrentHackEntity = new List<Entity>();

		// Token: 0x04024D0E RID: 150798
		private bool HackNumIsEmpty;

		// Token: 0x04024D0F RID: 150799
		private double LastShowTipTime;
	}
}
