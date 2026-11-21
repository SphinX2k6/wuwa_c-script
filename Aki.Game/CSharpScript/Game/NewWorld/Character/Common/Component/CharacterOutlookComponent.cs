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
	// Token: 0x02006331 RID: 25393
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterOutlookComponent : BaseOutlookComponent
	{
		// Token: 0x0603D862 RID: 252002 RVA: 0x011D0980 File Offset: 0x011CEB80
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

		// Token: 0x0603D863 RID: 252003 RVA: 0x011D09D3 File Offset: 0x011CEBD3
		protected override void OnActivate()
		{
			base.OnActivate();
			this.RefreshOrnaments();
		}

		// Token: 0x0603D864 RID: 252004 RVA: 0x011D09E4 File Offset: 0x011CEBE4
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

		// Token: 0x0603D865 RID: 252005 RVA: 0x011D0A2C File Offset: 0x011CEC2C
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

		// Token: 0x0603D866 RID: 252006 RVA: 0x011D0AC8 File Offset: 0x011CECC8
		protected override void AddRenderMesh(DecorationItem item)
		{
			CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
			if (component != null && item.MeshComp != null)
			{
				component.Actor.CharRenderingComponent.AddComponent(item.MeshComp.GetName(), item.MeshComp);
			}
		}

		// Token: 0x0603D867 RID: 252007 RVA: 0x011D0B10 File Offset: 0x011CED10
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

		// Token: 0x0603D868 RID: 252008 RVA: 0x011D0BB5 File Offset: 0x011CEDB5
		public override int GetSkinId()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return 0;
			}
			return actorComp.CreatureData.GetSkinId();
		}

		// Token: 0x0603D869 RID: 252009 RVA: 0x011D0BD0 File Offset: 0x011CEDD0
		private bool IsFemaleMainRole()
		{
			if (this.ActorComp == null)
			{
				return false;
			}
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(this.ActorComp.CreatureData.GetPbDataId());
			return RoleModel.Instance.IsMainRole(baseRoleId) && PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female;
		}

		// Token: 0x0603D86A RID: 252010 RVA: 0x011D0C20 File Offset: 0x011CEE20
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterOutlookComponent characterOutlookComponent = (CharacterOutlookComponent)componentTemplate;
			if (characterOutlookComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterOutlookComponent.CharRenderComp == null)
			{
				this.CharRenderComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharRenderComp), "CharRenderComp"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170074C2 RID: 29890
		// (get) Token: 0x0603D86B RID: 252011 RVA: 0x011D0C96 File Offset: 0x011CEE96
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074C3 RID: 29891
		// (get) Token: 0x0603D86C RID: 252012 RVA: 0x011D0C99 File Offset: 0x011CEE99
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074C4 RID: 29892
		// (get) Token: 0x0603D86D RID: 252013 RVA: 0x011D0C9C File Offset: 0x011CEE9C
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074C5 RID: 29893
		// (get) Token: 0x0603D86E RID: 252014 RVA: 0x011D0C9F File Offset: 0x011CEE9F
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074C6 RID: 29894
		// (get) Token: 0x0603D86F RID: 252015 RVA: 0x011D0CA2 File Offset: 0x011CEEA2
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A28 RID: 133672
		[Nullable(2)]
		protected CharacterActorComponent ActorComp;

		// Token: 0x04020A29 RID: 133673
		[Nullable(2)]
		protected CharRenderingComponent CharRenderComp;
	}
}
