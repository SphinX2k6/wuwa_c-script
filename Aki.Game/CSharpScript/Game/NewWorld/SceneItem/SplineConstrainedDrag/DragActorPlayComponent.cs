using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.SplineConstrainedDrag
{
	// Token: 0x0200625A RID: 25178
	[NullableContext(1)]
	[Nullable(0)]
	public class DragActorPlayComponent : EntityComponent
	{
		// Token: 0x170072F1 RID: 29425
		// (get) Token: 0x0603CC04 RID: 248836 RVA: 0x01171166 File Offset: 0x0116F366
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CreatureDataComponent),
					typeof(SceneItemReferenceComponent)
				};
			}
		}

		// Token: 0x0603CC05 RID: 248837 RVA: 0x01171188 File Offset: 0x0116F388
		[NullableContext(2)]
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			DragActorPlayComponent compConfig = args.GetP1<CreateEntityData>().GetParam<DragActorPlayComponent>() as DragActorPlayComponent;
			this.CompConfig = compConfig;
			if (this.CompConfig == null)
			{
				return false;
			}
			this.ActorKeyToConfig = new Dictionary<string, IDragActorPlayConfig>();
			foreach (IDragActorPlayConfig dragActorPlayConfig in this.CompConfig.Configs)
			{
				string[] array = dragActorPlayConfig.DraggableActor.PathName.Split('.', StringSplitOptions.None);
				if (array.Length < 3)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.LevelPlay;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "[DragActorPlayComponent] OnInitData: Invalid DraggableActor PathName";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PathName", dragActorPlayConfig.DraggableActor.PathName);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					string key = array[1] + "." + array[2];
					this.ActorKeyToConfig[key] = dragActorPlayConfig;
				}
			}
			List<string> list = new List<string>();
			foreach (IDragActorPlayConfig dragActorPlayConfig2 in this.CompConfig.Configs)
			{
				list.Add(dragActorPlayConfig2.DraggableActorEffectDa);
			}
			SplineConstrainedDragController.Instance.PreloadSelectionMaterials(this.CreatureDataComp.GetPbDataId(), list);
			return true;
		}

		// Token: 0x0603CC06 RID: 248838 RVA: 0x011712FC File Offset: 0x0116F4FC
		protected override bool OnInit()
		{
			this.RefComp = base.Entity.GetComponent<SceneItemReferenceComponent>();
			if (this.RefComp == null)
			{
				return false;
			}
			foreach (IDragActorPlayConfig dragActorPlayConfig in this.CompConfig.Configs)
			{
				this.RefComp.RegisterCustomRefActor(dragActorPlayConfig.DraggableActor);
			}
			return true;
		}

		// Token: 0x0603CC07 RID: 248839 RVA: 0x0117137C File Offset: 0x0116F57C
		protected override bool OnStart()
		{
			UKuroActorSubsystem ukuroActorSubsystem = UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroActorSubsystem.StaticClass()) as UKuroActorSubsystem;
			if (this.RefComp != null)
			{
				this.RefComp.AddOnRefActorReadyCallback(new Action<string, AActor>(this.OnRefActorReady));
			}
			foreach (IDragActorPlayConfig dragActorPlayConfig in this.CompConfig.Configs)
			{
				string[] array = dragActorPlayConfig.DraggableActor.PathName.Split('.', StringSplitOptions.None);
				if (array.Length >= 3)
				{
					string text = array[1] + "." + array[2];
					AActor aactor = (ukuroActorSubsystem != null) ? ukuroActorSubsystem.GetActor(FNameUtil.GetDynamicFName(text) ?? FNameUtil.NONE) : null;
					if (aactor != null)
					{
						this.RegisterKuroSplineConstrainedDrag(text, aactor, dragActorPlayConfig);
					}
				}
			}
			this.InstallEffectVisibilityProviders();
			return true;
		}

		// Token: 0x0603CC08 RID: 248840 RVA: 0x01171478 File Offset: 0x0116F678
		protected override bool OnClear()
		{
			if (this.RefComp != null)
			{
				this.RefComp.RemoveOnRefActorReadyCallback(new Action<string, AActor>(this.OnRefActorReady));
			}
			this.RefComp = null;
			this.UninstallEffectVisibilityProviders();
			foreach (KeyValuePair<string, IKuroSplineConstrainedDrag> keyValuePair in this.RegisteredDrags)
			{
				string text;
				IKuroSplineConstrainedDrag kuroSplineConstrainedDrag;
				keyValuePair.Deconstruct(out text, out kuroSplineConstrainedDrag);
				IKuroSplineConstrainedDrag drag = kuroSplineConstrainedDrag;
				SplineConstrainedDragController.Instance.OnDraggableUnregistered(drag);
			}
			this.RegisteredDrags.Clear();
			foreach (KeyValuePair<string, ISequenceProgressController> keyValuePair2 in this.SeqControllers)
			{
				string text;
				ISequenceProgressController sequenceProgressController;
				keyValuePair2.Deconstruct(out text, out sequenceProgressController);
				sequenceProgressController.Destroy();
			}
			this.SeqControllers.Clear();
			if (this.CreatureDataComp != null)
			{
				SplineConstrainedDragController.Instance.ReleaseSelectionMaterialsByHolder(this.CreatureDataComp.GetPbDataId());
			}
			this.CachedEntityContext = null;
			return true;
		}

		// Token: 0x0603CC09 RID: 248841 RVA: 0x01171594 File Offset: 0x0116F794
		private void InstallEffectVisibilityProviders()
		{
			if (this.CompConfig == null)
			{
				return;
			}
			foreach (IDragActorPlayConfig dragActorPlayConfig in this.CompConfig.Configs)
			{
				int targetPbDataId = dragActorPlayConfig.EffectSplineEntityId.GetValueOrDefault();
				if (targetPbDataId > 0 && !this.EffectVisibilityRecords.ContainsKey(targetPbDataId))
				{
					string[] array = dragActorPlayConfig.DraggableActor.PathName.Split('.', StringSplitOptions.None);
					string ownerActorKey = (array.Length >= 3) ? (array[1] + "." + array[2]) : null;
					DragPlayEffectVisibilityProvider provider = new DragPlayEffectVisibilityProvider(dragActorPlayConfig.Condition, new Func<GeneralContext>(this.GetEntityContext), ownerActorKey);
					IEffectVisibilityRecord record = new EffectVisibilityRecord
					{
						Provider = provider
					};
					this.EffectVisibilityRecords[targetPbDataId] = record;
					Action action = LevelGamePlayModel.Instance.RegisterPendingGuidePathHandler(targetPbDataId, delegate(IGuidePathVisibilityHost host)
					{
						if (!this.EffectVisibilityRecords.ContainsKey(targetPbDataId))
						{
							return;
						}
						record.Attached = host;
						record.CancelPending = null;
						host.SetExternalVisibilityProvider(provider, new EGuidePathProviderRemovedBehavior?(EGuidePathProviderRemovedBehavior.RestoreDefault));
						provider.AttachTo(host);
					});
					if (action != null)
					{
						record.CancelPending = action;
					}
				}
			}
		}

		// Token: 0x0603CC0A RID: 248842 RVA: 0x011716F0 File Offset: 0x0116F8F0
		private void UninstallEffectVisibilityProviders()
		{
			foreach (KeyValuePair<int, IEffectVisibilityRecord> keyValuePair in this.EffectVisibilityRecords)
			{
				int num;
				IEffectVisibilityRecord effectVisibilityRecord;
				keyValuePair.Deconstruct(out num, out effectVisibilityRecord);
				IEffectVisibilityRecord effectVisibilityRecord2 = effectVisibilityRecord;
				if (effectVisibilityRecord2.CancelPending != null)
				{
					effectVisibilityRecord2.CancelPending();
					effectVisibilityRecord2.CancelPending = null;
				}
				if (effectVisibilityRecord2.Attached != null)
				{
					effectVisibilityRecord2.Attached.ClearExternalVisibilityProvider(effectVisibilityRecord2.Provider);
					effectVisibilityRecord2.Attached = null;
				}
				effectVisibilityRecord2.Provider.OnDetached();
			}
			this.EffectVisibilityRecords.Clear();
		}

		// Token: 0x0603CC0B RID: 248843 RVA: 0x011717A0 File Offset: 0x0116F9A0
		[NullableContext(2)]
		private GeneralContext GetEntityContext()
		{
			if (this.CachedEntityContext == null)
			{
				this.CachedEntityContext = EntityContext.Create(base.Entity.Id, null);
			}
			return this.CachedEntityContext;
		}

		// Token: 0x0603CC0C RID: 248844 RVA: 0x011717DC File Offset: 0x0116F9DC
		[return: Nullable(2)]
		private ISequenceProgressController GetOrCreateSeqController(string actorKey, IDragActorPlayConfig config)
		{
			if (this.RefComp == null)
			{
				return null;
			}
			ISequenceProgressController sequenceProgressController;
			if (this.SeqControllers.TryGetValue(actorKey, out sequenceProgressController))
			{
				sequenceProgressController.Destroy();
			}
			ISequenceProgressController sequenceProgressController2 = this.RefComp.CreateSequenceProgressController(config.Sequence);
			if (sequenceProgressController2 == null)
			{
				return null;
			}
			this.SeqControllers[actorKey] = sequenceProgressController2;
			return sequenceProgressController2;
		}

		// Token: 0x0603CC0D RID: 248845 RVA: 0x01171830 File Offset: 0x0116FA30
		private unsafe void OnRefActorReady(string actorKey, AActor actor)
		{
			IDragActorPlayConfig dragActorPlayConfig = null;
			Dictionary<string, IDragActorPlayConfig> actorKeyToConfig = this.ActorKeyToConfig;
			if (actorKeyToConfig != null)
			{
				actorKeyToConfig.TryGetValue(actorKey, out dragActorPlayConfig);
			}
			if (dragActorPlayConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[DragActorPlayComponent] OnRefActorReady: Invalid DraggableActor PathName";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PathName", actorKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorKeyToConfig", this.ActorKeyToConfig);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.RegisterKuroSplineConstrainedDrag(actorKey, actor, dragActorPlayConfig);
		}

		// Token: 0x0603CC0E RID: 248846 RVA: 0x011718BC File Offset: 0x0116FABC
		private void RegisterKuroSplineConstrainedDrag(string actorKey, AActor actor, IDragActorPlayConfig config)
		{
			int pbDataId = this.CreatureDataComp.GetPbDataId();
			long creatureDataId = this.CreatureDataComp.GetCreatureDataId();
			USplineComponent constraintSpline = GameSplineModel.Instance.LoadAndGetSplineComponent(config.SplineEntityId, pbDataId, EIdType.PbDataId);
			TsKuroSplineConstrainedDragImpl tsKuroSplineConstrainedDragImpl = KuroSplineConstrainedDragFactory.Create(new KuroSplineConstrainedDragParam
			{
				ActorKey = actorKey,
				ConstraintSpline = constraintSpline,
				Actor = actor,
				SequenceProgressController = this.GetOrCreateSeqController(actorKey, config),
				KeyPoints = config.KeyPoints,
				CreatureDataId = new long?(creatureDataId),
				MaxPlaySpeed = new float?(config.MaxPlaySpeed),
				Stiffness = config.Stiffness,
				Damping = config.Damping,
				DraggableActorEffectDa = config.DraggableActorEffectDa,
				Condition = config.Condition,
				IgnoreRotation = config.IgnoreRotation,
				AkEvent = ((!string.IsNullOrEmpty(config.DragAkEvent)) ? AudioSystem.Instance.parseAudioEventPath(config.DragAkEvent) : null),
				DragHintType = config.DragHintType
			});
			IKuroSplineConstrainedDrag valueOrDefault = this.RegisteredDrags.GetValueOrDefault(actorKey);
			if (valueOrDefault != null)
			{
				SplineConstrainedDragController.Instance.OnDraggableUnregistered(valueOrDefault);
			}
			this.RegisteredDrags[actorKey] = tsKuroSplineConstrainedDragImpl;
			SplineConstrainedDragController.Instance.OnDraggableRegistered(tsKuroSplineConstrainedDragImpl);
		}

		// Token: 0x0603CC0F RID: 248847 RVA: 0x011719F0 File Offset: 0x0116FBF0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			DragActorPlayComponent dragActorPlayComponent = (DragActorPlayComponent)componentTemplate;
			if (dragActorPlayComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (dragActorPlayComponent.CompConfig == null)
			{
				this.CompConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CompConfig), "CompConfig"))
			{
				return false;
			}
			if (dragActorPlayComponent.ActorKeyToConfig == null)
			{
				this.ActorKeyToConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorKeyToConfig), "ActorKeyToConfig"))
			{
				return false;
			}
			if (dragActorPlayComponent.RefComp == null)
			{
				this.RefComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RefComp), "RefComp"))
			{
				return false;
			}
			if (dragActorPlayComponent.SeqControllers != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SeqControllers), "SeqControllers"))
			{
				return false;
			}
			if (dragActorPlayComponent.RegisteredDrags != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.RegisteredDrags), "RegisteredDrags"))
			{
				return false;
			}
			if (dragActorPlayComponent.EffectVisibilityRecords != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.EffectVisibilityRecords), "EffectVisibilityRecords"))
			{
				return false;
			}
			if (dragActorPlayComponent.CachedEntityContext == null)
			{
				this.CachedEntityContext = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedEntityContext), "CachedEntityContext"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170072F2 RID: 29426
		// (get) Token: 0x0603CC10 RID: 248848 RVA: 0x01171B4D File Offset: 0x0116FD4D
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072F3 RID: 29427
		// (get) Token: 0x0603CC11 RID: 248849 RVA: 0x01171B50 File Offset: 0x0116FD50
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072F4 RID: 29428
		// (get) Token: 0x0603CC12 RID: 248850 RVA: 0x01171B53 File Offset: 0x0116FD53
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020355 RID: 131925
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04020356 RID: 131926
		[Nullable(2)]
		private DragActorPlayComponent CompConfig;

		// Token: 0x04020357 RID: 131927
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, IDragActorPlayConfig> ActorKeyToConfig;

		// Token: 0x04020358 RID: 131928
		[Nullable(2)]
		private SceneItemReferenceComponent RefComp;

		// Token: 0x04020359 RID: 131929
		private readonly Dictionary<string, ISequenceProgressController> SeqControllers = new Dictionary<string, ISequenceProgressController>();

		// Token: 0x0402035A RID: 131930
		private readonly Dictionary<string, IKuroSplineConstrainedDrag> RegisteredDrags = new Dictionary<string, IKuroSplineConstrainedDrag>();

		// Token: 0x0402035B RID: 131931
		private readonly Dictionary<int, IEffectVisibilityRecord> EffectVisibilityRecords = new Dictionary<int, IEffectVisibilityRecord>();

		// Token: 0x0402035C RID: 131932
		[Nullable(2)]
		private GeneralContext CachedEntityContext;
	}
}
