using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x020051C8 RID: 20936
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CardItemBase<[Nullable(2)] TItemData> : UiPanelBase
	{
		// Token: 0x0603599C RID: 219548 RVA: 0x00CB3288 File Offset: 0x00CB1488
		private void RegisterCardComponent()
		{
			this.OnRegisterCardComponent();
		}

		// Token: 0x0603599D RID: 219549 RVA: 0x00CB3290 File Offset: 0x00CB1490
		protected virtual void OnRegisterCardComponent()
		{
		}

		// Token: 0x0603599E RID: 219550 RVA: 0x00CB3294 File Offset: 0x00CB1494
		protected override UniTask OnBeforeStartAsync()
		{
			CardItemBase<TItemData>.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CardItemBase<TItemData>.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603599F RID: 219551 RVA: 0x00CB32D8 File Offset: 0x00CB14D8
		[NullableContext(2)]
		private ICardComponentBase AddComponent(ECardItemComponent key)
		{
			ICardComponentBase cardComponentBase = this.GetComponent<ICardComponentBase>(key);
			if (cardComponentBase != null)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "重复添加组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return cardComponentBase;
			}
			if (CardItemDefine.cardItemCreatorMap.ContainsKey(key))
			{
				cardComponentBase = CardItemDefine.cardItemCreatorMap[key]();
				this.ComponentsMap[key] = cardComponentBase;
			}
			return cardComponentBase;
		}

		// Token: 0x060359A0 RID: 219552 RVA: 0x00CB3340 File Offset: 0x00CB1540
		[return: Nullable(2)]
		public T GetComponent<T>(ECardItemComponent key) where T : class, ICardComponentBase
		{
			ICardComponentBase cardComponentBase;
			if (!this.ComponentsMap.TryGetValue(key, out cardComponentBase))
			{
				return default(T);
			}
			return cardComponentBase as T;
		}

		// Token: 0x060359A1 RID: 219553
		public abstract void Refresh(TItemData data);

		// Token: 0x060359A2 RID: 219554 RVA: 0x00CB3372 File Offset: 0x00CB1572
		protected virtual UniTask OnBeforeChildStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0401C72B RID: 116523
		protected List<TCardComponentsRegisterInfoByItem> ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>();

		// Token: 0x0401C72C RID: 116524
		protected List<TCardComponentsRegisterInfoByResourceId> ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>();

		// Token: 0x0401C72D RID: 116525
		private readonly Dictionary<ECardItemComponent, ICardComponentBase> ComponentsMap = new Dictionary<ECardItemComponent, ICardComponentBase>();
	}
}
