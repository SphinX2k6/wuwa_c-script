using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.SimpleCombat._3_3Pinball.GameBase.SpawnObj;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x0200613E RID: 24894
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballBattleFeverBarController
	{
		// Token: 0x0603B9E4 RID: 244196 RVA: 0x010E9460 File Offset: 0x010E7660
		[NullableContext(1)]
		public void Init(BP_Fever_Bar_C feverBar, float dissolveMin, float dissolveMax, [Nullable(2)] UMaterialInstance material)
		{
			this.MaterialParamName = new FName("Dissolve_Dissolve");
			TArray<UActorComponent> tarray = feverBar.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
			if (tarray != null)
			{
				for (int i = 0; i < tarray.Num(); i++)
				{
					UStaticMeshComponent ustaticMeshComponent = (UStaticMeshComponent)tarray.Get(i);
					string name = ustaticMeshComponent.GetName();
					if (name == "Mesh")
					{
						UMaterialInstanceDynamic umaterialInstanceDynamic = ustaticMeshComponent.CreateDynamicMaterialInstance(0, ustaticMeshComponent.GetMaterial(0), default(FName));
						if (umaterialInstanceDynamic != null)
						{
							umaterialInstanceDynamic.SetScalarParameterValue(this.MaterialParamName, 0f);
							this.FeverBarMaterial = umaterialInstanceDynamic;
						}
					}
					else if (name == "Bg")
					{
						if (material != null)
						{
							ustaticMeshComponent.SetMaterial(0, material);
						}
						ustaticMeshComponent.SetScalarParameterValueOnMaterials(this.MaterialParamName, 1f);
					}
				}
			}
			this.DissolveMin = dissolveMin;
			this.DissolveMax = dissolveMax;
			this.DissolveRange = this.DissolveMax - this.DissolveMin;
		}

		// Token: 0x0603B9E5 RID: 244197 RVA: 0x010E9554 File Offset: 0x010E7754
		[NullableContext(1)]
		public void BindAttr(AKSC_Shape2D_Entity_TeamPlayer kscTeamPlayer)
		{
			UKSC_SkillComp skillComp = kscTeamPlayer.GetSkillComp();
			UKSC_AttrSet uksc_AttrSet = (skillComp != null) ? skillComp.AttrSet_ : null;
			if (uksc_AttrSet != null)
			{
				this.AttrSet = uksc_AttrSet;
				TMap<EKSC_AttrType, int> attrs_ = uksc_AttrSet.Attrs_;
				this.FeverValue = (float)((attrs_ != null) ? attrs_.GetValueOrNull(EKSC_AttrType.SpecialEnergy3) : null).GetValueOrDefault();
				TMap<EKSC_AttrType, int> attrs_2 = uksc_AttrSet.Attrs_;
				this.FeverMaxValue = (float)((attrs_2 != null) ? attrs_2.GetValueOrNull(EKSC_AttrType.SpecialEnergy3Max) : null).GetValueOrDefault();
				this.DelegateFeverAttrChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnFeverAttrChange));
				this.DelegateFeverMaxAttrChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnFeverMaxAttrChange));
				uksc_AttrSet.AssignAttrListen(EKSC_AttrType.SpecialEnergy3, this.DelegateFeverAttrChange);
				uksc_AttrSet.AssignAttrListen(EKSC_AttrType.SpecialEnergy3Max, this.DelegateFeverMaxAttrChange);
				this.UpdateFeverBar();
			}
		}

		// Token: 0x0603B9E6 RID: 244198 RVA: 0x010E9628 File Offset: 0x010E7828
		public void Destroy()
		{
			this.MaterialParamName = default(FName);
			if (this.AttrSet != null)
			{
				if (this.DelegateFeverAttrChange != null)
				{
					this.AttrSet.RemoveAttrListen(EKSC_AttrType.SpecialEnergy3, this.DelegateFeverAttrChange);
				}
				if (this.DelegateFeverMaxAttrChange != null)
				{
					this.AttrSet.RemoveAttrListen(EKSC_AttrType.SpecialEnergy3Max, this.DelegateFeverMaxAttrChange);
				}
				this.AttrSet = null;
			}
			if (this.DelegateFeverAttrChange != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnFeverAttrChange));
				this.DelegateFeverAttrChange = null;
			}
			if (this.DelegateFeverMaxAttrChange != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnFeverMaxAttrChange));
				this.DelegateFeverMaxAttrChange = null;
			}
		}

		// Token: 0x0603B9E7 RID: 244199 RVA: 0x010E96C8 File Offset: 0x010E78C8
		private void UpdateFeverBar()
		{
			float num = (this.FeverMaxValue > 0f) ? (this.FeverValue / this.FeverMaxValue) : 0f;
			float value = this.DissolveMin + num * this.DissolveRange;
			UMaterialInstanceDynamic feverBarMaterial = this.FeverBarMaterial;
			if (feverBarMaterial == null)
			{
				return;
			}
			feverBarMaterial.SetScalarParameterValue(this.MaterialParamName, value);
		}

		// Token: 0x0603B9E8 RID: 244200 RVA: 0x010E971E File Offset: 0x010E791E
		private void OnFeverAttrChange(EKSC_AttrType attrType, int value)
		{
			this.FeverValue = (float)value;
			this.RefreshFever();
			this.UpdateFeverBar();
		}

		// Token: 0x0603B9E9 RID: 244201 RVA: 0x010E9734 File Offset: 0x010E7934
		private void OnFeverMaxAttrChange(EKSC_AttrType attrType, int value)
		{
			this.FeverMaxValue = (float)value;
			this.RefreshFever();
			this.UpdateFeverBar();
		}

		// Token: 0x0603B9EA RID: 244202 RVA: 0x010E974C File Offset: 0x010E794C
		private void RefreshFever()
		{
			bool flag = this.FeverValue <= 0f;
			bool flag2 = this.FeverValue >= this.FeverMaxValue;
			if (!flag && !flag2)
			{
				this.IsInProgress = true;
				return;
			}
			if (!this.IsInProgress)
			{
				return;
			}
			this.IsInProgress = false;
			if (flag2)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnPinballFeverChange, true);
				return;
			}
			if (flag)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnPinballFeverChange, false);
			}
		}

		// Token: 0x0401F70C RID: 128780
		private UKSC_AttrSet AttrSet;

		// Token: 0x0401F70D RID: 128781
		private UMaterialInstanceDynamic FeverBarMaterial;

		// Token: 0x0401F70E RID: 128782
		private FName MaterialParamName;

		// Token: 0x0401F70F RID: 128783
		private float FeverValue;

		// Token: 0x0401F710 RID: 128784
		private float FeverMaxValue;

		// Token: 0x0401F711 RID: 128785
		private float DissolveMin;

		// Token: 0x0401F712 RID: 128786
		private float DissolveMax = 1f;

		// Token: 0x0401F713 RID: 128787
		private float DissolveRange = 1f;

		// Token: 0x0401F714 RID: 128788
		private FOnKSCAttrChange DelegateFeverAttrChange;

		// Token: 0x0401F715 RID: 128789
		private FOnKSCAttrChange DelegateFeverMaxAttrChange;

		// Token: 0x0401F716 RID: 128790
		private bool IsInProgress;

		// Token: 0x0401F717 RID: 128791
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat UpdateStat = Stat.Create("PinballBattlePlayerBarController.UpdateFeverBar", "", "");
	}
}
