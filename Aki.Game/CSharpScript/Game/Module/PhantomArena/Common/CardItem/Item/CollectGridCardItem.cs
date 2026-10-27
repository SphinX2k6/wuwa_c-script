using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D3 RID: 20947
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectGridCardItem : GridProxyAbstract<CollectGridCardData>
	{
		// Token: 0x060359D4 RID: 219604 RVA: 0x00CB3DB2 File Offset: 0x00CB1FB2
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x060359D5 RID: 219605 RVA: 0x00CB3DEC File Offset: 0x00CB1FEC
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

		// Token: 0x060359D6 RID: 219606 RVA: 0x00CB3E7E File Offset: 0x00CB207E
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060359D7 RID: 219607 RVA: 0x00CB3E80 File Offset: 0x00CB2080
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060359D8 RID: 219608 RVA: 0x00CB3E82 File Offset: 0x00CB2082
		public override object GetKey(CollectGridCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x0401C74A RID: 116554
		protected CollectGridCardData Data;

		// Token: 0x0401C74B RID: 116555
		private CollectCardItem CardItem;

		// Token: 0x0401C74C RID: 116556
		public Action<int> CallbackOnClick;

		// Token: 0x0200B363 RID: 45923
		[NullableContext(0)]
		private static class EGirdComponent
		{
			// Token: 0x040365F1 RID: 222705
			public const int PanelBg = 0;

			// Token: 0x040365F2 RID: 222706
			public const int ItemCard = 1;
		}
	}
}
