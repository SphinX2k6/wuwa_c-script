using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B56 RID: 27478
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventPlayWalkingOverlayMontage : LevelEventBase
	{
		// Token: 0x060441CB RID: 278987 RVA: 0x010C345D File Offset: 0x010C165D
		public LevelEventPlayWalkingOverlayMontage(int id) : base(id)
		{
		}

		// Token: 0x060441CC RID: 278988 RVA: 0x010C3468 File Offset: 0x010C1668
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PlayWalkingOverlayMontage playWalkingOverlayMontage = inParams as PlayWalkingOverlayMontage;
			this.EventParam = playWalkingOverlayMontage;
			base.CreateWaitEntityTask(playWalkingOverlayMontage.EntityId);
		}

		// Token: 0x060441CD RID: 278989 RVA: 0x010C3490 File Offset: 0x010C1690
		protected override void ExecuteWhenEntitiesReady()
		{
			if (this.EventParam == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.EventParam.EntityId);
			CharacterAnimationComponent characterAnimationComponent;
			if (entityByPbDataId == null)
			{
				characterAnimationComponent = null;
			}
			else
			{
				WorldEntity entity = entityByPbDataId.Entity;
				characterAnimationComponent = ((entity != null) ? entity.GetComponent<CharacterAnimationComponent>() : null);
			}
			CharacterAnimationComponent characterAnimationComponent2 = characterAnimationComponent;
			if (entityByPbDataId == null || characterAnimationComponent2 == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			this.EntityHandle = entityByPbDataId;
			PlayMontageConfig config = new PlayMontageConfig(this.EventParam.RepeatTimes.GetValueOrDefault(), (double)this.EventParam.LoopDuration.GetValueOrDefault(), false, false);
			this.PlayMontageHandle = PlayMontageUtils.Instance.LoadAndPlayMontageByOverlapId(characterAnimationComponent2, this.EventParam.OverlapMontageId, config, null, null, null);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060441CE RID: 278990 RVA: 0x010C3550 File Offset: 0x010C1750
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (this.EntityHandle != handle)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "实体被移除，PlayRegisteredMontaged保底结束";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", handle.PbDataId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			}
			if (this.PlayMontageHandle != 0)
			{
				PlayMontageUtils.Instance.ClearAndStopMontage(this.PlayMontageHandle, null, 0f);
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060441CF RID: 278991 RVA: 0x010C3604 File Offset: 0x010C1804
		protected override void OnReset()
		{
			if (this.PlayMontageHandle != 0)
			{
				PlayMontageUtils.Instance.ClearAndEndMontage(this.PlayMontageHandle, true, null);
			}
			this.EventParam = null;
			this.EntityHandle = null;
			this.PlayMontageHandle = 0;
		}

		// Token: 0x04023934 RID: 145716
		[Nullable(2)]
		private PlayWalkingOverlayMontage EventParam;

		// Token: 0x04023935 RID: 145717
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x04023936 RID: 145718
		private int PlayMontageHandle;
	}
}
