using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E04 RID: 19972
	public class SpecialEnergyBarMorphCountDown : SpecialEnergyBarBase
	{
		// Token: 0x06032413 RID: 205843 RVA: 0x00E1627C File Offset: 0x00E1447C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032414 RID: 205844 RVA: 0x00E16348 File Offset: 0x00E14548
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMorphCountDown.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMorphCountDown.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032415 RID: 205845 RVA: 0x00E1638C File Offset: 0x00E1458C
		[NullableContext(1)]
		protected UniTask InitPointLeftItem(UUIItem pointItem)
		{
			SpecialEnergyBarMorphCountDown.<InitPointLeftItem>d__12 <InitPointLeftItem>d__;
			<InitPointLeftItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointLeftItem>d__.<>4__this = this;
			<InitPointLeftItem>d__.pointItem = pointItem;
			<InitPointLeftItem>d__.<>1__state = -1;
			<InitPointLeftItem>d__.<>t__builder.Start<SpecialEnergyBarMorphCountDown.<InitPointLeftItem>d__12>(ref <InitPointLeftItem>d__);
			return <InitPointLeftItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032416 RID: 205846 RVA: 0x00E163D8 File Offset: 0x00E145D8
		[NullableContext(1)]
		protected UniTask InitPointRightItem(UUIItem pointItem)
		{
			SpecialEnergyBarMorphCountDown.<InitPointRightItem>d__13 <InitPointRightItem>d__;
			<InitPointRightItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointRightItem>d__.<>4__this = this;
			<InitPointRightItem>d__.pointItem = pointItem;
			<InitPointRightItem>d__.<>1__state = -1;
			<InitPointRightItem>d__.<>t__builder.Start<SpecialEnergyBarMorphCountDown.<InitPointRightItem>d__13>(ref <InitPointRightItem>d__);
			return <InitPointRightItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032417 RID: 205847 RVA: 0x00E16424 File Offset: 0x00E14624
		protected override void OnStart()
		{
			if (this.Config == null)
			{
				return;
			}
			float effectBasePercent = (float)this.PointNum / 41f;
			ValueTuple<float, float> effectBasePercents = this.GetEffectBasePercents(effectBasePercent);
			float item = effectBasePercents.Item1;
			float item2 = effectBasePercents.Item2;
			ValueTuple<int, int> effectPointNums = this.GetEffectPointNums(this.PointNum);
			int item3 = effectPointNums.Item1;
			int item4 = effectPointNums.Item2;
			this.PointLeftItem.SetEffectBasePercents(item, new float?(item2), item3, new int?(item4));
			this.PointRightItem.SetEffectBasePercents(item, new float?(item2), item3, new int?(item4));
			if (!string.IsNullOrEmpty(this.Config.EffectColor))
			{
				FColor fcolor = FColor.FromHex(this.Config.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				this.PointLeftItem.SetFullEffectColor(flinearColor, true);
				this.PointRightItem.SetFullEffectColor(flinearColor, true);
			}
			if (!string.IsNullOrEmpty(this.Config.IconPath))
			{
				UUITexture[] iconTextureList = new UUITexture[]
				{
					base.GetTexture(2)
				};
				this.IconHandle.Init(iconTextureList, base.GetItem(4));
				this.IconHandle.SetIcon(this.Config.IconPath);
			}
			if (this.StartEffectFinishTime == 0.0)
			{
				base.GetUiNiagara(3).SetUIActive(false);
			}
			this.RefreshBarPercent();
		}

		// Token: 0x06032418 RID: 205848 RVA: 0x00E16565 File Offset: 0x00E14765
		protected virtual ValueTuple<float, float> GetEffectBasePercents(float effectBasePercent)
		{
			return new ValueTuple<float, float>(effectBasePercent, effectBasePercent);
		}

		// Token: 0x06032419 RID: 205849 RVA: 0x00E1656E File Offset: 0x00E1476E
		protected virtual ValueTuple<int, int> GetEffectPointNums(int pointNum)
		{
			return new ValueTuple<int, int>(pointNum, pointNum);
		}

		// Token: 0x0603241A RID: 205850 RVA: 0x00E16577 File Offset: 0x00E14777
		protected virtual int GetUseEffectPointOffsetNum(int pointNum)
		{
			return 0;
		}

		// Token: 0x0603241B RID: 205851 RVA: 0x00E1657A File Offset: 0x00E1477A
		public override void OnChangeVisibleByTagChange(bool visible)
		{
			if (visible)
			{
				base.GetUiNiagara(3).SetUIActive(true);
				this.StartEffectFinishTime = 500.0 + Time.Instance.Now;
			}
		}

		// Token: 0x0603241C RID: 205852 RVA: 0x00E165A6 File Offset: 0x00E147A6
		protected override void OnBeforeShow()
		{
			if ((byte)this.Config.PrefabType == 9)
			{
				base.GetUiNiagara(3).SetUIActive(true);
				this.StartEffectFinishTime = 500.0 + Time.Instance.Now;
			}
		}

		// Token: 0x0603241D RID: 205853 RVA: 0x00E165E0 File Offset: 0x00E147E0
		protected void RefreshBarPercent()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			int useEffectPointOffsetNum = this.GetUseEffectPointOffsetNum(this.PointNum);
			this.PointLeftItem.UpdatePercent(curPercent, true, useEffectPointOffsetNum);
			this.PointRightItem.UpdatePercent(curPercent, true, useEffectPointOffsetNum);
			bool isPlay = this.Config.ExtraFloatParams.Count > 0 && curPercent < this.Config.ExtraFloatParams[0];
			this.IconHandle.PlayEndAnim(isPlay);
		}

		// Token: 0x0603241E RID: 205854 RVA: 0x00E16659 File Offset: 0x00E14859
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent();
		}

		// Token: 0x0603241F RID: 205855 RVA: 0x00E16664 File Offset: 0x00E14864
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarPointItem pointLeftItem = this.PointLeftItem;
			if (pointLeftItem != null)
			{
				pointLeftItem.Tick(delta);
			}
			SpecialEnergyBarPointItem pointRightItem = this.PointRightItem;
			if (pointRightItem != null)
			{
				pointRightItem.Tick(delta);
			}
			if (this.StartEffectFinishTime > 0.0 && this.StartEffectFinishTime <= Time.Instance.Now)
			{
				base.GetUiNiagara(3).SetUIActive(false);
				this.StartEffectFinishTime = 0.0;
			}
		}

		// Token: 0x06032420 RID: 205856 RVA: 0x00E166DB File Offset: 0x00E148DB
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.IconHandle.OnBeforeDestroy();
		}

		// Token: 0x0401AA16 RID: 109078
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly int[] PointNumList = new int[]
		{
			19,
			20
		};

		// Token: 0x0401AA17 RID: 109079
		private const int TOTAL_NUM = 41;

		// Token: 0x0401AA18 RID: 109080
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401AA19 RID: 109081
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401AA1A RID: 109082
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointLeftItem;

		// Token: 0x0401AA1B RID: 109083
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointRightItem;

		// Token: 0x0401AA1C RID: 109084
		[Nullable(1)]
		private readonly SpecialEnergyBaIconHandle IconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401AA1D RID: 109085
		private double StartEffectFinishTime;

		// Token: 0x0401AA1E RID: 109086
		private int PointNum;

		// Token: 0x0200ABAA RID: 43946
		private enum EChildType
		{
			// Token: 0x04035202 RID: 217602
			PointLeftItem,
			// Token: 0x04035203 RID: 217603
			PointRightItem,
			// Token: 0x04035204 RID: 217604
			IconTexture,
			// Token: 0x04035205 RID: 217605
			StartEffect,
			// Token: 0x04035206 RID: 217606
			AnimItem
		}
	}
}
