using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Base;

namespace CSharpScript.Game.Module.Map.Mark.Component
{
	// Token: 0x020054CB RID: 21707
	public class MarkFishingPointComponent : MapComponent
	{
		// Token: 0x060376A5 RID: 226981 RVA: 0x00D29495 File Offset: 0x00D27695
		public MarkFishingPointComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x170084EA RID: 34026
		// (get) Token: 0x060376A6 RID: 226982 RVA: 0x00D2949E File Offset: 0x00D2769E
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.MarkFishingPoint;
			}
		}

		// Token: 0x170084EB RID: 34027
		// (get) Token: 0x060376A8 RID: 226984 RVA: 0x00D294BC File Offset: 0x00D276BC
		// (set) Token: 0x060376A7 RID: 226983 RVA: 0x00D294A2 File Offset: 0x00D276A2
		public int FishingPointEntityId
		{
			get
			{
				OneOf<Vector2D, bool, int, string, float> oneOf;
				if (base.PropertyMap.TryGetValue(0, out oneOf))
				{
					return oneOf.AsT3;
				}
				return 0;
			}
			set
			{
				base.PropertyMap[0] = value;
			}
		}

		// Token: 0x060376A9 RID: 226985 RVA: 0x00D294E8 File Offset: 0x00D276E8
		protected override void OnUpdate()
		{
			MapEntity parentEntity = base.ParentEntity;
			MarkResourceComponent markResourceComponent = (parentEntity != null) ? parentEntity.GetComponent<MarkResourceComponent>(EMapComponent.MarkResource) : null;
			if (markResourceComponent != null)
			{
				int valueOrDefault = ConfigCommonParamById.GetIntConfig("FishingWherfRange").GetValueOrDefault(1);
				markResourceComponent.RangeSize = (float)valueOrDefault;
				markResourceComponent.RangeSetAsFirstChild = true;
			}
			MapEntity parentEntity2 = base.ParentEntity;
			MarkViewLifeCircleComponent markViewLifeCircleComponent = (parentEntity2 != null) ? parentEntity2.GetComponent<MarkViewLifeCircleComponent>(EMapComponent.MarkViewLifeCircle) : null;
			if (markViewLifeCircleComponent != null)
			{
				markViewLifeCircleComponent.SetChildViewVisibility(EMarkViewComponentType.Range, false);
			}
		}

		// Token: 0x0200B738 RID: 46904
		private enum EPropertyType
		{
			// Token: 0x040377BE RID: 227262
			FishingPointEntityId
		}
	}
}
