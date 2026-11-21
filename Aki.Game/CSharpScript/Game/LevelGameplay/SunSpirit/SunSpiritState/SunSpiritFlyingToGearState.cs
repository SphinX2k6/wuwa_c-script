using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x02005B59 RID: 23385
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritFlyingToGearState : SunSpiritFlyingEffectState
	{
		// Token: 0x06039839 RID: 235577 RVA: 0x01025A37 File Offset: 0x01023C37
		public SunSpiritFlyingToGearState(SunSpiritData sunSpiritData, float waitBeforeFlyDuration, float flyingDuration, int gearConfigId, int gearSocketIndex, [Nullable(2)] Action flyingEndCallback) : base(ESunSpiritStateType.FlyingToGear, sunSpiritData, waitBeforeFlyDuration, flyingDuration)
		{
			this.GearConfigId = gearConfigId;
			this.GearSocketIndex = gearSocketIndex;
			this.FlyingFinishCallback = flyingEndCallback;
			this.FlyingInterruptCallback = flyingEndCallback;
			this.FlyingTargetGetter = delegate(Vector outPos, Quat outRot)
			{
				CreatureModel instance = CreatureModel.Instance;
				object obj;
				if (instance == null)
				{
					obj = null;
				}
				else
				{
					EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(this.GearConfigId);
					if (entityByPbDataId == null)
					{
						obj = null;
					}
					else
					{
						WorldEntity entity = entityByPbDataId.Entity;
						obj = ((entity != null) ? entity.GetComponent<SceneItemSunSpiritGearComponent>() : null);
					}
				}
				object obj2 = obj;
				return obj2 != null && obj2.GetSunSpiritSocketLocAndRot(this.GearSocketIndex, outPos, outRot);
			};
		}

		// Token: 0x0603983A RID: 235578 RVA: 0x01025A78 File Offset: 0x01023C78
		public override bool IsSameState(SunSpiritBaseState otherState)
		{
			if (base.IsSameState(otherState))
			{
				SunSpiritFlyingToGearState sunSpiritFlyingToGearState = otherState as SunSpiritFlyingToGearState;
				if (sunSpiritFlyingToGearState != null && this.GearConfigId == sunSpiritFlyingToGearState.GearConfigId)
				{
					return this.GearSocketIndex == sunSpiritFlyingToGearState.GearSocketIndex;
				}
			}
			return false;
		}

		// Token: 0x0603983B RID: 235579 RVA: 0x01025AB6 File Offset: 0x01023CB6
		protected override void OnSunSpiritFlyToTargetEnd(bool bKeepEffect = false, bool bIsInterrupt = false)
		{
			base.OnSunSpiritFlyToTargetEnd(bKeepEffect, bIsInterrupt);
			this.SunSpiritData.StopAllAndSetNextSunSpiritState(new SunSpiritOccupiedByGearState(this.SunSpiritData, this.GearConfigId, this.GearSocketIndex), false);
		}

		// Token: 0x0603983C RID: 235580 RVA: 0x01025AE4 File Offset: 0x01023CE4
		protected override bool OnEnter()
		{
			base.OnEnter();
			if (this.SunSpiritData.Transform == null || this.SunSpiritData.Transform.GetLocation().IsZero())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SunSpirit;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "日灵: SunSpiritFlyingToGearState.OnEnter 找不到已有位置，重设飞行起点";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
				if (characterActorComponent == null)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SunSpirit;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "日灵: SunSpiritFlyingToGearState.OnEnter 重设飞行起点位置失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("SpiritConfigId", this.SunSpiritData.ConfigId);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return false;
				}
				this.SunSpiritData.SetLocationAndRotation(characterActorComponent.ActorLocationProxy, characterActorComponent.ActorRotationProxy);
			}
			return true;
		}

		// Token: 0x17006D70 RID: 28016
		// (get) Token: 0x0603983D RID: 235581 RVA: 0x01025BC2 File Offset: 0x01023DC2
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401E5B8 RID: 124344
		public readonly int GearConfigId;

		// Token: 0x0401E5B9 RID: 124345
		public readonly int GearSocketIndex;
	}
}
