using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x02004198 RID: 16792
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CardItemBase<[Nullable(2)] TItemData> : UiPanelBase
	{
		// Token: 0x0602A897 RID: 174231 RVA: 0x00C008C4 File Offset: 0x00BFEAC4
		private void RegisterCardComponent()
		{
			this.OnRegisterCardComponent();
		}

		// Token: 0x0602A898 RID: 174232 RVA: 0x00C008CC File Offset: 0x00BFEACC
		protected virtual void OnRegisterCardComponent()
		{
		}

		// Token: 0x0602A899 RID: 174233 RVA: 0x00C008D0 File Offset: 0x00BFEAD0
		protected override UniTask OnBeforeStartAsync()
		{
			CardItemBase<TItemData>.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CardItemBase<TItemData>.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A89A RID: 174234 RVA: 0x00C00914 File Offset: 0x00BFEB14
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

		// Token: 0x0602A89B RID: 174235 RVA: 0x00C0097C File Offset: 0x00BFEB7C
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

		// Token: 0x0602A89C RID: 174236
		public abstract void Refresh(TItemData data);

		// Token: 0x0602A89D RID: 174237 RVA: 0x00C009AE File Offset: 0x00BFEBAE
		protected virtual UniTask OnBeforeChildStartAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x04017160 RID: 94560
		protected List<TCardComponentsRegisterInfoByItem> ComponentsRegisterInfoByItem = new List<TCardComponentsRegisterInfoByItem>();

		// Token: 0x04017161 RID: 94561
		protected List<TCardComponentsRegisterInfoByResourceId> ComponentsRegisterInfoByResourceId = new List<TCardComponentsRegisterInfoByResourceId>();

		// Token: 0x04017162 RID: 94562
		private readonly Dictionary<ECardItemComponent, ICardComponentBase> ComponentsMap = new Dictionary<ECardItemComponent, ICardComponentBase>();
	}
}
