using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD4 RID: 24020
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarDaniya : SpecialEnergyBarBase
	{
		// Token: 0x0603D0B0 RID: 250032 RVA: 0x00EAEB50 File Offset: 0x00EACD50
		protected override void OnRegisterComponent()
		{
			Dictionary<int, Type> dictionary = new Dictionary<int, Type>();
			dictionary[1] = typeof(UUISprite);
			dictionary[5] = typeof(UUISprite);
			dictionary[6] = typeof(UUISprite);
			Dictionary<int, Type> dictionary2 = dictionary;
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>(21);
			for (int i = 0; i < 21; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, dictionary2.GetValueOrDefault(i, typeof(UUIItem))));
			}
		}

		// Token: 0x0603D0B1 RID: 250033 RVA: 0x00EAEBD4 File Offset: 0x00EACDD4
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarDaniya.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarDaniya.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0B2 RID: 250034 RVA: 0x00EAEC18 File Offset: 0x00EACE18
		protected UniTask InitBarItem1()
		{
			SpecialEnergyBarDaniya.<InitBarItem1>d__20 <InitBarItem1>d__;
			<InitBarItem1>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem1>d__.<>4__this = this;
			<InitBarItem1>d__.<>1__state = -1;
			<InitBarItem1>d__.<>t__builder.Start<SpecialEnergyBarDaniya.<InitBarItem1>d__20>(ref <InitBarItem1>d__);
			return <InitBarItem1>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0B3 RID: 250035 RVA: 0x00EAEC5C File Offset: 0x00EACE5C
		protected UniTask InitBarItem2()
		{
			SpecialEnergyBarDaniya.<InitBarItem2>d__21 <InitBarItem2>d__;
			<InitBarItem2>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem2>d__.<>4__this = this;
			<InitBarItem2>d__.<>1__state = -1;
			<InitBarItem2>d__.<>t__builder.Start<SpecialEnergyBarDaniya.<InitBarItem2>d__21>(ref <InitBarItem2>d__);
			return <InitBarItem2>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0B4 RID: 250036 RVA: 0x00EAECA0 File Offset: 0x00EACEA0
		[NullableContext(1)]
		private void InitStarItems(List<UUIItem> arr, SpecialEnergyBarDaniya.EChildType org, SpecialEnergyBarDaniya.EChildType perent)
		{
			UUIItem item = base.GetItem((int)org);
			UUIItem item2 = base.GetItem((int)perent);
			arr.Add(item);
			for (int i = 2; i <= 5; i++)
			{
				UUIItem item3 = LguiUtil.Instance.DuplicateActor(item.GetOwner(), item2).GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
				arr.Add(item3);
			}
		}

		// Token: 0x0603D0B5 RID: 250037 RVA: 0x00EAED00 File Offset: 0x00EACF00
		protected override void OnStart()
		{
			this.InitStarItems(this.StarItemA, SpecialEnergyBarDaniya.EChildType.StarA, SpecialEnergyBarDaniya.EChildType.PnlStarA);
			this.InitStarItems(this.StarItemB, SpecialEnergyBarDaniya.EChildType.StarB, SpecialEnergyBarDaniya.EChildType.PnlStarB);
			for (int i = 17; i <= 20; i++)
			{
				this.StarBgItems.Add(base.GetItem(i));
			}
			for (int j = 9; j <= 12; j++)
			{
				base.InitTweenAnim(j);
			}
			this.BarMidB = base.GetSprite(6);
			this.RefreshState(true);
			if (!this.StarValid || !this.StarFlag)
			{
				this.CurBarSprite.SetFillAmount(0f);
				this.CurBarTips.SetUIActive(false);
			}
			base.PlayTweenAnim((this.CurState == SpecialEnergyBarDaniya.EState.StateA) ? 12 : 10);
		}

		// Token: 0x0603D0B6 RID: 250038 RVA: 0x00EAEDB2 File Offset: 0x00EACFB2
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D0B7 RID: 250039 RVA: 0x00EAEDCC File Offset: 0x00EACFCC
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.白形态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStyleChanged));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.黑形态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStyleChanged));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.UI标识.能量条一转二"], new BaseTagComponent.TTagSwitchedCallback(this.OnPlayAnim));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.UI标识.能量条二转一"], new BaseTagComponent.TTagSwitchedCallback(this.OnPlayAnim));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.共鸣链.3共"], new BaseTagComponent.TTagSwitchedCallback(this.OnUpdateBuffId));
			this.UpdateBuffId();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.buff标识.无穷集"], new BaseTagComponent.TTagSwitchedCallback(this.OnStarStateChanged));
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.buff标识.容器"], new BaseTagComponent.TTagSwitchedCallback(this.OnStarStateChanged));
			this.AttributeComponent.AddListener(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnStarChanged), null);
			this.AttributeComponent.AddListener(EAttributeType.SpecialEnergy3, new Action<EAttributeType, float, float>(this.OnR2Changed), null);
		}

		// Token: 0x0603D0B8 RID: 250040 RVA: 0x00EAEF00 File Offset: 0x00EAD100
		private void UpdateBuffId()
		{
			long curBuffId = this.CurBuffId;
			this.CurBuffId = (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.共鸣链.3共"]) ? 1211300002L : 1211300001L);
			if (curBuffId != this.CurBuffId)
			{
				bool flag = this.CurBuffId == 1211300002L;
				SpecialEnergyBarDaniya.<UpdateBuffId>g__updateBg|27_0(this.StarItemA, flag ? 5 : 3);
				SpecialEnergyBarDaniya.<UpdateBuffId>g__updateBg|27_0(this.StarItemB, flag ? 5 : 3);
				foreach (UUIItem uuiitem in this.StarBgItems)
				{
					uuiitem.SetUIActive(flag);
				}
				this.RefreshStarItems(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2));
			}
			BattleUiRoleData roleData = this.RoleData;
			WorldEntity worldEntity;
			if (roleData == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 != null)
			{
				if (curBuffId != 0L)
				{
					AbilityEvent.Instance.Remove(worldEntity2, EAbilityEventName.OnBuffAdd, this.CurBuffId, new Action<long, int>(this.OnStarBuffAdd));
				}
				AbilityEvent.Instance.Add(worldEntity2, EAbilityEventName.OnBuffAdd, this.CurBuffId, new Action<long, int>(this.OnStarBuffAdd));
			}
			this.StarBuff = null;
			this.RefreshStarState(false);
		}

		// Token: 0x0603D0B9 RID: 250041 RVA: 0x00EAF048 File Offset: 0x00EAD248
		private void OnStyleChanged(int tagId, bool tagExist)
		{
			this.RefreshState(false);
		}

		// Token: 0x0603D0BA RID: 250042 RVA: 0x00EAF054 File Offset: 0x00EAD254
		private void OnPlayAnim(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				SpecialEnergyBarDaniya.EChildType componentType = (tagId == GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.UI标识.能量条一转二"]) ? SpecialEnergyBarDaniya.EChildType.AniToB : SpecialEnergyBarDaniya.EChildType.AniToA;
				base.PlayTweenAnim((int)componentType);
			}
		}

		// Token: 0x0603D0BB RID: 250043 RVA: 0x00EAF084 File Offset: 0x00EAD284
		private void OnStarChanged(EAttributeType attrId, float newValue, float oldValue)
		{
			this.RefreshStarItems(newValue);
		}

		// Token: 0x0603D0BC RID: 250044 RVA: 0x00EAF08D File Offset: 0x00EAD28D
		private void OnUpdateBuffId(int tagId, bool tagExist)
		{
			this.UpdateBuffId();
		}

		// Token: 0x0603D0BD RID: 250045 RVA: 0x00EAF095 File Offset: 0x00EAD295
		private void OnR2Changed(EAttributeType attrId, float newValue, float oldValue)
		{
			this.RefreshR2(newValue);
		}

		// Token: 0x0603D0BE RID: 250046 RVA: 0x00EAF09E File Offset: 0x00EAD29E
		private void OnStarStateChanged(int tagId, bool tagExist)
		{
			this.RefreshStarState(false);
		}

		// Token: 0x0603D0BF RID: 250047 RVA: 0x00EAF0A8 File Offset: 0x00EAD2A8
		private void RefreshStarItems(float count)
		{
			List<UUIItem> list = (this.CurState == SpecialEnergyBarDaniya.EState.StateA) ? this.StarItemA : this.StarItemB;
			for (int i = 0; i < list.Count; i++)
			{
				UUIItem uuiitem = list[i];
				if ((float)i < count)
				{
					if (!uuiitem.IsUIActiveSelf())
					{
						uuiitem.SetUIActive(true);
					}
				}
				else
				{
					uuiitem.SetUIActive(false);
				}
			}
		}

		// Token: 0x0603D0C0 RID: 250048 RVA: 0x00EAF104 File Offset: 0x00EAD304
		private void RefreshR2(float cur)
		{
			float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy3Max);
			float num = cur / currentValue;
			this.BarMidB.SetFillAmount(num);
			if (num >= 1f && this.LastR2Percent < 1f)
			{
				base.PlayTweenAnim(11);
			}
			this.LastR2Percent = num;
		}

		// Token: 0x0603D0C1 RID: 250049 RVA: 0x00EAF154 File Offset: 0x00EAD354
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			if (this.CurState == SpecialEnergyBarDaniya.EState.StateA)
			{
				if (curPercent >= 1f && this.LastPercentA < 1f)
				{
					base.PlayTweenAnim(9);
				}
				this.BarSlotA.RefreshSlotKeyEnable(curPercent > 0f, false);
				this.LastPercentA = curPercent;
				return;
			}
			this.BarSlotB.RefreshSlotKeyEnable(curPercent > 0f, false);
		}

		// Token: 0x0603D0C2 RID: 250050 RVA: 0x00EAF1C2 File Offset: 0x00EAD3C2
		private void RefreshState(bool isStart = false)
		{
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.白形态"]))
			{
				this.SetState(SpecialEnergyBarDaniya.EState.StateA, isStart);
				return;
			}
			this.SetState(SpecialEnergyBarDaniya.EState.StateB, isStart);
		}

		// Token: 0x0603D0C3 RID: 250051 RVA: 0x00EAF1F4 File Offset: 0x00EAD3F4
		private void SetState(SpecialEnergyBarDaniya.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			if (this.CurState != state)
			{
				BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
				if (tweenAnimPlayer != null)
				{
					tweenAnimPlayer.StopAll();
				}
				base.PlayTweenAnim((state == SpecialEnergyBarDaniya.EState.StateA) ? 12 : 10);
			}
			this.CurState = state;
			this.CurBarSprite = base.GetSprite((state == SpecialEnergyBarDaniya.EState.StateA) ? 1 : 5);
			this.CurBarTips = base.GetItem((state == SpecialEnergyBarDaniya.EState.StateA) ? 14 : 16);
			UUIItem item = base.GetItem((state == SpecialEnergyBarDaniya.EState.StateA) ? 13 : 15);
			this.BarTipsWidth = item.GetParentAsUIItem().Width;
			this.RefreshStarState(false);
			this.RefreshStarItems(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2));
			float curPercent = this.PercentMachine.GetCurPercent();
			if (state == SpecialEnergyBarDaniya.EState.StateA)
			{
				this.BarSlotA.RefreshSlotKeyEnable(curPercent > 0f, true);
				return;
			}
			this.BarSlotB.RefreshSlotKeyEnable(curPercent > 0f, true);
			this.RefreshR2(this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy3));
		}

		// Token: 0x0603D0C4 RID: 250052 RVA: 0x00EAF2EC File Offset: 0x00EAD4EC
		private void RefreshStarState(bool isStart = false)
		{
			this.StarValid = (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.buff标识.无穷集"]) || this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.buff标识.容器"]));
			if (!this.StarValid)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.StarBuff = ((buffComponent != null) ? buffComponent.GetBuffById(this.CurBuffId) : null);
				if (this.StarBuff != null && this.StarBuff.IsValid())
				{
					this.StarValid = true;
				}
			}
			if (this.StarValid)
			{
				this.TickStarProgress();
			}
		}

		// Token: 0x0603D0C5 RID: 250053 RVA: 0x00EAF388 File Offset: 0x00EAD588
		private void OnStarBuffAdd(long buffId, int handle)
		{
			this.RefreshStarState(false);
		}

		// Token: 0x0603D0C6 RID: 250054 RVA: 0x00EAF394 File Offset: 0x00EAD594
		private void TickStarProgress()
		{
			if (!this.StarValid)
			{
				return;
			}
			if (this.StarBuff == null || !this.StarBuff.IsValid())
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.StarBuff = ((buffComponent != null) ? buffComponent.GetBuffById(this.CurBuffId) : null);
			}
			if (this.StarBuff != null && this.StarBuff.IsActive())
			{
				float valueOrDefault = this.StarBuff.GetRemainPeriod().GetValueOrDefault();
				float num = 1f - ((valueOrDefault < 0f) ? 0f : ((float)MathUtils.Instance.SafeDivide((double)valueOrDefault, (double)this.StarBuff.Period)));
				this.CurBarSprite.SetFillAmount(num);
				if (this.CurBarTips.IsUIActiveSelf())
				{
					this.CurBarTips.SetAnchorOffsetX(this.BarTipsWidth * num);
					if (num <= 0f)
					{
						this.CurBarTips.SetUIActive(false);
					}
				}
				else if (num > 0f)
				{
					this.CurBarTips.SetUIActive(true);
				}
				this.StarFlag = true;
				return;
			}
			if (this.StarFlag)
			{
				this.StarFlag = false;
				this.CurBarSprite.SetFillAmount(0f);
				this.CurBarTips.SetUIActive(false);
			}
		}

		// Token: 0x0603D0C7 RID: 250055 RVA: 0x00EAF4C4 File Offset: 0x00EAD6C4
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarDaniyaSlot barSlotA = this.BarSlotA;
			if (barSlotA != null)
			{
				barSlotA.Tick(delta);
			}
			SpecialEnergyBarDaniyaSlot barSlotB = this.BarSlotB;
			if (barSlotB != null)
			{
				barSlotB.Tick(delta);
			}
			this.TickStarProgress();
		}

		// Token: 0x0603D0C8 RID: 250056 RVA: 0x00EAF4F8 File Offset: 0x00EAD6F8
		protected override void OnBeforeDestroy()
		{
			this.StarItemA.Clear();
			this.StarItemB.Clear();
			BattleUiRoleData roleData = this.RoleData;
			WorldEntity worldEntity;
			if (roleData == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				worldEntity = ((entityHandle != null) ? entityHandle.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 != null)
			{
				AbilityEvent.Instance.Remove(worldEntity2, EAbilityEventName.OnBuffAdd, this.CurBuffId, new Action<long, int>(this.OnStarBuffAdd));
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D0CA RID: 250058 RVA: 0x00EAF598 File Offset: 0x00EAD798
		[NullableContext(1)]
		[CompilerGenerated]
		internal static void <UpdateBuffId>g__updateBg|27_0(List<UUIItem> items, int num)
		{
			for (int i = 0; i < items.Count; i++)
			{
				items[i].SetUIActive(i < num);
			}
		}

		// Token: 0x0401FCD9 RID: 130265
		private const int CONFIG_INFO_B = 121102;

		// Token: 0x0401FCDA RID: 130266
		private const long PCT_STAR_BAR_BUFFID1 = 1211300001L;

		// Token: 0x0401FCDB RID: 130267
		private const long PCT_STAR_BAR_BUFFID2 = 1211300002L;

		// Token: 0x0401FCDC RID: 130268
		private const EAttributeType ENERGY_STAR = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FCDD RID: 130269
		private const EAttributeType ENERGY_R2 = EAttributeType.SpecialEnergy3;

		// Token: 0x0401FCDE RID: 130270
		private const EAttributeType ENERGY_R2_MAX = EAttributeType.SpecialEnergy3Max;

		// Token: 0x0401FCDF RID: 130271
		private SpecialEnergyBarDaniyaSlot BarSlotA;

		// Token: 0x0401FCE0 RID: 130272
		private SpecialEnergyBarDaniyaSlot BarSlotB;

		// Token: 0x0401FCE1 RID: 130273
		private SpecialEnergyBarDaniya.EState CurState;

		// Token: 0x0401FCE2 RID: 130274
		[Nullable(1)]
		private readonly List<UUIItem> StarItemA = new List<UUIItem>();

		// Token: 0x0401FCE3 RID: 130275
		[Nullable(1)]
		private readonly List<UUIItem> StarItemB = new List<UUIItem>();

		// Token: 0x0401FCE4 RID: 130276
		[Nullable(1)]
		private readonly List<UUIItem> StarBgItems = new List<UUIItem>();

		// Token: 0x0401FCE5 RID: 130277
		private UUISprite BarMidB;

		// Token: 0x0401FCE6 RID: 130278
		private UUISprite CurBarSprite;

		// Token: 0x0401FCE7 RID: 130279
		private UUIItem CurBarTips;

		// Token: 0x0401FCE8 RID: 130280
		private float BarTipsWidth = 1f;

		// Token: 0x0401FCE9 RID: 130281
		private long CurBuffId;

		// Token: 0x0401FCEA RID: 130282
		private float LastR2Percent;

		// Token: 0x0401FCEB RID: 130283
		private float LastPercentA;

		// Token: 0x0401FCEC RID: 130284
		private bool StarValid;

		// Token: 0x0401FCED RID: 130285
		private ActiveBuffInternal StarBuff;

		// Token: 0x0401FCEE RID: 130286
		private bool StarFlag;

		// Token: 0x0200C0E8 RID: 49384
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A377 RID: 238455
			SlotA,
			// Token: 0x0403A378 RID: 238456
			BarA,
			// Token: 0x0403A379 RID: 238457
			PnlStarA,
			// Token: 0x0403A37A RID: 238458
			StarA,
			// Token: 0x0403A37B RID: 238459
			SlotB,
			// Token: 0x0403A37C RID: 238460
			BarB,
			// Token: 0x0403A37D RID: 238461
			BarMidB,
			// Token: 0x0403A37E RID: 238462
			PnlStarB,
			// Token: 0x0403A37F RID: 238463
			StarB,
			// Token: 0x0403A380 RID: 238464
			AniToAFull,
			// Token: 0x0403A381 RID: 238465
			AniToB,
			// Token: 0x0403A382 RID: 238466
			AniToBFull,
			// Token: 0x0403A383 RID: 238467
			AniToA,
			// Token: 0x0403A384 RID: 238468
			PnlWidthA,
			// Token: 0x0403A385 RID: 238469
			PnlNiaA,
			// Token: 0x0403A386 RID: 238470
			PnlWidthB,
			// Token: 0x0403A387 RID: 238471
			PnlNiaB,
			// Token: 0x0403A388 RID: 238472
			StarBgA1,
			// Token: 0x0403A389 RID: 238473
			StarBgA2,
			// Token: 0x0403A38A RID: 238474
			StarBgB1,
			// Token: 0x0403A38B RID: 238475
			StarBgB2,
			// Token: 0x0403A38C RID: 238476
			MaxCount
		}

		// Token: 0x0200C0E9 RID: 49385
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A38E RID: 238478
			StateA,
			// Token: 0x0403A38F RID: 238479
			StateB
		}
	}
}
