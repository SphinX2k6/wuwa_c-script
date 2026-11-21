using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component
{
	// Token: 0x020041B9 RID: 16825
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardEffectCountComponent : CardComponentBase<ICardEffectCountComponentData>
	{
		// Token: 0x0602A948 RID: 174408 RVA: 0x00C0241C File Offset: 0x00C0061C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602A949 RID: 174409 RVA: 0x00C02478 File Offset: 0x00C00678
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Layout = new GenericLayout<EffectCountItem, IEffectCountItemData>(base.GetLayoutBase(1), new Func<EffectCountItem>(this.InitEffectCountItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0602A94A RID: 174410 RVA: 0x00C024C7 File Offset: 0x00C006C7
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x0602A94B RID: 174411 RVA: 0x00C024D4 File Offset: 0x00C006D4
		private EffectCountItem InitEffectCountItem()
		{
			return new EffectCountItem();
		}

		// Token: 0x0602A94C RID: 174412 RVA: 0x00C024DC File Offset: 0x00C006DC
		private void RefreshEffectCount()
		{
			base.GetText(0).SetText(this.Data.EffectCount.ToString() + "/" + this.Data.EffectCountMax.ToString(), true);
		}

		// Token: 0x0602A94D RID: 174413 RVA: 0x00C02528 File Offset: 0x00C00728
		private UniTask ShowFullEffect()
		{
			CardEffectCountComponent.<ShowFullEffect>d__8 <ShowFullEffect>d__;
			<ShowFullEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowFullEffect>d__.<>4__this = this;
			<ShowFullEffect>d__.<>1__state = -1;
			<ShowFullEffect>d__.<>t__builder.Start<CardEffectCountComponent.<ShowFullEffect>d__8>(ref <ShowFullEffect>d__);
			return <ShowFullEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602A94E RID: 174414 RVA: 0x00C0256C File Offset: 0x00C0076C
		private UniTask ShowAddEffect(int lastEffectCount, int newEffectCount)
		{
			CardEffectCountComponent.<ShowAddEffect>d__9 <ShowAddEffect>d__;
			<ShowAddEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowAddEffect>d__.<>4__this = this;
			<ShowAddEffect>d__.lastEffectCount = lastEffectCount;
			<ShowAddEffect>d__.newEffectCount = newEffectCount;
			<ShowAddEffect>d__.<>1__state = -1;
			<ShowAddEffect>d__.<>t__builder.Start<CardEffectCountComponent.<ShowAddEffect>d__9>(ref <ShowAddEffect>d__);
			return <ShowAddEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602A94F RID: 174415 RVA: 0x00C025C0 File Offset: 0x00C007C0
		private UniTask ShowResetEffect()
		{
			CardEffectCountComponent.<ShowResetEffect>d__10 <ShowResetEffect>d__;
			<ShowResetEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowResetEffect>d__.<>4__this = this;
			<ShowResetEffect>d__.<>1__state = -1;
			<ShowResetEffect>d__.<>t__builder.Start<CardEffectCountComponent.<ShowResetEffect>d__10>(ref <ShowResetEffect>d__);
			return <ShowResetEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602A950 RID: 174416 RVA: 0x00C02604 File Offset: 0x00C00804
		private void RefreshEffectCountItemList()
		{
			List<IEffectCountItemData> list = new List<IEffectCountItemData>();
			for (int i = 0; i < this.Data.EffectCountMax; i++)
			{
				EffectCountItemData item = new EffectCountItemData
				{
					IsActive = (i < this.Data.EffectCount)
				};
				list.Add(item);
			}
			this.Layout.RefreshByData(list, null, false);
		}

		// Token: 0x0602A951 RID: 174417 RVA: 0x00C0265C File Offset: 0x00C0085C
		public override void Refresh(ICardEffectCountComponentData data)
		{
			if (!data.InFight)
			{
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			ICardEffectCountComponentData data2 = this.Data;
			bool flag = data2 != null && data2.InFight;
			if (data.InFight != flag)
			{
				this.Data = data;
				this.RefreshEffectCount();
				this.RefreshEffectCountItemList();
			}
		}

		// Token: 0x0602A952 RID: 174418 RVA: 0x00C026B0 File Offset: 0x00C008B0
		public UniTask RefreshEffect(ICardEffectCountComponentData data)
		{
			CardEffectCountComponent.<RefreshEffect>d__13 <RefreshEffect>d__;
			<RefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffect>d__.<>4__this = this;
			<RefreshEffect>d__.data = data;
			<RefreshEffect>d__.<>1__state = -1;
			<RefreshEffect>d__.<>t__builder.Start<CardEffectCountComponent.<RefreshEffect>d__13>(ref <RefreshEffect>d__);
			return <RefreshEffect>d__.<>t__builder.Task;
		}

		// Token: 0x040171A3 RID: 94627
		protected ICardEffectCountComponentData Data;

		// Token: 0x040171A4 RID: 94628
		protected GenericLayout<EffectCountItem, IEffectCountItemData> Layout;

		// Token: 0x040171A5 RID: 94629
		protected UiSequencePlayer Sequence;

		// Token: 0x02009DA1 RID: 40353
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04031055 RID: 200789
			public const int EffectText = 0;

			// Token: 0x04031056 RID: 200790
			public const int EffectCountLayout = 1;

			// Token: 0x04031057 RID: 200791
			public const int EffectCountItem = 2;
		}
	}
}
