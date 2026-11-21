using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB8 RID: 19896
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarDaniya : SpecialEnergyBarBase
	{
		// Token: 0x06032027 RID: 204839 RVA: 0x00DFFA44 File Offset: 0x00DFDC44
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

		// Token: 0x06032028 RID: 204840 RVA: 0x00DFFAC8 File Offset: 0x00DFDCC8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarDaniya.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarDaniya.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032029 RID: 204841 RVA: 0x00DFFB0C File Offset: 0x00DFDD0C
		protected UniTask InitBarItem1()
		{
			SpecialEnergyBarDaniya.<InitBarItem1>d__20 <InitBarItem1>d__;
			<InitBarItem1>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem1>d__.<>4__this = this;
			<InitBarItem1>d__.<>1__state = -1;
			<InitBarItem1>d__.<>t__builder.Start<SpecialEnergyBarDaniya.<InitBarItem1>d__20>(ref <InitBarItem1>d__);
			return <InitBarItem1>d__.<>t__builder.Task;
		}

		// Token: 0x0603202A RID: 204842 RVA: 0x00DFFB50 File Offset: 0x00DFDD50
		protected UniTask InitBarItem2()
		{
			SpecialEnergyBarDaniya.<InitBarItem2>d__21 <InitBarItem2>d__;
			<InitBarItem2>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem2>d__.<>4__this = this;
			<InitBarItem2>d__.<>1__state = -1;
			<InitBarItem2>d__.<>t__builder.Start<SpecialEnergyBarDaniya.<InitBarItem2>d__21>(ref <InitBarItem2>d__);
			return <InitBarItem2>d__.<>t__builder.Task;
		}

		// Token: 0x0603202B RID: 204843 RVA: 0x00DFFB94 File Offset: 0x00DFDD94
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

		// Token: 0x0603202C RID: 204844 RVA: 0x00DFFBF4 File Offset: 0x00DFDDF4
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

		// Token: 0x0603202D RID: 204845 RVA: 0x00DFFCA6 File Offset: 0x00DFDEA6
		protected override void ClearAllTweenAnim()
		{
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(true);
			}
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603202E RID: 204846 RVA: 0x00DFFCC0 File Offset: 0x00DFDEC0
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

		// Token: 0x0603202F RID: 204847 RVA: 0x00DFFDF4 File Offset: 0x00DFDFF4
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

		// Token: 0x06032030 RID: 204848 RVA: 0x00DFFF3C File Offset: 0x00DFE13C
		private void OnStyleChanged(int tagId, bool tagExist)
		{
			this.RefreshState(false);
		}

		// Token: 0x06032031 RID: 204849 RVA: 0x00DFFF48 File Offset: 0x00DFE148
		private void OnPlayAnim(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				SpecialEnergyBarDaniya.EChildType componentType = (tagId == GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.UI标识.能量条一转二"]) ? SpecialEnergyBarDaniya.EChildType.AniToB : SpecialEnergyBarDaniya.EChildType.AniToA;
				base.PlayTweenAnim((int)componentType);
			}
		}

		// Token: 0x06032032 RID: 204850 RVA: 0x00DFFF78 File Offset: 0x00DFE178
		private void OnStarChanged(EAttributeType attrId, float newValue, float oldValue)
		{
			this.RefreshStarItems(newValue);
		}

		// Token: 0x06032033 RID: 204851 RVA: 0x00DFFF81 File Offset: 0x00DFE181
		private void OnUpdateBuffId(int tagId, bool tagExist)
		{
			this.UpdateBuffId();
		}

		// Token: 0x06032034 RID: 204852 RVA: 0x00DFFF89 File Offset: 0x00DFE189
		private void OnR2Changed(EAttributeType attrId, float newValue, float oldValue)
		{
			this.RefreshR2(newValue);
		}

		// Token: 0x06032035 RID: 204853 RVA: 0x00DFFF92 File Offset: 0x00DFE192
		private void OnStarStateChanged(int tagId, bool tagExist)
		{
			this.RefreshStarState(false);
		}

		// Token: 0x06032036 RID: 204854 RVA: 0x00DFFF9C File Offset: 0x00DFE19C
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

		// Token: 0x06032037 RID: 204855 RVA: 0x00DFFFF8 File Offset: 0x00DFE1F8
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

		// Token: 0x06032038 RID: 204856 RVA: 0x00E00048 File Offset: 0x00DFE248
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

		// Token: 0x06032039 RID: 204857 RVA: 0x00E000B6 File Offset: 0x00DFE2B6
		private void RefreshState(bool isStart = false)
		{
			if (this.TagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1DaniyaMd10011.形态标识.白形态"]))
			{
				this.SetState(SpecialEnergyBarDaniya.EState.StateA, isStart);
				return;
			}
			this.SetState(SpecialEnergyBarDaniya.EState.StateB, isStart);
		}

		// Token: 0x0603203A RID: 204858 RVA: 0x00E000E8 File Offset: 0x00DFE2E8
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

		// Token: 0x0603203B RID: 204859 RVA: 0x00E001E0 File Offset: 0x00DFE3E0
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

		// Token: 0x0603203C RID: 204860 RVA: 0x00E0027C File Offset: 0x00DFE47C
		private void OnStarBuffAdd(long buffId, int handle)
		{
			this.RefreshStarState(false);
		}

		// Token: 0x0603203D RID: 204861 RVA: 0x00E00288 File Offset: 0x00DFE488
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

		// Token: 0x0603203E RID: 204862 RVA: 0x00E003B8 File Offset: 0x00DFE5B8
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

		// Token: 0x0603203F RID: 204863 RVA: 0x00E003EC File Offset: 0x00DFE5EC
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

		// Token: 0x06032041 RID: 204865 RVA: 0x00E0048C File Offset: 0x00DFE68C
		[NullableContext(1)]
		[CompilerGenerated]
		internal static void <UpdateBuffId>g__updateBg|27_0(List<UUIItem> items, int num)
		{
			for (int i = 0; i < items.Count; i++)
			{
				items[i].SetUIActive(i < num);
			}
		}

		// Token: 0x0401A796 RID: 108438
		private const int CONFIG_INFO_B = 121102;

		// Token: 0x0401A797 RID: 108439
		private const long PCT_STAR_BAR_BUFFID1 = 1211300001L;

		// Token: 0x0401A798 RID: 108440
		private const long PCT_STAR_BAR_BUFFID2 = 1211300002L;

		// Token: 0x0401A799 RID: 108441
		private const EAttributeType ENERGY_STAR = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A79A RID: 108442
		private const EAttributeType ENERGY_R2 = EAttributeType.SpecialEnergy3;

		// Token: 0x0401A79B RID: 108443
		private const EAttributeType ENERGY_R2_MAX = EAttributeType.SpecialEnergy3Max;

		// Token: 0x0401A79C RID: 108444
		private SpecialEnergyBarDaniyaSlot BarSlotA;

		// Token: 0x0401A79D RID: 108445
		private SpecialEnergyBarDaniyaSlot BarSlotB;

		// Token: 0x0401A79E RID: 108446
		private SpecialEnergyBarDaniya.EState CurState;

		// Token: 0x0401A79F RID: 108447
		[Nullable(1)]
		private readonly List<UUIItem> StarItemA = new List<UUIItem>();

		// Token: 0x0401A7A0 RID: 108448
		[Nullable(1)]
		private readonly List<UUIItem> StarItemB = new List<UUIItem>();

		// Token: 0x0401A7A1 RID: 108449
		[Nullable(1)]
		private readonly List<UUIItem> StarBgItems = new List<UUIItem>();

		// Token: 0x0401A7A2 RID: 108450
		private UUISprite BarMidB;

		// Token: 0x0401A7A3 RID: 108451
		private UUISprite CurBarSprite;

		// Token: 0x0401A7A4 RID: 108452
		private UUIItem CurBarTips;

		// Token: 0x0401A7A5 RID: 108453
		private float BarTipsWidth = 1f;

		// Token: 0x0401A7A6 RID: 108454
		private long CurBuffId;

		// Token: 0x0401A7A7 RID: 108455
		private float LastR2Percent;

		// Token: 0x0401A7A8 RID: 108456
		private float LastPercentA;

		// Token: 0x0401A7A9 RID: 108457
		private bool StarValid;

		// Token: 0x0401A7AA RID: 108458
		private ActiveBuffInternal StarBuff;

		// Token: 0x0401A7AB RID: 108459
		private bool StarFlag;

		// Token: 0x0200AAF1 RID: 43761
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034D49 RID: 216393
			SlotA,
			// Token: 0x04034D4A RID: 216394
			BarA,
			// Token: 0x04034D4B RID: 216395
			PnlStarA,
			// Token: 0x04034D4C RID: 216396
			StarA,
			// Token: 0x04034D4D RID: 216397
			SlotB,
			// Token: 0x04034D4E RID: 216398
			BarB,
			// Token: 0x04034D4F RID: 216399
			BarMidB,
			// Token: 0x04034D50 RID: 216400
			PnlStarB,
			// Token: 0x04034D51 RID: 216401
			StarB,
			// Token: 0x04034D52 RID: 216402
			AniToAFull,
			// Token: 0x04034D53 RID: 216403
			AniToB,
			// Token: 0x04034D54 RID: 216404
			AniToBFull,
			// Token: 0x04034D55 RID: 216405
			AniToA,
			// Token: 0x04034D56 RID: 216406
			PnlWidthA,
			// Token: 0x04034D57 RID: 216407
			PnlNiaA,
			// Token: 0x04034D58 RID: 216408
			PnlWidthB,
			// Token: 0x04034D59 RID: 216409
			PnlNiaB,
			// Token: 0x04034D5A RID: 216410
			StarBgA1,
			// Token: 0x04034D5B RID: 216411
			StarBgA2,
			// Token: 0x04034D5C RID: 216412
			StarBgB1,
			// Token: 0x04034D5D RID: 216413
			StarBgB2,
			// Token: 0x04034D5E RID: 216414
			MaxCount
		}

		// Token: 0x0200AAF2 RID: 43762
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04034D60 RID: 216416
			StateA,
			// Token: 0x04034D61 RID: 216417
			StateB
		}
	}
}
