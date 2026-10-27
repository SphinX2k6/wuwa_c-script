using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200718A RID: 29066
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemPickInteractComponent : EntityComponent
	{
		// Token: 0x0604716D RID: 291181 RVA: 0x01208718 File Offset: 0x01206918
		protected override bool OnInitData(IEntityArgs args = null)
		{
			PickInteractComponent pickInteractComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemPickInteractComponent>() as PickInteractComponent;
			if (pickInteractComponent != null)
			{
				IChessmanPickInteraction pickInteractType = pickInteractComponent.PickInteractType;
				if (pickInteractType != null)
				{
					this.SelectEffectPathName = pickInteractType.AvailablePosEffect;
				}
			}
			return true;
		}

		// Token: 0x0604716E RID: 291182 RVA: 0x01208750 File Offset: 0x01206950
		protected override bool OnStart()
		{
			this.ItemComponent = base.Entity.GetComponent<SceneItemJigsawItemComponent>();
			return true;
		}

		// Token: 0x17009D96 RID: 40342
		// (get) Token: 0x0604716F RID: 291183 RVA: 0x01208764 File Offset: 0x01206964
		public JigsawIndex Index
		{
			get
			{
				SceneItemJigsawItemComponent itemComponent = this.ItemComponent;
				if (itemComponent == null)
				{
					return null;
				}
				return itemComponent.PutDownIndex;
			}
		}

		// Token: 0x17009D97 RID: 40343
		// (get) Token: 0x06047170 RID: 291184 RVA: 0x01208777 File Offset: 0x01206977
		public SceneItemJigsawItemComponent Item
		{
			get
			{
				return this.ItemComponent;
			}
		}

		// Token: 0x06047171 RID: 291185 RVA: 0x01208780 File Offset: 0x01206980
		public void OnSelect()
		{
			if (this.ItemComponent != null)
			{
				SceneItemJigsawBaseComponent putDownBase = this.ItemComponent.PutDownBase;
				List<Vector> list = (putDownBase != null) ? putDownBase.OnItemTicTacToeSelect(this) : null;
				if (list == null)
				{
					return;
				}
				if (!string.IsNullOrEmpty(this.SelectEffectPathName))
				{
					foreach (Vector vector in list)
					{
						EffectSystem instance = EffectSystem.Instance;
						UObject world = GlobalData.World;
						FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
						int num = instance.SpawnEffect(world, ftransformDouble, this.SelectEffectPathName, "PickInteractComponent.OnSelect", new EffectContext(new int?(base.Entity.Id), null, false), EEffectType.Scene, null, null, null, false, false);
						if (EffectSystem.Instance.IsValid(num))
						{
							OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
							FVectorDouble fvectorDouble = vector.ToUeVector(false);
							effectActor.D_K2_SetActorLocation(fvectorDouble, false, ref WorldGlobal.SweepHitResult, true);
							this.SelectNieghtborEffects.Add(num);
						}
					}
				}
			}
		}

		// Token: 0x06047172 RID: 291186 RVA: 0x0120888C File Offset: 0x01206A8C
		public void OnSelectEnd()
		{
			foreach (int handle in this.SelectNieghtborEffects)
			{
				EffectSystem.Instance.StopEffectById(handle, "PickInteractComponent.OnSelectEnd", false, null);
			}
			this.SelectNieghtborEffects.Clear();
		}

		// Token: 0x06047173 RID: 291187 RVA: 0x01208900 File Offset: 0x01206B00
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemPickInteractComponent sceneItemPickInteractComponent = (SceneItemPickInteractComponent)componentTemplate;
			if (base.CanResetComponentProperty("ItemComponent"))
			{
				if (sceneItemPickInteractComponent.ItemComponent == null)
				{
					this.ItemComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemJigsawItemComponent>(this.ItemComponent), "ItemComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SelectNieghtborEffects") && sceneItemPickInteractComponent.SelectNieghtborEffects != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<int>>(this.SelectNieghtborEffects), "SelectNieghtborEffects"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("SelectEffectPathName"))
			{
				this.SelectEffectPathName = sceneItemPickInteractComponent.SelectEffectPathName;
			}
			return true;
		}

		// Token: 0x040255E3 RID: 153059
		private SceneItemJigsawItemComponent ItemComponent;

		// Token: 0x040255E4 RID: 153060
		[Nullable(1)]
		private readonly List<int> SelectNieghtborEffects = new List<int>();

		// Token: 0x040255E5 RID: 153061
		private string SelectEffectPathName;
	}
}
