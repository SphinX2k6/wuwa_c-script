using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DCC RID: 19916
	internal class SpecialEnergyBarKeLaiTaUltra : SpecialEnergyBarBase
	{
		// Token: 0x06032138 RID: 205112 RVA: 0x00E06C64 File Offset: 0x00E04E64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032139 RID: 205113 RVA: 0x00E06EE8 File Offset: 0x00E050E8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKeLaiTaUltra.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKeLaiTaUltra.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603213A RID: 205114 RVA: 0x00E06F2C File Offset: 0x00E0512C
		protected override void OnStart()
		{
			for (int i = 0; i < 4; i++)
			{
				this.TexBgItemList.Add(base.GetItem(1 + i));
				this.TexItemList.Add(base.GetItem(5 + i));
				base.InitTweenAnim(11 + i);
			}
			base.InitTweenAnim(15);
			this.RefreshNum(-1, true);
		}

		// Token: 0x0603213B RID: 205115 RVA: 0x00E06F87 File Offset: 0x00E05187
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(SpecialEnergyBarKeLaiTaUltra.NumTagId, new BaseTagComponent.TTagChangedCallback(this.OnNumTagCountChange));
		}

		// Token: 0x0603213C RID: 205116 RVA: 0x00E06FA6 File Offset: 0x00E051A6
		protected override void OnBeforeDestroy()
		{
			this.SetPlayEndAnim(false);
			base.OnBeforeDestroy();
		}

		// Token: 0x0603213D RID: 205117 RVA: 0x00E06FB5 File Offset: 0x00E051B5
		private void OnNumTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshNum(count, false);
		}

		// Token: 0x0603213E RID: 205118 RVA: 0x00E06FC0 File Offset: 0x00E051C0
		private void RefreshNum(int num = -1, bool isStart = false)
		{
			int num2 = num;
			if (num2 < 0)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				num2 = ((tagComponent != null) ? tagComponent.GetTagCount(SpecialEnergyBarKeLaiTaUltra.NumTagId) : 0);
			}
			num2 = 4 - num2;
			if (num2 != this.CurNum || isStart)
			{
				bool enable = num2 >= 4;
				if (isStart)
				{
					for (int i = 0; i < 4; i++)
					{
						bool flag = i < num2;
						this.TexBgItemList[i].SetUIActive(!flag);
						this.TexItemList[i].SetUIActive(flag);
					}
				}
				else if (num2 < this.CurNum)
				{
					for (int j = 0; j < 4; j++)
					{
						base.StopTweenAnim(11 + j);
					}
					for (int k = 0; k < 4; k++)
					{
						bool flag2 = k < num2;
						this.TexBgItemList[k].SetUIActive(!flag2);
						this.TexItemList[k].SetUIActive(flag2);
					}
				}
				else
				{
					for (int l = this.CurNum; l < num2; l++)
					{
						this.TexItemList[l].SetUIActive(true);
						base.PlayTweenAnim(11 + l);
					}
				}
				this.CurNum = num2;
				SpecialEnergyBarKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.RefreshKeyEnable(enable, isStart);
			}
		}

		// Token: 0x0603213F RID: 205119 RVA: 0x00E070FE File Offset: 0x00E052FE
		protected override bool GetKeyEnable()
		{
			return this.CurNum >= 4;
		}

		// Token: 0x06032140 RID: 205120 RVA: 0x00E0710C File Offset: 0x00E0530C
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_2F;
				}
			}
			this.RefreshBuff();
			IL_2F:
			if (this.Buff != null)
			{
				this.SetPlayEndAnim(this.Buff.GetRemainDuration() < this.Config.ExtraFloatParams[0]);
			}
		}

		// Token: 0x06032141 RID: 205121 RVA: 0x00E07174 File Offset: 0x00E05374
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

		// Token: 0x06032142 RID: 205122 RVA: 0x00E071E1 File Offset: 0x00E053E1
		private void SetPlayEndAnim(bool isPlay)
		{
			if (isPlay != this.IsPlayEndAnim)
			{
				this.IsPlayEndAnim = isPlay;
				if (isPlay)
				{
					base.PlayTweenAnim(15);
					return;
				}
				base.StopTweenAnim(15);
				UUIItem item = base.GetItem(16);
				if (item == null)
				{
					return;
				}
				item.SetAlpha(1f);
			}
		}

		// Token: 0x0401A85A RID: 108634
		private const int NUM = 4;

		// Token: 0x0401A85B RID: 108635
		[StaticVariableRuleIgnore]
		private static readonly int NumTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1KamolaMd10011.被动.大招普攻记层"];

		// Token: 0x0401A85C RID: 108636
		private int CurNum;

		// Token: 0x0401A85D RID: 108637
		[Nullable(1)]
		private readonly List<UUIItem> TexBgItemList = new List<UUIItem>();

		// Token: 0x0401A85E RID: 108638
		[Nullable(1)]
		private readonly List<UUIItem> TexItemList = new List<UUIItem>();

		// Token: 0x0401A85F RID: 108639
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401A860 RID: 108640
		private int BuffHandle;

		// Token: 0x0401A861 RID: 108641
		private bool IsPlayEndAnim;

		// Token: 0x0200AB1D RID: 43805
		private enum EChildType
		{
			// Token: 0x04034E91 RID: 216721
			KeyContainerItem,
			// Token: 0x04034E92 RID: 216722
			TexBgItem1,
			// Token: 0x04034E93 RID: 216723
			TexBgItem2,
			// Token: 0x04034E94 RID: 216724
			TexBgItem3,
			// Token: 0x04034E95 RID: 216725
			TexBgItem4,
			// Token: 0x04034E96 RID: 216726
			TexItem1,
			// Token: 0x04034E97 RID: 216727
			TexItem2,
			// Token: 0x04034E98 RID: 216728
			TexItem3,
			// Token: 0x04034E99 RID: 216729
			TexItem4,
			// Token: 0x04034E9A RID: 216730
			LightItem1,
			// Token: 0x04034E9B RID: 216731
			LightItem2,
			// Token: 0x04034E9C RID: 216732
			AniCharge1,
			// Token: 0x04034E9D RID: 216733
			AniCharge2,
			// Token: 0x04034E9E RID: 216734
			AniCharge3,
			// Token: 0x04034E9F RID: 216735
			AniCharge4,
			// Token: 0x04034EA0 RID: 216736
			AniEnd,
			// Token: 0x04034EA1 RID: 216737
			BarItem,
			// Token: 0x04034EA2 RID: 216738
			AnimReset
		}
	}
}
