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
	// Token: 0x020051E9 RID: 20969
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardEffectCountComponent : CardComponentBase<ICardEffectCountComponentData>
	{
		// Token: 0x06035A4D RID: 219725 RVA: 0x00CB4DE0 File Offset: 0x00CB2FE0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06035A4E RID: 219726 RVA: 0x00CB4E3C File Offset: 0x00CB303C
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Layout = new GenericLayout<EffectCountItem, IEffectCountItemData>(base.GetLayoutBase(1), new Func<EffectCountItem>(this.InitEffectCountItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06035A4F RID: 219727 RVA: 0x00CB4E8B File Offset: 0x00CB308B
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
		}

		// Token: 0x06035A50 RID: 219728 RVA: 0x00CB4E98 File Offset: 0x00CB3098
		private EffectCountItem InitEffectCountItem()
		{
			return new EffectCountItem();
		}

		// Token: 0x06035A51 RID: 219729 RVA: 0x00CB4EA0 File Offset: 0x00CB30A0
		private void RefreshEffectCount()
		{
			base.GetText(0).SetText(this.Data.EffectCount.ToString() + "/" + this.Data.EffectCountMax.ToString(), true);
		}

		// Token: 0x06035A52 RID: 219730 RVA: 0x00CB4EEC File Offset: 0x00CB30EC
		private UniTask ShowFullEffect()
		{
			CardEffectCountComponent.<ShowFullEffect>d__8 <ShowFullEffect>d__;
			<ShowFullEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowFullEffect>d__.<>4__this = this;
			<ShowFullEffect>d__.<>1__state = -1;
			<ShowFullEffect>d__.<>t__builder.Start<CardEffectCountComponent.<ShowFullEffect>d__8>(ref <ShowFullEffect>d__);
			return <ShowFullEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035A53 RID: 219731 RVA: 0x00CB4F30 File Offset: 0x00CB3130
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

		// Token: 0x06035A54 RID: 219732 RVA: 0x00CB4F84 File Offset: 0x00CB3184
		private UniTask ShowResetEffect()
		{
			CardEffectCountComponent.<ShowResetEffect>d__10 <ShowResetEffect>d__;
			<ShowResetEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowResetEffect>d__.<>4__this = this;
			<ShowResetEffect>d__.<>1__state = -1;
			<ShowResetEffect>d__.<>t__builder.Start<CardEffectCountComponent.<ShowResetEffect>d__10>(ref <ShowResetEffect>d__);
			return <ShowResetEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035A55 RID: 219733 RVA: 0x00CB4FC8 File Offset: 0x00CB31C8
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

		// Token: 0x06035A56 RID: 219734 RVA: 0x00CB5020 File Offset: 0x00CB3220
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

		// Token: 0x06035A57 RID: 219735 RVA: 0x00CB5074 File Offset: 0x00CB3274
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

		// Token: 0x0401C76E RID: 116590
		protected ICardEffectCountComponentData Data;

		// Token: 0x0401C76F RID: 116591
		protected GenericLayout<EffectCountItem, IEffectCountItemData> Layout;

		// Token: 0x0401C770 RID: 116592
		protected UiSequencePlayer Sequence;

		// Token: 0x0200B369 RID: 45929
		[NullableContext(0)]
		private static class EComponentDefine
		{
			// Token: 0x04036602 RID: 222722
			public const int EffectText = 0;

			// Token: 0x04036603 RID: 222723
			public const int EffectCountLayout = 1;

			// Token: 0x04036604 RID: 222724
			public const int EffectCountItem = 2;
		}
	}
}
