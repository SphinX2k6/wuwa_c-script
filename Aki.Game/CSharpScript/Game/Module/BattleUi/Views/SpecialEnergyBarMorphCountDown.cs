using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E1F RID: 24095
	public class SpecialEnergyBarMorphCountDown : SpecialEnergyBarBase
	{
		// Token: 0x0603D484 RID: 251012 RVA: 0x00EC4D1C File Offset: 0x00EC2F1C
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

		// Token: 0x0603D485 RID: 251013 RVA: 0x00EC4DE8 File Offset: 0x00EC2FE8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMorphCountDown.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMorphCountDown.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D486 RID: 251014 RVA: 0x00EC4E2C File Offset: 0x00EC302C
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

		// Token: 0x0603D487 RID: 251015 RVA: 0x00EC4E78 File Offset: 0x00EC3078
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

		// Token: 0x0603D488 RID: 251016 RVA: 0x00EC4EC4 File Offset: 0x00EC30C4
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

		// Token: 0x0603D489 RID: 251017 RVA: 0x00EC5005 File Offset: 0x00EC3205
		protected virtual ValueTuple<float, float> GetEffectBasePercents(float effectBasePercent)
		{
			return new ValueTuple<float, float>(effectBasePercent, effectBasePercent);
		}

		// Token: 0x0603D48A RID: 251018 RVA: 0x00EC500E File Offset: 0x00EC320E
		protected virtual ValueTuple<int, int> GetEffectPointNums(int pointNum)
		{
			return new ValueTuple<int, int>(pointNum, pointNum);
		}

		// Token: 0x0603D48B RID: 251019 RVA: 0x00EC5017 File Offset: 0x00EC3217
		protected virtual int GetUseEffectPointOffsetNum(int pointNum)
		{
			return 0;
		}

		// Token: 0x0603D48C RID: 251020 RVA: 0x00EC501A File Offset: 0x00EC321A
		public override void OnChangeVisibleByTagChange(bool visible)
		{
			if (visible)
			{
				base.GetUiNiagara(3).SetUIActive(true);
				this.StartEffectFinishTime = 500.0 + Time.Instance.Now;
			}
		}

		// Token: 0x0603D48D RID: 251021 RVA: 0x00EC5046 File Offset: 0x00EC3246
		protected override void OnBeforeShow()
		{
			if ((byte)this.Config.PrefabType == 9)
			{
				base.GetUiNiagara(3).SetUIActive(true);
				this.StartEffectFinishTime = 500.0 + Time.Instance.Now;
			}
		}

		// Token: 0x0603D48E RID: 251022 RVA: 0x00EC5080 File Offset: 0x00EC3280
		protected void RefreshBarPercent()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			int useEffectPointOffsetNum = this.GetUseEffectPointOffsetNum(this.PointNum);
			this.PointLeftItem.UpdatePercent(curPercent, true, useEffectPointOffsetNum);
			this.PointRightItem.UpdatePercent(curPercent, true, useEffectPointOffsetNum);
			bool isPlay = this.Config.ExtraFloatParams.Count > 0 && curPercent < this.Config.ExtraFloatParams[0];
			this.IconHandle.PlayEndAnim(isPlay);
		}

		// Token: 0x0603D48F RID: 251023 RVA: 0x00EC50F9 File Offset: 0x00EC32F9
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent();
		}

		// Token: 0x0603D490 RID: 251024 RVA: 0x00EC5104 File Offset: 0x00EC3304
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

		// Token: 0x0603D491 RID: 251025 RVA: 0x00EC517B File Offset: 0x00EC337B
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.IconHandle.OnBeforeDestroy();
		}

		// Token: 0x0401FF4F RID: 130895
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly int[] PointNumList = new int[]
		{
			19,
			20
		};

		// Token: 0x0401FF50 RID: 130896
		private const int TOTAL_NUM = 41;

		// Token: 0x0401FF51 RID: 130897
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401FF52 RID: 130898
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401FF53 RID: 130899
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointLeftItem;

		// Token: 0x0401FF54 RID: 130900
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointRightItem;

		// Token: 0x0401FF55 RID: 130901
		[Nullable(1)]
		private readonly SpecialEnergyBaIconHandle IconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401FF56 RID: 130902
		private double StartEffectFinishTime;

		// Token: 0x0401FF57 RID: 130903
		private int PointNum;

		// Token: 0x0200C19B RID: 49563
		private enum EChildType
		{
			// Token: 0x0403A810 RID: 239632
			PointLeftItem,
			// Token: 0x0403A811 RID: 239633
			PointRightItem,
			// Token: 0x0403A812 RID: 239634
			IconTexture,
			// Token: 0x0403A813 RID: 239635
			StartEffect,
			// Token: 0x0403A814 RID: 239636
			AnimItem
		}
	}
}
