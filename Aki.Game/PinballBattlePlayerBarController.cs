using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat.PB;
using UnrealEngine;

// Token: 0x02000EAB RID: 3755
[NullableContext(1)]
[Nullable(0)]
public class PinballBattlePlayerBarController
{
	// Token: 0x06005CB8 RID: 23736 RVA: 0x00110FC8 File Offset: 0x0010F1C8
	public void Init(AKSC_Shape2D_Entity_Bar playerBar, PinballBattleSubModel model)
	{
		this.Model = model;
		this.MaterialMap = new Dictionary<int, UMaterialInstanceDynamic>();
		this.MaterialParamName = new FName("Dissolve_Dissolve");
		FName parameterName = new FName("Dissolve_Smooth");
		TArray<UActorComponent> tarray = playerBar.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
		if (tarray != null)
		{
			for (int i = 0; i < tarray.Num(); i++)
			{
				UStaticMeshComponent ustaticMeshComponent = (UStaticMeshComponent)tarray.Get(i);
				string name = ustaticMeshComponent.GetName();
				if (name == "Level1" || name == "Level2" || name == "Level3")
				{
					int key = int.Parse(name[5].ToString());
					UMaterialInstanceDynamic umaterialInstanceDynamic = ustaticMeshComponent.CreateDynamicMaterialInstance(0, ustaticMeshComponent.GetMaterial(0), default(FName));
					if (umaterialInstanceDynamic != null)
					{
						umaterialInstanceDynamic.SetScalarParameterValue(this.MaterialParamName, 0f);
						umaterialInstanceDynamic.SetScalarParameterValue(parameterName, 100000f);
						this.MaterialMap[key] = umaterialInstanceDynamic;
					}
				}
				else if (name == "Bg")
				{
					ustaticMeshComponent.SetScalarParameterValueOnMaterials(this.MaterialParamName, 1f);
				}
			}
		}
		TArray<UActorComponent> tarray2 = playerBar.K2_GetComponentsByClass(UNiagaraComponent.StaticClass());
		if (tarray2 != null)
		{
			for (int j = 0; j < tarray2.Num(); j++)
			{
				UNiagaraComponent uniagaraComponent = (UNiagaraComponent)tarray2.Get(j);
				if (uniagaraComponent.GetName() == "FullCombo")
				{
					this.FullComboEffect = uniagaraComponent;
					break;
				}
			}
		}
		UKSC_DA_Shape2D_World shapeWorldDa = model.ShapeWorldDa;
		if (shapeWorldDa != null)
		{
			float comboEfficiency = model.ComboEfficiency;
			this.LevelComboCounts = new int[]
			{
				0,
				(int)Math.Ceiling((double)((float)shapeWorldDa.PowerCollisionCount1 * Math.Max(1f - comboEfficiency, 0f))),
				(int)Math.Ceiling((double)((float)shapeWorldDa.PowerCollisionCount2 * Math.Max(1f - comboEfficiency, 0f))),
				(int)Math.Ceiling((double)((float)shapeWorldDa.PowerCollisionCount3 * Math.Max(1f - comboEfficiency, 0f)))
			};
			this.MaxCombo = this.LevelComboCounts[3];
		}
		this.ResetPlayerBar();
	}

	// Token: 0x06005CB9 RID: 23737 RVA: 0x001111F5 File Offset: 0x0010F3F5
	public void Destroy()
	{
		this.Model = null;
		Dictionary<int, UMaterialInstanceDynamic> materialMap = this.MaterialMap;
		if (materialMap != null)
		{
			materialMap.Clear();
		}
		this.MaterialParamName = default(FName);
		this.FullComboEffect = null;
	}

	// Token: 0x06005CBA RID: 23738 RVA: 0x00111224 File Offset: 0x0010F424
	public void Update()
	{
		if (this.Model == null)
		{
			return;
		}
		int combo = this.Model.Combo;
		if (combo != this.Combo)
		{
			this.Combo = combo;
			if (combo != 0)
			{
				this.UpdatePlayerBar();
			}
			else
			{
				this.ComboLevel = 0;
				this.ResetPlayerBar();
			}
		}
		if (this.MaxCombo > 0)
		{
			this.ShowFullComboEffect(combo >= this.MaxCombo);
		}
	}

	// Token: 0x06005CBB RID: 23739 RVA: 0x0011128C File Offset: 0x0010F48C
	private void UpdatePlayerBar()
	{
		for (int i = 1; i < this.LevelComboCounts.Length; i++)
		{
			int num = this.LevelComboCounts[i];
			int num2 = this.LevelComboCounts[i - 1];
			if (this.Combo >= num)
			{
				if (this.ComboLevel < i)
				{
					this.ComboLevel = i;
					UMaterialInstanceDynamic umaterialInstanceDynamic;
					if (this.MaterialMap != null && this.MaterialMap.TryGetValue(i, out umaterialInstanceDynamic))
					{
						umaterialInstanceDynamic.SetScalarParameterValue(this.MaterialParamName, 1f);
					}
				}
			}
			else if (this.ComboLevel == i - 1)
			{
				float value = Math.Min((float)(this.Combo - num2) / (float)(num - num2), 1f);
				UMaterialInstanceDynamic umaterialInstanceDynamic2;
				if (this.MaterialMap != null && this.MaterialMap.TryGetValue(i, out umaterialInstanceDynamic2))
				{
					umaterialInstanceDynamic2.SetScalarParameterValue(this.MaterialParamName, value);
				}
			}
		}
	}

	// Token: 0x06005CBC RID: 23740 RVA: 0x00111358 File Offset: 0x0010F558
	private void ResetPlayerBar()
	{
		if (this.MaterialMap != null)
		{
			foreach (UMaterialInstanceDynamic umaterialInstanceDynamic in this.MaterialMap.Values)
			{
				umaterialInstanceDynamic.SetScalarParameterValue(this.MaterialParamName, 0f);
			}
		}
	}

	// Token: 0x06005CBD RID: 23741 RVA: 0x001113C0 File Offset: 0x0010F5C0
	private void ShowFullComboEffect(bool isShow)
	{
		if (isShow == this.IsShowFullComboEffect)
		{
			return;
		}
		this.IsShowFullComboEffect = isShow;
		UNiagaraComponent fullComboEffect = this.FullComboEffect;
		if (fullComboEffect == null)
		{
			return;
		}
		fullComboEffect.SetHiddenInGame(!isShow, false);
	}

	// Token: 0x04002A49 RID: 10825
	private FName MaterialParamName;

	// Token: 0x04002A4A RID: 10826
	private int Combo;

	// Token: 0x04002A4B RID: 10827
	private int ComboLevel;

	// Token: 0x04002A4C RID: 10828
	private int[] LevelComboCounts = Array.Empty<int>();

	// Token: 0x04002A4D RID: 10829
	private int MaxCombo;

	// Token: 0x04002A4E RID: 10830
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, UMaterialInstanceDynamic> MaterialMap;

	// Token: 0x04002A4F RID: 10831
	[Nullable(2)]
	private UNiagaraComponent FullComboEffect;

	// Token: 0x04002A50 RID: 10832
	private bool IsShowFullComboEffect;

	// Token: 0x04002A51 RID: 10833
	[Nullable(2)]
	private PinballBattleSubModel Model;

	// Token: 0x04002A52 RID: 10834
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateStat = Stat.Create("PinballBattlePlayerBarController.UpdatePlayerBar", "", "");
}
