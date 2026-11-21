using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A3 RID: 16803
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectGridCardItem : GridProxyAbstract<CollectGridCardData>
	{
		// Token: 0x0602A8CF RID: 174287 RVA: 0x00C013EE File Offset: 0x00BFF5EE
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x0602A8D0 RID: 174288 RVA: 0x00C01428 File Offset: 0x00BFF628
		public override void Refresh(CollectGridCardData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (this.CardItem == null)
			{
				this.CardItem = new CollectCardItem();
				int activityId = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(data.CardId).ActivityId;
				this.CardItem.IsNewPhantomArenaActivity = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(activityId);
				this.CardItem.CallbackOnClick = this.CallbackOnClick;
				this.CardItem.CreateThenShowByActorAsync(base.GetItem(1).GetOwner(), data, false).Forget();
				return;
			}
			this.CardItem.Refresh(data);
		}

		// Token: 0x0602A8D1 RID: 174289 RVA: 0x00C014BA File Offset: 0x00BFF6BA
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602A8D2 RID: 174290 RVA: 0x00C014BC File Offset: 0x00BFF6BC
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0602A8D3 RID: 174291 RVA: 0x00C014BE File Offset: 0x00BFF6BE
		public override object GetKey(CollectGridCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x0401717F RID: 94591
		protected CollectGridCardData Data;

		// Token: 0x04017180 RID: 94592
		private CollectCardItem CardItem;

		// Token: 0x04017181 RID: 94593
		public Action<int> CallbackOnClick;

		// Token: 0x02009D9B RID: 40347
		[NullableContext(0)]
		private static class EGirdComponent
		{
			// Token: 0x04031044 RID: 200772
			public const int PanelBg = 0;

			// Token: 0x04031045 RID: 200773
			public const int ItemCard = 1;
		}
	}
}
