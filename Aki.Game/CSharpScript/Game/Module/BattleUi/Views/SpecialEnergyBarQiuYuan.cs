using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DFC RID: 24060
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarQiuYuan : SpecialEnergyBarBase
	{
		// Token: 0x0603D2B0 RID: 250544 RVA: 0x00EBB60C File Offset: 0x00EB980C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D2B1 RID: 250545 RVA: 0x00EBB7E5 File Offset: 0x00EB99E5
		protected override void OnInitData()
		{
			base.OnInitData();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQiuYuan.CountDownTag, new BaseTagComponent.TTagSwitchedCallback(this.OnCountDownTagChanged));
		}

		// Token: 0x0603D2B2 RID: 250546 RVA: 0x00EBB804 File Offset: 0x00EB9A04
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarQiuYuan.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarQiuYuan.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D2B3 RID: 250547 RVA: 0x00EBB848 File Offset: 0x00EB9A48
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarQiuYuan.<InitBarItem>d__12 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarQiuYuan.<InitBarItem>d__12>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D2B4 RID: 250548 RVA: 0x00EBB88C File Offset: 0x00EB9A8C
		protected override void OnStart()
		{
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			this.BarTexture = base.GetTexture(1);
			this.RefreshBarPercent(true);
			this.SetCountDownState(this.TagComponent.HasTag(SpecialEnergyBarQiuYuan.CountDownTag), true);
			this.SetCountDownBarPercent(0f, true);
		}

		// Token: 0x0603D2B5 RID: 250549 RVA: 0x00EBB90C File Offset: 0x00EB9B0C
		private void OnCountDownTagChanged(int tagId, bool tagExist)
		{
			this.SetCountDownState(tagExist, false);
		}

		// Token: 0x0603D2B6 RID: 250550 RVA: 0x00EBB916 File Offset: 0x00EB9B16
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D2B7 RID: 250551 RVA: 0x00EBB920 File Offset: 0x00EB9B20
		protected void RefreshBarPercent(bool isStart = false)
		{
			int tagCount = (int)Math.Floor((double)(this.PercentMachine.GetCurPercent() * 3f));
			this.RefreshStateCount(tagCount, isStart);
		}

		// Token: 0x0603D2B8 RID: 250552 RVA: 0x00EBB950 File Offset: 0x00EB9B50
		private void RefreshStateCount(int tagCount, bool isStart = false)
		{
			if (tagCount == this.StateCount && !isStart)
			{
				return;
			}
			int stateCount = this.StateCount;
			this.StateCount = tagCount;
			if (stateCount > this.StateCount)
			{
				for (int i = this.StateCount; i < stateCount; i++)
				{
					base.StopTweenAnim(5 + i * 2);
					base.PlayTweenAnim(6 + i * 2);
				}
				return;
			}
			for (int j = stateCount; j < this.StateCount; j++)
			{
				base.StopTweenAnim(6 + j * 2);
				base.PlayTweenAnim(5 + j * 2);
			}
		}

		// Token: 0x0603D2B9 RID: 250553 RVA: 0x00EBB9D0 File Offset: 0x00EB9BD0
		private void SetCountDownState(bool state, bool isStart = false)
		{
			if (this.CountDownState == state && !isStart)
			{
				return;
			}
			this.CountDownState = state;
		}

		// Token: 0x0603D2BA RID: 250554 RVA: 0x00EBB9E8 File Offset: 0x00EB9BE8
		private void SetCountDownBarPercent(float percent = 0f, bool isStart = false)
		{
			if (isStart)
			{
				this.BarPercent = percent;
				this.BarTexture.SetFillAmount(percent);
				return;
			}
			if (this.BarPercent == percent)
			{
				return;
			}
			this.BarTexture.SetFillAmount(percent);
			if (percent <= 0f && this.BarPercent > 0f)
			{
				base.StopTweenAnim(11);
				base.PlayTweenAnim(12);
			}
			else if (percent > 0f && this.BarPercent <= 0f)
			{
				base.StopTweenAnim(12);
				base.PlayTweenAnim(11);
			}
			this.BarPercent = percent;
		}

		// Token: 0x0603D2BB RID: 250555 RVA: 0x00EBBA78 File Offset: 0x00EB9C78
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			if (!this.CountDownState)
			{
				this.SetCountDownBarPercent(0f, false);
				return;
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_56;
				}
			}
			this.RefreshBuff();
			IL_56:
			if (this.Buff != null)
			{
				this.SetCountDownBarPercent(this.Buff.GetRemainDuration() / this.Buff.Duration, false);
			}
		}

		// Token: 0x0603D2BC RID: 250556 RVA: 0x00EBBB04 File Offset: 0x00EB9D04
		private void RefreshBuff()
		{
			SpecialEnergyBarInfo config = this.Config;
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				long buffId = config.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.Config.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0401FE44 RID: 130628
		[StaticVariableRuleIgnore]
		private static readonly int CountDownTag = GameplayTagDefine.EGameplayTagId["角色.R2T1Qiuyuan01Md10011.特殊机制.心眼展开"];

		// Token: 0x0401FE45 RID: 130629
		private int StateCount;

		// Token: 0x0401FE46 RID: 130630
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401FE47 RID: 130631
		private UUITexture BarTexture;

		// Token: 0x0401FE48 RID: 130632
		private float BarPercent;

		// Token: 0x0401FE49 RID: 130633
		private IActiveBuff Buff;

		// Token: 0x0401FE4A RID: 130634
		private int BuffHandle;

		// Token: 0x0401FE4B RID: 130635
		private bool CountDownState;

		// Token: 0x0200C146 RID: 49478
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A60E RID: 239118
			SlotItem,
			// Token: 0x0403A60F RID: 239119
			BarTexture,
			// Token: 0x0403A610 RID: 239120
			StateItem1,
			// Token: 0x0403A611 RID: 239121
			StateItem2,
			// Token: 0x0403A612 RID: 239122
			StateItem3,
			// Token: 0x0403A613 RID: 239123
			AniStateIn1,
			// Token: 0x0403A614 RID: 239124
			AniStateOut1,
			// Token: 0x0403A615 RID: 239125
			AniStateIn2,
			// Token: 0x0403A616 RID: 239126
			AniStateOut2,
			// Token: 0x0403A617 RID: 239127
			AniStateIn3,
			// Token: 0x0403A618 RID: 239128
			AniStateOut3,
			// Token: 0x0403A619 RID: 239129
			AniBarIn,
			// Token: 0x0403A61A RID: 239130
			AniBarOut
		}
	}
}
