using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Common.Component;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070CD RID: 28877
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterOutlookComponent : BaseOutlookComponent
	{
		// Token: 0x0604676B RID: 288619 RVA: 0x011B1734 File Offset: 0x011AF934
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			if (this.ActorComp != null)
			{
				this.SkelMeshComp = this.ActorComp.Actor.Mesh;
				this.CharRenderComp = this.ActorComp.Actor.CharRenderingComponent;
			}
			return true;
		}

		// Token: 0x0604676C RID: 288620 RVA: 0x011B1787 File Offset: 0x011AF987
		protected override void OnActivate()
		{
			base.OnActivate();
			this.RefreshOrnaments();
		}

		// Token: 0x0604676D RID: 288621 RVA: 0x011B1798 File Offset: 0x011AF998
		public void RefreshOrnaments()
		{
			if (this.ActorComp == null)
			{
				return;
			}
			int skinId = this.ActorComp.CreatureData.GetSkinId();
			List<int> decorationIds = RoleUtils.MergeDefaultOrnaments(this.ActorComp.CreatureData.GetOrnamentIds(), skinId);
			base.EquipDecoration(decorationIds);
		}

		// Token: 0x0604676E RID: 288622 RVA: 0x011B17E0 File Offset: 0x011AF9E0
		public void OnEntityDressOrnamentChangeNotify(EntityDressOrnamentChangeNotify notify)
		{
			if (this.ActorComp == null)
			{
				return;
			}
			List<int> list = new List<int>();
			OrnamentComponentPb ornamentComponentPb = notify.OrnamentComponentPb;
			if (((ornamentComponentPb != null) ? ornamentComponentPb.OrnamentIds : null) != null)
			{
				RepeatedField<int> ornamentIds = notify.OrnamentComponentPb.OrnamentIds;
				list = new List<int>(ornamentIds.Count);
				for (int i = 0; i < ornamentIds.Count; i++)
				{
					list.Add(ornamentIds[i]);
				}
			}
			this.ActorComp.CreatureData.SetOrnamentIds(list);
			int skinId = this.ActorComp.CreatureData.GetSkinId();
			List<int> decorationIds = RoleUtils.MergeDefaultOrnaments(list, skinId);
			base.EquipDecoration(decorationIds);
		}

		// Token: 0x0604676F RID: 288623 RVA: 0x011B187C File Offset: 0x011AFA7C
		protected override void AddRenderMesh(DecorationItem item)
		{
			CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
			if (component != null && item.MeshComp != null)
			{
				component.Actor.CharRenderingComponent.AddComponent(item.MeshComp.GetName(), item.MeshComp);
			}
		}

		// Token: 0x06046770 RID: 288624 RVA: 0x011B18C4 File Offset: 0x011AFAC4
		protected override int? GetDecorationModelId(int decorationId)
		{
			Ornament? config = ConfigOrnamentById.GetConfig(decorationId, true);
			if (config == null)
			{
				return null;
			}
			if (config.Value.ModelIdLength <= 0)
			{
				return null;
			}
			if (this.IsFemaleMainRole() && config.Value.ModelIdLength > 1)
			{
				return new int?(config.Value.ModelId(1));
			}
			if (config.Value.ModelIdLength > 0)
			{
				return new int?(config.Value.ModelId(0));
			}
			return null;
		}

		// Token: 0x06046771 RID: 288625 RVA: 0x011B1969 File Offset: 0x011AFB69
		public override int GetSkinId()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return 0;
			}
			return actorComp.CreatureData.GetSkinId();
		}

		// Token: 0x06046772 RID: 288626 RVA: 0x011B1984 File Offset: 0x011AFB84
		private bool IsFemaleMainRole()
		{
			if (this.ActorComp == null)
			{
				return false;
			}
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(this.ActorComp.CreatureData.GetPbDataId());
			return RoleModel.Instance.IsMainRole(baseRoleId) && PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
		}

		// Token: 0x06046773 RID: 288627 RVA: 0x011B19D4 File Offset: 0x011AFBD4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterOutlookComponent characterOutlookComponent = (CharacterOutlookComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterOutlookComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CharRenderComp"))
			{
				if (characterOutlookComponent.CharRenderComp == null)
				{
					this.CharRenderComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharRenderingComponent>(this.CharRenderComp), "CharRenderComp"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024EE9 RID: 151273
		[Nullable(2)]
		protected CharacterActorComponent ActorComp;

		// Token: 0x04024EEA RID: 151274
		[Nullable(2)]
		protected CharRenderingComponent CharRenderComp;
	}
}
