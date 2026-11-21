using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using CSharpScript.Game.Input;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006333 RID: 25395
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterOverShoulderComponent : EntityComponent
	{
		// Token: 0x170074C7 RID: 29895
		// (get) Token: 0x0603D876 RID: 252022 RVA: 0x011D0E6A File Offset: 0x011CF06A
		[Nullable(1)]
		public override Type[] Dependencies
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

		// Token: 0x0603D877 RID: 252023 RVA: 0x011D0E9C File Offset: 0x011CF09C
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

		// Token: 0x0603D878 RID: 252024 RVA: 0x011D0F05 File Offset: 0x011CF105
		protected override bool OnEnd()
		{
			this.RemoveChangeOverShoulderModeListener();
			return true;
		}

		// Token: 0x0603D879 RID: 252025 RVA: 0x011D0F0E File Offset: 0x011CF10E
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

		// Token: 0x0603D87A RID: 252026 RVA: 0x011D0F49 File Offset: 0x011CF149
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

		// Token: 0x0603D87B RID: 252027 RVA: 0x011D0F88 File Offset: 0x011CF188
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

		// Token: 0x0603D87C RID: 252028 RVA: 0x011D0FE6 File Offset: 0x011CF1E6
		private void RemoveOverShoulderInputLayer()
		{
			if (this.OverShoulderModeInputLayer != null)
			{
				InputController.Instance.RemoveInputLayer(this.OverShoulderModeInputLayer);
				this.OverShoulderModeInputLayer.Clear();
				this.OverShoulderModeInputLayer = null;
			}
		}

		// Token: 0x0603D87D RID: 252029 RVA: 0x011D1012 File Offset: 0x011CF212
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

		// Token: 0x0603D87E RID: 252030 RVA: 0x011D1034 File Offset: 0x011CF234
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

		// Token: 0x0603D87F RID: 252031 RVA: 0x011D10D0 File Offset: 0x011CF2D0
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

		// Token: 0x0603D880 RID: 252032 RVA: 0x011D1194 File Offset: 0x011CF394
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterOverShoulderComponent characterOverShoulderComponent = (CharacterOverShoulderComponent)componentTemplate;
			if (characterOverShoulderComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterOverShoulderComponent.InputComp == null)
			{
				this.InputComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
			{
				return false;
			}
			if (characterOverShoulderComponent.StateComp == null)
			{
				this.StateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.StateComp), "StateComp"))
			{
				return false;
			}
			if (characterOverShoulderComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (characterOverShoulderComponent.GaitComp == null)
			{
				this.GaitComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GaitComp), "GaitComp"))
			{
				return false;
			}
			this.IsOverShoulderMode = characterOverShoulderComponent.IsOverShoulderMode;
			if (characterOverShoulderComponent.OverShoulderModeInputLayer == null)
			{
				this.OverShoulderModeInputLayer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OverShoulderModeInputLayer), "OverShoulderModeInputLayer"))
			{
				return false;
			}
			if (characterOverShoulderComponent.OverShoulderConfig == null)
			{
				this.OverShoulderConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OverShoulderConfig), "OverShoulderConfig"))
			{
				return false;
			}
			if (characterOverShoulderComponent.ChangeOverShoulderMode == null)
			{
				this.ChangeOverShoulderMode = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChangeOverShoulderMode), "ChangeOverShoulderMode"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170074C8 RID: 29896
		// (get) Token: 0x0603D881 RID: 252033 RVA: 0x011D1318 File Offset: 0x011CF518
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074C9 RID: 29897
		// (get) Token: 0x0603D882 RID: 252034 RVA: 0x011D131B File Offset: 0x011CF51B
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A31 RID: 133681
		[Nullable(1)]
		private const string OVER_SHOULDER_CONFIG_PATH = "/Game/Aki/Character/Role/Common/Data/DA/DA_OverShoulderModeConfig.DA_OverShoulderModeConfig";

		// Token: 0x04020A32 RID: 133682
		public CharacterActorComponent ActorComp;

		// Token: 0x04020A33 RID: 133683
		public CharacterInputComponent InputComp;

		// Token: 0x04020A34 RID: 133684
		public CharacterUnifiedStateComponent StateComp;

		// Token: 0x04020A35 RID: 133685
		public BaseTagComponent TagComp;

		// Token: 0x04020A36 RID: 133686
		public RoleGaitComponent GaitComp;

		// Token: 0x04020A37 RID: 133687
		private bool IsOverShoulderMode;

		// Token: 0x04020A38 RID: 133688
		private OverShoulderInputLayer OverShoulderModeInputLayer;

		// Token: 0x04020A39 RID: 133689
		private OverShoulderModeConfig OverShoulderConfig;

		// Token: 0x04020A3A RID: 133690
		private ITagTask ChangeOverShoulderMode;
	}
}
