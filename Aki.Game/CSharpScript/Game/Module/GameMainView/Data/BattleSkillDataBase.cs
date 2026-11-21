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
	// Token: 0x020049E1 RID: 18913
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class BattleSkillDataBase : ISkillButtonData
	{
		// Token: 0x17005F82 RID: 24450
		// (get) Token: 0x0602F594 RID: 193940 RVA: 0x00D351F2 File Offset: 0x00D333F2
		public bool IsExploreAsFight { get; }

		// Token: 0x17005F83 RID: 24451
		// (get) Token: 0x0602F595 RID: 193941 RVA: 0x00D351FA File Offset: 0x00D333FA
		public ESkillButtonAttributeUsageMode AttributeUsageMode { get; }

		// Token: 0x17005F84 RID: 24452
		// (get) Token: 0x0602F596 RID: 193942 RVA: 0x00D35202 File Offset: 0x00D33402
		public int[] AttributeUsageParams { get; }

		// Token: 0x17005F85 RID: 24453
		// (get) Token: 0x0602F597 RID: 193943 RVA: 0x00D3520A File Offset: 0x00D3340A
		public EAttributeType AttributeId { get; }

		// Token: 0x17005F86 RID: 24454
		// (get) Token: 0x0602F598 RID: 193944 RVA: 0x00D35212 File Offset: 0x00D33412
		public bool IsEnableSlideControl { get; }

		// Token: 0x17005F87 RID: 24455
		// (get) Token: 0x0602F599 RID: 193945 RVA: 0x00D3521A File Offset: 0x00D3341A
		public bool IsLimitCountCustom { get; }

		// Token: 0x17005F88 RID: 24456
		// (get) Token: 0x0602F59A RID: 193946 RVA: 0x00D35222 File Offset: 0x00D33422
		public int RemainingCountCustom { get; }

		// Token: 0x17005F89 RID: 24457
		// (get) Token: 0x0602F59B RID: 193947 RVA: 0x00D3522A File Offset: 0x00D3342A
		public int TotalCoolDownCustom { get; }

		// Token: 0x17005F8A RID: 24458
		// (get) Token: 0x0602F59C RID: 193948 RVA: 0x00D35232 File Offset: 0x00D33432
		public bool HideCoolDownTextCustom { get; }

		// Token: 0x17005F8B RID: 24459
		// (get) Token: 0x0602F59D RID: 193949 RVA: 0x00D3523A File Offset: 0x00D3343A
		public bool IsLimitCountVehicleSkill { get; }

		// Token: 0x17005F8C RID: 24460
		// (get) Token: 0x0602F59E RID: 193950 RVA: 0x00D35242 File Offset: 0x00D33442
		public int RemainingCountVehicleSkill { get; }

		// Token: 0x17005F8D RID: 24461
		// (get) Token: 0x0602F59F RID: 193951 RVA: 0x00D3524A File Offset: 0x00D3344A
		public EInputAction[] SharedHoldRingFxActions { get; }

		// Token: 0x17005F8E RID: 24462
		// (get) Token: 0x0602F5A0 RID: 193952 RVA: 0x00D35252 File Offset: 0x00D33452
		public bool IsEnableDotIndicator { get; }

		// Token: 0x17005F8F RID: 24463
		// (get) Token: 0x0602F5A1 RID: 193953 RVA: 0x00D3525A File Offset: 0x00D3345A
		public int DotIndicatorCount { get; }

		// Token: 0x0602F5A2 RID: 193954 RVA: 0x00D35262 File Offset: 0x00D33462
		[NullableContext(1)]
		public void InitData(string actionName)
		{
			this.ActionName = actionName;
			this.OnInitData();
		}

		// Token: 0x0602F5A3 RID: 193955 RVA: 0x00D35271 File Offset: 0x00D33471
		protected virtual void OnInitData()
		{
		}

		// Token: 0x0602F5A4 RID: 193956 RVA: 0x00D35273 File Offset: 0x00D33473
		public virtual EInputAction GetActionType()
		{
			return EInputAction.None;
		}

		// Token: 0x0602F5A5 RID: 193957 RVA: 0x00D3527A File Offset: 0x00D3347A
		[NullableContext(1)]
		public string GetInputAction()
		{
			return this.GetActionName();
		}

		// Token: 0x0602F5A6 RID: 193958 RVA: 0x00D35282 File Offset: 0x00D33482
		public virtual bool IsEnableInput()
		{
			return true;
		}

		// Token: 0x0602F5A7 RID: 193959 RVA: 0x00D35285 File Offset: 0x00D33485
		public virtual double GetLongPressTime()
		{
			return 0.0;
		}

		// Token: 0x0602F5A8 RID: 193960 RVA: 0x00D35290 File Offset: 0x00D33490
		public virtual void RefreshLongPressTime()
		{
		}

		// Token: 0x0602F5A9 RID: 193961 RVA: 0x00D35292 File Offset: 0x00D33492
		public virtual bool? GetIsLongPressControlCamera()
		{
			return new bool?(false);
		}

		// Token: 0x0602F5AA RID: 193962 RVA: 0x00D3529A File Offset: 0x00D3349A
		public string GetActionName()
		{
			return this.ActionName;
		}

		// Token: 0x0602F5AB RID: 193963 RVA: 0x00D352A2 File Offset: 0x00D334A2
		public virtual bool? IsMultiStageSkill()
		{
			return new bool?(false);
		}

		// Token: 0x0602F5AC RID: 193964 RVA: 0x00D352AA File Offset: 0x00D334AA
		[NullableContext(1)]
		public virtual string GetMultiSkillTexturePath()
		{
			return "";
		}

		// Token: 0x0602F5AD RID: 193965 RVA: 0x00D352B1 File Offset: 0x00D334B1
		public virtual string GetSkillTexturePath()
		{
			return "";
		}

		// Token: 0x0602F5AE RID: 193966 RVA: 0x00D352B8 File Offset: 0x00D334B8
		public virtual int GetSkillId()
		{
			return 0;
		}

		// Token: 0x0602F5AF RID: 193967 RVA: 0x00D352BB File Offset: 0x00D334BB
		public virtual string GetSkillIconName()
		{
			return "";
		}

		// Token: 0x0602F5B0 RID: 193968 RVA: 0x00D352C2 File Offset: 0x00D334C2
		public virtual MultiSkillInfo GetMultiSkillInfo()
		{
			return null;
		}

		// Token: 0x0602F5B1 RID: 193969 RVA: 0x00D352C5 File Offset: 0x00D334C5
		public virtual GroupSkillCdInfo GetGroupSkillCdInfo()
		{
			return null;
		}

		// Token: 0x0602F5B2 RID: 193970 RVA: 0x00D352C8 File Offset: 0x00D334C8
		public virtual bool HasCdComponent()
		{
			return false;
		}

		// Token: 0x0602F5B3 RID: 193971 RVA: 0x00D352CB File Offset: 0x00D334CB
		public virtual float GetSkillRemainingCoolDown()
		{
			return 0f;
		}

		// Token: 0x0602F5B4 RID: 193972 RVA: 0x00D352D2 File Offset: 0x00D334D2
		public virtual bool IsCdVisible()
		{
			return false;
		}

		// Token: 0x0602F5B5 RID: 193973 RVA: 0x00D352D5 File Offset: 0x00D334D5
		public virtual void RefreshIsEnable()
		{
		}

		// Token: 0x0602F5B6 RID: 193974 RVA: 0x00D352D7 File Offset: 0x00D334D7
		public virtual bool IsVehicleSkillInCd()
		{
			return false;
		}

		// Token: 0x0602F5B7 RID: 193975 RVA: 0x00D352DA File Offset: 0x00D334DA
		public virtual float GetRemainingCoolDownCustom()
		{
			return 0f;
		}

		// Token: 0x0602F5B8 RID: 193976 RVA: 0x00D352E1 File Offset: 0x00D334E1
		public virtual float GetAttribute()
		{
			return 0f;
		}

		// Token: 0x0602F5B9 RID: 193977 RVA: 0x00D352E8 File Offset: 0x00D334E8
		public virtual float GetMaxAttribute()
		{
			return 0f;
		}

		// Token: 0x0602F5BA RID: 193978 RVA: 0x00D352EF File Offset: 0x00D334EF
		public virtual ESkillButtonType GetButtonType()
		{
			return ESkillButtonType.None;
		}

		// Token: 0x0602F5BB RID: 193979 RVA: 0x00D352F2 File Offset: 0x00D334F2
		public virtual bool IsSkillInItemUseCd()
		{
			return false;
		}

		// Token: 0x0602F5BC RID: 193980 RVA: 0x00D352F5 File Offset: 0x00D334F5
		public virtual bool IsEquippedItemBanReqUse()
		{
			return false;
		}

		// Token: 0x0602F5BD RID: 193981 RVA: 0x00D352F8 File Offset: 0x00D334F8
		public virtual bool IsSkillInItemUseBuffCd()
		{
			return false;
		}

		// Token: 0x0602F5BE RID: 193982 RVA: 0x00D352FB File Offset: 0x00D334FB
		[NullableContext(0)]
		public virtual ValueTuple<double, double> GetEquippedItemUsingBuffCd()
		{
			return new ValueTuple<double, double>(0.0, 0.0);
		}

		// Token: 0x0602F5BF RID: 193983 RVA: 0x00D35314 File Offset: 0x00D33514
		public virtual bool IsSkillInItemUseSkillCd()
		{
			return false;
		}

		// Token: 0x0602F5C0 RID: 193984 RVA: 0x00D35317 File Offset: 0x00D33517
		[NullableContext(0)]
		public virtual ValueTuple<double, double> GetEquippedItemUsingSkillCd()
		{
			return new ValueTuple<double, double>(0.0, 0.0);
		}

		// Token: 0x0602F5C1 RID: 193985 RVA: 0x00D35330 File Offset: 0x00D33530
		[NullableContext(0)]
		public virtual ValueTuple<double, double> GetVehicleSkillCd()
		{
			return new ValueTuple<double, double>(0.0, 0.0);
		}

		// Token: 0x0602F5C2 RID: 193986 RVA: 0x00D35349 File Offset: 0x00D33549
		public bool GetExploreSkillChange()
		{
			return this.IsExploreSkillChange;
		}

		// Token: 0x0602F5C3 RID: 193987 RVA: 0x00D35351 File Offset: 0x00D33551
		public void SetExploreSkillChange(bool isExploreSkillChange)
		{
			this.IsExploreSkillChange = isExploreSkillChange;
		}

		// Token: 0x0602F5C4 RID: 193988 RVA: 0x00D3535A File Offset: 0x00D3355A
		[NullableContext(1)]
		public virtual string GetMaxAttributeEffectPath()
		{
			return "";
		}

		// Token: 0x0602F5C5 RID: 193989 RVA: 0x00D35364 File Offset: 0x00D33564
		public virtual FLinearColor? GetMaxAttributeColor()
		{
			return null;
		}

		// Token: 0x0602F5C6 RID: 193990 RVA: 0x00D3537C File Offset: 0x00D3357C
		public virtual SkillButtonEffect? GetDynamicEffectConfig()
		{
			return null;
		}

		// Token: 0x0602F5C7 RID: 193991 RVA: 0x00D35392 File Offset: 0x00D33592
		public virtual int GetCdCompletedEffectId()
		{
			return 0;
		}

		// Token: 0x0602F5C8 RID: 193992 RVA: 0x00D35398 File Offset: 0x00D33598
		public virtual SkillButtonEffect? GetCdCompletedEffectConfig()
		{
			return null;
		}

		// Token: 0x0602F5C9 RID: 193993 RVA: 0x00D353AE File Offset: 0x00D335AE
		public virtual bool HasConfigFollower()
		{
			return false;
		}

		// Token: 0x0602F5CA RID: 193994 RVA: 0x00D353B4 File Offset: 0x00D335B4
		public virtual FColor? GetFrameSpriteColor()
		{
			return null;
		}

		// Token: 0x0602F5CB RID: 193995 RVA: 0x00D353CA File Offset: 0x00D335CA
		public virtual bool HasAttribute()
		{
			return this.AttributeId != EAttributeType.None && this.MaxAttributeId != 0;
		}

		// Token: 0x0602F5CC RID: 193996 RVA: 0x00D353DF File Offset: 0x00D335DF
		public virtual bool IsEnable()
		{
			return true;
		}

		// Token: 0x0602F5CD RID: 193997 RVA: 0x00D353E2 File Offset: 0x00D335E2
		public virtual void InitVehicleHandle()
		{
		}

		// Token: 0x0602F5CE RID: 193998 RVA: 0x00D353E4 File Offset: 0x00D335E4
		public bool IsShowLongPress()
		{
			return this.IsShowLongPressInternal;
		}

		// Token: 0x0602F5CF RID: 193999 RVA: 0x00D353EC File Offset: 0x00D335EC
		public virtual void RefreshIsShowLongPress()
		{
		}

		// Token: 0x0602F5D0 RID: 194000 RVA: 0x00D353EE File Offset: 0x00D335EE
		public virtual void RefreshLongPressDuration()
		{
		}

		// Token: 0x0602F5D1 RID: 194001 RVA: 0x00D353F0 File Offset: 0x00D335F0
		public double GetLongPressDuration()
		{
			return (double)this.LongPressDuration;
		}

		// Token: 0x0602F5D2 RID: 194002 RVA: 0x00D353F9 File Offset: 0x00D335F9
		public virtual bool GetIsLongPressing()
		{
			return false;
		}

		// Token: 0x0602F5D3 RID: 194003 RVA: 0x00D353FC File Offset: 0x00D335FC
		public bool GetIsConfigShowLongPress()
		{
			return this.IsConfigShowLongPress;
		}

		// Token: 0x0602F5D4 RID: 194004 RVA: 0x00D35404 File Offset: 0x00D33604
		public void SetIsConfigShowLongPress(bool value)
		{
			this.IsConfigShowLongPress = value;
		}

		// Token: 0x0602F5D5 RID: 194005 RVA: 0x00D3540D File Offset: 0x00D3360D
		public bool IsVisible()
		{
			return this.IsVisibleInternal;
		}

		// Token: 0x0602F5D6 RID: 194006 RVA: 0x00D35415 File Offset: 0x00D33615
		public virtual int GetMaxAttributeBurstEffectId()
		{
			return 0;
		}

		// Token: 0x0602F5D7 RID: 194007 RVA: 0x00D35418 File Offset: 0x00D33618
		public virtual SkillButtonEffect? GetMaxAttributeBurstEffectConfig()
		{
			return null;
		}

		// Token: 0x0602F5D8 RID: 194008 RVA: 0x00D3542E File Offset: 0x00D3362E
		public virtual bool IsEnableLongPress()
		{
			return false;
		}

		// Token: 0x0602F5D9 RID: 194009 RVA: 0x00D35431 File Offset: 0x00D33631
		public virtual SkillButtonTypeFormationData GetFormationData()
		{
			return null;
		}

		// Token: 0x0602F5DA RID: 194010 RVA: 0x00D35434 File Offset: 0x00D33634
		public virtual bool IsSkillIdChangeByTag()
		{
			return false;
		}

		// Token: 0x0602F5DB RID: 194011 RVA: 0x00D35437 File Offset: 0x00D33637
		public List<EInputAction> GetValidSharedHoldRingFxActions()
		{
			return null;
		}

		// Token: 0x040191A8 RID: 102824
		[Nullable(1)]
		private string ActionName = "";

		// Token: 0x040191A9 RID: 102825
		private bool IsExploreSkillChange;

		// Token: 0x040191AE RID: 102830
		public int MaxAttributeId;

		// Token: 0x040191AF RID: 102831
		protected bool IsShowLongPressInternal;

		// Token: 0x040191B0 RID: 102832
		protected float LongPressDuration;

		// Token: 0x040191B1 RID: 102833
		protected bool IsConfigShowLongPress;

		// Token: 0x040191B2 RID: 102834
		protected bool IsVisibleInternal = true;
	}
}
