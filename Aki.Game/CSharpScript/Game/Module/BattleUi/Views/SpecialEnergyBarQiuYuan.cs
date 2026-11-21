using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE1 RID: 19937
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarQiuYuan : SpecialEnergyBarBase
	{
		// Token: 0x0603223F RID: 205375 RVA: 0x00E0CB58 File Offset: 0x00E0AD58
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

		// Token: 0x06032240 RID: 205376 RVA: 0x00E0CD31 File Offset: 0x00E0AF31
		protected override void OnInitData()
		{
			base.OnInitData();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarQiuYuan.CountDownTag, new BaseTagComponent.TTagSwitchedCallback(this.OnCountDownTagChanged));
		}

		// Token: 0x06032241 RID: 205377 RVA: 0x00E0CD50 File Offset: 0x00E0AF50
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarQiuYuan.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarQiuYuan.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032242 RID: 205378 RVA: 0x00E0CD94 File Offset: 0x00E0AF94
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarQiuYuan.<InitBarItem>d__12 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarQiuYuan.<InitBarItem>d__12>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032243 RID: 205379 RVA: 0x00E0CDD8 File Offset: 0x00E0AFD8
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

		// Token: 0x06032244 RID: 205380 RVA: 0x00E0CE58 File Offset: 0x00E0B058
		private void OnCountDownTagChanged(int tagId, bool tagExist)
		{
			this.SetCountDownState(tagExist, false);
		}

		// Token: 0x06032245 RID: 205381 RVA: 0x00E0CE62 File Offset: 0x00E0B062
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032246 RID: 205382 RVA: 0x00E0CE6C File Offset: 0x00E0B06C
		protected void RefreshBarPercent(bool isStart = false)
		{
			int tagCount = (int)Math.Floor((double)(this.PercentMachine.GetCurPercent() * 3f));
			this.RefreshStateCount(tagCount, isStart);
		}

		// Token: 0x06032247 RID: 205383 RVA: 0x00E0CE9C File Offset: 0x00E0B09C
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

		// Token: 0x06032248 RID: 205384 RVA: 0x00E0CF1C File Offset: 0x00E0B11C
		private void SetCountDownState(bool state, bool isStart = false)
		{
			if (this.CountDownState == state && !isStart)
			{
				return;
			}
			this.CountDownState = state;
		}

		// Token: 0x06032249 RID: 205385 RVA: 0x00E0CF34 File Offset: 0x00E0B134
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

		// Token: 0x0603224A RID: 205386 RVA: 0x00E0CFC4 File Offset: 0x00E0B1C4
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

		// Token: 0x0603224B RID: 205387 RVA: 0x00E0D050 File Offset: 0x00E0B250
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

		// Token: 0x0401A90B RID: 108811
		[StaticVariableRuleIgnore]
		private static readonly int CountDownTag = GameplayTagDefine.EGameplayTagId["角色.R2T1Qiuyuan01Md10011.特殊机制.心眼展开"];

		// Token: 0x0401A90C RID: 108812
		private int StateCount;

		// Token: 0x0401A90D RID: 108813
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401A90E RID: 108814
		private UUITexture BarTexture;

		// Token: 0x0401A90F RID: 108815
		private float BarPercent;

		// Token: 0x0401A910 RID: 108816
		private IActiveBuff Buff;

		// Token: 0x0401A911 RID: 108817
		private int BuffHandle;

		// Token: 0x0401A912 RID: 108818
		private bool CountDownState;

		// Token: 0x0200AB55 RID: 43861
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035000 RID: 217088
			SlotItem,
			// Token: 0x04035001 RID: 217089
			BarTexture,
			// Token: 0x04035002 RID: 217090
			StateItem1,
			// Token: 0x04035003 RID: 217091
			StateItem2,
			// Token: 0x04035004 RID: 217092
			StateItem3,
			// Token: 0x04035005 RID: 217093
			AniStateIn1,
			// Token: 0x04035006 RID: 217094
			AniStateOut1,
			// Token: 0x04035007 RID: 217095
			AniStateIn2,
			// Token: 0x04035008 RID: 217096
			AniStateOut2,
			// Token: 0x04035009 RID: 217097
			AniStateIn3,
			// Token: 0x0403500A RID: 217098
			AniStateOut3,
			// Token: 0x0403500B RID: 217099
			AniBarIn,
			// Token: 0x0403500C RID: 217100
			AniBarOut
		}
	}
}
