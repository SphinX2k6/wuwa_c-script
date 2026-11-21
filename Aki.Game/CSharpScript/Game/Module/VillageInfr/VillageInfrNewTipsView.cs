using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003800 RID: 14336
	public class VillageInfrNewTipsView : UiTickViewBase
	{
		// Token: 0x0602544B RID: 152651 RVA: 0x00A82F7E File Offset: 0x00A8117E
		[NullableContext(1)]
		public VillageInfrNewTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602544C RID: 152652 RVA: 0x00A82F88 File Offset: 0x00A81188
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x0602544D RID: 152653 RVA: 0x00A82FF8 File Offset: 0x00A811F8
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrNewTipsView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrNewTipsView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602544E RID: 152654 RVA: 0x00A8303C File Offset: 0x00A8123C
		protected override void OnStart()
		{
			int configId = (int)this.OpenParam;
			InfrV2TreeBuild? infrTreeBuild = VillageInfrConfig.Instance.GetInfrTreeBuild(configId);
			int num = 0;
			using (Dictionary<int, int>.KeyCollection.Enumerator enumerator = infrTreeBuild.Value.Requirement().Keys.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					num = enumerator.Current;
				}
			}
			if (num == 0)
			{
				Log.Instance.Error(ELogModule.Item, ELogAuthor.ZJC, "新物品提示错误, 没有物品id!", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.CloseMe(null);
				return;
			}
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
			if (itemConfigData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.ZJC;
				string message = "新物品提示错误, 没有物品配置!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.CloseMe(null);
				return;
			}
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = num,
				ItemConfigId = new int?(num)
			};
			this.IconItem.Apply<PropSmallItemGrid>(parameters);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "VillageInfr_Tips_Itemsatisfies", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(itemConfigData.Name, Array.Empty<object>())));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "VillageInfr_Tips_Deliverytips", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(infrTreeBuild.Value.Name, Array.Empty<object>())));
		}

		// Token: 0x0602544F RID: 152655 RVA: 0x00A831AC File Offset: 0x00A813AC
		protected override void OnBeforeDestroy()
		{
			ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x06025450 RID: 152656 RVA: 0x00A831C2 File Offset: 0x00A813C2
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x04014A18 RID: 84504
		[Nullable(2)]
		private SmallItemGrid IconItem;
	}
}
