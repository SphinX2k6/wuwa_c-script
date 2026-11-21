using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006203 RID: 25091
	[NullableContext(2)]
	[Nullable(0)]
	public class CustomAudioControlComponent : EntityComponent
	{
		// Token: 0x0603C47A RID: 246906 RVA: 0x0112F7F0 File Offset: 0x0112D9F0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			EntityCustomAudioComponent entityCustomAudioComponent = args.GetP1<CreateEntityData>().GetParam<CustomAudioControlComponent>() as EntityCustomAudioComponent;
			this.AudioRangeType = entityCustomAudioComponent.AudioRangeType;
			this.AudioControlConfig = entityCustomAudioComponent.AudioControlType;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x0603C47B RID: 246907 RVA: 0x0112F838 File Offset: 0x0112DA38
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

		// Token: 0x0603C47C RID: 246908 RVA: 0x0112F9A0 File Offset: 0x0112DBA0
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

		// Token: 0x0603C47D RID: 246909 RVA: 0x0112FA54 File Offset: 0x0112DC54
		[NullableContext(1)]
		protected override void OnDisable(string reason)
		{
			IAudioControlType audioControlConfig = this.AudioControlConfig;
			if ((((audioControlConfig != null) ? new EAudioControlType?(audioControlConfig.Type) : null) ?? EAudioControlType.Traffic) == EAudioControlType.Gramophone)
			{
				this.HandleDisableGramophone(reason);
			}
		}

		// Token: 0x0603C47E RID: 246910 RVA: 0x0112FA9C File Offset: 0x0112DC9C
		protected override void OnEnable()
		{
			IAudioControlType audioControlConfig = this.AudioControlConfig;
			if ((((audioControlConfig != null) ? new EAudioControlType?(audioControlConfig.Type) : null) ?? EAudioControlType.Traffic) == EAudioControlType.Gramophone)
			{
				this.HandleEnableGramophone();
			}
		}

		// Token: 0x0603C47F RID: 246911 RVA: 0x0112FAE4 File Offset: 0x0112DCE4
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

		// Token: 0x0603C480 RID: 246912 RVA: 0x0112FB3B File Offset: 0x0112DD3B
		private void HandlePlayerInOutGramophoneRange(bool isEnter)
		{
			if (isEnter)
			{
				PhonographController.Instance.PlayMusicByEntityId(base.Entity.Id);
				return;
			}
			PhonographController.Instance.StopMusicByEntityId(base.Entity.Id);
		}

		// Token: 0x0603C481 RID: 246913 RVA: 0x0112FB6B File Offset: 0x0112DD6B
		[NullableContext(1)]
		private void HandleDisableGramophone(string reason)
		{
			if (this.PlayerInRangeReal)
			{
				this.HandlePlayerInOutGramophoneRange(false);
			}
		}

		// Token: 0x0603C482 RID: 246914 RVA: 0x0112FB7C File Offset: 0x0112DD7C
		private void HandleEnableGramophone()
		{
			if (this.PlayerInRangeReal)
			{
				this.HandlePlayerInOutGramophoneRange(true);
			}
		}

		// Token: 0x0603C483 RID: 246915 RVA: 0x0112FB8D File Offset: 0x0112DD8D
		public IAudioControlType GetAudioControlConfig()
		{
			return this.AudioControlConfig;
		}

		// Token: 0x0603C484 RID: 246916 RVA: 0x0112FB98 File Offset: 0x0112DD98
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CustomAudioControlComponent customAudioControlComponent = (CustomAudioControlComponent)componentTemplate;
			if (customAudioControlComponent.AudioControlConfig == null)
			{
				this.AudioControlConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AudioControlConfig), "AudioControlConfig"))
			{
				return false;
			}
			this.AudioRangeType = customAudioControlComponent.AudioRangeType;
			if (customAudioControlComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (customAudioControlComponent.RefComp == null)
			{
				this.RefComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RefComp), "RefComp"))
			{
				return false;
			}
			this.PlayerInRangeReal = customAudioControlComponent.PlayerInRangeReal;
			return true;
		}

		// Token: 0x170071BF RID: 29119
		// (get) Token: 0x0603C485 RID: 246917 RVA: 0x0112FC51 File Offset: 0x0112DE51
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071C0 RID: 29120
		// (get) Token: 0x0603C486 RID: 246918 RVA: 0x0112FC54 File Offset: 0x0112DE54
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071C1 RID: 29121
		// (get) Token: 0x0603C487 RID: 246919 RVA: 0x0112FC57 File Offset: 0x0112DE57
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071C2 RID: 29122
		// (get) Token: 0x0603C488 RID: 246920 RVA: 0x0112FC5A File Offset: 0x0112DE5A
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEB3 RID: 130739
		private IAudioControlType AudioControlConfig;

		// Token: 0x0401FEB4 RID: 130740
		private EAudioRangeType AudioRangeType = EAudioRangeType.AOI;

		// Token: 0x0401FEB5 RID: 130741
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401FEB6 RID: 130742
		private SceneItemReferenceComponent RefComp;

		// Token: 0x0401FEB7 RID: 130743
		private bool PlayerInRangeReal;
	}
}
