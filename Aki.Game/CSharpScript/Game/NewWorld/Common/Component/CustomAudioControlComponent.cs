using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02007082 RID: 28802
	[NullableContext(2)]
	[Nullable(0)]
	public class CustomAudioControlComponent : EntityComponent
	{
		// Token: 0x06046264 RID: 287332 RVA: 0x011861F8 File Offset: 0x011843F8
		protected override bool OnInitData(IEntityArgs args = null)
		{
			EntityCustomAudioComponent entityCustomAudioComponent = args.GetP1<CreateEntityData>().GetParam<CustomAudioControlComponent>() as EntityCustomAudioComponent;
			this.AudioRangeType = entityCustomAudioComponent.AudioRangeType;
			this.AudioControlConfig = entityCustomAudioComponent.AudioControlType;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x06046265 RID: 287333 RVA: 0x01186240 File Offset: 0x01184440
		protected override bool OnStart()
		{
			switch (this.AudioRangeType)
			{
			case EAudioRangeType.SceneActorRefComp:
				this.RefComp = base.Entity.GetComponent<SceneItemReferenceComponent>();
				if (!this.RefComp)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Entity;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "SceneItemReferenceComponent不存在";
					string item = "ConfigId";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				this.RefComp.AddOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerInOutRange), false);
				break;
			case EAudioRangeType.RangeComp:
				if (!base.Entity.GetComponent<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Entity;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "RangeComponent不存在";
					string item2 = "ConfigId";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return false;
				}
				if (!EventSystem.Instance.HasWithTarget<bool>(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerInOutRange)))
				{
					EventSystem.Instance.AddWithTargetUseHoldKey(this, base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerInOutRange));
				}
				break;
			case EAudioRangeType.AOI:
				this.OnPlayerInOutRange(true);
				break;
			}
			return true;
		}

		// Token: 0x06046266 RID: 287334 RVA: 0x011863A8 File Offset: 0x011845A8
		protected override bool OnEnd()
		{
			switch (this.AudioRangeType)
			{
			case EAudioRangeType.SceneActorRefComp:
				if (this.RefComp != null)
				{
					this.RefComp.RemoveOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerInOutRange));
					this.RefComp = null;
				}
				if (this.PlayerInRangeReal)
				{
					this.OnPlayerInOutRange(false);
				}
				break;
			case EAudioRangeType.RangeComp:
				if (EventSystem.Instance.HasWithTarget<bool>(base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerInOutRange)))
				{
					EventSystem.Instance.RemoveWithTargetUseKey(this, base.Entity, EEventName.OnMyPlayerInOutRangeLocal, new Action<bool>(this.OnPlayerInOutRange));
				}
				break;
			case EAudioRangeType.AOI:
				this.OnPlayerInOutRange(false);
				break;
			}
			return true;
		}

		// Token: 0x06046267 RID: 287335 RVA: 0x0118645C File Offset: 0x0118465C
		[NullableContext(1)]
		protected override void OnDisable(string reason)
		{
			IAudioControlType audioControlConfig = this.AudioControlConfig;
			if ((((audioControlConfig != null) ? new EAudioControlType?(audioControlConfig.Type) : null) ?? EAudioControlType.Traffic) == EAudioControlType.Gramophone)
			{
				this.HandleDisableGramophone(reason);
			}
		}

		// Token: 0x06046268 RID: 287336 RVA: 0x011864A4 File Offset: 0x011846A4
		protected override void OnEnable()
		{
			IAudioControlType audioControlConfig = this.AudioControlConfig;
			if ((((audioControlConfig != null) ? new EAudioControlType?(audioControlConfig.Type) : null) ?? EAudioControlType.Traffic) == EAudioControlType.Gramophone)
			{
				this.HandleEnableGramophone();
			}
		}

		// Token: 0x06046269 RID: 287337 RVA: 0x011864EC File Offset: 0x011846EC
		private void OnPlayerInOutRange(bool isEnter)
		{
			if (isEnter == this.PlayerInRangeReal)
			{
				return;
			}
			this.PlayerInRangeReal = isEnter;
			IAudioControlType audioControlConfig = this.AudioControlConfig;
			if ((((audioControlConfig != null) ? new EAudioControlType?(audioControlConfig.Type) : null) ?? EAudioControlType.Traffic) == EAudioControlType.Gramophone)
			{
				this.HandlePlayerInOutGramophoneRange(isEnter);
			}
		}

		// Token: 0x0604626A RID: 287338 RVA: 0x01186543 File Offset: 0x01184743
		private void HandlePlayerInOutGramophoneRange(bool isEnter)
		{
			if (isEnter)
			{
				PhonographController.Instance.PlayMusicByEntityId(base.Entity.Id);
				return;
			}
			PhonographController.Instance.StopMusicByEntityId(base.Entity.Id);
		}

		// Token: 0x0604626B RID: 287339 RVA: 0x01186573 File Offset: 0x01184773
		[NullableContext(1)]
		private void HandleDisableGramophone(string reason)
		{
			if (this.PlayerInRangeReal)
			{
				this.HandlePlayerInOutGramophoneRange(false);
			}
		}

		// Token: 0x0604626C RID: 287340 RVA: 0x01186584 File Offset: 0x01184784
		private void HandleEnableGramophone()
		{
			if (this.PlayerInRangeReal)
			{
				this.HandlePlayerInOutGramophoneRange(true);
			}
		}

		// Token: 0x0604626D RID: 287341 RVA: 0x01186595 File Offset: 0x01184795
		public IAudioControlType GetAudioControlConfig()
		{
			return this.AudioControlConfig;
		}

		// Token: 0x0604626E RID: 287342 RVA: 0x011865A0 File Offset: 0x011847A0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CustomAudioControlComponent customAudioControlComponent = (CustomAudioControlComponent)componentTemplate;
			if (base.CanResetComponentProperty("AudioControlConfig"))
			{
				if (customAudioControlComponent.AudioControlConfig == null)
				{
					this.AudioControlConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IAudioControlType>(this.AudioControlConfig), "AudioControlConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AudioRangeType"))
			{
				this.AudioRangeType = customAudioControlComponent.AudioRangeType;
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (customAudioControlComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RefComp"))
			{
				if (customAudioControlComponent.RefComp == null)
				{
					this.RefComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemReferenceComponent>(this.RefComp), "RefComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PlayerInRangeReal"))
			{
				this.PlayerInRangeReal = customAudioControlComponent.PlayerInRangeReal;
			}
			return true;
		}

		// Token: 0x04024BF8 RID: 150520
		private IAudioControlType AudioControlConfig;

		// Token: 0x04024BF9 RID: 150521
		private EAudioRangeType AudioRangeType = EAudioRangeType.AOI;

		// Token: 0x04024BFA RID: 150522
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04024BFB RID: 150523
		private SceneItemReferenceComponent RefComp;

		// Token: 0x04024BFC RID: 150524
		private bool PlayerInRangeReal;
	}
}
