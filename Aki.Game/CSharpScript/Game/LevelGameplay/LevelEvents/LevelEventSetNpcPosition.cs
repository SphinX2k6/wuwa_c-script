using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B77 RID: 27511
	public class LevelEventSetNpcPosition : LevelEventBase
	{
		// Token: 0x06044250 RID: 279120 RVA: 0x010C9DD4 File Offset: 0x010C7FD4
		public LevelEventSetNpcPosition(int id) : base(id)
		{
		}

		// Token: 0x06044251 RID: 279121 RVA: 0x010C9DE0 File Offset: 0x010C7FE0
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
