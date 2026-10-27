using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E07 RID: 24071
	public class SpecialEnergyBarWind : SpecialEnergyBarBase
	{
		// Token: 0x0603D352 RID: 250706 RVA: 0x00EBE978 File Offset: 0x00EBCB78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D353 RID: 250707 RVA: 0x00EBEA68 File Offset: 0x00EBCC68
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarWind.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarWind.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D354 RID: 250708 RVA: 0x00EBEAAC File Offset: 0x00EBCCAC
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarWind.<InitBarItem>d__7 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarWind.<InitBarItem>d__7>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D355 RID: 250709 RVA: 0x00EBEAF0 File Offset: 0x00EBCCF0
		protected override void OnStart()
		{
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			this.RefreshBarPercent(true);
			BaseTagComponent tagComponent = this.TagComponent;
			bool isInCd = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1WindNanzhuMd10011.标记用.技能CD中"]);
			this.RefreshCdState(isInCd, true);
		}

		// Token: 0x0603D356 RID: 250710 RVA: 0x00EBEB3C File Offset: 0x00EBCD3C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1WindNanzhuMd10011.标记用.技能CD中"], new BaseTagComponent.TTagSwitchedCallback(this.OnCdTagChange));
		}

		// Token: 0x0603D357 RID: 250711 RVA: 0x00EBEB65 File Offset: 0x00EBCD65
		private void OnCdTagChange(int tagId, bool tagExist)
		{
			this.RefreshCdState(tagExist, false);
		}

		// Token: 0x0603D358 RID: 250712 RVA: 0x00EBEB6F File Offset: 0x00EBCD6F
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D359 RID: 250713 RVA: 0x00EBEB78 File Offset: 0x00EBCD78
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D35A RID: 250714 RVA: 0x00EBEB84 File Offset: 0x00EBCD84
		private void RefreshBarPercent(bool isStart = false)
		{
			bool keyEnable = this.GetKeyEnable();
			this.RefreshDrawState(keyEnable, isStart);
		}

		// Token: 0x0603D35B RID: 250715 RVA: 0x00EBEBA0 File Offset: 0x00EBCDA0
		private void RefreshDrawState(bool isDrawing, bool isStart = false)
		{
			if (this.IsDrawing == isDrawing && !isStart)
			{
				return;
			}
			this.IsDrawing = isDrawing;
			if (isDrawing)
			{
				UUIItem item = base.GetItem(1);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(2);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
			}
			else
			{
				UUIItem item3 = base.GetItem(1);
				if (item3 != null)
				{
					item3.SetUIActive(true);
				}
				UUIItem item4 = base.GetItem(2);
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
			}
			if (!isStart)
			{
				if (isDrawing)
				{
					base.PlayTweenAnim(4);
					base.StopTweenAnim(5);
					return;
				}
				base.StopTweenAnim(4);
				base.PlayTweenAnim(5);
			}
		}

		// Token: 0x0603D35C RID: 250716 RVA: 0x00EBEC35 File Offset: 0x00EBCE35
		private void RefreshCdState(bool isInCd, bool isStart = false)
		{
			if (this.IsInCd == isInCd && !isStart)
			{
				return;
			}
			this.IsInCd = isInCd;
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!isInCd);
		}

		// Token: 0x0603D35D RID: 250717 RVA: 0x00EBEC60 File Offset: 0x00EBCE60
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem == null)
			{
				return;
			}
			barItem.Tick(delta);
		}

		// Token: 0x0401FE9D RID: 130717
		private const float EFFECT_BASE_PERCENT = 0.4390244f;

		// Token: 0x0401FE9E RID: 130718
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401FE9F RID: 130719
		private bool IsDrawing;

		// Token: 0x0401FEA0 RID: 130720
		private bool IsInCd;

		// Token: 0x0200C169 RID: 49513
		private enum EChildType
		{
			// Token: 0x0403A6DE RID: 239326
			SlotBarItem,
			// Token: 0x0403A6DF RID: 239327
			StateItem1,
			// Token: 0x0403A6E0 RID: 239328
			StateItem2,
			// Token: 0x0403A6E1 RID: 239329
			CdNiagaraItem,
			// Token: 0x0403A6E2 RID: 239330
			AniIn,
			// Token: 0x0403A6E3 RID: 239331
			AniOut
		}
	}
}
