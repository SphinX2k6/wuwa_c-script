using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.GenericPrompt;

namespace CSharpScript.Game.NewWorld.Character.Monster.Component
{
	// Token: 0x02006307 RID: 25351
	[NullableContext(1)]
	[Nullable(0)]
	public class HackManagementComponent : EntityComponent
	{
		// Token: 0x0603D504 RID: 251140 RVA: 0x011B7B08 File Offset: 0x011B5D08
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			object param = args.GetP1<CreateEntityData>().GetParam<HackManagementComponent>();
			this.Config = (param as HackManagementComponent);
			this.MaxHackCount = this.Config.MaxHackingCount;
			return true;
		}

		// Token: 0x0603D505 RID: 251141 RVA: 0x011B7B40 File Offset: 0x011B5D40
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

		// Token: 0x0603D506 RID: 251142 RVA: 0x011B7C68 File Offset: 0x011B5E68
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

		// Token: 0x0603D507 RID: 251143 RVA: 0x011B7CDD File Offset: 0x011B5EDD
		public bool CanHack()
		{
			return this.CurrentHackEntity.Count < this.MaxHackCount;
		}

		// Token: 0x0603D508 RID: 251144 RVA: 0x011B7CF2 File Offset: 0x011B5EF2
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

		// Token: 0x0603D509 RID: 251145 RVA: 0x011B7D1C File Offset: 0x011B5F1C
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

		// Token: 0x0603D50A RID: 251146 RVA: 0x011B7D62 File Offset: 0x011B5F62
		public int GetRemainingHackNumber()
		{
			return Math.Max(0, this.MaxHackCount - this.CurrentHackEntity.Count);
		}

		// Token: 0x0603D50B RID: 251147 RVA: 0x011B7D7C File Offset: 0x011B5F7C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			HackManagementComponent hackManagementComponent = (HackManagementComponent)componentTemplate;
			if (hackManagementComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (hackManagementComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (hackManagementComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			this.MaxHackCount = hackManagementComponent.MaxHackCount;
			if (hackManagementComponent.CurrentHackEntity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentHackEntity), "CurrentHackEntity"))
			{
				return false;
			}
			this.HackNumIsEmpty = hackManagementComponent.HackNumIsEmpty;
			this.LastShowTipTime = hackManagementComponent.LastShowTipTime;
			return true;
		}

		// Token: 0x17007411 RID: 29713
		// (get) Token: 0x0603D50C RID: 251148 RVA: 0x011B7E63 File Offset: 0x011B6063
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402085B RID: 133211
		[Nullable(2)]
		private HackManagementComponent Config;

		// Token: 0x0402085C RID: 133212
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0402085D RID: 133213
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x0402085E RID: 133214
		private int MaxHackCount;

		// Token: 0x0402085F RID: 133215
		private readonly List<Entity> CurrentHackEntity = new List<Entity>();

		// Token: 0x04020860 RID: 133216
		private bool HackNumIsEmpty;

		// Token: 0x04020861 RID: 133217
		private double LastShowTipTime;
	}
}
