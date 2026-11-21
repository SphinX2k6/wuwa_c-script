using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D22 RID: 19746
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonHeadState : HeadStateViewBase
	{
		// Token: 0x0603182E RID: 202798 RVA: 0x00DD84DC File Offset: 0x00DD66DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603182F RID: 202799 RVA: 0x00DD86D8 File Offset: 0x00DD68D8
		protected override UniTask OnBeforeStartAsync()
		{
			CommonHeadState.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonHeadState.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031830 RID: 202800 RVA: 0x00DD871B File Offset: 0x00DD691B
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.RefreshHpAndShield(false);
			this.RefreshLevelText();
			this.RefreshHeadStateDetail();
			this.RefreshLevelTextVisible();
			this.RefreshBuffVisible();
			this.RefreshBuff();
			this.RefreshHpColor();
			this.RefreshWeaknessItem(true);
		}

		// Token: 0x06031831 RID: 202801 RVA: 0x00DD8756 File Offset: 0x00DD6956
		protected override void OnStart()
		{
			this.InitAllTweenAnim();
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
			this.BuffItemContainer.Init(base.GetItem(5), 6, true, false, false, null);
		}

		// Token: 0x06031832 RID: 202802 RVA: 0x00DD878C File Offset: 0x00DD698C
		protected override void OnBeforeDestroy()
		{
			if (this.WeaknessItem != null)
			{
				this.WeaknessItem.Destroy(null);
				this.WeaknessItem = null;
			}
		}

		// Token: 0x06031833 RID: 202803 RVA: 0x00DD87AC File Offset: 0x00DD69AC
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			UUIItem item = base.GetItem(7);
			if (this.ExtraItem != null)
			{
				this.ExtraItem.GetRootItem().SetUIParent(item, false);
				if (item != null)
				{
					item.SetUIActive(true);
					return;
				}
			}
			else if (item != null)
			{
				item.SetUIActive(false);
			}
		}

		// Token: 0x06031834 RID: 202804 RVA: 0x00DD87F6 File Offset: 0x00DD69F6
		protected override void ResetBattleHeadState()
		{
			this.BuffItemContainer.ClearAll();
			HeadStateWeaknessItem weaknessItem = this.WeaknessItem;
			if (weaknessItem != null)
			{
				weaknessItem.Refresh(null);
			}
			base.ResetBattleHeadState();
		}

		// Token: 0x06031835 RID: 202805 RVA: 0x00DD881C File Offset: 0x00DD6A1C
		private void RefreshWeaknessItem(bool isStart = false)
		{
			base.GetUiNiagara(11).SetUIActive(false);
			if (this.WeaknessItem == null)
			{
				return;
			}
			HeadStateWeaknessItem weaknessItem = this.WeaknessItem;
			HeadStateData headStateData = this.HeadStateData;
			weaknessItem.Refresh((headStateData != null) ? headStateData.GetEntity() : null);
			this.RefreshHpWeaknessPercent();
			this.RefreshHpWeaknessState(isStart);
			this.WeaknessItem.SetStateChangeCallback(new Action(this.OnWeaknessStateChanged));
		}

		// Token: 0x06031836 RID: 202806 RVA: 0x00DD8881 File Offset: 0x00DD6A81
		private void RefreshHpWeaknessPercent()
		{
			if (this.WeaknessItem != null && this.WeaknessItem.IsFullState(true))
			{
				base.GetSprite(10).SetFillAmount(this.CurrentBarPercent);
			}
		}

		// Token: 0x06031837 RID: 202807 RVA: 0x00DD88AC File Offset: 0x00DD6AAC
		private void RefreshHpWeaknessState(bool isStart = false)
		{
			if (this.WeaknessItem.IsInBreakAnim())
			{
				base.GetItem(9).SetUIActive(true);
				if (!isStart)
				{
					this.PlayTweenAnim(13);
					return;
				}
			}
			else if (this.WeaknessItem.IsFullState(true))
			{
				base.GetItem(9).SetUIActive(true);
				if (!isStart)
				{
					this.PlayTweenAnim(12);
					return;
				}
			}
			else
			{
				base.GetItem(9).SetUIActive(false);
			}
		}

		// Token: 0x06031838 RID: 202808 RVA: 0x00DD8916 File Offset: 0x00DD6B16
		private void OnWeaknessStateChanged()
		{
			this.RefreshHpWeaknessPercent();
			this.RefreshHpWeaknessState(false);
		}

		// Token: 0x06031839 RID: 202809 RVA: 0x00DD8925 File Offset: 0x00DD6B25
		protected override string GetResourceId()
		{
			return "UiItem_LittleMonsterState_Prefab";
		}

		// Token: 0x0603183A RID: 202810 RVA: 0x00DD892C File Offset: 0x00DD6B2C
		public override void OnRefresh(float distance, float scale, float delta)
		{
			base.OnRefresh(distance, scale, delta);
			if (!this.IsActivated)
			{
				return;
			}
			this.RefreshHeadStateDetail();
			this.RefreshLevelTextVisible();
			this.RefreshBuffVisible();
			this.TickBuffItem(delta);
			HeadStateWeaknessItem weaknessItem = this.WeaknessItem;
			if (weaknessItem == null)
			{
				return;
			}
			weaknessItem.Tick(delta);
		}

		// Token: 0x0603183B RID: 202811 RVA: 0x00DD896A File Offset: 0x00DD6B6A
		protected override void OnAddOrRemoveBuff(int entityId, in GameplayCue cueConfig, bool isAdd, int handleId)
		{
			if (this.HeadStateData.GetEntityId() != entityId)
			{
				return;
			}
			if (isAdd)
			{
				this.BuffItemContainer.AddBuffByCue(cueConfig, handleId, true);
				return;
			}
			this.BuffItemContainer.RemoveBuffByCue(cueConfig, handleId, true);
		}

		// Token: 0x0603183C RID: 202812 RVA: 0x00DD89A4 File Offset: 0x00DD6BA4
		private void RefreshBuff()
		{
			if (this.HeadStateData == null)
			{
				this.BuffItemContainer.ClearAll();
				return;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(this.HeadStateData.GetEntityId());
			this.BuffItemContainer.RefreshBuff(handle);
		}

		// Token: 0x0603183D RID: 202813 RVA: 0x00DD89E8 File Offset: 0x00DD6BE8
		private void RefreshHpColor()
		{
			string hpColor = base.GetHpColor();
			if (string.IsNullOrEmpty(hpColor))
			{
				return;
			}
			FColor color = FColor.FromHex(hpColor);
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(color);
		}

		// Token: 0x0603183E RID: 202814 RVA: 0x00DD8A20 File Offset: 0x00DD6C20
		private void RefreshHeadStateDetail()
		{
			bool flag = base.IsDetailVisible();
			base.GetItem(4).SetUIActive(flag);
			StateExtraItemBase extraItem = this.ExtraItem;
			if (extraItem != null)
			{
				extraItem.SetUiActive(flag);
			}
			this.WeaknessContainer.SetUIActive(flag);
		}

		// Token: 0x0603183F RID: 202815 RVA: 0x00DD8A60 File Offset: 0x00DD6C60
		private void RefreshLevelTextVisible()
		{
			bool uiactive = base.IsLevelTextVisible();
			base.GetText(3).SetUIActive(uiactive);
		}

		// Token: 0x06031840 RID: 202816 RVA: 0x00DD8A84 File Offset: 0x00DD6C84
		private void RefreshBuffVisible()
		{
			bool uiactive = base.IsBuffVisible();
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x06031841 RID: 202817 RVA: 0x00DD8AA5 File Offset: 0x00DD6CA5
		private void TickBuffItem(float delta)
		{
			if (!base.IsBuffVisible())
			{
				return;
			}
			this.BuffItemContainer.Tick(delta);
		}

		// Token: 0x06031842 RID: 202818 RVA: 0x00DD8ABC File Offset: 0x00DD6CBC
		public void RefreshHpAndShield(bool bPlayBarAnimation = false)
		{
			ValueTuple<float, float> hpAndShieldPercent = base.GetHpAndShieldPercent();
			float item = hpAndShieldPercent.Item1;
			float item2 = hpAndShieldPercent.Item2;
			this.SetHpBarPercent(item);
			this.SetShieldBarPercent(item2);
			if (bPlayBarAnimation)
			{
				this.PlayBarAnimation(item);
			}
			else
			{
				this.StopBarLerpAnimation();
			}
			this.RefreshHpWeaknessPercent();
		}

		// Token: 0x06031843 RID: 202819 RVA: 0x00DD8B02 File Offset: 0x00DD6D02
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x06031844 RID: 202820 RVA: 0x00DD8B0B File Offset: 0x00DD6D0B
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x06031845 RID: 202821 RVA: 0x00DD8B20 File Offset: 0x00DD6D20
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x06031846 RID: 202822 RVA: 0x00DD8B29 File Offset: 0x00DD6D29
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x06031847 RID: 202823 RVA: 0x00DD8B38 File Offset: 0x00DD6D38
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetFillAmount(percent);
			if (!sprite.IsUIActiveSelf())
			{
				sprite.SetUIActive(true);
			}
			UUISprite sprite2 = base.GetSprite(2);
			sprite2.SetStretchLeft(this.HpParentWidth * this.CurrentBarPercent - 2f);
			sprite2.SetStretchRight(this.HpParentWidth * (1f - percent) - 2f);
		}

		// Token: 0x06031848 RID: 202824 RVA: 0x00DD8B9C File Offset: 0x00DD6D9C
		private void SetShieldBarPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(6);
			if (percent > 0f)
			{
				sprite.SetFillAmount(percent);
				sprite.SetUIActive(true);
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x06031849 RID: 202825 RVA: 0x00DD8BCF File Offset: 0x00DD6DCF
		protected override void OnShieldChanged(float shield)
		{
			this.RefreshHpAndShield(false);
		}

		// Token: 0x0603184A RID: 202826 RVA: 0x00DD8BD8 File Offset: 0x00DD6DD8
		protected override void OnChangeTeam()
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603184B RID: 202827 RVA: 0x00DD8BE0 File Offset: 0x00DD6DE0
		protected override void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603184C RID: 202828 RVA: 0x00DD8BE8 File Offset: 0x00DD6DE8
		protected override void OnRoleLevelChange(int configId, int exp, int level)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603184D RID: 202829 RVA: 0x00DD8BF0 File Offset: 0x00DD6DF0
		protected override void OnHealthChanged()
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603184E RID: 202830 RVA: 0x00DD8BFC File Offset: 0x00DD6DFC
		private void RefreshLevelText()
		{
			if (this.HeadStateData == null)
			{
				return;
			}
			int level = this.GetLevel();
			UUIText text = base.GetText(3);
			string threadColor = BattleUiConfig.Instance.GetThreadColor(level, this.HeadStateData.Camp);
			text.SetColor(FColor.FromHex(threadColor));
			LguiUtil.Instance.SetLocalText(text, "LevelShow", new <>z__ReadOnlySingleElementList<object>(level));
		}

		// Token: 0x0603184F RID: 202831 RVA: 0x00DD8C5F File Offset: 0x00DD6E5F
		protected override void RefreshOnCampChanged()
		{
			this.RefreshLevelText();
			this.RefreshHpColor();
		}

		// Token: 0x06031850 RID: 202832 RVA: 0x00DD8C6D File Offset: 0x00DD6E6D
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(12);
			this.InitTweenAnim(13);
		}

		// Token: 0x06031851 RID: 202833 RVA: 0x00DD8C80 File Offset: 0x00DD6E80
		private void InitTweenAnim(int componentType)
		{
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(tarray.Count);
			foreach (UActorComponent uactorComponent in tarray)
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x06031852 RID: 202834 RVA: 0x00DD8D08 File Offset: 0x00DD6F08
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x0401A36C RID: 107372
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401A36D RID: 107373
		private float HpParentWidth;

		// Token: 0x0401A36E RID: 107374
		[Nullable(2)]
		private UUIItem WeaknessContainer;

		// Token: 0x0401A36F RID: 107375
		[Nullable(2)]
		private HeadStateWeaknessItem WeaknessItem;

		// Token: 0x0401A370 RID: 107376
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200A9E8 RID: 43496
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x040347F6 RID: 215030
			NormalHpBarSprite,
			// Token: 0x040347F7 RID: 215031
			BarBufferSprite,
			// Token: 0x040347F8 RID: 215032
			HpLight,
			// Token: 0x040347F9 RID: 215033
			LevelText,
			// Token: 0x040347FA RID: 215034
			DetailItem,
			// Token: 0x040347FB RID: 215035
			BuffHorizontalItem,
			// Token: 0x040347FC RID: 215036
			ShieldBarSprite,
			// Token: 0x040347FD RID: 215037
			ExtraItem,
			// Token: 0x040347FE RID: 215038
			WeaknessContainer,
			// Token: 0x040347FF RID: 215039
			HpWeaknessNode,
			// Token: 0x04034800 RID: 215040
			HpWeaknessSprite1,
			// Token: 0x04034801 RID: 215041
			HpWeaknessEffect,
			// Token: 0x04034802 RID: 215042
			AniHpWeaknessFull,
			// Token: 0x04034803 RID: 215043
			AniHpWeaknessBreak
		}
	}
}
