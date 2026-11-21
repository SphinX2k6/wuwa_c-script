using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CEF RID: 23791
	public class LevelEventSetNpcPosition : LevelEventBase
	{
		// Token: 0x0603A3A2 RID: 238498 RVA: 0x01073A48 File Offset: 0x01071C48
		public LevelEventSetNpcPosition(int id) : base(id)
		{
		}

		// Token: 0x0603A3A3 RID: 238499 RVA: 0x01073A54 File Offset: 0x01071C54
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			ActionSetNpcPosition actionSetNpcPosition = inParams as ActionSetNpcPosition;
			FVectorDouble value = new FVectorDouble(0.0, 0.0, 0.0);
			FRotator frotator = new FRotator(0f, 0f, 0f);
			foreach (EntityPositionData entityPositionData in actionSetNpcPosition.EntityData)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityPositionData.EntityId);
				if (entityByPbDataId == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.LevelEvent;
					ELogAuthor author = ELogAuthor.FZX;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("通过事件设置NPC坐标时找不到实体：pbDataId: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(entityPositionData.EntityId);
					instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
					base.Failure(false, true);
					break;
				}
				CharacterActorComponent component = entityByPbDataId.Entity.GetComponent<CharacterActorComponent>();
				if (entityPositionData.Pos.X != null && entityPositionData.Pos.Y != null && entityPositionData.Pos.Z != null)
				{
					value.Set((double)entityPositionData.Pos.X.Value, (double)entityPositionData.Pos.Y.Value, (double)entityPositionData.Pos.Z.Value);
					if (!actionSetNpcPosition.IsCenterPosition)
					{
						value.Z += (double)component.Actor.CapsuleComponent.GetScaledCapsuleHalfHeight();
					}
					component.SetActorLocation(value, "关卡事件{LevelEventSetNpcPosition}.设置NPC的位置", false);
				}
				if (entityPositionData.Pos.A != null)
				{
					frotator.Yaw = entityPositionData.Pos.A.Value;
					component.SetInputRotator(frotator);
					component.SetActorRotation(frotator, "关卡事件{LevelEventSetNpcPosition}.设置NPC的朝向", false);
				}
			}
		}
	}
}
