using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DE8 RID: 24040
	internal class SpecialEnergyBarKeLaiTaUltra : SpecialEnergyBarBase
	{
		// Token: 0x0603D1C1 RID: 250305 RVA: 0x00EB5D4C File Offset: 0x00EB3F4C
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

		// Token: 0x0603D1C2 RID: 250306 RVA: 0x00EB5FD0 File Offset: 0x00EB41D0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarKeLaiTaUltra.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarKeLaiTaUltra.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D1C3 RID: 250307 RVA: 0x00EB6014 File Offset: 0x00EB4214
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

		// Token: 0x0603D1C4 RID: 250308 RVA: 0x00EB606F File Offset: 0x00EB426F
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(SpecialEnergyBarKeLaiTaUltra.NumTagId, new BaseTagComponent.TTagChangedCallback(this.OnNumTagCountChange));
		}

		// Token: 0x0603D1C5 RID: 250309 RVA: 0x00EB608E File Offset: 0x00EB428E
		protected override void OnBeforeDestroy()
		{
			this.SetPlayEndAnim(false);
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D1C6 RID: 250310 RVA: 0x00EB609D File Offset: 0x00EB429D
		private void OnNumTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshNum(count, false);
		}

		// Token: 0x0603D1C7 RID: 250311 RVA: 0x00EB60A8 File Offset: 0x00EB42A8
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
					base.PlayTweenAnim(17);
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

		// Token: 0x0603D1C8 RID: 250312 RVA: 0x00EB61DB File Offset: 0x00EB43DB
		protected override bool GetKeyEnable()
		{
			return this.CurNum >= 4;
		}

		// Token: 0x0603D1C9 RID: 250313 RVA: 0x00EB61EC File Offset: 0x00EB43EC
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

		// Token: 0x0603D1CA RID: 250314 RVA: 0x00EB6254 File Offset: 0x00EB4454
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

		// Token: 0x0603D1CB RID: 250315 RVA: 0x00EB62C1 File Offset: 0x00EB44C1
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

		// Token: 0x0401FD9D RID: 130461
		private const int NUM = 4;

		// Token: 0x0401FD9E RID: 130462
		[StaticVariableRuleIgnore]
		private static readonly int NumTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1KamolaMd10011.被动.大招普攻记层"];

		// Token: 0x0401FD9F RID: 130463
		private int CurNum;

		// Token: 0x0401FDA0 RID: 130464
		[Nullable(1)]
		private readonly List<UUIItem> TexBgItemList = new List<UUIItem>();

		// Token: 0x0401FDA1 RID: 130465
		[Nullable(1)]
		private readonly List<UUIItem> TexItemList = new List<UUIItem>();

		// Token: 0x0401FDA2 RID: 130466
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401FDA3 RID: 130467
		private int BuffHandle;

		// Token: 0x0401FDA4 RID: 130468
		private bool IsPlayEndAnim;

		// Token: 0x0200C114 RID: 49428
		private enum EChildType
		{
			// Token: 0x0403A4BF RID: 238783
			KeyContainerItem,
			// Token: 0x0403A4C0 RID: 238784
			TexBgItem1,
			// Token: 0x0403A4C1 RID: 238785
			TexBgItem2,
			// Token: 0x0403A4C2 RID: 238786
			TexBgItem3,
			// Token: 0x0403A4C3 RID: 238787
			TexBgItem4,
			// Token: 0x0403A4C4 RID: 238788
			TexItem1,
			// Token: 0x0403A4C5 RID: 238789
			TexItem2,
			// Token: 0x0403A4C6 RID: 238790
			TexItem3,
			// Token: 0x0403A4C7 RID: 238791
			TexItem4,
			// Token: 0x0403A4C8 RID: 238792
			LightItem1,
			// Token: 0x0403A4C9 RID: 238793
			LightItem2,
			// Token: 0x0403A4CA RID: 238794
			AniCharge1,
			// Token: 0x0403A4CB RID: 238795
			AniCharge2,
			// Token: 0x0403A4CC RID: 238796
			AniCharge3,
			// Token: 0x0403A4CD RID: 238797
			AniCharge4,
			// Token: 0x0403A4CE RID: 238798
			AniEnd,
			// Token: 0x0403A4CF RID: 238799
			BarItem,
			// Token: 0x0403A4D0 RID: 238800
			AnimReset
		}
	}
}
