using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.PianoGameplay;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006249 RID: 25161
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemTextComponent : EntityComponent
	{
		// Token: 0x0603CB1B RID: 248603 RVA: 0x0116B108 File Offset: 0x01169308
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			SceneTextComponent sceneTextComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemTextComponent>() as SceneTextComponent;
			if (sceneTextComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[SceneItemTextComponent] 组件配置缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.Config = sceneTextComponent;
			this.ParameterMap = new TMap<string, string>();
			this.ParameterMap.Empty(0);
			this.ConstructParameterMap();
			SceneTextComponent config = this.Config;
			if (!string.IsNullOrEmpty((config != null) ? config.DisplayState : null))
			{
				this.DisplayStateTagId = new int?(GameplayTagUtils.GetTagIdByName(this.Config.DisplayState));
			}
			return true;
		}

		// Token: 0x0603CB1C RID: 248604 RVA: 0x0116B1E0 File Offset: 0x011693E0
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[SceneItemTextComponent] Actor组件缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.StateComp = base.Entity.GetComponent<SceneItemStateComponent>();
			if (this.StateComp == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SceneItem;
				ELogAuthor author2 = ELogAuthor.FJH;
				string message2 = "[SceneItemTextComponent] State组件缺失";
				string item2 = "PbDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new int?(creatureDataComp2.GetPbDataId()) : null);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			if (!EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnStateChange)))
			{
				EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.OnSceneItemStateChange, new Action<int, bool>(this.OnStateChange));
			}
			return true;
		}

		// Token: 0x0603CB1D RID: 248605 RVA: 0x0116B2FD File Offset: 0x011694FD
		protected override void OnActivate()
		{
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
				return;
			}
			this.OnSceneInteractionLoadCompleted();
		}

		// Token: 0x0603CB1E RID: 248606 RVA: 0x0116B338 File Offset: 0x01169538
		private void OnSceneInteractionLoadCompleted()
		{
			FVectorDouble actorLocation = this.ActorComp.ActorLocation;
			FRotator frotator = this.ActorComp.ActorRotation;
			SceneTextComponent config = this.Config;
			if (((config != null) ? config.RelativeTransform : null) != null)
			{
				actorLocation.Set(actorLocation.X + (double)this.Config.RelativeTransform.X.GetValueOrDefault(), actorLocation.Y + (double)this.Config.RelativeTransform.Y.GetValueOrDefault(), actorLocation.Z + (double)this.Config.RelativeTransform.Z.GetValueOrDefault());
				frotator = frotator.Add(this.Config.RelativeTransform.Pitch.GetValueOrDefault(), this.Config.RelativeTransform.A.GetValueOrDefault(), this.Config.RelativeTransform.Roll.GetValueOrDefault());
			}
			FQuat fquat = frotator.Quaternion();
			FVectorDouble fvectorDouble = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble;
			FTransformDouble transform = new FTransformDouble(ref fquat, ref actorLocation, ref fvector);
			this.UiSceneViewActor = (ActorSystem.Instance.Spawn(ASceneUiAnchorActor.StaticClass(), transform, this.ActorComp.Owner) as ASceneUiAnchorActor);
			ASceneUiAnchorActor uiSceneViewActor = this.UiSceneViewActor;
			if (uiSceneViewActor == null || !uiSceneViewActor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[SceneItemTextComponent] BP_SceneUiAnchor加载失败";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.UiSceneViewActor.bLockFaceCamera = false;
			int? displayStateTagId = this.DisplayStateTagId;
			if (displayStateTagId != null && displayStateTagId.GetValueOrDefault() != 0 && this.StateComp.StateTagId == this.DisplayStateTagId.Value)
			{
				this.OpenTextUi();
			}
		}

		// Token: 0x0603CB1F RID: 248607 RVA: 0x0116B540 File Offset: 0x01169740
		protected override bool OnEnd()
		{
			if (this.UiSceneViewActor != null)
			{
				if (this.IsDisplayStateInternal)
				{
					this.UiSceneViewActor.CloseUi();
				}
				ActorSystem.Instance.Put("SceneItemTextComponent 组件销毁", this.UiSceneViewActor, null);
			}
			this.IsDisplayStateInternal = false;
			this.UiSceneViewActor = null;
			return true;
		}

		// Token: 0x0603CB20 RID: 248608 RVA: 0x0116B590 File Offset: 0x01169790
		private void OnStateChange(int stateId, bool isReady)
		{
			if (this.UiSceneViewActor == null)
			{
				return;
			}
			int? displayStateTagId = this.DisplayStateTagId;
			if (displayStateTagId != null && displayStateTagId.GetValueOrDefault() != 0)
			{
				if (this.StateComp.StateTagId == this.DisplayStateTagId.Value)
				{
					this.OpenTextUi();
					return;
				}
				this.CloseTextUi();
			}
		}

		// Token: 0x0603CB21 RID: 248609 RVA: 0x0116B5E4 File Offset: 0x011697E4
		private void OpenTextUi()
		{
			if (this.UiSceneViewActor == null || this.IsDisplayStateInternal || this.ParameterMap == null)
			{
				return;
			}
			this.IsDisplayStateInternal = true;
			if (PianoGameplayModel.Instance.IsInPianoGameplay)
			{
				this.CurrentViewName = "PianoSceneUiViewCover";
			}
			else
			{
				this.CurrentViewName = "PianoSceneUiView";
			}
			this.UiSceneViewActor.OpenWithMap(this.CurrentViewName, this.ParameterMap);
			EventSystem.Instance.Emit<int>(EEventName.OnSceneTextOpen, this.CreatureDataComp.GetPbDataId());
		}

		// Token: 0x0603CB22 RID: 248610 RVA: 0x0116B667 File Offset: 0x01169867
		private void CloseTextUi()
		{
			if (this.UiSceneViewActor == null || !this.IsDisplayStateInternal)
			{
				return;
			}
			this.IsDisplayStateInternal = false;
			this.UiSceneViewActor.CloseUi();
			EventSystem.Instance.Emit<int>(EEventName.OnSceneTextClose, this.CreatureDataComp.GetPbDataId());
		}

		// Token: 0x0603CB23 RID: 248611 RVA: 0x0116B6A8 File Offset: 0x011698A8
		private void ConstructParameterMap()
		{
			if (this.Config == null || this.ParameterMap == null)
			{
				return;
			}
			if (this.Config.TextConfig.Type == ESceneTextType.SubtitleWithVoice)
			{
				ISceneTextSubtitleWithVoice sceneTextSubtitleWithVoice = this.Config.TextConfig as ISceneTextSubtitleWithVoice;
				if (sceneTextSubtitleWithVoice != null)
				{
					this.ConstructSubtitleWithVoiceParameterMap(sceneTextSubtitleWithVoice);
				}
			}
		}

		// Token: 0x0603CB24 RID: 248612 RVA: 0x0116B6F4 File Offset: 0x011698F4
		[NullableContext(1)]
		private void ConstructSubtitleWithVoiceParameterMap(ISceneTextSubtitleWithVoice textConfig)
		{
			this.ParameterMap.Empty(0);
			this.ParameterMap.Add("FlowGuid", textConfig.Content.FlowGuid ?? "");
			this.ParameterMap.Add("FlowId", textConfig.Content.FlowId.ToString());
			this.ParameterMap.Add("StateId", textConfig.Content.StateId.ToString());
			this.ParameterMap.Add("FlowListName", textConfig.Content.FlowListName ?? "");
			this.ParameterMap.Add("FontSize", textConfig.FontSize.ToString());
			this.ParameterMap.Add("BoxWidth", textConfig.BoxWidth.ToString());
			this.ParameterMap.Add("BoxHeight", textConfig.BoxHeight.ToString());
			if (textConfig.Duration != null)
			{
				this.ParameterMap.Add("Duration", textConfig.Duration.Value.ToString());
			}
			if (textConfig.AutoHide != null)
			{
				this.ParameterMap.Add("AutoHide", textConfig.AutoHide.Value ? "true" : "false");
			}
			TMap<string, string> parameterMap = this.ParameterMap;
			string key = "FadeInEffect";
			ESceneTextFadeInEffect? fadeInEffect = textConfig.FadeInEffect;
			int? num;
			int? num2;
			if (fadeInEffect == null)
			{
				num = null;
				num2 = num;
			}
			else
			{
				num2 = new int?((int)fadeInEffect.GetValueOrDefault());
			}
			num = num2;
			parameterMap.Add(key, ((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "");
			TMap<string, string> parameterMap2 = this.ParameterMap;
			string key2 = "FadeOutEffect";
			ESceneTextFadeOutEffect? fadeOutEffect = textConfig.FadeOutEffect;
			int? num3;
			if (fadeOutEffect == null)
			{
				num = null;
				num3 = num;
			}
			else
			{
				num3 = new int?((int)fadeOutEffect.GetValueOrDefault());
			}
			num = num3;
			parameterMap2.Add(key2, ((num != null) ? num.GetValueOrDefault().ToString() : null) ?? "");
			TMap<string, string> parameterMap3 = this.ParameterMap;
			string key3 = "OwnerId";
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			parameterMap3.Add(key3, ((creatureDataComp != null) ? creatureDataComp.GetPbDataId().ToString() : null) ?? "");
		}

		// Token: 0x0603CB25 RID: 248613 RVA: 0x0116B958 File Offset: 0x01169B58
		public void StopTextVoice()
		{
			if (!this.IsDisplayStateInternal)
			{
				return;
			}
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.OnSceneTextVoiceClose);
		}

		// Token: 0x0603CB26 RID: 248614 RVA: 0x0116B97C File Offset: 0x01169B7C
		[NullableContext(1)]
		public void HotFixConfig(SceneTextComponent config)
		{
			this.Config = config;
			this.ConstructParameterMap();
			if (this.UiSceneViewActor != null)
			{
				FVectorDouble actorLocation = this.ActorComp.ActorLocation;
				FRotator frotator = this.ActorComp.ActorRotation;
				SceneTextComponent config2 = this.Config;
				if (((config2 != null) ? config2.RelativeTransform : null) != null)
				{
					actorLocation.Set(actorLocation.X + (double)this.Config.RelativeTransform.X.GetValueOrDefault(), actorLocation.Y + (double)this.Config.RelativeTransform.Y.GetValueOrDefault(), actorLocation.Z + (double)this.Config.RelativeTransform.Z.GetValueOrDefault());
					frotator = frotator.Add(this.Config.RelativeTransform.Pitch.GetValueOrDefault(), this.Config.RelativeTransform.A.GetValueOrDefault(), this.Config.RelativeTransform.Roll.GetValueOrDefault());
				}
				FQuat fquat = frotator.Quaternion();
				FVectorDouble fvectorDouble = new FVectorDouble(1.0, 1.0, 1.0);
				FVector fvector = fvectorDouble;
				FTransformDouble ftransformDouble = new FTransformDouble(ref fquat, ref actorLocation, ref fvector);
				this.UiSceneViewActor.D_K2_SetActorTransform(ftransformDouble, false, null, true);
				this.UiSceneViewActor.DestroyUi();
				if (!string.IsNullOrEmpty(this.CurrentViewName))
				{
					this.UiSceneViewActor.OpenWithMap(this.CurrentViewName, this.ParameterMap);
				}
			}
		}

		// Token: 0x0603CB27 RID: 248615 RVA: 0x0116BB08 File Offset: 0x01169D08
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemTextComponent sceneItemTextComponent = (SceneItemTextComponent)componentTemplate;
			if (sceneItemTextComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemTextComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemTextComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (sceneItemTextComponent.UiSceneViewActor == null)
			{
				this.UiSceneViewActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UiSceneViewActor), "UiSceneViewActor"))
			{
				return false;
			}
			if (sceneItemTextComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			this.IsDisplayStateInternal = sceneItemTextComponent.IsDisplayStateInternal;
			if (sceneItemTextComponent.ParameterMap == null)
			{
				this.ParameterMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<string, string>(this.ParameterMap), "ParameterMap"))
			{
				return false;
			}
			this.CurrentViewName = sceneItemTextComponent.CurrentViewName;
			this.DisplayStateTagId = sceneItemTextComponent.DisplayStateTagId;
			return true;
		}

		// Token: 0x170072CF RID: 29391
		// (get) Token: 0x0603CB28 RID: 248616 RVA: 0x0116BC4E File Offset: 0x01169E4E
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072D0 RID: 29392
		// (get) Token: 0x0603CB29 RID: 248617 RVA: 0x0116BC51 File Offset: 0x01169E51
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072D1 RID: 29393
		// (get) Token: 0x0603CB2A RID: 248618 RVA: 0x0116BC54 File Offset: 0x01169E54
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040202D5 RID: 131797
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x040202D6 RID: 131798
		private SceneItemActorComponent ActorComp;

		// Token: 0x040202D7 RID: 131799
		private SceneItemStateComponent StateComp;

		// Token: 0x040202D8 RID: 131800
		private ASceneUiAnchorActor UiSceneViewActor;

		// Token: 0x040202D9 RID: 131801
		private SceneTextComponent Config;

		// Token: 0x040202DA RID: 131802
		private bool IsDisplayStateInternal;

		// Token: 0x040202DB RID: 131803
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> ParameterMap;

		// Token: 0x040202DC RID: 131804
		private string CurrentViewName;

		// Token: 0x040202DD RID: 131805
		private int? DisplayStateTagId;
	}
}
