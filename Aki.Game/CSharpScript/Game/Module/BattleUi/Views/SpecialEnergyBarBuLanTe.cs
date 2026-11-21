using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB1 RID: 19889
	public class SpecialEnergyBarBuLanTe : SpecialEnergyBarBase
	{
		// Token: 0x06031FE7 RID: 204775 RVA: 0x00DFDF5C File Offset: 0x00DFC15C
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

		// Token: 0x06031FE8 RID: 204776 RVA: 0x00DFE114 File Offset: 0x00DFC314
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarBuLanTe.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarBuLanTe.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031FE9 RID: 204777 RVA: 0x00DFE158 File Offset: 0x00DFC358
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarBuLanTe.<InitBarItem>d__10 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarBuLanTe.<InitBarItem>d__10>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031FEA RID: 204778 RVA: 0x00DFE19C File Offset: 0x00DFC39C
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

		// Token: 0x06031FEB RID: 204779 RVA: 0x00DFE1E8 File Offset: 0x00DFC3E8
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

		// Token: 0x06031FEC RID: 204780 RVA: 0x00DFE25B File Offset: 0x00DFC45B
		protected override void OnBarPercentChanged()
		{
			this.RefreshFullEffect(false);
			this.RefreshBottomBar(false);
			this.RefreshStarEffectItem(false);
		}

		// Token: 0x06031FED RID: 204781 RVA: 0x00DFE274 File Offset: 0x00DFC474
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

		// Token: 0x06031FEE RID: 204782 RVA: 0x00DFE30C File Offset: 0x00DFC50C
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

		// Token: 0x06031FEF RID: 204783 RVA: 0x00DFE3D0 File Offset: 0x00DFC5D0
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

		// Token: 0x06031FF0 RID: 204784 RVA: 0x00DFE43A File Offset: 0x00DFC63A
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

		// Token: 0x06031FF1 RID: 204785 RVA: 0x00DFE454 File Offset: 0x00DFC654
		protected override void OnBeforeDestroy()
		{
			this.IconHandle.OnBeforeDestroy();
			base.OnBeforeDestroy();
		}

		// Token: 0x0401A774 RID: 108404
		private const int NUM = 3;

		// Token: 0x0401A775 RID: 108405
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401A776 RID: 108406
		[Nullable(1)]
		private readonly SpecialEnergyBaIconHandle IconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401A777 RID: 108407
		[Nullable(1)]
		private readonly List<SpecialEnergyBarBuLanTeStarItem> StarItemList = new List<SpecialEnergyBarBuLanTeStarItem>();

		// Token: 0x0401A778 RID: 108408
		private bool IsEmpty;

		// Token: 0x0401A779 RID: 108409
		private bool IsFull;

		// Token: 0x0401A77A RID: 108410
		private int StarCount;

		// Token: 0x0200AAE6 RID: 43750
		private enum EChildType
		{
			// Token: 0x04034CF3 RID: 216307
			SlotBarItem,
			// Token: 0x04034CF4 RID: 216308
			BarSprite,
			// Token: 0x04034CF5 RID: 216309
			BarBgTexture,
			// Token: 0x04034CF6 RID: 216310
			StarItem1,
			// Token: 0x04034CF7 RID: 216311
			StarItem2,
			// Token: 0x04034CF8 RID: 216312
			StarItem3,
			// Token: 0x04034CF9 RID: 216313
			AniFull,
			// Token: 0x04034CFA RID: 216314
			AniUse,
			// Token: 0x04034CFB RID: 216315
			AniStar1,
			// Token: 0x04034CFC RID: 216316
			AniStar2,
			// Token: 0x04034CFD RID: 216317
			AniStar3,
			// Token: 0x04034CFE RID: 216318
			AniDefault
		}
	}
}
