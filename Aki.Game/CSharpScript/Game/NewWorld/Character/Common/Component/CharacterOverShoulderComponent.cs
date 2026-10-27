using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070CF RID: 28879
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterOverShoulderComponent : EntityComponent
	{
		// Token: 0x17009CAE RID: 40110
		// (get) Token: 0x0604677A RID: 288634 RVA: 0x011B1C26 File Offset: 0x011AFE26
		[Nullable(1)]
		public new static Type[] Dependencies
		{
			[NullableContext(1)]
			get
			{
				return new Type[]
				{
					typeof(CharacterActorComponent),
					typeof(CharacterInputComponent),
					typeof(BaseTagComponent)
				};
			}
		}

		// Token: 0x0604677B RID: 288635 RVA: 0x011B1C58 File Offset: 0x011AFE58
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.InputComp = base.Entity.GetComponent<CharacterInputComponent>();
			this.StateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.GaitComp = base.Entity.GetComponent<RoleGaitComponent>();
			this.AddChangeOverShoulderModeListener();
			return true;
		}

		// Token: 0x0604677C RID: 288636 RVA: 0x011B1CC1 File Offset: 0x011AFEC1
		protected override bool OnEnd()
		{
			this.RemoveChangeOverShoulderModeListener();
			return true;
		}

		// Token: 0x0604677D RID: 288637 RVA: 0x011B1CCA File Offset: 0x011AFECA
		private void AddChangeOverShoulderModeListener()
		{
			BaseTagComponent tagComp = this.TagComp;
			this.ChangeOverShoulderMode = ((tagComp != null) ? tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.越肩模式"]), delegate(int tagId, bool tagExists)
			{
				if (tagExists)
				{
					this.TryLoadAndInitFromOverShoulderConfigAsset();
					return;
				}
				this.ClearOverShoulderModeState();
			}, null) : null);
		}

		// Token: 0x0604677E RID: 288638 RVA: 0x011B1D05 File Offset: 0x011AFF05
		private void RemoveChangeOverShoulderModeListener()
		{
			this.ClearOverShoulderModeState();
			OverShoulderModeConfig overShoulderConfig = this.OverShoulderConfig;
			if (overShoulderConfig != null)
			{
				overShoulderConfig.TryAddOrRemoveTags(base.Entity, false);
			}
			this.OverShoulderConfig = null;
			ITagTask changeOverShoulderMode = this.ChangeOverShoulderMode;
			if (changeOverShoulderMode != null)
			{
				changeOverShoulderMode.EndTask();
			}
			this.ChangeOverShoulderMode = null;
		}

		// Token: 0x0604677F RID: 288639 RVA: 0x011B1D44 File Offset: 0x011AFF44
		private void CreateOverShoulderInputLayer()
		{
			if (this.OverShoulderModeInputLayer != null)
			{
				this.RemoveOverShoulderInputLayer();
			}
			this.OverShoulderModeInputLayer = (InputController.Instance.CreateInputLayer(EInputLayer.OverShoulder) as OverShoulderInputLayer);
			this.OverShoulderModeInputLayer.Init(base.Entity);
			InputController.Instance.AddInputLayer(base.Entity.Id, this.OverShoulderModeInputLayer);
		}

		// Token: 0x06046780 RID: 288640 RVA: 0x011B1DA2 File Offset: 0x011AFFA2
		private void RemoveOverShoulderInputLayer()
		{
			if (this.OverShoulderModeInputLayer != null)
			{
				InputController.Instance.RemoveInputLayer(this.OverShoulderModeInputLayer);
				this.OverShoulderModeInputLayer.Clear();
				this.OverShoulderModeInputLayer = null;
			}
		}

		// Token: 0x06046781 RID: 288641 RVA: 0x011B1DCE File Offset: 0x011AFFCE
		private void TryLoadAndInitFromOverShoulderConfigAsset()
		{
			ResourceSystem.Instance.LoadTypeAsync("BP_OverShoulderModeConfig_C", delegate
			{
				ResourceSystem.Instance.LoadAsync<BP_OverShoulderModeConfig_C>("/Game/Aki/Character/Role/Common/Data/DA/DA_OverShoulderModeConfig.DA_OverShoulderModeConfig", delegate([Nullable(2)] BP_OverShoulderModeConfig_C asset, string _)
				{
					if (asset == null || !asset.IsValid())
					{
						return;
					}
					OverShoulderModeConfig overShoulderModeConfig = new OverShoulderModeConfig();
					overShoulderModeConfig.InitFromAsset(asset);
					if (!overShoulderModeConfig.IsValid())
					{
						return;
					}
					this.OverShoulderConfig = overShoulderModeConfig;
					this.InitOverShoulderModeState();
				}, 100, "js_undefined");
			}, "js_undefined");
		}

		// Token: 0x06046782 RID: 288642 RVA: 0x011B1DF0 File Offset: 0x011AFFF0
		private void InitOverShoulderModeState()
		{
			if (this.IsOverShoulderMode)
			{
				return;
			}
			this.IsOverShoulderMode = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[OverShoulderMode] 进入越肩模式";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			OverShoulderModeConfig overShoulderConfig = this.OverShoulderConfig;
			if (overShoulderConfig != null)
			{
				overShoulderConfig.TryAddOrRemoveTags(base.Entity, true);
			}
			this.CreateOverShoulderInputLayer();
			CharacterInputComponent inputComp = this.InputComp;
			if (inputComp != null)
			{
				inputComp.EnableOverShoulderMode(this.OverShoulderConfig);
			}
			RoleGaitComponent gaitComp = this.GaitComp;
			if (gaitComp == null)
			{
				return;
			}
			gaitComp.EnableSprintStop(false);
		}

		// Token: 0x06046783 RID: 288643 RVA: 0x011B1E8C File Offset: 0x011B008C
		private void ClearOverShoulderModeState()
		{
			if (!this.IsOverShoulderMode)
			{
				return;
			}
			this.IsOverShoulderMode = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[OverShoulderMode] 退出越肩模式";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			OverShoulderModeConfig overShoulderConfig = this.OverShoulderConfig;
			if (overShoulderConfig != null)
			{
				overShoulderConfig.TryAddOrRemoveTags(base.Entity, false);
			}
			CharacterUnifiedStateComponent stateComp = this.StateComp;
			if (stateComp != null)
			{
				stateComp.SetDirectionState(ECharDirectionState.FaceDirection);
			}
			Entity entity = base.Entity;
			if (entity != null)
			{
				BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
				if (component != null)
				{
					component.SetLockedRotation(false);
				}
			}
			this.RemoveOverShoulderInputLayer();
			CharacterInputComponent inputComp = this.InputComp;
			if (inputComp != null)
			{
				inputComp.EnableOverShoulderMode(null);
			}
			RoleGaitComponent gaitComp = this.GaitComp;
			if (gaitComp == null)
			{
				return;
			}
			gaitComp.EnableSprintStop(true);
		}

		// Token: 0x06046784 RID: 288644 RVA: 0x011B1F50 File Offset: 0x011B0150
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterOverShoulderComponent characterOverShoulderComponent = (CharacterOverShoulderComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterOverShoulderComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InputComp"))
			{
				if (characterOverShoulderComponent.InputComp == null)
				{
					this.InputComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterInputComponent>(this.InputComp), "InputComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("StateComp"))
			{
				if (characterOverShoulderComponent.StateComp == null)
				{
					this.StateComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.StateComp), "StateComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (characterOverShoulderComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("GaitComp"))
			{
				if (characterOverShoulderComponent.GaitComp == null)
				{
					this.GaitComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<RoleGaitComponent>(this.GaitComp), "GaitComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsOverShoulderMode"))
			{
				this.IsOverShoulderMode = characterOverShoulderComponent.IsOverShoulderMode;
			}
			if (base.CanResetComponentProperty("OverShoulderModeInputLayer"))
			{
				if (characterOverShoulderComponent.OverShoulderModeInputLayer == null)
				{
					this.OverShoulderModeInputLayer = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<OverShoulderInputLayer>(this.OverShoulderModeInputLayer), "OverShoulderModeInputLayer"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("OverShoulderConfig"))
			{
				if (characterOverShoulderComponent.OverShoulderConfig == null)
				{
					this.OverShoulderConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<OverShoulderModeConfig>(this.OverShoulderConfig), "OverShoulderConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ChangeOverShoulderMode"))
			{
				if (characterOverShoulderComponent.ChangeOverShoulderMode == null)
				{
					this.ChangeOverShoulderMode = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.ChangeOverShoulderMode), "ChangeOverShoulderMode"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024EF2 RID: 151282
		[Nullable(1)]
		private const string OVER_SHOULDER_CONFIG_PATH = "/Game/Aki/Character/Role/Common/Data/DA/DA_OverShoulderModeConfig.DA_OverShoulderModeConfig";

		// Token: 0x04024EF3 RID: 151283
		public CharacterActorComponent ActorComp;

		// Token: 0x04024EF4 RID: 151284
		public CharacterInputComponent InputComp;

		// Token: 0x04024EF5 RID: 151285
		public CharacterUnifiedStateComponent StateComp;

		// Token: 0x04024EF6 RID: 151286
		public BaseTagComponent TagComp;

		// Token: 0x04024EF7 RID: 151287
		public RoleGaitComponent GaitComp;

		// Token: 0x04024EF8 RID: 151288
		private bool IsOverShoulderMode;

		// Token: 0x04024EF9 RID: 151289
		private OverShoulderInputLayer OverShoulderModeInputLayer;

		// Token: 0x04024EFA RID: 151290
		private OverShoulderModeConfig OverShoulderConfig;

		// Token: 0x04024EFB RID: 151291
		private ITagTask ChangeOverShoulderMode;
	}
}
