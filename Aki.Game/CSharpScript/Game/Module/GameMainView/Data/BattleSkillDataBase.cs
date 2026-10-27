using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.Data
{
	// Token: 0x02005A05 RID: 23045
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class BattleSkillDataBase : ISkillButtonData
	{
		// Token: 0x17008BB4 RID: 35764
		// (get) Token: 0x0603A64B RID: 239179 RVA: 0x00DE4CA2 File Offset: 0x00DE2EA2
		public bool IsExploreAsFight { get; }

		// Token: 0x17008BB5 RID: 35765
		// (get) Token: 0x0603A64C RID: 239180 RVA: 0x00DE4CAA File Offset: 0x00DE2EAA
		public ESkillButtonAttributeUsageMode AttributeUsageMode { get; }

		// Token: 0x17008BB6 RID: 35766
		// (get) Token: 0x0603A64D RID: 239181 RVA: 0x00DE4CB2 File Offset: 0x00DE2EB2
		public int[] AttributeUsageParams { get; }

		// Token: 0x17008BB7 RID: 35767
		// (get) Token: 0x0603A64E RID: 239182 RVA: 0x00DE4CBA File Offset: 0x00DE2EBA
		public EAttributeType AttributeId { get; }

		// Token: 0x17008BB8 RID: 35768
		// (get) Token: 0x0603A64F RID: 239183 RVA: 0x00DE4CC2 File Offset: 0x00DE2EC2
		public bool IsEnableSlideControl { get; }

		// Token: 0x17008BB9 RID: 35769
		// (get) Token: 0x0603A650 RID: 239184 RVA: 0x00DE4CCA File Offset: 0x00DE2ECA
		public bool IsLimitCountCustom { get; }

		// Token: 0x17008BBA RID: 35770
		// (get) Token: 0x0603A651 RID: 239185 RVA: 0x00DE4CD2 File Offset: 0x00DE2ED2
		public int RemainingCountCustom { get; }

		// Token: 0x17008BBB RID: 35771
		// (get) Token: 0x0603A652 RID: 239186 RVA: 0x00DE4CDA File Offset: 0x00DE2EDA
		public int TotalCoolDownCustom { get; }

		// Token: 0x17008BBC RID: 35772
		// (get) Token: 0x0603A653 RID: 239187 RVA: 0x00DE4CE2 File Offset: 0x00DE2EE2
		public bool HideCoolDownTextCustom { get; }

		// Token: 0x17008BBD RID: 35773
		// (get) Token: 0x0603A654 RID: 239188 RVA: 0x00DE4CEA File Offset: 0x00DE2EEA
		public bool IsLimitCountVehicleSkill { get; }

		// Token: 0x17008BBE RID: 35774
		// (get) Token: 0x0603A655 RID: 239189 RVA: 0x00DE4CF2 File Offset: 0x00DE2EF2
		public int RemainingCountVehicleSkill { get; }

		// Token: 0x17008BBF RID: 35775
		// (get) Token: 0x0603A656 RID: 239190 RVA: 0x00DE4CFA File Offset: 0x00DE2EFA
		public EInputAction[] SharedHoldRingFxActions { get; }

		// Token: 0x17008BC0 RID: 35776
		// (get) Token: 0x0603A657 RID: 239191 RVA: 0x00DE4D02 File Offset: 0x00DE2F02
		public bool IsEnableDotIndicator { get; }

		// Token: 0x17008BC1 RID: 35777
		// (get) Token: 0x0603A658 RID: 239192 RVA: 0x00DE4D0A File Offset: 0x00DE2F0A
		public int DotIndicatorCount { get; }

		// Token: 0x0603A659 RID: 239193 RVA: 0x00DE4D12 File Offset: 0x00DE2F12
		[NullableContext(1)]
		public void InitData(string actionName)
		{
			this.ActionName = actionName;
			this.OnInitData();
		}

		// Token: 0x0603A65A RID: 239194 RVA: 0x00DE4D21 File Offset: 0x00DE2F21
		protected virtual void OnInitData()
		{
		}

		// Token: 0x0603A65B RID: 239195 RVA: 0x00DE4D23 File Offset: 0x00DE2F23
		public virtual EInputAction GetActionType()
		{
			return EInputAction.None;
		}

		// Token: 0x0603A65C RID: 239196 RVA: 0x00DE4D2A File Offset: 0x00DE2F2A
		[NullableContext(1)]
		public string GetInputAction()
		{
			return this.GetActionName();
		}

		// Token: 0x0603A65D RID: 239197 RVA: 0x00DE4D32 File Offset: 0x00DE2F32
		public virtual bool IsEnableInput()
		{
			return true;
		}

		// Token: 0x0603A65E RID: 239198 RVA: 0x00DE4D35 File Offset: 0x00DE2F35
		public virtual double GetLongPressTime()
		{
			return 0.0;
		}

		// Token: 0x0603A65F RID: 239199 RVA: 0x00DE4D40 File Offset: 0x00DE2F40
		public virtual void RefreshLongPressTime()
		{
		}

		// Token: 0x0603A660 RID: 239200 RVA: 0x00DE4D42 File Offset: 0x00DE2F42
		public virtual bool? GetIsLongPressControlCamera()
		{
			return new bool?(false);
		}

		// Token: 0x0603A661 RID: 239201 RVA: 0x00DE4D4A File Offset: 0x00DE2F4A
		public string GetActionName()
		{
			return this.ActionName;
		}

		// Token: 0x0603A662 RID: 239202 RVA: 0x00DE4D52 File Offset: 0x00DE2F52
		public virtual bool? IsMultiStageSkill()
		{
			return new bool?(false);
		}

		// Token: 0x0603A663 RID: 239203 RVA: 0x00DE4D5A File Offset: 0x00DE2F5A
		[NullableContext(1)]
		public virtual string GetMultiSkillTexturePath()
		{
			return "";
		}

		// Token: 0x0603A664 RID: 239204 RVA: 0x00DE4D61 File Offset: 0x00DE2F61
		public virtual string GetSkillTexturePath()
		{
			return "";
		}

		// Token: 0x0603A665 RID: 239205 RVA: 0x00DE4D68 File Offset: 0x00DE2F68
		public virtual int GetSkillId()
		{
			return 0;
		}

		// Token: 0x0603A666 RID: 239206 RVA: 0x00DE4D6B File Offset: 0x00DE2F6B
		public virtual string GetSkillIconName()
		{
			return "";
		}

		// Token: 0x0603A667 RID: 239207 RVA: 0x00DE4D72 File Offset: 0x00DE2F72
		public virtual MultiSkillInfo GetMultiSkillInfo()
		{
			return null;
		}

		// Token: 0x0603A668 RID: 239208 RVA: 0x00DE4D75 File Offset: 0x00DE2F75
		public virtual GroupSkillCdInfo GetGroupSkillCdInfo()
		{
			return null;
		}

		// Token: 0x0603A669 RID: 239209 RVA: 0x00DE4D78 File Offset: 0x00DE2F78
		public virtual bool HasCdComponent()
		{
			return false;
		}

		// Token: 0x0603A66A RID: 239210 RVA: 0x00DE4D7B File Offset: 0x00DE2F7B
		public virtual float GetSkillRemainingCoolDown()
		{
			return 0f;
		}

		// Token: 0x0603A66B RID: 239211 RVA: 0x00DE4D82 File Offset: 0x00DE2F82
		public virtual bool IsCdVisible()
		{
			return false;
		}

		// Token: 0x0603A66C RID: 239212 RVA: 0x00DE4D85 File Offset: 0x00DE2F85
		public virtual void RefreshIsEnable()
		{
		}

		// Token: 0x0603A66D RID: 239213 RVA: 0x00DE4D87 File Offset: 0x00DE2F87
		public virtual bool IsVehicleSkillInCd()
		{
			return false;
		}

		// Token: 0x0603A66E RID: 239214 RVA: 0x00DE4D8A File Offset: 0x00DE2F8A
		public virtual float GetRemainingCoolDownCustom()
		{
			return 0f;
		}

		// Token: 0x0603A66F RID: 239215 RVA: 0x00DE4D91 File Offset: 0x00DE2F91
		public virtual float GetAttribute()
		{
			return 0f;
		}

		// Token: 0x0603A670 RID: 239216 RVA: 0x00DE4D98 File Offset: 0x00DE2F98
		public virtual float GetMaxAttribute()
		{
			return 0f;
		}

		// Token: 0x0603A671 RID: 239217 RVA: 0x00DE4D9F File Offset: 0x00DE2F9F
		public virtual ESkillButtonType GetButtonType()
		{
			return ESkillButtonType.None;
		}

		// Token: 0x0603A672 RID: 239218 RVA: 0x00DE4DA2 File Offset: 0x00DE2FA2
		public virtual bool IsSkillInItemUseCd()
		{
			return false;
		}

		// Token: 0x0603A673 RID: 239219 RVA: 0x00DE4DA5 File Offset: 0x00DE2FA5
		public virtual bool IsEquippedItemBanReqUse()
		{
			return false;
		}

		// Token: 0x0603A674 RID: 239220 RVA: 0x00DE4DA8 File Offset: 0x00DE2FA8
		public virtual bool IsSkillInItemUseBuffCd()
		{
			return false;
		}

		// Token: 0x0603A675 RID: 239221 RVA: 0x00DE4DAB File Offset: 0x00DE2FAB
		[NullableContext(0)]
		public virtual ValueTuple<double, double> GetEquippedItemUsingBuffCd()
		{
			return new ValueTuple<double, double>(0.0, 0.0);
		}

		// Token: 0x0603A676 RID: 239222 RVA: 0x00DE4DC4 File Offset: 0x00DE2FC4
		public virtual bool IsSkillInItemUseSkillCd()
		{
			return false;
		}

		// Token: 0x0603A677 RID: 239223 RVA: 0x00DE4DC7 File Offset: 0x00DE2FC7
		[NullableContext(0)]
		public virtual ValueTuple<double, double> GetEquippedItemUsingSkillCd()
		{
			return new ValueTuple<double, double>(0.0, 0.0);
		}

		// Token: 0x0603A678 RID: 239224 RVA: 0x00DE4DE0 File Offset: 0x00DE2FE0
		[NullableContext(0)]
		public virtual ValueTuple<double, double> GetVehicleSkillCd()
		{
			return new ValueTuple<double, double>(0.0, 0.0);
		}

		// Token: 0x0603A679 RID: 239225 RVA: 0x00DE4DF9 File Offset: 0x00DE2FF9
		public bool GetExploreSkillChange()
		{
			return this.IsExploreSkillChange;
		}

		// Token: 0x0603A67A RID: 239226 RVA: 0x00DE4E01 File Offset: 0x00DE3001
		public void SetExploreSkillChange(bool isExploreSkillChange)
		{
			this.IsExploreSkillChange = isExploreSkillChange;
		}

		// Token: 0x0603A67B RID: 239227 RVA: 0x00DE4E0A File Offset: 0x00DE300A
		[NullableContext(1)]
		public virtual string GetMaxAttributeEffectPath()
		{
			return "";
		}

		// Token: 0x0603A67C RID: 239228 RVA: 0x00DE4E14 File Offset: 0x00DE3014
		public virtual FLinearColor? GetMaxAttributeColor()
		{
			return null;
		}

		// Token: 0x0603A67D RID: 239229 RVA: 0x00DE4E2C File Offset: 0x00DE302C
		public virtual SkillButtonEffect? GetDynamicEffectConfig()
		{
			return null;
		}

		// Token: 0x0603A67E RID: 239230 RVA: 0x00DE4E42 File Offset: 0x00DE3042
		public virtual int GetCdCompletedEffectId()
		{
			return 0;
		}

		// Token: 0x0603A67F RID: 239231 RVA: 0x00DE4E48 File Offset: 0x00DE3048
		public virtual SkillButtonEffect? GetCdCompletedEffectConfig()
		{
			return null;
		}

		// Token: 0x0603A680 RID: 239232 RVA: 0x00DE4E5E File Offset: 0x00DE305E
		public virtual bool HasConfigFollower()
		{
			return false;
		}

		// Token: 0x0603A681 RID: 239233 RVA: 0x00DE4E64 File Offset: 0x00DE3064
		public virtual FColor? GetFrameSpriteColor()
		{
			return null;
		}

		// Token: 0x0603A682 RID: 239234 RVA: 0x00DE4E7A File Offset: 0x00DE307A
		public virtual bool HasAttribute()
		{
			return this.AttributeId != EAttributeType.None && this.MaxAttributeId != 0;
		}

		// Token: 0x0603A683 RID: 239235 RVA: 0x00DE4E8F File Offset: 0x00DE308F
		public virtual bool IsEnable()
		{
			return true;
		}

		// Token: 0x0603A684 RID: 239236 RVA: 0x00DE4E92 File Offset: 0x00DE3092
		public virtual void InitVehicleHandle()
		{
		}

		// Token: 0x0603A685 RID: 239237 RVA: 0x00DE4E94 File Offset: 0x00DE3094
		public bool IsShowLongPress()
		{
			return this.IsShowLongPressInternal;
		}

		// Token: 0x0603A686 RID: 239238 RVA: 0x00DE4E9C File Offset: 0x00DE309C
		public virtual void RefreshIsShowLongPress()
		{
		}

		// Token: 0x0603A687 RID: 239239 RVA: 0x00DE4E9E File Offset: 0x00DE309E
		public virtual void RefreshLongPressDuration()
		{
		}

		// Token: 0x0603A688 RID: 239240 RVA: 0x00DE4EA0 File Offset: 0x00DE30A0
		public double GetLongPressDuration()
		{
			return (double)this.LongPressDuration;
		}

		// Token: 0x0603A689 RID: 239241 RVA: 0x00DE4EA9 File Offset: 0x00DE30A9
		public virtual bool GetIsLongPressing()
		{
			return false;
		}

		// Token: 0x0603A68A RID: 239242 RVA: 0x00DE4EAC File Offset: 0x00DE30AC
		public bool GetIsConfigShowLongPress()
		{
			return this.IsConfigShowLongPress;
		}

		// Token: 0x0603A68B RID: 239243 RVA: 0x00DE4EB4 File Offset: 0x00DE30B4
		public void SetIsConfigShowLongPress(bool value)
		{
			this.IsConfigShowLongPress = value;
		}

		// Token: 0x0603A68C RID: 239244 RVA: 0x00DE4EBD File Offset: 0x00DE30BD
		public bool IsVisible()
		{
			return this.IsVisibleInternal;
		}

		// Token: 0x0603A68D RID: 239245 RVA: 0x00DE4EC5 File Offset: 0x00DE30C5
		public virtual int GetMaxAttributeBurstEffectId()
		{
			return 0;
		}

		// Token: 0x0603A68E RID: 239246 RVA: 0x00DE4EC8 File Offset: 0x00DE30C8
		public virtual SkillButtonEffect? GetMaxAttributeBurstEffectConfig()
		{
			return null;
		}

		// Token: 0x0603A68F RID: 239247 RVA: 0x00DE4EDE File Offset: 0x00DE30DE
		public virtual bool IsEnableLongPress()
		{
			return false;
		}

		// Token: 0x0603A690 RID: 239248 RVA: 0x00DE4EE1 File Offset: 0x00DE30E1
		public virtual SkillButtonTypeFormationData GetFormationData()
		{
			return null;
		}

		// Token: 0x0603A691 RID: 239249 RVA: 0x00DE4EE4 File Offset: 0x00DE30E4
		public virtual bool IsSkillIdChangeByTag()
		{
			return false;
		}

		// Token: 0x0603A692 RID: 239250 RVA: 0x00DE4EE7 File Offset: 0x00DE30E7
		public List<EInputAction> GetValidSharedHoldRingFxActions()
		{
			return null;
		}

		// Token: 0x0401E701 RID: 124673
		[Nullable(1)]
		private string ActionName = "";

		// Token: 0x0401E702 RID: 124674
		private bool IsExploreSkillChange;

		// Token: 0x0401E707 RID: 124679
		public int MaxAttributeId;

		// Token: 0x0401E708 RID: 124680
		protected bool IsShowLongPressInternal;

		// Token: 0x0401E709 RID: 124681
		protected float LongPressDuration;

		// Token: 0x0401E70A RID: 124682
		protected bool IsConfigShowLongPress;

		// Token: 0x0401E70B RID: 124683
		protected bool IsVisibleInternal = true;
	}
}
