using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.SimpleCombat._3_3Pinball.GameBase.SpawnObj;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FBD RID: 28605
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballBattleFeverBarController
	{
		// Token: 0x06045834 RID: 284724 RVA: 0x0113F690 File Offset: 0x0113D890
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

		// Token: 0x06045835 RID: 284725 RVA: 0x0113F784 File Offset: 0x0113D984
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

		// Token: 0x06045836 RID: 284726 RVA: 0x0113F858 File Offset: 0x0113DA58
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

		// Token: 0x06045837 RID: 284727 RVA: 0x0113F8F8 File Offset: 0x0113DAF8
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

		// Token: 0x06045838 RID: 284728 RVA: 0x0113F94E File Offset: 0x0113DB4E
		private void OnFeverAttrChange(EKSC_AttrType attrType, int value)
		{
			this.FeverValue = (float)value;
			this.RefreshFever();
			this.UpdateFeverBar();
		}

		// Token: 0x06045839 RID: 284729 RVA: 0x0113F964 File Offset: 0x0113DB64
		private void OnFeverMaxAttrChange(EKSC_AttrType attrType, int value)
		{
			this.FeverMaxValue = (float)value;
			this.RefreshFever();
			this.UpdateFeverBar();
		}

		// Token: 0x0604583A RID: 284730 RVA: 0x0113F97C File Offset: 0x0113DB7C
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

		// Token: 0x04024457 RID: 148567
		private UKSC_AttrSet AttrSet;

		// Token: 0x04024458 RID: 148568
		private UMaterialInstanceDynamic FeverBarMaterial;

		// Token: 0x04024459 RID: 148569
		private FName MaterialParamName;

		// Token: 0x0402445A RID: 148570
		private float FeverValue;

		// Token: 0x0402445B RID: 148571
		private float FeverMaxValue;

		// Token: 0x0402445C RID: 148572
		private float DissolveMin;

		// Token: 0x0402445D RID: 148573
		private float DissolveMax = 1f;

		// Token: 0x0402445E RID: 148574
		private float DissolveRange = 1f;

		// Token: 0x0402445F RID: 148575
		private FOnKSCAttrChange DelegateFeverAttrChange;

		// Token: 0x04024460 RID: 148576
		private FOnKSCAttrChange DelegateFeverMaxAttrChange;

		// Token: 0x04024461 RID: 148577
		private bool IsInProgress;

		// Token: 0x04024462 RID: 148578
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat UpdateStat = Stat.Create("PinballBattlePlayerBarController.UpdateFeverBar", "", "");
	}
}
