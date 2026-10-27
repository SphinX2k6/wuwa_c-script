using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.SceneItem;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.AiInteraction.AiWeapon
{
	// Token: 0x02005EAF RID: 24239
	[NullableContext(1)]
	[Nullable(0)]
	public class AiWeaponNet
	{
		// Token: 0x0603DABE RID: 252606 RVA: 0x00EE49D9 File Offset: 0x00EE2BD9
		public void RegisterNet()
		{
			Net.Instance.Register(ENotifyMessageId.HoldWeaponNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HoldWeaponNotify response = (HoldWeaponNotify)msg;
				this.OnHoldWeaponNotify(response);
			});
		}

		// Token: 0x0603DABF RID: 252607 RVA: 0x00EE49F7 File Offset: 0x00EE2BF7
		public void UnRegisterNet()
		{
			Net.Instance.UnRegister(ENotifyMessageId.HoldWeaponNotify);
		}

		// Token: 0x0603DAC0 RID: 252608 RVA: 0x00EE4A0C File Offset: 0x00EE2C0C
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

		// Token: 0x0603DAC1 RID: 252609 RVA: 0x00EE4A78 File Offset: 0x00EE2C78
		public bool SendHoldWeaponPushOnSafe(int entityId, int itemEntityId)
		{
			Entity entity = EntitySystem.Instance.Get(itemEntityId);
			return entity != null && entity.GetComponent<SceneItemAiInteractionComponent>().CanBeUsed() && this.SendHoldWeaponPush(entityId, itemEntityId);
		}

		// Token: 0x0603DAC2 RID: 252610 RVA: 0x00EE4AB0 File Offset: 0x00EE2CB0
		public bool SendHoldWeaponPush(int entityId, int itemEntityId)
		{
			HoldWeaponPush holdWeaponPush = HoldWeaponPush.Create();
			holdWeaponPush.EntityId = this.GetCreateDataId(entityId);
			holdWeaponPush.WeaponEntityId = this.GetCreateDataId(itemEntityId);
			Net.Instance.Send(EPushMessageId.HoldWeaponPush, holdWeaponPush);
			return true;
		}

		// Token: 0x0603DAC3 RID: 252611 RVA: 0x00EE4AF0 File Offset: 0x00EE2CF0
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

		// Token: 0x0603DAC4 RID: 252612 RVA: 0x00EE4D7C File Offset: 0x00EE2F7C
		private long GetCreateDataId(int entityId)
		{
			long creatureDataId = CreatureModel.Instance.GetCreatureDataId(entityId);
			return MathUtils.Instance.NumberToLong(creatureDataId);
		}

		// Token: 0x0603DAC5 RID: 252613 RVA: 0x00EE4DA0 File Offset: 0x00EE2FA0
		public double CalculateWeight(double size)
		{
			double num = Math.Abs(size);
			int num2 = (size > 0.0) ? 1 : -1;
			int num3 = 600;
			num = MathUtils.Instance.Clamp(num, 0.0, (double)num3);
			return ((double)num3 - num) * (double)num2;
		}

		// Token: 0x040202B3 RID: 131763
		private const int MAX_SPEED_SIZE = 600;
	}
}
