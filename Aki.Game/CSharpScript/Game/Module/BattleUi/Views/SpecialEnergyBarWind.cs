using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DEC RID: 19948
	public class SpecialEnergyBarWind : SpecialEnergyBarBase
	{
		// Token: 0x060322E1 RID: 205537 RVA: 0x00E0FED8 File Offset: 0x00E0E0D8
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

		// Token: 0x060322E2 RID: 205538 RVA: 0x00E0FFC8 File Offset: 0x00E0E1C8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarWind.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarWind.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060322E3 RID: 205539 RVA: 0x00E1000C File Offset: 0x00E0E20C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarWind.<InitBarItem>d__7 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarWind.<InitBarItem>d__7>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060322E4 RID: 205540 RVA: 0x00E10050 File Offset: 0x00E0E250
		protected override void OnStart()
		{
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			this.RefreshBarPercent(true);
			BaseTagComponent tagComponent = this.TagComponent;
			bool isInCd = tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1WindNanzhuMd10011.标记用.技能CD中"]);
			this.RefreshCdState(isInCd, true);
		}

		// Token: 0x060322E5 RID: 205541 RVA: 0x00E1009C File Offset: 0x00E0E29C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1WindNanzhuMd10011.标记用.技能CD中"], new BaseTagComponent.TTagSwitchedCallback(this.OnCdTagChange));
		}

		// Token: 0x060322E6 RID: 205542 RVA: 0x00E100C5 File Offset: 0x00E0E2C5
		private void OnCdTagChange(int tagId, bool tagExist)
		{
			this.RefreshCdState(tagExist, false);
		}

		// Token: 0x060322E7 RID: 205543 RVA: 0x00E100CF File Offset: 0x00E0E2CF
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x060322E8 RID: 205544 RVA: 0x00E100D8 File Offset: 0x00E0E2D8
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x060322E9 RID: 205545 RVA: 0x00E100E4 File Offset: 0x00E0E2E4
		private void RefreshBarPercent(bool isStart = false)
		{
			bool keyEnable = this.GetKeyEnable();
			this.RefreshDrawState(keyEnable, isStart);
		}

		// Token: 0x060322EA RID: 205546 RVA: 0x00E10100 File Offset: 0x00E0E300
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

		// Token: 0x060322EB RID: 205547 RVA: 0x00E10195 File Offset: 0x00E0E395
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

		// Token: 0x060322EC RID: 205548 RVA: 0x00E101C0 File Offset: 0x00E0E3C0
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

		// Token: 0x0401A964 RID: 108900
		private const float EFFECT_BASE_PERCENT = 0.4390244f;

		// Token: 0x0401A965 RID: 108901
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401A966 RID: 108902
		private bool IsDrawing;

		// Token: 0x0401A967 RID: 108903
		private bool IsInCd;

		// Token: 0x0200AB78 RID: 43896
		private enum EChildType
		{
			// Token: 0x040350D0 RID: 217296
			SlotBarItem,
			// Token: 0x040350D1 RID: 217297
			StateItem1,
			// Token: 0x040350D2 RID: 217298
			StateItem2,
			// Token: 0x040350D3 RID: 217299
			CdNiagaraItem,
			// Token: 0x040350D4 RID: 217300
			AniIn,
			// Token: 0x040350D5 RID: 217301
			AniOut
		}
	}
}
