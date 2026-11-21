using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.SceneItem.Jigsaw;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200623E RID: 25150
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemPickInteractComponent : EntityComponent
	{
		// Token: 0x0603CA22 RID: 248354 RVA: 0x01162728 File Offset: 0x01160928
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

		// Token: 0x0603CA23 RID: 248355 RVA: 0x01162760 File Offset: 0x01160960
		protected override bool OnStart()
		{
			this.ItemComponent = base.Entity.GetComponent<SceneItemJigsawItemComponent>();
			return true;
		}

		// Token: 0x170072AC RID: 29356
		// (get) Token: 0x0603CA24 RID: 248356 RVA: 0x01162774 File Offset: 0x01160974
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

		// Token: 0x170072AD RID: 29357
		// (get) Token: 0x0603CA25 RID: 248357 RVA: 0x01162787 File Offset: 0x01160987
		public SceneItemJigsawItemComponent Item
		{
			get
			{
				return this.ItemComponent;
			}
		}

		// Token: 0x0603CA26 RID: 248358 RVA: 0x01162790 File Offset: 0x01160990
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

		// Token: 0x0603CA27 RID: 248359 RVA: 0x0116289C File Offset: 0x01160A9C
		public void OnSelectEnd()
		{
			foreach (int handle in this.SelectNieghtborEffects)
			{
				EffectSystem.Instance.StopEffectById(handle, "PickInteractComponent.OnSelectEnd", false, null);
			}
			this.SelectNieghtborEffects.Clear();
		}

		// Token: 0x0603CA28 RID: 248360 RVA: 0x01162910 File Offset: 0x01160B10
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemPickInteractComponent sceneItemPickInteractComponent = (SceneItemPickInteractComponent)componentTemplate;
			if (sceneItemPickInteractComponent.ItemComponent == null)
			{
				this.ItemComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ItemComponent), "ItemComponent"))
			{
				return false;
			}
			if (sceneItemPickInteractComponent.SelectNieghtborEffects != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SelectNieghtborEffects), "SelectNieghtborEffects"))
			{
				return false;
			}
			this.SelectEffectPathName = sceneItemPickInteractComponent.SelectEffectPathName;
			return true;
		}

		// Token: 0x170072AE RID: 29358
		// (get) Token: 0x0603CA29 RID: 248361 RVA: 0x01162989 File Offset: 0x01160B89
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402024A RID: 131658
		private SceneItemJigsawItemComponent ItemComponent;

		// Token: 0x0402024B RID: 131659
		[Nullable(1)]
		private readonly List<int> SelectNieghtborEffects = new List<int>();

		// Token: 0x0402024C RID: 131660
		private string SelectEffectPathName;
	}
}
