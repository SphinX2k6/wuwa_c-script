using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using AkiClient.Game.Aki.UI.Manager;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003503 RID: 13571
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCharacterFoliageEffect : IStaticVariableResetter
	{
		// Token: 0x06022899 RID: 141465 RVA: 0x009CD858 File Offset: 0x009CBA58
		static SceneCharacterFoliageEffect()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneCharacterFoliageEffect.CreateStaticDefaultValue), new Action(SceneCharacterFoliageEffect.ResetStaticDefaultValue));
		}

		// Token: 0x0602289A RID: 141466 RVA: 0x009CD9D4 File Offset: 0x009CBBD4
		public void Start(TsBaseCharacter owner)
		{
			if (!owner.IsValid())
			{
				return;
			}
			if (UKismetSystemLibrary.GetConsoleVariableFloatValue("r.Kuro.InteractionEffect.EnableFoliageEffect") <= 0f)
			{
				return;
			}
			this.Owner = owner;
			this.IsReady = true;
			this.TempColor = new FLinearColor();
			ResourceSystem.Instance.LoadAsync<UNiagaraDataChannelAsset>("/Game/Aki/Effect/NiagaraDataChannel/NDCAsset/Scene/NDC_Leaves.NDC_Leaves", delegate([Nullable(2)] UNiagaraDataChannelAsset result, string _)
			{
				if (result == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.LLX;
					string message = "[FoliageEffect] NDC加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Effect/NiagaraDataChannel/NDCAsset/Scene/NDC_Leaves.NDC_Leaves");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.NDCAssetDefault = result;
			}, 100, "js_undefined");
			ResourceSystem.Instance.LoadAsync<UNiagaraDataChannelAsset>("/Game/Aki/Effect/NiagaraDataChannel/NDCAsset/Scene/NDC_Leaves_SF.NDC_Leaves_SF", delegate([Nullable(2)] UNiagaraDataChannelAsset result, string _)
			{
				if (result == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.LLX;
					string message = "[FoliageEffect] NDC加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Effect/NiagaraDataChannel/NDCAsset/Scene/NDC_Leaves_SF.NDC_Leaves_SF");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.NDCAssetSeqFrame = result;
			}, 100, "js_undefined");
			ResourceSystem.Instance.LoadAsync<UMaterialParameterCollection>("/Game/Aki/Render/Shaders/Scene/Interaction/MPC_NDCParameter.MPC_NDCParameter", delegate([Nullable(2)] UMaterialParameterCollection result, string _)
			{
				if (result == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.LLX;
					string message = "[FoliageEffect] MPC加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", "/Game/Aki/Render/Shaders/Scene/Interaction/MPC_NDCParameter.MPC_NDCParameter");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.MPCAsset = result;
			}, 100, "js_undefined");
			UDataTable table = ResourceSystem.Instance.Load<UDataTable>("/Game/Aki/Data/Effect/DT_FoliageNDCEffect.DT_FoliageNDCEffect", "js_undefined");
			this.ConfigMap.Clear();
			this.foliageNameArray = new TArray<string>();
			List<Tuple<string, FKuroInteractionEffectTraceFoliage>> allDataTableRowFromTableWithRowName = DataTableUtil.GetAllDataTableRowFromTableWithRowName<FKuroInteractionEffectTraceFoliage>(table);
			if (allDataTableRowFromTableWithRowName.Count > 0)
			{
				foreach (Tuple<string, FKuroInteractionEffectTraceFoliage> tuple in allDataTableRowFromTableWithRowName)
				{
					TSoftObjectPtr<UObject> tsoftObjectPtr = new TSoftObjectPtr<UObject>(tuple.Item2.FoliageMesh);
					if (UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
					{
						string text = tuple.Item2.FoliageMesh.ToAssetPathName();
						this.ConfigMap[text] = tuple.Item2;
						this.foliageNameArray.Add(text);
					}
				}
			}
		}

		// Token: 0x0602289B RID: 141467 RVA: 0x009CDB40 File Offset: 0x009CBD40
		[NullableContext(2)]
		private void WeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			this.WeaponPosition = new FVectorDouble?(OriginPoint);
		}

		// Token: 0x0602289C RID: 141468 RVA: 0x009CDB50 File Offset: 0x009CBD50
		public void Enable()
		{
			if (!this.IsReady)
			{
				return;
			}
			this.IsEnabled = true;
			this.ScalarParameterCache.Clear();
			this.VectorParameterCache.Clear();
			BP_EventManager_C bpEventManager = GlobalData.BpEventManager;
			if (bpEventManager != null)
			{
				bpEventManager.武器交互场景时.Remove(new Action<FVectorDouble, BP_SceneBattleInteract_C, int>(this.WeaponInteraction));
			}
			if (bpEventManager != null)
			{
				bpEventManager.武器交互场景时.Add(new Action<FVectorDouble, BP_SceneBattleInteract_C, int>(this.WeaponInteraction));
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			CharacterActorComponent actorComponent;
			if (characterActorComponent == null)
			{
				actorComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				actorComponent = ((entity != null) ? entity.GetComponent<CharacterActorComponent>() : null);
			}
			this.ActorComponent = actorComponent;
			this.EnviInteractionComponent = (this.Owner.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) as UKuroEnviInteractionComponent);
			this.kuroEnviInteractionSystem = UKuroInteractionEffectSystem.GetKuroInteractionEffectSystem(this.Owner.GetWorld());
		}

		// Token: 0x0602289D RID: 141469 RVA: 0x009CDC20 File Offset: 0x009CBE20
		public void Disable()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			this.IsEnabled = false;
			this.kuroEnviInteractionSystem = null;
			BP_EventManager_C bpEventManager = GlobalData.BpEventManager;
			if (bpEventManager == null)
			{
				return;
			}
			bpEventManager.武器交互场景时.Remove(new Action<FVectorDouble, BP_SceneBattleInteract_C, int>(this.WeaponInteraction));
		}

		// Token: 0x0602289E RID: 141470 RVA: 0x009CDC5C File Offset: 0x009CBE5C
		private bool RefreshKuroEnviInteractionSystem()
		{
			if (this.Owner == null || !this.Owner.IsValid())
			{
				this.kuroEnviInteractionSystem = null;
				return false;
			}
			if (this.kuroEnviInteractionSystem == null || !this.kuroEnviInteractionSystem.IsValid())
			{
				this.kuroEnviInteractionSystem = UKuroInteractionEffectSystem.GetKuroInteractionEffectSystem(this.Owner.GetWorld());
			}
			return this.kuroEnviInteractionSystem != null && this.kuroEnviInteractionSystem.IsValid();
		}

		// Token: 0x0602289F RID: 141471 RVA: 0x009CDCC8 File Offset: 0x009CBEC8
		public void Tick(float deltaSeconds)
		{
			if (!this.IsEnabled || this.Owner == null)
			{
				return;
			}
			CharacterActorComponent actorComponent = this.ActorComponent;
			if (actorComponent != null && actorComponent.IsAutonomousProxy)
			{
				this.Timer++;
				if (this.Timer >= 3)
				{
					if (this.RefreshKuroEnviInteractionSystem())
					{
						this.UpdatePlayerState();
						this.CalcSpeed();
						this.CalcSpawnMessage();
						this.SetFoliageMPC();
						this.SpawnNDC();
					}
					this.Timer = 0;
				}
			}
		}

		// Token: 0x060228A0 RID: 141472 RVA: 0x009CDD40 File Offset: 0x009CBF40
		private void SpawnNDC()
		{
			if (!this.IsReady || this.Owner == null || this.NDCAssetDefault == null || this.NDCAssetSeqFrame == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			BaseTagComponent baseTagComponent;
			if (characterActorComponent == null)
			{
				baseTagComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent.Entity;
				baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if ((baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.状态.空中状态"])) || (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"])))
			{
				return;
			}
			if (this.DefaultSpawnCount > 0)
			{
				UNiagaraDataChannelLibrary.WriteToNiagaraDataChannel(this.Owner.GetWorld(), this.NDCAssetDefault, SceneCharacterFoliageEffect.NDCSearchParam, this.DefaultSpawnCount, true, true, false, "TS FoliageEffect WriteToNDC Default");
			}
			if (this.SeqFrameSpawnCount > 0)
			{
				UNiagaraDataChannelLibrary.WriteToNiagaraDataChannel(this.Owner.GetWorld(), this.NDCAssetSeqFrame, SceneCharacterFoliageEffect.NDCSearchParam, this.SeqFrameSpawnCount, true, true, false, "TS FoliageEffect WriteToNDC SeqFrame");
			}
		}

		// Token: 0x060228A1 RID: 141473 RVA: 0x009CDE30 File Offset: 0x009CC030
		private void CalcSpeed()
		{
			if (!this.IsReady)
			{
				return;
			}
			this.WeaponSpeed = 0.0;
			if (this.WeaponPosition != null)
			{
				if (this.PreWeaponPosition != null)
				{
					this.WeaponSpeed = MathUtils.Instance.VectorDistance(this.WeaponPosition.Value, this.PreWeaponPosition.Value);
					FVectorDouble fvectorDouble = this.WeaponPosition.Value;
					FVectorDouble value = this.PreWeaponPosition.Value;
					this.WeaponVelocity = new FVector?((fvectorDouble - value).ToVector());
				}
				else
				{
					this.WeaponVelocity = null;
				}
			}
			this.PreWeaponPosition = this.WeaponPosition;
			this.PlayerSpeed = ((this.PrePlayerPosition != null) ? MathUtils.Instance.VectorDistance(this.Owner.D_K2_GetActorLocation(), this.PrePlayerPosition.Value) : 0.0);
			if (this.PrePlayerPosition != null)
			{
				FVectorDouble fvectorDouble = this.Owner.D_K2_GetActorLocation();
				FVectorDouble value = this.PrePlayerPosition.Value;
				this.PlayerVelocity = new FVector?((fvectorDouble - value).ToVector());
			}
			else
			{
				this.PlayerVelocity = null;
			}
			this.PrePlayerPosition = new FVectorDouble?(this.Owner.D_K2_GetActorLocation());
			this.WeaponSpawn = this.CalcWeaponSpawn();
			this.PlayerSpawn = this.CalcPlayerSpawn();
		}

		// Token: 0x060228A2 RID: 141474 RVA: 0x009CDFB4 File Offset: 0x009CC1B4
		private void CalcSpawnMessage()
		{
			if (this.Owner == null || this.foliageNameArray == null || !this.RefreshKuroEnviInteractionSystem())
			{
				return;
			}
			UKuroInteractionEffectSystem ukuroInteractionEffectSystem = this.kuroEnviInteractionSystem;
			if (ukuroInteractionEffectSystem == null)
			{
				return;
			}
			if (this.EnviInteractionComponent == null)
			{
				this.EnviInteractionComponent = (this.Owner.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) as UKuroEnviInteractionComponent);
			}
			this.WeightSpawnArrayDefault.Clear();
			this.WeightSpawnArraySeqFrame.Clear();
			TArray<int> tarray = ukuroInteractionEffectSystem.SearchInteractionFoliageArray(this.foliageNameArray);
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				string key = this.foliageNameArray.Get(i);
				FKuroInteractionEffectNDCConfigBase fkuroInteractionEffectNDCConfigBase;
				if (this.ConfigMap.TryGetValue(key, out fkuroInteractionEffectNDCConfigBase))
				{
					double num2 = (double)((float)tarray.Get(i) * fkuroInteractionEffectNDCConfigBase.SpawnNum);
					if (num2 > 0.0)
					{
						int effectIndex = fkuroInteractionEffectNDCConfigBase.EffectIndex;
						if (effectIndex != 0)
						{
							if (effectIndex == 1)
							{
								this.TryInsertTopWeightedSpawn(this.WeightSpawnArraySeqFrame, num2, fkuroInteractionEffectNDCConfigBase);
							}
						}
						else
						{
							this.TryInsertTopWeightedSpawn(this.WeightSpawnArrayDefault, num2, fkuroInteractionEffectNDCConfigBase);
						}
					}
				}
			}
			UKuroEnviInteractionComponent enviInteractionComponent = this.EnviInteractionComponent;
			if (enviInteractionComponent != null)
			{
				TWeakObjectPtr<AActor> hitBushActor = enviInteractionComponent.GetEnviInteractionData().HitBushActor;
				if (hitBushActor.IsValid(false, false))
				{
					UStaticMeshComponent ustaticMeshComponent = hitBushActor.Get().GetComponentByClass(UStaticMeshComponent.StaticClass()) as UStaticMeshComponent;
					if (ustaticMeshComponent != null && ustaticMeshComponent.StaticMesh != null)
					{
						FKuroInteractionEffectTraceStaticMesh fkuroInteractionEffectTraceStaticMesh = ukuroInteractionEffectSystem.SearchInteractionStaticMeshConfig(ustaticMeshComponent.StaticMesh);
						if (fkuroInteractionEffectTraceStaticMesh.SpawnNum > 0f)
						{
							int effectIndex = fkuroInteractionEffectTraceStaticMesh.EffectIndex;
							if (effectIndex == 0)
							{
								this.TryInsertTopWeightedSpawn(this.WeightSpawnArrayDefault, (double)fkuroInteractionEffectTraceStaticMesh.SpawnNum, fkuroInteractionEffectTraceStaticMesh);
								return;
							}
							if (effectIndex != 1)
							{
								return;
							}
							this.TryInsertTopWeightedSpawn(this.WeightSpawnArraySeqFrame, (double)fkuroInteractionEffectTraceStaticMesh.SpawnNum, fkuroInteractionEffectTraceStaticMesh);
						}
					}
				}
			}
		}

		// Token: 0x060228A3 RID: 141475 RVA: 0x009CE170 File Offset: 0x009CC370
		private bool ClampHeight(double Height)
		{
			return this.IsReady && (this.Owner != null && this.WeaponPosition != null && this.WeaponPosition.Value.Z - this.Owner.D_K2_GetActorLocation().Z <= Height);
		}

		// Token: 0x060228A4 RID: 141476 RVA: 0x009CE1C4 File Offset: 0x009CC3C4
		private void SetFoliageMPC()
		{
			if (this.MPCAsset == null)
			{
				return;
			}
			if (this.WeaponPosition != null)
			{
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_LeaveSpawnPosition, this.WeaponPosition.Value.X, this.WeaponPosition.Value.Y, this.WeaponPosition.Value.Z, 0.0);
			}
			if (this.Owner != null)
			{
				this.SetScalarParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_OnMotorcycle, this.OnMotorcycle > false);
				this.SetScalarParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpeed, this.PlayerSpeed);
				if (this.PrePlayerPosition != null)
				{
					double num = this.PrePlayerPosition.Value.X;
					double num2 = this.PrePlayerPosition.Value.Y;
					double num3 = this.PrePlayerPosition.Value.Z;
					if (this.OnMotorcycle && this.Owner.CharacterActorComponent != null && this.PlayerMotorcycleSpawnOffset != null)
					{
						num += (double)this.PlayerMotorcycleSpawnOffset.Value.X;
						num2 += (double)this.PlayerMotorcycleSpawnOffset.Value.Y;
						num3 += (double)this.PlayerMotorcycleSpawnOffset.Value.Z;
					}
					this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnPosition, num, num2, num3, 0.0);
				}
				if (this.WeaponVelocity != null)
				{
					this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_WeaponVelocity, (double)this.WeaponVelocity.Value.X, (double)this.WeaponVelocity.Value.Y, (double)this.WeaponVelocity.Value.Z, 0.0);
				}
				if (this.PlayerVelocity != null)
				{
					this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerVelocity, (double)this.PlayerVelocity.Value.X, (double)this.PlayerVelocity.Value.Y, (double)this.PlayerVelocity.Value.Z, 0.0);
				}
			}
			this.DefaultSpawnCount = this.SetDefaultFoliageMPC();
			this.SeqFrameSpawnCount = this.SetSeqFrameFoliageMPC();
		}

		// Token: 0x060228A5 RID: 141477 RVA: 0x009CE3D4 File Offset: 0x009CC5D4
		private int SetDefaultFoliageMPC()
		{
			if (this.MPCAsset == null)
			{
				return 0;
			}
			int num = Math.Min(4, this.WeightSpawnArrayDefault.Count);
			double num2 = 0.0;
			for (int i = 0; i < num; i++)
			{
				num2 += this.WeightSpawnArrayDefault[i].Item1;
			}
			if (num2 <= 0.0)
			{
				return 0;
			}
			double item = this.WeightSpawnArrayDefault[0].Item1;
			double num3 = this.WeightSpawnArrayDefault[Math.Min(1, num - 1)].Item1 + item;
			double w = this.WeightSpawnArrayDefault[Math.Min(2, num - 1)].Item1 + num3;
			double x = (double)this.WeightSpawnArrayDefault[0].Item2.TypeIndex;
			double z = (double)this.WeightSpawnArrayDefault[Math.Min(1, num - 1)].Item2.TypeIndex;
			double x2 = (double)this.WeightSpawnArrayDefault[Math.Min(2, num - 1)].Item2.TypeIndex;
			double z2 = (double)this.WeightSpawnArrayDefault[Math.Min(3, num - 1)].Item2.TypeIndex;
			this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_SpawnParam0, x, 0.0, z, item);
			this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_SpawnParam1, x2, num3, z2, w);
			double playerSpawnPercent = this.GetPlayerSpawnPercent(this.WeightSpawnArrayDefault[0].Item2);
			double x3 = this.ClampHeight((double)this.WeightSpawnArrayDefault[0].Item2.HeightClamp) ? playerSpawnPercent : 10.0;
			double playerSpawnPercent2 = this.GetPlayerSpawnPercent(this.WeightSpawnArrayDefault[Math.Min(1, num - 1)].Item2);
			double y = this.ClampHeight((double)this.WeightSpawnArrayDefault[Math.Min(1, num - 1)].Item2.HeightClamp) ? playerSpawnPercent2 : 10.0;
			double playerSpawnPercent3 = this.GetPlayerSpawnPercent(this.WeightSpawnArrayDefault[Math.Min(2, num - 1)].Item2);
			double z3 = this.ClampHeight((double)this.WeightSpawnArrayDefault[Math.Min(2, num - 1)].Item2.HeightClamp) ? playerSpawnPercent3 : 10.0;
			double playerSpawnPercent4 = this.GetPlayerSpawnPercent(this.WeightSpawnArrayDefault[Math.Min(3, num - 1)].Item2);
			double w2 = this.ClampHeight((double)this.WeightSpawnArrayDefault[Math.Min(3, num - 1)].Item2.HeightClamp) ? playerSpawnPercent4 : 10.0;
			this.SetScalarParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_SpawnNum, num2);
			if (this.Owner != null)
			{
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset0, (double)this.WeightSpawnArrayDefault[0].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArrayDefault[0].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArrayDefault[0].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset1, (double)this.WeightSpawnArrayDefault[Math.Min(1, num - 1)].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArrayDefault[Math.Min(1, num - 1)].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArrayDefault[Math.Min(1, num - 1)].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset2, (double)this.WeightSpawnArrayDefault[Math.Min(2, num - 1)].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArrayDefault[Math.Min(2, num - 1)].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArrayDefault[Math.Min(2, num - 1)].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset3, (double)this.WeightSpawnArrayDefault[Math.Min(3, num - 1)].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArrayDefault[Math.Min(3, num - 1)].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArrayDefault[Math.Min(3, num - 1)].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerPercent0123, x3, y, z3, w2);
			}
			return (int)MathUtils.Instance.GetFloatPointCeil(this.GetTotalSpawnCount(this.WeightSpawnArrayDefault, num), 0);
		}

		// Token: 0x060228A6 RID: 141478 RVA: 0x009CE8A4 File Offset: 0x009CCAA4
		private int SetSeqFrameFoliageMPC()
		{
			if (this.MPCAsset == null)
			{
				return 0;
			}
			int num = Math.Min(4, this.WeightSpawnArraySeqFrame.Count);
			double num2 = 0.0;
			for (int i = 0; i < num; i++)
			{
				num2 += this.WeightSpawnArraySeqFrame[i].Item1;
			}
			if (num2 <= 0.0)
			{
				return 0;
			}
			double item = this.WeightSpawnArraySeqFrame[0].Item1;
			double num3 = this.WeightSpawnArraySeqFrame[Math.Min(1, num - 1)].Item1 + item;
			double w = this.WeightSpawnArraySeqFrame[Math.Min(2, num - 1)].Item1 + num3;
			double x = (double)this.WeightSpawnArraySeqFrame[0].Item2.TypeIndex;
			double z = (double)this.WeightSpawnArraySeqFrame[Math.Min(1, num - 1)].Item2.TypeIndex;
			double x2 = (double)this.WeightSpawnArraySeqFrame[Math.Min(2, num - 1)].Item2.TypeIndex;
			double z2 = (double)this.WeightSpawnArraySeqFrame[Math.Min(3, num - 1)].Item2.TypeIndex;
			this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_SpawnParam0_SF, x, 0.0, z, item);
			this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_SpawnParam1_SF, x2, num3, z2, w);
			double playerSpawnPercent = this.GetPlayerSpawnPercent(this.WeightSpawnArraySeqFrame[0].Item2);
			double x3 = this.ClampHeight((double)this.WeightSpawnArraySeqFrame[0].Item2.HeightClamp) ? playerSpawnPercent : 10.0;
			double playerSpawnPercent2 = this.GetPlayerSpawnPercent(this.WeightSpawnArraySeqFrame[Math.Min(1, num - 1)].Item2);
			double y = this.ClampHeight((double)this.WeightSpawnArraySeqFrame[Math.Min(1, num - 1)].Item2.HeightClamp) ? playerSpawnPercent2 : 10.0;
			double playerSpawnPercent3 = this.GetPlayerSpawnPercent(this.WeightSpawnArraySeqFrame[Math.Min(2, num - 1)].Item2);
			double z3 = this.ClampHeight((double)this.WeightSpawnArraySeqFrame[Math.Min(2, num - 1)].Item2.HeightClamp) ? playerSpawnPercent3 : 10.0;
			double playerSpawnPercent4 = this.GetPlayerSpawnPercent(this.WeightSpawnArraySeqFrame[Math.Min(3, num - 1)].Item2);
			double w2 = this.ClampHeight((double)this.WeightSpawnArraySeqFrame[Math.Min(3, num - 1)].Item2.HeightClamp) ? playerSpawnPercent4 : 10.0;
			this.SetScalarParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_SpawnNum_SF, num2);
			if (this.Owner != null)
			{
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset0_SF, (double)this.WeightSpawnArraySeqFrame[0].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArraySeqFrame[0].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArraySeqFrame[0].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset1_SF, (double)this.WeightSpawnArraySeqFrame[Math.Min(1, num - 1)].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArraySeqFrame[Math.Min(1, num - 1)].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArraySeqFrame[Math.Min(1, num - 1)].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset2_SF, (double)this.WeightSpawnArraySeqFrame[Math.Min(2, num - 1)].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArraySeqFrame[Math.Min(2, num - 1)].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArraySeqFrame[Math.Min(2, num - 1)].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerSpawnOffset3_SF, (double)this.WeightSpawnArraySeqFrame[Math.Min(3, num - 1)].Item2.PlayerSpawnOffset.X, (double)this.WeightSpawnArraySeqFrame[Math.Min(3, num - 1)].Item2.PlayerSpawnOffset.Y, (double)this.WeightSpawnArraySeqFrame[Math.Min(3, num - 1)].Item2.PlayerSpawnOffset.Z, 0.0);
				this.SetVectorParameterValueIfChanged(SceneCharacterFoliageEffect.MPC_PlayerPercent0123_SF, x3, y, z3, w2);
			}
			return (int)MathUtils.Instance.GetFloatPointCeil(this.GetTotalSpawnCount(this.WeightSpawnArraySeqFrame, num), 0);
		}

		// Token: 0x060228A7 RID: 141479 RVA: 0x009CED73 File Offset: 0x009CCF73
		private double CalcWeaponSpawn()
		{
			double num = MathUtils.Instance.Clamp(this.WeaponSpeed, 0.0, 300.0) / 300.0;
			return num * num * 0.5;
		}

		// Token: 0x060228A8 RID: 141480 RVA: 0x009CEDB0 File Offset: 0x009CCFB0
		private double CalcPlayerSpawn()
		{
			double num = this.OnMotorcycle ? 100.0 : 100.0;
			return MathUtils.Instance.Clamp(this.PlayerSpeed, 0.0, num) / num * this.PlayerMoveTypeParam;
		}

		// Token: 0x060228A9 RID: 141481 RVA: 0x009CEE00 File Offset: 0x009CD000
		private void UpdatePlayerState()
		{
			if (!this.IsReady)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = this.Owner.CharacterActorComponent;
			FVectorDouble? fvectorDouble = (characterActorComponent != null) ? new FVectorDouble?(characterActorComponent.ActorForward) : null;
			CharacterActorComponent characterActorComponent2 = this.Owner.CharacterActorComponent;
			BaseTagComponent baseTagComponent;
			if (characterActorComponent2 == null)
			{
				baseTagComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent2.Entity;
				baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null || !baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.驾驶期间"]))
			{
				if ((baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走"])) || (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.行走停止"])) || (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.站立"])))
				{
					this.PlayerMoveTypeParam = 0.0;
				}
				else
				{
					this.PlayerMoveTypeParam = 0.1;
				}
				this.OnMotorcycle = false;
				return;
			}
			this.PlayerMoveTypeParam = 1.0;
			this.OnMotorcycle = true;
			FVectorDouble value;
			if (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.冲刺"]))
			{
				value = fvectorDouble.Value;
				this.PlayerMotorcycleSpawnOffset = new FVector?((value * (this.PlayerSpeed * 1.5)).ToVector());
				return;
			}
			if (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.烧胎"]))
			{
				value = fvectorDouble.Value;
				this.PlayerMotorcycleSpawnOffset = new FVector?((value * -100.0).ToVector());
				return;
			}
			value = fvectorDouble.Value;
			this.PlayerMotorcycleSpawnOffset = new FVector?((value * (this.PlayerSpeed * 1.2)).ToVector());
		}

		// Token: 0x060228AA RID: 141482 RVA: 0x009CEFD3 File Offset: 0x009CD1D3
		private void SetTempColor(double R, double G, double B, double A)
		{
			this.TempColor.R = (float)R;
			this.TempColor.G = (float)G;
			this.TempColor.B = (float)B;
			this.TempColor.A = (float)A;
		}

		// Token: 0x060228AB RID: 141483 RVA: 0x009CF00C File Offset: 0x009CD20C
		private double GetPlayerSpawnPercent(FKuroInteractionEffectNDCConfigBase config)
		{
			double num = this.PlayerSpawn * (double)config.MoveSpawn;
			double num2 = this.WeaponSpawn * (double)config.WeaponSpawn;
			return Math.Round(MathUtils.Instance.Clamp((num + 0.001) / (num2 + num + 0.001), 0.0, 1.0) * 10.0);
		}

		// Token: 0x060228AC RID: 141484 RVA: 0x009CF07C File Offset: 0x009CD27C
		private double GetTotalSpawnCount([Nullable(new byte[]
		{
			1,
			0,
			1
		})] List<ValueTuple<double, FKuroInteractionEffectNDCConfigBase>> weightSpawnArray, int typeNum)
		{
			double num = 0.0;
			for (int i = 0; i < typeNum; i++)
			{
				ValueTuple<double, FKuroInteractionEffectNDCConfigBase> valueTuple = weightSpawnArray[i];
				double num2 = Math.Max(this.WeaponSpawn * (double)valueTuple.Item2.WeaponSpawn + this.PlayerSpawn * (double)valueTuple.Item2.MoveSpawn - 0.0001, 0.0);
				num += valueTuple.Item1 * num2;
			}
			return num;
		}

		// Token: 0x060228AD RID: 141485 RVA: 0x009CF0F4 File Offset: 0x009CD2F4
		private void TryInsertTopWeightedSpawn([Nullable(new byte[]
		{
			1,
			0,
			1
		})] List<ValueTuple<double, FKuroInteractionEffectNDCConfigBase>> targetArray, double foliageNum, FKuroInteractionEffectNDCConfigBase message)
		{
			double num = foliageNum * (double)message.Weight;
			int num2 = targetArray.Count;
			for (int i = 0; i < targetArray.Count; i++)
			{
				ValueTuple<double, FKuroInteractionEffectNDCConfigBase> valueTuple = targetArray[i];
				if (num > valueTuple.Item1 * (double)valueTuple.Item2.Weight)
				{
					num2 = i;
					break;
				}
			}
			if (num2 >= 4 && targetArray.Count >= 4)
			{
				return;
			}
			targetArray.Insert(num2, new ValueTuple<double, FKuroInteractionEffectNDCConfigBase>(foliageNum, message));
			if (targetArray.Count > 4)
			{
				targetArray.RemoveRange(4, targetArray.Count - 4);
			}
		}

		// Token: 0x060228AE RID: 141486 RVA: 0x009CF17C File Offset: 0x009CD37C
		private void SetScalarParameterValueIfChanged(FName paramName, double value)
		{
			if (this.MPCAsset == null || this.Owner == null)
			{
				return;
			}
			string key = paramName.ToString();
			double num;
			if (this.ScalarParameterCache.TryGetValue(key, out num) && num == value)
			{
				return;
			}
			this.ScalarParameterCache[key] = value;
			UKismetMaterialLibrary.SetScalarParameterValue(this.Owner.GetWorld(), this.MPCAsset, paramName, (float)value);
		}

		// Token: 0x060228AF RID: 141487 RVA: 0x009CF1E4 File Offset: 0x009CD3E4
		private void SetVectorParameterValueIfChanged(FName paramName, double X, double Y, double Z, double W)
		{
			if (this.MPCAsset == null)
			{
				return;
			}
			string key = paramName.ToString();
			ValueTuple<double, double, double, double> valueTuple;
			if (this.VectorParameterCache.TryGetValue(key, out valueTuple) && valueTuple.Item1 == X && valueTuple.Item2 == Y && valueTuple.Item3 == Z && valueTuple.Item4 == W)
			{
				return;
			}
			this.VectorParameterCache[key] = new ValueTuple<double, double, double, double>(X, Y, Z, W);
			this.SetTempColor(X, Y, Z, W);
			UKismetMaterialLibrary.SetVectorParameterValue(GlobalData.World, this.MPCAsset, paramName, this.TempColor);
		}

		// Token: 0x060228B0 RID: 141488 RVA: 0x009CF279 File Offset: 0x009CD479
		public static void CreateStaticDefaultValue()
		{
			SceneCharacterFoliageEffect.NDCSearchParam = new FNiagaraDataChannelSearchParameters();
		}

		// Token: 0x060228B1 RID: 141489 RVA: 0x009CF285 File Offset: 0x009CD485
		public static void ResetStaticDefaultValue()
		{
			SceneCharacterFoliageEffect.NDCSearchParam = null;
		}

		// Token: 0x04013173 RID: 78195
		private const string NDCAssetPathDefault = "/Game/Aki/Effect/NiagaraDataChannel/NDCAsset/Scene/NDC_Leaves.NDC_Leaves";

		// Token: 0x04013174 RID: 78196
		private const string NDCAssetPathSeqFrame = "/Game/Aki/Effect/NiagaraDataChannel/NDCAsset/Scene/NDC_Leaves_SF.NDC_Leaves_SF";

		// Token: 0x04013175 RID: 78197
		private const string ConfigPath = "/Game/Aki/Data/Effect/DT_FoliageNDCEffect.DT_FoliageNDCEffect";

		// Token: 0x04013176 RID: 78198
		private const string MPCPath = "/Game/Aki/Render/Shaders/Scene/Interaction/MPC_NDCParameter.MPC_NDCParameter";

		// Token: 0x04013177 RID: 78199
		private const double WEAPON_SPAWN_PARAM = 300.0;

		// Token: 0x04013178 RID: 78200
		private const double PLAYER_SPAWN_PARAM = 100.0;

		// Token: 0x04013179 RID: 78201
		private const double PLAYER_MOTORCYCLE_SPAWN_PARAM = 100.0;

		// Token: 0x0401317A RID: 78202
		private const int MAX_SPAWN_TYPE_COUNT = 4;

		// Token: 0x0401317B RID: 78203
		private const double PLAYER_PERCENT_SCALE = 10.0;

		// Token: 0x0401317C RID: 78204
		[Nullable(2)]
		public TsBaseCharacter Owner;

		// Token: 0x0401317D RID: 78205
		[Nullable(2)]
		public CharacterActorComponent ActorComponent;

		// Token: 0x0401317E RID: 78206
		public bool IsReady;

		// Token: 0x0401317F RID: 78207
		protected int Timer;

		// Token: 0x04013180 RID: 78208
		protected double WeaponSpeed;

		// Token: 0x04013181 RID: 78209
		public FVector? WeaponVelocity;

		// Token: 0x04013182 RID: 78210
		public FVector? PlayerVelocity;

		// Token: 0x04013183 RID: 78211
		protected double PlayerSpeed;

		// Token: 0x04013184 RID: 78212
		protected double WeaponSpawn;

		// Token: 0x04013185 RID: 78213
		protected double PlayerSpawn;

		// Token: 0x04013186 RID: 78214
		protected double PlayerMoveTypeParam = 0.1;

		// Token: 0x04013187 RID: 78215
		protected FVector? PlayerMotorcycleSpawnOffset;

		// Token: 0x04013188 RID: 78216
		protected bool OnMotorcycle;

		// Token: 0x04013189 RID: 78217
		protected FVectorDouble? WeaponPosition;

		// Token: 0x0401318A RID: 78218
		protected int DefaultSpawnCount;

		// Token: 0x0401318B RID: 78219
		protected int SeqFrameSpawnCount;

		// Token: 0x0401318C RID: 78220
		protected FVectorDouble? PreWeaponPosition;

		// Token: 0x0401318D RID: 78221
		protected FVectorDouble? PrePlayerPosition;

		// Token: 0x0401318E RID: 78222
		[Nullable(2)]
		protected UNiagaraDataChannelAsset NDCAssetDefault;

		// Token: 0x0401318F RID: 78223
		[Nullable(2)]
		protected UNiagaraDataChannelAsset NDCAssetSeqFrame;

		// Token: 0x04013190 RID: 78224
		[Nullable(2)]
		protected UMaterialParameterCollection MPCAsset;

		// Token: 0x04013191 RID: 78225
		protected Dictionary<string, FKuroInteractionEffectNDCConfigBase> ConfigMap = new Dictionary<string, FKuroInteractionEffectNDCConfigBase>();

		// Token: 0x04013192 RID: 78226
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected List<ValueTuple<double, FKuroInteractionEffectNDCConfigBase>> WeightSpawnArrayDefault = new List<ValueTuple<double, FKuroInteractionEffectNDCConfigBase>>();

		// Token: 0x04013193 RID: 78227
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected List<ValueTuple<double, FKuroInteractionEffectNDCConfigBase>> WeightSpawnArraySeqFrame = new List<ValueTuple<double, FKuroInteractionEffectNDCConfigBase>>();

		// Token: 0x04013194 RID: 78228
		[Nullable(2)]
		protected UKuroInteractionEffectSystem kuroEnviInteractionSystem;

		// Token: 0x04013195 RID: 78229
		[Nullable(2)]
		protected UKuroEnviInteractionComponent EnviInteractionComponent;

		// Token: 0x04013196 RID: 78230
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected TArray<string> foliageNameArray;

		// Token: 0x04013197 RID: 78231
		protected readonly Dictionary<string, double> ScalarParameterCache = new Dictionary<string, double>();

		// Token: 0x04013198 RID: 78232
		[Nullable(new byte[]
		{
			1,
			1,
			0
		})]
		protected readonly Dictionary<string, ValueTuple<double, double, double, double>> VectorParameterCache = new Dictionary<string, ValueTuple<double, double, double, double>>();

		// Token: 0x04013199 RID: 78233
		public static readonly FName MPC_LeaveSpawnPosition = new FName("NDC_LeaveSpawnPosition");

		// Token: 0x0401319A RID: 78234
		public static readonly FName MPC_SpawnParam0 = new FName("SpawnParam0");

		// Token: 0x0401319B RID: 78235
		public static readonly FName MPC_SpawnParam1 = new FName("SpawnParam1");

		// Token: 0x0401319C RID: 78236
		public static readonly FName MPC_SpawnNum = new FName("SpawnNum");

		// Token: 0x0401319D RID: 78237
		public static readonly FName MPC_SpawnParam0_SF = new FName("SpawnParam0_SF");

		// Token: 0x0401319E RID: 78238
		public static readonly FName MPC_SpawnParam1_SF = new FName("SpawnParam1_SF");

		// Token: 0x0401319F RID: 78239
		public static readonly FName MPC_SpawnNum_SF = new FName("SpawnNum_SF");

		// Token: 0x040131A0 RID: 78240
		public static readonly FName MPC_OnMotorcycle = new FName("OnMotorcycle");

		// Token: 0x040131A1 RID: 78241
		public static readonly FName MPC_PlayerSpeed = new FName("PlayerSpeed");

		// Token: 0x040131A2 RID: 78242
		public static readonly FName MPC_PlayerSpawnPosition = new FName("NDC_PlayerSpawnPosition");

		// Token: 0x040131A3 RID: 78243
		public static readonly FName MPC_PlayerSpawnOffset0 = new FName("PlayerSpawnOffset0");

		// Token: 0x040131A4 RID: 78244
		public static readonly FName MPC_PlayerSpawnOffset1 = new FName("PlayerSpawnOffset1");

		// Token: 0x040131A5 RID: 78245
		public static readonly FName MPC_PlayerSpawnOffset2 = new FName("PlayerSpawnOffset2");

		// Token: 0x040131A6 RID: 78246
		public static readonly FName MPC_PlayerSpawnOffset3 = new FName("PlayerSpawnOffset3");

		// Token: 0x040131A7 RID: 78247
		public static readonly FName MPC_PlayerPercent0123 = new FName("PlayerPercent0123");

		// Token: 0x040131A8 RID: 78248
		public static readonly FName MPC_PlayerSpawnOffset0_SF = new FName("PlayerSpawnOffset0_SF");

		// Token: 0x040131A9 RID: 78249
		public static readonly FName MPC_PlayerSpawnOffset1_SF = new FName("PlayerSpawnOffset1_SF");

		// Token: 0x040131AA RID: 78250
		public static readonly FName MPC_PlayerSpawnOffset2_SF = new FName("PlayerSpawnOffset2_SF");

		// Token: 0x040131AB RID: 78251
		public static readonly FName MPC_PlayerSpawnOffset3_SF = new FName("PlayerSpawnOffset3_SF");

		// Token: 0x040131AC RID: 78252
		public static readonly FName MPC_PlayerPercent0123_SF = new FName("PlayerPercent0123_SF");

		// Token: 0x040131AD RID: 78253
		public static readonly FName MPC_WeaponVelocity = new FName("WeaponVelocity");

		// Token: 0x040131AE RID: 78254
		public static readonly FName MPC_PlayerVelocity = new FName("PlayerVelocity");

		// Token: 0x040131AF RID: 78255
		protected FLinearColor TempColor;

		// Token: 0x040131B0 RID: 78256
		[Nullable(2)]
		protected static FNiagaraDataChannelSearchParameters NDCSearchParam = null;

		// Token: 0x040131B1 RID: 78257
		public bool IsEnabled;
	}
}
