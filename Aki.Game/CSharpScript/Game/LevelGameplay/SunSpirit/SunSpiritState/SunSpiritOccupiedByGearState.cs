using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x02005B5C RID: 23388
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritOccupiedByGearState : SunSpiritBaseState
	{
		// Token: 0x06039848 RID: 235592 RVA: 0x01026178 File Offset: 0x01024378
		public SunSpiritOccupiedByGearState(SunSpiritData sunSpiritData, int gearConfigId, int gearSocketIndex) : base(ESunSpiritStateType.OccupiedByGear, sunSpiritData)
		{
			this.GearConfigId = gearConfigId;
			this.GearSocketIndex = gearSocketIndex;
		}

		// Token: 0x06039849 RID: 235593 RVA: 0x01026190 File Offset: 0x01024390
		public override bool IsSameState(SunSpiritBaseState otherState)
		{
			if (base.IsSameState(otherState))
			{
				SunSpiritOccupiedByGearState sunSpiritOccupiedByGearState = otherState as SunSpiritOccupiedByGearState;
				if (sunSpiritOccupiedByGearState != null && this.GearConfigId == sunSpiritOccupiedByGearState.GearConfigId)
				{
					return this.GearSocketIndex == sunSpiritOccupiedByGearState.GearSocketIndex;
				}
			}
			return false;
		}

		// Token: 0x0603984A RID: 235594 RVA: 0x010261D0 File Offset: 0x010243D0
		protected override bool OnEnter()
		{
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(this.GearConfigId);
				worldEntity = ((entityByPbDataId != null) ? entityByPbDataId.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			SceneItemSunSpiritGearComponent sceneItemSunSpiritGearComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<SceneItemSunSpiritGearComponent>() : null;
			Transform transform = Transform.Create();
			if (sceneItemSunSpiritGearComponent != null)
			{
				sceneItemSunSpiritGearComponent.GetSunSpiritSocketTransform(this.GearSocketIndex, transform);
			}
			SunSpiritBasePerform sunSpiritPerform = this.SunSpiritData.GetSunSpiritPerform();
			ESunSpiritGearPerformType? esunSpiritGearPerformType = (sceneItemSunSpiritGearComponent != null) ? sceneItemSunSpiritGearComponent.GetSunSpiritPerformType() : null;
			if (esunSpiritGearPerformType != null)
			{
				ESunSpiritGearPerformType valueOrDefault = esunSpiritGearPerformType.GetValueOrDefault();
				if (valueOrDefault != ESunSpiritGearPerformType.ToGearRelativePos)
				{
					if (valueOrDefault != ESunSpiritGearPerformType.ScaleUp)
					{
					}
				}
				else
				{
					if (!(sunSpiritPerform is SunSpiritCrowdPerform))
					{
						this.SunSpiritData.ChangeSunSpiritPerform(new SunSpiritCrowdPerform(this.SunSpiritData, transform, false, true));
						goto IL_E4;
					}
					((SunSpiritCrowdPerform)sunSpiritPerform).UpdateCtrlByCrowdAi(false);
					((SunSpiritCrowdPerform)sunSpiritPerform).UpdateForceSpawn(true);
					goto IL_E4;
				}
			}
			if (!(sunSpiritPerform is SunSpiritNonePerform))
			{
				this.SunSpiritData.ChangeSunSpiritPerform(new SunSpiritNonePerform(this.SunSpiritData, transform));
			}
			IL_E4:
			if (worldEntity2 != null && sceneItemSunSpiritGearComponent != null)
			{
				sceneItemSunSpiritGearComponent.OnSunSpiritTakeUp(this.SunSpiritData, this.GearSocketIndex);
				EventSystem.Instance.EmitWithTarget(worldEntity2, EEventName.OnSunSpiritOccupiedByGearChanged);
			}
			return true;
		}

		// Token: 0x0603984B RID: 235595 RVA: 0x010262EC File Offset: 0x010244EC
		protected override void OnExit()
		{
			CreatureModel instance = CreatureModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(this.GearConfigId);
				worldEntity = ((entityByPbDataId != null) ? entityByPbDataId.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			SceneItemSunSpiritGearComponent sceneItemSunSpiritGearComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<SceneItemSunSpiritGearComponent>() : null;
			if (worldEntity2 != null && sceneItemSunSpiritGearComponent != null)
			{
				if (sceneItemSunSpiritGearComponent.GetSunSpiritPerformType().GetValueOrDefault() == ESunSpiritGearPerformType.ScaleUp)
				{
					Transform transform = Transform.Create();
					sceneItemSunSpiritGearComponent.GetSunSpiritSocketTransform(this.GearSocketIndex, transform);
					this.SunSpiritData.SetTransform(transform);
				}
				if (sceneItemSunSpiritGearComponent != null)
				{
					sceneItemSunSpiritGearComponent.OnSunSpiritRelease(this.SunSpiritData, this.GearSocketIndex);
				}
				EventSystem.Instance.EmitWithTarget(worldEntity2, EEventName.OnSunSpiritOccupiedByGearChanged);
			}
		}

		// Token: 0x0401E5BF RID: 124351
		public readonly int GearConfigId;

		// Token: 0x0401E5C0 RID: 124352
		public readonly int GearSocketIndex;
	}
}
