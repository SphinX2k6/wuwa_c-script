using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.SceneItem;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.AiInteraction.AiWeapon
{
	// Token: 0x02004E94 RID: 20116
	[NullableContext(1)]
	[Nullable(0)]
	public class AiWeaponNet
	{
		// Token: 0x06032A4E RID: 207438 RVA: 0x00E35F25 File Offset: 0x00E34125
		public void RegisterNet()
		{
			Net.Instance.Register(ENotifyMessageId.HoldWeaponNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HoldWeaponNotify response = (HoldWeaponNotify)msg;
				this.OnHoldWeaponNotify(response);
			});
		}

		// Token: 0x06032A4F RID: 207439 RVA: 0x00E35F43 File Offset: 0x00E34143
		public void UnRegisterNet()
		{
			Net.Instance.UnRegister(ENotifyMessageId.HoldWeaponNotify);
		}

		// Token: 0x06032A50 RID: 207440 RVA: 0x00E35F58 File Offset: 0x00E34158
		private void OnHoldWeaponNotify(HoldWeaponNotify response)
		{
			long creatureDataId = MathUtils.Instance.LongToNumber(response.EntityId);
			EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
			if (entity == null)
			{
				return;
			}
			WorldEntity entity2 = entity.Entity;
			CharacterWeaponComponent characterWeaponComponent = (entity2 != null) ? entity2.GetComponent<CharacterWeaponComponent>() : null;
			if (characterWeaponComponent == null)
			{
				return;
			}
			if (response.WeaponConfId != 0)
			{
				characterWeaponComponent.RegisterCharacterDropWeaponEvent(response.WeaponConfId);
				characterWeaponComponent.ChangeWeaponByWeaponByConfigId(response.WeaponConfId);
				return;
			}
			characterWeaponComponent.ClearWeaponForAi();
		}

		// Token: 0x06032A51 RID: 207441 RVA: 0x00E35FC4 File Offset: 0x00E341C4
		public bool SendHoldWeaponPushOnSafe(int entityId, int itemEntityId)
		{
			Entity entity = EntitySystem.Instance.Get(itemEntityId);
			return entity != null && entity.GetComponent<SceneItemAiInteractionComponent>().CanBeUsed() && this.SendHoldWeaponPush(entityId, itemEntityId);
		}

		// Token: 0x06032A52 RID: 207442 RVA: 0x00E35FFC File Offset: 0x00E341FC
		public bool SendHoldWeaponPush(int entityId, int itemEntityId)
		{
			HoldWeaponPush holdWeaponPush = HoldWeaponPush.Create();
			holdWeaponPush.EntityId = this.GetCreateDataId(entityId);
			holdWeaponPush.WeaponEntityId = this.GetCreateDataId(itemEntityId);
			Net.Instance.Send(EPushMessageId.HoldWeaponPush, holdWeaponPush);
			return true;
		}

		// Token: 0x06032A53 RID: 207443 RVA: 0x00E3603C File Offset: 0x00E3423C
		public bool SendDiscardWeaponPush(CharacterWeaponComponent weaponComp)
		{
			if (weaponComp.AiWeaponConfigId == 0)
			{
				return false;
			}
			SWeaponSocketItem weaponConfigByConfigId = AiWeaponModel.Instance.GetWeaponConfigByConfigId(weaponComp.AiWeaponConfigId, weaponComp.Entity);
			if (weaponConfigByConfigId == null)
			{
				return false;
			}
			DiscardWeaponRequest discardWeaponRequest = DiscardWeaponRequest.Create();
			MovementInformation movementInformation = MovementInformation.Create();
			discardWeaponRequest.EntityId = this.GetCreateDataId(weaponComp.Entity.Id);
			CharacterActorComponent component = weaponComp.Entity.GetComponent<CharacterActorComponent>();
			CharacterHitComponent component2 = weaponComp.Entity.GetComponent<CharacterHitComponent>();
			global::Vector vector;
			if (component2.GetHitData() != null)
			{
				vector = global::Vector.Create(component2.GetHitData().HitPosition);
			}
			else
			{
				vector = global::Vector.Create(component.ActorLocation);
				vector.Z -= 50.0;
			}
			global::Vector vector2 = global::Vector.Create(component.ActorLocation);
			vector2.SubtractionEqual(vector);
			vector2.X *= 100.0;
			vector2.Y *= 100.0;
			vector2.Z *= 5.0;
			vector2.X = this.CalculateWeight(vector2.X);
			vector2.Y = this.CalculateWeight(vector2.Y);
			vector2.Z = Math.Abs(this.CalculateWeight(vector2.Z));
			FVectorDouble fvectorDouble = component.Actor.Mesh.D_GetSocketLocation(weaponConfigByConfigId.DropSocket);
			global::Rotator rotator = global::Rotator.Create();
			vector2.Rotation(rotator);
			movementInformation.Location = Aki.Protocol.Vector.Create();
			movementInformation.Location.X = (float)fvectorDouble.X;
			movementInformation.Location.Y = (float)fvectorDouble.Y;
			movementInformation.Location.Z = (float)fvectorDouble.Z;
			movementInformation.Rotation = Aki.Protocol.Rotator.Create();
			movementInformation.Rotation.Roll = rotator.Roll;
			movementInformation.Rotation.Pitch = rotator.Pitch;
			movementInformation.Rotation.Yaw = rotator.Yaw;
			movementInformation.LinearVelocity = Aki.Protocol.Vector.Create();
			movementInformation.LinearVelocity.X = (float)vector2.X;
			movementInformation.LinearVelocity.Y = (float)vector2.Y;
			movementInformation.LinearVelocity.Z = (float)vector2.Z;
			discardWeaponRequest.MovementInformation = movementInformation;
			Net.Instance.Call(ERequestMessageId.DiscardWeaponRequest, discardWeaponRequest, delegate(IMessage _, Net.CallbackStatus _)
			{
			}, 0);
			return true;
		}

		// Token: 0x06032A54 RID: 207444 RVA: 0x00E362C8 File Offset: 0x00E344C8
		private long GetCreateDataId(int entityId)
		{
			long creatureDataId = CreatureModel.Instance.GetCreatureDataId(entityId);
			return MathUtils.Instance.NumberToLong(creatureDataId);
		}

		// Token: 0x06032A55 RID: 207445 RVA: 0x00E362EC File Offset: 0x00E344EC
		public double CalculateWeight(double size)
		{
			double num = Math.Abs(size);
			int num2 = (size > 0.0) ? 1 : -1;
			int num3 = 600;
			num = MathUtils.Instance.Clamp(num, 0.0, (double)num3);
			return ((double)num3 - num) * (double)num2;
		}

		// Token: 0x0401AD7A RID: 109946
		private const int MAX_SPEED_SIZE = 600;
	}
}
