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
	// Token: 0x02005D40 RID: 23872
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonHeadState : HeadStateViewBase
	{
		// Token: 0x0603C8D5 RID: 248021 RVA: 0x00E87D3C File Offset: 0x00E85F3C
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

		// Token: 0x0603C8D6 RID: 248022 RVA: 0x00E87F38 File Offset: 0x00E86138
		protected override UniTask OnBeforeStartAsync()
		{
			CommonHeadState.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonHeadState.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C8D7 RID: 248023 RVA: 0x00E87F7B File Offset: 0x00E8617B
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

		// Token: 0x0603C8D8 RID: 248024 RVA: 0x00E87FB6 File Offset: 0x00E861B6
		protected override void OnStart()
		{
			this.InitAllTweenAnim();
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
			this.BuffItemContainer.Init(base.GetItem(5), 6, true, false, false, null);
		}

		// Token: 0x0603C8D9 RID: 248025 RVA: 0x00E87FEC File Offset: 0x00E861EC
		protected override void OnBeforeDestroy()
		{
			if (this.WeaknessItem != null)
			{
				this.WeaknessItem.Destroy(null);
				this.WeaknessItem = null;
			}
		}

		// Token: 0x0603C8DA RID: 248026 RVA: 0x00E8800C File Offset: 0x00E8620C
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

		// Token: 0x0603C8DB RID: 248027 RVA: 0x00E88056 File Offset: 0x00E86256
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

		// Token: 0x0603C8DC RID: 248028 RVA: 0x00E8807C File Offset: 0x00E8627C
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

		// Token: 0x0603C8DD RID: 248029 RVA: 0x00E880E1 File Offset: 0x00E862E1
		private void RefreshHpWeaknessPercent()
		{
			if (this.WeaknessItem != null && this.WeaknessItem.IsFullState(true))
			{
				base.GetSprite(10).SetFillAmount(this.CurrentBarPercent);
			}
		}

		// Token: 0x0603C8DE RID: 248030 RVA: 0x00E8810C File Offset: 0x00E8630C
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

		// Token: 0x0603C8DF RID: 248031 RVA: 0x00E88176 File Offset: 0x00E86376
		private void OnWeaknessStateChanged()
		{
			this.RefreshHpWeaknessPercent();
			this.RefreshHpWeaknessState(false);
		}

		// Token: 0x0603C8E0 RID: 248032 RVA: 0x00E88185 File Offset: 0x00E86385
		protected override string GetResourceId()
		{
			return "UiItem_LittleMonsterState_Prefab";
		}

		// Token: 0x0603C8E1 RID: 248033 RVA: 0x00E8818C File Offset: 0x00E8638C
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

		// Token: 0x0603C8E2 RID: 248034 RVA: 0x00E881CA File Offset: 0x00E863CA
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

		// Token: 0x0603C8E3 RID: 248035 RVA: 0x00E88204 File Offset: 0x00E86404
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

		// Token: 0x0603C8E4 RID: 248036 RVA: 0x00E88248 File Offset: 0x00E86448
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

		// Token: 0x0603C8E5 RID: 248037 RVA: 0x00E88280 File Offset: 0x00E86480
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

		// Token: 0x0603C8E6 RID: 248038 RVA: 0x00E882C0 File Offset: 0x00E864C0
		private void RefreshLevelTextVisible()
		{
			bool uiactive = base.IsLevelTextVisible();
			base.GetText(3).SetUIActive(uiactive);
		}

		// Token: 0x0603C8E7 RID: 248039 RVA: 0x00E882E4 File Offset: 0x00E864E4
		private void RefreshBuffVisible()
		{
			bool uiactive = base.IsBuffVisible();
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x0603C8E8 RID: 248040 RVA: 0x00E88305 File Offset: 0x00E86505
		private void TickBuffItem(float delta)
		{
			if (!base.IsBuffVisible())
			{
				return;
			}
			this.BuffItemContainer.Tick(delta);
		}

		// Token: 0x0603C8E9 RID: 248041 RVA: 0x00E8831C File Offset: 0x00E8651C
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

		// Token: 0x0603C8EA RID: 248042 RVA: 0x00E88362 File Offset: 0x00E86562
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603C8EB RID: 248043 RVA: 0x00E8836B File Offset: 0x00E8656B
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603C8EC RID: 248044 RVA: 0x00E88380 File Offset: 0x00E86580
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x0603C8ED RID: 248045 RVA: 0x00E88389 File Offset: 0x00E86589
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x0603C8EE RID: 248046 RVA: 0x00E88398 File Offset: 0x00E86598
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

		// Token: 0x0603C8EF RID: 248047 RVA: 0x00E883FC File Offset: 0x00E865FC
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

		// Token: 0x0603C8F0 RID: 248048 RVA: 0x00E8842F File Offset: 0x00E8662F
		protected override void OnShieldChanged(float shield)
		{
			this.RefreshHpAndShield(false);
		}

		// Token: 0x0603C8F1 RID: 248049 RVA: 0x00E88438 File Offset: 0x00E86638
		protected override void OnChangeTeam()
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603C8F2 RID: 248050 RVA: 0x00E88440 File Offset: 0x00E86640
		protected override void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603C8F3 RID: 248051 RVA: 0x00E88448 File Offset: 0x00E86648
		protected override void OnRoleLevelChange(int configId, int exp, int level)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603C8F4 RID: 248052 RVA: 0x00E88450 File Offset: 0x00E86650
		protected override void OnHealthChanged()
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603C8F5 RID: 248053 RVA: 0x00E8845C File Offset: 0x00E8665C
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

		// Token: 0x0603C8F6 RID: 248054 RVA: 0x00E884BF File Offset: 0x00E866BF
		protected override void RefreshOnCampChanged()
		{
			this.RefreshLevelText();
			this.RefreshHpColor();
		}

		// Token: 0x0603C8F7 RID: 248055 RVA: 0x00E884CD File Offset: 0x00E866CD
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(12);
			this.InitTweenAnim(13);
		}

		// Token: 0x0603C8F8 RID: 248056 RVA: 0x00E884E0 File Offset: 0x00E866E0
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

		// Token: 0x0603C8F9 RID: 248057 RVA: 0x00E88560 File Offset: 0x00E86760
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

		// Token: 0x0401F8B3 RID: 129203
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401F8B4 RID: 129204
		private float HpParentWidth;

		// Token: 0x0401F8B5 RID: 129205
		[Nullable(2)]
		private UUIItem WeaknessContainer;

		// Token: 0x0401F8B6 RID: 129206
		[Nullable(2)]
		private HeadStateWeaknessItem WeaknessItem;

		// Token: 0x0401F8B7 RID: 129207
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200BFE2 RID: 49122
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039E34 RID: 237108
			NormalHpBarSprite,
			// Token: 0x04039E35 RID: 237109
			BarBufferSprite,
			// Token: 0x04039E36 RID: 237110
			HpLight,
			// Token: 0x04039E37 RID: 237111
			LevelText,
			// Token: 0x04039E38 RID: 237112
			DetailItem,
			// Token: 0x04039E39 RID: 237113
			BuffHorizontalItem,
			// Token: 0x04039E3A RID: 237114
			ShieldBarSprite,
			// Token: 0x04039E3B RID: 237115
			ExtraItem,
			// Token: 0x04039E3C RID: 237116
			WeaknessContainer,
			// Token: 0x04039E3D RID: 237117
			HpWeaknessNode,
			// Token: 0x04039E3E RID: 237118
			HpWeaknessSprite1,
			// Token: 0x04039E3F RID: 237119
			HpWeaknessEffect,
			// Token: 0x04039E40 RID: 237120
			AniHpWeaknessFull,
			// Token: 0x04039E41 RID: 237121
			AniHpWeaknessBreak
		}
	}
}
