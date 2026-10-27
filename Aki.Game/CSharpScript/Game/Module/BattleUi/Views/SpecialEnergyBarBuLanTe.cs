using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DCD RID: 24013
	public class SpecialEnergyBarBuLanTe : SpecialEnergyBarBase
	{
		// Token: 0x0603D070 RID: 249968 RVA: 0x00EAD068 File Offset: 0x00EAB268
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D071 RID: 249969 RVA: 0x00EAD220 File Offset: 0x00EAB420
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarBuLanTe.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarBuLanTe.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D072 RID: 249970 RVA: 0x00EAD264 File Offset: 0x00EAB464
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarBuLanTe.<InitBarItem>d__10 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarBuLanTe.<InitBarItem>d__10>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D073 RID: 249971 RVA: 0x00EAD2A8 File Offset: 0x00EAB4A8
		private UniTask InitStarItems(int index)
		{
			SpecialEnergyBarBuLanTe.<InitStarItems>d__11 <InitStarItems>d__;
			<InitStarItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitStarItems>d__.<>4__this = this;
			<InitStarItems>d__.index = index;
			<InitStarItems>d__.<>1__state = -1;
			<InitStarItems>d__.<>t__builder.Start<SpecialEnergyBarBuLanTe.<InitStarItems>d__11>(ref <InitStarItems>d__);
			return <InitStarItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603D074 RID: 249972 RVA: 0x00EAD2F4 File Offset: 0x00EAB4F4
		protected override void OnStart()
		{
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.PlayTweenAnim(11);
			this.IconHandle.Init(new UUITexture[]
			{
				base.GetTexture(2)
			}, null);
			this.RefreshFullEffect(true);
			this.RefreshBottomBar(true);
			this.RefreshStarEffectItem(true);
		}

		// Token: 0x0603D075 RID: 249973 RVA: 0x00EAD367 File Offset: 0x00EAB567
		protected override void OnBarPercentChanged()
		{
			this.RefreshFullEffect(false);
			this.RefreshBottomBar(false);
			this.RefreshStarEffectItem(false);
		}

		// Token: 0x0603D076 RID: 249974 RVA: 0x00EAD380 File Offset: 0x00EAB580
		private void RefreshFullEffect(bool isStart = false)
		{
			bool flag = this.PercentMachine.GetCurPercent() >= this.Config.DisableKeyOnPercent;
			if (this.IsFull == flag && !isStart)
			{
				return;
			}
			this.IsFull = flag;
			if (this.IsFull)
			{
				base.StopTweenAnim(7);
				base.PlayTweenAnim(6);
				return;
			}
			if (!isStart)
			{
				base.StopTweenAnim(6);
				base.PlayTweenAnim(7);
				return;
			}
			base.StopTweenAnim(6);
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			UUITexture texture2 = base.GetTexture(2);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetAlpha(1f);
		}

		// Token: 0x0603D077 RID: 249975 RVA: 0x00EAD418 File Offset: 0x00EAB618
		private void RefreshBottomBar(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetFillAmount(curPercent);
			}
			bool flag = curPercent <= 0f;
			if (this.IsEmpty == flag && !isStart)
			{
				return;
			}
			this.IsEmpty = flag;
			SpecialEnergyBaIconHandle iconHandle = this.IconHandle;
			string icon;
			if (!flag)
			{
				SpecialEnergyBarInfo config = this.Config;
				icon = ((config != null) ? config.EnableIconPath : null);
			}
			else
			{
				SpecialEnergyBarInfo config2 = this.Config;
				icon = ((config2 != null) ? config2.IconPath : null);
			}
			iconHandle.SetIcon(icon);
			foreach (SpecialEnergyBarBuLanTeStarItem specialEnergyBarBuLanTeStarItem in this.StarItemList)
			{
				specialEnergyBarBuLanTeStarItem.SetIsEmpty(flag);
			}
		}

		// Token: 0x0603D078 RID: 249976 RVA: 0x00EAD4DC File Offset: 0x00EAB6DC
		private void RefreshStarEffectItem(bool isStart = false)
		{
			int num = Math.Min((int)MathF.Floor(this.PercentMachine.GetCurPercent() * 4f), 3);
			for (int i = this.StarCount; i < num; i++)
			{
				base.PlayTweenAnim(8 + i);
			}
			for (int j = num; j < 3; j++)
			{
				this.StarItemList[j].SetStarEnable(false);
			}
			this.StarCount = num;
		}

		// Token: 0x0603D079 RID: 249977 RVA: 0x00EAD546 File Offset: 0x00EAB746
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

		// Token: 0x0603D07A RID: 249978 RVA: 0x00EAD560 File Offset: 0x00EAB760
		protected override void OnBeforeDestroy()
		{
			this.IconHandle.OnBeforeDestroy();
			base.OnBeforeDestroy();
		}

		// Token: 0x0401FCB7 RID: 130231
		private const int NUM = 3;

		// Token: 0x0401FCB8 RID: 130232
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401FCB9 RID: 130233
		[Nullable(1)]
		private readonly SpecialEnergyBaIconHandle IconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401FCBA RID: 130234
		[Nullable(1)]
		private readonly List<SpecialEnergyBarBuLanTeStarItem> StarItemList = new List<SpecialEnergyBarBuLanTeStarItem>();

		// Token: 0x0401FCBB RID: 130235
		private bool IsEmpty;

		// Token: 0x0401FCBC RID: 130236
		private bool IsFull;

		// Token: 0x0401FCBD RID: 130237
		private int StarCount;

		// Token: 0x0200C0DD RID: 49373
		private enum EChildType
		{
			// Token: 0x0403A321 RID: 238369
			SlotBarItem,
			// Token: 0x0403A322 RID: 238370
			BarSprite,
			// Token: 0x0403A323 RID: 238371
			BarBgTexture,
			// Token: 0x0403A324 RID: 238372
			StarItem1,
			// Token: 0x0403A325 RID: 238373
			StarItem2,
			// Token: 0x0403A326 RID: 238374
			StarItem3,
			// Token: 0x0403A327 RID: 238375
			AniFull,
			// Token: 0x0403A328 RID: 238376
			AniUse,
			// Token: 0x0403A329 RID: 238377
			AniStar1,
			// Token: 0x0403A32A RID: 238378
			AniStar2,
			// Token: 0x0403A32B RID: 238379
			AniStar3,
			// Token: 0x0403A32C RID: 238380
			AniDefault
		}
	}
}
